
using WildlifeTracker;

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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox kattBiTextBox;


        private void InitializeComponent()
        {
            groupBoxAnimalDetails = new GroupBox();
            groupBox2 = new GroupBox();
            kattBiTextBox = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
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
            lblListAll = new Label();
            checkBoxListAll = new CheckBox();
            textBox1 = new TextBox();
            AnimalListBox = new ListBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            groupBoxAnimalDetails.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnimalPictureBox).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAnimalDetails
            // 
            groupBoxAnimalDetails.Controls.Add(groupBox2);
            groupBoxAnimalDetails.Controls.Add(groupBox1);
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
            groupBoxAnimalDetails.Controls.Add(lblListAll);
            groupBoxAnimalDetails.Controls.Add(checkBoxListAll);
            groupBoxAnimalDetails.Location = new Point(12, 10);
            groupBoxAnimalDetails.Name = "groupBoxAnimalDetails";
            groupBoxAnimalDetails.Size = new Size(883, 325);
            groupBoxAnimalDetails.TabIndex = 0;
            groupBoxAnimalDetails.TabStop = false;
            groupBoxAnimalDetails.Text = "Djur Specifikationer";
            groupBoxAnimalDetails.Enter += groupBoxAnimalDetails_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(kattBiTextBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(214, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 86);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Djur specifikationer";
            // 
            // kattBiTextBox
            // 
            kattBiTextBox.Location = new Point(190, 35);
            kattBiTextBox.Name = "kattBiTextBox";
            kattBiTextBox.Size = new Size(85, 29);
            kattBiTextBox.TabIndex = 0;
            kattBiTextBox.Visible = false;
            kattBiTextBox.TextChanged += kattBiTextBox_TextChanged;
            // 
            // label7
            // 
            label7.Location = new Point(15, 25);
            label7.Name = "label7";
            label7.Size = new Size(169, 45);
            label7.TabIndex = 23;
            label7.Text = "Gillar hunden att leka med bollar?";
            label7.Visible = false;
            label7.Click += label7_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ja", "Nej" });
            comboBox1.Location = new Point(190, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(82, 29);
            comboBox1.TabIndex = 0;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(8, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 86);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Klass specifikationer";
            groupBox1.TextChanged += groupBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.AddRange(new object[] { "Ja", "Nej" });
            comboBox2.Location = new Point(121, 36);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(61, 29);
            comboBox2.TabIndex = 21;
            comboBox2.Visible = false;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Location = new Point(15, 25);
            label5.Name = "label5";
            label5.Size = new Size(100, 45);
            label5.TabIndex = 20;
            label5.Text = "Ange antalet tänder";
            label5.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(61, 29);
            textBox2.TabIndex = 20;
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Namn";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(150, 39);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(180, 29);
            NameTextBox.TabIndex = 1;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(20, 74);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 2;
            lblAge.Text = "Ålder";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(150, 74);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(180, 29);
            AgeTextBox.TabIndex = 3;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(20, 109);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 4;
            lblGender.Text = "Kön";
            // 
            // GenderComboBox
            // 
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.Location = new Point(150, 109);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(180, 29);
            GenderComboBox.TabIndex = 5;
            GenderComboBox.SelectedIndexChanged += GenderComboBox_SelectedIndexChanged;
            // 
            // lblDomesticated
            // 
            lblDomesticated.Location = new Point(20, 141);
            lblDomesticated.Name = "lblDomesticated";
            lblDomesticated.Size = new Size(84, 23);
            lblDomesticated.TabIndex = 6;
            lblDomesticated.Text = "Tamdjur?";
            // 
            // checkBoxDomesticated
            // 
            checkBoxDomesticated.Location = new Point(110, 141);
            checkBoxDomesticated.Name = "checkBoxDomesticated";
            checkBoxDomesticated.Size = new Size(104, 24);
            checkBoxDomesticated.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(336, 13);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 23);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Kategori";
            // 
            // CategoryListBox
            // 
            CategoryListBox.ItemHeight = 21;
            CategoryListBox.Location = new Point(336, 39);
            CategoryListBox.Name = "CategoryListBox";
            CategoryListBox.Size = new Size(150, 151);
            CategoryListBox.TabIndex = 9;
            // 
            // lblSpecies
            // 
            lblSpecies.Location = new Point(492, 13);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(100, 23);
            lblSpecies.TabIndex = 10;
            lblSpecies.Text = "Art";
            // 
            // SpeciesListBox
            // 
            SpeciesListBox.ItemHeight = 21;
            SpeciesListBox.Location = new Point(492, 39);
            SpeciesListBox.Name = "SpeciesListBox";
            SpeciesListBox.Size = new Size(150, 151);
            SpeciesListBox.TabIndex = 11;
            SpeciesListBox.SelectedIndexChanged += SpeciesListBox_SelectedIndexChanged;
            // 
            // AnimalPictureBox
            // 
            AnimalPictureBox.BackColor = Color.White;
            AnimalPictureBox.BorderStyle = BorderStyle.FixedSingle;
            AnimalPictureBox.Location = new Point(648, 39);
            AnimalPictureBox.Name = "AnimalPictureBox";
            AnimalPictureBox.Size = new Size(200, 211);
            AnimalPictureBox.TabIndex = 12;
            AnimalPictureBox.TabStop = false;
            AnimalPictureBox.Click += AnimalPictureBox_Click;
            // 
            // AddImageButton
            // 
            AddImageButton.Location = new Point(648, 256);
            AddImageButton.Name = "AddImageButton";
            AddImageButton.Size = new Size(200, 30);
            AddImageButton.TabIndex = 13;
            AddImageButton.Text = "Lägg till bild";
            AddImageButton.Click += AddImageButton_Click;
            // 
            // AddAnimalButton
            // 
            AddAnimalButton.BackColor = Color.MistyRose;
            AddAnimalButton.Location = new Point(531, 245);
            AddAnimalButton.Name = "AddAnimalButton";
            AddAnimalButton.Size = new Size(111, 47);
            AddAnimalButton.TabIndex = 14;
            AddAnimalButton.Text = "Lägg till djur";
            AddAnimalButton.UseVisualStyleBackColor = false;
            AddAnimalButton.Click += AddAnimalButton_Click;
            // 
            // lblListAll
            // 
            lblListAll.Location = new Point(492, 197);
            lblListAll.Name = "lblListAll";
            lblListAll.Size = new Size(106, 23);
            lblListAll.TabIndex = 16;
            lblListAll.Text = "Lista alla djur";
            // 
            // checkBoxListAll
            // 
            checkBoxListAll.Location = new Point(598, 197);
            checkBoxListAll.Name = "checkBoxListAll";
            checkBoxListAll.Size = new Size(44, 24);
            checkBoxListAll.TabIndex = 17;
            checkBoxListAll.CheckedChanged += checkBoxListAll_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(300, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(264, 149);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // AnimalListBox
            // 
            AnimalListBox.BackColor = SystemColors.Window;
            AnimalListBox.BorderStyle = BorderStyle.FixedSingle;
            AnimalListBox.ItemHeight = 21;
            AnimalListBox.Location = new Point(36, 46);
            AnimalListBox.Name = "AnimalListBox";
            AnimalListBox.Size = new Size(248, 149);
            AnimalListBox.TabIndex = 15;
            AnimalListBox.SelectedIndexChanged += AnimalListBox_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(AnimalListBox);
            groupBox3.Location = new Point(12, 341);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(883, 216);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista över alla registrerade djur";
            // 
            // label2
            // 
            label2.Location = new Point(300, 19);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 21;
            label2.Text = "Beskrivning";
            // 
            // label1
            // 
            label1.Location = new Point(579, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 20;
            label1.Text = "Matschema";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLightLight;
            textBox3.Location = new Point(570, 46);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(279, 149);
            textBox3.TabIndex = 19;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // Form1
            // 
            ClientSize = new Size(914, 570);
            Controls.Add(groupBox3);
            Controls.Add(groupBoxAnimalDetails);
            Name = "Form1";
            Text = "Wildlife Tracker";
            Load += Form1_Load;
            groupBoxAnimalDetails.ResumeLayout(false);
            groupBoxAnimalDetails.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AnimalPictureBox).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label7;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
    }
}