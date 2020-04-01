using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_beta
{
    public partial class project : Form
    {
        private bool step1 = false;
        private bool alive = true;
        private bool jumped = false;
        private bool jumpedAlready = false;
        private bool enemyAlive = true;
        int characterWidth = 120;
        int characterHeight = 270;
        Brush brushBricks;
        Rectangle[] rectangles = new Rectangle[4];
        int multiplier = 1;

        public project()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(project_KeyDown);
            this.MouseClick += new MouseEventHandler(project_MouseClick);
            this.KeyPress += new KeyPressEventHandler(project_KeyPress);
            healthbar.Maximum = 5;
            healthbar.Value= 5;
            healthbar.Step = -1;
            //potion: healthbar.Value+=1; vagy healthbar.Value=5

            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += timer1_Tick;
        }

        private void project_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!alive)
            {
                return;
            }
            int x = character.Location.X;
            int y = character.Location.Y;
            if (e.KeyChar.Equals(Keys.Space)) 
            {
                character.Image = project_beta.Properties.Resources.DagothJump;
                y -= 60;
                x += 10;
                System.Threading.Thread.Sleep(100);
                character.Location = new Point(x, y);
                character.Refresh();
            
            }
        }

        

        private void project_KeyDown(object sender, KeyEventArgs e)
        { 
            if(!alive)
            {
                return;
            }
            int x = character.Location.X;
            int y = character.Location.Y;
            if (e.KeyCode.Equals(Keys.D))
            {
                for (int i = 0; i < rectangles.Length; i++)
                {
                    if ((rectangles[i].Left <= x + characterWidth + 10 && rectangles[i].Right >= x + characterWidth + 10
                        && rectangles[i].Top <= y + characterHeight && rectangles[i].Bottom >= y + characterHeight))
                    {
                        return;
                    }
                }
                step1 = !step1;
                if (step1)
                {
                    character.Image = project_beta.Properties.Resources.DagothStep2;
                }
                else { character.Image = project_beta.Properties.Resources.DagothStep1; }
                x += 10;
                jumpedAlready = false;
            }
            else if (e.KeyCode.Equals(Keys.A))
            {
                for (int i = 0; i < rectangles.Length; i++)
                {
                    if ((rectangles[i].Left >= x + characterWidth + 10 && rectangles[i].Right <= x + characterWidth + 10
                        && rectangles[i].Top <= y + characterHeight && rectangles[i].Bottom >= y + characterHeight))
                    {
                        return;
                    }
                }
                step1 = !step1;
                if (step1)
                {
                   character.Image = project_beta.Properties.Resources.DagothStep2;
                }
                else { character.Image = project_beta.Properties.Resources.DagothStep1; }
                x -= 10;
                jumpedAlready = false;
            }
            else if(e.KeyCode.Equals(Keys.W)&& !jumpedAlready)
            {
                Jump(-150); jumpedAlready = true; return;
            }
            else if (e.KeyCode.Equals(Keys.S)&& !jumpedAlready)
            {
                  if(rectangles[0].Top<=y+characterHeight+150)
                    {
                    Jump(rectangles[0].Top - (y + characterHeight));return;
                    }
               
               Jump(150); jumpedAlready = true;return;
            }
            else if (e.KeyCode.Equals(Keys.C))
            {
                healthbar.PerformStep();
            }

            if (character.Location.X < potion.Location.X + 50 && character.Location.X+100 > potion.Location.X)
                healthbar.Value = 5;

            System.Threading.Thread.Sleep(100);
            character.Location = new Point(x, y);
            character.Refresh();
        }

        private void project_MouseClick(object sender, MouseEventArgs e)
        {
            if(alive)
            Attack();
        }

        private void background_MouseClick(object sender, MouseEventArgs e)
        {
            if (alive)
                Attack();
        }

        private void character_MouseClick(object sender, MouseEventArgs e)
        {
            if (alive)
                Attack();
        }

        private void Attack()
        {
            character.Image = project_beta.Properties.Resources.DagothAttack;
            character.Refresh();
            System.Threading.Thread.Sleep(150);
            character.Image = project_beta.Properties.Resources.DagothStep1;
            if (character.Location.X + 200 > enemy1.Location.X && character.Location.X < enemy1.Location.X)
            {
                enemyAlive = false;
                enemy1.Visible = false;
            }
        }
        private void Jump(int number)
        {
            int x = character.Location.X;
            int y = character.Location.Y;
            int cycle = number / 10;
            for (int i = 0; i < 10; i++)
            {
                jumped = !jumped;
                if (jumped)
                {
                    character.Image = project_beta.Properties.Resources.DagothJump1;
                }
                else
                {
                    character.Image = project_beta.Properties.Resources.DagothJump2;
                }
                y += cycle;
                System.Threading.Thread.Sleep(50);
                character.Location = new Point(x, y);
                character.Refresh();
            }

        }

        private void background_Paint(object sender, PaintEventArgs e)
        {
            rectangles[0] = new Rectangle(0, 600, 1000, 10);
            rectangles[1] = new Rectangle(300, 450, 200, 150);
            rectangles[2] = new Rectangle(400, 330, 200, 120);
            rectangles[3] = new Rectangle(600, 200, 100, 130);

            using (brushBricks = new SolidBrush(Color.Purple))
            {
                e.Graphics.FillRectangles(brushBricks, rectangles);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!enemyAlive) return;
            int x = enemy1.Location.X;
            int y = enemy1.Location.Y;
            x += (multiplier * 10);

            if(enemy1.Right>900)
            {
                multiplier = (-1);
            }
            else if (enemy1.Left<450)
            {
                multiplier = 1;
            }
            enemy1.Location = new Point(x, y);
            enemy1.Refresh();
            if (enemy1.Location.X < character.Location.X+100 && enemy1.Location.X+250 >character.Location.X) { healthbar.PerformStep();
                System.Threading.Thread.Sleep(2000); }
            if(healthbar.Value==0)
            {
                character.Image = project_beta.Properties.Resources.DagothDie2;
                alive = false;
            }
        }
    }
}
