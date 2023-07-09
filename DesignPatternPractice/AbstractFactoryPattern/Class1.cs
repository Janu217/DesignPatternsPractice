using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
	public class Example
    {
		static Example()
        {
			Console.WriteLine("Static constructor");
        }

		public Example()
        {
			Console.WriteLine("Non-static constructor");
        }

		
    }

	public interface ISourceCourseFactory1
	{
		Isource1 GetIsource1();
		Icourse1 GetIcourse1();
	}

	public interface Isource1
	{
		public void GetDetails();
	}

	public interface Icourse1
	{
		public void GetDetails();
	}

	public class OnlineSource1 : Isource1
	{
		public void GetDetails()
		{
			Console.WriteLine("OnlineSource");
		}
	}

	public class OfflineSource1 : Isource1
	{
		public void GetDetails()
		{
			Console.WriteLine("OfflineSource");
		}
	}

	public class FrontEndSource1 : Icourse1
	{
		public void GetDetails()
		{
			Console.WriteLine("FrontEndSource");
		}
	}

	public class BackEndEndSource1 : Icourse1
	{
		public void GetDetails()
		{
			Console.WriteLine("BackEndEndSource");
		}
	}

    public class OnLineSourceFrontEndCourseFactory1 : ISourceCourseFactory1
    {
        public Icourse1 GetIcourse1()
        {
			return new FrontEndSource1();
        }

        public Isource1 GetIsource1()
        {
			return new OnlineSource1();

		}
    }

	public class OfflineSourceBackEndCourseFactory1 : ISourceCourseFactory1
	{
		public Icourse1 GetIcourse1()
		{
			return new BackEndEndSource1();
		}

		public Isource1 GetIsource1()
		{
			return new OfflineSource1();

		}
	}

	
}
