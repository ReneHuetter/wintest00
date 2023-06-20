namespace WinPool
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
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.NumericUpDown();
            this.lblHoehe = new System.Windows.Forms.Label();
            this.txtHoehe = new System.Windows.Forms.NumericUpDown();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoehe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(72, 52);
            this.lblModel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(100, 37);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model:";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModelName
            // 
            this.txtModelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelName.Location = new System.Drawing.Point(290, 43);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(245, 50);
            this.txtModelName.TabIndex = 1;
            // 
            // lblRadius
            // 
            this.lblRadius.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(71, 111);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(178, 45);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radius [m]:";
            // 
            // txtRadius
            // 
            this.txtRadius.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRadius.DecimalPlaces = 2;
            this.txtRadius.Location = new System.Drawing.Point(290, 111);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(243, 50);
            this.txtRadius.TabIndex = 3;
            this.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRadius.ThousandsSeparator = true;
            // 
            // lblHoehe
            // 
            this.lblHoehe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoehe.AutoSize = true;
            this.lblHoehe.Location = new System.Drawing.Point(72, 178);
            this.lblHoehe.Name = "lblHoehe";
            this.lblHoehe.Size = new System.Drawing.Size(152, 45);
            this.lblHoehe.TabIndex = 4;
            this.lblHoehe.Text = "Höhe[m]:";
            // 
            // txtHoehe
            // 
            this.txtHoehe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoehe.DecimalPlaces = 2;
            this.txtHoehe.Location = new System.Drawing.Point(290, 178);
            this.txtHoehe.Name = "txtHoehe";
            this.txtHoehe.Size = new System.Drawing.Size(245, 50);
            this.txtHoehe.TabIndex = 5;
            this.txtHoehe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHoehe.ThousandsSeparator = true;
            // 
            // lblVolumen
            // 
            this.lblVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(71, 276);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(213, 45);
            this.lblVolumen.TabIndex = 6;
            this.lblVolumen.Text = "Volumen[m³]:";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVolumen.Location = new System.Drawing.Point(290, 273);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(245, 50);
            this.txtVolumen.TabIndex = 7;
            this.txtVolumen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBerechnen.Location = new System.Drawing.Point(79, 352);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(164, 116);
            this.btnBerechnen.TabIndex = 8;
            this.btnBerechnen.Text = "Volumen Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 614);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.txtHoehe);
            this.Controls.Add(this.lblHoehe);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.lblModel);
            this.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MinimumSize = new System.Drawing.Size(900, 653);
            this.Name = "FrmMain";
            this.Text = "Pool Berechnung";
            ((System.ComponentModel.ISupportInitialize)(this.txtRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoehe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.NumericUpDown txtRadius;
        private System.Windows.Forms.Label lblHoehe;
        private System.Windows.Forms.NumericUpDown txtHoehe;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Button btnBerechnen;
    }
}

