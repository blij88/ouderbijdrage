using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouderbijdrage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<child> gezin = new List<child> { };
        private void createFamily_Click(object sender, EventArgs e)
        {
            InfoDisplay.Clear();
            gezin.Clear();
            string ouder2;
            string ouder1 = parentFirstName.Text + " " + parentLastName.Text;
            bool isSingle = singleParent.Checked;
            if (isSingle == false)
            {
                ouder2 = secondParentFirstName.Text + " " + secondParentLastName.Text;
            InfoDisplay.Text = ($"ouders:\n{ouder1} en {ouder2}\n\nKinderen:\n");
            }
            else
            {
                InfoDisplay.Text = ($"ouder:\n{ouder1}\n\nKinderen:\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gezin.Add(NewChild());

        }

        public child NewChild()
        {
            child newchild = new child();
            newchild.name = nameChild.Text;
            newchild.birthDay = birthday.Value;
            newchild.age = newchild.Age(birthday.Value);
            if (newchild.age < 10)
            {
                newchild.cost = 25;
            }
            else
            {
                newchild.cost = 37;
            }
            InfoDisplay.Text += ($"{newchild.name}\ngeboorte datum: {newchild.birthDay:dd-MM-yyyy}\nleeftijd: {newchild.age}\nbedrag: {newchild.cost}\n\n");
            return newchild;
        }

        private void singleParent_CheckedChanged(object sender, EventArgs e)
        {
            if (secondParentFirstName.Visible == true)
            {
                secondParentFirstName.Visible = false;
                firstName2ndP.Visible = false;
                secondParentLastName.Visible = false;
                lastName2ndP.Visible = false;
            }
            else
            {
                secondParentFirstName.Visible = true;
                firstName2ndP.Visible = true;
                secondParentLastName.Visible = true;
                lastName2ndP.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birthday.Value = DateTime.Now.AddYears(-10);
        }

        private void calcTotal_Click(object sender, EventArgs e)
        {
            decimal max = 150;
            double onlyParent = 0.75;
            decimal total = 50;

            foreach (var item in gezin)
            {
                total += item.cost;
            }
                if (total > max)
                {
                    total = max;
                }
                if (singleParent.Checked)
                {
                    total = total * (decimal)onlyParent;
                }
            finalAmount.Text = total.ToString("N2");
        }
    }

    public class child
    {
        public string name { get; set; }
        public DateTime birthDay { get; set; }
        public int age { get; set; }
        public decimal cost { get; set; }
        public int Age(DateTime birth)
        {
            int age;
            _ = new DateTime();
            DateTime current = DateTime.Today;
            int wholeYears = current.Year - birth.Year;
            int wholeMonths = current.Month - birth.Month;
            int wholeDays = current.Day - birth.Day;
            if (wholeMonths < 0 || (wholeMonths == 0 && wholeDays < 0))
            {
                age = wholeYears - 1;
            }
            else
            {
                age = wholeYears;
            }
            return age;
        }
    }
}
