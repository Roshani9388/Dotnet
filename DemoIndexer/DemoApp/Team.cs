namespace ICC;
public class Team{
    private List<Player> plist=new List<Player>();

    public Team(){
        plist.Add(new Player{Name="Dhoni",Score=100000});
        plist.Add(new Player{Name="sachin",Score=87885});
        plist.Add(new Player{Name="Virat",Score=652156});
        plist.Add(new Player{Name="Gill",Score=26444585});
    }

    public override string ToString()
    {
        return base.ToString();
    }
    //Indexer
    public Player this[int index]{
        get{return this.plist[index];}
        set{this.plist[index]=value;}
    }
}