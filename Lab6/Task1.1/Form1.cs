using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1._1
{
	public partial class Form1 : Form
	{
		private char[] _validLetters = {'А', 'В', 'Е', 'К', 'М', 'Н', 'О', 'Р', 'С', 'Т', 'У', 'Х'};
		public Form1()
		{
			InitializeComponent();
		}

		private bool NameValidating(string text)
		{
			text = text.Trim();
			if (string.IsNullOrWhiteSpace(text))
				return false;
			for (int i = 0; i < text.Length; i++)
			{
				if (!char.IsLetter(text[i]))
					return false;
			}
			return true;
		}
		private bool LettersValidating(string letters, int numOfLetters)
		{
			letters = letters.Trim();
			if (letters.Length != numOfLetters)
				return false;
			letters = letters.ToUpper();
			for (int i = 0; i < letters.Length; i++)
			{
				if (!_validLetters.Contains(letters[i]))
				{
					return false;
				}
			}
			return true;
		}
		private bool NumberValidating(string stringNumber, int numberOrder)
		{
			stringNumber = stringNumber.Trim();
			if (stringNumber.Length != numberOrder)
			{
				return false;
			}
			int number;
			if (!int.TryParse(stringNumber, out number))
			{
				return false;
			}
			return true;
		}

		private void Name_Validating(object sender, CancelEventArgs e)
		{
			var textBox = sender as TextBox;
			if (!NameValidating(textBox.Text))
			{
				textBox.BackColor = Color.LightCoral;
				errorLabel.Visible = true;
				errorLabel.Text = "Поле не может быть пустым или содержать символы!";
			}
			else
			{
				textBox.BackColor = Color.SpringGreen;
				errorLabel.Visible = false;
			}
		}

		private void telNumber1TB_Validating(object sender, CancelEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (!NumberValidating(textBox.Text, 3))
			{
				textBox.BackColor = Color.LightCoral;
				errorLabel.Visible = true;
				errorLabel.Text = "Поле должно состоять из трех чисел!";
			}
			else
			{
				textBox.BackColor = Color.SpringGreen;
				errorLabel.Visible = false;
			}
		}

		private void telNumber2TB_Validating(object sender, CancelEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			string text = textBox.Text.Replace(" ", "").Replace("-", "");
			if (!NumberValidating(text, 7))
			{
				textBox.BackColor = Color.LightCoral;
				errorLabel.Visible = true;
				errorLabel.Text = "Поле должно состоять из семи чисел!";
			}
			else
			{
				textBox.BackColor = Color.SpringGreen;
				errorLabel.Visible = false;
			}
		}

		private void carNumber4TB_Validating(object sender, CancelEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (!(NumberValidating(textBox.Text, 1) || NumberValidating(textBox.Text, 2) || NumberValidating(textBox.Text, 3)))
			{
				textBox.BackColor = Color.LightCoral;
				errorLabel.Visible = true;
				errorLabel.Text = "Неверный код региона!";
			}
			else
			{
				textBox.BackColor = Color.SpringGreen;
				errorLabel.Visible = false;
			}
		}

		private void carNumber1TB_Validating(object sender, CancelEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (!LettersValidating(textBox.Text, 1))
			{
				textBox.BackColor = Color.LightCoral;
				errorLabel.Visible = true;
				errorLabel.Text = "Неверно заполен первый символ номера!";
			}
			else
			{
				textBox.BackColor = Color.SpringGreen;
				errorLabel.Visible = false;
			}
		}

		private void carNumber3TB_Validating(object sender, CancelEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (!LettersValidating(textBox.Text, 2))
			{
				textBox.BackColor = Color.LightCoral;
				errorLabel.Visible = true;
				errorLabel.Text = "Неверно заполены последние два символа номера!";
			}
			else
			{
				textBox.BackColor = Color.SpringGreen;
				errorLabel.Visible = false;
			}
		}
	}
}
