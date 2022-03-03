using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace image_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void openImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;
            }
        }

        void saveImage()
        {
            if (opened) {

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Image|*.png;*.bmp;*.jpeg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("No image loaded, first image upload");
            }
        }

        void filter2 ()
        {
            if (!opened)
            {
                MessageBox.Show("Open the image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted =new Bitmap(img.Width, img.Height);

                ImageAttributes ia= new ImageAttributes();
                ColorMatrix cm= new ColorMatrix(new float[][]
                {
                    new float[] {.393f,.349f+0.5f,.272f, 0,0},
                    new float[] {.769f+0.3f,.686f,.534f,0,0},
                    new float[] {.189f,.168f,.131f+0.5f,0,0},
                    new float[] { 0,0,0,1,0},
                    new float[] {0,0,0,0,1 }
                }  
                  );
                ia.SetColorMatrix(cm);
                Graphics g= Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0,0,img.Width,img.Height),0,0,img.Width,img.Height, GraphicsUnit.Pixel,ia);

            g.Dispose();
                pictureBox1.Image=bmpInverted;

            }
        }


        void filter3()
        {
            if (!opened)
            {
                MessageBox.Show("Open the image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {.299f,.299f,.299f, 0,0},
                    new float[] {.587f,.587f,.587f,0,0},
                    new float[] {.114f,.114f,.114f,0,0},
                   new float[] { 0,0,0,1,0},
                   new float[] {0,0,0,0,1 }
                }
                  );
                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }


        void filter4()
        {
            if (!opened)
            {
                MessageBox.Show("Open the image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {1+0.3f,0,0, 0,0},
                    new float[] {0,1+0.7f,0,0,0},
                    new float[] {0,0,1+1.3f,0,0},
                   new float[] { 0,0,0,1,0},
                   new float[] {0,0,0,0,1 }
                }
                  );
                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }


        void filter5()
        {
            if (!opened)
            {
                MessageBox.Show("Open the image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {1+0.9f,0,0, 0,0},
                    new float[] {0,1+1.5f,0,0,0},
                    new float[] {0,0,1+1.3f,0,0},
                   new float[] { 0,0,0,1,0},
                   new float[] {0,0,0,0,1 }
                }
                  );
                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }

        void filter6()
        {
            if (!opened)
            {
                MessageBox.Show("Open the image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {1+0.3f,0,0, 0,0},
                    new float[] {0,1+0f,0,0,0},
                    new float[] {0,0,1+5f,0,0},
                   new float[] { 0,0,0,1,0},
                   new float[] {0,0,0,0,1 }
                }
                  );
                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }





        void hue()
        {
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {1,0,(redbar.Value),0,0,0},
                    new float[] {0,1,0,0,0},
                    new float[] {0,0,0,0,0},
                    new float[] { 0,0,0,1,0},
                    new float[] {0,0,0,0,1}
                });

                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }

        void contrast()
            {
            float cont = 0;
            cont = 0.2f * greenbar.Value;
               Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {cont,0f,0f,0f,0f},
                    new float[] {0f,cont,0f,0f,0f},
                    new float[] {0f,0f,cont,0f,0f},
                    new float[] { 0f,0f,0f,1f,0f},
                    new float[] {0.001f,0.001f,0.001f,0f,1f}
                });

                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;
        }


        void bright()
        
            {
                Image img = pictureBox1.Image;
            float fvalue = bluebar.Value / 50f;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {1,0,0,0,0},
                    new float[] {0,1,0,0,0},
                    new float[] {0,0,0,0,0},
                    new float[] { 0,0,0,0,0},
                    new float[] {fvalue,fvalue,fvalue,1,1}
                });

                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        

        void reload()
        {
            if (!opened)
            {

            }
            else
            {
                if (opened)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image= file;
                    opened = true;
                }
            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)         
        {

        }
        Image file;
        Boolean opened = false;  // to check whether image is open in picture box not
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            openImage();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            redbar.Value = 0;
            greenbar.Value = 0;
            bluebar.Value = 0;
            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reload();
            filter2();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            reload();
            hue();
        }

        private void greenbar_ValueChanged(object sender, EventArgs e)
        {
            reload();
            contrast();
        }

        private void bluebar_ValueChanged(object sender, EventArgs e)
        {
            reload();
            bright();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reload();
            filter3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reload();
            filter4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reload();
            filter5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reload();
            filter6();
        }
    }
}
