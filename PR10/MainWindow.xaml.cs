using System.Collections;
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

namespace PR10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mas = new List<int>();
        }
        List<int> mas;
        public void btMasAdd_Click(object sender, RoutedEventArgs e)
        {
            lbMas.Items.Clear();
            bool boolMasAdd = int.TryParse(tbMasAdd.Text, out int masAdd);
            if (boolMasAdd == true)
            {
                mas.Add(masAdd);
                for (int i = 0; i < mas.Count; i++) lbMas.Items.Add(mas[i].ToString());
            }
        }
        public void btMasReplace_Click(object sender, RoutedEventArgs e)
        {
            int lastNumber = 0;
            int index=0;
            for (int i = 0; i < mas.Count; i++)
            {
                if (mas[i] > mas[lastNumber])
                {
                    lastNumber = mas[i];
                    index = i;
                }
            }
            int firtsnumber = mas[0];
            Swap<int>(ref lastNumber, ref firtsnumber);
            mas[0] = firtsnumber;
            mas[index]= lastNumber;
            lbMas.Items.Clear();
            for (int i = 0; i < mas.Count; i++) lbMas.Items.Add(mas[i].ToString());
        }
        public static void Swap<T>(ref T masReplaceItem, ref T masItem1)
        {
            T temp = masReplaceItem;
            masReplaceItem = masItem1;
            masItem1 = temp;
        }

        private void btInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Информация");
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}