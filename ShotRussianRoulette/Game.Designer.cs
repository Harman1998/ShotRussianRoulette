namespace ShotRussianRoulette
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Load = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Fire = new System.Windows.Forms.Button();
            this.FireAway = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.Image_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Load.FlatAppearance.BorderSize = 6;
            this.Load.Font = new System.Drawing.Font("Wide Latin", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.ForeColor = System.Drawing.Color.Black;
            this.Load.Location = new System.Drawing.Point(13, 59);
            this.Load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(156, 89);
            this.Load.TabIndex = 0;
            this.Load.Text = "LOAD";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Spin
            // 
            this.Spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Spin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Spin.FlatAppearance.BorderSize = 6;
            this.Spin.Font = new System.Drawing.Font("Wide Latin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.ForeColor = System.Drawing.Color.Black;
            this.Spin.Location = new System.Drawing.Point(13, 217);
            this.Spin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(156, 89);
            this.Spin.TabIndex = 1;
            this.Spin.Text = "SPIN";
            this.Spin.UseVisualStyleBackColor = false;
            this.Spin.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fire
            // 
            this.Fire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Fire.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Fire.FlatAppearance.BorderSize = 6;
            this.Fire.Font = new System.Drawing.Font("Wide Latin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire.ForeColor = System.Drawing.Color.Black;
            this.Fire.Location = new System.Drawing.Point(824, 59);
            this.Fire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(192, 89);
            this.Fire.TabIndex = 2;
            this.Fire.Text = "FIRE";
            this.Fire.UseVisualStyleBackColor = false;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // FireAway
            // 
            this.FireAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FireAway.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FireAway.FlatAppearance.BorderSize = 6;
            this.FireAway.Font = new System.Drawing.Font("Wide Latin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireAway.ForeColor = System.Drawing.Color.Black;
            this.FireAway.Location = new System.Drawing.Point(824, 217);
            this.FireAway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FireAway.Name = "FireAway";
            this.FireAway.Size = new System.Drawing.Size(192, 89);
            this.FireAway.TabIndex = 3;
            this.FireAway.Text = "FIRE AWAY";
            this.FireAway.UseVisualStyleBackColor = false;
            this.FireAway.Click += new System.EventHandler(this.FireAway_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.PlayAgain.FlatAppearance.BorderSize = 6;
            this.PlayAgain.Font = new System.Drawing.Font("Wide Latin", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.Color.Black;
            this.PlayAgain.Location = new System.Drawing.Point(324, 440);
            this.PlayAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(260, 89);
            this.PlayAgain.TabIndex = 4;
            this.PlayAgain.Text = "PLAY AGAIN";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // Image_box
            // 
            this.Image_box.BackColor = System.Drawing.Color.Transparent;
            this.Image_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image_box.Location = new System.Drawing.Point(196, 32);
            this.Image_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Image_box.Name = "Image_box";
            this.Image_box.Size = new System.Drawing.Size(592, 388);
            this.Image_box.TabIndex = 5;
            this.Image_box.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.FireAway);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Image_box);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game";
            this.Text = "Game Russian Roulette";
            ((System.ComponentModel.ISupportInitialize)(this.Image_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button FireAway;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.PictureBox Image_box;
    }
}

