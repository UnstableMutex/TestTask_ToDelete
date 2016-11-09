using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using TestTask_ToDelete.ViewModel;

namespace TestTask_ToDelete
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SimpleIoc.Default.Register<IContent,MainViewModel>();
            DataContext = SimpleIoc.Default.GetInstance<IContent>();
        }
    }
}
