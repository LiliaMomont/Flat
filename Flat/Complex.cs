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
    public partial class Complex : Form
    {
        public Complex()
        {
            InitializeComponent();
        }
        CSV complex = new CSV(ComplexFile.Path);
        CSV connection = new CSV(ConnectionFile.Path);
        CSV properties = new CSV(PropertiesFile.Path);

        int selectIndex = -1;
        string selectIdCopmlex = "";
        string selectProperties = "";
        string PropertiesId = "";

        List<data> PropertiesList = new List<data>();

        struct data
        {
            public string n;
            public string name;
        };

        private void addComplexToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewName.ReadOnly = false;
            dataGridViewName.Rows.Add();
            int n = dataGridViewName.RowCount;
            dataGridViewName.Rows[n - 1].Cells[0].Value = n;
        }

        private void saveComplextoolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewName.ReadOnly = true;
            int n = dataGridViewName.RowCount - 1;
            int k = int.Parse(complex.lastId());
            string id = (k + 1).ToString();
            string name = dataGridViewName.Rows[n].Cells[2].Value.ToString();
            List<string> rowCopmlex = new List<string>();
            rowCopmlex.Add(id);
            rowCopmlex.Add(name);
            complex.Add(rowCopmlex);
        }

        private void dataGridViewName_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                listBoxProperties.Items.Clear();
                comboBoxProperties.Items.Clear();
                selectIndex = e.RowIndex;                
                selectIdCopmlex = dataGridViewName.Rows[selectIndex].Cells[1].Value.ToString();
               
                using (CsvReader csv = connection.connect())
                {                                
                    while (csv.ReadNextRecord())
                    {
                        if (csv[ConnectionFile.id_ComplexId] == selectIdCopmlex)
                        {
                            PropertiesId = csv[ConnectionFile.id_Properties];                            
                            using (CsvReader csvProperties = properties.connect())
                            {
                                while (csvProperties.ReadNextRecord())
                                {
                                    if (csvProperties[PropertiesFile.id_Id] == PropertiesId)
                                    {
                                        listBoxProperties.Items.Add(csvProperties[PropertiesFile.id_Name]);
                                    }
                                }
                            }                                                       
                        }
                    }
                }

                using (CsvReader csv = properties.connect())
                 {
                     while (csv.ReadNextRecord())
                     {
                         string name = csv[PropertiesFile.id_Name];
                         // for (int i = 0; i < listBoxProperties.Items.Count; i++)
                         // {
                         if (!listBoxProperties.Items.Contains(name))
                         {
                             comboBoxProperties.Items.Add(name);
                         }
                         // }
                     }
                }


            }
            catch
            {

            }
        }

        private void Complex_Load(object sender, EventArgs e)
        {
            using (CsvReader csv = complex.connect())
            {
                int n = csv.FieldCount;
                int i = 0;
                while (csv.ReadNextRecord())
                {
                    dataGridViewName.Rows.Add();
                    dataGridViewName.Rows[i].Cells[0].Value = i + 1;
                    for (int j = 0; j < n; j++)
                    {
                        dataGridViewName.Rows[i].Cells[j + 1].Value = csv[j];
                    }
                    i++;
                }
            }

            using (CsvReader csv = properties.connect())
            {
                data dataProperties = new data();
                while (csv.ReadNextRecord())
                {
                    dataProperties.name = csv[PropertiesFile.id_Name];
                    dataProperties.n = csv[PropertiesFile.id_Id];
                    PropertiesList.Add(dataProperties);
                }
            }
        }

        private void addPropertiesToolStripButton_Click(object sender, EventArgs e)
        {           
            string name = comboBoxProperties.SelectedItem.ToString();                       
            listBoxProperties.Items.Add(name);

            int k = int.Parse(connection.lastId());
            string id_con = (k + 1).ToString();
            string id_complex = selectIdCopmlex;
            string id_properties = PropertiesId;
            List<string> rowConnection = new List<string>();
            rowConnection.Add(id_con);
            rowConnection.Add(id_complex);
            rowConnection.Add(id_properties);
            connection.Add(rowConnection);
        }

        private void comboBoxProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Properties = "";
            Properties = comboBoxProperties.SelectedItem.ToString();
            for (int i = 0; i < PropertiesList.Count; i++)
            {
                if (Properties.CompareTo(PropertiesList[i].name) == 0)
                {
                    PropertiesId = PropertiesList[i].n;
                    break;
                }
            }
        }

        private void deletePropertiesToolStripButton_Click(object sender, EventArgs e)
        {
            bool a = false;
            selectProperties = listBoxProperties.SelectedItem.ToString();           
            for (int i = 0; i < PropertiesList.Count; i++)
            {
                if (selectProperties.CompareTo(PropertiesList[i].name) == 0)
                {
                    PropertiesId = PropertiesList[i].n;
                    break;
                }
            }
            string id = "";
            using (CsvReader csv = connection.connect())
            {
                while (csv.ReadNextRecord())
                {
                    if (PropertiesId == csv[ConnectionFile.id_Properties] && selectIdCopmlex == csv[ConnectionFile.id_ComplexId])
                    {                       
                        id = csv[ConnectionFile.id_Id];
                        break;
                    }
                }
            }                      
            
            DialogResult resut = MessageBox.Show("Видалити " + selectProperties + "?", "Увага!", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {
                connection.Remove(int.Parse(id));
                listBoxProperties.Items.Remove(selectProperties);
            }            
        }

        
    }
}
