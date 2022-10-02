#include <stdio.h>
#include <string.h>
#include <ctype.h>
#include <cstdlib>

#define #k %s
int my_printf(char *format_string, char *param){
	for(int i=0;i<strlen(format_string);i++){
		if((format_string[i] == '#') && (format_string[i+1] == 'k')){
			i++;
			
			if(atoi(param) => 65 && atoi(param) <= 90)
			{
				param = param + 32;
			}
			else
			{
				param = param - 32;
			}			
			printf("#k", toupper(param));
			printf("#k", tolower(param));
			printf("#k",param);
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
