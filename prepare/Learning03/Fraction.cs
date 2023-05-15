using System;

public class Function {
    private int _top;
    private int _bottom;

    public Function() {
        _top = 1;
        _bottom = 1;
    }

    public Function(int wholeNum) {
        _top = wholeNum;
        _bottom = 1;
    }
    
    public Function(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }
    

    public void GetTop() {
        Console.WriteLine(_top);
    }
    public void SetTop(int top) {
        _top = top;
    }
    public void GetBottom() {
        Console.WriteLine(_bottom);
    }
    public void SetBottom(int bottom) {
        _bottom = bottom;
    }
    
    
    
    
    
    
    
    
    
    public string GetFractionString() {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue() {
        return (double)_top / (double)_bottom;
    }

}