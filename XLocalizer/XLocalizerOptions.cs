﻿using System;
using XLocalizer.ErrorMessages;

namespace XLocalizer
{
    /// <summary>
    /// Express localization options
    /// </summary>
    public class XLocalizerOptions
    {
        /// <summary>
        /// The path to the resources folder e.g. "LocalizationResources"
        /// </summary>
        public string ResourcesPath { get; set; } = "LocalizationResources";

        /// <summary>
        /// Express validation attributes are deprected. Use default attributes instead. See <a href="https://docs.ziyad.info/en/XLocalizer/v1.0/localizing-validation-attributes-errors.md">Localizing Data Annotations</a>
        /// </summary>
        [Obsolete("Express validation attributes are deprected. Use default attributes instead. See https://docs.ziyad.info/en/XLocalizer/v1.0/localizing-validation-attributes-errors.md")]
        public bool UseExpressValidationAttributes { get; set; } = false;

        /// <summary>
        /// If the key string is not found in the DB, it will be inserted autoamtically to the DB.
        /// default: false
        /// </summary>
        public bool AutoAddKeys { get; set; } = false;

        /// <summary>
        /// If the translation string is not found, it will be translated via registered translation servies.
        /// default: false
        /// Requires registering of one translation service at least. see <a href="https://docs.ziyad.info/en/XLocalizer/v1.0/translate-services.md">Registering Translation Services for Localization</a>
        /// </summary>
        public bool AutoTranslate { get; set; } = false;

        /// <summary>
        /// ExpressMemory cache helps speeding up getting localized values from data stores.
        /// It is helpful to set to false during development mode and to true in production.
        /// Default value: true.
        /// </summary>
        public bool UseExpressMemoryCache { get; set; } = true;

        /// <summary>
        /// The culture name to translate from, if not set default request culture will be used.
        /// </summary>
        public string TranslateFromCulture { get; set; }

        /// <summary>
        /// Customize all valdiation error messages.
        /// </summary>
        public ValidationErrors ValidationErrors { get; set; } = new ValidationErrors();

        /// <summary>
        /// identity describer error messages
        /// </summary>
        public IdentityErrors IdentityErrors { get; set; } = new IdentityErrors();

        /// <summary>
        /// Model Binding Error Messages
        /// </summary>
        public ModelBindingErrors ModelBindingErrors { get; set; } = new ModelBindingErrors();
    }
}
