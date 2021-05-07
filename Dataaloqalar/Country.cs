using System.Collections.Generic;

namespace Dataaloqalar
{
    public class Country
    {
        public int Id { get; set; }
        public string  Name    { get; set; }
       
        public int CityId { get; set; }
        public City City  { get; set; }
        public List<Company> Companies { get; set; } = new List<Company>();

    }


}
