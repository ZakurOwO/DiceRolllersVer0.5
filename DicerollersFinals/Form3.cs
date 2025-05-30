using System;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicerollersFinals
{
    public partial class Form3 : Form
    {
        public Form3(int totalPayout)
        {
            InitializeComponent();
           
            totalPayoutLabel.Text = $"{totalPayout}"; // Ensure label1 is added to the form
        }

        public async Task ShowCongratsPopupIfWin(bool isWin, int totalPayout, int displayDuration = 3000)
        {
            if (isWin)
            {
                // Close any existing Form3 instances
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is Form3 existingForm)
                    {
                        existingForm.Close();
                        break;
                    }
                }

                // Wait before showing the new popup
                await Task.Delay(500);

                // Show the new popup
                Form3 popup = new Form3(totalPayout);
                popup.Show();

                // Play audio
                await PlayAudioWithDelay();

                // Wait for the display duration
                await Task.Delay(displayDuration);
                popup.Close();
            }
        }

        private async Task PlayAudioWithDelay()
        {
            try
            {
                // Specify the path to your audio file
                string audioPath = Path.Combine(Application.StartupPath, "SoundEfx", "YAY Kids (Celebration) Sound Effect [Free Download].wav");

                if (!File.Exists(audioPath))
                {
                    MessageBox.Show("Audio file not found: " + audioPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Introduce a short delay before playing the audio
                await Task.Delay(15); // Adjust delay as needed

                // Play the audio
                using (SoundPlayer player = new SoundPlayer(audioPath))
                {
                    player.Play(); // Use PlaySync() if you want to wait for the sound to finish playing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing audio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void totalPayoutLabel_Click(object sender, EventArgs e)
        {
            // Add logic if needed for clicking the label
        }
    }
}
