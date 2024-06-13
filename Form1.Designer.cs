namespace PDFAttacher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dlgSelectPdf = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnSelectPdf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgSelectPdf
            // 
            this.dlgSelectPdf.Filter = "PDF-файлы|*.pdf|Все файлы|*.*";
            this.dlgSelectPdf.RestoreDirectory = true;
            this.dlgSelectPdf.ShowReadOnly = true;
            this.dlgSelectPdf.Title = "Выбрать PDF-файл";
            this.dlgSelectPdf.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgSelectPdf_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectPdf);
            this.groupBox1.Controls.Add(this.tbFileName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор PDF-файла";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(6, 21);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(461, 22);
            this.tbFileName.TabIndex = 0;
            // 
            // btnSelectPdf
            // 
            this.btnSelectPdf.Location = new System.Drawing.Point(474, 21);
            this.btnSelectPdf.Name = "btnSelectPdf";
            this.btnSelectPdf.Size = new System.Drawing.Size(95, 23);
            this.btnSelectPdf.TabIndex = 1;
            this.btnSelectPdf.Text = "Выбрать";
            this.btnSelectPdf.UseVisualStyleBackColor = true;
            this.btnSelectPdf.Click += new System.EventHandler(this.btnSelectPdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgSelectPdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectPdf;
        private System.Windows.Forms.TextBox tbFileName;
    }
}

