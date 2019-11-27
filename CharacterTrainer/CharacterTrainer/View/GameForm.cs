using CharacterTrainer.Model;
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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void DayLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConditioLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
