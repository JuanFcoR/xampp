using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamppTest.Conexion;
using XamppTest.UI.Registros;

namespace XamppTest
{
    public partial class PerosnasDataGridView : Form
    {
        public PerosnasDataGridView()
        {
            InitializeComponent();
        }

        private void Consultar()
        {
            string sql = "Select UsuarioId,Nombres,Edad FROM usuario";
            MySqlCommand cmd = new MySqlCommand(sql, DBConexion.ObtenerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            DataGridView.Rows.Clear();

            while(reader.Read())
            {
                object[] fila = { reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2) };
                DataGridView.Rows.Add(fila);
            }

        }
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            rAgregar ag = new rAgregar();
            ag.Visible = true;
            Consultar();
        }

        private void PerosnasDataGridView_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
