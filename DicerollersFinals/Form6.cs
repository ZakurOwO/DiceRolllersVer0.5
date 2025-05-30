using System;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicerollersFinals
{
    public partial class Form6 : Form
    {
        private SoundPlayer _soundPlayer; // Class-level SoundPlayer reference

        public Form6()
        {
            InitializeComponent();
            PlayAudioWithDelay();
        }

        private async void PlayAudioWithDelay()
        {
            try
            {
                // Specify the path to your audio file
                string audioPath = Path.Combine(Application.StartupPath, "SoundEfx", "Applause Crowd Cheering sound effect.wav");

                if (!File.Exists(audioPath))
                {
                    MessageBox.Show("Audio file not found: " + audioPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await Task.Delay(50); // delay before playing sound

                // Initialize and play the audio
                _soundPlayer = new SoundPlayer(audioPath);
                _soundPlayer.PlayLooping(); // Play audio in a loop
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing audio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Override the OnFormClosing method to stop the audio
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Stop the audio if it's playing
            _soundPlayer?.Stop();
            _soundPlayer?.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle picture box click event
        }
    }
}
