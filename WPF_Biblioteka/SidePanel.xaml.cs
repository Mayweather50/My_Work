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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для SidePanel.xaml
    /// </summary>
    public partial class SidePanel : UserControl
    {
        public SidePanel()
        {
            InitializeComponent();
        }

        private void mail_sidepanel_listboxitem_Selected(object sender, RoutedEventArgs e)
        {
            // Start the SubmenuOne Slide-In Animation 
            Storyboard sb = FindResource("SubmenuOne_Enter") as Storyboard;
            sb.Begin();

            // Access the SubmenuOne UserControl Menu Panel and Enable it. 
           

            // TrackOne Enter Indicator
           

        }

        private void mail_sidepanel_listboxitem_Unselected(object sender, RoutedEventArgs e)
        {
            // Start the SubmenuOne Slide-Out Animation 
            Storyboard sb = FindResource("SubmenuOne_Exit") as Storyboard;
            sb.Begin();

            // TrackOne Exit Indicator 
          
        }

       
        

        private void settings_sidepanel_listboxitem_Selected(object sender, RoutedEventArgs e)
        {
            Audio audio = new Audio();
            audio.Show();
        }
    }
}
