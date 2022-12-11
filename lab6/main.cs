using System;
using System.IO;
using System.Text;

namespace lab0
{
    class Hello {         
	static void my_printf(string format_string, string param){
		for(int i=0;i<format_string.Length;i++){
			
			if(format_string[i] == '#' && format_string[i+i] == '.'){

				i++;
				string strNumber = "";
				int x=0;

				for(int j=i+1; j<format_string.Length;j++)
				{
					if(int.TryParse(format_string[j].ToString(), out x))
					{
						strNumber += format_string[j];
						i++;
					}
					else 
					{
						break;	
					}
				}

				if(format_string[i+1] == 'g' && int.TryParse(strNumber, out x)){
					string temp="";
					string firstChar;
					int num = 0; 
					//string new = str.Substring(0, 1); // "1"

					for (int k=0; i<param.Length;k++)
					{
						firstChar = param.Substring(0, k);

						if (int.TryParse(firstChar, out num))
						{
							num = ((num *9+1)%10);			
						}

						temp = temp + num.ToString();
					}

					if(x >= param.Length)
					{
						string result = new StringBuilder().Insert(0, " ", x-param.Length).ToString();
						result += temp;
						Console.Write(result);
					}
					else if(x < param.Length)
					{
						Console.Write(temp.Substring(0, x));
					}
					else if(x == 0)
					{
						Console.Write(temp);
					}	
				}

				i++;
			}
			else{
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
