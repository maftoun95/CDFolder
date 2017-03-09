function Player(name){
    this.name = name;
    this.hand = this.setHand()
}

Player.prototype.setHand = function(){
    var hand = [];
    for (var i = 0; i < 7; i++){
        hand.push(deck.deal())
    }
    return hand;
}

Player.prototype.draw = function(){
    this.hand.push(deck.deal());
}
//this function is dependant on the player knowing the index of the card they wish to discard.
//we can acheive this easily by printing <player>.hand
// if no index is provided, the card in the 0th position will be discarded term
Player.prototype.discard = function(idx){
    return this.hand.splice(idx,1);
}