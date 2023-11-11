using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FormUsuario());
        }

        public void Abrirformhijo(object formhijo)
        {
            if (this.paneVentanas.Controls.Count > 0)
                this.paneVentanas.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.paneVentanas.Controls.Add(fh);
            this.paneVentanas.Tag = fh;
            fh.Show();
        }

        private void btnLocales_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new Locales());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FormReserva());
        }

        private void btnArtista_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FormArtista());
        }
    }
}
