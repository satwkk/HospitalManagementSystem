using Authentication;
using Authentication.DbModels;
using Microsoft.Data.Sqlite;

namespace HotelManagementSystem
{
    public partial class Dashboard : Form
    {
        public List<GroupBox> _groupBoxes;

        public Dashboard()
        {
            InitializeComponent();

            _groupBoxes = new List<GroupBox>()
            {
                dashboardMainGroupBox,
                addPatientGroupBox,
                editPatientGroupBox,
                editPatientGroupBoxPopup
            };

            dataGridView1.CellClick += OnCellClick;

            QueryPatientList();
        }

        /** Event fired when a particular cell is clicked **/
        private void OnCellClick( object? sender, DataGridViewCellEventArgs e )
        {
            // If we are clicking at the first column ie. name
            if ( e.ColumnIndex == 0 )
            {
                // Get the patient name from the cell we click on
                var patientName = dataGridView1[e.ColumnIndex, e.RowIndex].Value;

                // Create an sql connection to read the entries with the patient name
                using ( SqliteConnection conn = new SqliteConnection( "Data Source=test.db" ) )
                {
                    conn.Open();

                    string name = "";
                    string illness = "";
                    string illnessDescription = "";
                    string admissionDate = "";
                    string contactNumber = "";
                    string email = "";
                    string emergencyNumber = "";

                    // Get the data from database
                    var command = conn.CreateCommand();
                    command.CommandText = $"SELECT * FROM Patient WHERE name = '{patientName}'";
                    var reader = command.ExecuteReader();
                    while ( reader.Read() )
                    {
                        name = reader.GetString( 0 );
                        illness = reader.GetString( 1 );
                        illnessDescription = reader.GetString( 2 );
                        admissionDate = reader.GetString( 3 );
                        contactNumber = reader.GetString( 4 );
                        email = reader.GetString( 5 );
                        emergencyNumber = reader.GetString( 6 );
                    }

                    conn.Close();

                    // Toggle the group box for editing patient on
                    ToggleGroupBoxVisibility( editPatientGroupBoxPopup, true );

                    // Fill the edit form with the already existing data
                    editGroupBoxPatientName.Text = name;
                    editGroupBoxPatientName.Enabled = false; // Setting it to false so the client cannot edit patient name
                    editGroupBoxMedicalIllness.Text = illness;
                    editGroupBoxIllnessDescription.Text = illnessDescription;
                    // TODO: Format the admission date into proper date value
                    editGroupBoxAdmissionDate.Text = admissionDate;
                    editGroupBoxContactNumber.Text = contactNumber;
                    editGroupBoxEmail.Text = email;
                    editGroupBoxEmergencyNumber.Text = emergencyNumber;
                }
            }
        }

        /** Queries the patient list and displays it onto the edit patient groupbox grid **/
        private void QueryPatientList()
        {
            List<Patient> rows = new List<Patient>();

            using ( SqliteConnection connection = new SqliteConnection( "Data Source=test.db" ) )
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Patient";
                using ( var reader = command.ExecuteReader() )
                {
                    while ( reader.Read() )
                    {
                        rows.Add(
                            new Patient(
                            reader.GetString( 0 ),
                            reader.GetString( 1 ),
                            reader.GetString( 2 ),
                            reader.GetString( 3 ),
                            reader.GetString( 4 ),
                            reader.GetString( 5 ),
                            reader.GetString( 6 )
                            )
                        );
                    }
                }
                connection.Close();
            }
            dataGridView1.DataSource = rows;
        }

        /** Toggles visibility of one groupbox on and rest off 
         * @param: groupBox: the groupbox you want to toggle the value to on 
         **/
        private void ToggleGroupBoxVisibility( GroupBox groupBox, bool value )
        {
            foreach ( GroupBox g in _groupBoxes )
            {
                if ( g != groupBox )
                {
                    g.Visible = false;
                }
            }
            groupBox.Visible = true;
        }

        /** Clears all the input fields in the add patient group box **/
        private void ClearAllLabels()
        {
            dashboardPatientNameValue.Clear();
            dashboardMedicalProblemValue.Clear();
            dashboardMedicalProblemDescriptionValue.Clear();
            dashboardContactNumberValue.Clear();
            dashboardAdmissionDateValue.ResetText();
            dashboardContactEmailValue.Clear();
            dashboardEmergencyNumberValue.Clear();
        }

        /** IDK what this does :( **/
        private void dashboardMenuFileButton_Click( object sender, EventArgs e )
        {

        }

