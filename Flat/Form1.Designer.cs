namespace Flat
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.житловийКомплексToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemName = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFlat = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewFlat = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewProperties = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.textBoxSquareLife = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCredit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSquareGeneraly = new System.Windows.Forms.TextBox();
            this.textBoxWorthFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrice1m2To = new System.Windows.Forms.TextBox();
            this.textBoxPrice1m2Form = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxWorthTo = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewFlat = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPoverx = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlat)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.житловийКомплексToolStripMenuItem,
            this.ToolStripMenuItemFlat,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1368, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // житловийКомплексToolStripMenuItem
            // 
            this.житловийКомплексToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemName,
            this.ToolStripMenuItemAddress,
            this.ToolStripMenuItemProperties});
            this.житловийКомплексToolStripMenuItem.Name = "житловийКомплексToolStripMenuItem";
            this.житловийКомплексToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.житловийКомплексToolStripMenuItem.Text = "Житловий комплекс";
            // 
            // ToolStripMenuItemName
            // 
            this.ToolStripMenuItemName.Name = "ToolStripMenuItemName";
            this.ToolStripMenuItemName.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItemName.Text = "Назва";
            this.ToolStripMenuItemName.Click += new System.EventHandler(this.ToolStripMenuItemName_Click);
            // 
            // ToolStripMenuItemAddress
            // 
            this.ToolStripMenuItemAddress.Name = "ToolStripMenuItemAddress";
            this.ToolStripMenuItemAddress.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItemAddress.Text = "Адреса";
            this.ToolStripMenuItemAddress.Click += new System.EventHandler(this.ToolStripMenuItemAddress_Click);
            // 
            // ToolStripMenuItemProperties
            // 
            this.ToolStripMenuItemProperties.Name = "ToolStripMenuItemProperties";
            this.ToolStripMenuItemProperties.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItemProperties.Text = "Характеристики";
            this.ToolStripMenuItemProperties.Click += new System.EventHandler(this.ToolStripMenuItemProperties_Click);
            // 
            // ToolStripMenuItemFlat
            // 
            this.ToolStripMenuItemFlat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewFlat,
            this.ToolStripMenuItemView});
            this.ToolStripMenuItemFlat.Name = "ToolStripMenuItemFlat";
            this.ToolStripMenuItemFlat.Size = new System.Drawing.Size(71, 20);
            this.ToolStripMenuItemFlat.Text = "Квартири";
            // 
            // ToolStripMenuItemNewFlat
            // 
            this.ToolStripMenuItemNewFlat.Name = "ToolStripMenuItemNewFlat";
            this.ToolStripMenuItemNewFlat.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItemNewFlat.Text = "Нова";
            this.ToolStripMenuItemNewFlat.Click += new System.EventHandler(this.ToolStripMenuItemNewFlat_Click);
            // 
            // ToolStripMenuItemView
            // 
            this.ToolStripMenuItemView.Name = "ToolStripMenuItemView";
            this.ToolStripMenuItemView.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItemView.Text = "Перегляд";
            this.ToolStripMenuItemView.Click += new System.EventHandler(this.ToolStripMenuItemView_Click);
            // 
            // dataGridViewProperties
            // 
            this.dataGridViewProperties.AllowUserToAddRows = false;
            this.dataGridViewProperties.AllowUserToDeleteRows = false;
            this.dataGridViewProperties.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties.ColumnHeadersVisible = false;
            this.dataGridViewProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.status});
            this.dataGridViewProperties.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewProperties.Name = "dataGridViewProperties";
            this.dataGridViewProperties.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewProperties.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProperties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProperties.Size = new System.Drawing.Size(247, 404);
            this.dataGridViewProperties.TabIndex = 1;
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.Name = "number";
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.number.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Назва";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 200;
            // 
            // status
            // 
            this.status.FalseValue = "0";
            this.status.HeaderText = "Стан";
            this.status.IndeterminateValue = "2";
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.ThreeState = true;
            this.status.TrueValue = "1";
            this.status.Width = 30;
            // 
            // buttonFind
            // 
            this.buttonFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonFind.Location = new System.Drawing.Point(1129, 89);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(192, 23);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Пошук";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Виберіть характеристики житового комплексу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(895, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Адреса";
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(898, 90);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(192, 21);
            this.comboBoxAddress.TabIndex = 6;
            // 
            // textBoxSquareLife
            // 
            this.textBoxSquareLife.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxSquareLife.Location = new System.Drawing.Point(443, 92);
            this.textBoxSquareLife.Name = "textBoxSquareLife";
            this.textBoxSquareLife.Size = new System.Drawing.Size(148, 20);
            this.textBoxSquareLife.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Житлова площа, м2, менше:";
            // 
            // comboBoxCredit
            // 
            this.comboBoxCredit.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCredit.FormattingEnabled = true;
            this.comboBoxCredit.Items.AddRange(new object[] {
            "Будь-який",
            "Так",
            "Ні"});
            this.comboBoxCredit.Location = new System.Drawing.Point(615, 90);
            this.comboBoxCredit.Name = "comboBoxCredit";
            this.comboBoxCredit.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCredit.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Доступність в кредит:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxCount.Location = new System.Drawing.Point(615, 48);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(612, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Кількість кімнат:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Вартість, грн:";
            // 
            // textBoxSquareGeneraly
            // 
            this.textBoxSquareGeneraly.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxSquareGeneraly.Location = new System.Drawing.Point(443, 49);
            this.textBoxSquareGeneraly.Name = "textBoxSquareGeneraly";
            this.textBoxSquareGeneraly.Size = new System.Drawing.Size(148, 20);
            this.textBoxSquareGeneraly.TabIndex = 29;
            // 
            // textBoxWorthFrom
            // 
            this.textBoxWorthFrom.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxWorthFrom.Location = new System.Drawing.Point(776, 48);
            this.textBoxWorthFrom.Name = "textBoxWorthFrom";
            this.textBoxWorthFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxWorthFrom.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Загальна площа, м2, менше:";
            // 
            // textBoxPrice1m2To
            // 
            this.textBoxPrice1m2To.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxPrice1m2To.Location = new System.Drawing.Point(320, 92);
            this.textBoxPrice1m2To.Name = "textBoxPrice1m2To";
            this.textBoxPrice1m2To.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice1m2To.TabIndex = 26;
            // 
            // textBoxPrice1m2Form
            // 
            this.textBoxPrice1m2Form.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxPrice1m2Form.Location = new System.Drawing.Point(320, 49);
            this.textBoxPrice1m2Form.Name = "textBoxPrice1m2Form";
            this.textBoxPrice1m2Form.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice1m2Form.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ціна за 1 м2, грн:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(739, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "До";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(739, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Від";
            // 
            // textBoxWorthTo
            // 
            this.textBoxWorthTo.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxWorthTo.Location = new System.Drawing.Point(776, 91);
            this.textBoxWorthTo.Name = "textBoxWorthTo";
            this.textBoxWorthTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxWorthTo.TabIndex = 39;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAddress.ForeColor = System.Drawing.Color.Red;
            this.textBoxAddress.Location = new System.Drawing.Point(1129, 48);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(192, 20);
            this.textBoxAddress.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1126, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Житловий комплекс";
            // 
            // dataGridViewFlat
            // 
            this.dataGridViewFlat.AllowUserToAddRows = false;
            this.dataGridViewFlat.AllowUserToDeleteRows = false;
            this.dataGridViewFlat.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewFlat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.id,
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
            this.dataGridViewFlat.Location = new System.Drawing.Point(295, 118);
            this.dataGridViewFlat.Name = "dataGridViewFlat";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            this.dataGridViewFlat.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFlat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFlat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlat.Size = new System.Drawing.Size(935, 295);
            this.dataGridViewFlat.TabIndex = 42;
            this.dataGridViewFlat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFlat_CellMouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Від";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(292, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "До";
            // 
            // textBoxPoverx
            // 
            this.textBoxPoverx.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxPoverx.Location = new System.Drawing.Point(898, 47);
            this.textBoxPoverx.Name = "textBoxPoverx";
            this.textBoxPoverx.Size = new System.Drawing.Size(100, 20);
            this.textBoxPoverx.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(895, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Поверх:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // id_address
            // 
            this.id_address.HeaderText = "id_address";
            this.id_address.Name = "id_address";
            this.id_address.Visible = false;
            // 
            // id_complex
            // 
            this.id_complex.HeaderText = "id_copmlex";
            this.id_complex.Name = "id_complex";
            this.id_complex.Visible = false;
            // 
            // price1m2
            // 
            this.price1m2.HeaderText = "Ціна за 1 м2, грн";
            this.price1m2.Name = "price1m2";
            // 
            // poverx
            // 
            this.poverx.HeaderText = "Поверх";
            this.poverx.Name = "poverx";
            this.poverx.Width = 80;
            // 
            // square_generaly
            // 
            this.square_generaly.HeaderText = "Загальна площа, м2";
            this.square_generaly.Name = "square_generaly";
            // 
            // square_life
            // 
            this.square_life.HeaderText = "Житлова площа, м2";
            this.square_life.Name = "square_life";
            // 
            // price
            // 
            this.price.HeaderText = "Вартість, грн";
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // count
            // 
            this.count.HeaderText = "Кількість кімнат";
            this.count.Name = "count";
            // 
            // credit
            // 
            this.credit.HeaderText = "Можливість кредитування";
            this.credit.Name = "credit";
            // 
            // staus
            // 
            this.staus.HeaderText = "Продано";
            this.staus.Name = "staus";
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.допомогаToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1368, 590);
            this.Controls.Add(this.textBoxPoverx);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridViewFlat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxWorthTo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSquareLife);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxCredit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSquareGeneraly);
            this.Controls.Add(this.textBoxWorthFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrice1m2To);
            this.Controls.Add(this.textBoxPrice1m2Form);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridViewProperties);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem житловийКомплексToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemName;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddress;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProperties;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFlat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewFlat;
        private System.Windows.Forms.DataGridView dataGridViewProperties;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.TextBox textBoxSquareLife;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCredit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSquareGeneraly;
        private System.Windows.Forms.TextBox textBoxWorthFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice1m2To;
        private System.Windows.Forms.TextBox textBoxPrice1m2Form;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxWorthTo;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridViewFlat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPoverx;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
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
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
    }
}

