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
    public partial class Form2 : Form
    {
        private int nop;
        private RichTextBox masterText;
        public Form2()
        {
            InitializeComponent();
        }

        public static String ShowDialog(string text, string caption, Boolean alphabet)
        {
            Form prompt = new Form();
            prompt.Width = 100;
            prompt.Height = 100;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 25, Top = 25, Text = text };
            Button confirmation = new Button() { Text = "Ok", Left = 25, Width = 50, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);


            if (alphabet == false)
            {
                NumericUpDown inputBox = new NumericUpDown() { Left = 25, Top = 50, Width = 50 };
                prompt.Controls.Add(inputBox);
                prompt.ShowDialog();
                return (string)inputBox.Value.ToString();

            }
            else
            {
                TextBox inputBox = new TextBox() { Left = 25, Top = 50, Width = 50 };
                inputBox.MaxLength = 1;
                inputBox.Text = "A";
                prompt.Controls.Add(inputBox);
                prompt.ShowDialog();
                return (String)inputBox.Text;

            }
        }

        public static int addFilesConfirmation(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 100;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            NumericUpDown inputBox = new NumericUpDown() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.ShowDialog();
            return (int)inputBox.Value;
        }

        public Form2(int nop, RichTextBox masterText)
        {
            // TODO: Complete member initialization
            this.nop = nop;
            this.masterText = masterText;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void addIndex()
        {
            int s = dataGridView1.Rows.Count;
            dataGridView1.Rows[s-1].Cells[0].Value = s.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("index", "");
            dataGridView1.Rows.Add();
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[0].ReadOnly = true;


            dataGridView1.Rows[0].Cells[0].Value = "1";
            for (int i = 0; i < nop; i++)
            {
                dataGridView1.Columns.Add("placeholder" + (i + 1), "PLace holder " + (i + 1));
            }

        }


        private void importFiles(Boolean onlyFileNames)
        {
            openFileDialog1.ShowDialog();


            string rootDirectory = openFileDialog1.FileNames[0].ToString();
            rootDirectory = rootDirectory.Substring(0, rootDirectory.LastIndexOf(@"\"));

            if (onlyFileNames == false)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.SelectedPath = rootDirectory;
                fbd.ShowDialog();
            }


            for (int i = 0; i < dataGridView1.SelectedCells.Count && i < openFileDialog1.FileNames.Length; i++)
            {
                String fileName = openFileDialog1.FileNames[i].ToString().Replace(rootDirectory, "");

                if (onlyFileNames == true)
                { //onlyfile names to add

                    dataGridView1.SelectedCells[i].Value = fileName;
                    MessageBox.Show("Root diretory:- " + rootDirectory + Environment.NewLine + "File Name " + fileName);
                }
                else
                {
                    dataGridView1.SelectedCells[i].Value = rootDirectory + @"\" + fileName;


                }

            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {



        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)  //Numbers
        {

            int s = int.Parse(ShowDialog("Enter the Number !", "Number", false));
            for (int x = 0; x < dataGridView1.SelectedCells.Count; x++)
            {
                dataGridView1.SelectedCells[x].Value = dataGridView1.SelectedCells.Count + s-x;
                
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = ShowDialog("Enter the Alphabet !", "Alphabet", true);
            for (int x = 0; x < dataGridView1.SelectedCells.Count; x++)
            {
                char letter = Convert.ToChar(s);

                char nextChar;
                if (letter == 'z')
                    nextChar = 'a';
                else if (letter == 'Z')
                    nextChar = 'A';

                else
                    nextChar = (char)(((int)letter) + x);


                dataGridView1.SelectedCells[x].Value = nextChar.ToString();
            }
        }

        private void onlyFileNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importFiles(true);

        }

        private void withDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importFiles(false);
        }

        private void addAllFilesSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                openFileDialog1.ShowDialog();
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    if (dataGridView1.CurrentCell.RowIndex + i == dataGridView1.Rows.Count)
                    {
                        dataGridView1.Rows.Add();
                    }
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + i].Cells[dataGridView1.CurrentCell.ColumnIndex].Value = openFileDialog1.FileNames[i].ToString();

                }
            }
            else
            {
                MessageBox.Show("First Select Only one Cell! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder b = new StringBuilder();
            int rows = dataGridView1.Rows.Count;
            string g = masterText.Text ; 
            for (int x = 0; x < rows; x++)
            {
                for (int i =1; i < nop+1; i++)  //x=rows i=columns
                {
                    try
                    {
                        masterText.Text = masterText.Text.Replace(Form1.placeHolder + (i), dataGridView1.Rows[x].Cells[i].Value.ToString());
                    }
                    catch (Exception error)
                    {
                   //  /   MessageBox.Show(error.ToString()+ Environment.NewLine +masterText.Text + Environment.NewLine + "i="+i+Environment.NewLine+"x="+x+Environment.NewLine+Form1.placeHolder);
                        
                    }
                    
                    
                }
                b.AppendLine(masterText.Text);
                masterText.Text = g;
            }


            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, b.ToString());
            }
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                dataGridView1.SelectedCells[i].Value = "";
            }
        }


        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            addIndex();

        }

        private void oneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();

        }

        private void anyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = int.Parse(ShowDialog("Enter number of rows to be added?", "Add rows", false));
            for (int i = 0; i <x ; i++)
            {
                dataGridView1.Rows.Add();
            }
        }
        
    }
}
