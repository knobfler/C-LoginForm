using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if(idField.Text == "" || idField.Text.Length <= 0)
            {
                MessageBox.Show("아이디를 입력해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (passwordField.Text == "" || passwordField.Text.Length <= 0)
            {
                MessageBox.Show("비밀번호를 입력해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=soft1234");
            //if (connection != null)
            //{
            //    MessageBox.Show("연결되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            MySqlCommand command = new MySqlCommand("select * from csharptest.member where userID = '" + idField.Text + "';", connection);
            MySqlCommand insertCommand = new MySqlCommand("insert into csharptest.member (userID, userPassword) values ('" + idField.Text + "', '" + passwordField.Text + "');", connection);
            MySqlDataReader reader;
            

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //try
            //{
            //    connection.Open();
            //    reader = command.ExecuteReader();
            //    int count = 0;
            //    while (reader.Read())
            //    {
            //        count++;
            //    }
            //    if(count == 1)
            //    {
            //        MessageBox.Show("연결되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    } else
            //    {
            //        MessageBox.Show("잘못된 계정입니다..", "성공", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            //}
            // catch(Exception exception)
            //{
            //    MessageBox.Show(exception.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
        }
    }
}
