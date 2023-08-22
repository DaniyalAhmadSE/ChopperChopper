using System.Drawing;
using System.Windows.Forms;

namespace ChopperChopper.Models
{
    class Chopper : PictureBox
    {
        public Chopper()
        {
            this.Height = 30;
            this.Width = 50;
        }

        public bool IsDirectionUp { get; set; } = false;
        public int Speed { get; set; } = 5;

        public void MoveChopper()
        {
            Point p = this.Location;

            if (IsDirectionUp)
            {
                p.Y -= this.Speed;
            }
            else
            {
                p.Y += this.Speed;
            }

            this.Location = p;
        }
    }
}
