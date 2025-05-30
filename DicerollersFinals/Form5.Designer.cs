namespace DicerollersFinals
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.backButton = new System.Windows.Forms.PictureBox();
            this.walletBalanceLabelProfile = new System.Windows.Forms.Label();
            this.BiggestWinProfile = new System.Windows.Forms.Label();
            this.TotalBetsProfile = new System.Windows.Forms.Label();
            this.TotalWinsProfile = new System.Windows.Forms.Label();
            this.GcashPaymentMethod = new System.Windows.Forms.Button();
            this.VisaPaymentMethod = new System.Windows.Forms.Button();
            this.VisaWithdrawal = new System.Windows.Forms.Button();
            this.WithdrawalGcash = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Deposit = new System.Windows.Forms.TextBox();
            this.Withdrawal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.ErrorImage = null;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(40, 39);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 31;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // walletBalanceLabelProfile
            // 
            this.walletBalanceLabelProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.walletBalanceLabelProfile.AutoSize = true;
            this.walletBalanceLabelProfile.BackColor = System.Drawing.Color.Transparent;
            this.walletBalanceLabelProfile.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletBalanceLabelProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.walletBalanceLabelProfile.Location = new System.Drawing.Point(284, 115);
            this.walletBalanceLabelProfile.Name = "walletBalanceLabelProfile";
            this.walletBalanceLabelProfile.Size = new System.Drawing.Size(71, 33);
            this.walletBalanceLabelProfile.TabIndex = 32;
            this.walletBalanceLabelProfile.Text = "5000";
            this.walletBalanceLabelProfile.Click += new System.EventHandler(this.walletBalanceLabelProfile_Click);
            // 
            // BiggestWinProfile
            // 
            this.BiggestWinProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BiggestWinProfile.BackColor = System.Drawing.Color.Transparent;
            this.BiggestWinProfile.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiggestWinProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BiggestWinProfile.Location = new System.Drawing.Point(683, 502);
            this.BiggestWinProfile.Name = "BiggestWinProfile";
            this.BiggestWinProfile.Size = new System.Drawing.Size(71, 33);
            this.BiggestWinProfile.TabIndex = 35;
            this.BiggestWinProfile.Text = "0";
            this.BiggestWinProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BiggestWinProfile.Click += new System.EventHandler(this.BiggestWinProfile_Click);
            // 
            // TotalBetsProfile
            // 
            this.TotalBetsProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalBetsProfile.BackColor = System.Drawing.Color.Transparent;
            this.TotalBetsProfile.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBetsProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TotalBetsProfile.Location = new System.Drawing.Point(487, 502);
            this.TotalBetsProfile.Name = "TotalBetsProfile";
            this.TotalBetsProfile.Size = new System.Drawing.Size(71, 33);
            this.TotalBetsProfile.TabIndex = 36;
            this.TotalBetsProfile.Text = "0";
            this.TotalBetsProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalBetsProfile.Click += new System.EventHandler(this.TotalBetsProfile_Click);
            // 
            // TotalWinsProfile
            // 
            this.TotalWinsProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalWinsProfile.BackColor = System.Drawing.Color.Transparent;
            this.TotalWinsProfile.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalWinsProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TotalWinsProfile.Location = new System.Drawing.Point(292, 502);
            this.TotalWinsProfile.Name = "TotalWinsProfile";
            this.TotalWinsProfile.Size = new System.Drawing.Size(71, 33);
            this.TotalWinsProfile.TabIndex = 37;
            this.TotalWinsProfile.Text = "0";
            this.TotalWinsProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalWinsProfile.Click += new System.EventHandler(this.TotalWinsProfile_Click);
            // 
            // GcashPaymentMethod
            // 
            this.GcashPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GcashPaymentMethod.BackColor = System.Drawing.Color.White;
            this.GcashPaymentMethod.BackgroundImage = global::DicerollersFinals.Properties.Resources.gcash;
            this.GcashPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GcashPaymentMethod.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.GcashPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GcashPaymentMethod.Location = new System.Drawing.Point(239, 257);
            this.GcashPaymentMethod.Name = "GcashPaymentMethod";
            this.GcashPaymentMethod.Size = new System.Drawing.Size(98, 33);
            this.GcashPaymentMethod.TabIndex = 38;
            this.GcashPaymentMethod.UseVisualStyleBackColor = false;
            this.GcashPaymentMethod.Click += new System.EventHandler(this.GcashPaymentMethod_Click);
            // 
            // VisaPaymentMethod
            // 
            this.VisaPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VisaPaymentMethod.BackColor = System.Drawing.Color.White;
            this.VisaPaymentMethod.BackgroundImage = global::DicerollersFinals.Properties.Resources.Visa;
            this.VisaPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VisaPaymentMethod.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.VisaPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VisaPaymentMethod.Location = new System.Drawing.Point(345, 257);
            this.VisaPaymentMethod.Name = "VisaPaymentMethod";
            this.VisaPaymentMethod.Size = new System.Drawing.Size(98, 33);
            this.VisaPaymentMethod.TabIndex = 39;
            this.VisaPaymentMethod.UseVisualStyleBackColor = false;
            this.VisaPaymentMethod.Click += new System.EventHandler(this.VisaPaymentMethod_Click);
            // 
            // VisaWithdrawal
            // 
            this.VisaWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VisaWithdrawal.BackColor = System.Drawing.Color.White;
            this.VisaWithdrawal.BackgroundImage = global::DicerollersFinals.Properties.Resources.Visa;
            this.VisaWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VisaWithdrawal.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.VisaWithdrawal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VisaWithdrawal.Location = new System.Drawing.Point(345, 398);
            this.VisaWithdrawal.Name = "VisaWithdrawal";
            this.VisaWithdrawal.Size = new System.Drawing.Size(98, 33);
            this.VisaWithdrawal.TabIndex = 41;
            this.VisaWithdrawal.UseVisualStyleBackColor = false;
            this.VisaWithdrawal.Click += new System.EventHandler(this.VisaWithdrawal_Click);
            // 
            // WithdrawalGcash
            // 
            this.WithdrawalGcash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WithdrawalGcash.BackColor = System.Drawing.Color.White;
            this.WithdrawalGcash.BackgroundImage = global::DicerollersFinals.Properties.Resources.gcash;
            this.WithdrawalGcash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WithdrawalGcash.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.WithdrawalGcash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WithdrawalGcash.Location = new System.Drawing.Point(238, 398);
            this.WithdrawalGcash.Name = "WithdrawalGcash";
            this.WithdrawalGcash.Size = new System.Drawing.Size(98, 33);
            this.WithdrawalGcash.TabIndex = 40;
            this.WithdrawalGcash.UseVisualStyleBackColor = false;
            this.WithdrawalGcash.Click += new System.EventHandler(this.WithdrawalGcash_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-15, -15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 42;
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(238, 194);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(114, 20);
            this.Deposit.TabIndex = 43;
            this.Deposit.TextChanged += new System.EventHandler(this.Deposit_TextChanged);
            // 
            // Withdrawal
            // 
            this.Withdrawal.Location = new System.Drawing.Point(238, 338);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(114, 20);
            this.Withdrawal.TabIndex = 44;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DicerollersFinals.Properties.Resources.Violet_Gradient_Blob_Virtual_Background__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 617);
            this.Controls.Add(this.Withdrawal);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.VisaWithdrawal);
            this.Controls.Add(this.WithdrawalGcash);
            this.Controls.Add(this.VisaPaymentMethod);
            this.Controls.Add(this.GcashPaymentMethod);
            this.Controls.Add(this.TotalWinsProfile);
            this.Controls.Add(this.TotalBetsProfile);
            this.Controls.Add(this.BiggestWinProfile);
            this.Controls.Add(this.walletBalanceLabelProfile);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label walletBalanceLabelProfile;
        private System.Windows.Forms.Label BiggestWinProfile;
        private System.Windows.Forms.Label TotalBetsProfile;
        private System.Windows.Forms.Label TotalWinsProfile;
        private System.Windows.Forms.Button GcashPaymentMethod;
        private System.Windows.Forms.Button VisaPaymentMethod;
        private System.Windows.Forms.Button VisaWithdrawal;
        private System.Windows.Forms.Button WithdrawalGcash;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Deposit;
        private System.Windows.Forms.TextBox Withdrawal;
    }
}