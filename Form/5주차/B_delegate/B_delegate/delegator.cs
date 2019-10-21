using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    System.Delegate
    Delegator : 메서드를 인자로 받아드림
    메서드를 가르키는 참조형
    객체를 만드는 타입(변수 X, new)
*/

namespace B_delegate
{
    class carDrive
    {
        public static void GoForward()
        {
            Console.WriteLine("직진");
        }

        public static void GoLeft()
        {
            Console.WriteLine("좌회전");
        }

        public static void GoRight()
        {
            Console.WriteLine("우회전");
        }
    }

    class delegator
    {
        //대리자 생성
        //대리자를 생성할때에는무조건 delegate로 선언을 해줘야한다.
        //인자로 들어갈 때에는 데이터 타입 혹은 인자의 수를 명확하게 선언해줘야한다.
        public delegate void GoHome();

        static void Main(string[] args)
        {
            //메서드 따로 호출
            //carDrive.GoForward();
            //carDrive.GoLeft();
            //carDrive.GoRight();

            //대리자 : class와 동급
            //대리자를 통한 메서드 등록 및 호출
            //delegate만 인자안에 메서드를 사용할 수 있다.
            GoHome go = new GoHome(carDrive.GoForward);

            //대리자의 인자에 메서드를 추가할 때는 복합대입연산자를 사용한다.
            go += new GoHome(carDrive.GoLeft);
            go += new GoHome(carDrive.GoRight);

            //대리자 호출 : 한 번에 인자안에 있는 메서드를 모두 호출해준다.
            go();
        }
    }
}
