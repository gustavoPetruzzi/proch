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
        List<Cheque> cheques;
        public MainWindow()
        {
            InitializeComponent();
            cheques = new List<Cheque>();
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
                cheques.Add(miCheque);
                MessageBox.Show("Cheque Cargado", "Proch");
                cantidad.Content = cheques.Count;
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
            for (int i = 0; i < cheques.Count; i++)
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
                Window Resultado = new Window1( chequeFinal, cheques);

                Resultado.ShowDialog();

            }
            else
            {
                MessageBox.Show("No se ha cargado ningun cheque", "Error", MessageBoxButton.OK,MessageBoxImage.Exclamation);
            }
        
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            this.cantidad.Content = 0;
            cheques.Clear();
        }
        #endregion

        private void handleKey(object sender, KeyEventArgs e)
        {
            if ( e.Key == Key.L && Keyboard.IsKeyDown(Key.LeftCtrl ))
                btnLimpiar_Click(sender, new RoutedEventArgs() );
        }

        private void TextBox_gotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        
    }
}
