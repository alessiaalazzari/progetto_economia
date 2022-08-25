namespace Prova_1_econmics
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nome_benvenuto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nuovo_progetto = new System.Windows.Forms.Button();
            this.bottone_Esci = new System.Windows.Forms.Button();
            this.bottone_github = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome_benvenuto
            // 
            this.nome_benvenuto.AutoSize = true;
            this.nome_benvenuto.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_benvenuto.Location = new System.Drawing.Point(104, 31);
            this.nome_benvenuto.Name = "nome_benvenuto";
            this.nome_benvenuto.Size = new System.Drawing.Size(260, 50);
            this.nome_benvenuto.TabIndex = 0;
            this.nome_benvenuto.Text = "BENVENUT*!";
            this.nome_benvenuto.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apri un progetto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.TextChanged += new System.EventHandler(this.Prova);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nuovo_progetto
            // 
            this.nuovo_progetto.Location = new System.Drawing.Point(123, 166);
            this.nuovo_progetto.Name = "nuovo_progetto";
            this.nuovo_progetto.Size = new System.Drawing.Size(219, 27);
            this.nuovo_progetto.TabIndex = 3;
            this.nuovo_progetto.Text = "Crea un nuovo progetto";
            this.nuovo_progetto.UseVisualStyleBackColor = true;
            this.nuovo_progetto.Click += new System.EventHandler(this.Cambioi_colore_Click);
            // 
            // bottone_Esci
            // 
            this.bottone_Esci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottone_Esci.Location = new System.Drawing.Point(132, 351);
            this.bottone_Esci.Name = "bottone_Esci";
            this.bottone_Esci.Size = new System.Drawing.Size(219, 23);
            this.bottone_Esci.TabIndex = 4;
            this.bottone_Esci.Text = "Esci";
            this.bottone_Esci.UseVisualStyleBackColor = true;
            this.bottone_Esci.Click += new System.EventHandler(this.button2_Click);
            // 
            // bottone_github
            // 
            this.bottone_github.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottone_github.Location = new System.Drawing.Point(132, 289);
            this.bottone_github.Name = "bottone_github";
            this.bottone_github.Size = new System.Drawing.Size(219, 23);
            this.bottone_github.TabIndex = 5;
            this.bottone_github.Text = "Visualizza crediti/codice";
            this.bottone_github.UseVisualStyleBackColor = true;
            this.bottone_github.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Che cosa vuoi fare oggi?";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orchid;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(113, 439);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alessia Lazzari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mat: 1078863";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Progetto di Economia ed Organizzazione \r\nAziendale presso l\'Università degli Stud" +
    "i di Bergamo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(482, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bottone_github);
            this.Controls.Add(this.bottone_Esci);
            this.Controls.Add(this.nuovo_progetto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nome_benvenuto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Analisi Break-Even";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome_benvenuto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nuovo_progetto;
        private System.Windows.Forms.Button bottone_Esci;
        private System.Windows.Forms.Button bottone_github;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

