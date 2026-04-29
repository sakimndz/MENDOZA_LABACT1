namespace MENDOZA_LABACT1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpVehicleRegistration = new GroupBox();
            txtAssignedSlot = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtHoursParked = new TextBox();
            cmbVehicleType = new ComboBox();
            label1 = new Label();
            txtPlateNumber = new TextBox();
            label = new Label();
            grpActions = new GroupBox();
            btnUpdateStatus = new Button();
            btnRegisterVehicle = new Button();
            grpParkingStatus = new GroupBox();
            btnG5 = new Button();
            btnG4 = new Button();
            btnG3 = new Button();
            btnG2 = new Button();
            btnG1 = new Button();
            btnF5 = new Button();
            btnF4 = new Button();
            btnF3 = new Button();
            btnF2 = new Button();
            btnF1 = new Button();
            btnE5 = new Button();
            btnE4 = new Button();
            btnE3 = new Button();
            btnE2 = new Button();
            btnE1 = new Button();
            btnD5 = new Button();
            btnD4 = new Button();
            btnD3 = new Button();
            btnD2 = new Button();
            btnD1 = new Button();
            btnC5 = new Button();
            btnC4 = new Button();
            btnC3 = new Button();
            btnC2 = new Button();
            btnC1 = new Button();
            btnB5 = new Button();
            btnB4 = new Button();
            btnB3 = new Button();
            btnB2 = new Button();
            btnB1 = new Button();
            btnA5 = new Button();
            btnA4 = new Button();
            btnA3 = new Button();
            btnA2 = new Button();
            btnA1 = new Button();
            gprCurrentTransaction = new GroupBox();
            lblOvertimeFee = new Label();
            lblSlot = new Label();
            lblDuration = new Label();
            lblVehicleInfo = new Label();
            lblPlateNumber = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            grpFeeCalculation = new GroupBox();
            lblTotal = new Label();
            label14 = new Label();
            lblServiceCharge = new Label();
            label12 = new Label();
            lblStandardFee = new Label();
            label10 = new Label();
            grpPaymentsandReceipts = new GroupBox();
            btnClearForm = new Button();
            btnGenerateReceipt = new Button();
            btnProcessPayment = new Button();
            listBox1 = new ListBox();
            lblChange = new Label();
            label15 = new Label();
            label11 = new Label();
            txtPayAmount = new TextBox();
            cmbDiscount = new ComboBox();
            label9 = new Label();
            grpVehicleRegistration.SuspendLayout();
            grpActions.SuspendLayout();
            grpParkingStatus.SuspendLayout();
            gprCurrentTransaction.SuspendLayout();
            grpFeeCalculation.SuspendLayout();
            grpPaymentsandReceipts.SuspendLayout();
            SuspendLayout();
            // 
            // grpVehicleRegistration
            // 
            grpVehicleRegistration.Controls.Add(txtAssignedSlot);
            grpVehicleRegistration.Controls.Add(label3);
            grpVehicleRegistration.Controls.Add(label2);
            grpVehicleRegistration.Controls.Add(txtHoursParked);
            grpVehicleRegistration.Controls.Add(cmbVehicleType);
            grpVehicleRegistration.Controls.Add(label1);
            grpVehicleRegistration.Controls.Add(txtPlateNumber);
            grpVehicleRegistration.Controls.Add(label);
            grpVehicleRegistration.Location = new Point(12, 12);
            grpVehicleRegistration.Name = "grpVehicleRegistration";
            grpVehicleRegistration.Size = new Size(225, 157);
            grpVehicleRegistration.TabIndex = 0;
            grpVehicleRegistration.TabStop = false;
            grpVehicleRegistration.Text = "Vehicle Registration";
            // 
            // txtAssignedSlot
            // 
            txtAssignedSlot.Location = new Point(95, 123);
            txtAssignedSlot.Name = "txtAssignedSlot";
            txtAssignedSlot.Size = new Size(124, 23);
            txtAssignedSlot.TabIndex = 7;
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Location = new Point(6, 126);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Assigned Slot:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 5;
            label2.Text = "Hours Parked:";
            // 
            // txtHoursParked
            // 
            txtHoursParked.Location = new Point(95, 94);
            txtHoursParked.Name = "txtHoursParked";
            txtHoursParked.Size = new Size(124, 23);
            txtHoursParked.TabIndex = 4;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Items.AddRange(new object[] { "Car", "Motorcycle", "Van" });
            cmbVehicleType.Location = new Point(95, 65);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(124, 23);
            cmbVehicleType.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 68);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Vehicle Type:";
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(95, 36);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(124, 23);
            txtPlateNumber.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(6, 39);
            label.Name = "label";
            label.Size = new Size(83, 15);
            label.TabIndex = 0;
            label.Text = "Plate Number:";
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnUpdateStatus);
            grpActions.Controls.Add(btnRegisterVehicle);
            grpActions.Location = new Point(12, 175);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(225, 102);
            grpActions.TabIndex = 1;
            grpActions.TabStop = false;
            grpActions.Text = "Actions";
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(38, 59);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(152, 31);
            btnUpdateStatus.TabIndex = 1;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnRegisterVehicle
            // 
            btnRegisterVehicle.Location = new Point(38, 22);
            btnRegisterVehicle.Name = "btnRegisterVehicle";
            btnRegisterVehicle.Size = new Size(152, 31);
            btnRegisterVehicle.TabIndex = 0;
            btnRegisterVehicle.Text = "Register Vehicle";
            btnRegisterVehicle.UseVisualStyleBackColor = true;
            btnRegisterVehicle.Click += btnRegisterVehicle_Click;
            // 
            // grpParkingStatus
            // 
            grpParkingStatus.Controls.Add(btnG5);
            grpParkingStatus.Controls.Add(btnG4);
            grpParkingStatus.Controls.Add(btnG3);
            grpParkingStatus.Controls.Add(btnG2);
            grpParkingStatus.Controls.Add(btnG1);
            grpParkingStatus.Controls.Add(btnF5);
            grpParkingStatus.Controls.Add(btnF4);
            grpParkingStatus.Controls.Add(btnF3);
            grpParkingStatus.Controls.Add(btnF2);
            grpParkingStatus.Controls.Add(btnF1);
            grpParkingStatus.Controls.Add(btnE5);
            grpParkingStatus.Controls.Add(btnE4);
            grpParkingStatus.Controls.Add(btnE3);
            grpParkingStatus.Controls.Add(btnE2);
            grpParkingStatus.Controls.Add(btnE1);
            grpParkingStatus.Controls.Add(btnD5);
            grpParkingStatus.Controls.Add(btnD4);
            grpParkingStatus.Controls.Add(btnD3);
            grpParkingStatus.Controls.Add(btnD2);
            grpParkingStatus.Controls.Add(btnD1);
            grpParkingStatus.Controls.Add(btnC5);
            grpParkingStatus.Controls.Add(btnC4);
            grpParkingStatus.Controls.Add(btnC3);
            grpParkingStatus.Controls.Add(btnC2);
            grpParkingStatus.Controls.Add(btnC1);
            grpParkingStatus.Controls.Add(btnB5);
            grpParkingStatus.Controls.Add(btnB4);
            grpParkingStatus.Controls.Add(btnB3);
            grpParkingStatus.Controls.Add(btnB2);
            grpParkingStatus.Controls.Add(btnB1);
            grpParkingStatus.Controls.Add(btnA5);
            grpParkingStatus.Controls.Add(btnA4);
            grpParkingStatus.Controls.Add(btnA3);
            grpParkingStatus.Controls.Add(btnA2);
            grpParkingStatus.Controls.Add(btnA1);
            grpParkingStatus.Location = new Point(243, 12);
            grpParkingStatus.Name = "grpParkingStatus";
            grpParkingStatus.Size = new Size(477, 535);
            grpParkingStatus.TabIndex = 2;
            grpParkingStatus.TabStop = false;
            grpParkingStatus.Text = "Parking Status";
            // 
            // btnG5
            // 
            btnG5.BackColor = Color.LawnGreen;
            btnG5.Location = new Point(380, 453);
            btnG5.Name = "btnG5";
            btnG5.Size = new Size(68, 52);
            btnG5.TabIndex = 34;
            btnG5.Text = "G5";
            btnG5.UseVisualStyleBackColor = false;
            // 
            // btnG4
            // 
            btnG4.BackColor = Color.LawnGreen;
            btnG4.Location = new Point(291, 453);
            btnG4.Name = "btnG4";
            btnG4.Size = new Size(68, 52);
            btnG4.TabIndex = 33;
            btnG4.Text = "G4";
            btnG4.UseVisualStyleBackColor = false;
            // 
            // btnG3
            // 
            btnG3.BackColor = Color.LawnGreen;
            btnG3.Location = new Point(202, 453);
            btnG3.Name = "btnG3";
            btnG3.Size = new Size(68, 52);
            btnG3.TabIndex = 32;
            btnG3.Text = "G3";
            btnG3.UseVisualStyleBackColor = false;
            // 
            // btnG2
            // 
            btnG2.BackColor = Color.LawnGreen;
            btnG2.Location = new Point(115, 453);
            btnG2.Name = "btnG2";
            btnG2.Size = new Size(68, 52);
            btnG2.TabIndex = 31;
            btnG2.Text = "G2";
            btnG2.UseVisualStyleBackColor = false;
            // 
            // btnG1
            // 
            btnG1.BackColor = Color.LawnGreen;
            btnG1.Location = new Point(26, 453);
            btnG1.Name = "btnG1";
            btnG1.Size = new Size(68, 52);
            btnG1.TabIndex = 30;
            btnG1.Text = "G1";
            btnG1.UseVisualStyleBackColor = false;
            // 
            // btnF5
            // 
            btnF5.BackColor = Color.LawnGreen;
            btnF5.Location = new Point(380, 382);
            btnF5.Name = "btnF5";
            btnF5.Size = new Size(68, 52);
            btnF5.TabIndex = 29;
            btnF5.Text = "F5";
            btnF5.UseVisualStyleBackColor = false;
            // 
            // btnF4
            // 
            btnF4.BackColor = Color.LawnGreen;
            btnF4.Location = new Point(291, 382);
            btnF4.Name = "btnF4";
            btnF4.Size = new Size(68, 52);
            btnF4.TabIndex = 28;
            btnF4.Text = "F4";
            btnF4.UseVisualStyleBackColor = false;
            // 
            // btnF3
            // 
            btnF3.BackColor = Color.LawnGreen;
            btnF3.Location = new Point(202, 382);
            btnF3.Name = "btnF3";
            btnF3.Size = new Size(68, 52);
            btnF3.TabIndex = 27;
            btnF3.Text = "F3";
            btnF3.UseVisualStyleBackColor = false;
            // 
            // btnF2
            // 
            btnF2.BackColor = Color.LawnGreen;
            btnF2.Location = new Point(115, 382);
            btnF2.Name = "btnF2";
            btnF2.Size = new Size(68, 52);
            btnF2.TabIndex = 26;
            btnF2.Text = "F2";
            btnF2.UseVisualStyleBackColor = false;
            // 
            // btnF1
            // 
            btnF1.BackColor = Color.LawnGreen;
            btnF1.Location = new Point(26, 382);
            btnF1.Name = "btnF1";
            btnF1.Size = new Size(68, 52);
            btnF1.TabIndex = 25;
            btnF1.Text = "F1";
            btnF1.UseVisualStyleBackColor = false;
            // 
            // btnE5
            // 
            btnE5.BackColor = Color.LawnGreen;
            btnE5.Location = new Point(380, 313);
            btnE5.Name = "btnE5";
            btnE5.Size = new Size(68, 52);
            btnE5.TabIndex = 24;
            btnE5.Text = "E5";
            btnE5.UseVisualStyleBackColor = false;
            // 
            // btnE4
            // 
            btnE4.BackColor = Color.LawnGreen;
            btnE4.Location = new Point(291, 313);
            btnE4.Name = "btnE4";
            btnE4.Size = new Size(68, 52);
            btnE4.TabIndex = 23;
            btnE4.Text = "E4";
            btnE4.UseVisualStyleBackColor = false;
            // 
            // btnE3
            // 
            btnE3.BackColor = Color.LawnGreen;
            btnE3.Location = new Point(202, 313);
            btnE3.Name = "btnE3";
            btnE3.Size = new Size(68, 52);
            btnE3.TabIndex = 22;
            btnE3.Text = "E3";
            btnE3.UseVisualStyleBackColor = false;
            // 
            // btnE2
            // 
            btnE2.BackColor = Color.LawnGreen;
            btnE2.Location = new Point(115, 313);
            btnE2.Name = "btnE2";
            btnE2.Size = new Size(68, 52);
            btnE2.TabIndex = 21;
            btnE2.Text = "E2";
            btnE2.UseVisualStyleBackColor = false;
            // 
            // btnE1
            // 
            btnE1.BackColor = Color.LawnGreen;
            btnE1.Location = new Point(26, 313);
            btnE1.Name = "btnE1";
            btnE1.Size = new Size(68, 52);
            btnE1.TabIndex = 20;
            btnE1.Text = "E1";
            btnE1.UseVisualStyleBackColor = false;
            // 
            // btnD5
            // 
            btnD5.BackColor = Color.LawnGreen;
            btnD5.Location = new Point(380, 243);
            btnD5.Name = "btnD5";
            btnD5.Size = new Size(68, 52);
            btnD5.TabIndex = 19;
            btnD5.Text = "D5";
            btnD5.UseVisualStyleBackColor = false;
            // 
            // btnD4
            // 
            btnD4.BackColor = Color.LawnGreen;
            btnD4.Location = new Point(291, 243);
            btnD4.Name = "btnD4";
            btnD4.Size = new Size(68, 52);
            btnD4.TabIndex = 18;
            btnD4.Text = "D4";
            btnD4.UseVisualStyleBackColor = false;
            // 
            // btnD3
            // 
            btnD3.BackColor = Color.LawnGreen;
            btnD3.Location = new Point(202, 243);
            btnD3.Name = "btnD3";
            btnD3.Size = new Size(68, 52);
            btnD3.TabIndex = 17;
            btnD3.Text = "D3";
            btnD3.UseVisualStyleBackColor = false;
            // 
            // btnD2
            // 
            btnD2.BackColor = Color.LawnGreen;
            btnD2.Location = new Point(115, 243);
            btnD2.Name = "btnD2";
            btnD2.Size = new Size(68, 52);
            btnD2.TabIndex = 16;
            btnD2.Text = "D2";
            btnD2.UseVisualStyleBackColor = false;
            // 
            // btnD1
            // 
            btnD1.BackColor = Color.LawnGreen;
            btnD1.Location = new Point(26, 243);
            btnD1.Name = "btnD1";
            btnD1.Size = new Size(68, 52);
            btnD1.TabIndex = 15;
            btnD1.Text = "D1";
            btnD1.UseVisualStyleBackColor = false;
            // 
            // btnC5
            // 
            btnC5.BackColor = Color.LawnGreen;
            btnC5.Location = new Point(380, 174);
            btnC5.Name = "btnC5";
            btnC5.Size = new Size(68, 52);
            btnC5.TabIndex = 14;
            btnC5.Text = "C5";
            btnC5.UseVisualStyleBackColor = false;
            // 
            // btnC4
            // 
            btnC4.BackColor = Color.LawnGreen;
            btnC4.Location = new Point(291, 174);
            btnC4.Name = "btnC4";
            btnC4.Size = new Size(68, 52);
            btnC4.TabIndex = 13;
            btnC4.Text = "C4";
            btnC4.UseVisualStyleBackColor = false;
            // 
            // btnC3
            // 
            btnC3.BackColor = Color.LawnGreen;
            btnC3.Location = new Point(202, 174);
            btnC3.Name = "btnC3";
            btnC3.Size = new Size(68, 52);
            btnC3.TabIndex = 12;
            btnC3.Text = "C3";
            btnC3.UseVisualStyleBackColor = false;
            // 
            // btnC2
            // 
            btnC2.BackColor = Color.LawnGreen;
            btnC2.Location = new Point(115, 174);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(68, 52);
            btnC2.TabIndex = 11;
            btnC2.Text = "C2";
            btnC2.UseVisualStyleBackColor = false;
            // 
            // btnC1
            // 
            btnC1.BackColor = Color.LawnGreen;
            btnC1.Location = new Point(26, 174);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(68, 52);
            btnC1.TabIndex = 10;
            btnC1.Text = "C1";
            btnC1.UseVisualStyleBackColor = false;
            // 
            // btnB5
            // 
            btnB5.BackColor = Color.LawnGreen;
            btnB5.Location = new Point(380, 105);
            btnB5.Name = "btnB5";
            btnB5.Size = new Size(68, 52);
            btnB5.TabIndex = 9;
            btnB5.Text = "B5";
            btnB5.UseVisualStyleBackColor = false;
            // 
            // btnB4
            // 
            btnB4.BackColor = Color.LawnGreen;
            btnB4.Location = new Point(291, 105);
            btnB4.Name = "btnB4";
            btnB4.Size = new Size(68, 52);
            btnB4.TabIndex = 8;
            btnB4.Text = "B4";
            btnB4.UseVisualStyleBackColor = false;
            // 
            // btnB3
            // 
            btnB3.BackColor = Color.LawnGreen;
            btnB3.Location = new Point(202, 105);
            btnB3.Name = "btnB3";
            btnB3.Size = new Size(68, 52);
            btnB3.TabIndex = 7;
            btnB3.Text = "B3";
            btnB3.UseVisualStyleBackColor = false;
            // 
            // btnB2
            // 
            btnB2.BackColor = Color.LawnGreen;
            btnB2.Location = new Point(115, 105);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(68, 52);
            btnB2.TabIndex = 6;
            btnB2.Text = "B2";
            btnB2.UseVisualStyleBackColor = false;
            // 
            // btnB1
            // 
            btnB1.BackColor = Color.LawnGreen;
            btnB1.Location = new Point(26, 105);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(68, 52);
            btnB1.TabIndex = 5;
            btnB1.Text = "B1";
            btnB1.UseVisualStyleBackColor = false;
            // 
            // btnA5
            // 
            btnA5.BackColor = Color.LawnGreen;
            btnA5.Location = new Point(380, 36);
            btnA5.Name = "btnA5";
            btnA5.Size = new Size(68, 52);
            btnA5.TabIndex = 4;
            btnA5.Text = "A5";
            btnA5.UseVisualStyleBackColor = false;
            // 
            // btnA4
            // 
            btnA4.BackColor = Color.LawnGreen;
            btnA4.Location = new Point(291, 36);
            btnA4.Name = "btnA4";
            btnA4.Size = new Size(68, 52);
            btnA4.TabIndex = 3;
            btnA4.Text = "A4";
            btnA4.UseVisualStyleBackColor = false;
            // 
            // btnA3
            // 
            btnA3.BackColor = Color.LawnGreen;
            btnA3.Location = new Point(202, 36);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(68, 52);
            btnA3.TabIndex = 2;
            btnA3.Text = "A3";
            btnA3.UseVisualStyleBackColor = false;
            // 
            // btnA2
            // 
            btnA2.BackColor = Color.LawnGreen;
            btnA2.Location = new Point(115, 36);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(68, 52);
            btnA2.TabIndex = 1;
            btnA2.Text = "A2";
            btnA2.UseVisualStyleBackColor = false;
            // 
            // btnA1
            // 
            btnA1.BackColor = Color.LawnGreen;
            btnA1.Location = new Point(26, 36);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(68, 52);
            btnA1.TabIndex = 0;
            btnA1.Text = "A1";
            btnA1.UseVisualStyleBackColor = false;
            // 
            // gprCurrentTransaction
            // 
            gprCurrentTransaction.Controls.Add(lblOvertimeFee);
            gprCurrentTransaction.Controls.Add(lblSlot);
            gprCurrentTransaction.Controls.Add(lblDuration);
            gprCurrentTransaction.Controls.Add(lblVehicleInfo);
            gprCurrentTransaction.Controls.Add(lblPlateNumber);
            gprCurrentTransaction.Controls.Add(label8);
            gprCurrentTransaction.Controls.Add(label7);
            gprCurrentTransaction.Controls.Add(label6);
            gprCurrentTransaction.Controls.Add(label5);
            gprCurrentTransaction.Controls.Add(label4);
            gprCurrentTransaction.Location = new Point(726, 12);
            gprCurrentTransaction.Name = "gprCurrentTransaction";
            gprCurrentTransaction.Size = new Size(182, 182);
            gprCurrentTransaction.TabIndex = 3;
            gprCurrentTransaction.TabStop = false;
            gprCurrentTransaction.Text = "Current Transaction";
            // 
            // lblOvertimeFee
            // 
            lblOvertimeFee.AutoSize = true;
            lblOvertimeFee.Location = new Point(95, 154);
            lblOvertimeFee.Name = "lblOvertimeFee";
            lblOvertimeFee.Size = new Size(52, 15);
            lblOvertimeFee.TabIndex = 9;
            lblOvertimeFee.Text = "---------";
            // 
            // lblSlot
            // 
            lblSlot.AutoSize = true;
            lblSlot.Location = new Point(95, 126);
            lblSlot.Name = "lblSlot";
            lblSlot.Size = new Size(52, 15);
            lblSlot.TabIndex = 8;
            lblSlot.Text = "---------";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(95, 97);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(52, 15);
            lblDuration.TabIndex = 7;
            lblDuration.Text = "---------";
            // 
            // lblVehicleInfo
            // 
            lblVehicleInfo.AutoSize = true;
            lblVehicleInfo.Location = new Point(95, 68);
            lblVehicleInfo.Name = "lblVehicleInfo";
            lblVehicleInfo.Size = new Size(52, 15);
            lblVehicleInfo.TabIndex = 6;
            lblVehicleInfo.Text = "---------";
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Location = new Point(95, 39);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(52, 15);
            lblPlateNumber.TabIndex = 5;
            lblPlateNumber.Text = "---------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 154);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 4;
            label8.Text = "Overtime Fee:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 126);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 3;
            label7.Text = "Slot:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 97);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 2;
            label6.Text = "Duration:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 68);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 1;
            label5.Text = "Vehicle Info:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 39);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 0;
            label4.Text = "Plate Number:";
            // 
            // grpFeeCalculation
            // 
            grpFeeCalculation.Controls.Add(lblTotal);
            grpFeeCalculation.Controls.Add(label14);
            grpFeeCalculation.Controls.Add(lblServiceCharge);
            grpFeeCalculation.Controls.Add(label12);
            grpFeeCalculation.Controls.Add(lblStandardFee);
            grpFeeCalculation.Controls.Add(label10);
            grpFeeCalculation.Location = new Point(726, 200);
            grpFeeCalculation.Name = "grpFeeCalculation";
            grpFeeCalculation.Size = new Size(182, 118);
            grpFeeCalculation.TabIndex = 4;
            grpFeeCalculation.TabStop = false;
            grpFeeCalculation.Text = "Fee Calculation";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(95, 92);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(52, 15);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "---------";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 92);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 14;
            label14.Text = "Total:";
            // 
            // lblServiceCharge
            // 
            lblServiceCharge.AutoSize = true;
            lblServiceCharge.Location = new Point(95, 55);
            lblServiceCharge.Name = "lblServiceCharge";
            lblServiceCharge.Size = new Size(52, 15);
            lblServiceCharge.TabIndex = 13;
            lblServiceCharge.Text = "---------";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 55);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 12;
            label12.Text = "Service Charge:";
            // 
            // lblStandardFee
            // 
            lblStandardFee.AutoSize = true;
            lblStandardFee.Location = new Point(95, 34);
            lblStandardFee.Name = "lblStandardFee";
            lblStandardFee.Size = new Size(52, 15);
            lblStandardFee.TabIndex = 11;
            lblStandardFee.Text = "---------";
            // 
            // label10
            // 
            label10.AllowDrop = true;
            label10.AutoSize = true;
            label10.Location = new Point(6, 34);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 10;
            label10.Text = "Standard Fee:";
            // 
            // grpPaymentsandReceipts
            // 
            grpPaymentsandReceipts.Controls.Add(btnClearForm);
            grpPaymentsandReceipts.Controls.Add(btnGenerateReceipt);
            grpPaymentsandReceipts.Controls.Add(btnProcessPayment);
            grpPaymentsandReceipts.Controls.Add(listBox1);
            grpPaymentsandReceipts.Controls.Add(lblChange);
            grpPaymentsandReceipts.Controls.Add(label15);
            grpPaymentsandReceipts.Controls.Add(label11);
            grpPaymentsandReceipts.Controls.Add(txtPayAmount);
            grpPaymentsandReceipts.Controls.Add(cmbDiscount);
            grpPaymentsandReceipts.Controls.Add(label9);
            grpPaymentsandReceipts.Location = new Point(914, 12);
            grpPaymentsandReceipts.Name = "grpPaymentsandReceipts";
            grpPaymentsandReceipts.Size = new Size(231, 477);
            grpPaymentsandReceipts.TabIndex = 5;
            grpPaymentsandReceipts.TabStop = false;
            grpPaymentsandReceipts.Text = "Payments and Receipts";
            // 
            // btnClearForm
            // 
            btnClearForm.Location = new Point(42, 440);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(152, 31);
            btnClearForm.TabIndex = 20;
            btnClearForm.Text = "Clear Form";
            btnClearForm.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReceipt
            // 
            btnGenerateReceipt.Location = new Point(42, 403);
            btnGenerateReceipt.Name = "btnGenerateReceipt";
            btnGenerateReceipt.Size = new Size(152, 31);
            btnGenerateReceipt.TabIndex = 19;
            btnGenerateReceipt.Text = "Generate Receipt";
            btnGenerateReceipt.UseVisualStyleBackColor = true;
            // 
            // btnProcessPayment
            // 
            btnProcessPayment.Location = new Point(42, 367);
            btnProcessPayment.Name = "btnProcessPayment";
            btnProcessPayment.Size = new Size(152, 31);
            btnProcessPayment.TabIndex = 2;
            btnProcessPayment.Text = "Process Payment";
            btnProcessPayment.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 132);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 229);
            listBox1.TabIndex = 18;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(104, 102);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(52, 15);
            lblChange.TabIndex = 17;
            lblChange.Text = "---------";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 102);
            label15.Name = "label15";
            label15.Size = new Size(51, 15);
            label15.TabIndex = 16;
            label15.Text = "Change:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 68);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 3;
            label11.Text = "Pay Amount:";
            // 
            // txtPayAmount
            // 
            txtPayAmount.Location = new Point(104, 65);
            txtPayAmount.Name = "txtPayAmount";
            txtPayAmount.Size = new Size(121, 23);
            txtPayAmount.TabIndex = 2;
            // 
            // cmbDiscount
            // 
            cmbDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiscount.FormattingEnabled = true;
            cmbDiscount.Items.AddRange(new object[] { "Employee", "Senior Citizen" });
            cmbDiscount.Location = new Point(104, 36);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(121, 23);
            cmbDiscount.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 39);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 0;
            label9.Text = "Discount:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 572);
            Controls.Add(grpPaymentsandReceipts);
            Controls.Add(grpFeeCalculation);
            Controls.Add(gprCurrentTransaction);
            Controls.Add(grpParkingStatus);
            Controls.Add(grpActions);
            Controls.Add(grpVehicleRegistration);
            Name = "MainForm";
            Text = "Form1";
            grpVehicleRegistration.ResumeLayout(false);
            grpVehicleRegistration.PerformLayout();
            grpActions.ResumeLayout(false);
            grpParkingStatus.ResumeLayout(false);
            gprCurrentTransaction.ResumeLayout(false);
            gprCurrentTransaction.PerformLayout();
            grpFeeCalculation.ResumeLayout(false);
            grpFeeCalculation.PerformLayout();
            grpPaymentsandReceipts.ResumeLayout(false);
            grpPaymentsandReceipts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpVehicleRegistration;
        private TextBox txtAssignedSlot;
        private Label label3;
        private Label label2;
        private TextBox txtHoursParked;
        private ComboBox cmbVehicleType;
        private Label label1;
        private TextBox txtPlateNumber;
        private Label label;
        private GroupBox grpActions;
        private Button btnUpdateStatus;
        private Button btnRegisterVehicle;
        private GroupBox grpParkingStatus;
        private Button btnA5;
        private Button btnA4;
        private Button btnA3;
        private Button btnA2;
        private Button btnA1;
        private Button btnG5;
        private Button btnG4;
        private Button btnG3;
        private Button btnG2;
        private Button btnG1;
        private Button btnF5;
        private Button btnF4;
        private Button btnF3;
        private Button btnF2;
        private Button btnF1;
        private Button btnE5;
        private Button btnE4;
        private Button btnE3;
        private Button btnE2;
        private Button btnE1;
        private Button btnD5;
        private Button btnD4;
        private Button btnD3;
        private Button btnD2;
        private Button btnD1;
        private Button btnC5;
        private Button btnC4;
        private Button btnC3;
        private Button btnC2;
        private Button btnC1;
        private Button btnB5;
        private Button btnB4;
        private Button btnB3;
        private Button btnB2;
        private Button btnB1;
        private GroupBox gprCurrentTransaction;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblOvertimeFee;
        private Label lblSlot;
        private Label lblDuration;
        private Label lblVehicleInfo;
        private Label lblPlateNumber;
        private GroupBox grpFeeCalculation;
        private Label lblTotal;
        private Label label14;
        private Label lblServiceCharge;
        private Label label12;
        private Label lblStandardFee;
        private Label label10;
        private GroupBox grpPaymentsandReceipts;
        private TextBox txtPayAmount;
        private ComboBox cmbDiscount;
        private Label label9;
        private Label label11;
        private Button btnClearForm;
        private Button btnGenerateReceipt;
        private Button btnProcessPayment;
        private ListBox listBox1;
        private Label lblChange;
        private Label label15;
    }
}
