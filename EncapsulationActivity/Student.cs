using System;
namespace EncapsulationActivity.Student
{

	public class Student
	{
		private readonly string _stu_name;
		private string _stu_grade;
		private int _stu_group;
		
		private const string _secret_nick_name = "MySecretNickName";

		public Student(string stu_name, string stu_grade, int stu_group)
		{
			_stu_name = stu_name;
			Stu_Grade = stu_grade;
			Stu_Group = stu_group;

		}

		public string Stu_Name => _stu_name;

		public string Stu_Grade
		{
			get { return _stu_grade; }
			set
            {_stu_grade = (value =="A"||value =="B"||value =="C"||value =="D"||value=="E"||value=="F")? value : "The given Grade is Invalid.Please check the grade";}
		}
		
		public int Stu_Group
		{
			get { return _stu_group; }
			set
			{_stu_group = (value == 1 || value == 2 || value == 3 || value == 4 || value == 5) ? value : 0;}
		}

		public void DisplayStudentGradeReport()
		{
			Console.WriteLine($" Student Name: {Stu_Name} \n Student Group : {Stu_Group} \n Initial Grade : {Stu_Grade} \n Upgraded Grade: {StudentGradeUpgrade()} \n Downgraded Grade: {StudentGradeDowngrade()}");
		}


		public String StudentGradeUpgrade()
		{
			switch (Stu_Grade)
			{
				case "F":
					return "E";

				case "E":
					return "D";

				case "D":
					return "C";

				case "C":
					return "B";

				case "B":
					return "A";

				default:
					return Stu_Grade;
			}
		}

		public String StudentGradeDowngrade()
		{
			switch (Stu_Grade)
			{
				case "A":
					return "B";

				case "B":
					return "C";

				case "C":
					return "D";

				case "D":
					return "E";

				case "E":
					return "F";

				default:
					return Stu_Grade;
			}

		}
	}
}

