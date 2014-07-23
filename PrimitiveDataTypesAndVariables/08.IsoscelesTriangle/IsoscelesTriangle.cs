using System;
using System.Text;
class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        char copyRight = '\u00A9';
        int rows = 4;
        int cols = (rows * 2) - 1;


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if(j == rows-i-1)
                    Console.Write(copyRight);
                else if((cols-j)==(rows-i))
                    Console.Write(copyRight);
                else if(i==rows-1)
                {
                    Console.Write( (j%2==0?copyRight:' ') );
                }
                else
                    Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
