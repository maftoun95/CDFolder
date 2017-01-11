import random
def coinToss():
    heads = 0
    tails = 0
    for flip in range(5000):
        chance = round(random.random())
        if chance == 1:
            heads += 1
            print 'Attempt #' + str(flip+1) + ': Throwing a coin... It\'s a head! ... Got ' + str(heads) + ' head(s) so far and ' + str(tails) + ' tail(s) so far.'
        else:
            tails += 1
            print 'Attempt #' + str(flip+1) + ': Throwing a coin... It\'s a tail! ... Got ' + str(heads) + ' head(s) so far and ' + str(tails) + ' tail(s) so far.'

coinToss()
