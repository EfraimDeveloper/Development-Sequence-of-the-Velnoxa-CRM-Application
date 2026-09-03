using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Domain.Common;

namespace Velnoxa.Domain.Entities
{
    public class WhatsAppccount:AuditableEntity
    {
        public Guid CompanyId { get; set; }  //Foreign Key para Company.

        public Company Company { get; set; } = null!;  //Navigation Property.

        public string PhoneNumber { get; set; } = string.Empty;

        public string phoneNumberId { get; set; } = string.Empty;

        public string businessAccountId { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;


    }
}
