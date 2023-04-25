using MongoDB.Driver; // necessary for MongoDB
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

namespace Brainiac
{
    public partial class Form1 : Form
    {
        // MongoDB fields 
        private MongoClient client; // MongoDB client
        private IMongoDatabase database; // MongoDB database
        private IMongoCollection<FlashCard> collection; // MongoDB collection for flashcards
        private List<FlashCard> flashcards; // List of flashcards

        // Flashcard fields
        private int currentIndex; // Index of the current flashcard
        private bool showingAnswer; // Whether the answer or question is being displayed

        public Form1()
        {
            InitializeComponent(); // Initializes form components
            InitializeDatabase(); // Initializes the MongoDB database
            LoadFlashcards(); // Loads flashcards from the database
            DisplayCurrentFlashcard(); // Displays the current flashcard in the TextBox
        }

        // Initializes the MongoDB database connection and the flashcards collection
        private void InitializeDatabase()
        {
            // MongoDB connection string to connect to the database
            string connectionString = "mongodb+srv://dlponder3082:Mw010203$$@cluster0.wyatmul.mongodb.net/?retryWrites=true&w=majority";
            
            // instance of the MongoDB client, creates a connection to the database
            client = new MongoClient(connectionString);
            
            // get the actual database of flashcards from the client connection
            database = client.GetDatabase("flashcards");

            // get the collection of flashcards from the database (like a table in SQL)
            collection = database.GetCollection<FlashCard>("cards");
        }

        // Loads all flashcards from the database
        private void LoadFlashcards()
        {
            // Gets all flashcards from the database and converts them to a list
            flashcards = collection.Find(_ => true).ToList();

            // set the current index to 0 (first flashcard)
            currentIndex = 0;
        }

        // Displays the current flashcard's question
        private void DisplayCurrentFlashcard()
        {
            // Check if there are any flashcards in the list
            if (flashcards.Count > 0)
            {
                // Set the text of the TextBox to the current flashcard's question
                FlashcardTextBox.Text = flashcards[currentIndex].Question;
               
                // Set visibilty to true so the TextBox is visible
                FlashcardTextBox.Visible = true; 
            }
        }

        // Add button click event handler
        private void Add_Click(object sender, EventArgs e)
        {
            var addForm = new AddFlashcardForm(); // Creates a new AddFlashcardForm instance
            addForm.ShowDialog(); // Shows the AddFlashcardForm as a dialog box

            var newFlashcard = addForm.Flashcard; // Gets the new flashcard from the AddFlashcardForm
            if (newFlashcard != null)
            {
                collection.InsertOne(newFlashcard); // Inserts the new flashcard into the database
                flashcards.Add(newFlashcard); // Adds the new flashcard to the flashcards list

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

        // Extracts chapter number from chapter text "Chapter 1" -> 1
        private int ExtractChapterNumber(string chapterText)
        {
            // Split the chapterText string into an array of strings
            string[] parts = chapterText.Split(' ');

            // Try to parse the second part of the array into an integer
            int.TryParse(parts[1], out int chapterNumber);
            
            // Return the chapter number
            return chapterNumber;
        }

        // Previous button click event handler
        private void Previous_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--; // Decreases the currentIndex by 1
                DisplayCurrentFlashcard(); // current flashcard is now the previous flashcard
                FlashcardTextBox.Visible = true; // Set visibility to true so that the flashcard is visible
            }
        }

        // function that simulates a flip of a flashcard to display the answer
        private void Flip_Click(object sender, EventArgs e)
        {
            // check if there are any flashcards in the list
            if (flashcards.Count > 0)
            {
                // check if the answer is being displayed
                if (showingAnswer)
                {
                    // display the question
                    FlashcardTextBox.Text = flashcards[currentIndex].Question;
                }
                else // otherwise show the answer
                {
                    FlashcardTextBox.Text = flashcards[currentIndex].Answer;
                }

                // set the showingAnswer variable to the opposite of what it was 
                showingAnswer = !showingAnswer;
            }
        }

