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
using System.IO;

namespace MidTermLizCuellar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int totalYard, totalPar;
        int h1, h2, h3, h4, h5, h6, h7, h8, h9;

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtBTotalP.Text = "";
            txtBTotalY.Text = "";
            txtHorizontalC.Text = "";
            txtNameCourse.Text = "";
            txtPar1.Text = "";
            txtPar2.Text = "";
            txtPar3.Text = "";
            txtPar4.Text = "";
            txtPar5.Text = "";
            txtPar6.Text = "";
            txtPar7.Text = "";
            txtPar8.Text = "";
            txtPar9.Text = "";
            txtVerticalC.Text = "";
            txtWidth.Text = "";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string line, horizontalC, verticalC, nameCourse;
            nameCourse = txtNameCourse.Text;
            horizontalC = txtHorizontalC.Text;
            verticalC = txtVerticalC.Text;
            int.TryParse(txtWidth.Text, out int width);
            width += 63;
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Test.txt");
                sw.WriteLine(nameCourse + "Golf Course");
                for (int i = 1; i <= width; i++)
                {
                    sw.WriteLine(horizontalC);
                }
                sw.WriteLine(horizontalC + "Hole | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |Total|");
                for (int i = 1; i <= width; i++)
                {
                    sw.WriteLine(horizontalC);
                }
                sw.WriteLine($"{horizontalC} | Yardage |{h1}|{h2}|{h3}|{h4}|{h5}|{h6}|{h7}|{h8}|{h9} |{totalYard}|");
                sw.WriteLine($"{horizontalC} | Par |{p1}|{p2}|{p3}|{p4}|{p5}|{p6}|{p7}|{p8}|{p9} |{totalPar}|");
                sw.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Could not copy to file!");
            }
            }

        int p1, p2, p3, p4, p5, p6, p7, p8, p9;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(txtYH1.Text, out h1);
            int.TryParse(txtYH2.Text, out h2);
            int.TryParse(txtYH3.Text, out h3);
            int.TryParse(txtYH4.Text, out h4);
            int.TryParse(txtYH5.Text, out h5);
            int.TryParse(txtYH6.Text, out h6);
            int.TryParse(txtYH7.Text, out h7);
            int.TryParse(txtYH8.Text, out h8);
            int.TryParse(txtYH9.Text, out h9);
            int.TryParse(txtPar1.Text, out p1);
            int.TryParse(txtPar2.Text, out p2);
            int.TryParse(txtPar3.Text, out p3);
            int.TryParse(txtPar4.Text, out p4);
            int.TryParse(txtPar5.Text, out p5);
            int.TryParse(txtPar6.Text, out p6);
            int.TryParse(txtPar7.Text, out p7);
            int.TryParse(txtPar8.Text, out p8);
            int.TryParse(txtPar9.Text, out p9);
            totalYard = h1+h2 +h3 + h4 + h5 + h6 + h7 + h8 + h9;
            totalPar = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9;
            txtBTotalY.Text = totalYard.ToString();
            txtBTotalP.Text = totalPar.ToString();
        }
    }
}
