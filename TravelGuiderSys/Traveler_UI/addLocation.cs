using TravelGuiderLibrary;

namespace Traveler_UI
{
    public partial class addLocation : Form
    {
        public addLocation()
        {
            InitializeComponent(); // Initialize components
            UpdateLocationIdLabel();
        }

        private void addLocationBtn_Click(object sender, EventArgs e)
        {
            // Trim any leading or trailing spaces before trying to parse
            string budjetText = budjetTxtbox.Text.Trim();
            string descriptionText = DescriptionTxtbox.Text.Trim();

            // Debugging output to see the input values
            Console.WriteLine($"budjetTxtbox.Text (trimmed): '{budjetText}'");
            Console.WriteLine($"DescriptionTxtbox.Text (trimmed): '{descriptionText}'");

            // Attempt to parse the Budjet field
            bool isBudjetValid = int.TryParse(budjetText, out int budjet);

            // Debugging output to verify parsing
            Console.WriteLine($"Budjet valid: {isBudjetValid}");

            // Validate the LocationName and District fields (non-empty)
            if (string.IsNullOrWhiteSpace(locationNameTxtBox.Text))
            {
                MessageBox.Show("Location Name cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop processing if Location Name is empty
            }

            if (string.IsNullOrWhiteSpace(districtTxtbox.Text))
            {
                MessageBox.Show("District cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop processing if District is empty
            }

            // Validate the Budjet field
            if (string.IsNullOrWhiteSpace(budjetText) || !isBudjetValid)
            {
                MessageBox.Show("Please enter a valid Budjet (integer).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop processing if Budjet is invalid
            }

            // If all fields are valid, create the new location object
            var newLocation = new LocationModel
            {
                LocationName = locationNameTxtBox.Text,
                District = districtTxtbox.Text,
                Budjet = budjet,
                Description = descriptionText // New field
            };

            // Add the new location to the global list
            GlobalVariables.AddLocation(newLocation);

            // Update the LocationIDValueLbl to reflect the new number of nodes
            UpdateLocationIdLabel();

            // Ask if the user wants to add another location
            var result = MessageBox.Show("Do you want to add another location?", "Add Another Location", MessageBoxButtons.YesNo);

            // If Yes, reset the form for new input, else close the form
            if (result == DialogResult.Yes)
            {
                // Clear the textboxes to allow new input
                locationNameTxtBox.Clear();
                districtTxtbox.Clear();
                budjetTxtbox.Clear();
                DescriptionTxtbox.Clear();

                // Set the focus back to the LocationNameTxtBox to allow entering the next location name
                locationNameTxtBox.Focus();
            }
            else
            {
                // Close the form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void UpdateLocationIdLabel()
        {
            int numberOfNodes = GlobalVariables.LocationList.GetAllLocations().Count;
            locationIdTxtbox.Text = numberOfNodes.ToString();
        }
    }

}

