using System;


public class Reference {
    
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verse2;


    public string GetBook() {
        return _book;
    }

    public string GetChapter() {
        return _chapter;
    }        

    public string GetVerse() {
        return _verse;
    }


    public Reference() {
        _book = "";
        _chapter = "";
        _verse = "";
        _verse2 = "";
    }

    public Reference(string bookRef, string chapterRef, string verseRef) {
        _book = bookRef;
        _chapter = chapterRef;
        _verse = verseRef;
    }

     public Reference(string bookRef, string chapterRef, string verseRef, string endVerse) {
        _book = bookRef;
        _chapter = chapterRef;
        _verse = verseRef;
        _verse2 = endVerse;
    }
}