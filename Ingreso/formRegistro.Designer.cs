namespace Ingreso
{
    partial class formRegistro
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
            lblMail = new Label();
            lblPass = new Label();
            lblConfPass = new Label();
            label4 = new Label();
            txtMail = new TextBox();
            txtPass = new TextBox();
            txtRepitePass = new TextBox();
            lblIngreso = new Label();
            lnkIngresar = new LinkLabel();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblValidar = new Label();
            SuspendLayout();
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(86, 176);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 0;
            lblMail.Text = "Mail";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(86, 226);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(69, 15);
            lblPass.TabIndex = 1;
            lblPass.Text = "Contraseña";
            // 
            // lblConfPass
            // 
            lblConfPass.AutoSize = true;
            lblConfPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfPass.Location = new Point(86, 273);
            lblConfPass.Name = "lblConfPass";
            lblConfPass.Size = new Size(122, 15);
            lblConfPass.TabIndex = 2;
            lblConfPass.Text = "Confirma contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(214, 35);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 3;
            label4.Text = "Registro";
            // 
            // txtMail
            // 
            txtMail.Cursor = Cursors.IBeam;
            txtMail.Location = new Point(214, 173);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(261, 23);
            txtMail.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Location = new Point(214, 223);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(261, 23);
            txtPass.TabIndex = 5;
            txtPass.TextChanged += textBox2_TextChanged;
            // 
            // txtRepitePass
            // 
            txtRepitePass.BackColor = SystemColors.Window;
            txtRepitePass.BorderStyle = BorderStyle.FixedSingle;
            txtRepitePass.Cursor = Cursors.IBeam;
            txtRepitePass.Location = new Point(214, 270);
            txtRepitePass.Name = "txtRepitePass";
            txtRepitePass.PasswordChar = '*';
            txtRepitePass.Size = new Size(261, 23);
            txtRepitePass.TabIndex = 6;
            txtRepitePass.TextChanged += txtRepitePass_TextChanged;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(20, 334);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(97, 15);
            lblIngreso.TabIndex = 7;
            lblIngreso.Text = "¿Ya tiene cuenta?";
            lblIngreso.Click += lblIngreso_Click;
            // 
            // lnkIngresar
            // 
            lnkIngresar.AutoSize = true;
            lnkIngresar.Cursor = Cursors.Hand;
            lnkIngresar.Location = new Point(20, 351);
            lnkIngresar.Name = "lnkIngresar";
            lnkIngresar.Size = new Size(49, 15);
            lnkIngresar.TabIndex = 8;
            lnkIngresar.TabStop = true;
            lnkIngresar.Text = "Ingresar";
            lnkIngresar.LinkClicked += lnkIngresar_LinkClicked;
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(488, 343);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(361, 343);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(86, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(86, 132);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(214, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(261, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(214, 132);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(261, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValidar.Location = new Point(214, 316);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(74, 20);
            lblValidar.TabIndex = 11;
            lblValidar.Text = "validador";
            lblValidar.Visible = false;
            // 
            // formRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 388);
            Controls.Add(lblValidar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lnkIngresar);
            Controls.Add(lblIngreso);
            Controls.Add(txtRepitePass);
            Controls.Add(txtPass);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Controls.Add(lblConfPass);
            Controls.Add(lblPass);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblMail);
            Name = "formRegistro";
            Text = "formRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMail;
        private Label lblPass;
        private Label lblConfPass;
        private Label label4;
        private TextBox txtMail;
        private TextBox txtPass;
        private TextBox txtRepitePass;
        private Label lblIngreso;
        private LinkLabel lnkIngresar;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblValidar;
    }
}