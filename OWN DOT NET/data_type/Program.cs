using System;

class data_type
{
        static void Main(string[] args)
    {
        /*
        //size of different data types 

        //signed 

        //byte
        Console.WriteLine("The size of the byte data type is : " + sizeof(byte)*8 + " bits"); //1
        //sbyte
        Console.WriteLine("The size of the sbyte data type is : " + sizeof(sbyte)*8 + " bits"); //1
        //int
        Console.WriteLine("The size of the int data type is : " + sizeof(int) * 8 + " bits"); //4
        //short
        Console.WriteLine("The size of the short data type is : " + sizeof(short) * 8 + " bits"); //2
        //long
        Console.WriteLine("The size of the long data type is : " + sizeof(long) * 8 + " bits"); // 8
        //float
        Console.WriteLine("The size of the float data type is : " + sizeof(float) * 8 + " bits"); //4
        //double
        Console.WriteLine("The size of the double data type is : " + sizeof(double) * 8 + " bits"); //8
        //decimal
        Console.WriteLine("The size of the decimal data type is : " + sizeof(decimal) * 8 + " bits"); // 16
        //char
        Console.WriteLine("The size of the char data type is : " + sizeof(char) * 8 + " bits"); // 2
        //boolean
        Console.WriteLine("The size of the boolean data type is : " + sizeof(bool) * 8 + " bits"); //1

        //unsigned

        //uint
        Console.WriteLine("The size of the uint data type is : " + sizeof(uint) * 8 + " bits"); //4
        //ushort
        Console.WriteLine("The size of the ushort data type is : " + sizeof(ushort) * 8 + " bits"); //2
        //ulong
        Console.WriteLine("The size of the ulong data type is : " + sizeof(ulong) * 8 + " bits"); //8
        */

        // Min and Max Values Of All Data Types 
        //Signed
        // sbyte 
        Console.WriteLine("Sbyte: Min value : " + sbyte.MinValue + " and Max Value : " + sbyte.MaxValue);
        // short 
        Console.WriteLine("Short: Min value : " + short.MinValue + " and Max Value : " + short.MaxValue);
        //int
        Console.WriteLine("Int: Min value : " + int.MinValue + " and Max Value : " + int.MaxValue);
        //char
        Console.WriteLine("Char: Min value : " + char.MinValue + " and Max Value : " + char.MaxValue);
        //float
        Console.WriteLine("Float: Min value : " + float.MinValue + " and Max Value : " + float.MaxValue);
        //double
        Console.WriteLine("Double: Min value : " + double.MinValue + " and Max Value : " + double.MaxValue);
        //long
        Console.WriteLine("Long: Min value : " + long.MinValue + " and Max Value : " + long.MaxValue);

        // unsigned
        //byte
        Console.WriteLine("Byte: Min value : " + byte.MinValue + " and Max Value : " + byte.MaxValue);
        //uint
        Console.WriteLine("Uint: Min value : " + uint.MinValue + " and Max Value : " + uint.MaxValue);
        //ulong
        Console.WriteLine("Ulong: Min value : " + ulong.MinValue + " and Max Value : " + ulong.MaxValue);
        //ushort
        Console.WriteLine("Ushort: Min value : " + ushort.MinValue + " and Max Value : " + ushort.MaxValue);
        }
}
