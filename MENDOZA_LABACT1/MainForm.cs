
namespace MENDOZA_LABACT1
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Button> slotButtons = new Dictionary<string, Button>();
        public List<Reservation> reservations = new List<Reservation>();

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

            Reservation foundRes = reservations.FirstOrDefault(r => r.AssignedSlot == slotName);
            if (foundRes !=  null)
            {
                LoadReservationData(foundRes);
                return;
            }

            else
            {
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
                MessageBox.Show( "Parking slot is already occupied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void UpdateSlotVisual(Reservation newres)
        {
            if (slotButtons.ContainsKey(newres.AssignedSlot))
            {
                Button btn = slotButtons[newres.AssignedSlot];
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
                btn.Text = $"{newres.AssignedSlot}\n{newres.PlateNumber}";
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
            foreach (Control c in grpVehicleRegistration.Controls)
            {
                if (c is TextBox tb) tb.Clear();
                if (c is ComboBox cb) cb.SelectedIndex = -1;
            }
        }

        private void LoadReservationData(Reservation res)
        {
            lblPlateNumber.Text = res.PlateNumber;
            lblVehicleInfo.Text = res.VehicleType;
            lblDuration.Text = $"{res.HoursParked} hours";
            lblSlot.Text = res.AssignedSlot;
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

        private void btnRegisterVehicle_Click(object sender, EventArgs e)
        {
            if (!ValidateRegistrationInputs()) return;

            try
            {
                string plate = txtPlateNumber.Text.Trim();
                string type = cmbVehicleType.SelectedItem.ToString();
                double hours = Convert.ToDouble(txtHoursParked.Text.Trim());
                string slot = txtAssignedSlot.Text.Trim();

                Reservation reservation = new Reservation(plate, type, hours, slot);
                reservations.Add(reservation);

                UpdateSlotVisual(reservation);

                double totalFee = reservation.CalculateFee();
                lblOvertimeFee.Text = reservation.OvertimeFee.ToString("N2");
                lblStandardFee.Text = (totalFee - 20).ToString("N2");
                lblServiceCharge.Text = reservation.ServiceCharge.ToString("N2");
                lblTotal.Text = totalFee.ToString("N2");

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
