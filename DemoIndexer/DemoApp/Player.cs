namespace ICC;
public class Player{
    public string Name{get;set;}
    public int Score{get;set;}

    public Player(){}
    public Player(string nm,int sc){
        this.Name=nm;
        this.Score=sc;
    }

    public override string ToString()
    {
        return "Name= "+ Name + "Score= "+Score;
    }
}