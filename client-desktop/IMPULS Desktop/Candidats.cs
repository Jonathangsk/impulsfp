using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace IMPULS_Desktop
{
    public partial class Candidats : Form
    {
        private readonly HttpClient client = new HttpClient();
        private List<Candidat> candidats = new List<Candidat>();

        private string apiUrl = "https://tu-servidor/api/candidats";

        public Candidats()
        {
            InitializeComponent();
        }

        private async void Candidats_Load(object sender, EventArgs e)
        {
            await CargarCandidats();

            // 🔥 EVENTO CORRECTO AQUÍ
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        // =========================
        // CARGAR
        // =========================
        private async System.Threading.Tasks.Task CargarCandidats()
        {
            try
            {
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                candidats = JsonSerializer.Deserialize<List<Candidat>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = candidats;
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("❌ No se puede conectar con el servidor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }

        // =========================
        // PUT AUTOMÁTICO
        // =========================
        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var c = (Candidat)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                var json = JsonSerializer.Serialize(c);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"{apiUrl}/{c.Id}", content);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("❌ Error de conexión al guardar");
                await CargarCandidats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al actualizar: " + ex.Message);
                await CargarCandidats();
            }
        }

        // =========================
        // SELECCIONAR
        // =========================
        private void btnTriarCandidat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un candidat");
                return;
            }

            var c = (Candidat)dataGridView1.CurrentRow.DataBoundItem;
            MessageBox.Show("Candidat seleccionat: " + c.Nom);
        }

        // =========================
        // DELETE
        // =========================
        private async void btnEliminarCandidat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un candidat");
                return;
            }

            var c = (Candidat)dataGridView1.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(
                "Segur que vols eliminar a " + c.Nom + "?",
                "Confirmar",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var response = await client.DeleteAsync($"{apiUrl}/{c.Id}");
                response.EnsureSuccessStatusCode();

                await CargarCandidats();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("❌ Error de conexión");
            }
        }

        private void btnTancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

    // =========================
    // MODELO
    // =========================
    public class Candidat
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }
}