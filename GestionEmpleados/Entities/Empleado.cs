using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados.Entities
{
    public abstract class Empleado
    {
        public string PrimerNombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string NumeroSeguroSocial { get; set; }

        public Empleado(string apellido, string numeroSeguroSocial) //Este constructor sirve para la clase EmpleadoPorHoras, ya que esta no pide PrimerNombre en el SRS
        {
            ApellidoPaterno = apellido;
            NumeroSeguroSocial = numeroSeguroSocial;
        }

        public Empleado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguroSocial = numeroSeguroSocial;
        }
        public abstract decimal CalcularPago();
        public abstract string ObtenerDetallesPago();

    }
}
