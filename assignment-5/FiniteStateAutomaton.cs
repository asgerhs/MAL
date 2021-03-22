using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace assignment_5
{
    public class AbcdeAutomaton : Automaton
    {
        public Alphabet alphabet { get; }
        public List<State> states { get; }
        public State[,] table { get; }
        public State initialState { get; }

        public bool isFinal { get; set; }
        
        public AbcdeAutomaton(string regex = "A(B|C)D") {
            // A(B|C)D
            // A(B|C|E)*D
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
            
            // for (int index = 0; index < regex.Length; index++) {
            //     if (index == regex.Length - 1) states.Add(new AbcdeState(index, true));
            //     else states.Add(new AbcdeState(index, false));
            // }
            foreach(char c in regex){
                if(idx != regex.Length - 1){
                    if(!regex.Contains('*')){
                        if(char.IsLetterOrDigit(c) && alphabet.indexOf(c) >= alphabet.indexOf('a') && alphabet.indexOf(c) <= alphabet.indexOf('z')){
                            if(parentheses == false){
                                states.Add(new AbcdeState(totalStates, false));
                                totalStates++;
                            }
                        }

                        else if(c == '(' ) {
                            if(parentheses == false) {
                                parentheses = true; 
                                states.Add(new AbcdeState(totalStates, false));
                                totalStates++;
                            }

                            else if(parentheses == true)
                                parenthesesCount++;
                        }

                        else if(c == ')') {
                            if(parenthesesCount == 0)
                                parentheses = false; 
                            else
                                parenthesesCount--;
                        }
                        idx++;
                    } else {
                        Console.WriteLine("sut mig");
                    }
                }
                else {
                    states.Add(new AbcdeState(totalStates, true));
                    totalStates++;
                }
                
            }
            table = new State[states.Count(), totalStates];
            foreach(char c in regex) {
                if(!regex.Contains('*')){
                    if(char.IsLetterOrDigit(c) && alphabet.indexOf(c) >= alphabet.indexOf('a') && alphabet.indexOf(c) <= alphabet.indexOf('z')){
                        if(parentheses == false){
                            table[current, alphabet.indexOf(c)] = states.ElementAt(nextState);
                            current = nextState; 
                            nextState++;
                        } else {
                            table[current, alphabet.indexOf(c)] = states.ElementAt(nextState);
                        }
                    }

                    else if(c == '(' ) {
                        if(parentheses == false) {
                            parentheses = true; 
                        }

                        else if(parentheses == true)
                            parenthesesCount++;
                        // Change current, symbol
                    }

                    else if(c == ')') {
                        // Change current, symbol
                        if(parenthesesCount == 0){
                            parentheses = false; 
                            current = nextState;
                            nextState++;
                        } else
                            parenthesesCount--;
                    }
                }
                else{
                    if(char.IsLetterOrDigit(c) && alphabet.indexOf(c) >= alphabet.indexOf('a') && alphabet.indexOf(c) <= alphabet.indexOf('z')) {
                        // Change current, symbol and state
                        char next = idx+1 != regex.Length ? regex[idx +1] : regex[idx];

                        if(next != '|' && parentheses == false){
                            table[current, alphabet.indexOf(c)] = states.ElementAt(nextState);
                            current = nextState;
                            nextState++;
                        } else {
                            table[current, alphabet.indexOf(c)] = states.ElementAt(nextState);
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
                    }
                    idx++;
                }
                if(c == regex.Last()) isFinal = true;
            }

            
            // Actual automaton:

            // //state 0 to state 1 login
            // table[0, 0] = states.ElementAt(1);

            // //login to view list and back
            // table[1, 1] = states.ElementAt(1);
            // table[1, 2] = states.ElementAt(1);

            // //login to edit list and back

            // //view list to edit list and reversed
            // table[1, 3] = states.ElementAt(2);
        }

        public State nextState(State state, char symbol)
        {
            return table[state.index, alphabet.indexOf(symbol)];
        }
    }
}