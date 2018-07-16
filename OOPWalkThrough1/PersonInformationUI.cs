using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OOPWalkThrough1.Models;

namespace OOPWalkThrough1
{
    public partial class PersonInformationUI : Form
    {
        public PersonInformationUI()
        {
            InitializeComponent();
        }

        Person person;

        List<Person> people = new List<Person>(); 
        
        private void showButton_Click(object sender, EventArgs e)
        {
            //person object 

            person = new Person(Convert.ToInt32(idTextBox.Text),firstNameTextBox.Text,middleNameTextBox.Text,lastNameTextBox.Text);

            people.Add(person);
            personCountLabel.Text = people.Count.ToString();

            idTextBox.Clear();
            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        private void PersonInformationUI_Load(object sender, EventArgs e)
        {

        }

        private void showAll_Click(object sender, EventArgs e)
        {
            if (people.Count==0)
            {
                MessageBox.Show("Sorry, no person found!");
                return;
            }

            peopleListView.Items.Clear();
            foreach (Person aPerson in people)
            {
                ListViewItem item = new ListViewItem(aPerson.Id.ToString());
                item.SubItems.Add(aPerson.FirstName);
                item.SubItems.Add(aPerson.MiddleName);
                item.SubItems.Add(aPerson.LastName);

                peopleListView.Items.Add(item);

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (people.Count == 0)
            {
                MessageBox.Show("Sorry, Empty ListView found!");
                return;
            }
            foreach (Person aPerson in people)
            {
                if(aPerson.Id == Convert.ToInt32(SearchIdTextBox.Text))
                {
                    fullNameTextBox.Text = aPerson.FirstName + " " + aPerson.MiddleName + " " + aPerson.LastName;
                    reverseNameTextBox.Text = aPerson.GetReverseFullName;
                }
            }


        }



       
    }
}
