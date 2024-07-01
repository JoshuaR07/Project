using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FrmFilm : Form
    {
        public FrmFilm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create and show the new form
            FrmFilm2 form = new FrmFilm2();
            form.Show();

            // Create the AxWindowsMediaPlayer control
            AxWMPLib.AxWindowsMediaPlayer vid = new AxWMPLib.AxWindowsMediaPlayer();

            // Begin initialization
            ((System.ComponentModel.ISupportInitialize)(vid)).BeginInit();

            // Set control properties
            vid.Dock = DockStyle.Fill; // Optionally, make the video player fill the form
            vid.Enabled = true;

            // Add the control to the new form
            form.Controls.Add(vid);

            // End initialization
            ((System.ComponentModel.ISupportInitialize)(vid)).EndInit();

            // Set the video URL
            vid.URL = @"C:\Users\Slyfe\Downloads\[720p]Puss.In.Boots.The.Last.Wish.2022.WEB-DL.x264.AAC5.1-melongmovie.mp4";

            // Play the video
            vid.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create and show the new form
            FrmFilm3 form = new FrmFilm3();
            form.Show();

            // Create the AxWindowsMediaPlayer control
            AxWMPLib.AxWindowsMediaPlayer vid = new AxWMPLib.AxWindowsMediaPlayer();

            // Begin initialization
            ((System.ComponentModel.ISupportInitialize)(vid)).BeginInit();

            // Set control properties
            vid.Dock = DockStyle.Fill; // Optionally, make the video player fill the form
            vid.Enabled = true;

            // Add the control to the new form
            form.Controls.Add(vid);

            // End initialization
            ((System.ComponentModel.ISupportInitialize)(vid)).EndInit();

            // Set the video URL
            vid.URL = @"C:\Users\Slyfe\Downloads\[720p]Guardians.of.the.Galaxy.Vol.3.2023.WEB-DL - melongmovie.mp4";

            // Play the video
            vid.Ctlcontrols.play();
        }
    }
}
 