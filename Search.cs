using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyMorpher
{
    public partial class Search : Form
    {
        Form1 myparent;
        public Search(Form1 myparent)
        {
            InitializeComponent();
            this.myparent = myparent;
        }

        private void Search_ResizeEnd(object sender, EventArgs e)
        {
            txtName.Size = new Size(this.Size.Width - btnSearch.Size.Width - 30, txtName.Size.Height);
            btnSearch.Location = new Point(this.Size.Width - btnSearch.Size.Width - 15, btnSearch.Location.Y);
            listView1.Size = new Size(listView1.Size.Width, this.Size.Height - 65);
            listView1.Columns[1].Width = listView1.ClientSize.Width - listView1.Columns[0].Width;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            txtName.Size = new Size(this.Size.Width - btnSearch.Size.Width - 30, txtName.Size.Height);
            btnSearch.Location = new Point(this.Size.Width - btnSearch.Size.Width - 15, btnSearch.Location.Y);
            listView1.Size = new Size(listView1.Size.Width, this.Size.Height - 65);
            listView1.Columns[1].Width = listView1.ClientSize.Width - listView1.Columns[0].Width;
            listView1.Activation = ItemActivation.TwoClick;
            listView1.ItemActivate += ListView1_ItemActivate;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (txtName.TextLength > 1)
            { 
                for (int i = 0; i < DisplayDB.DisplayName.Length; i++)
                {
                    if (DisplayDB.DisplayName[i].Contains(txtName.Text))
                    {
                        ListViewItem newrow = new ListViewItem(DisplayDB.DisplayID[i].ToString());
                        newrow.SubItems.Add(DisplayDB.DisplayName[i]);
                        listView1.Items.Add(newrow);
                    }
                }
            }
            if (listView1.ClientSize.Width - listView1.Columns[0].Width - listView1.Columns[1].Width < 1)
                listView1.Columns[1].Width = listView1.ClientSize.Width - listView1.Columns[0].Width;
        }

        private void ListView1_ItemActivate(Object sender, EventArgs e)
        {
            myparent.textBox2.Text = listView1.SelectedItems[0].Text;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnSearch_Click(sender, e);
            }
        }
    }
}
