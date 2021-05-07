using System.Collections.Generic;

namespace Dataaloqalar
{
    public class Country
    {
        public int Id { get; set; }
        public string  Name    { get; set; }
        public List<Company> Users { get; set; } = new List<Company>();
    }



}
