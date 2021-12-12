
namespace Guess
{
    partial class Guess
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
            this.gameBtn = new System.Windows.Forms.Button();
            this.autoBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.countTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBtn
            // 
            this.gameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameBtn.Location = new System.Drawing.Point(298, 143);
            this.gameBtn.Name = "gameBtn";
            this.gameBtn.Size = new System.Drawing.Size(199, 62);
            this.gameBtn.TabIndex = 0;
            this.gameBtn.Text = "Игра";
            this.gameBtn.UseVisualStyleBackColor = false;
            this.gameBtn.Click += new System.EventHandler(this.gameBtn_Click);
            // 
            // autoBtn
            // 
            this.autoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.autoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoBtn.Location = new System.Drawing.Point(298, 228);
            this.autoBtn.Name = "autoBtn";
            this.autoBtn.Size = new System.Drawing.Size(199, 65);
            this.autoBtn.TabIndex = 1;
            this.autoBtn.Text = "Автоматический поиск";
            this.autoBtn.UseVisualStyleBackColor = false;
            this.autoBtn.Click += new System.EventHandler(this.autoBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(298, 97);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(199, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(275, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите число от1 до 2000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countLbl
            // 
            this.countLbl.BackColor = System.Drawing.Color.White;
            this.countLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLbl.Location = new System.Drawing.Point(477, 361);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(112, 20);
            this.countLbl.TabIndex = 4;
            this.countLbl.Text = "000000\r\n";
            this.countLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          
            // 
            // countTxt
            // 
            this.countTxt.AutoSize = true;
            this.countTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countTxt.Location = new System.Drawing.Point(252, 361);
            this.countTxt.Name = "countTxt";
            this.countTxt.Size = new System.Drawing.Size(197, 20);
            this.countTxt.TabIndex = 5;
            this.countTxt.Text = "Колличество попыток";
            this.countTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countTxt);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.autoBtn);
            this.Controls.Add(this.gameBtn);
            this.Name = "Guess";
            this.Text = "Guess";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gameBtn;
        private System.Windows.Forms.Button autoBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label countTxt;
    }
}

