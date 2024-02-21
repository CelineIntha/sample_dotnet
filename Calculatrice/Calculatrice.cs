using System;
using System.Security.Cryptography;
using System.Xml.Linq;


namespace Calculatrice
{
    public class Calculator
    {
            public int Add(int numberOne, int numberTwo)
            {
            if (numberOne < 0 || numberTwo < 0)
                throw new ArgumentException("Les deux paramètres ne peuvent pas être négatifs");

            if (numberTwo >= 1000)
                throw new ArgumentException("Second chiffre ne doit pas être supérieur ou égal à 1000");
                return (numberOne + numberTwo);
            }

            public int  Substract(int numberOne, int numberTwo)
            {
                return (numberOne - numberTwo);
            }

            public int Divide(int numberOne, int numberTwo)
            {
                if (numberOne == 0 || numberTwo == 0)
                {
                    throw new ArgumentException("On ne peut pas diviser un nombre par 0");
                }
                else
                {
                    return (numberOne / numberTwo);
                }
            }

            public int Multiply(int numberOne, int numberTwo)
            {
                return (numberOne * numberTwo);
            }
        }
    }
