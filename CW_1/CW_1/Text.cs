using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Text : IPrintable
{
    IPrintable[] arrTmp;

    public Text(params IPrintable[] arr) {
        foreach (var item in arr)
        {
            Array.Resize(ref arrTmp, arr.Length);
            Array.Copy(arr, arrTmp, arr.Length);
        }
    }

    public void Print(IPrinter printer) {
        foreach (var item in arrTmp)
        {
            item.Print(printer);
        }
    }
}