using System;

namespace assignment_5
{
    public class StateMachine
    {
        public bool isFinal { get; set; }
        int systemId { get; set; }
        int instanceId { get; set; }

        public StateMachine(bool isFinal = false, int systemId = 0, int instanceId = 0){
            this.isFinal = isFinal;
            this.systemId = systemId;
            this.instanceId = instanceId; 
        }
        public void doSomething(AbcdeAutomaton automaton, string word = "abd")
        {
            LogUtility lu = new LogUtility();
            
            Random rand = new Random();
            State state = automaton.initialState;
            systemId = rand.Next();
            instanceId = rand.Next();
            Console.WriteLine("state" + state.index);

            foreach (char symbol in word.ToCharArray())
            {
                isFinal = automaton.isFinal;
                if (state == null)
                {
                    lu.writeLog("logs/log.txt", true, systemId, instanceId, symbol);
                }
                state = automaton.nextState(state, symbol);
                if (state == null) lu.writeLog("logs/log.txt", true, systemId, instanceId, symbol);
                else lu.writeLog("logs/log.txt", false, systemId, instanceId, symbol);
                Console.WriteLine("State" + state.index);
            }
        }
    }
}