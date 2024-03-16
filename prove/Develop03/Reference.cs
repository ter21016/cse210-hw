using System;
using System.ComponentModel;

public class Reference 
{
  private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string reference)
    {
        string[] parts = reference.Split(' ');
        _book = parts[0];

        string[] chapterVerse = parts[1].Split(':');
        _chapter = int.Parse(chapterVerse[0]);

        if (chapterVerse[1].Contains("-"))
        {
            string[] verses = chapterVerse[1].Split('-');
            _verse = int.Parse(verses[0]);
            _endVerse = int.Parse(verses[1]);
        }
        else
        {
            _verse = int.Parse(chapterVerse[1]);
            _endVerse = null;
        }
    }

    public string GetDisplayText()
    {
        if (_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}