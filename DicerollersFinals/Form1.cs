using System.Windows.Forms;
using System;
using WMPLib;

namespace DicerollersFinals
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer bgmPlayer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a Windows Media Player instance
            bgmPlayer = new WindowsMediaPlayer();
            bgmPlayer.URL = "E:\\New folder (15)\\DicerollsFinalsUpdated-master\\DicerollersFinals\\Resources\\231. Jazz.wav"; // Replace with your audio file
            bgmPlayer.settings.setMode("loop", true); // Loop the music
            bgmPlayer.settings.volume = 10; // Set volume from 0 to 100 (lower = quieter)
            bgmPlayer.controls.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Stop and release the player
            if (bgmPlayer != null)
            {
                bgmPlayer.controls.stop();
                bgmPlayer.close();
                bgmPlayer = null;
            }

            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
