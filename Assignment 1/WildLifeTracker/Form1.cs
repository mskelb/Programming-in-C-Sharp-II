using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WildlifeTracker;
using WildLifeTrackerForm;

namespace WildlifeTrackerWinForms
{
    public partial class Form1 : Form
    {
        private bool isUpdating = false; // Förhindrar cirkulär uppdatering
        private List<Djur> animalList = new List<Djur>();
        private Djur selectedAnimal = null; // Håller koll på valt djur
        private string selectedImagePath = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Fyller i kategorier och arter vid start
            CategoryListBox.Items.Add("Däggdjur");
            CategoryListBox.Items.Add("Fågel");
            CategoryListBox.Items.Add("Insekt");

            // Förifyll könsalternativ
            GenderComboBox.Items.Add("Hane");
            GenderComboBox.Items.Add("Hona");
            GenderComboBox.Items.Add("Okänd");

            // Se till att SpeciesListBox uppdateras vid val av kategori
            CategoryListBox.SelectedIndexChanged += CategoryListBox_SelectedIndexChanged;
        }

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryListBox.SelectedItem == null || isUpdating)
                return;

            string selectedCategory = CategoryListBox.SelectedItem.ToString();

            checkBoxListAll.Checked = false; 
            // Töm listan endast om den inte redan innehåller rätt djur
            SpeciesListBox.Items.Clear();

            if (selectedCategory == "Däggdjur")
            {
                SpeciesListBox.Items.Add("Hund");
                SpeciesListBox.Items.Add("Katt");
            }
            else if (selectedCategory == "Fågel")
            {
                SpeciesListBox.Items.Add("Duva");
                SpeciesListBox.Items.Add("Falk");
            }
            else if (selectedCategory == "Insekt")
            {
                SpeciesListBox.Items.Add("Bi");
                SpeciesListBox.Items.Add("Fjäril");
            }
        }

        private void SpeciesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SpeciesListBox.SelectedItem == null || isUpdating)
                return;

            string selectedSpecies = SpeciesListBox.SelectedItem.ToString();

            // Sätt flaggan för att förhindra cirkulär uppdatering
            isUpdating = true;

            if (selectedSpecies == "Hund" || selectedSpecies == "Katt")
            {
                CategoryListBox.SelectedItem = "Däggdjur";
            }
            else if (selectedSpecies == "Duva" || selectedSpecies == "Falk")
            {
                CategoryListBox.SelectedItem = "Fågel";
            }
            else if (selectedSpecies == "Bi" || selectedSpecies == "Fjäril")
            {
                CategoryListBox.SelectedItem = "Insekt";
            }

            // Avmarkera flaggan efter uppdatering
            isUpdating = false;
        }

        private void checkBoxListAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxListAll.Checked)
            {
                // Rensa listan och lägg till alla arter
                SpeciesListBox.Items.Clear();
                SpeciesListBox.Items.Add("Hund");
                SpeciesListBox.Items.Add("Katt");
                SpeciesListBox.Items.Add("Duva");
                SpeciesListBox.Items.Add("Falk");
                SpeciesListBox.Items.Add("Bi");
                SpeciesListBox.Items.Add("Fjäril");

                // Avmarkera kategori-listan (för att visa alla djur)
                CategoryListBox.ClearSelected();
            }
            else
            {
                // Om kryssrutan avmarkeras, rensa och visa rätt kategori
                SpeciesListBox.Items.Clear();

                if (CategoryListBox.SelectedItem != null)
                {
                    CategoryListBox_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            if (!int.TryParse(AgeTextBox.Text, out int age))
            {
                MessageBox.Show("Vänligen ange en giltig ålder.");
                return;
            }

            string gender = GenderComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Vänligen välj kön.");
                return;
            }

            bool isDomesticated = checkBoxDomesticated.Checked;
            string category = CategoryListBox.SelectedItem?.ToString();
            string species = SpeciesListBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(species))
            {
                MessageBox.Show("Vänligen välj kategori och art.");
                return;
            }

            Djur newAnimal = null;

            switch (category)
            {
                case "Däggdjur":
                    if (species == "Hund")
                    {
                        bool likesBalls = MessageBox.Show("Gillar hunden att leka med bollar?", "Egenskap", MessageBoxButtons.YesNo) == DialogResult.Yes;
                        newAnimal = new Hund(name, age, gender, isDomesticated, 42, likesBalls) { ImagePath = selectedImagePath };
                    }
                    else if (species == "Katt")
                    {
                        if (!int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Ange sötindex (0-10):", "Kattens egenskap"), out int cutenessIndex))
                        {
                            MessageBox.Show("Ogiltigt sötindex.");
                            return;
                        }
                        newAnimal = new Katt(name, age, gender, isDomesticated, 30, cutenessIndex) { ImagePath = selectedImagePath };
                    }
                    break;

                case "Fågel":
                    if (!double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Ange vingbredd i cm:", "Fågelns egenskap"), out double wingSpan))
                    {
                        MessageBox.Show("Ogiltig vingbredd.");
                        return;
                    }

                    if (species == "Duva")
                    {
                        bool isPeaceDove = MessageBox.Show("Är detta en fridens duva?", "Egenskap", MessageBoxButtons.YesNo) == DialogResult.Yes;
                        newAnimal = new Duva(name, age, gender, wingSpan, isPeaceDove) { ImagePath = selectedImagePath };
                    }
                    else if (species == "Falk")
                    {
                        if (!double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Ange flyghastighet i km/h:", "Falkens egenskap"), out double flightSpeed))
                        {
                            MessageBox.Show("Ogiltig flyghastighet.");
                            return;
                        }
                        newAnimal = new Falk(name, age, gender, wingSpan, flightSpeed) { ImagePath = selectedImagePath };
                    }
                    break;

                case "Insekt":
                    if (species == "Bi")
                    {
                        bool isCute = MessageBox.Show("Är biet gulligt?", "Egenskap", MessageBoxButtons.YesNo) == DialogResult.Yes;
                        newAnimal = new Bi(name, age, gender, isCute) { ImagePath = selectedImagePath };
                    }
                    else if (species == "Fjäril")
                    {
                        bool isBeautiful = MessageBox.Show("Är fjärilen vacker?", "Egenskap", MessageBoxButtons.YesNo) == DialogResult.Yes;
                        newAnimal = new Fjäril(name, age, gender, isBeautiful) { ImagePath = selectedImagePath };
                    }
                    break;

                default:
                    MessageBox.Show("Ogiltig kategori.");
                    return;
            }

            if (newAnimal != null)
            {
                newAnimal.IsDomesticated = isDomesticated; // Spara domesticerad-status
                animalList.Add(newAnimal);
                AnimalListBox.Items.Add($"ID: {newAnimal.ID}, {species}, {newAnimal.Name}");
            }

            // Rensa fält efter att djuret har lagts till
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SpeciesListBox.SelectedItem = -1;
            CategoryListBox.SelectedItem = -1;
            GenderComboBox.SelectedIndex = -1; // Avmarkera kön
            checkBoxDomesticated.Checked = false; // Återställ domesticerad-rutan
            AnimalPictureBox.Image = null; // Rensa bild
            selectedImagePath = null; // Rensa den sparade bildsökvägen
        }
        private void checkBoxDomesticated_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedAnimal != null)
            {
                selectedAnimal.IsDomesticated = checkBoxDomesticated.Checked;
            }
        }
        private void ClearSelection()
        {
            textBox1.Clear(); // Rensa djurdetaljer
            AnimalPictureBox.Image = null; // Rensa bild
            selectedAnimal = null; // Nollställ det valda djuret
            AnimalListBox.ClearSelected(); // Avmarkera alla val i listan
        }
        private void AnimalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AnimalListBox.SelectedIndex == -1)
                return;
            // Om användaren klickar på en redan vald post, avmarkera och rensa
            if (selectedAnimal != null && AnimalListBox.SelectedIndex == animalList.IndexOf(selectedAnimal))
            {
                AnimalListBox.ClearSelected(); // Avmarkera
                ClearSelection();
                return;
            }
            int selectedIndex = AnimalListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < animalList.Count)
            {
                selectedAnimal = animalList[selectedIndex];

                // Visar all information direkt genom ToString()
                textBox1.Text = selectedAnimal.ToString();

                // Visa bild om det finns en
                AnimalPictureBox.Image = string.IsNullOrEmpty(selectedAnimal.ImagePath)
                    ? null
                    : System.Drawing.Image.FromFile(selectedAnimal.ImagePath);
            }
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
                selectedImagePath = openFileDialog.FileName; // Store the path
                AnimalPictureBox.Image = System.Drawing.Image.FromFile(selectedImagePath); // Show preview
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
    }
}
