namespace PresentationLayer.Prefabs
{
    partial class MoneyControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValue = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.inputQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblEditing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(19, 26);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(93, 39);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "1000";
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAction.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAction.FlatAppearance.BorderSize = 0;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(44, 120);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(94, 34);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Agregar";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.action);
            // 
            // inputQuantity
            // 
            this.inputQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputQuantity.Location = new System.Drawing.Point(26, 84);
            this.inputQuantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inputQuantity.Name = "inputQuantity";
            this.inputQuantity.Size = new System.Drawing.Size(127, 30);
            this.inputQuantity.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(146, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.removeCurrency);
            // 
            // lblEditing
            // 
            this.lblEditing.AutoSize = true;
            this.lblEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditing.Location = new System.Drawing.Point(21, 56);
            this.lblEditing.Name = "lblEditing";
            this.lblEditing.Size = new System.Drawing.Size(58, 25);
            this.lblEditing.TabIndex = 4;
            this.lblEditing.Text = "Valor";
            this.lblEditing.Visible = false;
            // 
            // MoneyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.circular1;
            this.Controls.Add(this.lblEditing);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.inputQuantity);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblValue);
            this.Name = "MoneyControl";
            this.Size = new System.Drawing.Size(171, 189);
            ((System.ComponentModel.ISupportInitialize)(this.inputQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.NumericUpDown inputQuantity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblEditing;
    }
}
