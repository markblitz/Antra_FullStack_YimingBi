// See https://aka.ms/new-console-template for more information
sbyte[] sbyte_info = { sizeof(sbyte), sbyte.MaxValue, sbyte.MinValue };
byte[] byte_info = { sizeof(byte), byte.MaxValue, byte.MinValue };
short[] short_info = { sizeof(short), short.MaxValue, short.MinValue };
ushort[] ushort_info = { sizeof(ushort), ushort.MaxValue, ushort.MinValue };
int[] int_info = { sizeof(int), int.MaxValue, int.MinValue };
uint[] uint_info = { sizeof(uint), uint.MaxValue, uint.MinValue };
long[] long_info = { sizeof(long), long.MaxValue, long.MinValue };
ulong[] ulong_info = { sizeof(ulong), ulong.MaxValue, ulong.MinValue };
float[] float_info = { sizeof(float), float.MaxValue, float.MinValue };
double[] double_info = { sizeof(double), double.MaxValue, double.MinValue };
decimal[] decimal_info = { sizeof(decimal), decimal.MaxValue, decimal.MinValue };

Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-40} {3,-20}", "Type:sbyte", $"Size:{sbyte_info[0]}", $"MaxValue:{sbyte_info[1]}", $"MinValue:{sbyte_info[2]}"));
Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-40} {3,-20}", "Type:byte", $"Size:{byte_info[0]}", $"MaxValue:{byte_info[1]}", $"MinValue:{byte_info[2]}"));
Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-40} {3,-20}", "Type:short", $"Size:{short_info[0]}", $"MaxValue:{short_info[1]}", $"MinValue:{short_info[2]}"));
Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-40} {3,-20}", "Type:ushort", $"Size:{ushort_info[0]}", $"MaxValue:{ushort_info[1]}", $"MinValue:{ushort_info[2]}"));
Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-40} {3,-20}", "Type:int", $"Size:{int_info[0]}", $"MaxValue:{int_info[1]}", $"MinValue:{int_info[2]}"));
Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-40} {3,-20}", "Type:uint", $"Size:{uint_info[0]}", $"MaxValue:{uint_info[1]}", $"MinValue:{uint_info[2]}"));
Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-40} {3,-20}", "Type:long", $"Size:{long_info[0]}", $"MaxValue:{long_info[1]}", $"MinValue:{long_info[2]}"));
Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-40} {3,-20}", "Type:ulong", $"Size:{ulong_info[0]}", $"MaxValue:{ulong_info[1]}", $"MinValue:{ulong_info[2]}"));
Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-40} {3,-20}", "Type:float", $"Size:{float_info[0]}", $"MaxValue:{float_info[1]}", $"MinValue:{float_info[2]}"));
Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-40} {3,-20}", "Type:double", $"Size:{double_info[0]}", $"MaxValue:{double_info[1]}", $"MinValue:{double_info[2]}"));
Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-40} {3,-20}", "Type:decimal", $"Size:{decimal_info[0]}", $"MaxValue:{decimal_info[1]}", $"MinValue:{decimal_info[2]}"));