using DotNETAPI.Models;

namespace DotNETAPI.Services;

public static class PizzaService
{
  static List<Pizza> Pizzas {get;}
  static int nextId = 3;
  static PizzaService()
  {
    Pizzas = new List<Pizza>
    {
      new Pizza { id = 1, Name = "Hawaiian", Description = "Mozzarella, ham, pineapple, and olives on a fresh pizza crust.", ImageUrl = "https://images.unsplash.com/photo-1518791841217-8f162f1e1131?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=800&q=60", Price = 9.99m, isGlutenFree = false },
      new Pizza { id = 2, Name = "Pepperoni", Description = "Mozzarella, pepperoni, and oregano on a fresh pizza crust.", ImageUrl = "https://images.unsplash.com/photo-1518791841217-8f162f1e1131?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=800&q=60", Price = 10.99m, isGlutenFree = false },
    };
  }
  public static List<Pizza> GetAll() => Pizzas;
  public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.id == id);
  public static void Add(Pizza pizza)
  {
    pizza.id = nextId++;
    Pizzas.Add(pizza);
  }
  public static void Delete(int id)
  {
    var pizza = Get(id);
    if(pizza is null)
      return;
    Pizzas.Remove(pizza);
  }
  public static void Update(Pizza pizza)
  {
    var index = Pizzas.FindIndex(p => p.id == pizza.id);
    if(index == -1)
      return;
    Pizzas[index] = pizza;
  }

}