namespace Traveler_UI
{
    partial class Dashbord
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
            addLocationBtn = new Button();
            getLocationBtn = new Button();
            travelerDashboardLbl = new Label();
            wannagoLbl = new Label();
            textBox1 = new TextBox();
            searchBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // addLocationBtn
            // 
            addLocationBtn.BackColor = SystemColors.ActiveCaptionText;
            addLocationBtn.ForeColor = Color.Transparent;
            addLocationBtn.Location = new Point(77, 138);
            addLocationBtn.Margin = new Padding(6);
            addLocationBtn.Name = "addLocationBtn";
            addLocationBtn.Size = new Size(179, 52);
            addLocationBtn.TabIndex = 0;
            addLocationBtn.Text = "Add Location";
            addLocationBtn.UseVisualStyleBackColor = false;
            addLocationBtn.Click += addLocationBtn_Click;
            // 
            // getLocationBtn
            // 
            getLocationBtn.BackColor = SystemColors.ActiveCaptionText;
            getLocationBtn.ForeColor = Color.Transparent;
            getLocationBtn.Location = new Point(435, 138);
            getLocationBtn.Margin = new Padding(6);
            getLocationBtn.Name = "getLocationBtn";
            getLocationBtn.Size = new Size(179, 52);
            getLocationBtn.TabIndex = 1;
            getLocationBtn.Text = "Get Location";
            getLocationBtn.UseVisualStyleBackColor = false;
            getLocationBtn.Click += getLocationBtn_Click_1;
            // 
            // travelerDashboardLbl
            // 
            travelerDashboardLbl.AutoSize = true;
            travelerDashboardLbl.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            travelerDashboardLbl.Location = new Point(190, 43);
            travelerDashboardLbl.Name = "travelerDashboardLbl";
            travelerDashboardLbl.Size = new Size(285, 40);
            travelerDashboardLbl.TabIndex = 2;
            travelerDashboardLbl.Text = "Traveler Dashboard";
            // 
            // wannagoLbl
            // 
            wannagoLbl.AutoSize = true;
            wannagoLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            wannagoLbl.Location = new Point(77, 240);
            wannagoLbl.Name = "wannagoLbl";
            wannagoLbl.Size = new Size(240, 30);
            wannagoLbl.TabIndex = 3;
            wannagoLbl.Text = "Where you want to go ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(365, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 39);
            textBox1.TabIndex = 4;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ActiveCaptionText;
            searchBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(530, 240);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(101, 38);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(596, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(29, 12);
            button2.Name = "button2";
            button2.Size = new Size(114, 28);
            button2.TabIndex = 7;
            button2.Text = "See Cart";
            button2.UseVisualStyleBackColor = false;
            // 
            // Dashbord
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 340);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(searchBtn);
            Controls.Add(textBox1);
            Controls.Add(wannagoLbl);
            Controls.Add(travelerDashboardLbl);
            Controls.Add(getLocationBtn);
            Controls.Add(addLocationBtn);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Dashbord";
            Text = "Dashbord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addLocationBtn;
        private Button getLocationBtn;
        private Label travelerDashboardLbl;
        private Label wannagoLbl;
        private TextBox textBox1;
        private Button searchBtn;
        private Button button1;
        private Button button2;
    }
}