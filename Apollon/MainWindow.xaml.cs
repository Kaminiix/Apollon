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

namespace Apollon
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSettings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SettingsWindow SettingsForm = new SettingsWindow();
            SettingsForm.Show();
        }


        /* Animations */
        private void imgLoad_MouseEnter(object sender, MouseEventArgs e)
        {
            btnLoad.Background = new SolidColorBrush(Color.FromArgb(255,54,54,66));
        }

        private void imgLoad_MouseLeave(object sender, MouseEventArgs e)
        {
            btnLoad.Background = new SolidColorBrush(Color.FromArgb(255, 57, 58, 78));

        }
       

        private void imgSave_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSave.Background = new SolidColorBrush(Color.FromArgb(255, 54, 54, 66));

        }
        private void imgSave_MouseLeave(object sender, MouseEventArgs e)
        {
            btnSave.Background = new SolidColorBrush(Color.FromArgb(255, 57, 58, 78));

        }
        
        private void imgSettings_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSettings.Background = new SolidColorBrush(Color.FromArgb(255, 54, 54, 66));

        }
        private void imgSettings_MouseLeave(object sender, MouseEventArgs e)
        {
            btnSettings.Background = new SolidColorBrush(Color.FromArgb(255, 57, 58, 78));

        }
        
        private void imgPower_MouseEnter(object sender, MouseEventArgs e)
        {
            btnPower.Background = new SolidColorBrush(Color.FromArgb(255, 54, 54, 66));

        }

        private void imgPower_MouseLeave(object sender, MouseEventArgs e)
        {
            btnPower.Background = new SolidColorBrush(Color.FromArgb(255, 57, 58, 78));

        }

       
    }
}
