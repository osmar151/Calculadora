namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.cmdResultado = new System.Windows.Forms.Button();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.cbxOperaciones = new System.Windows.Forms.ComboBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(108, 24);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(40, 13);
            this.lblV1.TabIndex = 0;
            this.lblV1.Text = "Valor 1";
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Location = new System.Drawing.Point(111, 68);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(40, 13);
            this.lblV2.TabIndex = 1;
            this.lblV2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.BackColor = System.Drawing.Color.Red;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.Location = new System.Drawing.Point(217, 184);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(32, 33);
            this.lblres.TabIndex = 3;
            this.lblres.Text = "0";
            // 
            // cmdResultado
            // 
            this.cmdResultado.Location = new System.Drawing.Point(190, 252);
            this.cmdResultado.Name = "cmdResultado";
            this.cmdResultado.Size = new System.Drawing.Size(75, 23);
            this.cmdResultado.TabIndex = 4;
            this.cmdResultado.Text = "Resultado";
            this.cmdResultado.UseVisualStyleBackColor = true;
            this.cmdResultado.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(165, 24);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(100, 20);
            this.txtv1.TabIndex = 6;
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(165, 65);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(100, 20);
            this.txtv2.TabIndex = 7;
            this.txtv2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbxOperaciones
            // 
            this.cbxOperaciones.FormattingEnabled = true;
            this.cbxOperaciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.cbxOperaciones.Location = new System.Drawing.Point(190, 126);
            this.cbxOperaciones.Name = "cbxOperaciones";
            this.cbxOperaciones.Size = new System.Drawing.Size(121, 21);
            this.cbxOperaciones.TabIndex = 8;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(115, 134);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(56, 13);
            this.lblOp.TabIndex = 9;
            this.lblOp.Text = "Operacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 290);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.cbxOperaciones);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.cmdResultado);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblV1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button cmdResultado;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.ComboBox cbxOperaciones;
        private System.Windows.Forms.Label lblOp;
    }
}

