using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IPrinterDelegate : IPrinter
{
    public void Print(IPrintable ptb);
}