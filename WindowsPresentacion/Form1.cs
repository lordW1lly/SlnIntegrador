using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Models.Models.derivada;
using Negocio.Colecciones;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        AdmMedico admMedicos = new AdmMedico();
        AdmHabitacion admHabitaciones = new AdmHabitacion();
        AdmPaciente admPacientes = new AdmPaciente();

        public Form1()
        {
            InitializeComponent();
        }

        private void bttnVerMedicos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = admMedicos.Listar(); // aca estoy agregando al datagrid los medicos 
        }

        private void bttnMostrarPacientes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = admPacientes.Listar(); // aca estoy agregando al datagrid los pacientes
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = admHabitaciones.Listar(); // agregando pacientes al Datagrid
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Medico> clinicos;
            clinicos = admMedicos.Listar("Clinico");
            foreach(Medico medico in clinicos)
            {
                listBox1.Items.Add("Nombre: "+medico.Nombre +" Apellido: "+medico.Apellido+" " +"Especialidad: "+medico.Especialidad);
            }
            
        }
    }
}
