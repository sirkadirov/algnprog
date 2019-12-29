using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab11
{

    class DefiniteIntegral
    {

        public class Interval
        {

            public Interval(double leftEndpoint, double rightEndpoint)
            {
                LeftEndpoint = leftEndpoint;
                RightEndpoint = rightEndpoint;
            }

            public double LeftEndpoint { get; set; }

            public double RightEndpoint { get; set; }

            public double Size => RightEndpoint - LeftEndpoint;

            public double Center => (LeftEndpoint + RightEndpoint) / 2;

            public IEnumerable<Interval> Subdivide(int subIntervalCount)
            {

                var subIntervalSize = Size / subIntervalCount;

                return Enumerable
                    .Range(0, subIntervalCount)
                    .Select(index => 
                        new Interval(
                            LeftEndpoint + index * subIntervalSize, subIntervalSize
                        )
                    );

            }

        }

        public Func<double, double> Integrand { get; set; }

        public Interval Domain { get; set; }

        public double SampleIntegrand(ApproximationMethod approximationMethod, Interval subDomain)
        {

            switch (approximationMethod)
            {

                case ApproximationMethod.RectangleLeft:
                    return Integrand(subDomain.LeftEndpoint);

                case ApproximationMethod.RectangleMidpoint:
                    return Integrand(subDomain.Center);

                case ApproximationMethod.RectangleRight:
                    return Integrand(subDomain.RightEndpoint);

                case ApproximationMethod.Trapezium:
                    return (Integrand(subDomain.LeftEndpoint) + Integrand(subDomain.RightEndpoint)) / 2;

                case ApproximationMethod.Simpson:
                    return (Integrand(subDomain.LeftEndpoint) + 4 * Integrand(subDomain.Center) + Integrand(subDomain.RightEndpoint)) / 6;

                default:
                    throw new NotImplementedException();

            }

        }

        public double Approximate(ApproximationMethod approximationMethod, int subDomainCount)
        {
            return Domain.Subdivide(subDomainCount).Sum(subdomain => SampleIntegrand(approximationMethod, subdomain)) / subDomainCount * Domain.Size;
        }

        public enum ApproximationMethod
        {
            RectangleLeft,
            RectangleMidpoint,
            RectangleRight,
            Trapezium,
            Simpson
        }

    }

}
