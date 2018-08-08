using System;

namespace Models.LastMinute
{
    public class Search
    {
        public string sid { get; set; }
        public string website_id { get; set; }
        public string country_code { get; set; }
        public string trips_from_i { get; set; }
        public string trips_to_iat { get; set; }
        public DateTime trips_date { get; set; }
        public int adults { get; set; }
        public int children { get; set; }
        public int infants { get; set; }
        public int search_class { get; set; }
    }
}