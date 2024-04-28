using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class CalculationService : ICalculationService
    {
       public NumberModel AddTwoNumbers(NumberModel numberModel)
        {
            numberModel.Result = numberModel.firstNo + numberModel.secondNo;
            return numberModel;
        }
    }
    public interface ICalculationService
    {
        public NumberModel AddTwoNumbers(NumberModel numberModel);
    }
}
