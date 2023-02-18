
namespace Lab2_Part4
{
    partial class AddForm
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
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FlatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HouseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelApartement = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelPatronimic = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(191, 290);
            this.PhoneMaskedTextBox.Mask = "(999) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(100, 26);
            this.PhoneMaskedTextBox.TabIndex = 6;
            // 
            // FlatNumericUpDown
            // 
            this.FlatNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlatNumericUpDown.Location = new System.Drawing.Point(191, 256);
            this.FlatNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.FlatNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FlatNumericUpDown.Name = "FlatNumericUpDown";
            this.FlatNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.FlatNumericUpDown.TabIndex = 5;
            this.FlatNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HouseNumericUpDown
            // 
            this.HouseNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseNumericUpDown.Location = new System.Drawing.Point(191, 221);
            this.HouseNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HouseNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HouseNumericUpDown.Name = "HouseNumericUpDown";
            this.HouseNumericUpDown.Size = new System.Drawing.Size(100, 26);
            this.HouseNumericUpDown.TabIndex = 4;
            this.HouseNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicTextBox.Location = new System.Drawing.Point(191, 151);
            this.PatronymicTextBox.MaxLength = 25;
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(100, 26);
            this.PatronymicTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(191, 114);
            this.NameTextBox.MaxLength = 25;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 26);
            this.NameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTextBox.Location = new System.Drawing.Point(191, 79);
            this.LastNameTextBox.MaxLength = 25;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.LastNameTextBox.TabIndex = 0;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetTextBox.Location = new System.Drawing.Point(191, 184);
            this.StreetTextBox.MaxLength = 40;
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(100, 26);
            this.StreetTextBox.TabIndex = 3;
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTelephone.Location = new System.Drawing.Point(94, 293);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(79, 20);
            this.labelTelephone.TabIndex = 39;
            this.labelTelephone.Text = "Телефон";
            // 
            // labelApartement
            // 
            this.labelApartement.AutoSize = true;
            this.labelApartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelApartement.Location = new System.Drawing.Point(94, 258);
            this.labelApartement.Name = "labelApartement";
            this.labelApartement.Size = new System.Drawing.Size(82, 20);
            this.labelApartement.TabIndex = 38;
            this.labelApartement.Text = "Квартира";
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHouse.Location = new System.Drawing.Point(94, 223);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(41, 20);
            this.labelHouse.TabIndex = 37;
            this.labelHouse.Text = "Дом";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStreet.Location = new System.Drawing.Point(94, 187);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(56, 20);
            this.labelStreet.TabIndex = 36;
            this.labelStreet.Text = "Улица";
            // 
            // labelPatronimic
            // 
            this.labelPatronimic.AutoSize = true;
            this.labelPatronimic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronimic.Location = new System.Drawing.Point(94, 154);
            this.labelPatronimic.Name = "labelPatronimic";
            this.labelPatronimic.Size = new System.Drawing.Size(83, 20);
            this.labelPatronimic.TabIndex = 35;
            this.labelPatronimic.Text = "Отчество";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(94, 117);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(40, 20);
            this.labelFirstName.TabIndex = 34;
            this.labelFirstName.Text = "Имя";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondName.Location = new System.Drawing.Point(94, 82);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(81, 20);
            this.labelSecondName.TabIndex = 33;
            this.labelSecondName.Text = "Фамилия";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(98, 344);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(193, 34);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 435);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.FlatNumericUpDown);
            this.Controls.Add(this.HouseNumericUpDown);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelApartement);
            this.Controls.Add(this.labelHouse);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelPatronimic);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelSecondName);
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.NumericUpDown FlatNumericUpDown;
        private System.Windows.Forms.NumericUpDown HouseNumericUpDown;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelApartement;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelPatronimic;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Button AddButton;
    }
}