// Categories cat = new Categories(10);
// cat.Categorize();
// cat.ShowCats();

Diary d = new Diary();
d.FillRow(new DateTime(2000, 1, 1), "Strong", "SSS");
d.FillRow(new DateTime(2001, 1, 2), "Weak", "CCC");
d.FillRow(new DateTime(2002, 1, 3), "Soft", "AAA");
d.FillRow(new DateTime(2003, 1, 4), "Local", "PPP");
d.Display();
d.DelRow(2);
Console.WriteLine();
d.Display();