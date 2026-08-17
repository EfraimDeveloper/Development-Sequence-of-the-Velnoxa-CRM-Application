using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Domain.Common;
namespace Velnoxa.Domain.Entities
{
    public class Customer: AuditableEntity
    {
        public Guid CompanyId { get; set; }
        public Company company { get; set; }=null!; //Navigation Property
        public string FirstName { get; set; }=string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Address {get; set; } = string.Empty;

    }
}
