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
using Microsoft.VisualBasic;
using CentroMedicoDesktop.models;
using CentroMedicoApi.Models;
using Microsoft.VisualBasic;

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

        private async Task ActualizarPaciente()

        {
            var filaSeleccionada = dgvPacientes.CurrentRow;

        {
            var filaSeleccionada = dgvPacientes.CurrentRow;

            if (int.TryParse(filaSeleccionada.Cells["Id"].Value?.ToString(), out int id))
            {
                // Obtener valores actuales
                string nombreActual = filaSeleccionada.Cells["Nombre"].Value?.ToString();
                string dniActual = filaSeleccionada.Cells["Dni"].Value?.ToString();
                string emailActual = filaSeleccionada.Cells["Email"].Value?.ToString();

                // Mostrar InputBox para editar
                string nuevoNombre = Interaction.InputBox("Nuevo nombre:", "Editar Paciente", nombreActual);
                string nuevoDni = Interaction.InputBox("Nuevo DNI:", "Editar Paciente", dniActual);
                string nuevoEmail = Interaction.InputBox("Nuevo Email:", "Editar Paciente", emailActual);

                // Validación mínima
                if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevoDni) || string.IsNullOrWhiteSpace(nuevoEmail))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                var pacienteActualizado = new Paciente
                {
                    Id = id,
                    Nombre = nuevoNombre,
                    Dni = nuevoDni,
                    Email = nuevoEmail
                };

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7099/");
                    var response = await client.PutAsJsonAsync($"api/Paciente/{id}", pacienteActualizado);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Paciente actualizado correctamente.");
                        await CargarPacientesAsync();
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al actualizar paciente: {response.StatusCode}. {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("ID de paciente inválido. Asegúrate de seleccionar una fila existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task ActualizarProfesional()
        {
            if (dgvProfesionales.CurrentRow != null)
            {
                var fila = dgvProfesionales.CurrentRow;

                if (int.TryParse(fila.Cells["Id"].Value?.ToString(), out int id))
                {
                    string nombreActual = fila.Cells["Nombre"].Value?.ToString();
                    string especialidadActual = fila.Cells["Especialidad"].Value?.ToString();
                    string matriculaActual = fila.Cells["Matricula"].Value.ToString();

                    string nuevoNombre = Interaction.InputBox("Nuevo nombre del profesional:", "Editar Profesional", nombreActual);
                    string nuevaEspecialidad = Interaction.InputBox("Nueva especialidad:", "Editar Profesional", especialidadActual);
                    string nuevaMatricula = Interaction.InputBox("Nueva matricula:", "Editar Profesional", matriculaActual);

                    if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevaEspecialidad))
                    {
                        MessageBox.Show("Todos los campos son obligatorios.");
                        return;
                    }

                    var profesionalActualizado = new Profesional
                    {
                        Id = id,
                        Nombre = nuevoNombre,
                        Especialidad = nuevaEspecialidad,
                        Matricula = nuevaMatricula
                    };

                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:7099/");
                        var response = await client.PutAsJsonAsync($"api/Profesional/{id}", profesionalActualizado);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Profesional actualizado correctamente.");
                            await CargarProfesionalesAsync();
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Error al actualizar profesional: {response.StatusCode}. {error}");
                        }
                    }
                }
            }
        }

        private async Task ActualizarCentroMedico()
        {
            var fila = dgvCentros.CurrentRow;

            if (int.TryParse(fila.Cells["Id"].Value?.ToString(), out int id))
            {
                string nombreActual = fila.Cells["Nombre"].Value?.ToString();
                string direccionActual = fila.Cells["Direccion"].Value?.ToString();
                string telefonoActual = fila.Cells["Telefono"].Value?.ToString();

                string nuevoNombre = Interaction.InputBox("Nuevo nombre del centro médico:", "Editar Centro Médico", nombreActual);
                string nuevaDireccion = Interaction.InputBox("Nueva dirección:", "Editar Centro Médico", direccionActual);
                string nuevoTelefono = Interaction.InputBox("Nuevo telefono:", "Editar Centro Médico", telefonoActual);

                if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevaDireccion))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                var centroActualizado = new CentroMedico
                {
                    Id = id,
                    Nombre = nuevoNombre,
                    Direccion = nuevaDireccion,
                    Telefono = nuevoTelefono
                };

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7099/");
                    var response = await client.PutAsJsonAsync($"api/CentroMedico/{id}", centroActualizado);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Centro médico actualizado correctamente.");
                        await CargarCentrosAsync();
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al actualizar centro médico: {response.StatusCode}. {error}");
                    }
                }
            }
        }

        private async Task ActualizarTurno()
        {
            if (dgvTurnos.CurrentRow != null)
            {
                var fila = dgvTurnos.CurrentRow;

                if (int.TryParse(fila.Cells["Id"].Value?.ToString(), out int id))
                {
                    string pacienteIdActual = fila.Cells["PacienteId"].Value?.ToString();
                    string profesionalIdActual = fila.Cells["ProfesionalId"].Value?.ToString();
                    string fechaHoraActual = fila.Cells["FechaHora"].Value?.ToString(); // formato esperado: "2025-05-28 14:30"
                    string estadoActual = fila.Cells["Estado"].Value.ToString();

                    string nuevoPacienteId = Interaction.InputBox("Nuevo ID del paciente:", "Editar Turno", pacienteIdActual);
                    string nuevoProfesionalId = Interaction.InputBox("Nuevo ID del profesional:", "Editar Turno", profesionalIdActual); 
                    string nuevaFechaHoraStr = Interaction.InputBox("Nueva fecha y hora (formato: yyyy-MM-dd HH:mm):", "Editar Turno", fechaHoraActual);
                    string nuevoEstado = Interaction.InputBox("Nuevo Estado del paciente:", "Editar Turno", estadoActual);

                    if (!int.TryParse(nuevoPacienteId, out int pacienteId) ||
                        !int.TryParse(nuevoProfesionalId, out int profesionalId) ||
                        !DateTime.TryParse(nuevaFechaHoraStr, out DateTime nuevaFechaHora))
                      
                    {
                        MessageBox.Show("Algún dato es inválido. Revisa los valores ingresados.");
                        return;
                    }

                    var turnoActualizado = new Turno
                    {
                        Id = id,
                        PacienteId = pacienteId,
                        ProfesionalId = profesionalId,
                        FechaHora = nuevaFechaHora,
                        Estado = nuevoEstado
                    };

                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:7099/");
                        var response = await client.PutAsJsonAsync($"api/Turno/{id}", turnoActualizado);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Turno actualizado correctamente.");
                            await CargarTurnosAsync();
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Error al actualizar turno: {response.StatusCode}. {error}");
                        }
                    }
                }
            }
        }

        private async Task EliminarPaciente()
        {
            if (dgvPacientes.CurrentRow != null)
            {
                var filaSeleccionada = dgvPacientes.CurrentRow;

                if (int.TryParse(filaSeleccionada.Cells["Id"].Value?.ToString(), out int id))
                {
                    var confirmacion = MessageBox.Show(
                        $"¿Estás seguro de que querés eliminar al paciente con ID {id}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmacion == DialogResult.Yes)
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            client.BaseAddress = new Uri("https://localhost:7099/");
                            var response = await client.DeleteAsync($"api/Paciente/{id}");

                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Paciente eliminado correctamente.");
                                await CargarPacientesAsync();
                            }
                            else
                            {
                                string error = await response.Content.ReadAsStringAsync();
                                MessageBox.Show($"Error al eliminar paciente: {response.StatusCode}. {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID de paciente inválido. Seleccioná una fila válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async Task EliminarProfesional()
        {
            if (dgvProfesionales.CurrentRow?.DataBoundItem is Profesional seleccionado)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7099/");

                    var response = await client.DeleteAsync($"api/Profesional/{seleccionado.Id}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Profesional eliminado correctamente.");
                        await CargarProfesionalesAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar: {response.ReasonPhrase}");
                    }
                }
            }
        }

        private async Task EliminarCentroMedico()
        {
            if (dgvCentros.CurrentRow?.DataBoundItem is CentroMedico seleccionado)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7099/");

                    var response = await client.DeleteAsync($"api/CentroMedico/{seleccionado.Id}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Centro médico eliminado correctamente.");
                        await CargarCentrosAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar: {response.ReasonPhrase}");
                    }
                }
            }
        }

        private async Task EliminarTurno()
        {
            if (dgvTurnos.CurrentRow?.DataBoundItem is Turno seleccionado)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7099/");

                    var response = await client.DeleteAsync($"api/Turno/{seleccionado.Id}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Turno eliminado correctamente.");
                        await CargarTurnosAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar: {response.ReasonPhrase}");
                    }
                }
            }
        }




        private async void button1_Click(object sender, EventArgs e)
        {
            await CargarPacientesAsync();
            await CargarTurnosAsync();
            await CargarProfesionalesAsync();
            await CargarCentrosAsync();



            if (int.TryParse(filaSeleccionada.Cells["Id"].Value?.ToString(), out int id))
            {
                // Obtener valores actuales
                string nombreActual = filaSeleccionada.Cells["Nombre"].Value?.ToString();
                string dniActual = filaSeleccionada.Cells["Dni"].Value?.ToString();
                string emailActual = filaSeleccionada.Cells["Email"].Value?.ToString();

                // Mostrar InputBox para editar
                string nuevoNombre = Interaction.InputBox("Nuevo nombre:", "Editar Paciente", nombreActual);
                string nuevoDni = Interaction.InputBox("Nuevo DNI:", "Editar Paciente", dniActual);
                string nuevoEmail = Interaction.InputBox("Nuevo Email:", "Editar Paciente", emailActual);

                // Validación mínima
                if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevoDni) || string.IsNullOrWhiteSpace(nuevoEmail))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                var pacienteActualizado = new Paciente
                {
                    Id = id,
                    Nombre = nuevoNombre,
                    Dni = nuevoDni,
                    Email = nuevoEmail
                };

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7099/");
                    var response = await client.PutAsJsonAsync($"api/Paciente/{id}", pacienteActualizado);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Paciente actualizado correctamente.");
                        await CargarPacientesAsync();
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al actualizar paciente: {response.StatusCode}. {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("ID de paciente inválido. Asegúrate de seleccionar una fila existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task ActualizarProfesional()
        {
            if (dgvProfesionales.CurrentRow != null)
            {
                var fila = dgvProfesionales.CurrentRow;

                if (int.TryParse(fila.Cells["Id"].Value?.ToString(), out int id))
                {
                    string nombreActual = fila.Cells["Nombre"].Value?.ToString();
                    string especialidadActual = fila.Cells["Especialidad"].Value?.ToString();
                    string matriculaActual = fila.Cells["Matricula"].Value.ToString();

                    string nuevoNombre = Interaction.InputBox("Nuevo nombre del profesional:", "Editar Profesional", nombreActual);
                    string nuevaEspecialidad = Interaction.InputBox("Nueva especialidad:", "Editar Profesional", especialidadActual);
                    string nuevaMatricula = Interaction.InputBox("Nueva matricula:", "Editar Profesional", matriculaActual);

                    if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevaEspecialidad))
                    {
                        MessageBox.Show("Todos los campos son obligatorios.");
                        return;
                    }

                    var profesionalActualizado = new Profesional
                    {
                        Id = id,
                        Nombre = nuevoNombre,
                        Especialidad = nuevaEspecialidad,
                        Matricula = nuevaMatricula
                    };

                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:7099/");
                        var response = await client.PutAsJsonAsync($"api/Profesional/{id}", profesionalActualizado);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Profesional actualizado correctamente.");
                            await CargarProfesionalesAsync();
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Error al actualizar profesional: {response.StatusCode}. {error}");
                        }
                    }
                }
            }
        }

        private async Task ActualizarCentroMedico()
        {
            var fila = dgvCentros.CurrentRow;

            if (int.TryParse(fila.Cells["Id"].Value?.ToString(), out int id))
            {
                string nombreActual = fila.Cells["Nombre"].Value?.ToString();
                string direccionActual = fila.Cells["Direccion"].Value?.ToString();
                string telefonoActual = fila.Cells["Telefono"].Value?.ToString();

                string nuevoNombre = Interaction.InputBox("Nuevo nombre del centro médico:", "Editar Centro Médico", nombreActual);
                string nuevaDireccion = Interaction.InputBox("Nueva dirección:", "Editar Centro Médico", direccionActual);
                string nuevoTelefono = Interaction.InputBox("Nuevo telefono:", "Editar Centro Médico", telefonoActual);

                if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevaDireccion))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                var centroActualizado = new CentroMedico
                {
                    Id = id,
                    Nombre = nuevoNombre,
                    Direccion = nuevaDireccion,
                    Telefono = nuevoTelefono
                };

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7099/");
                    var response = await client.PutAsJsonAsync($"api/CentroMedico/{id}", centroActualizado);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Centro médico actualizado correctamente.");
                        await CargarCentrosAsync();
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al actualizar centro médico: {response.StatusCode}. {error}");
                    }
                }
            }
        }

        private async Task ActualizarTurno()
        {
            if (dgvTurnos.CurrentRow != null)
            {
                var fila = dgvTurnos.CurrentRow;

                if (int.TryParse(fila.Cells["Id"].Value?.ToString(), out int id))
                {
                    string pacienteIdActual = fila.Cells["PacienteId"].Value?.ToString();
                    string profesionalIdActual = fila.Cells["ProfesionalId"].Value?.ToString();
                    string fechaHoraActual = fila.Cells["FechaHora"].Value?.ToString(); // formato esperado: "2025-05-28 14:30"
                    string estadoActual = fila.Cells["Estado"].Value.ToString();

                    string nuevoPacienteId = Interaction.InputBox("Nuevo ID del paciente:", "Editar Turno", pacienteIdActual);
                    string nuevoProfesionalId = Interaction.InputBox("Nuevo ID del profesional:", "Editar Turno", profesionalIdActual);
                    string nuevaFechaHoraStr = Interaction.InputBox("Nueva fecha y hora (formato: yyyy-MM-dd HH:mm):", "Editar Turno", fechaHoraActual);
                    string nuevoEstado = Interaction.InputBox("Nuevo Estado del paciente:", "Editar Turno", estadoActual);

                    if (
                        !int.TryParse(nuevoProfesionalId, out int profesionalId) ||
                        !DateTime.TryParse(nuevaFechaHoraStr, out DateTime nuevaFechaHora))

                    {
                        MessageBox.Show("Algún dato es inválido. Revisa los valores ingresados.");
                        return;
                    }

                    var turnoActualizado = new Turno
                    {
                        Id = id,

                        ProfesionalId = profesionalId,
                        FechaHora = nuevaFechaHora,
                        Estado = nuevoEstado
                    };

                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:7099/");
                        var response = await client.PutAsJsonAsync($"api/Turno/{id}", turnoActualizado);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Turno actualizado correctamente.");
                            await CargarTurnosAsync();
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Error al actualizar turno: {response.StatusCode}. {error}");
                        }
                    }
                }
            }
        }

        private async Task EliminarPaciente()
        {
            if (dgvPacientes.CurrentRow != null)
            {
                var filaSeleccionada = dgvPacientes.CurrentRow;

                if (int.TryParse(filaSeleccionada.Cells["Id"].Value?.ToString(), out int id))
                {
                    var confirmacion = MessageBox.Show(
                        $"¿Estás seguro de que querés eliminar al paciente con ID {id}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmacion == DialogResult.Yes)
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            client.BaseAddress = new Uri("https://localhost:7099/");
                            var response = await client.DeleteAsync($"api/Paciente/{id}");

                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Paciente eliminado correctamente.");
                                await CargarPacientesAsync();
                            }
                            else
                            {
                                string error = await response.Content.ReadAsStringAsync();
                                MessageBox.Show($"Error al eliminar paciente: {response.StatusCode}. {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID de paciente inválido. Seleccioná una fila válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async Task EliminarProfesional()
        {
            if (dgvProfesionales.CurrentRow?.DataBoundItem is Profesional seleccionado)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7099/");

                    var response = await client.DeleteAsync($"api/Profesional/{seleccionado.Id}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Profesional eliminado correctamente.");
                        await CargarProfesionalesAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar: {response.ReasonPhrase}");
                    }
                }
            }
        }

        private async Task EliminarCentroMedico()
        {
            if (dgvCentros.CurrentRow?.DataBoundItem is CentroMedico seleccionado)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7099/");

                    var response = await client.DeleteAsync($"api/CentroMedico/{seleccionado.Id}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Centro médico eliminado correctamente.");
                        await CargarCentrosAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar: {response.ReasonPhrase}");
                    }
                }
            }
        }

        private async Task EliminarTurno()
        {
            if (dgvTurnos.CurrentRow?.DataBoundItem is Turno seleccionado)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7099/");

                    var response = await client.DeleteAsync($"api/Turno/{seleccionado.Id}");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Turno eliminado correctamente.");
                        await CargarTurnosAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar: {response.ReasonPhrase}");
                    }
                }
            }
        }





        private async Task AgregarPaciente()
        {
            string nombre = Interaction.InputBox("Nombre del paciente:", "Agregar Paciente");
            string dni = Interaction.InputBox("DNI del paciente:", "Agregar Paciente");
            string email = Interaction.InputBox("Email del paciente:", "Agregar Paciente");

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            var nuevoPaciente = new Paciente
            {
                Nombre = nombre,
                Dni = dni,
                Email = email
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7099/");
                var response = await client.PostAsJsonAsync("api/Paciente", nuevoPaciente);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Paciente agregado correctamente.");
                    await CargarPacientesAsync();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al agregar paciente: {response.StatusCode}. {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private async Task AgregarCentroMedico()
        {
            string nombre = Interaction.InputBox("Nombre del centro médico:", "Agregar Centro Médico");
            string direccion = Interaction.InputBox("Dirección:", "Agregar Centro Médico");
            string telefono = Interaction.InputBox("Teléfono:", "Agregar Centro Médico");

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Nombre y dirección son obligatorios.");
                return;
            }

            var nuevoCentro = new CentroMedico
            {
                Nombre = nombre,
                Direccion = direccion,
                Telefono = telefono
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7099/");
                var response = await client.PostAsJsonAsync("api/CentroMedico", nuevoCentro);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Centro médico agregado correctamente.");
                    await CargarCentrosAsync();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al agregar centro médico: {response.StatusCode}. {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private async Task AgregarProfesional()
        {
            string nombre = Interaction.InputBox("Nombre del profesional:", "Agregar Profesional");
            string especialidad = Interaction.InputBox("Especialidad:", "Agregar Profesional");
            string matricula = Interaction.InputBox("Matrícula:", "Agregar Profesional");

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(especialidad) || string.IsNullOrWhiteSpace(matricula))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            var nuevoProfesional = new Profesional
            {
                Nombre = nombre,
                Especialidad = especialidad,
                Matricula = matricula
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7099/");
                var response = await client.PostAsJsonAsync("api/Profesional", nuevoProfesional);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Profesional agregado correctamente.");
                    await CargarProfesionalesAsync();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al agregar profesional: {response.StatusCode}. {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private async Task AgregarTurno()
        {
            string pacienteIdStr = Interaction.InputBox("ID del paciente:", "Agregar Turno");
            string profesionalIdStr = Interaction.InputBox("ID del profesional:", "Agregar Turno");
            string fechaHoraStr = Interaction.InputBox("Fecha y hora (formato: yyyy-MM-dd HH:mm):", "Agregar Turno");
            string estado = Interaction.InputBox("Estado del turno:", "Agregar Turno");

            if (
                !int.TryParse(profesionalIdStr, out int profesionalId) ||
                !DateTime.TryParse(fechaHoraStr, out DateTime fechaHora) ||
                string.IsNullOrWhiteSpace(estado))
            {
                MessageBox.Show("Algún dato es inválido o incompleto.");
                return;
            }

            var nuevoTurno = new Turno
            {
                ProfesionalId = profesionalId,
                FechaHora = fechaHora,
                Estado = estado
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7099/");
                var response = await client.PostAsJsonAsync("api/Turno", nuevoTurno);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Turno agregado correctamente.");
                    await CargarTurnosAsync();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al agregar turno: {response.StatusCode}. {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }






        private async void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabSeleccionada = tabControl1.SelectedTab.Text;

            switch (tabSeleccionada)
            {
                case "PACIENTES":
                    await ActualizarPaciente();
                    break;

                case "CENTRO MEDICOS":
                    await ActualizarCentroMedico();
                    break;

                case "PROFESIONALES":
                    await ActualizarProfesional();
                    break;

                case "TURNOS":
                    await ActualizarTurno();
                    break;

                default:
                    MessageBox.Show("Seleccioná una pestaña válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private async void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabSeleccionada = tabControl1.SelectedTab.Text;

            switch (tabSeleccionada)
            {
                case "PACIENTES":
                    await EliminarPaciente();
                    break;

                case "CENTRO MEDICOS":
                    await EliminarCentroMedico();
                    break;

                case "PROFESIONALES":
                    await EliminarProfesional();
                    break;

                case "TURNOS":
                    await EliminarTurno();
                    break;

                default:
                    MessageBox.Show("Seleccioná una pestaña válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private async void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabSeleccionada = tabControl1.SelectedTab.Text;

            switch (tabSeleccionada)
            {
                case "PACIENTES":
                    await AgregarPaciente();
                    break;

                case "CENTRO MEDICOS":
                    await AgregarCentroMedico();
                    break;

                case "PROFESIONALES":
                    await AgregarProfesional();
                    break;

                case "TURNOS":
                    await AgregarTurno();
                    break;

                default:
                    MessageBox.Show("Seleccioná una pestaña válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private async void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                await CargarPacientesAsync();
                await CargarTurnosAsync();
                await CargarProfesionalesAsync();
                await CargarCentrosAsync();

                MessageBox.Show("Los datos fueron actualizados correctamente.", "Actualización completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnActualizarPaciente_Click(object sender, EventArgs e)
        {
            var tabSeleccionada = tabControl1.SelectedTab.Text;

            switch (tabSeleccionada)
            {
                case "PACIENTES":
                    await ActualizarPaciente();
                    break;

                case "CENTRO MEDICOS":
                    await ActualizarCentroMedico();
                    break;

                case "PROFESIONALES":
                    await ActualizarProfesional();
                    break;

                case "TURNOS":
                    await ActualizarTurno();
                    break;

                default:
                    MessageBox.Show("Seleccioná una pestaña válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private async void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            var tabSeleccionada = tabControl1.SelectedTab.Text;

            switch (tabSeleccionada)
            {
                case "PACIENTES":
                    await EliminarPaciente();
                    break;

                case "CENTRO MEDICOS":
                    await EliminarCentroMedico();
                    break;

                case "PROFESIONALES":
                    await EliminarProfesional();
                    break;

                case "TURNOS":
                    await EliminarTurno();
                    break;

                default:
                    MessageBox.Show("Seleccioná una pestaña válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

    }
}
