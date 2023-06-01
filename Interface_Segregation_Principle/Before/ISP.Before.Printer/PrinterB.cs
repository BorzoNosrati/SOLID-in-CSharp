namespace ISP.Before.Printer;

public class PrinterB : IPrinter
{
    public void Print() => Console.WriteLine("Print Done.");
    public void ColorPrint() => Console.WriteLine("Color Print Done.");
    public void Scan() => throw new Exception("Scan not applicable to printer B.");
}
