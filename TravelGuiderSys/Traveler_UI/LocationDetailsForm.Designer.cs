namespace Traveler_UI
{
    partial class LocationDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            locationIdLbl = new Label();
            locationNameLbl = new Label();
            districtLbl = new Label();
            budjetLbl = new Label();
            descriptionLbl = new Label();
            locationIdValueLbl = new Label();
            locationNameValueLbl = new Label();
            districtValueLbl = new Label();
            budjetValueLbl = new Label();
            descriptionValueLbl = new Label();
            planeBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // locationIdLbl
            // 
            locationIdLbl.AutoSize = true;
            locationIdLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            locationIdLbl.Location = new Point(12, 20);
            locationIdLbl.Name = "locationIdLbl";
            locationIdLbl.Size = new Size(119, 25);
            locationIdLbl.TabIndex = 0;
            locationIdLbl.Text = "Location ID:";
            // 
            // locationNameLbl
            // 
            locationNameLbl.AutoSize = true;
            locationNameLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            locationNameLbl.Location = new Point(12, 60);
            locationNameLbl.Name = "locationNameLbl";
            locationNameLbl.Size = new Size(151, 25);
            locationNameLbl.TabIndex = 1;
            locationNameLbl.Text = "Location Name:";
            // 
            // districtLbl
            // 
            districtLbl.AutoSize = true;
            districtLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            districtLbl.Location = new Point(12, 100);
            districtLbl.Name = "districtLbl";
            districtLbl.Size = new Size(80, 25);
            districtLbl.TabIndex = 2;
            districtLbl.Text = "District:";
            // 
            // budjetLbl
            // 
            budjetLbl.AutoSize = true;
            budjetLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            budjetLbl.Location = new Point(12, 140);
            budjetLbl.Name = "budjetLbl";
            budjetLbl.Size = new Size(75, 25);
            budjetLbl.TabIndex = 3;
            budjetLbl.Text = "Budjet:";
            // 
            // descriptionLbl
            // 
            descriptionLbl.AutoSize = true;
            descriptionLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLbl.Location = new Point(12, 180);
            descriptionLbl.Name = "descriptionLbl";
            descriptionLbl.Size = new Size(119, 25);
            descriptionLbl.TabIndex = 4;
            descriptionLbl.Text = "Description:";
            // 
            // locationIdValueLbl
            // 
            locationIdValueLbl.AutoSize = true;
            locationIdValueLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            locationIdValueLbl.Location = new Point(160, 20);
            locationIdValueLbl.Name = "locationIdValueLbl";
            locationIdValueLbl.Size = new Size(0, 25);
            locationIdValueLbl.TabIndex = 5;
            // 
            // locationNameValueLbl
            // 
            locationNameValueLbl.AutoSize = true;
            locationNameValueLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            locationNameValueLbl.Location = new Point(160, 60);
            locationNameValueLbl.Name = "locationNameValueLbl";
            locationNameValueLbl.Size = new Size(0, 25);
            locationNameValueLbl.TabIndex = 6;
            // 
            // districtValueLbl
            // 
            districtValueLbl.AutoSize = true;
            districtValueLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            districtValueLbl.Location = new Point(160, 100);
            districtValueLbl.Name = "districtValueLbl";
            districtValueLbl.Size = new Size(0, 25);
            districtValueLbl.TabIndex = 7;
            // 
            // budjetValueLbl
            // 
            budjetValueLbl.AutoSize = true;
            budjetValueLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            budjetValueLbl.Location = new Point(160, 140);
            budjetValueLbl.Name = "budjetValueLbl";
            budjetValueLbl.Size = new Size(0, 25);
            budjetValueLbl.TabIndex = 8;
            // 
            // descriptionValueLbl
            // 
            descriptionValueLbl.AutoSize = true;
            descriptionValueLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionValueLbl.Location = new Point(160, 180);
            descriptionValueLbl.Name = "descriptionValueLbl";
            descriptionValueLbl.Size = new Size(0, 25);
            descriptionValueLbl.TabIndex = 9;
            // 
            // planeBtn
            // 
            planeBtn.BackColor = SystemColors.ActiveCaptionText;
            planeBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            planeBtn.ForeColor = SystemColors.ControlLightLight;
            planeBtn.Location = new Point(12, 281);
            planeBtn.Name = "planeBtn";
            planeBtn.Size = new Size(215, 59);
            planeBtn.TabIndex = 10;
            planeBtn.Text = "Plan The Trip Now";
            planeBtn.UseVisualStyleBackColor = false;
            planeBtn.Click += planeBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(517, 281);
            button1.Name = "button1";
            button1.Size = new Size(215, 59);
            button1.TabIndex = 11;
            button1.Text = "Add to cart";
            button1.UseVisualStyleBackColor = false;
            // 
            // LocationDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 352);
            Controls.Add(button1);
            Controls.Add(planeBtn);
            Controls.Add(descriptionValueLbl);
            Controls.Add(budjetValueLbl);
            Controls.Add(districtValueLbl);
            Controls.Add(locationNameValueLbl);
            Controls.Add(locationIdValueLbl);
            Controls.Add(descriptionLbl);
            Controls.Add(budjetLbl);
            Controls.Add(districtLbl);
            Controls.Add(locationNameLbl);
            Controls.Add(locationIdLbl);
            Name = "LocationDetailsForm";
            Text = "Location Details";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label locationIdLbl;
        private System.Windows.Forms.Label locationNameLbl;
        private System.Windows.Forms.Label districtLbl;
        private System.Windows.Forms.Label budjetLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label locationIdValueLbl;
        private System.Windows.Forms.Label locationNameValueLbl;
        private System.Windows.Forms.Label districtValueLbl;
        private System.Windows.Forms.Label budjetValueLbl;
        private System.Windows.Forms.Label descriptionValueLbl;
        private Button planeBtn;
        private Button button1;
    }
}