namespace AnalisisNumerico.UI
{
    partial class FormularioMetodosAbiertos
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
            this.labelErrorResultado = new System.Windows.Forms.Label();
            this.labelIteracionesResultado = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelIteraciones = new System.Windows.Forms.Label();
            this.labelRaiz = new System.Windows.Forms.Label();
            this.labelDetalles = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelTangente = new System.Windows.Forms.Label();
            this.Metodo = new System.Windows.Forms.Label();
            this.comboMetodo = new System.Windows.Forms.ComboBox();
            this.labelSecante = new System.Windows.Forms.Label();
            this.txtRaiz = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labelLimiteMaximo = new System.Windows.Forms.Label();
            this.txtboxLimiteMaximo = new System.Windows.Forms.TextBox();
            this.labelLimiteMinimo = new System.Windows.Forms.Label();
            this.txtboxLimiteMinimo = new System.Windows.Forms.TextBox();
            this.Iteraciones = new System.Windows.Forms.Label();
            this.txtboxIteraciones = new System.Windows.Forms.TextBox();
            this.Tolerancia = new System.Windows.Forms.Label();
            this.txtboxTolerancia = new System.Windows.Forms.TextBox();
            this.Funcion = new System.Windows.Forms.Label();
            this.txtboxFuncion = new System.Windows.Forms.TextBox();
            this.btnLimpiarPantalla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelErrorResultado
            // 
            this.labelErrorResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelErrorResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorResultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelErrorResultado.Location = new System.Drawing.Point(540, 400);
            this.labelErrorResultado.Name = "labelErrorResultado";
            this.labelErrorResultado.Size = new System.Drawing.Size(90, 30);
            this.labelErrorResultado.TabIndex = 46;
            this.labelErrorResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIteracionesResultado
            // 
            this.labelIteracionesResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelIteracionesResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIteracionesResultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelIteracionesResultado.Location = new System.Drawing.Point(375, 400);
            this.labelIteracionesResultado.Name = "labelIteracionesResultado";
            this.labelIteracionesResultado.Size = new System.Drawing.Size(150, 30);
            this.labelIteracionesResultado.TabIndex = 45;
            this.labelIteracionesResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelError.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelError.Location = new System.Drawing.Point(540, 350);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(90, 40);
            this.labelError.TabIndex = 44;
            this.labelError.Text = "ERROR";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIteraciones
            // 
            this.labelIteraciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelIteraciones.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIteraciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelIteraciones.Location = new System.Drawing.Point(375, 350);
            this.labelIteraciones.Name = "labelIteraciones";
            this.labelIteraciones.Size = new System.Drawing.Size(150, 40);
            this.labelIteraciones.TabIndex = 43;
            this.labelIteraciones.Text = "ITERACIONES";
            this.labelIteraciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRaiz
            // 
            this.labelRaiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRaiz.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaiz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelRaiz.Location = new System.Drawing.Point(271, 351);
            this.labelRaiz.Name = "labelRaiz";
            this.labelRaiz.Size = new System.Drawing.Size(90, 40);
            this.labelRaiz.TabIndex = 42;
            this.labelRaiz.Text = "RAIZ";
            this.labelRaiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDetalles
            // 
            this.labelDetalles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDetalles.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDetalles.Location = new System.Drawing.Point(126, 351);
            this.labelDetalles.Name = "labelDetalles";
            this.labelDetalles.Size = new System.Drawing.Size(139, 79);
            this.labelDetalles.TabIndex = 41;
            this.labelDetalles.Text = "DETALLES";
            this.labelDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResultado
            // 
            this.labelResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResultado.Location = new System.Drawing.Point(87, 292);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(571, 40);
            this.labelResultado.TabIndex = 40;
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTangente
            // 
            this.labelTangente.AutoSize = true;
            this.labelTangente.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTangente.Location = new System.Drawing.Point(109, 87);
            this.labelTangente.Name = "labelTangente";
            this.labelTangente.Size = new System.Drawing.Size(578, 24);
            this.labelTangente.TabIndex = 39;
            this.labelTangente.Text = "METODOS ABIERTOS - NEWTON-RAPHSON (TANGENTE)";
            // 
            // Metodo
            // 
            this.Metodo.AutoSize = true;
            this.Metodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metodo.Location = new System.Drawing.Point(55, 33);
            this.Metodo.Name = "Metodo";
            this.Metodo.Size = new System.Drawing.Size(77, 18);
            this.Metodo.TabIndex = 38;
            this.Metodo.Text = "METODO";
            // 
            // comboMetodo
            // 
            this.comboMetodo.FormattingEnabled = true;
            this.comboMetodo.Location = new System.Drawing.Point(168, 33);
            this.comboMetodo.Name = "comboMetodo";
            this.comboMetodo.Size = new System.Drawing.Size(198, 21);
            this.comboMetodo.TabIndex = 37;
            this.comboMetodo.SelectedIndexChanged += new System.EventHandler(this.comboMetodo_SelectedIndexChanged);
            // 
            // labelSecante
            // 
            this.labelSecante.AutoSize = true;
            this.labelSecante.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecante.Location = new System.Drawing.Point(225, 87);
            this.labelSecante.Name = "labelSecante";
            this.labelSecante.Size = new System.Drawing.Size(345, 24);
            this.labelSecante.TabIndex = 36;
            this.labelSecante.Text = "METODOS ABIERTOS - SECANTE";
            // 
            // txtRaiz
            // 
            this.txtRaiz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaiz.Location = new System.Drawing.Point(275, 404);
            this.txtRaiz.Name = "txtRaiz";
            this.txtRaiz.Size = new System.Drawing.Size(86, 26);
            this.txtRaiz.TabIndex = 35;
            this.txtRaiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(432, 219);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(226, 44);
            this.btnCalcular.TabIndex = 34;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // labelLimiteMaximo
            // 
            this.labelLimiteMaximo.AutoSize = true;
            this.labelLimiteMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLimiteMaximo.Location = new System.Drawing.Point(429, 183);
            this.labelLimiteMaximo.Name = "labelLimiteMaximo";
            this.labelLimiteMaximo.Size = new System.Drawing.Size(123, 18);
            this.labelLimiteMaximo.TabIndex = 33;
            this.labelLimiteMaximo.Text = "LIMITE MAXIMO";
            // 
            // txtboxLimiteMaximo
            // 
            this.txtboxLimiteMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLimiteMaximo.Location = new System.Drawing.Point(558, 180);
            this.txtboxLimiteMaximo.Name = "txtboxLimiteMaximo";
            this.txtboxLimiteMaximo.Size = new System.Drawing.Size(100, 26);
            this.txtboxLimiteMaximo.TabIndex = 32;
            // 
            // labelLimiteMinimo
            // 
            this.labelLimiteMinimo.AutoSize = true;
            this.labelLimiteMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLimiteMinimo.Location = new System.Drawing.Point(429, 140);
            this.labelLimiteMinimo.Name = "labelLimiteMinimo";
            this.labelLimiteMinimo.Size = new System.Drawing.Size(115, 18);
            this.labelLimiteMinimo.TabIndex = 31;
            this.labelLimiteMinimo.Text = "LIMITE MINIMO";
            // 
            // txtboxLimiteMinimo
            // 
            this.txtboxLimiteMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLimiteMinimo.Location = new System.Drawing.Point(558, 139);
            this.txtboxLimiteMinimo.Name = "txtboxLimiteMinimo";
            this.txtboxLimiteMinimo.Size = new System.Drawing.Size(100, 26);
            this.txtboxLimiteMinimo.TabIndex = 30;
            // 
            // Iteraciones
            // 
            this.Iteraciones.AutoSize = true;
            this.Iteraciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iteraciones.Location = new System.Drawing.Point(88, 233);
            this.Iteraciones.Name = "Iteraciones";
            this.Iteraciones.Size = new System.Drawing.Size(113, 18);
            this.Iteraciones.TabIndex = 29;
            this.Iteraciones.Text = "ITERACIONES";
            // 
            // txtboxIteraciones
            // 
            this.txtboxIteraciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIteraciones.Location = new System.Drawing.Point(214, 228);
            this.txtboxIteraciones.Name = "txtboxIteraciones";
            this.txtboxIteraciones.Size = new System.Drawing.Size(198, 26);
            this.txtboxIteraciones.TabIndex = 28;
            // 
            // Tolerancia
            // 
            this.Tolerancia.AutoSize = true;
            this.Tolerancia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tolerancia.Location = new System.Drawing.Point(88, 182);
            this.Tolerancia.Name = "Tolerancia";
            this.Tolerancia.Size = new System.Drawing.Size(108, 18);
            this.Tolerancia.TabIndex = 27;
            this.Tolerancia.Text = "TOLERANCIA";
            // 
            // txtboxTolerancia
            // 
            this.txtboxTolerancia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTolerancia.Location = new System.Drawing.Point(214, 182);
            this.txtboxTolerancia.Name = "txtboxTolerancia";
            this.txtboxTolerancia.Size = new System.Drawing.Size(198, 26);
            this.txtboxTolerancia.TabIndex = 26;
            // 
            // Funcion
            // 
            this.Funcion.AutoSize = true;
            this.Funcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Funcion.Location = new System.Drawing.Point(88, 140);
            this.Funcion.Name = "Funcion";
            this.Funcion.Size = new System.Drawing.Size(78, 18);
            this.Funcion.TabIndex = 25;
            this.Funcion.Text = "FUNCION";
            // 
            // txtboxFuncion
            // 
            this.txtboxFuncion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFuncion.Location = new System.Drawing.Point(214, 140);
            this.txtboxFuncion.Name = "txtboxFuncion";
            this.txtboxFuncion.Size = new System.Drawing.Size(198, 26);
            this.txtboxFuncion.TabIndex = 24;
            // 
            // btnLimpiarPantalla
            // 
            this.btnLimpiarPantalla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPantalla.Location = new System.Drawing.Point(564, 2);
            this.btnLimpiarPantalla.Name = "btnLimpiarPantalla";
            this.btnLimpiarPantalla.Size = new System.Drawing.Size(208, 32);
            this.btnLimpiarPantalla.TabIndex = 47;
            this.btnLimpiarPantalla.Text = "LIMPIAR PANTALLA";
            this.btnLimpiarPantalla.UseVisualStyleBackColor = true;
            this.btnLimpiarPantalla.Click += new System.EventHandler(this.btnLimpiarPantalla_Click);
            // 
            // FormularioMetodosAbiertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 461);
            this.Controls.Add(this.btnLimpiarPantalla);
            this.Controls.Add(this.labelErrorResultado);
            this.Controls.Add(this.labelIteracionesResultado);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelIteraciones);
            this.Controls.Add(this.labelRaiz);
            this.Controls.Add(this.labelDetalles);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelTangente);
            this.Controls.Add(this.Metodo);
            this.Controls.Add(this.comboMetodo);
            this.Controls.Add(this.labelSecante);
            this.Controls.Add(this.txtRaiz);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labelLimiteMaximo);
            this.Controls.Add(this.txtboxLimiteMaximo);
            this.Controls.Add(this.labelLimiteMinimo);
            this.Controls.Add(this.txtboxLimiteMinimo);
            this.Controls.Add(this.Iteraciones);
            this.Controls.Add(this.txtboxIteraciones);
            this.Controls.Add(this.Tolerancia);
            this.Controls.Add(this.txtboxTolerancia);
            this.Controls.Add(this.Funcion);
            this.Controls.Add(this.txtboxFuncion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FormularioMetodosAbiertos";
            this.Text = "METODOS ABIERTOS";
            this.Load += new System.EventHandler(this.FormularioMetodosAbiertos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErrorResultado;
        private System.Windows.Forms.Label labelIteracionesResultado;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelIteraciones;
        private System.Windows.Forms.Label labelRaiz;
        private System.Windows.Forms.Label labelDetalles;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelTangente;
        private System.Windows.Forms.Label Metodo;
        private System.Windows.Forms.ComboBox comboMetodo;
        private System.Windows.Forms.Label labelSecante;
        private System.Windows.Forms.TextBox txtRaiz;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label labelLimiteMaximo;
        private System.Windows.Forms.TextBox txtboxLimiteMaximo;
        private System.Windows.Forms.Label labelLimiteMinimo;
        private System.Windows.Forms.TextBox txtboxLimiteMinimo;
        private System.Windows.Forms.Label Iteraciones;
        private System.Windows.Forms.TextBox txtboxIteraciones;
        private System.Windows.Forms.Label Tolerancia;
        private System.Windows.Forms.TextBox txtboxTolerancia;
        private System.Windows.Forms.Label Funcion;
        private System.Windows.Forms.TextBox txtboxFuncion;
        private System.Windows.Forms.Button btnLimpiarPantalla;
    }
}