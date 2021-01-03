using System;
using System.Runtime.InteropServices;

namespace BLE.Client.Converters
{
    public class ByteHandler
    {
        /// <summary>
        /// Get Byte Array from any object; 
        /// Hint: for standard types as int, float ,etc, use BitConverter.GetBytes().
        /// </summary>
        /// <param name="str">instance of object to transform</param>
        /// <returns>byte array of given object, empty array for null objects</returns>
        public static byte[] GetBytes(object str)
        {
            if (str == null)
                return new byte[] { };  // return empty byte array for null objects
            
            if (str.GetType() == typeof(byte[]))
                return (byte[])str;     // return given object directly back, because it is already a byte array

            int size = Marshal.SizeOf(str);
            byte[] arr = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.StructureToPtr(str, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);

            return arr;
        }

        /// <summary>
        /// Transform byte array to given type T; 
        /// Hint: for type 'string', System.Text.Encoding.UTF8.GetString(byte[] arr) can be used as well
        /// </summary>
        /// <typeparam name="T">the type of object</typeparam>
        /// <param name="arr">the byte array as source</param>
        /// <param name="idx">the start index in the byte array to begin copying from</param>
        /// <param name="cnt">the amount of bytes to use</param>
        /// <returns>an instance of type T</returns>
        public static T FromBytes<T>(byte[] arr, int idx = 0, int cnt = 0)
        {
            T str = default(T); // set to 0 (value type) or null (reference type)

            if (cnt == 0)
                cnt = arr.Length;

            IntPtr ptr = Marshal.AllocHGlobal(cnt);

            Marshal.Copy(arr, idx, ptr, cnt);

            str = (T)Marshal.PtrToStructure(ptr, typeof(T));
            Marshal.FreeHGlobal(ptr);

            return str;
        }

        /// <summary>
        /// Determines the size of given data object
        /// </summary>
        /// <param name="str">the object</param>
        /// <returns>size of object in bytes</returns>
        public static int SizeOf(object str)
        {
            if (str == null)
                return 0;
            if (str.GetType() == typeof(byte[]))
                return ((byte[])str).Length;    // return length of given object directly back, because it is already a byte array

            return Marshal.SizeOf(str);
        }

        /// <summary>
        /// Estimate/guess content of a byte array by it's length and return presumed content as string.
        /// </summary>
        /// <param name="arr">the byte array as source</param>
        /// <param name="value">return the value for the guessed data-type</param>
        /// <returns>the presumed content of the byte-arry as string</returns>
        public static string PresumedContentToString(byte[] arr)
        {
            if (arr == null || arr.Length == 0)
                return "undefined";

            try
            {
                switch (arr.Length)
                {
                    case 1: // possible one byte types: byte, one byte ASCII char, 8 Bits (2 Nibbles H L)
                        return $"{arr[0]} : '{System.Text.Encoding.ASCII.GetString(arr)}'" +
                            $" : {Convert.ToString(arr[0] >> 4, 2).PadLeft(4, '0')} {Convert.ToString(arr[0] & 0x0F, 2).PadLeft(4, '0')}";

                    case 2: // possible two byte types: short (int16), ushort(uint16), char, 16 Bits (4 nibbles HH HL LH LL)
                        return $"{BitConverter.ToInt16(arr, 0)} : {BitConverter.ToUInt16(arr, 0)} : '{BitConverter.ToChar(arr, 0)}'" +
                            $" : {Convert.ToString(arr[1] >> 4, 2).PadLeft(4, '0')} {Convert.ToString(arr[1] & 0x0F, 2).PadLeft(4, '0')}" +
                            $" {Convert.ToString(arr[0] >> 4, 2).PadLeft(4, '0')} {Convert.ToString(arr[0] & 0x0F, 2).PadLeft(4, '0')}";

                    case 4: // possible four byte types: integer(int32, uint32), Single(float), string, 32 Bits
                        return $"{BitConverter.ToInt32(arr, 0)}:{BitConverter.ToUInt32(arr, 0)} : {BitConverter.ToSingle(arr, 0)} : '{System.Text.Encoding.UTF8.GetString(arr)}'" +
                            $" : {Convert.ToString(BitConverter.ToInt32(arr, 0), 2).PadLeft(32, '0')}";

                    case 8: // possible eight byte types: long (int64, uint64), Double, string, 64 Bits
                        return $"{BitConverter.ToInt64(arr, 0)} : {BitConverter.ToUInt64(arr, 0)} : {BitConverter.ToDouble(arr, 0)} : '{System.Text.Encoding.UTF8.GetString(arr)}'" +
                            $" : {Convert.ToString(BitConverter.ToInt64(arr, 0), 2).PadLeft(64, '0')}";

                    case 10: // possible ten byte types: time-stamp, string
                        return $"{GetTimeString(arr)}" +
                            $" : '{System.Text.Encoding.UTF8.GetString(arr)}'";

                    default: // all other byte-arry lengths: no number format can be guessed - try string
                        return $"'{System.Text.Encoding.UTF8.GetString(arr)}'";
                }
            }
            catch
            {
                return "indeterminate";
            }
        }

        /// <summary>
        /// returns timestamp in form 'yyyy-MM-ddTHH:mm:ss'
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static string GetTimeString(byte[] arr)
        {
            return $"{BitConverter.ToInt16(arr, 0)}" +      // yyyy
                $"-{arr[2].ToString().PadLeft(2, '0')}" +   // MM
                $"-{arr[3].ToString().PadLeft(2, '0')}" +   // DD
                $"T{arr[4].ToString().PadLeft(2, '0')}" +   // HH
                $":{arr[5].ToString().PadLeft(2, '0')}" +   // mm
                $":{arr[6].ToString().PadLeft(2, '0')}";    // ss
                // arr[7-9]                           // ???
        }
    }
}
