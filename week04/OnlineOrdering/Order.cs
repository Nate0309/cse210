public class Order{
    private List<Product> _products;
    private Customer _customer;


    public Order(Customer customer){
        _customer = customer;
    }

    public void AddProduct(Product product){
        if(_products == null){
            _products = new List<Product>();
        }
        _products.Add(product);
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

    public string DisplayShippingLabel(){
        string shippingLabel = $"Shipping Label:\n{_customer.GetCustomer()}";
        return shippingLabel;
    }
}