        /** Shows the add patient group box **/
        private void addPatientToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ToggleGroupBoxVisibility( addPatientGroupBox, true );
        }

        /** Show the edit patient group box **/
        private void editPatientToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ToggleGroupBoxVisibility( editPatientGroupBox, true );
            QueryPatientList();
        }

        /** Show the delete patient group box **/
        private void deletePatientToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        /** Adds patient to the database **/
        private void button1_Click( object sender, EventArgs e )
        {
            var patientName = dashboardPatientNameValue.Text;
            var patientMedicalProblem = dashboardMedicalProblemValue.Text;
            var patientMedicalProblemDescription = dashboardMedicalProblemDescriptionValue.Text;
            var patientContactNumber = dashboardContactNumberValue.Text;
            var patientAdmissionDate = dashboardAdmissionDateValue.Text;
            var patientContactEmail = dashboardContactEmailValue.Text;
            var patientEmergencyNumber = dashboardEmergencyNumberValue.Text;

            var validator = new Validator( new List<string> {
                patientName,
                patientMedicalProblem,
                patientMedicalProblemDescription,
                patientContactNumber,
                patientAdmissionDate,
                patientContactEmail,
                patientEmergencyNumber } );

            var valid = validator.Validate( new List<Func<bool>> { validator.IsNotEmpty, validator.HasNoWhiteSpace } );
            if ( valid == false ) return;

            var patient = new Patient(
                patientName,
                patientMedicalProblem,
                patientMedicalProblemDescription,
                patientAdmissionDate,
                patientContactEmail,
                patientContactNumber,
                patientEmergencyNumber
                );

            try
            {
                DatabaseConnector.Get().Commit( ref patient, onCommit: ( successMsg ) =>
                {
                    ClearAllLabels();
                    new FeedbackForm( successMsg ).Show();
                } );
            }
            catch ( SqliteException sqlError )
            {
                new FeedbackForm( sqlError.ToString() ).Show();
            }
        }

        private void dashboardPatientTextValue_TextChanged( object sender, EventArgs e )
        {
        }

        private void ClearLables_V2( params Control[] fields )
        {
            foreach ( var f in fields )
            {
                f.Text = string.Empty;
            }
        }

        /** Edits the patient model and sends the data back to database for update **/
        private void button2_Click( object sender, EventArgs e )
        {

            var patientName = editGroupBoxPatientName.Text;
            var patientMedicalProblem = editGroupBoxMedicalIllness.Text;
            var patientMedicalProblemDescription = editGroupBoxIllnessDescription.Text;
            var patientAdmissionDate = editGroupBoxAdmissionDate.Text;
            var patientContactNumber = editGroupBoxContactNumber.Text;
            var patientContactEmail = editGroupBoxEmail.Text;
            var patientEmergencyNumber = editGroupBoxEmergencyNumber.Text;

            // Validate the strings that they have all required properties set
            var paramStrings = new List<string> {
                patientName,
                patientMedicalProblem,
                patientMedicalProblemDescription,
                patientContactNumber,
                patientAdmissionDate,
                patientContactEmail,
                patientEmergencyNumber };

            var validator = new Validator( paramStrings );

            var valid = validator.Validate( new List<Func<bool>> { validator.IsNotEmpty, validator.HasNoWhiteSpace } );
            if ( !valid ) return;

            try
            {
                // Update the database
                using ( SqliteConnection conn = new SqliteConnection( "Data Source=test.db" ) )
                {
                    conn.Open();

                    var command = conn.CreateCommand();
                    command.CommandText = "UPDATE Patient SET illness=$illness, illnessdescription=$illnessDescription, admissiondate=$admissionDate,contact_number=$contactNumber,email=$email,emergency_number=$emergencyNumber WHERE name=$name";
                    command.Parameters.AddWithValue( "$illness", patientMedicalProblem );
                    command.Parameters.AddWithValue( "$illnessDescription", patientMedicalProblemDescription );
                    command.Parameters.AddWithValue( "$admissionDate", patientAdmissionDate );
                    command.Parameters.AddWithValue( "$contactNumber", patientContactNumber );
                    command.Parameters.AddWithValue( "$email", patientContactEmail );
                    command.Parameters.AddWithValue( "$emergencyNumber", patientEmergencyNumber );
                    command.Parameters.AddWithValue( "$name", patientName );
                    var nAffectedRows = command.ExecuteNonQuery();

                    if ( nAffectedRows > 0 )
                    {
                        // Clear all the labels
                        ClearLables_V2(
                            editGroupBoxPatientName,
                            editGroupBoxMedicalIllness,
                            editGroupBoxIllnessDescription,
                            editGroupBoxAdmissionDate,
                            editGroupBoxContactNumber,
                            editGroupBoxEmail,
                            editGroupBoxEmergencyNumber
                        );
                        // Create a feedback form to let user know patient has been edited succesfully
                        new FeedbackForm( "Patient was edited succesfully" ).Show();
                    }

                    conn.Close();
                }
            }
            catch ( SqliteException sqlError )
            {
                new FeedbackForm( sqlError.ToString() ).Show();
            }
        }
    }
}
