using MarsRover;
using System;
using Xunit;

namespace MarsRoverTests
{
    public class RoverTest
    {
        [Fact]
        public void SpinLeft()
        {
            Rover rover = new Rover("1 2 N");
            rover.SpinLeft();
            Assert.Equal("W", rover.direction);
        }

        [Fact]
        public void SpinRight()
        {
            Rover rover = new Rover("1 2 N");
            rover.SpinRight();

            Assert.Equal("E", rover.direction);
        }

        [Fact]
        public void StepForward()
        {
            Rover rover = new Rover("1 2 N");
            rover.StepForward();

            Assert.Equal(3, rover.y);
        }

        [Fact]
        public void OneThreeN()
        {
            Rover rover = new Rover("1 2 N"); //3 3 E
            rover.GoLocation("LMLMLMLMM"); //MMRMMRMRRM

            Assert.Equal("1 3 N", rover.x + " " + rover.y + " " + rover.direction);  //5 1 E
        }
    }
}
