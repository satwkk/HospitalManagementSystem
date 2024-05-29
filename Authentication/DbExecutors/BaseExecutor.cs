namespace Authentication.DbExecutors
{
    public class Row
    {
        private List<string> parameters = new List<string>();

        public List<string> Parameters { get => parameters; private set => parameters = value; }

        public Row(params string[] p)
        {
            Parameters = p.ToList();
        }
    }


    public abstract class BaseExecutor
    {
        protected List<char> tokenTerminators = new List<char> { '\'', ';', ' ' };

        protected abstract string Query { get; set; }

        public abstract List<Row> Execute( IExecutorModel model );
    }
}
