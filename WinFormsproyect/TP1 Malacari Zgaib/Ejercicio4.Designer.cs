namespace TP1_Malacari_Zgaib
{
    partial class Ejercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio4));
            this.txtCantidadFilas = new System.Windows.Forms.TextBox();
            this.CantidadFilas = new System.Windows.Forms.Label();
            this.cmbCriterioOrdenamiento = new System.Windows.Forms.ComboBox();
            this.lblcriterio = new System.Windows.Forms.Label();
            this.algoritmos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTim = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidadFilas
            // 
            this.txtCantidadFilas.Location = new System.Drawing.Point(621, 125);
            this.txtCantidadFilas.Name = "txtCantidadFilas";
            this.txtCantidadFilas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadFilas.TabIndex = 3;
            this.txtCantidadFilas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadFilas_KeyPress);
            // 
            // CantidadFilas
            // 
            this.CantidadFilas.AutoSize = true;
            this.CantidadFilas.BackColor = System.Drawing.Color.White;
            this.CantidadFilas.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadFilas.Location = new System.Drawing.Point(457, 121);
            this.CantidadFilas.Name = "CantidadFilas";
            this.CantidadFilas.Size = new System.Drawing.Size(67, 15);
            this.CantidadFilas.TabIndex = 4;
            this.CantidadFilas.Text = "Filas a Leer";
            // 
            // cmbCriterioOrdenamiento
            // 
            this.cmbCriterioOrdenamiento.FormattingEnabled = true;
            this.cmbCriterioOrdenamiento.Location = new System.Drawing.Point(621, 12);
            this.cmbCriterioOrdenamiento.Name = "cmbCriterioOrdenamiento";
            this.cmbCriterioOrdenamiento.Size = new System.Drawing.Size(100, 21);
            this.cmbCriterioOrdenamiento.TabIndex = 6;
            this.cmbCriterioOrdenamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCriterioOrdenamiento_KeyPress);
            // 
            // lblcriterio
            // 
            this.lblcriterio.AutoSize = true;
            this.lblcriterio.BackColor = System.Drawing.Color.White;
            this.lblcriterio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcriterio.Location = new System.Drawing.Point(457, 10);
            this.lblcriterio.Name = "lblcriterio";
            this.lblcriterio.Size = new System.Drawing.Size(158, 15);
            this.lblcriterio.TabIndex = 11;
            this.lblcriterio.Text = "Criterios de Ordenamiento ";
            // 
            // algoritmos
            // 
            this.algoritmos.AutoSize = true;
            this.algoritmos.BackColor = System.Drawing.Color.White;
            this.algoritmos.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmos.Location = new System.Drawing.Point(457, 240);
            this.algoritmos.Name = "algoritmos";
            this.algoritmos.Size = new System.Drawing.Size(74, 15);
            this.algoritmos.TabIndex = 15;
            this.algoritmos.Text = "Algoritmos :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paisDataGridViewTextBoxColumn,
            this.itemTypeDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.unitsSoldDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.objetoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 464);
            this.dataGridView1.TabIndex = 16;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "itemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "itemType";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // unitsSoldDataGridViewTextBoxColumn
            // 
            this.unitsSoldDataGridViewTextBoxColumn.DataPropertyName = "unitsSold";
            this.unitsSoldDataGridViewTextBoxColumn.HeaderText = "unitsSold";
            this.unitsSoldDataGridViewTextBoxColumn.Name = "unitsSoldDataGridViewTextBoxColumn";
            // 
            // objetoBindingSource
            // 
            this.objetoBindingSource.DataSource = typeof(TP1_Malacari_Zgaib.Objeto);
            this.objetoBindingSource.CurrentChanged += new System.EventHandler(this.objetoBindingSource_CurrentChanged);
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTim.BackgroundImage")));
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTim.Location = new System.Drawing.Point(600, 415);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(123, 33);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "Tim Sort";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnQuick
            // 
            this.btnQuick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuick.BackgroundImage")));
            this.btnQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuick.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuick.Location = new System.Drawing.Point(600, 371);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(123, 33);
            this.btnQuick.TabIndex = 9;
            this.btnQuick.Text = "Quick Sort";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMerge.BackgroundImage")));
            this.btnMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMerge.Location = new System.Drawing.Point(599, 283);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(123, 33);
            this.btnMerge.TabIndex = 8;
            this.btnMerge.Text = "Merge Sort";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnShell
            // 
            this.btnShell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShell.BackgroundImage")));
            this.btnShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShell.Location = new System.Drawing.Point(599, 327);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(123, 33);
            this.btnShell.TabIndex = 7;
            this.btnShell.Text = "Shell Sort";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBubble.BackgroundImage")));
            this.btnBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBubble.Location = new System.Drawing.Point(600, 239);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(123, 33);
            this.btnBubble.TabIndex = 5;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLeer.BackgroundImage = global::TP1_Malacari_Zgaib.Properties.Resources.Screenshot_2020_11_12_0235271;
            this.btnLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLeer.Location = new System.Drawing.Point(600, 170);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(123, 33);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1_Malacari_Zgaib.Properties.Resources.background_w;
            this.ClientSize = new System.Drawing.Size(735, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.algoritmos);
            this.Controls.Add(this.lblcriterio);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.cmbCriterioOrdenamiento);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.CantidadFilas);
            this.Controls.Add(this.txtCantidadFilas);
            this.Controls.Add(this.btnLeer);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.Load += new System.EventHandler(this.Ejercicio4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.TextBox txtCantidadFilas;
        private System.Windows.Forms.Label CantidadFilas;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.ComboBox cmbCriterioOrdenamiento;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblcriterio;
        private System.Windows.Forms.Label algoritmos;
        private System.Windows.Forms.BindingSource objetoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsSoldDataGridViewTextBoxColumn;
    }
}