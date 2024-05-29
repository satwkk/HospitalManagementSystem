namespace Authentication.DbModels
{
    public readonly struct Patient : IExecutorModel
    {
        public readonly string _name { get; }
        public readonly string _illness { get; }
        public readonly string _illnessDescription { get; }
        public readonly string _admissionDate { get; }
        public readonly string _email { get; }
        public readonly string _phone { get; }
        public readonly string _emergencyNumber { get; }

        public Patient( string name, string illness = null, string illnessDescription = null, string admissionDate = null, string email = null, string phone = null, string emergencyNumber = null )
        {
            _name = name;
            _illness = illness;
            _illnessDescription = illnessDescription;
            _admissionDate = admissionDate;
            _email = email;
            _phone = phone;
            _emergencyNumber = emergencyNumber;
        }

        public List<string> GetValues()
        {
            return new List<string> { "Patient", _name, _illness, _illnessDescription, _admissionDate, _email, _phone, _emergencyNumber };
        }
    }
}
