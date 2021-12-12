using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess
{
    public partial class Guess : Form
    {
        int inputNum;
        int count = 1;
        public Guess()
        {
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            inputNum = Convert.ToInt32(numericUpDown1.Value);
        }

        private void gameBtn_Click(object sender, EventArgs e)
        {
            //int count = 1;
            DialogResult result;
            while (true)
            {
                result = MessageBox.Show($"{new Random().Next(1, 2000)}", "Вы загадали число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Количество запросов {count}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count = 0;
                    result = MessageBox.Show("Хотите продолжить?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) this.Close();
                }
                else
                {
                count++;
                countLbl.Text = Convert.ToString(count);

                }
            }
        } 

        private void autoBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult result;
            while (true)
            {
                if (inputNum == new Random().Next(1, 2000))
                {
                    result = MessageBox.Show($"Вы загадали число: {inputNum} ", $"Количество запросов: {count}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count = 0;
                    result = MessageBox.Show("Хотите продолжить?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) this.Close();
                }
                else
                {

                count++;
                countLbl.Text = Convert.ToString(count);
                }
               
            }
        }

        
    }
}
