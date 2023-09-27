using System.Threading.Tasks;

namespace ObfuscateCORE.Contracts.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle();

        Task HandleAsync();
    }
}
