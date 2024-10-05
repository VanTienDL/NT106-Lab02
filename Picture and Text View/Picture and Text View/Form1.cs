using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Picture_and_Text_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAllValidDirectories();
            // Kết nối sự kiện nhấp đúp chuột cho TreeView
            treeView1.NodeMouseDoubleClick += treeViewFiles_NodeMouseDoubleClick;
        }

        // Nạp tất cả ổ đĩa và thư mục hợp lệ (chứa file txt và hình ảnh)
        private void LoadAllValidDirectories()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    TreeNode rootNode = new TreeNode(drive.Name);
                    rootNode.Tag = drive.Name;

                    // Nạp các file và thư mục hợp lệ từ ổ đĩa
                    if (LoadValidFilesAndDirectories(new DirectoryInfo(drive.Name), rootNode))
                    {
                        treeView1.Nodes.Add(rootNode);
                    }
                }
            }
        }

        // Nạp các file và thư mục hợp lệ từ thư mục hiện tại
        private bool LoadValidFilesAndDirectories(DirectoryInfo directoryInfo, TreeNode parentNode)
        {
            bool hasValidFiles = false;

            try
            {
                // Kiểm tra file hợp lệ trong thư mục hiện tại
                foreach (var file in directoryInfo.GetFiles())
                {
                    if (IsValidFileType(file.FullName))
                    {
                        TreeNode fileNode = new TreeNode(file.Name);
                        fileNode.Tag = file.FullName;
                        parentNode.Nodes.Add(fileNode);
                        hasValidFiles = true; // Có ít nhất một file hợp lệ
                    }
                }

                // Kiểm tra thư mục con
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    TreeNode dirNode = new TreeNode(directory.Name);
                    dirNode.Tag = directory.FullName;

                    // Đệ quy nạp các file và thư mục con hợp lệ
                    if (LoadValidFilesAndDirectories(directory, dirNode))
                    {
                        parentNode.Nodes.Add(dirNode);
                        hasValidFiles = true; // Có ít nhất một thư mục con hợp lệ
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                // Bỏ qua các thư mục không có quyền truy cập
                Console.WriteLine($"Không thể truy cập vào: {directoryInfo.FullName}. Chi tiết lỗi: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Bắt lỗi chung
                Console.WriteLine($"Lỗi xảy ra khi truy cập: {directoryInfo.FullName}. Chi tiết lỗi: {ex.Message}");
            }

            // Trả về true nếu thư mục này hoặc các thư mục con của nó chứa file hợp lệ
            return hasValidFiles;
        }

        // Kiểm tra xem file có phải là định dạng hợp lệ không
        private bool IsValidFileType(string filePath)
        {
            string[] validExtensions = { ".txt", ".jpg", ".jpeg", ".png", ".bmp" };
            string extension = Path.GetExtension(filePath).ToLower();
            return validExtensions.Contains(extension);
        }

        // Hiển thị nội dung file
        private void ShowFileContent(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            if (extension == ".txt")
            {
                ShowTextFile(filePath);
            }
            else if (extension == ".jpg" || extension == ".png" || extension == ".bmp" || extension == ".jpeg")
            {
                ShowImage(filePath);
            }
            else
            {
                MessageBox.Show("Không hỗ trợ định dạng file này.");
            }
        }

        // Hiển thị nội dung file văn bản
        private void ShowTextFile(string filePath)
        {
            tbOne.Visible = true;
            pbOne.Visible = false;
            tbOne.Text = File.ReadAllText(filePath);
        }

        // Hiển thị nội dung file ảnh
        private void ShowImage(string filePath)
        {
            tbOne.Visible = false;
            pbOne.Visible = true;
            pbOne.Image = Image.FromFile(filePath);
        }

        // Sự kiện nhấp đúp chuột trên TreeView
        private void treeViewFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            if (File.Exists(path))
            {
                // Hiển thị nội dung file khi người dùng nhấp vào file
                ShowFileContent(path);
            }
        }
    }
}
