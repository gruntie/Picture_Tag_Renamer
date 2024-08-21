using System.Collections.Specialized;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DanbooruNameTagger
{
    public partial class MainForm : Form
    {
        private bool IsFileMode = false;
        private bool IsFolderMode = false;
        private string FilePath = string.Empty;
        //private List<string> Files = new List<string>();
        private string[] Files = new string[0];
        private int FilePointer = 0;

        List<string> tags = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            LoadAutocompleteSource();
        }

        #region CUSTOM_FUNCTIONS
        public void LoadAutocompleteSource()
        {
            if (!File.Exists("tags.txt"))
            {
                Application.Exit();
            }

            string[] lines = File.ReadLines("tags.txt").ToArray();
            var source = new AutoCompleteStringCollection();

            tags = new List<string>(lines);
            source.AddRange(lines);
            tagSearch.AutoCompleteCustomSource = source;
            tagSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tagSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.C))
            {
                Clipboard.SetText(composedName.Text);
                return true;
            }

            if (keyData == Keys.Left)
            {
                btnPicturePrevious_Click(keyData, new EventArgs());
            }

            if (keyData == Keys.Right)
            {
                btnPictureNext_Click(keyData, new EventArgs());
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void SetComposedName(string separator)
        {
            string tempComposed = string.Empty;

            if (tagList.Items.Count > 0)
            {
                foreach (var item in tagList.Items)
                {
                    tempComposed += item.ToString() + separator;
                }
            }
            else
            {
                tempComposed = "-";
            }

            composedName.Text = tempComposed;
            SetLabelNewName();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureViewer.Width, pictureViewer.Height);
            pictureViewer.DrawToBitmap(bm, new Rectangle(0, 0, pictureViewer.Width, pictureViewer.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        public void SetLabelNewName()
        {
            if (string.IsNullOrEmpty(composedName.Text))
            {
                return;
            }

            string filename = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
            var match = Regex.Match(filename, @"^[A-z0-9]*\s");

            if (filename.Contains("__"))
            {
                filename = filename.Replace("__", "__" + composedName.Text);
                labelNewName.Text = filename;
            }
            else if (match.Success)
            {
                filename = filename.Insert(match.Value.Length, composedName.Text);
                labelNewName.Text = filename;
            }
            else
            {
                filename = composedName.Text + " " + filename;
                labelNewName.Text = filename;
            }
        }

        public void ClearNamingControls()
        {
            tagList.Items.Clear();
            composedName.Text = string.Empty;

            if (!IsFolderMode && !IsFileMode)
            {
                labelCurrentName.Text = "-";
                labelNewName.Text = "-";
            }
            else
            {
                labelCurrentName.Text = labelNewName.Text = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
            }
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void tagSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(tagSearch.Text))
                {
                    if (tags.Contains(tagSearch.Text))
                    {
                        tagList.Items.Add(tagSearch.Text);
                    }
                    tagSearch.Text = string.Empty;
                }
            }
        }

        private void tagList_DoubleClick(object sender, EventArgs e)
        {
            if (tagList.SelectedItem != null)
            {
                tagList.Items.Remove(tagList.SelectedItem);
            }
        }

        private void tagList_ItemsChanged(object sender, EventArgs e)
        {
            if (nameSpacesCheck.Checked)
            {
                SetComposedName(" ");
            }
            else
            {
                SetComposedName("_");
            }
        }

        private void nameSpacesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (nameSpacesCheck.Checked)
            {
                SetComposedName(" ");
            }
            else
            {
                SetComposedName("_");
            }
        }

        private void btnComposedNameCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(composedName.Text);
        }

        private void openPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearNamingControls();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog.Filter = "Picture Files|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK && File.Exists(openFileDialog.FileName))
            {
                FilePath = openFileDialog.FileName;

                byte[] buffer = new byte[16];
                int bytesRead = 0;
                using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                {
                    bytesRead = fs.Read(buffer, 0, buffer.Length);
                    fs.Close();
                }
                string filename = openFileDialog.SafeFileName;
                string mime = MimeType.GetMimeType(buffer, filename);

                if (Util.pictures.Contains(mime))
                {
                    IsFileMode = true;
                    IsFolderMode = false;
                    if (pictureViewer.Image != null)
                    {
                        pictureViewer.Image.Dispose();
                    }
                    pictureViewer.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureViewer.Image = Image.FromFile(FilePath);

                    labelCurrentName.Text = filename;
                    labelNewName.Text = filename;
                }
                else
                {
                    IsFileMode = false;
                    IsFolderMode = false;
                    MessageBox.Show("Selected file is not a picture.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearNamingControls();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
            {
                IsFileMode = false;
                IsFolderMode = true;

                try
                {
                    Files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.*", SearchOption.TopDirectoryOnly);
                    byte[] buffer = new byte[16];
                    int bytesRead = 0;
                    string filename = string.Empty;

                    foreach (string file in Files)
                    {
                        //buffer = File.ReadAllBytes(file);
                        using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                        {
                            bytesRead = fs.Read(buffer, 0, buffer.Length);
                            fs.Close();
                        }
                        filename = file.Split('\\')[file.Split('\\').Length - 1];
                        string mime = MimeType.GetMimeType(buffer, filename);

                        if (!Util.pictures.Contains(mime))
                        {
                            Files = Files.Except(new string[] { file }).ToArray();
                        }
                    }

                    FilePath = Files[FilePointer];
                    filename = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
                    if (pictureViewer.Image != null)
                    {
                        pictureViewer.Image.Dispose();
                    }
                    pictureViewer.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureViewer.Image = Image.FromFile(Files[FilePointer]);
                    labelCurrentName.Text = filename;
                    labelNewName.Text = filename;
                }
                catch (Exception ex)
                {
                    IsFileMode = false;
                    IsFolderMode = false;
                    Files = new string[0];
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPicturePrevious_Click(object sender, EventArgs e)
        {
            string filename = string.Empty;

            if (IsFolderMode)
            {
                FilePointer--;

                if (FilePointer < 0)
                {
                    FilePointer = Files.Length - 1;
                }

                FilePath = Files[FilePointer];
                if (pictureViewer.Image != null)
                {
                    pictureViewer.Image.Dispose();
                }
                pictureViewer.SizeMode = PictureBoxSizeMode.Zoom;
                pictureViewer.Image = Image.FromFile(Files[FilePointer]);
                filename = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
                labelCurrentName.Text = filename;
                labelNewName.Text = filename;

                ClearNamingControls();
            }
        }

        private void btnPictureNext_Click(object sender, EventArgs e)
        {
            string filename = string.Empty;

            if (IsFolderMode)
            {
                FilePointer++;

                if (FilePointer >= Files.Length)
                {
                    FilePointer = 0;
                }

                FilePath = Files[FilePointer];
                if (pictureViewer.Image != null)
                {
                    pictureViewer.Image.Dispose();
                }
                pictureViewer.SizeMode = PictureBoxSizeMode.Zoom;
                pictureViewer.Image = Image.FromFile(Files[FilePointer]);
                filename = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
                labelCurrentName.Text = filename;
                labelNewName.Text = filename;

                ClearNamingControls();
            }
        }

        private void btnPictureZoomReset_Click(object sender, EventArgs e)
        {
            if (pictureViewer.Image != null)
            {
                pictureViewer.Image.Dispose();
                pictureViewer.SizeMode = PictureBoxSizeMode.Zoom;
                pictureViewer.Image = Image.FromFile(FilePath);
                pictureViewer.Refresh();
            }
        }

        private void btnPictureZoomOut_Click(object sender, EventArgs e)
        {
            if (pictureViewer.Image != null)
            {
                pictureViewer.SizeMode = PictureBoxSizeMode.CenterImage;

                int newWidth = pictureViewer.Image.Width - (int)Math.Round(pictureViewer.Image.Width * 0.1);
                int newHeight = pictureViewer.Image.Height - (int)Math.Round(pictureViewer.Image.Height * 0.1);
                Size newSize = new Size(newWidth, newHeight);
                Image temp = pictureViewer.Image;
                ImageFormat format = format = MimeType.GetImageFormat(ref temp);
                MemoryStream ms = new MemoryStream();

                if (pictureViewer.Image != null)
                {
                    temp.Dispose();
                    pictureViewer.Image.Dispose();
                }

                if (newSize.Width <= 0 || newSize.Height <= 0)
                {
                    return;
                }

                /*Bitmap bm = new Bitmap(Image.FromFile(FilePath), newSize);
                Graphics g = Graphics.FromImage(bm);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;*/

                using (Bitmap bm = new Bitmap(Image.FromFile(FilePath), newSize))
                {
                    Graphics g = Graphics.FromImage(bm);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    GC.Collect();

                    Image image = (Image)bm;
                    image.Save(ms, format);
                    g.Dispose();
                }

                pictureViewer.Image = Image.FromStream(ms);
            }
        }

        private void btnPictureZoomIn_Click(object sender, EventArgs e)
        {
            if (pictureViewer.Image != null)
            {
                pictureViewer.SizeMode = PictureBoxSizeMode.CenterImage;
                int newWidth = pictureViewer.Image.Width + (int)Math.Round(pictureViewer.Image.Width * 0.1);
                int newHeight = pictureViewer.Image.Height + (int)Math.Round(pictureViewer.Image.Height * 0.1);
                Size newSize = new Size(newWidth, newHeight);
                Image temp = pictureViewer.Image;
                ImageFormat format = format = MimeType.GetImageFormat(ref temp);
                //ImageFormat format = MimeType.GetImageFormat(FilePath);
                MemoryStream ms = new MemoryStream();

                if (pictureViewer.Image != null)
                {
                    temp.Dispose();
                    pictureViewer.Image.Dispose();
                }

                using (Bitmap bm = new Bitmap(Image.FromFile(FilePath), newSize))
                {
                    Graphics g = Graphics.FromImage(bm);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                    GC.Collect();

                    Image image = (Image)bm;
                    image.Save(ms, format);
                    g.Dispose();
                }

                pictureViewer.Image = Image.FromStream(ms);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureViewer.Image != null)
            {
                PrintDialog ptdg = new PrintDialog();
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += Doc_PrintPage;
                ptdg.Document = doc;

                if (ptdg.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                }
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath) || labelCurrentName.Text.Equals(labelNewName.Text)) return;

            string newfilename = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
            newfilename = FilePath.Replace(newfilename, labelNewName.Text);

            try
            {
                if (File.Exists(newfilename))
                {
                    File.Delete(newfilename);
                }

                //pictureViewer.Image = null;
                if (pictureViewer.Image != null)
                {
                    pictureViewer.Image.Dispose();
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();

                File.Move(FilePath, newfilename);
                FilePath = newfilename;

                if (IsFolderMode)
                {
                    Files[FilePointer] = FilePath;
                }

                ClearNamingControls();
                pictureViewer.Image = Image.FromFile(FilePath);
                labelCurrentName.Text = labelNewName.Text = FilePath.Split('\\')[FilePath.Split('\\').Length - 1];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't change file name.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearNamingControls();
        }
    }
}