        // shows the next flashcard in the list
        private void Next_Click(object sender, EventArgs e)
        {
            // if the current index is less than the number of flashcards in the list
            if (currentIndex < flashcards.Count - 1)
            {
                // increment the current index by 1
                currentIndex++;

                // display the current flashcard
                DisplayCurrentFlashcard();
                FlashcardTextBox.Visible = true; // Set visibility to true
            }
        }

        
        /*private void Flashcard_Click(object sender, EventArgs e)
        {
            // Calls the Flip_Click method to flip the flashcard and display the answer 
            Flip_Click(sender, e);
        }*/

        private void QuestionLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // variable that checks if a "Chapter" field exists in a FlashCard document
            // using the Exists method from the MongoDB driver
            var filter = Builders<FlashCard>.Filter.Exists("Chapter", true);

            // queries the "cards" collection in the database to find distinct "Chapter" values
            // from all the FlashCard documents that match the filter. It returns a list of distinct
            // chapter numbers as strings.
            var chapters = collection.Distinct<string>("Chapter", filter).ToList();


            // Sort the chapters in ascending order
            chapters = chapters.OrderBy(chapter =>
            {
                int.TryParse(chapter, out int result);
                return result;
            }).ToList();

            // Temporarily remove the event handler
           comboBoxChapters.SelectedIndexChanged -= comboBoxChapters_SelectedIndexChanged;

            // Add the sorted chapters to the ComboBox
            string chapterText;
            foreach (var chapter in chapters)
            {
                chapterText = $"Chapter {chapter}";
                comboBoxChapters.Items.Add(chapterText);
                Console.WriteLine($"Added to ComboBox: {chapterText}"); // Debugging information
            }

            // Reattach the event handler
            comboBoxChapters.SelectedIndexChanged += comboBoxChapters_SelectedIndexChanged;

            // sets the selected index of the comboBoxChapters to 0
            // if there are items in the ComboBox
            // so the first chapter is selected by default when the application starts
            if (comboBoxChapters.Items.Count > 0)
            {
                comboBoxChapters.SelectedIndex = 0;
            }
        }

        // function that displays the flashcards from the selected chapter
        private void comboBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected chapter from the ComboBox
            string selectedItemText = comboBoxChapters.SelectedItem.ToString();

            // Extract the chapter number from the selected item
            string selectedChapter = selectedItemText.Split(' ')[1];

            // Filter the flashcards based on the selected chapter using the MongoDB driver filter builder
            var filter = Builders<FlashCard>.Filter.Eq(card => card.Chapter, selectedChapter);
            
            // Get the flashcards from the database that match the filter
            // and store them in the flashcards list 
            flashcards = collection.Find(filter).ToList();

            // Debugging information 
            Console.WriteLine($"Selected chapter: {selectedChapter}");
            Console.WriteLine($"Number of flashcards: {flashcards.Count}");

            // Reset the current index to 0 so that the first flashcard is displayed
            currentIndex = 0;

            // Display the current set of flashcards
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

        // function that fetches cards bases on the corresponding box number 
        private List<FlashCard> GetFlashcardsForReview()
        {
            var filter = Builders<FlashCard>.Filter.Empty;
            var allFlashcards = collection.Find(filter).ToList();
            var currentDate = DateTime.Now.Date;

            return allFlashcards.Where(card =>
                card.Box == 1 ||
                (card.Box == 2 && (currentDate - card.LastReviewDate).TotalDays >= 3) ||
                (card.Box == 3 && (currentDate - card.LastReviewDate).TotalDays >= 5) ||
                (card.Box == 4 && (currentDate - card.LastReviewDate).TotalDays >= 7)
            ).ToList();
        }

