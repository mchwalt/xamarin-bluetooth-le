using System;
using System.Collections.Generic;
using System.Linq;

namespace Plugin.BLE.Abstractions
{
    // 16-bit UUID Numbers Document, Revision 2021-3-24
    // Source: https://btprodspecificationrefs.blob.core.windows.net/assigned-values/16-bit%20UUID%20Numbers%20Document.pdf
    public static class KnownServices
    {
        private static readonly Dictionary<Guid, KnownService> LookupTable;

        static KnownServices()
        {
            LookupTable = Services.ToDictionary(s => s.Id, s => s);
        }

        public static KnownService Lookup(Guid id)
        {
            return LookupTable.ContainsKey(id) ? LookupTable[id] : new KnownService(Guid.Empty, "Unknown Service");
        }

        private static readonly IList<KnownService> Services = new List<KnownService>()
        {
            new KnownService("00001800-0000-1000-8000-00805f9b34fb", "Generic Access"),
            new KnownService("00001801-0000-1000-8000-00805f9b34fb", "Generic Attribute"),
            new KnownService("00001802-0000-1000-8000-00805f9b34fb", "Immediate Alert"),
            new KnownService("00001803-0000-1000-8000-00805f9b34fb", "Link Loss"),
            new KnownService("00001804-0000-1000-8000-00805f9b34fb", "Tx Power"),
            new KnownService("00001805-0000-1000-8000-00805f9b34fb", "Current Time"),
            new KnownService("00001806-0000-1000-8000-00805f9b34fb", "Reference Time Update"),
            new KnownService("00001807-0000-1000-8000-00805f9b34fb", "Next DST Change"),
            new KnownService("00001808-0000-1000-8000-00805f9b34fb", "Glucose"),
            new KnownService("00001809-0000-1000-8000-00805f9b34fb", "Health Thermometer"),
            new KnownService("0000180a-0000-1000-8000-00805f9b34fb", "Device Information"),
            new KnownService("0000180d-0000-1000-8000-00805f9b34fb", "Heart Rate"),
            new KnownService("0000180e-0000-1000-8000-00805f9b34fb", "Phone Alert Status Service"),
            new KnownService("0000180f-0000-1000-8000-00805f9b34fb", "Battery"),
            new KnownService("00001810-0000-1000-8000-00805f9b34fb", "Blood Pressure"),
            new KnownService("00001811-0000-1000-8000-00805f9b34fb", "Alert Notification"),
            new KnownService("00001812-0000-1000-8000-00805f9b34fb", "Human Interface Device"),
            new KnownService("00001813-0000-1000-8000-00805f9b34fb", "Scan Parameters"),
            new KnownService("00001814-0000-1000-8000-00805f9b34fb", "Running Speed and Cadence"),
            new KnownService("00001815-0000-1000-8000-00805f9b34fb", "Automation IO"),
            new KnownService("00001816-0000-1000-8000-00805f9b34fb", "Cycling Speed and Cadence"),
            new KnownService("00001818-0000-1000-8000-00805f9b34fb", "Cycling Power"),
            new KnownService("00001819-0000-1000-8000-00805f9b34fb", "Location and Navigation"),
            new KnownService("0000181a-0000-1000-8000-00805f9b34fb", "Environmental Sensing"),
            new KnownService("0000181b-0000-1000-8000-00805f9b34fb", "Body Composition"),
            new KnownService("0000181c-0000-1000-8000-00805f9b34fb", "User Data"),
            new KnownService("0000181d-0000-1000-8000-00805f9b34fb", "Weight Scale"),
            new KnownService("0000181e-0000-1000-8000-00805f9b34fb", "Bond Management"),
            new KnownService("0000181f-0000-1000-8000-00805f9b34fb", "Continuous Glucose Monitoring"),
            new KnownService("00001820-0000-1000-8000-00805f9b34fb", "Internet Protocol Support"),
            new KnownService("00001821-0000-1000-8000-00805f9b34fb", "Indoor Positioning"),
            new KnownService("00001822-0000-1000-8000-00805f9b34fb", "Pulse Oximeter"),
            new KnownService("00001823-0000-1000-8000-00805f9b34fb", "HTTP Proxy"),
            new KnownService("00001824-0000-1000-8000-00805f9b34fb", "Transport Discovery"),
            new KnownService("00001825-0000-1000-8000-00805f9b34fb", "Object Transfer"),
            new KnownService("00001826-0000-1000-8000-00805f9b34fb", "Fitness Machine"),
            new KnownService("00001827-0000-1000-8000-00805f9b34fb", "Mesh Provisioning"),
            new KnownService("00001828-0000-1000-8000-00805f9b34fb", "Mesh Proxy"),
            new KnownService("00001829-0000-1000-8000-00805f9b34fb", "Reconnection Configuration"),
            new KnownService("0000183A-0000-1000-8000-00805f9b34fb", "Insulin Delivery"),
            new KnownService("0000183B-0000-1000-8000-00805f9b34fb", "Binary Sensor"),
            new KnownService("0000183C-0000-1000-8000-00805f9b34fb", "Emergency Configuration"),
            new KnownService("0000183E-0000-1000-8000-00805f9b34fb", "Physical Activity Monitor"),
            new KnownService("00001843-0000-1000-8000-00805f9b34fb", "Audio Input Control"),
            new KnownService("00001844-0000-1000-8000-00805f9b34fb", "Volume Control"),
            new KnownService("00001845-0000-1000-8000-00805f9b34fb", "Volume Offset Control"),
            new KnownService("00001847-0000-1000-8000-00805f9b34fb", "Device Time"),
            new KnownService("00001846-0000-1000-8000-00805f9b34fb", "Coordinated Set Identification Service"),
            new KnownService("00001848-0000-1000-8000-00805f9b34fb", "Media Control Service"),
            new KnownService("00001849-0000-1000-8000-00805f9b34fb", "Generic Media Control Service"),
            new KnownService("0000184A-0000-1000-8000-00805f9b34fb", "Constant Tone Extension"),
            new KnownService("0000184B-0000-1000-8000-00805f9b34fb", "Telephone Bearer Service"),
            new KnownService("0000184C-0000-1000-8000-00805f9b34fb", "Generic Telephone Bearer Service"),
            new KnownService("0000184D-0000-1000-8000-00805f9b34fb", "Microphone Control"),
            new KnownService("00001910-0000-1000-8000-00805f9b34fb", "Temperature X (???)"),
            new KnownService("00001920-0000-1000-8000-00805f9b34fb", "Acceleration, Orientation X (???)"),
            new KnownService("00001930-0000-1000-8000-00805f9b34fb", "Advertising Interval X (???)"),
            new KnownService("00002b10-0000-1000-8000-00805f9b34fb", "Temperature Y (???)"),
            new KnownService("00002b20-0000-1000-8000-00805f9b34fb", "Acceleration, Orientation Y (???)"),
            new KnownService("00002b30-0000-1000-8000-00805f9b34fb", "Advertising Interval Y (???)"),
            new KnownService("00006006-0000-1000-8000-00805f9b34fb", "Pedometer"),
            new KnownService("0000ff00-0000-1000-8000-00805f9b34fb", "Extension"),
            new KnownService("0000ff90-0000-1000-8000-00805f9b34fb", "Device Config"),
            new KnownService("0000ffa0-0000-1000-8000-00805f9b34fb", "Bluetooth RSSI"),
            new KnownService("0000ffc0-0000-1000-8000-00805f9b34fb", "Password"),
            new KnownService("0000ffe0-0000-1000-8000-00805f9b34fb", "TI SensorTag Smart Keys"), // Read Data From Device, Key information ???
            new KnownService("0000ffe5-0000-1000-8000-00805f9b34fb", "Send Data to Device"),
            new KnownService("713d0000-503e-4c75-ba94-3148f18d941e", "TXRX_SERV_UUID RedBearLabs Biscuit Service"),
            new KnownService("f000aa00-0451-4000-b000-000000000000", "TI SensorTag Infrared Thermometer"),
            new KnownService("f000aa10-0451-4000-b000-000000000000", "TI SensorTag Accelerometer"),
            new KnownService("f000aa20-0451-4000-b000-000000000000", "TI SensorTag Humidity"),
            new KnownService("f000aa30-0451-4000-b000-000000000000", "TI SensorTag Magnometer"),
            new KnownService("f000aa40-0451-4000-b000-000000000000", "TI SensorTag Barometer"),
            new KnownService("f000aa50-0451-4000-b000-000000000000", "TI SensorTag Gyroscope"),
            new KnownService("f000aa60-0451-4000-b000-000000000000", "TI SensorTag Test"),
            new KnownService("f000ccc0-0451-4000-b000-000000000000", "TI SensorTag Connection Control"),
            new KnownService("f000ffc0-0451-4000-b000-000000000000", "TI SensorTag OvertheAir Download"),
        };

    }
}