using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // model.comer
            pictureBox17.Location = new Point(200, 10);
            setState("eat");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // model.recogercomida
            pictureBox17.Location = new Point(200, 140);
            setState("farm");
            pictureBox19.Size = new Size(0, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // model.irBaño
            pictureBox17.Location = new Point(200, 240);
            setState("toilet");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // model.sleep
            pictureBox17.Location = new Point(200, 380);
            setState("sleep");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            // model.pelea
            pictureBox17.Location = new Point(600, 10);
            setState("spar");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // model.gym
            pictureBox17.Location = new Point(1200, 10);
            setState("exercises");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // model.meditar
            pictureBox17.Location = new Point(1200, 185);
            setState("meditate");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // model.run
            pictureBox17.Location = new Point(1200, 330);
            setState("run");
        }

        private void setState(string state)
        {
            // frutos
            switch (state)
            {
                case "eat":
                    // comiendo
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/activites/eat.gif");
                    setStateString("Comiendo");
                    break;
                case "friend":
                    // friend
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/activites/friends.png");
                    setStateString("Socializando");
                    break;
                case "meditate":
                    // meditar
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/activites/meditate.png");
                    setStateString("Meditando");
                    break;
                case "run":
                    // run
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/activites/run.gif");
                    setStateString("Corriendo");
                    break;
                case "sleep":
                    // sleep
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/activites/sleep.gif");
                    setStateString("Durmiendo");
                    break;
                case "toilet":
                    // baño
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/activites/toilet.jpg");
                    setStateString("En el baño");
                    break;
                case "train":
                    // entrenar
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/activites/train.gif");
                    setStateString("Entrenando");
                    break;
                case "spar":
                    // pelea
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/activites/spar.gif");
                    setStateString("Peleando");
                    break;
                case "exercises":
                    // ejercicios
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/activites/pushups.gif");
                    setStateString("Ejercitandose");
                    break;
                case "cure":
                    // pelea
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/activites/cure.jpg");
                    setStateString("Sanando");
                    break;
                case "fat":
                    // gordo
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/sickness/fat.png");
                    setStateString("Gordo");
                    break;
                case "tired":
                    // cansado
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/sickness/tired.png");
                    setStateString("Cansado");
                    break;
                case "sick":
                    // enfermo
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/sickness/sick.png");
                    setStateString("Enfermo");
                    break;
                case "beatud":
                    // pelea
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/sickness/beatup.png");
                    setStateString("Golpeado");
                    break;
                case "farm":
                    // pelea
                    pictureBox9.Image = Image.FromFile("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/activites/goFarm.png");
                    setStateString("Recolectando frutos");
                    break;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            // model.socializar
            pictureBox17.Location = new Point(900, 20);
            setState("friend");
        }

        private void setHealth(int point)
        {
            label4.Text = "Health: "+ point + "%";
        }
        private void setEnergy(int point)
        {
            label5.Text = "Energy: " + point + "%";
        }

        private void setThirts(int point)
        {
            label6.Text = "Thirts: " + point + "%";
        }
        private void setHunger(int point)
        {
            label7.Text = "Hunger: " + point + "%";
        }
        private void setCondition(int point)
        {
            label8.Text = "Condition: " + point + "%";
        }
        private void setHappiness(int point)
        {
            label10.Text = "Happiness: " + point + "%";
        }
        private void setTime(int day, int hour)
        {
            label9.Text = "Time: Day:" + day + " Hour: " + hour;
        }
        private void setStateString(string state)
        {
            label11.Text = "State: " + state;
        }

        private void setFood()
        {
            // agregar intervalo de tiempo

            ArrayList array = new ArrayList();
            array.Add("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/items/4star.png");
            array.Add("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/items/beer.png");
            array.Add("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/items/cake.png");
            array.Add("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/items/carrot.png");
            array.Add("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/items/icecream.png");
            array.Add("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/items/mushroom.png");
            array.Add("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/items/onion.png");
            array.Add("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/items/ramen.png");
            array.Add("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/items/sensu.png");
            array.Add("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/items/sushi.png");
            array.Add("C:/Users/curso/source/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/images/items/watermelon.png");
            Random random = new Random();
            int valor = random.Next(0, 10);
            int j = 0;
            foreach (String i in array)
            {
                if (valor == j)
                {
                    pictureBox19.Image = Image.FromFile(i);
                    pictureBox19.Location = new Point(190, 160);
                    pictureBox19.Size = new Size(100, 100);
                }
                j++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // model. save state
            this.Close();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            // model.cure
            pictureBox17.Location = new Point(450, 10);
            setState("cure");
        }
    }
}
