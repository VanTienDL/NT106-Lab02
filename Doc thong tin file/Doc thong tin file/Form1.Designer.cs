namespace Doc_thong_tin_file
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
            btnExit = new Button();
            label1 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbURL = new TextBox();
            tbSize = new TextBox();
            tbLine = new TextBox();
            tbWord = new TextBox();
            tbCha = new TextBox();
            tbOne = new RichTextBox();
            pLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(11, 412);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(170, 49);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read File ";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(187, 412);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(184, 49);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 116);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "File Name ";
            // 
            // tbName
            // 
            tbName.Location = new Point(116, 108);
            tbName.Name = "tbName";
            tbName.Size = new Size(338, 23);
            tbName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 163);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 4;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 224);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 5;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 278);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Lines Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 333);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 7;
            label5.Text = "Words Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 383);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 8;
            label6.Text = "Characters Count";
            // 
            // tbURL
            // 
            tbURL.Location = new Point(116, 219);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(338, 23);
            tbURL.TabIndex = 9;
            // 
            // tbSize
            // 
            tbSize.Location = new Point(116, 158);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(338, 23);
            tbSize.TabIndex = 10;
            // 
            // tbLine
            // 
            tbLine.Location = new Point(116, 273);
            tbLine.Name = "tbLine";
            tbLine.Size = new Size(338, 23);
            tbLine.TabIndex = 11;
            // 
            // tbWord
            // 
            tbWord.Location = new Point(116, 328);
            tbWord.Name = "tbWord";
            tbWord.Size = new Size(338, 23);
            tbWord.TabIndex = 12;
            // 
            // tbCha
            // 
            tbCha.Location = new Point(116, 378);
            tbCha.Name = "tbCha";
            tbCha.Size = new Size(338, 23);
            tbCha.TabIndex = 13;
            // 
            // tbOne
            // 
            tbOne.Location = new Point(474, 12);
            tbOne.Name = "tbOne";
            tbOne.Size = new Size(453, 449);
            tbOne.TabIndex = 14;
            tbOne.Text = "";
            // 
            // pLogo
            // 
            pLogo.Location = new Point(10, 12);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(458, 90);
            pLogo.TabIndex = 15;
            pLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(939, 464);
            Controls.Add(pLogo);
            Controls.Add(tbOne);
            Controls.Add(tbCha);
            Controls.Add(tbWord);
            Controls.Add(tbLine);
            Controls.Add(tbSize);
            Controls.Add(tbURL);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnRead);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Button btnExit;
        private Label label1;
        private TextBox tbName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbURL;
        private TextBox tbSize;
        private TextBox tbLine;
        private TextBox tbWord;
        private TextBox tbCha;
        private RichTextBox tbOne;
        private PictureBox pLogo;
    }
}
