namespace info;

public class Person{
    private int pid;
    private string pname;
    private DateTime dob;
    private int phoneno;

    public Person(){
        Console.WriteLine("In default constructor");
        this.pid=10;
        this.pname="Roshani";
        this.dob=new DateTime(1993,08,26);
        this.phoneno=1234567;
    }

    public Person(int pid,string pname,DateTime dob,int phoneno){
        Console.WriteLine("In parameterized constructor");
         this.pid=pid;
        this.pname=pname;
        this.dob=dob;
        this.phoneno=phoneno;
    }

    public int Pid{
        set{this.pid=value;}
        get{return this.pid;}
    }

     public string Pname{
        set{this.pname=value;}
        get{return this.pname;}
    }

     public DateTime Dob{
        set{this.dob=value;}
        get{return this.dob;}
    }

     public int Phoneno{
        set{this.phoneno=value;}
        get{return this.phoneno;}
    }

    public override string  ToString(){
        return "pid= "+this.pid+" pname= "+this.pname+" dob= "+this.dob+" phone no= "+phoneno;
    }

}