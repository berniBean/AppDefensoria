namespace INVEDEP
{
    partial class ListaInvedep
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DgListadoInvedep = new System.Windows.Forms.DataGridView();
            this.peticionarioParticularesDGViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Serieindevep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoPeticionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carpeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jurisdiccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcesoPenal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundaInstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpedinteAmparo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupoEtnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lengua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListadoInvedep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peticionarioParticularesDGViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 248);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(899, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DgListadoInvedep, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43094F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.56906F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 248);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // DgListadoInvedep
            // 
            this.DgListadoInvedep.AutoGenerateColumns = false;
            this.DgListadoInvedep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListadoInvedep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serieindevep,
            this.Periodo,
            this.Nombre,
            this.Apaterno,
            this.Amaterno,
            this.sexoPeticionario,
            this.Delito,
            this.Carpeta,
            this.Jurisdiccion,
            this.Juez,
            this.ProcesoPenal,
            this.SegundaInstancia,
            this.Toca,
            this.ExpedinteAmparo,
            this.GrupoEtnico,
            this.Lengua,
            this.Domicilio,
            this.Telefono});
            this.DgListadoInvedep.DataSource = this.peticionarioParticularesDGViewBindingSource;
            this.DgListadoInvedep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgListadoInvedep.Location = new System.Drawing.Point(2, 32);
            this.DgListadoInvedep.Margin = new System.Windows.Forms.Padding(2);
            this.DgListadoInvedep.Name = "DgListadoInvedep";
            this.DgListadoInvedep.RowHeadersWidth = 62;
            this.DgListadoInvedep.RowTemplate.Height = 33;
            this.DgListadoInvedep.Size = new System.Drawing.Size(895, 214);
            this.DgListadoInvedep.TabIndex = 0;
            this.DgListadoInvedep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgListadoInvedep_KeyDown);
            // 
            // peticionarioParticularesDGViewBindingSource
            // 
            this.peticionarioParticularesDGViewBindingSource.DataSource = typeof(Clases.DTO.TableViews.PeticionarioParticularesDGView);
            // 
            // Serieindevep
            // 
            this.Serieindevep.DataPropertyName = "Serieindevep";
            this.Serieindevep.HeaderText = "Serieindevep";
            this.Serieindevep.Name = "Serieindevep";
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apaterno
            // 
            this.Apaterno.DataPropertyName = "Apaterno";
            this.Apaterno.HeaderText = "Apaterno";
            this.Apaterno.Name = "Apaterno";
            // 
            // Amaterno
            // 
            this.Amaterno.DataPropertyName = "Amaterno";
            this.Amaterno.HeaderText = "Amaterno";
            this.Amaterno.Name = "Amaterno";
            // 
            // sexoPeticionario
            // 
            this.sexoPeticionario.DataPropertyName = "sexoPeticionario";
            this.sexoPeticionario.HeaderText = "sexoPeticionario";
            this.sexoPeticionario.Name = "sexoPeticionario";
            // 
            // Delito
            // 
            this.Delito.DataPropertyName = "Delito";
            this.Delito.HeaderText = "Delito";
            this.Delito.Name = "Delito";
            // 
            // Carpeta
            // 
            this.Carpeta.DataPropertyName = "Carpeta";
            this.Carpeta.HeaderText = "Carpeta";
            this.Carpeta.Name = "Carpeta";
            // 
            // Jurisdiccion
            // 
            this.Jurisdiccion.DataPropertyName = "Jurisdiccion";
            this.Jurisdiccion.HeaderText = "Jurisdiccion";
            this.Jurisdiccion.Name = "Jurisdiccion";
            // 
            // Juez
            // 
            this.Juez.DataPropertyName = "Juez";
            this.Juez.HeaderText = "Juez";
            this.Juez.Name = "Juez";
            // 
            // ProcesoPenal
            // 
            this.ProcesoPenal.DataPropertyName = "ProcesoPenal";
            this.ProcesoPenal.HeaderText = "ProcesoPenal";
            this.ProcesoPenal.Name = "ProcesoPenal";
            // 
            // SegundaInstancia
            // 
            this.SegundaInstancia.DataPropertyName = "SegundaInstancia";
            this.SegundaInstancia.HeaderText = "SegundaInstancia";
            this.SegundaInstancia.Name = "SegundaInstancia";
            // 
            // Toca
            // 
            this.Toca.DataPropertyName = "Toca";
            this.Toca.HeaderText = "Toca";
            this.Toca.Name = "Toca";
            // 
            // ExpedinteAmparo
            // 
            this.ExpedinteAmparo.DataPropertyName = "ExpedinteAmparo";
            this.ExpedinteAmparo.HeaderText = "ExpedinteAmparo";
            this.ExpedinteAmparo.Name = "ExpedinteAmparo";
            // 
            // GrupoEtnico
            // 
            this.GrupoEtnico.DataPropertyName = "GrupoEtnico";
            this.GrupoEtnico.HeaderText = "GrupoEtnico";
            this.GrupoEtnico.Name = "GrupoEtnico";
            // 
            // Lengua
            // 
            this.Lengua.DataPropertyName = "Lengua";
            this.Lengua.HeaderText = "Lengua";
            this.Lengua.Name = "Lengua";
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // ListaInvedep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 270);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListaInvedep";
            this.Text = "ListaInvedep";
            this.Load += new System.EventHandler(this.ListaInvedep_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgListadoInvedep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peticionarioParticularesDGViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DgListadoInvedep;
        private BindingSource peticionarioParticularesDGViewBindingSource;
        private DataGridViewTextBoxColumn Serieindevep;
        private DataGridViewTextBoxColumn Periodo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apaterno;
        private DataGridViewTextBoxColumn Amaterno;
        private DataGridViewTextBoxColumn sexoPeticionario;
        private DataGridViewTextBoxColumn Delito;
        private DataGridViewTextBoxColumn Carpeta;
        private DataGridViewTextBoxColumn Jurisdiccion;
        private DataGridViewTextBoxColumn Juez;
        private DataGridViewTextBoxColumn ProcesoPenal;
        private DataGridViewTextBoxColumn SegundaInstancia;
        private DataGridViewTextBoxColumn Toca;
        private DataGridViewTextBoxColumn ExpedinteAmparo;
        private DataGridViewTextBoxColumn GrupoEtnico;
        private DataGridViewTextBoxColumn Lengua;
        private DataGridViewTextBoxColumn Domicilio;
        private DataGridViewTextBoxColumn Telefono;
    }
}