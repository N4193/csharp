using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {  
       //the array Lenght =  1 + 8 -> buffer[0] + buffer[1] a [8]
       var buffer = new byte[9];
       var (signed, bytes) = reading switch
        {
            > uint.MaxValue => (true, BitConverter.GetBytes(reading)), 
            > int.MaxValue => (false, BitConverter.GetBytes((uint)reading)),
            > ushort.MaxValue => (true, BitConverter.GetBytes((int)reading)),
            >= ushort.MinValue => (false, BitConverter.GetBytes((ushort)reading)),
            >= short.MinValue => (true, BitConverter.GetBytes((short)reading)),
            >= int.MinValue => (true, BitConverter.GetBytes((int)reading)),
            _ => (true, BitConverter.GetBytes(reading)),
        };
        //Console.WriteLine($"if signed = False ({signed}) =>  {bytes.Length} OR"); 
        //Console.WriteLine($"if signed = True  ({signed}) =>  {byte.MaxValue + 1} - {bytes.Length} =  {(byte.MaxValue + 1) - bytes.Length}");

        //buffer[0]->if signed => bytes Length || if not signed => 256 - bytes Length ;
        buffer[0] = (byte)(signed ? byte.MaxValue + 1 - bytes.Length : bytes.Length);
        
        //Console.WriteLine($"{buffer[0]},{buffer[1]},{buffer[2]},{buffer[3]},{buffer[4]},{buffer[5]},{buffer[6]},{buffer[7]},{buffer[8]}");
        //copy from bytes[0]-[7] to  buffer[1]-[8];
        Array.Copy(bytes, 0, buffer, 1, bytes.Length);
        
        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        long FromBuffer = buffer[0] switch
        {
            256 - sizeof(long) => BitConverter.ToInt64(buffer, 1),
            256 - sizeof(int) => BitConverter.ToInt32(buffer, 1),
            256 - sizeof(short) => BitConverter.ToInt16(buffer, 1),
            sizeof(ushort) => BitConverter.ToUInt16(buffer, 1),
            sizeof(uint) => BitConverter.ToUInt32(buffer, 1),
            _ => 0
        };
        return FromBuffer ;
    }
}