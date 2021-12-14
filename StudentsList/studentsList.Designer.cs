
namespace StudentsList
{
    partial class studentsList
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
            this.presentBox = new System.Windows.Forms.ListBox();
            this.missingBox = new System.Windows.Forms.ListBox();
            this.personaList = new System.Windows.Forms.CheckedListBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.presentLbl = new System.Windows.Forms.Label();
            this.personsLbl = new System.Windows.Forms.Label();
            this.missingLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.actionBox = new System.Windows.Forms.ComboBox();
            this.presentBtn = new System.Windows.Forms.Button();
            this.missingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // presentBox
            // 
            this.presentBox.FormattingEnabled = true;
            this.presentBox.Location = new System.Drawing.Point(23, 70);
            this.presentBox.Name = "presentBox";
            this.presentBox.Size = new System.Drawing.Size(282, 342);
            this.presentBox.Sorted = true;
            this.presentBox.TabIndex = 0;
            // 
            // missingBox
            // 
            this.missingBox.FormattingEnabled = true;
            this.missingBox.Location = new System.Drawing.Point(634, 70);
            this.missingBox.Name = "missingBox";
            this.missingBox.Size = new System.Drawing.Size(282, 342);
            this.missingBox.Sorted = true;
            this.missingBox.TabIndex = 1;
            // 
            // personaList
            // 
            this.personaList.CheckOnClick = true;
            this.personaList.FormattingEnabled = true;
            this.personaList.Location = new System.Drawing.Point(329, 70);
            this.personaList.MultiColumn = true;
            this.personaList.Name = "personaList";
            this.personaList.Size = new System.Drawing.Size(282, 349);
            this.personaList.Sorted = true;
            this.personaList.TabIndex = 2;
            this.personaList.UseCompatibleTextRendering = true;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(936, 351);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(175, 23);
            this.runBtn.TabIndex = 3;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(936, 389);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(175, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // presentLbl
            // 
            this.presentLbl.AutoSize = true;
            this.presentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.presentLbl.Location = new System.Drawing.Point(20, 25);
            this.presentLbl.Name = "presentLbl";
            this.presentLbl.Size = new System.Drawing.Size(135, 16);
            this.presentLbl.TabIndex = 5;
            this.presentLbl.Text = "Присутствующие";
            // 
            // personsLbl
            // 
            this.personsLbl.AutoSize = true;
            this.personsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personsLbl.Location = new System.Drawing.Point(326, 25);
            this.personsLbl.Name = "personsLbl";
            this.personsLbl.Size = new System.Drawing.Size(143, 16);
            this.personsLbl.TabIndex = 6;
            this.personsLbl.Text = "Список студентов";
            // 
            // missingLbl
            // 
            this.missingLbl.AutoSize = true;
            this.missingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.missingLbl.Location = new System.Drawing.Point(631, 25);
            this.missingLbl.Name = "missingLbl";
            this.missingLbl.Size = new System.Drawing.Size(125, 16);
            this.missingLbl.TabIndex = 7;
            this.missingLbl.Text = "Отсутствующие";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(933, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Действие";
            // 
            // actionBox
            // 
            this.actionBox.FormattingEnabled = true;
            this.actionBox.Items.AddRange(new object[] {
            "Присутствуюшие",
            "Отсутствующие"});
            this.actionBox.Location = new System.Drawing.Point(936, 70);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(175, 21);
            this.actionBox.TabIndex = 9;
            // 
            // presentBtn
            // 
            this.presentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.presentBtn.Location = new System.Drawing.Point(23, 429);
            this.presentBtn.Name = "presentBtn";
            this.presentBtn.Size = new System.Drawing.Size(282, 23);
            this.presentBtn.TabIndex = 10;
            this.presentBtn.Text = "Очистить список";
            this.presentBtn.UseVisualStyleBackColor = true;
            this.presentBtn.Click += new System.EventHandler(this.presentBtn_Click);
            // 
            // missingBtn
            // 
            this.missingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.missingBtn.Location = new System.Drawing.Point(634, 429);
            this.missingBtn.Name = "missingBtn";
            this.missingBtn.Size = new System.Drawing.Size(282, 23);
            this.missingBtn.TabIndex = 11;
            this.missingBtn.Text = "Очистить список";
            this.missingBtn.UseVisualStyleBackColor = true;
            this.missingBtn.Click += new System.EventHandler(this.missingBtn_Click);
            // 
            // studentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 466);
            this.Controls.Add(this.missingBtn);
            this.Controls.Add(this.presentBtn);
            this.Controls.Add(this.actionBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.missingLbl);
            this.Controls.Add(this.personsLbl);
            this.Controls.Add(this.presentLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.personaList);
            this.Controls.Add(this.missingBox);
            this.Controls.Add(this.presentBox);
            this.Name = "studentsList";
            this.Text = "studentsList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox presentBox;
        private System.Windows.Forms.ListBox missingBox;
        private System.Windows.Forms.CheckedListBox personaList;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label presentLbl;
        private System.Windows.Forms.Label personsLbl;
        private System.Windows.Forms.Label missingLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox actionBox;
        private System.Windows.Forms.Button presentBtn;
        private System.Windows.Forms.Button missingBtn;
    }
}

