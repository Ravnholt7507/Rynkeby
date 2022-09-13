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
using Microsoft.VisualBasic.FileIO;


namespace Rynkeby
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateMyListView(listView1);

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            selectrandoms(listView1,5);
        }        
        private void PopulateMyListView(ListView listView1)
        {
            // if you call this method multiple times, don't forget to remove the olds rows
            listView1.Items.Clear();

            var path = @"C:\Universitet\Privat\testfil.csv";

            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { ";" });
                csvParser.HasFieldsEnclosedInQuotes = true;


                //skipper kolloner
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    //læser linje og pointer bevaeger sig til næste linje 
                    string[] fields = csvParser.ReadFields();

                    ListViewItem row = new ListViewItem();
                    row.SubItems.Add(fields[0]);
                    row.SubItems.Add(fields[1]);
                    row.SubItems.Add(fields[2]);
                    row.SubItems.Add(fields[3]);
                    row.SubItems.Add(fields[4]);
                    row.SubItems.Add(fields[5]);
                    row.SubItems.Add(fields[6]);
                    row.SubItems.Add(fields[7]);
                    row.SubItems.Add(fields[8]);
                    row.SubItems.Add(fields[9]);
                    row.SubItems.Add(fields[10]);
                    row.SubItems.Add(fields[11]);
                    row.SubItems.Add(fields[12]);
                    row.SubItems.Add(fields[13]);

                    listView1.Items.Add(row);

                }
            }
        }

        private void selectrandoms(ListView listView1, int numberOfRandoms)
        {
            List<string> Event = new List<string>();
            List<string> Currency = new List<string>();
            List<string> Ammount = new List<string>();
            List<string> DateAndTime = new List<string>();
            List<string> customerName = new List<string>();
            List<string> lwitems = new List<string>();
            List<string> lwitems = new List<string>();
            List<string> lwitems = new List<string>();
            List<string> lwitems = new List<string>();
            List<string> lwitems = new List<string>();
            List<string> lwitems = new List<string>();
            List<string> lwitems = new List<string>();
            List<string> lwitems = new List<string>();
            List<string> lwitems = new List<string>();


            foreach (ListViewItem item in listView1.Items)
            {
                lwitems.Add(item.SubItems[0].Text);
               
            }

            List<int> indexOfRandom = new List<int>();
            var random = new Random();
            var lower = 0;
            var upper = test.Length;

            for (int k = 0; k < numberOfRandoms; k++)
            {
                var rannum = random.Next(lower, upper);
                indexOfRandom.Add(rannum);
            }

            foreach (int item in indexOfRandom)
            {
                
            }
        }


     
    }
}
