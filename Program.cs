// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string s = "45678";
char[] ch = s.ToCharArray();
int sum = 0;
foreach(char c in ch)
{
    //Console.WriteLine(c);
    //Console.WriteLine(Convert.ToInt32(c.ToString()));
    sum += Convert.ToInt32(c.ToString());
}
Console.WriteLine(sum);

int num=2456;
char[] chNums = num.ToString().ToCharArray();
sum = 0;
foreach(char cr in chNums)
{
    sum += Convert.ToInt32(cr.ToString());
}
Console.WriteLine(sum);
