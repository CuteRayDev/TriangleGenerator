using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter number: ");
		int num = 0;
		int.TryParse(Console.ReadLine(), out num);
		string result = "\n";
		for (int i = 1; i <= num; i++) // 1 2 3 4 5
		{
			for (int j = 1; j <= i * 2; j += 2) // 1, 1 2
			{
				int numofspace = ((num * 2) - j) / 2;
					for (int x = 1; x <= numofspace; x++)
					{
						result += " ";
					}
				for (int z = 1; z <= j; z ++) 
				{
					if ((z == 1 && j == 1) )
					{
						result += "*";
					}
					else if ((j == (i * 2 - 1) && (z==j || z == 1)) )
					{
						result += ".";
					}
					else if (j == (i * 2 - 1))
					{
						result += "_";
					}
					else if (z == j)
					{
						result += "\\";
					}
					else if (z == 1 )
					{
						result += "/";
					}
					else
					{
						result += " ";
					}
				}
				for (int x = 1; x <= numofspace; x++)
					{
						result += " ";
					}
				result += "\n";
			}

			result += "\n";
		}

		Console.WriteLine(result);
	}
}
