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
    public partial class Address : Form
    {
        public Address()
        {
            InitializeComponent();
        }

        bool edit = false;
        int selectIndex = -1;
        int selectId = -1;
        CSV address = new CSV(AddressFile.Path);
        CSV flat = new CSV(FlatFile.Path);

        

        private void dataGridViewAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addToolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridViewAddress.ReadOnly = false;
            dataGridViewAddress.Rows.Add();
            int n = dataGridViewAddress.RowCount;
            dataGridViewAddress.Rows[n - 1].Cells[0].Value = n;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "";
                string name = "";
                
                if (edit)
                {
                    id = dataGridViewAddress.Rows[selectIndex].Cells[1].Value.ToString();
                    name = dataGridViewAddress.Rows[selectIndex].Cells[2].Value.ToString();
                    address.Edit(selectId, id + ";" + name + ";");
                }
                else
                {
                    int n = dataGridViewAddress.RowCount - 1;
                    int k = int.Parse(address.lastId());
                    id = (k + 1).ToString();
                    name = dataGridViewAddress.Rows[n].Cells[2].Value.ToString();                    
                    List<string> rowAddress = new List<string>();
                    rowAddress.Add(id);
                    rowAddress.Add(name);                    
                    address.Add(rowAddress);
                }
                dataGridViewAddress.ReadOnly = true;
            }
            catch
            {
            }
        }

        private void dataGridViewAddress_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectIndex = e.RowIndex;
                selectId = int.Parse(dataGridViewAddress.Rows[selectIndex].Cells[1].Value.ToString());                
            }
            catch (Exception r)
            {                                
            }
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridViewAddress.ReadOnly = false;
            edit = true;
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            bool a = false;
            if (selectIndex != -1)
            {
                using (CsvReader csvFlat = flat.connect())
                {
                    while (csvFlat.ReadNextRecord())
                    {
                        if (selectId.ToString() == csvFlat[FlatFile.id_AddressId])
                        {
                            MessageBox.Show("Неможливо видалити, дана адреса використовується!");
                            a = true;
                            break;
                        }
                    }
                }

                if (!a)
                {
                    DialogResult resut = MessageBox.Show("Адреса " + dataGridViewAddress.Rows[selectIndex].Cells[2].Value + " не використовується.\nВидалити?", "Увага!", MessageBoxButtons.YesNo);
                    if (resut == DialogResult.Yes)
                    {
                        address.Remove(selectId);
                        dataGridViewAddress.Rows.RemoveAt(selectIndex);
                    }
                }
            }
        }

        private void Address_Load(object sender, EventArgs e)
        {
            dataGridViewAddress.ReadOnly = true;
            using (CsvReader csv = address.connect())
            {
                int n = csv.FieldCount;
                int i = 0;
                while (csv.ReadNextRecord())
                {
                    dataGridViewAddress.Rows.Add();
                    dataGridViewAddress.Rows[i].Cells[0].Value = i + 1;
                    for (int j = 0; j < n; j++)
                    {
                        dataGridViewAddress.Rows[i].Cells[j + 1].Value = csv[j];
                    }
                    i++;
                }
            }
        }

       
    }
}
