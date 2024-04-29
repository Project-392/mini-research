using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config; // Config files to connect C# app to FireBase
using FireSharp.Interfaces; // Contains methods to send data to FireBase DB
using FireSharp.Response; // 

namespace firebase_db
{
    public partial class Form2 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "E0w8q4Ea1nqjaHmgWpM2vTv7NximRUBxdALljKVK",
            BasePath = "https://fir-crud-b042d-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form2(string userID)
        {
            InitializeComponent();

            tb_userID.Text = userID;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Connection is setup");
            }
        }

        // Holds Data for Each pet
        public class PetData
        {
            public string? PetName { get; set; }
            public string? PetAge { get; set; }
            public string? PetBreed { get; set; }
            public string? Bio { get; set; }
            public string? Diet { get; set; }
            public string? MedicalHistory { get; set; }
        }


        // Data for the Overall User, holds all pets and scans added by the user
        public class UserData
        {
            public List<string> PetHistory { get; set; } = new List<string>();
            public List<string> ScanHistory { get; set; } = new List<string>();
        }

        // Inputs Pet Data to DB and autimatically update's the list of the user's Pets
        private async void btn_submit_Click(object sender, EventArgs e)
        {
            var petData = new PetData
            {
                PetName = tb_petName.Text,
                PetAge = tb_petAge.Text,
                PetBreed = tb_petBreed.Text,
                Bio = tb_bio.Text,
                Diet = tb_diet.Text,
                MedicalHistory = tb_medicalHistory.Text
            };

            SetResponse response = await client.SetTaskAsync($"users/{tb_userID.Text}/pets/" + tb_petName.Text, petData); // Retrieves Data from the petData object
            PetData result = response.ResultAs<PetData>();

            // Retrieves current UserData including PetHistory
            FirebaseResponse userResponse = await client.GetTaskAsync($"users/{tb_userID.Text}");
            UserData userData = userResponse.ResultAs<UserData>() ?? new UserData();

            // Checks and updates PetHistory List
            if (!userData.PetHistory.Contains(tb_petName.Text))
            {
                userData.PetHistory.Add(tb_petName.Text); // Includes Newly Added Pet onto PetHistory List 

                await client.SetTaskAsync($"users/{tb_userID.Text}", userData);
            }
            MessageBox.Show("Data inserted for pet named " + result.PetName);

        }

        // Gets all the Data from the inputted Pet Name
        private async void btn_retrieve_pet_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync($"users/{tb_userID.Text}/pets/" + tb_petName.Text);
            PetData obj = response.ResultAs<PetData>();


            tb_petName.Text = obj.PetName;
            tb_petAge.Text = obj.PetAge;
            tb_petBreed.Text = obj.PetBreed;
            tb_bio.Text = obj.Bio;
            tb_diet.Text = obj.Diet;
            tb_medicalHistory.Text = obj.MedicalHistory;


            MessageBox.Show("Pet Data Recovered for " + tb_petName.Text);
        }
        // Shows all Pet's entered by the User
        // Helps when a user has different pet's
        private async void btn_retrieve_all_pets_Click(object sender, EventArgs e)
        {
            tb_petHistory.Clear();
            FirebaseResponse userResponse = await client.GetTaskAsync($"users/{tb_userID.Text}"); // Retrieves the UserData that will be used later

            if (userResponse.Body != "null")
            {
                UserData userData = userResponse.ResultAs<UserData>();

                if (userData != null && userData.PetHistory != null)
                {
                    foreach (var petName in userData.PetHistory) // Loops through each pet in the PetHistory List
                    {
                        tb_petHistory.AppendText(petName + Environment.NewLine); // Shows each pet line by Line
                    }
                }
                else
                {
                    tb_petHistory.Text = "No pet history found."; // The user has not inputted any pet
                }
            }
            else
            {
                tb_petHistory.Text = "User not found."; // User's unique ID is invalid
            }
        }

        // Basically Same Function as the Retrieve All Pets Function
        private async void btn_add_scan_history_Click(object sender, EventArgs e)
        {
            // Retrieves current UserData including PetHistory
            FirebaseResponse userResponse = await client.GetTaskAsync($"users/{tb_userID.Text}");
            UserData userData = userResponse.ResultAs<UserData>() ?? new UserData();


            // Adds Scan Text onto Scan History
            userData.ScanHistory.Add(tb_scanHistory.Text);
            await client.SetTaskAsync($"users/{tb_userID.Text}", userData);

            MessageBox.Show("Added to Scan History");
        }

        private async void btn_show_scan_history_Click_1(object sender, EventArgs e)
        {
            tb_scanHistory.Clear();
            FirebaseResponse userResponse = await client.GetTaskAsync($"users/{tb_userID.Text}"); // Retrieves the UserData that will be used later

            if (userResponse.Body != "null")
            {
                UserData userData = userResponse.ResultAs<UserData>();

                if (userData != null && userData.ScanHistory != null)
                {
                    foreach (var scan in userData.ScanHistory)
                    {
                        tb_scanHistory.AppendText(scan + Environment.NewLine + Environment.NewLine + Environment.NewLine);
                    }
                }
                else
                {
                    tb_scanHistory.Text = "No scan history found.";
                }
            }
            else
            {
                tb_scanHistory.Text = "User not found.";
            }

        }


        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }


    }

}
