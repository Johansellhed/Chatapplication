namespace ServerKlient
{
    partial class ClientForm
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
            this.tbxInkorg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMeddelande = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.tbxAnvändarnamn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBifoga = new System.Windows.Forms.Button();
            this.btnLoggaUt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxInkorg
            // 
            this.tbxInkorg.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbxInkorg.Location = new System.Drawing.Point(0, 0);
            this.tbxInkorg.Multiline = true;
            this.tbxInkorg.Name = "tbxInkorg";
            this.tbxInkorg.ReadOnly = true;
            this.tbxInkorg.Size = new System.Drawing.Size(155, 371);
            this.tbxInkorg.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inkorg";
            // 
            // tbxMeddelande
            // 
            this.tbxMeddelande.Location = new System.Drawing.Point(214, 141);
            this.tbxMeddelande.Name = "tbxMeddelande";
            this.tbxMeddelande.Size = new System.Drawing.Size(218, 20);
            this.tbxMeddelande.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skicka ett meddelande";
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(214, 176);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(75, 51);
            this.btnSkicka.TabIndex = 4;
            this.btnSkicka.Text = "Skicka";
            this.btnSkicka.UseVisualStyleBackColor = true;
            this.btnSkicka.Click += new System.EventHandler(this.btnSkicka_Click_1);
            // 
            // btnAnslut
            // 
            this.btnAnslut.BackColor = System.Drawing.Color.Lime;
            this.btnAnslut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAnslut.Location = new System.Drawing.Point(523, 0);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(70, 371);
            this.btnAnslut.TabIndex = 5;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = false;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click_1);
            // 
            // tbxAnvändarnamn
            // 
            this.tbxAnvändarnamn.Location = new System.Drawing.Point(214, 102);
            this.tbxAnvändarnamn.Name = "tbxAnvändarnamn";
            this.tbxAnvändarnamn.Size = new System.Drawing.Size(100, 20);
            this.tbxAnvändarnamn.TabIndex = 6;
            this.tbxAnvändarnamn.TextChanged += new System.EventHandler(this.tbxAnvändarnamn_TextChanged);

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Användarnamn";
            // 
            // btnBifoga
            // 
            this.btnBifoga.Location = new System.Drawing.Point(333, 98);
            this.btnBifoga.Name = "btnBifoga";
            this.btnBifoga.Size = new System.Drawing.Size(67, 26);
            this.btnBifoga.TabIndex = 8;
            this.btnBifoga.Text = "Bifoga";
            this.btnBifoga.UseVisualStyleBackColor = true;
            this.btnBifoga.Click += new System.EventHandler(this.btnBifoga_Click);
            // 
            // btnLoggaUt
            // 
            this.btnLoggaUt.Location = new System.Drawing.Point(442, 336);
            this.btnLoggaUt.Name = "btnLoggaUt";
            this.btnLoggaUt.Size = new System.Drawing.Size(75, 23);
            this.btnLoggaUt.TabIndex = 9;
            this.btnLoggaUt.Text = "Logga ut";
            this.btnLoggaUt.UseVisualStyleBackColor = true;
            this.btnLoggaUt.Click += new System.EventHandler(this.btnLoggaUt_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(593, 371);
            this.Controls.Add(this.btnLoggaUt);
            this.Controls.Add(this.btnBifoga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxAnvändarnamn);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.btnSkicka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMeddelande);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxInkorg);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInkorg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMeddelande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.TextBox tbxAnvändarnamn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBifoga;
        private System.Windows.Forms.Button btnLoggaUt;
    }
}