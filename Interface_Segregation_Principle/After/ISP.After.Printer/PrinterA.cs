namespace ISP.After.Printer;

public class PrinterA : IPrinter, IColorPrinter, IScanPrinter
{
    public void Print() => Console.WriteLine("Print Done.");
    void IColorPrinter.Print() => Console.WriteLine("Color Print Done.");
    public void Scan() => Console.WriteLine("Scan Done.");
}
