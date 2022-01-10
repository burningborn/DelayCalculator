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
    public partial class Editor : Form
    {
        public Person Editable { get; set; }
        public Editor(string Name)
        {
            InitializeComponent();
            editBox.Text = Name;
            Editable = new Person();
        }

        private void editBox_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void closeBtn_Click(object sender, EventArgs e)
        {
        }

        private void editorBtn_Click(object sender, EventArgs e)
        {
            Editable.Name = editBox.Text;      
            Close();
        }
    }
}
