
namespace NotePad
{
    partial class fontSettings
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
            this.exampleLbl = new System.Windows.Forms.Label();
            this.stileLbl = new System.Windows.Forms.Label();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.exampleFontLbl = new System.Windows.Forms.Label();
            this.sizeChoice = new System.Windows.Forms.ComboBox();
            this.styleChoice = new System.Windows.Forms.ComboBox();
            this.okFontBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exampleLbl
            // 
            this.exampleLbl.AutoSize = true;
            this.exampleLbl.Location = new System.Drawing.Point(178, 96);
            this.exampleLbl.Name = "exampleLbl";
            this.exampleLbl.Size = new System.Drawing.Size(47, 13);
            this.exampleLbl.TabIndex = 0;
            this.exampleLbl.Text = "Example";
            // 
            // stileLbl
            // 
            this.stileLbl.AutoSize = true;
            this.stileLbl.Location = new System.Drawing.Point(73, 14);
            this.stileLbl.Name = "stileLbl";
            this.stileLbl.Size = new System.Drawing.Size(30, 13);
            this.stileLbl.TabIndex = 1;
            this.stileLbl.Text = "Style";
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Location = new System.Drawing.Point(322, 14);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(27, 13);
            this.sizeLbl.TabIndex = 2;
            this.sizeLbl.Text = "Size";
            // 
            // exampleFontLbl
            // 
            this.exampleFontLbl.AutoSize = true;
            this.exampleFontLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exampleFontLbl.Location = new System.Drawing.Point(142, 132);
            this.exampleFontLbl.Name = "exampleFontLbl";
            this.exampleFontLbl.Size = new System.Drawing.Size(143, 31);
            this.exampleFontLbl.TabIndex = 3;
            this.exampleFontLbl.Text = "AaBbYyZz";
            // 
            // sizeChoice
            // 
            this.sizeChoice.FormattingEnabled = true;
            this.sizeChoice.Items.AddRange(new object[] {
            "8",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32"});
            this.sizeChoice.Location = new System.Drawing.Point(280, 39);
            this.sizeChoice.Name = "sizeChoice";
            this.sizeChoice.Size = new System.Drawing.Size(121, 21);
            this.sizeChoice.TabIndex = 6;
            this.sizeChoice.SelectedValueChanged += new System.EventHandler(this.onSizeChanged);
            this.sizeChoice.Click += new System.EventHandler(this.onSizeChanged);
            // 
            // styleChoice
            // 
            this.styleChoice.FormattingEnabled = true;
            this.styleChoice.Items.AddRange(new object[] {
            "Bold",
            "Italic",
            "Regular",
            "Strikeout",
            "Underline"});
            this.styleChoice.Location = new System.Drawing.Point(24, 39);
            this.styleChoice.Name = "styleChoice";
            this.styleChoice.Size = new System.Drawing.Size(121, 21);
            this.styleChoice.TabIndex = 7;
            this.styleChoice.SelectedValueChanged += new System.EventHandler(this.onStyleChanged);
            this.styleChoice.Click += new System.EventHandler(this.onStyleChanged);
            // 
            // okFontBtn
            // 
            this.okFontBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.okFontBtn.Location = new System.Drawing.Point(181, 195);
            this.okFontBtn.Name = "okFontBtn";
            this.okFontBtn.Size = new System.Drawing.Size(75, 23);
            this.okFontBtn.TabIndex = 8;
            this.okFontBtn.Text = "OK";
            this.okFontBtn.UseVisualStyleBackColor = false;
            this.okFontBtn.Click += new System.EventHandler(this.okFontBtn_Click);
            // 
            // fontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 277);
            this.Controls.Add(this.okFontBtn);
            this.Controls.Add(this.styleChoice);
            this.Controls.Add(this.sizeChoice);
            this.Controls.Add(this.exampleFontLbl);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.stileLbl);
            this.Controls.Add(this.exampleLbl);
            this.Name = "fontSettings";
            this.Text = "Font";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exampleLbl;
        private System.Windows.Forms.Label stileLbl;
        private System.Windows.Forms.Label sizeLbl;
        private System.Windows.Forms.Label exampleFontLbl;
        private System.Windows.Forms.ComboBox sizeChoice;
        private System.Windows.Forms.ComboBox styleChoice;
        private System.Windows.Forms.Button okFontBtn;
    }
}