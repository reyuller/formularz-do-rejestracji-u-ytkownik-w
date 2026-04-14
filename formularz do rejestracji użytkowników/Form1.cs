using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace formularz_do_rejestracji_użytkowników
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			listView1.View = View.Details;
			listView1.Columns.Add("Username", 120);
			listView1.Columns.Add("Email", 200);
			listView1.Columns.Add("Password", 120);
			listView1.FullRowSelect = true;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		
		}
		private void textBox3_TextChanged_1(object sender, EventArgs e)
		{

		}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void password_Textchanged(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private bool IsValidEmail(string email)
		{
			string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
			return Regex.IsMatch(email, pattern);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			error.Text = "";

			string nazwauzytkownika = textBox4.Text;
			string email = textBox3.Text;
			string pwd = textbox6.Text;

			if (nazwauzytkownika == "" || email == "" || pwd == "")
			{
				error.Text = "Wszystkie pola muszą być wypełnione!";
				return;
			}

			if (!IsValidEmail(email))
			{
				error.Text = "Niepoprawny adres e-mail!";
				return;
			}

			if (!checkBox1.Checked)
			{
				error.Text = "Musisz zaakceptować regulamin!";
				return;
			}

			ListViewItem item = new ListViewItem(nazwauzytkownika);
			item.SubItems.Add(email);
			item.SubItems.Add(pwd);

			listView1.Items.Add(item);

			textBox4.Clear();
			textBox3.Clear();
			textbox6.Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				listView1.Items.Remove(listView1.SelectedItems[0]);
			}
			else
			{
				MessageBox.Show("Wybierz użytkownika do usunięcia!");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textbox6.PasswordChar = '*';
		}

		private void textBox4_TextChanged_1(object sender, EventArgs e)
		{

		}
	}
}
