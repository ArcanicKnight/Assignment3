using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace BDSA2020.Assignment03.Tests
{
    public class QueriesTests
    {
        private Queries queries = new Queries();
        
        [Fact]
        public void Queries_TestRowling()
        {
            // Arrange
            IEnumerable<string> expected = new List<string>() {"Severus Snape", "Albus Dumbledore"};

            // Act
            var result = queries.Rowling();
            
            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void Queries_TestRowlingExtension()
        {
            // Arrange
            IEnumerable<string> expected = new List<string>() {"Severus Snape", "Albus Dumbledore"};

            // Act
            var result = queries.RowlingExtension();
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Queries_TestFirstSithLord()
        {
            // Arrange
            IEnumerable<int?> expected = new List<int?>() {1977};

            // Act
            var result = queries.FirstSithLord();
            
            // Assert
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Queries_TestFirstSithLordExtension()
        {
            // Arrange
            IEnumerable<int?> expected = new List<int?>() {1977};

            // Act
            var result = queries.FirstSithLordExtension();
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Queries_TestHarryPotterList()
        {
            // Arrange
            IEnumerable<Tuple<string,int?>> expected = new List<Tuple<string,int?>>() {new ("Severus Snape",2001), new ("Albus Dumbledore",2001)};

            // Act
            var result = queries.HarryPotterList();
            
            // Assert
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Queries_TestHarryPotterListExtension()
        {
            // Arrange
            IEnumerable<Tuple<string,int?>> expected = new List<Tuple<string,int?>>() {new ("Severus Snape",2001), new ("Albus Dumbledore",2001)};

            // Act
            var result = queries.HarryPotterListExtenxion();
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Queries_TestReversedWizard()
        {
            // Arrange
            IEnumerable<string> expected = new List<string>()
            {
                "Dr. Strange",
                "Glinda the Good Witch",
                "Gandalf the Grey",
                "Sauron",
                "Albus Dumbledore",
                "Severus Snape",
                "Merlin",
                "Darth Maul",
                "Darth Vader",
                "Yoda"
            };
            
            // Act
            var result = queries.ReverseWizard();
            
            // Assert
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void Queries_TestReversedWizardExtension()
        {
            // Arrange
            IEnumerable<string> expected = new List<string>()
            {
                "Dr. Strange",
                "Glinda the Good Witch",
                "Gandalf the Grey",
                "Sauron",
                "Albus Dumbledore",
                "Severus Snape",
                "Merlin",
                "Darth Maul",
                "Darth Vader",
                "Yoda"
            };
            
            // Act
            var result = queries.ReverseWizardExtension();
            
            // Assert
            Assert.Equal(expected,result);
        }
    }
}