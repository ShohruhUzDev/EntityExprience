using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birgabir
{
    public   class User
    {
        public int Id { get; set; }
        
        public string  Name { get; set; }
        public int CompanyId { get; set; }
        public Company Company  { get; set; }


    }



}
