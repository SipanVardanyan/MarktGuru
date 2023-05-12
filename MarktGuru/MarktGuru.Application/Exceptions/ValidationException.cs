using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace MarktGuru.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public List<string> Errors { get; }

        public ValidationException(string message) : base(message)
        {
            Errors = new List<string>();
        }

        public ValidationException() : this("One or more validation failures have occurred.")
        {
            Errors = new List<string>();
        }
        
        public ValidationException(IEnumerable<ValidationFailure> failures)
            : this()
        {
            foreach (var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }
        }
    }
}
