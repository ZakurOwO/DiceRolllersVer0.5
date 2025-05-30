namespace DicerollersFinals
{
    partial class Form1
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
            this.Exitout = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exitout
            // 
            this.Exitout.AllowDrop = true;
            this.Exitout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exitout.AutoSize = true;
            this.Exitout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Exitout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exitout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exitout.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Exitout.ForeColor = System.Drawing.Color.White;
            this.Exitout.Location = new System.Drawing.Point(875, 64);
            this.Exitout.Name = "Exitout";
            this.Exitout.Size = new System.Drawing.Size(103, 27);
            this.Exitout.TabIndex = 30;
            this.Exitout.Text = "Exit";
            this.Exitout.UseVisualStyleBackColor = false;
            this.Exitout.Click += new System.EventHandler(this.Exitout_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Black;
            this.Start.BackgroundImage = global::DicerollersFinals.Properties.Resources.Untitled_design_2_1;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Location = new System.Drawing.Point(632, 276);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(284, 253);
            this.Start.TabIndex = 0;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = global::DicerollersFinals.Properties.Resources.Violet_Gradient_Blob_Virtual_Background__4_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 617);
            this.Controls.Add(this.Exitout);
            this.Controls.Add(this.Start);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Exitout;
        private System.Windows.Forms.Button Start;
    }
}