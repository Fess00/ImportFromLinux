using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class PrinterSpecial : PrinterDefault
{
    public PrinterSpecial() {}

    public override void ShowMessage(string message) {
        Console.Write("(" + message + ")");
    }

    public override void ShowSign(char message) {
        Console.Write(message);
    }
}