using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace AirportTestSimulator
{
    public partial class AddFlight : Form
    {

        int existingFlights = 0; // upon loading, existing flights is 0 in the array
        Data[] newFlight; // setting up array to hold as many flights as needed


        string tempDes = "";
        int tempHr = 00;
        int tempMin = 00;

        int index = 0;

        internal static bool editingOpen = false;
        internal static List<string> updatedFlight = new List<string>();


        public AddFlight() // Initializes the form, must be done first
        {
            InitializeComponent(); // required

            // To find current number of flights in the list from the text file
            int FLL = ArrangeFlights(); 

            newFlight = new Data[FLL];

            CreateFlightArray(FLL);
            // lbFlightList.Items.Add($"{existingFlights}"); 
            // ^ to check whether the array is working
            DisplayFlights();
        }

        List<string> importedFile()
        {
            // Importing data from text file
            List<string> import = new List<string>();

            foreach (string destination in File.ReadAllLines("ListofFlights.txt"))
            {
                import.Add(destination);
            }
            return import;
        }

        // To handle the text file flights at the start of the program
        int ArrangeFlights() 
        {
            List<string> import = importedFile();
            int importLength = import.Count;
            int flightListLength = importLength / 4;

            // Noting the length of the flight list in order
            // to create an array of appropriate size

            // lbFlightList.Items.Add($"{flightListLength}");
            return flightListLength;
        }

        List<string> FormatFlights()
        {
            List<string> import = importedFile();
            List<string> FlightList = new List<string>();
            int importLength = import.Count - 1;
            int count = 0;

            while (count < importLength)
            {
                FlightList.Add($"{import[count]} - {import[count + 1]}:{import[count + 2]}  Status: {import[count + 3]}");
                count += 4;
            }

            return FlightList;
        }

        void CreateFlightArray(int f)
        {
            int flightListLength = f;
            List<string> import = importedFile();
            for (int i = existingFlights; i < flightListLength; i++)
            {
                newFlight[i] = new Data()
                {
                    destination = import[i * 4],
                    hour = Convert.ToInt32(import[(i * 4) + 1]),
                    minute = Convert.ToInt32(import[(i * 4) + 2]),
                    status = import[(i * 4) + 3]
                };
            }

            // lbFlightList.Items.Add($"{newFlight[existingFlights].destination}"); 
            // ^ to check whether the array is working
        }

        void DisplayFlights()
        {
            int count = 0;
            int n = ArrangeFlights();
            List<string> formattedFlights = FormatFlights();
            lbFlightList.Items.Clear();
            while (count < n)
            {
                lbFlightList.Items.Add(formattedFlights[(count)]);
                count ++;
            }
            int FLL = ArrangeFlights();
            // lbFlightList.Items.Add($"{FLL}");
        }

        public int GetSelectedIndex()
        {
            int selectedIndex = lbFlightList.SelectedIndex;
            return selectedIndex;
        }

        void EditingFlightScreen()
        {
            EditFlight editFlight = new EditFlight(this);
            //ActiveForm.Hide();
            editFlight.Show();
            index = GetSelectedIndex();
            lblSelectedFlight.Text = $"{newFlight[index].destination} - {newFlight[index].hour}:{newFlight[index].minute}";
        }

        public List<string> GetFlightDetails(int i)
        {
            List<string> flightDetails = new List<string>();
            flightDetails.Add(newFlight[i].destination);
            flightDetails.Add(Convert.ToString(newFlight[i].hour));
            flightDetails.Add(Convert.ToString(newFlight[i].minute));
            return flightDetails;
        }

        public void AppendFlightListbox()
        {
            if (updatedFlight == null || updatedFlight.Count < 4) return;
            if (index < 0 || index >= newFlight.Length) return;

            newFlight[index].SetFlightDetails(updatedFlight[0], Convert.ToInt32(updatedFlight[1]), Convert.ToInt32(updatedFlight[2]));
            newFlight[index].SetStatus(updatedFlight[3]);
            File.WriteAllText("ListofFlights.txt", ""); // Clear the text file
            for (int i = 0; i < newFlight.Length; i++)
            {
                File.AppendAllText("ListofFlights.txt", "\n");
                File.AppendAllText("ListofFlights.txt", newFlight[i].destination + "\n" + newFlight[i].hour + "\n" + newFlight[i].minute + "\n" + newFlight[i].status);
            }
            lbFlightList.Items.Insert(index, $"{updatedFlight[0]} - {updatedFlight[1]}:{updatedFlight[2]}   Status: {updatedFlight[3]}");
            lbFlightList.Items.RemoveAt(index + 1);
        }

        void btnAddNewFlight_Click(object sender, EventArgs e)
        {
            if (cmbDestinationList.SelectedIndex == -1)
            {
                lblConfirmation.Text = "Please select a destination.";
            }
            else if (cmbHour.SelectedIndex == -1 || cmbMinute.SelectedIndex == -1)
            {
                lblConfirmation.Text = "Please select a time.";
            }
            else
            {
                tempDes = cmbDestinationList.Text;
                tempHr = Convert.ToInt32(cmbHour.Text);
                tempMin = Convert.ToInt32(cmbMinute.Text);
                string tempFlightFormatted = ($"{tempDes} - {tempHr}:{tempMin}");

                //FLL++; // increasing flight list length by 1 to accommodate new flight
                // Add new flight to txt file and then rerun the import and createflightarray methods
                File.AppendAllText("ListofFlights.txt", "\n");
                File.AppendAllText("ListofFlights.txt", tempDes + "\n" + tempHr + "\n" + tempMin + "\n" + "Active");

                lblConfirmation.Text = ($"Flight to {tempFlightFormatted} confirmed.");
                int FLL = ArrangeFlights() - 1;
                DisplayFlights();
                Array.Resize(ref newFlight, newFlight.Length + 1);
                newFlight[FLL] = new Data()
                {
                    destination = tempDes,
                    hour = tempHr,
                    minute = tempMin
                };
                //lbFlightList.Items.Add($"{FLL}");
                // testArray();
            }

        }

        private void btnOpenEditScreen_Click(object sender, EventArgs e)
        {
            if (editingOpen == false)
            {
                EditingFlightScreen();
                editingOpen = true;
            }
            else
            {
                MessageBox.Show("A flight is already being edited. Please finish editing before trying to edit another.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AppendFlightListbox();
        }




        // void testArray()
        // {
        // lbFlightList.Items.Add($"{newFlight[0].Destination}, {newFlight[1].Destination}, {newFlight[3].Destination}");
        // }


    }
}
