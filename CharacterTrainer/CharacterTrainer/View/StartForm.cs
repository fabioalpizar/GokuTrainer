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
    public partial class StartForm : Form
    {

        private readonly Image gokuSprite;
        private Point movingPicturePosition = new Point(200, 200);

        public StartForm()
        {
            InitializeComponent();
<<<<<<< HEAD:CharacterTrainer/CharacterTrainer/View/StartForm.cs
=======
            new GameLogic(20, 12);
>>>>>>> b61da7b168cc79689831648b2b3cdd137a1664bb:CharacterTrainer/CharacterTrainer/View/Form1.cs
            gokuSprite = Image.FromFile(@"Resources\images\goku\sprite.png");
        }

        private void bgImage_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawImageUnscaled(gokuSprite, movingPicturePosition);
        }

    }
}
