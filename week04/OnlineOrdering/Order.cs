public class Order{
    private List<Product> _products;
    private Customer _customer;


    public Order(Product product, Customer customer){
        _products.Add(product);
        _customer = customer;
    }
        
    public float CalculateTotalCost(){
        float total = 0;
        foreach(Product product in _products){
            total = total + product.CalculateProductCost();
        }
        if(_customer.LiveInUSA() == true){
            total = total + 5;
        }else {
            total = total + 35;
        }
        return total;
    }

    public string DisplayPackingLabel(){
                
        string packingLabel = "Packing Label:\n";

        foreach (Product product in _products){
            packingLabel += $"Product ID: {product.GetProductDetails()}\n";
        }
        
        return packingLabel;
    }
}
