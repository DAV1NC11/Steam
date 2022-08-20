namespace STEAM_FLOW_CALCULATIONS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblCalculatedResults = new System.Windows.Forms.Label();
            this.lblCombinedEnthalpy = new System.Windows.Forms.Label();
            this.lblWaterCorrectionFactor = new System.Windows.Forms.Label();
            this.lblDrynessFraction = new System.Windows.Forms.Label();
            this.txtCombinedEnthalpy = new System.Windows.Forms.TextBox();
            this.txtWaterCorrectionFactor = new System.Windows.Forms.TextBox();
            this.txtDrynessFraction = new System.Windows.Forms.TextBox();
            this.lblMassFlow = new System.Windows.Forms.Label();
            this.lblSteamEnthalpy = new System.Windows.Forms.Label();
            this.txtMassFlow = new System.Windows.Forms.TextBox();
            this.lblCorrectedWaterFlowrate = new System.Windows.Forms.Label();
            this.txtSteamEnthalpy = new System.Windows.Forms.TextBox();
            this.lblWaterEnthalpy = new System.Windows.Forms.Label();
            this.txtCorrectedWaterFlow = new System.Windows.Forms.TextBox();
            this.lblWaterFlowRate = new System.Windows.Forms.Label();
            this.txtWaterEnthalpy = new System.Windows.Forms.TextBox();
            this.lblSteamFLowRate = new System.Windows.Forms.Label();
            this.txtWaterFlowRate = new System.Windows.Forms.TextBox();
            this.txtSteamFlowRate = new System.Windows.Forms.TextBox();
            this.lblDifferentialPressure = new System.Windows.Forms.Label();
            this.lblExpansibility = new System.Windows.Forms.Label();
            this.txtDifferentialPressure = new System.Windows.Forms.TextBox();
            this.txtExpansibilityFactor = new System.Windows.Forms.TextBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.txtWaterHeight = new System.Windows.Forms.TextBox();
            this.txtManometerr = new System.Windows.Forms.TextBox();
            this.txtManometerHt = new System.Windows.Forms.TextBox();
            this.lblWaterHeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblManometerHt = new System.Windows.Forms.Label();
            this.txtUpstreamPressure = new System.Windows.Forms.TextBox();
            this.txtOrificeDiameter = new System.Windows.Forms.TextBox();
            this.txtPipeDiameter = new System.Windows.Forms.TextBox();
            this.lblUpstreamPressure = new System.Windows.Forms.Label();
            this.lblOrificeDiameter = new System.Windows.Forms.Label();
            this.lblpipediameter = new System.Windows.Forms.Label();
            this.txtwellno = new System.Windows.Forms.TextBox();
            this.lblwellno = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(4, 403);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(774, 335);
            this.dgvData.TabIndex = 181;
            // 
            // lblCalculatedResults
            // 
            this.lblCalculatedResults.AutoSize = true;
            this.lblCalculatedResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculatedResults.Location = new System.Drawing.Point(477, 18);
            this.lblCalculatedResults.Name = "lblCalculatedResults";
            this.lblCalculatedResults.Size = new System.Drawing.Size(112, 13);
            this.lblCalculatedResults.TabIndex = 180;
            this.lblCalculatedResults.Text = "Calculated results:";
            // 
            // lblCombinedEnthalpy
            // 
            this.lblCombinedEnthalpy.AutoSize = true;
            this.lblCombinedEnthalpy.Location = new System.Drawing.Point(474, 385);
            this.lblCombinedEnthalpy.Name = "lblCombinedEnthalpy";
            this.lblCombinedEnthalpy.Size = new System.Drawing.Size(101, 13);
            this.lblCombinedEnthalpy.TabIndex = 179;
            this.lblCombinedEnthalpy.Text = "Combined Enthalpy:";
            // 
            // lblWaterCorrectionFactor
            // 
            this.lblWaterCorrectionFactor.AutoSize = true;
            this.lblWaterCorrectionFactor.Location = new System.Drawing.Point(475, 351);
            this.lblWaterCorrectionFactor.Name = "lblWaterCorrectionFactor";
            this.lblWaterCorrectionFactor.Size = new System.Drawing.Size(123, 13);
            this.lblWaterCorrectionFactor.TabIndex = 170;
            this.lblWaterCorrectionFactor.Text = "Water Correction Factor:";
            // 
            // lblDrynessFraction
            // 
            this.lblDrynessFraction.AutoSize = true;
            this.lblDrynessFraction.Location = new System.Drawing.Point(475, 318);
            this.lblDrynessFraction.Name = "lblDrynessFraction";
            this.lblDrynessFraction.Size = new System.Drawing.Size(89, 13);
            this.lblDrynessFraction.TabIndex = 171;
            this.lblDrynessFraction.Text = "Dryness Fraction:";
            // 
            // txtCombinedEnthalpy
            // 
            this.txtCombinedEnthalpy.Location = new System.Drawing.Point(664, 377);
            this.txtCombinedEnthalpy.Name = "txtCombinedEnthalpy";
            this.txtCombinedEnthalpy.Size = new System.Drawing.Size(100, 20);
            this.txtCombinedEnthalpy.TabIndex = 164;
            // 
            // txtWaterCorrectionFactor
            // 
            this.txtWaterCorrectionFactor.Location = new System.Drawing.Point(664, 344);
            this.txtWaterCorrectionFactor.Name = "txtWaterCorrectionFactor";
            this.txtWaterCorrectionFactor.Size = new System.Drawing.Size(100, 20);
            this.txtWaterCorrectionFactor.TabIndex = 166;
            // 
            // txtDrynessFraction
            // 
            this.txtDrynessFraction.Location = new System.Drawing.Point(664, 311);
            this.txtDrynessFraction.Name = "txtDrynessFraction";
            this.txtDrynessFraction.Size = new System.Drawing.Size(100, 20);
            this.txtDrynessFraction.TabIndex = 168;
            // 
            // lblMassFlow
            // 
            this.lblMassFlow.AutoSize = true;
            this.lblMassFlow.Location = new System.Drawing.Point(475, 285);
            this.lblMassFlow.Name = "lblMassFlow";
            this.lblMassFlow.Size = new System.Drawing.Size(89, 13);
            this.lblMassFlow.TabIndex = 178;
            this.lblMassFlow.Text = "Mass Flow(T/Hr):";
            // 
            // lblSteamEnthalpy
            // 
            this.lblSteamEnthalpy.AutoSize = true;
            this.lblSteamEnthalpy.Location = new System.Drawing.Point(475, 252);
            this.lblSteamEnthalpy.Name = "lblSteamEnthalpy";
            this.lblSteamEnthalpy.Size = new System.Drawing.Size(119, 13);
            this.lblSteamEnthalpy.TabIndex = 173;
            this.lblSteamEnthalpy.Text = "Steam Enthalpy(kJ/Kg):";
            // 
            // txtMassFlow
            // 
            this.txtMassFlow.Location = new System.Drawing.Point(664, 278);
            this.txtMassFlow.Name = "txtMassFlow";
            this.txtMassFlow.Size = new System.Drawing.Size(100, 20);
            this.txtMassFlow.TabIndex = 167;
            // 
            // lblCorrectedWaterFlowrate
            // 
            this.lblCorrectedWaterFlowrate.AutoSize = true;
            this.lblCorrectedWaterFlowrate.Location = new System.Drawing.Point(475, 219);
            this.lblCorrectedWaterFlowrate.Name = "lblCorrectedWaterFlowrate";
            this.lblCorrectedWaterFlowrate.Size = new System.Drawing.Size(168, 13);
            this.lblCorrectedWaterFlowrate.TabIndex = 172;
            this.lblCorrectedWaterFlowrate.Text = "Corrected Water Flow Rate(T/Hr):";
            // 
            // txtSteamEnthalpy
            // 
            this.txtSteamEnthalpy.Location = new System.Drawing.Point(664, 245);
            this.txtSteamEnthalpy.Name = "txtSteamEnthalpy";
            this.txtSteamEnthalpy.Size = new System.Drawing.Size(100, 20);
            this.txtSteamEnthalpy.TabIndex = 165;
            // 
            // lblWaterEnthalpy
            // 
            this.lblWaterEnthalpy.AutoSize = true;
            this.lblWaterEnthalpy.Location = new System.Drawing.Point(475, 186);
            this.lblWaterEnthalpy.Name = "lblWaterEnthalpy";
            this.lblWaterEnthalpy.Size = new System.Drawing.Size(118, 13);
            this.lblWaterEnthalpy.TabIndex = 175;
            this.lblWaterEnthalpy.Text = "Water Enthalpy(kJ/Kg):";
            // 
            // txtCorrectedWaterFlow
            // 
            this.txtCorrectedWaterFlow.Location = new System.Drawing.Point(664, 212);
            this.txtCorrectedWaterFlow.Name = "txtCorrectedWaterFlow";
            this.txtCorrectedWaterFlow.Size = new System.Drawing.Size(100, 20);
            this.txtCorrectedWaterFlow.TabIndex = 163;
            // 
            // lblWaterFlowRate
            // 
            this.lblWaterFlowRate.AutoSize = true;
            this.lblWaterFlowRate.Location = new System.Drawing.Point(475, 153);
            this.lblWaterFlowRate.Name = "lblWaterFlowRate";
            this.lblWaterFlowRate.Size = new System.Drawing.Size(119, 13);
            this.lblWaterFlowRate.TabIndex = 176;
            this.lblWaterFlowRate.Text = "Water Flow Rate(T/Hr):";
            // 
            // txtWaterEnthalpy
            // 
            this.txtWaterEnthalpy.Location = new System.Drawing.Point(664, 179);
            this.txtWaterEnthalpy.Name = "txtWaterEnthalpy";
            this.txtWaterEnthalpy.Size = new System.Drawing.Size(100, 20);
            this.txtWaterEnthalpy.TabIndex = 162;
            // 
            // lblSteamFLowRate
            // 
            this.lblSteamFLowRate.AutoSize = true;
            this.lblSteamFLowRate.Location = new System.Drawing.Point(475, 120);
            this.lblSteamFLowRate.Name = "lblSteamFLowRate";
            this.lblSteamFLowRate.Size = new System.Drawing.Size(120, 13);
            this.lblSteamFLowRate.TabIndex = 177;
            this.lblSteamFLowRate.Text = "Steam Flow Rate(T/Hr):";
            // 
            // txtWaterFlowRate
            // 
            this.txtWaterFlowRate.Location = new System.Drawing.Point(664, 146);
            this.txtWaterFlowRate.Name = "txtWaterFlowRate";
            this.txtWaterFlowRate.Size = new System.Drawing.Size(100, 20);
            this.txtWaterFlowRate.TabIndex = 161;
            // 
            // txtSteamFlowRate
            // 
            this.txtSteamFlowRate.Location = new System.Drawing.Point(664, 113);
            this.txtSteamFlowRate.Name = "txtSteamFlowRate";
            this.txtSteamFlowRate.Size = new System.Drawing.Size(100, 20);
            this.txtSteamFlowRate.TabIndex = 160;
            // 
            // lblDifferentialPressure
            // 
            this.lblDifferentialPressure.AutoSize = true;
            this.lblDifferentialPressure.Location = new System.Drawing.Point(475, 86);
            this.lblDifferentialPressure.Name = "lblDifferentialPressure";
            this.lblDifferentialPressure.Size = new System.Drawing.Size(101, 13);
            this.lblDifferentialPressure.TabIndex = 169;
            this.lblDifferentialPressure.Text = "Well Head Pressure";
            // 
            // lblExpansibility
            // 
            this.lblExpansibility.AutoSize = true;
            this.lblExpansibility.Location = new System.Drawing.Point(475, 53);
            this.lblExpansibility.Name = "lblExpansibility";
            this.lblExpansibility.Size = new System.Drawing.Size(97, 13);
            this.lblExpansibility.TabIndex = 174;
            this.lblExpansibility.Text = "Expansibility factor:";
            // 
            // txtDifferentialPressure
            // 
            this.txtDifferentialPressure.Location = new System.Drawing.Point(664, 79);
            this.txtDifferentialPressure.Name = "txtDifferentialPressure";
            this.txtDifferentialPressure.Size = new System.Drawing.Size(100, 20);
            this.txtDifferentialPressure.TabIndex = 159;
            // 
            // txtExpansibilityFactor
            // 
            this.txtExpansibilityFactor.Location = new System.Drawing.Point(664, 46);
            this.txtExpansibilityFactor.Name = "txtExpansibilityFactor";
            this.txtExpansibilityFactor.Size = new System.Drawing.Size(100, 20);
            this.txtExpansibilityFactor.TabIndex = 158;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.AutoEllipsis = true;
            this.btnEvaluate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEvaluate.Location = new System.Drawing.Point(134, 255);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluate.TabIndex = 7;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click_1);
            // 
            // txtWaterHeight
            // 
            this.txtWaterHeight.Location = new System.Drawing.Point(204, 200);
            this.txtWaterHeight.Name = "txtWaterHeight";
            this.txtWaterHeight.Size = new System.Drawing.Size(100, 20);
            this.txtWaterHeight.TabIndex = 6;
            // 
            // txtManometerr
            // 
            this.txtManometerr.Location = new System.Drawing.Point(204, 174);
            this.txtManometerr.Name = "txtManometerr";
            this.txtManometerr.Size = new System.Drawing.Size(100, 20);
            this.txtManometerr.TabIndex = 5;
            // 
            // txtManometerHt
            // 
            this.txtManometerHt.Location = new System.Drawing.Point(204, 174);
            this.txtManometerHt.Name = "txtManometerHt";
            this.txtManometerHt.Size = new System.Drawing.Size(100, 20);
            this.txtManometerHt.TabIndex = 154;
            // 
            // lblWaterHeight
            // 
            this.lblWaterHeight.AutoSize = true;
            this.lblWaterHeight.Location = new System.Drawing.Point(10, 200);
            this.lblWaterHeight.Name = "lblWaterHeight";
            this.lblWaterHeight.Size = new System.Drawing.Size(190, 13);
            this.lblWaterHeight.TabIndex = 153;
            this.lblWaterHeight.Text = "Water Height through the V-notch(cm):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 152;
            this.label2.Text = "Manometer Ht(inch Hg):";
            // 
            // lblManometerHt
            // 
            this.lblManometerHt.AutoSize = true;
            this.lblManometerHt.Location = new System.Drawing.Point(10, 174);
            this.lblManometerHt.Name = "lblManometerHt";
            this.lblManometerHt.Size = new System.Drawing.Size(147, 13);
            this.lblManometerHt.TabIndex = 151;
            this.lblManometerHt.Text = "Differential Pressure(inch Hg):";
            // 
            // txtUpstreamPressure
            // 
            this.txtUpstreamPressure.Location = new System.Drawing.Point(204, 139);
            this.txtUpstreamPressure.Name = "txtUpstreamPressure";
            this.txtUpstreamPressure.Size = new System.Drawing.Size(100, 20);
            this.txtUpstreamPressure.TabIndex = 4;
            // 
            // txtOrificeDiameter
            // 
            this.txtOrificeDiameter.Location = new System.Drawing.Point(204, 108);
            this.txtOrificeDiameter.Name = "txtOrificeDiameter";
            this.txtOrificeDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtOrificeDiameter.TabIndex = 3;
            // 
            // txtPipeDiameter
            // 
            this.txtPipeDiameter.Location = new System.Drawing.Point(204, 79);
            this.txtPipeDiameter.Name = "txtPipeDiameter";
            this.txtPipeDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtPipeDiameter.TabIndex = 2;
            // 
            // lblUpstreamPressure
            // 
            this.lblUpstreamPressure.AutoSize = true;
            this.lblUpstreamPressure.Location = new System.Drawing.Point(10, 146);
            this.lblUpstreamPressure.Name = "lblUpstreamPressure";
            this.lblUpstreamPressure.Size = new System.Drawing.Size(96, 13);
            this.lblUpstreamPressure.TabIndex = 146;
            this.lblUpstreamPressure.Text = "Upstream Pressure";
            // 
            // lblOrificeDiameter
            // 
            this.lblOrificeDiameter.AutoSize = true;
            this.lblOrificeDiameter.Location = new System.Drawing.Point(10, 115);
            this.lblOrificeDiameter.Name = "lblOrificeDiameter";
            this.lblOrificeDiameter.Size = new System.Drawing.Size(122, 13);
            this.lblOrificeDiameter.TabIndex = 145;
            this.lblOrificeDiameter.Text = "Orifice Diameter (mm) d: ";
            // 
            // lblpipediameter
            // 
            this.lblpipediameter.AutoSize = true;
            this.lblpipediameter.Location = new System.Drawing.Point(10, 86);
            this.lblpipediameter.Name = "lblpipediameter";
            this.lblpipediameter.Size = new System.Drawing.Size(112, 13);
            this.lblpipediameter.TabIndex = 144;
            this.lblpipediameter.Text = "Pipe Diameter (mm) D:";
            // 
            // txtwellno
            // 
            this.txtwellno.Location = new System.Drawing.Point(204, 53);
            this.txtwellno.Name = "txtwellno";
            this.txtwellno.Size = new System.Drawing.Size(100, 20);
            this.txtwellno.TabIndex = 1;
            // 
            // lblwellno
            // 
            this.lblwellno.AutoSize = true;
            this.lblwellno.Location = new System.Drawing.Point(10, 60);
            this.lblwellno.Name = "lblwellno";
            this.lblwellno.Size = new System.Drawing.Size(48, 13);
            this.lblwellno.TabIndex = 143;
            this.lblwellno.Text = "Well No:";
            // 
            // dtTime
            // 
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTime.Location = new System.Drawing.Point(227, 21);
            this.dtTime.Name = "dtTime";
            this.dtTime.ShowUpDown = true;
            this.dtTime.Size = new System.Drawing.Size(77, 20);
            this.dtTime.TabIndex = 142;
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(46, 20);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(106, 20);
            this.dtDate.TabIndex = 141;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(191, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 140;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 139;
            this.lblDate.Text = "Date";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(783, 756);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblCalculatedResults);
            this.Controls.Add(this.lblCombinedEnthalpy);
            this.Controls.Add(this.lblWaterCorrectionFactor);
            this.Controls.Add(this.lblDrynessFraction);
            this.Controls.Add(this.txtCombinedEnthalpy);
            this.Controls.Add(this.txtWaterCorrectionFactor);
            this.Controls.Add(this.txtDrynessFraction);
            this.Controls.Add(this.lblMassFlow);
            this.Controls.Add(this.lblSteamEnthalpy);
            this.Controls.Add(this.txtMassFlow);
            this.Controls.Add(this.lblCorrectedWaterFlowrate);
            this.Controls.Add(this.txtSteamEnthalpy);
            this.Controls.Add(this.lblWaterEnthalpy);
            this.Controls.Add(this.txtCorrectedWaterFlow);
            this.Controls.Add(this.lblWaterFlowRate);
            this.Controls.Add(this.txtWaterEnthalpy);
            this.Controls.Add(this.lblSteamFLowRate);
            this.Controls.Add(this.txtWaterFlowRate);
            this.Controls.Add(this.txtSteamFlowRate);
            this.Controls.Add(this.lblDifferentialPressure);
            this.Controls.Add(this.lblExpansibility);
            this.Controls.Add(this.txtDifferentialPressure);
            this.Controls.Add(this.txtExpansibilityFactor);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.txtWaterHeight);
            this.Controls.Add(this.txtManometerr);
            this.Controls.Add(this.txtManometerHt);
            this.Controls.Add(this.lblWaterHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblManometerHt);
            this.Controls.Add(this.txtUpstreamPressure);
            this.Controls.Add(this.txtOrificeDiameter);
            this.Controls.Add(this.txtPipeDiameter);
            this.Controls.Add(this.lblUpstreamPressure);
            this.Controls.Add(this.lblOrificeDiameter);
            this.Controls.Add(this.lblpipediameter);
            this.Controls.Add(this.txtwellno);
            this.Controls.Add(this.lblwellno);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEAM FLOW CALCULATIONS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblCalculatedResults;
        private System.Windows.Forms.Label lblCombinedEnthalpy;
        private System.Windows.Forms.Label lblWaterCorrectionFactor;
        private System.Windows.Forms.Label lblDrynessFraction;
        private System.Windows.Forms.TextBox txtCombinedEnthalpy;
        private System.Windows.Forms.TextBox txtWaterCorrectionFactor;
        private System.Windows.Forms.TextBox txtDrynessFraction;
        private System.Windows.Forms.Label lblMassFlow;
        private System.Windows.Forms.Label lblSteamEnthalpy;
        private System.Windows.Forms.TextBox txtMassFlow;
        private System.Windows.Forms.Label lblCorrectedWaterFlowrate;
        private System.Windows.Forms.TextBox txtSteamEnthalpy;
        private System.Windows.Forms.Label lblWaterEnthalpy;
        private System.Windows.Forms.TextBox txtCorrectedWaterFlow;
        private System.Windows.Forms.Label lblWaterFlowRate;
        private System.Windows.Forms.TextBox txtWaterEnthalpy;
        private System.Windows.Forms.Label lblSteamFLowRate;
        private System.Windows.Forms.TextBox txtWaterFlowRate;
        private System.Windows.Forms.TextBox txtSteamFlowRate;
        private System.Windows.Forms.Label lblDifferentialPressure;
        private System.Windows.Forms.Label lblExpansibility;
        private System.Windows.Forms.TextBox txtDifferentialPressure;
        private System.Windows.Forms.TextBox txtExpansibilityFactor;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.TextBox txtWaterHeight;
        private System.Windows.Forms.TextBox txtManometerr;
        private System.Windows.Forms.TextBox txtManometerHt;
        private System.Windows.Forms.Label lblWaterHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblManometerHt;
        private System.Windows.Forms.TextBox txtUpstreamPressure;
        private System.Windows.Forms.TextBox txtOrificeDiameter;
        private System.Windows.Forms.TextBox txtPipeDiameter;
        private System.Windows.Forms.Label lblUpstreamPressure;
        private System.Windows.Forms.Label lblOrificeDiameter;
        private System.Windows.Forms.Label lblpipediameter;
        private System.Windows.Forms.TextBox txtwellno;
        private System.Windows.Forms.Label lblwellno;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
    }
}

