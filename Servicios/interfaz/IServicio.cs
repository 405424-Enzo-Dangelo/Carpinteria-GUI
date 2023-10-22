using CarpinteriaGUI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaGUI.Servicios.interfaz
{
    public interface IServicio
    {
        int TraerProximoNro();
        List<Producto> TraerProductos();
        bool GrabarPresupuesto(Presupuesto oPresupuesto);
        bool ModificarPresupuesto(Presupuesto oPresupuesto);
        List<Presupuesto> TraerPresupuestosFiltrados(DateTime desde, DateTime hasta, string cliente);
    }
}
