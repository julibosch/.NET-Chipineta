using Ingreso;

namespace Ingreso
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            this.lblValidar.Visible = true;

            if (Ingreso.Program.Validar(this.txtUsuario.Text, this.txtPass.Text) != null)
            {
                this.lblValidar.Text = "Ususario encontrado";
                this.lblValidar.ForeColor = Color.Green;
            }
            else
            {
                this.lblValidar.Text = "Ususario no encontrado";
                this.lblValidar.ForeColor = Color.Red;
            }


        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formRegistro formregistro = new formRegistro();
            formregistro.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}