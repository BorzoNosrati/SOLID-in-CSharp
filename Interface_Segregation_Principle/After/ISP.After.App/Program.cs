// See https://aka.ms/new-console-template for more information
using ISP.After.Printer;

Console.WriteLine("Hello, World!");


var printerA = new PrinterA();
var printerB = new PrinterB();
var printerC = new PrinterC();

printerA.Print();
printerB.Print();
printerC.Print();

printerA.ColorPrint();
printerB.ColorPrint();
//printerC.ColorPrint();    //printer C does not have ColorPrint() method

printerA.Scan();
//printerB.Scan();          //printer C does not have Scan() method
//printerC.Scan();          //printer C does not have Scan() method

Console.ReadKey();