namespace Flat
{
    partial class ComplProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplProperties));
            this.dataGridViewProperties = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorComplex = new System.Windows.Forms.BindingNavigator(this.components);
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorComplex)).BeginInit();
            this.bindingNavigatorComplex.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProperties
            // 
            this.dataGridViewProperties.AllowUserToAddRows = false;
            this.dataGridViewProperties.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.number,
            this.name});
            this.dataGridViewProperties.Location = new System.Drawing.Point(5, 28);
            this.dataGridViewProperties.Name = "dataGridViewProperties";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.dataGridViewProperties.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProperties.Size = new System.Drawing.Size(594, 452);
            this.dataGridViewProperties.TabIndex = 0;
            this.dataGridViewProperties.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProperties_CellMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.Name = "number";
            this.number.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Назва характеристики";
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.Width = 500;
            // 
            // bindingNavigatorComplex
            // 
            this.bindingNavigatorComplex.AddNewItem = null;
            this.bindingNavigatorComplex.CountItem = null;
            this.bindingNavigatorComplex.DeleteItem = null;
            this.bindingNavigatorComplex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.editToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.deleteToolStripButton});
            this.bindingNavigatorComplex.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorComplex.MoveFirstItem = null;
            this.bindingNavigatorComplex.MoveLastItem = null;
            this.bindingNavigatorComplex.MoveNextItem = null;
            this.bindingNavigatorComplex.MovePreviousItem = null;
            this.bindingNavigatorComplex.Name = "bindingNavigatorComplex";
            this.bindingNavigatorComplex.PositionItem = null;
            this.bindingNavigatorComplex.Size = new System.Drawing.Size(602, 25);
            this.bindingNavigatorComplex.TabIndex = 4;
            this.bindingNavigatorComplex.Text = "bindingNavigator2";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.RightToLeftAutoMirrorImage = true;
            this.addToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addToolStripButton.Text = "Додати";
            this.addToolStripButton.ToolTipText = "Додати";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton_Click);
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
            // ComplProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(602, 486);
            this.Controls.Add(this.bindingNavigatorComplex);
            this.Controls.Add(this.dataGridViewProperties);
            this.Name = "ComplProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Характеристики комплексу";
            this.Load += new System.EventHandler(this.ComplProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorComplex)).EndInit();
            this.bindingNavigatorComplex.ResumeLayout(false);
            this.bindingNavigatorComplex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProperties;
        private System.Windows.Forms.BindingNavigator bindingNavigatorComplex;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}