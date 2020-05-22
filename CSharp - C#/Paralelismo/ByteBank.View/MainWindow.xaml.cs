using ByteBank.Core.Model;
using ByteBank.Core.Repository;
using ByteBank.Core.Service;
using ByteBank.View.Processamento.Aulas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ByteBank.View
{
    public partial class MainWindow : Window
    {
        private ProcessamentoAula1 _processamentoAula1;
        private ProcessamentoAula2 _processamentoAula2;

        public MainWindow()
        {
            InitializeComponent();
            _processamentoAula1 = new ProcessamentoAula1(this);
            _processamentoAula2 = new ProcessamentoAula2(this);
        }

        private void BtnProcessar_Click(object sender, RoutedEventArgs e)
        {
            _processamentoAula2.Executar();
        }

       
    }
}
