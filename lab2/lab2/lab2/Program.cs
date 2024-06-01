using System;
using System.Collections.Generic;
using lab2.task1;
using lab2.task2.Brands;
using lab2.task2.Interfaces;
using lab2.task3;
using lab2.task4;
using lab2.task5;
namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorySubscription webSiteFactory = new WebSite();
            FactorySubscription mobileAppFactory = new MobileApp();
            FactorySubscription managerCallFactory = new ManagerCall();


            subscription webSiteSubscription = webSiteFactory.CreateSubscription("Domestic");
            subscription mobileAppSubscription = mobileAppFactory.CreateSubscription("Educational");
            subscription managerCallSubscription = managerCallFactory.CreateSubscription("Premium");

            Console.WriteLine(webSiteSubscription.ToString());
            Console.WriteLine("");
            Console.WriteLine(mobileAppSubscription.ToString());
            Console.WriteLine("");
            Console.WriteLine(managerCallSubscription.ToString());

            Balaxy balaxyFactory = new Balaxy();
            ILaptop laptop1 = balaxyFactory.CreateLaptop();
            INetbook netbook1 = balaxyFactory.CreateNetbook();
            ISmartphone smartphone1 = balaxyFactory.CreateSmartphone();
            laptop1.DisplayInfo();
            netbook1.DisplayInfo();
            smartphone1.DisplayInfo();
            Console.WriteLine("");

            IProne iproneFactory = new IProne();
            ILaptop laptop2 = iproneFactory.CreateLaptop();
            INetbook netbook2 = iproneFactory.CreateNetbook();
            ISmartphone smartphone2 = iproneFactory.CreateSmartphone();
            laptop2.DisplayInfo();
            netbook2.DisplayInfo();
            smartphone2.DisplayInfo();
            Console.WriteLine("");

            Kiaomi kiaomiFactory = new Kiaomi();
            ILaptop laptop3 = kiaomiFactory.CreateLaptop();
            INetbook netbook3 = kiaomiFactory.CreateNetbook();
            ISmartphone smartphone3 = kiaomiFactory.CreateSmartphone();
            laptop3.DisplayInfo();
            netbook3.DisplayInfo();
            smartphone3.DisplayInfo();

            Authenticator authenticator1 = Authenticator.GetInstance();
            Authenticator authenticator2 = Authenticator.GetInstance();

            Console.WriteLine("authenticator1 == authenticator2: {0}", authenticator1 == authenticator2);


            Virus parentVirus = new Virus(10, 3, "Parent Virus", "Type A");
            Virus child1 = new Virus(5, 1, "Child 1", "Type B");
            Virus child2 = new Virus(6, 2, "Child 2", "Type C");

            parentVirus.AddChild(child1);
            parentVirus.AddChild(child2);

            Console.WriteLine("All viruses info:");
            parentVirus.ShowAllInfo();

            Virus parentVirusCopy = new Virus(parentVirus);

            Console.WriteLine("\nEquality check:");
            parentVirusCopy.IsEqualVirusAndCopy(parentVirus);

            Virus deepCopyVirus = new Virus(parentVirus);
            Console.WriteLine("\nDeep Copy Virus:");
            deepCopyVirus.ShowAllInfo();

            Creates director = new Creates();
            HeroBuilder heroBuilder = new HeroBuilder();
            EnemyBuilder enemyBuilder = new EnemyBuilder();

            Hero hero = director.ConstructHero(heroBuilder);
            Hero enemy = director.ConstructEnemy(enemyBuilder);
            Console.WriteLine();
            Console.WriteLine("Hero:\n" + hero);
            Console.WriteLine();
            Console.WriteLine("Enemy:\n" + enemy);
        }
    }
}