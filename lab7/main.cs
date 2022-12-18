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
				i += 2; // Przeskakujemy dwa znaki ('#' i 'j')
				int value = (int)param[0]; // Pobieramy wartość liczby szesnastkowej z listy argumentów
				Console.Write(hex(value)); // Drukujemy zamienioną liczbę szesnastkową
				param = param.Skip(1).ToArray(); // Usuwamy pierwszy element z listy argumentów
			}
			// else if (c == '%') // Jeśli napotkamy znak '%', to sprawdzamy, czy następny znak to 'x'
			// {
			//     i++; // Przeskakujemy znak '%'
			//     if (i < format_string.Length && format_string[i] == 'x')
			//     {
			//         int value = (int)args[0]; // Pobieramy wartość liczby szesnastkowej z listy argumentów
			//         Console.Write(hex(value)); // Drukujemy zamienioną liczbę szesnastkową
			//         args = args.Skip(1).ToArray(); // Usuwamy pierwszy element z listy argumentów
			//     }
			// }
			else // Jeśli to zwykły znak, to drukujemy go bez zmian
			{
				Console.Write(c);
			}
            }
			Console.Write("\n");
        }

		public static string hex(int value)
        {
            // Zamieniamy liczbę szesnastkową na string i iterujemy po każdym znaku
            string hex = value.ToString("X");
            for (int i = 0; i < hex.Length; i++)
            {
                char c = hex[i];
                // Zamieniamy cyfry a-f na g-l
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
