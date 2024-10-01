public string customerName { get; set; }
public string orderDate { get; set; }
public Desk desk { get; set; }
public string shippingDays { get; set; }
public double price { get; set; }
public DeskQuote()
{
    customerName = string.Empty;
    orderDate = DateTime.Empty;
    desk = new Desk();
    price = double.Empty;
    
}