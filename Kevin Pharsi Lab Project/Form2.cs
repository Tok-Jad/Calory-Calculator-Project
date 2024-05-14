using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kevin_Pharsi_Lab_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string configFile = "configFile.txt";

        public string inputName { get; set; }
        public string foodName { get; set; }
        public string numericCalories { get; set; }
        public string weightGoal { get; set; }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bool nameValid, foodValid, caloriesValid, goalValid;
            double temp0, temp1, temp2, temp3;

            nameValid = double.TryParse(inputName, out temp0);
            foodValid = double.TryParse(foodName, out temp1);
            caloriesValid = double.TryParse(numericCalories, out temp2);
            goalValid = double.TryParse(weightGoal, out temp3);

            if (nameValid && foodValid && caloriesValid && goalValid)
            {



                StreamWriter sw = File.CreateText(configFile);




                sw.Close();

                this.Hide();
            }

            //Open & Read Config File
            if (File.Exists(configFile))
            {
                using (StreamReader srConfig = File.OpenText(configFile))
                {
                    string line;
                    while ((line = srConfig.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                    srConfig.Close();


                }
                Console.WriteLine("Config file successfully opened");


            }
            else
            {
                Console.WriteLine("Config file does not exist");
            }


        }
    }
}
