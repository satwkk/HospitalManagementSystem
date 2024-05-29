using Authentication;

namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        char[] blackListChars = new char[]
        {
            '\'', '*', '/', '{', '-'
        };
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            string userName = loginUsername.Text;
            string password = loginPassword.Text;

            var validator = new Validator( new List<string> { userName, password } );
            var valid = validator.Validate( new List<Func<bool>>
            {
                validator.IsNotEmpty,
                validator.HasNoBlackListChar,
                validator.HasNoWhiteSpace
            } ); ;

            if ( !valid ) return;

            var loginUser = new Authentication.DbModels.LoginUser( userName, password );
            var validLogin = DatabaseConnector.Get().ValidLogin( ref loginUser );

            if ( validLogin )
            {
                this.Hide();
                var dashbard = new Dashboard();
                dashbard.Show();
            }
            else
            {
                new FeedbackForm( "Invalid Login" ).Show();
            }
        }

        private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            Hide();
            new Register().Show();
        }
    }
}