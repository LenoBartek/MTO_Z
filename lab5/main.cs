using System;
using System.IO;
using System.Text;

namespace lab0
{
    class Hello {         
	static void my_printf(string format_string, string param){
		for(int i=0;i<format_string.Length;i++){
			
			if(format_string[i] == '#'){
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
					for(int k=0; k < param.Length; k++)
					{
						if(param[k] == '1'){
							temp+= "0";
						}
						else if(param[k] == '2'){
							temp+= "1";
						}
						else if(param[k] == '3'){
							temp+= "2";
						}
						else if(param[k] == '4'){
							temp+= "3";
						}
						else if(param[k] == '5'){
							temp+= "4";
						}
						else if(param[k] == '6'){
							temp+= "5";
						}
						else if(param[k] == '7'){
							temp+= "6";
						}
						else if(param[k] == '8'){
							temp+= "7";
						}
						else if(param[k] == '9'){
							temp+= "8";
						}
						else if(param[k] == '0'){
							temp+= "9";
						}
					}

					if(x > param.Length)
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
