using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionOutputBox.Text = wishList.Text;
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            wishList.Items.Add("Siargao Beach");
            wishList.Items.Add("Bali, Indonesia");
            wishList.Items.Add("Coron, Palawan");
            wishList.Items.Add("El Nido, Palawan");
            wishList.Items.Add("Hokkaido, Japan");

        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            wishList.Sorted = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            wishList.Items.Clear();
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            countTxt.Text = Convert.ToString(wishList.Items.Count);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void selectionOutputBox_Click(object sender, EventArgs e)
        {

        }
    }
}
