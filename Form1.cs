using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDialogExample
{
    public partial class Form1 : Form
    {
        StreamReader inFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string inValue;
            int count = 0;

            try
            {
                openFileDialog1.ShowDialog();
                inFile = new StreamReader(openFileDialog1.FileName);
                lblMessage.Text = "File: " + openFileDialog1.FileName;

                while ((inValue = inFile.ReadLine()) != null)
                    lstBxQuestions.Items.Add("-" + inValue);
            } 

            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }

            finally
            {
                inFile.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstBxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
