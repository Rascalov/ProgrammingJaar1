using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIOFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    var fileStream2 = fileStream;
                    string text = "";
                    int counter = 0;

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        while (reader.ReadLine() != null)
                        {
                            counter++;
                        }
                        reader.ReadLine(null);
                    }

                    using (StreamReader reader2 = new StreamReader(fileStream2))
                    {
                        for (int i = 0; i < counter; i++)
                        {
                            text = text + reader2.ReadLine() + "\n";
                        }
                    }
                    
                        
                    lblOutput.Text = text;
                }
            }   

        }

                
                

                    
                        
                
                
                

                        
                      


                      
                    
                   
                
        

          //  MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);



        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
