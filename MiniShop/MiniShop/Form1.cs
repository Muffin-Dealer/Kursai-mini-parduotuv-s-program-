using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShop
{
    public partial class Form1 : Form
    {
        Dictionary<TabPage, Merchandise> merchandises;
        //List<Merchandise> merchandises;
        List<ShopBasket> basket;

        public Form1()
        {
            InitializeComponent();
            // merchandises = new List<Merchandise>();
            merchandises = new Dictionary<TabPage, Merchandise>();
            basket = new List<ShopBasket>();
            LoadMerch();
        }

        public void LoadMerch()
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader("Merch.txt"))
            {
                string line = null;

                while ((line = reader.ReadLine()) != null)
                {
                    var data = line.Split(';');
                    Merchandise merch = new Merchandise(data[0], data[1], double.Parse(data[2]), double.Parse(data[3]));
                    string fileName = merch.Name + ".JPG";
                    string path = Path.Combine(Environment.CurrentDirectory, @"foto\", fileName);
                    merch.ImagePath = path;
                    FileInfo inf = new FileInfo(path);

                    TabPage page = new TabPage();
                    page.Text = (merch.Name).ToString();
                    if (inf.Exists )
                    {
                        using (Bitmap img = new Bitmap(path))
                        {
                            page.BackgroundImage = (Image)img.Clone();
                            page.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                    MerchInfo.TabPages.Add(page);
                    merchandises.Add(page, merch);
                }
            }
           

        }

        private void MerchInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MerchInfo.TabPages.Count != 0)
            {
                Pavadinimas.Text = merchandises[MerchInfo.SelectedTab].Name;
                Svoris.Text = merchandises[MerchInfo.SelectedTab].Weight.ToString() + " Kg";
                Kaina.Text = merchandises[MerchInfo.SelectedTab].Price.ToString() + " Eur";

            }
        }

        private void IdetiBtn_Click(object sender, EventArgs e)
        {
            var mer = merchandises[MerchInfo.SelectedTab];
            bool exist = false;
            foreach (var item in basket)
            {
                if (item.merchandise == mer)
                    exist = true;
            }
            if(!exist)
                basket.Add(new ShopBasket(mer));
            else
            {
                var result = MessageBox.Show("Preke jau krepselyje");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
