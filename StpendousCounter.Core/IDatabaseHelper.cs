using System.Collections.Generic;
using System.Threading.Tasks;

namespace StpendousCounter.Core
{
    public interface IDatabaseHelper
    {
        Task AddOrUpdateCounterAsync(Counter counter);
        Task IncrementCounterAsync(Counter counter);
        Task<IEnumerable<Counter>> GetAllCountersAsync();
        Task<IEnumerable<CounterIncrementHistory>> GetCounterHIstoryAsync(int counterId);
    }
}
