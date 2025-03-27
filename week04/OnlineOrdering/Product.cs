public class Product{
    private string _productName;
    private int _productId;
    private int _quantity;
    private float _price;

    public Product(string productName, int productId, int quantity, float price){
        _productName = productName;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }

    public string GetProductDetails(){
        return $"{_productName}, {_productId}";
    }
    public float CalculateProductCost(){
        float cost = _quantity * _price;
        return cost;
    }

    
}