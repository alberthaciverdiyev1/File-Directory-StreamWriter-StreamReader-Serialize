using Newtonsoft.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<string> list = new List<string>();
            list.Add(new string("Albert"));
            list.Add(new string("Alyona"));
            list.Add(new string("Sekine"));
            list.Add(new string("Nahid"));
            list.Add(new string("Saleh"));
            list.Add(new string("Nermin"));
            list.Add(new string("Royal"));
            list.Add(new string("Murad"));
            list.Add(new string("Emil"));

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //string json = JsonConvert.SerializeObject(list);

            //using (StreamWriter sr = new StreamWriter(@"C:\Users\Alber\Desktop\ConsoleApp2\ConsoleApp2\Files\json1.json"))
            //{
            //    sr.WriteLine(json);
            //}
            Console.WriteLine(Search("Albert"));
        }

        void Add(string name)
        {
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\Alber\Desktop\ConsoleApp2\ConsoleApp2\Files\json1.json"))
            {
                result = sr.ReadToEnd();
            };
            List<string> names = JsonConvert.DeserializeObject<List<string>>(result);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Alber\Desktop\ConsoleApp2\ConsoleApp2\Files\json1.json"))
            {

                names.Add(name);
            }
            string json = JsonConvert.SerializeObject(names);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Alber\Desktop\ConsoleApp2\ConsoleApp2\Files\json1.json"))
            {
                sw.Write(json);
            }

        }



        //public static bool Search(string name)
        //{
        //    string result;
        //    using (StreamReader sr = new StreamReader(@"C:\Users\Alber\Desktop\ConsoleApp2\ConsoleApp2\Files\json1.json"))
        //    {
        //        result = sr.ReadToEnd();
        //    }

        //    List<string> names = JsonConvert.DeserializeObject<List<string>>(result);
        //    Predicate<string> predicate = new Predicate<string>(n => n == name);
        //    return names.Exists(predicate);
        //}

        public static bool Search(string name)
        {
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\Alber\Desktop\ConsoleApp2\ConsoleApp2\Files\json1.json"))
            {
                result = sr.ReadToEnd();
            }

            List<string> names = JsonConvert.DeserializeObject<List<string>>(result);
            if (names.Contains(name))
            {
                return true;
            }
            return false;
        }
        public static void Delete(int index)
        {
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\Alber\Desktop\ConsoleApp2\ConsoleApp2\Files\json1.json"))
            {
                result = sr.ReadToEnd();
            }
            List<string> names = JsonConvert.DeserializeObject<List<string>>(@"C:\Users\Alber\Desktop\ConsoleApp2\ConsoleApp2\Files\json1.json");
            names.Remove(names[index]);

            string json = JsonConvert.SerializeObject(names);
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Alber\Desktop\ConsoleApp2\ConsoleApp2\Files\json1.json"))
            {
                sw.WriteLine(json);
            }


        }


    }

}