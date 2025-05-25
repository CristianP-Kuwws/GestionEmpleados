using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados.Entities
{
    public sealed class EmpleadoAsalariado : Empleado
    {
        public decimal SalarioSemanal { get; set; }

        public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salarioSemanal) : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            SalarioSemanal = salarioSemanal;
        }

        public override decimal CalcularPago()
        {
            return SalarioSemanal;
        }

        public override string ObtenerDetallesPago()
        {
            return "Asalariado: $" + SalarioSemanal.ToString("0.00") + " por semana";
        }
    }
}
