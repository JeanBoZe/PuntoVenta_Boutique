using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Punto_VentaRG.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Conexion conex = new Clases.Conexion();

                using (SqlConnection con = conex.Conectar())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_LOGIN", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@USUARIO", txt_usuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text.Trim());

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        // Guardar datos globales del usuario logueado
                        int userId = Convert.ToInt32(dr["USU_ID"]);
                        string nombre = dr["USU_NOMBRE"].ToString();
                        int nivel = Convert.ToInt32(dr["USU_NIVEL"]);

                        // Abrir pantalla principal
                        Menu menu = new Menu(userId, nombre, nivel);
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Contacta a el autor",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es Enter (código ASCII 13)
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Llama al evento click del botón
                btn_entrar_Click(sender, e);

                // Opcional: Evita que el sonido de 'beep' se reproduzca al presionar Enter
                e.Handled = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
