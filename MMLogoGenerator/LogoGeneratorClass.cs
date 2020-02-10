using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMLogoGenerator
{
    class LogoGeneratorClass
    {
        private int inputNumber;

        private StringBuilder logoBuilder = new StringBuilder();

        private string logo;

        public LogoGeneratorClass(int inputNumber)
        {
            this.inputNumber = inputNumber;
        }

        private void DashAppender(int dashCount)
        {
            for (int i = 0; i < dashCount; i++)
            {
                logoBuilder.Append('-');
            }
        }

        public void LogoPrinter()
        {
            UpperHalfLogoGenerator(inputNumber, inputNumber, inputNumber);
            Console.Write(logo);
        }

        private void LowerHalfLogoGenerator(int endDash, int endStar, int middleDash, int middleStar)
        {
            if (endDash >= 0)
            {
                DashAppender(endDash);
                StarAppender(endStar);
                DashAppender(middleDash);
                StarAppender(middleStar);
                DashAppender(middleDash);
                StarAppender(endStar);
                DashAppender(endDash);
                DashAppender(endDash);
                StarAppender(endStar);
                DashAppender(middleDash);
                StarAppender(middleStar);
                DashAppender(middleDash);
                StarAppender(endStar);
                DashAppender(endDash);
                logoBuilder.Append("\n");
                LowerHalfLogoGenerator(endDash - 1, endStar, middleDash + 2, middleStar - 2);
            }
            else
            {
                logo = logoBuilder.ToString();
            }
        }

        private void StarAppender(int starCount)
        {
            for (int i = 0; i < starCount; i++)
            {
                logoBuilder.Append('*');
            }
        }

        private void UpperHalfLogoGenerator(int endDash, int middleDash, int stars)
        {
            if (middleDash >= 1)
            {
                DashAppender(endDash);
                StarAppender(stars);
                DashAppender(middleDash);
                StarAppender(stars);
                DashAppender(endDash);
                DashAppender(endDash);
                StarAppender(stars);
                DashAppender(middleDash);
                StarAppender(stars);
                DashAppender(endDash);
                logoBuilder.Append('\n');
                UpperHalfLogoGenerator(endDash - 1, middleDash - 2, stars + 2);
            }
            else
            {
                LowerHalfLogoGenerator(endDash, inputNumber, 1, inputNumber * 2 - 1);
            }
        }
    }
}
