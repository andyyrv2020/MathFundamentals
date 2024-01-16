using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;

namespace MatrixCalculations
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Initialize the first matrix data with default values
            double[,] firstData = {
                { 2, 1, 4 },
                { 3, 6, 5 },
                { 8, 9, 7 }
            };

            // Initialize the second matrix data with default values
            double[,] secondData = {
                { 2, 1, 4 },
                { 3, 6, 5 },
                { 8, 9, 7 }
            };

            // Read input values for the first matrix from the console
            string firstInputLine = Console.ReadLine();
            string[] firstInputValues = firstInputLine.Split(' ');
            int firstIndex = 0;

            // Populate the first matrix with input values
            for (int i = 0; i < 3; i++) // Number of rows
            {
                for (int s = 0; s < 3; s++) // Number of columns
                {
                    firstData[i, s] = double.Parse(firstInputValues[firstIndex]);
                    firstIndex++;
                }
            }

            // Read input values for the second matrix from the console
            string secondInputLine = Console.ReadLine();
            string[] secondInputValues = secondInputLine.Split(' ');
            int secondIndex = 0;

            // Populate the second matrix with input values
            for (int i = 0; i < 3; i++) // Number of rows
            {
                for (int s = 0; s < 3; s++) // Number of columns
                {
                    secondData[i, s] = double.Parse(secondInputValues[secondIndex]);
                    secondIndex++;
                }
            }

            // Create MathNet.Numerics matrices from the populated arrays
            Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(firstData);
            Matrix<double> matrix2 = Matrix<double>.Build.DenseOfArray(secondData);

            // Multiply the first matrix by a scalar (2) and print the result
            Matrix<double> multiplyResult = matrix * 2;
            Console.WriteLine(multiplyResult);

            // Add the first and second matrices and print the result
            Matrix<double> addResult = matrix + matrix2;
            Console.WriteLine(addResult);

            // Print the determinant of the first matrix
            Console.WriteLine($"Determinant: ");
            double determinant = matrix.Determinant();
            Console.WriteLine(determinant);

            // Solve a linear system using the first matrix and a given vector
            var vector = new DenseVector(new[] { 12.0, 8.0, 5.0 });
            var solveVector = matrix.Solve(vector);
            Console.WriteLine(solveVector);
        }
    }
}
