using System.Collections.Generic;

namespace assignment_5
{
    public interface Automaton
    {
        Alphabet alphabet { get; }
        List<State> states { get; }
        State initialState{ get; }
        State nextState(State state, char symbol);
    }
}