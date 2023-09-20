using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using System.IO;
namespace Face_Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ContainsFace(string imagePath)
        {
            using (var faceDetector = new CascadeClassifier("haarcascade_frontalface_default.xml"))
            using (var image = new Image<Bgr, byte>(imagePath))
            {
                var grayImage = image.Convert<Gray, byte>();
                var faces = faceDetector.DetectMultiScale(grayImage, 1.1, 3, Size.Empty);

                return faces.Length > 0;
            }
        }
        bool stop = false;

        private void DeleteImagesWithoutFaces(string sourceFolderPath, string destinationFolderPath)
        {
            var imagePaths = Directory.GetFiles(sourceFolderPath, "*.jpg");
            int totalImages = imagePaths.Length;
            int processedImages = 0;
            int noFace = 0;
            foreach (var imagePath in imagePaths)
            {
                if (!ContainsFace(imagePath))
                {
                    string destinationPath = Path.Combine(destinationFolderPath, Path.GetFileName(imagePath));
                    File.Move(imagePath, destinationPath);
                    noFace++;
                    LB_NOFACE.Text = noFace.ToString();
                }
                else if (stop) { return; }
                processedImages++;
                lb_SL.Text = processedImages.ToString();

                // Cập nhật tiến trình
                int progressPercentage = (int)((float)processedImages / totalImages * 100);
                notifyIcon.Text = $"Tiến trình: {progressPercentage}%";
                progressBar.Value = progressPercentage;
                Application.DoEvents(); // Cập nhật giao diện người dùng
            }
            //MessageBox.Show("Chuyển ảnh không có khuôn mặt thành công!");+
            btn_Stop.Visible = false;
            imgg_Success.Visible = true;
        }


        private void btn_Check_Click(object sender, EventArgs e)
        {
            string folderPath = txt_link.Text.ToString();
            string destinationFolderPath = txt_chuyen.Text.ToString();
            progressBar.Value = 0;
            btn_Stop.Visible = true;
            imgg_Success.Visible = false;
            DeleteImagesWithoutFaces(folderPath, destinationFolderPath);
        }

        // Hàm xóa ảnh nhỏ hơn kích thước 240x240
        public void DeleteSmallImages(string folderPath)
        {
            //Task.Run(() =>
            //{
                // Lấy danh sách các tệp tin ảnh trong thư mục
                string[] imageFiles = Directory.GetFiles(folderPath, "*.jpg");
                int sl = 0;
                foreach (string imagePath in imageFiles)
                {
                    using (Image image = Image.FromFile(imagePath))
                    {
                        // Kiểm tra kích thước ảnh
                        if (image.Width < 240 || image.Height < 240)
                        {
                            // Xóa ảnh nhỏ hơn 240x240
                            File.Delete(imagePath);
                        }
                    }
                    sl++;
                }
                MessageBox.Show($"Xoa Xong {sl.ToString()}!");
            //});
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string folderPath = txt_link.Text.ToString();
            DeleteSmallImages(folderPath);
        }
    }
}
