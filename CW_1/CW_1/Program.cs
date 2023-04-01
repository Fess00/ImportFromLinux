using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

Sign sign = new Sign('1');
sign.Print(new PrinterDefault());
Console.WriteLine();

Text txt = new Text(
	new Word("Тестируем"), new Sign(' '),
	new Word("мою"), new Sign(' '),
	new Word("архитектуру"), new Sign('!'));
txt.Print(new PrinterDefault());
Console.WriteLine();
txt.Print(new PrinterSpecial());
Console.WriteLine();

Word word = new Word("Work!");
PrinterDelegateDefaullt a = new PrinterDelegateDefaullt();
a.Print(txt);
Console.WriteLine();
txt.Print(a);
Console.WriteLine();
