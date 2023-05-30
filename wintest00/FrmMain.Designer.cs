namespace wintest00
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
            this.btn_say_Hello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_say_Hello
            // 
            this.btn_say_Hello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_say_Hello.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_say_Hello.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_say_Hello.Location = new System.Drawing.Point(308, 267);
            this.btn_say_Hello.Name = "btn_say_Hello";
            this.btn_say_Hello.Size = new System.Drawing.Size(214, 80);
            this.btn_say_Hello.TabIndex = 0;
            this.btn_say_Hello.Text = "Sag Hallo";
            this.btn_say_Hello.UseVisualStyleBackColor = false;
            this.btn_say_Hello.Click += new System.EventHandler(this.btn_say_Hello_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 359);
            this.Controls.Add(this.btn_say_Hello);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmMain";
            this.Text = "Klick Übung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_say_Hello;
    }
}

