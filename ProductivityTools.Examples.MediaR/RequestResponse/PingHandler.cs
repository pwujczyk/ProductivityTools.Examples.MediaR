﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductivityTools.Examples.MediaR.RequestResponse
{
    public class PingHandler : IRequestHandler<Ping,string>
    {
        public Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return Task.FromResult(DateTime.Now.ToString());
        }
    }
}
