﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Brainiac
{
    public partial class AddFlashcardForm : MetroForm
    {
        // Create a new FlashCard object
       
        public FlashCard Flashcard { get; private set; }

        public AddFlashcardForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Get the question and answer from the TextBox controls
            string question = QuestionTextBox.Text;
            string answer = AnswerTextBox.Text;
            string chapter = ChapterTextBox.Text;

            // Create a new flashcard and set the property
            Flashcard = new FlashCard { Question = question, Answer = answer, Chapter = chapter};

            // Close the form
            this.Close();
        }

        private void AddFlashcardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
