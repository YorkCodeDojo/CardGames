namespace HigherLower
{
    partial class NewGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdReplay = new System.Windows.Forms.Button();
            this.cmdNewGame = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorry you have lost";
            // 
            // cmdReplay
            // 
            this.cmdReplay.Location = new System.Drawing.Point(42, 105);
            this.cmdReplay.Name = "cmdReplay";
            this.cmdReplay.Size = new System.Drawing.Size(223, 47);
            this.cmdReplay.TabIndex = 1;
            this.cmdReplay.Text = "Try this game again?";
            this.cmdReplay.UseVisualStyleBackColor = true;
            this.cmdReplay.Click += new System.EventHandler(this.cmdReplay_Click);
            // 
            // cmdNewGame
            // 
            this.cmdNewGame.Location = new System.Drawing.Point(42, 173);
            this.cmdNewGame.Name = "cmdNewGame";
            this.cmdNewGame.Size = new System.Drawing.Size(223, 47);
            this.cmdNewGame.TabIndex = 2;
            this.cmdNewGame.Text = "Play a new game?";
            this.cmdNewGame.UseVisualStyleBackColor = true;
            this.cmdNewGame.Click += new System.EventHandler(this.cmdNewGame_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(42, 250);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(223, 47);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Exit?";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 339);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdNewGame);
            this.Controls.Add(this.cmdReplay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdReplay;
        private System.Windows.Forms.Button cmdNewGame;
        private System.Windows.Forms.Button cmdExit;
    }
}