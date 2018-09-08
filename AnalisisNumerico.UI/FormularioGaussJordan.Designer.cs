namespace AnalisisNumerico.UI
{
    partial class FormularioGaussJordan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Incognita1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incognita2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incognita3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Incognita1,
            this.Incognita2,
            this.Incognita3});
            this.dataGridView1.Location = new System.Drawing.Point(62, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Incognita1
            // 
            this.Incognita1.HeaderText = "Incognita1";
            this.Incognita1.Name = "Incognita1";
            // 
            // Incognita2
            // 
            this.Incognita2.HeaderText = "Incognita2";
            this.Incognita2.Name = "Incognita2";
            // 
            // Incognita3
            // 
            this.Incognita3.HeaderText = "Incognita3";
            this.Incognita3.Name = "Incognita3";
            // 
            // FormularioGaussJordan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 433);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormularioGaussJordan";
            this.Text = "FormularioGaussJordan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Incognita1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Incognita2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Incognita3;
    }
}