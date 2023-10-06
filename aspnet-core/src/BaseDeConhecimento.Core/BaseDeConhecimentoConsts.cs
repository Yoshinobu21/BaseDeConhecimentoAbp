using BaseDeConhecimento.Debugging;

namespace BaseDeConhecimento
{
    public class BaseDeConhecimentoConsts
    {
        public const string LocalizationSourceName = "BaseDeConhecimento";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "84e9d2c9796944ada166d4840383e682";
    }
}
