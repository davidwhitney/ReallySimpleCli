using System;

namespace ReallySimpleCli.TestApp.Models
{
    public class DefaultModel
    {
        public string Id { get; set; }

        public DefaultModel()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}