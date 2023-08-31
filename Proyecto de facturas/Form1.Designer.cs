namespace Proyecto_de_facturas
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btProducto = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.btFactura = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btProducto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btFactura, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btCliente, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btProducto
            // 
            this.btProducto.Location = new System.Drawing.Point(403, 3);
            this.btProducto.Name = "btProducto";
            this.btProducto.Size = new System.Drawing.Size(394, 216);
            this.btProducto.TabIndex = 0;
            this.btProducto.Text = "PRODUCTO";
            this.btProducto.UseVisualStyleBackColor = true;
            // 
            // btCliente
            // 
            this.btCliente.Location = new System.Drawing.Point(3, 3);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(382, 207);
            this.btCliente.TabIndex = 1;
            this.btCliente.Text = "CLIENTES";
            this.btCliente.UseVisualStyleBackColor = true;
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(403, 228);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(394, 219);
            this.bt.TabIndex = 2;
            this.bt.Text = "button3";
            this.bt.UseVisualStyleBackColor = true;
            // 
            // btFactura
            // 
            this.btFactura.Location = new System.Drawing.Point(3, 228);
            this.btFactura.Name = "btFactura";
            this.btFactura.Size = new System.Drawing.Size(394, 210);
            this.btFactura.TabIndex = 3;
            this.btFactura.Text = "FACTURAs";
            this.btFactura.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btProducto;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Button btFactura;
        private System.Windows.Forms.Button btCliente;
    }
}

