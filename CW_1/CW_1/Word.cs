using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Word : IPrintable
{
    string tmp;

    public Word(string prm) {
        tmp = prm;
    }

    public void Print(IPrinter printer) {
        printer.ShowMessage(tmp);
    }
}