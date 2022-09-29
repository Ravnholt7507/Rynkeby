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
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Indtast et tal");
            }
            else
            {
                selectrandoms(listView1, textBox1.Text);
            }


        }        
        private void PopulateMyListView(ListView listView1)
        {
            
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

                    ListViewItem row = new ListViewItem(fields[0]);
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


                    listView1.Items.Add(row);

                }
            }
        }

        private void selectrandoms(ListView listView1, string numberOfRandoms)
        {
            listView2.Items.Clear();
            List<string> Event = new List<string>();
            List<string> Currency = new List<string>();
            List<string> Ammount = new List<string>();
            List<string> DateAndTime = new List<string>();
            List<string> customerName = new List<string>();
            List<string> mpnumber = new List<string>();
            List<string> Comment = new List<string>();
            List<string> transactionid = new List<string>();
 
            List<string> paymentpoint = new List<string>();
            List<string> myshopnumber = new List<string>();

            List<string> Date = new List<string>();
            List<string> time = new List<string>();


            foreach (ListViewItem item in listView1.Items)
            {
                Event.Add(item.SubItems[0].Text);
                Currency.Add(item.SubItems[1].Text);
                Ammount.Add(item.SubItems[2].Text);
                DateAndTime.Add(item.SubItems[3].Text);
                customerName.Add(item.SubItems[4].Text);
                mpnumber.Add(item.SubItems[5].Text);
                Comment.Add(item.SubItems[6].Text);
                transactionid.Add(item.SubItems[7].Text);
     
                paymentpoint.Add(item.SubItems[8].Text);
                myshopnumber.Add(item.SubItems[9].Text);
 
                Date.Add(item.SubItems[10].Text);
                time.Add(item.SubItems[11].Text);
            }

            List<int> indexOfRandom = new List<int>();
            var random = new Random();
            var lower = 0;
            var upper = Event.Count;
            int nof = Int32.Parse(numberOfRandoms);
            var csv = new StringBuilder();
            var path = @"C:\Universitet\Privat\output.csv";

            while (indexOfRandom.Count < nof)
            {
                var rannum = random.Next(lower, upper);
                if (!indexOfRandom.Contains(rannum))
                    indexOfRandom.Add(rannum);
                
            }
            listView2.BeginUpdate();
            for (int i = 0; i < nof; i++)
            {
                ListViewItem randomrows = new ListViewItem(Event[i]);
                randomrows.SubItems.Add(Currency[indexOfRandom[i]]);
                randomrows.SubItems.Add(Ammount[indexOfRandom[i]]);
                randomrows.SubItems.Add(DateAndTime[indexOfRandom[i]]);
                randomrows.SubItems.Add(customerName[indexOfRandom[i]]);
                randomrows.SubItems.Add(mpnumber[indexOfRandom[i]]);
                randomrows.SubItems.Add(Comment[indexOfRandom[i]]);
                randomrows.SubItems.Add(transactionid[indexOfRandom[i]]);
                randomrows.SubItems.Add(paymentpoint[indexOfRandom[i]]);
                randomrows.SubItems.Add(myshopnumber[indexOfRandom[i]]);
                randomrows.SubItems.Add(Date[indexOfRandom[i]]);
                randomrows.SubItems.Add(time[indexOfRandom[i]]);
                listView2.Items.Add(randomrows);

                var first = Event[indexOfRandom[i]];
                var second = Currency[indexOfRandom[i]];
                var third = Ammount[indexOfRandom[i]];
                var fourth = DateAndTime[indexOfRandom[i]];
                var fifth = customerName[indexOfRandom[i]];
                var sixth = mpnumber[indexOfRandom[i]];
                var seventh = Comment[indexOfRandom[i]];
                var eighth = transactionid[indexOfRandom[i]];
                var ninth = paymentpoint[indexOfRandom[i]];
                var tenth = myshopnumber[indexOfRandom[i]];
                var eleventh = Date[indexOfRandom[i]];
                var twelveth = time[indexOfRandom[i]];

                var newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11}", first, second, third, fourth, fifth, sixth, seventh, eighth, ninth, tenth, eleventh, twelveth);
                csv.AppendLine(newLine);

                File.WriteAllText(path, csv.ToString());
            }
            listView2.EndUpdate();    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