        // if answer is correct then increment the box number by 1
        private void HandleCorrectAnswer()
        {
            if (flashcards[currentIndex].Box < 4)
            {
                flashcards[currentIndex].Box++;
            }
            flashcards[currentIndex].LastReviewDate = DateTime.Now;
            collection.ReplaceOne(card => card.Id == flashcards[currentIndex].Id, flashcards[currentIndex]);

            // if correct, increment the correct answer count for the progress stats
            flashcards[currentIndex].LastCorrectAnswerDate = DateTime.Now;
            collection.ReplaceOne(card => card.Id == flashcards[currentIndex].Id, flashcards[currentIndex]);

        }

        // if answer is incorrect then set the box number to 1
        private void HandleIncorrectAnswer()
        {
            flashcards[currentIndex].Box = 1;
            flashcards[currentIndex].LastReviewDate = DateTime.Now;
            collection.ReplaceOne(card => card.Id == flashcards[currentIndex].Id, flashcards[currentIndex]);

            // if incorrect, increment the incorrect answer count for the progress stats 
            flashcards[currentIndex].LastIncorrectAnswerDate = DateTime.Now;
            collection.ReplaceOne(card => card.Id == flashcards[currentIndex].Id, flashcards[currentIndex]);
        }


        // function that displays all of the chapters currently in the database 
        private void StudyAll_Click(object sender, EventArgs e)
        {
            // Get all flashcards from the database
            flashcards = GetFlashcardsForReview();
            currentIndex = 0;
            DisplayCurrentFlashcard();
        }

        private void CorrectAnswerButton_Click(object sender, EventArgs e)
        {
            HandleCorrectAnswer();
            Next_Click(sender, e);
        }

        private void IncorrectAnswerButton_Click(object sender, EventArgs e)
        {
            HandleIncorrectAnswer();
            Next_Click(sender, e);
        }

        // method to display the users progress statistics
        private void DisplayProgressStatistics()
        {
            int totalFlashcards = flashcards.Count;
            int totalCorrectAnswers = flashcards.Sum(card => card.CorrectAnswers);
            int totalIncorrectAnswers = flashcards.Sum(card => card.IncorrectAnswers);
            int totalAnswers = totalCorrectAnswers + totalIncorrectAnswers;

            MessageBox.Show($"Total flashcards: {totalFlashcards}\n" +
                            $"Total correct answers: {totalCorrectAnswers}\n" +
                            $"Total incorrect answers: {totalIncorrectAnswers}\n" +
                            $"Total answers: {totalAnswers}");
        }

        // method to display more detailed progress statistics
        private void DisplayDetailedProgressStatistics()
        {
            int totalFlashcards = flashcards.Count;
            int totalCorrectAnswers = flashcards.Sum(card => card.CorrectAnswers);
            int totalIncorrectAnswers = flashcards.Sum(card => card.IncorrectAnswers);
            int totalAnswers = totalCorrectAnswers + totalIncorrectAnswers;

            int lastWeekCorrectAnswers = flashcards
                .Where(card => card.LastCorrectAnswerDate != null && (DateTime.Now - card.LastCorrectAnswerDate.Value).TotalDays <= 7)
                .Sum(card => card.CorrectAnswers);

            int lastWeekIncorrectAnswers = flashcards
                .Where(card => card.LastIncorrectAnswerDate != null && (DateTime.Now - card.LastIncorrectAnswerDate.Value).TotalDays <= 7)
                .Sum(card => card.IncorrectAnswers);

            MessageBox.Show($"Total flashcards: {totalFlashcards}\n" +
                            $"Total correct answers: {totalCorrectAnswers}\n" +
                            $"Total incorrect answers: {totalIncorrectAnswers}\n" +
                            $"Total answers: {totalAnswers}\n" +
                            $"\nLast week's correct answers: {lastWeekCorrectAnswers}\n" +
                            $"Last week's incorrect answers: {lastWeekIncorrectAnswers}");
        }

        private void ProgressButton_Click(object sender, EventArgs e)
        {
            // display the progress statistics to user 
            //DisplayProgressStatistics();

            // display more detailed progress statistics to user
            DisplayDetailedProgressStatistics();
        }
    }
    }



