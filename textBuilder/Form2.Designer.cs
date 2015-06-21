namespace textBuilder
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyFileNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAllFilesSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 183);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 226);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.addRowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.filesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.toolsToolStripMenuItem.Text = "Fill";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.customizeToolStripMenuItem.Text = "Numbers";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.optionsToolStripMenuItem.Text = "Alphabets";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withDirectoryToolStripMenuItem,
            this.onlyFileNamesToolStripMenuItem,
            this.addAllFilesSelectedToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // withDirectoryToolStripMenuItem
            // 
            this.withDirectoryToolStripMenuItem.Name = "withDirectoryToolStripMenuItem";
            this.withDirectoryToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.withDirectoryToolStripMenuItem.Text = "With Directory";
            this.withDirectoryToolStripMenuItem.Click += new System.EventHandler(this.withDirectoryToolStripMenuItem_Click);
            // 
            // onlyFileNamesToolStripMenuItem
            // 
            this.onlyFileNamesToolStripMenuItem.Name = "onlyFileNamesToolStripMenuItem";
            this.onlyFileNamesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.onlyFileNamesToolStripMenuItem.Text = "Only FileNames";
            this.onlyFileNamesToolStripMenuItem.Click += new System.EventHandler(this.onlyFileNamesToolStripMenuItem_Click);
            // 
            // addAllFilesSelectedToolStripMenuItem
            // 
            this.addAllFilesSelectedToolStripMenuItem.Name = "addAllFilesSelectedToolStripMenuItem";
            this.addAllFilesSelectedToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addAllFilesSelectedToolStripMenuItem.Text = "Add all files Selected";
            this.addAllFilesSelectedToolStripMenuItem.ToolTipText = "Select one cell from there down below all the files will be added";
            this.addAllFilesSelectedToolStripMenuItem.Click += new System.EventHandler(this.addAllFilesSelectedToolStripMenuItem_Click);
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneToolStripMenuItem,
            this.anyToolStripMenuItem});
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.addRowToolStripMenuItem.Text = "Add Row";
            // 
            // oneToolStripMenuItem
            // 
            this.oneToolStripMenuItem.Name = "oneToolStripMenuItem";
            this.oneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oneToolStripMenuItem.Text = "One";
            this.oneToolStripMenuItem.Click += new System.EventHandler(this.oneToolStripMenuItem_Click);
            // 
            // anyToolStripMenuItem
            // 
            this.anyToolStripMenuItem.Name = "anyToolStripMenuItem";
            this.anyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.anyToolStripMenuItem.Text = "Any";
            this.anyToolStripMenuItem.Click += new System.EventHandler(this.anyToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Fill";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyFileNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAllFilesSelectedToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anyToolStripMenuItem;
    }
}