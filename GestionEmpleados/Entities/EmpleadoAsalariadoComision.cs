using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados.Entities
{
    public sealed class EmpleadoAsalariadoComision : Empleado
    {
        public decimal VentasBrutas { get; set; }
        public decimal TarifaComision { get; set; }
        public decimal SalarioBase { get; set; }

        public EmpleadoAsalariadoComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision, decimal salarioBase) : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
            SalarioBase = salarioBase;
        }
        public override decimal CalcularPago()
        {
            return (VentasBrutas * TarifaComision) + SalarioBase + (SalarioBase * 0.10m);
        }

        public override string ObtenerDetallesPago()
        {
            decimal pago = CalcularPago();
            decimal extra = SalarioBase * 0.10m;
            return "Asalariado + Comisión: ($" + VentasBrutas.ToString("0.00") + " × " +
                   (TarifaComision * 100).ToString("0.00") + "%) + $" + SalarioBase.ToString("0.00") +
                   " + 10% de $" + SalarioBase.ToString("0.00") + " = $" + pago.ToString("0.00");
        }
    }
}
