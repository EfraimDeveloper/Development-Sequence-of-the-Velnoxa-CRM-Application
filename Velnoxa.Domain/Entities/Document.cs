using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Domain.Common;

namespace Velnoxa.Domain.Entities
{
    public class Document:AuditableEntity
    {
        public Guid CompanyId { get; set; }
        public string FileName { get; set; } = string.Empty;

        public string OriginalFileName { get; set; } = string.Empty;

        public string ContentType { get; set; } = string.Empty;

        public long Size { get; set; }

        public string BlobName { get; set; } = string.Empty;

        public  string Folder { get; set; } = string.Empty;

        public Company Company { get; set; } = null!; // Navigation Property
    }
}
