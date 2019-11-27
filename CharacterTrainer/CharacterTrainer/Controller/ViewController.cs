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
using CharacterTrainer.Model;

namespace CharacterTrainer.Controller
{
    class ViewController
    {

        private readonly Image gokuSprite = Image.FromFile(@"Resources\images\goku\sprite.png");
        private Image enemy = null;
        private Point movingPicturePosition = new Point(200, 200);
        private Boolean movingRight = true;
        private string currentActivity = "walk";
        private string currentItem = "select";

        private GameForm gameForm;
        private StartForm startForm;
        private FightForm fightForm;

        public Point MovingPicturePosition { get => movingPicturePosition; set => movingPicturePosition = value; }
        public Image GokuSprite => gokuSprite;
        public GameForm GameForm { get => gameForm; set => gameForm = value; }
        public string CurrentActivity { get => currentActivity; set => currentActivity = value; }
        public string CurrentItem { get => currentItem; set => currentItem = value; }
        public Image Enemy { get => enemy; set => enemy = value; }

        public ViewController()
        {
            this.gameForm = new GameForm();
            this.startForm = new StartForm();
            this.fightForm = new FightForm();
            init();
        }

        public string GetActivity()
        {
            return this.currentActivity;
        }

        public void Finish()
        {
            string message = "Your goku died lol";
            string title = "Game over!";
            MessageBox.Show(message, title);
            this.gameForm.Invoke(new Action(() =>  this.gameForm.Close()));
        }

        public void init()
        {
            this.gameForm.bgImage.Paint += new System.Windows.Forms.PaintEventHandler(this.bgImage_Paint);
            this.gameForm.houseImage.Click += new System.EventHandler(this.HouseImage_Click);
            this.gameForm.kitchenImage.Click += new System.EventHandler(this.KitchenImage_Click);
            this.gameForm.farmImage.Click += new System.EventHandler(this.FarmImage_Click);
            this.gameForm.gymImage.Click += new System.EventHandler(this.GymImage_Click);
            this.gameForm.toiletImage.Click += new System.EventHandler(this.ToiletImage_Click);
            this.gameForm.meditateImage.Click += new System.EventHandler(this.MeditateImage_Click);
            this.gameForm.runImage.Click += new System.EventHandler(this.RunImage_Click);
            this.gameForm.bagButton.Click += new System.EventHandler(this.BagButton_Click);
            this.gameForm.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.gameForm.bagComboBox.SelectedIndexChanged += new System.EventHandler(this.BagComboBox_SelectedIndexChanged);
        }

        public void bgImage_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawImageUnscaled(gokuSprite, movingPicturePosition);
            if (this.enemy != null)
            {
                g.DrawImageUnscaled(enemy, new Point(600,200));
            }
        }

        public void GymImage_Click(object sender, EventArgs e)
        {
            updateActivity("spar");
        }

        public void MeditateImage_Click(object sender, EventArgs e)
        {
            updateActivity("meditate");
        }

        public void ToiletImage_Click(object sender, EventArgs e)
        {
            updateActivity("poop");
        }

        public void KitchenImage_Click(object sender, EventArgs e)
        {
            updateActivity("consume");
        }

        public void FarmImage_Click(object sender, EventArgs e)
        {
            updateActivity("farm");
        }

        public void RunImage_Click(object sender, EventArgs e)
        {
            updateActivity("run");
        }

        public void HouseImage_Click(object sender, EventArgs e)
        {
            updateActivity("sleep");
        }

