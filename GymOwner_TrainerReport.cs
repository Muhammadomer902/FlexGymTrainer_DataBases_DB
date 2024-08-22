﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class GymOwner_TrainerReport : Form
    {
        private Form prevForm;
        private int GymOwner_ID;
        private int GymID; string gymname;
        public GymOwner_TrainerReport(Form prevForm, int gymOwner_ID)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.GymOwner_ID = gymOwner_ID;
            GymID = -1;
        }

        SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False");


        private void GymOwner_TrainerReport_Load(object sender, EventArgs e)
        {
            // Connection string to your SQL Server database

            string query = $"SELECT GymName FROM Gym Where Verified=1 and Owner_ID='{GymOwner_ID}'";
            // Create a SqlConnection object to connect to the database
            // Create a SqlCommand object with the SQL query and the SqlConnection
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Open the connection
                connection.Open();

                // Execute the query and obtain a SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Check if there are any rows returned
                    if (reader.HasRows)
                    {
                        // Iterate over the SqlDataReader
                        while (reader.Read())
                        {
                            // Retrieve the value from the reader and add it to the ComboBox
                            GymName.Items.Add(reader.GetString(0)); // Assuming the value is a string
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Gym Available!");
                        prevForm.Show();
                        this.Close();
                    }
                }

                connection.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (GymName.SelectedIndex != -1)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=MOUIDS-LAPTOP\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False"))
                {
                    string query = $@"
                                    SELECT *
                                    FROM Trainer
                                    WHERE Trainer_ID IN (
                                        SELECT Trainer_ID
                                        FROM Gym_Trainer
                                        WHERE Gym_ID = '{GymID}'
                                    )";

                    
                    connection.Open();

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter for GymID
                        command.Parameters.AddWithValue("@GymID", GymID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear the existing text in the RichTextBox
                            richTextBox1.Clear();

                            // Iterate through the results and append them to the RichTextBox
                            while (reader.Read())
                            {
                                // Format the data and append to the RichTextBox
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    richTextBox1.AppendText($"{reader.GetName(i)}: {reader.GetValue(i)}\n");
                                }
                                richTextBox1.AppendText("--------------------\n");
                            }
                        }
                    }

                    // Close the connection
                    connection.Close();
                }
            }

        }

        private void GymName_SelectedIndexChanged(object sender, EventArgs e)
        {
            gymname = GymName.Text;
            connection.Open();
            string query1 = $"SELECT Gym_ID FROM ( SELECT Gym_ID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM Gym WHERE Verified=1 and Owner_ID='{GymOwner_ID}') AS SubQuery WHERE RowNum = '{GymName.SelectedIndex + 1}'";
            SqlCommand Cmd1 = new SqlCommand(query1, connection);
            GymID = (int)Cmd1.ExecuteScalar();
            connection.Close();
        }
    }
}
