﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Lotes : Form
    {
        public Frm_Lotes()
        {
            InitializeComponent();

            string[] alias = { "ID Lote", "Codigo ", "Producto", "Cantidad", "Fecha Creacion", "Fecha Expiracion", "Etapa", "Descripcion", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            // Instanciar colores personalizados
            Color colorFondo = ColorTranslator.FromHtml("#AEA1D6"); // Color de fondo
            Color colorFuente = ColorTranslator.FromHtml("#230050"); // Color de fuente
            navegador1.AsignarColorFondo(colorFondo);
            navegador1.AsignarColorFuente(colorFuente);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("tbl_lotes");
            navegador1.AsignarNombreForm("Lotes");
            // List<string> tablas = new List<string> { "otra_tabla_1", "otra_tabla_2" };
            // navegador1.AsignarTablas(tablas); 
        }
    }
}