﻿
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
            this.ListBtn = new System.Windows.Forms.Button();
            this.removeSelBtn = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // presentBox
            // 
            this.presentBox.FormattingEnabled = true;
            this.presentBox.ItemHeight = 16;
            this.presentBox.Location = new System.Drawing.Point(31, 86);
            this.presentBox.Margin = new System.Windows.Forms.Padding(4);
            this.presentBox.Name = "presentBox";
            this.presentBox.Size = new System.Drawing.Size(375, 420);
            this.presentBox.Sorted = true;
            this.presentBox.TabIndex = 0;
            // 
            // missingBox
            // 
            this.missingBox.FormattingEnabled = true;
            this.missingBox.ItemHeight = 16;
            this.missingBox.Location = new System.Drawing.Point(845, 86);
            this.missingBox.Margin = new System.Windows.Forms.Padding(4);
            this.missingBox.Name = "missingBox";
            this.missingBox.Size = new System.Drawing.Size(375, 420);
            this.missingBox.Sorted = true;
            this.missingBox.TabIndex = 1;
            // 
            // personaList
            // 
            this.personaList.CheckOnClick = true;
            this.personaList.FormattingEnabled = true;
            this.personaList.Location = new System.Drawing.Point(439, 86);
            this.personaList.Margin = new System.Windows.Forms.Padding(4);
            this.personaList.MultiColumn = true;
            this.personaList.Name = "personaList";
            this.personaList.Size = new System.Drawing.Size(375, 429);
            this.personaList.Sorted = true;
            this.personaList.TabIndex = 2;
            this.personaList.UseCompatibleTextRendering = true;
            this.personaList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.personaList_MouseDoubleClick);
            // 
            // runBtn
            // 
            this.runBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runBtn.Location = new System.Drawing.Point(1248, 432);
            this.runBtn.Margin = new System.Windows.Forms.Padding(4);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(233, 28);
            this.runBtn.TabIndex = 3;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(1248, 479);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(233, 28);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // presentLbl
            // 
            this.presentLbl.AutoSize = true;
            this.presentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.presentLbl.Location = new System.Drawing.Point(27, 31);
            this.presentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.presentLbl.Name = "presentLbl";
            this.presentLbl.Size = new System.Drawing.Size(167, 20);
            this.presentLbl.TabIndex = 5;
            this.presentLbl.Text = "Присутствующие";
            // 
            // personsLbl
            // 
            this.personsLbl.AutoSize = true;
            this.personsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personsLbl.Location = new System.Drawing.Point(435, 31);
            this.personsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personsLbl.Name = "personsLbl";
            this.personsLbl.Size = new System.Drawing.Size(179, 20);
            this.personsLbl.TabIndex = 6;
            this.personsLbl.Text = "Список студентов";
            // 
            // missingLbl
            // 
            this.missingLbl.AutoSize = true;
            this.missingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.missingLbl.Location = new System.Drawing.Point(841, 31);
            this.missingLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.missingLbl.Name = "missingLbl";
            this.missingLbl.Size = new System.Drawing.Size(156, 20);
            this.missingLbl.TabIndex = 7;
            this.missingLbl.Text = "Отсутствующие";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1244, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Действие";
            // 
            // actionBox
            // 
            this.actionBox.FormattingEnabled = true;
            this.actionBox.Items.AddRange(new object[] {
            "Присутствуюшие",
            "Отсутствующие"});
            this.actionBox.Location = new System.Drawing.Point(1248, 86);
            this.actionBox.Margin = new System.Windows.Forms.Padding(4);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(232, 24);
            this.actionBox.TabIndex = 9;
            // 
            // presentBtn
            // 
            this.presentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.presentBtn.Location = new System.Drawing.Point(31, 528);
            this.presentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.presentBtn.Name = "presentBtn";
            this.presentBtn.Size = new System.Drawing.Size(376, 28);
            this.presentBtn.TabIndex = 10;
            this.presentBtn.Text = "Очистить список";
            this.presentBtn.UseVisualStyleBackColor = true;
            this.presentBtn.Click += new System.EventHandler(this.presentBtn_Click);
            // 
            // missingBtn
            // 
            this.missingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.missingBtn.Location = new System.Drawing.Point(845, 528);
            this.missingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.missingBtn.Name = "missingBtn";
            this.missingBtn.Size = new System.Drawing.Size(376, 28);
            this.missingBtn.TabIndex = 11;
            this.missingBtn.Text = "Очистить список";
            this.missingBtn.UseVisualStyleBackColor = true;
            this.missingBtn.Click += new System.EventHandler(this.missingBtn_Click);
            // 
            // ListBtn
            // 
            this.ListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBtn.Location = new System.Drawing.Point(439, 533);
            this.ListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(376, 28);
            this.ListBtn.TabIndex = 12;
            this.ListBtn.Text = "Очистить список";
            this.ListBtn.UseVisualStyleBackColor = true;
            this.ListBtn.Click += new System.EventHandler(this.ListBtn_Click);
            // 
            // removeSelBtn
            // 
            this.removeSelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeSelBtn.Location = new System.Drawing.Point(439, 578);
            this.removeSelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.removeSelBtn.Name = "removeSelBtn";
            this.removeSelBtn.Size = new System.Drawing.Size(376, 28);
            this.removeSelBtn.TabIndex = 13;
            this.removeSelBtn.Text = "Удалить выбранные из списка";
            this.removeSelBtn.UseVisualStyleBackColor = true;
            this.removeSelBtn.Click += new System.EventHandler(this.removeSelBtn_Click);
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(1248, 225);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(233, 22);
            this.addBox.TabIndex = 14;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(1248, 190);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(233, 28);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Добавить студента";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.Location = new System.Drawing.Point(1248, 254);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(233, 28);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "Редактировать ";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // studentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 630);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.removeSelBtn);
            this.Controls.Add(this.ListBtn);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button ListBtn;
        private System.Windows.Forms.Button removeSelBtn;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
    }
}

