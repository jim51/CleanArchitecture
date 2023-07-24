using CleanArchitecture.Domain.Common;
using MediatR;

namespace CleanArchitecture.Application.Common.Event;
public class DomainNotification<TDomainEvent> : INotification where TDomainEvent : IDomainEvent
{
    public TDomainEvent DomainEvent { get; }

    public DomainNotification(TDomainEvent domainEvent)
    {
        DomainEvent = domainEvent;
    }
}