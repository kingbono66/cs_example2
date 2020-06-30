using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Data.SqlTypes;

namespace cs_example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int asset = 1000000;
            int dogPrice = 500000;
            int dogFoodPrice = 300000;
            string dogName = "백구";

            WriteLine("아무키나 누르면 한줄씩 진행이 됩니다\n"); ReadKey();
            WriteLine($"원룸에서 {asset}원을 가진 인간 한명이 살고 있었다\n"); ReadKey();
            Human master = new Human(asset);
            WriteLine($"외로운 인간은 {dogPrice}원인 개를 한마리 분양받아 주인이 되었다\n"); ReadKey();
            Dog dog = master.BuyDog(dogPrice);
            WriteLine($"주인은 개에게 이름을 {dogName}라고 지어 주었다\n"); ReadKey();
            master.NamingDog(dog, dogName);
            WriteLine("주인은 개에게 애교를 요구한다\n"); ReadKey();
            master.RequestCuteTricks(dog);
            WriteLine("짖기만 하는걸 보니 배고픈가 보다"); 
            WriteLine("주인은 개에게 개밥을 사다 줬다\n"); ReadKey();
            master.FeedDog(dog, dogFoodPrice);
            WriteLine("다시 애교를 시켜본다\n"); ReadKey();
            master.RequestCuteTricks(dog);
            WriteLine($"전재산이 {master.money}원 뿐이지만 모두가 행복해졌다\n");
        }
    }

    class Human
    {
        public int money;

        public Human(int asset)
        {
            money = asset;
        }
        public Dog BuyDog(int price)
        {
            money -= price;
            return new Dog();
        }
        public void NamingDog(Dog dog, string name)
        {
            dog.dogName = name;
        }
        public void RequestCuteTricks(Dog dog)
        {
            dog.ReceiveCuteTricks();
        }
        public void FeedDog(Dog dog, int dogFoodCost)
        {
            dog.EatFood();
            money -= dogFoodCost;
        }
    }

    class Dog
    {
        public bool isHungry;
        public string dogName;

        public Dog()
        {
            isHungry = true;
        }
        public void Bark()
        {
            WriteLine($"{dogName} : Bow Wow!!!!!");
        }
        public void ReceiveCuteTricks()
        {
            if (isHungry)
                Bark();
            else
                DoCuteTricks();
        }
        public void DoCuteTricks()
        {
            WriteLine($"{dogName} : 폴짝폴짝 귀염귀염");
        }
        public void EatFood()
        {
            isHungry = false;
        }
    }
}
