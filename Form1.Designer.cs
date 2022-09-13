
namespace Rynkeby
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.nothing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Currency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dateandtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phonenumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Transactionid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Transferid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Myshopnumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bankaccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nothing,
            this.Event,
            this.Currency,
            this.Amount,
            this.Dateandtime,
            this.Customername,
            this.Phonenumber,
            this.Comment,
            this.Transactionid,
            this.Transferid,
            this.PaymentPoint,
            this.Myshopnumber,
            this.Bankaccount,
            this.Date,
            this.Time});
            this.listView1.HideSelection = false;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1327, 661);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nothing
            // 
            this.nothing.Text = "";
            this.nothing.Width = 0;
            // 
            // Event
            // 
            this.Event.Text = "Event";
            // 
            // Currency
            // 
            this.Currency.Text = "Currency";
            this.Currency.Width = 67;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 64;
            // 
            // Dateandtime
            // 
            this.Dateandtime.Text = "Date and time";
            this.Dateandtime.Width = 121;
            // 
            // Customername
            // 
            this.Customername.Text = "Customer name";
            this.Customername.Width = 125;
            // 
            // Phonenumber
            // 
            this.Phonenumber.Text = "Phone number";
            this.Phonenumber.Width = 134;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 139;
            // 
            // Transactionid
            // 
            this.Transactionid.Text = "Transaction ID";
            this.Transactionid.Width = 112;
            // 
            // Transferid
            // 
            this.Transferid.Text = "Transfer ID";
            this.Transferid.Width = 71;
            // 
            // PaymentPoint
            // 
            this.PaymentPoint.Text = "Payment Point";
            this.PaymentPoint.Width = 91;
            // 
            // Myshopnumber
            // 
            this.Myshopnumber.Text = "My-shop number";
            this.Myshopnumber.Width = 95;
            // 
            // Bankaccount
            // 
            this.Bankaccount.Text = "Bank Account";
            this.Bankaccount.Width = 85;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 46;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Rynkeby Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader nothing;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.ColumnHeader Currency;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Dateandtime;
        private System.Windows.Forms.ColumnHeader Customername;
        private System.Windows.Forms.ColumnHeader Phonenumber;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.ColumnHeader Transactionid;
        private System.Windows.Forms.ColumnHeader Transferid;
        private System.Windows.Forms.ColumnHeader PaymentPoint;
        private System.Windows.Forms.ColumnHeader Myshopnumber;
        private System.Windows.Forms.ColumnHeader Bankaccount;
        private System.Windows.Forms.ColumnHeader Date;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Time;
    }
}

