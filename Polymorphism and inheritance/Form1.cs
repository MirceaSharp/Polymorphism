using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism_and_inheritance
{
    public partial class Form1 : Form
    {
        Animal human = new Human("Joe");
        Animal cat1 = new Cat("Felix");
        Animal parrot1 = new Parrot("Koko");


        string one = "Hello!, How are you?";
        string two = "What time is it?";
        string three = "Good evening!";
        List<string> SentencesList = new List<string>();

        


        public Form1()
        {
            InitializeComponent();
            SentencesList.Add(one);
            SentencesList.Add(two);
            SentencesList.Add(three);
            lbSentences.DataSource = SentencesList;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCaress_Click(object sender, EventArgs e)
        {
            if (rdHuman.Checked )
            {
                MessageBox.Show(human.Caress());
            }
            else if(rdCat.Checked )
            {
                MessageBox.Show(cat1.Caress());

            }
            else if(rdParrot.Checked )
            {
                MessageBox.Show( parrot1.Caress());
            }
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {
            if(rdParrot.Checked)
            {
                MessageBox.Show(parrot1.Talk(Convert.ToString(lbSentences.SelectedItem)));
            }
            else if(rdCat.Checked)
            {
                MessageBox.Show(cat1.Talk(Convert.ToString(lbSentences.SelectedItem)));
            }
            else if(rdHuman.Checked)
            {
                MessageBox.Show(human.Talk(Convert.ToString(lbSentences.SelectedItem)));
            }
        }

        private void btnEat_Click(object sender, EventArgs e)
        {
            if(rdCat.Checked)
            {
                MessageBox.Show(cat1.Eat());
            }
            else if (rdParrot.Checked)
            {
                MessageBox.Show(parrot1.Eat());
            }
            else if(rdHuman.Checked)
            {
                MessageBox.Show(human.Eat());
            }
        }
    }
}
