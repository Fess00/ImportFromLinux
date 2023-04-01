using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class PrinterDelegateDefaullt : IPrinterDelegate
{

    public virtual void ShowMessage(string message) {
        Console.Write(message);
    }

    public virtual void ShowSign(char message) {
        Console.Write(message);
    }

    public void Print(IPrintable ptb) {
        ptb.Print(this);
    }
}