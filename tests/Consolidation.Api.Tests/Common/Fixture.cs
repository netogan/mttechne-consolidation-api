﻿using Bogus;

namespace Consolidation.Api.Tests.Common
{
    public static class Fixture
    {
        private static Faker? _faker;
        public static Faker Get() => _faker ??= new("pt_BR");
        public static Faker<TObject> Get<TObject>()
            where TObject : class => new("pt_BR");
    }
}
