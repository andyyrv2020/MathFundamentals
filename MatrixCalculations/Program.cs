using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;

namespace MatrixCalculations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Matrix<double> matrix1 = new DenseMatrix(3, 3);
			var matrix1 = DenseMatrix.OfArray(new double[,]{
				{ 1, 2, -3},
				{ 2, -10, 1},
				{ 1, 7, -10}
			});
			var matrix2 = DenseMatrix.OfArray(new double[,]{
				{ 2, -1, 3},
				{ 2, 1, 1},
				{ 3, -1, 0}
			});

			matrix1 = matrix1 * 3;
			matrix1 = matrix1 + matrix2;
			var det = matrix1.Determinant();
			var vec = new DenseVector(new[] { 12.0, 8.0, 5.0 });
			var solve = matrix2.Solve(vec);

			Console.WriteLine("Determinant is: " + det);

		}
	}
}