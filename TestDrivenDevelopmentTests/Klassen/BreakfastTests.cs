using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment.Klassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Klassen.Tests
{
    [TestClass()]
    public class BreakfastTests
    {
        [TestMethod()]
        
        public void TestPouringCoffee()
        {
            var coffee = Breakfast.PourCoffee();
            Assert.IsTrue(typeof(Coffee) == coffee.GetType());

        }

        [TestMethod()]
        public void TestCoffeeTemperature()
        {
            var coffee = Breakfast.PourCoffee();
            Assert.Equal("Hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Quite hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Not so hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Cold", coffee.Temperature);
        }

        [TestMethod()]
        public void TestFryingEggsLength()
        {
            var eggs = Breakfast.FryEggs(2);
            Assert.Equal(2, eggs.Length);
            Assert.Equal("2 eggs", eggs.Print());
        }

        [TestMethod()]
        public void TestFryingBaconLength()
        {
            var bacon = Breakfast.FryBacon(3);
            Assert.Equal(3, bacon.Length);
            Breakfast.EatBacon(ref bacon, 2);
            Assert.Equal(1, bacon.Length);
        }

        [TestMethod()]
        public void TestToastingBreadLength()
        {
            var toasts = Breakfast.ToastBread(2);
            Assert.Equal(2, toasts.Length);
        }

        [TestMethod()]
        public void TestApplyingToToast()
        {
            var toasts = Breakfast.ToastBread(2);

            Breakfast.ApplyButter(toasts[0]);
            Breakfast.ApplyJam(toasts[1]);

            Assert.False(toasts[0].JamApplied);
            Assert.False(toasts[1].ButterApplied);
            Assert.True(toasts[1].JamApplied);
            Assert.True(toasts[0].ButterApplied);
        }
    }
}