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
            this.LimiteMinimo = new System.Windows.Forms.Label();
            this.txtboxLimiteMinimo = new System.Windows.Forms.TextBox();
            this.LimiteMaximo = new System.Windows.Forms.Label();
            this.txtboxLimiteMaximo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Label();
            this.txtRaiz = new System.Windows.Forms.TextBox();
            this.labelBiseccion = new System.Windows.Forms.Label();
            this.comboMetodo = new System.Windows.Forms.ComboBox();
            this.Metodo = new System.Windows.Forms.Label();
            this.labelReglaFalsa = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxFuncion
            // 
            this.txtboxFuncion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFuncion.Location = new System.Drawing.Point(173, 141);
            this.txtboxFuncion.Name = "txtboxFuncion";
            this.txtboxFuncion.Size = new System.Drawing.Size(100, 26);
            this.txtboxFuncion.TabIndex = 0;
            // 
            // Funcion
            // 
            this.Funcion.AutoSize = true;
            this.Funcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Funcion.Location = new System.Drawing.Point(47, 143);
            this.Funcion.Name = "Funcion";
            this.Funcion.Size = new System.Drawing.Size(78, 18);
            this.Funcion.TabIndex = 1;
            this.Funcion.Text = "FUNCION";
            // 
            // Tolerancia
            // 
            this.Tolerancia.AutoSize = true;
            this.Tolerancia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tolerancia.Location = new System.Drawing.Point(47, 233);
            this.Tolerancia.Name = "Tolerancia";
            this.Tolerancia.Size = new System.Drawing.Size(108, 18);
            this.Tolerancia.TabIndex = 3;
            this.Tolerancia.Text = "TOLERANCIA";
            // 
            // txtboxTolerancia
            // 
            this.txtboxTolerancia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTolerancia.Location = new System.Drawing.Point(173, 233);
            this.txtboxTolerancia.Name = "txtboxTolerancia";
            this.txtboxTolerancia.Size = new System.Drawing.Size(100, 26);
            this.txtboxTolerancia.TabIndex = 2;
            // 
            // Iteraciones
            // 
            this.Iteraciones.AutoSize = true;
            this.Iteraciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iteraciones.Location = new System.Drawing.Point(47, 190);
            this.Iteraciones.Name = "Iteraciones";
            this.Iteraciones.Size = new System.Drawing.Size(113, 18);
            this.Iteraciones.TabIndex = 5;
            this.Iteraciones.Text = "ITERACIONES";
            // 
            // txtboxIteraciones
            // 
            this.txtboxIteraciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIteraciones.Location = new System.Drawing.Point(173, 191);
            this.txtboxIteraciones.Name = "txtboxIteraciones";
            this.txtboxIteraciones.Size = new System.Drawing.Size(100, 26);
            this.txtboxIteraciones.TabIndex = 4;
            // 
            // LimiteMinimo
            // 
            this.LimiteMinimo.AutoSize = true;
            this.LimiteMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimiteMinimo.Location = new System.Drawing.Point(319, 141);
            this.LimiteMinimo.Name = "LimiteMinimo";
            this.LimiteMinimo.Size = new System.Drawing.Size(115, 18);
            this.LimiteMinimo.TabIndex = 9;
            this.LimiteMinimo.Text = "LIMITE MINIMO";
            // 
            // txtboxLimiteMinimo
            // 
            this.txtboxLimiteMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLimiteMinimo.Location = new System.Drawing.Point(448, 142);
            this.txtboxLimiteMinimo.Name = "txtboxLimiteMinimo";
            this.txtboxLimiteMinimo.Size = new System.Drawing.Size(100, 26);
            this.txtboxLimiteMinimo.TabIndex = 8;
            // 
            // LimiteMaximo
            // 
            this.LimiteMaximo.AutoSize = true;
            this.LimiteMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimiteMaximo.Location = new System.Drawing.Point(319, 184);
            this.LimiteMaximo.Name = "LimiteMaximo";
            this.LimiteMaximo.Size = new System.Drawing.Size(123, 18);
            this.LimiteMaximo.TabIndex = 7;
            this.LimiteMaximo.Text = "LIMITE MAXIMO";
            // 
            // txtboxLimiteMaximo
            // 
            this.txtboxLimiteMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLimiteMaximo.Location = new System.Drawing.Point(448, 182);
            this.txtboxLimiteMaximo.Name = "txtboxLimiteMaximo";
            this.txtboxLimiteMaximo.Size = new System.Drawing.Size(100, 26);
            this.txtboxLimiteMaximo.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(338, 224);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(199, 44);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Raiz
            // 
            this.Raiz.AutoSize = true;
            this.Raiz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raiz.Location = new System.Drawing.Point(645, 142);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(42, 18);
            this.Raiz.TabIndex = 11;
            this.Raiz.Text = "RAIZ";
            // 
            // txtRaiz
            // 
            this.txtRaiz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaiz.Location = new System.Drawing.Point(618, 176);
            this.txtRaiz.Name = "txtRaiz";
            this.txtRaiz.Size = new System.Drawing.Size(100, 26);
            this.txtRaiz.TabIndex = 12;
            // 
            // labelBiseccion
            // 
            this.labelBiseccion.AutoSize = true;
            this.labelBiseccion.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiseccion.Location = new System.Drawing.Point(224, 87);
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
            this.labelReglaFalsa.Location = new System.Drawing.Point(210, 87);
            this.labelReglaFalsa.Name = "labelReglaFalsa";
            this.labelReglaFalsa.Size = new System.Drawing.Size(406, 24);
            this.labelReglaFalsa.TabIndex = 16;
            this.labelReglaFalsa.Text = "METODOS CERRADOS - REGLA FALSA";
            // 
            // labelResultado
            // 
            this.labelResultado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResultado.Location = new System.Drawing.Point(104, 308);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(567, 131);
            this.labelResultado.TabIndex = 17;
            // 
            // FormularioMetodosCerrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelReglaFalsa);
            this.Controls.Add(this.Metodo);
            this.Controls.Add(this.comboMetodo);
            this.Controls.Add(this.labelBiseccion);
            this.Controls.Add(this.txtRaiz);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.LimiteMinimo);
            this.Controls.Add(this.txtboxLimiteMinimo);
            this.Controls.Add(this.LimiteMaximo);
            this.Controls.Add(this.txtboxLimiteMaximo);
            this.Controls.Add(this.Iteraciones);
            this.Controls.Add(this.txtboxIteraciones);
            this.Controls.Add(this.Tolerancia);
            this.Controls.Add(this.txtboxTolerancia);
            this.Controls.Add(this.Funcion);
            this.Controls.Add(this.txtboxFuncion);
            this.Name = "FormularioMetodosCerrados";
            this.Text = "METODOS CERRADOS";
            this.Load += new System.EventHandler(this.MetodosCerrados_Load);
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
        private System.Windows.Forms.Label LimiteMinimo;
        private System.Windows.Forms.TextBox txtboxLimiteMinimo;
        private System.Windows.Forms.Label LimiteMaximo;
        private System.Windows.Forms.TextBox txtboxLimiteMaximo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label Raiz;
        private System.Windows.Forms.TextBox txtRaiz;
        private System.Windows.Forms.Label labelBiseccion;
        private System.Windows.Forms.ComboBox comboMetodo;
        private System.Windows.Forms.Label Metodo;
        private System.Windows.Forms.Label labelReglaFalsa;
        private System.Windows.Forms.Label labelResultado;
    }
}