using Godot;

namespace GodotOnFireLibrary
{
    public partial class GodotOnFire : Node
    {
        [Signal]
        public delegate void GodotOnFireInitiated(SignalParams signalParams);

        [Signal]
        public delegate void GetFirebaseUserCompleted(SignalParams signalParams);

        [Signal]
        public delegate void FirebaseUserSignedIn(SignalParams signalParams);

        [Signal]
        public delegate void FirebaseUserSignedOut(SignalParams signalParams);

        [Signal]
        public delegate void SignInAnonymouslyCompleted(SignalParams signalParams);

        [Signal]
        public delegate void GoogleSignInCompleted(SignalParams signalParams);

        [Signal]
        public delegate void LinkAccountCompleted(SignalParams signalParams);

        [Signal]
        public delegate void EmailSignUpCompleted(SignalParams signalParams);

        [Signal]
        public delegate void EmailSignInCompleted(SignalParams signalParams);

        [Signal]
        public delegate void SendEmailVerificationCompleted(SignalParams signalParams);

        [Signal]
        public delegate void DatabaseSetCompleted(SignalParams signalParams);

        [Signal]
        public delegate void DatabasePushCompleted(SignalParams signalParams);

        [Signal]
        public delegate void DatabaseUpdateCompleted(SignalParams signalParams);

        [Signal]
        public delegate void DatabaseGetCompleted(SignalParams signalParams);

        [Signal]
        public delegate void DatabaseRemoveCompleted(SignalParams signalParams);

        [Signal]
        public delegate void FirestoreSetCompleted(SignalParams signalParams);

        [Signal]
        public delegate void FirestoreAddCompleted(SignalParams signalParams);

        [Signal]
        public delegate void FirestoreUpdateCompleted(SignalParams signalParams);

        [Signal]
        public delegate void FirestoreReadCompleted(SignalParams signalParams);

        [Signal]
        public delegate void FirestoreDeleteCompleted(SignalParams signalParams);

        [Signal]
        public delegate void RemoteConfigFetchCompleted(SignalParams signalParams);

        [Signal]
        public delegate void RemoteConfigActivateCompleted(SignalParams signalParams);

        [Signal]
        public delegate void RemoteConfigGetValueCompleted(SignalParams signalParams);
    }
}
