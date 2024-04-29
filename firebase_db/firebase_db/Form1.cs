using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Firebase.Auth;
using static System.Windows.Forms.DataFormats;

namespace firebase_db
{
    public partial class Form1 : Form
    {
        private string API_KEY = "AIzaSyCTqVT08BHk-WyGwjDBbZHJWJhTd36nXio"; // Firebase DB Web API Key

        private FirebaseAuthProvider _firebaseAuthProvider;
        public Form1()
        {
            InitializeComponent();

            // Initialize FirebaseAuthProvider with your Firebase API Key
            _firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(API_KEY));
        }

        private async void btn_signup_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            string password = tb_password.Text;
            try
            {
                FirebaseAuthLink firebaseAuthLink = await _firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(email, password);
                MessageBox.Show("Account created successfully! User ID: " + firebaseAuthLink.User.LocalId);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Account creation failed: " + ex.Message);
            }
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            string password = tb_password.Text;

            try
            {
                // Use the firebaseAuthProvider instance to sign in
                // FirebaseAuthLink firebaseAuthLink = await _firebaseAuthProvider.SignInWithEmailAndPasswordAsync(email, password);
                FirebaseAuthLink firebaseAuthLink = await _firebaseAuthProvider.SignInWithEmailAndPasswordAsync(email, password);
                MessageBox.Show("Login successful! User ID: " + firebaseAuthLink.User.LocalId); // Shows unique ID for user that will allow them to access their own data

                // After Logging in, it should Redirect to Form2, the DB page
                Form2 form2 = new Form2(firebaseAuthLink.User.LocalId); // Passes the Unique ID to Form2
                form2.Show();
                this.Hide(); // Hides Authentication Page

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }

        private void cb_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpassword.Checked)
            {
                tb_password.PasswordChar = '\0';  // Show the password
            }
            else
            {
                tb_password.PasswordChar = '*';  // Hide the password
            }
        }
    }
}
