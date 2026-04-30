
namespace MENDOZA_LABACT1
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Button> slotButtons = new Dictionary<string, Button>();
        public List<Reservation> reservations = new List<Reservation>();
        private Reservation currentReservation = null;
        private Button selectedSlotButton = null;

        public MainForm()
        {
            InitializeComponent();
            foreach (Control c in grpParkingStatus.Controls)
            {
                if (c is Button btn)
                {
                    btn.Click += ParkingSlot_Click;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    slotButtons[btn.Text] = btn;
                }
            }
        }

        private void ParkingSlot_Click(object sender, EventArgs e)
        {
            Button clickedSlot = (Button)sender;
            string slotName = clickedSlot.Text.Split('\n')[0];

            if (selectedSlotButton != null && selectedSlotButton != clickedSlot)
            {
                selectedSlotButton.FlatAppearance.BorderSize = 0;
            }
            selectedSlotButton = clickedSlot;
            clickedSlot.FlatAppearance.BorderSize = 2;
            clickedSlot.FlatAppearance.BorderColor = Color.Blue;

            Reservation foundRes = reservations.FirstOrDefault(r => r.AssignedSlot == slotName);
            if (foundRes != null)
            {
                currentReservation = foundRes;
                LoadReservationData(foundRes);

                txtPlateNumber.Text = foundRes.PlateNumber;
                cmbVehicleType.SelectedItem = foundRes.VehicleType;
                txtHoursParked.Text = foundRes.HoursParked.ToString();
                txtAssignedSlot.Text = foundRes.AssignedSlot;
                return;
            }

            else
            {
                currentReservation = null;
                txtAssignedSlot.Text = slotName;
                ClearTransactionLabels();
            }

            foreach (Control c in grpParkingStatus.Controls)
            {
                if (c is Button btn && btn.BackColor != Color.Red)
                    btn.FlatAppearance.BorderSize = 0;
            }
            clickedSlot.FlatAppearance.BorderSize = 2;
            clickedSlot.FlatAppearance.BorderColor = Color.Blue;
        }

        private bool ValidateRegistrationInputs()
        {
            if (cmbVehicleType.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtPlateNumber.Text) || string.IsNullOrEmpty(txtAssignedSlot.Text))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(txtHoursParked.Text, out _))
            {
                MessageBox.Show("Please enter a numeric value for hours parked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!slotButtons.ContainsKey(txtAssignedSlot.Text))
            {
                MessageBox.Show("Please select a valid parking slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (slotButtons.ContainsKey(txtAssignedSlot.Text) && slotButtons[txtAssignedSlot.Text].BackColor == Color.Red)
            {
                MessageBox.Show("Parking slot is already occupied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnRegisterVehicle_Click(object sender, EventArgs e)
        {
            if (!ValidateRegistrationInputs()) return;

            try
            {
                string plate = txtPlateNumber.Text.Trim().ToUpper();
                string type = cmbVehicleType.SelectedItem.ToString();
                double hours = Convert.ToDouble(txtHoursParked.Text.Trim());
                string slot = txtAssignedSlot.Text.Trim();

                if (reservations.Any(r => r.PlateNumber == plate))
                {
                    MessageBox.Show($"A vehicle with plate number '{plate}' is already registered.",
                        "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (slotButtons.ContainsKey(slot) && slotButtons[slot].BackColor == Color.Red)
                {
                    MessageBox.Show("That parking slot is already occupied.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Reservation reservation = new Reservation(plate, type, hours, slot);
                reservations.Add(reservation);
                currentReservation = reservation;

                UpdateSlotVisual(reservation);

                double totalFee = reservation.CalculateFee();
                DisplayFees(reservation);

                ClearInputs();

                MessageBox.Show($"Vehicle '{plate}' successfully registered to slot {slot}.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (currentReservation == null)
            {
                MessageBox.Show("Please select an occupied parking slot to update.",
                    "No Reservation Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbVehicleType.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtHoursParked.Text))
            {
                MessageBox.Show("Please fill in Vehicle Type and Hours Parked to update.",
                    "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtHoursParked.Text, out double newHours) || newHours <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for hours parked.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                currentReservation.VehicleType = cmbVehicleType.SelectedItem.ToString();
                currentReservation.HoursParked = newHours;

                currentReservation.CalculateFee();

                LoadReservationData(currentReservation);
                DisplayFees(currentReservation);

                MessageBox.Show($"Reservation for '{currentReservation.PlateNumber}' updated successfully.",
                    "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            if (currentReservation == null)
            {
                MessageBox.Show("Please select an occupied parking slot first.",
                    "No Reservation Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentReservation.TotalFee == 0)
                currentReservation.CalculateFee();

            if (!double.TryParse(txtPayAmount.Text, out double amountPaid) || amountPaid < 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double discountRate = GetDiscountRate();
            double discountAmount = currentReservation.TotalFee * discountRate;
            double discountedTotal = currentReservation.TotalFee - discountAmount;

            if (amountPaid < discountedTotal)
            {
                MessageBox.Show($"Insufficient payment. Amount due: ₱{discountedTotal:N2}",
                    "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double change = amountPaid - discountedTotal;
            lblChange.Text = $"₱{change:N2}";

            // Update total label to reflect discounted price
            lblTotal.Text = $"₱{discountedTotal:N2}";

            MessageBox.Show(
                $"Payment processed!\n\n" +
                $"Amount Due:  ₱{discountedTotal:N2}\n" +
                $"Amount Paid: ₱{amountPaid:N2}\n" +
                $"Change:      ₱{change:N2}",
                "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            if (currentReservation == null)
            {
                MessageBox.Show("Please select an occupied parking slot first.",
                    "No Reservation Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentReservation.TotalFee == 0)
                currentReservation.CalculateFee();

            if (!double.TryParse(txtPayAmount.Text, out double amountPaid) || amountPaid < 0)
            {
                MessageBox.Show("Please enter the payment amount before generating a receipt.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double discountRate = GetDiscountRate();
            double discountAmount = currentReservation.TotalFee * discountRate;
            double discountedTotal = currentReservation.TotalFee - discountAmount;
            double change = amountPaid - discountedTotal;

            if (change < 0)
            {
                MessageBox.Show("Cannot generate receipt: payment amount is insufficient.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string discountLabel = cmbDiscount.SelectedIndex == -1
                ? "None"
                : cmbDiscount.SelectedItem.ToString();

            string separator = new string('─', 28);
            string[] receiptLines =
            {
                separator,
                $"  PARKING RECEIPT",
                $"  {DateTime.Now:MM/dd/yyyy  hh:mm tt}",
                separator,
                $"  Plate No.   : {currentReservation.PlateNumber}",
                $"  Vehicle     : {currentReservation.VehicleType}",
                $"  Slot        : {currentReservation.AssignedSlot}",
                $"  Duration    : {currentReservation.HoursParked} hr(s)",
                separator,
                $"  Standard Fee: ₱{currentReservation.StandardFee:N2}",
                $"  Overtime Fee: ₱{currentReservation.OvertimeFee:N2}",
                $"  Service Chg : ₱{currentReservation.ServiceCharge:N2}",
                $"  Discount    : {discountLabel} (-{discountRate * 100:0}%)",
                $"  Disc. Amt   : -₱{discountAmount:N2}",
                $"  TOTAL DUE   : ₱{discountedTotal:N2}",
                separator,
                $"  Amount Paid : ₱{amountPaid:N2}",
                $"  Change      : ₱{change:N2}",
                separator,
                "  Thank you!",
                separator,
                ""
            };

            foreach (string line in receiptLines)
                listBox1.Items.Add(line);

            listBox1.TopIndex = listBox1.Items.Count - 1;

            MessageBox.Show("Receipt generated and added to the receipt log.",
                "Receipt Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FreeSlot(currentReservation);
            reservations.Remove(currentReservation);
            currentReservation = null;
            ClearTransactionLabels();
            ClearInputs();
            lblChange.Text = "---------";
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            currentReservation = null;
            ClearInputs();
            ClearTransactionLabels();
            lblChange.Text = "---------";
            txtPayAmount.Clear();

            if (selectedSlotButton != null)
            {
                selectedSlotButton.FlatAppearance.BorderSize = 0;
                selectedSlotButton = null;
            }
        }

        // HELPERS -----------------------------------------------------------------------------
        private double GetDiscountRate()
        {
            if (cmbDiscount.SelectedIndex == -1) return 0;
            string selected = cmbDiscount.SelectedItem.ToString();
            if (selected == "Employee") return 0.10;
            if (selected == "Senior Citizen") return 0.20;
            return 0;
        }

        private void DisplayFees(Reservation res)
        {
            lblStandardFee.Text = $"₱{res.StandardFee:N2}";
            lblServiceCharge.Text = $"₱{res.ServiceCharge:N2}";
            lblOvertimeFee.Text = $"₱{res.OvertimeFee:N2}";
            lblTotal.Text = $"₱{res.TotalFee:N2}";
        }

        private void UpdateSlotVisual(Reservation res)
        {
            if (slotButtons.ContainsKey(res.AssignedSlot))
            {
                Button btn = slotButtons[res.AssignedSlot];
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
                btn.Text = $"{res.AssignedSlot}\n{res.PlateNumber}";
                slotButtons[res.AssignedSlot] = btn;
            }
        }

        private void ClearTransactionLabels()
        {
            lblPlateNumber.Text = "-";
            lblVehicleInfo.Text = "-";
            lblDuration.Text = "-";
            lblSlot.Text = "-";
            lblOvertimeFee.Text = "-";
            lblStandardFee.Text = "-";
            lblServiceCharge.Text = "-";
            lblTotal.Text = "-";
        }

        private void ClearInputs()
        {
            txtPlateNumber.Clear();
            txtHoursParked.Clear();
            txtAssignedSlot.Clear();
            cmbVehicleType.SelectedIndex = -1;
            cmbDiscount.SelectedIndex = -1;
        }

        private void LoadReservationData(Reservation res)
        {
            lblPlateNumber.Text = res.PlateNumber;
            lblVehicleInfo.Text = res.VehicleType;
            lblDuration.Text = $"{res.HoursParked} hr(s)";
            lblSlot.Text = res.AssignedSlot;
            lblOvertimeFee.Text = res.OvertimeFee > 0
                ? $"₱{res.OvertimeFee:N2}"
                : "None";

            if (res.TotalFee > 0)
                DisplayFees(res);
        }

        public void RegisterVehicle(List<Reservation> reservations, string plateNumber, string vehicleType, double hoursParked, string assignedSlot)
        {
            Reservation newReservation = new Reservation(plateNumber, vehicleType, hoursParked, assignedSlot);
            reservations.Add(newReservation);
        }

        public void AssignSlot(List<Reservation> reservations, string plateNumber, string assignedSlot)
        {
            var reservation = reservations.FirstOrDefault(r => r.PlateNumber == plateNumber);

            if (reservation != null && slotButtons.ContainsKey(assignedSlot))
            {
                Button btn = slotButtons[assignedSlot];
                btn.BackColor = Color.Red;
                btn.Text = $"{assignedSlot}\n{reservation.PlateNumber}";
            }
        }

        private void FreeSlot(Reservation res)
        {
            if (slotButtons.ContainsKey(res.AssignedSlot))
            {
                Button btn = slotButtons[res.AssignedSlot];
                btn.BackColor = Color.LawnGreen;
                btn.ForeColor = SystemColors.ControlText;
                btn.Text = res.AssignedSlot;
                btn.FlatAppearance.BorderSize = 0;
            }
        }
    }
}
