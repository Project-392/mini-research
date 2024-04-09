using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barcode
{
    public partial class Form2 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "E0w8q4Ea1nqjaHmgWpM2vTv7NximRUBxdALljKVK",
            BasePath = "https://fir-crud-b042d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient fbclient;
        public Form2()
        {
            InitializeComponent();
        }
        // Food data for the FireBase Database
        public class FoodData
        {
            public string Barcode { get; set; }
            public string Name { get; set; }
            public string Ingredients { get; set; }
            public string Nutrion { get; set; }
            public string Additives { get; set; }
            public string Vitamins { get; set; }
            public string Minerals { get; set; }
            public string Links { get; set; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fbclient = new FireSharp.FirebaseClient(config);

            if (fbclient != null)
            {
                MessageBox.Show("Connection is setup");
            }
        }

        // Function to clear all text boxes
        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        // Inserts food's data onto db
        private async void button1_Click(object sender, EventArgs e)
        {
            var fbData = new FoodData
            {
                Barcode = textBox1.Text,
                Name = textBox2.Text,
                Ingredients = textBox3.Text,
                Nutrion = textBox4.Text,
                Additives = textBox5.Text,
                Vitamins = textBox6.Text,
                Minerals = textBox7.Text,
                Links = textBox8.Text
            };

            SetResponse response = await fbclient.SetTaskAsync("Information/" + textBox1.Text, fbData);
            FoodData result = response.ResultAs<FoodData>();
            MessageBox.Show("fbData inserted for barcode number: " + result.Barcode);

            ClearTextBoxes();
        }
        // Updates Petfood's info
        private async void btn_update_Click(object sender, EventArgs e)
        {
            var fbData = new FoodData
            {
                Barcode = textBox1.Text,
                Name = textBox2.Text,
                Ingredients = textBox3.Text,
                Nutrion = textBox4.Text,
                Additives = textBox5.Text,
                Vitamins = textBox6.Text,
                Minerals = textBox7.Text,
                Links = textBox8.Text
            };

            FirebaseResponse response = await fbclient.UpdateTaskAsync("Information/" + textBox1.Text, fbData);
            FoodData result = response.ResultAs<FoodData>();
            MessageBox.Show("Updated food info for barcode number: " + result.Barcode);
            ClearTextBoxes();
        }

        // Delete a Single Food's Data
        private async void btn_delete_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await fbclient.DeleteTaskAsync("Information/" + textBox1.Text);
            MessageBox.Show("Deleted pet info for barcode number: " + textBox1.Text);
            ClearTextBoxes();
        }

        // Deletes All Users
        private async void btn_deleteAll_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await fbclient.DeleteTaskAsync("Information");
            MessageBox.Show("Deleted all pet foods");
            ClearTextBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
