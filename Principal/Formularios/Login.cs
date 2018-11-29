﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Presentacion;


namespace Principal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btninciosesion_Click(object sender, EventArgs e)
        {
            try
            {
                #region "Validaciones campos vacíos"
                if (this.txtusuario.Text == "")
                    {
                        MessageBox.Show("El campo Usuario no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (this.txtcontraseña.Text == "")
                    {
                        MessageBox.Show("El campo Contraseña no puede estar vacío ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                #endregion

                    SqlConnection _Conexion = new SqlConnection(@"Data Source=JTONYVAIO; Initial Catalog= CITRA; Integrated Security= true; MultipleActiveResultSets=True");

                    string CadenaSql = "SELECT Id_Usuario, Nombre_Usuario, Contraseña, Roles FROM Usuarios WHERE Nombre_Usuario= '" + txtusuario.Text + "' AND Contraseña= '" + txtcontraseña.Text + "'";
                    SqlCommand comando = new SqlCommand(CadenaSql, _Conexion);
                    _Conexion.Open();

                    SqlDataReader leer = comando.ExecuteReader();
                    int iduser = 0;
                    int idrol = 0;
                    string usuario= null;

                    if (leer.Read() == true)
                    {
                        MessageBox.Show("Bienvenido " + txtusuario.Text + " ", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        /*Obtener ID del Usuario*/
                        iduser = leer.GetInt32(0);/*Id del Usuario*/
                        usuario = leer.GetString(1);/*Id ROL del Usuario*/
                        idrol = leer.GetInt32(3);/*Id ROL del Usuario*/
                        //MessageBox.Show("User " + iduser.ToString() + " ", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        Menu_Principal frmPrincipal = new Menu_Principal(iduser, idrol, usuario );
                        frmPrincipal.Show();                   
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Error al ingresar los datos, Consulte al administrador", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _Conexion.Close();
                    
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

          }
                   
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
