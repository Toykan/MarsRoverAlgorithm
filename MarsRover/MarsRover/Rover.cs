using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public int x; //rover x coordinate
        public int y; //rover y coordinate
        public string direction;
        public Rover(string location)
        {
            Int32.TryParse(location.Split(" ")[0], out x);
            Int32.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];

        }

        public void SpinRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }


        public void SpinLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }            
        }

        public void StepForward()
        {
            switch (direction)
            {
                case "N":
                    y = y + 1;
                    break;
                case "E":
                    x = x + 1;
                    break;
                case "S":
                    y = y - 1;
                    break;
                case "W":
                    x = x - 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void GoLocation(string roverCommand) //"LMLMLMLMM"   // "MMRMMRMRRM"
        {
            char[] directions = roverCommand.ToCharArray();

            for (int i = 0; i < directions.Length; i++)
            {
                switch (directions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}
