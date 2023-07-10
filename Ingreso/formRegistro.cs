using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingreso
{
    public partial class formRegistro : Form
    {
        public formRegistro()
        {
            InitializeComponent();
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Length == 0 || txtRepitePass.Text.Length == 0)
            {
                this.lblValidar.Visible = false;
            }
            else
            {

                if (this.txtPass.Text == this.txtRepitePass.Text)
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.Text = "Las contraseñas coinciden.";
                    this.lblValidar.ForeColor = Color.Green;
                }
                else
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.Text = "Las contraseñas no coinciden.";
                    this.lblValidar.ForeColor = Color.Red;
                }
            }
        }

        private void lnkIngresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formLogin formIngreso = new formLogin();
            formIngreso.ShowDialog();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text.Length > 0 && this.txtApellido.Text.Length > 0 &&
                this.txtMail.Text.Length > 0 && this.txtPass.Text.Length > 0 && this.txtRepitePass.Text.Length > 0 &&
                this.txtPass.Text == this.txtRepitePass.Text)
            {
                Persona persona = new Persona(this.txtNombre.Text, this.txtApellido.Text, this.txtMail.Text, this.txtPass.Text);
                if (Ingreso.Program.AddPersona(persona))
                {
                    this.Hide();
                    formLogin formIngreso = new formLogin();
                    formIngreso.ShowDialog();

                }
                else
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.Text = "Ya está registrado en el sistema. Intente ingresar.";
                    this.lblValidar.ForeColor = Color.Red;
                }

            }
            else
            {
                if (this.txtNombre.Text.Length == 0 || this.txtApellido.Text.Length == 0 ||
                this.txtMail.Text.Length == 0 || this.txtPass.Text.Length == 0 || this.txtRepitePass.Text.Length == 0)
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.Text = "Complete todos los campos.";
                    this.lblValidar.ForeColor = Color.Red;
                }
                else
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.Text = "Las contraseñas no coinciden.";
                    this.lblValidar.ForeColor = Color.Red;
                }
            }
        }

        private void txtRepitePass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Length == 0 || txtRepitePass.Text.Length == 0)
            {
                this.lblValidar.Visible = false;
            }
            else
            {

                if (this.txtPass.Text == this.txtRepitePass.Text)
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.Text = "Las contraseñas coinciden.";
                    this.lblValidar.ForeColor = Color.Green;
                }
                else
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.Text = "Las contraseñas no coinciden.";
                    this.lblValidar.ForeColor = Color.Red;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin formIngreso = new formLogin();
            formIngreso.ShowDialog();
        }
    }
}
