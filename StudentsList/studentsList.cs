using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsList
{
    public partial class studentsList : Form
    {
        string[] studens = { "Иванов", "Петров", "Сидоров", "Пупкин", "Зябликов", "Мартышкин", "Бигбаев", "Василевский", "Картышев", "Пиндяев" };
        bool res;
        public studentsList()
        {
            InitializeComponent();
            personaList.Items.AddRange(studens);
        }
        bool coincidence(string[] Arr)
        {
            bool check = true;
            int Count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < personaList.CheckedItems.Count; j++)
                {
                    if (Arr[i] == (string)personaList.CheckedItems[j])
                        Count++;
                }
            }
            if (Count != 0)
                check = false;
            return check;
        }
        private void runBtn_Click(object sender, EventArgs e)
        {
            if (actionBox.SelectedIndex == 0)
            {
                if (personaList.CheckedItems.Count == 0)
                {
                    presentBox.Items.AddRange(personaList.Items.OfType<string>().ToArray());
                    personaList.Items.Clear();
                }
                res = coincidence(presentBox.Items.OfType<string>().ToArray());
                if (res)

                    presentBox.Items.AddRange(personaList.CheckedItems.OfType<string>().ToArray());
                else
                    MessageBox.Show("Эти студенты уже есть в этом списке");
                for (int i = 0; i < personaList.CheckedItems.Count; i++)
                    personaList.Items.Remove(personaList.CheckedItems[i--]);
            }

            if (actionBox.SelectedIndex == 1)
            {
                if (personaList.CheckedItems.Count == 0)
                {
                    missingBox.Items.AddRange(personaList.Items.OfType<string>().ToArray());
                    personaList.Items.Clear();
                }
                res = coincidence(missingBox.Items.OfType<string>().ToArray());
                if (res)
                    missingBox.Items.AddRange(personaList.CheckedItems.OfType<string>().ToArray());
                else
                    MessageBox.Show("Эти студенты уже есть в этом списке");
                for (int i = 0; i < personaList.CheckedItems.Count; i++)
                    personaList.Items.Remove(personaList.CheckedItems[i--]);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
            if (result == DialogResult.No)
                exitBtn.BackColor = Color.Red;
        }

        private void presentBtn_Click(object sender, EventArgs e)
        {
            personaList.Items.AddRange(presentBox.Items.OfType<string>().ToArray());
            presentBox.Items.Clear();
        }

        private void missingBtn_Click(object sender, EventArgs e)
        {
            personaList.Items.AddRange(missingBox.Items.OfType<string>().ToArray());
            missingBox.Items.Clear();
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            personaList.Items.Clear();
        }

        private void removeSelBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < personaList.CheckedItems.Count; i++)
                personaList.Items.Remove(personaList.CheckedItems[i--]);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool newPerson = personaList.Items.Contains(addBox.Text);
            if (newPerson)
            {
                MessageBox.Show("Этот студент уже есть в списке");
            }
            else
            {
                personaList.Items.Add(addBox.Text);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            //personaList.SelectedItem = addBox.Text;
        }

        private void personaList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
