using System;

namespace ConsoleApplication{
    public class Card{
        public string stringVal {
            // based on the given numerical value, pass back the equivalent string value
            get {
                    if (val > && val < 11){
                    return val.ToString();
                } else if (val == 11){
                    return "Jack";
                } else if (val == 12){
                    return "Queen";
                } else if (val == 13){
                    return "King";
                } else if (val == 1){
                    return "Ace";
                } else {
                    return "Joker";
                }
        }
        }
        public string suit;
        public int val;
        // we only need to pass in the cards suit and numerical value because of the way the string values getter works
        public Card(string s, int numVal){
            suit = s;
            val = numVal;
        }
        // this resets what happens when we call System.Console.WriteLine(); makes the print more readable
        public override string ToString(){
            return stringVal+" of " suit;
        }
    }
}
