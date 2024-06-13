using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDFAttacher
{
    public partial class Form1 : Form
    {
        private string pdfSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSelectPdf_Click(object sender, EventArgs e)
        {
            dlgSelectPdf.ShowDialog();
        }

        private void dlgSelectPdf_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = dlgSelectPdf.FileName;
            tbFileName.Text = fileName;
        }

        private void dlgSelectFile_FileOk(object sender, CancelEventArgs e)
        {
            string[] fileNames = dlgSelectFile.FileNames;
            foreach (string fileName in fileNames)
            {
                lbFileList.Items.Add(fileName);
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            dlgSelectFile.ShowDialog();
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            while (lbFileList.SelectedItems.Count > 0)
            {
                lbFileList.Items.Remove(lbFileList.SelectedItem);
            }
        }

        private void tbFileName_TextChanged(object sender, EventArgs e)
        {
            pdfSource = tbFileName.Text;
        }
    }
}
