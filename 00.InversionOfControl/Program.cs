using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.InversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueExecution = true;
            do
            {
                Console.Write("Ոݔ����������:");
                var firstName = Console.ReadLine();

                Console.Write("Ոݔ��������:");
                var lastName = Console.ReadLine();

                Console.Write("���Ƿ�Ҫ����? Y/N: ");

                var wantToSave = Console.ReadLine();

                if (wantToSave.ToUpper() == "Y")
                    SaveToDB(firstName, lastName);

                Console.Write("���Ƿ�Ҫ�Y���x�_? Y/N: ");

                var wantToExit = Console.ReadLine();

                if (wantToExit.ToUpper() == "Y")
                    continueExecution = false;

            } while (continueExecution);
        }

        private static void SaveToDB(string firstName, string lastName)
        {
            //���@�e��Ҫ��ݔ����ա��������뵽�Y�ώ��
            Console.WriteLine($"{lastName} {firstName} �ѽ����뵽�Y�ώ����");
        }
    }
}
