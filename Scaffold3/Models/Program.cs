using Scaffold3.Data;
using System.Linq;

namespace Scaffold3.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MasterContext _Context = new MasterContext();

                var Catigories = _Context.Categories.ToList();

                //foreach (var cat in Catigories) 
                //{
                //    Console.WriteLine($"Id={cat.CategoryId},Name ={cat.CategoryName}");
                //}

                //var Custmor= _Context.Customers.Where(e => e.State =="NY" ||e.State == "CA");
                //var Custmor = _Context.Customers.Where(e=>e.Email.Contains("@yahoo.com")).OrderBy(e=>e.FirstName).ThenByDescending(e=>e.LastName).Take(5);

                //var Custmor = _Context.Customers.Where(e => e.State == "NY" || e.State == "CA").Select(e=> new
                //{
                //    e.CustomerId,
                //    e.FirstName,
                //    e.LastName,
                //    e.Email,
                //    e.State

                //}
                 //foreach (var cust in Custmor)
                                //{
                                //    Console.WriteLine($"Id={cust.CustomerId},Name ={cust.FirstName},state={cust.State},Email={cust.Email}");
                                //}



                var products = _Context.Products.GroupBy(e => e.ModelYear).Select(e => new

                {
                    ModelYear = e.Key,
                    Count=e.Count()

                }
                ) ;

                foreach ( var product in products ) 
                {
                    Console.WriteLine( $"Grop={product.ModelYear}" );
                }

                
               



            }
            catch (Exception ex)
            {
                Console.WriteLine("There is Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);  
            }
        }
    }
}
