using System;

namespace Lab6_2
{

    class Cramer
    {

        public static double[] Solve(int[][] equations)
        {

            var size = equations.Length;

            var matrix = new int[size, size];
            var column = new int[size];

            for (var r = 0; r < size; r++)
            {

                column[r] = equations[r][size];

                for (var c = 0; c < size; c++)
                {
                    matrix[r, c] = equations[r][c];
                }

            }

            return Solve(new SubMatrix(matrix, column));

        }

        private static double[] Solve(SubMatrix matrix)
        {

            var det = matrix.Det();

            if (det == 0)
                throw new ArgumentException("The determinant is zero.");

            var answer = new double[matrix.Size];

            for (var i = 0; i < matrix.Size; i++)
            {
                matrix.ColumnIndex = i;
                answer[i] = (double)matrix.Det() / det;
            }

            return answer;

        }

        private class SubMatrix
        {

            public int ColumnIndex { get; set; }
            public int Size { get; }

            private int[,] source;
            private SubMatrix prev;
            private int[] replaceColumn;

            public SubMatrix(int[,] source, int[] replaceColumn)
            {
                this.source = source;
                this.replaceColumn = replaceColumn;
                prev = null;
                ColumnIndex = -1;
                Size = replaceColumn.Length;
            }

            private SubMatrix(SubMatrix prev, int deletedColumnIndex = -1)
            {

                source = null;
                this.prev = prev;
                ColumnIndex = deletedColumnIndex;
                Size = prev.Size - 1;

            }

            public int this[int row, int column]
            {
                get
                {
                    if (source != null) return column == ColumnIndex ? replaceColumn[row] : source[row, column];
                    return prev[row + 1, column < ColumnIndex ? column : column + 1];
                }
            }

            public int Det()
            {

                switch (Size)
                {
                    case 1:
                        return this[0, 0];
                    case 2:
                        return this[0, 0] * this[1, 1] - this[0, 1] * this[1, 0];
                }

                var m = new SubMatrix(this);

                var det = 0;
                var sign = 1;

                for (var c = 0; c < Size; c++)
                {
                    m.ColumnIndex = c;
                    int d = m.Det();
                    det += this[0, c] * d * sign;
                    sign = -sign;
                }

                return det;

            }

        }

    }

}
