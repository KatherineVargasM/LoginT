
namespace Login.Views.Usuarios
{
    partial class frm_Usuarios_Contrsenia
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_contraseniaNueva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_confirmarContrasenia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cambio de Contraseña";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(206, 237);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(112, 36);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(84, 237);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(112, 36);
            this.btn_Guardar.TabIndex = 8;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contraseña Nueva:";
            // 
            // txt_contraseniaNueva
            // 
            this.txt_contraseniaNueva.Location = new System.Drawing.Point(83, 120);
            this.txt_contraseniaNueva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_contraseniaNueva.Name = "txt_contraseniaNueva";
            this.txt_contraseniaNueva.PasswordChar = '*';
            this.txt_contraseniaNueva.Size = new System.Drawing.Size(235, 26);
            this.txt_contraseniaNueva.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Confirmar Contraseña:";
            // 
            // txt_confirmarContrasenia
            // 
            this.txt_confirmarContrasenia.Location = new System.Drawing.Point(83, 190);
            this.txt_confirmarContrasenia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_confirmarContrasenia.Name = "txt_confirmarContrasenia";
            this.txt_confirmarContrasenia.PasswordChar = '*';
            this.txt_confirmarContrasenia.Size = new System.Drawing.Size(235, 26);
            this.txt_confirmarContrasenia.TabIndex = 16;
            // 
            // frm_Usuarios_Contrsenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 315);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_confirmarContrasenia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_contraseniaNueva);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Usuarios_Contrsenia";
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.frm_Usuarios_Contrsenia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_contraseniaNueva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_confirmarContrasenia;
    }
}