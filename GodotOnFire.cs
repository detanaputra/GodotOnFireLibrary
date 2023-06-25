using Godot;
using Godot.Collections;

using System.Threading.Tasks;

using PM = GodotOnFireLibrary.PluginMethods;

namespace GodotOnFireLibrary
{
    public partial class GodotOnFire : Node
    {
        public bool IsAvailable { get; private set; } = false;

        private Godot.Object plugin;
        private Node parent;
        private static GodotOnFire instance;

        public static GodotOnFire GetInstance()
        {
            if (instance == null)
            {
                instance = new GodotOnFire();
            }
            return instance;
        }

        #region PLUGIN METHOD
        public async Task Init(Node _parent, Godot.Object _plugin)
        {
            Log.D(nameof(GodotOnFire), "Initiating GodotOnFire");
            if (Engine.HasSingleton("GodotOnFire"))
            {
                Log.D(nameof(GodotOnFire), "GodotOnFire android plugin found!");
                plugin = _plugin;
                parent = _parent;
                parent.AddChild(GetInstance());
                IsAvailable = true;
                Log.D(nameof(GodotOnFire), "Connecting signals from GodotOnFire");
                ConnectSignals();
                Log.D(nameof(GodotOnFire), "All signals from GodotOnFire are connected!");
                Log.D(nameof(GodotOnFire), "Calling GodotOnFire init");
                plugin.Call(PM.init);
                await ToSignal(GetInstance(), nameof(GodotOnFireInitiated));
                Log.D(nameof(GodotOnFire), "GodotOnFire initiated successfully");
            }
            else
            {
                Log.E(nameof(GodotOnFire), "GodotOnFire Not Detected!!!");
            }
        }

        private void CheckSignalParams(in object[] result, ref SignalParams signalParams)
        {
            if (result[0] is SignalParams _param)
            {
                signalParams = _param;
            }
        }

