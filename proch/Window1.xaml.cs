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
        public Window1()
        {
            InitializeComponent();
        }

        public Window1(Cheque chequeAmostrar)
        {
            InitializeComponent();
            lblImporteFinal1.Content = string.Format("{0:.00}",chequeAmostrar.importe);
            lblInteresFinal1.Content = string.Format("{0:.00}",chequeAmostrar.interes);
            lblGastosFinal1.Content = string.Format("{0:.00}",chequeAmostrar.gastos);
            lblIvaFinal1.Content = string.Format("{0:.00}",chequeAmostrar.iva);
            lblFinal1.Content = string.Format("{0:.00}", chequeAmostrar.resultado);
        }

        
    }
}
