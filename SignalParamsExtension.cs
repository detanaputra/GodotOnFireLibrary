using Newtonsoft.Json;

using System;

namespace GodotOnFireLibrary
{
    public static class SignalParamsExtension
    {
        public static T GetData<T>(this SignalParams signalParams)
        {
            if (signalParams == null) return default;
            string data = signalParams.Data;
            if (string.IsNullOrEmpty(data)) return default;
            try
            {
                T type = JsonConvert.DeserializeObject<T>(data);
                return type;
            }
            catch (Exception e)
            {
                Log.E(e.Message);
                return default;
            }
        }

        public static bool IsSuccessful(this SignalParams signalParams)
        {
            if (signalParams == null) return false;
            if (signalParams.Status == 0)
            {
                return true;
            }
            return false;
        }
    }
}