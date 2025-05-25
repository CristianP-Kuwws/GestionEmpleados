using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados.Entities
{
    public class GestionarEmpleados
    {
        public List<Empleado> Empleados = new List<Empleado>();

        public void AgregarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
        }

        public void ActualizarEmpleado(int indice, Empleado empleadoNuevo)
        {
            if (indice >= 0 && indice < Empleados.Count)
            {
                Empleados[indice] = empleadoNuevo;
            }
        }

        public void GenerarReporteSemanal()
        {
            foreach (var empleado in Empleados)
            {
                Console.WriteLine($"Empleado {empleado.PrimerNombre} {empleado.ApellidoPaterno}");
                Console.WriteLine(empleado.ObtenerDetallesPago());
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
