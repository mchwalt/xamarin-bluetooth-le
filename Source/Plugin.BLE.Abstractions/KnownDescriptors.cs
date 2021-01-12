using System;
using System.Collections.Generic;
using System.Linq;

namespace Plugin.BLE.Abstractions
{
    // 16-bit UUID Numbers Document, Revision 2021-1-7
    // Source: https://btprodspecificationrefs.blob.core.windows.net/assigned-values/16-bit%20UUID%20Numbers%20Document.pdf
    public static class KnownDescriptors
    {
        private static readonly Dictionary<Guid, KnownDescriptor> LookupTable;

        static KnownDescriptors()
        {
            LookupTable = Descriptors.ToDictionary(d => d.Id, d => d);
        }

        public static KnownDescriptor Lookup(Guid id)
        {
            return LookupTable.ContainsKey(id) ? LookupTable[id] : new KnownDescriptor(Guid.Empty, "Unknown descriptor");
        }

        private static readonly IList<KnownDescriptor> Descriptors = new List<KnownDescriptor>()
        {
            new KnownDescriptor("00002900-0000-1000-8000-00805f9b34fb", "Characteristic Extended Properties"),
            new KnownDescriptor("00002901-0000-1000-8000-00805f9b34fb", "Characteristic User Description"),
            new KnownDescriptor("00002902-0000-1000-8000-00805f9b34fb", "Client Characteristic Configuration"),
            new KnownDescriptor("00002903-0000-1000-8000-00805f9b34fb", "Server Characteristic Configuration"),
            new KnownDescriptor("00002904-0000-1000-8000-00805f9b34fb", "Characteristic Presentation Format"),
            new KnownDescriptor("00002905-0000-1000-8000-00805f9b34fb", "Characteristic Aggregate Format"),
            new KnownDescriptor("00002906-0000-1000-8000-00805f9b34fb", "Valid Range"),
            new KnownDescriptor("00002907-0000-1000-8000-00805f9b34fb", "External Report Reference"),
            new KnownDescriptor("00002908-0000-1000-8000-00805f9b34fb", "Report Reference"),
            new KnownDescriptor("00002909-0000-1000-8000-00805f9b34fb", "Number of Digitals"),
            new KnownDescriptor("0000290a-0000-1000-8000-00805f9b34fb", "Value Trigger Setting"),
            new KnownDescriptor("0000290b-0000-1000-8000-00805f9b34fb", "Environmental Sensing Configuration"),
            new KnownDescriptor("0000290c-0000-1000-8000-00805f9b34fb", "Environmental Sensing Measurement"),
            new KnownDescriptor("0000290d-0000-1000-8000-00805f9b34fb", "Environmental Sensing Trigger Setting"),
            new KnownDescriptor("0000290e-0000-1000-8000-00805f9b34fb", "Time Trigger Setting"),
            new KnownDescriptor("0000290f-0000-1000-8000-00805f9b34fb", "Complete BR-EDR Transport Block Data"),
        };
    }
}