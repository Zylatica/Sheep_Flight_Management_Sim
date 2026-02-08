using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportTestSimulator
{
    public partial class EditFlight : Form
    {

        List<string> updatedFlightData = new List<string>();

        public EditFlight(AddFlight addFlightInstance)
        {
            InitializeComponent(); // required

            GetUpdatedDetails();

            int selectedIndex = addFlightInstance.GetSelectedIndex();
            List<string> flightData = addFlightInstance.GetFlightDetails(selectedIndex);

            lblShowDestination.Text = flightData[0];
            lblShowHr.Text = flightData[1];
            lblShowMin.Text = flightData[2];

            cmbNewHr.Text = flightData[1];
            cmbNewMin.Text = flightData[2];
            cmbNewStatus.Text = lblShowCancelled.Text;
        }

        List<string> GetUpdatedDetails()
        {
            updatedFlightData.Clear();
            updatedFlightData.Add(lblShowDestination.Text);
            updatedFlightData.Add(lblShowHr.Text);
            updatedFlightData.Add(lblShowMin.Text);
            updatedFlightData.Add(lblShowCancelled.Text);

            return updatedFlightData;
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            lblShowHr.Text = cmbNewHr.Text;
            lblShowMin.Text = cmbNewMin.Text;
            lblShowCancelled.Text = cmbNewStatus.Text;

            GetUpdatedDetails();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            AddFlight.updatedFlight = GetUpdatedDetails();
            AddFlight.editingOpen = false;
            ActiveForm.Close();
        }
    }
}
