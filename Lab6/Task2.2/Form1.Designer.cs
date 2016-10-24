namespace Task2._2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.errorLabel = new System.Windows.Forms.Label();
			this.ipTB = new System.Windows.Forms.TextBox();
			this.timeLabel = new System.Windows.Forms.Label();
			this.timeTB = new System.Windows.Forms.TextBox();
			this.carNumberLabel = new System.Windows.Forms.Label();
			this.ipLabel = new System.Windows.Forms.Label();
			this.patronymicLabel = new System.Windows.Forms.Label();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.patronymicTB = new System.Windows.Forms.TextBox();
			this.nameTB = new System.Windows.Forms.TextBox();
			this.surnameTB = new System.Windows.Forms.TextBox();
			this.mainLabel = new System.Windows.Forms.Label();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.BackColor = System.Drawing.Color.LightCoral;
			this.errorLabel.Location = new System.Drawing.Point(71, 227);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(184, 13);
			this.errorLabel.TabIndex = 37;
			this.errorLabel.Text = "Одна из форм заполнена не верно";
			this.errorLabel.Visible = false;
			// 
			// ipTB
			// 
			this.ipTB.Location = new System.Drawing.Point(170, 194);
			this.ipTB.Name = "ipTB";
			this.ipTB.Size = new System.Drawing.Size(113, 20);
			this.ipTB.TabIndex = 33;
			this.ipTB.Text = "192.168.0.1";
			this.ipTB.Validating += new System.ComponentModel.CancelEventHandler(this.ipTB_Validating);
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Location = new System.Drawing.Point(71, 170);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(40, 13);
			this.timeLabel.TabIndex = 31;
			this.timeLabel.Text = "Время";
			// 
			// timeTB
			// 
			this.timeTB.Location = new System.Drawing.Point(170, 167);
			this.timeTB.Name = "timeTB";
			this.timeTB.Size = new System.Drawing.Size(113, 20);
			this.timeTB.TabIndex = 30;
			this.timeTB.Text = "22:30";
			this.timeTB.Validating += new System.ComponentModel.CancelEventHandler(this.timeTB_Validating);
			// 
			// carNumberLabel
			// 
			this.carNumberLabel.AutoSize = true;
			this.carNumberLabel.Location = new System.Drawing.Point(71, 144);
			this.carNumberLabel.Name = "carNumberLabel";
			this.carNumberLabel.Size = new System.Drawing.Size(33, 13);
			this.carNumberLabel.TabIndex = 29;
			this.carNumberLabel.Text = "Дата";
			// 
			// ipLabel
			// 
			this.ipLabel.AutoSize = true;
			this.ipLabel.Location = new System.Drawing.Point(71, 197);
			this.ipLabel.Name = "ipLabel";
			this.ipLabel.Size = new System.Drawing.Size(62, 13);
			this.ipLabel.TabIndex = 27;
			this.ipLabel.Text = "IPv4 адрес";
			// 
			// patronymicLabel
			// 
			this.patronymicLabel.AutoSize = true;
			this.patronymicLabel.Location = new System.Drawing.Point(71, 118);
			this.patronymicLabel.Name = "patronymicLabel";
			this.patronymicLabel.Size = new System.Drawing.Size(54, 13);
			this.patronymicLabel.TabIndex = 26;
			this.patronymicLabel.Text = "Отчество";
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(69, 66);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(56, 13);
			this.surnameLabel.TabIndex = 25;
			this.surnameLabel.Text = "Фамилия";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(71, 92);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(29, 13);
			this.nameLabel.TabIndex = 24;
			this.nameLabel.Text = "Имя";
			// 
			// patronymicTB
			// 
			this.patronymicTB.Location = new System.Drawing.Point(170, 115);
			this.patronymicTB.Name = "patronymicTB";
			this.patronymicTB.Size = new System.Drawing.Size(113, 20);
			this.patronymicTB.TabIndex = 22;
			this.patronymicTB.Text = "Иванович";
			this.patronymicTB.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
			// 
			// nameTB
			// 
			this.nameTB.Location = new System.Drawing.Point(170, 89);
			this.nameTB.Name = "nameTB";
			this.nameTB.Size = new System.Drawing.Size(113, 20);
			this.nameTB.TabIndex = 21;
			this.nameTB.Text = "Иван";
			this.nameTB.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
			// 
			// surnameTB
			// 
			this.surnameTB.Location = new System.Drawing.Point(170, 63);
			this.surnameTB.Name = "surnameTB";
			this.surnameTB.Size = new System.Drawing.Size(113, 20);
			this.surnameTB.TabIndex = 20;
			this.surnameTB.Text = "Иванов";
			this.surnameTB.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
			// 
			// mainLabel
			// 
			this.mainLabel.AutoSize = true;
			this.mainLabel.Location = new System.Drawing.Point(99, 23);
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Size = new System.Drawing.Size(199, 13);
			this.mainLabel.TabIndex = 19;
			this.mainLabel.Text = "Сведения о регистрации посетитилей";
			// 
			// datePicker
			// 
			this.datePicker.Location = new System.Drawing.Point(170, 141);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(113, 20);
			this.datePicker.TabIndex = 38;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(366, 261);
			this.Controls.Add(this.datePicker);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.ipTB);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.timeTB);
			this.Controls.Add(this.carNumberLabel);
			this.Controls.Add(this.ipLabel);
			this.Controls.Add(this.patronymicLabel);
			this.Controls.Add(this.surnameLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.patronymicTB);
			this.Controls.Add(this.nameTB);
			this.Controls.Add(this.surnameTB);
			this.Controls.Add(this.mainLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label errorLabel;
		private System.Windows.Forms.TextBox ipTB;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.TextBox timeTB;
		private System.Windows.Forms.Label carNumberLabel;
		private System.Windows.Forms.Label ipLabel;
		private System.Windows.Forms.Label patronymicLabel;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox patronymicTB;
		private System.Windows.Forms.TextBox nameTB;
		private System.Windows.Forms.TextBox surnameTB;
		private System.Windows.Forms.Label mainLabel;
		private System.Windows.Forms.DateTimePicker datePicker;
	}
}

