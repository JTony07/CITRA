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
using Negocios;

namespace Presentacion
{
    public partial class BSectores : Form
    {
        public BSectores()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Buscar.Text != "") dgv.DataSource = sql.BuscarSectores(Txt_Buscar.Text);
            else dgv.DataSource = sql.MostrarDatosSectores(); 
        }

        private void BSectores_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatosSectores();
        }


    }
}
