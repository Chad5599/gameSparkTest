#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("TkZXrPfnfax1tlgosMD7wz3jivrMPtth0Ivb6zwg74WIsg9ugWcPxL6CThMHkAdnvmBxohsUmQsPfHu2AdHYif+v/HJoY/kwgYxAWPFe9PB7yUppe0ZNQmHNA828RkpKSk5LSEEYqeqFwU7jrhV/yOycpjNMN2DBAyb5Ux6zUDLjnMCX2IAFG5nJ35THmKY0tRNZVp3itzmTnRG4N3uyHpjSZd4CA6m6McEhUxy3rCcVmFtOB5FDovYxtnYQCAjU6qWsyUGEaLZHF5cAjTPhyvZ6dDZS6iYiMgHTpvV1pJtRyjo40NfDlY2Sj2NIeUowyUpES3vJSkFJyUpKS/TKbpd8vdFHvFQPVe53J9Wd0gwNB5m+6r6mlQO1/ri8FKdqPklISktK");
        private static int[] order = new int[] { 12,13,8,9,12,5,8,10,8,9,11,11,13,13,14 };
        private static int key = 75;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
