using System;

namespace cyrkat.common.events
{
	public abstract class Event
	{
		public Event(ulong id, DateTime createdAt, string aggregateType, string aggregateId)
		{
			Id = id;
			CreatedAt = createdAt;
			AggregateType = aggregateType;
			AggregateId = aggregateId;
		}

		public readonly ulong Id;
		public readonly DateTime CreatedAt;
		public readonly string AggregateType;
		public readonly string AggregateId;
	}
}
