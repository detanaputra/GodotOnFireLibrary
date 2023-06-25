using Godot;
using Godot.Collections;

namespace GodotOnFireLibrary
{
    public partial class GodotOnFire : Node
    {
        private void ConnectSignals()
        {
            plugin.Connect("_get_firebase_user_completed", instance, nameof(instance.OnGetFirebaseUserCompleted));
            plugin.Connect("_firebase_user_signed_in", instance, nameof(instance.OnFirebaseUserSignedIn));
            plugin.Connect("_firebase_user_signed_out", instance, nameof(instance.OnFirebaseUserSignedOut));
            plugin.Connect("_sign_in_anonymously_completed", instance, nameof(instance.OnSignInAnonymouslyCompleted));
            plugin.Connect("_google_sign_in_completed", instance, nameof(instance.OnGoogleSignInCompleted));
            plugin.Connect("_link_account_completed", instance, nameof(instance.OnLinkAccountCompleted));
            plugin.Connect("_email_sign_up_completed", instance, nameof(instance.OnEmailSignUpCompleted));
            plugin.Connect("_email_sign_in_completed", instance, nameof(instance.OnEmailSignInCompleted));
            plugin.Connect("_send_email_verification_completed", instance, nameof(instance.OnSendEmailVerificationCompleted));

            plugin.Connect("_database_set_completed", instance, nameof(instance.OnDatabaseSetCompleted));
            plugin.Connect("_database_push_completed", instance, nameof(instance.OnDatabasePushCompleted));
            plugin.Connect("_database_update_completed", instance, nameof(instance.OnDatabaseUpdateCompleted));
            plugin.Connect("_database_get_completed", instance, nameof(instance.OnDatabaseGetCompleted));
            plugin.Connect("_database_remove_completed", instance, nameof(instance.OnDatabaseRemoveCompleted));

            plugin.Connect("_firestore_set_completed", instance, nameof(instance.OnFirestoreSetCompleted));
            plugin.Connect("_firestore_add_completed", instance, nameof(instance.OnFirestoreAddCompleted));
            plugin.Connect("_firestore_update_completed", instance, nameof(instance.OnFirestoreUpdateCompleted));
            plugin.Connect("_firestore_read_completed", instance, nameof(instance.OnFirestoreReadCompleted));
            plugin.Connect("_firestore_delete_completed", instance, nameof(instance.OnFirestoreDeleteCompleted));

            plugin.Connect("_remote_config_fetch_completed", instance, nameof(instance.OnRemoteConfigFetchCompleted));
            plugin.Connect("_remote_config_activate_completed", instance, nameof(instance.OnRemoteConfigActivateCompleted));
            plugin.Connect("_remote_config_get_value_completed", instance, nameof(instance.OnRemoteConfigGetValueCompleted));
        }

        #region PLUGIN CALLBACK
        private void OnGodotOnFireInitiated(Dictionary signalParams)
        {
            SignalParams param = new SignalParams(signalParams);
            parent.EmitSignal(nameof(GodotOnFireInitiated), param);
        }

        private void OnGetFirebaseUserCompleted(Dictionary signalParams)
        {
            SignalParams param = new SignalParams(signalParams);
            EmitSignal(nameof(GetFirebaseUserCompleted), param);
        }

        private void OnFirebaseUserSignedIn(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(FirebaseUserSignedIn), _param);
        }

        private void OnGoogleSignInCompleted(Dictionary signalParams)
        {
            SignalParams param = new SignalParams(signalParams);
            EmitSignal(nameof(GoogleSignInCompleted), param);
        }

        private void OnEmailSignUpCompleted(Dictionary signalParams)
        {
            SignalParams param = new SignalParams(signalParams);
            EmitSignal(nameof(EmailSignUpCompleted), param);
        }

        private void OnEmailSignInCompleted(Dictionary signalParams)
        {
            SignalParams param = new SignalParams(signalParams);
            EmitSignal(nameof(EmailSignInCompleted), param);
        }

        private void OnSignInAnonymouslyCompleted(Dictionary signalParams)
        {
            SignalParams param = new SignalParams(signalParams);
            EmitSignal(nameof(SignInAnonymouslyCompleted), param);
        }

        private void OnSendEmailVerificationCompleted(Dictionary signalParams)
        {
            SignalParams param = new SignalParams(signalParams);
            EmitSignal(nameof(SendEmailVerificationCompleted), param);
        }

        private void OnFirebaseUserSignedOut(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(FirebaseUserSignedOut), _param);
        }

        private void OnLinkAccountCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(LinkAccountCompleted), _param);
        }

        private void OnDatabaseSetCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(DatabaseSetCompleted), _param);
        }

        private void OnDatabasePushCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(DatabasePushCompleted), _param);
        }

        private void OnDatabaseUpdateCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(DatabaseUpdateCompleted), _param);
        }

        private void OnDatabaseGetCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(DatabaseGetCompleted), _param);
        }

        private void OnDatabaseRemoveCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(DatabaseRemoveCompleted), _param);
        }

        private void OnFirestoreSetCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(FirestoreSetCompleted), _param);
        }

        private void OnFirestoreAddCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(FirestoreAddCompleted), _param);
        }

        private void OnFirestoreUpdateCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(FirestoreUpdateCompleted), _param);
        }

        private void OnFirestoreReadCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(FirestoreReadCompleted), _param);
        }

        private void OnFirestoreDeleteCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(FirestoreDeleteCompleted), _param);
        }

        private void OnRemoteConfigFetchCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(RemoteConfigFetchCompleted), _param);
        }

        private void OnRemoteConfigActivateCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(RemoteConfigActivateCompleted), _param);
        }

        private void OnRemoteConfigGetValueCompleted(Dictionary signalParams)
        {
            SignalParams _param = new SignalParams(signalParams);
            EmitSignal(nameof(RemoteConfigGetValueCompleted), _param);
        }
        #endregion
    }
}
