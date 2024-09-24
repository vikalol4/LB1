using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using winda1.DBContext;

namespace winda1.DBContext
{
    public partial class FormAddUsers : Form
    {
        public FormAddUsers()
        {
            InitializeComponent();
        }

        Model1 model = new Model1();

        private void FormAddUsers_Load(object sender, EventArgs e)
        {
           BindingSource1.DataSource = model.Roles.ToList();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
            if (!reg.IsMatch(emailtextBox.Text))
            {
                MessageBox.Show("Почта не соотвествует требованиям!");
                return;
            }
            if (!passwordtextBox.Text.Equals(passwordtextBox2.Text))
            {
                MessageBox.Show("Пароли не равны!");
                return;
            }
            if (String.IsNullOrWhiteSpace(logintextBox.Text) ||
            String.IsNullOrWhiteSpace(passwordtextBox.Text) ||
            String.IsNullOrWhiteSpace(textBoxname.Text) ||
            String.IsNullOrWhiteSpace(textBoxname2.Text) ||
            !maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            Users users = new Users();
            users.ID = 0;
            users.Login = logintextBox.Text;
            users.Password = passwordtextBox.Text;
            users.Email = emailtextBox.Text;
            users.Phone = maskedTextBox1.Text;
            users.First_Name = textBoxname.Text;
            users.Second_Name = textBoxname2.Text;
            users.RoleID = (int)comboBoxroleID.SelectedValue;
            users.Gender = menradioButton.Checked ? "Мужской" : "Женский";

            try
            {
                model.Users.Add(users);
                model.SaveChanges();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Данные добавленны!");
            Close();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}



