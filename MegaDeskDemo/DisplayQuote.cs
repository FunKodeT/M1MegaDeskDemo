using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskDemo
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote DeskQuote = new DeskQuote();
        public DisplayQuote(DeskQuote deskQuote)
        {
            DeskQuote = deskQuote;
            InitializeComponent();
            Console.WriteLine("Customer Name: " + deskQuote.customerName);
        }
        private void return_to_main()
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            Close();
        }
        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            return_to_main();
        }
        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            CustomerName.Text = DeskQuote.customerName;
            Console.WriteLine("Sender" + sender.GetType());
            QuoteDate.Text = DeskQuote.orderDate;
            string width = Convert.ToString(DeskQuote.desk.Width);
            Console.WriteLine("Width:" + width);
            string depth = Convert.ToString(DeskQuote.desk.Depth);
            string drawers = Convert.ToString(DeskQuote.desk.DrawerNumber);
            string shippingDays = Convert.ToString(DeskQuote.desk.ShippingDays);
            string material = DeskQuote.desk.Material;
            int surfaceTotal = DeskQuote.desk.Width * DeskQuote.desk.Depth;

            string total = Convert.ToString(surfaceTotal);

            WidthLabel.Text = width;
            DepthLabel.Text = depth;
            DrawerLabel.Text = drawers + " drawers";
            TotalSizeLabel.Text = total + " in^2";
            MaterialLabel.Text = material;
            DeliveryLabel.Text = shippingDays + " days";
        }
    }
}
