﻿using ConfigInjector.QuickAndDirty;
using NUnit.Framework;
using Sample.IntegrationTests.ConfigurationSettings;
using Shouldly;

namespace Sample.IntegrationTests
{
    [TestFixture]
    public class WhenReadingASettingUsingTheStaticSettingsReader
    {
        private SimpleIntSetting _setting;
        private EnvironmentSettingsMutex _environmentSettingsMutex;

        [SetUp]
        public void SetUp()
        {
            _environmentSettingsMutex = new EnvironmentSettingsMutex();

            DefaultSettingsReader.SetStrategy(new DefaultStaticSettingReaderStrategy());

            _setting = DefaultSettingsReader.Get<SimpleIntSetting>();
        }

        [TearDown]
        public void TearDown()
        {
            _environmentSettingsMutex.Dispose();
        }

        [Test]
        public void NothingShouldGoBang()
        {
        }

        [Test]
        public void TheAnswerShouldBeCorrect()
        {
            _setting.Value.ShouldBe(13);
        }
    }
}