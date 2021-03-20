using System;

namespace assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            AbcdeAutomaton automaton = new AbcdeAutomaton();
            String word = "abcd";
            State state = automaton.initialState;
            Console.WriteLine("state" + state.index);

            foreach (char symbol in word.ToCharArray()) {
                if (state == null) Console.WriteLine(word + " does not match");
                state = automaton.nextState(state, symbol);
                Console.WriteLine("State" + state.index);
            }
            if (state == null) Console.WriteLine(word+" does not match");
            else if (state.final) Console.WriteLine("You had a match");
            else Console.WriteLine("Partially match");
        }
    }
}

