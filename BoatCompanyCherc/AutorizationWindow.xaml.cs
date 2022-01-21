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
using BoatCompanyCherc.Service;
using BoatCompanyCherc.Views;

namespace BoatCompanyCherc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));
            FrameManager.MainFrame = mainFrame;
            FrameManager.MainFrame.Navigate(new MainPage());

        }
    }
}
