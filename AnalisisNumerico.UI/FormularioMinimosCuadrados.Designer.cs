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
            this.labelRegresion = new System.Windows.Forms.Label();
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
            this.txtboxPendiente = new System.Windows.Forms.TextBox();
            this.labelPendiente = new System.Windows.Forms.Label();
            this.txtboxOrdenada = new System.Windows.Forms.TextBox();
            this.labelOrdenada = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegresion
            // 
            this.labelRegresion.AutoSize = true;
            this.labelRegresion.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegresion.Location = new System.Drawing.Point(277, 70);
            this.labelRegresion.Name = "labelRegresion";
            this.labelRegresion.Size = new System.Drawing.Size(213, 24);
            this.labelRegresion.TabIndex = 76;
            this.labelRegresion.Text = "REGRESION LINEAL";
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
            this.Grilla.Location = new System.Drawing.Point(31, 155);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(253, 324);
            this.Grilla.TabIndex = 80;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnCalcular.Location = new System.Drawing.Point(294, 189);
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
            this.Resultado.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.Resultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Resultado.Location = new System.Drawing.Point(499, 311);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(316, 40);
            this.Resultado.TabIndex = 82;
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxPendiente
            // 
            this.txtboxPendiente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPendiente.Location = new System.Drawing.Point(715, 387);
            this.txtboxPendiente.Name = "txtboxPendiente";
            this.txtboxPendiente.Size = new System.Drawing.Size(100, 26);
            this.txtboxPendiente.TabIndex = 84;
            // 
            // labelPendiente
            // 
            this.labelPendiente.AutoSize = true;
            this.labelPendiente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendiente.Location = new System.Drawing.Point(500, 391);
            this.labelPendiente.Name = "labelPendiente";
            this.labelPendiente.Size = new System.Drawing.Size(98, 18);
            this.labelPendiente.TabIndex = 83;
            this.labelPendiente.Text = "PENDIENTE";
            // 
            // txtboxOrdenada
            // 
            this.txtboxOrdenada.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxOrdenada.Location = new System.Drawing.Point(715, 436);
            this.txtboxOrdenada.Name = "txtboxOrdenada";
            this.txtboxOrdenada.Size = new System.Drawing.Size(100, 26);
            this.txtboxOrdenada.TabIndex = 86;
            // 
            // labelOrdenada
            // 
            this.labelOrdenada.AutoSize = true;
            this.labelOrdenada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenada.Location = new System.Drawing.Point(500, 440);
            this.labelOrdenada.Name = "labelOrdenada";
            this.labelOrdenada.Size = new System.Drawing.Size(184, 18);
            this.labelOrdenada.TabIndex = 85;
            this.labelOrdenada.Text = "ORDENADA AL ORIGEN";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(604, 272);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(114, 18);
            this.labelResultado.TabIndex = 87;
            this.labelResultado.Text = "RESULTADOS";
            // 
            // FormularioMinimosCuadrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 609);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.txtboxOrdenada);
            this.Controls.Add(this.labelOrdenada);
            this.Controls.Add(this.txtboxPendiente);
            this.Controls.Add(this.labelPendiente);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.txtboxCantidadValores);
            this.Controls.Add(this.CantidadValores);
            this.Controls.Add(this.labelRegresion);
            this.Controls.Add(this.Metodo);
            this.Controls.Add(this.comboMetodo);
            this.Controls.Add(this.btnLimpiarPantalla);
            this.Controls.Add(this.labelGaussJordan);
            this.Name = "FormularioMinimosCuadrados";
            this.Text = "FormularioMinimosCuadrados";
            this.Load += new System.EventHandler(this.FormularioMinimosCuadrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegresion;
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
        private System.Windows.Forms.TextBox txtboxPendiente;
        private System.Windows.Forms.Label labelPendiente;
        private System.Windows.Forms.TextBox txtboxOrdenada;
        private System.Windows.Forms.Label labelOrdenada;
        private System.Windows.Forms.Label labelResultado;
    }
}