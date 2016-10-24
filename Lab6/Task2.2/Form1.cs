using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2._2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private bool NameValidating(string text)
		{
			return !string.IsNullOrWhiteSpace(text);
		}
		private bool TimeValidating(string text)
		{
			string[] textArray = text.Split(':');
			int[] numArray = new int[2];
			if (textArray.Length != 2)
			{
				return false;
			}
			if (!int.TryParse(textArray[0], out numArray[0]) ||
				!int.TryParse(textArray[1], out numArray[1]))
			{
				return false;
			}
			if (numArray[0] < 0 || numArray[0] > 23 ||
				numArray[1] > 59 || numArray[1] < 0)
			{
				return false;
			}
			return true;
		}

		private bool IpValidating(string text)
		{
			string[] textArray = text.Split('.');
			int[] numArray = new int[4];
			if (textArray.Length != 4)
			{
				return false;
			}
			if (!int.TryParse(textArray[0], out numArray[0]) ||
				!int.TryParse(textArray[1], out numArray[1]) ||
				!int.TryParse(textArray[2], out numArray[2]) ||
				!int.TryParse(textArray[3], out numArray[3]))
			{
				return false;
			}
			if (numArray[0] < 127 || numArray[0] > 255 ||
				numArray[1] < 0 || numArray[1] > 255 ||
				numArray[2] < 0 || numArray[2] > 255 ||
				numArray[3] < 0 || numArray[3] > 255)
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
				errorLabel.Text = "Поле не может быть пустым!";
			}
			else
			{
				textBox.BackColor = Color.SpringGreen;
				errorLabel.Visible = false;
			}
		}

		private void timeTB_Validating(object sender, CancelEventArgs e)
		{
			var textBox = sender as TextBox;
			if (!TimeValidating(textBox.Text))
			{
				textBox.BackColor = Color.LightCoral;
				errorLabel.Visible = true;
				errorLabel.Text = "Неверный формат времени (HH:MM)!";
			}
			else
			{
				textBox.BackColor = Color.SpringGreen;
				errorLabel.Visible = false;
			}
		}

		private void ipTB_Validating(object sender, CancelEventArgs e)
		{
			var textBox = sender as TextBox;
			if (!IpValidating(textBox.Text))
			{
				textBox.BackColor = Color.LightCoral;
				errorLabel.Visible = true;
				errorLabel.Text = "Неверный формат ip адресса (255.0.0.1)!";
			}
			else
			{
				textBox.BackColor = Color.SpringGreen;
				errorLabel.Visible = false;
			}
		}
	}
}
