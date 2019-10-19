using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductivityTools.Examples.MediaR.Notification
{
    public class NotificationHandler : INotificationHandler<Notify>
    {
        public Task Handle(Notify notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
