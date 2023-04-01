using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public struct Diary
{
    private List<DateTime> date;
    private List<int> number;
    private List<string> text;
    private List<string> note;
    private int realNumber;

    public Diary() {
        realNumber = 0;
        date = new List<DateTime>();
        number = new List<int>();
        text = new List<string>();
        note = new List<string>();
    }

    public void FillRow(DateTime date, string text, string note) {
        this.date.Add(date);
        this.number.Add(realNumber + 1);
        this.text.Add(text);
        this.note.Add(note);
        realNumber++;
    }

    public void DelRow(int num) {
        int index = number.IndexOf(num);
        date.RemoveAt(index);
        number.RemoveAt(index);
        text.RemoveAt(index);
        note.RemoveAt(index);
        realNumber--;
        for (int i = 0; i < realNumber; i++)
        {
            number[i] = i + 1;
        }
    }

    public void ModRow(int num, DateTime date, string text, string note) {
        this.date[num - 1] = date;
        this.text[num - 1] = text;
        this.note[num - 1] = note;
    }

    public void ModDate(int num, DateTime date) {
        this.date[num - 1] = date;
    }

    public void ModText(int num, string text) {
        this.text[num - 1] = text;
    }

    public void ModNote(int num, string note) {
        this.note[num - 1] = note;
    }

    public void Display() {
        for (int i = 0; i < realNumber; i++)
        {
            Console.WriteLine($"{number[i]} {date[i]} {text[i]} {note[i]}");
        }
    }

    //Clear

    //DownLoad

    //UpLoad

    //UpLoadByDate

    //DownLoadFromFile

    //SortByField

}
