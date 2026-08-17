using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velnoxa.Application.DTOs
{
    public class CreateWhatsAppAccountDto
    {
        public Guid CompanyId { get; set; }
        public string PhoneNumber { get; set; }=string.Empty;
        public string PhoneNumberId { get; set; }= string.Empty;    
        public string BusinessAccoundId { get; set; } = string.Empty;   
    }
}
