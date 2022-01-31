
//double squareMe = 5;                            
//Console.WriteLine(Calculate.Square(squareMe));


//class Calculate
//{
//    public static int Square(int number)
//    {
//        return number * number;
//    }

//    public static double Square(double number)
//    {
//        return number * number;
//    }
//}

RationalNumber rn = new(5, -10);
Console.WriteLine("{0}/{1}", rn.Numerator, rn.Denominator);

RationalNumber r1 = new(17, 9);
RationalNumber r2 = new(11, 3);

RationalNumber add = ++r1;
Console.WriteLine("{0}/{1}", add.Numerator, add.Denominator);
RationalNumber sub = -- r2;
Console.WriteLine("{0}/{1}", sub.Numerator, sub.Denominator);
RationalNumber mul = r1 * r2;
Console.WriteLine("{0}/{1}", mul.Numerator, mul.Denominator);
RationalNumber div = r1 / r2;   
Console.WriteLine("{0}/{1}", div.Numerator, div.Denominator);

public struct RationalNumber
{
    /// <summary>
    /// числитель
    /// </summary>
    private int _numerator;
    /// <summary>
    /// знаменатель
    /// </summary>
    private int _denominator;

    public int Numerator
    {
        get { return _numerator; }
    }

    public int Denominator
    {
        get { return _denominator; }
    }

    //конструктор
    public RationalNumber(int numerator, int denominator)
    {
        
        if (denominator == 0)
            throw new ArgumentException("Знаменатель не может быть равным 0.");
        
        if (denominator < 0)
        {
            numerator *= (- 1);
            denominator *= (-1);
        }
        _numerator = numerator;
        _denominator = denominator;

        ReduceToLowestTerms();
    }

    private void ReduceToLowestTerms()
    {
        int greatestCommonDivisor = RationalNumber.GetGCD(_numerator, _denominator);
        _numerator /= greatestCommonDivisor;
        _denominator /= greatestCommonDivisor;
    }

    /// <summary>
    /// наибольший общий делитель
    /// </summary>
    /// <param name="term1"></param>
    /// <param name="term2"></param>
    /// <returns></returns>
    private static int GetGCD(int term1, int term2)  //Сокращение дроби до ее наименьших значений
    {
        if (term2 == 0)
            return term1;
        if (term2 < 0)
        {
            term1 *= (-1);
            term2 *= (-1);
        }
        
            return GetGCD(term2, term1 % term2);
    }

    //==, != (метод Equals()), <, >, <=, >=, +, –, ++, --

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber((r1.Numerator * r2.Denominator)
            + (r2.Numerator * r1.Denominator), r1.Denominator * r2.Denominator);
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber((r1.Numerator * r2.Denominator)
            - (r2.Numerator * r1.Denominator), r1.Denominator * r2.Denominator);
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
    }

    public static RationalNumber operator ++(RationalNumber r1)
    {
        return new RationalNumber(r1.Numerator + r1.Denominator, r1.Denominator);
    }
    //{
    //    return new RationalNumber(r1.Numerator + r1.Denominator, r1.Denominator);
    //}

    public static RationalNumber operator --(RationalNumber r1)
    {
        return new RationalNumber((r1.Numerator - r1.Denominator), r1.Denominator);
    }

    public bool Equals(RationalNumber other)
    {
        return Numerator.Equals(other.Numerator)
               && Denominator.Equals(other.Denominator);
    }

    public override bool Equals(object? obj)
    {
        if (obj is RationalNumber other_vector)
            return Numerator == other_vector.Numerator && Denominator == other_vector.Denominator;

        return false;
    }

    public override string ToString() => $"({Numerator};{Denominator})";

    //public static RationalNumber bool operator ==(RationalNumber r1, RationalNumber r2)
    //{
    //    return r1.Equals(r2);
    //}


}