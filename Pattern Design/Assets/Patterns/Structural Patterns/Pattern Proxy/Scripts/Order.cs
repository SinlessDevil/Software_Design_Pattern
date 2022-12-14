using System;

namespace Proxy
{
    public struct Order
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public int StatusId { get; set; }
    }
}