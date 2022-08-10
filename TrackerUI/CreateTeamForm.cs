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
    public partial class CreateTeamForm : Form 
    {

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            //CreateSampleData();
            callingForm = caller;
            WireUpLists();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void tournamentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void tournamentNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel(
                    firstNameValue.Text,
                    lastNameValue.Text,
                    emailValue.Text,
                    cellphoneValue.Text);

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill in all the forms");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length==0 || lastNameValue.Text.Length == 0 || emailValue.Text.Length==0)
            {
                return false;
            }

            return true;

        }


        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeamMembers;
            selectTeamDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        //private void CreateSampleData()
        //{
        //    availableTeamMembers.Add(new PersonModel { FirstName = "Tan", LastName = "CQ1" });
        //    availableTeamMembers.Add(new PersonModel { FirstName = "Tan", LastName = "CQ3" });
        //    selectedTeamMembers.Add(new PersonModel { FirstName = "Tan", LastName = "CQ2" });
        //}

        private void selectTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpLists(); //Refresh the list 
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
      
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUpLists(); //Refresh the list
            }
        }

        private void ccreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;
            t = GlobalConfig.Connection.CreateTeam(t);
            callingForm.TeamComplete(t);
            this.Close();
        }
    }
}
