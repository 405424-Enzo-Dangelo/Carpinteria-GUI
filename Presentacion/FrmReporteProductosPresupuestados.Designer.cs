namespace CarpinteriaGUI.Presentacion
{
    partial class FrmReporteProductosPresupuestados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtp_fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.GrpFiltros = new System.Windows.Forms.GroupBox();
            this.dtp_fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dTProductosPresupuestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSProductosPresupuestados = new CarpinteriaGUI.Presentacion.Reportes.DSProductosPresupuestados();
            this.GrpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTProductosPresupuestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosPresupuestados)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dTProductosPresupuestadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Carpinteria_Bazan.Presentacion.Reportes.RptProductosPresupuestados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(645, 285);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_desde.Location = new System.Drawing.Point(86, 31);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(97, 20);
            this.dtp_fecha_desde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Desde:";
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(535, 30);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(104, 23);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // GrpFiltros
            // 
            this.GrpFiltros.Controls.Add(this.dtp_fecha_hasta);
            this.GrpFiltros.Controls.Add(this.label2);
            this.GrpFiltros.Controls.Add(this.dtp_fecha_desde);
            this.GrpFiltros.Controls.Add(this.btn_generar);
            this.GrpFiltros.Controls.Add(this.label1);
            this.GrpFiltros.Location = new System.Drawing.Point(12, 12);
            this.GrpFiltros.Name = "GrpFiltros";
            this.GrpFiltros.Size = new System.Drawing.Size(645, 69);
            this.GrpFiltros.TabIndex = 4;
            this.GrpFiltros.TabStop = false;
            this.GrpFiltros.Text = "Filtros";
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(322, 31);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(97, 20);
            this.dtp_fecha_hasta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Hasta:";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(582, 392);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dTProductosPresupuestadosBindingSource
            // 
            this.dTProductosPresupuestadosBindingSource.DataMember = "DTProductosPresupuestados";
            this.dTProductosPresupuestadosBindingSource.DataSource = this.dSProductosPresupuestados;
            // 
            // dSProductosPresupuestados
            // 
            this.dSProductosPresupuestados.DataSetName = "DSProductosPresupuestados";
            this.dSProductosPresupuestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmReporteProductosPresupuestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 425);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.GrpFiltros);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteProductosPresupuestados";
            this.Text = "Reporte de Productos Presupuestados";
            this.Load += new System.EventHandler(this.FrmReporteProductosPresupuestados_Load);
            this.GrpFiltros.ResumeLayout(false);
            this.GrpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTProductosPresupuestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosPresupuestados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtp_fecha_desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.GroupBox GrpFiltros;
        private System.Windows.Forms.DateTimePicker dtp_fecha_hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.BindingSource dTProductosPresupuestadosBindingSource;
        private Reportes.DSProductosPresupuestados dSProductosPresupuestados;
    }
}