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
            groupBox1 = new GroupBox();
            rdoRegular = new RadioButton();
            rdoMild = new RadioButton();
            rdoMaintain = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            btnOpenFile = new Button();
            menuStrip1 = new MenuStrip();
            groupBox1.SuspendLayout();
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
            lstOutput.Size = new Size(472, 154);
            lstOutput.TabIndex = 8;
            lstOutput.TabStop = false;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(230, 382);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 23);
            btnDisplay.TabIndex = 9;
            btnDisplay.Text = "&Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(375, 382);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(627, 382);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoRegular);
            groupBox1.Controls.Add(rdoMild);
            groupBox1.Controls.Add(rdoMaintain);
            groupBox1.Location = new Point(502, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 119);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Weight Goal";
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Location = new Point(6, 72);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(132, 19);
            rdoRegular.TabIndex = 2;
            rdoRegular.TabStop = true;
            rdoRegular.Text = "Regular Weight Loss";
            rdoRegular.UseVisualStyleBackColor = true;
            rdoRegular.CheckedChanged += rbtnRegular_CheckedChanged;
            // 
            // rdoMild
            // 
            rdoMild.AutoSize = true;
            rdoMild.Location = new Point(6, 47);
            rdoMild.Name = "rdoMild";
            rdoMild.Size = new Size(116, 19);
            rdoMild.TabIndex = 1;
            rdoMild.TabStop = true;
            rdoMild.Text = "Mild Weight Loss";
            rdoMild.UseVisualStyleBackColor = true;
            rdoMild.CheckedChanged += rbtnMild_CheckedChanged;
            // 
            // rdoMaintain
            // 
            rdoMaintain.AutoSize = true;
            rdoMaintain.Location = new Point(6, 22);
            rdoMaintain.Name = "rdoMaintain";
            rdoMaintain.Size = new Size(113, 19);
            rdoMaintain.TabIndex = 0;
            rdoMaintain.TabStop = true;
            rdoMaintain.Text = "Maintain Weight";
            rdoMaintain.UseVisualStyleBackColor = true;
            rdoMaintain.CheckedChanged += rbtnMaintain_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(502, 382);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(75, 23);
            btnOpenFile.TabIndex = 13;
            btnOpenFile.Text = "Open File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenFile);
            Controls.Add(groupBox1);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Kevin Pharsi Lab Project";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private RadioButton rdoRegular;
        private RadioButton rdoMild;
        private RadioButton rdoMaintain;
        private OpenFileDialog openFileDialog1;
        private Button btnOpenFile;
        private MenuStrip menuStrip1;
    }
}
