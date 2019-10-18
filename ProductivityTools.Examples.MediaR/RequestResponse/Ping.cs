using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductivityTools.Examples.MediaR.RequestResponse
{
    public class Ping:IRequest<string>
    {
    }
}
