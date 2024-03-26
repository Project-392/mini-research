using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using FireSharp.Config; // Config files to connect C# app to FireBase
using FireSharp.Interfaces; // Contains methods to send data to FireBase DB
using FireSharp.Response; // 

namespace Firebase_CRUD
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "E0w8q4Ea1nqjaHmgWpM2vTv7NximRUBxdALljKVK",
            BasePath = "https://fir-crud-b042d-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        // Connects c# application to firebase
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config); 

            if (client != null)
            {
                MessageBox.Show("Connection is setup");
            }
        }

        // Function to clear all text boxes
        private void ClearTextBoxes()
        {
            tb_user.Text = "";
            tb_name.Text = "";
            tb_age.Text = "";
            tb_city.Text = "";
        }

        // Inserts Data to FireBase DB
        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                UserName = tb_user.Text,
                Name = tb_name.Text,
                Age = tb_age.Text,
                City = tb_city.Text
            };
         
            SetResponse response = await client.SetTaskAsync("Information/" + tb_user.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data inserted for user: " + result.UserName);

            ClearTextBoxes();
        }

        // Displays User Information back when inputting username
        private async void btn_recover_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Information/" + tb_user.Text);
            Data obj = response.ResultAs<Data>();

        
            tb_user.Text = obj.UserName;
            tb_name.Text = obj.Name;
            tb_age.Text = obj.Age;
            tb_city.Text = obj.City;

            MessageBox.Show("User Data Recovered");
        }
        // Updates User's data
        private async void btn_update_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                UserName = tb_user.Text,
                Name = tb_name.Text,
                Age = tb_age.Text,
                City = tb_city.Text
            };

            FirebaseResponse response = await client.UpdateTaskAsync("Information/" + tb_user.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Updated data for user: " + result.UserName);
            ClearTextBoxes();
        }
        // Delete a Single User
        private async void btn_delete_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information/" + tb_user.Text);
            MessageBox.Show("Deleted user: " + tb_user.Text);
            ClearTextBoxes();
        }

        // Deletes All Users
        private async void btn_deleteAll_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information");
            MessageBox.Show("Deleted all users");
            ClearTextBoxes();
        }
    }
}


