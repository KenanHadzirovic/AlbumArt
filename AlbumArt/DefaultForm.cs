using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumArt
{
    public partial class DefaultForm : Form
    {
        public static string DirectoryPath { get; set; } = "Source path...";
        public static List<string> ListOfFiles { get; set; }
        public static string ImagePath { get; set; }
        public static Image Image { get; set; }
        public DefaultForm()
        {
            InitializeComponent();
            ListOfFiles = new List<string>();
            RefreshValues();
        }

        private void RefreshValues()
        {
            textBoxPath.Text = DirectoryPath;
            listBox1.DataSource = ListOfFiles;
            pictureBox1.Image = Image;
        }

        private static void SetImages()
        {
            foreach(string image in ListOfFiles)
            {
                SetImage(image, Image);
            }
        }

        private static void SetImage(string path, Image image)
        {
            TagLib.File file = TagLib.File.Create(path);
            TagLib.Picture pic = new TagLib.Picture();
            pic.Type = TagLib.PictureType.FrontCover;
            pic.Description = "Cover";
            pic.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ms.Position = 0;
            pic.Data = TagLib.ByteVector.FromStream(ms);
            file.Tag.Pictures = new TagLib.IPicture[] { pic };
            file.Save();
            ms.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DirectoryPath = fbd.SelectedPath;
                    ListOfFiles = Directory.GetFiles(fbd.SelectedPath).ToList();
                }
            }
            RefreshValues();
        }

        private void textBoxPath_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void buttonApplyImage_Click(object sender, EventArgs e)
        {
            SetImages();
            MessageBox.Show("Cover art image applied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenBrowseImageDialog();
        }

        private void OpenBrowseImageDialog()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImagePath = openFileDialog1.FileName;
                Image = Image.FromFile(ImagePath);
                RefreshValues();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
