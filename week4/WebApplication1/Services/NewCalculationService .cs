using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class NewCalculationService : ICalculationService
    {
       public NumberModel AddTwoNumbers(NumberModel numberModel)
        {
            numberModel.Result = numberModel.firstNo *2 + numberModel.secondNo*2;
            return numberModel;
        }
    }
    
}
