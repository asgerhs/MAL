namespace assignment_5 {
    public class AbcdeAlphabet : Alphabet {
        public int indexOf(char symbol) {
            if (symbol < 'a' || 'z' < symbol) throw new System.Exception("Symbol out of bounds"); 
            return symbol - 'a';
        }

        public char symbolOf(int index, int max) {
            if (index < 0 || max < index) throw new System.Exception();
            return (char)('a' + index);
        }

        public int size() {
            return 5;
        }
    }
}