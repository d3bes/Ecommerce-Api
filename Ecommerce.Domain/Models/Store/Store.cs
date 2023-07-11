using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_Api.Domain.Contracts;

namespace Ecommerce_Api.Domain.Models.Store
{
    public class Store:ISoftDeleted
    {
        /// Gets or sets the store name
        public string Name { get; set; }

        /// Gets or sets the meta keywords
        public string DefaultMetaKeywords { get; set; }

        /// Gets or sets the meta description
        public string DefaultMetaDescription { get; set; }

        /// Gets or sets the meta title
        public string DefaultTitle { get; set; }

        /// Home page title
        public string HomepageTitle { get; set; }

        /// Home page description
        public string HomepageDescription { get; set; }

        /// Gets or sets the store URL
        public string Url { get; set; }

        /// Gets or sets a value indicating whether SSL is enabled
        public bool SslEnabled { get; set; }

        /// Gets or sets the comma separated list of possible HTTP_HOST values
        public string Hosts { get; set; }

        /// Gets or sets the identifier of the default language for this store; 0 is set when we use the default language display order
        public int DefaultLanguageId { get; set; }

        /// Gets or sets the display order
        public int DisplayOrder { get; set; }

        /// Gets or sets the company name
        public string CompanyName { get; set; }

        /// Gets or sets the company address
        public string CompanyAddress { get; set; }

        /// Gets or sets the store phone number
        public string CompanyPhoneNumber { get; set; }

        /// Gets or sets the company VAT (used in Europe Union countries)
        public string CompanyVat { get; set; }

        /// Gets or sets a value indicating whether the entity has been deleted
        public bool isDeleted { get; set; }
    }
}