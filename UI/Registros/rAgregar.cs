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

namespace XamppTest.UI.Registros
{
    public partial class rAgregar : Form
    {
        public rAgregar()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            string sql = "Insert into usuario (UsuarioId, Nombres, Edad) values('{0}','{1}','{2}')";
            MySqlCommand cmd = new MySqlCommand(String.Format(sql, Convert.ToString(UsuarioIdNumericUpDown.Value),NombreTextBox.Text,Convert.ToString(EdadNumericUpDown.Value)),DBConexion.ObtenerConexion());
            cmd.ExecuteNonQuery();

            Close();

        }

       
    }
}
