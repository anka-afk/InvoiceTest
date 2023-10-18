using System;

public class InvoiceTest
{
    public static int Main()
    {
        //测试这个程序
        Invoice invoice = new Invoice("1", "齿轮", 100, 15);
        Console.WriteLine(invoice.GetInvoiceAmount(invoice));
        Console.WriteLine("{0},{1},{2},{3}", invoice.Number, invoice.Name, invoice.Amount, invoice.Price);
        invoice.Number = "2";
        invoice.Name = "铁板";
        //合法的更改哦
        invoice.Amount = 1000;
        invoice.Price = 1000;
        Console.WriteLine("{0},{1},{2},{3}",invoice.Number, invoice.Name, invoice.Amount, invoice.Price) ;
        //这是不行的
        invoice.Amount = -1;
        invoice.Price = -1;
        Console.WriteLine("{0},{1},{2},{3}", invoice.Number, invoice.Name, invoice.Amount, invoice.Price);
        return 0;
    }
}
    

public class Invoice
{
    private string number;
    private string name;
    private int amount;
    private decimal price;
    public Invoice(string Number,string Name,int Amount,decimal Price)
    {
        number = Number;
        name = Name;
        amount = Amount;
        price = Price;
    }
    public decimal GetInvoiceAmount(Invoice invoice)
    {
        decimal allPrice = new decimal();
        allPrice = invoice.price * invoice.amount;
        return allPrice;
    }
    public string Number
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
        set { name = value; }
    }
    public int Amount
    {
        get
        {
            return amount;
        }
        set
        {
            if (value >= 0) { amount = value; }
        }
    }
    public decimal Price
    {
        get
        {
            return price;
        }
                set
        {
            if(value >= 0) { price = value;}
        }
    }
}