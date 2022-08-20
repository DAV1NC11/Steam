using Npgsql;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace STEAM_FLOW_CALCULATIONS
{
    public partial class Form1 : Form
    {
        private string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2}; Password={3};Database={4};",
            "localhost", 5432, "postgres",
            "Chaga@2019...", "STEAM FLOW CALCULATION");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
            loadgrid();
            txtCombinedEnthalpy.Visible = false;
            lblCombinedEnthalpy.Visible = false;
            txtCorrectedWaterFlow.Visible = false;
            lblCorrectedWaterFlowrate.Visible = false;
            txtDifferentialPressure.Visible = false;
            lblDifferentialPressure.Visible = false;
            txtDrynessFraction.Visible = false;
            lblDrynessFraction.Visible = false;
            txtExpansibilityFactor.Visible = false;
            lblExpansibility.Visible = false;
            txtMassFlow.Visible = false;
            lblMassFlow.Visible = false;
            txtSteamEnthalpy.Visible = false;
            lblSteamEnthalpy.Visible = false;
            txtSteamFlowRate.Visible = false;
            lblSteamFLowRate.Visible = false;
            txtWaterCorrectionFactor.Visible = false;
            lblWaterCorrectionFactor.Visible = false;
            txtWaterEnthalpy.Visible = false;
            lblWaterEnthalpy.Visible = false;
            txtWaterFlowRate.Visible = false;
            lblWaterFlowRate.Visible = false;
            lblCalculatedResults.Visible = false;

        }

        private void loadgrid()
        {
            OleDbConnection con = new OleDbConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString()
            };
            try
            {
                con.Open();
                MessageBox.Show("Connection Success");
            }
            catch (Exception e)
            {
                MessageBox.Show("Database Error", e.Message);
            }


            OleDbCommand cmd = new OleDbCommand
            {
                CommandText = "select * from [Calculations]",
                Connection = con
            };
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvData.DataSource = ds.Tables[0];
            con.Close();

            
        }

        private void txtwellno_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPipeDiameter_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtOrificeDiameter_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtWellHeadPressure_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWaterHeight_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            double Hg = Convert.ToDouble(txtManometerr.Text);
            double P = Convert.ToDouble(txtUpstreamPressure.Text);
            double D = Convert.ToDouble(txtPipeDiameter.Text);
            double G = Convert.ToDouble(txtOrificeDiameter.Text);
            double Hw = Convert.ToDouble(txtWaterHeight.Text);
            double A = 0.000011;
            double F = 0.000018;
            double Hs = 2665.4;
            double Hsw = 2273.7;
            double Pa = P + 0.8;
            P = P * 98100 + 80000;


            double T = 0;
            double V = 0;
            double U = 0;
            if (P / 100000 <= 5)
            {
                T = 110.6 + (8.271401 * Math.Pow(10, -5) * P);
                V = 0.82506 - (9.109999 * Math.Pow(10, -7) * P);
                U = 1.2476 * (Math.Pow(10, -5)) + (3.0714 * Math.Pow(10, -12) * P);

            }

            else if (P / 100000f > 5)
            {
                T = 117.31 + (6.929 * Math.Pow(10, -5) * P);
                V = 0.66864 - (5.909 * Math.Pow(10, -7) * P);
                U = 1.2738 * Math.Pow(10, -5) + (2.543 * Math.Pow(10, -12) * P);
            }

            D = D * (1 + A * (T - 20)) / 1000;
            G = G * (1 + F * (T - 20)) / 1000;
            Hg = Hg * 13600 * 9.810001 * 0.0254;
            double B = G / D;
            double E = Math.Pow(1 - Math.Pow(B, 4), 0.5);
            E = 1 / E;
            double K = 1 - (0.41 + 0.35 * Math.Pow(B, 4));
            double R = 1000000;
            double X = 0.5994 + 0.312 * Math.Pow(B, 2.1) - 0.184 * Math.Pow(B, 8) - 0.0158 * Math.Pow(B, 3);
            double Q = 0;
            double M;
            do
            {
                double Y = 0.029 * Math.Pow(B, 2.5) * Math.Pow(1000000 / R, 0.75);
                M = Q;
                double C = X + Y;
                Q = C * E * K * 3.14 * Math.Pow(G, 2) * Math.Pow(2 * Hg / V, 0.5) / 4;
                R = 4 * Q / (3.14 * D * U);
            } while (Math.Abs(Q - M) > 0.1);
            double Ht = 353.28 + 93.816 * Math.Log(Pa) + 61.189 * Math.Pow(Pa, 0.5) + 1.0995 * Math.Pow(10, -5) * Math.Pow(Pa, 3);
            double Hfg = 2317.1 - 44.0548 * Math.Log(Pa) - 57.311 * Math.Pow(Pa, 0.5) - 1.9433 * Pa - 3.0737 * Math.Pow(10, -5) * Math.Pow(Pa, 3);
            double Hst = Ht + Hfg;
            double Mw = 0.048 * Math.Pow(Hw, 2.5);
            double Cw = (Mw * Hsw) / (Hs - Ht);
            Q *= 3.6;
            X = 1 - (Cw / (Q + Cw));
            double Sh = (Cw * Ht + Q * Hst) / (Cw + Q);

            double H;
            double Tm;
            double Cf = 0;
            if (Mw == 0)
            {
                H = Sh;
                Tm = Q + Cw;
            }

            else
            {
                Cf = Cw / Mw;
                H = Sh;
                Tm = Q + Cw;

            }

            txtCombinedEnthalpy.Text = Convert.ToString(H);
            txtCorrectedWaterFlow.Text = Convert.ToString(Cw);
            txtDifferentialPressure.Text = Convert.ToString(Hg);
            txtDrynessFraction.Text = Convert.ToString(X);
            txtExpansibilityFactor.Text = Convert.ToString(K);
            txtMassFlow.Text = Convert.ToString(Tm);
            txtSteamEnthalpy.Text = Convert.ToString(Hst);
            txtSteamFlowRate.Text = Convert.ToString(Q);
            txtWaterCorrectionFactor.Text = Convert.ToString(value: Cf);
            txtWaterEnthalpy.Text = Convert.ToString(Ht);
            txtWaterFlowRate.Text = Convert.ToString(Mw);

            txtCombinedEnthalpy.Visible = true;
            lblCombinedEnthalpy.Visible = true;
            txtCorrectedWaterFlow.Visible = true;
            lblCorrectedWaterFlowrate.Visible = true;
            txtDifferentialPressure.Visible = true;
            lblDifferentialPressure.Visible = true;
            txtDrynessFraction.Visible = true;
            lblDrynessFraction.Visible = true;
            txtExpansibilityFactor.Visible = true;
            lblExpansibility.Visible = true;
            txtMassFlow.Visible = true;
            lblMassFlow.Visible = true;
            txtSteamEnthalpy.Visible = true;
            lblSteamEnthalpy.Visible = true;
            txtSteamFlowRate.Visible = true;
            lblSteamFLowRate.Visible = true;
            txtWaterCorrectionFactor.Visible = true;
            lblWaterCorrectionFactor.Visible = true;
            txtWaterEnthalpy.Visible = true;
            lblWaterEnthalpy.Visible = true;
            txtWaterFlowRate.Visible = true;
            lblWaterFlowRate.Visible = true;

            OleDbConnection con = new OleDbConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString()
            };
            con.Open();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandText = "insert into [Calculations](DAY, TIME, WELL NO, PIPE DIAMETER, ORIFICE DIAMETER, WELL HEAD PRESSURE, DIFFERENTIAL PRESSURE, WATER HEIGHT, UPSTREAM PRESSURE, STEAM FLOW RATE, CORRECTED WATER FLOW RATE, MASS FLOW RATE, WATER ENTHALPY, STEAM ENTHALPY, COMBINED ENTHALPY, DRYNESS FRACTION)values(@date, @time, @wellno, @pipediameter, @orificediameter, @wellheadpressure, @differentialpressure, @waterheight, @upstreampressure, @steamflowrate, @corrwaterflow, @massflowrate, @waterenthalpy, @steamenthalpy, @combinedenthalpy, @drynessfraction)"
            };
            cmd.Parameters.AddWithValue("@date", dtDate.Text);
            cmd.Parameters.AddWithValue("@time", dtTime.Text);
            cmd.Parameters.AddWithValue("@wellno", txtwellno.Text);
            cmd.Parameters.AddWithValue("@pipediameter", txtPipeDiameter.Text);
            cmd.Parameters.AddWithValue("@orificediameter", txtOrificeDiameter.Text);
            cmd.Parameters.AddWithValue("@wellheadpressure", txtManometerr.Text);
            cmd.Parameters.AddWithValue("@differentialpressure", txtDifferentialPressure.Text);
            cmd.Parameters.AddWithValue("@waterheight", txtWaterHeight.Text);
            cmd.Parameters.AddWithValue("@upstreampressure", txtUpstreamPressure.Text);
            cmd.Parameters.AddWithValue("@steamflowrate", txtSteamFlowRate.Text);
            cmd.Parameters.AddWithValue("@corrwaterflow", txtCorrectedWaterFlow.Text);
            cmd.Parameters.AddWithValue("@massflowrate", txtMassFlow.Text);
            cmd.Parameters.AddWithValue("@waterenthalpy", txtWaterEnthalpy.Text);
            cmd.Parameters.AddWithValue("@steamenthalpy", txtSteamEnthalpy.Text);
            cmd.Parameters.AddWithValue("@combinedenthalpy", txtCombinedEnthalpy.Text);
            cmd.Parameters.AddWithValue("@drynessfraction", txtDrynessFraction.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Select();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select();
        }

        private void Select()
        {
            OleDbConnection con = new OleDbConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString()
            };
            con.Open();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandText = "select * from [Calculations]",
                Connection = con
            };
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvData.DataSource = ds.Tables[0];
            con.Close();

        }


        private void txtValueofCw_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCW_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
           
        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEvaluate_Click_1(object sender, EventArgs e)
        {
            double Hg = Convert.ToDouble(txtManometerr.Text);
            double P = Convert.ToDouble(txtUpstreamPressure.Text);
            double D = Convert.ToDouble(txtPipeDiameter.Text);
            double G = Convert.ToDouble(txtOrificeDiameter.Text);
            double Hw = Convert.ToDouble(txtWaterHeight.Text);
            double A = 0.000011;
            double F = 0.000018;
            double Hs = 2665.4;
            double Hsw = 2273.7;
            double Pa = P + 0.8;
            P = P * 98100 + 80000;


            double T = 0;
            double V = 0;
            double U = 0;
            if (P / 100000 <= 5)
            {
                T = 10.6 + (8.271401 * Math.Pow(10, -5) * P);
                V = 0.82506 - (9.109999 * Math.Pow(10, -7) * P);
                U = 1.2476 * (Math.Pow(10, -5)) + (3.0714 * Math.Pow(10, -12) * P);

            }

            else if (P / 100000f > 5)
            {
                T = 117.31 + (6.929 * Math.Pow(10, -5) * P);
                V = 0.66864 - (5.909 * Math.Pow(10, -7) * P);
                U = 1.2738 * Math.Pow(10, -5) + (2.543 * Math.Pow(10, -12) * P);
            }

            D = D * (1 + A * (T - 20)) / 1000;
            G = G * (1 + F * (T - 20)) / 1000;
            Hg = Hg * 13600 * 9.810001 * 0.0254;
            double B = G / D;
            double E = Math.Pow(1 - Math.Pow(B, 4), 0.5);
            E = 1 / E;
            double K = 1 - (0.41 + 0.35 * Math.Pow(B, 4));
            double R = 1000000;
            double X = 0.5994 + 0.312 * Math.Pow(B, 2.1) - 0.184 * Math.Pow(B, 8) - 0.0158 * Math.Pow(B, 3);
            double Q = 0;
            double M;
            do
            {
                double Y = 0.029 * Math.Pow(B, 2.5) * Math.Pow(1000000 / R, 0.75);
                M = Q;
                double C = X + Y;
                Q = C * E * K * 3.14 * Math.Pow(G, 2) * Math.Pow(2 * Hg / V, 0.5) / 4;
                R = 4 * Q / (3.14 * D * U);
            } while (Math.Abs(Q - M) > 0.1);
            double Ht = 353.28 + 93.816 * Math.Log(Pa) + 61.189 * Math.Pow(Pa, 0.5) + 1.0995 * Math.Pow(10, -5) * Math.Pow(Pa, 3);
            double Hfg = 2317.1 - 44.0548 * Math.Log(Pa) - 57.311 * Math.Pow(Pa, 0.5) - 1.9433 * Pa - 3.0737 * Math.Pow(10, -5) * Math.Pow(Pa, 3);
            double Hst = Ht + Hfg;
            double Mw = 0.048 * Math.Pow(Hw, 2.5);
            double Cw = (Mw * Hsw) / (Hs - Ht);
            Q *= 3.6;
            X = 1 - (Cw / (Q + Cw));
            double Sh = (Cw * Ht + Q * Hst) / (Cw + Q);

            double H;
            double Tm;
            double Cf = 0;
            if (Mw == 0)
            {
                H = Sh;
                Tm = Q + Cw;
            }

            else
            {
                Cf = Cw / Mw;
                H = Sh;
                Tm = Q + Cw;

            }

            txtCombinedEnthalpy.Text = Convert.ToString(Math.Round(H, 2));
            txtCorrectedWaterFlow.Text = Convert.ToString(Math.Round(Cw, 2));
            txtDifferentialPressure.Text = Convert.ToString(Math.Round(Hg, 2));
            txtDrynessFraction.Text = Convert.ToString(Math.Round(X, 2));
            txtExpansibilityFactor.Text = Convert.ToString(Math.Round(K, 2));
            txtMassFlow.Text = Convert.ToString(Math.Round(Tm, 2));
            txtSteamEnthalpy.Text = Convert.ToString(Math.Round(Hst, 2));
            txtSteamFlowRate.Text = Convert.ToString(Math.Round(Q, 2));
            txtWaterCorrectionFactor.Text = Convert.ToString(Math.Round(value: Cf, 2));
            txtWaterEnthalpy.Text = Convert.ToString(Math.Round(Ht, 2));
            txtWaterFlowRate.Text = Convert.ToString(Math.Round(Mw, 2));

            lblCalculatedResults.Visible = true;
            txtCombinedEnthalpy.Visible = true;
            lblCombinedEnthalpy.Visible = true;
            txtCorrectedWaterFlow.Visible = true;
            lblCorrectedWaterFlowrate.Visible = true;
            txtDifferentialPressure.Visible = true;
            lblDifferentialPressure.Visible = true;
            txtDrynessFraction.Visible = true;
            lblDrynessFraction.Visible = true;
            txtExpansibilityFactor.Visible = true;
            lblExpansibility.Visible = true;
            txtMassFlow.Visible = true;
            lblMassFlow.Visible = true;
            txtSteamEnthalpy.Visible = true;
            lblSteamEnthalpy.Visible = true;
            txtSteamFlowRate.Visible = true;
            lblSteamFLowRate.Visible = true;
            txtWaterCorrectionFactor.Visible = true;
            lblWaterCorrectionFactor.Visible = true;
            txtWaterEnthalpy.Visible = true;
            lblWaterEnthalpy.Visible = true;
            txtWaterFlowRate.Visible = true;
            lblWaterFlowRate.Visible = true;

            OleDbConnection con = new OleDbConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString()
            };
            con.Open();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandType = CommandType.Text,
                //cmd.CommandText = "insert into [Calculations](DAY, TIME, WELL_NO, PIPE_DIAMETER, ORIFICE_DIAMETER, WELL_HEAD_PRESSURE, DIFFERENTIAL_PRESSURE, WATER_HEIGHT, UPSTREAM_PRESSURE, STEAM_FLOW_ RATE, CORRECTED_WATER_FLOW_RATE, MASS_FLOW_RATE, WATER_ENTHALPY, STEAM_ENTHALPY, COMBINED_ENTHALPY, DRYNES_ FRACTION)values(@date, @time, @wellno, @pipediameter, @orificediameter, @wellheadpressure, @differentialpressure, @waterheight, @upstreampressure, @steamflowrate, @corrwaterflow, @massflowrate, @waterenthalpy, @steamenthalpy, @combinedenthalpy, @drynessfraction)";
                CommandText = "insert into Calculations values ('" + dtDate.Text + "', '" + dtTime.Text + "', '" + txtwellno.Text + "', '" + txtPipeDiameter.Text + "', '" + txtOrificeDiameter.Text + "', '" + txtManometerr.Text + "', '" + txtDifferentialPressure.Text + "', '" + txtWaterHeight.Text + "', '" + txtUpstreamPressure.Text + "', '" + txtSteamFlowRate.Text + "', '" + txtCorrectedWaterFlow.Text + "', '" + txtMassFlow.Text + "', '" + txtWaterEnthalpy.Text + "', '" + txtSteamEnthalpy.Text + "', '" + txtCombinedEnthalpy.Text + "', '" + txtDrynessFraction.Text + "')",
                //(DAY, [TIME], WELL_NO, PIPE_DIAMETER, ORIFICE_DIAMETER, WELL_HEAD_PRESSURE, DIFFERENTIAL_PRESSURE, WATER_HEIGHT, UPSTREAM_PRESSURE, STEAM_FLOW_ RATE, CORRECTED_WATER_FLOW_RATE, MASS_FLOW_RATE, WATER_ENTHALPY, STEAM_ENTHALPY, COMBINED_ENTHALPY, DRYNESS_ FRACTION)
                //cmd.Parameters.AddWithValue("@date", dtDate.Text);
                //cmd.Parameters.AddWithValue("@time", dtTime.Text);
                //cmd.Parameters.AddWithValue("@wellno", txtwellno.Text);
                //cmd.Parameters.AddWithValue("@pipediameter", txtPipeDiameter.Text);
                //cmd.Parameters.AddWithValue("@orificediameter", txtOrificeDiameter.Text);
                //cmd.Parameters.AddWithValue("@wellheadpressure", txtManometerr.Text);
                //cmd.Parameters.AddWithValue("@differentialpressure", txtDifferentialPressure.Text);
                //cmd.Parameters.AddWithValue("@waterheight", txtWaterHeight.Text);
                //cmd.Parameters.AddWithValue("@upstreampressure", txtUpstreamPressure.Text);
                //cmd.Parameters.AddWithValue("@steamflowrate", txtSteamFlowRate.Text);
                //cmd.Parameters.AddWithValue("@corrwaterflow", txtCorrectedWaterFlow.Text);
                //cmd.Parameters.AddWithValue("@massflowrate", txtMassFlow.Text);
                //cmd.Parameters.AddWithValue("@waterenthalpy", txtWaterEnthalpy.Text);
                //cmd.Parameters.AddWithValue("@steamenthalpy", txtSteamEnthalpy.Text);
                //cmd.Parameters.AddWithValue("@combinedenthalpy", txtCombinedEnthalpy.Text);
                //cmd.Parameters.AddWithValue("@drynessfraction", txtDrynessFraction.Text);
                Connection = con
            };
            cmd.ExecuteNonQuery();
            con.Close();
            Select();
        }
    }
}
