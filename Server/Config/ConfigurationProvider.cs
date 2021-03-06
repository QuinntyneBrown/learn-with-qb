﻿using System;
using LearnWithQB.Server.Config.Contracts;

namespace LearnWithQB.Server.Config
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        public T Get<T>()  where T: class
        {
            if (typeof(T) == typeof(IAppConfiguration))
                return AppConfiguration.Config as T;

            if (typeof(T) == typeof(ISmptConfiguration))
                return SmtpConfiguration.Config as T;

            if (typeof(T) == typeof(IStripeConfiguration))
                return StripeConfiguration.Config as T;

            throw new InvalidOperationException();
        }
    }
}