using System;
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
using DGVPrinterHelper;

namespace BitWarden_JSON
{
    public partial class Results : Form
    {
        Rootobject bitwarden;
        BindingSource bindingsource = new BindingSource();
        // Declare the PrintDocument object.
        private System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();
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

            //create DataGrid View Printer object
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "DataGridView Report";

            printer.SubTitle = "An Easy to Use DataGridView Printing Object";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | 

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "Your Company Name Here";

            printer.FooterSpacing = 15;

            printer.PrintPreviewDataGridView(dataGridView1);

            printer.PrintDataGridView(dataGridView1);



            // Set the Document property to the PrintDocument for 
            // which the PrintPage Event has been handled. To display the
            // dialog, either this property or the PrinterSettings property 
            // must be set 
            //printDialog1.Document = docToPrint;

            //DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            //if (result == DialogResult.OK)
            //{
            //    docToPrint.Print();
            //}
        }

        // The PrintDialog will print the document
        // by handling the document's PrintPage event.

        void export_csv(string file, DataGridView grid)
        {
            using (StreamWriter csv = new StreamWriter(file, false))
            {
                int totalcolms = grid.ColumnCount;
                //add headers to csv file
                foreach (DataGridViewColumn colm in grid.Columns) csv.Write(colm.HeaderText + ',');
                //go to next(first) row under headers
                csv.Write('\n');
                //create cell data variable and set it to null/empty
                string data = "";
                foreach (DataGridViewRow row in grid.Rows)
                {
                    //if it's an empty row continue with the remainder of the code
                    if (row.IsNewRow) 
                        continue;
                    data = "";
                    for (int i = 0; i < totalcolms; i++)
                    {
                        //look at each column and set the value to a string in the data variable
                        //TODO: This next line is separating out the notes portion of some of the records.
                        data += (row.Cells[i].Value ?? "").ToString() + ',';
                    }
                    //if (data != string.Empty) csv.WriteLine(data);
                    csv.WriteLine(data);
                }
            }

        }

        private void saveCSV_Click(object sender, EventArgs e)
        {
            //when clicked, run combineData, open save dialog, save as CSV file
            //run combineData
            combineData();
            //TODO: open save dialog
            export_csv(@"C:\Users\cantc\Downloads\csv-export.csv", dataGridView1);
        }

