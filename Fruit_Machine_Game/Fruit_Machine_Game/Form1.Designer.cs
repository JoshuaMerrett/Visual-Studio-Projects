namespace Fruit_Machine_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.picturesList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblToken = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 47);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(256, 256);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(274, 47);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(256, 256);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(536, 47);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(256, 256);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(12, 387);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(780, 78);
            this.btnSpin.TabIndex = 3;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // picturesList
            // 
            this.picturesList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("picturesList.ImageStream")));
            this.picturesList.TransparentColor = System.Drawing.Color.Transparent;
            this.picturesList.Images.SetKeyName(0, "2-green-apples.jpg");
            this.picturesList.Images.SetKeyName(1, "Grapes.gif");
            this.picturesList.Images.SetKeyName(2, "kiwi.jpg");
            this.picturesList.Images.SetKeyName(3, "oranges-vitamin-c-lg.jpg");
            this.picturesList.Images.SetKeyName(4, "sourced-mango.jpg");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.Location = new System.Drawing.Point(13, 345);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(83, 25);
            this.lblToken.TabIndex = 4;
            this.lblToken.Text = "Tokens";
            // 
            // txtToken
            // 
            this.txtToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToken.Location = new System.Drawing.Point(102, 342);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(93, 31);
            this.txtToken.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 477);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.ImageList picturesList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtToken;
    }
}

