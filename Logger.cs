using Godot;

using System.Runtime.CompilerServices;

namespace GodotOnFireLibrary
{
    internal class Log : Node
    {
        public Log() { }

        public override void _Ready()
        {
            base._Ready();
        }

        internal static void D(string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "")
        {
            GD.Print($"{message}, from {caller} at line {lineNumber}");
        }

        internal static void D(string tag, string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "")
        {
            GD.Print($"{tag} : {message}, from {caller} at line {lineNumber}");
        }

        internal static void W(string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "")
        {
            GD.PushWarning($"{message}, from {caller} at line {lineNumber}");
        }

        internal static void W(string tag, string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "")
        {
            GD.PushWarning($"{tag} : {message}, from {caller} at line {lineNumber}");
        }

        internal static void E(string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "")
        {
            GD.PushError($"{message}, from {caller} at line {lineNumber}");
        }

        internal static void E(string tag, string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = "")
        {
            GD.PushError($"{tag} : {message}, from {caller} at line {lineNumber}");
        }
    }
}
