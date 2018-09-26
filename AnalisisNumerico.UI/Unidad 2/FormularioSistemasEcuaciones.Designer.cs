namespace AnalisisNumerico.UI
{
    partial class FormularioSistemasEcuaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioSistemasEcuaciones));
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
            this.Metodo = new System.Windows.Forms.Label();
            this.comboMetodo = new System.Windows.Forms.ComboBox();
            this.txtboxIteraciones = new System.Windows.Forms.TextBox();
            this.txtboxTolerancia = new System.Windows.Forms.TextBox();
            this.labelIteraciones = new System.Windows.Forms.Label();
            this.labelTolerancia = new System.Windows.Forms.Label();
            this.labelGaussSeidel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // NumeroIncognitas
            // 
            this.NumeroIncognitas.AutoSize = true;
            this.NumeroIncognitas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroIncognitas.Location = new System.Drawing.Point(108, 95);
            this.NumeroIncognitas.Name = "NumeroIncognitas";
            this.NumeroIncognitas.Size = new System.Drawing.Size(202, 18);
            this.NumeroIncognitas.TabIndex = 39;
            this.NumeroIncognitas.Text = "NUMERO DE INCOGNITAS";
            // 
            // NumeroEcuaciones
            // 
            this.NumeroEcuaciones.AutoSize = true;
            this.NumeroEcuaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroEcuaciones.Location = new System.Drawing.Point(97, 129);
            this.NumeroEcuaciones.Name = "NumeroEcuaciones";
            this.NumeroEcuaciones.Size = new System.Drawing.Size(213, 18);
            this.NumeroEcuaciones.TabIndex = 40;
            this.NumeroEcuaciones.Text = "NUMERO DE ECUACIONES";
            // 
            // txtboxNumeroIncognitas
            // 
            this.txtboxNumeroIncognitas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNumeroIncognitas.Location = new System.Drawing.Point(351, 95);
            this.txtboxNumeroIncognitas.Name = "txtboxNumeroIncognitas";
            this.txtboxNumeroIncognitas.Size = new System.Drawing.Size(100, 26);
            this.txtboxNumeroIncognitas.TabIndex = 41;
            // 
            // txtboxNumeroEcuaciones
            // 
            this.txtboxNumeroEcuaciones.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNumeroEcuaciones.Location = new System.Drawing.Point(351, 127);
            this.txtboxNumeroEcuaciones.Name = "txtboxNumeroEcuaciones";
            this.txtboxNumeroEcuaciones.Size = new System.Drawing.Size(100, 26);
            this.txtboxNumeroEcuaciones.TabIndex = 42;
            // 
            // Grilla
            // 
            this.Grilla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(78, 232);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(550, 150);
            this.Grilla.TabIndex = 43;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAplicar.Location = new System.Drawing.Point(468, 95);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(152, 54);
            this.btnAplicar.TabIndex = 44;
            this.btnAplicar.Text = "APLICAR";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // labelGaussJordan
            // 
            this.labelGaussJordan.AutoSize = true;
            this.labelGaussJordan.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGaussJordan.Location = new System.Drawing.Point(212, 44);
            this.labelGaussJordan.Name = "labelGaussJordan";
            this.labelGaussJordan.Size = new System.Drawing.Size(286, 24);
            this.labelGaussJordan.TabIndex = 46;
            this.labelGaussJordan.Text = "METODO GAUSS - JORDAN";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnCalcular.Location = new System.Drawing.Point(634, 263);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(152, 62);
            this.btnCalcular.TabIndex = 47;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // GrillaResultado
            // 
            this.GrillaResultado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GrillaResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaResultado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GrillaResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaResultado.Location = new System.Drawing.Point(173, 505);
            this.GrillaResultado.Name = "GrillaResultado";
            this.GrillaResultado.Size = new System.Drawing.Size(535, 81);
            this.GrillaResultado.TabIndex = 48;
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Resultado.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.Resultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Resultado.Location = new System.Drawing.Point(74, 385);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(712, 40);
            this.Resultado.TabIndex = 49;
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiarPantalla
            // 
            this.btnLimpiarPantalla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPantalla.Location = new System.Drawing.Point(634, 26);
            this.btnLimpiarPantalla.Name = "btnLimpiarPantalla";
            this.btnLimpiarPantalla.Size = new System.Drawing.Size(208, 32);
            this.btnLimpiarPantalla.TabIndex = 50;
            this.btnLimpiarPantalla.Text = "LIMPIAR PANTALLA";
            this.btnLimpiarPantalla.UseVisualStyleBackColor = true;
            this.btnLimpiarPantalla.Click += new System.EventHandler(this.btnLimpiarPantalla_Click);
            // 
            // Metodo
            // 
            this.Metodo.AutoSize = true;
            this.Metodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metodo.Location = new System.Drawing.Point(37, 10);
            this.Metodo.Name = "Metodo";
            this.Metodo.Size = new System.Drawing.Size(77, 18);
            this.Metodo.TabIndex = 52;
            this.Metodo.Text = "METODO";
            // 
            // comboMetodo
            // 
            this.comboMetodo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMetodo.FormattingEnabled = true;
            this.comboMetodo.Location = new System.Drawing.Point(133, 6);
            this.comboMetodo.Name = "comboMetodo";
            this.comboMetodo.Size = new System.Drawing.Size(198, 28);
            this.comboMetodo.TabIndex = 51;
            this.comboMetodo.SelectedIndexChanged += new System.EventHandler(this.comboMetodo_SelectedIndexChanged);
            // 
            // txtboxIteraciones
            // 
            this.txtboxIteraciones.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIteraciones.Location = new System.Drawing.Point(351, 193);
            this.txtboxIteraciones.Name = "txtboxIteraciones";
            this.txtboxIteraciones.Size = new System.Drawing.Size(100, 26);
            this.txtboxIteraciones.TabIndex = 70;
            // 
            // txtboxTolerancia
            // 
            this.txtboxTolerancia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTolerancia.Location = new System.Drawing.Point(351, 162);
            this.txtboxTolerancia.Name = "txtboxTolerancia";
            this.txtboxTolerancia.Size = new System.Drawing.Size(100, 26);
            this.txtboxTolerancia.TabIndex = 69;
            // 
            // labelIteraciones
            // 
            this.labelIteraciones.AutoSize = true;
            this.labelIteraciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIteraciones.Location = new System.Drawing.Point(197, 192);
            this.labelIteraciones.Name = "labelIteraciones";
            this.labelIteraciones.Size = new System.Drawing.Size(113, 18);
            this.labelIteraciones.TabIndex = 68;
            this.labelIteraciones.Text = "ITERACIONES";
            // 
            // labelTolerancia
            // 
            this.labelTolerancia.AutoSize = true;
            this.labelTolerancia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTolerancia.Location = new System.Drawing.Point(202, 162);
            this.labelTolerancia.Name = "labelTolerancia";
            this.labelTolerancia.Size = new System.Drawing.Size(108, 18);
            this.labelTolerancia.TabIndex = 67;
            this.labelTolerancia.Text = "TOLERANCIA";
            // 
            // labelGaussSeidel
            // 
            this.labelGaussSeidel.AutoSize = true;
            this.labelGaussSeidel.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGaussSeidel.Location = new System.Drawing.Point(212, 44);
            this.labelGaussSeidel.Name = "labelGaussSeidel";
            this.labelGaussSeidel.Size = new System.Drawing.Size(274, 24);
            this.labelGaussSeidel.TabIndex = 71;
            this.labelGaussSeidel.Text = "METODO GAUSS - SEIDEL";
            // 
            // FormularioSistemasEcuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 609);
            this.Controls.Add(this.labelGaussSeidel);
            this.Controls.Add(this.txtboxIteraciones);
            this.Controls.Add(this.txtboxTolerancia);
            this.Controls.Add(this.labelIteraciones);
            this.Controls.Add(this.labelTolerancia);
            this.Controls.Add(this.Metodo);
            this.Controls.Add(this.comboMetodo);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioSistemasEcuaciones";
            this.Text = "SISTEMAS DE ECUACIONES";
            this.Load += new System.EventHandler(this.FormularioGaussJordan_Load);
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
        private System.Windows.Forms.Label Metodo;
        private System.Windows.Forms.ComboBox comboMetodo;
        private System.Windows.Forms.TextBox txtboxIteraciones;
        private System.Windows.Forms.TextBox txtboxTolerancia;
        private System.Windows.Forms.Label labelIteraciones;
        private System.Windows.Forms.Label labelTolerancia;
        private System.Windows.Forms.Label labelGaussSeidel;
    }
}