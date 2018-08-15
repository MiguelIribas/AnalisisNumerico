namespace AnalisisNumerico.UI
{
    partial class Biseccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxFuncion
            // 
            this.txtboxFuncion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFuncion.Location = new System.Drawing.Point(172, 89);
            this.txtboxFuncion.Name = "txtboxFuncion";
            this.txtboxFuncion.Size = new System.Drawing.Size(100, 26);
            this.txtboxFuncion.TabIndex = 0;
            // 
            // Funcion
            // 
            this.Funcion.AutoSize = true;
            this.Funcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Funcion.Location = new System.Drawing.Point(46, 91);
            this.Funcion.Name = "Funcion";
            this.Funcion.Size = new System.Drawing.Size(78, 18);
            this.Funcion.TabIndex = 1;
            this.Funcion.Text = "FUNCION";
            // 
            // Tolerancia
            // 
            this.Tolerancia.AutoSize = true;
            this.Tolerancia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tolerancia.Location = new System.Drawing.Point(46, 181);
            this.Tolerancia.Name = "Tolerancia";
            this.Tolerancia.Size = new System.Drawing.Size(108, 18);
            this.Tolerancia.TabIndex = 3;
            this.Tolerancia.Text = "TOLERANCIA";
            // 
            // txtboxTolerancia
            // 
            this.txtboxTolerancia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTolerancia.Location = new System.Drawing.Point(172, 181);
            this.txtboxTolerancia.Name = "txtboxTolerancia";
            this.txtboxTolerancia.Size = new System.Drawing.Size(100, 26);
            this.txtboxTolerancia.TabIndex = 2;
            // 
            // Iteraciones
            // 
            this.Iteraciones.AutoSize = true;
            this.Iteraciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iteraciones.Location = new System.Drawing.Point(46, 138);
            this.Iteraciones.Name = "Iteraciones";
            this.Iteraciones.Size = new System.Drawing.Size(113, 18);
            this.Iteraciones.TabIndex = 5;
            this.Iteraciones.Text = "ITERACIONES";
            // 
            // txtboxIteraciones
            // 
            this.txtboxIteraciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIteraciones.Location = new System.Drawing.Point(172, 139);
            this.txtboxIteraciones.Name = "txtboxIteraciones";
            this.txtboxIteraciones.Size = new System.Drawing.Size(100, 26);
            this.txtboxIteraciones.TabIndex = 4;
            // 
            // LimiteMinimo
            // 
            this.LimiteMinimo.AutoSize = true;
            this.LimiteMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimiteMinimo.Location = new System.Drawing.Point(318, 89);
            this.LimiteMinimo.Name = "LimiteMinimo";
            this.LimiteMinimo.Size = new System.Drawing.Size(115, 18);
            this.LimiteMinimo.TabIndex = 9;
            this.LimiteMinimo.Text = "LIMITE MINIMO";
            // 
            // txtboxLimiteMinimo
            // 
            this.txtboxLimiteMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLimiteMinimo.Location = new System.Drawing.Point(447, 90);
            this.txtboxLimiteMinimo.Name = "txtboxLimiteMinimo";
            this.txtboxLimiteMinimo.Size = new System.Drawing.Size(100, 26);
            this.txtboxLimiteMinimo.TabIndex = 8;
            // 
            // LimiteMaximo
            // 
            this.LimiteMaximo.AutoSize = true;
            this.LimiteMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimiteMaximo.Location = new System.Drawing.Point(318, 132);
            this.LimiteMaximo.Name = "LimiteMaximo";
            this.LimiteMaximo.Size = new System.Drawing.Size(123, 18);
            this.LimiteMaximo.TabIndex = 7;
            this.LimiteMaximo.Text = "LIMITE MAXIMO";
            // 
            // txtboxLimiteMaximo
            // 
            this.txtboxLimiteMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLimiteMaximo.Location = new System.Drawing.Point(447, 130);
            this.txtboxLimiteMaximo.Name = "txtboxLimiteMaximo";
            this.txtboxLimiteMaximo.Size = new System.Drawing.Size(100, 26);
            this.txtboxLimiteMaximo.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(337, 172);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(199, 44);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Raiz
            // 
            this.Raiz.AutoSize = true;
            this.Raiz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raiz.Location = new System.Drawing.Point(644, 90);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(42, 18);
            this.Raiz.TabIndex = 11;
            this.Raiz.Text = "RAIZ";
            // 
            // txtRaiz
            // 
            this.txtRaiz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaiz.Location = new System.Drawing.Point(617, 124);
            this.txtRaiz.Name = "txtRaiz";
            this.txtRaiz.Size = new System.Drawing.Size(100, 26);
            this.txtRaiz.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "METODOS CERRADOS - BISECCION";
            // 
            // Biseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
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
            this.Name = "Biseccion";
            this.Text = "Biseccion";
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
        private System.Windows.Forms.Label label1;
    }
}