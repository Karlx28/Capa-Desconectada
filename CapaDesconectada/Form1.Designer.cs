﻿namespace CapaDesconectada
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizarNT = new System.Windows.Forms.Button();
            this.btnBuscarNt = new System.Windows.Forms.Button();
            this.tbBusquedaNt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerNoTipado = new System.Windows.Forms.Button();
            this.gridNoTipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInsertarT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarTipado = new System.Windows.Forms.Button();
            this.tBoxBuscarTipado = new System.Windows.Forms.TextBox();
            this.btnObtenerTipado = new System.Windows.Forms.Button();
            this.gridTipado = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxCompanyName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxContactName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxContactTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxAddres = new System.Windows.Forms.TextBox();
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            this.btnActualizarTipado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizarNT);
            this.groupBox1.Controls.Add(this.btnBuscarNt);
            this.groupBox1.Controls.Add(this.tbBusquedaNt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnObtenerNoTipado);
            this.groupBox1.Controls.Add(this.gridNoTipado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 639);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet No Tipado";
            // 
            // btnActualizarNT
            // 
            this.btnActualizarNT.Location = new System.Drawing.Point(269, 488);
            this.btnActualizarNT.Name = "btnActualizarNT";
            this.btnActualizarNT.Size = new System.Drawing.Size(193, 37);
            this.btnActualizarNT.TabIndex = 5;
            this.btnActualizarNT.Text = "Actualizar";
            this.btnActualizarNT.UseVisualStyleBackColor = true;
            this.btnActualizarNT.Click += new System.EventHandler(this.btnActualizarNT_Click);
            // 
            // btnBuscarNt
            // 
            this.btnBuscarNt.Location = new System.Drawing.Point(19, 488);
            this.btnBuscarNt.Name = "btnBuscarNt";
            this.btnBuscarNt.Size = new System.Drawing.Size(193, 37);
            this.btnBuscarNt.TabIndex = 4;
            this.btnBuscarNt.Text = "Enviar";
            this.btnBuscarNt.UseVisualStyleBackColor = true;
            this.btnBuscarNt.Click += new System.EventHandler(this.btnBuscarNt_Click);
            // 
            // tbBusquedaNt
            // 
            this.tbBusquedaNt.Location = new System.Drawing.Point(192, 446);
            this.tbBusquedaNt.Name = "tbBusquedaNt";
            this.tbBusquedaNt.Size = new System.Drawing.Size(125, 22);
            this.tbBusquedaNt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CustomerID";
            // 
            // btnObtenerNoTipado
            // 
            this.btnObtenerNoTipado.Location = new System.Drawing.Point(91, 367);
            this.btnObtenerNoTipado.Name = "btnObtenerNoTipado";
            this.btnObtenerNoTipado.Size = new System.Drawing.Size(267, 44);
            this.btnObtenerNoTipado.TabIndex = 1;
            this.btnObtenerNoTipado.Text = "Obtener Datos no Tipado";
            this.btnObtenerNoTipado.UseVisualStyleBackColor = true;
            this.btnObtenerNoTipado.Click += new System.EventHandler(this.btnObtenerNoTipado_Click);
            // 
            // gridNoTipado
            // 
            this.gridNoTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNoTipado.Location = new System.Drawing.Point(19, 45);
            this.gridNoTipado.Name = "gridNoTipado";
            this.gridNoTipado.RowHeadersWidth = 51;
            this.gridNoTipado.RowTemplate.Height = 24;
            this.gridNoTipado.Size = new System.Drawing.Size(443, 286);
            this.gridNoTipado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizarTipado);
            this.groupBox2.Controls.Add(this.btnInsertarT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnBuscarTipado);
            this.groupBox2.Controls.Add(this.tBoxBuscarTipado);
            this.groupBox2.Controls.Add(this.btnObtenerTipado);
            this.groupBox2.Controls.Add(this.gridTipado);
            this.groupBox2.Location = new System.Drawing.Point(530, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 639);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet Tipado";
            // 
            // btnInsertarT
            // 
            this.btnInsertarT.Location = new System.Drawing.Point(253, 488);
            this.btnInsertarT.Name = "btnInsertarT";
            this.btnInsertarT.Size = new System.Drawing.Size(197, 37);
            this.btnInsertarT.TabIndex = 18;
            this.btnInsertarT.Text = "Insertar Cliente";
            this.btnInsertarT.UseVisualStyleBackColor = true;
            this.btnInsertarT.Click += new System.EventHandler(this.btnInsertarT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "CustomerID";
            // 
            // btnBuscarTipado
            // 
            this.btnBuscarTipado.Location = new System.Drawing.Point(24, 488);
            this.btnBuscarTipado.Name = "btnBuscarTipado";
            this.btnBuscarTipado.Size = new System.Drawing.Size(197, 37);
            this.btnBuscarTipado.TabIndex = 7;
            this.btnBuscarTipado.Text = "Enviar";
            this.btnBuscarTipado.UseVisualStyleBackColor = true;
            this.btnBuscarTipado.Click += new System.EventHandler(this.btnBuscarTipado_Click);
            // 
            // tBoxBuscarTipado
            // 
            this.tBoxBuscarTipado.Location = new System.Drawing.Point(227, 446);
            this.tBoxBuscarTipado.Name = "tBoxBuscarTipado";
            this.tBoxBuscarTipado.Size = new System.Drawing.Size(125, 22);
            this.tBoxBuscarTipado.TabIndex = 6;
            // 
            // btnObtenerTipado
            // 
            this.btnObtenerTipado.Location = new System.Drawing.Point(130, 367);
            this.btnObtenerTipado.Name = "btnObtenerTipado";
            this.btnObtenerTipado.Size = new System.Drawing.Size(267, 44);
            this.btnObtenerTipado.TabIndex = 2;
            this.btnObtenerTipado.Text = "Obtener Datos Tipados";
            this.btnObtenerTipado.UseVisualStyleBackColor = true;
            this.btnObtenerTipado.Click += new System.EventHandler(this.btnObtenerTipado_Click);
            // 
            // gridTipado
            // 
            this.gridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipado.Location = new System.Drawing.Point(24, 45);
            this.gridTipado.Name = "gridTipado";
            this.gridTipado.RowHeadersWidth = 51;
            this.gridTipado.RowTemplate.Height = 24;
            this.gridTipado.Size = new System.Drawing.Size(443, 286);
            this.gridTipado.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1055, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "CustomerID";
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.Location = new System.Drawing.Point(1170, 149);
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(125, 22);
            this.tboxCustomerID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1055, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "CompanyName";
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.Location = new System.Drawing.Point(1170, 194);
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.Size = new System.Drawing.Size(125, 22);
            this.tboxCompanyName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1055, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contact Name";
            // 
            // tboxContactName
            // 
            this.tboxContactName.Location = new System.Drawing.Point(1170, 246);
            this.tboxContactName.Name = "tboxContactName";
            this.tboxContactName.Size = new System.Drawing.Size(125, 22);
            this.tboxContactName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1055, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contact Title";
            // 
            // tboxContactTitle
            // 
            this.tboxContactTitle.Location = new System.Drawing.Point(1170, 302);
            this.tboxContactTitle.Name = "tboxContactTitle";
            this.tboxContactTitle.Size = new System.Drawing.Size(125, 22);
            this.tboxContactTitle.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1055, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Address";
            // 
            // tboxAddres
            // 
            this.tboxAddres.Location = new System.Drawing.Point(1170, 353);
            this.tboxAddres.Name = "tboxAddres";
            this.tboxAddres.Size = new System.Drawing.Size(125, 22);
            this.tboxAddres.TabIndex = 17;
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Location = new System.Drawing.Point(1070, 412);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(225, 37);
            this.btnInsertarCliente.TabIndex = 8;
            this.btnInsertarCliente.Text = "Insertar Cliente";
            this.btnInsertarCliente.UseVisualStyleBackColor = true;
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // btnActualizarTipado
            // 
            this.btnActualizarTipado.Location = new System.Drawing.Point(130, 556);
            this.btnActualizarTipado.Name = "btnActualizarTipado";
            this.btnActualizarTipado.Size = new System.Drawing.Size(197, 37);
            this.btnActualizarTipado.TabIndex = 6;
            this.btnActualizarTipado.Text = "Actualizar";
            this.btnActualizarTipado.UseVisualStyleBackColor = true;
            this.btnActualizarTipado.Click += new System.EventHandler(this.btnActualizarTipado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 673);
            this.Controls.Add(this.btnInsertarCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxAddres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxContactTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxContactName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObtenerNoTipado;
        private System.Windows.Forms.DataGridView gridNoTipado;
        private System.Windows.Forms.Button btnObtenerTipado;
        private System.Windows.Forms.DataGridView gridTipado;
        private System.Windows.Forms.Button btnBuscarNt;
        private System.Windows.Forms.TextBox tbBusquedaNt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarTipado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxBuscarTipado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxCompanyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxContactName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxContactTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxAddres;
        private System.Windows.Forms.Button btnInsertarCliente;
        private System.Windows.Forms.Button btnInsertarT;
        private System.Windows.Forms.Button btnActualizarNT;
        private System.Windows.Forms.Button btnActualizarTipado;
    }
}

