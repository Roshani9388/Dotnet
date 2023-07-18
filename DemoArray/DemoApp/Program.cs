// See https://aka.ms/new-console-template for more information
using HR;
int[] marks={54,62,87,21,96};
Array.Sort(marks);
Array.Reverse(marks);
string[] names={"sainya","saket","roshani"};
Person[] people={
    new Person{FirstName="aaa",LastName="yyy"},
    new Person{FirstName="ccc",LastName="ooo"},
    new Person{FirstName="fdfc",LastName="fgh"},
};
Person p1=people[1];
foreach(Person p in people){
    Console.WriteLine(p);
}

//Rectangular Array

int[,] matrix=new int[2,3]{
    {11,55,11},
    {54,45,78}
};
for(int i=0;i<=2;i++){
    for(int j=0;j<=3;j++){
        Console.WriteLine(matrix[i,j]);
    }
}

//Array of Array
//Jagged Array
int[][] dacMarks=new int[3][];
dacMarks[0]=new int[4]{11,55,21,65};
dacMarks[1]=new int[3]{47,65,78};
dacMarks[2]=new int[]{11,55,21,11,63,65};
