using CarpinteriaGUI.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpinteriaGUI.Presentacion
{
    public partial class FrmReporteProductosPresupuestados : Form
    {
        public FrmReporteProductosPresupuestados()
        {
            InitializeComponent();
        }

        private void FrmReporteProductosPresupuestados_Load(object sender, EventArgs e)
        {
            dtp_fecha_desde.Value = DateTime.Now.AddDays(-30);
            dtp_fecha_hasta.Value = DateTime.Now;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@fecha_desde", dtp_fecha_desde.Value));
            lista.Add(new Parametro("@fecha_hasta", dtp_fecha_hasta.Value));

            //this.dTProductosPresupuestadosBindingSource.DataSource = new DBhelper().Consultar("SP_REPORTE_PRODUCTOS", lista);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", new DBhelper().Consultar("SP_REPORTE_PRODUCTOS", lista)));

            this.reportViewer1.RefreshReport();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
