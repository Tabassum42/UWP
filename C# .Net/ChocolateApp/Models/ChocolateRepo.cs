using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateApp.Models
{
    public class ChocolateRepo
    {
        ObservableCollection<Chocolate> chocolate;
        public ChocolateRepo()
        {
            this.chocolate = new ObservableCollection<Chocolate>()
            {
                new Chocolate{ID=01, Name="Mini Chocolates", ProductionDate= new DateTime(2022,04,2), ExpiredDate=new DateTime(2024,08,10), Quantity="500gm", Price="750.00 BDT",Stockdetails="Available", Ingrdients="Cocoa Powder, Suger, Flavour, Milk, Butter", ImportBy="Agro DairyShop Ltd , Gazipur.", picture="Assets/Mini Chocolates09.jpg"},
                new Chocolate{ID=02, Name="Ball Truffle Chocolate box", ProductionDate= new DateTime(2022,02,25), ExpiredDate=new DateTime(2024,08,20), Quantity="200gm", Price="500.00 BDT",Stockdetails="Available", Ingrdients="Cocoa Powder, Suger, Flavour, Milk, Butter", ImportBy="Agro DairyShop Ltd , Gazipur.", picture="Assets/Ball Truffle Chocolate box10.jpg"},
                new Chocolate{ID=03, Name="KitKat", ProductionDate= new DateTime(2022,03,28), ExpiredDate=new DateTime(2024,08,30), Quantity="300gm", Price="550.00 BDT",Stockdetails="Available", Ingrdients="Cocoa Powder, Suger, Flavour, Milk, Butter", ImportBy="Agro DairyShop Ltd , Gazipur.", picture="Assets/KitKat.jpg"},
                new Chocolate{ID=04, Name="E.Wedel chocolate bar", ProductionDate= new DateTime(2021,08,10), ExpiredDate=new DateTime(2023,08,12), Quantity="300gm", Price="300.00 BDT", Stockdetails="Available", Ingrdients="Cocoa Powder, Suger, Flavour, Milk, Butter", ImportBy="Rehman's Ltd ,Gazipur.", picture="Assets/E.Wedel chocolate bar01.jpg"},
                new Chocolate{ID=05, Name="Amul Dark Chocolate bar", ProductionDate= new DateTime(2021,09,11), ExpiredDate=new DateTime(2023,08,10), Quantity="300gm", Price="600.00 BDT",Stockdetails="Available", Ingrdients="Cocoa Powder, Suger, Flavour, Butter", ImportBy="Gazi Frams Ltd ,Tongi.", picture="Assets/Amul Dark Chocolate bar02.jpg"},
                new Chocolate{ID=06, Name="Shickers", ProductionDate= new DateTime(2021,07,05), ExpiredDate=new DateTime(2024,02,10), Quantity="200gm", Price="250.00 BDT",Stockdetails="Limited in stock", Ingrdients="Cocoa Powder,Penuts, Ceramal, Suger, Flavour, Milk, Butter", ImportBy="Agro DairyShop Ltd , Gazipur.", picture="Assets/Shickers03.jpg"},
                new Chocolate{ID=07, Name="Amul Fruit N Nut Dark chocolate bar", ProductionDate= new DateTime(2022,02,10), ExpiredDate=new DateTime(2024,08,12), Quantity="500gm", Price="500.00 BDT",Stockdetails="Not In Stock", Ingrdients="Cocoa Powder, Nuts, Suger, Flavour, Milk, Butter", ImportBy="Rehman's Ltd ,Gazipur.", picture="Assets/Amul Fruit N Nut Dark chocolate bar04.jpg"},
                new Chocolate{ID=08, Name="Lindt swiss classic bar", ProductionDate= new DateTime(2022,01,20), ExpiredDate=new DateTime(2024,08,10), Quantity="300gm", Price="550.00 BDT",Stockdetails="Available", Ingrdients="Cocoa Powder, Nuts,Honey, Suger, Flavour, Milk, Butter", ImportBy="Rehman's Ltd ,Gazipur.", picture="Assets/Lindt swiss classic bar05.jpg"},
                new Chocolate{ID=09, Name="Cadbury Starbar", ProductionDate= new DateTime(2021,10,10), ExpiredDate=new DateTime(2022,12,12), Quantity="300gm", Price="700.00 BDT",Stockdetails="Available", Ingrdients="Cocoa Powder, Suger, Flavour, Milk, Butter", ImportBy="Agro DairyShop Ltd , Gazipur.", picture="Assets/Cadbury Starbar06.jpg"},
                new Chocolate{ID=10, Name="White bar chocolate", ProductionDate= new DateTime(2021,02,10), ExpiredDate=new DateTime(2023,05,12), Quantity="100gm", Price="150.00 BDT",Stockdetails="Available", Ingrdients="Suger, Flavour, Milk, Butter", ImportBy="Agro DairyShop Ltd , Gazipur.", picture="Assets/White bar chocolate07.jpg"},
                new Chocolate{ID=11, Name="Cadbury chocolate gift box", ProductionDate= new DateTime(2022,04,25), ExpiredDate=new DateTime(2024,08,15), Quantity="300gm", Price="300.00 BDT",Stockdetails="Limited in stock", Ingrdients="Cocoa Powder, Suger, Flavour, Milk, Butter", ImportBy="Rehman's Ltd , Gazipur.", picture="Assets/Cadbury chocolate gift box08.jpg"}
              
            };
        }
        public ObservableCollection<Chocolate> Get()
        {
            return this.chocolate;
        }
        public Chocolate Get(int id)
        {
            return this.chocolate.FirstOrDefault(c => c.ID == id);
        }
    }
}
