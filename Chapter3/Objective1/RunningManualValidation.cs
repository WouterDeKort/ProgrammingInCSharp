using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-3 Running manual validation.")]
    internal class RunningManualValidation : ISample
    {
        public void Run()
        {
        }

        public static class GenericValidator<T>
        {
            public static IList<ValidationResult> Validate(T entity)
            {
                var results = new List<ValidationResult>();
                var context = new ValidationContext(entity, null, null);
                Validator.TryValidateObject(entity, context, results);
                return results;
            }
        }
    }
}