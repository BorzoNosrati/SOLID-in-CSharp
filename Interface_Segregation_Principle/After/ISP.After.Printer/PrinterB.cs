namespace ISP.After.Printer;

public class PrinterB : IPrinter, IColorPrinter
{
    public void Print() => Console.WriteLine("Print Done.");
    public void ColorPrint() => Console.WriteLine("Color Print Done.");
}