        public void BagButton_Click(object sender, EventArgs e)
        {
            switch (this.CurrentItem)
            {
                case "onion":
                    updateBagItem(@"Resources\images\items\onion.png");
                    break;
                case "carrot":
                    updateBagItem(@"Resources\images\items\carrot.png");
                    break;
                case "sensu":
                    updateBagItem(@"Resources\images\items\sensu.png");
                    break;
                case "4star":
                    updateBagItem(@"Resources\images\items\4star.png");
                    break;
                case "mushroom":
                    updateBagItem(@"Resources\images\items\mushroom.png");
                    break;
                case "watermelon":
                    updateBagItem(@"Resources\images\items\watermelon.png");
                    break;
                default:
                    updateBagItem(@"Resources\images\items\bag.png");
                    break;
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            saveLog();
            this.gameForm.Close();
        }

        public void updateCharInfo(Character c)
        {
            this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.nameLabel.Text = "Name: " + c.Name));
            this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.levelLabel.Text = "Level: " + c.Level));
            this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.energyLabel.Text = "Energy: " + c.Energy));
            this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.hpLabel.Text = "Hp: " + c.Hp));
            this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.happinessLabel.Text = "Happinnes: " + c.Happiness));
            this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.hungerLabel.Text = "Hunger: " + c.Hunger));
            this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.thirstLabel.Text = "Thirst: " + c.Thirst));
            this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.conditioLabel.Text = "Condition: " + c.Condition));
            this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.bagComboBox.Items.Clear()));
            this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.bagComboBox.Items.Add("select")));
            foreach (IConsumable i in c.Items)
            {
                this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.bagComboBox.Items.Add(i.Name)));
            }
        }

        public void updateOkAppearance(int level)
        {
            switch (level)
            {
                case 1:
                    this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.appearanceImage.Image = Image.FromFile(@"Resources\images\goku\goku1.png")));
                    break;
                case 2:
                    this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.appearanceImage.Image = Image.FromFile(@"Resources\images\goku\goku2.png")));
                    break;
                case 3:
                    this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.appearanceImage.Image = Image.FromFile(@"Resources\images\goku\goku3.png")));
                    break;
                case 4:
                    this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.appearanceImage.Image = Image.FromFile(@"Resources\images\goku\goku4.png")));
                    break;
                default:
                    this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.appearanceImage.Image = Image.FromFile(@"Resources\images\goku\goku5.png")));
                    break;
            }
        }

        public void updateConditionAppearance(string condition)
        {
            this.gameForm.conditioLabel.Invoke(new Action(() => this.gameForm.conditioLabel.Text = "Condition: " + condition));
            switch (condition)
            {
                case "beatup":
                    this.gameForm.appearanceImage.Invoke(new Action(() => this.gameForm.appearanceImage.Image = Image.FromFile(@"Resources\images\sickness\beatup.png")));
                    break;
                case "fat":
                    this.gameForm.appearanceImage.Invoke(new Action(() => this.gameForm.appearanceImage.Image = Image.FromFile(@"Resources\images\sickness\fat.png")));
                    break;
                case "sick":
                    this.gameForm.appearanceImage.Invoke(new Action(() => this.gameForm.appearanceImage.Image = Image.FromFile(@"Resources\images\sickness\sick.png")));
                    break;
                default:
                    this.gameForm.appearanceImage.Invoke(new Action(() => this.gameForm.appearanceImage.Image = Image.FromFile(@"Resources\images\sickness\tired.png")));
                    break;
            }
        }

        public void updateActivity(string activity)
        {
            this.currentActivity = activity;
            updateActivityLabel(activity);
            switch (activity)
            {
                case "meditate":
                    this.gameForm.statusImage.Invoke(new Action(() => this.gameForm.statusImage.Image = Image.FromFile(@"Resources\images\activites\meditate.png")));
                    break;
                case "farm":
                    this.gameForm.statusImage.Invoke(new Action(() => this.gameForm.statusImage.Image = Image.FromFile(@"Resources\images\activites\farm.png")));
                    break;
                case "consume":
                    if(this.currentItem == "select")
                    {
                        this.currentActivity = "walk";
                    }
                    else
                    {
                        this.gameForm.statusImage.Invoke(new Action(() => this.gameForm.statusImage.Image = Image.FromFile(@"Resources\images\activites\eat.gif")));
                    }
                    break;
                case "poop":
                    this.gameForm.statusImage.Invoke(new Action(() => this.gameForm.statusImage.Image = Image.FromFile(@"Resources\images\activites\toilet.jpg")));
                    break;
                case "run":
                    this.gameForm.statusImage.Invoke(new Action(() => this.gameForm.statusImage.Image = Image.FromFile(@"Resources\images\activites\run.gif")));
                    break;
                case "sleep":
                    this.gameForm.statusImage.Invoke(new Action(() => this.gameForm.statusImage.Image = Image.FromFile(@"Resources\images\activites\sleep.gif")));
                    break;
                case "friends":
                    this.gameForm.statusImage.Invoke(new Action(() => this.gameForm.statusImage.Image = Image.FromFile(@"Resources\images\activites\friends.png")));
                    break;
                case "spar":
                    this.gameForm.statusImage.Invoke(new Action(() => this.gameForm.statusImage.Image = Image.FromFile(@"Resources\images\activites\spar.gif")));
                    break;
                case "fight":
                    this.gameForm.statusImage.Invoke(new Action(() => this.gameForm.statusImage.Image = Image.FromFile(@"Resources\images\activites\fight.jpg")));
                    break;
                default:
                    this.gameForm.statusImage.Invoke(new Action(() => this.gameForm.statusImage.Image = Image.FromFile(@"Resources\images\activites\walk.jpg")));
                    break;
            }
        }

        public void updateStatusImage(string path)
        {
            this.gameForm.appearanceImage.Invoke(new Action(() => this.gameForm.appearanceImage.Image = Image.FromFile(path)));
        }

        public void updateBagItem(string path)
        {
            this.gameForm.itemImage.Invoke(new Action(() => this.gameForm.itemImage.Image = Image.FromFile(path)));
        }

        public void moveSprite(int speed)
        {
            if (this.movingPicturePosition.X > 500)
            {
                this.movingRight = false;
            } else if (this.movingPicturePosition.X < 200)
            {
                this.movingRight = true;
            }
            if (this.movingRight)
            {
                this.movingPicturePosition.X += speed;
            }
            else
            {
                this.movingPicturePosition.X -= speed;
            }
            this.gameForm.bgImage.Invoke(new Action(() => this.gameForm.bgImage.Invalidate()));
            this.gameForm.bgImage.Invoke(new Action(() => this.gameForm.bgImage.Refresh()));
        }

        public void updateDate(string day, string year)
        {
            this.gameForm.dayLabel.Invoke(new Action(() => this.gameForm.dayLabel.Text = "Date: day " + day + ", year " + year));
        }

        public void updateTime(string time)
        {
            this.gameForm.timeLabel.Invoke(new Action(() => this.gameForm.timeLabel.Text = "Time: " + time));
        }

        public void updateActivityLabel(string activity)
        {
            this.gameForm.activityLabel.Invoke(new Action(() => this.gameForm.activityLabel.Text = "Activity: " + activity));
        }

        public void updateConsole(string update)
        {
            this.gameForm.consoleTextBox.Invoke(new Action(() => this.gameForm.consoleTextBox.Text += "\n" +update));
        }

        private void BagComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentItem = this.gameForm.bagComboBox.SelectedItem.ToString();
        }

        public void saveLog()
        {
            string txt = this.gameForm.consoleTextBox.Text;
            System.IO.File.WriteAllText(@"Resources\log.txt", txt);
        }

       

    }
}
