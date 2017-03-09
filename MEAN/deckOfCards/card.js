function Card(val, suit){
    this.val = val;
    
    this.suit = suit;
    
    this.str = this.setVal(this.val);
}

Card.prototype.setVal = function(val){
        var strval;
        if (val === 1){
            strval = "Ace";
        } else if (val === 11){
            strval = "Jack";
        } else if (val === 12){
            strval = "Queen";
        } else if (val === 13){
            strval = "King";
        } else {
            strval = val.toString();
        }
        return strval;
    }