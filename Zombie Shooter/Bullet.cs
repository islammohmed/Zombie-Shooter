using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Zombie_Shooter
{
    internal class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;
        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public void mkBullet(Form form)
        {
            bullet.BackColor = System.Drawing.Color.Yellow;
            bullet.Size = new System.Drawing.Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();
            form.Controls.Add(bullet);
            timer.Interval = speed;
            timer.Tick += new EventHandler(BulletTimerEvent);
            timer.Start();
        }
        private void BulletTimerEvent(object sender ,EventArgs e)
        {
            if (direction == "left")
            {
                bullet.Left -= speed;
            }
            if (direction == "right")
            {
                bullet.Left += speed;
            }
            if (direction == "up")
            {
                bullet.Top -= speed;
            }
            if (direction == "down")
            {
                bullet.Top += speed;
            }
            if (bullet.Left < 10 || bullet.Left > 860 || bullet.Top < 10 || bullet.Top > 616)
            {
                timer.Stop();
                timer.Dispose();
                bullet.Dispose();
            }
        }
    }
}
