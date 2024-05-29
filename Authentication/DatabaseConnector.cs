using Authentication.DbExecutors;
using Authentication.DbModels;
using Microsoft.Data.Sqlite;
using System.Runtime.CompilerServices;

namespace Authentication
{
    public class DatabaseConnector
    {
        public static DatabaseConnector Instance { get; private set; }

        private DatabaseConnector()
        {
        }

        // Singleton getter
        public static DatabaseConnector Get()
        {
            if (Instance == null)
            {
                Instance = new DatabaseConnector();
            }
            return Instance;
        }

        // Initializing and creating tables 
        public void Init()
        {
            using ( var connection = new SqliteConnection( "Data Source=test.db" ) )
            {
                connection.Open();

                var command = connection.CreateCommand();

                /** Create the employee table **/
                command.CommandText = "CREATE TABLE IF NOT EXISTS Employees (name VARCHAR(500), email VARCHAR(200), password VARCHAR(500));";
                command.ExecuteReader().Close();

                /** Create the patient table **/
                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Patient 
                (name VARCHAR(500), 
                illness VARCHAR(100), 
                illnessdescription VARCHAR(1000),
                admissiondate VARCHAR(50),
                contact_number VARCHAR(15),
                email VARCHAR(500),
                emergency_number VARCHAR(15));";
                command.ExecuteReader().Close();

                connection.Close();
            }
        }

        // Check for valid login if the username and password entered is valid
        public bool ValidLogin(ref DbModels.LoginUser loginUser)
        {
            using (SqliteConnection conn = new SqliteConnection("Data Source=test.db"))
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM Employees WHERE name=$name AND password=$password";
                command.Parameters.AddWithValue( "$name", loginUser._userName );
                command.Parameters.AddWithValue( "$password", loginUser._password );
                using ( var reader = command.ExecuteReader() )
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
            //var rows = new ReadExecutor().Execute( loginUser );
            //if (rows.Count == 0)
            //{
            //    return false;
            //}
            //return true;
        }

        // Add a registration user to the database
        public void Commit( ref RegistrationUser registrationUser, Action<string> onCommit = null )
        {
            var readRow = new ReadExecutor().Execute( new LoginUser( registrationUser._userName, registrationUser._password ) );

            if ( readRow.Count > 0 )
            {
                throw new SqliteException( "Account already exists", -1 );
            }

            new WriteExecutor().Execute( registrationUser );

            onCommit?.Invoke( "Successfully registered new employee" );
        }

        // Adds a patient to the database
        public void Commit( ref Patient patient, Action<string> onCommit = null )
        {
            var rows = new WriteExecutor().Execute( patient );

            onCommit?.Invoke( "Successfully created the patient" );
        }
    }
}
