using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatProject
{
    public partial class Form1 : Form
    {
        public Painting paint = null;
        Point firstPoint = Point.Empty;
        Point secondPoint = Point.Empty;
        public sbyte counter = 0;

        public Form1()
        {
            InitializeComponent();
            paint = new Painting(pictureBox1.Size);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            catCountDown.Enabled = true;
        }

        private void catCountDown_Tick(object sender, EventArgs e)
        {
            if (counter == 120)
            {
                catCountDown.Enabled = false;
                if (saveFileCatDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
                {
                    paint.bitmap.Save(saveFileCatDialog.FileName);
                }
                MessageBox.Show(String.Format("Нарисованный тобой файл сохранен под именем: {0}",saveFileCatDialog.FileName));
                return;
            }
            counter++;            
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(paint.bitmap, Point.Empty);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            secondPoint = e.Location;

            if (firstPoint != Point.Empty)
            {
                paint.pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                paint.pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                paint.graphics.DrawLine(paint.pen, firstPoint, secondPoint);
                firstPoint = secondPoint;
            }
            this.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (firstPoint != Point.Empty)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    secondPoint = e.Location;
                    paint.pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    paint.pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    paint.graphics.DrawLine(paint.pen, firstPoint, secondPoint);
                    firstPoint = secondPoint;
                }
                this.Refresh();
            }
        }
    }
}
