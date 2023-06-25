using Godot;

namespace GodotOnFireLibrary
{
    public class GodotFirebaseUser : Node
    {
        public string Uid { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ProviderId { get; set; } = string.Empty;

        public GodotFirebaseUser()
        {

        }

    }
}
