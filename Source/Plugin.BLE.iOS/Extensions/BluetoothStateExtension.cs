using CoreBluetooth;
using Plugin.BLE.Abstractions.Contracts;

namespace Plugin.BLE.Extensions
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static class BluetoothStateExtension
    {
        public static BluetoothState ToBluetoothState(this CBCentralManagerState state)
        {
            switch (state)
            {
                case CBCentralManagerState.Unknown:
                    return BluetoothState.Unknown;
                case CBCentralManagerState.Resetting:
                    return BluetoothState.Unknown;
                case CBCentralManagerState.Unsupported:
                    return BluetoothState.Unavailable;
                case CBCentralManagerState.Unauthorized:
                    return BluetoothState.Unauthorized;
                case CBCentralManagerState.PoweredOff:
                    return BluetoothState.Off;
                case CBCentralManagerState.PoweredOn:
                    return BluetoothState.On;
                default:
                    return BluetoothState.Unknown;
            }
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}