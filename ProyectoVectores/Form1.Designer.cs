namespace ProyectoVectores
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstVector = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar un entero";
            // 
            // txtEntero
            // 
            this.txtEntero.Location = new System.Drawing.Point(163, 49);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(100, 20);
            this.txtEntero.TabIndex = 1;
            this.txtEntero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntero_KeyDown);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(51, 104);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(99, 43);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vectores Ordenados";
            // 
            // lstVector
            // 
            this.lstVector.FormattingEnabled = true;
            this.lstVector.Location = new System.Drawing.Point(15, 193);
            this.lstVector.Name = "lstVector";
            this.lstVector.Size = new System.Drawing.Size(135, 134);
            this.lstVector.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 373);
            this.Controls.Add(this.lstVector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ordenacion de vectores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstVector;
    }
}

