using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterTrainer
{
    public partial class FightForm : Form
    {

        private readonly Image gokuSprite;
        private Point movingPicturePosition = new Point(200, 200);

        public FightForm()
        {
            InitializeComponent();
            gokuSprite = Image.FromFile(@"Resources\images\goku\sprite.png");
        }

        private void bgImage_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawImageUnscaled(gokuSprite, movingPicturePosition);
        }

    }
}
