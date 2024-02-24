
FabonacciPlay fabonacci = new();

fabonacci.Start();


class FabonacciPlay{
    private int a = 0, b=1, c= 0;
    public List<int> List = [];
    public void Start(){
        System.Console.WriteLine("**Fabonacci**");
        System.Console.WriteLine();

        System.Console.Write("End Number : ");
        var x = System.Console.ReadLine();
        bool checkType = int.TryParse(x, out int result);
        if(!checkType){
            System.Console.WriteLine("please enter a number");
            System.Console.Write("Press any key to return");
            Start();
        }
        for (int i = 0; i < result; i++)
        {
            c = a + b;
            a = b;
            b = c;
            List.Add(a+c);
            System.Console.WriteLine($"{a} + {c} = {a+c}");
        }
        int sum = List.Sum(x => Convert.ToInt32(x));
        System.Console.WriteLine($"Total : {sum}");
    }
}