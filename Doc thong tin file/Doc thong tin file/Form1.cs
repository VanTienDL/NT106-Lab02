using System.Xml.Linq;
using System.IO;
using System.Drawing;

namespace Doc_thong_tin_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Giả sử bạn đã có một mảng byte[] chứa dữ liệu hình ảnh
            byte[] imageData = Properties.Resources.banner_uit; // Thay "TenHinhAnh" bằng tên hình ảnh trong Resources

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                pLogo.Image = Image.FromStream(ms);
            }

            // Tùy chỉnh PictureBox để hiển thị hình ảnh đúng tỉ lệ
            pLogo.SizeMode = PictureBoxSizeMode.Zoom; // Hoặc chọn Zoom, CenterImage tùy theo nhu cầu
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();// Mo mot tep tin ma ten no bi danh se la ofd
                ofd.Filter = "Text Files (*.txt)|*.txt";//File text moi duoc
                ofd.ShowDialog();//Chon tep, link cua no se dc luu trong thuoc tinh Filename cua ofd
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);//Tao mot luong cho ofd
                StreamReader sr = new StreamReader(fs);//Doc van ban tren luong fs cua ofd
                int lineCount = 0;
                while (sr.ReadLine() != null)
                {
                    lineCount++;
                }
                sr.BaseStream.Seek(0, SeekOrigin.Begin);//Dua con tro ve dau de doc lai tu dau
                string fileContent = sr.ReadToEnd();// Doc het noi dung ghi len Text cua fileContent
                tbOne.Text = fileContent;
                tbLine.Text = lineCount.ToString();
                tbName.Text = ofd.SafeFileName.ToString();
                tbURL.Text = fs.Name.ToString();
                // Hiển thị kích thước file
                FileInfo fileInfo = new FileInfo(ofd.FileName);
                tbSize.Text = fileInfo.Length.ToString() + " bytes";
                tbCha.Text = fileContent.Length.ToString();
                //Dem tu
                int wordCount = fileContent.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                tbWord.Text = wordCount.ToString();
                sr.Close();
                fs.Close();//Doc het roi thi dong luong lai khoi ton tai nguyen
            }
            catch(Exception ex)
            {
                MessageBox.Show("Oops, somethings went wrong", "Error or Bug", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
