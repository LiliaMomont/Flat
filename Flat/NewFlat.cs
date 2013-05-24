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
    public partial class NewFlat : Form
    {
        public NewFlat()
        {
            InitializeComponent();
        }

        List<data> Complexlist = new List<data>();
        List<data> Addresslist = new List<data>();
        List<data> Typelist = new List<data>();
        List<data> Colorlist = new List<data>();
        CSV flat = new CSV(FlatFile.Path);
        CSV complex = new CSV(ComplexFile.Path);
        CSV address = new CSV(AddressFile.Path);

        string IdAddress = "";
        string IdComplex = "";
       
        struct data
        {
            public string n;
            public string name;
        };


        private void NewFlat_Load(object sender, EventArgs e)
        {
            data data = new data();
            // Load complex in comboBox
            using (CsvReader csv = complex.connect())
            {
                int j = 0;
                while (csv.ReadNextRecord())
                {
                    data.name = csv[ComplexFile.id_Name];
                    data.n = csv[ComplexFile.id_Id];
                    comboBoxComlx.Items.Add(csv[ComplexFile.id_Name]);
                    Complexlist.Add(data);
                    j++;
                }
            }
           
         //    Load address in comboBox
            using (CsvReader csv = address.connect())
            {
                int j = 0;
                while (csv.ReadNextRecord())
                {
                    data.name = csv[ComplexFile.id_Name];
                    data.n = csv[ComplexFile.id_Id];
                    comboBoxAddress.Items.Add(csv[ComplexFile.id_Name]);
                    Addresslist.Add(data);
                    j++;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //add new flat
                List<string> rowFlat = new List<string>();
                int k_complex = int.Parse(flat.lastId());
              //  MessageBox.Show(k_complex.ToString());
                string id_flat = (k_complex + 1).ToString();
                rowFlat.Add(id_flat);
                rowFlat.Add(IdAddress);
                rowFlat.Add(IdComplex);
                rowFlat.Add(textBoxprice1m2.Text);
                rowFlat.Add(textBoxPoverx.Text);
                rowFlat.Add(textBoxSquareGeneraly.Text);
                rowFlat.Add(textBoxSquareLife.Text);
                rowFlat.Add(textBoxPrice.Text);
                rowFlat.Add(textBoxCount.Text);                
                rowFlat.Add(comboBoxCredit.SelectedItem.ToString());
                rowFlat.Add("Ні");
                flat.Add(rowFlat);
                MessageBox.Show("Успішно додано!");                
            }
            catch(Exception t)
            {
                MessageBox.Show("Не вдалося додати запис в БД. Вибачте за неpручності. Виникла помилка: " + t.Message);
            }
        }

        private void comboBoxComlx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string model = "";
            model = comboBoxComlx.SelectedItem.ToString();
            for (int i = 0; i < Complexlist.Count; i++)
            {
                if (model.CompareTo(Complexlist[i].name) == 0)
                {
                    IdComplex = Complexlist[i].n;
                    break;
                }
            }              

        }

        private void comboBoxAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = "";
            type = comboBoxAddress.SelectedItem.ToString();
            for (int i = 0; i < Addresslist.Count; i++)
            {
                if (type.CompareTo(Addresslist[i].name) == 0)
                {
                    IdAddress = Addresslist[i].n;
                    break;
                }
            }           
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
