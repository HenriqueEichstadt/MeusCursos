using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace _05.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaCorrente(1, 100);
            var conta2 = new ContaCorrente(4, 150);

            Console.WriteLine(conta1);
            Console.WriteLine(conta2);

            ITransferenciaBancaria transferencia = new TransferenciaBancaria_BD();
            transferencia.Efetuar(conta1, conta2, 30);

            Console.WriteLine(conta1);
            Console.WriteLine(conta2);

            try
            {
                transferencia.Efetuar(conta1, conta2, 250);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Aconteceu um problema na transferência.");
                Logger.LogErro(ex.ToString());
            }
            
            
            Console.ReadKey();
        }
    }

    class ContaCorrente
    {
        public int Id { get; }
        public decimal Saldo { get; private set; }

        public ContaCorrente(int id, decimal saldo)
        {
            if (id <= 0)
            {
                throw new ArgumentException(nameof(id));
            }

            Id = id;
            Saldo = saldo;
        }

        public void Debitar(decimal valor)
        {
            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }

            Saldo -= valor;
        }

        public void Creditar(decimal valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return $"Conta Nº: {Id:0000}, Saldo: {Saldo:C}";
        }
    }

    interface ITransferenciaBancaria
    {
        void Efetuar(ContaCorrente contaDebito, ContaCorrente contaCredito, decimal valor);
    }

    class TransferenciaBancaria : ITransferenciaBancaria
    {
        public void Efetuar(ContaCorrente contaDebito, ContaCorrente contaCredito, decimal valor)
        {
            if (contaDebito == null)
                throw new ArgumentNullException(nameof(contaDebito));
            
            if(contaCredito == null)
                throw new ArgumentNullException(nameof(contaCredito));
            
            if(valor <= 0)
                throw new ArgumentOutOfRangeException(nameof(valor));
            
            if(valor > contaDebito.Saldo)
            
            Logger.LogInfo("Entrando do método Efetuar.");

            contaDebito.Debitar(valor);
            contaCredito.Creditar(valor);
            Logger.LogInfo("Transferência realizada com sucesso.");
            Logger.LogInfo("Saindo do método Efetuar.");
        }
    }

    class TransferenciaBancaria_BD : ITransferenciaBancaria
    {
        private const string CONNECTION_STRING =
            @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB\ByteBank.mdf;Integrated Security=True";

        private const decimal TAXA_TRANSFERENCIA = 1.0m;
        private SqlConnection connection;
        private SqlTransaction transaction;

        public void Efetuar(ContaCorrente contaCredito, ContaCorrente contaDebito, decimal valor)
        {
            Logger.LogInfo("Entrando do método Efetuar.");

            connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            transaction = connection.BeginTransaction();

            // OBTÉM OS COMANDOS DO SQL SERVER
            SqlCommand comandoTransferencia = GetTransferenciaCommand
                (contaCredito.Id, contaDebito.Id, valor);
            SqlCommand comandoTaxa = GetTaxaTransferenciaCommand
                (contaCredito.Id, TAXA_TRANSFERENCIA);

            try
            {
                // EXECUTA OS COMANDOS NO SERVIDOR DOE BANCO DE DADOS
                comandoTaxa.ExecuteNonQuery();
                comandoTransferencia.ExecuteNonQuery();
                transaction.Commit(); // A TRANSFERÊNCIA OCORRE NESTA LINHA
                
                Logger.LogInfo("Transferência realizada com sucesso.");
            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                Logger.LogErro(ex.ToString());
                throw;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Logger.LogErro(ex.ToString());
                throw;
            }
            finally
            {
                // LIBERA OS RECURSOS
                comandoTransferencia.Dispose();
                comandoTaxa.Dispose();
                transaction.Dispose();
                connection.Dispose();
                Logger.LogInfo("Saindo do método Efetuar.");    
            }
        }

        private SqlCommand GetTransferenciaCommand(int contaDebitoId, int contaCreditoId, decimal valorTransferencia)
        {
            SqlCommand command = new SqlCommand("p_TRANSFERENCIA_BANCARIA_i", connection, transaction);
            command.Parameters.AddWithValue("@CONTA_ID_DEBITO", contaDebitoId);
            command.Parameters.AddWithValue("@CONTA_ID_CREDITO", contaCreditoId);
            command.Parameters.AddWithValue("@VALOR", valorTransferencia);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            return command;
        }

        private SqlCommand GetTaxaTransferenciaCommand(int contaId, decimal valorTransferencia)
        {
            SqlCommand command = new SqlCommand("p_TARIFA_TRANSFERENCIA_i", connection, transaction);
            command.Parameters.AddWithValue("@CONTA_ID", contaId);
            command.Parameters.AddWithValue("@VALOR", valorTransferencia);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            return command;
        }
    }

    class Logger
    {
        public static void LogInfo(string mensagem)
        {
            Log(mensagem, "INFO");
        }

        public static void LogErro(string mensagem)
        {
            Log(mensagem, "ERRO");
        }

        private static void Log(string mensagem, string tipo)
        {
            using (var sw = new StreamWriter("logs.txt", append: true))
            {
                sw.WriteLine(DateTime.Now.ToLocalTime() + ": " + tipo + " - " + mensagem);
            }
        }
    }
}