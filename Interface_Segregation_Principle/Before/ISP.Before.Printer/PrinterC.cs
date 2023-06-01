namespace ISP.Before.Printer;

public class PrinterC : IPrinter
{
    public void Print() => Console.WriteLine("Print Done.");
    public void ColorPrint() => throw new Exception("Printer C is not a color printer.");
    public void Scan() => throw new Exception("Scan not applicable to printer C.");
}