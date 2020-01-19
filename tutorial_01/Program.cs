using System;
using System.Collections.Generic;


namespace tutorial_01
{
    class Program
    {
        // 열거형 (Enum)
        enum Weapon
        {
            None = 0,
            Longsword,
            staff,
            Bow,
            Etc
        }
        static void Main(string[] args)
        {
            #region 조건문 및 반복문


            // ctrl + shift +b 전체 빌드 단축키
            //ctrl + F5 빌드 후 실행 
            // int -21억 부터 21억 까지 들어감 
            // float 부동 소수점. 소수점 7자리(6자리)
            // double 부동 소수점. 소수점 16자리(12자리)
            // bool ture 또는 false 값만 들어가는 자료형
            // string 문자열을 넣을 수 있는 자료형
            // char -126~ 126
            // unsinged char 0~256 

            //int value = 0;
            //value = value + 1;
            //value += 1;

            //value = value - 1;
            //value -= 1;

            //value = value * 1;
            //value *= 1;

            //value = value / 1;
            //value /= 1;

            ////조건문
            //if(value  ==1)
            //{
            //    Console.WriteLine("ok");

            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            ////반복문
            ////for,while
            //for (int i = 0; i <= 10; ++i)
            //{
            //    Console.WriteLine(i.ToString());
            //    // printf("%d\n",i);
            //}
            // 전체 주석하기 
            // ctrl + k + c
            // 주석 풀기 
            // ctrl + k + u
            // i는 0부터 5까지 출력하되 
            //for (int i = 0; i <= 5; ++i)
            //{
            //    Console.WriteLine(i);
            //    if (i == 2) Console.WriteLine("OK");
            //    else Console.WriteLine("False");

            //}
            ////구구단 
            ////1단부터 9단
            //for(int i = 1; i <=9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine("{0} x {1} = {2}",i, j, i * j);
            //    }
            //}
            #endregion
            #region 열거형 및 스위치문
            //switch 
            //조건문

            //int money = 100000;
            //// 내가 지금 장착 하고 있는무기

            //Weapon weapon = Weapon.None;
            ////weapon = default(Weapon);

            //string str = string.Empty;
            //Console.ReadLine();

            //Console.WriteLine("내가 장착한 무기:"+ weapon.ToString());
            //Weapon findWeapon = Weapon.None;
            //Enum.TryParse(str, out findWeapon);

            ////case, break, default
            //switch (findWeapon)
            //{
            //    case Weapon.Longsword:
            //        weapon = Weapon.Longsword;
            //        break;

            //    case Weapon.staff:
            //        weapon = Weapon.Bow;
            //        break;

            //    default:
            //        weapon = Weapon.Etc;
            //        break;




            //}
            //Console.WriteLine("새로 장착한 무기:"+ weapon.ToString());

            //while
            //반복문

            //int value = 0;

            //while (value != 100)
            //{
            //    value++;
            //    Console.WriteLine(value.ToString());
            //    #endregion




            //}
            #endregion
            // 자료형, 이름 , 파라메터
            // 1. 자료형? 리턴할 변수형
            // 2. 이름은 함수의 이름
            // 3. 파라메터 (선택) 이 0함수를 사용할때 필요할 수 도있는 객체


            //
            int result = subtract(3, 5);
            Console.WriteLine(result);
            

        }

        static int subtract(int a, int b)
        {
            return a - b;
        }
        static void PrintName()
        {

        }

        static int Add(int a, int b)

        {
            return a + b;
        }


    }
}
