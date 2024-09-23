using Corte1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private Registro registro;
        private Operacion operacion;
        private ComboBox cmbCiudad; 

        public Form1()
        {
            InitializeComponent();
            registro = new Registro();
            operacion = new Operacion();
            cmbCiudad = new ComboBox(); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Ciudad = cmbCiudad.SelectedItem?.ToString()
            };

            registro.AgregarPersona(persona);
            MessageBox.Show("Persona agregada exitosamente.");
        }

        private void btnMostrarEdad_Click(object sender, EventArgs e)
        {
            if (registro.ObtenerPersonas().Length > 0)
            {
                Persona persona = registro.ObtenerPersonas().Last();
                int edad = operacion.CalcularEdad(persona);
                bool esMayorDeEdad = operacion.EsMayorDeEdad(persona);

                MessageBox.Show($"La edad de {persona.Nombres} {persona.Apellidos} es {edad} años. " +
                                $"Es {(esMayorDeEdad ? "mayor" : "menor")} de edad.");
            }
            else
            {
                MessageBox.Show("No hay personas registradas.");
            }
        }

        private void cmbCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarPersonas_Click(object sender, EventArgs e)
        {

        }
        private void btnMostrarPersonas_Click(object sender, EventArgs e)
    {
        lstPersonas.Items.Clear();
        foreach (var persona in registro.ObtenerPersonas())
        {
            lstPersonas.Items.Add($"{persona.Nombres} {persona.Apellidos} - {persona.Ciudad}");
        }
    }
    }
}
