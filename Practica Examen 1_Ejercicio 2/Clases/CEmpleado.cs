using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practica_Examen_1_Ejercicio_2.Modelo;

namespace Practica_Examen_1_Ejercicio_2.Clases
{
    public class CEmpleado
    {
        PractExa1Entities db = new PractExa1Entities();

        public List<empleado> MostrarEmpleado()
        {
            return db.empleado.ToList();
        }

        public void InsertarEmpleado(int codigo_empleado, string Nombre,decimal Horas_laboradas, decimal Salario_Hora, decimal Salario_Bruto)
        {
            empleado a = new empleado();
            a.codigo_empleado = codigo_empleado;
            a.Nombre = Nombre;
            a.Horas_laboradas = Horas_laboradas;
            a.Salario_Hora = Salario_Hora;
            a.Salario_Bruto = Salario_Bruto;
            db.empleado.Add(a);
            db.SaveChanges();
        }


        public empleado extraerEmpleado(int codigo_empleado)
        {
            empleado obj = db.empleado.Single(x => x.codigo_empleado == codigo_empleado);
            return obj;
        }

        public empleado borrarEmpleado(int codigo_empleado)
        {
            empleado obj = db.empleado.Single(x => x.codigo_empleado == codigo_empleado);
            db.empleado.Remove(obj);
            db.SaveChanges();
            return obj;
        }
    }
}