
namespace MENDOZA_LABACT1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public List<Reservation> reservations = new List<Reservation>();
        public void RegisterVehicle(List<Reservation> reservations, string plateNumber, string vehicleType, double hoursParked, string assignedSlot)
        {
            Reservation newReservation = new Reservation(plateNumber, vehicleType, hoursParked, assignedSlot);
            reservations.Add(newReservation);
        }

        public void AssignSlot (List<Reservation> reservations, string plateNumber, string assignedSlot)
        {
            Reservation reservation = reservations.FirstOrDefault(r => r.PlateNumber == plateNumber);
            if (reservation != null)
            {
                foreach (Control c in grpParkingStatus.Controls)
                {
                    if (c is Button && c.Text == assignedSlot)
                    {
                        c.BackColor = Color.Red; // Mark the slot as occupied
                        c.Text = $"{assignedSlot}\n{reservation.PlateNumber}";
                        break;
                    }
                }
            }
        }

        private bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }
        private bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }

        private void btnRegisterVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in grpVehicleRegistration.Controls)
                {
                    if (c is TextBox t)
                    {
                        if (IsEmpty(t.Text))
                        {
                            MessageBox.Show("Error", "Please fill in all fields.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (c is ComboBox cb)
                    {
                        if (cb.SelectedIndex == -1)
                        {
                            MessageBox.Show("Error", "Please select a vehicle type.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                if (!IsNumeric(txtHoursParked.Text))
                {
                    MessageBox.Show("Error", "Please enter a valid number for hours parked.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                RegisterVehicle(reservations, txtPlateNumber.Text, cmbVehicleType.SelectedItem.ToString(), double.Parse(txtHoursParked.Text), txtAssignedSlot.Text);
                AssignSlot(reservations, txtPlateNumber.Text, txtAssignedSlot.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
