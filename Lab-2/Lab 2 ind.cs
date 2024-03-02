using System;

class Complex
{
    
    private dynamic real;
    private dynamic imaginary;

    
    public Complex(dynamic real, dynamic imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
    }

    public static Complex operator -(Complex c1, Complex c2)
    {
        return new Complex(c1.real - c2.real, c1.imaginary - c2.imaginary);
    }

    public static Complex operator *(Complex c1, Complex c2)
    {
        dynamic newReal = c1.real * c2.real - c1.imaginary * c2.imaginary;
        dynamic newImaginary = c1.real * c2.imaginary + c1.imaginary * c2.real;
        return new Complex(newReal, newImaginary);
    }

    
    public override string ToString()
    {
        return $"{real} + {imaginary}i";
    }
}

class Program
{
    static void Main()
    {
        
        Complex c1 = new Complex(2.5, 3.7);
        Complex c2 = new Complex(1, 4);

        
        Complex sum = c1 + c2;
        Console.WriteLine("Сума: " + sum);

        
        Complex difference = c1 - c2;
        Console.WriteLine("Різниця: " + difference);

        
        Complex product = c1 * c2;
        Console.WriteLine("Добуток: " + product);
    }
}
