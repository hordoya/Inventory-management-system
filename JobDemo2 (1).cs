using System;

public class Job
{
	private int _job_number;
	private string _customer_name;
	private string _job_description;
	private int _estimated_hour;
	private int _price;

	public Job(int job_number, string c_name, string j_des, int e_hour)
	{
		_job_number = job_number;
		_customer_name = c_name;
		_job_description = j_des;
		_estimated_hour = e_hour;
		_price = e_hour * 45;

	}

	public int job_number
	{
		get
		{
			return _job_number;
		}
		set
		{
			_job_number = value;
		}

	}

	public string job_description
	{
		get
		{
			return _job_description;

		}
		set
		{
			_job_description = value;
		}

	}

	public string customer_name
	{
		get
		{
			return _customer_name;

		}
		set
		{
			_customer_name = value;
		}

	}


	public int get_price()
	{

		return _price;

	}

	public bool Equals(Job j)
	{
		if (j._job_number == this._job_number)
		{
			return true;
		}
		else
		{
			return false;
		}

	}

	public override int GetHashCode()
	{
		return this._job_number;
	}

	public override string ToString()
	{
		return "Job Number: " + _job_number + " Customer name: " + _customer_name + " Job Description: " + _job_description + " Estimated Hours: " + _estimated_hour + " Price: " + _price;
	}

	public static void Main(string[] args)
	{
		Job[] joblist = new Job[5];
		int job_number;
		string customer_name;
		string job_description;
		int estimated_hour;


		bool take_input = true;
		int index = 0;
		while (take_input)
		{
			Console.WriteLine("Enter Job Number");
			job_number = int.Parse(Console.ReadLine());
			int duplicate = 0;
			for (int i = 0; i < index; i++)
			{
				if (joblist[i].job_number == job_number)
				{
					Console.WriteLine("Job Already Exists.Please Enter a new job");
					duplicate = 1;
					break;
				}
			}
			if (duplicate == 1)
			{
				continue;
			}

			if (duplicate == 0)
			{
				Console.WriteLine("Enter Customer Name");
				customer_name = Console.ReadLine();
				Console.WriteLine("Enter Job Description");
				job_description = Console.ReadLine();
				Console.WriteLine("Enter Estimated Hour");
				estimated_hour = int.Parse(Console.ReadLine());
				joblist[index] = new Job(job_number, customer_name, job_description, estimated_hour);
				Console.WriteLine("Job Added Successfully\n\n");
				index++;
			}
			if(index==5)
            {
				Console.WriteLine("Five Jobs Added Successfully\n\n");
				take_input = false;
            }


		}
		int total_price = 0;
		for(int i=0;i<joblist.Length;i++)
        {
			Console.WriteLine(joblist[i].ToString());
			total_price += joblist[i].get_price();
        }
		Console.WriteLine(total_price);
	}
}

