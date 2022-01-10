
namespace StudentsList
{
    partial class Editor
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
        public void InitializeComponent()
        {
            this.editBox = new System.Windows.Forms.TextBox();
            this.editorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editBox
            // 
            this.editBox.Location = new System.Drawing.Point(12, 12);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(134, 20);
            this.editBox.TabIndex = 0;
            this.editBox.TextChanged += new System.EventHandler(this.editBox_TextChanged);
            // 
            // editorBtn
            // 
            this.editorBtn.Location = new System.Drawing.Point(12, 68);
            this.editorBtn.Name = "editorBtn";
            this.editorBtn.Size = new System.Drawing.Size(134, 23);
            this.editorBtn.TabIndex = 1;
            this.editorBtn.Text = "Вернуть в список";
            this.editorBtn.UseVisualStyleBackColor = true;
            this.editorBtn.Click += new System.EventHandler(this.editorBtn_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(155, 123);
            this.Controls.Add(this.editorBtn);
            this.Controls.Add(this.editBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1500, 1500);
            this.Name = "Editor";
            this.Text = "Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox editBox;
        public System.Windows.Forms.Button editorBtn;
    }
}