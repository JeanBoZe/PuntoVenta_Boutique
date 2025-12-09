using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_VentaRG
{
    public partial class Menu : Form
    {
        private int userId;
        private string userNom;
        private int userNivel;
        public Menu(int _userId, string _userNom, int _userNivel)
        {
            InitializeComponent();

            userId = _userId;
            userNom = _userNom;
            userNivel = _userNivel;

            lbl_user.Text = $"{userNom}";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Login login = new Forms.Login();
            login.Show();
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            // 1. Buscamos si el formulario "Venta" ya está abierto
            Form formularioExistente = null;
            foreach (Form formAbierto in this.MdiChildren)
            {
                // Comprueba si el formulario abierto es del TIPO "Venta"
                if (formAbierto is Venta)
                {
                    formularioExistente = formAbierto;
                    break; // Lo encontramos, salimos del bucle
                }
            }

            // 2. Decidimos qué hacer
            if (formularioExistente != null)
            {
                // SI YA EXISTE:

                // Si estaba minimizado, lo restauramos a normal
                if (formularioExistente.WindowState == FormWindowState.Minimized)
                {
                    formularioExistente.WindowState = FormWindowState.Normal;
                }

                // Lo traemos al frente
                formularioExistente.Activate();
            }
            else
            {
                // NO EXISTE: Creamos uno nuevo

                // 3. Minimizamos el que esté activo (tu lógica original)
                if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.WindowState = FormWindowState.Minimized;
                }

                // 4. Creamos la nueva instancia (con tus parámetros)
                Venta frmVenta = new Venta(userId);
                frmVenta.MdiParent = this;

                // 5. Asignamos la posición (de la pregunta anterior)
                frmVenta.StartPosition = FormStartPosition.Manual;
                frmVenta.Location = new Point(0, 0);

                frmVenta.Show();
            }
        }
        private void btn_productos_Click(object sender, EventArgs e)
        {
            // 1. Buscamos si el formulario "Producto" ya está abierto
            Form formularioExistente = null;
            foreach (Form formAbierto in this.MdiChildren)
            {
                // Comprueba si el formulario abierto es del TIPO "Producto"
                if (formAbierto is Producto)
                {
                    formularioExistente = formAbierto;
                    break; // Lo encontramos
                }
            }

            // 2. Decidimos qué hacer
            if (formularioExistente != null)
            {
                // SI YA EXISTE:

                // Si estaba minimizado, lo restauramos
                if (formularioExistente.WindowState == FormWindowState.Minimized)
                {
                    formularioExistente.WindowState = FormWindowState.Normal;
                }

                // Lo traemos al frente
                formularioExistente.Activate();
            }
            else
            {
                // NO EXISTE: Creamos uno nuevo

                // 3. Minimizamos el que esté activo (tu lógica original)
                if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.WindowState = FormWindowState.Minimized;
                }

                // 4. Creamos la nueva instancia
                Producto frmProducto = new Producto();
                frmProducto.MdiParent = this;

                // 5. Asignamos la posición (de la pregunta anterior)
                frmProducto.StartPosition = FormStartPosition.Manual;
                frmProducto.Location = new Point(0, 0);

                frmProducto.Show();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_rptVentas_Click(object sender, EventArgs e)
        {
            // 1. Buscamos si el formulario "Producto" ya está abierto
            Form formularioExistente = null;
            foreach (Form formAbierto in this.MdiChildren)
            {
                // Comprueba si el formulario abierto es del TIPO "Producto"
                if (formAbierto is Forms.Rpt_Ventas)
                {
                    formularioExistente = formAbierto;
                    break; // Lo encontramos
                }
            }

            // 2. Decidimos qué hacer
            if (formularioExistente != null)
            {
                // SI YA EXISTE:

                // Si estaba minimizado, lo restauramos
                if (formularioExistente.WindowState == FormWindowState.Minimized)
                {
                    formularioExistente.WindowState = FormWindowState.Normal;
                }

                // Lo traemos al frente
                formularioExistente.Activate();
            }
            else
            {
                // NO EXISTE: Creamos uno nuevo

                // 3. Minimizamos el que esté activo (tu lógica original)
                if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.WindowState = FormWindowState.Minimized;
                }

                // 4. Creamos la nueva instancia
                Forms.Rpt_Ventas frmRptVentas = new Forms.Rpt_Ventas();
                frmRptVentas.MdiParent = this;

                // 5. Asignamos la posición (de la pregunta anterior)
                frmRptVentas.StartPosition = FormStartPosition.Manual;
                frmRptVentas.Location = new Point(0, 0);

                frmRptVentas.Show();

            }
        }
    }
}
