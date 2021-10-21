using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Practica_Examen_1_Ejercicio_2.Clases;
using Practica_Examen_1_Ejercicio_2.Modelo;

namespace Practica_Examen_1_Ejercicio_2
{
    public partial class MostrarDatos1 : System.Web.UI.Page
    {
        CEmpleado cn = new CEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {
            Cargar();
        }


        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            int codigo_empleado = Convert.ToInt32(TxtCodigo.Text);
            string Nombre = TxtNombre.Text;
            decimal Horas_laboradas = Convert.ToInt32(TxtHoras.Text);
            decimal Salario_Hora = Convert.ToInt32(TxtSalHora.Text);
            decimal Salario_Bruto = Convert.ToInt32(TxtSalBruto.Text);

            cn.InsertarEmpleado(codigo_empleado, Nombre, Horas_laboradas, Salario_Hora, Salario_Bruto);
        }


        private void Cargar()
        {
            GridView1.DataSource = cn.MostrarEmpleado();
            GridView1.DataBind();
        }

        protected void btn_Mostrar_Click(object sender, EventArgs e)
        {
            Cargar();
        }
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            hf_Control.Value = Convert.ToString(GridView1.DataKeys[GridView1.SelectedRow.RowIndex].Value);
            Panel1.Visible = true;
            empleado obj = cn.extraerEmpleado(Convert.ToInt32(hf_Control.Value));
            TxtCodigo.Text = Convert.ToString(obj.codigo_empleado);
            TxtNombre.Text = obj.Nombre;
            TxtHoras.Text = Convert.ToString(obj.Horas_laboradas);
            TxtSalHora.Text = Convert.ToString(obj.Salario_Hora);
            TxtSalBruto.Text = Convert.ToString(obj.Salario_Bruto);

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onMouseOver", "this.style.cursor = 'pointer'");
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(GridView1, "select$" + e.Row.RowIndex.ToString()));
            }

        }

        protected void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
        }

        protected void btn_Borrar_Click(object sender, EventArgs e)
        {
            empleado obj = cn.borrarEmpleado(Convert.ToInt32(hf_Control.Value));
        }
    }
}