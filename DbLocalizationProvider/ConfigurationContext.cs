﻿using System;

namespace DbLocalizationProvider
{
    public class ConfigurationContext
    {
        /// <summary>
        /// Gets or sets the disable localization callback.
        /// </summary>
        /// <value>
        /// The disable localization callback.
        /// </value>
        public Func<bool> DisableLocalizationCallback { get; set; } = () => false;

        /// <summary>
        /// Gets or sets the flag to control localized models discovery and registration during startup.
        /// </summary>
        /// <value>
        /// Discovers and registers localized models.
        /// </value>
        public Func<bool> DiscoverAndRegisterLocalizedModels { get; set; } = () => true;

        public static ConfigurationContext Current { get; } = new ConfigurationContext();
    }
}
