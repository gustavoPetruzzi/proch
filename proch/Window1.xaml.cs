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
        public Window1(Cheque cheque)
        {
            InitializeComponent();
            Importe.Content = cheque.importe;
            Intereses.Content = cheque.interes;
            Gastos.Content = cheque.gastos;
            Iva.Content = cheque.iva;
            Final.Content = cheque.resultado;
        }
    }
}
