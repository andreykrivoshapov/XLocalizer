﻿using System;

namespace XLocalizer.DataAnnotations
{
    /// <summary>
    /// Interface to provide custom default data annotation error messages.
    /// Messages can be provided in any culture, so user can provide localized error messages here,
    /// but the default request culture in startup must be configured same as messages culture.
    /// </summary>
    [Obsolete]
    public interface IDataAnnotationsMessagesProvider
    {
        /// <summary>
        /// '{0}' and '{1}' do not match.
        /// </summary>
        string CompareAttribute_MustMatch { get; }

        /// <summary>
        /// The {0} field is not a valid credit card number.
        /// </summary>
        string CreditCardAttribute_Invalid { get; }

        /// <summary>
        /// {0} is not valid.
        /// </summary>
        string CustomValidationAttribute_ValidationError { get; }

        /// <summary>
        /// The custom DataType string cannot be null or empty.
        /// </summary>
        string DataTypeAttribute_EmptyDataTypeString { get; }

        /// <summary>
        /// The {0} field is not a valid e-mail address.
        /// </summary>
        string EmailAddressAttribute_Invalid { get; }
                
        /// <summary>
        /// The {0} field only accepts files with the following extensions: {1}
        /// </summary>
        string FileExtensionsAttribute_Invalid { get; }
                        
        /// <summary>
        /// The field {0} must be a string or array type with a maximum length of '{1}'.
        /// </summary>
        string MaxLengthAttribute_ValidationError { get; }

        /// <summary>
        /// The field {0} must be a string or array type with a minimum length of '{1}'.
        /// </summary>
        string MinLengthAttribute_ValidationError { get; }

        /// <summary>
        /// The {0} field is not a valid phone number.
        /// </summary>
        string PhoneAttribute_Invalid { get; }

        /// <summary>
        /// The field {0} must be between {1} and {2}.
        /// </summary>
        string RangeAttribute_ValidationError { get; }

        /// <summary>
        /// The field {0} must match the regular expression '{1}'.
        /// </summary>
        string RegexAttribute_ValidationError { get; }

        /// <summary>
        /// The {0} field is required.
        /// </summary>
        string RequiredAttribute_ValidationError { get; }

        /// <summary>
        /// The field {0} must be a string with a maximum length of {1}.
        /// </summary>
        string StringLengthAttribute_ValidationError { get; }

        /// <summary>
        /// The field {0} must be a string with a minimum length of {2} and a maximum length of {1}.
        /// </summary>
        string StringLengthAttribute_ValidationErrorIncludingMinimum { get; }

        /// <summary>
        /// The {0} field is not a valid fully-qualified http, https, or ftp URL.
        /// </summary>
        string UrlAttribute_Invalid { get; }

        /// <summary>
        /// The field {0} is invalid.
        /// </summary>
        string ValidationAttribute_ValidationError { get; }
    }
}
