namespace TP1_Malacari_Zgaib
{
    partial class EjercicioUno
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjercicioUno));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cQuesosDataGridView = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuesosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textWmax = new System.Windows.Forms.TextBox();
            this.wmax = new System.Windows.Forms.Label();
            this.dinamica = new System.Windows.Forms.Button();
            this.voraz = new System.Windows.Forms.Button();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.cQuesosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cQuesosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            nombreLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cQuesosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cQuesosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cQuesosBindingNavigator)).BeginInit();
            this.cQuesosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.White;
            nombreLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(104, 72);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(56, 15);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "Nombre:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.BackColor = System.Drawing.Color.White;
            pesoLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pesoLabel.Location = new System.Drawing.Point(104, 98);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(54, 15);
            pesoLabel.TabIndex = 2;
            pesoLabel.Text = "Peso:      ";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.BackColor = System.Drawing.Color.White;
            precioLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(104, 124);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(54, 15);
            precioLabel.TabIndex = 4;
            precioLabel.Text = "Precio:   ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackgroundImage = global::TP1_Malacari_Zgaib.Properties.Resources.robomoch3;
            this.splitContainer1.Panel1.Controls.Add(this.cQuesosDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.splitContainer1.Panel2.BackgroundImage = global::TP1_Malacari_Zgaib.Properties.Resources.robomoch9;
            this.splitContainer1.Panel2.Controls.Add(this.textWmax);
            this.splitContainer1.Panel2.Controls.Add(this.wmax);
            this.splitContainer1.Panel2.Controls.Add(this.dinamica);
            this.splitContainer1.Panel2.Controls.Add(this.voraz);
            this.splitContainer1.Panel2.Controls.Add(nombreLabel);
            this.splitContainer1.Panel2.Controls.Add(this.nombreTextBox);
            this.splitContainer1.Panel2.Controls.Add(pesoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.pesoTextBox);
            this.splitContainer1.Panel2.Controls.Add(precioLabel);
            this.splitContainer1.Panel2.Controls.Add(this.precioTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1011, 371);
            this.splitContainer1.SplitterDistance = 616;
            this.splitContainer1.TabIndex = 0;
            // 
            // cQuesosDataGridView
            // 
            this.cQuesosDataGridView.AutoGenerateColumns = false;
            this.cQuesosDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.cQuesosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cQuesosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cQuesosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cQuesosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cQuesosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.cQuesosDataGridView.DataSource = this.cQuesosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cQuesosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.cQuesosDataGridView.GridColor = System.Drawing.Color.DimGray;
            this.cQuesosDataGridView.Location = new System.Drawing.Point(0, 28);
            this.cQuesosDataGridView.Name = "cQuesosDataGridView";
            this.cQuesosDataGridView.Size = new System.Drawing.Size(345, 153);
            this.cQuesosDataGridView.TabIndex = 0;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // cQuesosBindingSource
            // 
            this.cQuesosBindingSource.DataSource = typeof(TP1_Malacari_Zgaib.cQuesos);
            this.cQuesosBindingSource.CurrentChanged += new System.EventHandler(this.cQuesosBindingSource_CurrentChanged);
            // 
            // textWmax
            // 
            this.textWmax.Location = new System.Drawing.Point(173, 192);
            this.textWmax.Name = "textWmax";
            this.textWmax.Size = new System.Drawing.Size(120, 20);
            this.textWmax.TabIndex = 10;
            this.textWmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textWmax_KeyPress);
            // 
            // wmax
            // 
            this.wmax.AutoSize = true;
            this.wmax.BackColor = System.Drawing.Color.White;
            this.wmax.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wmax.Location = new System.Drawing.Point(104, 197);
            this.wmax.Name = "wmax";
            this.wmax.Size = new System.Drawing.Size(49, 15);
            this.wmax.TabIndex = 9;
            this.wmax.Text = "Wmax: ";
            // 
            // dinamica
            // 
            this.dinamica.BackColor = System.Drawing.Color.Black;
            this.dinamica.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinamica.ForeColor = System.Drawing.Color.GhostWhite;
            this.dinamica.Location = new System.Drawing.Point(88, 256);
            this.dinamica.Name = "dinamica";
            this.dinamica.Size = new System.Drawing.Size(80, 30);
            this.dinamica.TabIndex = 8;
            this.dinamica.Text = "Dinámica";
            this.dinamica.UseVisualStyleBackColor = false;
            this.dinamica.Click += new System.EventHandler(this.dinamica_Click);
            // 
            // voraz
            // 
            this.voraz.BackColor = System.Drawing.Color.Black;
            this.voraz.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voraz.ForeColor = System.Drawing.Color.GhostWhite;
            this.voraz.Location = new System.Drawing.Point(212, 256);
            this.voraz.Name = "voraz";
            this.voraz.Size = new System.Drawing.Size(80, 30);
            this.voraz.TabIndex = 7;
            this.voraz.Text = "Voraz";
            this.voraz.UseVisualStyleBackColor = false;
            this.voraz.Click += new System.EventHandler(this.voraz_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cQuesosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(173, 70);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(120, 20);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cQuesosBindingSource, "peso", true));
            this.pesoTextBox.Location = new System.Drawing.Point(173, 96);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(120, 20);
            this.pesoTextBox.TabIndex = 3;
            this.pesoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesoTextBox_KeyPress);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cQuesosBindingSource, "precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(173, 122);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(120, 20);
            this.precioTextBox.TabIndex = 5;
            this.precioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioTextBox_KeyPress);
            // 
            // cQuesosBindingNavigator
            // 
            this.cQuesosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cQuesosBindingNavigator.BindingSource = this.cQuesosBindingSource;
            this.cQuesosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cQuesosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cQuesosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cQuesosBindingNavigatorSaveItem});
            this.cQuesosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cQuesosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cQuesosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cQuesosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cQuesosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cQuesosBindingNavigator.Name = "cQuesosBindingNavigator";
            this.cQuesosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cQuesosBindingNavigator.Size = new System.Drawing.Size(1011, 25);
            this.cQuesosBindingNavigator.TabIndex = 1;
            this.cQuesosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cQuesosBindingNavigatorSaveItem
            // 
            this.cQuesosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cQuesosBindingNavigatorSaveItem.Enabled = false;
            this.cQuesosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cQuesosBindingNavigatorSaveItem.Image")));
            this.cQuesosBindingNavigatorSaveItem.Name = "cQuesosBindingNavigatorSaveItem";
            this.cQuesosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cQuesosBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // EjercicioUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 371);
            this.Controls.Add(this.cQuesosBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "EjercicioUno";
            this.Text = "EjercicioUno";
            this.Load += new System.EventHandler(this.cQuesosBindingSource_CurrentChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cQuesosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cQuesosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cQuesosBindingNavigator)).EndInit();
            this.cQuesosBindingNavigator.ResumeLayout(false);
            this.cQuesosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView cQuesosDataGridView;
        private System.Windows.Forms.BindingNavigator cQuesosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cQuesosBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource cQuesosBindingSource;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Button dinamica;
        private System.Windows.Forms.Button voraz;
        private System.Windows.Forms.Label wmax;
        private System.Windows.Forms.TextBox textWmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
    }
}