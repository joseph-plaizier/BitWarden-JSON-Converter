using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitWarden_JSON
{
    public partial class Hide_Columns : Form
    {

        //create bitWarden object for items
        Item bitItem;
        BindingSource bindingsource = new BindingSource();
        bool[] cVisibility;
        ArrayList columns = new ArrayList();
        public Hide_Columns(Rootobject bitItem, DataGridView grid)
        {
            //save object from parameters to created object
            Type type = typeof(Item);

            InitializeComponent();
            //get the column headers as checkbox items
            foreach (var prop in type.GetProperties())
            {
                //MessageBox.Show(prop.PropertyType.ToString(), "Test", MessageBoxButtons.OK);
                if (!(prop.PropertyType.IsArray))
                {
                    checkedListBox1.Items.Add(prop.Name);
                    columns.Add(prop.Name);
                }
            }
            //check if the column is visible and set it as checked or not when the form opens
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (grid.Columns[i].Visible) //volumn visible on form
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                else
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        } // end constructor

        private void hcCancel_Click(object sender, EventArgs e)
        {
            //cancel button pushed
            this.Close();
        }

        public void hcOK_Click(object sender, EventArgs e)
        {
            //ok button pushed
            //create array to hold values for columns (true = show; false = hide)
            cVisibility = new bool[checkedListBox1.Items.Count];

            //check which values are selected to show/hide columns
            for (int i = 0;i < checkedListBox1.Items.Count;i++)
            {
                if (checkedListBox1.GetItemChecked(i)) //checked
                {
                    cVisibility[i] = true;
                }
                else //unchecked
                {
                    cVisibility[i] = false;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public bool[] getColumns() => cVisibility;
        public ArrayList getColumnNames() => columns;
    }
}
