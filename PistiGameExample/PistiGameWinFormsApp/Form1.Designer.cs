namespace PistiGameWinFormsApp
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
            this.grpPlayer1 = new System.Windows.Forms.GroupBox();
            this.pBoxPlayer1Card4 = new System.Windows.Forms.PictureBox();
            this.pBoxPlayer1Card2 = new System.Windows.Forms.PictureBox();
            this.pBoxPlayer1Card3 = new System.Windows.Forms.PictureBox();
            this.pBoxPlayer1Card1 = new System.Windows.Forms.PictureBox();
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.pBoxPlayer2Card4 = new System.Windows.Forms.PictureBox();
            this.pBoxPlayer2Card3 = new System.Windows.Forms.PictureBox();
            this.pBoxPlayer2Card2 = new System.Windows.Forms.PictureBox();
            this.pBoxPlayer2Card1 = new System.Windows.Forms.PictureBox();
            this.pBoxMiddle = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.grpPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer1Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer1Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer1Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer1Card1)).BeginInit();
            this.grpPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer2Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer2Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer2Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer2Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMiddle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPlayer1
            // 
            this.grpPlayer1.Controls.Add(this.pBoxPlayer1Card4);
            this.grpPlayer1.Controls.Add(this.pBoxPlayer1Card2);
            this.grpPlayer1.Controls.Add(this.pBoxPlayer1Card3);
            this.grpPlayer1.Controls.Add(this.pBoxPlayer1Card1);
            this.grpPlayer1.Location = new System.Drawing.Point(122, 287);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Size = new System.Drawing.Size(496, 160);
            this.grpPlayer1.TabIndex = 0;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "Player1";
            // 
            // pBoxPlayer1Card4
            // 
            this.pBoxPlayer1Card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxPlayer1Card4.Location = new System.Drawing.Point(390, 46);
            this.pBoxPlayer1Card4.Name = "pBoxPlayer1Card4";
            this.pBoxPlayer1Card4.Size = new System.Drawing.Size(100, 105);
            this.pBoxPlayer1Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPlayer1Card4.TabIndex = 9;
            this.pBoxPlayer1Card4.TabStop = false;
            this.pBoxPlayer1Card4.Tag = "1";
            this.pBoxPlayer1Card4.Click += new System.EventHandler(this.Players_Click);
            // 
            // pBoxPlayer1Card2
            // 
            this.pBoxPlayer1Card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxPlayer1Card2.Location = new System.Drawing.Point(130, 46);
            this.pBoxPlayer1Card2.Name = "pBoxPlayer1Card2";
            this.pBoxPlayer1Card2.Size = new System.Drawing.Size(100, 105);
            this.pBoxPlayer1Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPlayer1Card2.TabIndex = 7;
            this.pBoxPlayer1Card2.TabStop = false;
            this.pBoxPlayer1Card2.Tag = "1";
            this.pBoxPlayer1Card2.Click += new System.EventHandler(this.Players_Click);
            // 
            // pBoxPlayer1Card3
            // 
            this.pBoxPlayer1Card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxPlayer1Card3.Location = new System.Drawing.Point(260, 46);
            this.pBoxPlayer1Card3.Name = "pBoxPlayer1Card3";
            this.pBoxPlayer1Card3.Size = new System.Drawing.Size(100, 105);
            this.pBoxPlayer1Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPlayer1Card3.TabIndex = 8;
            this.pBoxPlayer1Card3.TabStop = false;
            this.pBoxPlayer1Card3.Tag = "1";
            this.pBoxPlayer1Card3.Click += new System.EventHandler(this.Players_Click);
            // 
            // pBoxPlayer1Card1
            // 
            this.pBoxPlayer1Card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxPlayer1Card1.Location = new System.Drawing.Point(6, 46);
            this.pBoxPlayer1Card1.Name = "pBoxPlayer1Card1";
            this.pBoxPlayer1Card1.Size = new System.Drawing.Size(100, 105);
            this.pBoxPlayer1Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPlayer1Card1.TabIndex = 6;
            this.pBoxPlayer1Card1.TabStop = false;
            this.pBoxPlayer1Card1.Tag = "1";
            this.pBoxPlayer1Card1.Click += new System.EventHandler(this.Players_Click);
            // 
            // grpPlayer2
            // 
            this.grpPlayer2.Controls.Add(this.pBoxPlayer2Card4);
            this.grpPlayer2.Controls.Add(this.pBoxPlayer2Card3);
            this.grpPlayer2.Controls.Add(this.pBoxPlayer2Card2);
            this.grpPlayer2.Controls.Add(this.pBoxPlayer2Card1);
            this.grpPlayer2.Location = new System.Drawing.Point(122, 12);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Size = new System.Drawing.Size(496, 149);
            this.grpPlayer2.TabIndex = 1;
            this.grpPlayer2.TabStop = false;
            this.grpPlayer2.Text = "Player2";
            // 
            // pBoxPlayer2Card4
            // 
            this.pBoxPlayer2Card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxPlayer2Card4.Location = new System.Drawing.Point(390, 28);
            this.pBoxPlayer2Card4.Name = "pBoxPlayer2Card4";
            this.pBoxPlayer2Card4.Size = new System.Drawing.Size(100, 105);
            this.pBoxPlayer2Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPlayer2Card4.TabIndex = 5;
            this.pBoxPlayer2Card4.TabStop = false;
            this.pBoxPlayer2Card4.Tag = "2";
            this.pBoxPlayer2Card4.Click += new System.EventHandler(this.Players_Click);
            // 
            // pBoxPlayer2Card3
            // 
            this.pBoxPlayer2Card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxPlayer2Card3.Location = new System.Drawing.Point(260, 28);
            this.pBoxPlayer2Card3.Name = "pBoxPlayer2Card3";
            this.pBoxPlayer2Card3.Size = new System.Drawing.Size(100, 105);
            this.pBoxPlayer2Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPlayer2Card3.TabIndex = 4;
            this.pBoxPlayer2Card3.TabStop = false;
            this.pBoxPlayer2Card3.Tag = "2";
            this.pBoxPlayer2Card3.Click += new System.EventHandler(this.Players_Click);
            // 
            // pBoxPlayer2Card2
            // 
            this.pBoxPlayer2Card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxPlayer2Card2.Location = new System.Drawing.Point(130, 28);
            this.pBoxPlayer2Card2.Name = "pBoxPlayer2Card2";
            this.pBoxPlayer2Card2.Size = new System.Drawing.Size(100, 105);
            this.pBoxPlayer2Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPlayer2Card2.TabIndex = 3;
            this.pBoxPlayer2Card2.TabStop = false;
            this.pBoxPlayer2Card2.Tag = "2";
            this.pBoxPlayer2Card2.Click += new System.EventHandler(this.Players_Click);
            // 
            // pBoxPlayer2Card1
            // 
            this.pBoxPlayer2Card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxPlayer2Card1.Location = new System.Drawing.Point(6, 28);
            this.pBoxPlayer2Card1.Name = "pBoxPlayer2Card1";
            this.pBoxPlayer2Card1.Size = new System.Drawing.Size(100, 105);
            this.pBoxPlayer2Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPlayer2Card1.TabIndex = 2;
            this.pBoxPlayer2Card1.TabStop = false;
            this.pBoxPlayer2Card1.Tag = "2";
            this.pBoxPlayer2Card1.Click += new System.EventHandler(this.Players_Click);
            // 
            // pBoxMiddle
            // 
            this.pBoxMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxMiddle.Location = new System.Drawing.Point(317, 176);
            this.pBoxMiddle.Name = "pBoxMiddle";
            this.pBoxMiddle.Size = new System.Drawing.Size(100, 105);
            this.pBoxMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxMiddle.TabIndex = 10;
            this.pBoxMiddle.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(681, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 39);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Enabled = false;
            this.btnDeal.Location = new System.Drawing.Point(681, 78);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 41);
            this.btnDeal.TabIndex = 12;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pBoxMiddle);
            this.Controls.Add(this.grpPlayer2);
            this.Controls.Add(this.grpPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPlayer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer1Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer1Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer1Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer1Card1)).EndInit();
            this.grpPlayer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer2Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer2Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer2Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlayer2Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMiddle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlayer1;
        private System.Windows.Forms.PictureBox pBoxPlayer1Card4;
        private System.Windows.Forms.PictureBox pBoxPlayer1Card2;
        private System.Windows.Forms.PictureBox pBoxPlayer1Card3;
        private System.Windows.Forms.PictureBox pBoxPlayer1Card1;
        private System.Windows.Forms.GroupBox grpPlayer2;
        private System.Windows.Forms.PictureBox pBoxPlayer2Card4;
        private System.Windows.Forms.PictureBox pBoxPlayer2Card3;
        private System.Windows.Forms.PictureBox pBoxPlayer2Card2;
        private System.Windows.Forms.PictureBox pBoxPlayer2Card1;
        private System.Windows.Forms.PictureBox pBoxMiddle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDeal;
    }
}

