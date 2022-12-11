using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

// Порушено принцип розподілення інтерфейсів

interface IPrice
{
    void SetPrice(double price);
}

interface ISales
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}

interface ICloth
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book : IPrice, ISales
{
    private double price;

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine("Promocode is  {0}", promocode);
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine("The size of discount is {0}", discount);
    }
}

class Clothes : IPrice, ICloth, ISales
{
    private double price;
    private byte color;
    private byte size;

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void SetColor(byte color)
    {
        this.color = color;
    }

    public void SetSize(byte size)
    {
        this.size = size;
    }
    
    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine("Promocode is  {0}", promocode);
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine("The size of discount is {0}", discount);
    }
}



class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}