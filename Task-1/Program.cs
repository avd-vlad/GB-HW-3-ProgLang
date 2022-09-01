/*----------------------------------------------------------------------------------------------------------------------
Напишите программу, которая принимает на вход произвольное (пятизначное) число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
----------------------------------------------------------------------------------------------------------------------*/
/*
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
*/

long ReverseNum(long x)
{
    int cntDgt=0;                        //index
    long res=0;                      //result
    long xX=x;

    while(xX>0)                      //splitting x to digits
    {
        xX/=10;
        cntDgt++;
    }
    for(int j=cntDgt;j>0;j--)
    {
        res=res+x%10*Convert.ToInt64(Math.Pow(10,j-1)); //reversing number
        x/=10;
    }
    return res;
}

bool CheckPalindrom(long x)          //to split number into two parts and compare them
{
 /*
    int a,b;
    a=FirstNumPart(x);
    b=SecondNumPart(x);
*/
    return x==ReverseNum(x);
}

bool CheckPalindrom1(long x, ref long newX)          //to split number into two parts and compare them
{
    long oldX=x;
    
    newX=0;
    while(x>0)                      
    {
        newX*=10;
        newX=newX+x%10;                    //reversing x to newX
        x/=10;
    }
    return newX==oldX;
}

while(true)  //main
{
    Console.Write("Введите число для проверки на палиндром или \"q\" для выхода: ");
    string input = Console.ReadLine();
    if(input.ToLower()=="q")
        return;
    long x = Convert.ToInt64(input);
    long newX=0;
    bool isPalindrom = CheckPalindrom1(x, ref newX);

    if(isPalindrom)
        Console.WriteLine($"{x} == {newX} => {isPalindrom}");
    else
        Console.WriteLine($"{x} != {newX} => {isPalindrom}");

}
