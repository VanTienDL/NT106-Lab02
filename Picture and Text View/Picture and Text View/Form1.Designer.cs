namespace Picture_and_Text_View
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
            treeView1 = new TreeView();
            label1 = new Label();
            pbOne = new PictureBox();
            tbOne = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pbOne).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 11);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(190, 427);
            treeView1.TabIndex = 0;
           // treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(217, 11);
            label1.Name = "label1";
            label1.Size = new Size(555, 430);
            label1.TabIndex = 1;
            label1.Text = "File Content";
            // 
            // pbOne
            // 
            pbOne.Location = new Point(229, 38);
            pbOne.Name = "pbOne";
            pbOne.Size = new Size(526, 385);
            pbOne.SizeMode = PictureBoxSizeMode.Zoom;
            pbOne.TabIndex = 2;
            pbOne.TabStop = false;
            // 
            // tbOne
            // 
            tbOne.BorderStyle = BorderStyle.None;
            tbOne.Location = new Point(229, 38);
            tbOne.Name = "tbOne";
            tbOne.Size = new Size(526, 385);
            tbOne.TabIndex = 3;
            tbOne.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 450);
            Controls.Add(tbOne);
            Controls.Add(pbOne);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "File Viewer ";
            ((System.ComponentModel.ISupportInitialize)pbOne).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private Label label1;
        private PictureBox pbOne;
        private RichTextBox tbOne;
    }
}
