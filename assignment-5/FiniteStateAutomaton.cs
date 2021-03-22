using System.Collections.Generic;
using System.Linq;

namespace assignment_5
{
    public class AbcdeAutomaton : Automaton
    {
        public Alphabet alphabet { get; }
        public List<State> states { get; }
        public State[,] table { get; }
        public State initialState { get; }
        
        public AbcdeAutomaton(string regex = "A(B|C)*D") {
            regex = regex.ToLower();
            alphabet = new AbcdeAlphabet();
            states = new List<State>();
            int idx = 0; 
            int current = 0;
            int nextState = 1;
            int totalStates = 1;
            int parenthesesCount = 0;
            bool parentheses = false;

            
            states.Add(initialState = new AbcdeState(0, false));
            
            foreach(char c in regex){
                if(idx != regex.Length - 1){
                    if(char.IsLetterOrDigit(c) && alphabet.indexOf(c) >= alphabet.indexOf('a') && alphabet.indexOf(c) <= alphabet.indexOf('z')){
                        if(parentheses == false){
                            states.Add(new AbcdeState(totalStates, false));
                            totalStates++;
                        }
                    }

                    else if(c == '(' ) {
                        if(parentheses == false) {
                            parentheses = true;                           
                            
                        }

                        else if(parentheses == true)
                            parenthesesCount++;
                    }

                    else if(c == ')') {
                        if(parenthesesCount == 0)
                            parentheses = false; 
                        else
                            parenthesesCount--;

                        if(regex[idx+1] != '*') {
                            totalStates++;
                            states.Add(new AbcdeState(totalStates, false)); 
                        }
                    }
                    idx++;
                }
                else {
                    states.Add(new AbcdeState(totalStates, true));
                    totalStates++;
                }                
            }
            table = new State[states.Count(), totalStates+1];
            idx = 0;

            foreach(char c in regex) {
                if(char.IsLetterOrDigit(c) && alphabet.indexOf(c) >= alphabet.indexOf('a') && alphabet.indexOf(c) <= alphabet.indexOf('z')){
                    if(parentheses == false){
                        table[current, alphabet.indexOf(c)] = states.ElementAt(nextState);
                        current = nextState; 
                        nextState++;
                    } else {
                        int star = regex.IndexOf(')', idx);
                        if(regex[star+1] == '*')
                            table[current, alphabet.indexOf(c)] = states.ElementAt(current);
                        else {
                            table[current, alphabet.indexOf(c)] = states.ElementAt(nextState);
                        }
                    }
                }

                else if(c == '(' ) {
                    if(parentheses == false) {
                        parentheses = true; 
                    }

                    else if(parentheses == true)
                        parenthesesCount++;
                }

                else if(c == ')') {
                    if(parenthesesCount == 0){
                        parentheses = false; 
                    } else
                        parenthesesCount--;
                }
                idx++;
            }
        }

        public State nextState(State state, char symbol)
        {
            return table[state.index, alphabet.indexOf(symbol)];
        }
    }
}