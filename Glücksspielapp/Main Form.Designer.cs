using System.Windows.Forms;

namespace Glücksspielapp
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlayRoulette = new System.Windows.Forms.Button();
            this.btnPlayMines = new System.Windows.Forms.Button();
            this.btnPlayBlackjack = new System.Windows.Forms.Button();
            this.picRoulette = new System.Windows.Forms.PictureBox();
            this.picMines = new System.Windows.Forms.PictureBox();
            this.picBlackjack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRoulette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackjack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(171, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Willkommen im Casino!";
            // 
            // btnPlayRoulette
            // 
            this.btnPlayRoulette.Location = new System.Drawing.Point(43, 173);
            this.btnPlayRoulette.Name = "btnPlayRoulette";
            this.btnPlayRoulette.Size = new System.Drawing.Size(129, 43);
            this.btnPlayRoulette.TabIndex = 1;
            this.btnPlayRoulette.Text = "Roulette";
            this.btnPlayRoulette.UseVisualStyleBackColor = true;
            this.btnPlayRoulette.Click += new System.EventHandler(this.BtnPlayRoulette_Click);
            // 
            // btnPlayMines
            // 
            this.btnPlayMines.Location = new System.Drawing.Point(214, 173);
            this.btnPlayMines.Name = "btnPlayMines";
            this.btnPlayMines.Size = new System.Drawing.Size(129, 43);
            this.btnPlayMines.TabIndex = 2;
            this.btnPlayMines.Text = "Mines";
            this.btnPlayMines.UseVisualStyleBackColor = true;
            this.btnPlayMines.Click += new System.EventHandler(this.BtnPlayMines_Click);
            // 
            // btnPlayBlackjack
            // 
            this.btnPlayBlackjack.Location = new System.Drawing.Point(386, 173);
            this.btnPlayBlackjack.Name = "btnPlayBlackjack";
            this.btnPlayBlackjack.Size = new System.Drawing.Size(129, 43);
            this.btnPlayBlackjack.TabIndex = 3;
            this.btnPlayBlackjack.Text = "Blackjack";
            this.btnPlayBlackjack.UseVisualStyleBackColor = true;
            this.btnPlayBlackjack.Click += new System.EventHandler(this.BtnPlayBlackjack_Click);
            // 
            // picRoulette
            // 
            this.picRoulette.Image = global::Glücksspielapp.Resources.roulette;
            this.picRoulette.Location = new System.Drawing.Point(43, 87);
            this.picRoulette.Name = "picRoulette";
            this.picRoulette.Size = new System.Drawing.Size(129, 69);
            this.picRoulette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoulette.TabIndex = 4;
            this.picRoulette.TabStop = false;
            // 
            // picMines
            // 
            this.picMines.Location = new System.Drawing.Point(214, 87);
            this.picMines.Name = "picMines";
            this.picMines.Size = new System.Drawing.Size(129, 69);
            this.picMines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMines.TabIndex = 5;
            this.picMines.TabStop = false;
            // 
            // picBlackjack
            // 
            this.picBlackjack.Location = new System.Drawing.Point(386, 87);
            this.picBlackjack.Name = "picBlackjack";
            this.picBlackjack.Size = new System.Drawing.Size(129, 69);
            this.picBlackjack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlackjack.TabIndex = 6;
            this.picBlackjack.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 260);
            this.Controls.Add(this.picBlackjack);
            this.Controls.Add(this.picMines);
            this.Controls.Add(this.picRoulette);
            this.Controls.Add(this.btnPlayBlackjack);
            this.Controls.Add(this.btnPlayMines);
            this.Controls.Add(this.btnPlayRoulette);
            this.Controls.Add(this.lblTitle);
            this.Name = "Main_Form";
            this.Text = "Casino Hauptmenü";
            ((System.ComponentModel.ISupportInitialize)(this.picRoulette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackjack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlayRoulette;
        private System.Windows.Forms.Button btnPlayMines;
        private System.Windows.Forms.Button btnPlayBlackjack;
        private System.Windows.Forms.PictureBox picRoulette;
        private System.Windows.Forms.PictureBox picMines;
        private System.Windows.Forms.PictureBox picBlackjack;
    }

    #endregion
}