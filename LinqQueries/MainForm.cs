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
            dgv.DataSource = null;
            dgv.DataSource = People.PeopleList
                .OrderByDescending(a=>a.Id)
                .ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ObjectRepo repo = new ObjectRepo();
            //Person person = new Person();
            //person.Name = tbName.Text;
            //person.LastName = tbLastName.Text;
            //person.BirthDate = dtpBirth.Value;
            //person.Weight = Convert.ToInt32(mtbWeight.Text);
            //person.Height = Convert.ToInt32(mtbHeight.Text);
            Person person = new Person()
            {
                Name = tbName.Text,
                LastName = tbLastName.Text,
                BirthDate = dtpBirth.Value,
                Weight = Convert.ToInt32(mtbWeight.Text),
                Height = Convert.ToInt32(mtbHeight.Text),
            };
            repo.Add(person);
            MessageBox.Show("OK");
            getResult_Click(null, null);        // wywołanie metody z przycisku, bez obciążania pamięci
            //getResult_Click(sender, e);        // wywołanie metody z przycisku

        }
    }
}
