using CarpinteriaGUI.Datos.implementacion;
using CarpinteriaGUI.Datos.interfaz;
using CarpinteriaGUI.Entidades;
using CarpinteriaGUI.Servicios.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaGUI.Servicios.implementacion
{
    public class Servicio : IServicio
    {
        private IPresupuestoDao dao;

        public Servicio()
        {
            dao = new PresupuestoDao();
        }

        public int TraerProximoNro()
        {
            return dao.ObtenerProximoNro();
        }

        public List<Producto> TraerProductos()
        {
            return dao.ObtenerProductos();
        }

        public bool GrabarPresupuesto(Presupuesto oPresupuesto)
        {
            return dao.Crear(oPresupuesto);
        }

        public bool ModificarPresupuesto(Presupuesto oPresupuesto)
        {
            return dao.Actualizar(oPresupuesto);
        }

        public List<Presupuesto> TraerPresupuestosFiltrados(DateTime desde, DateTime hasta, string cliente)
        {
            return dao.ObtenerPresupuestoPorFiltros(desde, hasta, cliente);
        }
    }
}
