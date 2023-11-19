using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        BLL.PersonaService personaService= new BLL.PersonaService();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona { 
                Cedula=txtCedula.Text,
                Nombre=txtNombre.Text,
                Telefono=txtTelefono.Text,
                FechaNacimiento=dtpFecha.Value
            };

            Guadar(persona);
        }

        private void Guadar(Persona persona)
        {
            var msg =personaService.Insertar(persona);
            MessageBox.Show(msg);   
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }
        void Eliminar(string cedula)
        {
            var msg = personaService.Eliminar(cedula);
            MessageBox.Show(msg);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar(txtCedula.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrillaPersonas();
        }

        private void cargarGrillaPersonas()
        {
           dgvPersonas.DataSource= personaService.ObtenerTodos();
            //dgvPersonas.AutoResizeColumns();
            dgvPersonas.Columns[0].Visible= false;
            //dgvPersonas.Columns[1].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill; // auto
            dgvPersonas.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgvPersonas.RowHeadersVisible=false;
        }

        private void dgvPersonas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           var fila= dgvPersonas.Rows[e.RowIndex];
            Persona persona = new Persona
            {
                Id= Convert.ToInt32( fila.Cells[0].Value),
                Cedula = fila.Cells[1].Value.ToString(),
                Nombre = fila.Cells[2].Value.ToString(),
                Telefono = fila.Cells[3].Value.ToString(),
                FechaNacimiento = Convert.ToDateTime(fila.Cells[4].Value)

            };
            var respuesta= MessageBox.Show("desea actualizar los datos ","actualizar datos",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                personaService.Actualizar(persona);
               MessageBox.Show("datos actualizados" );
                cargarGrillaPersonas();
            }
        }
    }
}
