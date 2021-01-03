using System;

namespace Plugin.BLE.Abstractions
{
    public struct KnownCharacteristic
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public KnownCharacteristic(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// KnownCharacteristic
        /// </summary>
        /// <param name="name">name of characteristic</param>
        /// <param name="idAsString">id (guid) of characteristic in form 32 digits separated by hyphens, e.g. "00001811-0000-1000-8000-00805f9b34fb"</param>
        public KnownCharacteristic(string idAsString, string name)
        {
            Id = Guid.ParseExact(idAsString, "d");
            Name = name;
        }
    }
}