using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Sign : IPrintable
{
    public char tmp;

    public Sign(char prm) {
        tmp = prm;
    }

    public void Print(IPrinter printer) {
        printer.ShowSign(tmp);
    }
}