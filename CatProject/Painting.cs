using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatProject
{
    public class Painting
    {
        public Painting(Size size)
        {
            this.size = size;
            bitmap = new Bitmap(size.Width, size.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
        }

        public Size size = Size.Empty;
        public Pen pen = new Pen(Color.Red, 5);
        public Bitmap bitmap = null;
        public Graphics graphics = null;
    }
}
