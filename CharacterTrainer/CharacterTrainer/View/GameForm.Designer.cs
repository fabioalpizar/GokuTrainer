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
            this.statusImage = new System.Windows.Forms.PictureBox();
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
            this.dayLabel = new System.Windows.Forms.Label();
            this.appearanceImage = new System.Windows.Forms.PictureBox();
            this.appearanceLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.labelConsole = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiletImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meditateImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appearanceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bgImage
            // 
            this.bgImage.Image = ((System.Drawing.Image)(resources.GetObject("bgImage.Image")));
            this.bgImage.Location = new System.Drawing.Point(0, 0);
            this.bgImage.Name = "bgImage";
            this.bgImage.Size = new System.Drawing.Size(1207, 490);
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
            this.consoleTextBox.Location = new System.Drawing.Point(888, 516);
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
            // statusImage
            // 
            this.statusImage.Location = new System.Drawing.Point(682, 516);
            this.statusImage.Name = "statusImage";
            this.statusImage.Size = new System.Drawing.Size(200, 200);
            this.statusImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statusImage.TabIndex = 9;
            this.statusImage.TabStop = false;
            // 
            // bagComboBox
            // 
            this.bagComboBox.FormattingEnabled = true;
            this.bagComboBox.Location = new System.Drawing.Point(8, 660);
            this.bagComboBox.Name = "bagComboBox";
            this.bagComboBox.Size = new System.Drawing.Size(121, 21);
            this.bagComboBox.TabIndex = 10;
            // 
            // bagButton
            // 
            this.bagButton.Location = new System.Drawing.Point(8, 687);
            this.bagButton.Name = "bagButton";
            this.bagButton.Size = new System.Drawing.Size(75, 23);
            this.bagButton.TabIndex = 11;
            this.bagButton.Text = "Select item";
            this.bagButton.UseVisualStyleBackColor = true;
            // 
            // itemImage
            // 
            this.itemImage.Location = new System.Drawing.Point(135, 660);
            this.itemImage.Name = "itemImage";
            this.itemImage.Size = new System.Drawing.Size(50, 50);
            this.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.itemImage.TabIndex = 12;
            this.itemImage.TabStop = false;
            // 
            // bagLabel
            // 
            this.bagLabel.AutoSize = true;
            this.bagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagLabel.Location = new System.Drawing.Point(8, 637);
            this.bagLabel.Name = "bagLabel";
            this.bagLabel.Size = new System.Drawing.Size(42, 20);
            this.bagLabel.TabIndex = 13;
            this.bagLabel.Text = "Bag:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(8, 514);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Name:";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(8, 553);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(50, 20);
            this.levelLabel.TabIndex = 15;
            this.levelLabel.Text = "Level:";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.Location = new System.Drawing.Point(8, 590);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(34, 20);
            this.hpLabel.TabIndex = 16;
            this.hpLabel.Text = "Hp:";
            // 
            // happinessLabel
            // 
            this.happinessLabel.AutoSize = true;
            this.happinessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.happinessLabel.Location = new System.Drawing.Point(150, 514);
            this.happinessLabel.Name = "happinessLabel";
            this.happinessLabel.Size = new System.Drawing.Size(89, 20);
            this.happinessLabel.TabIndex = 17;
            this.happinessLabel.Text = "Happiness:";
            // 
            // energyLabel
            // 
            this.energyLabel.AutoSize = true;
            this.energyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyLabel.Location = new System.Drawing.Point(308, 516);
            this.energyLabel.Name = "energyLabel";
            this.energyLabel.Size = new System.Drawing.Size(63, 20);
            this.energyLabel.TabIndex = 18;
            this.energyLabel.Text = "Energy:";
            // 
            // thirstLabel
            // 
            this.thirstLabel.AutoSize = true;
            this.thirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirstLabel.Location = new System.Drawing.Point(150, 553);
            this.thirstLabel.Name = "thirstLabel";
            this.thirstLabel.Size = new System.Drawing.Size(52, 20);
            this.thirstLabel.TabIndex = 19;
            this.thirstLabel.Text = "Thirst:";
            // 
            // hungerLabel
            // 
            this.hungerLabel.AutoSize = true;
            this.hungerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hungerLabel.Location = new System.Drawing.Point(150, 590);
            this.hungerLabel.Name = "hungerLabel";
            this.hungerLabel.Size = new System.Drawing.Size(66, 20);
            this.hungerLabel.TabIndex = 20;
            this.hungerLabel.Text = "Hunger:";
            // 
            // conditioLabel
            // 
            this.conditioLabel.AutoSize = true;
            this.conditioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditioLabel.Location = new System.Drawing.Point(308, 553);
            this.conditioLabel.Name = "conditioLabel";
            this.conditioLabel.Size = new System.Drawing.Size(119, 20);
            this.conditioLabel.TabIndex = 21;
            this.conditioLabel.Text = "Condition: Fine.";
            this.conditioLabel.Click += new System.EventHandler(this.ConditioLabel_Click);
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLabel.Location = new System.Drawing.Point(308, 590);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(62, 20);
            this.activityLabel.TabIndex = 22;
            this.activityLabel.Text = "Activity:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(380, 684);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(198, 658);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(141, 20);
            this.dayLabel.TabIndex = 24;
            this.dayLabel.Text = "Date: day 1, year 1";
            this.dayLabel.Click += new System.EventHandler(this.DayLabel_Click);
            // 
            // appearanceImage
            // 
            this.appearanceImage.Location = new System.Drawing.Point(476, 516);
            this.appearanceImage.Name = "appearanceImage";
            this.appearanceImage.Size = new System.Drawing.Size(200, 200);
            this.appearanceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appearanceImage.TabIndex = 25;
            this.appearanceImage.TabStop = false;
            // 
            // appearanceLabel
            // 
            this.appearanceLabel.AutoSize = true;
            this.appearanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appearanceLabel.Location = new System.Drawing.Point(472, 493);
            this.appearanceLabel.Name = "appearanceLabel";
            this.appearanceLabel.Size = new System.Drawing.Size(96, 20);
            this.appearanceLabel.TabIndex = 26;
            this.appearanceLabel.Text = "Appearance";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(678, 493);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(56, 20);
            this.statusLabel.TabIndex = 27;
            this.statusLabel.Text = "Status";
            // 
            // labelConsole
            // 
            this.labelConsole.AutoSize = true;
            this.labelConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsole.Location = new System.Drawing.Point(884, 493);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(67, 20);
            this.labelConsole.TabIndex = 28;
            this.labelConsole.Text = "Console";
            this.labelConsole.Click += new System.EventHandler(this.Label3_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(198, 687);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(47, 20);
            this.timeLabel.TabIndex = 29;
            this.timeLabel.Text = "Time:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 719);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.appearanceLabel);
            this.Controls.Add(this.appearanceImage);
            this.Controls.Add(this.dayLabel);
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
            this.Controls.Add(this.statusImage);
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
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appearanceImage)).EndInit();
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
        public PictureBox statusImage;
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
        public Label dayLabel;
        public PictureBox appearanceImage;
        public Label appearanceLabel;
        public Label statusLabel;
        public Label labelConsole;
        public Label timeLabel;
    }
}

