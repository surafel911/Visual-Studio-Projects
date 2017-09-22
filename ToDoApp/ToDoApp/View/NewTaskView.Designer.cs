namespace View
{
    partial class NewTaskView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createSubTaskButton = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(49, 40);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(223, 20);
            this.titleTextBox.TabIndex = 3;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(16, 80);
            this.descriptionTextBox.MaxLength = 200;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(256, 72);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // createTaskButton
            // 
            this.createTaskButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createTaskButton.Location = new System.Drawing.Point(71, 256);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(75, 23);
            this.createTaskButton.TabIndex = 5;
            this.createTaskButton.Text = "Create Task";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(152, 256);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createSubTaskButton
            // 
            this.createSubTaskButton.Location = new System.Drawing.Point(177, 227);
            this.createSubTaskButton.Name = "createSubTaskButton";
            this.createSubTaskButton.Size = new System.Drawing.Size(95, 23);
            this.createSubTaskButton.TabIndex = 7;
            this.createSubTaskButton.Text = "Create Sub-Task";
            this.createSubTaskButton.UseVisualStyleBackColor = true;
            this.createSubTaskButton.Click += new System.EventHandler(this.createSubTaskButton_Click);
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Control;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView.Location = new System.Drawing.Point(16, 159);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(256, 62);
            this.treeView.TabIndex = 8;
            // 
            // NewTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.createSubTaskButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createTaskButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewTaskView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTaskView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createSubTaskButton;
        private System.Windows.Forms.TreeView treeView;
    }
}