namespace Lottery_App
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
            this.txtNumOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumFour = new System.Windows.Forms.TextBox();
            this.txtNumBonus = new System.Windows.Forms.TextBox();
            this.txtNumFive = new System.Windows.Forms.TextBox();
            this.txtNumSix = new System.Windows.Forms.TextBox();
            this.txtNumThree = new System.Windows.Forms.TextBox();
            this.txtNumTwo = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumOne
            // 
            this.txtNumOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOne.Location = new System.Drawing.Point(46, 86);
            this.txtNumOne.Name = "txtNumOne";
            this.txtNumOne.ReadOnly = true;
            this.txtNumOne.Size = new System.Drawing.Size(76, 62);
            this.txtNumOne.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(695, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bonus";
            // 
            // txtNumFour
            // 
            this.txtNumFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFour.Location = new System.Drawing.Point(369, 86);
            this.txtNumFour.Name = "txtNumFour";
            this.txtNumFour.ReadOnly = true;
            this.txtNumFour.Size = new System.Drawing.Size(76, 62);
            this.txtNumFour.TabIndex = 8;
            // 
            // txtNumBonus
            // 
            this.txtNumBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumBonus.Location = new System.Drawing.Point(684, 86);
            this.txtNumBonus.Name = "txtNumBonus";
            this.txtNumBonus.ReadOnly = true;
            this.txtNumBonus.Size = new System.Drawing.Size(76, 62);
            this.txtNumBonus.TabIndex = 9;
            // 
            // txtNumFive
            // 
            this.txtNumFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFive.Location = new System.Drawing.Point(477, 86);
            this.txtNumFive.Name = "txtNumFive";
            this.txtNumFive.ReadOnly = true;
            this.txtNumFive.Size = new System.Drawing.Size(76, 62);
            this.txtNumFive.TabIndex = 10;
            // 
            // txtNumSix
            // 
            this.txtNumSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSix.Location = new System.Drawing.Point(583, 86);
            this.txtNumSix.Name = "txtNumSix";
            this.txtNumSix.ReadOnly = true;
            this.txtNumSix.Size = new System.Drawing.Size(76, 62);
            this.txtNumSix.TabIndex = 11;
            // 
            // txtNumThree
            // 
            this.txtNumThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumThree.Location = new System.Drawing.Point(259, 86);
            this.txtNumThree.Name = "txtNumThree";
            this.txtNumThree.ReadOnly = true;
            this.txtNumThree.Size = new System.Drawing.Size(76, 62);
            this.txtNumThree.TabIndex = 12;
            // 
            // txtNumTwo
            // 
            this.txtNumTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTwo.Location = new System.Drawing.Point(151, 86);
            this.txtNumTwo.Name = "txtNumTwo";
            this.txtNumTwo.ReadOnly = true;
            this.txtNumTwo.Size = new System.Drawing.Size(76, 62);
            this.txtNumTwo.TabIndex = 13;
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(344, 174);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(114, 40);
            this.btnDraw.TabIndex = 14;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 254);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtNumTwo);
            this.Controls.Add(this.txtNumThree);
            this.Controls.Add(this.txtNumSix);
            this.Controls.Add(this.txtNumFive);
            this.Controls.Add(this.txtNumBonus);
            this.Controls.Add(this.txtNumFour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumOne);
            this.Name = "Form1";
            this.Text = "Lottery Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumFour;
        private System.Windows.Forms.TextBox txtNumBonus;
        private System.Windows.Forms.TextBox txtNumFive;
        private System.Windows.Forms.TextBox txtNumSix;
        private System.Windows.Forms.TextBox txtNumThree;
        private System.Windows.Forms.TextBox txtNumTwo;
        private System.Windows.Forms.Button btnDraw;
    }
}

