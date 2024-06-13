using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDFAttacher
{
    public partial class Form1 : Form
    {
        private string pdfSource;
        private string pdfTarget;

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

        private void btnAttach_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            pdfTarget = pdfSource + ".tmp";

            sb.Append("\"").Append(pdfSource).Append("\" ");
            foreach (string item in lbFileList.Items.Cast<string>())
            {
                sb.AppendFormat("--add-attachment \"{0}\" ", item);
            }
            sb.Append("-- ");
            sb.Append("\"").Append(pdfTarget).Append("\"");

            procQpdf.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\qpdf\\qpdf.exe";
            procQpdf.StartInfo.Arguments = sb.ToString();
            procQpdf.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            procQpdf.StartInfo.UseShellExecute = false;
            procQpdf.StartInfo.RedirectStandardError = true;
            procQpdf.StartInfo.StandardErrorEncoding = Encoding.UTF8;
            procQpdf.StartInfo.ErrorDialog = true;
            procQpdf.StartInfo.CreateNoWindow = true;
            procQpdf.EnableRaisingEvents = true;

            procQpdf.Start();
        }

        private void procQpdf_Exited(object sender, EventArgs e)
        {
            MessageBox.Show("Exited with code " + procQpdf.ExitCode);
            if (procQpdf.ExitCode != 2)
            {
                try
                {
                    File.Replace(pdfTarget, pdfSource, pdfSource + ".bak");
                    MessageBox.Show("Вложения добавлены успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbFileList.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string Error = procQpdf.StandardError.ReadToEnd();
                MessageBox.Show("Произошла ошибка:\n"+Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
