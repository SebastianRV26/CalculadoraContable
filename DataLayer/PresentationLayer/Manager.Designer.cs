namespace PresentationLayer
{
    partial class Manager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBefore = new System.Windows.Forms.Button();
            this.txtboxAdd = new System.Windows.Forms.NumericUpDown();
            this.radiobtnMoneda = new System.Windows.Forms.RadioButton();
            this.radiobtnBillete = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(206)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBefore);
            this.panel1.Controls.Add(this.txtboxAdd);
            this.panel1.Controls.Add(this.radiobtnMoneda);
            this.panel1.Controls.Add(this.radiobtnBillete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnBefore
            // 
            this.btnBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBefore.Location = new System.Drawing.Point(724, -1);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(75, 45);
            this.btnBefore.TabIndex = 17;
            this.btnBefore.Text = "Atrás";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.BtnBefore_Click);
            // 
            // txtboxAdd
            // 
            this.txtboxAdd.DecimalPlaces = 2;
            this.txtboxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAdd.Location = new System.Drawing.Point(348, 10);
            this.txtboxAdd.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtboxAdd.Name = "txtboxAdd";
            this.txtboxAdd.Size = new System.Drawing.Size(120, 24);
            this.txtboxAdd.TabIndex = 16;
            // 
            // radiobtnMoneda
            // 
            this.radiobtnMoneda.AutoSize = true;
            this.radiobtnMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnMoneda.Location = new System.Drawing.Point(174, 10);
            this.radiobtnMoneda.Name = "radiobtnMoneda";
            this.radiobtnMoneda.Size = new System.Drawing.Size(85, 24);
            this.radiobtnMoneda.TabIndex = 14;
            this.radiobtnMoneda.Text = "Moneda";
            this.radiobtnMoneda.UseVisualStyleBackColor = true;
            // 
            // radiobtnBillete
            // 
            this.radiobtnBillete.AutoSize = true;
            this.radiobtnBillete.Checked = true;
            this.radiobtnBillete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnBillete.Location = new System.Drawing.Point(98, 11);
            this.radiobtnBillete.Name = "radiobtnBillete";
            this.radiobtnBillete.Size = new System.Drawing.Size(70, 24);
            this.radiobtnBillete.TabIndex = 15;
            this.radiobtnBillete.TabStop = true;
            this.radiobtnBillete.Text = "Billete";
            this.radiobtnBillete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(474, -1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.addMoney);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(296, 12);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar";
            // 
            // moneyContainer
            // 
            this.moneyContainer.AutoScroll = true;
            this.moneyContainer.AutoSize = true;
            this.moneyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moneyContainer.Location = new System.Drawing.Point(0, 45);
            this.moneyContainer.Name = "moneyContainer";
            this.moneyContainer.Size = new System.Drawing.Size(800, 405);
            this.moneyContainer.TabIndex = 13;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveData);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radiobtnMoneda;
        private System.Windows.Forms.RadioButton radiobtnBillete;
        private System.Windows.Forms.FlowLayoutPanel moneyContainer;
        private System.Windows.Forms.NumericUpDown txtboxAdd;
        private System.Windows.Forms.Button btnBefore;
    }
}