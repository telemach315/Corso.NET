namespace EsempioForm
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
            label2 = new Label();
            textCognome = new TextBox();
            lblRisultato = new Label();
            btnCerca = new Button();
            groupBox1 = new GroupBox();
            buttonInserisci = new Button();
            txtBoxNumero = new TextBox();
            txtBoxNome = new TextBox();
            txtBoxCognome = new TextBox();
            lblCreaNumero = new Label();
            lblCreaNome = new Label();
            lblCreaCognome = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 30);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 4;
            label2.Text = "Cerca per Cognome";
            // 
            // textCognome
            // 
            textCognome.Location = new Point(134, 27);
            textCognome.Name = "textCognome";
            textCognome.Size = new Size(152, 23);
            textCognome.TabIndex = 5;
            // 
            // lblRisultato
            // 
            lblRisultato.AutoSize = true;
            lblRisultato.Location = new Point(292, 30);
            lblRisultato.Name = "lblRisultato";
            lblRisultato.Size = new Size(22, 15);
            lblRisultato.TabIndex = 6;
            lblRisultato.Text = "---";
            // 
            // btnCerca
            // 
            btnCerca.Location = new Point(429, 81);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(75, 23);
            btnCerca.TabIndex = 7;
            btnCerca.Text = " Cerca";
            btnCerca.UseVisualStyleBackColor = true;
            btnCerca.Click += btnCerca_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonInserisci);
            groupBox1.Controls.Add(txtBoxNumero);
            groupBox1.Controls.Add(txtBoxNome);
            groupBox1.Controls.Add(txtBoxCognome);
            groupBox1.Controls.Add(lblCreaNumero);
            groupBox1.Controls.Add(lblCreaNome);
            groupBox1.Controls.Add(lblCreaCognome);
            groupBox1.Location = new Point(15, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 192);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuovo contatto";
            // 
            // buttonInserisci
            // 
            buttonInserisci.Location = new Point(393, 154);
            buttonInserisci.Name = "buttonInserisci";
            buttonInserisci.Size = new Size(75, 23);
            buttonInserisci.TabIndex = 6;
            buttonInserisci.Text = "Inserisci";
            buttonInserisci.UseVisualStyleBackColor = true;
            buttonInserisci.Click += buttonInserisci_Click;
            // 
            // txtBoxNumero
            // 
            txtBoxNumero.Location = new Point(102, 103);
            txtBoxNumero.Name = "txtBoxNumero";
            txtBoxNumero.Size = new Size(169, 23);
            txtBoxNumero.TabIndex = 5;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Location = new Point(102, 71);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(169, 23);
            txtBoxNome.TabIndex = 4;
            // 
            // txtBoxCognome
            // 
            txtBoxCognome.Location = new Point(102, 40);
            txtBoxCognome.Name = "txtBoxCognome";
            txtBoxCognome.Size = new Size(169, 23);
            txtBoxCognome.TabIndex = 3;
            // 
            // lblCreaNumero
            // 
            lblCreaNumero.AutoSize = true;
            lblCreaNumero.Location = new Point(36, 106);
            lblCreaNumero.Name = "lblCreaNumero";
            lblCreaNumero.Size = new Size(53, 15);
            lblCreaNumero.TabIndex = 2;
            lblCreaNumero.Text = "Telefono";
            // 
            // lblCreaNome
            // 
            lblCreaNome.AutoSize = true;
            lblCreaNome.Location = new Point(36, 71);
            lblCreaNome.Name = "lblCreaNome";
            lblCreaNome.Size = new Size(40, 15);
            lblCreaNome.TabIndex = 1;
            lblCreaNome.Text = "Nome";
            // 
            // lblCreaCognome
            // 
            lblCreaCognome.AutoSize = true;
            lblCreaCognome.Location = new Point(36, 40);
            lblCreaCognome.Name = "lblCreaCognome";
            lblCreaCognome.Size = new Size(60, 15);
            lblCreaCognome.TabIndex = 0;
            lblCreaCognome.Text = "Cognome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(528, 379);
            Controls.Add(groupBox1);
            Controls.Add(btnCerca);
            Controls.Add(lblRisultato);
            Controls.Add(textCognome);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        
        private TextBox txtBoxCognome;
        private Button btnSave;
        private Label label2;
        private TextBox textCognome;
        private Label lblRisultato;
        private Button btnCerca;
        private GroupBox groupBox1;
        private Label lblCreaNumero;
        private Label lblCreaNome;
        private Label lblCreaCognome;
        private Button buttonInserisci;
        private TextBox txtBoxNumero;
        private TextBox txtBoxNome;
    }
}
