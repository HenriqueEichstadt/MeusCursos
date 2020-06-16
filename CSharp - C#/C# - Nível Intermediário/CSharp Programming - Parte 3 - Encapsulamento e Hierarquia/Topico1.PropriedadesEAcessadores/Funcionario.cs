using System;

namespace Topico1.PropriedadesEAcessadores
{
    class Funcionario
    {
        private decimal salario;
        
        public decimal Salario // Encapsulamento do campo salário
        {
            get 
            { 
                return salario; 
            }
            //set
            //{
            //    if (value < 0)
            //        throw new ArgumentOutOfRangeException("Salário não pode ser negativo");
        
            //    salario = value;
            //}
        }

        public Funcionario(decimal salario)
        {
            if(salario < 0)
                throw new ArgumentOutOfRangeException("Salário não pode ser negativo");

            this.salario = salario;
        }
        
        
        // propfull
        // private int salario;
        //
        // public int Salario
        // {
        //     get { return salario; }
        //     set { salario = value; }
        // }
        
       // public decimal Salario { get; set; }
    }
}