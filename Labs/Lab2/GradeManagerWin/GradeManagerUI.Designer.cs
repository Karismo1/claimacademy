namespace GradeManagerWin
{
    partial class GradeManagerUI
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
            this.GradeManager = new System.Windows.Forms.Label();
            this.LoadStudentFileButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GradeManager
            // 
            this.GradeManager.AutoSize = true;
            this.GradeManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeManager.Location = new System.Drawing.Point(370, 14);
            this.GradeManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GradeManager.Name = "GradeManager";
            this.GradeManager.Size = new System.Drawing.Size(298, 46);
            this.GradeManager.TabIndex = 0;
            this.GradeManager.Text = "GradeManager";
            this.GradeManager.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoadStudentFileButton
            // 
            this.LoadStudentFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadStudentFileButton.Location = new System.Drawing.Point(380, 126);
            this.LoadStudentFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadStudentFileButton.Name = "LoadStudentFileButton";
            this.LoadStudentFileButton.Size = new System.Drawing.Size(282, 88);
            this.LoadStudentFileButton.TabIndex = 1;
            this.LoadStudentFileButton.Text = "Load Student File";
            this.LoadStudentFileButton.UseVisualStyleBackColor = true;
            this.LoadStudentFileButton.Click += new System.EventHandler(this.LoadStudentFileButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentButton.Location = new System.Drawing.Point(380, 254);
            this.AddStudentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(282, 92);
            this.AddStudentButton.TabIndex = 2;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // GradeManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 726);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.LoadStudentFileButton);
            this.Controls.Add(this.GradeManager);
            this.Name = "GradeManagerUI";
            this.Text = "GradeManagerUI";
            this.Load += new System.EventHandler(this.GradeManagerUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GradeManager;
        private System.Windows.Forms.Button LoadStudentFileButton;
        private System.Windows.Forms.Button AddStudentButton;
    }
}

