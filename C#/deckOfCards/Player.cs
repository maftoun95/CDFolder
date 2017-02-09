using System;
using System.Collections.Generic;

namespace ConsoleApplication{
    public class Player{
        //name is a string
        public string name;
        //instantiate hand. Expect it to be a List of strings
        private List<string> hand;
        //the Player creator function. Pass the players name
        public Player(string n){
            // do the other end of the hand creation. Set hand to be a list of strings
            hand = new List<Card>();
            // name is n
            name = n;
        }
        // the func that draws a card. pass this function the current deck 
        public void DrawFrom(Deck currentDeck){
            // use the deal function for this current deck removing/returning one card. add it to the players hand
            hand.Add(currentDeck.Deal());
        }
        // the players discard function. Pass the index of the card to discard/play. returns said card
        public Card Discard(int idx){
            // copy the value of the desired card to a temp so it doesnt disapear after removal
            Card temp = hand[idx];
            // remove the card
            hand.RemoveAt[idx];
            // return the temp; same thing as the removed card
            return temp;
            
        }
    }
}
