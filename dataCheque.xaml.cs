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
    /// Interaction logic for dataCheque.xaml
    /// </summary>
    public partial class dataCheque : Window
    {
        public dataCheque(List<Cheque> cheques)
        {
            InitializeComponent();
            this.dataCheques.ItemsSource = cheques;

        }
        private void handlerKeys(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
