function Deck(){
    this.deck = [];
    
}

Deck.prototype.setDeck = function(){
    var s, v,
    suit = ["Hearts", "Clubs", "Diamonds", "Spades"]
    for (s = 0; s < 4; s++){
        for (v = 1; v <= 13; v++){
            this.deck.push(new Card(v,suit[s]))
        }
    }
}

Deck.prototype.reset = function(){
    this.deck = [];
    this.setDeck();
}

Deck.prototype.deal = function(){
    return this.deck.pop();
}

Deck.prototype.shuffle = function() {
  var copy = [], n = this.deck.length, i;

  while (n) {
    i = Math.floor(Math.random() * n--);
    copy.push(this.deck.splice(i, 1)[0]);
  }

  this.deck = copy;
}