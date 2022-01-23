using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotePad
{
    public partial class NotePad_2022 : Form
    {
        public int fontSize = 0; //размер шрифта
        public System.Drawing.FontStyle fS = FontStyle.Regular; //стиль шрифта

        public string filename; // имя файла
        public bool isFileChanged;// проверка изменения файла

        fontSettings fontSet;
        public NotePad_2022()
        {
            InitializeComponent();

            Init(); //инициализация нового файла
        }
        public void Init() //функция инициализации нового файла
        {
            filename = "";
            isFileChanged = false;
            updateTitleText();
        }
        public void createNewFile(object sender, EventArgs e)//функция создания нового файла
        {
            saveUnsavedFile();
            textBoxPad.Text = "";
            filename = "";
            updateTitleText();
        }
        public void openFile(object sender, EventArgs e) //функция открытия файла
        {
            saveUnsavedFile();
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sR = new StreamReader(openFileDialog1.FileName);
                    textBoxPad.Text = sR.ReadToEnd();
                    sR.Close();
                    filename = openFileDialog1.FileName;
                    isFileChanged = false;
                }
                catch 
                {
                    MessageBox.Show("File can`t open!");
                }
            }
            updateTitleText();
        }
        public void saveFile(string _filename) // функция сохранения файла
        {
            if(_filename == "")
            {
                if(saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
            }
            try 
            {
                StreamWriter sW = new StreamWriter(_filename + ".txt");
                sW.Write(textBoxPad.Text);
                sW.Close();
                filename = _filename;
                isFileChanged = false;
            }
            catch
            {
                MessageBox.Show("Unable to save file");
            }
            updateTitleText();
        }
        public void save(object sender, EventArgs e) //функция сохранить
        {
            saveFile(filename);
            updateTitleText();
        }
        public void saveAs(object sender, EventArgs e)//функция сохранить как
        {
            saveFile("");
        }

        private void onTextChanged(object sender, EventArgs e)//функция индикации изменённого файла
        {
            if(!isFileChanged)
            {
                this.Text = this.Text.Replace("*", " ");
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }
        public void updateTitleText()//фукция обновления загогловка файла
        {
            if (filename!="")
            this.Text = filename + " - notePad";
            else this.Text = "new - notePad";
        }
        public void saveUnsavedFile()//фукция сохранения файла при выходе
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Do you want save this file?", "Save file", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                { 
                    saveFile(filename);
                }
            }
        }
        public void cutText()
        {
            Clipboard.SetText(textBoxPad.SelectedText);
            textBoxPad.Text = textBoxPad.Text.Remove(textBoxPad.SelectionStart, textBoxPad.SelectionLength);
        }
        public void copyText()
        {
            Clipboard.SetText(textBoxPad.SelectedText);
        }
        public void pasteText()
        {
            textBoxPad.Text = textBoxPad.Text.Substring(0, textBoxPad.SelectionStart) + Clipboard.GetText() 
          + textBoxPad.Text.Substring(textBoxPad.SelectionStart, textBoxPad.Text.Length - textBoxPad.SelectionStart);
        }
        private void onCutClick(object sender, EventArgs e)
        {
            cutText();
        }
        private void onCopyClick(object sender, EventArgs e)
        {
            copyText();
        }
        private void onPasteClick(object sender, EventArgs e)
        {
            pasteText();
        }

        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            saveUnsavedFile();
        }

        private void onFontClick(object sender, EventArgs e)
        {
            fontSet = new fontSettings();
            fontSet.Show();
        }

        private void onFocus(object sender, EventArgs e)
        {
            if (fontSet != null)
            {
                fontSize = fontSet.fontSize;
                fS = fontSet.fS;
                textBoxPad.Font = new Font(textBoxPad.Font.FontFamily, fontSize, fS);
                fontSet.Close();
            }
        }
    }
}
