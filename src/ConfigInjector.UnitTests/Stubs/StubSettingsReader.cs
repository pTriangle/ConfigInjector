using System.Collections.Generic;
using ConfigInjector.Infrastructure.SettingsReaders;

namespace ConfigInjector.UnitTests.Stubs
{
    internal class StubSettingsReader : ISettingsReader
    {
        private readonly IDictionary<string, string> _settings;

        public StubSettingsReader(IDictionary<string, string> settings)
        {
            _settings = settings;
        }

        public string ReadValue(string key)
        {
            return _settings[key];
        }

        public IEnumerable<string> AllKeys
        {
            get { return _settings.Keys; }
        }
    }
}