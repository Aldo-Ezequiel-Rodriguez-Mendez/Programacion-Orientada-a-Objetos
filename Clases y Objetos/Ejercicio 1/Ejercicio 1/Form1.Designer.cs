namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.grpObjeto = new System.Windows.Forms.GroupBox();
            this.radMoneda = new System.Windows.Forms.RadioButton();
            this.radRueda = new System.Windows.Forms.RadioButton();
            this.grpOperacion = new System.Windows.Forms.GroupBox();
            this.radCalcularPerimetro = new System.Windows.Forms.RadioButton();
            this.radCalcularArea = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpObjeto.SuspendLayout();
            this.grpOperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(47, 38);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(51, 20);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(104, 38);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(125, 27);
            this.txtRadio.TabIndex = 1;
            // 
            // grpObjeto
            // 
            this.grpObjeto.Controls.Add(this.radMoneda);
            this.grpObjeto.Controls.Add(this.radRueda);
            this.grpObjeto.Location = new System.Drawing.Point(47, 117);
            this.grpObjeto.Name = "grpObjeto";
            this.grpObjeto.Size = new System.Drawing.Size(250, 125);
            this.grpObjeto.TabIndex = 2;
            this.grpObjeto.TabStop = false;
            this.grpObjeto.Text = "Objeto de la circunferencia";
            // 
            // radMoneda
            // 
            this.radMoneda.AutoSize = true;
            this.radMoneda.Location = new System.Drawing.Point(47, 78);
            this.radMoneda.Name = "radMoneda";
            this.radMoneda.Size = new System.Drawing.Size(85, 24);
            this.radMoneda.TabIndex = 1;
            this.radMoneda.Text = "Moneda";
            this.radMoneda.UseVisualStyleBackColor = true;
            // 
            // radRueda
            // 
            this.radRueda.AutoSize = true;
            this.radRueda.Checked = true;
            this.radRueda.Location = new System.Drawing.Point(47, 38);
            this.radRueda.Name = "radRueda";
            this.radRueda.Size = new System.Drawing.Size(72, 24);
            this.radRueda.TabIndex = 0;
            this.radRueda.TabStop = true;
            this.radRueda.Text = "Rueda";
            this.radRueda.UseVisualStyleBackColor = true;
            // 
            // grpOperacion
            // 
            this.grpOperacion.Controls.Add(this.radCalcularPerimetro);
            this.grpOperacion.Controls.Add(this.radCalcularArea);
            this.grpOperacion.Location = new System.Drawing.Point(47, 261);
            this.grpOperacion.Name = "grpOperacion";
            this.grpOperacion.Size = new System.Drawing.Size(250, 125);
            this.grpOperacion.TabIndex = 3;
            this.grpOperacion.TabStop = false;
            this.grpOperacion.Text = "Operacion";
            // 
            // radCalcularPerimetro
            // 
            this.radCalcularPerimetro.AutoSize = true;
            this.radCalcularPerimetro.Location = new System.Drawing.Point(47, 81);
            this.radCalcularPerimetro.Name = "radCalcularPerimetro";
            this.radCalcularPerimetro.Size = new System.Drawing.Size(153, 24);
            this.radCalcularPerimetro.TabIndex = 5;
            this.radCalcularPerimetro.Text = "Calcular perimetro";
            this.radCalcularPerimetro.UseVisualStyleBackColor = true;
            // 
            // radCalcularArea
            // 
            this.radCalcularArea.AutoSize = true;
            this.radCalcularArea.Checked = true;
            this.radCalcularArea.Location = new System.Drawing.Point(47, 38);
            this.radCalcularArea.Name = "radCalcularArea";
            this.radCalcularArea.Size = new System.Drawing.Size(116, 24);
            this.radCalcularArea.TabIndex = 0;
            this.radCalcularArea.TabStop = true;
            this.radCalcularArea.Text = "Calcular area";
            this.radCalcularArea.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(47, 392);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(250, 29);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpOperacion);
            this.Controls.Add(this.grpObjeto);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circunferencia";
            this.grpObjeto.ResumeLayout(false);
            this.grpObjeto.PerformLayout();
            this.grpOperacion.ResumeLayout(false);
            this.grpOperacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRadio;
        private TextBox txtRadio;
        private GroupBox grpObjeto;
        private RadioButton radMoneda;
        private RadioButton radRueda;
        private GroupBox grpOperacion;
        private RadioButton radCalcularPerimetro;
        private RadioButton radCalcularArea;
        private Button btnCalcular;
    }
}