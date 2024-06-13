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
    }
}
