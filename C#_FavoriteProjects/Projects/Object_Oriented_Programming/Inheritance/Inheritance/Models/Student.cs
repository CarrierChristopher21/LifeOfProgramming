using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Inheritance.Models
{
	public class Student:Person
	{
		private string major = "undecided";

		public string Major
		{
			get
			{
				return major;
			}
			set
			{
				major = value;
			}
		}

		public Student( ):base()
		{
		
		}

		public Student(string anID, string aFirstName, string aMiddleName, string aLastName, string aMajor) 
		: base(anID, aFirstName, aMiddleName, aLastName)
		{
			this.Major = aMajor;
		}

		public override string Display()
		{
			string aDisplay =base.Display();
			aDisplay = aDisplay + " Major: " + Major;
			return aDisplay;
		}
		
	}
}