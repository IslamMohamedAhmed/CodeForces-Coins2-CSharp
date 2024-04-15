using static System.Console;
using static System.Convert;
using static System.Math;

int n;
string str = "";

n = ToInt32(ReadLine());
if(n == 1)
{
    str += $"{n}";
}
else
{
    str += $"{n} ";
    while (n != 1)
    {

        for(int i = n - 1; i >= 1; i--)
        {
            if (n % i == 0)
            {
                str += $"{i} ";
                n = i; break ;
            }
        }

    }
}

WriteLine(str);
