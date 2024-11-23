using System.ComponentModel.DataAnnotations;

namespace IStore.Web.Utility
{
    public class MaxFileSizeAttribute(int maxFileSize) : ValidationAttribute
    {
        private readonly int _maxFileSize = maxFileSize;

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {

                if (file.Length > (_maxFileSize * 2048 * 2048))
                {
                    return new ValidationResult($"Maximum allowed file size is {_maxFileSize} MB.");
                }
            }

            return ValidationResult.Success;
        }

    }
}
