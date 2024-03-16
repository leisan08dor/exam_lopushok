using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopushok
{
    public partial class Form1_Login : Form
    {
        private string login = "";
        private string password = "";
        private int count;

        public Form1_Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            login = textBox1.Text;
            password = textBox2.Text;
            string getedPassword = "";

            if (login.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми!");
                return;
            }

            if (Program.connection.State == ConnectionState.Closed)
            {
                Program.connection.Open();
            }
            NpgsqlCommand commandGetLogin = new NpgsqlCommand($"SELECT password FROM users WHERE login = '{login}'", Program.connection);
            try
            {
                if (commandGetLogin.ExecuteScalar() == null)
                {
                    MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.connection.Close();
                    return;
                }

                getedPassword = commandGetLogin.ExecuteScalar().ToString();
            }
            catch
            {
                MessageBox.Show("Неизвестная шибка");
                Program.connection.Close();
                return;
            }
            Program.connection.Close();
            if (getedPassword != password)
            {
                count++;
                if (count == 3)
                {
                    this.Enabled = false;
                    await Task.Delay(20000);
                    this.Enabled = true;

                }
                MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Успешный вход!");
                this.Hide();
                Form2_Products newForm = new Form2_Products(); // создание новой формы
                newForm.Show();
            }

        }

        private void Form1_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
