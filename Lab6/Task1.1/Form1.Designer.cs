namespace Task1._1
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
			this.mainLabel = new System.Windows.Forms.Label();
			this.surnameTB = new System.Windows.Forms.TextBox();
			this.nameTB = new System.Windows.Forms.TextBox();
			this.patronymicTB = new System.Windows.Forms.TextBox();
			this.telNumber1TB = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.patronymicLabel = new System.Windows.Forms.Label();
			this.telNumberLabel = new System.Windows.Forms.Label();
			this.carNumberLabel = new System.Windows.Forms.Label();
			this.carNumber1TB = new System.Windows.Forms.TextBox();
			this.carColorLabel = new System.Windows.Forms.Label();
			this.carColorTB = new System.Windows.Forms.TextBox();
			this.telCodeTB = new System.Windows.Forms.TextBox();
			this.telNumber2TB = new System.Windows.Forms.TextBox();
			this.carNumber2TB = new System.Windows.Forms.TextBox();
			this.carNumber3TB = new System.Windows.Forms.TextBox();
			this.carNumber4TB = new System.Windows.Forms.TextBox();
			this.errorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// mainLabel
			// 
			this.mainLabel.AutoSize = true;
			this.mainLabel.Location = new System.Drawing.Point(113, 9);
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Size = new System.Drawing.Size(167, 13);
			this.mainLabel.TabIndex = 0;
			this.mainLabel.Text = "Сведения о владельце машины";
			// 
			// surnameTB
			// 
			this.surnameTB.Location = new System.Drawing.Point(184, 49);
			this.surnameTB.Name = "surnameTB";
			this.surnameTB.Size = new System.Drawing.Size(113, 20);
			this.surnameTB.TabIndex = 1;
			this.surnameTB.Text = "Иванов";
			this.surnameTB.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
			// 
			// nameTB
			// 
			this.nameTB.Location = new System.Drawing.Point(184, 75);
			this.nameTB.Name = "nameTB";
			this.nameTB.Size = new System.Drawing.Size(113, 20);
			this.nameTB.TabIndex = 2;
			this.nameTB.Text = "Иван";
			this.nameTB.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
			// 
			// patronymicTB
			// 
			this.patronymicTB.Location = new System.Drawing.Point(184, 101);
			this.patronymicTB.Name = "patronymicTB";
			this.patronymicTB.Size = new System.Drawing.Size(113, 20);
			this.patronymicTB.TabIndex = 3;
			this.patronymicTB.Text = "Иванович";
			this.patronymicTB.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
			// 
			// telNumber1TB
			// 
			this.telNumber1TB.Location = new System.Drawing.Point(211, 127);
			this.telNumber1TB.Name = "telNumber1TB";
			this.telNumber1TB.Size = new System.Drawing.Size(25, 20);
			this.telNumber1TB.TabIndex = 4;
			this.telNumber1TB.Text = "800";
			this.telNumber1TB.Validating += new System.ComponentModel.CancelEventHandler(this.telNumber1TB_Validating);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(85, 78);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(29, 13);
			this.nameLabel.TabIndex = 5;
			this.nameLabel.Text = "Имя";
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(83, 52);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(56, 13);
			this.surnameLabel.TabIndex = 6;
			this.surnameLabel.Text = "Фамилия";
			// 
			// patronymicLabel
			// 
			this.patronymicLabel.AutoSize = true;
			this.patronymicLabel.Location = new System.Drawing.Point(85, 104);
			this.patronymicLabel.Name = "patronymicLabel";
			this.patronymicLabel.Size = new System.Drawing.Size(54, 13);
			this.patronymicLabel.TabIndex = 7;
			this.patronymicLabel.Text = "Отчество";
			// 
			// telNumberLabel
			// 
			this.telNumberLabel.AutoSize = true;
			this.telNumberLabel.Location = new System.Drawing.Point(85, 130);
			this.telNumberLabel.Name = "telNumberLabel";
			this.telNumberLabel.Size = new System.Drawing.Size(93, 13);
			this.telNumberLabel.TabIndex = 8;
			this.telNumberLabel.Text = "Номер телефона";
			// 
			// carNumberLabel
			// 
			this.carNumberLabel.AutoSize = true;
			this.carNumberLabel.Location = new System.Drawing.Point(85, 156);
			this.carNumberLabel.Name = "carNumberLabel";
			this.carNumberLabel.Size = new System.Drawing.Size(86, 13);
			this.carNumberLabel.TabIndex = 10;
			this.carNumberLabel.Text = "Номер машины";
			// 
			// carNumber1TB
			// 
			this.carNumber1TB.Location = new System.Drawing.Point(184, 153);
			this.carNumber1TB.Name = "carNumber1TB";
			this.carNumber1TB.Size = new System.Drawing.Size(21, 20);
			this.carNumber1TB.TabIndex = 9;
			this.carNumber1TB.Text = "А";
			this.carNumber1TB.Validating += new System.ComponentModel.CancelEventHandler(this.carNumber1TB_Validating);
			// 
			// carColorLabel
			// 
			this.carColorLabel.AutoSize = true;
			this.carColorLabel.Location = new System.Drawing.Point(85, 182);
			this.carColorLabel.Name = "carColorLabel";
			this.carColorLabel.Size = new System.Drawing.Size(32, 13);
			this.carColorLabel.TabIndex = 12;
			this.carColorLabel.Text = "Цвет";
			// 
			// carColorTB
			// 
			this.carColorTB.Location = new System.Drawing.Point(184, 179);
			this.carColorTB.Name = "carColorTB";
			this.carColorTB.Size = new System.Drawing.Size(113, 20);
			this.carColorTB.TabIndex = 11;
			this.carColorTB.Text = "Черный";
			this.carColorTB.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
			// 
			// telCodeTB
			// 
			this.telCodeTB.Enabled = false;
			this.telCodeTB.Location = new System.Drawing.Point(184, 127);
			this.telCodeTB.Name = "telCodeTB";
			this.telCodeTB.Size = new System.Drawing.Size(21, 20);
			this.telCodeTB.TabIndex = 13;
			this.telCodeTB.Text = "+7 (800) 000-0000";
			// 
			// telNumber2TB
			// 
			this.telNumber2TB.Location = new System.Drawing.Point(242, 127);
			this.telNumber2TB.Name = "telNumber2TB";
			this.telNumber2TB.Size = new System.Drawing.Size(55, 20);
			this.telNumber2TB.TabIndex = 14;
			this.telNumber2TB.Text = "000-0000";
			this.telNumber2TB.Validating += new System.ComponentModel.CancelEventHandler(this.telNumber2TB_Validating);
			// 
			// carNumber2TB
			// 
			this.carNumber2TB.Location = new System.Drawing.Point(211, 153);
			this.carNumber2TB.Name = "carNumber2TB";
			this.carNumber2TB.Size = new System.Drawing.Size(25, 20);
			this.carNumber2TB.TabIndex = 15;
			this.carNumber2TB.Text = "001";
			this.carNumber2TB.Validating += new System.ComponentModel.CancelEventHandler(this.telNumber1TB_Validating);
			// 
			// carNumber3TB
			// 
			this.carNumber3TB.Location = new System.Drawing.Point(242, 153);
			this.carNumber3TB.Name = "carNumber3TB";
			this.carNumber3TB.Size = new System.Drawing.Size(20, 20);
			this.carNumber3TB.TabIndex = 16;
			this.carNumber3TB.Text = "АА";
			this.carNumber3TB.Validating += new System.ComponentModel.CancelEventHandler(this.carNumber3TB_Validating);
			// 
			// carNumber4TB
			// 
			this.carNumber4TB.Location = new System.Drawing.Point(268, 153);
			this.carNumber4TB.Name = "carNumber4TB";
			this.carNumber4TB.Size = new System.Drawing.Size(29, 20);
			this.carNumber4TB.TabIndex = 17;
			this.carNumber4TB.Text = "163";
			this.carNumber4TB.Validating += new System.ComponentModel.CancelEventHandler(this.carNumber4TB_Validating);
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.BackColor = System.Drawing.Color.LightCoral;
			this.errorLabel.Location = new System.Drawing.Point(127, 211);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(184, 13);
			this.errorLabel.TabIndex = 18;
			this.errorLabel.Text = "Одна из форм заполнена не верно";
			this.errorLabel.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(398, 261);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.carNumber4TB);
			this.Controls.Add(this.carNumber3TB);
			this.Controls.Add(this.carNumber2TB);
			this.Controls.Add(this.telNumber2TB);
			this.Controls.Add(this.telCodeTB);
			this.Controls.Add(this.carColorLabel);
			this.Controls.Add(this.carColorTB);
			this.Controls.Add(this.carNumberLabel);
			this.Controls.Add(this.carNumber1TB);
			this.Controls.Add(this.telNumberLabel);
			this.Controls.Add(this.patronymicLabel);
			this.Controls.Add(this.surnameLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.telNumber1TB);
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

		private System.Windows.Forms.Label mainLabel;
		private System.Windows.Forms.TextBox surnameTB;
		private System.Windows.Forms.TextBox nameTB;
		private System.Windows.Forms.TextBox patronymicTB;
		private System.Windows.Forms.TextBox telNumber1TB;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.Label patronymicLabel;
		private System.Windows.Forms.Label telNumberLabel;
		private System.Windows.Forms.Label carNumberLabel;
		private System.Windows.Forms.TextBox carNumber1TB;
		private System.Windows.Forms.Label carColorLabel;
		private System.Windows.Forms.TextBox carColorTB;
		private System.Windows.Forms.TextBox telCodeTB;
		private System.Windows.Forms.TextBox telNumber2TB;
		private System.Windows.Forms.TextBox carNumber2TB;
		private System.Windows.Forms.TextBox carNumber3TB;
		private System.Windows.Forms.TextBox carNumber4TB;
		private System.Windows.Forms.Label errorLabel;
	}
}

