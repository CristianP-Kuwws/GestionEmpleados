using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados.Entities
{
    public sealed class EmpleadoPorComision : Empleado
    {
        public decimal VentasBrutas { get; set; }
        public decimal TarifaComision { get; set; }

        public EmpleadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision) : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
        }
        public override decimal CalcularPago()
        {
            return VentasBrutas * TarifaComision;
        }

        public override string ObtenerDetallesPago()
        {
            decimal pago = CalcularPago();

            return "Por Comisión: $" + VentasBrutas.ToString("0.00") + " × " +
                   (TarifaComision * 100).ToString("0.00") + "% = $" + pago.ToString("0.00");
        }
    }
}
