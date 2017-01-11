def grades():
    for i in range(0,10):
        score = int(input("FEED ME A TEST SCORE\n"))
        if score < 60:
            print "score is " + str(score) + ". Your grade is F"
        elif 60 <= score <=69:
            print "score is " + str(score) + ". Your grade is D"
        elif 70 <= score <=79:
            print "score is " + str(score) + ". Your grade is C"
        elif 80 <= score <=89:
            print "score is " + str(score) + ". Your grade is B"
        elif 90 <= score <=100:
            print "score is " + str(score) + ". Your grade is A"
        else:
            print "THATS NOT A REAL SCORE!!"

grades()
