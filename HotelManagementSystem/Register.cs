using Authentication;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagementSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click( object sender, EventArgs e )
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {
            var userName = registerUsernameValue.Text;
            var password = registerPasswordValue.Text;
            var email = registerEmailValue.Text;
            var confirmPassword = registerConfirmPasswordValue.Text;

            var validator = new Validator( new List<string> { userName, password, email, confirmPassword } );
            var valid = validator.Validate( new List<Func<bool>>
            {
                validator.IsNotEmpty,
                validator.HasNoBlackListChar,
                validator.HasNoWhiteSpace
            } ); ;

            if ( !valid ) return;

            var newEmployee = new Authentication.DbModels.RegistrationUser( userName, email, password, confirmPassword );

            try
            {
                DatabaseConnector.Get().Commit( ref newEmployee );
                Hide();
                new Login().Show();
            }
            catch (SqliteException sqlError)
            {
                new FeedbackForm( sqlError.ToString() ).Show();
            }
        }

        private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            Hide();
            new Login().Show();
        }
    }
}
