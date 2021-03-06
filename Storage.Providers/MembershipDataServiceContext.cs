﻿// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Samples.Storage.Providers
{
    using System.Linq;

    using Microsoft.WindowsAzure.StorageClient;

    /// <summary>
    /// This class allows DevtableGen to generate the correct table (named 'Membership') 
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses",
        Justification = "Class is used by devtablegen to generate database for the development storage tool")]
    internal class MembershipDataServiceContext : TableServiceContext
    {
        public MembershipDataServiceContext()
            : base(null, null) { }

        public IQueryable<MembershipRow> Membership
        {
            get
            {
                return this.CreateQuery<MembershipRow>(ProvidersConfiguration.DefaultMembershipTableName);
            }
        }
    }
}