using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Student_Management_System
{
    class Program
    {
        public void check()
        {
            Console.Write("\nƠ kìa bạn, sao lại gõ kí tự bạn êi" +
               "\nBấm 1 để tiếp tục\n");
            while (true)
            {
                int check = int.Parse(Console.ReadLine());

                if (check == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Tôi đếu hiểu tại sao bạn lại gõ chữ luôn ấy" +
                        "\nGõ 2 thử đê người anh em:");
                }
                else if (check == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ơ kìa, chúng mình lại gặp nhau rồi :))" +
                        "\nGõ 3 để không gặp lại:");
                }
                else if (check == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Ông tin người vãi cả nồi ra, thế thử gõ số 4 coi" +
                        "\nGõ nốt số 4 lẹ lẹ bro:");
                }
                else if (check == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Thôi chọc đủ rồi, lần sau nhớ gõ số nghe chưa! Bấm 5 để sám hối");
                }
                else if (check == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Chúc mừng bạn đã sám hối thành công! Gõ 6 để out");
                }
                else if (check == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Nãy lộn, bấm số 2 bạn nhé ^^");
                }
                else { break; }
            }            
        }          
    }
}

