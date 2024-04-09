using Microsoft.VisualBasic;

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

                    //Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                    //update the text box with the file path
                    textBox1.Text = filePath;

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}
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

            //check if it's a directory or a file
            //create a new file attributes variable type
            try
            {
                FileAttributes attributes = File.GetAttributes(filePath);

                //check if it's a directory or a file
                if (attributes.ToString().Contains(FileAttributes.Directory.ToString()))
                {
                    //it's a directory
                    throw new Exception("Not a .json file. Try again.");
                }
            
            //check if it's a directory or a file
            switch(attributes)
            {
                    case FileAttributes.Directory  : //it's a directory
                                                                               //check if it exists
                        MessageBox.Show(filePath, "Directory", MessageBoxButtons.OK);
                        if (Directory.Exists(filePath))
                        {
                            //throw new Exception("Not a file. Try again.");
                            MessageBox.Show(filePath, "Directory", MessageBoxButtons.OK);
                        }
                        //else
                        //{
                        //    MessageBox.Show(filePath, "File Content at path: " + filePath, MessageBoxButtons.OK);

                       // }
                        //no directories are supported
                        
                    break;
                default: //it's a file
                    //check if it exists
                    if (File.Exists(filePath))
                    {
                        MessageBox.Show(attributes.ToString(), "File Content at path: " + filePath, MessageBoxButtons.OK);
                     
                    }
                    else
                    {
                        MessageBox.Show(attributes.ToString(), "File Content at path: " + filePath, MessageBoxButtons.OK);
                       
                    }
                    break;
            }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Invalid path", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Not a .json file", MessageBoxButtons.OK);
            }

        }
    }
}
