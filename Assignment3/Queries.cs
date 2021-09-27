using System.Linq;

namespace BDSA2020.Assignment03
{
    public class Queries
    {
        public static void Main(string[] args)
        {
            var wizards = Wizard.Wizards.Value;

            var rowling = from w in wizards
                where w.Creator.Contains("Rowling")
                select w.Name;
            
        }
    }
}