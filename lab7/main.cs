using System;
using System.IO;
using System.Text;

namespace lab0
{
    class Hello {         
	static void my_printf(string format_string, string param){
		for(int i=0;i<format_string.Length;i++){

			char c = format_string[i];
			if (c == '#' && i + 1 < format_string.Length && format_string[i + 1] == 'j')
			{
				i += 2;
				int value = Convert.ToInt32(param);
				Console.Write(hex(value));
			}
			else
			{
				Console.Write(c);
			}
            }
			Console.Write("\n");
        }

		public static string hex(int value)
        {
            string hex = value.ToString("X");
            for (int i = 0; i < hex.Length; i++)
            {
                char c = hex[i];
				c = char.ToLowerInvariant(c);

                if (c >= 'a' && c <= 'f')
                {
                    c = (char)(c + 'g' - 'a');
                }
                hex = hex.Substring(0, i) + c + hex.Substring(i + 1);
            }
            return hex;
        }

        static void Main(string[] args)
        {
	    	string format_string;
	   		while ((format_string = Console.ReadLine()) != null)
	    	{
				string param = Console.ReadLine();
				my_printf(format_string,param);
	   		}
        }
    }
}
