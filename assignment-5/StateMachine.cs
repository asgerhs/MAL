using System;

namespace assignment_5
{
    public class StateMachine
    {
        int systemId { get; set; }
        int instanceId { get; set; }
        public AbcdeAutomaton automaton { get; }
        public State currentState { get; set; }

        public StateMachine(AbcdeAutomaton automaton, int systemId = 0, int instanceId = 0){
            this.automaton = automaton;
            this.systemId = systemId;
            this.instanceId = instanceId; 
        }
        public void doSomething(string word = "abd")
        {
            Random rand = new Random();
            currentState = automaton.initialState;
            systemId = rand.Next();
            instanceId = rand.Next();
            Console.WriteLine("state" + currentState.index);

            foreach (char symbol in word.ToCharArray())
            {
                if (currentState == null)
                {
                    LogUtility.writeLog("logs/log.txt", true, systemId, instanceId, symbol);
                }
                currentState = automaton.nextState(currentState, symbol);
                if (currentState == null) LogUtility.writeLog("logs/log.txt", true, systemId, instanceId, symbol);
                else LogUtility.writeLog("logs/log.txt", false, systemId, instanceId, symbol);
                Console.WriteLine("State" + currentState.index);
            }
        }
    }
}