﻿namespace MaquinaTuring
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.grpMaquinas = new System.Windows.Forms.GroupBox();
            this.rdoMultiplicación = new System.Windows.Forms.RadioButton();
            this.rdoResta = new System.Windows.Forms.RadioButton();
            this.rdoSuma = new System.Windows.Forms.RadioButton();
            this.rdoPatrón = new System.Windows.Forms.RadioButton();
            this.rdoPalíndromo = new System.Windows.Forms.RadioButton();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.dgvCinta = new System.Windows.Forms.DataGridView();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.lbTítulo = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnDiagrama = new System.Windows.Forms.Button();
            this.btnAnimación = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlGráfico = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.picDiagrama = new System.Windows.Forms.PictureBox();
            this.grpMaquinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.pnlGráfico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiagrama)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMaquinas
            // 
            this.grpMaquinas.Controls.Add(this.rdoMultiplicación);
            this.grpMaquinas.Controls.Add(this.rdoResta);
            this.grpMaquinas.Controls.Add(this.rdoSuma);
            this.grpMaquinas.Controls.Add(this.rdoPatrón);
            this.grpMaquinas.Controls.Add(this.rdoPalíndromo);
            this.grpMaquinas.Location = new System.Drawing.Point(12, 77);
            this.grpMaquinas.Name = "grpMaquinas";
            this.grpMaquinas.Size = new System.Drawing.Size(217, 148);
            this.grpMaquinas.TabIndex = 0;
            this.grpMaquinas.TabStop = false;
            this.grpMaquinas.Text = "Maquinas de Turing";
            // 
            // rdoMultiplicación
            // 
            this.rdoMultiplicación.AutoSize = true;
            this.rdoMultiplicación.Location = new System.Drawing.Point(20, 111);
            this.rdoMultiplicación.Name = "rdoMultiplicación";
            this.rdoMultiplicación.Size = new System.Drawing.Size(123, 17);
            this.rdoMultiplicación.TabIndex = 4;
            this.rdoMultiplicación.TabStop = true;
            this.rdoMultiplicación.Text = "Multiplicación Unaria";
            this.rdoMultiplicación.UseVisualStyleBackColor = true;
            // 
            // rdoResta
            // 
            this.rdoResta.AutoSize = true;
            this.rdoResta.Location = new System.Drawing.Point(20, 88);
            this.rdoResta.Name = "rdoResta";
            this.rdoResta.Size = new System.Drawing.Size(87, 17);
            this.rdoResta.TabIndex = 3;
            this.rdoResta.TabStop = true;
            this.rdoResta.Text = "Resta Unaria";
            this.rdoResta.UseVisualStyleBackColor = true;
            // 
            // rdoSuma
            // 
            this.rdoSuma.AutoSize = true;
            this.rdoSuma.Location = new System.Drawing.Point(20, 65);
            this.rdoSuma.Name = "rdoSuma";
            this.rdoSuma.Size = new System.Drawing.Size(84, 17);
            this.rdoSuma.TabIndex = 2;
            this.rdoSuma.TabStop = true;
            this.rdoSuma.Text = "Suma unaria";
            this.rdoSuma.UseVisualStyleBackColor = true;
            // 
            // rdoPatrón
            // 
            this.rdoPatrón.AutoSize = true;
            this.rdoPatrón.Location = new System.Drawing.Point(20, 42);
            this.rdoPatrón.Name = "rdoPatrón";
            this.rdoPatrón.Size = new System.Drawing.Size(111, 17);
            this.rdoPatrón.TabIndex = 1;
            this.rdoPatrón.TabStop = true;
            this.rdoPatrón.Text = "Copia de patrones";
            this.rdoPatrón.UseVisualStyleBackColor = true;
            // 
            // rdoPalíndromo
            // 
            this.rdoPalíndromo.AutoSize = true;
            this.rdoPalíndromo.Location = new System.Drawing.Point(20, 19);
            this.rdoPalíndromo.Name = "rdoPalíndromo";
            this.rdoPalíndromo.Size = new System.Drawing.Size(79, 17);
            this.rdoPalíndromo.TabIndex = 0;
            this.rdoPalíndromo.TabStop = true;
            this.rdoPalíndromo.Text = "Palíndromo";
            this.rdoPalíndromo.UseVisualStyleBackColor = true;
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(12, 54);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(136, 20);
            this.tbEntrada.TabIndex = 1;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(154, 54);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.Text = "Iniciar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // dgvCinta
            // 
            this.dgvCinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCinta.ColumnHeadersVisible = false;
            this.dgvCinta.Location = new System.Drawing.Point(12, 341);
            this.dgvCinta.Name = "dgvCinta";
            this.dgvCinta.RowHeadersVisible = false;
            this.dgvCinta.Size = new System.Drawing.Size(724, 45);
            this.dgvCinta.TabIndex = 3;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(235, 54);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.Size = new System.Drawing.Size(501, 281);
            this.dgvTabla.TabIndex = 5;
            // 
            // lbTítulo
            // 
            this.lbTítulo.AutoSize = true;
            this.lbTítulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTítulo.Location = new System.Drawing.Point(188, 9);
            this.lbTítulo.Name = "lbTítulo";
            this.lbTítulo.Size = new System.Drawing.Size(326, 33);
            this.lbTítulo.TabIndex = 6;
            this.lbTítulo.Text = "MAQUINA DE TURING";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(8, 399);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(97, 22);
            this.lbResultado.TabIndex = 7;
            this.lbResultado.Text = "ESTADO:";
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Enabled = false;
            this.btnAvanzar.Location = new System.Drawing.Point(12, 231);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(217, 23);
            this.btnAvanzar.TabIndex = 8;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnDiagrama
            // 
            this.btnDiagrama.Enabled = false;
            this.btnDiagrama.Location = new System.Drawing.Point(12, 289);
            this.btnDiagrama.Name = "btnDiagrama";
            this.btnDiagrama.Size = new System.Drawing.Size(217, 23);
            this.btnDiagrama.TabIndex = 9;
            this.btnDiagrama.Text = "Ver diagrama";
            this.btnDiagrama.UseVisualStyleBackColor = true;
            this.btnDiagrama.Click += new System.EventHandler(this.btnDiagrama_Click);
            // 
            // btnAnimación
            // 
            this.btnAnimación.Enabled = false;
            this.btnAnimación.Location = new System.Drawing.Point(12, 260);
            this.btnAnimación.Name = "btnAnimación";
            this.btnAnimación.Size = new System.Drawing.Size(217, 23);
            this.btnAnimación.TabIndex = 10;
            this.btnAnimación.Text = "Avance Rápido";
            this.btnAnimación.UseVisualStyleBackColor = true;
            this.btnAnimación.Click += new System.EventHandler(this.btnAnimación_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlGráfico
            // 
            this.pnlGráfico.Controls.Add(this.btnCerrar);
            this.pnlGráfico.Controls.Add(this.picDiagrama);
            this.pnlGráfico.Location = new System.Drawing.Point(12, 12);
            this.pnlGráfico.Name = "pnlGráfico";
            this.pnlGráfico.Size = new System.Drawing.Size(790, 409);
            this.pnlGráfico.TabIndex = 11;
            this.pnlGráfico.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(339, 365);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(125, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // picDiagrama
            // 
            this.picDiagrama.Location = new System.Drawing.Point(6, 13);
            this.picDiagrama.Name = "picDiagrama";
            this.picDiagrama.Size = new System.Drawing.Size(771, 346);
            this.picDiagrama.TabIndex = 0;
            this.picDiagrama.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 426);
            this.Controls.Add(this.pnlGráfico);
            this.Controls.Add(this.btnAnimación);
            this.Controls.Add(this.btnDiagrama);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbTítulo);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.dgvCinta);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.tbEntrada);
            this.Controls.Add(this.grpMaquinas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMaquinas.ResumeLayout(false);
            this.grpMaquinas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.pnlGráfico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDiagrama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaquinas;
        private System.Windows.Forms.RadioButton rdoMultiplicación;
        private System.Windows.Forms.RadioButton rdoResta;
        private System.Windows.Forms.RadioButton rdoSuma;
        private System.Windows.Forms.RadioButton rdoPatrón;
        private System.Windows.Forms.RadioButton rdoPalíndromo;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridView dgvCinta;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label lbTítulo;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnDiagrama;
        private System.Windows.Forms.Button btnAnimación;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlGráfico;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox picDiagrama;
    }
}

