using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class PrinterDefault : IPrinter
{

    public PrinterDefault() {
        
    }

    public virtual void ShowMessage(string message) {
        Console.Write(message);
    }

    public virtual void ShowSign(char message) {
        Console.Write(message);
    }
}
