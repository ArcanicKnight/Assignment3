using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace BDSA2020.Assignment03
{
    public class Queries
    {
        public IReadOnlyCollection<Wizard> wizards = Wizard.Wizards.Value;
        
        public IEnumerable<string> Rowling()
        {
            return from w in wizards
                where w.Creator.Contains("Rowling")
                select w.Name;
        }

        public IEnumerable<string> RowlingExtension()
        {
            return wizards.Where(w => w.Creator.Contains("Rowling")).Select(w => w.Name);
        }

        public IEnumerable<int?> FirstSithLord()
        {
            return (from w in wizards
                where w.Name.Contains("Darth")
                orderby w.Year
                select w.Year).Take(1);
        }

        public IEnumerable<int?> FirstSithLordExtension()
        {
            return wizards.Where(w => w.Name.Contains("Darth")).OrderBy(w => w.Year).Select(w => w.Year).Take(1);
        }

        public IEnumerable<Tuple<string, int?>> HarryPotterList()
        {
            return from w in wizards
                where w.Medium.Contains("Harry Potter")
                select Tuple.Create(w.Name, w.Year);
        }

        public IEnumerable<Tuple<string, int?>> HarryPotterListExtenxion()
        {
            return wizards.Where(w => w.Medium.Contains("Harry Potter"))
                .Select(w => Tuple.Create(w.Name, w.Year));
        }

        public IEnumerable<string> ReverseWizard()
        {
            var sdraziw = from w in wizards
                orderby w.Name
                group w by w.Creator
                into creators
                orderby creators.Key descending
                select creators;

            foreach (var s in sdraziw)
            {
                foreach (var c in s)
                {
                    yield return c.Name;
                }
            }
        }
        
        public IEnumerable<string> ReverseWizardExtension()
        {
            var sdraziw = wizards.OrderBy(w => w.Name).GroupBy(w => w.Creator).OrderByDescending(w => w.Key)
                .Select(w => w);

            foreach (var s in sdraziw)
            {
                foreach (var c in s)
                {
                    yield return c.Name;
                }
            }
        }
    }
}