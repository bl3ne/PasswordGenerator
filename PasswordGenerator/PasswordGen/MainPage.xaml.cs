using System.Security.Cryptography;

namespace PasswordGen
{
    public partial class MainPage : ContentPage
    {

        // Variable to track the number of times the button has been clicked
        int ClickedTimes = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void GeneratePasswordButton_Clicked(object sender, EventArgs e)
        {

            // Validate if the input is a valid integer
            if (int.TryParse(TxtLenght.Text, out int result))
            {
                ClickedTimes = ClickedTimes + 1;
                TxbClickedTimes.Text = "Generate Password Button Clicked Times: " + ClickedTimes;
                // Password lenght
                int length = Convert.ToInt32(TxtLenght.Text);  //user can change the lenght of the password

                // set of characters to use in the password
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*_?-:;";

                //idk why but Random class work better than RandomNumberGenerator
                Random PasswordRandom = new Random();

                // array to hold the generated characters
                char[] buffer = new char[length];

                for (int i = 0; i < length; i++)
                {
                    int index = PasswordRandom.Next(chars.Length);
                    buffer[i] = chars[index];
                }

                // convert the character array to a string
                TxbPassword.Text = new string(buffer);
            }
            else
            {
                // Show an alert if the input is not a valid integer
                DisplayAlert("Lenght error", "The lenght isn't intiger", "OK");
                
            }

          


            

        }

        // Event handler for BtnCopyPassword Clicked event
        private void BtnCopyPassword_Clicked(object sender, EventArgs e)
        {
            // Get the password from the TextBox
            string passwordToCopy = TxbPassword.Text;


            if (string.IsNullOrEmpty(passwordToCopy))
            {
                // Show an alert if there is no password to copy
                DisplayAlert("No Password", "There is no password to copy. Please generate one first, clicking the button", "OK");

            }
            else if (TxbPassword.Text == "Press the button")
            {
                // Show an alert if there is no password to copy
                DisplayAlert("No Password", "There is no password to copy. Please generate one first, clicking the button", "OK");
            }
            else
            {
                // Copy the password to clipboard
                Clipboard.SetTextAsync(passwordToCopy);
                DisplayAlert("Password Copied", "The password has been copied to clipboard.", "OK");
            }



        }


        // Event handler for TxtLenght Unfocused event
        private void TxtLenght_Unfocused(object sender, FocusEventArgs e)
        {
            // Check if the TextBox is empty
            if (string.IsNullOrEmpty(TxtLenght.Text))
            {
                // Show an alert if the input is empty
                DisplayAlert("No lenght", "There is lenght for the password. Please insert the lenght first", "OK");
                
            }
            else
            {

            }
        }
    }
}
