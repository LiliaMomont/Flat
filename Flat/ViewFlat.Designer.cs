namespace Flat
{
    partial class ViewFlat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFlat));
            this.comboBoxComplex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFlat = new System.Windows.Forms.DataGridView();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.bindingNavigatorViewFlat = new System.Windows.Forms.BindingNavigator(this.components);
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_complex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1m2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poverx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.square_generaly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.square_life = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorViewFlat)).BeginInit();
            this.bindingNavigatorViewFlat.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxComplex
            // 
            this.comboBoxComplex.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxComplex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComplex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxComplex.FormattingEnabled = true;
            this.comboBoxComplex.Location = new System.Drawing.Point(6, 48);
            this.comboBoxComplex.Name = "comboBoxComplex";
            this.comboBoxComplex.Size = new System.Drawing.Size(195, 21);
            this.comboBoxComplex.TabIndex = 0;
            this.comboBoxComplex.SelectedIndexChanged += new System.EventHandler(this.comboBoxComplex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виберіть житловий комплекс";
            // 
            // dataGridViewFlat
            // 
            this.dataGridViewFlat.AllowUserToAddRows = false;
            this.dataGridViewFlat.AllowUserToOrderColumns = true;
            this.dataGridViewFlat.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewFlat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFlat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewFlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.number,
            this.id_address,
            this.id_complex,
            this.price1m2,
            this.poverx,
            this.square_generaly,
            this.square_life,
            this.price,
            this.count,
            this.credit,
            this.staus});
            this.dataGridViewFlat.Location = new System.Drawing.Point(6, 75);
            this.dataGridViewFlat.Name = "dataGridViewFlat";
            this.dataGridViewFlat.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.dataGridViewFlat.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlat.Size = new System.Drawing.Size(923, 471);
            this.dataGridViewFlat.TabIndex = 2;
            this.dataGridViewFlat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFlat_CellMouseClick);
            this.dataGridViewFlat.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFlat_CellMouseDoubleClick);
            // 
            // textBoxFind
            // 
            this.textBoxFind.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFind.ForeColor = System.Drawing.Color.Red;
            this.textBoxFind.Location = new System.Drawing.Point(652, 49);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(277, 20);
            this.textBoxFind.TabIndex = 3;
            this.textBoxFind.Text = "Пошук по загальній площі";
            this.textBoxFind.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxFind_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пошук";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адреса житлового комплексу:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxAddress.Enabled = false;
            this.textBoxAddress.Location = new System.Drawing.Point(243, 48);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(374, 20);
            this.textBoxAddress.TabIndex = 6;
            // 
            // bindingNavigatorViewFlat
            // 
            this.bindingNavigatorViewFlat.AddNewItem = null;
            this.bindingNavigatorViewFlat.CountItem = null;
            this.bindingNavigatorViewFlat.DeleteItem = null;
            this.bindingNavigatorViewFlat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.deleteToolStripButton});
            this.bindingNavigatorViewFlat.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorViewFlat.MoveFirstItem = null;
            this.bindingNavigatorViewFlat.MoveLastItem = null;
            this.bindingNavigatorViewFlat.MoveNextItem = null;
            this.bindingNavigatorViewFlat.MovePreviousItem = null;
            this.bindingNavigatorViewFlat.Name = "bindingNavigatorViewFlat";
            this.bindingNavigatorViewFlat.PositionItem = null;
            this.bindingNavigatorViewFlat.Size = new System.Drawing.Size(934, 25);
            this.bindingNavigatorViewFlat.TabIndex = 7;
            this.bindingNavigatorViewFlat.Text = "bindingNavigator2";
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.Image = global::Flat.Properties.Resources._1_2699;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.editToolStripButton.Text = "Редагувати";
            this.editToolStripButton.ToolTipText = "Редагувати";
            this.editToolStripButton.Click += new System.EventHandler(this.editToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.ToolTipText = "Зберегти";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.RightToLeftAutoMirrorImage = true;
            this.deleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.ToolTipText = "Видалити";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // name
            // 
            this.name.HeaderText = "№";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 50;
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Visible = false;
            // 
            // id_address
            // 
            this.id_address.HeaderText = "id_address";
            this.id_address.Name = "id_address";
            this.id_address.ReadOnly = true;
            this.id_address.Visible = false;
            // 
            // id_complex
            // 
            this.id_complex.HeaderText = "id_complex";
            this.id_complex.Name = "id_complex";
            this.id_complex.ReadOnly = true;
            this.id_complex.Visible = false;
            // 
            // price1m2
            // 
            this.price1m2.HeaderText = "Ціна за 1 м2, грн";
            this.price1m2.Name = "price1m2";
            this.price1m2.ReadOnly = true;
            // 
            // poverx
            // 
            this.poverx.HeaderText = "Поверх";
            this.poverx.Name = "poverx";
            this.poverx.ReadOnly = true;
            this.poverx.Width = 80;
            // 
            // square_generaly
            // 
            this.square_generaly.HeaderText = "Загальна площа, м2";
            this.square_generaly.Name = "square_generaly";
            this.square_generaly.ReadOnly = true;
            // 
            // square_life
            // 
            this.square_life.HeaderText = "Житлова площа, м2";
            this.square_life.Name = "square_life";
            this.square_life.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Вартість, грн";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // count
            // 
            this.count.HeaderText = "Кількість кімнат";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // credit
            // 
            this.credit.HeaderText = "Можливість кредитування";
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            // 
            // staus
            // 
            this.staus.HeaderText = "Продано";
            this.staus.Name = "staus";
            this.staus.ReadOnly = true;
            // 
            // ViewFlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(934, 552);
            this.Controls.Add(this.bindingNavigatorViewFlat);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.dataGridViewFlat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxComplex);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "ViewFlat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перегляд квартир";
            this.Load += new System.EventHandler(this.ViewFlat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorViewFlat)).EndInit();
            this.bindingNavigatorViewFlat.ResumeLayout(false);
            this.bindingNavigatorViewFlat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxComplex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFlat;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.BindingNavigator bindingNavigatorViewFlat;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_complex;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1m2;
        private System.Windows.Forms.DataGridViewTextBoxColumn poverx;
        private System.Windows.Forms.DataGridViewTextBoxColumn square_generaly;
        private System.Windows.Forms.DataGridViewTextBoxColumn square_life;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn staus;
    }
}