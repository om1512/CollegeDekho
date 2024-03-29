using System.Runtime.Serialization;

namespace CollegeDekhoService
{
    [DataContract]
    public class Admin
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
