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
    public partial class ComplProperties : Form
    {
        public ComplProperties()
        {
            InitializeComponent();
        }

        int selectIndex = -1;
        int selectId = -1;        
        CSV properties = new CSV(PropertiesFile.Path);
        CSV connection = new CSV(ConnectionFile.Path);
        //CSV car = new CSV(CarFile.Path);
        bool edit = false;    
     

        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewProperties.ReadOnly = false;
            dataGridViewProperties.Rows.Add();
            int n = dataGridViewProperties.RowCount;
            dataGridViewProperties.Rows[n - 1].Cells[0].Value = n;
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewProperties.ReadOnly = false;
            edit = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "";
                string name = "";                
                if (edit)
                {
                    id = dataGridViewProperties.Rows[selectIndex].Cells[1].Value.ToString();
                    name = dataGridViewProperties.Rows[selectIndex].Cells[2].Value.ToString();
                    properties.Edit(selectId, id + ";" + name + ";");
                }
                else
                {
                    int n = dataGridViewProperties.RowCount - 1;
                    int k = int.Parse(properties.lastId());
                    id = (k + 1).ToString();
                    name = dataGridViewProperties.Rows[n].Cells[2].Value.ToString();                   
                    List<string> rowProperties = new List<string>();
                    rowProperties.Add(id);
                    rowProperties.Add(name);
                    properties.Add(rowProperties);
                }
                dataGridViewProperties.ReadOnly = true;
            }
            catch
            {
            }
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            bool a = false;
            if (selectIndex != -1)
            {
                using (CsvReader csv = connection.connect())
                {
                    while (csv.ReadNextRecord())
                    {
                        if (selectId.ToString() == csv[ConnectionFile.id_Properties])
                        {
                            MessageBox.Show("Неможливо видалити, дана характеристика використовується!");
                            a = true;
                            break;
                        }
                    }
                }

                if (!a)
                {
                    DialogResult resut = MessageBox.Show("Характеристика " + dataGridViewProperties.Rows[selectIndex].Cells[2].Value + " не використовується.\nВидалити?", "Увага!", MessageBoxButtons.YesNo);
                    if (resut == DialogResult.Yes)
                    {
                        properties.Remove(selectId);
                        dataGridViewProperties.Rows.RemoveAt(selectIndex);
                    }
                }
            }
        }

        private void ComplProperties_Load(object sender, EventArgs e)
        {
            dataGridViewProperties.ReadOnly = true;
            using (CsvReader csv =properties.connect())
            {
                int n = csv.FieldCount;
                int i = 0;
                while (csv.ReadNextRecord())
                {
                    dataGridViewProperties.Rows.Add();
                    dataGridViewProperties.Rows[i].Cells[0].Value = i + 1;
                    for (int j = 0; j < n; j++)
                    {
                        dataGridViewProperties.Rows[i].Cells[j + 1].Value = csv[j];
                    }
                    i++;
                }
            }
        }

        private void dataGridViewProperties_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectIndex = e.RowIndex;
                selectId = int.Parse(dataGridViewProperties.Rows[selectIndex].Cells[1].Value.ToString());
            }
            catch (Exception r)
            {
            }
        }

        //bool a = false;
        //    selectProperties = comboBoxProperties.SelectedItem.ToString();

        //    for (int i = 0; i < PropertiesList.Count; i++)
        //    {
        //        if (selectProperties.CompareTo(PropertiesList[i].name) == 0)
        //        {
        //            PropertiesId = PropertiesList[i].n;
        //            break;
        //        }
        //    }

        //        using (CsvReader csv = connection.connect())
        //        {
        //            while (csv.ReadNextRecord())
        //            {
        //                if (PropertiesId == csv[ConnectionFile.id_Properties])
        //                {
        //                    MessageBox.Show("Неможливо видалити, даний автосалон використовується!");
        //                    a = true;
        //                    break;
        //                }
        //            }
        //        }

        //        if (!a)
        //        {
        //            DialogResult resut = MessageBox.Show("Автосалон " + selectProperties + " не використовується.\nВидалити?", "Увага!", MessageBoxButtons.YesNo);
        //            if (resut == DialogResult.Yes)
        //            {
        //                properties.Remove(int.Parse(PropertiesId));
        //                comboBoxProperties.Items.Remove(selectProperties);
        //            }
        //        }
    }
}
