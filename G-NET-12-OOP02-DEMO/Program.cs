namespace G_NET_12_OOP02_DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP02 - Demo
            #region Without Encapsulation
            //BankAccount Account01 = new BankAccount();
            //Account01.AccountNumber = -10;//Invalid
            //Account01.Balance = -1000m;//Invalid
            //Account01.Name = "RA";//Invalid
            //Console.WriteLine(Account01.Balance);
            #endregion
            #region Encasulation
            #region Part 01
            //BankAccount Account01 = new BankAccount();
            //Account01.SetBalance(-1000m);//Set
            //Console.WriteLine(Account01.GetBalance());//Get
            #endregion
            #region Part 02
            //BankAccount account01 = new BankAccount(1111, 2000, "NNNN");
            ////account01.name="Ra";Invalid
            //account01.Name = "Ra";//Invalid Data => Set
            //Console.WriteLine(account01.Name);//Get

            //---------------------------
            ////account01.AccountNumber = 1111;Invalid
            //Console.WriteLine(account01.AccountNumber);
            //--------------------
            //account01.AccountNumber = 1212;//Valid
            //Console.WriteLine(account01.AccountNumber);
            #endregion
            #region Part 03
            //BankAccount account01 = new BankAccount(10000, "Rana Hatem", 1234)
            //{
            //    Pin = 4567
            //};
            //account01.Pin = 789654; Invalid
            //----------------------------
            //if(account01.GetBalance()>0)
            // {
            //     Console.WriteLine("Has Balance");
            // }
            //if(account01.HasBalance)
            //  Console.WriteLine(" Has Balance");



            #endregion

            #endregion
            #region Indexer
            #region Part 01
            //ToDoList toDoList = new ToDoList(3);
            //toDoList[0] = "Go To Work";
            //toDoList[1] = "Go To Gym";
            //toDoList[2] = "Go To Sleep";
            //// For Set
            //Console.WriteLine($"First Task:{toDoList[0]}");
            #endregion
            #region Part 02
            //Libraray libraray01 = new Libraray("City Libraray");
            //libraray01.AddNewBook(new Book("123-456-789", "C#"));
            //libraray01.AddNewBook(new Book("789-456-123", "Programming"));
            ////---------------------
            //Console.WriteLine(libraray01[0]);//By Position in list
            //Console.WriteLine(libraray01["123-456-789"]);// By Isbn

            #endregion
            #endregion
            #region  Static Attribute 
            //Student student01 = new Student("Ahmed");
            //Console.WriteLine($"After Creating Ahmed:TotalStudents:{Student.TotalStudents}");

            //Student student02 = new Student("Mohammed");
            //Console.WriteLine($"After Creating Mohammed:TotalStudents:{Student.TotalStudents}");

            //Student student03 = new Student("Ali");
            //Console.WriteLine($"After Creating Ali:TotalStudents:{Student.TotalStudents}");


            //Console.WriteLine(student01.Name);
            //Console.WriteLine(Student.TotalStudents);
            #endregion
            #region Static Method
            //Console.WriteLine($"At First:{Counter.GetCount()}");
            //Counter.Increment(); //1
            //Counter.Increment(); //2
            //Counter.Increment(); //3
            //Console.WriteLine($"After Increment:{Counter.GetCount()}");//3
            //Counter.Reset();
            //Console.WriteLine($"At First:{Counter.GetCount()}");//0


            #endregion
            #region Static Constructor
            //Product P01 = new Product("Laptop", 1000m);
            //Product P02 = new Product("KeyBoard", 500m);
            //Product P03 = new Product("Mouse", 255m);
            //Console.WriteLine(P03);
            #endregion
            #endregion
        }
    }
}
