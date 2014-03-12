using System;

namespace ReallySimpleCli.ActionResults
{
    public class ViewResult : IActionResult
    {
        private readonly object _model;

        public ViewResult(object model)
        {
            _model = model;
        }

        public void Execute()
        {
            Console.WriteLine(_model.ToString());
        }
    }

    public interface IActionResult
    {
        void Execute();
    }
}
