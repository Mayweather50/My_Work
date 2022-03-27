using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : Window
    {
       
        public Users()
        {
            InitializeComponent();

         

        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            //if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //       imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
            //}
        }


        SqlConnection sqlConnection;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sqlConnection = new SqlConnection("Data Source=DESKTOP-ER355JS;Initial Catalog=Download;Integrated Security=True");
            sqlConnection.Open();

            byte[] image = null;


        }


        private byte[] _imageBytes = null;

        // Browse for an image on your computer
        private void BrowseButton_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = false,
                Filter = "Images (*.jpg,*.png)|*.jpg;*.png|All Files(*.*)|*.*"
            };

            if (dialog.ShowDialog() != true) { return; }

            ImagePath.Text = dialog.FileName;
            MyImage.Source = new BitmapImage(new Uri(lImagePath.Text));

            using (var fs = new FileStream(ImagePath.Text, FileMode.Open, FileAccess.Read))
            {
                _imageBytes = new byte[fs.Length];
                fs.Read(imgBytes, 0, System.Convert.ToInt32(fs.Length));
            }
        }

        // Save the selected image to your database
        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(ImagePath.Text))
            {
                var db = new MyDataContext();
                var uploadedImg = new UploadedImage
                {
                    ImageID = 0,
                    ImageContent = _imageBytes,
                    ImageName = ImagePath.Text
                };

                db.UploadedImages.InsertOnSubmit(uploadedImg);
                db.SubmitChanges();
            }
        }

        // Load an image from the database
        private void LoadButton_OnClick(object sender, RoutedEventArgs e)
        {
            // Load 1 image from the database and display it
            var db = new ImageInDatabaseDataContext();
            var img = (from el in db.UploadedImages
                       select el).FirstOrDefault();


            if (img != null)
            {
                // Display the loaded image
                ImageFile.Source = new BitmapImage(new Uri(img.ImageName));
            }
        }
    }
}
