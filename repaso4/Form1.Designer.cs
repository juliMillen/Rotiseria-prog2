
namespace repaso4
{
    partial class form1
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
            this.btnTomarPedido = new System.Windows.Forms.Button();
            this.cbxOpciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregarMenu = new System.Windows.Forms.Button();
            this.lBpedidos = new System.Windows.Forms.ListBox();
            this.btnCerrarPedido = new System.Windows.Forms.Button();
            this.lBlistaPedidos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTomarPedido
            // 
            this.btnTomarPedido.Location = new System.Drawing.Point(13, 13);
            this.btnTomarPedido.Name = "btnTomarPedido";
            this.btnTomarPedido.Size = new System.Drawing.Size(246, 43);
            this.btnTomarPedido.TabIndex = 0;
            this.btnTomarPedido.Text = "Tomar Pedido";
            this.btnTomarPedido.UseVisualStyleBackColor = true;
            this.btnTomarPedido.Click += new System.EventHandler(this.btnTomarPedido_Click);
            // 
            // cbxOpciones
            // 
            this.cbxOpciones.FormattingEnabled = true;
            this.cbxOpciones.Items.AddRange(new object[] {
            "Pizza Napolitana Especial",
            "Gaseosa"});
            this.cbxOpciones.Location = new System.Drawing.Point(13, 76);
            this.cbxOpciones.Name = "cbxOpciones";
            this.cbxOpciones.Size = new System.Drawing.Size(246, 21);
            this.cbxOpciones.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnAgregarMenu
            // 
            this.btnAgregarMenu.Location = new System.Drawing.Point(322, 73);
            this.btnAgregarMenu.Name = "btnAgregarMenu";
            this.btnAgregarMenu.Size = new System.Drawing.Size(75, 34);
            this.btnAgregarMenu.TabIndex = 4;
            this.btnAgregarMenu.Text = "Agregar Menu";
            this.btnAgregarMenu.UseVisualStyleBackColor = true;
            this.btnAgregarMenu.Click += new System.EventHandler(this.btnAgregarMenu_Click);
            // 
            // lBpedidos
            // 
            this.lBpedidos.FormattingEnabled = true;
            this.lBpedidos.Location = new System.Drawing.Point(13, 159);
            this.lBpedidos.Name = "lBpedidos";
            this.lBpedidos.Size = new System.Drawing.Size(384, 121);
            this.lBpedidos.TabIndex = 5;
            // 
            // btnCerrarPedido
            // 
            this.btnCerrarPedido.Location = new System.Drawing.Point(13, 287);
            this.btnCerrarPedido.Name = "btnCerrarPedido";
            this.btnCerrarPedido.Size = new System.Drawing.Size(384, 23);
            this.btnCerrarPedido.TabIndex = 6;
            this.btnCerrarPedido.Text = "Cerrar Pedido";
            this.btnCerrarPedido.UseVisualStyleBackColor = true;
            this.btnCerrarPedido.Click += new System.EventHandler(this.btnCerrarPedido_Click);
            // 
            // lBlistaPedidos
            // 
            this.lBlistaPedidos.FormattingEnabled = true;
            this.lBlistaPedidos.Location = new System.Drawing.Point(13, 326);
            this.lBlistaPedidos.Name = "lBlistaPedidos";
            this.lBlistaPedidos.Size = new System.Drawing.Size(384, 134);
            this.lBlistaPedidos.TabIndex = 7;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 473);
            this.Controls.Add(this.lBlistaPedidos);
            this.Controls.Add(this.btnCerrarPedido);
            this.Controls.Add(this.lBpedidos);
            this.Controls.Add(this.btnAgregarMenu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxOpciones);
            this.Controls.Add(this.btnTomarPedido);
            this.Name = "form1";
            this.Text = "Rotiseria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnTomarPedido;
        private System.Windows.Forms.ComboBox cbxOpciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnAgregarMenu;
        private System.Windows.Forms.ListBox lBpedidos;
        public System.Windows.Forms.Button btnCerrarPedido;
        private System.Windows.Forms.ListBox lBlistaPedidos;
    }
}

