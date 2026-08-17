using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Velnoxa.Domain.Common;
using Velnoxa.Domain.Entities;

public class Company:AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string Nif { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public ICollection<Customer> Customers { get; set; } = new List<Customer>(); //Navigation Property

    public ICollection<WhatsAppccount> WhatsAppccounts { get; set; } = new List<WhatsAppccount>();
}