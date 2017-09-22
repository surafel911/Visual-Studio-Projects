namespace View
{
    partial class FileTransferView
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
            this.transferButton = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceBrowseButton = new System.Windows.Forms.Button();
            this.targetBrowseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(179, 77);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(75, 23);
            this.transferButton.TabIndex = 0;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(51, 25);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(355, 20);
            this.sourceTextBox.TabIndex = 1;
            this.sourceTextBox.TextChanged += new System.EventHandler(this.sourceTextBox_TextChanged);
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(51, 51);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(355, 20);
            this.targetTextBox.TabIndex = 2;
            this.targetTextBox.TextChanged += new System.EventHandler(this.targetTextBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(260, 77);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To:";
            // 
            // sourceBrowseButton
            // 
            this.sourceBrowseButton.Location = new System.Drawing.Point(412, 22);
            this.sourceBrowseButton.Name = "sourceBrowseButton";
            this.sourceBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.sourceBrowseButton.TabIndex = 6;
            this.sourceBrowseButton.Text = "Browse...";
            this.sourceBrowseButton.UseVisualStyleBackColor = true;
            this.sourceBrowseButton.Click += new System.EventHandler(this.sourceBrowseButton_Click);
            // 
            // targetBrowseButton
            // 
            this.targetBrowseButton.Location = new System.Drawing.Point(412, 51);
            this.targetBrowseButton.Name = "targetBrowseButton";
            this.targetBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.targetBrowseButton.TabIndex = 7;
            this.targetBrowseButton.Text = "Browse...";
            this.targetBrowseButton.UseVisualStyleBackColor = true;
            this.targetBrowseButton.Click += new System.EventHandler(this.targetBrowseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose two file locations.";
            this.toolTip1.SetToolTip(this.label3, "Choose a \"source\" file location to retrieve and  \r\ntransfer its contents to the \"" +
        "target\" file location.");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // FileTransferView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 108);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.targetBrowseButton);
            this.Controls.Add(this.sourceBrowseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.transferButton);
            this.Name = "FileTransferView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sourceBrowseButton;
        private System.Windows.Forms.Button targetBrowseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}