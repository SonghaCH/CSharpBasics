using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics
{
    public enum MachineState : byte
    {
        Off,
        Running,
        Broken
    }
    public class Machine
    {
        private string m_name;
        private float m_weight;
        private int m_price;
        private MachineState m_state = MachineState.Off;

        public Machine(string name, float weight, int price, MachineState state)
        {
            this.m_name = name;
            this.m_weight = weight;
            this.m_price = price;
            this.m_state = state;
            Console.WriteLine($"새로운 {m_name}를 구매하였습니다.");
        }
        public string GetMachineName()
        {
            return m_name;
        }

        public MachineState GetState()
        {
            return m_state;
        }

        public void SetState(MachineState state)
        {
            m_state = state;
            Console.WriteLine($"기계의 상태가 {m_state}로 변경되었습니다.");
        }
    }

    public class Mechanic
    {
        private string m_name;

        public Mechanic(string name)
        {
            m_name = name;
        }
        public void Repair(Machine targetMachine)
        {
            Console.WriteLine($"[정비중]  {m_name} 정비사가 {targetMachine.GetMachineName()}의 점검을 시작합니다.");
            if (targetMachine.GetState() == MachineState.Broken)
            {
                targetMachine.SetState(MachineState.Off);
                Console.WriteLine($"-> {targetMachine.GetMachineName()} 수리 완료! (현재 상태: Off)");
            }
            else
            {
                Console.WriteLine("기계 이상없습니다.");
            }
        }
    }
    internal class Program
    {




        static void Main(string[] args)
        {
            Machine myMouse = new Machine("고사양 게이밍 마우스", 0.6f, 300000, MachineState.Off);
            Mechanic myMechanic = new Mechanic("차송하");
            myMechanic.Repair(myMouse);

        }
    }
}
