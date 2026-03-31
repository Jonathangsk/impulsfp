using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IMPULS_Desktop
{
    public partial class Candidats : Form
    {
        private List<string> candidats;

        public Candidats(List<string> candidats)
        {
            InitializeComponent();
            this.candidats = candidats;
        }

        private void Candidats_Load(object sender, EventArgs e)
        {
            CargarCandidats();
        }

        private void CargarCandidats()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = candidats
                .Select(c => new { Nom = c })
                .ToList();
        }

        private void btnTriarCandidat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un candidat");
                return;
            }

            string candidat = dataGridView1.CurrentRow.Cells["Nom"].Value.ToString();
            MessageBox.Show("Candidat seleccionat: " + candidat);
        }

        private void btnEliminarCandidat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un candidat");
                return;
            }

         string candidat = dataGridView1.CurrentRow.Cells["Nom"].Value.ToString();
            var confirm = MessageBox.Show(
                "Segur que vols eliminar a " + candidat + "?",
                "Confirmar",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                candidats.Remove(candidat);

                CargarCandidats();
            }
        }
    }
}