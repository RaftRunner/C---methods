class Program{
    static int addMethod(int x, int y){
        int sum = x + y;
        return sum;
    }

    static int subMethod(int x, int y){
        int subbedSum = x - y;
        return subbedSum;
    }

    static int multMethod(int x, int y){
        int product = x * y;
        return product;
    }

    static double divideMethod(double x, double y){
        double divided = x / y;
        return divided;
    }

    static void Main(string[] args){
        int a = 3;
        int b = 4;

        double c = 3.34;
        double d = 5.8;

        int sum = addMethod(a,b);    
        Console.WriteLine(sum);

        int subbedSum = subMethod(b,a);
        Console.WriteLine(subbedSum);

        int product = multMethod(b,a);
        Console.WriteLine(product);
        
        double divided = divideMethod(c,d);
        Console.WriteLine(divided);
    }
}