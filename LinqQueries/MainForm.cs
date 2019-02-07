using MockData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqQueries
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void getResult_Click(object sender, EventArgs e)
        {
            ObjectRepo repo = new ObjectRepo();
            repo.Add(new Person { Id = 1000, Name = "XYZ" });
            dgv.DataSource = null;
            dgv.DataSource = People.PeopleList
                .OrderByDescending(a=>a.Id)
                .ToList();
        }
    }
}
