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
using GeometryLibrary;



namespace MainApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Graphic graphic;

        public MainWindow()
        {
            InitializeComponent();

            graphic = new Graphic(canvas);
        }

        private void ButtonLoadAndDraw_Click(object sender, RoutedEventArgs e)
        {
            var file = "Triangles.txt";
            var triangles = FileWorker.Read(file).ToList();

            triangles.ForEach(t => graphic.Draw(t));
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
