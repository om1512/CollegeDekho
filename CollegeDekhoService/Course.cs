using System.Runtime.Serialization;

namespace CollegeDekhoService 
{
    [DataContract]
    public class Course
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int college_id { get; set; }

        [DataMember]
        public string type { get; set; }

        [DataMember]
        public string degree { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public string duration { get; set; }

        [DataMember]
        public decimal fees { get; set; }

        [DataMember]
        public decimal rating { get; set; }

        [DataMember]
        public decimal placement_rate { get; set; }

        [DataMember]
        public decimal median_salary { get; set; }

        [DataMember]
        public int total_available_seats { get; set; }

        [DataMember]
        public int general_seat { get; set; }

        [DataMember]
        public int obc_seat { get; set; }

        [DataMember]
        public int sc_seat { get; set; }

        [DataMember]
        public int st_seat { get; set; }

        [DataMember]
        public int opening_home_state_rank { get; set; }

        [DataMember]
        public int closing_home_state_rank { get; set; }

        [DataMember]
        public int general_opening_rank_Gujcat { get; set; }

        [DataMember]
        public int general_closing_rank_Gujcat { get; set; }

        [DataMember]
        public int general_opening_rank_Jee { get; set; }

        [DataMember]
        public int general_closing_rank_Jee { get; set; }

        [DataMember]
        public int obc_opening_rank_Gujcat { get; set; }

        [DataMember]
        public int obc_closing_rank_Gujcat { get; set; }

        [DataMember]
        public int obc_opening_rank_Jee { get; set; }

        [DataMember]
        public int obc_closing_rank_Jee { get; set; }

        [DataMember]
        public int SC_opening_rank_Gujcat { get; set; }

        [DataMember]
        public int SC_closing_rank_Gujcat { get; set; }

        [DataMember]
        public int SC_opening_rank_Jee { get; set; }

        [DataMember]
        public int SC_closing_rank_Jee { get; set; }

        [DataMember]
        public int ST_opening_rank_Gujcat { get; set; }

        [DataMember]
        public int ST_closing_rank_Gujcat { get; set; }

        [DataMember]
        public int ST_opening_rank_Jee { get; set; }

        [DataMember]
        public int ST_closing_rank_Jee { get; set; }
    }
}
