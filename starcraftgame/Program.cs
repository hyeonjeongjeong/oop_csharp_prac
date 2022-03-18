using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_abstract_interface
{
    /*
        추상클래스와 인터페이스의 공통점
        1. 강제적 구현
        2. 상속을 목적으로 한다.
        3. 스스로 객체 생성이 불가능하다
        4. 다형성 (캐스팅)
        
        추상클래스와 인터페이스의 차이점
        추)멤버필드를 가질 수 있다
        일반 함수를 가질 수 있다
        당일 상속
        미완성 + 완성

        인) 멤버필드를 가질 수 없다
        다중 상속  
        구현 코드를 갖지 않는다. (미완성)

     */
    /*
     게임 (unit)
     unit 공통기능 (이동좌표, 이동, 멈춘다) :추상화, 일반화
     unit 이동방법은 다르다 (이동방법은 unit마다 별도의 구현 강제로)

     */

    abstract class Unit
    {
        public int x, y;
        public void stop()
        {
            Console.WriteLine("unit stop");
        }

        //이동
        interface Ia
        {
            void tank();
            int get
            {
                get;
            }
        }
        public abstract void move(int x, int y);


        class Tank : Unit
        {
            public override void move(int x, int y)
            {
                this.x = x;
                this.y = y;
                Console.WriteLine("Tank 이동 : " + this.x + "," + this.y);
            }
            //Tank 특수화, 구체화
            public void changeMode()
            {
                Console.WriteLine("Tank 변환 모드");
            }
        }



        class Marine : Unit
        {
            public override void move(int x, int y)
            {
                this.x = x;
                this.y = y;
                Console.WriteLine("Marine 이동 : " + this.x + "," + this.y);
            }
            //Tank 특수화, 구체화
            public void stimpack()
            {
                Console.WriteLine("스팀팩 기능");
            }
        }
        class DropShip : Unit
        {
            public override void move(int x, int y)
            {
                this.x = x;
                this.y = y;
                Console.WriteLine("DropShip 이동 : " + this.x + "," + this.y);
            }
            //Tank 특수화, 구체화
            public void load()
            {
                Console.WriteLine("Unit Load");
            }
            public void unload()
            {
                Console.WriteLine("Unit unLoad");
            }
        }



        class Program
        {
            static void Main(string[] args)
            {
                Tank tank = new Tank();
                tank.move(1, 2);
                tank.stop();
                tank.changeMode();

                Marine marine = new Marine();
                marine.move(200, 500);
                marine.stop();
                marine.stimpack();

                Tank[] tanklist = { new Tank(), new Tank(), new Tank() };
                foreach (Tank t in tanklist)
                {
                    t.move(555, 444);
                }

                /*
                문제 1. 탱크 3대를 만들고 같은 좌표로 이동시켜라 -> 객체배열을 사용
                문제 2. 여러개의 unit (tank, marin, dropship)을 만들고 같은 좌표로 이동시켜라 -> 다형성**
                전자제품 매장 (buy (product p))
                
                 */
                Unit[] unitlist = { new Tank(), new Marine(), new DropShip() }; //유닛을 묶어서 만든것.
                foreach (Unit unit in unitlist)
                {
                    unit.move(888, 999);
                }
            }
        }
    }
}


