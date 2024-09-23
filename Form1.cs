using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Reflection.Metadata;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace NoteTaking
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=NoteTaking;Uid=root;Pwd=1234;";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
            }
        }

        //Insert Note Method
        private void InsertNote()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO note (Title, Body) VALUES (@Title, @Body)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", TitleTxt.Text);
                command.Parameters.AddWithValue("@Body", BodyTxt.Text);

                command.ExecuteNonQuery();

                MessageBox.Show($"{TitleTxt.Text} \nadded successfully!");

            }
        }

        //Insert Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertNote();
        }

        //Notes List Method
        private void LoadNotes()
        {
            Notes.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Define the SQL query to fetch the data (e.g., Title)
                    string query = "SELECT Title FROM note";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Execute the query and get a MySQL data reader to read the data
                    MySqlDataReader reader = command.ExecuteReader();

                    // Loop through the data and add each record to the ListBox
                    while (reader.Read())
                    {
                        Notes.Items.Add(reader["Title"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        //Show Notes List Button
        private void ShowListBtn_Click(object sender, EventArgs e)
        {
            LoadNotes();
        }

        //Delete a Note Method
        private void DeleteNote()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM note where Title = @Title";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", Notes.SelectedItem);
                    command.ExecuteNonQuery();

                    MessageBox.Show($"{Notes.SelectedItem} \ndeleted successfully");
                }


            }
        }

        //Delete a Note Button
        private void DelBtn_Click(object sender, EventArgs e)
        {
            DeleteNote();


        }

        //Open a Note Method
        private void OpenNote()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM note WHERE Title = @Title";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", Notes.SelectedItem);
                    command.ExecuteNonQuery();

                    MessageBox.Show($"This Note is \n{Notes.SelectedItem}");
                }
            }
        }

        //Open a Note Button
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenNote();

        }

        //Search a Note Method
        public List<string> SearchNotes(string keyword)
        {
            List<string> notes = new List<string>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT title FROM note WHERE Title LIKE @keyword OR Body LIKE @keyword";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notes.Add(reader["title"].ToString());
                        }
                    }
                }
            }
            return notes;
        }

        //Search a Note Button
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string keyword = SearchBarTxt.Text;
            Notes.Items.Clear();
            List<string> notes = SearchNotes(keyword);
            foreach (var note in notes)
            {
                Notes.Items.Add(note);  // Add the note titles to the ListBox
            }
        }
    }
}
