namespace TeraBite
{
    partial class TeraBite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeraBite));
            this.cosmix_pnl = new System.Windows.Forms.Panel();
            this.title_pnl = new System.Windows.Forms.Panel();
            this.play_pnl = new System.Windows.Forms.Panel();
            this.copyright_pnl = new System.Windows.Forms.Panel();
            this.spaceship_pnl = new System.Windows.Forms.Panel();
            this.cosmix_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cosmix_pnl
            // 
            this.cosmix_pnl.BackColor = System.Drawing.Color.Transparent;
            this.cosmix_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cosmix_pnl.BackgroundImage")));
            this.cosmix_pnl.Controls.Add(this.play_pnl);
            this.cosmix_pnl.Controls.Add(this.title_pnl);
            this.cosmix_pnl.Controls.Add(this.spaceship_pnl);
            this.cosmix_pnl.Controls.Add(this.copyright_pnl);
            this.cosmix_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cosmix_pnl.Location = new System.Drawing.Point(0, 0);
            this.cosmix_pnl.Name = "cosmix_pnl";
            this.cosmix_pnl.Size = new System.Drawing.Size(624, 441);
            this.cosmix_pnl.TabIndex = 0;
            // 
            // title_pnl
            // 
            this.title_pnl.BackColor = System.Drawing.Color.Transparent;
            this.title_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("title_pnl.BackgroundImage")));
            this.title_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.title_pnl.Location = new System.Drawing.Point(222, -12);
            this.title_pnl.Name = "title_pnl";
            this.title_pnl.Size = new System.Drawing.Size(180, 180);
            this.title_pnl.TabIndex = 0;
            // 
            // play_pnl
            // 
            this.play_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play_pnl.BackgroundImage")));
            this.play_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play_pnl.Location = new System.Drawing.Point(252, 283);
            this.play_pnl.Name = "play_pnl";
            this.play_pnl.Size = new System.Drawing.Size(120, 120);
            this.play_pnl.TabIndex = 1;
            // 
            // copyright_pnl
            // 
            this.copyright_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyright_pnl.BackgroundImage")));
            this.copyright_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyright_pnl.Location = new System.Drawing.Point(137, 406);
            this.copyright_pnl.Name = "copyright_pnl";
            this.copyright_pnl.Size = new System.Drawing.Size(350, 35);
            this.copyright_pnl.TabIndex = 2;
            // 
            // spaceship_pnl
            // 
            this.spaceship_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spaceship_pnl.BackgroundImage")));
            this.spaceship_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spaceship_pnl.Location = new System.Drawing.Point(205, 142);
            this.spaceship_pnl.Name = "spaceship_pnl";
            this.spaceship_pnl.Size = new System.Drawing.Size(215, 200);
            this.spaceship_pnl.TabIndex = 3;
            // 
            // TeraBite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.cosmix_pnl);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "TeraBite";
            this.Text = "TeraBite";
            this.cosmix_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cosmix_pnl;
        private System.Windows.Forms.Panel copyright_pnl;
        private System.Windows.Forms.Panel play_pnl;
        private System.Windows.Forms.Panel title_pnl;
        private System.Windows.Forms.Panel spaceship_pnl;
    }
}

