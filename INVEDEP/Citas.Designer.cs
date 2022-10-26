namespace INVEDEP
{
    partial class Citas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DtFechaAudiencia = new System.Windows.Forms.DateTimePicker();
            this.TbSala = new System.Windows.Forms.TextBox();
            this.TbTipoAudiencia = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblTipoAudiencia = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.lblResumen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DgViewCitas = new System.Windows.Forms.DataGridView();
            this.ResultadoAudiencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citasDGViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasDGViewBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registo de cita";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.57087F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.42913F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.37688F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.62313F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1016, 467);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.40938F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.59062F));
            this.tableLayoutPanel2.Controls.Add(this.DtFechaAudiencia, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TbSala, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TbTipoAudiencia, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblFecha, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSala, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTipoAudiencia, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtResultado, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblResumen, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(466, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(547, 331);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // DtFechaAudiencia
            // 
            this.DtFechaAudiencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtFechaAudiencia.Location = new System.Drawing.Point(180, 3);
            this.DtFechaAudiencia.Name = "DtFechaAudiencia";
            this.DtFechaAudiencia.Size = new System.Drawing.Size(364, 23);
            this.DtFechaAudiencia.TabIndex = 0;
            // 
            // TbSala
            // 
            this.TbSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbSala.Location = new System.Drawing.Point(180, 36);
            this.TbSala.Name = "TbSala";
            this.TbSala.Size = new System.Drawing.Size(364, 23);
            this.TbSala.TabIndex = 1;
            // 
            // TbTipoAudiencia
            // 
            this.TbTipoAudiencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbTipoAudiencia.Location = new System.Drawing.Point(180, 66);
            this.TbTipoAudiencia.Name = "TbTipoAudiencia";
            this.TbTipoAudiencia.Size = new System.Drawing.Size(364, 23);
            this.TbTipoAudiencia.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFecha.Location = new System.Drawing.Point(133, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 33);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSala.Location = new System.Drawing.Point(143, 33);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 30);
            this.lblSala.TabIndex = 4;
            this.lblSala.Text = "Sala:";
            // 
            // lblTipoAudiencia
            // 
            this.lblTipoAudiencia.AutoSize = true;
            this.lblTipoAudiencia.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTipoAudiencia.Location = new System.Drawing.Point(87, 63);
            this.lblTipoAudiencia.Name = "lblTipoAudiencia";
            this.lblTipoAudiencia.Size = new System.Drawing.Size(87, 31);
            this.lblTipoAudiencia.TabIndex = 5;
            this.lblTipoAudiencia.Text = "Tipo audiencia:";
            // 
            // txtResultado
            // 
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultado.Location = new System.Drawing.Point(180, 105);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(364, 223);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.Text = "";
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblResumen.Location = new System.Drawing.Point(61, 102);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(113, 229);
            this.lblResumen.TabIndex = 7;
            this.lblResumen.Text = "Resumen audiencia:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 331);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Peticionario";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 19);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgViewCitas);
            this.splitContainer1.Size = new System.Drawing.Size(451, 309);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(451, 23);
            this.textBox3.TabIndex = 0;
            // 
            // DgViewCitas
            // 
            this.DgViewCitas.AllowUserToAddRows = false;
            this.DgViewCitas.AutoGenerateColumns = false;
            this.DgViewCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResultadoAudiencia,
            this.apaternoDataGridViewTextBoxColumn,
            this.amaternoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn});
            this.DgViewCitas.DataSource = this.citasDGViewBindingSource;
            this.DgViewCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgViewCitas.Location = new System.Drawing.Point(0, 0);
            this.DgViewCitas.Name = "DgViewCitas";
            this.DgViewCitas.RowTemplate.Height = 25;
            this.DgViewCitas.Size = new System.Drawing.Size(451, 269);
            this.DgViewCitas.TabIndex = 0;
            this.DgViewCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ResultadoAudiencia
            // 
            this.ResultadoAudiencia.DataPropertyName = "ResultadoAudiencia";
            this.ResultadoAudiencia.HeaderText = "ResultadoAudiencia";
            this.ResultadoAudiencia.Name = "ResultadoAudiencia";
            this.ResultadoAudiencia.Visible = false;
            // 
            // apaternoDataGridViewTextBoxColumn
            // 
            this.apaternoDataGridViewTextBoxColumn.DataPropertyName = "Apaterno";
            this.apaternoDataGridViewTextBoxColumn.HeaderText = "Apaterno";
            this.apaternoDataGridViewTextBoxColumn.Name = "apaternoDataGridViewTextBoxColumn";
            // 
            // amaternoDataGridViewTextBoxColumn
            // 
            this.amaternoDataGridViewTextBoxColumn.DataPropertyName = "Amaterno";
            this.amaternoDataGridViewTextBoxColumn.HeaderText = "Amaterno";
            this.amaternoDataGridViewTextBoxColumn.Name = "amaternoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            // 
            // citasDGViewBindingSource
            // 
            this.citasDGViewBindingSource.DataSource = typeof(Clases.DTO.TableViews.CitasDGView);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 124);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro citas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(451, 102);
            this.dataGridView2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.48701F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.51299F));
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(466, 340);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.06452F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.93549F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 124);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.Location = new System.Drawing.Point(415, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 35);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 489);
            this.Controls.Add(this.groupBox1);
            this.Name = "Citas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Citas_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasDGViewBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private DateTimePicker DtFechaAudiencia;
        private TextBox TbSala;
        private TextBox TbTipoAudiencia;
        private Label lblFecha;
        private Label lblSala;
        private Label lblTipoAudiencia;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox2;
        private DataGridView DgViewCitas;
        private GroupBox groupBox3;
        private DataGridView dataGridView2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnGuardar;
        private SplitContainer splitContainer1;
        private TextBox textBox3;
        private RichTextBox txtResultado;
        private Label lblResumen;
        private DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private BindingSource citasDGViewBindingSource;
        private DataGridViewTextBoxColumn idcitasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reportesIdreportesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn archivoIdarchivoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaAudienciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn audienciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ResultadoAudiencia;
        private DataGridViewTextBoxColumn apaternoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amaternoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn archivosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn citaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn peticionariosDataGridViewTextBoxColumn;
    }
}