using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShop
{
    public partial class Form2 : Form
    {
        public List<ShopBasket> basket;
        Mailing mail;
        public Form2(List<ShopBasket> k)
        {
            mail = new Mailing();
            InitializeComponent();
            basket = k;
            LoadBasket();
            
        }

        private void LoadBasket()
        {
            dataGridView1.DataSource = basket;
            dataGridView1.Columns["Id"].Visible = false;

            Total.Text = (Math.Round(mail.MailingPrice(basket, " ")*100)/100).ToString();
            
        }

        private void Order_Click(object sender, EventArgs e)
        {
           
        }
    }
}
