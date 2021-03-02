using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace C20_Ex01_Ron_204464127_Tomer_312500937
{
    public class PicturesBoxAdditionalsProxy : PictureBox
    {
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Height += 100;
            this.Width += 100;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Height -= 100;
            this.Width -= 100;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
            Image flipImage = this.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            this.Image = flipImage;
        }

    }
}

