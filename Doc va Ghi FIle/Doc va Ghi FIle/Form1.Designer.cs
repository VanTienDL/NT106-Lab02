namespace Doc_va_Ghi_FIle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRead = new Button();
            btnWrite = new Button();
            tbOne = new RichTextBox();
            pLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(12, 222);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(171, 81);
            btnRead.TabIndex = 0;
            btnRead.Text = "READ FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(12, 328);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(171, 79);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "WRITE FILE";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // tbOne
            // 
            tbOne.Location = new Point(208, 12);
            tbOne.Name = "tbOne";
            tbOne.Size = new Size(580, 426);
            tbOne.TabIndex = 2;
            tbOne.Text = "";
            // 
            // pLogo
            // 
            pLogo.Location = new Point(12, 12);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(190, 180);
            pLogo.TabIndex = 3;
            pLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pLogo);
            Controls.Add(tbOne);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "Form1";
            Text = "Read and Write";
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private RichTextBox tbOne;
        private PictureBox pLogo;
    }
}
