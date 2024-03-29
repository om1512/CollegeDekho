using System.Runtime.Serialization;

namespace CollegeDekhoService
{
    [DataContract]
    public class College
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string University { get; set; }

        [DataMember]
        public string Place { get; set; }

        [DataMember]
        public int? Established { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Website { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public int? CampusSize { get; set; }

        [DataMember]
        public string Gyn { get; set; }

        [DataMember]
        public string Canteen { get; set; }

        [DataMember]
        public string Sports { get; set; }

        [DataMember]
        public string NAAC { get; set; }

        [DataMember]
        public string NIRF { get; set; }

        [DataMember]
        public string Library { get; set; }
    }
}
