using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Model;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        
        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null; // to allow rebind
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentPlayersListBox.DataSource = null;
            tournamentPlayersListBox.DataSource = selectedTeams;
            tournamentPlayersListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";

        }


        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void placeNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void placeNumberValue_TextChanged(object sender, EventArgs e)
        {

        }


        private void prizesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prizesLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            //PersonModel p = (PersonModel)selectTeamDropDown.SelectedItem;
            //if (p != null)
            //{
            //    availableTeamMembers.Remove(p);
            //    selectedTeamMembers.Add(p);
            //    WireUpLists(); //Refresh the list 
            //}
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // Call create prize form
            CreatePrizeForm frm = new  CreatePrizeForm(this);
            frm.Show();
            
        }

        public void PrizeComplete(PrizeModel model)
        {
            // Get back from the form a prize model
            // Take prize model put it in list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void RemoveSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            //PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            //if (p != null)
            //{
            //    selectedTeamMembers.Remove(p);
            //    availableTeamMembers.Add(p);
            //    WireUpLists(); //Refresh the list
            //}
            TeamModel t = (TeamModel)tournamentPlayersListBox.SelectedItem;

            if (t!=null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);
                WireUpLists();
            }
        }
        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);

            if(!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid entry fee", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Create tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // TODO-  Create our matchups
            TournamentLogic.CreateRounds(tm);

            // Create tournaments entry
            // Create all of the prizes entries
            // Create all of team entries
            GlobalConfig.Connection.CreateTournament(tm);

            

        }
    }
}
