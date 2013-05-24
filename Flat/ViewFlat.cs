using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;
using System.IO;

namespace Flat
{
    public partial class ViewFlat : Form
    {
        public ViewFlat()
        {
            InitializeComponent();
        }

        List<data> Complexlist = new List<data>();
        List<data> Addresslist = new List<data>();
        List<data> Flatlist = new List<data>();
        //List<data> Colorlist = new List<data>();
        CSV flat = new CSV(FlatFile.Path);
        CSV complex = new CSV(ComplexFile.Path);
        CSV address = new CSV(AddressFile.Path);
        string[,] str;
        string IdAddress = "";
        string IdComplex = "";
        int selectIndex = -1;
        int selectId = -1;
        struct data
        {
            public string n;
            public string name;
        };

        private void ViewFlat_Load(object sender, EventArgs e)
        {
            data data = new data();
            // Load complex in comboBox
            using (CsvReader csv = complex.connect())
            {              
                while (csv.ReadNextRecord())
                {
                    data.name = csv[ComplexFile.id_Name];
                    data.n = csv[ComplexFile.id_Id];
                    comboBoxComplex.Items.Add(csv[ComplexFile.id_Name]);
                    Complexlist.Add(data);                                       
                }
            }
        }

        private void comboBoxComplex_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewFlat.Rows.Clear();
            string SelectedComplex = "";            
            SelectedComplex = comboBoxComplex.SelectedItem.ToString();
            for (int i = 0; i < Complexlist.Count; i++)
            {
                if (SelectedComplex.CompareTo(Complexlist[i].name) == 0)
                {
                    IdComplex = Complexlist[i].n;
                    break;
                }
            }           

            using (CsvReader csv = flat.connect())
            {
                int i = 0;
                while (csv.ReadNextRecord())
                {                  
                    if (csv[FlatFile.id_ComplexId] == IdComplex && IdComplex != "")
                    {
                        IdAddress = csv[FlatFile.id_AddressId];
                        dataGridViewFlat.Rows.Add();
                        dataGridViewFlat.Rows[i].Cells[0].Value = i + 1;
                        for (int j = 0; j < csv.FieldCount; j++)
                        {
                            dataGridViewFlat.Rows[i].Cells[j + 1].Value = csv[j].ToString();
                        }
                        i++;
                    }                    
                }
            }
           
            using (CsvReader csv = address.connect())
            {                
                while (csv.ReadNextRecord())
                {
                    if (csv[AddressFile.id_Id] == IdAddress && IdAddress != "")
                    {
                        textBoxAddress.Text = csv[AddressFile.id_Name];
                    }
                }
            }

        }

        private void textBoxFind_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxFind.Text = "";
        }

        private void dataGridViewFlat_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("Адреса", "fgh");
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            string id = "";
            if (selectIndex != -1)
            {
                using (CsvReader csvFlat = flat.connect())
                {
                    while (csvFlat.ReadNextRecord())
                    {
                        if (selectId.ToString() == csvFlat[FlatFile.id_Id])
                        {
                            id = csvFlat[FlatFile.id_Id];
                            break;
                        }
                    }                    
                }
                DialogResult resut = MessageBox.Show("Видалити квартиру?", "Увага!", MessageBoxButtons.YesNo);
                if (resut == DialogResult.Yes)
                {
                    flat.Remove(int.Parse(id));
                    dataGridViewFlat.Rows.RemoveAt(selectIndex);
                }
            }
        }

        private void dataGridViewFlat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectIndex = e.RowIndex;
                selectId = int.Parse(dataGridViewFlat.Rows[selectIndex].Cells[1].Value.ToString());
            }
            catch (Exception r)
            {
            }
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewFlat.ReadOnly = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            string st = "";
            
            for (int i = 1; i < dataGridViewFlat.Columns.Count; i++)
            {
                st += dataGridViewFlat.Rows[selectIndex].Cells[i].Value + ";";
            }           
            flat.Edit(selectId, st);
        }
    }
}
