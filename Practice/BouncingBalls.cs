using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Practice.Practice
{
    /*A child is playing with a ball on the nth floor of a tall building.
    The height of this floor above ground level, h, is known.
   He drops the ball out of the window.The ball bounces (for example), to two-thirds of 
   its height(a bounce of 0.66). His mother looks out of a window 1.5 meters from the ground.
How many times will the mother see the ball pass in front of her window (including when it's falling and bouncing?
Three conditions must be met for a valid experiment:
Float parameter "h" in meters must be greater than 0
Float parameter "bounce" must be greater than 0 and less than 1
Float parameter "window" must be less than h.
If all three conditions above are fulfilled, return a positive integer, otherwise return -1.

Note:
The ball can only be seen if the height of the rebounding ball is strictly greater than the window parameter.*/
    internal class BouncingBalls
    {
        int views = 1;
        public int bouncingBall(double h, double bounce, double window)
        {
            double height = h;
            double b = bounce;
            double w = window;
            double returnHeight = height * b;

            if (h > 0 && (0<b && b <1) && w<height)
            {
                while (returnHeight > window)
                {
                    views++;

                    if (returnHeight > window)
                    {
                        views++;
                    }
                    returnHeight = returnHeight * b;
                }

                return views;
            }
            else return -1;
        }
    }
}
