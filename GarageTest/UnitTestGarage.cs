using AssignFive.TheGarage;
using AssignFive.TheVehicles;
using System.Collections;
using System.Drawing;
using System.Security.Cryptography;

namespace GarageTest
{
    public class GarageTests
    {
        [Fact]
        public void InitiatingNewGarageArrayObject()
        {
            // Arrange
            Garage<Vehicle> garageArrayTest; 
            
            // Act
            garageArrayTest = Garage<Vehicle>.OwnArr(100);

            // Assert
            Assert.True(garageArrayTest != null);
        }

        [Fact]  
        public void InitiatingNewVehicleObject()
        {
            // Arrange
            string regNumber = "GGD725";
            int numberOfWheels = 2;
            string color = "Violet";
            int cylVolume = 850;

            // Act (Made Motorcycle class public during test - could have made test for private vs public as well)
            Motorcycle mCycle = new(regNumber, numberOfWheels, color, cylVolume);
           
            // Assert
            Assert.Equal(cylVolume, mCycle.CylVolume);
        }

        [Fact]
        public void AddingVehicleToArrayThruParkMethod()
        {
            // Arrange
            Garage<Vehicle> garageParkTestArray = Garage<Vehicle>.OwnArr(10);
            Motorcycle mCycle = new("GGD725", 2, "Violet", 850);

            // Act
            garageParkTestArray.Park(mCycle);


            // Assert
            Assert.True(garageParkTestArray.Any());
        }

        [Fact]
        public void RemoveVehicleFromArrayThruUnparkMethod()
        {
            // Arrange
            Garage<Vehicle> garageParkTestArray = Garage<Vehicle>.OwnArr(10);
            Motorcycle mCycle = new("GGD725", 2, "Violet", 850);
            garageParkTestArray.Park(mCycle);

            // Act
            garageParkTestArray.Unpark(mCycle.Color);

            // Assert
            Assert.False(garageParkTestArray.Any());

        }

    }
}