using System;

namespace Plugin.BLE.Abstractions
{
    public struct KnownDescriptor
    {
        public Guid Id { get; }
        public string Name { get; }

        public KnownDescriptor(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// KnownDescriptor
        /// </summary>
        /// <param name="idAsString">id (guid) of descriptor in form 32 digits separated by hyphens, e.g. "00001811-0000-1000-8000-00805f9b34fb"</param>
        /// <param name="name">name of descriptor</param>
        public KnownDescriptor(string idAsString, string name)
        {
            Id = Guid.ParseExact(idAsString, "d");
            Name = name;
        }
    }
}