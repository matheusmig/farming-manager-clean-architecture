using System.Threading.Tasks;

namespace Application.Base.Boundaries
{
    /// <summary>
    /// Use Case.
    /// </summary>
    /// <typeparam name="TUseCaseInput">Any Input Message.</typeparam>
    public interface IUseCase<in TUseCaseInput>
    {
        /// <summary>
        /// Executes the Use Case.
        /// </summary>
        /// <param name="input">Input Message.</param>
        /// <returns>Task.</returns>
        Task ExecuteAsync(TUseCaseInput input);
    }

    /// <summary>
    /// Use Case parameterless.
    /// </summary>
    public interface IUseCase
    {
        /// <summary>
        /// Executes the Use Case.
        /// </summary>
        /// <returns>Task.</returns>
        Task ExecuteAsync();
    }
}
