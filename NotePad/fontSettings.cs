using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class fontSettings : Form
    {
        public int fontSize = 0;
        public System.Drawing.FontStyle fS = FontStyle.Regular;
        public fontSettings()
        {
            InitializeComponent();
            sizeChoice.SelectedItem = sizeChoice.Items[0];
            styleChoice.SelectedItem = styleChoice.Items[2];
        }       
        private void onSizeChanged(object sender, EventArgs e)
        {
            exampleFontLbl.Font = new Font(exampleFontLbl.Font.FontFamily, int.Parse(sizeChoice.SelectedItem.ToString()), exampleFontLbl.Font.Style);
            fontSize = int.Parse(sizeChoice.SelectedItem.ToString());

        }
        private void onStyleChanged(object sender, EventArgs e)
        {            
            switch (styleChoice.SelectedItem.ToString())
            {
                case "Bold":
                    exampleFontLbl.Font = new Font(exampleFontLbl.Font.FontFamily, int.Parse(sizeChoice.SelectedItem.ToString()), FontStyle.Bold);                  
                    break;
                case "Italic":
                    exampleFontLbl.Font = new Font(exampleFontLbl.Font.FontFamily, int.Parse(sizeChoice.SelectedItem.ToString()), FontStyle.Italic);
                    break;
                case "Regular":
                    exampleFontLbl.Font = new Font(exampleFontLbl.Font.FontFamily, int.Parse(sizeChoice.SelectedItem.ToString()), FontStyle.Regular);
                    break;
                case "Strikeout":
                    exampleFontLbl.Font = new Font(exampleFontLbl.Font.FontFamily, int.Parse(sizeChoice.SelectedItem.ToString()), FontStyle.Strikeout);
                    break;
                case "Underline":
                    exampleFontLbl.Font = new Font(exampleFontLbl.Font.FontFamily, int.Parse(sizeChoice.SelectedItem.ToString()), FontStyle.Underline);
                    break;
                default:
                    break;
            }
                fS = exampleFontLbl.Font.Style;
        }

        private void okFontBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
