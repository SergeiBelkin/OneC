Console.WriteLine("Enter a");

string entera = Console.ReadLine();
int a = Convert.ToInt32(entera);

Console.WriteLine("Enter b");

string enterb = Console.ReadLine();
int b = Convert.ToInt32(enterb);

Console.WriteLine("Enter c");

string enterc = Console.ReadLine();
int c = Convert.ToInt32(enterc);
int max = a;
if (b>a) max = b;
if (c>b) max = c;


Console.Write(max);