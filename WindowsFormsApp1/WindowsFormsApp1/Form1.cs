using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Level1 gameLevel1;
        private List<PhysicsObject> physicsObjectsList;

        public Form1()
        {
            InitializeComponent();
            physicsObjectsList = new List<PhysicsObject>();
            physicsObjectsList.Add(new PhysicsObject(50, 50, 0.5f));
            

            gameLevel1 = new Level1();
            this.KeyPreview = true;

            
        }

        private void btOne_Click(object sender, EventArgs e)
        {
            txtTitleStartSeite.Text = "Oh wow!";
            ApplyPhysicsToObject(btOne);
            
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if(gameLevel1 == null || gameLevel1.IsDisposed)
            {
                gameLevel1 = new Level1();
                //gameLevel1.FormClosed += Level1_FormClosed;
            }

            gameLevel1.Show();
        }

        private void txtAusgabe_Click(object sender, EventArgs e)
        {
            
        }

        private void btStartGame_Click(object sender, EventArgs e)
        {
            txtTitleStartSeite.Text = "Oh no. Was nu?";
            ApplyPhysicsToObject(btStartGame);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float objectBounce = 1.0f;

            foreach (var obj in physicsObjectsList)
            {
                obj.Update();
                CheckCollisionWithEdges(obj, objectBounce);

                foreach (var contols in obj.AssociatedControls)
                {
                    contols.Location = new Point((int)obj.X, (int)obj.Y);
                }

            }
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                foreach(var obj in physicsObjectsList)
                {
                    obj.VelocityY = -5;
                }
                
            }
            if (e.KeyCode == Keys.D)
            {
                foreach (var obj in physicsObjectsList)
                {
                    obj.VelocityX =+ 5;
                }

            }
            else if (e.KeyCode == Keys.A)
            {
                foreach (var obj in physicsObjectsList)
                {
                    obj.VelocityX = -5;
                }

            }
        }
        private void ApplyPhysicsToObject(Control control)
        {
            PhysicsObject newObject = new PhysicsObject(control.Location.X, control.Location.Y, 0);
            newObject.AssociatedControls.Add(control);
            physicsObjectsList.Add(newObject);
        }

        private void CheckCollisionWithEdges(PhysicsObject physicsObject, float bounce)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            foreach (var obj in physicsObject.AssociatedControls)
            {
                // Check collision with the left and right edges
                if (physicsObject.X < 0)
                {
                    physicsObject.X = 0;
                    physicsObject.VelocityX = -physicsObject.VelocityX * bounce;
                }
                else if (physicsObject.X + obj.Width > formWidth)
                {
                    physicsObject.X = formWidth - obj.Width;
                    physicsObject.VelocityX = -physicsObject.VelocityX * bounce;
                }

                // Check collision with the top and bottom edges
                if (physicsObject.Y < 0)
                {
                    physicsObject.Y = 0;
                    physicsObject.VelocityY = -physicsObject.VelocityY * bounce;
                }
                else if (physicsObject.Y + obj.Height > formHeight)
                {
                    physicsObject.Y = formHeight - obj.Height;
                    physicsObject.VelocityY = -physicsObject.VelocityY * bounce;
                }
            }
        }

        private void AddPhysicsToObject(float x, float y, float velY)
        {
            PhysicsObject newObject = new PhysicsObject(x, y, velY);
            physicsObjectsList.Add(newObject);
        }
        
    }
}
