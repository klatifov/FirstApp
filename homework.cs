namespace Salary_helper;
class Program
{
    static void Main(string[] args)
    {
        float tax = 0;
        int familyAssitant = 0;
        int moneyForChildren = 0;
        int taxDegree = 0;
        float nettSalary = 0;

        Console.WriteLine("Ümumi əmək haqqı");
        int grossSalary = int.Parse(Console.ReadLine());
        Console.WriteLine("Ailə vəziyyəti (e / E: evli, b / B: subay, d / D: dul)");
        char salutation = char.Parse(Console.ReadLine());
        if (salutation == e || E || d || D)
        { Console.WriteLine("Uşaqların sayı");
            int childrenQuantity = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Əlil olub-olmaması (e / E: bəli, h / N: yox)");
        char disabled = char.Parse(Console.ReadLine());

        //ailə müavinəti
        if (salutation == e || E || d || D)
        {
            grossSalary = grossSalary + 50;
            familyAssitant = grossSalary;
            //uşaq pulu
            if (childrenQuantity != 0)
            {
                for (int i = 0; i <= childrenQuantity; i++)
                {
                    if (i == 1)
                    { grossSalary = grossSalary + 30; }
                    if (i == 2)
                    { grossSalary = grossSalary + 30 + 25; }
                    if (i == 3)
                    { grossSalary = grossSalary + 30 + 25 + 20; }
                    for (int k = 3; k <= childrenQuantity; k++)
                    { grossSalary = grossSalary + 30 + 25 + 20 + 15; }
                    moneyForChildren = grossSalary;
                }
            }
        }
        //gəlir vergisi
        if (grossSalary <= 1000)
        { tax = grossSalary * 15 / 100;
            taxDegree = 15;
        }
        if (grossSalary > 1000 && grossSalary <= 2000)
        { tax = grossSalary * 20 / 100;
            taxDegree = 20;
        }
        if (grossSalary > 2000 && grossSalary <= 3000)
        { tax = grossSalary * 25 / 100;
            taxDegree = 25;
        }
        if (grossSalary > 3000)
        { tax = grossSalary * 30 / 100;
            taxDegree = 30;
        }
        //Əlil işçilər % 50 daha az gəlir vergisi
        if (disabled == e || E)
        { tax = tax / 2;
            taxDegree = taxDegree / 2;
        }
        nettSalary = grossSalary - tax;
        Console.WriteLine("Ailə müavinəti: " + familyAssitant);
        Console.WriteLine("uşaq pulu: " + moneyForChildren);
        Console.WriteLine("gəlir vergisi dərəcəsi: " + taxDegree);
        Console.WriteLine("gəlir vergisinin məbləği: " + tax);
        Console.WriteLine("ümumi əmək haqqı: " + grossSalary);
        Console.WriteLine("xalis əmək haqqı: " + nettSalary);
    }
}
