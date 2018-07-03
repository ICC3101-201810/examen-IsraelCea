namespace PacMan_IsraelCea
{
    partial class GameOver
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
            this.label2 = new System.Windows.Forms.Label();
            this.jugador = new System.Windows.Forms.Label();
            this.puntaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 108);
            this.label2.TabIndex = 1;
            this.label2.Text = "GAME OVER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // jugador
            // 
            this.jugador.AutoSize = true;
            this.jugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugador.Location = new System.Drawing.Point(42, 228);
            this.jugador.Name = "jugador";
            this.jugador.Size = new System.Drawing.Size(89, 24);
            this.jugador.TabIndex = 2;
            this.jugador.Text = "Jugador: ";
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntaje.Location = new System.Drawing.Point(42, 267);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(78, 24);
            this.puntaje.TabIndex = 3;
            this.puntaje.Text = "Puntaje:";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.jugador);
            this.Controls.Add(this.label2);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label jugador;
        private System.Windows.Forms.Label puntaje;
    }
}