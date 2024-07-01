using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Project
{
    public partial class FrmMusic : Form
    {
        public FrmMusic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create and show the new form
            FrmMusic2 form = new FrmMusic2();
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
            vid.URL = @"C:\Users\Slyfe\Downloads\Different Heaven - Safe And Sound _ House _ NCS - Copyright Free Music.mp4";

            // Play the video
            vid.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create and show the new form
            FrmMusic2 form = new FrmMusic2();
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
            vid.URL = @"C:\Users\Slyfe\Downloads\Tobu - Colors [Privated NCS Release].mp4";

            // Play the video
            vid.Ctlcontrols.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
