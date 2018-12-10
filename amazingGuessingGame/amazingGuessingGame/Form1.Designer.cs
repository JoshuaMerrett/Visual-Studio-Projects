namespace amazingGuessingGame
{
    partial class frmGame
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.txtAttempts = new System.Windows.Forms.TextBox();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblWins = new System.Windows.Forms.Label();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.lblPlayed = new System.Windows.Forms.Label();
            this.txtPlayed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(35, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "The Amazing Guessing Game";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(83, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 52);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Click Here To Start The Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(39, 193);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(48, 13);
            this.lblAttempts.TabIndex = 2;
            this.lblAttempts.Text = "Attempts";
            // 
            // txtAttempts
            // 
            this.txtAttempts.Location = new System.Drawing.Point(93, 190);
            this.txtAttempts.Name = "txtAttempts";
            this.txtAttempts.ReadOnly = true;
            this.txtAttempts.Size = new System.Drawing.Size(34, 20);
            this.txtAttempts.TabIndex = 3;
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Insanity"});
            this.cbDifficulty.Location = new System.Drawing.Point(74, 64);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(121, 21);
            this.cbDifficulty.TabIndex = 4;
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(56, 219);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(31, 13);
            this.lblWins.TabIndex = 5;
            this.lblWins.Text = "Wins";
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(93, 216);
            this.txtWins.Name = "txtWins";
            this.txtWins.ReadOnly = true;
            this.txtWins.Size = new System.Drawing.Size(34, 20);
            this.txtWins.TabIndex = 6;
            // 
            // lblPlayed
            // 
            this.lblPlayed.AutoSize = true;
            this.lblPlayed.Location = new System.Drawing.Point(12, 245);
            this.lblPlayed.Name = "lblPlayed";
            this.lblPlayed.Size = new System.Drawing.Size(75, 13);
            this.lblPlayed.TabIndex = 7;
            this.lblPlayed.Text = "Games Played";
            // 
            // txtPlayed
            // 
            this.txtPlayed.Location = new System.Drawing.Point(93, 242);
            this.txtPlayed.Name = "txtPlayed";
            this.txtPlayed.ReadOnly = true;
            this.txtPlayed.Size = new System.Drawing.Size(34, 20);
            this.txtPlayed.TabIndex = 8;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.txtPlayed);
            this.Controls.Add(this.lblPlayed);
            this.Controls.Add(this.txtWins);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.txtAttempts);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmGame";
            this.Text = "The Amazing Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.TextBox txtAttempts;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.TextBox txtWins;
        private System.Windows.Forms.Label lblPlayed;
        private System.Windows.Forms.TextBox txtPlayed;
    }
}

