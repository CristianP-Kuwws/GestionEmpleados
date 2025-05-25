using GestionEmpleados.Entities;
using System.Numerics;

namespace GestionEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GestionarEmpleados gestionar = new GestionarEmpleados();

            EmpleadoAsalariado empAsalariado = new EmpleadoAsalariado("Juan", "Figueroa", "20252020", 750);

            EmpleadoPorHoras empHoras = new EmpleadoPorHoras("Marquez", "19992021", 20, 8);

            EmpleadoPorComision empComision = new EmpleadoPorComision("Tony", "Cipriani", "20055000", 14000, 0.06m);

            EmpleadoAsalariadoComision empleadoAC = new EmpleadoAsalariadoComision("Carlos", "Gonza", "19992000", 170000, 0.08m, 600);

            gestionar.AgregarEmpleado(empAsalariado);
            gestionar.AgregarEmpleado(empHoras);
            gestionar.AgregarEmpleado(empComision);
            gestionar.AgregarEmpleado(empleadoAC);

            gestionar.GenerarReporteSemanal();

            EmpleadoPorHoras empHorasActualizado = new EmpleadoPorHoras("Marquez", "19992021", 50, 10);

            gestionar.ActualizarEmpleado(1, empHorasActualizado);

            Console.WriteLine("\n=== Después de Actualizar ===\n");
            gestionar.GenerarReporteSemanal();
        }
    }
}
