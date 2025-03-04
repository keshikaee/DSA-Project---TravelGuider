namespace Traveler_UI
{
    partial class addLocation
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
            locationIDLbl = new Label();
            locationNameTxtBox = new TextBox();
            locationDetailLbl = new Label();
            locationNameLbl = new Label();
            locationDistrict = new Label();
            estimatedBudjetLbl = new Label();
            districtTxtbox = new TextBox();
            budjetTxtbox = new TextBox();
            addLocationBtn = new Button();
            descriptionLbl = new Label();
            DescriptionTxtbox = new TextBox();
            locationIdTxtbox = new Label();
            SuspendLayout();
            // 
            // locationIDLbl
            // 
            locationIDLbl.AutoSize = true;
            locationIDLbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            locationIDLbl.Location = new Point(38, 74);
            locationIDLbl.Name = "locationIDLbl";
            locationIDLbl.Size = new Size(110, 25);
            locationIDLbl.TabIndex = 8;
            locationIDLbl.Text = "Location ID";
            // 
            // locationNameTxtBox
            // 
            locationNameTxtBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            locationNameTxtBox.Location = new Point(261, 122);
            locationNameTxtBox.Name = "locationNameTxtBox";
            locationNameTxtBox.Size = new Size(193, 33);
            locationNameTxtBox.TabIndex = 0;
            // 
            // locationDetailLbl
            // 
            locationDetailLbl.AutoSize = true;
            locationDetailLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            locationDetailLbl.Location = new Point(144, 18);
            locationDetailLbl.Name = "locationDetailLbl";
            locationDetailLbl.Size = new Size(395, 32);
            locationDetailLbl.TabIndex = 1;
            locationDetailLbl.Text = "Tell me detail about the Location ";
            // 
            // locationNameLbl
            // 
            locationNameLbl.AutoSize = true;
            locationNameLbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            locationNameLbl.Location = new Point(38, 125);
            locationNameLbl.Name = "locationNameLbl";
            locationNameLbl.Size = new Size(142, 25);
            locationNameLbl.TabIndex = 2;
            locationNameLbl.Text = "Location Name";
            // 
            // locationDistrict
            // 
            locationDistrict.AutoSize = true;
            locationDistrict.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            locationDistrict.Location = new Point(38, 184);
            locationDistrict.Name = "locationDistrict";
            locationDistrict.Size = new Size(74, 25);
            locationDistrict.TabIndex = 3;
            locationDistrict.Text = "District";
            // 
            // estimatedBudjetLbl
            // 
            estimatedBudjetLbl.AutoSize = true;
            estimatedBudjetLbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            estimatedBudjetLbl.Location = new Point(38, 240);
            estimatedBudjetLbl.Name = "estimatedBudjetLbl";
            estimatedBudjetLbl.Size = new Size(157, 25);
            estimatedBudjetLbl.TabIndex = 4;
            estimatedBudjetLbl.Text = "Estimated Budjet";
            // 
            // districtTxtbox
            // 
            districtTxtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            districtTxtbox.Location = new Point(261, 181);
            districtTxtbox.Name = "districtTxtbox";
            districtTxtbox.Size = new Size(193, 33);
            districtTxtbox.TabIndex = 5;
            // 
            // budjetTxtbox
            // 
            budjetTxtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            budjetTxtbox.Location = new Point(261, 237);
            budjetTxtbox.Name = "budjetTxtbox";
            budjetTxtbox.Size = new Size(193, 33);
            budjetTxtbox.TabIndex = 6;
            // 
            // addLocationBtn
            // 
            addLocationBtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addLocationBtn.Location = new Point(467, 353);
            addLocationBtn.Name = "addLocationBtn";
            addLocationBtn.Size = new Size(178, 37);
            addLocationBtn.TabIndex = 7;
            addLocationBtn.Text = "Add Location";
            addLocationBtn.UseVisualStyleBackColor = true;
            addLocationBtn.Click += addLocationBtn_Click;
            // 
            // descriptionLbl
            // 
            descriptionLbl.AutoSize = true;
            descriptionLbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLbl.Location = new Point(38, 293);
            descriptionLbl.Name = "descriptionLbl";
            descriptionLbl.Size = new Size(110, 25);
            descriptionLbl.TabIndex = 10;
            descriptionLbl.Text = "Description";
            // 
            // DescriptionTxtbox
            // 
            DescriptionTxtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTxtbox.Location = new Point(261, 290);
            DescriptionTxtbox.Name = "DescriptionTxtbox";
            DescriptionTxtbox.Size = new Size(193, 33);
            DescriptionTxtbox.TabIndex = 11;
            // 
            // locationIdTxtbox
            // 
            locationIdTxtbox.AutoSize = true;
            locationIdTxtbox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            locationIdTxtbox.Location = new Point(261, 74);
            locationIdTxtbox.Name = "locationIdTxtbox";
            locationIdTxtbox.Size = new Size(110, 25);
            locationIdTxtbox.TabIndex = 12;
            locationIdTxtbox.Text = "Location ID";
            // 
            // addLocation
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 411);
            Controls.Add(locationIdTxtbox);
            Controls.Add(DescriptionTxtbox);
            Controls.Add(descriptionLbl);
            Controls.Add(locationIDLbl);
            Controls.Add(addLocationBtn);
            Controls.Add(budjetTxtbox);
            Controls.Add(districtTxtbox);
            Controls.Add(estimatedBudjetLbl);
            Controls.Add(locationDistrict);
            Controls.Add(locationNameLbl);
            Controls.Add(locationDetailLbl);
            Controls.Add(locationNameTxtBox);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "addLocation";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox locationNameTxtBox;
        private Label locationDetailLbl;
        private Label locationNameLbl;
        private Label locationDistrict;
        private Label estimatedBudjetLbl;
        private TextBox districtTxtbox;
        private TextBox budjetTxtbox;
        private Button addLocationBtn;
        private Label locationIDLbl;
        private Label descriptionLbl;
        private TextBox DescriptionTxtbox;
        private Label locationIdTxtbox;
    }
}