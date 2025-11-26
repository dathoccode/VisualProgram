using ABCCoffee.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ABCCoffee.GUI.UserControls
{
    public partial class UC_Statistic : UserControl
    {
        public UC_Statistic()
        {
            InitializeComponent();
        }

        Chart chart = new Chart();
        DataGridView dgvCheckIn = new DataGridView();

        private void UpdateChart()
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            ChartArea area = new ChartArea("ChartArea");
            chart.ChartAreas.Add(area);
            switch (cbChartType.Text)
            {
                case "Doanh số bán hàng":
                    IncomeChart();
                    break;
                case "Số lượng sản phẩm":
                    FoodSaleChart(); 
                    break;
                case "Bảng công":
                    CheckInTable();
                    break;
                default:
                    break;
            }
        }

        private void IncomeChart()
        {
            showChart();
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column; // cột
            string query = "USP_IncomeChartByDate @beginTime , @endTime";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, 
                new object[] {dtpBeginTime.Value, dtpEndTime.Value });
            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["SaleDate"], Convert.ToDouble(row["Revenue"] ));
            }
            chart.Series.Add(series);
        }

        private void showChart()
        {
            pnChart.Controls.Clear();
            pnChart.Controls.Add(chart);
            chart.Dock = DockStyle.Fill;
        }

        private void showTable()
        {
            pnChart.Controls.Clear();
            pnChart.Controls.Add(dgvCheckIn);
            dgvCheckIn.AllowUserToAddRows = false;
            dgvCheckIn.Dock = DockStyle.Fill;
        }

        private void FoodSaleChart()
        {
            showChart();
            Series series = new Series("Số lượng bán");
            series.ChartType= SeriesChartType.Pie;
            if(chart.Legends.Count == 0)
            {
                chart.Legends.Add(new Legend("Legend 1"));
            }
            string query = "USP_FoodSaleRatio @beginTime , @endTime";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query,
                new object[] { dtpBeginTime.Value, dtpEndTime.Value });
            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["FoodName"], Convert.ToDouble(row["SaleQuantity"]));
            }
            series["PieLabelStyle"] = "Disabled";
            chart.Series.Add(series);
        }

        private void CheckInTable()
        {
            showTable();
            string query = "USP_GetCheckInTable @beginTime , @endTime";
            DataTable raw = DataProvider.Instance.ExecuteQuery(query,
                new object[] { dtpBeginTime.Value, dtpEndTime.Value });
            DataTable matrix = BuildMatrix(raw);
            dgvCheckIn.DataSource = matrix;
            dgvCheckIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckIn.RowHeadersVisible = false;
            dgvCheckIn.BackgroundColor = Color.White;
            dgvCheckIn.AllowUserToResizeColumns = false;
            dgvCheckIn.AllowUserToResizeRows = false;
        }
        private void cbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void dtpBeginTime_ValueChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void dtpEndTime_ValueChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void UC_Statistic_Load(object sender, EventArgs e)
        {
            cbChartType.SelectedIndex = 0;
            UpdateChart();
        }
        private DataTable BuildMatrix(DataTable raw)
        {
            DataTable matrix = new DataTable();
            matrix.Columns.Add("Ngày");

            var employees = raw.AsEnumerable()
                .Select(r => r["DisplayName"].ToString())
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            foreach (var emp in employees)
                matrix.Columns.Add(emp, typeof(string));

            var dates = raw.AsEnumerable()
                .Select(r => Convert.ToDateTime(r["CheckInDate"]))
                .Distinct()
                .OrderBy(d => d)
                .ToList();

            foreach (var date in dates)
            {
                DataRow row = matrix.NewRow();
                row["Ngày"] = date.ToString("dd/MM/yyyy");

                foreach (var emp in employees)
                {
                    bool has = raw.AsEnumerable().Any(r =>
                        r["DisplayName"].ToString() == emp &&
                        Convert.ToDateTime(r["CheckInDate"]) == date);

                    row[emp] = has ? "✔" : "";
                }

                matrix.Rows.Add(row);
            }

            return matrix;
        }

    }
}
