﻿
namespace Grafico_Server
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
            this.avvia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.list_eventi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // avvia
            // 
            this.avvia.Location = new System.Drawing.Point(305, 148);
            this.avvia.Name = "avvia";
            this.avvia.Size = new System.Drawing.Size(173, 56);
            this.avvia.TabIndex = 0;
            this.avvia.Text = "AVVIA SERVER";
            this.avvia.UseVisualStyleBackColor = true;
            this.avvia.Click += new System.EventHandler(this.avvia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "SERVER";
            // 
            // list_eventi
            // 
            this.list_eventi.FormattingEnabled = true;
            this.list_eventi.Location = new System.Drawing.Point(191, 235);
            this.list_eventi.Name = "list_eventi";
            this.list_eventi.Size = new System.Drawing.Size(445, 186);
            this.list_eventi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_eventi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avvia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button avvia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_eventi;
    }
}
