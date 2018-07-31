using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _08_Hangman
{


	public partial class Form1 : Form
	{
		#region Variables
		List<Word> words = new List<Word>() {
			new Word("BEER","DRINKS"),
			new Word("VODKA","DRINKS"),
			new Word("PROCESSOR","IT"),
			new Word("PRINTER","IN OFFICE"),
			new Word("ROUTER","IT"),
			new Word("PEPSI","DRINKS"),
			new Word("KEYBOARD","HARDWARE")


		};
		List<MyLabel> labels = new List<MyLabel>();
		Word activeWord;
		bool guessed = false;
		int misses = 0;
		#endregion
		public Form1()
		{
			InitializeComponent();
			SetRandomWord();

		}

		#region Classes
		class Word
		{
			public Word(string Word, string Category)
			{
				word = Word;
				category = Category;
			}
			public string word;
			public string category;
		}
		class MyLabel
		{
			public MyLabel(Label l,string letter)
			{
				label = l;
				correctLetter = letter;
			}
			public Label label;
			public string correctLetter;
		}
		#endregion
		#region Events
		private void button1_Click(object sender, EventArgs e)
		{
			if(guessed || misses ==6)
			{
				ClearLabels();
				SetRandomWord();
				button1.Text = "Make guess";
				guessTextBox.Text = "";
				guessed = false;
				return;
			}
			if (guessTextBox.Text.Length == 0) return;
			if(guessTextBox.Text.Length>1)
			{
				if(guessTextBox.Text.ToUpper()==activeWord.word.ToUpper())
				{
					guessTextBox.Text = "YES, you guessed it!";
					ShowCorrectAnswer();
					button1.Text = "Next word";
					guessed = true;
				}else
				{
					misses += 1;
					CheckIfAlive();

				}
			}else
			{
				string letter = guessTextBox.Text.ToUpper();
				if (activeWord.word.Contains(letter))
				{
					for (int i = 0; i < labels.Count; i++)
					{
						if (labels[i].correctLetter == letter)
						{
							labels[i].label.Text = labels[i].correctLetter;
						
						}
					}
					if(CheckIfWonWithLetters())
					{
						guessTextBox.Text = "YES, you guessed it!";
						ShowCorrectAnswer();
						button1.Text = "Next word";
						guessed = true;
					}
				}
				else
				{
					misses += 1;
					missedLetters.Text += letter + " ";
					guessTextBox.Text = "";
					CheckIfAlive();					
				}
				guessTextBox.Text = "";
			}
			
		}
		private void guessTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button1.PerformClick();
			}
		}
		#endregion
		#region Functions
		private void ClearLabels()
		{
			for(int i =0;i<labels.Count;i++)
			{
				Controls.Remove(labels[i].label);
			}
			labels.Clear();
		}
		private bool CheckIfWonWithLetters()
		{
			int counter = 0;
			for(int i =0;i<labels.Count;i++)
			{
				if(labels[i].label.Text==labels[i].correctLetter)
				{
					counter++;
				}
			}
			if(counter==activeWord.word.Length)
			{
				return true;
			}else return false;

		}
		private void CheckIfAlive()
		{
			
			if (misses == 6)
			{
				guessTextBox.Text = "Oh noo, you're dead!";
				ShowCorrectAnswer();
				button1.Text = "Next word";
			}
			else
			{
				switch (misses)
				{
					case 1:
						{
							picture.Image = Properties.Resources.Hangman1;
							break;
						}
					case 2:
						{
							picture.Image = Properties.Resources.Hangman2;
							break;
						}
					case 3:
						{
							picture.Image = Properties.Resources.Hangman3;
							break;
						}
					case 4:
						{
							picture.Image = Properties.Resources.Hangman4;
							break;
						}
					case 5:
						{
							picture.Image = Properties.Resources.Hangman5;
							break;
						}
					case 6:
						{
							picture.Image = Properties.Resources.Hangman6;
							break;
						}
					default: break;
				}

				
				
			}

		}
		private void ShowCorrectAnswer()
		{
			for (int i = 0; i < labels.Count; i++)
			{ 
				
					labels[i].label.Text = labels[i].correctLetter;
			}
		}
		private void SetRandomWord()
		{
			misses = 0;
			missedLetters.Text = "";
			picture.Image = Properties.Resources.Hangman0;
			activeWord = words[new Random().Next(0, words.Count)];
			InitLettersUnderlines(activeWord.word);
			categoryLabel.Text = activeWord.category;
		}


		private void InitLettersUnderlines(string word)
		{
			Label lastLabel = new Label()
			{
				Location = new Point(260, 203),
				Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold),
				Text = "_",
				AutoSize = true
			};
			labels.Add(new MyLabel(lastLabel, activeWord.word[0].ToString()));
			Controls.Add(lastLabel);
			for (int i = 1; i < word.Length; i++)
			{
				Label label = new Label()
				{
					Location = new Point(lastLabel.Location.X + 38, 203),
					Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold),
					Text = "_",
					AutoSize = true
				};
				labels.Add(new MyLabel(label, activeWord.word[i].ToString()));
				Controls.Add(label);
				lastLabel = label;

			}

		}
		#endregion


		
	}
}
