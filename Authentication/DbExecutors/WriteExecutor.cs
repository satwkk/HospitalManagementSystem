using Microsoft.Data.Sqlite;

namespace Authentication.DbExecutors
{
    public class WriteExecutor : BaseExecutor
    {
        private string _query = "INSERT INTO $table VALUES ($)";

        protected override string Query { get => _query; set => _query = value; }

        public override List<Row> Execute( IExecutorModel model )
        {
            List<Row> rows = new List<Row>();

            using ( SqliteConnection conn = new SqliteConnection( "Data Source=test.db" ) )
            {
                conn.Open();

                var command = conn.CreateCommand();
                var parameters = model.GetValues();
                ConstructQueryString( parameters );
                command.CommandText = _query;
                var reader = command.ExecuteReader();

                while ( reader.Read() )
                {
                    string[] values = new string[] { };
                    reader.GetValues( values );
                    foreach ( string val in values )
                    {
                        rows.Add( new Row( val ) );
                    }
                }

                conn.Close();
            }

            return rows;
        }

        private void ConstructQueryString( List<string> parameters )
        {
            // INSERT INTO $table VALUES()
            // first param -> table name
            // second - last -> sql attributes
            //private string _query = "INSERT INTO $table VALUES ($)";
            bool foundTable = false;

            for (int i = 0; i < _query.Length; i++)
            {
                if ( _query[i] == '$' )
                {
                    if (!foundTable)
                    {
                        string tempStr = "";
                        int j = i;
                        while ( !tokenTerminators.Contains( _query[j] ))
                        {
                            tempStr += _query[j];
                            j++;
                        }
                        _query = _query.Replace( tempStr, parameters[0] );
                        foundTable = true;
                        i = j;
                    }
                    else
                    {
                        string valueStr = "";

                        for (int pIdx = 1; pIdx < parameters.Count; pIdx++)
                        {
                            if (pIdx == parameters.Count - 1)
                            {
                                valueStr += $"'{parameters[pIdx]}'";
                            }
                            else
                            {
                                valueStr += $"'{parameters[pIdx]}',";
                            }
                        }

                        _query = _query.Replace( "$", valueStr );

                        break;
                    }

                }
            }

        }
    }
}
