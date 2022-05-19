using System;

public class Part2
{
	public Part2()
	{
		int max = 500;
		for (byte i = 0; i < max; i++)
        {
			Console.WriteLine(i);
        }
	}
}

public class Part2Modified
{
	public Part2Modified()
	{
		int max = 500;
		for (byte i = 0; i < max; i++)
		{
			if (i == byte.MaxValue) {
				Console.WriteLine("Iterator has reached the maxvalue! Loop will stop!");
				break;
            }
			Console.WriteLine(i);
		}
	}
}
