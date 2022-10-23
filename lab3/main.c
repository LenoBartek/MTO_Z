#include <stdio.h>
#include <string.h>
#include <ctype.h>
#include <stdlib.h>

void swapLetters(char *param);

int my_printf(char *format_string, char *param){
	for(int i=0;i<strlen(format_string);i++){
		if((format_string[i] == '#') && (format_string[i+1] == 'k')){
			i++;
			swapLetters(param);
			printf("%s",param);
		}
		else if((format_string[i] == '#') && (format_string[i+1] == '.'))
		{
			size_t j = i+2;
			char number[60];

			for(size_t counter = 0; format_string[j] >= '0' && format_string[j] <= '9'; ++j, ++counter)
			{
				number[counter] = format_string[j];
			}
				
			if(format_string[j] == 'k')
			{
				size_t amountToPrint = atoi(number);
				if(amountToPrint <= 0 || amountToPrint > strlen(param))
				{
					amountToPrint = strlen(param);
				}

				for(size_t i = 0; i < amountToPrint; ++i)
				{
					printf("%c", param[i]);
				}
			}
			else 
			{
				printf("%s",param);
			}
			i = j;
		}
		else if (format_string[i] == '#' && format_string[i+1] >= '0' && format_string[i+1] <= '9') 
		{
			size_t j = i+1;
			char number[60] = "";

			for(size_t counter = 0; format_string[j] >= '0' && format_string[j] <= '9'; ++j, ++counter)
			{
				number[counter] = format_string[j];
			}

			if(format_string[j] == 'k')
			{
				i = j;
				size_t amountToPrint = atoi(number);
				//printf(" tu: %d tu: ", amountToPrint);
		
				if(amountToPrint <= 0)
				{
					amountToPrint = strlen(param);
					for(size_t i = 0; i < amountToPrint; ++i)
					{
						printf("%c", param[i]);
					}
				}
				else if(amountToPrint < strlen(param))
				{
					for(size_t i = 0; i < amountToPrint; ++i)
					{
						printf("%c", param[i]);
					}
				}
				else if (amountToPrint > strlen(param))
				{
					size_t amountOfSpace = amountToPrint - strlen(param);
					char buff[1024] = "";

					for(size_t i=0; i<amountOfSpace; ++i)
					{
						buff[i] = ' ';
					}
					strcat(buff, param);

					for(size_t i = 0; i < amountToPrint; ++i)
					{
						printf("%c", buff[i]);
					}
				}

				
			}
		}
		else
			putchar(format_string[i]);
	}
	puts("");
}

int main(int argc, char *argv[]){
	char buf[1024],buf2[1024];
	while(gets(buf)){
		gets(buf2);
		my_printf(buf,buf2);
	}
	return 0;
}


void swapLetters(char *param)
{
	for (size_t i = 0; i < strlen(param); ++i)
	{
		if(param[i] >= 65 && param[i] <= 90)
		{
			param[i] = tolower(param[i]);
		}
		else
		{
			param[i] = toupper(param[i]);
		}		
	}	
}