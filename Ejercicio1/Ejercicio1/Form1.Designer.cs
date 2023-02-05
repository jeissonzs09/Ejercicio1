namespace Ejercicio1
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
            this.label2 = new System.Windows.Forms.Label();
            this.NumEnterotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumNPtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumIPtextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un número entero:";
            // 
            // NumEnterotextBox
            // 
            this.NumEnterotextBox.Location = new System.Drawing.Point(369, 106);
            this.NumEnterotextBox.Name = "NumEnterotextBox";
            this.NumEnterotextBox.Size = new System.Drawing.Size(136, 22);
            this.NumEnterotextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "El número es:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "El número es:";
            // 
            // NumNPtextBox
            // 
            this.NumNPtextBox.Location = new System.Drawing.Point(213, 181);
            this.NumNPtextBox.Name = "NumNPtextBox";
            this.NumNPtextBox.Size = new System.Drawing.Size(149, 22);
            this.NumNPtextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(659, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Determinar si un número es par o impar, positivo o negativo";
            // 
            // NumIPtextBox
            // 
            this.NumIPtextBox.Location = new System.Drawing.Point(212, 243);
            this.NumIPtextBox.Name = "NumIPtextBox";
            this.NumIPtextBox.Size = new System.Drawing.Size(149, 22);
            this.NumIPtextBox.TabIndex = 7;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Calcularbutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcularbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calcularbutton.Location = new System.Drawing.Point(230, 297);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(132, 61);
            this.Calcularbutton.TabIndex = 8;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = false;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Limpiarbutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiarbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Limpiarbutton.Location = new System.Drawing.Point(405, 297);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(132, 61);
            this.Limpiarbutton.TabIndex = 9;
            this.Limpiarbutton.Text = "Limpiar Datos";
            this.Limpiarbutton.UseVisualStyleBackColor = false;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Limpiarbutton);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.NumIPtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumNPtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumEnterotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumEnterotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumNPtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumIPtextBox;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Button Limpiarbutton;
    }
}

