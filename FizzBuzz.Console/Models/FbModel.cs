using System.Text;

namespace FizzBuzz.Console.Models
{
    public class FbModel : IEntity
    {
        public int Id { get; set; }
        public IList<string>? fbStrings { get; set; }

        public string RunFizzBuzz()
        {
            string fbString = "";

            IEnumerable<int> fblist = Enumerable.Range(1, 100);

            foreach (var fb in fblist)
            {
                fbString = (fb % 15 == 0)
                    ? fbString + $" FizzBuzz"
                    : (
                        (fb % 3 == 0)
                        ? fbString + $" Fizz"
                        : (
                            (fb % 5 == 0)
                            ? fbString + $" Buzz" : fbString + $" {fb.ToString()}"
                          )
                       ).ToString();

                if (fb != 100) fbString = fbString + ",";
                    
            }
            
            return fbString; 
        }
    }

}
