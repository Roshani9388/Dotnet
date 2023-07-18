namespace HR;
public class Person:IDisposable {
    public string FirstName{get;set;}
    public string LastName{get;set;}

    public override string ToString()
    {
        return base.ToString();
    }

    public void Dispose(){
        Console.WriteLine("Resources are released instantly");
        GC.SuppressFinalize(this );
    }
    ~Person(){
        //Releasing resources which have been allocated 
        //during lifetime of this object
         
    }
}