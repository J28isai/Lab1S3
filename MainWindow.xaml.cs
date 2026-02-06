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
using Trabajo_semana_3.Repositories;
using Trabajo_semana_3.ViewModel;

namespace Lab1S3
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IRegistroInterface repo = new RegistroRepository();
            DataContext = new RegistroViewModel(repo);
        }
    }
}