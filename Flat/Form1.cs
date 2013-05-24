using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace Flat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CSV properties = new CSV(PropertiesFile.Path);
        CSV flat = new CSV(FlatFile.Path);
        CSV address = new CSV(AddressFile.Path);
        List<data> AddressList = new List<data>();

        string AddressId = "";
        struct data
        {
            public string n;
            public string name;
        };

        
        private void ToolStripMenuItemName_Click(object sender, EventArgs e)
        {
            Complex complex = new Complex();
            complex.Show();
        }

        private void ToolStripMenuItemAddress_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.Show();
        }

        private void ToolStripMenuItemProperties_Click(object sender, EventArgs e)
        {
            ComplProperties complProperties = new ComplProperties();
            complProperties.Show();
        }

        private void ToolStripMenuItemNewFlat_Click(object sender, EventArgs e)
        {
            NewFlat newFlat = new NewFlat();
            newFlat.Show();
        }

        private void ToolStripMenuItemView_Click(object sender, EventArgs e)
        {
            ViewFlat view = new ViewFlat();
            view.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            data dataProperties = new data();
            //label5.Text = "Загальна площа, м2 \r\nменше:";
            comboBoxCredit.SelectedIndex = 0;
            using (CsvReader csv = properties.connect())
            {
                int n = csv.FieldCount;
                int i = 0;                
                while (csv.ReadNextRecord())
                {
                    dataGridViewProperties.Rows.Add();                  
                    for (int j = 0; j < n; j++)
                    {
                        dataGridViewProperties.Rows[i].Cells[j].Value = csv[j];
                        dataGridViewProperties.Rows[i].Cells[2].Value= CheckState.Indeterminate;                                              
                    }
                    i++;
                }
            }          

            dataGridViewFlat.Width = Width - 320;
            dataGridViewFlat.Height = Height - 170;

            int width = dataGridViewFlat.Width;
            int count = dataGridViewFlat.Columns.Count-3;
            int sizeCol = width / count-1;
            
            for (int i = 0; i < count; i++)
			{                
                dataGridViewFlat.Columns[i].Width = sizeCol;
			}
                       
            comboBoxAddress.Items.Add("Будь-яка");
            comboBoxAddress.SelectedIndex = 0;
            using (CsvReader csv = address.connect())
            {
                int n = csv.FieldCount;                
                while (csv.ReadNextRecord())
                {
                    dataProperties.name = csv[AddressFile.id_Name];
                    dataProperties.n = csv[AddressFile.id_Id];
                    comboBoxAddress.Items.Add(csv[AddressFile.id_Name]);
                    AddressList.Add(dataProperties);
                }
            }            
            
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            dataGridViewFlat.Rows.Clear();
            using (CsvReader csv = flat.connect())
            {
                int n = csv.FieldCount;
                int i = 0;
                
                while (csv.ReadNextRecord())
                {
                    dataGridViewFlat.Rows.Add();
                    dataGridViewFlat.Rows[i].Cells[0].Value = i + 1;
                    for (int j = 0; j < csv.FieldCount; j++)
                    {
                        dataGridViewFlat.Rows[i].Cells[j + 1].Value = csv[j];
                    }
                    i++;
                }
            }

            // фільтрація по ціні за 1м2
            if (textBoxPrice1m2Form.Text != "" && textBoxPrice1m2To.Text != "")
            {
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (int.Parse(textBoxPrice1m2Form.Text) <= int.Parse(dataGridViewFlat.Rows[j].Cells[4].Value.ToString()) && int.Parse(textBoxPrice1m2To.Text) >= int.Parse(dataGridViewFlat.Rows[j].Cells[4].Value.ToString()))
                    {

                    }
                    else
                        dataGridViewFlat.Rows[j].Visible = false;

                }
            }

            if (textBoxPrice1m2Form.Text == "" && textBoxPrice1m2To.Text != "")
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (int.Parse(textBoxPrice1m2To.Text.ToString()) >= int.Parse(dataGridViewFlat.Rows[j].Cells[4].Value.ToString()))
                    {

                        //  MessageBox.Show("true");
                    }
                    else
                        dataGridViewFlat.Rows[j].Visible = false;
                }

            if (textBoxPrice1m2Form.Text != "" && textBoxPrice1m2To.Text == "")
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (int.Parse(textBoxPrice1m2Form.Text.ToString()) <= int.Parse(dataGridViewFlat.Rows[j].Cells[4].Value.ToString()))// && comboBoxModels.SelectedItem.ToString() != "Будь-яка")
                    {

                        //  MessageBox.Show("true");
                    }
                    else
                        dataGridViewFlat.Rows[j].Visible = false;
                }


            // фільтрація по загальній площі
            if (textBoxSquareGeneraly.Text != "")
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (int.Parse(textBoxSquareGeneraly.Text) < int.Parse(dataGridViewFlat.Rows[j].Cells[6].Value.ToString()))
                    {
                        dataGridViewFlat.Rows[j].Visible = false;
                    }
                }

            if (textBoxSquareLife.Text != "")
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (int.Parse( textBoxSquareLife.Text) < int.Parse( dataGridViewFlat.Rows[j].Cells[7].Value.ToString()))
                    {
                        dataGridViewFlat.Rows[j].Visible = false;
                    }
                }

            if (textBoxCount.Text != "")
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (int.Parse(textBoxCount.Text) != int.Parse(dataGridViewFlat.Rows[j].Cells[9].Value.ToString()))
                    {
                        dataGridViewFlat.Rows[j].Visible = false;
                    }
                }

            if (comboBoxCredit.SelectedItem.ToString() != "Будь-який")
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (comboBoxCredit.SelectedItem.ToString() != dataGridViewFlat.Rows[j].Cells[10].Value.ToString())
                    {
                        dataGridViewFlat.Rows[j].Visible = false;
                    }
                }


            // фільтрація по вартості
            if (textBoxWorthFrom.Text != "" && textBoxWorthTo.Text != "")
            {
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (int.Parse(textBoxWorthFrom.Text) <= int.Parse(dataGridViewFlat.Rows[j].Cells[8].Value.ToString()) && int.Parse(textBoxWorthTo.Text) >= int.Parse(dataGridViewFlat.Rows[j].Cells[8].Value.ToString()))
                    {

                    }
                    else
                        dataGridViewFlat.Rows[j].Visible = false;

                }
            }

            if (textBoxWorthFrom.Text == "" && textBoxWorthTo.Text != "")
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (int.Parse(textBoxWorthTo.Text.ToString()) >= int.Parse(dataGridViewFlat.Rows[j].Cells[8].Value.ToString()))
                    {

                        //  MessageBox.Show("true");
                    }
                    else
                        dataGridViewFlat.Rows[j].Visible = false;
                }

            if (textBoxWorthFrom.Text != "" && textBoxWorthTo.Text == "")
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (int.Parse(textBoxWorthFrom.Text.ToString()) <= int.Parse(dataGridViewFlat.Rows[j].Cells[8].Value.ToString()))
                    {

                        //  MessageBox.Show("true");
                    }
                    else
                        dataGridViewFlat.Rows[j].Visible = false;
                }


            if (textBoxPoverx.Text != "")
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (int.Parse(textBoxPoverx.Text) != int.Parse(dataGridViewFlat.Rows[j].Cells[5].Value.ToString()))
                    {
                        dataGridViewFlat.Rows[j].Visible = false;
                    }
                }
            
            if (comboBoxAddress.SelectedItem.ToString() != "Будь-яка")
            {
                for (int i = 0; i < AddressList.Count; i++)
                {
                    if (comboBoxAddress.SelectedItem.ToString().CompareTo(AddressList[i].name) == 0)
                    {
                        AddressId = AddressList[i].n;
                        break;
                    }
                }
               
                for (int j = 0; j < dataGridViewFlat.Rows.Count; j++)
                {
                    if (AddressId != dataGridViewFlat.Rows[j].Cells[2].Value.ToString())
                    {

                        dataGridViewFlat.Rows[j].Visible = false;
                    }                        
                }
            }
        }

        private void dataGridViewFlat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                AddressId = dataGridViewFlat.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (AddressId != "")
                    using (CsvReader csv = address.connect())
                    {
                        while (csv.ReadNextRecord())
                        {
                            if (AddressId == csv[AddressFile.id_Id])
                            {
                                textBoxAddress.Text = csv[AddressFile.id_Name];
                                break;
                            }

                        }
                    }
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewFlat.Rows.Add();            
        }
        
    
        
    }
}
