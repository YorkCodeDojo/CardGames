namespace HigherLower
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
            this.pbCard1 = new System.Windows.Forms.PictureBox();
            this.cmdHigher = new System.Windows.Forms.Button();
            this.cmdLower = new System.Windows.Forms.Button();
            this.cmdSame = new System.Windows.Forms.Button();
            this.pbCard2 = new System.Windows.Forms.PictureBox();
            this.pbCard3 = new System.Windows.Forms.PictureBox();
            this.pbCard4 = new System.Windows.Forms.PictureBox();
            this.pbCard5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCard1
            // 
            this.pbCard1.Location = new System.Drawing.Point(15, 21);
            this.pbCard1.Name = "pbCard1";
            this.pbCard1.Size = new System.Drawing.Size(185, 205);
            this.pbCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCard1.TabIndex = 0;
            this.pbCard1.TabStop = false;
            // 
            // cmdHigher
            // 
            this.cmdHigher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHigher.Location = new System.Drawing.Point(757, 418);
            this.cmdHigher.Name = "cmdHigher";
            this.cmdHigher.Size = new System.Drawing.Size(145, 51);
            this.cmdHigher.TabIndex = 2;
            this.cmdHigher.Text = "Higher";
            this.cmdHigher.UseVisualStyleBackColor = true;
            this.cmdHigher.Click += new System.EventHandler(this.cmdHigher_Click);
            // 
            // cmdLower
            // 
            this.cmdLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLower.Location = new System.Drawing.Point(403, 418);
            this.cmdLower.Name = "cmdLower";
            this.cmdLower.Size = new System.Drawing.Size(146, 51);
            this.cmdLower.TabIndex = 3;
            this.cmdLower.Text = "Lower";
            this.cmdLower.UseVisualStyleBackColor = true;
            this.cmdLower.Click += new System.EventHandler(this.cmdLower_Click);
            // 
            // cmdSame
            // 
            this.cmdSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSame.Location = new System.Drawing.Point(580, 418);
            this.cmdSame.Name = "cmdSame";
            this.cmdSame.Size = new System.Drawing.Size(154, 51);
            this.cmdSame.TabIndex = 4;
            this.cmdSame.Text = "Same";
            this.cmdSame.UseVisualStyleBackColor = true;
            this.cmdSame.Click += new System.EventHandler(this.cmdSame_Click);
            // 
            // pbCard2
            // 
            this.pbCard2.Location = new System.Drawing.Point(277, 21);
            this.pbCard2.Name = "pbCard2";
            this.pbCard2.Size = new System.Drawing.Size(185, 205);
            this.pbCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCard2.TabIndex = 10;
            this.pbCard2.TabStop = false;
            // 
            // pbCard3
            // 
            this.pbCard3.Location = new System.Drawing.Point(543, 21);
            this.pbCard3.Name = "pbCard3";
            this.pbCard3.Size = new System.Drawing.Size(185, 205);
            this.pbCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCard3.TabIndex = 11;
            this.pbCard3.TabStop = false;
            // 
            // pbCard4
            // 
            this.pbCard4.Location = new System.Drawing.Point(818, 21);
            this.pbCard4.Name = "pbCard4";
            this.pbCard4.Size = new System.Drawing.Size(185, 205);
            this.pbCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCard4.TabIndex = 12;
            this.pbCard4.TabStop = false;
            // 
            // pbCard5
            // 
            this.pbCard5.Location = new System.Drawing.Point(1072, 21);
            this.pbCard5.Name = "pbCard5";
            this.pbCard5.Size = new System.Drawing.Size(185, 205);
            this.pbCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCard5.TabIndex = 13;
            this.pbCard5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 556);
            this.Controls.Add(this.pbCard5);
            this.Controls.Add(this.pbCard4);
            this.Controls.Add(this.pbCard3);
            this.Controls.Add(this.pbCard2);
            this.Controls.Add(this.cmdSame);
            this.Controls.Add(this.cmdLower);
            this.Controls.Add(this.cmdHigher);
            this.Controls.Add(this.pbCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCard1;
        private System.Windows.Forms.Button cmdHigher;
        private System.Windows.Forms.Button cmdLower;
        private System.Windows.Forms.Button cmdSame;
        private System.Windows.Forms.PictureBox pbCard2;
        private System.Windows.Forms.PictureBox pbCard3;
        private System.Windows.Forms.PictureBox pbCard4;
        private System.Windows.Forms.PictureBox pbCard5;
    }
}

