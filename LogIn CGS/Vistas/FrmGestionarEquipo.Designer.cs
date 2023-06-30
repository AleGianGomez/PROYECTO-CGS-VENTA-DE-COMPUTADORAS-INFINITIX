namespace Proyecto_CGS
{
    partial class FrmGestionarEquipo
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
            System.Windows.Forms.Label idEquipoLabel;
            System.Windows.Forms.Label marcaEquipoLabel;
            System.Windows.Forms.Label modeloEquipoLabel;
            System.Windows.Forms.Label precioEquipoLabel;
            System.Windows.Forms.Label tipoEquipoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarEquipo));
            this.equipoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxEquipo = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.idEquipoTextBox = new System.Windows.Forms.TextBox();
            this.marcaEquipoTextBox = new System.Windows.Forms.TextBox();
            this.modeloEquipoTextBox = new System.Windows.Forms.TextBox();
            this.precioEquipoTextBox = new System.Windows.Forms.TextBox();
            this.tipoEquipoTextBox = new System.Windows.Forms.TextBox();
            this.statusStripUsuario = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idEquipoLabel = new System.Windows.Forms.Label();
            marcaEquipoLabel = new System.Windows.Forms.Label();
            modeloEquipoLabel = new System.Windows.Forms.Label();
            precioEquipoLabel = new System.Windows.Forms.Label();
            tipoEquipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipoDataGridView)).BeginInit();
            this.groupBoxEquipo.SuspendLayout();
            this.statusStripUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idEquipoLabel
            // 
            idEquipoLabel.AutoSize = true;
            idEquipoLabel.ForeColor = System.Drawing.Color.White;
            idEquipoLabel.Location = new System.Drawing.Point(16, 139);
            idEquipoLabel.Name = "idEquipoLabel";
            idEquipoLabel.Size = new System.Drawing.Size(66, 16);
            idEquipoLabel.TabIndex = 0;
            idEquipoLabel.Text = "Id Equipo:";
            // 
            // marcaEquipoLabel
            // 
            marcaEquipoLabel.AutoSize = true;
            marcaEquipoLabel.ForeColor = System.Drawing.Color.White;
            marcaEquipoLabel.Location = new System.Drawing.Point(16, 20);
            marcaEquipoLabel.Name = "marcaEquipoLabel";
            marcaEquipoLabel.Size = new System.Drawing.Size(89, 16);
            marcaEquipoLabel.TabIndex = 2;
            marcaEquipoLabel.Text = "Marca Equipo:";
            // 
            // modeloEquipoLabel
            // 
            modeloEquipoLabel.AutoSize = true;
            modeloEquipoLabel.ForeColor = System.Drawing.Color.White;
            modeloEquipoLabel.Location = new System.Drawing.Point(13, 58);
            modeloEquipoLabel.Name = "modeloEquipoLabel";
            modeloEquipoLabel.Size = new System.Drawing.Size(92, 16);
            modeloEquipoLabel.TabIndex = 4;
            modeloEquipoLabel.Text = "Modelo Equipo:";
            // 
            // precioEquipoLabel
            // 
            precioEquipoLabel.AutoSize = true;
            precioEquipoLabel.ForeColor = System.Drawing.Color.White;
            precioEquipoLabel.Location = new System.Drawing.Point(13, 175);
            precioEquipoLabel.Name = "precioEquipoLabel";
            precioEquipoLabel.Size = new System.Drawing.Size(86, 16);
            precioEquipoLabel.TabIndex = 6;
            precioEquipoLabel.Text = "Precio Equipo:";
            // 
            // tipoEquipoLabel
            // 
            tipoEquipoLabel.AutoSize = true;
            tipoEquipoLabel.ForeColor = System.Drawing.Color.White;
            tipoEquipoLabel.Location = new System.Drawing.Point(16, 98);
            tipoEquipoLabel.Name = "tipoEquipoLabel";
            tipoEquipoLabel.Size = new System.Drawing.Size(75, 16);
            tipoEquipoLabel.TabIndex = 8;
            tipoEquipoLabel.Text = "Tipo Equipo:";
            // 
            // equipoDataGridView
            // 
            this.equipoDataGridView.AllowUserToAddRows = false;
            this.equipoDataGridView.AllowUserToDeleteRows = false;
            this.equipoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipoDataGridView.AutoGenerateColumns = false;
            this.equipoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.equipoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.equipoDataGridView.DataSource = this.equipoBindingSource;
            this.equipoDataGridView.Location = new System.Drawing.Point(326, 116);
            this.equipoDataGridView.Name = "equipoDataGridView";
            this.equipoDataGridView.ReadOnly = true;
            this.equipoDataGridView.Size = new System.Drawing.Size(575, 337);
            this.equipoDataGridView.TabIndex = 1;
            // 
            // groupBoxEquipo
            // 
            this.groupBoxEquipo.BackColor = System.Drawing.Color.Black;
            this.groupBoxEquipo.Controls.Add(this.btnCancelar);
            this.groupBoxEquipo.Controls.Add(this.btnAceptar);
            this.groupBoxEquipo.Controls.Add(this.idEquipoTextBox);
            this.groupBoxEquipo.Controls.Add(marcaEquipoLabel);
            this.groupBoxEquipo.Controls.Add(idEquipoLabel);
            this.groupBoxEquipo.Controls.Add(this.marcaEquipoTextBox);
            this.groupBoxEquipo.Controls.Add(modeloEquipoLabel);
            this.groupBoxEquipo.Controls.Add(this.modeloEquipoTextBox);
            this.groupBoxEquipo.Controls.Add(precioEquipoLabel);
            this.groupBoxEquipo.Controls.Add(this.precioEquipoTextBox);
            this.groupBoxEquipo.Controls.Add(tipoEquipoLabel);
            this.groupBoxEquipo.Controls.Add(this.tipoEquipoTextBox);
            this.groupBoxEquipo.Enabled = false;
            this.groupBoxEquipo.Location = new System.Drawing.Point(12, 72);
            this.groupBoxEquipo.Name = "groupBoxEquipo";
            this.groupBoxEquipo.Size = new System.Drawing.Size(238, 287);
            this.groupBoxEquipo.TabIndex = 2;
            this.groupBoxEquipo.TabStop = false;
            this.groupBoxEquipo.Text = "Nuevo Equipo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(136, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(16, 228);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 36);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // idEquipoTextBox
            // 
            this.idEquipoTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.idEquipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "IdEquipo", true));
            this.idEquipoTextBox.Location = new System.Drawing.Point(111, 131);
            this.idEquipoTextBox.Name = "idEquipoTextBox";
            this.idEquipoTextBox.Size = new System.Drawing.Size(100, 24);
            this.idEquipoTextBox.TabIndex = 1;
            // 
            // marcaEquipoTextBox
            // 
            this.marcaEquipoTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.marcaEquipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "MarcaEquipo", true));
            this.marcaEquipoTextBox.Location = new System.Drawing.Point(111, 17);
            this.marcaEquipoTextBox.Name = "marcaEquipoTextBox";
            this.marcaEquipoTextBox.Size = new System.Drawing.Size(100, 24);
            this.marcaEquipoTextBox.TabIndex = 3;
            // 
            // modeloEquipoTextBox
            // 
            this.modeloEquipoTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.modeloEquipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "ModeloEquipo", true));
            this.modeloEquipoTextBox.Location = new System.Drawing.Point(111, 55);
            this.modeloEquipoTextBox.Name = "modeloEquipoTextBox";
            this.modeloEquipoTextBox.Size = new System.Drawing.Size(100, 24);
            this.modeloEquipoTextBox.TabIndex = 5;
            // 
            // precioEquipoTextBox
            // 
            this.precioEquipoTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.precioEquipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "PrecioEquipo", true));
            this.precioEquipoTextBox.Location = new System.Drawing.Point(111, 167);
            this.precioEquipoTextBox.Name = "precioEquipoTextBox";
            this.precioEquipoTextBox.Size = new System.Drawing.Size(100, 24);
            this.precioEquipoTextBox.TabIndex = 7;
            // 
            // tipoEquipoTextBox
            // 
            this.tipoEquipoTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.tipoEquipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "TipoEquipo", true));
            this.tipoEquipoTextBox.Location = new System.Drawing.Point(111, 90);
            this.tipoEquipoTextBox.Name = "tipoEquipoTextBox";
            this.tipoEquipoTextBox.Size = new System.Drawing.Size(100, 24);
            this.tipoEquipoTextBox.TabIndex = 9;
            // 
            // statusStripUsuario
            // 
            this.statusStripUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStripUsuario.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStripUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStripUsuario.Location = new System.Drawing.Point(9, 523);
            this.statusStripUsuario.Name = "statusStripUsuario";
            this.statusStripUsuario.Size = new System.Drawing.Size(109, 22);
            this.statusStripUsuario.TabIndex = 3;
            this.statusStripUsuario.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(42, 17);
            this.lblUsuario.Text = "XXXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por : Marca | Modelo";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.Location = new System.Drawing.Point(243, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(406, 24);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(660, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(754, 22);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.BackColor = System.Drawing.Color.Black;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Location = new System.Drawing.Point(846, 22);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 8;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(81, 417);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 36);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(612, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "VENTA DE COMPUTADOR";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(657, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "INFINITX";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(801, 467);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(Proyecto_CGS.Models.Equipo);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEquipo";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDEquipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MarcaEquipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ModeloEquipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TipoEquipo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrecioEquipo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FrmGestionarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStripUsuario);
            this.Controls.Add(this.groupBoxEquipo);
            this.Controls.Add(this.equipoDataGridView);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionarEquipo";
            this.Text = "FrmGestionarEquipo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGestionarEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipoDataGridView)).EndInit();
            this.groupBoxEquipo.ResumeLayout(false);
            this.groupBoxEquipo.PerformLayout();
            this.statusStripUsuario.ResumeLayout(false);
            this.statusStripUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.DataGridView equipoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBoxEquipo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox idEquipoTextBox;
        private System.Windows.Forms.TextBox marcaEquipoTextBox;
        private System.Windows.Forms.TextBox modeloEquipoTextBox;
        private System.Windows.Forms.TextBox precioEquipoTextBox;
        private System.Windows.Forms.TextBox tipoEquipoTextBox;
        private System.Windows.Forms.StatusStrip statusStripUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}