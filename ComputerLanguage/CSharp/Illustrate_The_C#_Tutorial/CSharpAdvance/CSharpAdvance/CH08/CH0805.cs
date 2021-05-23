using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH08
{
    /*
     对于类来说，派生类的实例可以赋值给基类，但在泛型中不成立，因为在泛型中代表两个不同的同级对象
    这个时候就要用到逆变和协变
    协变：派生类-基类
    逆变：基类-派生类
     */

    class Animal
    {
        public int Legs = 4;
    }

    //派生类
    class Dog : Animal
    {

    }

    delegate T Factory<T>();

    delegate T FactoryOut<out T>();//协变

    delegate void FactoryIn<in T>(T t); //逆变
    /// <summary>
    /// 协变和逆变
    /// </summary>
    class CH0805
    {
        static Dog MakeDog()
        {
            return new Dog();
        }

        static void Animal(Animal a) { Console.WriteLine(a.Legs); }

        public CH0805()
        {

            Factory<Dog> doMaker = MakeDog;
            //Factory<Animal> animalMaker = doMaker;
            //Factory<Dog>和Factory<Animal>不是同一个对象，不存在继承关系

            FactoryOut<Dog> dog = MakeDog;
            FactoryOut<Animal> animal = dog;    //协变
            Console.WriteLine(animal().Legs.ToString());

            FactoryIn<Animal> animalIn = Animal;
            FactoryIn<Dog> dogIn = animalIn;    //逆变
            dogIn(new Dog());


        }
    }
}
