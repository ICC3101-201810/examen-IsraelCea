namespace PacMan_IsraelCea
{
    partial class PACMAN
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
            this.components = new System.ComponentModel.Container();
            this.Pman = new System.Windows.Forms.PictureBox();
            this.PinkGhost = new System.Windows.Forms.PictureBox();
            this.RedGhost = new System.Windows.Forms.PictureBox();
            this.Cherry = new System.Windows.Forms.PictureBox();
            this.Uva = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPuntaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uva)).BeginInit();
            this.SuspendLayout();
            // 
            // Pman
            // 
            this.Pman.Image = global::PacMan_IsraelCea.Properties.Resources.pacman_right;
            this.Pman.Location = new System.Drawing.Point(31, 61);
            this.Pman.Name = "Pman";
            this.Pman.Size = new System.Drawing.Size(52, 48);
            this.Pman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pman.TabIndex = 0;
            this.Pman.TabStop = false;
            // 
            // PinkGhost
            // 
            this.PinkGhost.Image = global::PacMan_IsraelCea.Properties.Resources.pink_left1;
            this.PinkGhost.Location = new System.Drawing.Point(521, 91);
            this.PinkGhost.Name = "PinkGhost";
            this.PinkGhost.Size = new System.Drawing.Size(52, 48);
            this.PinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PinkGhost.TabIndex = 1;
            this.PinkGhost.TabStop = false;
            // 
            // RedGhost
            // 
            this.RedGhost.Image = global::PacMan_IsraelCea.Properties.Resources.red_left1;
            this.RedGhost.Location = new System.Drawing.Point(427, 225);
            this.RedGhost.Name = "RedGhost";
            this.RedGhost.Size = new System.Drawing.Size(52, 48);
            this.RedGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedGhost.TabIndex = 2;
            this.RedGhost.TabStop = false;
            // 
            // Cherry
            // 
            this.Cherry.Image = global::PacMan_IsraelCea.Properties.Resources.cherry;
            this.Cherry.Location = new System.Drawing.Point(183, 339);
            this.Cherry.Name = "Cherry";
            this.Cherry.Size = new System.Drawing.Size(52, 48);
            this.Cherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cherry.TabIndex = 3;
            this.Cherry.TabStop = false;
            // 
            // Uva
            // 
            this.Uva.Image = global::PacMan_IsraelCea.Properties.Resources.tile114;
            this.Uva.Location = new System.Drawing.Point(321, 339);
            this.Uva.Name = "Uva";
            this.Uva.Size = new System.Drawing.Size(52, 48);
            this.Uva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Uva.TabIndex = 4;
            this.Uva.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPuntaje
            // 
            this.labelPuntaje.AutoSize = true;
            this.labelPuntaje.Location = new System.Drawing.Point(28, 13);
            this.labelPuntaje.Name = "labelPuntaje";
            this.labelPuntaje.Size = new System.Drawing.Size(35, 13);
            this.labelPuntaje.TabIndex = 5;
            this.labelPuntaje.Text = "label1";
            // 
            // PACMAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 484);
            this.Controls.Add(this.labelPuntaje);
            this.Controls.Add(this.Uva);
            this.Controls.Add(this.Cherry);
            this.Controls.Add(this.RedGhost);
            this.Controls.Add(this.PinkGhost);
            this.Controls.Add(this.Pman);
            this.Name = "PACMAN";
            this.Text = "Juego";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Pman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pman;
        private System.Windows.Forms.PictureBox PinkGhost;
        private System.Windows.Forms.PictureBox RedGhost;
        private System.Windows.Forms.PictureBox Cherry;
        private System.Windows.Forms.PictureBox Uva;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPuntaje;
    }
}