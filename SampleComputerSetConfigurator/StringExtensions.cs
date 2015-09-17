using System.Linq;

namespace SampleComputerSetConfigurator
{
	public static class StringExtensions
	{
		public static string NormalizeAndAddSequence(this string text, int sequence)
		{
			var chars = text.ToList();

			for (var i = 0; i < chars.Count; i++)
			{
				if (chars[i] == 'ą')
				{
					chars[i] = 'a';
				}

				if (chars[i] == 'ę')
				{
					chars[i] = 'e';
				}

				if (chars[i] == 'ć')
				{
					chars[i] = 'c';
				}

				if (chars[i] == 'ł')
				{
					chars[i] = 'l';
				}

				if (chars[i] == 'ń')
				{
					chars[i] = 'n';
				}

				if (chars[i] == 'ó')
				{
					chars[i] = 'o';
				}

				if (chars[i] == 'ś')
				{
					chars[i] = 's';
				}

				if (chars[i] == 'ż' || chars[i] == 'ź')
				{
					chars[i] = 'z';
				}
			}

			chars.RemoveAll(x => x == ' ');

			return new string(chars.ToArray()) + sequence;
		}
	}
}