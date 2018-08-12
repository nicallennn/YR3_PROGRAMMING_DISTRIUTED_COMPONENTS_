using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopNetworkEditor
{
    public partial class MainForm : Form
    {
        

        private string loggedInUser;

        public MainForm(string loggedInUser)
        {
            InitializeComponent();

            //set user as user
            this.loggedInUser = loggedInUser;
            lblUsername.Text = loggedInUser;

            //display train network information
            UpdateLists();
           
        }

        private void BtnStationsAndLines_Click(object sender, EventArgs e)
        {
            pnlStationEditor.Visible = !pnlStationEditor.Visible;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //check user has entered a value and return if null
            if(txtName.Text == "")
            {
                return;
            }

            LinqMethods Add = new LinqMethods();

            if (rbStation.Checked)
            {
                bool addQuery = Add.AddStation(txtName.Text);
                if (addQuery)
                {
                    //update the lists
                    UpdateLists();
                }
            }
            else
            {
                bool addQuery = Add.AddLine(txtName.Text);
                if (addQuery)
                {
                    //update the lists
                    UpdateLists();
                }
            }

        }

        private void BtnRem_Click(object sender, EventArgs e)
        {

            //check user has entered a value and return if null
            if (txtRemove.Text == "")
            {
                return;
            }

            LinqMethods Remove = new LinqMethods();

            if (rbStation.Checked)
            {

                //get the id
                int id = GetId(txtRemove.Text);
                
                //remove station
                bool removeQuery = Remove.RemoveStation(id);

                if (removeQuery)
                {
                    //update the lists
                    UpdateLists();
                }

            }
            else
            {
                //get the id
                int id = GetId(txtRemove.Text);

                //remove the line
                bool removeQuery = Remove.RemoveLine(id);

                if (removeQuery)
                {
                    //update the lists
                    UpdateLists();
                }

            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //check user has entered a value and return if null
            if (txtEdit.Text == "")
            {
                return;
            }

            LinqMethods Edit = new LinqMethods();

            if (rbStation.Checked)
            {
                int id = GetId(txtEdit.Text);
                bool editQuery = Edit.EditStation(id, txtEditName.Text);

                if (editQuery)
                {
                    //update the lists
                    UpdateLists();
                }
                

            }
            else
            {
                int id = GetId(txtEdit.Text);
                bool editQuery = Edit.EditLine(id, txtEditName.Text);

                if (editQuery)
                {
                    //update the lists
                    UpdateLists();
                }
                
            }

        }

        private void BtnAddStationToLine_Click(object sender, EventArgs e)
        {
            //check user has entered all values int he form 
            bool validated = ValidateLineEditorFields();

            //if not validated, return from event handler
            if (!validated)
            {
                return;
            }

            LinqMethods AddLineInfo = new LinqMethods();

            //call Add line info method, add new line information
            AddLineInfo.AddToLine(
                GetId(txtLineSelect.Text), 
                GetId(txtStationToLine.Text), 
                GetId(txtPosition.Text), 
                GetDecimal(txtDistance.Text), 
                GetDecimal(txtTime.Text)
                );

            UpdateLineInfo(GetId(txtLineSelect.Text));
            ClearLineEditor();
        }

        

        private void BtnRemoveFromLine_Click(object sender, EventArgs e)
        {
            //check a line is selected
            if(txtLineInfo.Text != "")
            {
                LinqMethods RemoveLineInfo = new LinqMethods();

                //get line id
                int lineId = GetId(txtLineInfo.Text);

                //call remove line method
                bool removeFromLine = RemoveLineInfo.RemoveFromLine(lineId, GetId(txtRemoveFromLine.Text));

                //if station was removed from line, refresh the list
                if (removeFromLine)
                {
                    UpdateLineInfo(lineId);
                }

                ClearLineEditor();

            }

        }

        private void BtnLineView_Click(object sender, EventArgs e)
        {
            if (txtLineInfo.Text == "")
            {
                return;
            }

                //update the line info
                UpdateLineInfo(GetId(txtLineInfo.Text));

                //get the name of the line
                LinqMethods GetLineName = new LinqMethods();
                //display the line and id
                lblName.Text = GetLineName.GetLineName(GetId(txtLineInfo.Text));
                lblId.Text = txtLineInfo.Text;
            
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            if (txtLineInfo.Text == "")
            {
                return;
            }

            //get line id
            int lineId = GetId(txtLineInfo.Text);

            //sort the line order, incase of user input errors
            LinqMethods Sort = new LinqMethods();
            Sort.SortLineOrder(lineId);

            //refresh the display
            UpdateLineInfo(lineId);

        }

        private void BtnAddDelay_Click(object sender, EventArgs e)
        {
            //if add is selected, call add method, else call remove method
            if (rbAddDelay.Checked)
            {
                //validate textbox
                if(txtDelay.Text == "" || txtDelayStationId.Text == "")
                {
                    return;
                }

                LinqMethods AddDelay = new LinqMethods();
                AddDelay.AddDelayToLine(GetId(txtLineInfo.Text), GetId(txtDelayStationId.Text), GetDecimal(txtDelay.Text));

            }
            else
            {
                //validate textbox
                if (txtDelayStationId.Text == "")
                {
                    return;
                }

                LinqMethods RemoveDelay = new LinqMethods();
                RemoveDelay.RemoveDelayFromLine(GetId(txtLineInfo.Text), GetId(txtDelayStationId.Text));

            }

            //refresh the display
            txtDelayStationId.Text = "";
            txtDelay.Text = "";
            UpdateLineInfo(GetId(txtLineInfo.Text));
        }

        private void BtnLineEditor_Click(object sender, EventArgs e)
        {
            pnlLineEditor.Visible = !pnlLineEditor.Visible;
        }

        //method to validate the line editor input textboxes
        private bool ValidateLineEditorFields()
        {
            //check each textbox !null
            if (
                txtLineSelect.Text == "" ||
                txtStationToLine.Text == "" ||
                txtPosition.Text == "" ||
                txtDistance.Text == "" ||
                txtTime.Text == ""
                )
            {
                return false;
            }

            return true;

        }

        //method to parse textbox value to int
        private int GetId(string stringId)
        {
            try
            {
                return int.Parse(stringId);
            }
            catch(Exception eX)
            {
                Console.WriteLine("Could not convert to integer value!, Exception: " + eX);
                return 0;
            }
            
        }

        //method to parse textbox value into decimal
        private decimal GetDecimal(string input)
        {
            
            try
            {
                return decimal.Parse(input);
            }
            catch (Exception eX)
            {
                Console.WriteLine("Could not convert to decimal value!, Exception: " + eX);
                return 0;
            }
        }

        
        
        //method to update the station and line info lists -> i.e. refresh the form
        private void UpdateLists()
        {
            DBClassesDataContext db = new DBClassesDataContext();

            //clear the text inputs
            txtName.Text = "";
            txtEdit.Text = "";
            txtEditName.Text = "";
            txtRemove.Text = "";

            //clear the listboxes
            stationList.Items.Clear();
            lineList.Items.Clear();

            //update the station list
            var stationsQuery =
                from stn in db.stations
                select stn;

            foreach (var stn in stationsQuery)
            {
                stationList.Items.Add("ID: " + stn.station_id + ". Station Name: " + stn.station_name);
            }

            //update the line list
            var lineQuery =
                from ln in db.lines
                select ln;

            foreach (var ln in lineQuery)
            {
                lineList.Items.Add("ID: " + ln.line_id + ". Line Name: " + ln.line_name);
            }


        }


        //method to update line info list, clears inputs and reloads data from line_informations table
        private void UpdateLineInfo(int lineId)
        {
            DBClassesDataContext db = new DBClassesDataContext();

            lineInfoList.Items.Clear();

            var joinLineQuery =
                (from lInfo in db.line_informations
                 join stn in db.stations on lInfo.station_id equals stn.station_id
                 where lInfo.line_id == lineId
                 orderby lInfo.position
                 select new
                 {
                     Id = stn.station_id,
                     StationName = stn.station_name,
                     Position = lInfo.position,
                     ToNext = lInfo.distance_to_next,
                     Delay = lInfo.delay_to_next,

                 });

            foreach (var lInfo in joinLineQuery)
            {
                lineInfoList.Items.Add(
                    $"ID: {lInfo.Id}. Station: {lInfo.StationName}. Position: {lInfo.Position}. Next Station: {lInfo.ToNext} (Miles). Delay: {lInfo.Delay}");
            }
        }

        //method to clear the input field of the line editor panel
        private void ClearLineEditor()
        {
            txtStationToLine.Text = "";
            txtPosition.Text = "";
            txtDistance.Text = "";
            txtTime.Text = "";
            txtRemoveFromLine.Text = "";
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'na2880gDataSet.lines' table. You can move, or remove it, as needed.
            this.linesTableAdapter.Fill(this.na2880gDataSet.lines);
            // TODO: This line of code loads data into the 'na2880gDataSet.stations' table. You can move, or remove it, as needed.
            this.stationsTableAdapter.Fill(this.na2880gDataSet.stations);

        }

        
        private void rbDeleteDelay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeleteDelay.Checked)
            {
                txtDelay.Enabled = false;
            }
            else
            {
                txtDelay.Enabled = true;


            }
        }


        //mirror user input across line editor id textboxes
        private void txtLineSelect_TextChanged(object sender, EventArgs e)
        {
            txtLineInfo.Text = txtLineSelect.Text;
        }

        private void txtLineInfo_TextChanged(object sender, EventArgs e)
        {
            txtLineSelect.Text = txtLineInfo.Text;
        }
    }
}
