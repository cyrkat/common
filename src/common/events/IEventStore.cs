using System;
using System.Threading.Tasks;

namespace cyrkat.common.events
{
	public interface IEventStore
	{
		Task Store(Event @event);

		Event GetLast();

		Task<Event[]> FindByAggregate<TAggregate>(string aggregateId)
		where TAggregate : class;

		IObservable<Event> AsObservable(bool fromStart = false);
	}
}
