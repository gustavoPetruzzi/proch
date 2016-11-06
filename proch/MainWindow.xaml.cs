using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace proch
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cheque[] cheques = new Cheque[5];
        public MainWindow()
        {
            InitializeComponent();
        }

        
        #region Botones
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            double importe;
            double interes;
            double gastos;
            if(double.TryParse(txtImporte.Text.Replace(".",","), out importe) && double.TryParse(txtInteres.Text.Replace(".",","), out interes) && double.TryParse(txtGastos.Text.Replace('.',','), out gastos))
            {
                Boolean pudoAgregar;
                Cheque miCheque = new Cheque(importe, interes, gastos);
                MessageBox.Show("Cheque Cargado", "hola");
                pudoAgregar = cheques + miCheque;
            }
            else
            {
                MessageBox.Show("Solamente ingrese numeros", "ERROR",MessageBoxButton.OK, MessageBoxImage.Error );
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            Cheque chequeFinal = new Cheque();
            bool chequeCargado = false;
            for (int i = 0; i < cheques.Length; i++)
            {
                if (!(object.Equals(cheques[i], null)))
                {
                    cheques[i] = Cheque.calcular(cheques[i]);
                    chequeFinal = chequeFinal + cheques[i];
                    chequeCargado = true;
                }
                
            }
            if(chequeCargado)
            {
                Window Resultado = new Window1( chequeFinal);
                                
                Resultado.Show();

            }
            else
            {
                MessageBox.Show("No se ha cargado ningun cheque", "Error", MessageBoxButton.OK,MessageBoxImage.Exclamation);
            }
            #endregion
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Array.Clear(cheques, 0, cheques.Length);
        }
    }
}
