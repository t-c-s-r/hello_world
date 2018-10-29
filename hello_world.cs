using System;
namespace helloworld{/* is namespace declarartion?*/

public class hello/* a class?*/
{
    public void greet()/*a class method*/
    {
        System.Console.WriteLine("Hello, World!");/*statement*/
    }
}
}/*name space ends */



 public class maingreetingclass
    {
        public static void Main()/*a main method*/
        {
    
            var greetsworld = new helloworld.hello();
            greetsworld.greet();
            
        }
    }
