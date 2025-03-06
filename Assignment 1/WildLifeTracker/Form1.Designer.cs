namespace WildlifeTrackerWinForms
{
    partial class Form1
    {
        // Gruppbox för djurdetaljer
        private System.Windows.Forms.GroupBox groupBoxAnimalDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.ListBox SpeciesListBox;
        private System.Windows.Forms.PictureBox AnimalPictureBox;
        private System.Windows.Forms.Button AddImageButton;
        private System.Windows.Forms.Button AddAnimalButton;
        private System.Windows.Forms.ListBox AnimalListBox;
        private System.Windows.Forms.Label lblDomesticated;
        private System.Windows.Forms.CheckBox checkBoxDomesticated;
        private System.Windows.Forms.Label lblListAll;
        private System.Windows.Forms.CheckBox checkBoxListAll;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSpecies;

        private void InitializeComponent()
        {
            groupBoxAnimalDetails = new GroupBox();
            textBox1 = new TextBox();
            lblName = new Label();
            NameTextBox = new TextBox();
            lblAge = new Label();
            AgeTextBox = new TextBox();
            lblGender = new Label();
            GenderComboBox = new ComboBox();
            lblDomesticated = new Label();
            checkBoxDomesticated = new CheckBox();
            lblCategory = new Label();
            CategoryListBox = new ListBox();
            lblSpecies = new Label();
            SpeciesListBox = new ListBox();
            AnimalPictureBox = new PictureBox();
            AddImageButton = new Button();
            AddAnimalButton = new Button();
            AnimalListBox = new ListBox();
            lblListAll = new Label();
            checkBoxListAll = new CheckBox();
            groupBoxAnimalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnimalPictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAnimalDetails
            // 
            groupBoxAnimalDetails.Controls.Add(textBox1);
            groupBoxAnimalDetails.Controls.Add(lblName);
            groupBoxAnimalDetails.Controls.Add(NameTextBox);
            groupBoxAnimalDetails.Controls.Add(lblAge);
            groupBoxAnimalDetails.Controls.Add(AgeTextBox);
            groupBoxAnimalDetails.Controls.Add(lblGender);
            groupBoxAnimalDetails.Controls.Add(GenderComboBox);
            groupBoxAnimalDetails.Controls.Add(lblDomesticated);
            groupBoxAnimalDetails.Controls.Add(checkBoxDomesticated);
            groupBoxAnimalDetails.Controls.Add(lblCategory);
            groupBoxAnimalDetails.Controls.Add(CategoryListBox);
            groupBoxAnimalDetails.Controls.Add(lblSpecies);
            groupBoxAnimalDetails.Controls.Add(SpeciesListBox);
            groupBoxAnimalDetails.Controls.Add(AnimalPictureBox);
            groupBoxAnimalDetails.Controls.Add(AddImageButton);
            groupBoxAnimalDetails.Controls.Add(AddAnimalButton);
            groupBoxAnimalDetails.Controls.Add(AnimalListBox);
            groupBoxAnimalDetails.Controls.Add(lblListAll);
            groupBoxAnimalDetails.Controls.Add(checkBoxListAll);
            groupBoxAnimalDetails.Location = new Point(12, 10);
            groupBoxAnimalDetails.Name = "groupBoxAnimalDetails";
            groupBoxAnimalDetails.Size = new Size(592, 541);
            groupBoxAnimalDetails.TabIndex = 0;
            groupBoxAnimalDetails.TabStop = false;
            groupBoxAnimalDetails.Text = "Djur Specifikationer";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(336, 271);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(200, 200);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Namn";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(150, 30);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(180, 29);
            NameTextBox.TabIndex = 1;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(20, 65);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 2;
            lblAge.Text = "Ålder";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(150, 65);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(180, 29);
            AgeTextBox.TabIndex = 3;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(20, 100);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 4;
            lblGender.Text = "Kön";
            // 
            // GenderComboBox
            // 
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.Location = new Point(150, 100);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(180, 29);
            GenderComboBox.TabIndex = 5;
            GenderComboBox.SelectedIndexChanged += GenderComboBox_SelectedIndexChanged;
            // 
            // lblDomesticated
            // 
            lblDomesticated.Location = new Point(20, 136);
            lblDomesticated.Name = "lblDomesticated";
            lblDomesticated.Size = new Size(84, 23);
            lblDomesticated.TabIndex = 6;
            lblDomesticated.Text = "Tamdjur?";
            // 
            // checkBoxDomesticated
            // 
            checkBoxDomesticated.Location = new Point(226, 135);
            checkBoxDomesticated.Name = "checkBoxDomesticated";
            checkBoxDomesticated.Size = new Size(104, 24);
            checkBoxDomesticated.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(20, 159);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 23);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Kategori";
            // 
            // CategoryListBox
            // 
            CategoryListBox.ItemHeight = 21;
            CategoryListBox.Location = new Point(20, 185);
            CategoryListBox.Name = "CategoryListBox";
            CategoryListBox.Size = new Size(150, 151);
            CategoryListBox.TabIndex = 9;
            // 
            // lblSpecies
            // 
            lblSpecies.Location = new Point(180, 159);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(100, 23);
            lblSpecies.TabIndex = 10;
            lblSpecies.Text = "Art";
            // 
            // SpeciesListBox
            // 
            SpeciesListBox.ItemHeight = 21;
            SpeciesListBox.Location = new Point(180, 185);
            SpeciesListBox.Name = "SpeciesListBox";
            SpeciesListBox.Size = new Size(150, 151);
            SpeciesListBox.TabIndex = 11;
            SpeciesListBox.SelectedIndexChanged += SpeciesListBox_SelectedIndexChanged;
            // 
            // AnimalPictureBox
            // 
            AnimalPictureBox.BackColor = Color.White;
            AnimalPictureBox.BorderStyle = BorderStyle.FixedSingle;
            AnimalPictureBox.Location = new Point(336, 65);
            AnimalPictureBox.Name = "AnimalPictureBox";
            AnimalPictureBox.Size = new Size(200, 200);
            AnimalPictureBox.TabIndex = 12;
            AnimalPictureBox.TabStop = false;
            AnimalPictureBox.Click += AnimalPictureBox_Click;
            // 
            // AddImageButton
            // 
            AddImageButton.Location = new Point(336, 30);
            AddImageButton.Name = "AddImageButton";
            AddImageButton.Size = new Size(200, 30);
            AddImageButton.TabIndex = 13;
            AddImageButton.Text = "Lägg till bild";
            AddImageButton.Click += AddImageButton_Click;
            // 
            // AddAnimalButton
            // 
            AddAnimalButton.Location = new Point(20, 483);
            AddAnimalButton.Name = "AddAnimalButton";
            AddAnimalButton.Size = new Size(310, 30);
            AddAnimalButton.TabIndex = 14;
            AddAnimalButton.Text = "Lägg till djur";
            AddAnimalButton.Click += AddAnimalButton_Click;
            // 
            // AnimalListBox
            // 
            AnimalListBox.BackColor = SystemColors.ButtonFace;
            AnimalListBox.BorderStyle = BorderStyle.FixedSingle;
            AnimalListBox.ItemHeight = 21;
            AnimalListBox.Location = new Point(20, 368);
            AnimalListBox.Name = "AnimalListBox";
            AnimalListBox.Size = new Size(310, 107);
            AnimalListBox.TabIndex = 15;
            AnimalListBox.SelectedIndexChanged += AnimalListBox_SelectedIndexChanged;
            // 
            // lblListAll
            // 
            lblListAll.Location = new Point(20, 339);
            lblListAll.Name = "lblListAll";
            lblListAll.Size = new Size(124, 23);
            lblListAll.TabIndex = 16;
            lblListAll.Text = "Lista alla djur";
            // 
            // checkBoxListAll
            // 
            checkBoxListAll.Location = new Point(226, 338);
            checkBoxListAll.Name = "checkBoxListAll";
            checkBoxListAll.Size = new Size(104, 24);
            checkBoxListAll.TabIndex = 17;
            checkBoxListAll.CheckedChanged += checkBoxListAll_CheckedChanged;
            // 
            // Form1
            // 
            ClientSize = new Size(616, 563);
            Controls.Add(groupBoxAnimalDetails);
            Name = "Form1";
            Text = "Wildlife Tracker";
            Load += Form1_Load;
            groupBoxAnimalDetails.ResumeLayout(false);
            groupBoxAnimalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AnimalPictureBox).EndInit();
            ResumeLayout(false);
        }

        private TextBox textBox1;
    }
}