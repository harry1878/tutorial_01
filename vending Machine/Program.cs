using System;
using System.Collections.Generic;
using System.Threading;


namespace vending_Machine
{
    class Program
    {
        enum product
        {
            None = 0,
            Cola,
            Sida,
            Fanta,
            Water,
            Coffee,
            Tea
        }

        static void Main(string[] args)
        {
            // 자판기 
            int money = 10000;

            string input = "Start";
            while (!string.IsNullOrEmpty(input))
            {
                
                Console.Clear();
                Console.WriteLine("잔여액:{0}", money);
                Console.WriteLine("어서오세요 자판기 입니다");
                // 1. 상품 보여주기!
                
        

        

                Console.WriteLine("상품 종류: Cola(100), Sida(200), Fanta(300), Water(1000), Coffee(1), Tea(30)");


                // 2. 입력 받기
                Console.WriteLine("사고 싶은 상품을 입력해주세요");
                
                input = Console.ReadLine();

                product findproduct = product.None;
                Enum.TryParse(input, out findproduct);



                // Cola(100), Sida(200), Fanta(300), Water(1000), Coffee(1), Tea(30)


                // 3. 계산하기
                if (findproduct == product.Tea)
                {
                    if (money >= 30)
                    {
                        money = money - 30;
                       
                    }

                    else
                    {
                        Console.WriteLine("돈이 부족하여 이 상품을 구입할 수 없습니다.");
                        Thread.Sleep(1000);
                    }

                }
                if (findproduct == product.Coffee)
                {
                    if (money >= 1)
                    {
                        money = money - 1;
                       
                    }

                    else
                    {
                        Console.WriteLine("돈이 부족하여 이 상품을 구입할 수 없습니다.");
                        Thread.Sleep(1000);
                    }

                }
                if (findproduct == product.Water)
                {
                    if (money >= 1000)
                    {
                        money = money - 1000;
                        
                    }

                    else
                    {
                        Console.WriteLine("돈이 부족하여 이 상품을 구입할 수 없습니다.");
                        Thread.Sleep(1000);
                    }

                }
                if (findproduct == product.Fanta)
                {
                    if (money >= 300)
                    {
                        money = money - 300;
                        
                    }

                    else
                    {
                        Console.WriteLine("돈이 부족하여 이 상품을 구입할 수 없습니다.");
                        Thread.Sleep(1000);
                    }

                }
                if (findproduct == product.Sida)
                {
                    if (money >= 200)
                    {
                        money = money - 200;
                        
                    }

                    else
                    {
                        Console.WriteLine("돈이 부족하여 이 상품을 구입할 수 없습니다.");
                        Thread.Sleep(1000);
                    }

                }

                if (findproduct == product.Cola)
                {
                    if (money >= 100)
                    {
                        money = money - 100;
                        
                    }

                    else
                    {
                        Console.WriteLine("돈이 부족하여 이 상품을 구입할 수 없습니다.");
                        Thread.Sleep(1000);
                    }

                }


            }

            Console.WriteLine("자판기 종료!");  


        }
    }
}
