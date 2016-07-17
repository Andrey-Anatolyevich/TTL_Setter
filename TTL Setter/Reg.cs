using Microsoft.Win32;

namespace Reg_ns{
    class Reg {
        public string[] GetSubKeys(string path) {
            RegistryKey Key = Registry.LocalMachine.OpenSubKey(path);
            string[] Result = Key.GetSubKeyNames();
            Key.Close();
            return Result;
        }
        public string[] GetKeys(string path) {
            RegistryKey Key = Registry.LocalMachine.OpenSubKey(path);
            string[] Result = Key.GetValueNames();
            Key.Close();
            return Result;
        }
        public object GetKeyValue(string path, string keyName) {
            RegistryKey Key = Registry.LocalMachine.OpenSubKey(path);
            object Result = Key.GetValue(keyName);
            Key.Close();
            return Result;
        }
        public void CreateSetKey(string path, string keyName, object value) {
            RegistryKey Key = Registry.LocalMachine.OpenSubKey(path, true);
            Key.SetValue(keyName, value, RegistryValueKind.DWord);
            Key.Close();
        }
        public void DeleteKey(string path, string keyName) {
            RegistryKey Key = Registry.LocalMachine.OpenSubKey(path, true);
            Key.DeleteValue(keyName, false);
        }
    }
}
