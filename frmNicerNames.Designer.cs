namespace NicerNames
{
    partial class frmNicerNames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNicerNames));
            this.lblDrop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDrop
            // 
            this.lblDrop.AllowDrop = true;
            this.lblDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrop.Location = new System.Drawing.Point(12, 9);
            this.lblDrop.Name = "lblDrop";
            this.lblDrop.Size = new System.Drawing.Size(214, 23);
            this.lblDrop.TabIndex = 0;
            this.lblDrop.Text = "!! Drop File here !!";
            this.lblDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblDrop_DragDrop);
            this.lblDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblDrop_DragEnter);
            // 
            // frmNicerNames
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 49);
            this.Controls.Add(this.lblDrop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNicerNames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NicerNames";
            this.Load += new System.EventHandler(this.frmNicerNames_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDrop;
    }
}

