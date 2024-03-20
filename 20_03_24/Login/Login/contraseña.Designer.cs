namespace Login
{
    partial class contraseña
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entrar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(-35, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(841, 20);
            this.textBox2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources._20;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(277, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "RECUPERAR CONTRASEÑA";
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.Red;
            this.entrar.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.entrar.Location = new System.Drawing.Point(373, 181);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(134, 42);
            this.entrar.TabIndex = 27;
            this.entrar.Text = "ENVIAR";
            this.entrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Login.Properties.Resources._18;
            this.pictureBox4.Location = new System.Drawing.Point(287, 142);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(290, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.MenuText;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.SystemColors.Window;
            this.pass.Location = new System.Drawing.Point(309, 110);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(253, 16);
            this.pass.TabIndex = 24;
            this.pass.Text = "Ingrese su Correo Electronico";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(606, 322);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Name = "contraseña";
            this.Text = "contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox pass;
    }
}