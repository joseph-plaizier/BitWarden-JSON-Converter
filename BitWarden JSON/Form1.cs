using Microsoft.VisualBasic;
using System.Text.Json;

namespace BitWarden_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            string filePath;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //update the text box with the file path
                    textBox1.Text = filePath;
                }
            }

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cancel button clicked; exit
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //save the selected path
            string filePath = textBox1.Text;
            
            try
            {
                //create a new file attributes variable type

                FileAttributes attributes = File.GetAttributes(filePath);

                //check if it's a directory or a file
                if (attributes.ToString().Contains(FileAttributes.Directory.ToString()))
                {
                    //it's a directory
                    throw new Exception("Not a .json file. Try again.");
                }

                else //not a directory, must be a file
                {
                    //check if it's a .json file
                    if ((Path.GetExtension(filePath)) != ".json")
                    {
                        throw new Exception("File is not a .json file.  Please try again.");
                    }
                }
                //MessageBox.Show(attributes.ToString(), "File Content at path: " + filePath, MessageBoxButtons.OK);

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Invalid path", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Not a .json file", MessageBoxButtons.OK);
            }

            //VS2022 creates JSON Classes for you.
            //Highlight JSON, create a new class, delete template code,
            //Edit -> Paste Special -> As JSON

            //get the content of the .json file
            
            //create a new string variable
            string file;
            //read the entire json file and save it to the string variable
            file = File.ReadAllText(filePath);

            
            
            //call JSON Class
            Rootobject? bitWarden = JsonSerializer.Deserialize<Rootobject>(file);

            //output information
            //MessageBox.Show(bitWarden?.encrypted.ToString(), "encrypted", MessageBoxButtons.OK);
            for(int i =0; i< bitWarden.items.Count(); i++)
            {
                Console.WriteLine(bitWarden.items[i]);
            }
            
            Results f2 = new Results(bitWarden);
            
            f2.DataContext = f2;
            f2.ShowDialog();
            

        }
    }
}
