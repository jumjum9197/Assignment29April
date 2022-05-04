
using System;
using System.Collections;
using System.Linq;
namespace Assignment29April
{
    public class Jumoke
    {
        
        static void Main()
        {
            var emp = Employee.Main1();
            var lastName = emp.Where(x => x.LastName.StartsWith("D"));
            foreach (var item in lastName)
            {
                Console.WriteLine($"lastname:{item.LastName}");
            }

            Console.WriteLine(      "/n ++++++++++++/n");
            var older = emp.Where(o => o.Age > 40).OrderByDescending(o => o.FirstName);
            var lastPerson = older.First();
            Console.WriteLine($"age: {lastPerson.Age} name :{lastPerson.FirstName}+{lastPerson.LastName}");


            Console.WriteLine("OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOoo");

            string[] words =
            {

            "abstract", "add*", "alias*", "as", "ascending*",
                 "async*", "await*", "base","bool", "break",
             "by*", "byte", "case", "catch", "char", "checked",
             "class", "const", "continue", "decimal", "default",
             "delegate", "descending*", "do", "double",
             "dynamic*", "else", "enum", "event", "equals*",
             "explicit", "extern", "false", "finally", "fixed",
             "from*", "float", "for", "foreach", "get*", "global*",
             "group*", "goto", "if", "implicit", "in", "int",
             "into*", "interface", "internal", "is", "lock", "long",
             "join*", "let*", "nameof*", "namespace", "new", "null",
             "object", "on*", "operator", "orderby*", "out",
             "override", "params", "partial*", "private", "protected",
             "public", "readonly", "ref", "remove*", "return", "sbyte",
             "sealed", "select*", "set*", "short", "sizeof",
             "stackalloc", "static", "string", "struct", "switch",
             "this", "throw", "true", "try", "typeof", "uint", "ulong",
             "unsafe", "ushort", "using", "value*", "var*", "virtual",
             "unchecked", "void", "volatile", "where*", "while", "yield*"




            };
            Console.WriteLine("888888888888888888888888");
            var containE = words.Where(b => b.Contains("e")).OrderBy(b => b);

            foreach (var word in containE)
            {
                Console.WriteLine(word);

            }
            Console.WriteLine("#############################33");


            var lastword = containE.Last();


            Console.WriteLine(lastword);

            Console.WriteLine("))))))))))))))))))))))))))))))0000");


            var select = words.Where(b => b.Contains("*")).OrderBy(b => b);
            foreach (var word in select)
            {

                Console.WriteLine(word);
            }
            Console.WriteLine("Ppppppppppppp\n");



            string[] nonEmpty = { "plane", "ferry", "car", "bike" };
            var contain = nonEmpty.OrderBy(b => b)
                .Where(b => b.Contains("e"));

            //foreach (var a in contain)
            //{
            //    Console.WriteLine(a);

            //}
            var b = contain.First();

            Console.WriteLine(b);






        }



    }  



    

}   
      


  



