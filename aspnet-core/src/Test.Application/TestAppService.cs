﻿using Test.Localization;
using Volo.Abp.Application.Services;

namespace Test
{
    // test commit 2
    /* Inherit your application services from this class.
     */
    public abstract class TestAppService : ApplicationService
    {
        protected TestAppService()
        {
            LocalizationResource = typeof(TestResource);
        }
    }
}
