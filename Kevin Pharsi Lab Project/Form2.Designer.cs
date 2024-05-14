namespace Kevin_Pharsi_Lab_Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDietersName = new Label();
            lblFoodName = new Label();
            lblCaloriesPerServing = new Label();
            lblTargetWeight = new Label();
            txtDietersName = new TextBox();
            txtFoodName = new TextBox();
            txtCaloriesPerServing = new TextBox();
            txtTargetWeight = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblDietersName
            // 
            lblDietersName.AutoSize = true;
            lblDietersName.Location = new Point(92, 47);
            lblDietersName.Name = "lblDietersName";
            lblDietersName.Size = new Size(81, 15);
            lblDietersName.TabIndex = 0;
            lblDietersName.Text = "Dieter's Name";
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.Location = new Point(93, 87);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(69, 15);
            lblFoodName.TabIndex = 1;
            lblFoodName.Text = "Food Name";
            // 
            // lblCaloriesPerServing
            // 
            lblCaloriesPerServing.AutoSize = true;
            lblCaloriesPerServing.Location = new Point(93, 124);
            lblCaloriesPerServing.Name = "lblCaloriesPerServing";
            lblCaloriesPerServing.Size = new Size(111, 15);
            lblCaloriesPerServing.TabIndex = 2;
            lblCaloriesPerServing.Text = "Calories Per Serving";
            // 
            // lblTargetWeight
            // 
            lblTargetWeight.AutoSize = true;
            lblTargetWeight.Location = new Point(92, 165);
            lblTargetWeight.Name = "lblTargetWeight";
            lblTargetWeight.Size = new Size(106, 15);
            lblTargetWeight.TabIndex = 3;
            lblTargetWeight.Text = "Target Weight (lbs)";
            // 
            // txtDietersName
            // 
            txtDietersName.Location = new Point(210, 39);
            txtDietersName.Name = "txtDietersName";
            txtDietersName.Size = new Size(100, 23);
            txtDietersName.TabIndex = 4;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(210, 79);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(100, 23);
            txtFoodName.TabIndex = 5;
            // 
            // txtCaloriesPerServing
            // 
            txtCaloriesPerServing.Location = new Point(210, 124);
            txtCaloriesPerServing.Name = "txtCaloriesPerServing";
            txtCaloriesPerServing.Size = new Size(100, 23);
            txtCaloriesPerServing.TabIndex = 6;
            // 
            // txtTargetWeight
            // 
            txtTargetWeight.Location = new Point(210, 165);
            txtTargetWeight.Name = "txtTargetWeight";
            txtTargetWeight.Size = new Size(100, 23);
            txtTargetWeight.TabIndex = 7;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(521, 263);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(txtTargetWeight);
            Controls.Add(txtCaloriesPerServing);
            Controls.Add(txtFoodName);
            Controls.Add(txtDietersName);
            Controls.Add(lblTargetWeight);
            Controls.Add(lblCaloriesPerServing);
            Controls.Add(lblFoodName);
            Controls.Add(lblDietersName);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDietersName;
        private Label lblFoodName;
        private Label lblCaloriesPerServing;
        private Label lblTargetWeight;
        private TextBox txtDietersName;
        private TextBox txtFoodName;
        private TextBox txtCaloriesPerServing;
        private TextBox txtTargetWeight;
        private Button btnClose;
    }
}