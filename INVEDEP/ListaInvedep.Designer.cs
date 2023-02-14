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
            this.peticionarioParticularesDGViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListadoInvedep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peticionarioParticularesDGViewBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DgListadoInvedep, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.43094F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.56906F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1284, 428);
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
            this.DgListadoInvedep.Location = new System.Drawing.Point(3, 56);
            this.DgListadoInvedep.Name = "DgListadoInvedep";
            this.DgListadoInvedep.RowHeadersWidth = 62;
            this.DgListadoInvedep.RowTemplate.Height = 33;
            this.DgListadoInvedep.Size = new System.Drawing.Size(1278, 369);
            this.DgListadoInvedep.TabIndex = 0;
            this.DgListadoInvedep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgListadoInvedep_KeyDown);
            // 
            // Serieindevep
            // 
            this.Serieindevep.DataPropertyName = "Serieindevep";
            this.Serieindevep.HeaderText = "Serieindevep";
            this.Serieindevep.MinimumWidth = 8;
            this.Serieindevep.Name = "Serieindevep";
            this.Serieindevep.Width = 150;
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.MinimumWidth = 8;
            this.Periodo.Name = "Periodo";
            this.Periodo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Apaterno
            // 
            this.Apaterno.DataPropertyName = "Apaterno";
            this.Apaterno.HeaderText = "Apaterno";
            this.Apaterno.MinimumWidth = 8;
            this.Apaterno.Name = "Apaterno";
            this.Apaterno.Width = 150;
            // 
            // Amaterno
            // 
            this.Amaterno.DataPropertyName = "Amaterno";
            this.Amaterno.HeaderText = "Amaterno";
            this.Amaterno.MinimumWidth = 8;
            this.Amaterno.Name = "Amaterno";
            this.Amaterno.Width = 150;
            // 
            // sexoPeticionario
            // 
            this.sexoPeticionario.DataPropertyName = "sexoPeticionario";
            this.sexoPeticionario.HeaderText = "sexoPeticionario";
            this.sexoPeticionario.MinimumWidth = 8;
            this.sexoPeticionario.Name = "sexoPeticionario";
            this.sexoPeticionario.Width = 150;
            // 
            // Delito
            // 
            this.Delito.DataPropertyName = "Delito";
            this.Delito.HeaderText = "Delito";
            this.Delito.MinimumWidth = 8;
            this.Delito.Name = "Delito";
            this.Delito.Width = 150;
            // 
            // Carpeta
            // 
            this.Carpeta.DataPropertyName = "Carpeta";
            this.Carpeta.HeaderText = "Carpeta";
            this.Carpeta.MinimumWidth = 8;
            this.Carpeta.Name = "Carpeta";
            this.Carpeta.Width = 150;
            // 
            // Jurisdiccion
            // 
            this.Jurisdiccion.DataPropertyName = "Jurisdiccion";
            this.Jurisdiccion.HeaderText = "Jurisdiccion";
            this.Jurisdiccion.MinimumWidth = 8;
            this.Jurisdiccion.Name = "Jurisdiccion";
            this.Jurisdiccion.Width = 150;
            // 
            // Juez
            // 
            this.Juez.DataPropertyName = "Juez";
            this.Juez.HeaderText = "Juez";
            this.Juez.MinimumWidth = 8;
            this.Juez.Name = "Juez";
            this.Juez.Width = 150;
            // 
            // ProcesoPenal
            // 
            this.ProcesoPenal.DataPropertyName = "ProcesoPenal";
            this.ProcesoPenal.HeaderText = "ProcesoPenal";
            this.ProcesoPenal.MinimumWidth = 8;
            this.ProcesoPenal.Name = "ProcesoPenal";
            this.ProcesoPenal.Width = 150;
            // 
            // SegundaInstancia
            // 
            this.SegundaInstancia.DataPropertyName = "SegundaInstancia";
            this.SegundaInstancia.HeaderText = "SegundaInstancia";
            this.SegundaInstancia.MinimumWidth = 8;
            this.SegundaInstancia.Name = "SegundaInstancia";
            this.SegundaInstancia.Width = 150;
            // 
            // Toca
            // 
            this.Toca.DataPropertyName = "Toca";
            this.Toca.HeaderText = "Toca";
            this.Toca.MinimumWidth = 8;
            this.Toca.Name = "Toca";
            this.Toca.Width = 150;
            // 
            // ExpedinteAmparo
            // 
            this.ExpedinteAmparo.DataPropertyName = "ExpedinteAmparo";
            this.ExpedinteAmparo.HeaderText = "ExpedinteAmparo";
            this.ExpedinteAmparo.MinimumWidth = 8;
            this.ExpedinteAmparo.Name = "ExpedinteAmparo";
            this.ExpedinteAmparo.Width = 150;
            // 
            // GrupoEtnico
            // 
            this.GrupoEtnico.DataPropertyName = "GrupoEtnico";
            this.GrupoEtnico.HeaderText = "GrupoEtnico";
            this.GrupoEtnico.MinimumWidth = 8;
            this.GrupoEtnico.Name = "GrupoEtnico";
            this.GrupoEtnico.Width = 150;
            // 
            // Lengua
            // 
            this.Lengua.DataPropertyName = "Lengua";
            this.Lengua.HeaderText = "Lengua";
            this.Lengua.MinimumWidth = 8;
            this.Lengua.Name = "Lengua";
            this.Lengua.Width = 150;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 8;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 8;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 150;
            // 
            // peticionarioParticularesDGViewBindingSource
            // 
            this.peticionarioParticularesDGViewBindingSource.DataSource = typeof(Clases.DTO.TableViews.PeticionarioParticularesDGView);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // ListaInvedep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaInvedep";
            this.Text = "ListaInvedep";
            this.Load += new System.EventHandler(this.ListaInvedep_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListadoInvedep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peticionarioParticularesDGViewBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem guardarToolStripMenuItem;
    }
}