using Authentication.DbExecutors;
using Microsoft.Data.Sqlite;
using System.Diagnostics.Eventing.Reader;

namespace Authentication.DbExecutors
{
    public class ReadExecutor : BaseExecutor
    {
        private string _query = "SELECT * FROM $table WHERE name = '$name';";

        protected override string Query { get => _query; set => _query = value; }

        public override List<Row> Execute( IExecutorModel dbModel )
        {
            List<Row> rows = new List<Row>();

            using (SqliteConnection connection = new SqliteConnection("Data Source=test.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                var parameters = GetParameters();
                var values = dbModel.GetValues();

                for (int i = 0; i < parameters.Count; i++)
                {
                    _query = _query.Replace( parameters[i], values[i] );
                }

                command.CommandText = _query;
                var reader = command.ExecuteReader();

                while ( reader.Read() )
                {
                    rows.Add( new Row( reader.GetString( 0 ), reader.GetString( 1 ), reader.GetString( 2 ) ) );
                }
                

                connection.Close();
            }

            return rows;
        }

        private List<string> GetParameters()
        {
            List<string> parameters = new List<string>();

            for (int i = 0; i < _query.Length; i++)
            {
                if ( _query[i] == '$' )
                {
                    string tempParam = "";
                    int j = i;
                    while ( j < _query.Length && !tokenTerminators.Contains( _query[j] ) )
                    {
                        tempParam += _query[j];
                        j++;
                    }
                    parameters.Add( tempParam );
                    tempParam = "";
                }
            }
            return parameters;
        }
    }
}
