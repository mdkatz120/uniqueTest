using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using uniqueTest.Models;

namespace uniqueTest.Output
{
    public class Print
    {
        public  async Task PrintDishes(Order o)
        {
            //get Dish and put all properties and values in format like JSON inside text

            string res = JsonSerializer.Serialize(o);

           
            List<string> str = new List<string>() { res };
            await File.WriteAllLinesAsync("Menu.txt",str,System.Text.Encoding.UTF32);
        }
    }
}
