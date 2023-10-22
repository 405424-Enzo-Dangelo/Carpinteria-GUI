using CarpinteriaGUI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaGUI.Datos.interfaz
{
    public interface IPresupuestoDao
    {
        int ObtenerProximoNro();
        List<Producto> ObtenerProductos();
        bool Crear(Presupuesto oPresupuesto);
        bool Actualizar(Presupuesto oPresupuesto);
        List<Presupuesto> ObtenerPresupuestoPorFiltros(DateTime desde, DateTime hasta, string cliente);
        Presupuesto ObtenerPresupuestoNro(int numero);
    }
}
