using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DevExpCardView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<GoldProduct> lstGoldProducts = new List<GoldProduct>();
        public class GoldProduct
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public string Description { get; set; }
            public decimal Weight { get; set; }
            public Image ImageURL { get; set; }
            public decimal Price { get; set; }

        }
        private List<GoldProduct> getProductList()
        {
            lstGoldProducts = new List<GoldProduct>();

            Random R = new Random();
            int range = 100;
            string Path = System.IO.Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "Images");
            for (int i = 1; i <= 40; i++)
            {

                int ProductID = R.Next(i, range);
                double Weight = R.NextDouble() * range;
                double Price = R.NextDouble() * 1000;

                lstGoldProducts.Add(new GoldProduct()
                {
                    ProductID = ProductID,
                    ProductName = "Sample Product " + ProductID,
                    Description = "هذا المنتج " + ProductID + " description " + (DateTime.Now.Millisecond * R.Next()).ToString(),
                    Weight = Math.Round(Convert.ToDecimal(Weight), 2),
                    ImageURL = System.Drawing.Image.FromFile(Path + @"\img (" + i + ").jpg"),
                    Price = Math.Round(Convert.ToDecimal(Price), 2),
                });
            }
            return lstGoldProducts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grdTestEx.DataSource = getProductList();
        }
        private void chkRTL_CheckedChanged(object sender, EventArgs e)
        {
            this.grdTestEx.RightToLeft = chkRTL.Checked ? RightToLeft.Yes : RightToLeft.No;
        }
        private void productCard_CustomDrawCardCaption(object sender, DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventArgs e)
        {
            var cardView = sender as DevExpress.XtraGrid.Views.Card.CardView;
            var fieldValue = cardView.GetRowCellDisplayText(e.RowHandle, "ProductName");
            e.CardCaption = fieldValue;
        }
        private void chkView_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
