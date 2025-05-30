namespace DicerollersFinals
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.PlayVideoButton = new System.Windows.Forms.Button();
            this.StopVideoButton = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.TutorialBackButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TutorialBackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayVideoButton
            // 
            this.PlayVideoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PlayVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlayVideoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PlayVideoButton.Location = new System.Drawing.Point(171, 500);
            this.PlayVideoButton.Name = "PlayVideoButton";
            this.PlayVideoButton.Size = new System.Drawing.Size(63, 34);
            this.PlayVideoButton.TabIndex = 31;
            this.PlayVideoButton.Text = "▶";
            this.PlayVideoButton.UseVisualStyleBackColor = false;
            this.PlayVideoButton.Click += new System.EventHandler(this.PlayVideoButton_Click);
            // 
            // StopVideoButton
            // 
            this.StopVideoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.StopVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StopVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StopVideoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StopVideoButton.Location = new System.Drawing.Point(242, 500);
            this.StopVideoButton.Name = "StopVideoButton";
            this.StopVideoButton.Size = new System.Drawing.Size(63, 34);
            this.StopVideoButton.TabIndex = 31;
            this.StopVideoButton.Text = "■";
            this.StopVideoButton.UseVisualStyleBackColor = false;
            this.StopVideoButton.Click += new System.EventHandler(this.StopVideoButton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(160, 104);
            this.axWindowsMediaPlayer1.MaximumSize = new System.Drawing.Size(667, 392);
            this.axWindowsMediaPlayer1.MinimumSize = new System.Drawing.Size(667, 392);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(667, 392);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // TutorialBackButton
            // 
            this.TutorialBackButton.BackColor = System.Drawing.Color.Transparent;
            this.TutorialBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TutorialBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TutorialBackButton.ErrorImage = null;
            this.TutorialBackButton.Image = global::DicerollersFinals.Properties.Resources.back__1_;
            this.TutorialBackButton.Location = new System.Drawing.Point(85, 70);
            this.TutorialBackButton.Name = "TutorialBackButton";
            this.TutorialBackButton.Size = new System.Drawing.Size(40, 39);
            this.TutorialBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TutorialBackButton.TabIndex = 32;
            this.TutorialBackButton.TabStop = false;
            this.TutorialBackButton.Click += new System.EventHandler(this.TutorialBackButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DicerollersFinals.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 617);
            this.Controls.Add(this.TutorialBackButton);
            this.Controls.Add(this.StopVideoButton);
            this.Controls.Add(this.PlayVideoButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TutorialBackButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button PlayVideoButton;
        private System.Windows.Forms.Button StopVideoButton;
        private System.Windows.Forms.PictureBox TutorialBackButton;
    }
}