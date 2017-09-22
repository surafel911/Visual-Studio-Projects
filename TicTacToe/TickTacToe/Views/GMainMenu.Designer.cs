namespace Views
{
    partial class GMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GMainMenu));
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerOneNameTextbox = new System.Windows.Forms.TextBox();
            this.playerTwoNameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playButton.Location = new System.Drawing.Point(13, 114);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitButton.Location = new System.Drawing.Point(164, 114);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player One:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player Two: ";
            // 
            // playerOneNameTextbox
            // 
            this.playerOneNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerOneNameTextbox.Location = new System.Drawing.Point(78, 33);
            this.playerOneNameTextbox.Name = "playerOneNameTextbox";
            this.playerOneNameTextbox.Size = new System.Drawing.Size(161, 20);
            this.playerOneNameTextbox.TabIndex = 4;
            this.playerOneNameTextbox.TextChanged += new System.EventHandler(this.playerOneNameTextbox_TextChanged);
            // 
            // playerTwoNameTextbox
            // 
            this.playerTwoNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerTwoNameTextbox.Location = new System.Drawing.Point(78, 71);
            this.playerTwoNameTextbox.Name = "playerTwoNameTextbox";
            this.playerTwoNameTextbox.Size = new System.Drawing.Size(161, 20);
            this.playerTwoNameTextbox.TabIndex = 5;
            this.playerTwoNameTextbox.TextChanged += new System.EventHandler(this.playerTwoNameTextbox_TextChanged);
            // 
            // GMainMenu
            // 
            this.AcceptButton = this.playButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CancelButton = this.quitButton;
            this.ClientSize = new System.Drawing.Size(251, 149);
            this.Controls.Add(this.playerTwoNameTextbox);
            this.Controls.Add(this.playerOneNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerOneNameTextbox;
        private System.Windows.Forms.TextBox playerTwoNameTextbox;
    }
}