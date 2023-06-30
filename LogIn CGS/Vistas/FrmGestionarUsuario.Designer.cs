namespace Proyecto_CGS.Vistas
{
    partial class FrmGestionarUsuario
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
            System.Windows.Forms.Label estadoUsuarioLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label nombreCompletoLabel;
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label passwordUsuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarUsuario));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_Usuario = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.estadoUsuarioCheckBox = new System.Windows.Forms.CheckBox();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.passwordUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.statusStripuusuario = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            estadoUsuarioLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            passwordUsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.groupBox_Usuario.SuspendLayout();
            this.statusStripuusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // estadoUsuarioLabel
            // 
            estadoUsuarioLabel.AutoSize = true;
            estadoUsuarioLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoUsuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            estadoUsuarioLabel.Location = new System.Drawing.Point(20, 300);
            estadoUsuarioLabel.Name = "estadoUsuarioLabel";
            estadoUsuarioLabel.Size = new System.Drawing.Size(133, 23);
            estadoUsuarioLabel.TabIndex = 0;
            estadoUsuarioLabel.Text = "Estado Usuario:";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idUsuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            idUsuarioLabel.Location = new System.Drawing.Point(20, 32);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(99, 23);
            idUsuarioLabel.TabIndex = 2;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreCompletoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nombreCompletoLabel.Location = new System.Drawing.Point(13, 163);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(152, 23);
            nombreCompletoLabel.TabIndex = 4;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreUsuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nombreUsuarioLabel.Location = new System.Drawing.Point(13, 79);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(141, 23);
            nombreUsuarioLabel.TabIndex = 6;
            nombreUsuarioLabel.Text = "Nombre Usuario:";
            // 
            // passwordUsuarioLabel
            // 
            passwordUsuarioLabel.AutoSize = true;
            passwordUsuarioLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordUsuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            passwordUsuarioLabel.Location = new System.Drawing.Point(14, 124);
            passwordUsuarioLabel.Name = "passwordUsuarioLabel";
            passwordUsuarioLabel.Size = new System.Drawing.Size(151, 23);
            passwordUsuarioLabel.TabIndex = 8;
            passwordUsuarioLabel.Text = "Password Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(715, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "\"INFINITIX\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(645, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "\"VENTA DE COMPUTADORAS\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(328, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Buscar por : Nombre Usuario | Nombre Completo";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.BackColor = System.Drawing.Color.DarkGray;
            this.txt_buscar.ForeColor = System.Drawing.Color.Black;
            this.txt_buscar.Location = new System.Drawing.Point(329, 85);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(466, 20);
            this.txt_buscar.TabIndex = 28;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(912, 102);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 34);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.BackColor = System.Drawing.Color.Cyan;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(912, 59);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(135, 37);
            this.btn_editar.TabIndex = 26;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevo.BackColor = System.Drawing.Color.Lime;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nuevo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(909, 12);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(138, 43);
            this.btn_nuevo.TabIndex = 25;
            this.btn_nuevo.Text = "Nuevo Usuario";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(816, 71);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(88, 34);
            this.btn_buscar.TabIndex = 24;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(332, 155);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.Size = new System.Drawing.Size(713, 312);
            this.usuarioDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreUsuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreUsuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PasswordUsuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "PasswordUsuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreCompleto";
            this.dataGridViewTextBoxColumn4.HeaderText = "NombreCompleto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "EstadoUsuario";
            this.dataGridViewCheckBoxColumn1.HeaderText = "EstadoUsuario";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Proyecto_CGS.Models.Usuario);
            // 
            // groupBox_Usuario
            // 
            this.groupBox_Usuario.Controls.Add(this.btn_guardar);
            this.groupBox_Usuario.Controls.Add(this.btn_cancelar);
            this.groupBox_Usuario.Controls.Add(estadoUsuarioLabel);
            this.groupBox_Usuario.Controls.Add(this.estadoUsuarioCheckBox);
            this.groupBox_Usuario.Controls.Add(idUsuarioLabel);
            this.groupBox_Usuario.Controls.Add(this.idUsuarioTextBox);
            this.groupBox_Usuario.Controls.Add(nombreCompletoLabel);
            this.groupBox_Usuario.Controls.Add(this.nombreCompletoTextBox);
            this.groupBox_Usuario.Controls.Add(nombreUsuarioLabel);
            this.groupBox_Usuario.Controls.Add(this.nombreUsuarioTextBox);
            this.groupBox_Usuario.Controls.Add(passwordUsuarioLabel);
            this.groupBox_Usuario.Controls.Add(this.passwordUsuarioTextBox);
            this.groupBox_Usuario.Enabled = false;
            this.groupBox_Usuario.Location = new System.Drawing.Point(12, 102);
            this.groupBox_Usuario.Name = "groupBox_Usuario";
            this.groupBox_Usuario.Size = new System.Drawing.Size(290, 412);
            this.groupBox_Usuario.TabIndex = 33;
            this.groupBox_Usuario.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Lime;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_guardar.Location = new System.Drawing.Point(24, 347);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(111, 46);
            this.btn_guardar.TabIndex = 34;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancelar.Location = new System.Drawing.Point(157, 347);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(113, 46);
            this.btn_cancelar.TabIndex = 35;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // estadoUsuarioCheckBox
            // 
            this.estadoUsuarioCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "EstadoUsuario", true));
            this.estadoUsuarioCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoUsuarioCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.estadoUsuarioCheckBox.Location = new System.Drawing.Point(178, 300);
            this.estadoUsuarioCheckBox.Name = "estadoUsuarioCheckBox";
            this.estadoUsuarioCheckBox.Size = new System.Drawing.Size(104, 24);
            this.estadoUsuarioCheckBox.TabIndex = 1;
            this.estadoUsuarioCheckBox.Text = "Activo";
            this.estadoUsuarioCheckBox.UseVisualStyleBackColor = true;
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsuarioTextBox.ForeColor = System.Drawing.Color.Black;
            this.idUsuarioTextBox.Location = new System.Drawing.Point(134, 29);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(122, 30);
            this.idUsuarioTextBox.TabIndex = 3;
            // 
            // nombreCompletoTextBox
            // 
            this.nombreCompletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NombreCompleto", true));
            this.nombreCompletoTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCompletoTextBox.ForeColor = System.Drawing.Color.Black;
            this.nombreCompletoTextBox.Location = new System.Drawing.Point(65, 189);
            this.nombreCompletoTextBox.Multiline = true;
            this.nombreCompletoTextBox.Name = "nombreCompletoTextBox";
            this.nombreCompletoTextBox.Size = new System.Drawing.Size(194, 90);
            this.nombreCompletoTextBox.TabIndex = 5;
            // 
            // nombreUsuarioTextBox
            // 
            this.nombreUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NombreUsuario", true));
            this.nombreUsuarioTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuarioTextBox.ForeColor = System.Drawing.Color.Black;
            this.nombreUsuarioTextBox.Location = new System.Drawing.Point(168, 79);
            this.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            this.nombreUsuarioTextBox.Size = new System.Drawing.Size(88, 30);
            this.nombreUsuarioTextBox.TabIndex = 7;
            // 
            // passwordUsuarioTextBox
            // 
            this.passwordUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "PasswordUsuario", true));
            this.passwordUsuarioTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordUsuarioTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordUsuarioTextBox.Location = new System.Drawing.Point(168, 124);
            this.passwordUsuarioTextBox.Name = "passwordUsuarioTextBox";
            this.passwordUsuarioTextBox.Size = new System.Drawing.Size(88, 28);
            this.passwordUsuarioTextBox.TabIndex = 9;
            // 
            // statusStripuusuario
            // 
            this.statusStripuusuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStripuusuario.BackColor = System.Drawing.Color.DarkGray;
            this.statusStripuusuario.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStripuusuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStripuusuario.Location = new System.Drawing.Point(26, 571);
            this.statusStripuusuario.Name = "statusStripuusuario";
            this.statusStripuusuario.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripuusuario.Size = new System.Drawing.Size(108, 22);
            this.statusStripuusuario.TabIndex = 46;
            this.statusStripuusuario.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(42, 17);
            this.lblUsuario.Text = "XXXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(115, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 49);
            this.label3.TabIndex = 47;
            this.label3.Text = "USUARIOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Proyecto_CGS.Properties.Resources._1687840974853;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1057, 602);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // FrmGestionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1057, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStripuusuario);
            this.Controls.Add(this.groupBox_Usuario);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "FrmGestionarUsuario";
            this.Text = "FrmGestionarUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGestionarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.groupBox_Usuario.ResumeLayout(false);
            this.groupBox_Usuario.PerformLayout();
            this.statusStripuusuario.ResumeLayout(false);
            this.statusStripuusuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox_Usuario;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.CheckBox estadoUsuarioCheckBox;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox nombreCompletoTextBox;
        private System.Windows.Forms.TextBox nombreUsuarioTextBox;
        private System.Windows.Forms.TextBox passwordUsuarioTextBox;
        public System.Windows.Forms.StatusStrip statusStripuusuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}