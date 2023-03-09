using ConsoleApp1.DB;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static GoodsContext _ef;
    private static void Main(string[] args)
    {
        _ef = new GoodsContext();

        _ef.Database.Migrate();

        Console.WriteLine($"Can connect to db: {_ef.Database.CanConnect()}");

        var find_category = _ef.Category.FirstOrDefault(x => x.Name == "Снэки");

        if (find_category == null)
        {
            find_category = new Category() { Name = "Снэки" };
        }
        //Good good = new Good()
        //{
        //    Name = "Чипсы",
        //    Price = 199.0,
        //    Sale = 0.50,
        //    Category = find_category
        //};
        //_ef.Add(good);
        //_ef.SaveChanges();
        foreach (var item in _ef.Goods.ToList())
        {
            double total_price = item.Price - item.Sale;
            Console.WriteLine($"{item.Name}," + 
                $" cтоимость с учетом скидки: {total_price} руб.");
        }
        foreach (var item in _ef.Category.ToList())
        {
            Console.WriteLine(item.Name);
        }

        //Category category = new Category() { Name = "Снеки"};

        //_ef.Category.Add(category);
        //_ef.SaveChanges();
    }
}