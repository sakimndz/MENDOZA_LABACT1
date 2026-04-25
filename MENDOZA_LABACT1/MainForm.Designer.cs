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
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            label1.Size = new Size(75, 15);
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
            grpParkingStatus.Controls.Add(button26);
            grpParkingStatus.Controls.Add(button27);
            grpParkingStatus.Controls.Add(button28);
            grpParkingStatus.Controls.Add(button29);
            grpParkingStatus.Controls.Add(button30);
            grpParkingStatus.Controls.Add(button16);
            grpParkingStatus.Controls.Add(button17);
            grpParkingStatus.Controls.Add(button18);
            grpParkingStatus.Controls.Add(button19);
            grpParkingStatus.Controls.Add(button20);
            grpParkingStatus.Controls.Add(button21);
            grpParkingStatus.Controls.Add(button22);
            grpParkingStatus.Controls.Add(button23);
            grpParkingStatus.Controls.Add(button24);
            grpParkingStatus.Controls.Add(button25);
            grpParkingStatus.Controls.Add(button6);
            grpParkingStatus.Controls.Add(button7);
            grpParkingStatus.Controls.Add(button8);
            grpParkingStatus.Controls.Add(button9);
            grpParkingStatus.Controls.Add(button10);
            grpParkingStatus.Controls.Add(button11);
            grpParkingStatus.Controls.Add(button12);
            grpParkingStatus.Controls.Add(button13);
            grpParkingStatus.Controls.Add(button14);
            grpParkingStatus.Controls.Add(button15);
            grpParkingStatus.Controls.Add(button1);
            grpParkingStatus.Controls.Add(button2);
            grpParkingStatus.Controls.Add(button3);
            grpParkingStatus.Controls.Add(button4);
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
            // button26
            // 
            button26.BackColor = Color.LawnGreen;
            button26.Location = new Point(380, 453);
            button26.Name = "button26";
            button26.Size = new Size(68, 52);
            button26.TabIndex = 34;
            button26.Text = "G5";
            button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            button27.BackColor = Color.LawnGreen;
            button27.Location = new Point(291, 453);
            button27.Name = "button27";
            button27.Size = new Size(68, 52);
            button27.TabIndex = 33;
            button27.Text = "G4";
            button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            button28.BackColor = Color.LawnGreen;
            button28.Location = new Point(202, 453);
            button28.Name = "button28";
            button28.Size = new Size(68, 52);
            button28.TabIndex = 32;
            button28.Text = "G3";
            button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            button29.BackColor = Color.LawnGreen;
            button29.Location = new Point(115, 453);
            button29.Name = "button29";
            button29.Size = new Size(68, 52);
            button29.TabIndex = 31;
            button29.Text = "G2";
            button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            button30.BackColor = Color.LawnGreen;
            button30.Location = new Point(26, 453);
            button30.Name = "button30";
            button30.Size = new Size(68, 52);
            button30.TabIndex = 30;
            button30.Text = "G1";
            button30.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.LawnGreen;
            button16.Location = new Point(380, 382);
            button16.Name = "button16";
            button16.Size = new Size(68, 52);
            button16.TabIndex = 29;
            button16.Text = "F5";
            button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = Color.LawnGreen;
            button17.Location = new Point(291, 382);
            button17.Name = "button17";
            button17.Size = new Size(68, 52);
            button17.TabIndex = 28;
            button17.Text = "F4";
            button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = Color.LawnGreen;
            button18.Location = new Point(202, 382);
            button18.Name = "button18";
            button18.Size = new Size(68, 52);
            button18.TabIndex = 27;
            button18.Text = "F3";
            button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = Color.LawnGreen;
            button19.Location = new Point(115, 382);
            button19.Name = "button19";
            button19.Size = new Size(68, 52);
            button19.TabIndex = 26;
            button19.Text = "F2";
            button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = Color.LawnGreen;
            button20.Location = new Point(26, 382);
            button20.Name = "button20";
            button20.Size = new Size(68, 52);
            button20.TabIndex = 25;
            button20.Text = "F1";
            button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = Color.LawnGreen;
            button21.Location = new Point(380, 313);
            button21.Name = "button21";
            button21.Size = new Size(68, 52);
            button21.TabIndex = 24;
            button21.Text = "E5";
            button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            button22.BackColor = Color.LawnGreen;
            button22.Location = new Point(291, 313);
            button22.Name = "button22";
            button22.Size = new Size(68, 52);
            button22.TabIndex = 23;
            button22.Text = "E4";
            button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            button23.BackColor = Color.LawnGreen;
            button23.Location = new Point(202, 313);
            button23.Name = "button23";
            button23.Size = new Size(68, 52);
            button23.TabIndex = 22;
            button23.Text = "E3";
            button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            button24.BackColor = Color.LawnGreen;
            button24.Location = new Point(115, 313);
            button24.Name = "button24";
            button24.Size = new Size(68, 52);
            button24.TabIndex = 21;
            button24.Text = "E2";
            button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            button25.BackColor = Color.LawnGreen;
            button25.Location = new Point(26, 313);
            button25.Name = "button25";
            button25.Size = new Size(68, 52);
            button25.TabIndex = 20;
            button25.Text = "E1";
            button25.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LawnGreen;
            button6.Location = new Point(380, 243);
            button6.Name = "button6";
            button6.Size = new Size(68, 52);
            button6.TabIndex = 19;
            button6.Text = "D5";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LawnGreen;
            button7.Location = new Point(291, 243);
            button7.Name = "button7";
            button7.Size = new Size(68, 52);
            button7.TabIndex = 18;
            button7.Text = "D4";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LawnGreen;
            button8.Location = new Point(202, 243);
            button8.Name = "button8";
            button8.Size = new Size(68, 52);
            button8.TabIndex = 17;
            button8.Text = "D3";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.LawnGreen;
            button9.Location = new Point(115, 243);
            button9.Name = "button9";
            button9.Size = new Size(68, 52);
            button9.TabIndex = 16;
            button9.Text = "D2";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.LawnGreen;
            button10.Location = new Point(26, 243);
            button10.Name = "button10";
            button10.Size = new Size(68, 52);
            button10.TabIndex = 15;
            button10.Text = "D1";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.LawnGreen;
            button11.Location = new Point(380, 174);
            button11.Name = "button11";
            button11.Size = new Size(68, 52);
            button11.TabIndex = 14;
            button11.Text = "C5";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.LawnGreen;
            button12.Location = new Point(291, 174);
            button12.Name = "button12";
            button12.Size = new Size(68, 52);
            button12.TabIndex = 13;
            button12.Text = "C4";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.LawnGreen;
            button13.Location = new Point(202, 174);
            button13.Name = "button13";
            button13.Size = new Size(68, 52);
            button13.TabIndex = 12;
            button13.Text = "C3";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.LawnGreen;
            button14.Location = new Point(115, 174);
            button14.Name = "button14";
            button14.Size = new Size(68, 52);
            button14.TabIndex = 11;
            button14.Text = "C2";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.LawnGreen;
            button15.Location = new Point(26, 174);
            button15.Name = "button15";
            button15.Size = new Size(68, 52);
            button15.TabIndex = 10;
            button15.Text = "C1";
            button15.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.Location = new Point(380, 105);
            button1.Name = "button1";
            button1.Size = new Size(68, 52);
            button1.TabIndex = 9;
            button1.Text = "B5";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LawnGreen;
            button2.Location = new Point(291, 105);
            button2.Name = "button2";
            button2.Size = new Size(68, 52);
            button2.TabIndex = 8;
            button2.Text = "B4";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LawnGreen;
            button3.Location = new Point(202, 105);
            button3.Name = "button3";
            button3.Size = new Size(68, 52);
            button3.TabIndex = 7;
            button3.Text = "B3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LawnGreen;
            button4.Location = new Point(115, 105);
            button4.Name = "button4";
            button4.Size = new Size(68, 52);
            button4.TabIndex = 6;
            button4.Text = "B2";
            button4.UseVisualStyleBackColor = false;
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
            label14.Size = new Size(36, 15);
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
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
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
