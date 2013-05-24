namespace Flat
{
    partial class Address
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Address));
            this.dataGridViewAddress = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddress = new System.Windows.Forms.BindingNavigator(this.components);
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAddress)).BeginInit();
            this.bindingNavigatorAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAddress
            // 
            this.dataGridViewAddress.AllowUserToAddRows = false;
            this.dataGridViewAddress.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.number,
            this.name});
            this.dataGridViewAddress.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewAddress.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewAddress.Name = "dataGridViewAddress";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.dataGridViewAddress.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddress.Size = new System.Drawing.Size(493, 334);
            this.dataGridViewAddress.TabIndex = 0;
            this.dataGridViewAddress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddress_CellContentClick);
            this.dataGridViewAddress.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAddress_CellMouseClick);
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
            this.name.HeaderText = "Назва";
            this.name.Name = "name";
            this.name.Width = 400;
            // 
            // bindingNavigatorAddress
            // 
            this.bindingNavigatorAddress.AddNewItem = null;
            this.bindingNavigatorAddress.CountItem = null;
            this.bindingNavigatorAddress.DeleteItem = null;
            this.bindingNavigatorAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.editToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.deleteToolStripButton});
            this.bindingNavigatorAddress.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorAddress.MoveFirstItem = null;
            this.bindingNavigatorAddress.MoveLastItem = null;
            this.bindingNavigatorAddress.MoveNextItem = null;
            this.bindingNavigatorAddress.MovePreviousItem = null;
            this.bindingNavigatorAddress.Name = "bindingNavigatorAddress";
            this.bindingNavigatorAddress.PositionItem = null;
            this.bindingNavigatorAddress.Size = new System.Drawing.Size(502, 25);
            this.bindingNavigatorAddress.TabIndex = 4;
            this.bindingNavigatorAddress.Text = "bindingNavigator2";
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
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton1_Click);
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
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(502, 370);
            this.Controls.Add(this.bindingNavigatorAddress);
            this.Controls.Add(this.dataGridViewAddress);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Address";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Адреси житлових комплексів";
            this.Load += new System.EventHandler(this.Address_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAddress)).EndInit();
            this.bindingNavigatorAddress.ResumeLayout(false);
            this.bindingNavigatorAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAddress;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAddress;
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