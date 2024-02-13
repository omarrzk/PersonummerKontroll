using System;
using Xunit;
using PersonnummerVerifiering;
namespace PersonnummerVerifiering.Tests
{
    public class PersonnummerKontrollTests
    {
        [Fact]
        public void ValideraPersonnummer_ShouldReturnTrueForValidPersonnummer()
        {
            // Arrange
            string validPersonnummer = "8808214855"; // Ett giltigt personnummer

            // Act
            bool result = PersonnummerKontroll.ValideraPersonnummer(validPersonnummer);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValideraPersonnummer_ShouldReturnFalseForInvalidPersonnummer()
        {
            // Arrange
            string invalidPersonnummer = "9003994855"; // Ett ogiltigt personnummer

            // Act
            bool result = PersonnummerKontroll.ValideraPersonnummer(invalidPersonnummer);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void HämtaKönFrånPersonnummer_ShouldReturnManForMalePersonnummer()
        {
            // Arrange
            string malePersonnummer = "8808214855"; // Ett manligt personnummer

            // Act
            string kön = PersonnummerKontroll.HämtaKönFrånPersonnummer(malePersonnummer);

            // Assert
            Assert.Equal("Man", kön);
        }

        [Fact]
        public void HämtaKönFrånPersonnummer_ShouldReturnKvinnaForFemalePersonnummer()
        {
            // Arrange
            string femalePersonnummer = "8808214856"; // Ett kvinnligt personnummer

            // Act
            string kön = PersonnummerKontroll.HämtaKönFrånPersonnummer(femalePersonnummer);

            // Assert
            Assert.Equal("Kvinna", kön);
        }
    }
}
