﻿// <copyright file="Bootstrapper.cs" company="A-IT">
//     Copyright (c) A-IT. All rights reserved.
// </copyright>
// <author>Szymon M Sasin</author>
//-----------------------------------------------------------------------

namespace Nuget.Server.AzureStorage
{
    using AutoMapper;
    using Nuget.Server.AzureStorage.Domain.Services;
    using NuGet;
    using NuGet.Server.Infrastructure;

    public static class Bootstraper
    {
        public static void SetUp()
        {
            NinjectBootstrapper.Kernel.Rebind<IServerPackageRepository>().To<AzureServerPackageRepository>();
            NinjectBootstrapper.Kernel.Bind<IPackageLocator>().To<AzurePackageLocator>();
        }
    }
}
