﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitWarden_JSON
{
    public partial class Results : Form
    {
        Rootobject bitwarden;
        BindingSource bindingsource = new BindingSource();
        public Results(Rootobject bitwarden)
        {
            InitializeComponent();
            this.bitwarden = bitwarden;

            //add items from JSON to data grid
            dataGridView1.DataSource = bitwarden.items;
            dataGridView2.DataContext = bitwarden;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //when a cell is selected, pull the necessary information to the other data grids
            //determine the type selected

            //Cell 6 has type
            //int type = 6;
            //int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());

            //get the ID
            string id = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //MessageBox.Show(id.ToString(), "Test", MessageBoxButtons.OK);

            //search through the items object to find the matching ID
            foreach (Item entry in bitwarden.items)
            {
                if (entry.id.ToString() == id)
                {
                    //determine the type
                    //1 = Login; 2 = SecureNote ; 3 = Card ; 4 = Identity
                    int type = entry.type;
                    if (type == 1) //login
                    {
                        //get the login info and display it in datagridview2
                        bindingsource.DataSource = entry.login;
                        //display the login info in datagrid2
                        dataGridView2.DataSource = bindingsource;
                        //MessageBox.Show(entry.login.GetType().ToString(), "Test", MessageBoxButtons.OK);
                    }
                    else if (type == 2) //secure note
                    {
                        bindingsource.DataSource = entry.secureNote;
                        dataGridView2.DataSource = bindingsource;
                        //MessageBox.Show(entry.secureNote.ToString(), "Test", MessageBoxButtons.OK);
                    }
                    else if (type == 3) //card
                    {
                        bindingsource.DataSource = entry.card;
                        dataGridView2.DataSource = bindingsource;
                    }
                    else if (type == 4) //identity
                    {
                        bindingsource.DataSource = entry.identity;
                        dataGridView2.DataSource = bindingsource;
                    }
                    //MessageBox.Show(, "test", MessageBoxButtons.OK);
                    //MessageBox.Show(entry.name, "Test", MessageBoxButtons.OK);
                }
            }

            //Securenote securenote = (Securenote) dataGridView1.CurrentRow.Cells[12].Value;

            //Cell 12 has Secure Note
            //dataGridView2.DataSource = securenote;
        }

        private void Columns_Click(object sender, EventArgs e)
        {
            //when Hide Columns button is pressed...
            //create the dialog box window
            Hide_Columns hideCol = new Hide_Columns(bitwarden, dataGridView1);

            var result = hideCol.ShowDialog();
            if (result == DialogResult.OK) //OK button pressed
            {
                //populate the columns available (seen or unseen) from the data grid
                bool[] showCol = hideCol.getColumns();

                //for each item in the array, show or hide the cooresponding column
                for (int i = 0; i < showCol.Length; i++)
                {
                    if (showCol[i] == false) //unchecked
                    {
                        dataGridView1.Columns[i].Visible = false;
                    }
                    else //checked
                    {
                        dataGridView1.Columns[i].Visible = true;
                    }
                }
            } // end dialog result
        }

        private void showColumns_Click(object sender, EventArgs e)
        {
            //show all columns
            //create Hide_Columns object
            Hide_Columns showCol = new Hide_Columns(bitwarden, dataGridView1);
            ArrayList colNames = new ArrayList();
            //populate the columns available (seen or unseen) from the data grid
            colNames = showCol.getColumnNames();

            //for each item in the array set to show the cooresponding column
            for (int i = 0; i < colNames.Count; i++)
            {
                dataGridView1.Columns[i].Visible = true;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void print_Click(object sender, EventArgs e)
        {
            //when clicked, run combineData, open print dialog
            //run combineData
            combineData();
            // TODO: open print dialog


        }

        private void saveCSV_Click(object sender, EventArgs e)
        {
            //when clicked, run combineData, open save dialog, save as CSV file
            //run combineData
            combineData();
            //TODO: open save dialog
        }

        private void combineData()
        {
            //TODO: clean up this method to ensure it's working
            //will most likely need to add all of the field names manually

            //get field names for secureNote class
            dataGridView1.Columns.Add("secureNoteType","securenote type");
            
            //get field names for identity class


            //get data for card class

            //get data for login class



            //remove columns securenote, identity, card, and login

            dataGridView1.Columns.Remove("secureNoteDataGridViewTextBoxColumn");
            dataGridView1.Columns.Remove("cardDataGridViewTextBoxColumn");
            dataGridView1.Columns.Remove("identityDataGridViewTextBoxColumn");
            dataGridView1.Columns.Remove("loginDataGridViewTextBoxColumn");


            //get the columns for each type of class

            

            //add all the columns into an object/table
            //get the ID
            //string id = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //MessageBox.Show(id.ToString(), "Test", MessageBoxButtons.OK);

            //search through the items object to find the matching ID
            //foreach (Item entry in bitwarden.items)
            //{
                
                
                //add current items to the datatable
                
                //determine the type
                    //1 = Login; 2 = SecureNote ; 3 = Card ; 4 = Identity
                    //int type = entry.type;
                    //if (type == 1) //login
                    //{
                        //get the login info and add it to datatable 3
                        //bindingsource.DataSource = entry.login;
                        //display the login info in datagrid2
                        //dataGridView2.DataSource = bindingsource;
                        //MessageBox.Show(entry.login.GetType().ToString(), "Test", MessageBoxButtons.OK);
                    //}
                    //else if (type == 2) //secure note
                    //{
                        //bindingsource.DataSource = entry.secureNote;
                        //dataGridView2.DataSource = bindingsource;
                        //MessageBox.Show(entry.secureNote.ToString(), "Test", MessageBoxButtons.OK);
                    //}
                    //else if (type == 3) //card
                   //{
                        //bindingsource.DataSource = entry.card;
                        //dataGridView2.DataSource = bindingsource;
                    //}
                    //else if (type == 4) //identity
                    //{
                        //bindingsource.DataSource = entry.identity;
                        //dataGridView2.DataSource = bindingsource;
                    //}
                    //MessageBox.Show(, "test", MessageBoxButtons.OK);
                    //MessageBox.Show(entry.name, "Test", MessageBoxButtons.OK);
                //}
            //}
        }
    }
}
