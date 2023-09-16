
using project_2.DocumentClas;
void Key(byte choose)
{
    Console.Clear();
    if (choose == 1)
    {
        Console.WriteLine("\n\n\t\t\t\t=>basic");
        Console.WriteLine("\t\t\t\tpro");
        Console.WriteLine("\t\t\t\texpert");
    }
    else if (choose == 2)
    {
        Console.WriteLine("\n\n\t\t\t\tbasic");
        Console.WriteLine("\t\t\t\t=>pro");
        Console.WriteLine("\t\t\t\texpert");
    }
    else if (choose == 3)
    {
        Console.WriteLine("\n\n\t\t\t\tbasic");
        Console.WriteLine("\t\t\t\tpro");
        Console.WriteLine("\t\t\t\t=>expert");
    }
}
dynamic select;
byte choose = 1;
Key(choose);
while (true)
{
    select = Console.ReadKey();
    if (select.Key == ConsoleKey.UpArrow)
    {
        if (choose == 1) choose = 3;
        else choose--;
        Key(choose);
    }
    else if (select.Key == ConsoleKey.DownArrow)
    {
        if (choose == 3) choose = 1;
        else choose++;
        Key(choose);
    }
    else if (select.Key == ConsoleKey.Enter)
    {
        DocumentProgram docProgram = new ();//DocumentProgram
        if (choose == 2)//ProDocumentProgram
        {
            docProgram = new ProDocumentProgram();
        }
        else if (choose == 3) //ExpertDocument 
        {
            docProgram = new ExpertDocument();
        }
        docProgram.OpenDocument();
        docProgram.EditDocument();
        docProgram.SaveDocument();

    }
}
