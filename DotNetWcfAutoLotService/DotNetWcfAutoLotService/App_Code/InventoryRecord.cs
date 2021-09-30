using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

/// <summary>
/// Summary description for InventoryRecord
/// </summary>
[DataContract]
public class InventoryRecord
{
    [DataMember]
    public int ID { get; set; }

    [DataMember]
    public string Make { get; set; }

    [DataMember]
    public string Color { get; set; }

    [DataMember]
    public string PetName { get; set; }
}