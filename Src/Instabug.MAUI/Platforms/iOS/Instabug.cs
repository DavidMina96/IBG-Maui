using NativeInstabug = IBG.iOS.Binding.Instabug;
using IBG.iOS.Binding;

namespace Instabug.MAUI;

public partial class Instabug
{
    public static partial void Start(string token, List<InvocationEvent> invocationEvents)
    {
        var resolvedEvents = invocationEvents.Aggregate(
            0,
            (resolvedEvents, invocationEvent) =>
            {
                var mappedEvents = invocationEvent switch
                {
                    InvocationEvent.Shake => IBGInvocationEvent.Shake,
                    InvocationEvent.Screenshot => IBGInvocationEvent.Screenshot,
                    InvocationEvent.TwoFingerSwipe => IBGInvocationEvent.TwoFingersSwipeLeft,
                    InvocationEvent.FloatingButton => IBGInvocationEvent.FloatingButton,
                    InvocationEvent.None => IBGInvocationEvent.None
                };
                return resolvedEvents | (int)mappedEvents;
            }
        );

        NativeInstabug.StartWithToken(token, (IBGInvocationEvent)resolvedEvents);
    }
}
