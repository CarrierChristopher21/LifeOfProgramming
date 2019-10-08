using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inheritance.Models
{
	public class Person
	{
		private string idNumber = "n/a";
		private string firstName = "n/a";
		private string lastname = "n/a";
		private string middlename = "n/a";

		public string IDNumber
		{
			get
			{
				return idNumber;
			}
			set
			{
				idNumber = value;
			}
		}
		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				firstName = value;
			}
		}
		public string LastName
		{
			get
			{
				return lastname;
			}
			set
			{
				lastname = value;
			}
		}
		public string MiddleName
		{
			get
			{
				return middlename;
			}
			set
			{
				middlename = value;
			}
		}
		public string FullName
		{
			get
			{
				string fullName = "";
				fullName = fullName + FirstName + " " + MiddleName + " " + LastName;
				return fullName;
			}
		}

		public Person()
		{

		}

		public Person(string anID, string aFirstName, string aMiddleName, string aLastName)
		{
			this.IDNumber = anID;
			this.FirstName = aFirstName;
			this.MiddleName = aMiddleName;
			this.LastName = aLastName;
		}

		// The br tags are only for display for learning purposes!
		public virtual string Display()
		{
			string stats = "First Name: " + this.FirstName;
			stats = stats + " Middle Name: " + this.MiddleName;
			stats = stats + " Last Name: " + this.LastName;
			return stats;
			
		}
		
	}
}