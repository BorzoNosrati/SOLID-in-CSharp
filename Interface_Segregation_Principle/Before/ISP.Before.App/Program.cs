// See https://aka.ms/new-console-template for more information
using ISP.Before.Printer;

Console.WriteLine("Hello, World!");


var printerA = new PrinterA();
var printerB = new PrinterB();
var printerC = new PrinterC();

printerA.Print();
printerB.Print();
printerC.Print();

printerA.ColorPrint();
printerB.ColorPrint();
printerC.ColorPrint();  //throw exception not applicaple

printerA.Scan();
printerB.Scan();        //throw exception not applicaple
printerC.Scan();        //throw exception not applicaple
