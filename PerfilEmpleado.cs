using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActTres.CapaController;
using ActTres.CapaModel;


namespace ActividadIII_Formulario.CapaView
{
    public partial class PerfilEmpleado : Form
    {
        EmpleadosController emple = new EmpleadosController();
        EmpleadoModel model = new EmpleadoModel();


        public PerfilEmpleado()
        {
            InitializeComponent();
        }

        private void refrescar()
        {
            EmpleadosController emple = new EmpleadosController();
            DepartamentoController depto = new DepartamentoController();
            dgvempleado.DataSource = emple.getempleados();

            cmbdepto.DataSource = depto.getdepar();
            cmbdepto.DisplayMember = "Abreviatura";
            cmbdepto.ValueMember = "IdDepartamento";
        }
        private void PerfilEmpleado_Load(object sender, EventArgs e)
        {

            this.refrescar();

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            model.Nombre = txtnombre.Text;
            model.Identidad = txtidentidad.Text;
            model.Fecha = dtfecha.Value;
            model.Puesto = txtpuesto.Text;
            model.IdDepartamento = Convert.ToInt32  (cmbdepto.SelectedValue);
            emple.CrearEmpleado(model);

            txtnombre.Text = "";
            txtidentidad.Text = "";
            txtpuesto.Text = "";
            cmbdepto.SelectedIndex = 0;

            this.refrescar();
        }
    }
}
