using RestaurantSystem.BusinessLogicLayer.Abstract;
using RestaurantSystem.BusinessLogicLayer.Concrete;
using conc=RestaurantSystem.DataAccessLayer.Concrete

using RestaurantSystem.Entity;

Console.WriteLine("-------------RESTAURANT SYSTEM---------");
Console.WriteLine();
AddRestaurant();
Console.WriteLine();
Console.WriteLine("------Restaurants-----");
_restaurantManager.GetAll();



BaseManager






void AddRestaurant()
{
    restoranStart:
    Console.Write("Add Restaurant Name:");
    string name=Console.ReadLine();
    Restaurant restaurant = new Restaurant(name);
    
    _restaurantManager.Create(restaurant);
    Console.WriteLine("Do you wanna add new Restaurant?\n 1.Yes 2.No");
    int choice=Convert.ToInt32(Console.ReadLine());
    if (choice==1)
    {
        goto restoranStart;

    }
}

void AddProduct()
{
    Console.WriteLine("-----Adding product To Restaurant------");
    Console.Write("Write Restaurant Name:");
    string name= Console.ReadLine();


}