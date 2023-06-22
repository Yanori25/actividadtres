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

namespace ActTres.CapaView
{
    public partial class Perfilepartamento : Form
    {
        
        public Perfilepartamento()
        {
            InitializeComponent();
        }

        private void PerfilDepartamento_Load(object sender, EventArgs e)
        {
            DepartamentoController depto = new DepartamentoController();
            dgvdepto.DataSource = depto.getdepartamento();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            DepartamentoModel model = new DepartamentoModel();

            model.Departamento = txtDepartamento.Text;
            model.Abreviatura = txtAbreviatura.Text;


            DepartamentoController depto = new DepartamentoController();
            depto.CrearDepartamento(model);
            txtAbreviatura.Text = "";
            txtDepartamento.Text = "";
        }
    }
}
