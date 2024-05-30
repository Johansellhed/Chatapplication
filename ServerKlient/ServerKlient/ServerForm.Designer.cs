namespace ServerKlient
{
    partial class ServerForm
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
            this.btnStarta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxInkorg
            // 
            this.tbxInkorg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbxInkorg.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbxInkorg.Location = new System.Drawing.Point(0, 0);
            this.tbxInkorg.Multiline = true;
            this.tbxInkorg.Name = "tbxInkorg";
            this.tbxInkorg.ReadOnly = true;
            this.tbxInkorg.Size = new System.Drawing.Size(191, 450);
            this.tbxInkorg.TabIndex = 0;
    
            // 
            // btnStarta
            // 
            this.btnStarta.BackColor = System.Drawing.Color.IndianRed;
            this.btnStarta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStarta.Location = new System.Drawing.Point(614, 0);
            this.btnStarta.Name = "btnStarta";
            this.btnStarta.Size = new System.Drawing.Size(186, 450);
            this.btnStarta.TabIndex = 1;
            this.btnStarta.Text = "Starta Server";
            this.btnStarta.UseVisualStyleBackColor = false;
            this.btnStarta.Click += new System.EventHandler(this.btnStarta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chat Logs";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStarta);
            this.Controls.Add(this.tbxInkorg);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInkorg;
        private System.Windows.Forms.Button btnStarta;
        private System.Windows.Forms.Label label1;
    }
}