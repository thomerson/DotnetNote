using System;
using System.Collections.Generic;
using System.Text;

namespace Thomerson.DotnetNote
{
    class DotnetMath
    {
        public static void Test()
        {
            //四舍六入五成双
            //被修约的数字小于5时，该数字舍去； 四舍
            //被修约的数字大于5时，则进位； 六入
            //五成双[后进前奇进]被修约的数字等于5时：若5的后面还有不为“0”的任何数，则此时无论5的前面是奇数还是偶数，均应进位
            //           5前面的数字，若是奇数则进位，若是偶数则将5舍掉，即修约后末尾数字都成为偶数；
            Console.WriteLine("Math.Round(1.2600, 2) = " + Math.Round(1.2600, 2));
            Console.WriteLine("Math.Round(1.2550, 2) = " + Math.Round(1.2550, 2));
            Console.WriteLine("Math.Round(1.2551, 2) = " + Math.Round(1.2551, 2));

            //四舍五入
            Console.WriteLine("Math.Round(1.2551, 2) = " + Math.Round(1.2551, 2, MidpointRounding.AwayFromZero));
        }
    }
}
