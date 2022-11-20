using System;
using System.IO;

namespace lab0
{
    class Hello {         
	static void my_printf(string format_string, string param){
		for(int i=0;i<format_string.Length;i++){
			if((format_string[i] == '#') && (format_string[i+1] == 'g')){
				
				Int32 original = 0;
				Int32 val = 0;
				if(Int32.TryParse(param, out original)) {
					val = original;
					if(original < 0) {
						val = Math.Abs(original);
					}
					Int64 reverse = 0;
					while (val > 0)
					{
						Int32 r = val % 10;
						reverse = (reverse*10) + Convert.ToInt64(r);
						val = val / 10;
					}
					
					if(original < 0)
					{
						reverse = (reverse * (-1));
					}
					
					Console.Write(reverse);
				}
				else {
					Console.Write("err");
				}

				i++;
			}else{
				Console.Write(format_string[i]);
			}
		}
		Console.Write("\n");
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
