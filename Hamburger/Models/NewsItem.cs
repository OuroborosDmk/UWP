using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Models
{
    public class NewsItem
    {
        public int Id { get; set; }//序号
        public string Module { get; set; }//板块
        public string Category { get; set; }//类别
        public string Headline { get; set; }//店家
        public string Subhead { get; set; }//名称
        public string Image { get; set; }//图片
    }

    public class NewsManager
    {
        public static void GetNews(string module, ObservableCollection<NewsItem> newsItems)
        {
            newsItems.Clear();

            var allItems = getsNewsItems();
            var filteredItems = allItems.Where(p =>p.Module == module).ToList();

            filteredItems.ForEach(p=> newsItems.Add(p));

        }
        private static List<NewsItem> getsNewsItems()
        {
            var Items = new List<NewsItem>();

            Items.Add(new NewsItem() { Id = 1, Module = "Food", Category = "麻辣拌/烫类", Headline = "晓哲麻辣拌", Subhead = "麻辣拌",  Image ="Assets/晓哲麻辣拌 麻辣拌.png" });
            Items.Add(new NewsItem() { Id = 2, Module = "Food", Category = "麻辣拌/烫类", Headline = "朝天椒麻辣拌", Subhead = "麻辣拌加方便面", Image = "Assets/朝天椒麻辣拌.png" });
            Items.Add(new NewsItem() { Id = 3, Module = "Food", Category = "麻辣拌/烫类", Headline = "南京老鸭粉锡纸花甲粉", Subhead = "锡纸培根金针菇", Image = "Assets/南京老鸭粉锡纸花甲粉锡纸培根金针菇.png" });
            Items.Add(new NewsItem() { Id = 4, Module = "Food", Category = "盖饭类", Headline = "川渝食尚", Subhead = "烧茄子饭", Image = "Assets/川渝食尚烧茄子饭.png" });
            Items.Add(new NewsItem() { Id = 5, Module = "Food", Category = "盖饭类", Headline = "美味小厨", Subhead = "照烧鸡腿饭", Image = "Assets/美味小厨照烧鸡腿饭.png" });
            Items.Add(new NewsItem() { Id = 6, Module = "Food", Category = "盖饭类", Headline = "琦健快餐", Subhead = "鸡柳饭", Image = "Assets/琦健快餐鸡柳饭.png" });
            Items.Add(new NewsItem() { Id = 7, Module = "Food", Category = "盖饭类", Headline = "琦健快餐", Subhead = "鸡排饭", Image = "Assets/琦健快餐鸡排饭.png" });
            Items.Add(new NewsItem() { Id = 8, Module = "Food", Category = "盖饭类", Headline = "琦健快餐", Subhead = "招牌茄子", Image = "Assets/琦健快餐招牌茄子.png" });
            Items.Add(new NewsItem() { Id = 9, Module = "Food", Category = "盖饭类", Headline = "首尔家的汤饭", Subhead = "牛肉盖饭", Image = "Assets/首尔家的汤饭牛肉盖饭.png" });
            Items.Add(new NewsItem() { Id = 10, Module = "Food", Category = "盖饭类", Headline = "亿家好饭", Subhead = "台湾大鸡排饭", Image = "Assets/亿家好饭台湾大鸡排饭.png" });
            Items.Add(new NewsItem() { Id = 11, Module = "Food", Category = "盖饭类", Headline = "亿家好饭", Subhead = "招牌干妈茄子饭", Image = "Assets/亿家好饭招牌干妈茄子饭.png" });
            Items.Add(new NewsItem() { Id = 12, Module = "Food", Category = "盖饭类", Headline = "亿家好饭", Subhead = "照烧鸡腿饭", Image = "Assets/亿家好饭照烧鸡腿饭.png" });
            Items.Add(new NewsItem() { Id = 12, Module = "Food", Category = "炒饭类", Headline = "琦健快餐", Subhead = "蛋炒饭", Image = "Assets/琦健快餐蛋炒饭.png" });
            Items.Add(new NewsItem() { Id = 12, Module = "Food", Category = "炒饭类", Headline = "首尔家的汤饭", Subhead = "韩式铁板炒饭", Image = "Assets/首尔家的汤饭韩式铁板炒饭.png" });
            Items.Add(new NewsItem() { Id = 12, Module = "Food", Category = "炒饭类", Headline = "首尔家的汤饭", Subhead = "火腿芝士炒饭", Image = "Assets/首尔家的汤饭火腿芝士炒饭.png" });
            Items.Add(new NewsItem() { Id = 12, Module = "Food", Category = "炒饭类", Headline = "小小滋味简餐", Subhead = "纽西兰缤纷炒饭", Image = "Assets/小小滋味简餐纽西兰缤纷炒饭.png" });
            Items.Add(new NewsItem() { Id = 12, Module = "Food", Category = "小吃类", Headline = "美味小厨", Subhead = "红油杏鲍菇", Image = "Assets/美味小厨红油杏鲍菇.png" });
            Items.Add(new NewsItem() { Id = 12, Module = "Food", Category = "小吃类", Headline = "首尔家的汤饭", Subhead = "辣炒米条", Image = "Assets/首尔家的汤饭辣炒米条.png" });


            return Items;
        }
    }
}