        private void combineData()
        {
            //get field names for password history class
            addColumns("Passwordhistory", "Password History");

            //get field names for secureNote class
            addColumns("Securenote", "Secure Note");

            //get field names for identity class
            addColumns("Identity", "Identity");

            //get data for card class
            addColumns("Card", "Card");

            //get data for login class
            addColumns("Login", "Login");

            //get data for Uri class
            addColumns("Uri", "Login Uri");

            //fill in datagrid with correct data
            //get the ID

            //search through the items object to find the matching ID
            int count = 0;
            foreach (Item entry in bitwarden.items)
            {
                int index = -1;
                //determine the type
                //1 = Login; 2 = SecureNote ; 3 = Card ; 4 = Identity
                int type = entry.type;
                if (type == 1) //login
                {
                    Login loginData = entry.login;
                    Uri[] uriData = loginData.uris;
                    //get the login info and enter it into datagrid1
                    //loginfido2Credentials
                    index = getColumnIndex("loginfido2Credentials");
                    dataGridView1[index, count].Value = loginData.fido2Credentials;
                    //login uri
                    var uriMatch = "";
                    var uriUri = "";
                    foreach(Uri uri in uriData)
                    {
                        uriMatch += $"{uri.match},";
                        uriUri += $"{uri.uri},";
                    }
                    index = getColumnIndex("urimatch");
                    dataGridView1[index, count].Value = uriMatch;
                    index = getColumnIndex("uriuri");
                    dataGridView1[index, count].Value = uriUri;
                    //username
                    index = getColumnIndex("loginusername");
                    dataGridView1[index, count].Value = loginData.username;
                    //password
                    index = getColumnIndex("loginpassword");
                    dataGridView1[index, count].Value = loginData.password;
                    //totp
                    index = getColumnIndex("logintotp");
                    dataGridView1[index, count].Value = loginData.totp;

                }
                else if (type == 2) //secure note
                {
                    Securenote securenote = entry.secureNote;
                    //type
                    index = getColumnIndex("securenotetype");
                    dataGridView1[index, count].Value = securenote.type;
                }
                else if (type == 3) //card
                {
                    Card card = entry.card;
                    //cardholderName
                    index = getColumnIndex("cardcardholderName");
                    dataGridView1[index, count].Value = card.cardholderName;
                    //brand
                    index = getColumnIndex("cardbrand");
                    dataGridView1[index, count].Value = card.brand;
                    //number
                    index = getColumnIndex("cardnumber");
                    dataGridView1[index, count].Value = card.number;
                    //expMonth
                    index = getColumnIndex("cardexpMonth");
                    dataGridView1[index, count].Value = card.expMonth;
                    //expYear
                    index = getColumnIndex("cardexpYear");
                    dataGridView1[index, count].Value = card.expYear;
                    //code
                    index = getColumnIndex("cardcode");
                    dataGridView1[index, count].Value = card.code;
                }
                else if (type == 4) //identity
                {
                    Identity identity = entry.identity;
                    //title
                    index = getColumnIndex("identitytitle");
                    dataGridView1[index, count].Value = identity.title;
                    //firstName
                    index = getColumnIndex("identityfirstName");
                    dataGridView1[index, count].Value = identity.firstName;
                    //middleName
                    index = getColumnIndex("identitymiddleName");
                    dataGridView1[index, count].Value = identity.middleName;
                    //lastName
                    index = getColumnIndex("identitylastName");
                    dataGridView1[index, count].Value = identity.lastName;
                    //address1
                    index = getColumnIndex("identityaddress1");
                    dataGridView1[index, count].Value = identity.address1;
                    //address2
                    index = getColumnIndex("identityaddress2");
                    dataGridView1[index, count].Value = identity.address2;
                    //address3
                    index = getColumnIndex("identityaddress3");
                    dataGridView1[index, count].Value = identity.address3;
                    //city
                    index = getColumnIndex("identitycity");
                    dataGridView1[index, count].Value = identity.city;
                    //state
                    index = getColumnIndex("identitystate");
                    dataGridView1[index, count].Value = identity.state;
                    //postalCode
                    index = getColumnIndex("identitypostalCode");
                    dataGridView1[index, count].Value = identity.postalCode;
                    //country
                    index = getColumnIndex("identitycountry");
                    dataGridView1[index, count].Value = identity.country;
                    //company
                    index = getColumnIndex("identitycompany");
                    dataGridView1[index, count].Value = identity.company;
                    //email
                    index = getColumnIndex("identityemail");
                    dataGridView1[index, count].Value = identity.email;
                    //phone
                    index = getColumnIndex("identityphone");
                    dataGridView1[index, count].Value = identity.phone;
                    //ssn
                    index = getColumnIndex("identityssn");
                    dataGridView1[index, count].Value = identity.ssn;
                    //username
                    index = getColumnIndex("identityusername");
                    dataGridView1[index, count].Value = identity.username;
                    //passportNumber
                    index = getColumnIndex("identitypassportNumber");
                    dataGridView1[index, count].Value = identity.passportNumber;
                    //licenseNumber
                    index = getColumnIndex("identitylicenseNumber");
                    dataGridView1[index, count].Value = identity.licenseNumber;
                }
                
                //check if password history has some data
                if(entry.passwordHistory != null)
                {
                    Passwordhistory[] passwordhistory = entry.passwordHistory;
                    var lastUsedDate = "";
                    var password = "";
                    foreach (Passwordhistory record in passwordhistory)
                    {
                        lastUsedDate += $"{record.lastUsedDate},";
                        password += $"{record.password},";
                    }
                    index = getColumnIndex("passwordhistorylastUsedDate");
                    dataGridView1[index, count].Value = lastUsedDate;
                    index = getColumnIndex("passwordhistorypassword");
                    dataGridView1[index, count].Value = password;
                }
                count++;
            } //end foreach

            //remove columns securenote, identity, card, and login
            dataGridView1.Columns.Remove("secureNoteDataGridViewTextBoxColumn");
            dataGridView1.Columns.Remove("cardDataGridViewTextBoxColumn");
            dataGridView1.Columns.Remove("identityDataGridViewTextBoxColumn");
            dataGridView1.Columns.Remove("loginDataGridViewTextBoxColumn");
            dataGridView1.Columns.Remove("loginuris");
        }

        private void addColumns(string className, string columnName)
        {
            //get field names for passwordhistory class
            PropertyInfo[] properties;
            properties = Type.GetType(className).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                //MessageBox.Show($"Securenote properties are: {prop.Name}", "test", MessageBoxButtons.OK);
                dataGridView1.Columns.Add($"{className}{prop.Name}", $"{columnName} {prop.Name}");
            }
        }

        private int getColumnIndex(string columnName)
        {
            int index = -1;
            var dataGridViewColumn = dataGridView1.Columns[$"{columnName}"];
            if (dataGridViewColumn != null)
            {
                index = dataGridView1.Columns.IndexOf(dataGridViewColumn);
                return index;
            }
            return index;
        }
    }
}
