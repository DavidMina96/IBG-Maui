namespace Instabug.MAUI;

public partial class Instabug
{
    public enum InvocationEvent
    {
        Shake,
        Screenshot,
        TwoFingerSwipe,
        FloatingButton,
        None
    };

    public static partial void Start(string token, List<InvocationEvent> invocationEvents);
}
