using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeslaDashcamPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                comboBox1.Items.Add(drive.Name);

                if (comboBox1.SelectedIndex == -1 && drive.DriveType == DriveType.Removable)
                {
                    comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                }
            }

        }

        private void LoadItems()
        {
            listBox1.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(comboBox1.SelectedItem + "TeslaCam\\RecentClips");
            if (dinfo.Exists)
            {
                FileInfo[] files = dinfo.GetFiles("*-front.mp4");
                foreach (FileInfo file in files)
                {
                    listBox1.Items.Add(file.Name.Replace("-front.mp4", ""));
                }

                listBox2.Items.Clear();
                dinfo = new DirectoryInfo(comboBox1.SelectedItem + "TeslaCam\\SavedClips");
                var directories = dinfo.GetDirectories();
                foreach (DirectoryInfo directory in directories)
                {
                    listBox2.Items.Add(directory.Name);
                }
            }
        }

        private void axWindowsMediaPlayer2_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 0:    // Undefined
                    currentStateLabel.Text = "Undefined";
                    break;

                case 1:    // Stopped
                    currentStateLabel.Text = "Stopped";
                    axWindowsMediaPlayerLeft.Ctlcontrols.stop();
                    axWindowsMediaPlayerRight.Ctlcontrols.stop();
                    break;

                case 2:    // Paused
                    currentStateLabel.Text = "Paused";
                    axWindowsMediaPlayerLeft.Ctlcontrols.pause();
                    axWindowsMediaPlayerRight.Ctlcontrols.pause();
                    break;

                case 3:    // Playing
                    currentStateLabel.Text = "Playing";
                    axWindowsMediaPlayerLeft.Ctlcontrols.play();
                    axWindowsMediaPlayerRight.Ctlcontrols.play();
                    break;

                case 4:    // ScanForward
                    currentStateLabel.Text = "ScanForward";
                    break;

                case 5:    // ScanReverse
                    currentStateLabel.Text = "ScanReverse";
                    break;

                case 6:    // Buffering
                    currentStateLabel.Text = "Buffering";
                    break;

                case 7:    // Waiting
                    currentStateLabel.Text = "Waiting";
                    break;

                case 8:    // MediaEnded
                    currentStateLabel.Text = "MediaEnded";
                    break;

                case 9:    // Transitioning
                    currentStateLabel.Text = "Transitioning";
                    break;

                case 10:   // Ready
                    currentStateLabel.Text = "Ready";
                    break;

                case 11:   // Reconnecting
                    currentStateLabel.Text = "Reconnecting";
                    break;

                case 12:   // Last
                    currentStateLabel.Text = "Last";
                    break;

                default:
                    currentStateLabel.Text = ("Unknown State: " + e.newState.ToString());
                    break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
            axWindowsMediaPlayerFront.URL = comboBox1.SelectedItem + "TeslaCam\\RecentClips\\" + selectedItem + "-front.mp4";
            axWindowsMediaPlayerLeft.URL = comboBox1.SelectedItem + "TeslaCam\\RecentClips\\" + selectedItem + "-left_repeater.mp4";
            axWindowsMediaPlayerRight.URL = comboBox1.SelectedItem + "TeslaCam\\RecentClips\\" + selectedItem + "-right_repeater.mp4";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string selectedItem = listBox2.SelectedItem.ToString();
            DirectoryInfo dinfo = new DirectoryInfo(comboBox1.SelectedItem + "TeslaCam\\SavedClips\\" + selectedItem);
            FileInfo[] files = dinfo.GetFiles("*-front.mp4");
            foreach (FileInfo file in files)
            {
                listBox3.Items.Add(file.Name.Replace("-front.mp4", ""));
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFolder = listBox2.SelectedItem.ToString();
            string selectedItem = listBox3.SelectedItem.ToString();
            axWindowsMediaPlayerFront.URL = comboBox1.SelectedItem + "TeslaCam\\SavedClips\\" + selectedFolder + "\\" +  selectedItem + "-front.mp4";
            axWindowsMediaPlayerLeft.URL = comboBox1.SelectedItem + "TeslaCam\\SavedClips\\" + selectedFolder + "\\" + selectedItem + "-left_repeater.mp4";
            axWindowsMediaPlayerRight.URL = comboBox1.SelectedItem + "TeslaCam\\SavedClips\\" + selectedFolder + "\\" + selectedItem + "-right_repeater.mp4";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItems();
        }
    }
}
