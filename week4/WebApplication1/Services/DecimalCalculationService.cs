using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class DecimlaCalculationService : ICalculationService
    {
       public NumberModel AddTwoNumbers(DecimalNumberModel numberModel)
        {
            numberModel.Result = numberModel.firstNo + numberModel.secondNo;
            return numberModel;
        }
    }
}
