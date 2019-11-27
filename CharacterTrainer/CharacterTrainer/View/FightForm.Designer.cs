using System.Drawing;
using System.Windows.Forms;

namespace CharacterTrainer
{
    partial class FightForm
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
            this.characterImage = new System.Windows.Forms.PictureBox();
            this.enemyImage = new System.Windows.Forms.PictureBox();
            this.fightConsole = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // characterImage
            // 
            this.characterImage.Location = new System.Drawing.Point(12, 12);
            this.characterImage.Name = "characterImage";
            this.characterImage.Size = new System.Drawing.Size(200, 200);
            this.characterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.characterImage.TabIndex = 0;
            this.characterImage.TabStop = false;
            // 
            // enemyImage
            // 
            this.enemyImage.Location = new System.Drawing.Point(462, 12);
            this.enemyImage.Name = "enemyImage";
            this.enemyImage.Size = new System.Drawing.Size(200, 200);
            this.enemyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyImage.TabIndex = 1;
            this.enemyImage.TabStop = false;
            // 
            // fightConsole
            // 
            this.fightConsole.Location = new System.Drawing.Point(218, 12);
            this.fightConsole.Name = "fightConsole";
            this.fightConsole.ReadOnly = true;
            this.fightConsole.Size = new System.Drawing.Size(238, 200);
            this.fightConsole.TabIndex = 2;
            this.fightConsole.Text = "";
            // 
            // FightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 229);
            this.Controls.Add(this.fightConsole);
            this.Controls.Add(this.enemyImage);
            this.Controls.Add(this.characterImage);
            this.Name = "FightForm";
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox characterImage;
        private PictureBox enemyImage;
        private RichTextBox fightConsole;
    }
}

