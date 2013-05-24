namespace Flat
{
    partial class Complex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Complex));
            this.dataGridViewName = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorComplex = new System.Windows.Forms.BindingNavigator(this.components);
            this.addComplexToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveComplextoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteComplexToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorProperties = new System.Windows.Forms.BindingNavigator(this.components);
            this.addPropertiesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.deletePropertiesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.comboBoxProperties = new System.Windows.Forms.ComboBox();
            this.listBoxProperties = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorComplex)).BeginInit();
            this.bindingNavigatorComplex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorProperties)).BeginInit();
            this.bindingNavigatorProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewName
            // 
            this.dataGridViewName.AllowUserToAddRows = false;
            this.dataGridViewName.AllowUserToOrderColumns = true;
            this.dataGridViewName.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.number,
            this.name});
            this.dataGridViewName.Location = new System.Drawing.Point(3, 29);
            this.dataGridViewName.Name = "dataGridViewName";
            this.dataGridViewName.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.dataGridViewName.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewName.Size = new System.Drawing.Size(394, 424);
            this.dataGridViewName.TabIndex = 0;
            this.dataGridViewName.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewName_CellMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Назва";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // bindingNavigatorComplex
            // 
            this.bindingNavigatorComplex.AddNewItem = null;
            this.bindingNavigatorComplex.CountItem = null;
            this.bindingNavigatorComplex.DeleteItem = null;
            this.bindingNavigatorComplex.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorComplex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addComplexToolStripButton,
            this.saveComplextoolStripButton,
            this.toolStripSeparator4,
            this.deleteComplexToolStripButton});
            this.bindingNavigatorComplex.Location = new System.Drawing.Point(3, 1);
            this.bindingNavigatorComplex.MoveFirstItem = null;
            this.bindingNavigatorComplex.MoveLastItem = null;
            this.bindingNavigatorComplex.MoveNextItem = null;
            this.bindingNavigatorComplex.MovePreviousItem = null;
            this.bindingNavigatorComplex.Name = "bindingNavigatorComplex";
            this.bindingNavigatorComplex.PositionItem = null;
            this.bindingNavigatorComplex.Size = new System.Drawing.Size(87, 25);
            this.bindingNavigatorComplex.TabIndex = 5;
            this.bindingNavigatorComplex.Text = "bindingNavigator1";
            // 
            // addComplexToolStripButton
            // 
            this.addComplexToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addComplexToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addComplexToolStripButton.Image")));
            this.addComplexToolStripButton.Name = "addComplexToolStripButton";
            this.addComplexToolStripButton.RightToLeftAutoMirrorImage = true;
            this.addComplexToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addComplexToolStripButton.Text = "Add new";
            this.addComplexToolStripButton.ToolTipText = "Додати";
            this.addComplexToolStripButton.Click += new System.EventHandler(this.addComplexToolStripButton_Click);
            // 
            // saveComplextoolStripButton
            // 
            this.saveComplextoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveComplextoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveComplextoolStripButton.Image")));
            this.saveComplextoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveComplextoolStripButton.Name = "saveComplextoolStripButton";
            this.saveComplextoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveComplextoolStripButton.Text = "&Save";
            this.saveComplextoolStripButton.ToolTipText = "Зберегти";
            this.saveComplextoolStripButton.Click += new System.EventHandler(this.saveComplextoolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteComplexToolStripButton
            // 
            this.deleteComplexToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteComplexToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteComplexToolStripButton.Image")));
            this.deleteComplexToolStripButton.Name = "deleteComplexToolStripButton";
            this.deleteComplexToolStripButton.RightToLeftAutoMirrorImage = true;
            this.deleteComplexToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteComplexToolStripButton.Text = "Delete";
            this.deleteComplexToolStripButton.ToolTipText = "Видалити";
            // 
            // bindingNavigatorProperties
            // 
            this.bindingNavigatorProperties.AddNewItem = null;
            this.bindingNavigatorProperties.CountItem = null;
            this.bindingNavigatorProperties.DeleteItem = null;
            this.bindingNavigatorProperties.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPropertiesToolStripButton,
            this.toolStripSeparator,
            this.deletePropertiesToolStripButton});
            this.bindingNavigatorProperties.Location = new System.Drawing.Point(403, 0);
            this.bindingNavigatorProperties.MoveFirstItem = null;
            this.bindingNavigatorProperties.MoveLastItem = null;
            this.bindingNavigatorProperties.MoveNextItem = null;
            this.bindingNavigatorProperties.MovePreviousItem = null;
            this.bindingNavigatorProperties.Name = "bindingNavigatorProperties";
            this.bindingNavigatorProperties.PositionItem = null;
            this.bindingNavigatorProperties.Size = new System.Drawing.Size(64, 25);
            this.bindingNavigatorProperties.TabIndex = 6;
            this.bindingNavigatorProperties.Text = "bindingNavigator2";
            // 
            // addPropertiesToolStripButton
            // 
            this.addPropertiesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addPropertiesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addPropertiesToolStripButton.Image")));
            this.addPropertiesToolStripButton.Name = "addPropertiesToolStripButton";
            this.addPropertiesToolStripButton.RightToLeftAutoMirrorImage = true;
            this.addPropertiesToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addPropertiesToolStripButton.Text = "Add new";
            this.addPropertiesToolStripButton.ToolTipText = "Додати";
            this.addPropertiesToolStripButton.Click += new System.EventHandler(this.addPropertiesToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // deletePropertiesToolStripButton
            // 
            this.deletePropertiesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deletePropertiesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deletePropertiesToolStripButton.Image")));
            this.deletePropertiesToolStripButton.Name = "deletePropertiesToolStripButton";
            this.deletePropertiesToolStripButton.RightToLeftAutoMirrorImage = true;
            this.deletePropertiesToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deletePropertiesToolStripButton.Text = "Delete";
            this.deletePropertiesToolStripButton.ToolTipText = "Видалити";
            this.deletePropertiesToolStripButton.Click += new System.EventHandler(this.deletePropertiesToolStripButton_Click);
            // 
            // comboBoxProperties
            // 
            this.comboBoxProperties.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProperties.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxProperties.FormattingEnabled = true;
            this.comboBoxProperties.Location = new System.Drawing.Point(403, 28);
            this.comboBoxProperties.Name = "comboBoxProperties";
            this.comboBoxProperties.Size = new System.Drawing.Size(225, 21);
            this.comboBoxProperties.TabIndex = 10;
            this.comboBoxProperties.SelectedIndexChanged += new System.EventHandler(this.comboBoxProperties_SelectedIndexChanged);
            // 
            // listBoxProperties
            // 
            this.listBoxProperties.BackColor = System.Drawing.Color.Honeydew;
            this.listBoxProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProperties.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProperties.FormattingEnabled = true;
            this.listBoxProperties.ItemHeight = 21;
            this.listBoxProperties.Items.AddRange(new object[] {
            " "});
            this.listBoxProperties.Location = new System.Drawing.Point(403, 71);
            this.listBoxProperties.Name = "listBoxProperties";
            this.listBoxProperties.Size = new System.Drawing.Size(225, 378);
            this.listBoxProperties.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Характеристики:";
            // 
            // Complex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(633, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProperties);
            this.Controls.Add(this.comboBoxProperties);
            this.Controls.Add(this.bindingNavigatorProperties);
            this.Controls.Add(this.bindingNavigatorComplex);
            this.Controls.Add(this.dataGridViewName);
            this.Name = "Complex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complex";
            this.Load += new System.EventHandler(this.Complex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorComplex)).EndInit();
            this.bindingNavigatorComplex.ResumeLayout(false);
            this.bindingNavigatorComplex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorProperties)).EndInit();
            this.bindingNavigatorProperties.ResumeLayout(false);
            this.bindingNavigatorProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewName;
        private System.Windows.Forms.BindingNavigator bindingNavigatorComplex;
        private System.Windows.Forms.ToolStripButton addComplexToolStripButton;
        private System.Windows.Forms.ToolStripButton saveComplextoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton deleteComplexToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigatorProperties;
        private System.Windows.Forms.ToolStripButton addPropertiesToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton deletePropertiesToolStripButton;
        private System.Windows.Forms.ComboBox comboBoxProperties;
        private System.Windows.Forms.ListBox listBoxProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label label1;
    }
}