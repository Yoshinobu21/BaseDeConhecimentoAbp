using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace BaseDeConhecimento.Localization
{
    public static class BaseDeConhecimentoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BaseDeConhecimentoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BaseDeConhecimentoLocalizationConfigurer).GetAssembly(),
                        "BaseDeConhecimento.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
