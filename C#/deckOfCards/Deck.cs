using System;
using System.Collections.Generic;

namespace ConsoleApplication{
    public class Deck{
         
        private List<Card> cards;
        //the Deck cunstructor function
        public Deck() {
            //do the work in reset, call it here
            Reset();
        }

        public Card Deal(){
            if(cards.Count > 0){
                //like our player discard method, we need to set a temp before removing. return the temp. 
                Card temp = cards[0];
                cards.RemoveAt(0);
                return temp;
            }
            return null;
        }

        public Deck Shuffle(){
            // lets use random!
            Random rand = new Random();
            // loop the deck and do some work
            for(int idx = cards.Count-1; idx > 0; idx--){
                // use rand to produce a random index within our range of cards
                int randIdx = rand.Next(idx);
                //set that temp! type of Card
                Card temp = cards[randIdx];
                // that random index gets swapped with index of i. on and on till the end of the loop
                cards[randIdx] = cards[idx];
                cards[idx] = temp;
            }
            //return this, because: chaining.
            return this;
        }

        public Deck Reset() {
            cards = new List<Card>();
            //all the suits
            string[] suits = new string[4] {"Hearts", "Clubs", "Spades", "Diamonds"};
            // run the for loop oneach suit
            foreach(string suit in suits){
                for (int i = 1; i < 14; i++){
                    // make a card of each num val
                    cards.Add(new Card(suit, i));
                }
            }
        }
        //override the ToString method. make it work for US!!
        public override string ToString(){
            string info = "";
            foreach (Card card in cards){
                //take each card and append a new line. add. return.
                info += card + "\n";
            }
            // return the product of our labor
            return info;
        }
    }
}
