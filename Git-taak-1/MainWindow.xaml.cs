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

namespace Git_taak_1
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

        private void redImage_MouseEnter(object sender, MouseEventArgs e)
        {
           mainWindow.Background = Brushes.Red;
        }

        private void redImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void yellowImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Yellow;
        }

        private void yellowImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void greenImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Green;
        }

        private void greenImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void blueImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Blue;
        }

        private void blueImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void redImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCodeTextBox.Text = "#FF0000";
            colorInfoTextBox.Text = "Rood is de kleur van warmte";
        }

        private void yellowImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCodeTextBox.Text = "#FFFF00";
            colorInfoTextBox.Text = "Geel is de kleur van levenslust";
        }

        private void greenImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCodeTextBox.Text = "#008000";
            colorInfoTextBox.Text = "Groen is de kleur van genezing";
        }

        private void blueImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCodeTextBox.Text = "#0000FF";
            colorInfoTextBox.Text = "Blauw is de kleur van intelligentie";
        }
    }
}