        public async Task<SignalParams> SignInGoogle()
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.signInGoogle);
                object[] result = await ToSignal(GetInstance(), nameof(GoogleSignInCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> SignInAnonymously()
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.signInAnonymously);
                object[] result = await ToSignal(GetInstance(), nameof(SignInAnonymouslyCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> SignOut()
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.signOut);
                object[] result = await ToSignal(GetInstance(), nameof(FirebaseUserSignedOut));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> LinkAccountWithGoogle()
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.linkAccountWithGoogle);
                object[] result = await ToSignal(GetInstance(), nameof(LinkAccountCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> GetFirebaseUser()
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.getFirebaseUser);
                object[] result = await ToSignal(GetInstance(), nameof(GetFirebaseUserCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> SignUpWithEmail(string email, string password)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.signUpWithEmail, email, password);
                object[] result = await ToSignal(GetInstance(), nameof(EmailSignUpCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> SignInWithEmail(string email, string password)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance?.plugin?.Call(PM.signInWithEmail, email, password);
                object[] result = await ToSignal(GetInstance(), nameof(EmailSignInCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> LinkAccountWithEmail(string email, string password)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.linkAccountWithEmail, email, password);
                object[] result = await ToSignal(GetInstance(), nameof(LinkAccountCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> SendEmailVerification()
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.sendEmailVerification);
                object[] result = await ToSignal(GetInstance(), nameof(SendEmailVerificationCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> DatabaseSetUserData(string collectionName, string data)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.databaseSetUserData, collectionName, data);
                object[] result = await ToSignal(GetInstance(), nameof(DatabaseSetCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> DatabaseSetData(string collectionName, string data)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.databaseSetData, collectionName, data);
                object[] result = await ToSignal(GetInstance(), nameof(DatabaseSetCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> DatabasePushUserData(string collectionName, string data)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.databasePushUserData, collectionName, data);
                object[] result = await ToSignal(GetInstance(), nameof(DatabasePushCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> DatabasePushData(string collectionName, string data)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.databasePushData, collectionName, data);
                object[] result = await ToSignal(GetInstance(), nameof(DatabasePushCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> DatabaseUpdateUserData(string collectionName, string data)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.databaseUpdateUserData, collectionName, data);
                object[] result = await ToSignal(GetInstance(), nameof(DatabaseUpdateCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> DatabaseUpdateData(string collectionName, string data)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.databaseUpdateData, collectionName, data);
                object[] result = await ToSignal(GetInstance(), nameof(DatabaseUpdateCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> DatabaseGetUserData(string collectionName)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.databaseGetUserData, collectionName);
                object[] result = await ToSignal(GetInstance(), nameof(DatabaseGetCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> DatabaseGetData(string collectionName)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.databaseGetData, collectionName);
                object[] result = await ToSignal(GetInstance(), nameof(DatabaseGetCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> DatabaseRemoveUserData(string collectionName)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.databaseRemoveUserData, collectionName);
                object[] result = await ToSignal(GetInstance(), nameof(DatabaseRemoveCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> FirestoreSetUserData(string collectionName, string data)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.firestoreSetUserData, collectionName, data);
                object[] result = await ToSignal(GetInstance(), nameof(FirestoreSetCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> FirestoreSetData(string collectionName, string data)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.firestoreSetData, collectionName, data);
                object[] result = await ToSignal(GetInstance(), nameof(FirestoreSetCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> FirestoreAddData(string collectionName, string data)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.firestoreAddData, collectionName, data);
                object[] result = await ToSignal(GetInstance(), nameof(FirestoreAddCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> FirestoreUpdateUserData(string collectionName, string data)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.firestoreUpdateUserData, collectionName, data);
                object[] result = await ToSignal(GetInstance(), nameof(FirestoreUpdateCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> FirestoreUpdateData(string collectionName, string data)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.firestoreUpdateData, collectionName, data);
                object[] result = await ToSignal(GetInstance(), nameof(FirestoreUpdateCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> FirestoreReadUserData(string collectionName)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.firestoreReadUserData, collectionName);
                object[] result = await ToSignal(GetInstance(), nameof(FirestoreReadCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> FirestoreReadData(string collectionName)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.firestoreReadData, collectionName);
                object[] result = await ToSignal(GetInstance(), nameof(FirestoreReadCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> FirestoreDeleteUserData(string collectionName)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.firestoreDeleteUserData, collectionName);
                object[] result = await ToSignal(GetInstance(), nameof(FirestoreDeleteCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> FirestoreDeleteData(string collectionName)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.firestoreDeleteData, collectionName);
                object[] result = await ToSignal(GetInstance(), nameof(FirestoreDeleteCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> RemoteConfigFetch()
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.remoteConfigFetch);
                object[] result = await ToSignal(GetInstance(), nameof(RemoteConfigFetchCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> RemoteConfigActivate()
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.remoteConfigActivate);
                object[] result = await ToSignal(GetInstance(), nameof(RemoteConfigActivateCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> RemoteConfigFetchAndActivate()
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.remoteConfigFetchAndActivate);
                object[] result = await ToSignal(GetInstance(), nameof(RemoteConfigActivateCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> RemoteConfigGetString(string key)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.remoteConfigGetString, key);
                object[] result = await ToSignal(GetInstance(), nameof(RemoteConfigGetValueCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> RemoteConfigGetDouble(string key)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.remoteConfigGetDouble, key);
                object[] result = await ToSignal(GetInstance(), nameof(RemoteConfigGetValueCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> RemoteConfigGetLong(string key)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.remoteConfigGetLong, key);
                object[] result = await ToSignal(GetInstance(), nameof(RemoteConfigGetValueCompleted));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public async Task<SignalParams> RemoteConfigGetBoolean(string key)
        {
            SignalParams param = null;
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.remoteConfigGetBoolean, key);
                object[] result = await ToSignal(GetInstance(), nameof(RemoteConfigGetBoolean));
                CheckSignalParams(result, ref param);
            }
            return param;
        }

        public void LogEvent(string eventName, Dictionary param)
        {
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.logEvent, eventName, param);
            }
        }

        public void SetUserProperty(string propertyName, string value)
        {
            if (instance != null && plugin != null)
            {
                instance.plugin.Call(PM.setUserProperty, propertyName, value);
            }
        }

        #endregion
    }
}