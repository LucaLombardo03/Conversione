using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Conversione
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Converti_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string n = TxtNumero.Text;
                if (cmbBase.SelectedIndex == 0) //dabinario
                {

                    string valore = TxtNumero.Text;
                    int ris = 0;
                    int exp = 0;
                    for (int i = valore.Length - 1; i >= 0; i--)
                    {
                        if (valore[i] == '1')
                            ris += (int)Math.Pow(2, exp);
                        else if (valore[i] != '0')
                            throw new Exception("Non si possono inserire valori diversi da 0 e 1");
                        exp++;
                    }
                    TxtConverti.Text = $"{ris}";
                }

                else if (cmbBase.SelectedIndex == 1) //dadecimale
                {
                    int a = int.Parse(n);
                    string ris = " ";
                    int mezzo = a;
                    do
                    {
                        if (mezzo % 2 == 0)
                        {
                            mezzo = mezzo / 2;
                            ris = " " + "0" + ris;
                        }
                        else
                        {
                            mezzo = mezzo / 2;
                            ris = " " + "1" + ris;
                        }
                    } while (mezzo != 0);
                    TxtConverti.Text = ris.ToString();
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Non si possono inserire valori diversi da 0 e 1");
            }
        }
    }
}
