//Jerry Nava
//CPT-185-A01S
//Test-1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jerry_Nava_CPT_185_Test_1
{
    public partial class Form1 : Form
    {
        const double Lamborghini_Cost = 250000;
        const double Ferrari_Cost = 150000;
        const double Corvette_Cost = 75000;
        const double Automatic_Cost = 2000;
        const double Manual_Cost = 0;
        double subtotal,salestaxrate,total,tax;

        private void clearbutton_Click(object sender, EventArgs e)
        {
            Pricetext.Text = "";
            Transtext.Text = "";
            subtotalbox.Text = "";
            taxBox.Text = "";
            TotalBox.Text = "";
            taxratetextBox.Text = "";
            autoBox.ClearSelected();
            TransBox.ClearSelected();
            label2.Text = "Trans label";
            label4.Text = "Tax Label";
            label8.Text = "Selected Auto";

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            string car, trans;
            try
            {
                car = autoBox.SelectedItem.ToString();
                trans = TransBox.SelectedItem.ToString();
                label8.Text = car;
                if (car == "Lamborghini" && trans == "Manual")
                {
                    Pricetext.Text = Lamborghini_Cost.ToString("c2");
                    Transtext.Text = Manual_Cost.ToString("c2");
                    subtotal = Lamborghini_Cost;
                    subtotalbox.Text = subtotal.ToString("c2");
                    salestaxrate = double.Parse(taxratetextBox.Text);
                    tax = subtotal * (salestaxrate/100);
                    taxBox.Text = tax.ToString("c2");
                    label4.Text = "Sales Tax "+""+taxratetextBox.Text+"%";
                    total = (subtotal * salestaxrate/100) + subtotal;
                    TotalBox.Text = total.ToString("c2");
                    label2.Text = "Manual";
                }

                else if (car == "Lamborghini" && trans == "Automatic")
                {
                    Pricetext.Text = Lamborghini_Cost.ToString("c2");
                    Transtext.Text = Automatic_Cost.ToString("c2");
                    subtotal = Lamborghini_Cost + Automatic_Cost;
                    subtotalbox.Text = subtotal.ToString("c2");
                    subtotalbox.Text = subtotal.ToString("c2");
                    salestaxrate = double.Parse(taxratetextBox.Text);
                    tax = subtotal * (salestaxrate / 100);
                    taxBox.Text = tax.ToString("c2");
                    label4.Text = "Sales Tax " + "" + taxratetextBox.Text + "%";
                    total = (subtotal * salestaxrate / 100) + subtotal;
                    TotalBox.Text = total.ToString("c2");
                    label2.Text = "Automatic:";
                }
                else if (car == "Ferrari" && trans == "Manual")
                {
                    Pricetext.Text = Ferrari_Cost.ToString("c2");
                    Transtext.Text = Manual_Cost.ToString("c2");
                    subtotal = Ferrari_Cost;
                    subtotalbox.Text = subtotal.ToString("c2");
                    subtotalbox.Text = subtotal.ToString("c2");
                    salestaxrate = double.Parse(taxratetextBox.Text);
                    tax = subtotal * (salestaxrate / 100);
                    taxBox.Text = tax.ToString("c2");
                    label4.Text = "Sales Tax " + "" + taxratetextBox.Text + "%";
                    total = (subtotal * salestaxrate / 100) + subtotal;
                    TotalBox.Text = total.ToString("c2");
                    label2.Text = "Manual";
                }
                else if (car == "Ferrari" && trans == "Automatic")
                {
                    Pricetext.Text = Ferrari_Cost.ToString("c2");
                    Transtext.Text = Automatic_Cost.ToString("c2");
                    subtotal = Ferrari_Cost + Automatic_Cost;
                    subtotalbox.Text = subtotal.ToString("c2");
                    subtotalbox.Text = subtotal.ToString("c2");
                    subtotalbox.Text = subtotal.ToString("c2");
                    salestaxrate = double.Parse(taxratetextBox.Text);
                    tax = subtotal * (salestaxrate / 100);
                    taxBox.Text = tax.ToString("c2");
                    label4.Text = "Sales Tax " + "" + taxratetextBox.Text + "%";
                    total = (subtotal * salestaxrate / 100) + subtotal;
                    TotalBox.Text = total.ToString("c2");
                    label2.Text = "Automatic:";
                }

                else if (car == "Corvette" && trans == "Manual")
                {
                    Pricetext.Text = Corvette_Cost.ToString("c2");
                    Transtext.Text = Manual_Cost.ToString("c2");
                    subtotal = Corvette_Cost;
                    subtotalbox.Text = subtotal.ToString("c2");
                    subtotalbox.Text = subtotal.ToString("c2");
                    salestaxrate = double.Parse(taxratetextBox.Text);
                    tax = subtotal * (salestaxrate / 100);
                    taxBox.Text = tax.ToString("c2");
                    label4.Text = "Sales Tax " + "" + taxratetextBox.Text + "%";
                    total = (subtotal * salestaxrate / 100) + subtotal;
                    TotalBox.Text = total.ToString("c2");
                    label2.Text = "Manual";
                }
                else if (car == "Corvette" && trans == "Automatic")
                {
                    Pricetext.Text = Corvette_Cost.ToString("c2");
                    Transtext.Text = Automatic_Cost.ToString("c2");
                    subtotal = Corvette_Cost + Automatic_Cost;
                    subtotalbox.Text = subtotal.ToString("c2");
                    subtotalbox.Text = subtotal.ToString("c2");
                    subtotalbox.Text = subtotal.ToString("c2");
                    salestaxrate = double.Parse(taxratetextBox.Text);
                    tax = subtotal * (salestaxrate / 100);
                    taxBox.Text = tax.ToString("c2");
                    label4.Text = "Sales Tax " + "" + taxratetextBox.Text + "%";
                    total = (subtotal * salestaxrate / 100) + subtotal;
                    TotalBox.Text = total.ToString("c2");
                    label2.Text = "Automatic:";
                }
                }
                 
            catch 
            {
                MessageBox.Show("Please make a selection or blank or invalid tax rate.");
            } 

        }
    }
}
