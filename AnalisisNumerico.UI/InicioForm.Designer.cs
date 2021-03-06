﻿namespace AnalisisNumerico.UI
{
    partial class InicioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uNIDADIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mETODOSCERRADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mETODOSABIERTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sISTEMADEECUACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJUSTEDECURVASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNTEGRACIONNUMERICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNIDADIToolStripMenuItem,
            this.sISTEMADEECUACIONESToolStripMenuItem,
            this.aJUSTEDECURVASToolStripMenuItem,
            this.iNTEGRACIONNUMERICAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uNIDADIToolStripMenuItem
            // 
            this.uNIDADIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mETODOSCERRADOSToolStripMenuItem,
            this.mETODOSABIERTOSToolStripMenuItem});
            this.uNIDADIToolStripMenuItem.Name = "uNIDADIToolStripMenuItem";
            this.uNIDADIToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.uNIDADIToolStripMenuItem.Text = "RAICES DE FUNCIONES";
            // 
            // mETODOSCERRADOSToolStripMenuItem
            // 
            this.mETODOSCERRADOSToolStripMenuItem.Name = "mETODOSCERRADOSToolStripMenuItem";
            this.mETODOSCERRADOSToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.mETODOSCERRADOSToolStripMenuItem.Text = "METODOS CERRADOS";
            this.mETODOSCERRADOSToolStripMenuItem.Click += new System.EventHandler(this.MetodosCerradosToolStripMenuItem_Click);
            // 
            // mETODOSABIERTOSToolStripMenuItem
            // 
            this.mETODOSABIERTOSToolStripMenuItem.Name = "mETODOSABIERTOSToolStripMenuItem";
            this.mETODOSABIERTOSToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.mETODOSABIERTOSToolStripMenuItem.Text = "METODOS ABIERTOS";
            this.mETODOSABIERTOSToolStripMenuItem.Click += new System.EventHandler(this.mETODOSABIERTOSToolStripMenuItem_Click);
            // 
            // sISTEMADEECUACIONESToolStripMenuItem
            // 
            this.sISTEMADEECUACIONESToolStripMenuItem.Name = "sISTEMADEECUACIONESToolStripMenuItem";
            this.sISTEMADEECUACIONESToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.sISTEMADEECUACIONESToolStripMenuItem.Text = "SISTEMA DE ECUACIONES";
            this.sISTEMADEECUACIONESToolStripMenuItem.Click += new System.EventHandler(this.sISTEMADEECUACIONESToolStripMenuItem_Click);
            // 
            // aJUSTEDECURVASToolStripMenuItem
            // 
            this.aJUSTEDECURVASToolStripMenuItem.Name = "aJUSTEDECURVASToolStripMenuItem";
            this.aJUSTEDECURVASToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aJUSTEDECURVASToolStripMenuItem.Text = "AJUSTE DE CURVAS";
            this.aJUSTEDECURVASToolStripMenuItem.Click += new System.EventHandler(this.aJUSTEDECURVASToolStripMenuItem_Click);
            // 
            // iNTEGRACIONNUMERICAToolStripMenuItem
            // 
            this.iNTEGRACIONNUMERICAToolStripMenuItem.Name = "iNTEGRACIONNUMERICAToolStripMenuItem";
            this.iNTEGRACIONNUMERICAToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.iNTEGRACIONNUMERICAToolStripMenuItem.Text = "INTEGRACION NUMERICA";
            this.iNTEGRACIONNUMERICAToolStripMenuItem.Click += new System.EventHandler(this.iNTEGRACIONNUMERICAToolStripMenuItem_Click);
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InicioForm";
            this.Text = "ANALISIS NUMERICO";
            this.Load += new System.EventHandler(this.InicioForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uNIDADIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mETODOSCERRADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mETODOSABIERTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sISTEMADEECUACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJUSTEDECURVASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNTEGRACIONNUMERICAToolStripMenuItem;
    }
}