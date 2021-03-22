using System;
using System.Collections.Generic;

namespace assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            AbcdeAutomaton automaton = new AbcdeAutomaton();
            List<StateMachine> sm = new List<StateMachine>();


            StateMachine sm1 = new StateMachine();
            StateMachine sm2 = new StateMachine();
            StateMachine sm3 = new StateMachine();
            StateMachine sm4 = new StateMachine();
            sm.Add(sm1);
            sm.Add(sm2);
            sm.Add(sm3);
            sm.Add(sm4);
            sm1.doSomething(automaton);
            sm2.doSomething(automaton);
            sm3.doSomething(automaton, "ab");
            sm4.doSomething(automaton, "a");
            foreach(StateMachine s in sm){
                Console.WriteLine(s.isFinal);
                
            }
        }
    }
}

