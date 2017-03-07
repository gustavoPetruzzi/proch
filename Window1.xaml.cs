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
using System.Windows.Shapes;

namespace proch
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Cheque> chequesGrid;
        public Window1(Cheque cheque, List<Cheque> cheques)
        {
            InitializeComponent();
            this.chequesGrid = cheques;
            Importe.Content = string.Format("{0:.00}", cheque.importe);
            Intereses.Content = string.Format("{0:.00}", cheque.interes);
            Gastos.Content = string.Format("{0:.00}", cheque.gastos);
            Iva.Content = string.Format("{0:.00}", cheque.iva);
            Final.Content = string.Format("{0:.00}", cheque.resultado);
        }
        /*
         * Agregar al xaml, en la propiedad keydown, el valor handlerKeys para que tome el valor
        */
        private void handlerKeys(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }

        private void mostrarCheques_Click(object sender, RoutedEventArgs e)
        {
            Window dataGridCheques = new dataCheque(chequesGrid);
            dataGridCheques.ShowDialog();
            
        }
    }
}
