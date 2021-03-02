namespace FacturaEnOrigen
{
    static class Constants
    {
        public static bool isPRO = false; // true;
        public static bool isDebug = true; //true;
        /* PRODUCCIO */
        private static readonly string Usuario_PRO = "sa";
        private static readonly string Password_PRO = "nexus";
        private static readonly string Empresa_PRO = "";

        public static string SERVER_BDD_PRO = "SERVER2k8\\NEXUS";
        public static string USER_ID_BDD_PRO = "sa";
        public static string PASSWORD_BDD_PRO = "nexus";
        public static string DATABASE_BDD_PRO = "";
        private static readonly string Connection_PRO = "server=" + Constants.SERVER_BDD_PRO + ";user id=" + Constants.USER_ID_BDD_PRO + "; password=" + Constants.PASSWORD_BDD_PRO + "; database=" + Constants.DATABASE_BDD_PRO;
        /* DESENVOLUPAMENT*/
        private static readonly string Usuario_DEV = "sa";
        private static readonly string Password_DEV = "";
        private static readonly string Empresa_DEV = "";

        public static string SERVER_BDD_DEV = "WIN2k12\\NEXUS";
        public static string USER_ID_BDD_DEV = "sa";
        public static string PASSWORD_BDD_DEV = "";
        public static string DATABASE_BDD_DEV = "";
        private static readonly string Connection_DEV = "server=" + Constants.SERVER_BDD_DEV + ";user id=" + Constants.USER_ID_BDD_DEV + "; password=" + Constants.PASSWORD_BDD_DEV + "; database=" + Constants.DATABASE_BDD_DEV;

        public static string GetConnectionString()
        {
            return (isPRO ? Connection_PRO : Connection_DEV);
        }

        public static string GetUsuari()
        {
            return (isPRO ? Usuario_PRO : Usuario_DEV);
        }
        public static string GetPassword()
        {
            return (isPRO ? Password_PRO : Password_DEV);
        }
        public static string GetEmpresa()
        {
            return (isPRO ? Empresa_PRO : Empresa_DEV);
        }
    }
}
