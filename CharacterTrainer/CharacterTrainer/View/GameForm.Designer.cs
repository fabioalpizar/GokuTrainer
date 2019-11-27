using System.Drawing;
using System.Windows.Forms;

namespace CharacterTrainer
{
    partial class GameForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.bgImage = new System.Windows.Forms.PictureBox();
            this.houseImage = new System.Windows.Forms.PictureBox();
            this.kitchenImage = new System.Windows.Forms.PictureBox();
            this.farmImage = new System.Windows.Forms.PictureBox();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.gymImage = new System.Windows.Forms.PictureBox();
            this.toiletImage = new System.Windows.Forms.PictureBox();
            this.meditateImage = new System.Windows.Forms.PictureBox();
            this.runImage = new System.Windows.Forms.PictureBox();
            this.conditionImage = new System.Windows.Forms.PictureBox();
            this.bagComboBox = new System.Windows.Forms.ComboBox();
            this.bagButton = new System.Windows.Forms.Button();
            this.itemImage = new System.Windows.Forms.PictureBox();
            this.bagLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.happinessLabel = new System.Windows.Forms.Label();
            this.energyLabel = new System.Windows.Forms.Label();
            this.thirstLabel = new System.Windows.Forms.Label();
            this.hungerLabel = new System.Windows.Forms.Label();
            this.conditioLabel = new System.Windows.Forms.Label();
            this.activityLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiletImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meditateImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bgImage
            // 
            this.bgImage.Image = ((System.Drawing.Image)(resources.GetObject("bgImage.Image")));
            this.bgImage.Location = new System.Drawing.Point(0, 0);
            this.bgImage.Name = "bgImage";
            this.bgImage.Size = new System.Drawing.Size(1207, 494);
            this.bgImage.TabIndex = 0;
            this.bgImage.TabStop = false;
            // 
            // houseImage
            // 
            this.houseImage.Image = ((System.Drawing.Image)(resources.GetObject("houseImage.Image")));
            this.houseImage.Location = new System.Drawing.Point(709, 392);
            this.houseImage.Name = "houseImage";
            this.houseImage.Size = new System.Drawing.Size(87, 70);
            this.houseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.houseImage.TabIndex = 1;
            this.houseImage.TabStop = false;
            // 
            // kitchenImage
            // 
            this.kitchenImage.Image = ((System.Drawing.Image)(resources.GetObject("kitchenImage.Image")));
            this.kitchenImage.Location = new System.Drawing.Point(419, 392);
            this.kitchenImage.Name = "kitchenImage";
            this.kitchenImage.Size = new System.Drawing.Size(87, 70);
            this.kitchenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kitchenImage.TabIndex = 2;
            this.kitchenImage.TabStop = false;
            // 
            // farmImage
            // 
            this.farmImage.Image = ((System.Drawing.Image)(resources.GetObject("farmImage.Image")));
            this.farmImage.Location = new System.Drawing.Point(990, 415);
            this.farmImage.Name = "farmImage";
            this.farmImage.Size = new System.Drawing.Size(87, 70);
            this.farmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.farmImage.TabIndex = 3;
            this.farmImage.TabStop = false;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Location = new System.Drawing.Point(766, 502);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.Size = new System.Drawing.Size(291, 198);
            this.consoleTextBox.TabIndex = 4;
            this.consoleTextBox.Text = "";
            // 
            // gymImage
            // 
            this.gymImage.Image = ((System.Drawing.Image)(resources.GetObject("gymImage.Image")));
            this.gymImage.Location = new System.Drawing.Point(79, 34);
            this.gymImage.Name = "gymImage";
            this.gymImage.Size = new System.Drawing.Size(87, 70);
            this.gymImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gymImage.TabIndex = 5;
            this.gymImage.TabStop = false;
            this.gymImage.Click += new System.EventHandler(this.GymImage_Click);
            // 
            // toiletImage
            // 
            this.toiletImage.Image = ((System.Drawing.Image)(resources.GetObject("toiletImage.Image")));
            this.toiletImage.Location = new System.Drawing.Point(23, 382);
            this.toiletImage.Name = "toiletImage";
            this.toiletImage.Size = new System.Drawing.Size(87, 70);
            this.toiletImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.toiletImage.TabIndex = 6;
            this.toiletImage.TabStop = false;
            // 
            // meditateImage
            // 
            this.meditateImage.Image = ((System.Drawing.Image)(resources.GetObject("meditateImage.Image")));
            this.meditateImage.Location = new System.Drawing.Point(531, 48);
            this.meditateImage.Name = "meditateImage";
            this.meditateImage.Size = new System.Drawing.Size(87, 70);
            this.meditateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.meditateImage.TabIndex = 7;
            this.meditateImage.TabStop = false;
            // 
            // runImage
            // 
            this.runImage.Image = ((System.Drawing.Image)(resources.GetObject("runImage.Image")));
            this.runImage.Location = new System.Drawing.Point(1106, 86);
            this.runImage.Name = "runImage";
            this.runImage.Size = new System.Drawing.Size(87, 70);
            this.runImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.runImage.TabIndex = 8;
            this.runImage.TabStop = false;
            // 
            // conditionImage
            // 
            this.conditionImage.Location = new System.Drawing.Point(531, 500);
            this.conditionImage.Name = "conditionImage";
            this.conditionImage.Size = new System.Drawing.Size(200, 200);
            this.conditionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conditionImage.TabIndex = 9;
            this.conditionImage.TabStop = false;
            // 
            // bagComboBox
            // 
            this.bagComboBox.FormattingEnabled = true;
            this.bagComboBox.Location = new System.Drawing.Point(12, 646);
            this.bagComboBox.Name = "bagComboBox";
            this.bagComboBox.Size = new System.Drawing.Size(121, 21);
            this.bagComboBox.TabIndex = 10;
            // 
            // bagButton
            // 
            this.bagButton.Location = new System.Drawing.Point(12, 673);
            this.bagButton.Name = "bagButton";
            this.bagButton.Size = new System.Drawing.Size(75, 23);
            this.bagButton.TabIndex = 11;
            this.bagButton.Text = "Select item";
            this.bagButton.UseVisualStyleBackColor = true;
            // 
            // itemImage
            // 
            this.itemImage.Location = new System.Drawing.Point(139, 646);
            this.itemImage.Name = "itemImage";
            this.itemImage.Size = new System.Drawing.Size(50, 50);
            this.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.itemImage.TabIndex = 12;
            this.itemImage.TabStop = false;
            // 
            // bagLabel
            // 
            this.bagLabel.AutoSize = true;
            this.bagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagLabel.Location = new System.Drawing.Point(12, 623);
            this.bagLabel.Name = "bagLabel";
            this.bagLabel.Size = new System.Drawing.Size(42, 20);
            this.bagLabel.TabIndex = 13;
            this.bagLabel.Text = "Bag:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 500);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Name:";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(12, 539);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(50, 20);
            this.levelLabel.TabIndex = 15;
            this.levelLabel.Text = "Level:";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.Location = new System.Drawing.Point(12, 576);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(34, 20);
            this.hpLabel.TabIndex = 16;
            this.hpLabel.Text = "Hp:";
            // 
            // happinessLabel
            // 
            this.happinessLabel.AutoSize = true;
            this.happinessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.happinessLabel.Location = new System.Drawing.Point(190, 500);
            this.happinessLabel.Name = "happinessLabel";
            this.happinessLabel.Size = new System.Drawing.Size(89, 20);
            this.happinessLabel.TabIndex = 17;
            this.happinessLabel.Text = "Happiness:";
            // 
            // energyLabel
            // 
            this.energyLabel.AutoSize = true;
            this.energyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyLabel.Location = new System.Drawing.Point(354, 500);
            this.energyLabel.Name = "energyLabel";
            this.energyLabel.Size = new System.Drawing.Size(63, 20);
            this.energyLabel.TabIndex = 18;
            this.energyLabel.Text = "Energy:";
            // 
            // thirstLabel
            // 
            this.thirstLabel.AutoSize = true;
            this.thirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirstLabel.Location = new System.Drawing.Point(192, 539);
            this.thirstLabel.Name = "thirstLabel";
            this.thirstLabel.Size = new System.Drawing.Size(52, 20);
            this.thirstLabel.TabIndex = 19;
            this.thirstLabel.Text = "Thirst:";
            // 
            // hungerLabel
            // 
            this.hungerLabel.AutoSize = true;
            this.hungerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hungerLabel.Location = new System.Drawing.Point(192, 576);
            this.hungerLabel.Name = "hungerLabel";
            this.hungerLabel.Size = new System.Drawing.Size(66, 20);
            this.hungerLabel.TabIndex = 20;
            this.hungerLabel.Text = "Hunger:";
            // 
            // conditioLabel
            // 
            this.conditioLabel.AutoSize = true;
            this.conditioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditioLabel.Location = new System.Drawing.Point(354, 539);
            this.conditioLabel.Name = "conditioLabel";
            this.conditioLabel.Size = new System.Drawing.Size(80, 20);
            this.conditioLabel.TabIndex = 21;
            this.conditioLabel.Text = "Condition:";
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLabel.Location = new System.Drawing.Point(354, 576);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(62, 20);
            this.activityLabel.TabIndex = 22;
            this.activityLabel.Text = "Activity:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(358, 673);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 703);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.activityLabel);
            this.Controls.Add(this.conditioLabel);
            this.Controls.Add(this.hungerLabel);
            this.Controls.Add(this.thirstLabel);
            this.Controls.Add(this.energyLabel);
            this.Controls.Add(this.happinessLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.bagLabel);
            this.Controls.Add(this.itemImage);
            this.Controls.Add(this.bagButton);
            this.Controls.Add(this.bagComboBox);
            this.Controls.Add(this.conditionImage);
            this.Controls.Add(this.runImage);
            this.Controls.Add(this.meditateImage);
            this.Controls.Add(this.toiletImage);
            this.Controls.Add(this.gymImage);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.farmImage);
            this.Controls.Add(this.kitchenImage);
            this.Controls.Add(this.houseImage);
            this.Controls.Add(this.bgImage);
            this.Name = "GameForm";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiletImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meditateImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox bgImage;
        public System.Windows.Forms.PictureBox houseImage;
        public PictureBox kitchenImage;
        public PictureBox farmImage;
        public RichTextBox consoleTextBox;
        public PictureBox gymImage;
        public PictureBox toiletImage;
        public PictureBox meditateImage;
        public PictureBox runImage;
        public PictureBox conditionImage;
        public ComboBox bagComboBox;
        public Button bagButton;
        public PictureBox itemImage;
        public Label bagLabel;
        public Label nameLabel;
        public Label levelLabel;
        public Label hpLabel;
        public Label happinessLabel;
        public Label energyLabel;
        public Label thirstLabel;
        public Label hungerLabel;
        public Label conditioLabel;
        public Label activityLabel;
        public Button exitButton;
    }
}

