namespace hw_23._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.Write("Номер 1\n\nСписок: ");

            try
            {
                List<int> nums = new List<int> { 1, 2, -1, -2, -3, 3 };
                foreach (int i in nums) { Console.Write(i + " "); }

                List<int> nums_pol = nums.Where(n => n > 0).ToList();
                Console.WriteLine("\nСреднее арифм: " + nums_pol.Sum() / nums_pol.Count);

                Console.Write("\nСписок: ");
                nums = new List<int> { -1, -2, -1, -2, -3, -3 };
                foreach (int i in nums) { Console.Write(i + " "); }

                nums_pol = nums.Where(x => x > 0).ToList();
                if(nums_pol.Count == 0)
                {
                    throw new NoPositiveNumbersException("Положительных чисел не нашлось");
                }
                Console.WriteLine("Среднее арифм: " + nums_pol.Sum() / nums_pol.Count); 
            }
            catch (NoPositiveNumbersException ex) { Console.WriteLine("\nNoPositiveNumbersException: " + ex.Message); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            // 2
            Console.WriteLine("\nНомер 2\n");

            try
            {
                ContactsManager contactsManager = new ContactsManager();
                contactsManager.AddContact("name1", "number1");
                contactsManager.AddContact("name2", "number2");
                contactsManager.AddContact("name1", "number3");

                Console.WriteLine("name1: ");
                foreach (Contact cont in contactsManager.FindContactByName("name1"))
                {
                    Console.WriteLine($"Name: {cont.Name} Phone: {cont.PhoneNumber}");
                }
                Console.WriteLine("\nname2: ");
                foreach (Contact cont in contactsManager.FindContactByName("name2"))
                {
                    Console.WriteLine($"Name: {cont.Name} Phone: {cont.PhoneNumber}");
                }

                contactsManager.AddContact("", "5648");
            }
            catch(InvalidContactException ex) { Console.WriteLine("\nInvalidContactException: " + ex.Message); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}