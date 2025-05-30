using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicerollersFinals
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            UpdateStatisticsDisplay();
        }


        private void UpdateStatisticsDisplay()
        {
            // Update the wallet balance label with current balance from Form4
            walletBalanceLabelProfile.Text = Form4.CurrentBalance.ToString();

            // Update statistics displays
            TotalWinsProfile.Text = Form4.TotalWins.ToString();
            TotalBetsProfile.Text = Form4.TotalBets.ToString();
            BiggestWinProfile.Text = Form4.BiggestWin.ToString();
        }


        private void UpdateBalanceDisplay()
        {
            // Update the wallet balance label with current balance from Form4
            walletBalanceLabelProfile.Text = Form4.CurrentBalance.ToString();

            // Also update statistics when balance is updated
            TotalWinsProfile.Text = Form4.TotalWins.ToString();
            TotalBetsProfile.Text = Form4.TotalBets.ToString();
            BiggestWinProfile.Text = Form4.BiggestWin.ToString();
        }





        private void backButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void walletBalanceLabelProfile_Click(object sender, EventArgs e)
        {
            // Optional: You can add functionality here if needed
        }


        string numberneed = "500";

        private void Deposit_TextChanged(object sender, EventArgs e){}

        private void DepositButton_Clicked()
        {
            string depositText = Deposit.Text.Trim();
            if (Deposit.Text != null && Regex.IsMatch(depositText, @"^[0-9]+$"))
            {
                // Only process if there's actual text and it's a valid number
                if (!string.IsNullOrEmpty(depositText) && int.TryParse(depositText, out int depositAmount))
                {

                    if (depositAmount >= 500) //If the amount is greater than or equal to 500 the message will show
                    {
                        // Add the deposit to the current balance
                        Form4.CurrentBalance += depositAmount;

                        // Update the display
                        UpdateBalanceDisplay();

                        // Clear the deposit textbox after successful deposit
                        Deposit.Text = "";

                        // Show success message
                        MessageBox.Show($"Successfully deposited {depositAmount} credits!\nNew balance: {Form4.CurrentBalance}",
                                      "Deposit Successful",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }
                    if (depositAmount < 500 && depositAmount != 0) //If the amount is less than 500 the message will show
                    {
                        MessageBox.Show("Please input the minimum deposit amount of 500.",
                                      "Invalid Amount",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        Deposit.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Letters or special characters are not allowed\nPlease enter a number atleast greater than 499",
                                "Invalid input",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                Deposit.Text = "";
            }
        }

        private void WithdrawButton_Clicked()
        {
            string withdrawText = Withdrawal.Text.Trim();
            if (Deposit.Text != null && Regex.IsMatch(withdrawText, @"^[0-9]+$"))
            {
                // Only process if there's actual text and it's a valid number
                if (!string.IsNullOrEmpty(withdrawText) && int.TryParse(withdrawText, out int withdrawAmount))
                {
                    if (withdrawAmount > Form4.CurrentBalance)
                    {
                        MessageBox.Show("Insufficient balance for withdrawal.",
                                      "Withdrawal Failed",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        Withdrawal.Text = "";
                    }
                    if (withdrawAmount >= 500 && withdrawAmount <= Form4.CurrentBalance)
                    {
                        // Add the deposit to the current balance
                        Form4.CurrentBalance -= withdrawAmount;

                        // Update the display
                        UpdateBalanceDisplay();

                        // Clear the deposit textbox after successful deposit
                        Deposit.Text = "";

                        // Show success message
                        MessageBox.Show($"Successfully deposited {withdrawAmount} credits!\nNew balance: {Form4.CurrentBalance}",
                                      "Deposit Successful",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }
                    if (withdrawAmount < 500 && withdrawAmount != 0)
                    {
                        MessageBox.Show("Please input the minimum deposit amount of 500.",
                                      "Invalid Amount",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        Deposit.Text = "";
                    } 
                }
            }
            else
            {
                MessageBox.Show("Letters or special characters are not allowed\nPlease enter a number atleast greater than 499",
                                "Invalid input",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                Deposit.Text = "";
            }
        }


        private void GcashPaymentMethod_Click(object sender, EventArgs e)
        {
            DepositButton_Clicked();
        }

        private void VisaPaymentMethod_Click(object sender, EventArgs e)
        {
            DepositButton_Clicked();
        }

        private void WithdrawalGcash_Click(object sender, EventArgs e)
        {
            WithdrawButton_Clicked();
        }

        private void VisaWithdrawal_Click(object sender, EventArgs e)
        {
            WithdrawButton_Clicked();
        }

        private void TotalWinsProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total Credits Won: {Form4.TotalWins}",
                            "Total Wins",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void TotalBetsProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total Number of Rolls: {Form4.TotalBets}",
                            "Total Bets",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void BiggestWinProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Biggest Single Win: {Form4.BiggestWin} credits",
                            "Biggest Win",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }


    }
}