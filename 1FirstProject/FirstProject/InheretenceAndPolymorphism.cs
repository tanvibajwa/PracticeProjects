//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class Food
//    {
//        public string name;

//        public void Eat()
//        {

//        }

//        public int GetCalories()
//        {
//            return 50;
//        }

//        public override string ToString()
//        {
//            return "Some food with name = " + name;
//        }
//    }

//    class Fruit : Food
//    {
//        public void CreateJuice()
//        {

//        }

//        public override string ToString()
//        {
//            return "eh tann 22 fruit ai: " + name;
//        }
//    }

//    class Vegetable : Food
//    {
//        public void MakeSabji()
//        {

//        }

//        public override string ToString()
//        {
//            return "eh tann 22 SABJI ai: " + name;
//        }
//    }

//    class InheretenceAndPolymorphism
//    {
//        static void NoMain(string[] args)
//        {
//            var some_food_ref = new Food();
//            var some_fruit_ref = new Fruit();
//            var some_vegetable_ref = new Vegetable();

//            some_food_ref.name = "gol gappe";
//            some_fruit_ref.name = "sayb";
//            some_vegetable_ref.name = "jeera aalo";

//            Console.WriteLine(some_food_ref.ToString());
//            Console.WriteLine(some_fruit_ref.ToString());
//            Console.WriteLine(some_vegetable_ref.ToString());

//            //object base_ref = (object)some_fruit_ref;

//            object[] khaana = new object[] { some_food_ref, some_fruit_ref, some_vegetable_ref };

//            Console.WriteLine("");
//            Console.WriteLine("OBJECT REF NAAL");
//            foreach (var k in khaana)
//            {
//                Console.WriteLine(k.ToString());
//            }

//            //int a = 34;
//            //Console.WriteLine(a.ToString());
//        }
//    }
//}
