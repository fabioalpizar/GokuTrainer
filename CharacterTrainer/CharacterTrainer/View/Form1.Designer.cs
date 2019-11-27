using System.Drawing;
using System.Windows.Forms;

namespace CharacterTrainer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bgImage = new System.Windows.Forms.PictureBox();
            this.houseImage = new System.Windows.Forms.PictureBox();
            this.kitchenImage = new System.Windows.Forms.PictureBox();
            this.farmImage = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gymImage = new System.Windows.Forms.PictureBox();
            this.toiletImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiletImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.bgImage.Paint += new System.Windows.Forms.PaintEventHandler(this.bgImage_Paint);
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(622, 500);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(291, 141);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1106, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 653);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toiletImage);
            this.Controls.Add(this.gymImage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.farmImage);
            this.Controls.Add(this.kitchenImage);
            this.Controls.Add(this.houseImage);
            this.Controls.Add(this.bgImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiletImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bgImage;
        private System.Windows.Forms.PictureBox houseImage;
        private PictureBox kitchenImage;
        private PictureBox farmImage;
        private RichTextBox richTextBox1;
        private PictureBox gymImage;
        private PictureBox toiletImage;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

