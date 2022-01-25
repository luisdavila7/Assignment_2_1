using System;

namespace Assignment_2_1
{
    public class NumericalCalculator
    {
        public int option;
        public double number1, number2;
        public void basicCalculator()
        {
            Console.WriteLine("The Number Calculator");
            Console.Write("Insert a Number 1: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Insert a Number 2: ");
            number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("|--Menu Operations--|");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("5. Residual");
            Console.WriteLine("6. Pow");
            Console.WriteLine("7. Square Root");
            Console.WriteLine("8. Exit");

            do
            {
                Console.WriteLine("Select the Operation that you want: ");
                option = int.Parse(Console.ReadLine());
            } while (option != 1 && option != 2 && option != 3 && option != 4 && option != 5 && option != 6 && option != 7 && option != 8);

            switch (option)
            {
                case 1:
                    Console.WriteLine("The result of the Addition is: {0}", (number1 + number2).ToString("F2"));
                    break;
                case 2:
                    Console.WriteLine("The result of the Subtraction is: {0}", (number1 - number2).ToString("F2"));
                    break;
                case 3:
                    Console.WriteLine("The result of the Division is: {0}", (number1 / number2).ToString("F2"));
                    break;
                case 4:
                    Console.WriteLine("The result of the Multiplication is: {0}", (number1 * number2).ToString("F2"));
                    break;
                case 5:
                    Console.WriteLine("The result of the Residual is: {0}", (number1 % number2).ToString("F2"));
                    break;
                case 6:
                    Console.WriteLine("The result of the Pow is: {0}", (Math.Pow(number1, number2)).ToString("F2"));
                    break;
                case 7:
                    Console.WriteLine("The result of the Square Root for the values: {0}, {1} are: {2}, {3}", number1, number2, Math.Sqrt(number1).ToString("F2"), Math.Sqrt(number2).ToString("F2"));
                    break;
                case 8:
                    Console.WriteLine("Exiting the aplication");
                    break;
                default:
                    Console.WriteLine("Exiting the aplication");
                    break;
            }

        }

    }
    public class MatrixCalculator
    {
        public int option;
        public double[,] matrix1 = new double[3, 3];
        public double[,] matrix2 = new double[3, 3];
        public double[,] mResult = new double[3, 3];

        public void menuMatrixCalculator()
        {
            Console.WriteLine("The Matrix Calculator");
            Console.WriteLine("1. to add Matrix");
            Console.WriteLine("2. to add Substract");

            do
            {
                Console.Write("Select the Operation that you want: ");
                option = int.Parse(Console.ReadLine());

            } while (option != 1 && option != 2);

            switch (option)
            {
                case 1:
                    GetMatrix1();
                    GetMatrix2();
                    matrixResultSum();
                    break;
                case 2:
                    GetMatrix1();
                    GetMatrix2();
                    matrixResultSub();
                    break;
                default:
                    Console.WriteLine("Exiting the aplication");
                    break;
            }

        }
        public void matrixResultSum()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mResult[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("Result of the addition of the Matrix is: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", mResult[i, j]);
                }

                Console.WriteLine();
            }
        }
        public void matrixResultSub()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mResult[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            Console.WriteLine("Result of the substraction of the Matrix is:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", mResult[i, j]);
                }

                Console.WriteLine();
            }
        }
        public void GetMatrix1()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Insert a Row {0} for a Matrix 1 (please separated by space): ", i + 1);
                string[] stringRow = (Console.ReadLine().Split(' '));

                matrix1[i, 0] = Convert.ToDouble(stringRow[0]);
                matrix1[i, 1] = Convert.ToDouble(stringRow[1]);
                matrix1[i, 2] = Convert.ToDouble(stringRow[2]);

            }

            Console.WriteLine("The Matrix #1 is: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", matrix1[i, j]);
                }

                Console.WriteLine();
            }
        }
        public void GetMatrix2()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Insert a Row {0} for a Matrix 2 (please separated by space): ", i + 1);
                string[] stringRow = (Console.ReadLine().Split(' '));

                matrix2[i, 0] = Convert.ToDouble(stringRow[0]);
                matrix2[i, 1] = Convert.ToDouble(stringRow[1]);
                matrix2[i, 2] = Convert.ToDouble(stringRow[2]);

            }

            Console.WriteLine("The Matrix #2 is: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", matrix2[i, j]);
                }

                Console.WriteLine();
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NumericalCalculator nCalculator = new NumericalCalculator();
            MatrixCalculator mCalculator = new MatrixCalculator();

            int option;

            Console.WriteLine("Application Calculator");
            Console.WriteLine("|--------Menu--------|");
            Console.WriteLine("1. Number Calculator");
            Console.WriteLine("2. Matrix Calculator");
            Console.WriteLine("3. Exit");

            do
            {
                Console.Write("Select a option: ");
                option = int.Parse(Console.ReadLine());

            } while (option != 1 && option != 2 && option != 3);

            switch (option)
            {
                case 1:
                    nCalculator.basicCalculator();
                    break;
                case 2:
                    mCalculator.menuMatrixCalculator();
                    break;
                case 3:
                    Console.WriteLine("Hasta la vista!!");
                    break;
                default:
                    Console.WriteLine("Exiting the aplication");
                    break;
            }

        }
    }


}


