using System.Windows.Forms;

namespace WinBmi48
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblGewicht = new System.Windows.Forms.Label();
            this.txtGewichtKg = new System.Windows.Forms.TextBox();
            this.lblGroesseCm = new System.Windows.Forms.Label();
            this.txtGroesseCm = new System.Windows.Forms.TextBox();
            this.lblBmi = new System.Windows.Forms.Label();
            this.txtBmiErgebniss = new System.Windows.Forms.TextBox();
            this.bntBerechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGewicht
            // 
            this.lblGewicht.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGewicht.ForeColor = System.Drawing.Color.Green;
            this.lblGewicht.Image = global::WinBmi48.Properties.Resources.Balance;
            this.lblGewicht.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGewicht.Location = new System.Drawing.Point(12, 16);
            this.lblGewicht.Name = "lblGewicht";
            this.lblGewicht.Size = new System.Drawing.Size(192, 30);
            this.lblGewicht.TabIndex = 0;
            this.lblGewicht.Text = "Gewicht (Kg):";
            this.lblGewicht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGewichtKg
            // 
            this.txtGewichtKg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGewichtKg.ForeColor = System.Drawing.Color.Green;
            this.txtGewichtKg.Location = new System.Drawing.Point(17, 49);
            this.txtGewichtKg.Name = "txtGewichtKg";
            this.txtGewichtKg.Size = new System.Drawing.Size(525, 35);
            this.txtGewichtKg.TabIndex = 1;
            this.txtGewichtKg.Text = "83";
            this.txtGewichtKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGroesseCm
            // 
            this.lblGroesseCm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroesseCm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGroesseCm.Image = global::WinBmi48.Properties.Resources.height;
            this.lblGroesseCm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGroesseCm.Location = new System.Drawing.Point(12, 128);
            this.lblGroesseCm.Name = "lblGroesseCm";
            this.lblGroesseCm.Size = new System.Drawing.Size(192, 30);
            this.lblGroesseCm.TabIndex = 2;
            this.lblGroesseCm.Text = "Grösse(cm):";
            this.lblGroesseCm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGroesseCm
            // 
            this.txtGroesseCm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroesseCm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtGroesseCm.Location = new System.Drawing.Point(17, 161);
            this.txtGroesseCm.Name = "txtGroesseCm";
            this.txtGroesseCm.Size = new System.Drawing.Size(525, 35);
            this.txtGroesseCm.TabIndex = 3;
            this.txtGroesseCm.Text = "183";
            this.txtGroesseCm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBmi
            // 
            this.lblBmi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBmi.AutoSize = true;
            this.lblBmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBmi.Location = new System.Drawing.Point(12, 289);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(131, 30);
            this.lblBmi.TabIndex = 4;
            this.lblBmi.Text = "Dein BMI ist:";
            // 
            // txtBmiErgebniss
            // 
            this.txtBmiErgebniss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBmiErgebniss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtBmiErgebniss.Location = new System.Drawing.Point(12, 322);
            this.txtBmiErgebniss.Name = "txtBmiErgebniss";
            this.txtBmiErgebniss.Size = new System.Drawing.Size(525, 35);
            this.txtBmiErgebniss.TabIndex = 5;
            this.txtBmiErgebniss.Text = "-";
            this.txtBmiErgebniss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bntBerechnen
            // 
            this.bntBerechnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntBerechnen.Image = global::WinBmi48.Properties.Resources.okay;
            this.bntBerechnen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBerechnen.Location = new System.Drawing.Point(396, 415);
            this.bntBerechnen.Name = "bntBerechnen";
            this.bntBerechnen.Size = new System.Drawing.Size(146, 52);
            this.bntBerechnen.TabIndex = 6;
            this.bntBerechnen.Text = "Berechne";
            this.bntBerechnen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBerechnen.UseVisualStyleBackColor = true;
            this.bntBerechnen.Click += new System.EventHandler(this.bntBerechnen_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.bntBerechnen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 521);
            this.Controls.Add(this.bntBerechnen);
            this.Controls.Add(this.txtBmiErgebniss);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.txtGroesseCm);
            this.Controls.Add(this.lblGroesseCm);
            this.Controls.Add(this.txtGewichtKg);
            this.Controls.Add(this.lblGewicht);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(460, 560);
            this.Name = "FrmMain";
            this.Text = "BMI Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bntBerechnen;
        private TextBox txtBmiErgebniss;
        private Label lblBmi;
        private TextBox txtGroesseCm;
        private Label lblGroesseCm;
        private TextBox txtGewichtKg;
        private Label lblGewicht;
    }
}

