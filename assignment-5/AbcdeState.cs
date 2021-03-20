using System;

namespace assignment_5
{
    public class AbcdeState : State
    {
        public int index { get; set; }
        public bool final { get; set; }

        public AbcdeState(int index, bool final) {
            this.index = index;
            this.final = final;
        }
    }
}