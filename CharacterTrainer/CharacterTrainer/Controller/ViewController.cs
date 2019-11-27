using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterTrainer.Model.Activities;
using CharacterTrainer.Model.Rooms;
using CharacterTrainer;
using System.Drawing;

namespace CharacterTrainer.Controller
{
    class ViewController
    {

        private readonly Image gokuSprite  = Image.FromFile(@"Resources\images\goku\sprite.png");
        private Point movingPicturePosition = new Point(200, 200);

        private GameForm gameForm;


        public Point MovingPicturePosition { get => movingPicturePosition; set => movingPicturePosition = value; }
        public Image GokuSprite => gokuSprite;
        public GameForm GameForm { get => gameForm; set => gameForm = value; }

        public ViewController()
        {
            this.gameForm = new GameForm();
            init();
        }

        public string GetActivity()
        {
            return "walk";
        }

        public void Finish()
        {
            Console.WriteLine("El programa termino");
        }

        public void init()
        {
            this.gameForm.bgImage.Paint += new System.Windows.Forms.PaintEventHandler(this.bgImage_Paint);
        }

        private void bgImage_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawImageUnscaled(gokuSprite, movingPicturePosition);
        }


    }
}
