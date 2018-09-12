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
            this.NumeroIncognitas = new System.Windows.Forms.Label();
            this.NumeroEcuaciones = new System.Windows.Forms.Label();
            this.txtboxNumeroIncognitas = new System.Windows.Forms.TextBox();
            this.txtboxNumeroEcuaciones = new System.Windows.Forms.TextBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.labelGaussJordan = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.GrillaResultado = new System.Windows.Forms.DataGridView();
            this.Resultado = new System.Windows.Forms.Label();
            this.btnLimpiarPantalla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // NumeroIncognitas
            // 
            this.NumeroIncognitas.AutoSize = true;
            this.NumeroIncognitas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroIncognitas.Location = new System.Drawing.Point(108, 81);
            this.NumeroIncognitas.Name = "NumeroIncognitas";
            this.NumeroIncognitas.Size = new System.Drawing.Size(202, 18);
            this.NumeroIncognitas.TabIndex = 39;
            this.NumeroIncognitas.Text = "NUMERO DE INCOGNITAS";
            // 
            // NumeroEcuaciones
            // 
            this.NumeroEcuaciones.AutoSize = true;
            this.NumeroEcuaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroEcuaciones.Location = new System.Drawing.Point(108, 115);
            this.NumeroEcuaciones.Name = "NumeroEcuaciones";
            this.NumeroEcuaciones.Size = new System.Drawing.Size(213, 18);
            this.NumeroEcuaciones.TabIndex = 40;
            this.NumeroEcuaciones.Text = "NUMERO DE ECUACIONES";
            // 
            // txtboxNumeroIncognitas
            // 
            this.txtboxNumeroIncognitas.Location = new System.Drawing.Point(351, 81);
            this.txtboxNumeroIncognitas.Name = "txtboxNumeroIncognitas";
            this.txtboxNumeroIncognitas.Size = new System.Drawing.Size(100, 20);
            this.txtboxNumeroIncognitas.TabIndex = 41;
            // 
            // txtboxNumeroEcuaciones
            // 
            this.txtboxNumeroEcuaciones.Location = new System.Drawing.Point(351, 113);
            this.txtboxNumeroEcuaciones.Name = "txtboxNumeroEcuaciones";
            this.txtboxNumeroEcuaciones.Size = new System.Drawing.Size(100, 20);
            this.txtboxNumeroEcuaciones.TabIndex = 42;
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(91, 158);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(525, 130);
            this.Grilla.TabIndex = 43;
            this.Grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellContentClick);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAplicar.Location = new System.Drawing.Point(473, 81);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(128, 54);
            this.btnAplicar.TabIndex = 44;
            this.btnAplicar.Text = "APLICAR";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // labelGaussJordan
            // 
            this.labelGaussJordan.AutoSize = true;
            this.labelGaussJordan.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGaussJordan.Location = new System.Drawing.Point(212, 30);
            this.labelGaussJordan.Name = "labelGaussJordan";
            this.labelGaussJordan.Size = new System.Drawing.Size(286, 24);
            this.labelGaussJordan.TabIndex = 46;
            this.labelGaussJordan.Text = "METODO GAUSS - JORDAN";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnCalcular.Location = new System.Drawing.Point(280, 294);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(152, 62);
            this.btnCalcular.TabIndex = 47;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // GrillaResultado
            // 
            this.GrillaResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaResultado.Location = new System.Drawing.Point(91, 430);
            this.GrillaResultado.Name = "GrillaResultado";
            this.GrillaResultado.Size = new System.Drawing.Size(525, 61);
            this.GrillaResultado.TabIndex = 48;
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Resultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Resultado.Location = new System.Drawing.Point(27, 374);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(651, 40);
            this.Resultado.TabIndex = 49;
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiarPantalla
            // 
            this.btnLimpiarPantalla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPantalla.Location = new System.Drawing.Point(634, 12);
            this.btnLimpiarPantalla.Name = "btnLimpiarPantalla";
            this.btnLimpiarPantalla.Size = new System.Drawing.Size(208, 32);
            this.btnLimpiarPantalla.TabIndex = 50;
            this.btnLimpiarPantalla.Text = "LIMPIAR PANTALLA";
            this.btnLimpiarPantalla.UseVisualStyleBackColor = true;
            this.btnLimpiarPantalla.Click += new System.EventHandler(this.btnLimpiarPantalla_Click);
            // 
            // FormularioGaussJordan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 551);
            this.Controls.Add(this.btnLimpiarPantalla);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.GrillaResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labelGaussJordan);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.txtboxNumeroEcuaciones);
            this.Controls.Add(this.txtboxNumeroIncognitas);
            this.Controls.Add(this.NumeroEcuaciones);
            this.Controls.Add(this.NumeroIncognitas);
            this.Name = "FormularioGaussJordan";
            this.Text = "FormularioGaussJordan";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeroIncognitas;
        private System.Windows.Forms.Label NumeroEcuaciones;
        private System.Windows.Forms.TextBox txtboxNumeroIncognitas;
        private System.Windows.Forms.TextBox txtboxNumeroEcuaciones;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label labelGaussJordan;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView GrillaResultado;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button btnLimpiarPantalla;
    }
}