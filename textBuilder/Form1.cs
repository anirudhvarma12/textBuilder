using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textBuilder
{
    public partial class Form1 : Form
    {

        int nop = 0; //Number of placeholders
        public static string placeHolder = "placeHolder_!-+="; 

        public void generateListViews(int x)
        {
         
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
generateListViews(nop);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RichTextBox masterText = richTextBox1;
            masterText.Multiline = true;
            Form2 frm = new Form2(nop,masterText);
          frm.Show();
        this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nop++;
            var oldcolor = richTextBox1.SelectionColor;
            
            string place = placeHolder + nop;
            
            
            int t = richTextBox1.SelectionStart;
            
            richTextBox1.SelectedText = place;
            richTextBox1.Select(t,place.Length);
            this.richTextBox1.SelectionColor = Color.Red;

            richTextBox1.SelectionLength = 0;
            
            richTextBox1.SelectionStart = richTextBox1.Text.Length;

            richTextBox1.SelectionColor = oldcolor;

        }
        
    
    
    }
    }

