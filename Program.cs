using System;
using System.Collections.Generic;

namespace b1_chap12_zooPractice
{

    //interfaces
    public interface IWalking
    {

        void Walk();
    }

    public interface ISwimming
    {

        void Swim();
    }

    public interface IFlying
    {

        void Fly();
    }

    public interface IDigging

    {

        void Dig();
    }

    //animal classes

    public class Worm : IDigging
    {

        public void Dig()
        {
            Console.WriteLine("Animal is now digging");
        }
    }

    public class Ant : IDigging
    {

        public void Dig()
        {
            Console.WriteLine("Animal is now digging");
        }
    }

    public class Mouse : IWalking
    {

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }
    public class Gerbil : IWalking
    {

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }
    public class Snake : IWalking
    {

        public void Walk()
        {
            Console.WriteLine("Animal is now slithering");
        }
    }

    public class Parakeet : IFlying
    {

        public void Fly()
        {
            Console.WriteLine("Animal is now flying");
        }
    }

    public class Finch : IFlying
    {

        public void Fly()
        {
            Console.WriteLine("Animal is now flying");
        }
    }
    public class BetaFish : ISwimming
    {

        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }
    }

    public class Terrapin : ISwimming
    {

        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }
    }

    //containers

    public class WaterContainer
    {

        public List<ISwimming> swimmers = new List<ISwimming>();

    }

    public class DirtContainer
    {

        public List<IDigging> diggers = new List<IDigging>();

    }

    public class CageContainer
    {

        public List<IFlying> flyers = new List<IFlying>();

    }

    public class ContainerContainer
    {

        public List<IWalking> crawlers = new List<IWalking>();

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Finch finch1 = new Finch();
            Worm worm1 = new Worm();
            Terrapin terrapin1 = new Terrapin();
            Snake snake1 = new Snake();
            Mouse mouse1 = new Mouse();
            Ant ant1 = new Ant();
            Parakeet parakeet1 = new Parakeet();
            BetaFish betafish1 = new BetaFish();
            Gerbil gerbil1 = new Gerbil();

            WaterContainer water = new WaterContainer();
            DirtContainer dirt = new DirtContainer();
            CageContainer cage = new CageContainer();
            ContainerContainer pen = new ContainerContainer();

            pen.crawlers.Add(snake1);
            pen.crawlers.Add(mouse1);
            pen.crawlers.Add(gerbil1);
            water.swimmers.Add(terrapin1);
            water.swimmers.Add(betafish1);
            dirt.diggers.Add(worm1);
            dirt.diggers.Add(ant1);
            cage.flyers.Add(finch1);
            cage.flyers.Add(parakeet1);
            


        }
    }
}