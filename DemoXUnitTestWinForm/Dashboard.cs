using DemoLibrary;
using DemoLibrary.Models;

namespace DemoXUnitTestWinForm {
    public partial class Dashboard : Form {
        public Dashboard() {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            ResultTextBox.Text = Calculator.Add((double)FirstNumericUpDown.Value,
                                    (double)SecondNumericUpDown.Value).ToString();

            ResetNumericUpDown();
        }

        private void SubtractButton_Click(object sender, EventArgs e) {
            ResultTextBox.Text = Calculator.Subtract((double)FirstNumericUpDown.Value,
                                    (double)SecondNumericUpDown.Value).ToString();

            ResetNumericUpDown();
        }

        private void MultiplyButton_Click(object sender, EventArgs e) {
            ResultTextBox.Text = Calculator.Multiply((double)FirstNumericUpDown.Value,
                                    (double)SecondNumericUpDown.Value).ToString();

            ResetNumericUpDown();
        }

        private void DivideButton_Click(object sender, EventArgs e) {
            ResultTextBox.Text = Calculator.Divide((double)FirstNumericUpDown.Value,
                                    (double)SecondNumericUpDown.Value).ToString();

            ResetNumericUpDown();
        }

        private void ResetNumericUpDown() {
            FirstNumericUpDown.Value = 0;
            SecondNumericUpDown.Value = 0;
        }

        private async void AddPersonButton_Click(object sender, EventArgs e) {
            PersonModel person = new PersonModel {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text
            };

            await DataAccess.AddNewPersonAsync(person);

            FillUsersComboBoxAsync();
            RestTextBox();
        }

        private async void FillUsersComboBoxAsync() {
            UsersComboBox.Items.Clear();

            List<PersonModel> people = await DataAccess.GetAllPeopleAsync();

            foreach (var p in people) {
                UsersComboBox.Items.Add(p.FullName);
            }
        }

        private void RestTextBox() {
            FirstNameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
        }

        private void Dashboard_Load(object sender, EventArgs e) {
            FillUsersComboBoxAsync();
            RestTextBox();
        }
    }
}
