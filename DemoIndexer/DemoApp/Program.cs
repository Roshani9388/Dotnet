// See https://aka.ms/new-console-template for more information
using ICC;
Team t=new Team();
Player p=t[0];
Console.WriteLine(p);

//Typecasting

Player pp=new Player{Name="virat",Score=44244};
Object o=pp;//implicit typecasting
Player gg=(Player) o; //explicit typecasting
Player kk=o as Player;
if(kk is Player){
    Console.WriteLine("yes");
}else{
     Console.WriteLine("no");
}