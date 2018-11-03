namespace AnalisisNumerico.UI
{
    partial class FormularioIntegracionNumerica
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
            this.txtBoxExtremo1 = new System.Windows.Forms.TextBox();
            this.labelExtremo1 = new System.Windows.Forms.Label();
            this.txtboxCantidadIntervalos = new System.Windows.Forms.TextBox();
            this.labelCantidadSubintervalos = new System.Windows.Forms.Label();
            this.txtboxValorIntegral = new System.Windows.Forms.TextBox();
            this.labelValorIntegral = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtboxFuncion = new System.Windows.Forms.TextBox();
            this.labelFuncion = new System.Windows.Forms.Label();
            this.labelTrapecioSimple = new System.Windows.Forms.Label();
            this.Metodo = new System.Windows.Forms.Label();
            this.comboMetodo = new System.Windows.Forms.ComboBox();
            this.btnLimpiarPantalla = new System.Windows.Forms.Button();
            this.labelExtremo2 = new System.Windows.Forms.Label();
            this.txtBoxExtremo2 = new System.Windows.Forms.TextBox();
            this.labelTrapecioMultiple = new System.Windows.Forms.Label();
            this.labelSimpsonSimple = new System.Windows.Forms.Label();
            this.labelSimpsonMultiple = new System.Windows.Forms.Label();
            this.labelSimpson38 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxExtremo1
            // 
            this.txtBoxExtremo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxExtremo1.Location = new System.Drawing.Point(388, 201);
            this.txtBoxExtremo1.Name = "txtBoxExtremo1";
            this.txtBoxExtremo1.Size = new System.Drawing.Size(100, 26);
            this.txtBoxExtremo1.TabIndex = 120;
            // 
            // labelExtremo1
            // 
            this.labelExtremo1.AutoSize = true;
            this.labelExtremo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtremo1.Location = new System.Drawing.Point(133, 203);
            this.labelExtremo1.Name = "labelExtremo1";
            this.labelExtremo1.Size = new System.Drawing.Size(99, 18);
            this.labelExtremo1.TabIndex = 119;
            this.labelExtremo1.Text = "EXTREMO 1";
            // 
            // txtboxCantidadIntervalos
            // 
            this.txtboxCantidadIntervalos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCantidadIntervalos.Location = new System.Drawing.Point(388, 161);
            this.txtboxCantidadIntervalos.Name = "txtboxCantidadIntervalos";
            this.txtboxCantidadIntervalos.Size = new System.Drawing.Size(100, 26);
            this.txtboxCantidadIntervalos.TabIndex = 114;
            // 
            // labelCantidadSubintervalos
            // 
            this.labelCantidadSubintervalos.AutoSize = true;
            this.labelCantidadSubintervalos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadSubintervalos.Location = new System.Drawing.Point(133, 165);
            this.labelCantidadSubintervalos.Name = "labelCantidadSubintervalos";
            this.labelCantidadSubintervalos.Size = new System.Drawing.Size(251, 18);
            this.labelCantidadSubintervalos.TabIndex = 113;
            this.labelCantidadSubintervalos.Text = "CANTIDAD DE SUBINTERVALOS";
            // 
            // txtboxValorIntegral
            // 
            this.txtboxValorIntegral.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxValorIntegral.Location = new System.Drawing.Point(372, 360);
            this.txtboxValorIntegral.Name = "txtboxValorIntegral";
            this.txtboxValorIntegral.Size = new System.Drawing.Size(127, 32);
            this.txtboxValorIntegral.TabIndex = 109;
            // 
            // labelValorIntegral
            // 
            this.labelValorIntegral.AutoSize = true;
            this.labelValorIntegral.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorIntegral.Location = new System.Drawing.Point(198, 367);
            this.labelValorIntegral.Name = "labelValorIntegral";
            this.labelValorIntegral.Size = new System.Drawing.Size(150, 19);
            this.labelValorIntegral.TabIndex = 108;
            this.labelValorIntegral.Text = "VALOR INTEGRAL";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnCalcular.Location = new System.Drawing.Point(501, 159);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(152, 62);
            this.btnCalcular.TabIndex = 106;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtboxFuncion
            // 
            this.txtboxFuncion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFuncion.Location = new System.Drawing.Point(255, 129);
            this.txtboxFuncion.Name = "txtboxFuncion";
            this.txtboxFuncion.Size = new System.Drawing.Size(233, 26);
            this.txtboxFuncion.TabIndex = 103;
            // 
            // labelFuncion
            // 
            this.labelFuncion.AutoSize = true;
            this.labelFuncion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncion.Location = new System.Drawing.Point(133, 135);
            this.labelFuncion.Name = "labelFuncion";
            this.labelFuncion.Size = new System.Drawing.Size(78, 18);
            this.labelFuncion.TabIndex = 102;
            this.labelFuncion.Text = "FUNCION";
            // 
            // labelTrapecioSimple
            // 
            this.labelTrapecioSimple.AutoSize = true;
            this.labelTrapecioSimple.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrapecioSimple.Location = new System.Drawing.Point(288, 77);
            this.labelTrapecioSimple.Name = "labelTrapecioSimple";
            this.labelTrapecioSimple.Size = new System.Drawing.Size(200, 24);
            this.labelTrapecioSimple.TabIndex = 101;
            this.labelTrapecioSimple.Text = "TRAPECIO SIMPLE";
            // 
            // Metodo
            // 
            this.Metodo.AutoSize = true;
            this.Metodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metodo.Location = new System.Drawing.Point(30, 30);
            this.Metodo.Name = "Metodo";
            this.Metodo.Size = new System.Drawing.Size(77, 18);
            this.Metodo.TabIndex = 100;
            this.Metodo.Text = "METODO";
            // 
            // comboMetodo
            // 
            this.comboMetodo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMetodo.FormattingEnabled = true;
            this.comboMetodo.Location = new System.Drawing.Point(126, 26);
            this.comboMetodo.Name = "comboMetodo";
            this.comboMetodo.Size = new System.Drawing.Size(198, 28);
            this.comboMetodo.TabIndex = 99;
            this.comboMetodo.SelectedIndexChanged += new System.EventHandler(this.comboMetodo_SelectedIndexChanged);
            // 
            // btnLimpiarPantalla
            // 
            this.btnLimpiarPantalla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPantalla.Location = new System.Drawing.Point(627, 46);
            this.btnLimpiarPantalla.Name = "btnLimpiarPantalla";
            this.btnLimpiarPantalla.Size = new System.Drawing.Size(208, 32);
            this.btnLimpiarPantalla.TabIndex = 98;
            this.btnLimpiarPantalla.Text = "LIMPIAR PANTALLA";
            this.btnLimpiarPantalla.UseVisualStyleBackColor = true;
            this.btnLimpiarPantalla.Click += new System.EventHandler(this.btnLimpiarPantalla_Click);
            // 
            // labelExtremo2
            // 
            this.labelExtremo2.AutoSize = true;
            this.labelExtremo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtremo2.Location = new System.Drawing.Point(133, 237);
            this.labelExtremo2.Name = "labelExtremo2";
            this.labelExtremo2.Size = new System.Drawing.Size(99, 18);
            this.labelExtremo2.TabIndex = 121;
            this.labelExtremo2.Text = "EXTREMO 2";
            // 
            // txtBoxExtremo2
            // 
            this.txtBoxExtremo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxExtremo2.Location = new System.Drawing.Point(388, 237);
            this.txtBoxExtremo2.Name = "txtBoxExtremo2";
            this.txtBoxExtremo2.Size = new System.Drawing.Size(100, 26);
            this.txtBoxExtremo2.TabIndex = 122;
            // 
            // labelTrapecioMultiple
            // 
            this.labelTrapecioMultiple.AutoSize = true;
            this.labelTrapecioMultiple.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrapecioMultiple.Location = new System.Drawing.Point(276, 77);
            this.labelTrapecioMultiple.Name = "labelTrapecioMultiple";
            this.labelTrapecioMultiple.Size = new System.Drawing.Size(224, 24);
            this.labelTrapecioMultiple.TabIndex = 123;
            this.labelTrapecioMultiple.Text = "TRAPECIO MULTIPLE";
            // 
            // labelSimpsonSimple
            // 
            this.labelSimpsonSimple.AutoSize = true;
            this.labelSimpsonSimple.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimpsonSimple.Location = new System.Drawing.Point(276, 77);
            this.labelSimpsonSimple.Name = "labelSimpsonSimple";
            this.labelSimpsonSimple.Size = new System.Drawing.Size(223, 24);
            this.labelSimpsonSimple.TabIndex = 124;
            this.labelSimpsonSimple.Text = "SIMPSON 1/3 SIMPLE";
            // 
            // labelSimpsonMultiple
            // 
            this.labelSimpsonMultiple.AutoSize = true;
            this.labelSimpsonMultiple.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimpsonMultiple.Location = new System.Drawing.Point(272, 77);
            this.labelSimpsonMultiple.Name = "labelSimpsonMultiple";
            this.labelSimpsonMultiple.Size = new System.Drawing.Size(247, 24);
            this.labelSimpsonMultiple.TabIndex = 125;
            this.labelSimpsonMultiple.Text = "SIMPSON 1/3 MULTIPLE";
            // 
            // labelSimpson38
            // 
            this.labelSimpson38.AutoSize = true;
            this.labelSimpson38.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimpson38.Location = new System.Drawing.Point(325, 77);
            this.labelSimpson38.Name = "labelSimpson38";
            this.labelSimpson38.Size = new System.Drawing.Size(140, 24);
            this.labelSimpson38.TabIndex = 126;
            this.labelSimpson38.Text = "SIMPSON 3/8";
            // 
            // FormularioIntegracionNumerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 609);
            this.Controls.Add(this.labelSimpson38);
            this.Controls.Add(this.labelSimpsonMultiple);
            this.Controls.Add(this.labelSimpsonSimple);
            this.Controls.Add(this.labelTrapecioMultiple);
            this.Controls.Add(this.txtBoxExtremo2);
            this.Controls.Add(this.labelExtremo2);
            this.Controls.Add(this.txtBoxExtremo1);
            this.Controls.Add(this.labelExtremo1);
            this.Controls.Add(this.txtboxCantidadIntervalos);
            this.Controls.Add(this.labelCantidadSubintervalos);
            this.Controls.Add(this.txtboxValorIntegral);
            this.Controls.Add(this.labelValorIntegral);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtboxFuncion);
            this.Controls.Add(this.labelFuncion);
            this.Controls.Add(this.labelTrapecioSimple);
            this.Controls.Add(this.Metodo);
            this.Controls.Add(this.comboMetodo);
            this.Controls.Add(this.btnLimpiarPantalla);
            this.Name = "FormularioIntegracionNumerica";
            this.Text = "FormularioIntegracionNumerica";
            this.Load += new System.EventHandler(this.FormularioIntegracionNumerica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxExtremo1;
        private System.Windows.Forms.Label labelExtremo1;
        private System.Windows.Forms.TextBox txtboxCantidadIntervalos;
        private System.Windows.Forms.Label labelCantidadSubintervalos;
        private System.Windows.Forms.TextBox txtboxValorIntegral;
        private System.Windows.Forms.Label labelValorIntegral;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtboxFuncion;
        private System.Windows.Forms.Label labelFuncion;
        private System.Windows.Forms.Label labelTrapecioSimple;
        private System.Windows.Forms.Label Metodo;
        private System.Windows.Forms.ComboBox comboMetodo;
        private System.Windows.Forms.Button btnLimpiarPantalla;
        private System.Windows.Forms.Label labelExtremo2;
        private System.Windows.Forms.TextBox txtBoxExtremo2;
        private System.Windows.Forms.Label labelTrapecioMultiple;
        private System.Windows.Forms.Label labelSimpsonSimple;
        private System.Windows.Forms.Label labelSimpsonMultiple;
        private System.Windows.Forms.Label labelSimpson38;
    }
}