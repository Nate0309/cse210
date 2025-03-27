using System.Net.Sockets;

public class Customer{
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }
    
    public bool LiveInUSA(){
        if(_address.inUSA() == true){
        return true;
        }
        return false;
    }

    public string GetCustomer(){
        return $"Name: {_name}\nAddress{_address}";
    }
    
    }