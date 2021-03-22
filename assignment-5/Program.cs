using System;
using System.Collections.Generic;

namespace assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            AbcdeAutomaton abcdeAutomaton = new AbcdeAutomaton("A(B|C)*D");
            List<StateMachine> stateMachines = new List<StateMachine>() {
                new StateMachine(abcdeAutomaton),
                new StateMachine(abcdeAutomaton),
                new StateMachine(abcdeAutomaton)
            };

            Console.WriteLine("Do Actions for First State Machine: ");
            stateMachines[0].doSomething("ab");
            Console.WriteLine("Do Actions for Second State Machine: ");
            stateMachines[1].doSomething("a");
            Console.WriteLine("Do Actions for Third State Machine: ");
            stateMachines[2].doSomething("acd");

            Console.WriteLine("Show a list of running instances: ");
            foreach(StateMachine sm in stateMachines){
                int index = stateMachines.IndexOf(sm);
                Console.WriteLine($"Is the Statemachine {index} in final state? {sm.currentState.final}");
            }
        }
    }
}

