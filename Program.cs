using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook
{
    public class Note
    {
        private static int notes_quantity = 0;
        public int id;
        public long phone = 0;
        public string bday = "";
        public string name = "";
        public string lastName = "";
        public string middleName = "";
        public string country = "";
        public string org = "";
        public string position = "";
        public string others = "";
        public Note(string n, string l, string m, string c, string o, string p, string b, string others, long phone)
        {
            this.phone = phone;
            this.bday = b;
            this.name = n;
            this.lastName = l;
            this.middleName = m;
            this.country = c;
            this.org = o;
            this.position = p;
            this.others = others;
        }
        public void showNote()
        {
            Console.WriteLine("Name: " + name + "\n" +
                "Last Name: " + lastName + "\n" +
            "Middle Name: " + middleName + "\n" +
                "Phone Number: " + phone + "\n" +
                "Birth day: " + bday + "\n" +
                "Country: " + country + "\n" +
                "Organization: " + org + "\n" +
                "Position: " + position + "\n" +
                "Others: " + others + "\n");
        }
        public void redactNote()
        {
                    Program.showNotes();

                    Console.WriteLine("Last Name:");
                    lastName = Console.ReadLine();
                    Console.WriteLine("Name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Middle Name:");
                    middleName = Console.ReadLine();
                    Console.WriteLine("Phone:");
                    phone = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Country:");
                    country = Console.ReadLine();
                    Console.WriteLine("Date of birth:");
                    bday = Console.ReadLine();
                    Console.WriteLine("Org:");
                    org = Console.ReadLine();
                    Console.WriteLine("Position:");
                    position = Console.ReadLine();
                    Console.WriteLine("Other notes:");
                    others = Console.ReadLine();
            }
        }
    }

namespace Notebook
{
    class Program
    {
        static List<Note> notes = new List<Note>();
        static void Main(string[] args)
        {
            selectAction();
        }
        public static void selectAction()
        {
            Console.WriteLine("Create new note: 1");
            Console.WriteLine("Show note: 2");
            Console.WriteLine("Edit note: 3");
            Console.WriteLine("Delete note: 4");
            Console.WriteLine("Exit: 6");
            Console.WriteLine("Select action:");
            switch (Console.ReadLine())
            {
                case "1":
                    notes.Add(createNote());
                    selectAction();
                    break;
                case "2":
                    showNotes();
                    selectAction();
                    break;
                case "3":
                    Console.WriteLine("Select index: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    notes[index].redactNote();
                    showNotes();
                    selectAction();
                    break;
                case "4":
                    Console.WriteLine("Select index: ");
                    int i = 0;
                    i = Convert.ToInt32(Console.ReadLine());
                    notes.RemoveAt(i);
                    showNotes();
                    break;
                default:
                    Console.WriteLine("Error. Try again.");
                    selectAction();
                    break;
            }
        }
        public static Note createNote()
        {
            Console.WriteLine("Enter information about person." + "\n");
        Name:
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            if (name == "")
            {
                goto Name;
            }
        LastName:
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            if (lastName == "")
            {
                goto LastName;
            }
            Console.Write("Middle Name: ");
            string middleName = Console.ReadLine();
        Phone:
            Console.Write("Phone Number: ");
            long phone = Convert.ToInt64(Console.ReadLine());
            if (phone == 0)
            {
                goto Phone;
            }
            Console.Write("Birth day: ");
            string bday = Console.ReadLine();
            Console.Write("Country: ");
            string country = Console.ReadLine();
            Console.Write("Organization: ");
            string org = Console.ReadLine();
            Console.Write("Position: ");
            string position = Console.ReadLine();
            Console.Write("Others: ");
            string others = Console.ReadLine();
            Note note = new Note(name, lastName, middleName, country, org, position, bday, others, phone);
            return note;
        }
        public static void showNotes()
        {
            if (notes.Count == 0)
            {
                Console.WriteLine("Note is empty!");
            }
            for (int i = 0; i < notes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Last Name: {notes[0].lastName}. Name: {notes[0].name}. Phone: {notes[0].phone}");
            }


        }
    }
}
