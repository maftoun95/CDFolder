using System.Collections.Generic;

public class Trial{
    public int trialScore;
    public float responseTime;
    public enum {correct, incorrect, no_response};
    
    //CONSTRUCTOR FUNCTION. RUN TO CREATE NEW INSTANCE.
    public Trial(){

    }

    public
}

public class Round{
    public int roundScore;
    public List<Trial> trialList;
}

public class Scene{
    public int playerID;
    public int sceneID;
    public int sceneScore;
    public int rawScore;
    public float totalTime;
    public List<Round> roundList;
}