using System.Collections.Generic;

namespace BaseDeConhecimento.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
