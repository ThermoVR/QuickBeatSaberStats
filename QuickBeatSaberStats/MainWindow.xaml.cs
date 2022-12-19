using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using QuickBeatSaberStats;

namespace QuickBeatSaberStats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AllSongs allSongs;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ConfirmPlatform(object sender, RoutedEventArgs e)
        {
            if (optSteam.IsChecked == true)
            {
                allSongs = program.loadAllSongs("C:\\Program Files(x86)\\Steam\\steamapps\\common\\Beat Saber\\Beat Saber_Data\\CustomLevels");
            }
            else if(optOculus.IsChecked == true)
            {
                allSongs = program.loadAllSongs("C:\\Program Files\\Oculus\\Software\\Software\\hyperbolic-magnetism-beat-saber\\Beat Saber_Data\\CustomLevels");
            }
            else
            {
                allSongs = program.loadAllSongs(txtCustomPath.Text);
            }
            lstAllSongs.Items.Clear();
            for(int i = 0; i < allSongs.directoryCount; i++)
            {
                string display = allSongs.Info[i].Name + " by " + allSongs.Info[i].Mapper;
                lstAllSongs.Items.Add(display);
            }
            displaySongCount();

        }

        private void displayMapStats(object sender, SelectionChangedEventArgs e)
        {
            txtSongName.Text = "Song Name : " + allSongs.Info[lstAllSongs.SelectedIndex].Name;
            txtSongSubName.Text = "Song SubName : " + allSongs.Info[lstAllSongs.SelectedIndex].SubName;
            txtAuthor.Text = "Song Author : " + allSongs.Info[lstAllSongs.SelectedIndex].Author;
            txtMapper.Text = "Song Mapper : " + allSongs.Info[lstAllSongs.SelectedIndex].Mapper;
            txtBPM.Text = "Song BPM : " + Convert.ToString(allSongs.Info[lstAllSongs.SelectedIndex].BPM);
        }

        private void displaySongCount()
        {
            txtSongCount.Text = "Songs Installed : " + Convert.ToString(allSongs.directoryCount);
        }
    }
}
