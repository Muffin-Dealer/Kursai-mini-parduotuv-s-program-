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
    public partial class Form1 : Form
    {
        List<Merchandise> merchandises;
        List<ShopBasket> basket;

        public Form1()
        {
            InitializeComponent();
            merchandises = new List<Merchandise>();
            basket = new List<ShopBasket>();

        }

        public void LoadMerch()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("Merch.csv");
            string line = null;
            string path = "";
            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split(';');
                Merchandise merch = new Merchandise(data[0], data[1], double.Parse(data[2]), double.Parse(data[3]), path);
                merchandises.Add(merch);
            }
            //SandelioVaizdas.DataSource = VisosPrekes;
            //reader.Close();
        }

     
    }
}
