﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Presentacion.Reportes.Estaticos
{
    public partial class RepCirculos_Sociales : Form
    {

        static SqlConnection _Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        CITRADataSet dataReport = new CITRADataSet();

        string filtro;
        public RepCirculos_Sociales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataReport.Circulos_Sociales.Clear();
            _Conexion.Open();
            if (txt_Filtrar.Text != "")
            {
                switch (CB_CS.SelectedIndex)
                {
                    case 0:
                        filtro = "SELECT * FROM [dbo].[Circulos_Sociales] WHERE Nombre_Organizacion LIKE '%" + txt_Filtrar.Text + "%'";
                        break;
                    case 1:
                        filtro = "SELECT * FROM [dbo].[Circulos_Sociales] WHERE Nombre_Departamento LIKE '%" + txt_Filtrar.Text + "%'";
                        break;
                    case 2:
                        filtro = "SELECT * FROM [dbo].[Circulos_Sociales]";
                        break;
                    default:
                        filtro = "SELECT * FROM [dbo].[Circulos_Sociales]";
                        break;
                }
            }
            else filtro = "SELECT * FROM [dbo].[Circulos_Sociales]";
            SqlDataAdapter CirculosSoc = new SqlDataAdapter(filtro, _Conexion);
            CirculosSoc.Fill(dataReport.Circulos_Sociales);
            CirSoc CirSocReport = new CirSoc();
            CirSocReport.SetDataSource(dataReport);
            CR_CS.ReportSource = CirSocReport;
            _Conexion.Close();
        }
    }
}
