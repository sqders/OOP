using System;

namespace ConsoleApp2
{
    
    class A{}
    class Phone
    {
        public long number { get; set; }
        public static implicit operator Phone(long x)
        {
            return new Phone { number = x };
        }
        public static explicit operator long(Phone phone)
        {
            return phone.number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                // неявные преобразования
                // Таблица неявных преобразований базовых типов
                //Тип ||В какие типы безопасно преобразуется
                //byte ||short, ushort, int, uint, long, ulong, float, double, decimal
                //sbyte ||short, int, long, float, double, decimal
                //short ||int, long, float, double, decimal
                //ushort ||int, uint, long, ulong, float, double, decimal
                //int ||long, float, double, decimal
                //uint ||long, ulong, float, double, decimal
                //long ||float, double, decimal
                //ulong ||float, double, decimal
                //float ||double
                //char ||ushort, int, uint, long, ulong, float, double, decimal
                //Также любой базовый тип можно неявно преобразовать в ссылочный
                byte byte_var = 0;
                {
                    char char_byte = byte_var;
                    short short_byte = byte_var;
                    ushort ushort_byte = byte_var;
                    int int_byte = byte_var;
                    uint uint_byte = byte_var;
                    long long_byte = byte_var;
                    ulong ulong_byte = byte_var;
                    float float_byte = byte_var;
                    double double_byte = byte_var;
                    decimal decimal_byte = byte_var;
                }
                sbyte sbyte_var = -1;
                {
                    short short_sbyte = sbyte_var;
                    int int_sbyte = sbyte_var;
                    long long_sbyte = sbyte_var;
                    float float_sbyte = sbyte_var;
                    double double_sbyte = sbyte_var;
                    decimal decimal_sbyte_ = sbyte_var;
                }
                short short_var = 1;
                {
                    int int_short = short_var;
                    long long_short = short_var;
                    float float_short = short_var;
                    double double_short = short_var;
                    decimal decimal_short = short_var;
                }
                ushort ushort_var = 2;
                {
                    int int_ushort = ushort_var;
                    uint uint_ushort = ushort_var;
                    long long_ushort = ushort_var;
                    ulong ulong_ushort = ushort_var;
                    float float_ushort = ushort_var;
                    double double_ushort = ushort_var;
                    decimal decimal_ushort = ushort_var;
                }
                int int_var = 3;
                {
                    long long_int = int_var;
                    float float_int = int_var;
                    double double_int = int_var;
                    decimal decimal_int = int_var;
                }
                uint uint_var = 3;
                {
                    long long_uint = uint_var;
                    ulong ulong_uint = uint_var;
                    float float_uint = uint_var;
                    double double_uint = uint_var;
                    decimal decimal_uint = uint_var;
                }
                long long_var = 9223372036854775807;
                {
                    float float_long = long_var;
                    double double_long = long_var;
                    decimal decimal_long = long_var;
                }
                ulong ulong_var = 4;
                {
                    float float_ulong = ulong_var;
                    double double_ulong = ulong_var;
                    decimal decimal_ulong = ulong_var;
                }
                float float_var = 5;
                {
                    double double_float = float_var;
                }
                char char_var = 'a';
                {
                    ushort ushort_char = char_var;
                    int int_char = char_var;
                    uint uint_char = char_var;
                    long long_char = char_var;
                    ulong ulong_char = char_var;
                    float float_char = char_var;
                    double double_char = char_var;
                    decimal decimal_char = char_var;
                }
                //Неявное преобразование
                //Исходный тип    Кому
                //sbyte   ||byte, ushort, uint или ulong либо nuint
                //byte    ||sbyte
                //short   ||sbyte, byte, ushort, uint, ulong или nuint
                //ushort  ||sbyte, byteили short
                //int     ||sbyte, byte, short, ushort, uint, ulong или nuint
                //uint    ||sbyte, byte, short, ushort или int
                //long    ||sbyte, byte, short, ushort, int, uint, ulong, nint или nuint
                //ulong   ||sbyte, byte, short, ushort, int, uint, long, nint или nuint
                //float   ||sbyte, byte, short, ushort, int, uint, long, ulong, decimal, nint или nuint
                //double  ||sbyte, byte, short, ushort, int, uint, long, ulong, float, decimal, nint или nuint
                //decimal ||sbyte, byte, short, ushort, int, uint, long, ulong, float, double, nint или nuint
                try
                {
                    sbyte sbute_byte = (sbyte)byte_var;
                }
            catch (OverflowException)
            {
                Console.WriteLine("Byte OverflowException");
            }
            try
                {
                    byte byte_sbyte = (byte)sbyte_var;
                    ushort ushort_sbyte = (ushort)sbyte_var;
                    uint uint_sbyte = (uint)sbyte_var;
                    ulong ulong_sbyte = (ulong)sbyte_var;
                }
            catch (OverflowException)
            {
                Console.WriteLine("Sbyte OverflowException");
            }
            try
                {
                    sbyte sbyte_short = (sbyte)short_var;
                    byte byte_short = (byte)short_var;
                    ushort ushort_short = (ushort)short_var;
                    uint uint_short = (uint)short_var;
                    ulong ulong_short = (ulong)short_var;
                }
            catch (OverflowException)
            {
                Console.WriteLine("Short OverflowException");
            }
            try
                {
                    sbyte sbyte_ushort = (sbyte)ushort_var;
                    byte byte_ushort = (byte)ushort_var;
                    short short_ushort = (short)ushort_var;
                }
            catch (OverflowException)
            {
                Console.WriteLine("Ushort OverflowException");
            }
            try
                {
                    sbyte sbyte_int = (sbyte)int_var;
                    byte byte_int = (byte)int_var;
                    short short_int = (short)int_var;
                    ushort ushort_int = (ushort)int_var;
                    uint uint_int = (uint)int_var;
                    ulong ulong_int = (ulong)int_var;
                }
            catch (OverflowException)
            {
                Console.WriteLine("Int OverflowException");
            }
            try
                {
                    sbyte sbyte_uint = (sbyte)uint_var;
                    byte byte_uint = (byte)uint_var;
                    short short_uint = (short)uint_var;
                    ushort ushort_uint = (ushort)uint_var;
                    int int_uint = (int)uint_var;
                }
            catch (OverflowException)
            {
                Console.WriteLine("Uint OverflowException");
            }
            try
                {
                    sbyte sbyte_long = (sbyte)long_var;
                    byte byte_long = (byte)long_var;
                    short short_long = (short)long_var;
                    ushort ushort_long = (ushort)long_var;
                    int int_long = (int)long_var;
                    uint uint_long = (uint)long_var;
                    ulong ulong_long = (ulong)long_var;
                }
            catch (OverflowException)
            {
                Console.WriteLine("Long OverflowException");
            }
            try
                {
                    sbyte sbyte_ulong = (sbyte)ulong_var;
                    byte byte_ulong = (byte)ulong_var;
                    short short_ulong = (short)ulong_var;
                    ushort ushort_ulong = (ushort)ulong_var;
                    int int_ulong = (int)ulong_var;
                    uint uint_ulong = (uint)ulong_var;
                    long long_ulong = (long)ulong_var;
                }
            catch (OverflowException)
            {
                Console.WriteLine("Ulong OverflowException");
            }
            try
                {
                    sbyte sbyte_float = (sbyte)float_var;
                    byte byte_float = (byte)float_var;
                    short short_float = (short)float_var;
                    ushort ushort_float = (ushort)float_var;
                    int int_float = (int)float_var;
                    uint uint_float = (uint)float_var;
                    long long_float = (long)float_var;
                    ulong ulong_float = (ulong)float_var;
                    decimal decimal_float = (decimal)float_var;
                }
            catch (OverflowException)
            {
                Console.WriteLine("Float OverflowException");
            }
            double double_var = 3.14;
            try
                {
                    sbyte sbyte_double = (sbyte)double_var;
                    byte byte_double = (byte)double_var;
                    short short_double = (short)double_var;
                    ushort ushort_double = (ushort)double_var;
                    int int_double = (int)double_var;
                    uint uint_double = (uint)double_var;
                    long long_double = (long)double_var;
                    ulong ulong_double = (ulong)double_var;
                    decimal decimal_double = (decimal)double_var;
                    float float_double = (float)double_var;
                }
            catch (OverflowException)
            {
                Console.WriteLine("Double OverflowException");
            }
                decimal decimal_var = 1000000000000000M;
            try
                {
                    sbyte sbyte_decimal = (sbyte)decimal_var;
                    byte byte_decimal = (byte)decimal_var;
                    short short_decimal = (short)decimal_var;
                    ushort ushort_decimal = (ushort)decimal_var;
                    int int_decimal = (int)decimal_var;
                    uint uint_decimal = (uint)decimal_var;
                    long long_decimal = (long)decimal_var;
                    ulong ulong_decimal = (ulong)decimal_var;
                    float float_decimal = (float)decimal_var;
                }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Преобразование ссылочных типов
            //Неявное преобразование переменных ссылочных типов допускается к любому базовому типу, 
            //или к любому интерфейсу, который реализует тип переменной или любой базовый тип этой переменной.
            object o;
            string string_var = "aaa";
            {
                o = string_var;
                o = byte_var;
                o = char_var;
                o = decimal_var;
                o = double_var;
                o = float_var;
                o = int_var;
                o = long_var;
                o = sbyte_var;
                o = short_var;
                o = uint_var;
                o = ulong_var;
                o = ushort_var;
            }
            //Явное преобразование ссылочного типа
            o = new A();
            A a1 = (A)o;
            //Приведение с помощью операторов is и as
            //Оператор is проверяет принадлежность объекта к заданному типу
            if(o is A)
            {
                A a2 =(A) o;
            }
            //Оператор as проверяет можно ли преобразовать и преобразует если можно либо если нельзя возвращает null
            A a = o as A;
            //Пользовательское явное и неявное преобразование 
            Phone phone = 88005553535;
            long long_num = phone.number;
            long_num = (long)phone.number;
            //Преобразование при помощи класса Convert
            int value = 11;
            try
            {
                Convert.ToBoolean(value);
                Convert.ToByte(value);
                Convert.ToChar(value);
                Convert.ToDateTime(value);
                Convert.ToDecimal(value);
                Convert.ToDouble(value);
                Convert.ToInt16(value);
                Convert.ToInt32(value);
                Convert.ToInt64(value);
                Convert.ToSByte(value);
                Convert.ToSingle(value);
                Convert.ToUInt16(value);
                Convert.ToUInt32(value);
                Convert.ToUInt64(value);
            }catch(InvalidCastException)
            {
                Console.WriteLine("Convert Exception");
            }
            //Преобразование строки при помощи метода Parse
            {
                byte byte_str= byte.Parse("128");
                char char_str=char.Parse("9");
                decimal decimal_str = decimal.Parse("0,1010");
                double double_str = double.Parse("3,14");
                float float_str = float.Parse("213");
                int int_str = int.Parse("89980");
                long long_str = long.Parse("88005553535");
                sbyte sbyte_str = sbyte.Parse("-1");
                short short_str = short.Parse("-32");
                uint uint_str = uint.Parse("12");
                ulong ulong_str = ulong.Parse("9820980");
                ushort ushort_str = ushort.Parse("0999");
            }
            //преобразовнаие строки при помощи метода TryParse
            {
                bool result ;
                result = byte.TryParse("128", out byte_var);
                result = char.TryParse("932", out char_var);
                result = decimal.TryParse("0,1010", out decimal_var);
                result = double.TryParse("3,14", out double_var);
                result = float.TryParse("213", out float_var);
                result = int.TryParse("89980", out int_var);
                result = long.TryParse("88005553535", out long_var);
                result = sbyte.TryParse("-1", out sbyte_var);
                result = short.TryParse("-32", out short_var);
                result = uint.TryParse("12", out uint_var);
                result = ulong.TryParse("9820980", out ulong_var);
                result = ushort.TryParse("0999", out ushort_var);
            }
        }

    }
}
