using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace ResizEasy

{
    public partial class MainForm : Form
    {

        public List<int> allResults = new List<int>();
        private bool checkSelectedImage = false;

        private void CheckNewSize(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == false)
            {
                foreach (var i in this.allResults)
                {
                    int x = int.Parse(checkBox.Text);
                    if (i == x)
                    {
                        Console.WriteLine(x);
                        allResults.Remove(x);
                        return;
                    }
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            CheckBox NewSize = new CheckBox()
            {
                Text = "100",
                BackColor = Color.FromArgb(63, 63, 70),
                Checked = true,
                ForeColor = Color.FromArgb(174, 185, 185),
                Margin = new Padding(5, 5, 5, 5),
                Padding = new Padding(5, 5, 5, 5),
                Width = 100,
                Height = 33,
                TextAlign = ContentAlignment.MiddleCenter,
                FlatStyle = FlatStyle.Flat,
            };
            NewSize.CheckedChanged += new EventHandler(CheckNewSize);

            this.DefaultCheckBox.Controls.Add(NewSize);
            this.allResults.Add(100);
        }

        // Выбор изображения
        private void SelectPicture_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PNG Format|*.png|JPG Format|*.jpg"; // All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    this.checkSelectedImage = true;

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            SelectPicture.Image = Image.FromFile(filePath);

            // Изменяем размеры основной формы
            this.Width = 298;
            this.Height = 238;
        }

        private void DefaultCheckBox_Click(object sender, EventArgs e)
        {

            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == false)
            {
                foreach (var i in this.allResults)
                {
                    int x = int.Parse(checkBox.Text);
                    if (i == x)
                    {
                        Console.WriteLine(x);
                        allResults.Remove(x);
                        return;
                    }
                }
            }
        }

        // Получение текста из input
        public string GetFromTextBox(string tbName)
        {
            TextBox? textBox = this.Controls.Find(tbName, true).FirstOrDefault() as TextBox;
            return textBox?.Text ?? "";
        }

        private void InputNewSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Создание нового чек бокса если пользователь ввел число =)
                string newSize = GetFromTextBox("InputNewSize");
                int res = int.Parse(newSize);

                foreach (var i in this.allResults)
                {
                    if (i == res)
                    {
                        InputNewSize.Text = "";
                        return;
                    }
                }
            }
            catch
            {
                InputNewSize.Text = "";
            }
        }

        private void AppendNewSizeButton_Click(object sender, EventArgs e)
        {
                // Создание нового чек бокса если пользователь ввел число =)
                string newSize = GetFromTextBox("InputNewSize");

                int res = int.Parse(newSize);

                foreach (var i in this.allResults)
                {
                    if (i == res)
                    {
                        return;
                    }
                }

                CheckBox NewSize = new CheckBox()
                {
                    Text = newSize,
                    BackColor = Color.FromArgb(63, 63, 70),
                    Checked = true,
                    ForeColor = Color.FromArgb(174, 185, 185),
                    Margin = new Padding(5, 5, 5, 5),
                    Padding = new Padding(5, 5, 5, 5),
                    Width = 100,
                    Height = 33,
                    TextAlign = ContentAlignment.MiddleCenter,
                    FlatStyle = FlatStyle.Flat,
                };
                NewSize.CheckedChanged += new EventHandler(CheckNewSize);

                this.ResultsPanel.Controls.Add(NewSize);
                this.allResults.Add(res);
        }

        private void DefaultCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckNewSize(sender, e);
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (checkSelectedImage)
            {

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.InitialDirectory = "c:\\";
                    saveFileDialog.Filter = "PNG Format|*.png|JPG Format|*.jpg"; // All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = "ResizEasy";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if(Path.GetDirectoryName(saveFileDialog.FileName) != null)
                        {
                            string newPath = Path.GetDirectoryName(saveFileDialog.FileName);

                            foreach (var i in this.allResults)
                            {
                                System.Drawing.Image myNewImg = ScaleImage(this.SelectPicture.Image, i, i);
                                myNewImg.Save(newPath+"\\"+i+"px.png", System.Drawing.Imaging.ImageFormat.Png);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the image");
            }
        }

        static Image ScaleImage(Image source, int width, int height)
        {

            Image dest = new Bitmap(width, height);
            using (Graphics gr = Graphics.FromImage(dest))
            {
                gr.FillRectangle(Brushes.White, 0, 0, width, height);  // Очищаем экран
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                float srcwidth = source.Width;
                float srcheight = source.Height;
                float dstwidth = width;
                float dstheight = height;

                if (srcwidth <= dstwidth && srcheight <= dstheight)  // Исходное изображение меньше целевого
                {
                    int left = (width - source.Width) / 2;
                    int top = (height - source.Height) / 2;
                    gr.DrawImage(source, left, top, source.Width, source.Height);
                }
                else if (srcwidth / srcheight > dstwidth / dstheight)  // Пропорции исходного изображения более широкие
                {
                    float cy = srcheight / srcwidth * dstwidth;
                    float top = ((float)dstheight - cy) / 2.0f;
                    if (top < 1.0f) top = 0;
                    gr.DrawImage(source, 0, top, dstwidth, cy);
                }
                else  // Пропорции исходного изображения более узкие
                {
                    float cx = srcwidth / srcheight * dstheight;
                    float left = ((float)dstwidth - cx) / 2.0f;
                    if (left < 1.0f) left = 0;
                    gr.DrawImage(source, left, 0, cx, dstheight);
                }

                return dest;
            }
        }
    }
}