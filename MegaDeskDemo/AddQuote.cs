using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskDemo
{   
    public partial class AddQuote : Form
    {
        private DeskQuote deskQuote = new DeskQuote();
        public AddQuote()
        {
            InitializeComponent();
        }

        private void return_to_main()
        {
            var mainMenu = (mainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void GoBack(object sender, EventArgs e)
        {
            return_to_main();
        }

        private void WidthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newWidth;
                bool isNum = Int32.TryParse(input.Text, out newWidth);
                if (isNum)
                {
                    deskQuote.desk.Width = newWidth;
                    WidthErrorProvider.SetError(this.WidthBox, "");
                }
                else
                {
                    WidthErrorProvider.SetError(this.WidthBox, "Enter a number.");
                }
            }
            catch (Exception ex)
            {
                WidthErrorProvider.SetError(this.WidthBox, "Input must be between 24 and 96 inches.");
            }
        }

        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                string newName = input.Text;
                if (newName.Length >= 8)
                {
                    deskQuote.customerName = newName;
                    NameErrorProvider.SetError(this.NameBox, "");
                }
                else
                {
                    NameErrorProvider.SetError(this.NameBox, "Enter a name.");
                }
            }
            catch (Exception ex)
            {
                NameErrorProvider.SetError(this.NameBox, "Input must be 8 characters or more.");
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void DepthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newDepth;
                bool isNum = Int32.TryParse(input.Text, out newDepth);
                if (isNum)
                {
                    deskQuote.desk.Depth = newDepth;
                    DepthErrorProvider.SetError(this.DepthBox, "");
                }
                else
                {
                    DepthErrorProvider.SetError(this.DepthBox, "Enter a number.");
                }
            }
            catch (Exception ex)
            {
                DepthErrorProvider.SetError(this.DepthBox, "Input must be between 24 and 96 inches.");
            }
        }

        private void DrawerBox_Validating(object sender, CancelEventArgs e)
        {
            {
                TextBox input = (TextBox)sender;
                try
                {
                    int newDrawer;
                    bool isNum = Int32.TryParse(input.Text, out newDrawer);
                    if (isNum)
                    {
                        deskQuote.desk.DrawerNumber = newDrawer;
                        DrawerErrorProvider.SetError(this.DrawerInput, "");
                    }
                    else
                    {
                        DrawerErrorProvider.SetError(this.DrawerInput, "Choose a number.");
                    }
                }
                catch (Exception ex)
                {
                    DrawerErrorProvider.SetError(this.DrawerInput, "Input must not be empty.");
                }
            }
        }

        private void ShippingBox_Validating(object sender, CancelEventArgs e)
        {
            {
                TextBox input = (TextBox)sender;
                try
                {
                    int newShipping;
                    bool isNum = Int32.TryParse(input.Text, out newShipping);
                    if (isNum)
                    {
                        deskQuote.desk.ShippingDays = newShipping;
                        ShippingErrorProvider.SetError(this.ShippingComboBox, "");
                    }
                    else
                    {
                        ShippingErrorProvider.SetError(this.ShippingComboBox, "Choose a number.");
                    }
                }
                catch (Exception ex)
                {
                    ShippingErrorProvider.SetError(this.ShippingComboBox, "Input must not be empty.");
                }
            }
        }
    }
}
