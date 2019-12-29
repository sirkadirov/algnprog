using System;
using System.Collections.Generic;

namespace Lab6_2
{

    public class Gauss
    {

        private readonly double[,] _aMatrix;
        private readonly double[] _bVector;
        private readonly double _eps;
        private readonly int _size;

        public Gauss(double[,] aMatrix, double[] bVector, double eps)
        {

            _aMatrix = (double[,])aMatrix.Clone();
            _bVector = (double[])bVector.Clone();
            XVector = new double[bVector.Length];
            _size = bVector.Length;
            _eps = eps;

        }

        private double[] XVector { get; }

        private int[] InitIndex()
        {

            var index = new int[_size];

            for (var i = 0; i < index.Length; ++i)
                index[i] = i;

            return index;

        }
        

        public double[] Solve()
        {

            var index = InitIndex();
            GaussForwardStroke(index);
            GaussBackwardStroke(index);

            return XVector;

        }

        private double FindR(int row, int[] index)
        {
            var maxIndex = row;
            var max = _aMatrix[row, index[maxIndex]];
            var maxAbs = Math.Abs(max);

            for (var currentIndex = row + 1; currentIndex < _size; ++currentIndex)
            {

                var cur = _aMatrix[row, index[currentIndex]];
                var curAbs = Math.Abs(cur);

                if (curAbs <= maxAbs)
                    continue;

                maxIndex = currentIndex;
                max = cur;
                maxAbs = curAbs;

            }

            if (maxAbs < _eps)
            {

                if (Math.Abs(_bVector[row]) > _eps)
                    throw new Exception("Система не сумісна!");

                throw new Exception("Система має множину розв'язків.");

            }

            var temp = index[row];
            index[row] = index[maxIndex];
            index[maxIndex] = temp;

            return max;
        }

        private void GaussForwardStroke(int[] index)
        {

            for (var i = 0; i < _size; ++i)
            {

                var r = FindR(i, index);

                for (var j = 0; j < _size; ++j)
                    _aMatrix[i, j] /= r;

                _bVector[i] /= r;

                for (var k = i + 1; k < _size; ++k)
                {

                    var p = _aMatrix[k, index[i]];

                    for (var j = i; j < _size; ++j)
                        _aMatrix[k, index[j]] -= _aMatrix[i, index[j]] * p;

                    _bVector[k] -= _bVector[i] * p;
                    _aMatrix[k, index[i]] = 0.0;

                }

            }

        }

        private void GaussBackwardStroke(IReadOnlyList<int> index)
        {

            for (var i = _size - 1; i >= 0; --i)
            {

                var xI = _bVector[i];

                for (var j = i + 1; j < _size; ++j)
                    xI -= XVector[index[j]] * _aMatrix[i, index[j]];

                XVector[index[i]] = xI;

            }

        }

    }

}
