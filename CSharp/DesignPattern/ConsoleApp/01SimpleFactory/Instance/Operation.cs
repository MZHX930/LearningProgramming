namespace ConsoleApp._01SimpleFactory.Instance
{
    public class Operation
    {
        public double NumberA { get; set; } = 0;
        public double NumberB { get; set; } = 0;

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }


    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }


    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }


    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
                throw new Exception("除数不能为0！");

            return NumberA / NumberB;
        }
    }

}
