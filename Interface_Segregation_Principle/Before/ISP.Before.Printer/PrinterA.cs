namespace ISP.Before.Printer;

public class PrinterA : IPrinter
{
    public void Print() => Console.WriteLine("Print Done.");
    public void ColorPrint() => Console.WriteLine("Color Print Done.");
    public void Scan() => Console.WriteLine("Scan Done.");
}
