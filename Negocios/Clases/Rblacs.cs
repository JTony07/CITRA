﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class Rblacs
    {
        public Int32 Insertar(Rblac Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Rblacs IControlador;

            try
            {
                IControlador = new Acceso_Datos.Rblacs();
                FilasAfectadas = IControlador.Insertar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Modificar(Rblac Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Rblacs IControlador;

            try
            {
                IControlador = new Acceso_Datos.Rblacs();
                FilasAfectadas = IControlador.Modificar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public System.Data.DataTable LlenarLista()
        {
            Acceso_Datos.Rblacs IControlador;
            try
            {
                IControlador = new Acceso_Datos.Rblacs();
                return IControlador.LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Int32 Eliminar(Rblac Data)
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Rblacs IControlador;

            try
            {
                IControlador = new Acceso_Datos.Rblacs();
                FilasAfectadas = IControlador.Eliminar(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public Int32 Eliminar()
        {
            Int32 FilasAfectadas = 0;
            Acceso_Datos.Rblacs IControlador;

            try
            {
                IControlador = new Acceso_Datos.Rblacs();
                FilasAfectadas = IControlador.Eliminar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }

        public System.Data.DataTable LeerCodigoLlave(string pCodigoL)
        {
            Acceso_Datos.Rblacs IControlador;
            try
            {
                IControlador = new Acceso_Datos.Rblacs();
                return IControlador.LeerCodigoLlave(pCodigoL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Rblac LeerCodigoLlave(Int32 pCodigoL)//Int32 pCodigoL, string pCodigoNP
        {
            Acceso_Datos.Rblacs IControlador;
            try
            {
                IControlador = new Acceso_Datos.Rblacs();
                return IControlador.LeerCodigoLlave(pCodigoL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }




    }
}
