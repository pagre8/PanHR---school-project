using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace wroom
{
    public partial class Pracownicy : Form
    {
        public Pracownicy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.workersTableAdapter.Fill(this.hRDBDataSet.Workers);
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            Wykres form3 = new Wykres(peselMaskedTextBox.Text);
            form3.Show();
            
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|HRDB.mdf;Integrated Security=True");

        private void ClearButton_Cliick(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            surnameTextBox.Clear();
            peselMaskedTextBox.Clear();
            positionTextBox.Clear();
            ageMaskedTextBox.Clear();
            educationTextBox.Clear();
            internshipNumericUpDown.Text = "0";
            paymentUpDown.Text = "0";
            contractComboBox.Text = "";
            shiftTextBox.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];

            nameTextBox.Text = selectedRow.Cells[0].Value.ToString();
            surnameTextBox.Text = selectedRow.Cells[1].Value.ToString();
            peselMaskedTextBox.Text = selectedRow.Cells[2].Value.ToString();
            ageMaskedTextBox.Text = selectedRow.Cells[3].Value.ToString();
            internshipNumericUpDown.Text = selectedRow.Cells[4].Value.ToString();
            paymentUpDown.Text = selectedRow.Cells[5].Value.ToString();
            educationTextBox.Text = selectedRow.Cells[6].Value.ToString();
            positionTextBox.Text = selectedRow.Cells[7].Value.ToString();
            contractComboBox.Text = selectedRow.Cells[8].Value.ToString();
            shiftTextBox.Text = selectedRow.Cells[9].Value.ToString();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (nameTextBox.Text == "" ||
                    surnameTextBox.Text == "" ||
                    peselMaskedTextBox.Text == "" ||
                    positionTextBox.Text == "" ||
                    ageMaskedTextBox.Text == "" ||
                    educationTextBox.Text == "" ||
                    contractComboBox.Text == "" ||
                    shiftTextBox.Text == "") 
                {
                    throw new Exception("Pola nie mogą być puste");
                }
                    var cmd = new SqlCommand($"insert into Workers (Name,Surname,Position,Pesel,Contract_type,Pay_per_h,Bday,Shift, seniority, education) Values ('{nameTextBox.Text}','{surnameTextBox.Text}','{positionTextBox.Text}','{peselMaskedTextBox.Text}','{contractComboBox.Text}',{paymentUpDown.Value},'{ageMaskedTextBox.Text}','{shiftTextBox.Text}',{internshipNumericUpDown.Value},'{educationTextBox.Text}')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania pracownika\n"+ex.Message,"Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
                MessageBox.Show("Dodano pomyślnie","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form1_Load(sender,e);
            
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == "" ||
                    surnameTextBox.Text == "" ||
                    peselMaskedTextBox.Text == "" ||
                    positionTextBox.Text == "" ||
                    ageMaskedTextBox.Text == "" ||
                    educationTextBox.Text == "" ||
                    contractComboBox.Text == "" ||
                    shiftTextBox.Text == "")
                {
                    throw new Exception("Pola nie mogą być puste");
                }
                var cmd = new SqlCommand($"update Workers set Name = '{nameTextBox.Text}', Surname = '{surnameTextBox.Text}', Position = '{positionTextBox.Text}', Pesel = '{peselMaskedTextBox.Text}', Contract_type = '{contractComboBox.Text}', Pay_per_h = {paymentUpDown.Value}, Bday = '{ageMaskedTextBox.Text}', Shift = '{shiftTextBox.Text}', seniority = {internshipNumericUpDown.Value}, education = '{educationTextBox}'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas aktualizacji pracownika\n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Zaktualizowano pomyślnie pomyślnie", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1_Load(sender, e);
        }
    }
}
