﻿using Nop.Core;
using Nop.Core.Caching;

namespace Nop.Plugin.Tax.Avalara
{
    /// <summary>
    /// Represents plugin constants
    /// </summary>
    public class AvalaraTaxDefaults
    {
        /// <summary>
        /// Gets the Avalara tax provider system name
        /// </summary>
        public static string SystemName => "Tax.Avalara";

        /// <summary>
        /// Gets the Avalara tax provider connector name
        /// </summary>
        public static string ApplicationName => "nopCommerce-AvalaraTaxRateProvider|a0o33000004BoPM";

        /// <summary>
        /// Gets the Avalara tax provider version (used a nopCommerce version here)
        /// </summary>
        public static string ApplicationVersion => $"v{NopVersion.CURRENT_VERSION}";

        /// <summary>
        /// Gets the certificates script source URL
        /// </summary>
        public static string CertificatesScriptUrl => "https://app.certcapture.com/gencert2/js";

        /// <summary>
        /// Gets the certificates sandbox script source URL
        /// </summary>
        public static string CertificatesSandboxScriptUrl => "https://sbx.certcapture.com/gencert2/js";

        /// <summary>
        /// Gets the CertExpress default URL
        /// </summary>
        public static string CertExpressUrl => "https://app.certexpress.com/";

        /// <summary>
        /// Gets the configuration route name
        /// </summary>
        public static string ConfigurationRouteName => "Plugin.Tax.Avalara.Configure";

        /// <summary>
        /// Gets the tax categories list route name
        /// </summary>
        public static string TaxCategoriesRouteName => "Plugin.Tax.Avalara.Tax.Categories";

        /// <summary>
        /// Gets the tax exemption certificates list route name
        /// </summary>
        public static string ExemptionCertificatesRouteName => "Plugin.Tax.Avalara.ExemptionCertificates";

        /// <summary>
        /// Gets the download exemption certificate route name
        /// </summary>
        public static string DownloadCertificateRouteName => "Plugin.Tax.Avalara.DownloadCertificate";

        /// <summary>
        /// Gets the class name of the tax exemption certificates menu item
        /// </summary>
        public static string ExemptionCertificatesMenuClassName => "exemption-certificates";

        /// <summary>
        /// Gets the tab id of the tax exemption certificates menu item
        /// </summary>
        public static int ExemptionCertificatesMenuTab => 420;

        /// <summary>
        /// Gets the name of the generic attribute that is used to store Avalara system tax code description
        /// </summary>
        public static string TaxCodeDescriptionAttribute => "AvalaraTaxCodeDescription";

        /// <summary>
        /// Gets the name of the generic attribute that is used to store a tax code type
        /// </summary>
        public static string TaxCodeTypeAttribute => "AvalaraTaxCodeType";

        /// <summary>
        /// Gets the name of the generic attribute that is used to store an entity use code (customer usage type)
        /// </summary>
        public static string EntityUseCodeAttribute => "AvalaraEntityUseCode";

        /// <summary>
        /// Gets the key for caching tax rate
        /// </summary>
        /// <remarks>
        /// {0} - Customer id
        /// {1} - Tax category id
        /// {2} - Address
        /// {3} - City
        /// {4} - State or province identifier
        /// {5} - Country identifier
        /// {6} - Zip postal code
        /// </remarks>
        public static CacheKey TaxRateCacheKey => new("Nop.avalara.taxrate.{0}-{1}-{2}-{3}-{4}-{5}-{6}", TaxRateCacheKeyByCustomerPrefix);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : Customer id
        /// </remarks>
        public static string TaxRateCacheKeyByCustomerPrefix => "Nop.avalara.taxrate.{0}-";

        /// <summary>
        /// Gets the key for caching Avalara tax code types
        /// </summary>
        public static CacheKey TaxCodeTypesCacheKey => new("Nop.avalara.taxcodetypes");

        /// <summary>
        /// Gets the key for caching Avalara system entity use codes
        /// </summary>
        public static CacheKey EntityUseCodesCacheKey => new("Nop.avalara.entityusecodes");

        /// <summary>
        /// Gets the name of the view component to display entity use code field
        /// </summary>
        public const string ENTITY_USE_CODE_VIEW_COMPONENT_NAME = "AvalaraEntityUseCode";

        /// <summary>
        /// Gets the name of the view component to display export items button
        /// </summary>
        public const string EXPORT_ITEMS_VIEW_COMPONENT_NAME = "AvalaraExportItems";

        /// <summary>
        /// Gets the name of the view component to validate entered address
        /// </summary>
        public const string ADDRESS_VALIDATION_VIEW_COMPONENT_NAME = "AvalaraAddressValidation";

        /// <summary>
        /// Gets the name of the view component to display applied certificate
        /// </summary>
        public const string APPLIED_CERTIFICATE_VIEW_COMPONENT_NAME = "AvalaraAppliedCertificate";

        /// <summary>
        /// Gets the generic attribute name to hide general settings block on the plugin configuration page
        /// </summary>
        public static string HideGeneralBlock => "AvalaraPage.HideGeneralBlock";

        /// <summary>
        /// Gets the generic attribute name to hide log block on the plugin configuration page
        /// </summary>
        public static string HideLogBlock => "AvalaraPage.HideLogBlock";
    }
}