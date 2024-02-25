namespace Kevin_Pharsi_Lab_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDietersName = new Label();
            lblFoodName = new Label();
            lblCaloriesPerServing = new Label();
            txtDietersName = new TextBox();
            txtFoodName = new TextBox();
            txtCaloriesPerServing = new TextBox();
            lstOutput = new ListBox();
            btnDisplay = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            lblTargetWeight = new Label();
            txtTargetWeight = new TextBox();
            SuspendLayout();
            // 
            // lblDietersName
            // 
            lblDietersName.AutoSize = true;
            lblDietersName.Location = new Point(134, 45);
            lblDietersName.Name = "lblDietersName";
            lblDietersName.Size = new Size(81, 15);
            lblDietersName.TabIndex = 0;
            lblDietersName.Text = "Dieter's Name";
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.Location = new Point(134, 74);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(69, 15);
            lblFoodName.TabIndex = 1;
            lblFoodName.Text = "Food Name";
            // 
            // lblCaloriesPerServing
            // 
            lblCaloriesPerServing.AutoSize = true;
            lblCaloriesPerServing.Location = new Point(92, 107);
            lblCaloriesPerServing.Name = "lblCaloriesPerServing";
            lblCaloriesPerServing.Size = new Size(111, 15);
            lblCaloriesPerServing.TabIndex = 2;
            lblCaloriesPerServing.Text = "Calories per Serving";
            // 
            // txtDietersName
            // 
            txtDietersName.Location = new Point(230, 42);
            txtDietersName.Name = "txtDietersName";
            txtDietersName.Size = new Size(100, 23);
            txtDietersName.TabIndex = 4;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(230, 74);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(100, 23);
            txtFoodName.TabIndex = 5;
            // 
            // txtCaloriesPerServing
            // 
            txtCaloriesPerServing.Location = new Point(230, 107);
            txtCaloriesPerServing.Name = "txtCaloriesPerServing";
            txtCaloriesPerServing.Size = new Size(100, 23);
            txtCaloriesPerServing.TabIndex = 6;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 15;
            lstOutput.Location = new Point(230, 183);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(472, 109);
            lstOutput.TabIndex = 8;
            lstOutput.TabStop = false;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(230, 343);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 23);
            btnDisplay.TabIndex = 9;
            btnDisplay.Text = "&Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(430, 343);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(627, 343);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 11;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblTargetWeight
            // 
            lblTargetWeight.AutoSize = true;
            lblTargetWeight.Location = new Point(94, 141);
            lblTargetWeight.Name = "lblTargetWeight";
            lblTargetWeight.Size = new Size(109, 15);
            lblTargetWeight.TabIndex = 3;
            lblTargetWeight.Text = "Target Weight (Lbs)";
            // 
            // txtTargetWeight
            // 
            txtTargetWeight.Location = new Point(230, 138);
            txtTargetWeight.Name = "txtTargetWeight";
            txtTargetWeight.Size = new Size(100, 23);
            txtTargetWeight.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTargetWeight);
            Controls.Add(lblTargetWeight);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(lstOutput);
            Controls.Add(txtCaloriesPerServing);
            Controls.Add(txtFoodName);
            Controls.Add(txtDietersName);
            Controls.Add(lblCaloriesPerServing);
            Controls.Add(lblFoodName);
            Controls.Add(lblDietersName);
            Name = "Form1";
            Text = "Kevin Pharsi Lab Project";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDietersName;
        private Label lblFoodName;
        private Label lblCaloriesPerServing;
        private TextBox txtDietersName;
        private TextBox txtFoodName;
        private TextBox txtCaloriesPerServing;
        private ListBox lstOutput;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnQuit;
        private Label lblTargetWeight;
        private TextBox txtTargetWeight;
    }
}
