﻿using GreenshotPlugin.Core;

namespace TranslationByMarkupExtension {
    /// <summary>
    /// 
    /// </summary>
    public class LanguageXMLTranslationProvider : ITranslationProvider {
        #region Private Members

        #endregion

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="ResxTranslationProvider"/> class.
        /// </summary>
        /// <param name="baseName">Name of the base.</param>
        /// <param name="assembly">The assembly.</param>
        public LanguageXMLTranslationProvider() {
        }

        #endregion

        #region ITranslationProvider Members

        /// <summary>
        /// See <see cref="ITranslationProvider.Translate" />
        /// </summary>
        public object Translate(string key) {
        	if (Language.hasKey("confluence", key)) {
				return Language.GetString("confluence", key);
        	}
            return key;
        }

        #endregion
    }
}