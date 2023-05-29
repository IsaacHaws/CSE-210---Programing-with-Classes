using System;


public class Reference {
    
    private string _book;
    private string _chapter;
    private string _verse;


    public void SetBook(string book) {
        _book = book;
    }
    public string GetBook() {
        return _book;
    }


    public void SetChapter(string chapter) {
        _chapter = chapter;
    }
    public string GetChapter() {
        return _chapter;
    }        


    public void SetVerse(string verse) {
        _verse = verse;
    }
    public string GetVerse() {
        return _verse;
    }


    public Reference() {
        _book = "";
        _chapter = "";
        _verse = "";
    }

    public Reference(string bookRef, string chapterRef, string verseRef) {
        _book = bookRef;
        _chapter = chapterRef;
        _verse = verseRef;
    }
}