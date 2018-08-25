namespace AnalisisNumerico.UI
{
    partial class FormularioMetodosCerrados
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
            this.txtboxFuncion = new System.Windows.Forms.TextBox();
            this.Funcion = new System.Windows.Forms.Label();
            this.Tolerancia = new System.Windows.Forms.Label();
            this.txtboxTolerancia = new System.Windows.Forms.TextBox();
            this.Iteraciones = new System.Windows.Forms.Label();
            this.txtboxIteraciones = new System.Windows.Forms.TextBox();
            this.LimiteMaximo = new System.Windows.Forms.Label();
            this.txtboxLimiteMaximo = new System.Windows.Forms.TextBox();
            this.LimiteMinimo = new System.Windows.Forms.Label();
            this.txtboxLimiteMinimo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtRaiz = new System.Windows.Forms.TextBox();
            this.labelBiseccion = new System.Windows.Forms.Label();
            this.comboMetodo = new System.Windows.Forms.ComboBox();
            this.Metodo = new System.Windows.Forms.Label();
            this.labelReglaFalsa = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelDetalles = new System.Windows.Forms.Label();
            this.labelRaiz = new System.Windows.Forms.Label();
            this.labelIteraciones = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelIteracionesResultado = new System.Windows.Forms.Label();
            this.labelErrorResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxFuncion
            // 
            this.txtboxFuncion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFuncion.Location = new System.Drawing.Point(267, 142);
            this.txtboxFuncion.Name = "txtboxFuncion";
            this.txtboxFuncion.Size = new System.Drawing.Size(100, 26);
            this.txtboxFuncion.TabIndex = 0;
            // 
            // Funcion
            // 
            this.Funcion.AutoSize = true;
            this.Funcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Funcion.Location = new System.Drawing.Point(141, 142);
            this.Funcion.Name = "Funcion";
            this.Funcion.Size = new System.Drawing.Size(78, 18);
            this.Funcion.TabIndex = 1;
            this.Funcion.Text = "FUNCION";
            // 
            // Tolerancia
            // 
            this.Tolerancia.AutoSize = true;
            this.Tolerancia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tolerancia.Location = new System.Drawing.Point(141, 184);
            this.Tolerancia.Name = "Tolerancia";
            this.Tolerancia.Size = new System.Drawing.Size(108, 18);
            this.Tolerancia.TabIndex = 3;
            this.Tolerancia.Text = "TOLERANCIA";
            // 
            // txtboxTolerancia
            // 
            this.txtboxTolerancia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTolerancia.Location = new System.Drawing.Point(267, 184);
            this.txtboxTolerancia.Name = "txtboxTolerancia";
            this.txtboxTolerancia.Size = new System.Drawing.Size(100, 26);
            this.txtboxTolerancia.TabIndex = 2;
            // 
            // Iteraciones
            // 
            this.Iteraciones.AutoSize = true;
            this.Iteraciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iteraciones.Location = new System.Drawing.Point(141, 235);
            this.Iteraciones.Name = "Iteraciones";
            this.Iteraciones.Size = new System.Drawing.Size(113, 18);
            this.Iteraciones.TabIndex = 5;
            this.Iteraciones.Text = "ITERACIONES";
            // 
            // txtboxIteraciones
            // 
            this.txtboxIteraciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIteraciones.Location = new System.Drawing.Point(267, 230);
            this.txtboxIteraciones.Name = "txtboxIteraciones";
            this.txtboxIteraciones.Size = new System.Drawing.Size(100, 26);
            this.txtboxIteraciones.TabIndex = 4;
            // 
            // LimiteMaximo
            // 
            this.LimiteMaximo.AutoSize = true;
            this.LimiteMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimiteMaximo.Location = new System.Drawing.Point(413, 183);
            this.LimiteMaximo.Name = "LimiteMaximo";
            this.LimiteMaximo.Size = new System.Drawing.Size(123, 18);
            this.LimiteMaximo.TabIndex = 9;
            this.LimiteMaximo.Text = "LIMITE MAXIMO";
            // 
            // txtboxLimiteMaximo
            // 
            this.txtboxLimiteMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLimiteMaximo.Location = new System.Drawing.Point(542, 180);
            this.txtboxLimiteMaximo.Name = "txtboxLimiteMaximo";
            this.txtboxLimiteMaximo.Size = new System.Drawing.Size(100, 26);
            this.txtboxLimiteMaximo.TabIndex = 8;
            // 
            // LimiteMinimo
            // 
            this.LimiteMinimo.AutoSize = true;
            this.LimiteMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimiteMinimo.Location = new System.Drawing.Point(413, 140);
            this.LimiteMinimo.Name = "LimiteMinimo";
            this.LimiteMinimo.Size = new System.Drawing.Size(115, 18);
            this.LimiteMinimo.TabIndex = 7;
            this.LimiteMinimo.Text = "LIMITE MINIMO";
            // 
            // txtboxLimiteMinimo
            // 
            this.txtboxLimiteMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLimiteMinimo.Location = new System.Drawing.Point(542, 139);
            this.txtboxLimiteMinimo.Name = "txtboxLimiteMinimo";
            this.txtboxLimiteMinimo.Size = new System.Drawing.Size(100, 26);
            this.txtboxLimiteMinimo.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(416, 219);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(226, 44);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtRaiz
            // 
            this.txtRaiz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaiz.Location = new System.Drawing.Point(287, 404);
            this.txtRaiz.Name = "txtRaiz";
            this.txtRaiz.Size = new System.Drawing.Size(86, 26);
            this.txtRaiz.TabIndex = 12;
            this.txtRaiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBiseccion
            // 
            this.labelBiseccion.AutoSize = true;
            this.labelBiseccion.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiseccion.Location = new System.Drawing.Point(209, 87);
            this.labelBiseccion.Name = "labelBiseccion";
            this.labelBiseccion.Size = new System.Drawing.Size(372, 24);
            this.labelBiseccion.TabIndex = 13;
            this.labelBiseccion.Text = "METODOS CERRADOS - BISECCION";
            // 
            // comboMetodo
            // 
            this.comboMetodo.FormattingEnabled = true;
            this.comboMetodo.Location = new System.Drawing.Point(152, 33);
            this.comboMetodo.Name = "comboMetodo";
            this.comboMetodo.Size = new System.Drawing.Size(121, 21);
            this.comboMetodo.TabIndex = 14;
            this.comboMetodo.SelectedIndexChanged += new System.EventHandler(this.comboMetodo_SelectedIndexChanged);
            // 
            // Metodo
            // 
            this.Metodo.AutoSize = true;
            this.Metodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metodo.Location = new System.Drawing.Point(39, 33);
            this.Metodo.Name = "Metodo";
            this.Metodo.Size = new System.Drawing.Size(77, 18);
            this.Metodo.TabIndex = 15;
            this.Metodo.Text = "METODO";
            // 
            // labelReglaFalsa
            // 
            this.labelReglaFalsa.AutoSize = true;
            this.labelReglaFalsa.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReglaFalsa.Location = new System.Drawing.Point(189, 87);
            this.labelReglaFalsa.Name = "labelReglaFalsa";
            this.labelReglaFalsa.Size = new System.Drawing.Size(406, 24);
            this.labelReglaFalsa.TabIndex = 16;
            this.labelReglaFalsa.Text = "METODOS CERRADOS - REGLA FALSA";
            // 
            // labelResultado
            // 
            this.labelResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResultado.Location = new System.Drawing.Point(116, 294);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(555, 40);
            this.labelResultado.TabIndex = 17;
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDetalles
            // 
            this.labelDetalles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDetalles.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDetalles.Location = new System.Drawing.Point(138, 351);
            this.labelDetalles.Name = "labelDetalles";
            this.labelDetalles.Size = new System.Drawing.Size(139, 79);
            this.labelDetalles.TabIndex = 18;
            this.labelDetalles.Text = "DETALLES";
            this.labelDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRaiz
            // 
            this.labelRaiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRaiz.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaiz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelRaiz.Location = new System.Drawing.Point(283, 351);
            this.labelRaiz.Name = "labelRaiz";
            this.labelRaiz.Size = new System.Drawing.Size(90, 40);
            this.labelRaiz.TabIndex = 19;
            this.labelRaiz.Text = "RAIZ";
            this.labelRaiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIteraciones
            // 
            this.labelIteraciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelIteraciones.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIteraciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelIteraciones.Location = new System.Drawing.Point(387, 350);
            this.labelIteraciones.Name = "labelIteraciones";
            this.labelIteraciones.Size = new System.Drawing.Size(150, 40);
            this.labelIteraciones.TabIndex = 20;
            this.labelIteraciones.Text = "ITERACIONES";
            this.labelIteraciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelError.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelError.Location = new System.Drawing.Point(552, 350);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(90, 40);
            this.labelError.TabIndex = 21;
            this.labelError.Text = "ERROR";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIteracionesResultado
            // 
            this.labelIteracionesResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelIteracionesResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIteracionesResultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelIteracionesResultado.Location = new System.Drawing.Point(387, 400);
            this.labelIteracionesResultado.Name = "labelIteracionesResultado";
            this.labelIteracionesResultado.Size = new System.Drawing.Size(150, 30);
            this.labelIteracionesResultado.TabIndex = 22;
            this.labelIteracionesResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelErrorResultado
            // 
            this.labelErrorResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelErrorResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorResultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelErrorResultado.Location = new System.Drawing.Point(552, 400);
            this.labelErrorResultado.Name = "labelErrorResultado";
            this.labelErrorResultado.Size = new System.Drawing.Size(90, 30);
            this.labelErrorResultado.TabIndex = 23;
            this.labelErrorResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormularioMetodosCerrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelErrorResultado);
            this.Controls.Add(this.labelIteracionesResultado);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelIteraciones);
            this.Controls.Add(this.labelRaiz);
            this.Controls.Add(this.labelDetalles);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelReglaFalsa);
            this.Controls.Add(this.Metodo);
            this.Controls.Add(this.comboMetodo);
            this.Controls.Add(this.labelBiseccion);
            this.Controls.Add(this.txtRaiz);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.LimiteMaximo);
            this.Controls.Add(this.txtboxLimiteMaximo);
            this.Controls.Add(this.LimiteMinimo);
            this.Controls.Add(this.txtboxLimiteMinimo);
            this.Controls.Add(this.Iteraciones);
            this.Controls.Add(this.txtboxIteraciones);
            this.Controls.Add(this.Tolerancia);
            this.Controls.Add(this.txtboxTolerancia);
            this.Controls.Add(this.Funcion);
            this.Controls.Add(this.txtboxFuncion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FormularioMetodosCerrados";
            this.Text = "METODOS CERRADOS";
            this.Load += new System.EventHandler(this.FormularioMetodosCerrados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxFuncion;
        private System.Windows.Forms.Label Funcion;
        private System.Windows.Forms.Label Tolerancia;
        private System.Windows.Forms.TextBox txtboxTolerancia;
        private System.Windows.Forms.Label Iteraciones;
        private System.Windows.Forms.TextBox txtboxIteraciones;
        private System.Windows.Forms.Label LimiteMaximo;
        private System.Windows.Forms.TextBox txtboxLimiteMaximo;
        private System.Windows.Forms.Label LimiteMinimo;
        private System.Windows.Forms.TextBox txtboxLimiteMinimo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtRaiz;
        private System.Windows.Forms.Label labelBiseccion;
        private System.Windows.Forms.ComboBox comboMetodo;
        private System.Windows.Forms.Label Metodo;
        private System.Windows.Forms.Label labelReglaFalsa;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelDetalles;
        private System.Windows.Forms.Label labelRaiz;
        private System.Windows.Forms.Label labelIteraciones;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelIteracionesResultado;
        private System.Windows.Forms.Label labelErrorResultado;
    }
}