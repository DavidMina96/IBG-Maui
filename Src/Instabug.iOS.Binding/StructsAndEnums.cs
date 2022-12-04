using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace IBG.iOS.Binding
{
	[Flags]
	[Native]
	public enum IBGInvocationEvent : long
	{
		Shake = 1L << 0,
		Screenshot = 1L << 1,
		TwoFingersSwipeLeft = 1L << 2,
		RightEdgePan = 1L << 3,
		FloatingButton = 1L << 4,
		None = 1L << 5
	}

	[Native]
	public enum IBGColorTheme : long
	{
		Light,
		Dark
	}

	[Native]
	public enum IBGInvocationMode : long
	{
		Na,
		NewBug,
		NewFeedback,
		NewQuestion,
		NewChat,
		ChatsList,
		NewQuestionManually
	}

	[Flags]
	[Native]
	public enum IBGBugReportingInvocationOption : long
	{
		EmailFieldHidden = 1L << 0,
		EmailFieldOptional = 1L << 1,
		CommentFieldRequired = 1L << 2,
		DisablePostSendingDialog = 1L << 3,
		None = 1L << 4
	}

	[Flags]
	[Native]
	public enum IBGBugReportingReportType : long
	{
		Bug = 1L << 0,
		Feedback = 1L << 1,
		Question = 1L << 2
	}

	[Flags]
	[Native]
	public enum IBGBugReportingOption : long
	{
		EmailFieldHidden = 1L << 0,
		EmailFieldOptional = 1L << 1,
		CommentFieldRequired = 1L << 2,
		DisablePostSendingDialog = 1L << 3,
		None = 1L << 4
	}

	[Native]
	public enum IBGReportType : long
	{
		Bug,
		Feedback,
		Question
	}

	[Native]
	public enum IBGDismissType : long
	{
		Submit,
		Cancel,
		AddAttachment
	}

	[Native]
	public enum IBGLocale : long
	{
		Arabic,
		Azerbaijani,
		ChineseSimplified,
		ChineseTaiwan,
		ChineseTraditional,
		Czech,
		Danish,
		Dutch,
		English,
		French,
		German,
		Italian,
		Japanese,
		Korean,
		Norwegian,
		Polish,
		Portuguese,
		PortugueseBrazil,
		Russian,
		Slovak,
		Spanish,
		Swedish,
		Turkish,
		Hungarian,
		Finnish,
		Catalan,
		CatalanSpain,
		CatalanRomanian
	}

	[Flags]
	[Native]
	public enum IBGPromptOption : long
	{
		Chat = 1L << 0,
		Bug = 1L << 1,
		Feedback = 1L << 2,
		None = 1L << 3
	}

	[Native]
	public enum IBGPosition : long
	{
		BottomRight,
		TopRight,
		BottomLeft,
		TopLeft
	}

	[Native]
	public enum IBGLogLevel : long
	{
		None = 0,
		Error,
		Warning,
		Info,
		Debug,
		Verbose
	}

	[Native]
	public enum IBGSDKDebugLogsLevel : long
	{
		Verbose = 1,
		Debug = 2,
		Error = 3,
		None = 4
	}

	[Native]
	public enum IBGUserStepsMode : long
	{
		Enable,
		EnabledWithNoScreenshots,
		Disable
	}

	[Flags]
	[Native]
	public enum IBGAttachmentType : long
	{
		ScreenShot = 1L << 1,
		ExtraScreenShot = 1L << 2,
		GalleryImage = 1L << 4,
		ScreenRecording = 1L << 6
	}

	[Native]
	public enum IBGExtendedBugReportMode : long
	{
		EnabledWithRequiredFields,
		EnabledWithOptionalFields,
		Disabled
	}

	[Flags]
	[Native]
	public enum IBGAction : long
	{
		AllActions = 1L << 0,
		ReportBug = 1L << 1,
		RequestNewFeature = 1L << 2,
		AddCommentToFeature = 1L << 3
	}

	[Native]
	public enum IBGWelcomeMessageMode : long
	{
		Live,
		Beta,
		Disabled
	}

	[Native]
	public enum IBGPlatform : long
	{
		Ios,
		ReactNative,
		Cordova,
		Xamarin,
		Unity,
		Flutter
	}

	[Native]
	public enum IBGUIEventType : long
	{
		Tap,
		ForceTouch,
		LongPress,
		Pinch,
		Swipe,
		Scroll
	}

	[Native]
	public enum IBGNonFatalLevel : long
	{
		Info,
		Warning,
		Error,
		Critical
	}

	static class CFunctions
	{
		// extern void InstabugLog (NSString *format, ...) __attribute__((format(NSString, 1, 2)));
		[DllImport ("__Internal")]
		// [Verify (PlatformInvoke)]
		static extern void InstabugLog (NSString format, IntPtr varArgs);

		// extern void IBGLogVerbose (NSString *format, ...) __attribute__((format(NSString, 1, 2)));
		[DllImport ("__Internal")]
		// [Verify (PlatformInvoke)]
		static extern void IBGLogVerbose (NSString format, IntPtr varArgs);

		// extern void IBGLogDebug (NSString *format, ...) __attribute__((format(NSString, 1, 2)));
		[DllImport ("__Internal")]
		// [Verify (PlatformInvoke)]
		static extern void IBGLogDebug (NSString format, IntPtr varArgs);

		// extern void IBGLogInfo (NSString *format, ...) __attribute__((format(NSString, 1, 2)));
		[DllImport ("__Internal")]
		// [Verify (PlatformInvoke)]
		static extern void IBGLogInfo (NSString format, IntPtr varArgs);

		// extern void IBGLogWarn (NSString *format, ...) __attribute__((format(NSString, 1, 2)));
		[DllImport ("__Internal")]
		// [Verify (PlatformInvoke)]
		static extern void IBGLogWarn (NSString format, IntPtr varArgs);

		// extern void IBGLogError (NSString *format, ...) __attribute__((format(NSString, 1, 2)));
		[DllImport ("__Internal")]
		// [Verify (PlatformInvoke)]
		static extern void IBGLogError (NSString format, IntPtr varArgs);

		// extern void IBGNSLog (NSString *format, va_list args);
		[DllImport ("__Internal")]
		// [Verify (PlatformInvoke)]
		static extern unsafe void IBGNSLog (NSString format, sbyte* args);

		// extern void IBGNSLogWithLevel (NSString *format, va_list args, IBGLogLevel logLevel);
		[DllImport ("__Internal")]
		// [Verify (PlatformInvoke)]
		static extern unsafe void IBGNSLogWithLevel (NSString format, sbyte* args, IBGLogLevel logLevel);
	}

	[Native]
	public enum IBGSurveyFinishedState : long
	{
		Submitted,
		Ended,
		Dismissed
	}
}
