namespace Program
{
	

	
	class Data_base
	{
		public class student
		{
			public int flag = 0;
			public long phone = 0;
			public string bday;
			public string name = "";
			public string lastName = "";
			public string middleName = "";
			public string country = "";
			public string org = "";
			public string position = "";
			public string others = "";
		};
		public const int N =3;
		public student[] array = new student[N];
		static List<student> students = new List<student>();
		public void empty_element(int index)
		{
			if (array[index].flag == 0)
			{
				Console.WriteLine("Clear!");
			}
			else
			{
				array[index]=null;
			}
		}
		public void free_struct_var()
		{
			for (int i = 0; i < N; i++)
			{
				if (array[i].flag == 0)
				{
					Console.WriteLine(i + " place is free");
					break;
				}
			}
		}
		public void input_struct_var(int index, student s)
		{
            
			array[index] = s;
			students.Add(s);
			Console.WriteLine("index - " + index + " name - " + array[index].name);
			array[index].flag = 1;
			//this.array[index].flag = 1;
			this.array[index].name = s.name;
			//this.array[index].recbook_num = s.recbook_num;
			//this.array[index].fac = s.fac;
			//this.array[index].groupe = s.groupe;
		}
		public void output_struct_var(int index)
		{
            //Console.WriteLine(array[index]);
            Console.WriteLine("Name: " + array[index].name + "\n" +
				"Last Name: " + array[index].lastName + "\n" +
			"Middle Name: " + array[index].middleName + "\n" +
				"Phone Number: " + array[index].phone + "\n" +
				"Birth day: " + array[index].bday + "\n" +
				"Country: " + array[index].country+ "\n" +
				"Organization: " + array[index].org + "\n" +
				"Position: " + array[index].position + "\n" +
				"Others: " + array[index].others + "\n" );
		}
		public void output_all()
		{
            foreach (var item in students)
            {
                Console.WriteLine(item.name);
            }
			Console.WriteLine("Name: " + array[0].name + "\n" +
			"Last Name: " + array[0].lastName + "\n" +
			"Phone Number: " + array[0].phone + "\n");
			Console.WriteLine("Name: " + array[1].name + "\n" +
			"Last Name: " + array[1].lastName + "\n" +
			"Phone Number: " + array[1].phone + "\n");
			Console.WriteLine("Name: " + array[2].name + "\n" +
			"Last Name: " + array[2].lastName + "\n" +
			"Phone Number: " + array[2].phone + "\n");
			for (int i = 0; i < N; i++)
			{
				if (array[i].flag == 1)
				{
					//Console.WriteLine("Name: " + array[i].name + "\n" +
				//"Last Name: " + array[i].lastName + "\n" +
				//"Phone Number: " + array[i].phone + "\n");
				}
				else break;
			}
		}
		public void edit_element(int index)
        {
			Data_base db = new Data_base();
			student st = new student();
			Console.WriteLine("Enter new info: ");
			Console.WriteLine("Enter information about " + (index + 1) + " student." + "\n");
		Name:
			Console.Write("Enter name: ");
			st.name = Console.ReadLine();
			if (st.name == "")
			{
				goto Name;
			}
		LastName:
			Console.Write("Last Name: ");
			st.lastName = Console.ReadLine();
			if (st.lastName == "")
			{
				goto LastName;
			}
			Console.Write("Middle Name: ");
			st.middleName = Console.ReadLine();
		Phone:
			Console.Write("Phone Number: ");
			st.phone = Convert.ToInt32(Console.ReadLine());
			if (st.phone == 0)
			{
				goto Phone;
			}
			Console.Write("Birth day(dd/mm/yyyy): ");
			st.bday = Console.ReadLine();
			Console.Write("Country: ");
			st.country = Console.ReadLine();
			Console.Write("Organization: ");
			st.org = Console.ReadLine();
			Console.Write("Position: ");
			st.position = Console.ReadLine();
			Console.Write("Others: ");
			st.others = Console.ReadLine();
			db.input_struct_var(index, st);
		}
		static void Main(string[] args)
		{
			Data_base db = new Data_base();
			student st = new student();
			student st1 = new student();
			student st2 = new student();
			int index = 0;
			int field = 0;
			st.name = "Rufina";
			st.lastName = "Diusheeva";
			st.phone = 48482544;
			db.input_struct_var(0, st);
			st2.name = "Milana";
			st2.lastName = "Naumova";
			st2.phone = 22222222;
			db.input_struct_var(1, st2);
			st1.name = "Nana";
			st1.lastName = "Nananna";
			st1.phone = 1111111;
			db.input_struct_var(2, st1);
			string element;
			int action;
            //db.empty_element(index);
            //db.free_struct_var();
			Try:
            Console.WriteLine("Введите действие, которое вы хотите совершить: ");
            Console.WriteLine("1)Создание новой записи\n2) Редактирование созданных записей.\n3) Удаление созданных записей.\n4) Просмотр созданных учетных записей.\n5) Просмотр всех созданных учетных записей");
			action = Convert.ToInt32(Console.ReadLine());
			switch(action)
            {
				case 1:
					for (int i = 0; i < N; i++)
					{
						Console.WriteLine("Enter information about " + (i + 1) + " person." + "\n");
					Name:
						Console.Write("Enter name: ");
						st.name = Console.ReadLine();
						if (st.name == "")
						{
							goto Name;
						}
					LastName:
						Console.Write("Last Name: ");
						st.lastName = Console.ReadLine();
						if (st.lastName == "")
						{
							goto LastName;
						}
						Console.Write("Middle Name: ");
						st.middleName = Console.ReadLine();
					Phone:
						Console.Write("Phone Number: ");
						st.phone = Convert.ToInt64(Console.ReadLine());
						if (st.phone == 0)
						{
							goto Phone;
						}
						Console.Write("Birth day: ");
						st.bday = Console.ReadLine();
						Console.Write("Country: ");
						st.country = Console.ReadLine();
						Console.Write("Organization: ");
						st.org = Console.ReadLine();
						Console.Write("Position: ");
						st.position = Console.ReadLine();
						Console.Write("Others: ");
						st.others = Console.ReadLine();
						db.input_struct_var(i, st);
					}
					goto Try;
					break;
				case 2:
					Console.WriteLine("Enter index: ");
					index = Convert.ToInt32(Console.ReadLine());
					db.edit_element(index);
					goto Try;
					break;
				case 3:
					Console.WriteLine("Enter index: ");
					index = Convert.ToInt32(Console.ReadLine());
					db.empty_element(index);
					goto Try;
					break;
				case 4:
					Console.WriteLine("Enter index: ");
					index = Convert.ToInt32(Console.ReadLine());
					db.output_struct_var(index);
					goto Try;
					break;
				case 5:
					db.output_all();
					goto Try;
					break;
				default:
					Console.WriteLine("Упс, что-то пошло не так..");
					goto Try;
					break;
            }
		}
	};

}


