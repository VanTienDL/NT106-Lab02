using System.IO;
using System.Drawing;
namespace Doc_va_Ghi_FIle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            {
                // Giả sử bạn đã có một mảng byte[] chứa dữ liệu hình ảnh
                byte[] imageData = Properties.Resources.logoUIT; // Thay "TenHinhAnh" bằng tên hình ảnh trong Resources

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pLogo.Image = Image.FromStream(ms);
                }

                // Tùy chỉnh PictureBox để hiển thị hình ảnh đúng tỉ lệ
                pLogo.SizeMode = PictureBoxSizeMode.Zoom; // Hoặc chọn Zoom, CenterImage tùy theo nhu cầu
            }

        }
        
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();// Mo mot tep tin ma ten no bi danh se la ofd
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";//Open file text thoi
                ofd.ShowDialog();//Chon tep, link cua no se dc luu trong thuoc tinh Filename cua ofd
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);//Tao mot luong cho ofd
                StreamReader sr = new StreamReader(fs);//Doc van ban tren luong fs cua ofd
                string fileContent = sr.ReadToEnd();// Doc het noi dung ghi len fileContent
                fs.Close();//Doc het roi thi dong luong lai khoi ton tai nguyen
                tbOne.Text = fileContent;
            }
            catch
            {
                MessageBox.Show("Loi phat sinh","Loi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string fileContent = tbOne.Text;
                tbOne.Clear();
                fileContent.ToUpper();
                SaveFileDialog sfd = new SaveFileDialog();
                //Giong voi OpenFileDialog, mot cai de mo, mot cai de luu, bi danh cai sap dc luu la sfd
                sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                //Day la nhung duoi file hop le dc luu, cai nay cx giong OpenFileDialog- se mo nhung duoi file hop le

                if (sfd.ShowDialog() == DialogResult.OK)//Neu nhan OK
                {
                    // Luong sw ghi file vao tep 
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.Write(fileContent);
                        // ghi noi dung cua fileContent vao
                    }
                    /*Chu thich:
                        - Day la mot cai kieu khac de tao luong va thao tac tren luong ay voi file bi danh
                        - Cach tren StreamReader la minh lam thu cong 2 buoc:
                            + Buoc 1: Tao luong 
                                    FileStream fs = new...
                            + Buoc 2: Thao tac tren luong va file bi danh
                                    StreamReader sr = new...
                        - Con o day ta gom chung lai chu khong co gi kho hieu het, co che van vay, viet vay cho ngau thoi
                    */
                    // Thong bao la da ghi
                    MessageBox.Show("File saved successfully at: " + sfd.FileName);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Oops, somethings went wrong:{ ex.Message}","Error or Bug",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

