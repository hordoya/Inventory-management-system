using System;
public class job
{

    private int hours;
    private int price;
    public static int number { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int Hours
    {
        get
        {
            return hours;
        }
        set
        {
            hours = value;
        }
    }
    public int Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }
    public virtual int totalpri()
    {
        Price = 45 * Hours;
        return Price;
    }
}
public class RushJob : job
{
    public RushJob(string na, string des, int ha)
    {
        number = this.GetHashCode();
        name = na;
        description = des;
        Hours = ha;
    }
    public override int totalpri()
    {
        Price = 150 * Hours;
        return Price;
    }
    public static int lala()
    {
        return number;
    }
}
public class JobDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many job you wanna create? please type");
        string s = Console.ReadLine();
        int n = Convert.ToInt32(s);
        RushJob[] obj = new RushJob[n];
        int[] myNum;
        myNum = new int[n];
        bool u = true;
        int[] intArray;
        intArray = new int[n];
        while (u)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please Enter job description,job hour Respectively for  " + (i + 1));

                Console.WriteLine("Enter customer Name");
                string nam = Console.ReadLine();
                Console.WriteLine("Enter Job Description");
                string des = Console.ReadLine();
                Console.WriteLine("Enter Job Hour");
                int hou = Convert.ToInt32(Console.ReadLine());
                obj[i] = new RushJob(nam, des, hou);
                myNum[i] = RushJob.lala();
                intArray[i] = RushJob.lala();
            }
            if (myNum.Length > 1)
            {
                for (int j = 0; j < myNum.Length - 1; j++)
                {
                    if (myNum[j] == myNum[j + 1])
                    {
                        Console.WriteLine("Same job number please retype");
                    }
                    else
                    {
                        u = false;
                    }
                }
            }
        }
        Array.Sort(intArray);
        Console.WriteLine("Job Numbers : ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(intArray[i]);
        }
    }
}