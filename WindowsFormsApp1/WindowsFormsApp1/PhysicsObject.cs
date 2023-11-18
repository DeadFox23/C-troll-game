using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class PhysicsObject
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float VelocityY { get; set; }
        public float Gravity { get; set; }
        public float VelocityX { get; set; }
        public List<Control> AssociatedControls { get; set; } = new List<Control>();

        public PhysicsObject(float x, float y, float gravity)
        {
            X = x;
            Y = y;
            VelocityX = 0;
            VelocityY = 0;
            Gravity = gravity;

        }
        public void Update()
        {
            VelocityY += Gravity;
            Y += VelocityY;

            X += VelocityX;
        }
    }
}
