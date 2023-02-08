namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public  List<object> GetValue()
        {
            List<object> result = new List<object>();
            
            for(int number = 1; number <= 100; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if(number % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (number % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else 
                {
                    result.Add(number);
                }                
            }
            return result;
        }
    }
}