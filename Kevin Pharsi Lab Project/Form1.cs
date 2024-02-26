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
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            //Stores the inputs in variables
            string inputName = txtDietersName.Text;
            string inputFood = txtFoodName.Text;

            //Use parse on some inputs
            int numericCalories = int.Parse(txtCaloriesPerServing.Text);
            double numericTargetWeight = double.Parse(txtTargetWeight.Text);

            //Calculations
            double dailyCalories = numericTargetWeight * 12;
            double dailyServings = dailyCalories / numericCalories;

            //Concatenates labels and inputs for Output
            string outputName = "Name: " + inputName;
            string outputFood = "Food: " + inputFood;
            string outputCalories = "Calories per Serving: " + numericCalories.ToString("N0");
            string outputTargetWeight = "Target Weight: " + numericTargetWeight.ToString("N1") + "lbs";
            string outputMessage = "Your daily calorie limit is: " + dailyCalories + " calories";
            string outputMessage2 = "You can eat " + dailyServings + " servings of " + inputFood + " per day";

            string skip = " ";

            //Output
            lstOutput.Items.Add(outputName);
            lstOutput.Items.Add(outputFood);
            lstOutput.Items.Add(outputCalories);
            lstOutput.Items.Add(outputTargetWeight);
            lstOutput.Items.Add(skip);
            lstOutput.Items.Add(outputMessage);
            lstOutput.Items.Add(outputMessage2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDietersName.Clear();
            txtFoodName.Clear();
            txtCaloriesPerServing.Clear();
            txtTargetWeight.Clear();

            lstOutput.Items.Clear();
        }


    }
}
