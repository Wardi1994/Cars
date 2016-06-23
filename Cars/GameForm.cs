using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class GameForm : Form
    {
        private Image testImage;

        private int imgPozX;
        private int imgPozY;

        public GameForm()
        {
            imgPozX = 10;
            imgPozY = 10;
            testImage = Image.FromFile(@"Images\test.png");
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
           
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(testImage, imgPozX, imgPozY);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Down)
            {
                imgPozX++;
            }
            imgPozX++;

            Invalidate();
        }
    }
}
