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
            this.btnSelectPdf = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbFileList = new System.Windows.Forms.ListBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.dlgSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(6, 21);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(461, 22);
            this.tbFileName.TabIndex = 0;
            this.tbFileName.TextChanged += new System.EventHandler(this.tbFileName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveFile);
            this.groupBox2.Controls.Add(this.btnAddFile);
            this.groupBox2.Controls.Add(this.lbFileList);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список прикрепляемых файлов";
            // 
            // lbFileList
            // 
            this.lbFileList.FormattingEnabled = true;
            this.lbFileList.ItemHeight = 16;
            this.lbFileList.Location = new System.Drawing.Point(7, 22);
            this.lbFileList.Name = "lbFileList";
            this.lbFileList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbFileList.Size = new System.Drawing.Size(562, 148);
            this.lbFileList.TabIndex = 0;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(448, 182);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(120, 31);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "Добавить";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(333, 182);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(109, 32);
            this.btnRemoveFile.TabIndex = 2;
            this.btnRemoveFile.Text = "Удалить";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // dlgSelectFile
            // 
            this.dlgSelectFile.Multiselect = true;
            this.dlgSelectFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgSelectFile_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgSelectPdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectPdf;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ListBox lbFileList;
        private System.Windows.Forms.OpenFileDialog dlgSelectFile;
    }
}

