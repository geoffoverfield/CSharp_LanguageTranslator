/********************
*  Geoff Overfield  *
*  	   7/24/15		*
*    Translator	    *
********************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech;
using System.Speech.Synthesis;

namespace CSPG220_FinalProject
{

    public partial class Form1 : Form
    {
        
        //================================GLOBAL VARIABLES===========================================
        static string flags = Directory.GetCurrentDirectory() + "/Images/";
        StreamReader reader, reader1, reader2;
        StreamWriter writer;
        Dictionary<string, string> trans = new Dictionary<string, string>();
        Dictionary<string, string> revTrans = new Dictionary<string, string>();
        SpeechSynthesizer speak = new SpeechSynthesizer();
        Stack myKeyStack = new Stack();
        Stack myValueStack = new Stack();
        public string key;
        public string value;
        //===========================================================================================
        
        //================================FORM FUNCTIONS=============================================
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(flags + "Flags.jpg");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HideButton();
            //Rich Text Box 1
            rtb2.SelectAll();
            rtb1.SelectionAlignment = HorizontalAlignment.Center;
           //Rich Text Box 2
            rtb2.SelectAll();
            rtb2.SelectionAlignment = HorizontalAlignment.Center;
            
        }
        //===========================================================================================

        //================================DEFINED FUNCTIONS==========================================
        //function hides buttons and disables them to ensure proper functionality and no mismatches between languages can occur
        private void HideButton()
        {
            Eng2Span.Visible = false;
            Span2Eng.Visible = false;
            Span2Ital.Visible = false;
            Ital2Span.Visible = false;
            Ital2Eng.Visible = false;
            Eng2Ital.Visible = false;
            Span2Eng.Enabled = false;
            Span2Ital.Enabled = false;
            Ital2Span.Enabled = false;
            Ital2Eng.Enabled = false;
            Eng2Ital.Enabled = false;
            Eng2Span.Enabled = false;
        }

        //function loads data from stored values of English, Spanish, and Italian words located in text files within the project
        private void LoadData()
        {
            string buff;
            int ndx;
            int num;
            if (Eng2Span.Enabled == true || Eng2Ital.Enabled == true || Ital2Span.Enabled == true)
            {
                num = 1;
                reader = reader1;
            }
            else
            {
                num = 2;
                reader = reader2;
            }
            switch(num)
            {
                case 1:
                    while (reader.Peek() >= 0)
                    {
                        buff = reader.ReadLine();
                        ndx = buff.IndexOf(' ');
                        key = buff.Substring(0, ndx);
                        value = buff.Substring(ndx, buff.Length - ndx);
                        trans[key] = value;
                        //MessageBox.Show(trans[key]);
                    }
                        break;
                    
                case 2:
                    while (reader.Peek() >= 0)
                    {
                        buff = reader.ReadLine();
                        ndx = buff.IndexOf(' ');
                        key = buff.Substring(0, ndx);
                        value = buff.Substring(ndx, buff.Length - ndx);
                        revTrans[value] = key;
                        //MessageBox.Show(revTrans[key]);

                    }
                    break;
            }
        }

        //converts words from selected language to selected language using dictionary data structure (C++ map<,>)
        //function also allows text to speach
        private void Translate()
        {
            string k = rtb1.Text;
            string rk = " " + rtb1.Text;

            if (Eng2Ital.Enabled == true || Eng2Span.Enabled == true || Ital2Span.Enabled == true)
            {
                foreach (string nums in trans.Keys)
                {
                    if (trans.ContainsKey(k))
                    {
                        lblDisplay.Text = trans[k];
                    }
                    else
                    {
                        lblDisplay.Text = "Not Found";
                    }
                }
                rtb1.Focus();
                rtb1.SelectAll();
            }
            else if (Span2Eng.Enabled == true || Span2Ital.Enabled == true || Ital2Eng.Enabled == true)
            {
                foreach (string nums in revTrans.Keys)
                {
                    if (revTrans.ContainsKey(rk))
                    {
                        lblDisplay.Text = revTrans[rk];
                    }
                    else
                    {
                        lblDisplay.Text = "Not Found";
                    }
                }
                rtb1.Focus();
                rtb1.SelectAll();
            }
                
        }

        //==============================================================================================
        //==========================FUNCTIONS TO ADD WORDS TO LANGUAGE DICTIONARIES=====================
        public void addToStack()
        {
            key = rtb1.Text;
            value = rtb2.Text;
            myKeyStack.Push(key);
            myValueStack.Push(value);
        }
        public void popToFile()
        {
            string newK, newV, newS;
            int switchNum = 0;
            if (addEng2Span.Checked == true)
                switchNum = 1;
            else if (addEng2Ital.Checked == true)
                switchNum = 2;
            else if (addItal2Span.Checked == true)
                switchNum = 3;
            else if (addSpan2Eng.Checked == true)
                switchNum = 4;
            else if (addSpan2Ital.Checked == true)
                switchNum = 5;
            else if (addItal2Eng.Checked == true)
                switchNum = 6;
            switch (switchNum)
            {
                case 1:
                    newK = myKeyStack.Pop().ToString();
                    newV = myValueStack.Pop().ToString();
                    newS = "\n"+ newK + " " + newV ;
                    MessageBox.Show(newS);
                    writer = new StreamWriter(flags + "Eng2Span.txt", true);
                    writer.WriteLine(newS.ToString());
                    writer.Close();
                    break;
                case 2:
                    newK = myKeyStack.Pop().ToString();
                    newV = myValueStack.Pop().ToString();
                    newS = newK + " " + newV;
                    MessageBox.Show(newS);
                    writer = new StreamWriter(flags + "Eng2Ital.txt", true);
                    writer.WriteLine(newS.ToString());
                    writer.Close();
                    break;
                case 3:
                    newK = myKeyStack.Pop().ToString();
                    newV = myValueStack.Pop().ToString();
                    newS = newK + " " + newV;
                    MessageBox.Show(newS);
                    writer = new StreamWriter(flags + "Ital2Span.txt", true);
                    writer.WriteLine(newS.ToString());
                    writer.Close();
                    break;
                case 4:
                    newV = myKeyStack.Pop().ToString();
                    newK = myValueStack.Pop().ToString();
                    newS = newK + " " + newV;
                    MessageBox.Show(newS);
                    writer = new StreamWriter(flags + "Eng2Span.txt", true);
                    writer.WriteLine(newS.ToString());
                    writer.Close();
                    break;
                case 5:
                    newV = myKeyStack.Pop().ToString();
                    newK = myValueStack.Pop().ToString();
                    newS = newK + " " + newV;
                    MessageBox.Show(newS);
                    writer = new StreamWriter(flags + "Ital2Span.txt", true);
                    writer.WriteLine(newS.ToString());
                    writer.Close();
                    break;
                case 6:
                    newV = myKeyStack.Pop().ToString();
                    newK = myValueStack.Pop().ToString();
                    newS = newK + " " + newV;
                    MessageBox.Show(newS);
                    writer = new StreamWriter(flags + "Eng2Ital.txt", true);
                    writer.WriteLine(newS.ToString());
                    writer.Close();
                    break;

            }
            
        }
        //==================================END OF ADD FUNCTIONS=====================================
        //===========================================================================================


        //=============================MENU AND BUTTON OPERATIONS====================================
        private void toSpanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnAdd.Enabled = false;
            lblInput.Visible = false;
            rtb1.Enabled = true;
            rtb1.Visible = true;
            Eng2Span.Visible = true;
            Eng2Span.Enabled = true;
            this.BackgroundImage = Image.FromFile(flags + "AmericanFlag.jpg");
            //Eng2Span.Visible = false;
            Span2Eng.Visible = false;
            Span2Ital.Visible = false;
            Ital2Span.Visible = false;
            Ital2Eng.Visible = false;
            Eng2Ital.Visible = false;
            Span2Eng.Enabled = false;
            Span2Ital.Enabled = false;
            Ital2Span.Enabled = false;
            Ital2Eng.Enabled = false;
            Eng2Ital.Enabled = false;
            //Eng2Span.Enabled = false;
            try
            {
                reader1 = new StreamReader(flags + "Eng2Span.txt");
                //reader1 = new StreamReader(flags + "Test.txt");
            }
            catch
            {
                MessageBox.Show("Unable to locate language file.");
            }
            LoadData();
        }
        private void toItalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnAdd.Enabled = false;
            lblInput.Visible = false;
            rtb1.Enabled = true;
            rtb1.Visible = true;
            Eng2Ital.Visible = true;
            Eng2Ital.Enabled = true;
            this.BackgroundImage = Image.FromFile(flags + "AmericanFlag.jpg");
            Eng2Span.Visible = false;
            Span2Eng.Visible = false;
            Span2Ital.Visible = false;
            Ital2Span.Visible = false;
            Ital2Eng.Visible = false;
            //Eng2Ital.Visible = false;
            Span2Eng.Enabled = false;
            Span2Ital.Enabled = false;
            Ital2Span.Enabled = false;
            Ital2Eng.Enabled = false;
            //Eng2Ital.Enabled = false;
            Eng2Span.Enabled = false;
            try
            {
                reader1 = new StreamReader(flags + "Eng2Ital.txt");
            }
            catch
            {
                MessageBox.Show("Unable to locate language file.");
            }
            LoadData();

        }
        private void toEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Span2Eng.Text = Resource1.SpanTrans.ToString();
            btnAdd.Visible = false;
            btnAdd.Enabled = false;
            lblInput.Visible = false;
            rtb1.Enabled = true;
            rtb1.Visible = true;
            rtb1.Text = " ";
            Span2Eng.Visible = true;
            Span2Eng.Enabled = true;
            this.BackgroundImage = Image.FromFile(flags + "SpanishFlag.jpg");
            Eng2Span.Visible = false;
            //Span2Eng.Visible = false;
            Span2Ital.Visible = false;
            Ital2Span.Visible = false;
            Ital2Eng.Visible = false;
            Eng2Ital.Visible = false;
            //Span2Eng.Enabled = false;
            Span2Ital.Enabled = false;
            Ital2Span.Enabled = false;
            Ital2Eng.Enabled = false;
            Eng2Ital.Enabled = false;
            Eng2Span.Enabled = false;
            try
            {
                reader2 = new StreamReader(flags + "Eng2Span.txt");
                //reader2 = new StreamReader(flags + "Test.txt");
            }
            catch
            {
                MessageBox.Show("Unable to locate language file.");
            }
            LoadData();
        }
        private void toItalianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Span2Ital.Text = Resource1.SpanTrans.ToString();
            btnAdd.Visible = false;
            btnAdd.Enabled = false;
            lblInput.Visible = false;
            rtb1.Enabled = true;
            rtb1.Visible = true;
            rtb1.Text = " ";
            Span2Ital.Visible = true;
            Span2Ital.Enabled = true;
            this.BackgroundImage = Image.FromFile(flags + "SpanishFlag.jpg");
            Eng2Span.Visible = false;
            Span2Eng.Visible = false;
            //Span2Ital.Visible = false;
            Ital2Span.Visible = false;
            Ital2Eng.Visible = false;
            Eng2Ital.Visible = false;
            Span2Eng.Enabled = false;
            //Span2Ital.Enabled = false;
            Ital2Span.Enabled = false;
            Ital2Eng.Enabled = false;
            Eng2Ital.Enabled = false;
            Eng2Span.Enabled = false;
            try
            {
                reader2 = new StreamReader(flags + "Ital2Span.txt");
            }
            catch
            {
                MessageBox.Show("Unable to locate language file.");
            }
            LoadData();
        }
        private void toEnglishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ital2Eng.Text = Resource1.ItalTrans.ToString();
            btnAdd.Visible = false;
            btnAdd.Enabled = false;
            lblInput.Visible = false;
            rtb1.Enabled = true;
            rtb1.Visible = true;
            Ital2Eng.Visible = true;
            Ital2Eng.Enabled = true;
            this.BackgroundImage = Image.FromFile(flags + "ItalianFlag.jpg");
            Eng2Span.Visible = false;
            Span2Eng.Visible = false;
            Span2Ital.Visible = false;
            Ital2Span.Visible = false;
            //Ital2Eng.Visible = false;
            Eng2Ital.Visible = false;
            Span2Eng.Enabled = false;
            Span2Ital.Enabled = false;
            Ital2Span.Enabled = false;
            //Ital2Eng.Enabled = false;
            Eng2Ital.Enabled = false;
            Eng2Span.Enabled = false;
            try
            {
                reader2 = new StreamReader(flags + "Eng2Ital.txt");
            }
            catch
            {
                MessageBox.Show("Unable to locate language file.");
            }
            LoadData();
        }
        private void toSpanishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ital2Span.Text = Resource1.ItalTrans.ToString();
            btnAdd.Visible = false;
            btnAdd.Enabled = false;
            lblInput.Visible = false;
            rtb1.Enabled = true;
            rtb1.Visible = true;
            Ital2Span.Visible = true;
            Ital2Span.Enabled = true;
            this.BackgroundImage = Image.FromFile(flags + "ItalianFlag.jpg");
            Eng2Span.Visible = false;
            Span2Eng.Visible = false;
            Span2Ital.Visible = false;
            //Ital2Span.Visible = false;
            Ital2Eng.Visible = false;
            Eng2Ital.Visible = false;
            Span2Eng.Enabled = false;
            Span2Ital.Enabled = false;
            //Ital2Span.Enabled = false;
            Ital2Eng.Enabled = false;
            Eng2Ital.Enabled = false;
            Eng2Span.Enabled = false;
            try
            {
                reader1 = new StreamReader(flags + "Ital2Span.txt");
            }
            catch
            {
                MessageBox.Show("Unable to locate language file.");
            }
            LoadData();

        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select your language preferences and type in a word to translate.  \nIf the word is part of the database, your word will be translated.\n\nPlease note that only the 140 most commonly used words are part of the database.\nTo Add a word, select you options through the 'Add Word' Menu");
        }
        private void toItalianToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnSpeak.Enabled = false;
            btnSpeak.Visible = false;
            addEng2Ital.Checked = true;
            HideButton();
            lblInput.Text = "Your Word: ";
            lblDisplay.Text = "Translated Word:";
            rtb1.Visible = true;
            rtb1.Enabled = true;
            rtb2.Visible = true;
            rtb2.Enabled = true;
        }
        private void toEnglishToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lblInput.Text = Resource1.SpanWord.ToString();
            lblDisplay.Text = Resource1.SpanTrans.ToString();
            btnAdd.Text = Resource1.SpanAdd.ToString();
            btnSpeak.Enabled = false;
            btnSpeak.Visible = false;
            addSpan2Eng.Checked = true;
            HideButton();
            rtb1.Visible = true;
            rtb1.Enabled = true;
            rtb2.Visible = true;
            rtb2.Enabled = true;
        }
        private void toItalianToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lblInput.Text = Resource1.SpanWord.ToString();
            lblDisplay.Text = Resource1.SpanTrans.ToString();
            btnAdd.Text = Resource1.SpanAdd.ToString();
            btnSpeak.Enabled = false;
            btnSpeak.Visible = false;
            addSpan2Ital.Checked = true;
            HideButton();
            rtb1.Visible = true;
            rtb1.Enabled = true;
            rtb2.Visible = true;
            rtb2.Enabled = true;
        }
        private void toEnglishToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lblInput.Text = Resource1.ItalWord.ToString();
            lblDisplay.Text = Resource1.ItalTrans.ToString();
            btnAdd.Text = Resource1.ItalAdd.ToString();
            btnSpeak.Enabled = false;
            btnSpeak.Visible = false;
            addItal2Eng.Checked = true;
            HideButton();
            rtb1.Visible = true;
            rtb1.Enabled = true;
            rtb2.Visible = true;
            rtb2.Enabled = true;
        }
        private void toSpanishToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lblInput.Text = Resource1.ItalWord.ToString();
            lblDisplay.Text = Resource1.ItalTrans.ToString();
            btnAdd.Text = Resource1.ItalAdd.ToString();
            btnSpeak.Enabled = false;
            btnSpeak.Visible = false;
            addItal2Span.Checked = true;
            HideButton();
            rtb1.Visible = true;
            rtb1.Enabled = true;
            rtb2.Visible = true;
            rtb2.Enabled = true;
        }
        private void Ital2Span_Click(object sender, EventArgs e)
        {
            Translate();
        }
        private void Span2Ital_Click(object sender, EventArgs e)
        {
            Translate();
        }
        private void Ital2Eng_Click(object sender, EventArgs e)
        {
            Translate();
        }
        private void Eng2Ital_Click(object sender, EventArgs e)
        {
            Translate();
        }
        private void Span2Eng_Click(object sender, EventArgs e)
        {
            Translate();
        }
        private void Eng2Span_Click(object sender, EventArgs e)
        {
            Translate();
        }
        private void toSpanishToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnSpeak.Enabled = false;
            btnSpeak.Visible = false;
            addEng2Span.Checked = true;
            HideButton();
            lblInput.Text = "Your Word: ";
            lblDisplay.Text = "Translated Word:";
            rtb1.Visible = true;
            rtb1.Enabled = true;
            rtb2.Visible = true;
            rtb2.Enabled = true;
            btnAdd.Visible = true;
            btnAdd.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addToStack();
            popToFile();
            rtb1.Text = "";
            rtb2.Text = "";
        }
        private void lblInput_Click(object sender, EventArgs e)
        {
            lblInput.Visible = false;
            rtb1.Visible = true;
            rtb1.Enabled = true;
            //rtb1.Cursor = rtb1.TextLength;
            //rtb1.SelectionStart = 2;
            
        }
        private void lblDisplay_Click(object sender, EventArgs e)
        {
            if (addEng2Ital.Checked == true || addEng2Span.Checked == true || addItal2Eng.Checked == true||
                addItal2Span.Checked == true || addSpan2Eng.Checked == true || addSpan2Ital.Checked == true)
            {
                lblDisplay.Visible = false;
                rtb2.Visible = true;
                rtb2.Enabled = true;
            }
            
        }

        //Speaks translated word
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDisplay.Text != null)
                {
                    string word = lblDisplay.Text;
                    speak.Dispose();
                    speak = new SpeechSynthesizer();
                    speak.SpeakAsync(word);
                }
                else
                {
                    MessageBox.Show("Nothing to speak.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Return)
                {
                    Translate();
                }
            
        }
        //=================================================================================
        //=================================================================================
        //=================================================================================
        //=================================================================================
    }
}
