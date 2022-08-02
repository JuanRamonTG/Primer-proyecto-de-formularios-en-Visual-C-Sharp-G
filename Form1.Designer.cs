namespace Primer_proyecto_de_formularios_en_Visual_C_Sharp
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
            this.btnclicaqui = new System.Windows.Forms.Button();
            this.label1Holamundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclicaqui
            // 
            this.btnclicaqui.Location = new System.Drawing.Point(234, 341);
            this.btnclicaqui.Name = "btnclicaqui";
            this.btnclicaqui.Size = new System.Drawing.Size(75, 25);
            this.btnclicaqui.TabIndex = 0;
            this.btnclicaqui.Text = "clic aqui";
            this.btnclicaqui.UseVisualStyleBackColor = true;
            this.btnclicaqui.Click += new System.EventHandler(this.btnclicaqui_Click);
            // 
            // label1Holamundo
            // 
            this.label1Holamundo.AutoSize = true;
            this.label1Holamundo.Location = new System.Drawing.Point(264, 390);
            this.label1Holamundo.Name = "label1Holamundo";
            this.label1Holamundo.Size = new System.Drawing.Size(0, 13);
            this.label1Holamundo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.label1Holamundo);
            this.Controls.Add(this.btnclicaqui);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclicaqui;
        private System.Windows.Forms.Label label1Holamundo;
    }
}

