#include <stdio.h>
#include <string.h>
#include <ctype.h>

int my_printf(char *format_string, char *param){
	for(int i=0;i<strlen(format_string);i++){
		if((format_string[i] == '#') && (format_string[i+1] == 'k')){
			i++;

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

			printf("%s",param);
		}else
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
