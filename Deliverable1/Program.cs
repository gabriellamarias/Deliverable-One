using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputUnitAmount; 
            string userInputUnitType;
            string userInputUnitToConvertTo;
            string userInputContinue;
            string userContinue = "yes";
            bool userAnswer = true;

            string unitNameInch = "inch";
            string unitNameFoot = "foot";
            string unitNameFidgetSpinners = "fidget spinners";
            string unitNameMemes = "memes";

            double realNumberUnitAmount = 0.0;
            double convertedUnit = 0.0;
            double unitFidgetSpinners = 3.5;
            double unitMemes = 5;

            while(userAnswer == true)
            {
             Console.Write("Please enter the unit amount you wish to convert: ");
                userInputUnitAmount = Console.ReadLine();
                realNumberUnitAmount = Convert.ToDouble(userInputUnitAmount);

                Console.Write("Please enter the unit type you are trying to convert: ");
                userInputUnitType = Console.ReadLine();

                Console.Write("Please enter the unit type you are trying to convert to: ");
                userInputUnitToConvertTo = Console.ReadLine();

                if (userInputUnitType.ToLower() == unitNameInch && userInputUnitToConvertTo.ToLower() == unitNameFidgetSpinners)
                        {convertedUnit = realNumberUnitAmount * unitFidgetSpinners;
                    Console.Write(realNumberUnitAmount );
                    Console.Write(" inches is equal to ");
                    Console.Write(convertedUnit );
                    Console.WriteLine(" fidget spinners");
                }

                if (userInputUnitType.ToLower() == unitNameFidgetSpinners && userInputUnitToConvertTo.ToLower() == unitNameInch)
                {
                    convertedUnit = realNumberUnitAmount / unitFidgetSpinners;
                    Console.Write(realNumberUnitAmount);
                    Console.Write(" fidget spinners is equal to ");
                    Console.Write(convertedUnit);
                    Console.WriteLine(" inches");
                }

                if (userInputUnitType.ToLower() == unitNameFoot && userInputUnitToConvertTo.ToLower() == unitNameMemes)
                {
                    convertedUnit = realNumberUnitAmount * unitMemes;
                    Console.Write(realNumberUnitAmount);
                    Console.Write(" feet is equal to ");
                    Console.Write(convertedUnit);
                    Console.WriteLine(" memes");
                }

                if (userInputUnitType.ToLower() == unitNameMemes && userInputUnitToConvertTo.ToLower() == unitNameFoot)
                {
                    convertedUnit = realNumberUnitAmount / unitMemes;
                    Console.Write(realNumberUnitAmount);
                    Console.Write(" memes is equal to ");
                    Console.Write(convertedUnit);
                    Console.WriteLine(" feet");
                }

                Console.WriteLine("Do you wish to continue converting units?: ");

                userInputContinue = Console.ReadLine();
                if (userInputContinue.ToLower() != userContinue.ToLower())
                {
                    userAnswer = false;
                }

                


            }





           

        }
    }
}

