namespace Kevin_Pharsi_Lab_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show("Are you sure you want to quit?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ButtonSelected == DialogResult.Yes)
            {
                this.Close();
            }

        }
        //Constants
        double dailyCalories;


        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            //Stores the inputs in variables
            string inputName = txtDietersName.Text;
            string inputFood = txtFoodName.Text;

            double numericCalories;
            double numericTargetWeight;

            //Use parse on inputs (Stage 1)
            //double numericCalories = double.Parse(txtCaloriesPerServing.Text);
            //double numericTargetWeight = double.Parse(txtTargetWeight.Text);

            //TryParse Version (ICA 4)
            bool numericCaloriesValid;
            bool numericTargetWeightValid;

            numericCaloriesValid = double.TryParse(txtCaloriesPerServing.Text, out numericCalories);
            numericTargetWeightValid = double.TryParse(txtTargetWeight.Text, out numericTargetWeight);






            //ICA 5
            if (numericCaloriesValid && numericTargetWeightValid)
            {

                //Calculations
                //double dailyCalories = 2500;
                double dailyServings = dailyCalories / numericCalories;
                double percentageCalories = (numericCalories / dailyCalories) * 100; //percentage of 1 serving of the food item is of the daily calorie limit

                //Concatenates labels and inputs for Output
                string outputName = "Name: " + inputName;
                string outputFood = "Food: " + inputFood;
                string outputCalories = "Calories per Serving: " + numericCalories.ToString("N0");
                string outputTargetWeight = "Target Weight: " + numericTargetWeight.ToString("N1") + "lbs";
                string outputMessage = "Your daily calorie limit is: " + dailyCalories + " calories";
                string outputMessage2 = "You can eat " + dailyServings.ToString("N1") + " servings of " + inputFood + " per day";
                string outputMessage3 = "1 serving of " + inputFood + " is " + percentageCalories.ToString("N0") + "% of your daily calorie limit";

                string skip = " ";

                //Output
                lstOutput.Items.Add(outputName);
                lstOutput.Items.Add(outputFood);
                lstOutput.Items.Add(outputCalories);
                lstOutput.Items.Add(outputTargetWeight);
                lstOutput.Items.Add(skip);
                lstOutput.Items.Add(outputMessage);
                lstOutput.Items.Add(outputMessage3);
                lstOutput.Items.Add(outputMessage2);
            }
            else
            {
                lstOutput.Items.Add("The numeric values entered are not valid");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDietersName.Clear();
            txtFoodName.Clear();
            txtCaloriesPerServing.Clear();
            txtTargetWeight.Clear();

            lstOutput.Items.Clear();
        }
        //Radio buttons meant to adjust the daily calorie limit.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dailyCalories = 2500;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dailyCalories = 2250;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dailyCalories = 2000;
        }

        //Checks the first radio button by default when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
