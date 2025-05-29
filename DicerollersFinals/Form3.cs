using System;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicerollersFinals
{
    public partial class Form3 : Form
    {
        public Form3(int totalPayout)
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.Congratulations;
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

                // Wait for the display duration
                await Task.Delay(displayDuration);
                popup.Close();
            }
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Add logic if needed when user clicks the popup image
        }

        private void totalPayoutLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
