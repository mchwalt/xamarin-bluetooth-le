using System;

namespace Plugin.BLE.Abstractions
{
    public struct KnownService
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public KnownService(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// KnownService
        /// </summary>
        /// <param name="idAsString">id (guid) of service in form 32 digits separated by hyphens, e.g. "00001811-0000-1000-8000-00805f9b34fb"</param>
        /// <param name="name">name of service</param>
        public KnownService(string idAsString, string name)
        {
            Id = Guid.ParseExact(idAsString, "d");
            Name = name;
        }
    }
}