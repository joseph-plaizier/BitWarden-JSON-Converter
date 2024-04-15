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
        public Hide_Columns(Rootobject bitItem)
        {
            //save object from parameters to created object
            Type type = typeof(Item);
            
            InitializeComponent();
            //get the column headers as checkbox items
            foreach(var prop in type.GetProperties())
            {
                //MessageBox.Show(prop.PropertyType.ToString(), "Test", MessageBoxButtons.OK);
                if (!(prop.PropertyType.IsArray))
                {
                    checkedListBox1.Items.Add(prop.Name);
                }
            }
            //set all of the checkedlist items to checked by default
            for(int i = 0; i< checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            
        }
    }
}
