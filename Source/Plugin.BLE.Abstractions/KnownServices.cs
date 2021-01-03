using System;
using System.Collections.Generic;
using System.Linq;

namespace Plugin.BLE.Abstractions
{
    // Source: https://developer.bluetooth.org/gatt/services/Pages/ServicesHome.aspx
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
            new KnownService("00001805-0000-1000-8000-00805f9b34fb", "Current Time Service"),
            new KnownService("00001806-0000-1000-8000-00805f9b34fb", "Reference Time Update Service"),
            new KnownService("00001807-0000-1000-8000-00805f9b34fb", "Next DST Change Service"),
            new KnownService("00001808-0000-1000-8000-00805f9b34fb", "Glucose"),
            new KnownService("00001809-0000-1000-8000-00805f9b34fb", "Health Thermometer"),
            new KnownService("0000180a-0000-1000-8000-00805f9b34fb", "Device Information"),
            new KnownService("0000180d-0000-1000-8000-00805f9b34fb", "Heart Rate"),
            new KnownService("0000180e-0000-1000-8000-00805f9b34fb", "Phone Alert Status Service"),
            new KnownService("0000180f-0000-1000-8000-00805f9b34fb", "Battery Service"),
            new KnownService("00001810-0000-1000-8000-00805f9b34fb", "Blood Pressure"),
            new KnownService("00001811-0000-1000-8000-00805f9b34fb", "Alert Notification Service"),
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
            new KnownService("0000181e-0000-1000-8000-00805f9b34fb", "Bond Management Service"),
            new KnownService("0000181f-0000-1000-8000-00805f9b34fb", "Continuous Glucose Monitoring"),
            new KnownService("00001820-0000-1000-8000-00805f9b34fb", "Internet Protocol Support Service"),
            new KnownService("00001821-0000-1000-8000-00805f9b34fb", "Indoor Positioning"),
            new KnownService("00001822-0000-1000-8000-00805f9b34fb", "Pulse Oximeter Service"),
            new KnownService("00001823-0000-1000-8000-00805f9b34fb", "HTTP Proxy"),
            new KnownService("00001824-0000-1000-8000-00805f9b34fb", "Transport Discovery"),
            new KnownService("00001825-0000-1000-8000-00805f9b34fb", "Object Transfer Service"),
            new KnownService("00001826-0000-1000-8000-00805f9b34fb", "Fitness Machine"),
            new KnownService("00001827-0000-1000-8000-00805f9b34fb", "Mesh Provisioning Service"),
            new KnownService("00001828-0000-1000-8000-00805f9b34fb", "Mesh Proxy Service"),
            new KnownService("00001829-0000-1000-8000-00805f9b34fb", "Reconnection Configuration"),
            new KnownService("00001910-0000-1000-8000-00805f9b34fb", "Temperature X (???)"),
            new KnownService("00001920-0000-1000-8000-00805f9b34fb", "Acceleration, Orientation X (???)"),
            new KnownService("00001930-0000-1000-8000-00805f9b34fb", "Advertising Interval X (???)"),
            new KnownService("00002b10-0000-1000-8000-00805f9b34fb", "Temperature Y (???)"),
            new KnownService("00002b20-0000-1000-8000-00805f9b34fb", "Acceleration, Orientation Y (???)"),
            new KnownService("00002b30-0000-1000-8000-00805f9b34fb", "Advertising Interval Y (???)"),
            new KnownService("00006006-0000-1000-8000-00805f9b34fb", "Pedometer"),
            new KnownService("0000ffe0-0000-1000-8000-00805f9b34fb", "TI SensorTag Smart Keys"),
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