using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelayCalculator
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        public double bpm = 0;  //темп
        public double k = 0;    //длительность ноты
        double res = 0;         //результат

        private void Form1_Load(object sender, EventArgs e)
        {
            var tempTip = new ToolTip();
            tempTip.SetToolTip(inTemp, "Choice value from 0 to 250");
            var notesTip = new ToolTip();
            notesTip.SetToolTip(noteBox, "Choice note duration");
            var dotTip = new ToolTip();
            notesTip.SetToolTip(dotBtn, "Dotted notes");
            var tripleTip = new ToolTip();
            tripleTip.SetToolTip(trplBtn, "Triplet notes");
        }

        private void inTemp_ValueChanged(object sender, EventArgs e)
        {
            bpm = Convert.ToDouble(inTemp.Value);
        }

        private void noteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<double> notes = new List<double> { 1, 0.5, 0.25, 0.125, 0.0625, 0.03125, 0.015625 };
            int i = Convert.ToInt32(noteBox.SelectedIndex);
            if (i == 0)
            {
                trplBtn.Enabled = false;
                dotBtn.Enabled = false;
            }
            k = notes[i];
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            res = k * 240 / bpm;
            outLbl.Text = Convert.ToString(res);
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(noteBox.SelectedIndex) >= 0 && Convert.ToInt32(noteBox.SelectedIndex) < 7)
            {
            trplBtn.Enabled = false;
            List<double> notes = new List<double> { 1, 0.75, 0.375, 0.1875, 0.014375, 0.046875, 0.023437 };
            k = notes[Convert.ToInt32(noteBox.SelectedIndex)];
            }
        }

        private void trplBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(noteBox.SelectedIndex) >= 0 && Convert.ToInt32(noteBox.SelectedIndex) < 7)
            {
            dotBtn.Enabled = false;
            List<double> notes = new List<double> { 1, 0.333333, 0.166666, 0.083333, 0.041666, 0.020833, 0.010416 };
            k = notes[Convert.ToInt32(noteBox.SelectedIndex)];
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            dotBtn.Enabled = true;
            trplBtn.Enabled = true;
            noteBox.Text = " ";
            inTemp.Value = 0;
            outLbl.Text = Convert.ToString(0.000);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           var result = MessageBox.Show("Are you shure?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
