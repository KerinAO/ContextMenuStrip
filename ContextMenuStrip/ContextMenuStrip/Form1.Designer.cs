namespace ContextMenuStrip
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtLijevi = new System.Windows.Forms.TextBox();
            this.txtDesni = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLijevi
            // 
            this.txtLijevi.ContextMenuStrip = this.contextMenuStrip1;
            this.txtLijevi.Location = new System.Drawing.Point(82, 94);
            this.txtLijevi.Name = "txtLijevi";
            this.txtLijevi.Size = new System.Drawing.Size(100, 20);
            this.txtLijevi.TabIndex = 0;
            // 
            // txtDesni
            // 
            this.txtDesni.ContextMenuStrip = this.contextMenuStrip1;
            this.txtDesni.Location = new System.Drawing.Point(334, 94);
            this.txtDesni.Name = "txtDesni";
            this.txtDesni.Size = new System.Drawing.Size(100, 20);
            this.txtDesni.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoToolStripMenuItem,
            this.desnoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // lijevoToolStripMenuItem
            // 
            this.lijevoToolStripMenuItem.Name = "lijevoToolStripMenuItem";
            this.lijevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.lijevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lijevoToolStripMenuItem.Text = "Lijevo";
            this.lijevoToolStripMenuItem.Click += new System.EventHandler(this.lijevoToolStripMenuItem_Click);
            // 
            // desnoToolStripMenuItem
            // 
            this.desnoToolStripMenuItem.Name = "desnoToolStripMenuItem";
            this.desnoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.desnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desnoToolStripMenuItem.Text = "Desno";
            this.desnoToolStripMenuItem.Click += new System.EventHandler(this.desnoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 204);
            this.Controls.Add(this.txtDesni);
            this.Controls.Add(this.txtLijevi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLijevi;
        private System.Windows.Forms.TextBox txtDesni;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lijevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoToolStripMenuItem;
    }
}

