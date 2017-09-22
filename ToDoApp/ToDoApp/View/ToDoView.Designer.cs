namespace View
{
    partial class ToDoView
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(242, 204);
            this.treeView.TabIndex = 0;
            // 
            // createTaskButton
            // 
            this.createTaskButton.Location = new System.Drawing.Point(63, 226);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(75, 23);
            this.createTaskButton.TabIndex = 1;
            this.createTaskButton.Text = "Create Task";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.Location = new System.Drawing.Point(144, 226);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTaskButton.TabIndex = 2;
            this.deleteTaskButton.Text = "Delete Task";
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // ToDoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 261);
            this.Controls.Add(this.deleteTaskButton);
            this.Controls.Add(this.createTaskButton);
            this.Controls.Add(this.treeView);
            this.Name = "ToDoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.Button deleteTaskButton;
    }
}