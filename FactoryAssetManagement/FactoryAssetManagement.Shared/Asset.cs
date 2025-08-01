using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAssetManagement.Shared
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Status { get; set; } // "Operational", "Maintenance", "Retired"
        public DateTime? LastMaintenanceDate { get; set; }
    }
}
