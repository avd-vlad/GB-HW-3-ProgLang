/*----------------------------------------------------------------------------------------------------------------------
Напишите программу, которая принимает на вход произвольное (пятизначное) число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
----------------------------------------------------------------------------------------------------------------------*/

int FirstNumPart(int x) //function to split number to two parts and return the first
{
    int i=0;                        //index
    int res=0;                      //result
    int[] xDgt=new int[100];        //array to keep digits
        
    while(x>0)                      //splitting x to digits
    {
        xDgt[i++]= x%10;
        x/=10;
    }
    for(int j=i-1;j>=i/2;j--)       //packing first half of the number to result
    {
        res=res+xDgt[j]*Convert.ToInt32(Math.Pow(10,j-i/2));
    }
    return res;
}

int SecondNumPart(int x)
{
    int i=0;                        //index




    int res=0;                      //result
    int[] xDgt=new int[100];        //array to keep digits
    
    while(x>0)                      //splitting x to digits
    {
        xDgt[i++]= x%10;
        x/=10;
    }
    if(i%2==0)                      //checking if we have even either odd digits number
    {
        for(int j=0;j<i/2;j++)
            res=res+xDgt[j]*Convert.ToInt32(Math.Pow(10,i/2-j-1)); //packing resut for even digits num
    }
    else
        for(int j=0;j<=i/2;j++)
            res=res+xDgt[j]*Convert.ToInt32(Math.Pow(10,i/2-j)); //packing resut for odd digits num
    return res;
}

bool CheckPalindrom(int x)          //to split number into two parts and compare them
{
    int a,b;
    a=FirstNumPart(x);
    b=SecondNumPart(x);
    return a==b;
}


while(true)  //main
{
    Console.Write("Введите число для проверки на палиндром или \"q\" для выхода: ");
    string input = Console.ReadLine();
    if(input.ToLower()=="q")
        return;
    int x = Convert.ToInt32(input);
    bool isPalindrom = CheckPalindrom(x);
    if(isPalindrom)
        Console.WriteLine($"{FirstNumPart(x)} == {SecondNumPart(x)} => {isPalindrom}");
    else
        Console.WriteLine($"{FirstNumPart(x)} != {SecondNumPart(x)} => {isPalindrom}");
}