using NativeInstabug = Com.Instabug.Library.Instabug;
using Com.Instabug.Library.Invocation;

namespace Instabug.MAUI;

public partial class Instabug
{
    public static partial void Start(string token, List<InvocationEvent> invocationEvents)
    {
        var resolvedEvents = invocationEvents
            .Select(invocationEvent =>
            {
                return invocationEvent switch
                {
                    InvocationEvent.Shake => InstabugInvocationEvent.Shake,
                    InvocationEvent.Screenshot => InstabugInvocationEvent.Screenshot,
                    InvocationEvent.TwoFingerSwipe => InstabugInvocationEvent.TwoFingerSwipeLeft,
                    InvocationEvent.FloatingButton => InstabugInvocationEvent.FloatingButton,
                    InvocationEvent.None => InstabugInvocationEvent.None,
                    _ => InstabugInvocationEvent.None,
                };
            })
            .ToArray();

        var app = (MauiApplication)Platform.AppContext;
        new NativeInstabug.Builder(app, token)
            .SetInvocationEvents(resolvedEvents)
            .Build();
    }
}
