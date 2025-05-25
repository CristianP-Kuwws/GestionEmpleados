using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados.Entities
{
    public sealed class EmpleadoPorHoras : Empleado
    {
        public decimal SueldoPorHora { get; set; }
        public int HorasTrabajadas { get; set; }

        public EmpleadoPorHoras(string apellidoPaterno, string numeroSeguroSocial, decimal sueldoPorHora, int horasTrabajadas) : base(apellidoPaterno, numeroSeguroSocial)
        {
            SueldoPorHora = sueldoPorHora;
            HorasTrabajadas = horasTrabajadas;
        }
        public override decimal CalcularPago()
        {
            if (HorasTrabajadas <= 40)
            {
                return SueldoPorHora * HorasTrabajadas;
            } 
            else
            {
                return (SueldoPorHora * 40) + (SueldoPorHora * 1.5m * (HorasTrabajadas - 40));
            }
            
        }

        public override string ObtenerDetallesPago()
        {
            decimal pago = CalcularPago();

            if (HorasTrabajadas <= 40)
            {
                return "Por horas: " + HorasTrabajadas + "h x $" + SueldoPorHora.ToString("0.00") + " = $" + pago.ToString("0.00");
            }
            else
            {
                decimal horasExtra = HorasTrabajadas - 40;
                decimal pagoExtra = SueldoPorHora * 1.5m * horasExtra;

                return "Por Horas: 40h × $" + SueldoPorHora.ToString("0.00") + " + " +
                horasExtra + "h × $" + (SueldoPorHora * 1.5m).ToString("0.00") + " = $" + pago.ToString("0.00");
            }
        }
    }
}
