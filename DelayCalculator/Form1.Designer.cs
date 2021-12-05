
namespace DelayCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dotBtn = new System.Windows.Forms.Button();
            this.tempLbl = new System.Windows.Forms.Label();
            this.noteLbl = new System.Windows.Forms.Label();
            this.dotLbl = new System.Windows.Forms.Label();
            this.tripleLbl = new System.Windows.Forms.Label();
            this.trplBtn = new System.Windows.Forms.Button();
            this.msLbl = new System.Windows.Forms.Label();
            this.noteBox = new System.Windows.Forms.ComboBox();
            this.inTemp = new System.Windows.Forms.NumericUpDown();
            this.outLbl = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // dotBtn
            // 
            this.dotBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotBtn.Location = new System.Drawing.Point(418, 95);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(75, 23);
            this.dotBtn.TabIndex = 3;
            this.dotBtn.Text = "DOT";
            this.dotBtn.UseVisualStyleBackColor = false;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // tempLbl
            // 
            this.tempLbl.AutoSize = true;
            this.tempLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tempLbl.Location = new System.Drawing.Point(103, 63);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(76, 13);
            this.tempLbl.TabIndex = 1;
            this.tempLbl.Text = "TEMP (bpm)";
            // 
            // noteLbl
            // 
            this.noteLbl.AutoSize = true;
            this.noteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteLbl.Location = new System.Drawing.Point(274, 63);
            this.noteLbl.Name = "noteLbl";
            this.noteLbl.Size = new System.Drawing.Size(40, 13);
            this.noteLbl.TabIndex = 2;
            this.noteLbl.Text = "Notes";
            // 
            // dotLbl
            // 
            this.dotLbl.AutoSize = true;
            this.dotLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotLbl.Location = new System.Drawing.Point(438, 63);
            this.dotLbl.Name = "dotLbl";
            this.dotLbl.Size = new System.Drawing.Size(27, 13);
            this.dotLbl.TabIndex = 3;
            this.dotLbl.Text = "Dot";
            // 
            // tripleLbl
            // 
            this.tripleLbl.AutoSize = true;
            this.tripleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tripleLbl.Location = new System.Drawing.Point(601, 63);
            this.tripleLbl.Name = "tripleLbl";
            this.tripleLbl.Size = new System.Drawing.Size(43, 13);
            this.tripleLbl.TabIndex = 4;
            this.tripleLbl.Text = "Triplet";
            // 
            // trplBtn
            // 
            this.trplBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.trplBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trplBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trplBtn.Location = new System.Drawing.Point(582, 95);
            this.trplBtn.Name = "trplBtn";
            this.trplBtn.Size = new System.Drawing.Size(75, 23);
            this.trplBtn.TabIndex = 5;
            this.trplBtn.Text = "lll\r\n";
            this.trplBtn.UseVisualStyleBackColor = false;
            this.trplBtn.Click += new System.EventHandler(this.trplBtn_Click);
            // 
            // msLbl
            // 
            this.msLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msLbl.BackColor = System.Drawing.Color.Salmon;
            this.msLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msLbl.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msLbl.Location = new System.Drawing.Point(471, 342);
            this.msLbl.Name = "msLbl";
            this.msLbl.Size = new System.Drawing.Size(50, 28);
            this.msLbl.TabIndex = 6;
            this.msLbl.Text = "sec\r\n";
            this.msLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noteBox
            // 
            this.noteBox.FormattingEnabled = true;
            this.noteBox.Items.AddRange(new object[] {
            "1",
            "1/2",
            "1/4",
            "1/8",
            "1/16",
            "1/32",
            "1/64"});
            this.noteBox.Location = new System.Drawing.Point(234, 95);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(121, 21);
            this.noteBox.TabIndex = 7;
            this.noteBox.Text = "1";
            this.noteBox.SelectedIndexChanged += new System.EventHandler(this.noteBox_SelectedIndexChanged);
            // 
            // inTemp
            // 
            this.inTemp.DecimalPlaces = 2;
            this.inTemp.Location = new System.Drawing.Point(85, 95);
            this.inTemp.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.inTemp.Name = "inTemp";
            this.inTemp.Size = new System.Drawing.Size(120, 20);
            this.inTemp.TabIndex = 8;
            this.inTemp.ThousandsSeparator = true;
            this.inTemp.ValueChanged += new System.EventHandler(this.inTemp_ValueChanged);
            // 
            // outLbl
            // 
            this.outLbl.BackColor = System.Drawing.Color.Khaki;
            this.outLbl.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outLbl.Location = new System.Drawing.Point(293, 290);
            this.outLbl.Name = "outLbl";
            this.outLbl.Size = new System.Drawing.Size(172, 80);
            this.outLbl.TabIndex = 9;
            this.outLbl.Text = "0.000";
            // 
            // goBtn
            // 
            this.goBtn.BackColor = System.Drawing.Color.Red;
            this.goBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBtn.Location = new System.Drawing.Point(85, 143);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(572, 68);
            this.goBtn.TabIndex = 10;
            this.goBtn.Text = "GO";
            this.goBtn.UseVisualStyleBackColor = false;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.outLbl);
            this.Controls.Add(this.inTemp);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.msLbl);
            this.Controls.Add(this.trplBtn);
            this.Controls.Add(this.tripleLbl);
            this.Controls.Add(this.dotLbl);
            this.Controls.Add(this.noteLbl);
            this.Controls.Add(this.tempLbl);
            this.Controls.Add(this.dotBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Calc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.Label noteLbl;
        private System.Windows.Forms.Label dotLbl;
        private System.Windows.Forms.Label tripleLbl;
        private System.Windows.Forms.Button trplBtn;
        private System.Windows.Forms.Label msLbl;
        private System.Windows.Forms.ComboBox noteBox;
        private System.Windows.Forms.NumericUpDown inTemp;
        private System.Windows.Forms.Label outLbl;
        private System.Windows.Forms.Button goBtn;
    }
}

