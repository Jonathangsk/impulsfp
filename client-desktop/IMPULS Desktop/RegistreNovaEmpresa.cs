using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IMPULS_Desktop
{
    
    public partial class RegistreNovaEmpresa : Form
    {
        private string rutaImagen;
        private Form formularioAnterior;
        public RegistreNovaEmpresa(Form formAnterior)
        {
            InitializeComponent();
            formularioAnterior = formAnterior;
        }



        private void perfil_Click(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDesar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();

            empresa.Name = textNom.Text;
            empresa.Email = textEmail.Text;
            empresa.Address = textAdreça.Text;
            empresa.VatNumber = textCif.Text;
            empresa.Website = textWeb.Text;
            empresa.Phone = textTelefon.Text;
            empresa.Niche = textSector.Text;
            empresa.Technologies = textTecnologies.Text;

            empresa.ProfilePhoto = rutaImagen;
            MessageBox.Show("Empresa guardada correctament");
        }

        private void OfertesActives_SelectedIndexChanged(object sender, EventArgs e)
        { }
            private void CargarOfertas(Empresa empresa)
        {
            OfertesActives.Items.Clear();

            foreach (Oferta o in empresa.ActiveOffers)
            {
                OfertesActives.Items.Add(o.Title);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            textNom.Clear();
            textEmail.Clear();
            textAdreça.Clear();
            textCif.Clear();
            textWeb.Clear();
            textTelefon.Clear();
            textSector.Clear();
            textTecnologies.Clear();


            MessageBox.Show("Formulari net");
        }

        private void btnTornar_Click(object sender, EventArgs e)
        {
            formularioAnterior.Show(); 
            this.Close();
        }

        private void btnTancar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

