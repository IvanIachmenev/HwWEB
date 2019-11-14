#include <stdio.h>
#include <stdlib.h>
#include <getopt.h>

int Is_$_in_the_end = 0;
int flag_open = 0;
int Is_number = 0;

int getstr(char s[], int lim, FILE *fp)
{
	int c, i;

	c = fgetc(fp);
	if (c == EOF) return -1;

	for (i = 0; i < lim-1 && c != '\n'; i++)
	{
		s[i] = c;
		c = fgetc(fp);
	}
	if (c == '\n')
	{
		s[i] = '\0';
	}
	return i;
}

void fOutput(FILE *in)
{
	char line[1000];
	int i = 1;

	while ((getstr(line, 1000, in)) != -1) 
	{
		if(Is_number == 1)
		{
			int x[4];
			printf("%i. ",i);
			i++;
		}

		printf("%s",line); 
		
		if( Is_$_in_the_end == 1)
		{
			printf("$");
		}

		printf("\n");
	}
}
int main(int argc, char *argv[])
{
	const char* short_options = "nE";

	const struct option long_options[] = 
	{
        {"show-ends", no_argument, NULL,'E'},
        {"number", no_argument, NULL,'n'},
        {NULL, 0, NULL, 0}
    };


    int rez;
    int option_index = -1;

    while ((rez = getopt_long(argc, argv, short_options, long_options, &option_index)) != -1)
	{
    	printf("%c\n", rez);
        switch(rez)
		{
            case 'E': 
            {
                Is_$_in_the_end = 1;
                break;
            }
            case 'n': 
            {
                Is_number = 1;
                break;
            }
            default: 
            {
                printf("found unknown option\n");
                break;
            }
        }
        option_index = -1;
    }

	FILE *in;
	
	if (argc != 1)
	{
		for (int i = 1; i <= argc; i++)
		{
			in = fopen(argv[i], "r");
			if (in != NULL)
			{
				fOutput(in);
				flag_open = 1;
			}
		}
	}
	if (flag_open == 0)
	{
		in = stdin;
		fOutput(in);
	}
	return 0;
}