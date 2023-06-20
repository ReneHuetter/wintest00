namespace WinPoolV01
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.Label areaLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label lengthLabel;
            System.Windows.Forms.Label volumeLabel;
            System.Windows.Forms.Label widthLabel;
            this.poolBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.poolBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.bsPool = new System.Windows.Forms.BindingSource(this.components);
            areaLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            lengthLabel = new System.Windows.Forms.Label();
            volumeLabel = new System.Windows.Forms.Label();
            widthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poolBindingNavigator)).BeginInit();
            this.poolBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPool)).BeginInit();
            this.SuspendLayout();
            // 
            // poolBindingNavigator
            // 
            this.poolBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.poolBindingNavigator.BindingSource = this.bsPool;
            this.poolBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.poolBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.poolBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.poolBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.poolBindingNavigatorSaveItem});
            this.poolBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.poolBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.poolBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.poolBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.poolBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.poolBindingNavigator.Name = "poolBindingNavigator";
            this.poolBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.poolBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.poolBindingNavigator.Size = new System.Drawing.Size(764, 31);
            this.poolBindingNavigator.TabIndex = 0;
            this.poolBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(104, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 28);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // poolBindingNavigatorSaveItem
            // 
            this.poolBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.poolBindingNavigatorSaveItem.Enabled = false;
            this.poolBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("poolBindingNavigatorSaveItem.Image")));
            this.poolBindingNavigatorSaveItem.Name = "poolBindingNavigatorSaveItem";
            this.poolBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.poolBindingNavigatorSaveItem.Text = "Daten speichern";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new System.Drawing.Point(58, 323);
            areaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(67, 32);
            areaLabel.TabIndex = 7;
            areaLabel.Text = "Area:";
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPool, "Area", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.areaTextBox.Location = new System.Drawing.Point(169, 316);
            this.areaTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(212, 39);
            this.areaTextBox.TabIndex = 8;
            this.areaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(57, 95);
            heightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(91, 32);
            heightLabel.TabIndex = 1;
            heightLabel.Text = "Height:";
            // 
            // heightTextBox
            // 
            this.heightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPool, "Height", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.heightTextBox.Location = new System.Drawing.Point(168, 88);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(212, 39);
            this.heightTextBox.TabIndex = 2;
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new System.Drawing.Point(57, 148);
            lengthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new System.Drawing.Size(93, 32);
            lengthLabel.TabIndex = 3;
            lengthLabel.Text = "Length:";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPool, "Length", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.lengthTextBox.Location = new System.Drawing.Point(168, 141);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(212, 39);
            this.lengthTextBox.TabIndex = 4;
            this.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // volumeLabel
            // 
            volumeLabel.AutoSize = true;
            volumeLabel.Location = new System.Drawing.Point(57, 376);
            volumeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            volumeLabel.Name = "volumeLabel";
            volumeLabel.Size = new System.Drawing.Size(100, 32);
            volumeLabel.TabIndex = 9;
            volumeLabel.Text = "Volume:";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPool, "Volume", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.volumeTextBox.Location = new System.Drawing.Point(168, 369);
            this.volumeTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(212, 39);
            this.volumeTextBox.TabIndex = 10;
            this.volumeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new System.Drawing.Point(57, 195);
            widthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new System.Drawing.Size(83, 32);
            widthLabel.TabIndex = 5;
            widthLabel.Text = "Width:";
            // 
            // widthTextBox
            // 
            this.widthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPool, "Width", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.widthTextBox.Location = new System.Drawing.Point(169, 195);
            this.widthTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(212, 39);
            this.widthTextBox.TabIndex = 6;
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bsPool
            // 
            this.bsPool.DataSource = typeof(WinPoolV01.Pool);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 665);
            this.Controls.Add(areaLabel);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(heightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(lengthLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(volumeLabel);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(widthLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.poolBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(780, 704);
            this.Name = "FrmMain";
            this.Text = "Pool Berechnung";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poolBindingNavigator)).EndInit();
            this.poolBindingNavigator.ResumeLayout(false);
            this.poolBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsPool;
        private System.Windows.Forms.BindingNavigator poolBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton poolBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
    }
}

