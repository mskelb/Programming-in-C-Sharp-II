using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WildlifeTracker;
using WildLifeTrackerForm;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WildlifeTrackerWinForms
{
    public partial class Form1 : Form
    {
        private AnimalManager animalManager = new AnimalManager();
        private Djur selectedAnimal = null; // Håller koll på valt djur
        private string selectedImagePath = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // Fyller i kategorier och arter vid start
            CategoryListBox.Items.Add(Category.Däggdjur);
            CategoryListBox.Items.Add(Category.Fågel);
            CategoryListBox.Items.Add(Category.Insekt);

            // Förifyll könsalternativ
            GenderComboBox.Items.Add(Gender.Hona);
            GenderComboBox.Items.Add(Gender.Hane);
            GenderComboBox.Items.Add(Gender.Okänd);

            // Se till att SpeciesListBox uppdateras vid val av kategori
            CategoryListBox.SelectedIndexChanged += CategoryListBox_SelectedIndexChanged;
        }
        private void SpeciesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SpeciesListBox.SelectedItem == null)
            {
                return;
            }

            string selectedSpecies = SpeciesListBox.SelectedItem.ToString();

            // Återställ fält
            kattBiTextBox.Visible = false;
            comboBox1.Visible = false;
            kattBiTextBox.Text = "";
            comboBox1.SelectedIndex = -1;

            switch (selectedSpecies)
            {
                case "Hund":
                    groupBox2.Text = "Hund Specifikationer";
                    label7.Text = AnimalPrompts.HundGillarBollar.GetDescription(); ;
                    comboBox1.Visible = true;
                    break;
                case "Katt":
                    groupBox2.Text = "Katt Specifikationer";
                    label7.Text = AnimalPrompts.KattSötindex.GetDescription(); ;
                    kattBiTextBox.Visible = true;
                    break;
                case "Duva":
                    groupBox2.Text = "Duva Specifikationer";
                    label7.Text = AnimalPrompts.DuvaFridensDuva.GetDescription(); ;
                    comboBox1.Visible = true;
                    break;
                case "Falk":
                    groupBox2.Text = "Falk Specifikationer";
                    label7.Text = AnimalPrompts.FalkFlyghastighet.GetDescription(); ;
                    kattBiTextBox.Visible = true;
                    break;
                case "Bi":
                    groupBox2.Text = "Bi Specifikationer";
                    label7.Text = AnimalPrompts.BiGulligt.GetDescription(); ;
                    comboBox1.Visible = true;
                    break;
                case "Fjäril":
                    groupBox2.Text = "Fjäril Specifikationer";
                    label7.Text = AnimalPrompts.FjärilVacker.GetDescription(); ;
                    comboBox1.Visible = true;
                    break;
                default:
                    groupBox2.Text = "Specifikationer";
                    break;
            }
        }


        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpeciesListBox.Items.Clear();
            checkBoxListAll.Checked = false;
            label7.Visible = true;
            label5.Visible = true;

            if (CategoryListBox.SelectedItem is Category selectedCategory)
            {
                switch (selectedCategory)
                {
                    case Category.Däggdjur:
                        groupBox1.Text = "Däggdjur specifikationer";
                        textBox2.Visible = true;
                        comboBox2.Visible = false;
                        textBox2.Text = ""; // Återställ fält
                        groupBox2.Text = "Hund Specifikationer";
                        label5.Text = AnimalPrompts.Tänder.GetDescription();
                        label7.Text = AnimalPrompts.HundGillarBollar.GetDescription();
                        kattBiTextBox.Visible = false;
                        comboBox1.Visible = true;
                        comboBox1.SelectedIndex = -1;
                        SpeciesListBox.Items.Add("Hund");
                        SpeciesListBox.Items.Add("Katt");
                        SpeciesListBox.SelectedIndex = -1;
                        break;

                    case Category.Fågel:
                        groupBox1.Text = "Fågel specifikationer";
                        textBox2.Visible = true;
                        comboBox2.Visible = false;
                        textBox2.Text = "";
                        groupBox2.Text = "Falk Specifikationer";
                        label5.Text = "Vingbredd";
                        label7.Text = AnimalPrompts.FalkFlyghastighet.GetDescription(); ;
                        kattBiTextBox.Visible = true;
                        comboBox1.Visible = false;
                        kattBiTextBox.Text = ""; // Återställ fält
                        SpeciesListBox.Items.Add("Duva");
                        SpeciesListBox.Items.Add("Falk");
                        SpeciesListBox.SelectedIndex = -1;
                        break;

                    case Category.Insekt:
                        groupBox1.Text = "Insekt specifikationer";
                        textBox2.Visible = false;
                        comboBox2.Visible = true;
                        comboBox2.SelectedIndex = -1;
                        groupBox2.Text = "Bi Specifikationer";
                        label5.Text = "Pollinerare?";
                        label7.Text = AnimalPrompts.BiGulligt.GetDescription(); ;
                        kattBiTextBox.Visible = false;
                        comboBox1.Visible = true;
                        comboBox1.SelectedIndex = -1;
                        SpeciesListBox.Items.Add("Bi");
                        SpeciesListBox.Items.Add("Fjäril");
                        SpeciesListBox.SelectedIndex = -1;
                        break;

                    default:
                        MessageBox.Show("Ogiltig kategori.");
                        break;
                }
            }
            groupBox1.Refresh();
        }

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show("Vänligen ange ett namn.");
                return;
            }
            if (!int.TryParse(AgeTextBox.Text, out int age))
            {
                MessageBox.Show("Vänligen ange en giltig ålder.");
                return;
            }

            if (GenderComboBox.SelectedItem is not Gender gender)
            {
                MessageBox.Show("Vänligen välj kön.");
                return;
            }
            if (CategoryListBox.SelectedItem == null)
            {
                MessageBox.Show("Vänligen välj en kategori först.");
                return;
            }
            if (SpeciesListBox.SelectedItem == null)
            {
                MessageBox.Show("Vänligen välj en art.");
                return;
            }
            string name = NameTextBox.Text;
            bool isDomesticated = checkBoxDomesticated.Checked;
            string species = SpeciesListBox.SelectedItem.ToString();
            Djur newAnimal = null;

            // Hämta extra specifikationer baserat på kategori och art
            int numberOfTeeth = 0;
            int wingSpan = 0;
            int flightSpeed = 0;
            bool isPollinator = false;
            bool specialBoolean = false;
            int specialInt = 0;

            // Läs data från "Djur specifikationer"
            if (CategoryListBox.SelectedItem is Category selectedCategory)
            {
                switch (selectedCategory)
                {
                    case Category.Däggdjur:
                        if (!int.TryParse(textBox2.Text, out numberOfTeeth))
                        {
                            MessageBox.Show("Vänligen ange ett giltigt antal tänder.");
                            return;
                        }
                        break;

                    case Category.Fågel:
                        if (!int.TryParse(textBox2.Text, out wingSpan))
                        {
                            MessageBox.Show("Vänligen ange en giltig vingbredd.");
                            return;
                        }
                        break;

                    case Category.Insekt:
                        if (comboBox1.SelectedItem == null)
                        {
                            MessageBox.Show("Vänligen ange om insekten är pollinerare.");
                            return;
                        }
                        isPollinator = comboBox1.SelectedItem?.ToString() == "Ja";
                        break;
                }
            }
            // Läs data från "Art specifikationer"
            if (species == "Hund" || species == "Bi" || species == "Fjäril" || species == "Duva")
            {
                specialBoolean = comboBox1.SelectedItem?.ToString() == "Ja";
            }
            else if (species == "Katt" || species == "Falk")
            {
                if (!int.TryParse(kattBiTextBox.Text, out specialInt))
                {
                    MessageBox.Show($"Vänligen ange ett giltigt värde för {label7.Text}.");
                    return;
                }
            }

            // Skapa djur beroende på kategori och art
            switch (CategoryListBox.SelectedItem)
            {
                case Category.Däggdjur:
                    switch (species)
                    {
                        case "Hund":
                            newAnimal = new Hund(name, age, gender, isDomesticated, numberOfTeeth, specialBoolean, selectedImagePath);
                            break;
                        case "Katt":
                            newAnimal = new Katt(name, age, gender, isDomesticated, numberOfTeeth, specialInt, selectedImagePath);
                            break;
                        default:
                            MessageBox.Show("Ogiltig art för Däggdjur.");
                            return;
                    }
                    break;

                case Category.Fågel:
                    switch (species)
                    {
                        case "Duva":
                            newAnimal = new Duva(name, age, gender, isDomesticated, wingSpan, specialBoolean, selectedImagePath);
                            break;
                        case "Falk":
                            newAnimal = new Falk(name, age, gender, isDomesticated, wingSpan, specialInt, selectedImagePath);
                            break;
                        default:
                            MessageBox.Show("Ogiltig art för Fågel.");
                            return;
                    }
                    break;

                case Category.Insekt:
                    switch (species)
                    {
                        case "Bi":
                            newAnimal = new Bi(name, age, gender, isDomesticated, isPollinator, specialBoolean, selectedImagePath);
                            break;
                        case "Fjäril":
                            newAnimal = new Fjäril(name, age, gender, isDomesticated, isPollinator, specialBoolean, selectedImagePath);
                            break;
                        default:
                            MessageBox.Show("Ogiltig art för Insekt.");
                            return;
                    }
                    break;

                default:
                    MessageBox.Show("Ogiltig kategori.");
                    return;
            }

            // Om djuret skapades, lägg till det i listan och uppdatera 
            if (newAnimal != null)
            {
                animalManager.Add(newAnimal);
                AnimalListBox.Items.Add(newAnimal);
            }
            // Rensa fält efter att djuret har lagts till
            ClearSelection();
        }



        private void checkBoxDomesticated_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedAnimal != null)
            {
                selectedAnimal.IsDomesticated = checkBoxDomesticated.Checked;
            }
        }
        private void checkBoxListAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxListAll.Checked)
            {
                SpeciesListBox.Items.Clear();
                SpeciesListBox.Items.Add("Hund");
                SpeciesListBox.Items.Add("Katt");
                SpeciesListBox.Items.Add("Duva");
                SpeciesListBox.Items.Add("Falk");
                SpeciesListBox.Items.Add("Bi");
                SpeciesListBox.Items.Add("Fjäril");
            }
            else
            {
                // Rensa listan när kryssrutan avmarkeras
                SpeciesListBox.Items.Clear();
            }
        }
        private void ClearSelection()
        {
            // Rensa textfält
            NameTextBox.Clear();
            AgeTextBox.Clear();
            textBox1.Clear();
            textBox2.Clear();
            kattBiTextBox.Clear();

            // Återställ listboxar och comboboxar
            CategoryListBox.ClearSelected();
            SpeciesListBox.ClearSelected();
            GenderComboBox.SelectedIndex = -1;
            CategoryListBox.SelectedIndex = -1;
            SpeciesListBox.SelectedIndex = -1;

            // Återställ kryssrutor och bilder
            checkBoxDomesticated.Checked = false;
            AnimalPictureBox.Image = null;
            selectedImagePath = null;

            // Återställ dropdownlistor
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            // Nollställ valt djur och avmarkera listan
            selectedAnimal = null;
            AnimalListBox.ClearSelected();
            textBox3.Clear();

            groupBox1.Text = "Klass specifikationer";
            groupBox2.Text = "Djur specifikationer";
            label5.Visible = false;
            label7.Visible = false;
            comboBox2.Visible = false;
            comboBox1.Visible = false;
            textBox2.Visible = false;
            kattBiTextBox.Visible = false;

        }
        private void AnimalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AnimalListBox.SelectedIndex == -1)
                return;

            Djur selected = AnimalListBox.SelectedItem as Djur;
            if (selected == null)
                return;

            // Om användaren klickar på en redan vald post, avmarkera och rensa
            if (selected == selectedAnimal)
            {
                AnimalListBox.ClearSelected();
                ClearSelection();
                return;
            }

            selectedAnimal = selected;
            textBox1.Text = selectedAnimal.GetExtraInfo();
            DisplayFoodSchedule(selectedAnimal);
            AnimalPictureBox.Image = string.IsNullOrEmpty(selectedAnimal.ImagePath)
                ? null
                : System.Drawing.Image.FromFile(selectedAnimal.ImagePath);
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void AddImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Bildfiler|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                AnimalPictureBox.Image = System.Drawing.Image.FromFile(selectedImagePath);
            }
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string value = comboBox2.SelectedItem.ToString();
            }
        }
        private void DisplayFoodSchedule(Djur selectedAnimal)
        {
            if (selectedAnimal == null)
            {
                textBox3.Clear();
                return;
            }
            FoodSchedule schedule = selectedAnimal.GetFoodSchedule();
            string eaterType = selectedAnimal.EaterType.ToString();
            string foodInfo = $"Ätartyp: {eaterType}\r\nMatschema:\r\n";
            foodInfo += string.Join("\r\n", schedule.GetFoodListInfoStrings());

            textBox3.Text = foodInfo;
        }
        private void SortButton_Click(object sender, EventArgs e)
        {
            if (radioSortByName.Checked)
            {
                animalManager.SortAnimalsByName();
            }
            else if (radioSortBySpecies.Checked)
            {
                animalManager.SortAnimalsBySpecies(); 
            }

            UpdateAnimalListBox();
        }

        private void radioSortByName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpdateAnimalListBox()
        {
            AnimalListBox.Items.Clear();
            foreach (var animal in animalManager.GetAllAnimals())
            {
                AnimalListBox.Items.Add(animal);

            }
        }

        private void AnimalPictureBox_Click(object sender, EventArgs e)
        {

        }
        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void allatare_label_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void kattBiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBoxAnimalDetails_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioSortBySpecies_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
