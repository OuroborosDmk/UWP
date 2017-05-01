using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hamburger.Models
{
    public class FoodItem
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string Merchants { get; set; }
        public string FoodImage { get; set; }
    }

    public class FoodManager
    {
        public static List<FoodItem> GetFoods()
        {
            var Foods = new List<FoodItem>();

            Foods.Add(new FoodItem { FoodId = 1, Name = "麻辣拌", Merchants = "晓哲麻辣拌", FoodImage = "Assets/晓哲麻辣拌.png" });
            Foods.Add(new FoodItem { FoodId = 2, Name = "南京老鸭粉", Merchants = "南京老鸭粉", FoodImage = "Assets/南京老鸭粉.png" });
            Foods.Add(new FoodItem { FoodId = 3, Name = "照烧鸡腿饭", Merchants = "美味小厨", FoodImage = "Assets/美味小厨照烧鸡腿饭.png" });
            Foods.Add(new FoodItem { FoodId = 4, Name = "鸡排饭", Merchants = "琦健快餐", FoodImage = "Assets/琦健快餐鸡排饭.png" });
            Foods.Add(new FoodItem { FoodId = 5, Name = "红油杏鲍菇", Merchants = "美味小厨", FoodImage = "Assets/美味小厨红油杏鲍菇.png" });
            Foods.Add(new FoodItem { FoodId = 6, Name = "台湾大鸡排饭", Merchants = "亿家好饭", FoodImage = "Assets/亿家好饭台湾大鸡排饭.png" });
            Foods.Add(new FoodItem { FoodId = 7, Name = "朝天椒麻辣拌", Merchants = "朝天椒麻辣拌", FoodImage = "Assets/朝天椒麻辣拌.png" });
            Foods.Add(new FoodItem { FoodId = 8, Name = "辣炒米条", Merchants = "首尔家的汤饭", FoodImage = "Assets/首尔家的汤饭辣炒米条.png" });

            return Foods;
        }
    }
}
   