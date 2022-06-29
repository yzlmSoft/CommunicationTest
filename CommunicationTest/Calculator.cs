using Flee.PublicTypes;

namespace CommunicationTest;
public class Calculator
{
    private ExpressionContext _expressionContext;
    public Calculator()
    {
        _expressionContext = new ExpressionContext();
        _expressionContext.Imports.AddType(typeof(Math));
    }

    public decimal Compute(string formula)
    {
        IDynamicExpression eDynamic = _expressionContext.CompileDynamic(formula);
        return Convert.ToDecimal(eDynamic.Evaluate());
    }
}
