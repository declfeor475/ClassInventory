using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // create a List to store all inventory objects
        List<Class> inventory = new List<Class>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // gather all information from screen 
            string name = c.Text;
            int age = Convert.ToInt16(ageInput.Text);
            string team = teamInput.Text;
            string position = positionInput.Text;

            // create object with gathered information
            Class newClass = new Class(name, age, team, position);

            // add object to global list
            inventory.Add(newClass);

            // display message to indicate addition made
            outputLabel.Text = "Student has been added";

            // clear textboxes
            c.Text = "";
            ageInput.Text = "";
            teamInput.Text = "";
            positionInput.Text = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // if object is in list remove it
            string removePlayer = removeInput.Text;
            int index = inventory.FindIndex(n => n.name == removePlayer);
            
            if (index >= 0)
            {
                inventory.RemoveAt(index);
            }

            // display message to indicate deletion made
            outputLabel.Text = "";
            outputLabel.Text = "Student has been deleted";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // if object entered exists in list show it
            string showPlayer = textBox1.Text;
            int index = inventory.FindIndex(n => n.name == showPlayer);

            outputLabel.Text = "";

            if (index >= 0)
            {
                outputLabel.Text += inventory[index].name + "\n";
                outputLabel.Text += inventory[index].age + "\n";
                outputLabel.Text += inventory[index].team + "\n";
                outputLabel.Text += inventory[index].position + "\n\n";
            }
            else
            {
                // else show not found message
                outputLabel.Text = "Student not found";
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // clear label
            outputLabel.Text = "";

            // show all objects in list, use foreach loop
            foreach (Class c in inventory)
            {
                outputLabel.Text += c.name + "\n";
                outputLabel.Text += c.age + "\n";
                outputLabel.Text += c.team + "\n";
                outputLabel.Text += c.position + "\n\n";
            }
        }
    }
}
