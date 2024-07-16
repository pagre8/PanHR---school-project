using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace wroom
{
    public partial class Wykres : Form
    {
        public Wykres(String pesel)
        {
            
            InitializeComponent();
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|HRDB.mdf;Integrated Security=True");

                ChartValues<ObservablePoint> values = new ChartValues<ObservablePoint>();

                var cmd = new SqlCommand($"select Worked_hours.amount, Worked_hours.Month,Workers.Name from Worked_hours, Workers where Worked_hours.Worker_id = Workers.id and Workers.pesel = '{pesel}' order by Worked_hours.Month", conn);

                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ObservablePoint observablePoint = new ObservablePoint();
                        observablePoint.X = (int)reader["Month"];
                        observablePoint.Y = (int)reader["amount"];
                        this.Text = "Wykres dla: "+(string)reader["Name"];
                        values.Add(observablePoint);
                    }
                    reader.NextResult();
                }
                reader.Close();
                cmd.Dispose();

                LineSeries lineSeries = new LineSeries()
                {
                    Values = values,
                    PointGeometrySize = 15
                };

                SeriesCollection seriesCollecion = new SeriesCollection();

                seriesCollecion.Add(lineSeries);

                cartesianChart1.Series = seriesCollecion;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Wykres_Load(object sender, EventArgs e)
        {

        }
    }
}
