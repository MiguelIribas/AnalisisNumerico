namespace AnalisisNumerico.UI
{
    partial class FormularioMinimosCuadrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMinimosCuadrados));
            this.labelLineal = new System.Windows.Forms.Label();
            this.Metodo = new System.Windows.Forms.Label();
            this.comboMetodo = new System.Windows.Forms.ComboBox();
            this.btnLimpiarPantalla = new System.Windows.Forms.Button();
            this.labelGaussJordan = new System.Windows.Forms.Label();
            this.txtboxCantidadValores = new System.Windows.Forms.TextBox();
            this.CantidadValores = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.txtboxRecta = new System.Windows.Forms.TextBox();
            this.labelRecta = new System.Windows.Forms.Label();
            this.labelAjuste = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelResultadoAjuste = new System.Windows.Forms.Label();
            this.labelGrado = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.labelCoeficiente = new System.Windows.Forms.Label();
            this.labelResultadoCoeficiente = new System.Windows.Forms.Label();
            this.labelPolinomial = new System.Windows.Forms.Label();
            this.labelLagrange = new System.Windows.Forms.Label();
            this.labelValorX = new System.Windows.Forms.Label();
            this.textBoxValorX = new System.Windows.Forms.TextBox();
            this.labelImagenYResultado = new System.Windows.Forms.Label();
            this.labelImagenY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLineal
            // 
            this.labelLineal.AutoSize = true;
            this.labelLineal.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineal.Location = new System.Drawing.Point(277, 70);
            this.labelLineal.Name = "labelLineal";
            this.labelLineal.Size = new System.Drawing.Size(213, 24);
            this.labelLineal.TabIndex = 76;
            this.labelLineal.Text = "REGRESION LINEAL";
            // 
            // Metodo
            // 
            this.Metodo.AutoSize = true;
            this.Metodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metodo.Location = new System.Drawing.Point(28, 16);
            this.Metodo.Name = "Metodo";
            this.Metodo.Size = new System.Drawing.Size(77, 18);
            this.Metodo.TabIndex = 75;
            this.Metodo.Text = "METODO";
            // 
            // comboMetodo
            // 
            this.comboMetodo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMetodo.FormattingEnabled = true;
            this.comboMetodo.Location = new System.Drawing.Point(124, 12);
            this.comboMetodo.Name = "comboMetodo";
            this.comboMetodo.Size = new System.Drawing.Size(198, 28);
            this.comboMetodo.TabIndex = 74;
            this.comboMetodo.SelectedIndexChanged += new System.EventHandler(this.comboMetodo_SelectedIndexChanged);
            // 
            // btnLimpiarPantalla
            // 
            this.btnLimpiarPantalla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPantalla.Location = new System.Drawing.Point(625, 32);
            this.btnLimpiarPantalla.Name = "btnLimpiarPantalla";
            this.btnLimpiarPantalla.Size = new System.Drawing.Size(208, 32);
            this.btnLimpiarPantalla.TabIndex = 73;
            this.btnLimpiarPantalla.Text = "LIMPIAR PANTALLA";
            this.btnLimpiarPantalla.UseVisualStyleBackColor = true;
            this.btnLimpiarPantalla.Click += new System.EventHandler(this.btnLimpiarPantalla_Click);
            // 
            // labelGaussJordan
            // 
            this.labelGaussJordan.AutoSize = true;
            this.labelGaussJordan.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGaussJordan.Location = new System.Drawing.Point(277, 70);
            this.labelGaussJordan.Name = "labelGaussJordan";
            this.labelGaussJordan.Size = new System.Drawing.Size(157, 24);
            this.labelGaussJordan.TabIndex = 72;
            this.labelGaussJordan.Text = "REGRESION ...";
            // 
            // txtboxCantidadValores
            // 
            this.txtboxCantidadValores.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCantidadValores.Location = new System.Drawing.Point(346, 117);
            this.txtboxCantidadValores.Name = "txtboxCantidadValores";
            this.txtboxCantidadValores.Size = new System.Drawing.Size(100, 26);
            this.txtboxCantidadValores.TabIndex = 78;
            // 
            // CantidadValores
            // 
            this.CantidadValores.AutoSize = true;
            this.CantidadValores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadValores.Location = new System.Drawing.Point(131, 121);
            this.CantidadValores.Name = "CantidadValores";
            this.CantidadValores.Size = new System.Drawing.Size(195, 18);
            this.CantidadValores.TabIndex = 77;
            this.CantidadValores.Text = "CANTIDAD DE VALORES";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAplicar.Location = new System.Drawing.Point(499, 102);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(152, 54);
            this.btnAplicar.TabIndex = 79;
            this.btnAplicar.Text = "APLICAR";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // Grilla
            // 
            this.Grilla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(12, 244);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(253, 324);
            this.Grilla.TabIndex = 80;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnCalcular.Location = new System.Drawing.Point(346, 189);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(152, 62);
            this.btnCalcular.TabIndex = 81;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Resultado.Font = new System.Drawing.Font("Arial", 15F);
            this.Resultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Resultado.Location = new System.Drawing.Point(473, 299);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(342, 64);
            this.Resultado.TabIndex = 82;
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxRecta
            // 
            this.txtboxRecta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRecta.Location = new System.Drawing.Point(556, 392);
            this.txtboxRecta.Name = "txtboxRecta";
            this.txtboxRecta.Size = new System.Drawing.Size(259, 32);
            this.txtboxRecta.TabIndex = 84;
            // 
            // labelRecta
            // 
            this.labelRecta.AutoSize = true;
            this.labelRecta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecta.Location = new System.Drawing.Point(299, 405);
            this.labelRecta.Name = "labelRecta";
            this.labelRecta.Size = new System.Drawing.Size(218, 19);
            this.labelRecta.TabIndex = 83;
            this.labelRecta.Text = "RECTA DE MEJOR AJUSTE";
            // 
            // labelAjuste
            // 
            this.labelAjuste.AutoSize = true;
            this.labelAjuste.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjuste.Location = new System.Drawing.Point(299, 460);
            this.labelAjuste.Name = "labelAjuste";
            this.labelAjuste.Size = new System.Drawing.Size(73, 19);
            this.labelAjuste.TabIndex = 85;
            this.labelAjuste.Text = "AJUSTE";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(299, 324);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(108, 19);
            this.labelResultado.TabIndex = 87;
            this.labelResultado.Text = "RESULTADO";
            // 
            // labelResultadoAjuste
            // 
            this.labelResultadoAjuste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResultadoAjuste.Font = new System.Drawing.Font("Arial", 15F);
            this.labelResultadoAjuste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResultadoAjuste.Location = new System.Drawing.Point(621, 439);
            this.labelResultadoAjuste.Name = "labelResultadoAjuste";
            this.labelResultadoAjuste.Size = new System.Drawing.Size(194, 40);
            this.labelResultadoAjuste.TabIndex = 88;
            this.labelResultadoAjuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGrado
            // 
            this.labelGrado.AutoSize = true;
            this.labelGrado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrado.Location = new System.Drawing.Point(131, 155);
            this.labelGrado.Name = "labelGrado";
            this.labelGrado.Size = new System.Drawing.Size(66, 18);
            this.labelGrado.TabIndex = 89;
            this.labelGrado.Text = "GRADO";
            // 
            // txtGrado
            // 
            this.txtGrado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrado.Location = new System.Drawing.Point(213, 151);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(100, 26);
            this.txtGrado.TabIndex = 90;
            // 
            // labelCoeficiente
            // 
            this.labelCoeficiente.AutoSize = true;
            this.labelCoeficiente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoeficiente.Location = new System.Drawing.Point(299, 507);
            this.labelCoeficiente.Name = "labelCoeficiente";
            this.labelCoeficiente.Size = new System.Drawing.Size(269, 19);
            this.labelCoeficiente.TabIndex = 91;
            this.labelCoeficiente.Text = "COEFICIENTE DE CORRELACION";
            // 
            // labelResultadoCoeficiente
            // 
            this.labelResultadoCoeficiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResultadoCoeficiente.Font = new System.Drawing.Font("Arial", 15F);
            this.labelResultadoCoeficiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResultadoCoeficiente.Location = new System.Drawing.Point(621, 494);
            this.labelResultadoCoeficiente.Name = "labelResultadoCoeficiente";
            this.labelResultadoCoeficiente.Size = new System.Drawing.Size(194, 40);
            this.labelResultadoCoeficiente.TabIndex = 92;
            this.labelResultadoCoeficiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPolinomial
            // 
            this.labelPolinomial.AutoSize = true;
            this.labelPolinomial.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPolinomial.Location = new System.Drawing.Point(250, 70);
            this.labelPolinomial.Name = "labelPolinomial";
            this.labelPolinomial.Size = new System.Drawing.Size(267, 24);
            this.labelPolinomial.TabIndex = 93;
            this.labelPolinomial.Text = "REGRESION POLINOMIAL";
            // 
            // labelLagrange
            // 
            this.labelLagrange.AutoSize = true;
            this.labelLagrange.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLagrange.Location = new System.Drawing.Point(250, 70);
            this.labelLagrange.Name = "labelLagrange";
            this.labelLagrange.Size = new System.Drawing.Size(285, 24);
            this.labelLagrange.TabIndex = 94;
            this.labelLagrange.Text = "POLINOMIO DE LAGRANGE";
            // 
            // labelValorX
            // 
            this.labelValorX.AutoSize = true;
            this.labelValorX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorX.Location = new System.Drawing.Point(131, 189);
            this.labelValorX.Name = "labelValorX";
            this.labelValorX.Size = new System.Drawing.Size(76, 18);
            this.labelValorX.TabIndex = 95;
            this.labelValorX.Text = "VALOR X";
            // 
            // textBoxValorX
            // 
            this.textBoxValorX.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorX.Location = new System.Drawing.Point(213, 185);
            this.textBoxValorX.Name = "textBoxValorX";
            this.textBoxValorX.Size = new System.Drawing.Size(100, 26);
            this.textBoxValorX.TabIndex = 96;
            // 
            // labelImagenYResultado
            // 
            this.labelImagenYResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelImagenYResultado.Font = new System.Drawing.Font("Arial", 15F);
            this.labelImagenYResultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelImagenYResultado.Location = new System.Drawing.Point(621, 549);
            this.labelImagenYResultado.Name = "labelImagenYResultado";
            this.labelImagenYResultado.Size = new System.Drawing.Size(194, 40);
            this.labelImagenYResultado.TabIndex = 98;
            this.labelImagenYResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelImagenYResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelImagenY
            // 
            this.labelImagenY.AutoSize = true;
            this.labelImagenY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagenY.Location = new System.Drawing.Point(299, 559);
            this.labelImagenY.Name = "labelImagenY";
            this.labelImagenY.Size = new System.Drawing.Size(78, 19);
            this.labelImagenY.TabIndex = 97;
            this.labelImagenY.Text = "VALOR Y";
            this.labelImagenY.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormularioMinimosCuadrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 609);
            this.Controls.Add(this.labelImagenYResultado);
            this.Controls.Add(this.labelImagenY);
            this.Controls.Add(this.textBoxValorX);
            this.Controls.Add(this.labelValorX);
            this.Controls.Add(this.labelLagrange);
            this.Controls.Add(this.labelPolinomial);
            this.Controls.Add(this.labelResultadoCoeficiente);
            this.Controls.Add(this.labelCoeficiente);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.labelGrado);
            this.Controls.Add(this.labelResultadoAjuste);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelAjuste);
            this.Controls.Add(this.txtboxRecta);
            this.Controls.Add(this.labelRecta);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.txtboxCantidadValores);
            this.Controls.Add(this.CantidadValores);
            this.Controls.Add(this.labelLineal);
            this.Controls.Add(this.Metodo);
            this.Controls.Add(this.comboMetodo);
            this.Controls.Add(this.btnLimpiarPantalla);
            this.Controls.Add(this.labelGaussJordan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioMinimosCuadrados";
            this.Load += new System.EventHandler(this.FormularioMinimosCuadrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLineal;
        private System.Windows.Forms.Label Metodo;
        private System.Windows.Forms.ComboBox comboMetodo;
        private System.Windows.Forms.Button btnLimpiarPantalla;
        private System.Windows.Forms.Label labelGaussJordan;
        private System.Windows.Forms.TextBox txtboxCantidadValores;
        private System.Windows.Forms.Label CantidadValores;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox txtboxRecta;
        private System.Windows.Forms.Label labelRecta;
        private System.Windows.Forms.Label labelAjuste;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelResultadoAjuste;
        private System.Windows.Forms.Label labelGrado;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.Label labelCoeficiente;
        private System.Windows.Forms.Label labelResultadoCoeficiente;
        private System.Windows.Forms.Label labelPolinomial;
        private System.Windows.Forms.Label labelLagrange;
        private System.Windows.Forms.Label labelValorX;
        private System.Windows.Forms.TextBox textBoxValorX;
        private System.Windows.Forms.Label labelImagenYResultado;
        private System.Windows.Forms.Label labelImagenY;
    }
}