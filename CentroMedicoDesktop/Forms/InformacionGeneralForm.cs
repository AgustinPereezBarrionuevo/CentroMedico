using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http; 
using System.Net.Http.Json;
using CentroMedicoDesktop.Models;

namespace CentroMedicoDesktop.Forms
{
    public partial class InformacionGeneralForm : Form
    {
        public InformacionGeneralForm()
        {
            InitializeComponent();
            this.Load += InformacionGeneralForm_Load;
        }

        private async void InformacionGeneralForm_Load(object sender, EventArgs e)
        {
            try
            {
                await Task.WhenAll(
                    CargarPacientesAsync(),
                    CargarTurnosAsync(),
                    CargarProfesionalesAsync(),
                    CargarCentrosAsync()
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error general al cargar los datos: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarPacientesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7099/"); 
                client.Timeout = TimeSpan.FromSeconds(30);

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/Paciente");

                    if (response.IsSuccessStatusCode)
                    {
                        List<Paciente> pacientes = await response.Content.ReadFromJsonAsync<List<Paciente>>();
                        dgvPacientes.DataSource = pacientes;
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al cargar pacientes. Código: {response.StatusCode}. Mensaje: {errorMessage}", "Error de API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"Error de conexión a la API al cargar pacientes: {httpEx.Message}. Asegúrate de que la API esté funcionando en {client.BaseAddress}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error inesperado al cargar pacientes: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task CargarTurnosAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7099/"); 
                client.Timeout = TimeSpan.FromSeconds(30);
                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/Turno");
                    if (response.IsSuccessStatusCode)
                    {
                        List<Turno> turnos = await response.Content.ReadFromJsonAsync<List<Turno>>();
                        dgvTurnos.DataSource = turnos;
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al cargar turnos. Código: {response.StatusCode}. Mensaje: {errorMessage}", "Error de API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException httpEx) { MessageBox.Show($"Error de conexión al cargar turnos: {httpEx.Message}. Asegúrate de que la API esté funcionando.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                catch (Exception ex) { MessageBox.Show($"Ocurrió un error inesperado al cargar turnos: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private async Task CargarProfesionalesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7099/");
                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/Profesional");
                    if (response.IsSuccessStatusCode)
                    {
                        List<Profesional> profesionales = await response.Content.ReadFromJsonAsync<List<Profesional>>();
                        dgvProfesionales.DataSource = profesionales;
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al cargar profesionales. Código: {response.StatusCode}. Mensaje: {errorMessage}", "Error de API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException httpEx) { MessageBox.Show($"Error de conexión al cargar profesionales: {httpEx.Message}. Asegúrate de que la API esté funcionando.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                catch (Exception ex) { MessageBox.Show($"Ocurrió un error inesperado al cargar profesionales: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private async Task CargarCentrosAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7099/"); 
                client.Timeout = TimeSpan.FromSeconds(30);
                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/CentroMedico");
                    if (response.IsSuccessStatusCode)
                    {
                        List<CentroMedico> centros = await response.Content.ReadFromJsonAsync<List<CentroMedico>>();
                        dgvCentros.DataSource = centros;
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al cargar centros. Código: {response.StatusCode}. Mensaje: {errorMessage}", "Error de API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException httpEx) { MessageBox.Show($"Error de conexión al cargar centros: {httpEx.Message}. Asegúrate de que la API esté funcionando.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                catch (Exception ex) { MessageBox.Show($"Ocurrió un error inesperado al cargar centros: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await CargarPacientesAsync();
            await CargarTurnosAsync();
            await CargarProfesionalesAsync();
            await CargarCentrosAsync(); 
            

        }
    }
}
