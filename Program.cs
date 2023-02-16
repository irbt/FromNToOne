// print numbers from n to 1 using recursion
namespace Program;

class FromNToOneTask{

public static int FromNToOne(int num){

if (num < 1){
    return num;
}

Console.Write (num + " ");
num--;
return FromNToOne(num);
}

public static void Main (string[] args) {

    FromNToOne(10);
}



}