namespace SondaSpaziale
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            lblNome = new Label();
            label2 = new Label();
            lblVelocita = new Label();
            lblDistanza = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblStato = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Tianwen_2_scaled;
            pictureBox1.Location = new Point(41, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 131);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(41, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(164, 32);
            lblNome.TabIndex = 1;
            lblNome.Text = "nome sonda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(462, 66);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 2;
            label2.Text = "Velocità:";
            // 
            // lblVelocita
            // 
            lblVelocita.AutoSize = true;
            lblVelocita.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVelocita.ForeColor = Color.Chartreuse;
            lblVelocita.Location = new Point(770, 66);
            lblVelocita.Name = "lblVelocita";
            lblVelocita.Size = new Size(134, 32);
            lblVelocita.TabIndex = 3;
            lblVelocita.Text = "0,0 km/s";
            // 
            // lblDistanza
            // 
            lblDistanza.AutoSize = true;
            lblDistanza.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDistanza.ForeColor = Color.Chartreuse;
            lblDistanza.Location = new Point(617, 111);
            lblDistanza.Name = "lblDistanza";
            lblDistanza.Size = new Size(134, 32);
            lblDistanza.TabIndex = 5;
            lblDistanza.Text = "0,0 km/s";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(282, 111);
            label5.Name = "label5";
            label5.Size = new Size(329, 32);
            label5.TabIndex = 4;
            label5.Text = "Distanza dalla Terra:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            // 
            // lblStato
            // 
            lblStato.AutoSize = true;
            lblStato.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStato.ForeColor = Color.Chartreuse;
            lblStato.Location = new Point(256, 31);
            lblStato.Name = "lblStato";
            lblStato.Size = new Size(29, 32);
            lblStato.TabIndex = 6;
            lblStato.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1072, 408);
            Controls.Add(lblStato);
            Controls.Add(lblDistanza);
            Controls.Add(label5);
            Controls.Add(lblVelocita);
            Controls.Add(label2);
            Controls.Add(lblNome);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNome;
        private Label label2;
        private Label lblVelocita;
        private Label lblDistanza;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Label lblStato;
    }
}
