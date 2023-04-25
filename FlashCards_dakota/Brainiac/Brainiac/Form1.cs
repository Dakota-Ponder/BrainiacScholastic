using MongoDB.Driver;  // necessary for mongoDB
using MetroFramework.Forms;  // necessary for metro framework
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Interfaces;

namespace Brainiac
{
    public partial class Form1 : MetroForm
    {
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<FlashCard> collection;
        private List<FlashCard> flashcards;
        private int currentIndex;
        private bool showingAnswer;

        public Form1()
        {
            InitializeComponent();
            // Apply the style and theme
            ApplyThemeAndStyle();
            InitializeDatabase();
            LoadFlashcards();
            DisplayCurrentFlashcard();

        }

        private void ApplyThemeAndStyle()
        {
            // Set the form background color to Navy
            this.BackColor = Color.Navy;

            // Set the font color to Fuchsia
            this.ForeColor = Color.Fuchsia;

            // Apply the theme and style from the metroStyleManager1 instance
            this.Theme = metroStyleManager1.Theme;
            this.Style = metroStyleManager1.Style;

            // Update theme and style for all controls on the form
            foreach (Control control in this.Controls)
            {
                ApplyThemeAndStyleToControl(control);
            }
        }

        private void ApplyThemeAndStyleToControl(Control control)
        {
            // Set the font color to Fuchsia for all controls
            control.ForeColor = Color.Fuchsia;

            if (control is MetroFramework.Controls.MetroLabel metroLabel)
            {
                metroLabel.Theme = metroStyleManager1.Theme;
                metroLabel.Style = metroStyleManager1.Style;
            }
            else if (control is MetroFramework.Controls.MetroTextBox metroTextBox)
            {
                metroTextBox.Theme = metroStyleManager1.Theme;
                metroTextBox.Style = metroStyleManager1.Style;
            }
            else if (control is MetroFramework.Controls.MetroButton metroButton)
            {
                metroButton.Theme = metroStyleManager1.Theme;
                metroButton.Style = metroStyleManager1.Style;
            }
            else if (control is MetroFramework.Controls.MetroComboBox metroComboBox)
            {
                metroComboBox.Theme = metroStyleManager1.Theme;
                metroComboBox.Style = metroStyleManager1.Style;
            }
            // Add other MetroFramework control types if needed

            foreach (Control childControl in control.Controls)
            {
                ApplyThemeAndStyleToControl(childControl);
            }
        }



        private void InitializeDatabase()
        {
            string connectionString = "mongodb+srv://dlponder3082:Mw010203$$@cluster0.wyatmul.mongodb.net/?retryWrites=true&w=majority";
            client = new MongoClient(connectionString);
            database = client.GetDatabase("flashcards");
            collection = database.GetCollection<FlashCard>("cards");
        }

        private void LoadFlashcards()
        {
            flashcards = collection.Find(_ => true).ToList();
            currentIndex = 0;
        }

        private void DisplayCurrentFlashcard()
        {
            if (flashcards.Count > 0)
            {
                FlashcardTextBox.Text = flashcards[currentIndex].Question;
                FlashcardTextBox.Visible = true; // Set visibility to true
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var addForm = new AddFlashcardForm();
            addForm.ShowDialog();

            var newFlashcard = addForm.Flashcard;
            if (newFlashcard != null)
            {
                collection.InsertOne(newFlashcard);
                flashcards.Add(newFlashcard);

                string selectedItemText = comboBoxChapters.SelectedItem.ToString();
                int selectedChapter = ExtractChapterNumber(selectedItemText);
                if (newFlashcard.Chapter == selectedChapter.ToString(CultureInfo.InvariantCulture))
                {
                    currentIndex = flashcards.Count - 1;
                    DisplayCurrentFlashcard();
                    FlashcardTextBox.Visible = true; // Set visibility to true
                }
            }
        }

        private int ExtractChapterNumber(string chapterText)
        {
            string[] parts = chapterText.Split(' ');
            int.TryParse(parts[1], out int chapterNumber);
            return chapterNumber;
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayCurrentFlashcard();
                FlashcardTextBox.Visible = true; // Set visibility to true
            }
        }

        private void Flip_Click(object sender, EventArgs e)
        {
            if (flashcards.Count > 0)
            {
                if (showingAnswer)
                {
                    FlashcardTextBox.Text = flashcards[currentIndex].Question;
                }
                else
                {
                    FlashcardTextBox.Text = flashcards[currentIndex].Answer;
                }
                showingAnswer = !showingAnswer;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (currentIndex < flashcards.Count - 1)
            {
                currentIndex++;
                DisplayCurrentFlashcard();
                FlashcardTextBox.Visible = true; // Set visibility to true
            }
        }

        private void Flashcard_Click(object sender, EventArgs e)
        {
            Flip_Click(sender, e);
        }

        private void QuestionLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fetch distinct chapters from the database and add them to the ComboBox
            var filter = Builders<FlashCard>.Filter.Exists("Chapter", true);
            var chapters = collection.Distinct<string>("Chapter", filter).ToList();


            // Sort the chapters in ascending order
            chapters = chapters.OrderBy(chapter =>
            {
                int.TryParse(chapter, out int result);
                return result;
            }).ToList();

            // Temporarily remove the event handler
            comboBoxChapters.SelectedIndexChanged -= comboBoxChapters_SelectedIndexChanged;

            // Add chapters to the ComboBox
            string chapterText;
            foreach (var chapter in chapters)
            {
                chapterText = $"Chapter {chapter}";
                comboBoxChapters.Items.Add(chapterText);
                Console.WriteLine($"Added to ComboBox: {chapterText}"); // Debugging information
            }

            // Reattach the event handler
            comboBoxChapters.SelectedIndexChanged += comboBoxChapters_SelectedIndexChanged;

            // set the first chapter to 0
            if (comboBoxChapters.Items.Count > 0)
            {
                comboBoxChapters.SelectedIndex = 0;
            }
        }

        private void comboBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected chapter
            string selectedItemText = comboBoxChapters.SelectedItem.ToString();
            string selectedChapter = selectedItemText.Split(' ')[1];

            // Filter the flashcards based on the selected chapter
            var filter = Builders<FlashCard>.Filter.Eq(card => card.Chapter, selectedChapter);
            flashcards = collection.Find(filter).ToList();

            // Debugging information
            Console.WriteLine($"Selected chapter: {selectedChapter}");
            Console.WriteLine($"Number of flashcards: {flashcards.Count}");

            // Reset the current index and update the UI with the new set of flashcards
            currentIndex = 0;

            if (flashcards.Count > 0)
            {
                FlashcardTextBox.Text = flashcards[currentIndex].Question;
            }
            else
            {
                FlashcardTextBox.Text = "No flashcards for this chapter.";
            }
        }

        private void AnswerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}


