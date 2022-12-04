using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace IBG.iOS.Binding
{
	[Static]
	// [Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const kIBGStartAlertTextStringName;
		[Field ("kIBGStartAlertTextStringName", "__Internal")]
		NSString kIBGStartAlertTextStringName { get; }

		// extern NSString *const kIBGShakeStartAlertTextStringName;
		[Field ("kIBGShakeStartAlertTextStringName", "__Internal")]
		NSString kIBGShakeStartAlertTextStringName { get; }

		// extern NSString *const kIBGTwoFingerSwipeStartAlertTextStringName;
		[Field ("kIBGTwoFingerSwipeStartAlertTextStringName", "__Internal")]
		NSString kIBGTwoFingerSwipeStartAlertTextStringName { get; }

		// extern NSString *const kIBGEdgeSwipeStartAlertTextStringName;
		[Field ("kIBGEdgeSwipeStartAlertTextStringName", "__Internal")]
		NSString kIBGEdgeSwipeStartAlertTextStringName { get; }

		// extern NSString *const kIBGScreenshotStartAlertTextStringName;
		[Field ("kIBGScreenshotStartAlertTextStringName", "__Internal")]
		NSString kIBGScreenshotStartAlertTextStringName { get; }

		// extern NSString *const kIBGFloatingButtonStartAlertTextStringName;
		[Field ("kIBGFloatingButtonStartAlertTextStringName", "__Internal")]
		NSString kIBGFloatingButtonStartAlertTextStringName { get; }

		// extern NSString *const kIBGBetaWelcomeMessageWelcomeStepTitle;
		[Field ("kIBGBetaWelcomeMessageWelcomeStepTitle", "__Internal")]
		NSString kIBGBetaWelcomeMessageWelcomeStepTitle { get; }

		// extern NSString *const kIBGBetaWelcomeMessageWelcomeStepContent;
		[Field ("kIBGBetaWelcomeMessageWelcomeStepContent", "__Internal")]
		NSString kIBGBetaWelcomeMessageWelcomeStepContent { get; }

		// extern NSString *const kIBGBetaWelcomeMessageHowToReportStepTitle;
		[Field ("kIBGBetaWelcomeMessageHowToReportStepTitle", "__Internal")]
		NSString kIBGBetaWelcomeMessageHowToReportStepTitle { get; }

		// extern NSString *const kIBGBetaWelcomeMessageHowToReportStepContent;
		[Field ("kIBGBetaWelcomeMessageHowToReportStepContent", "__Internal")]
		NSString kIBGBetaWelcomeMessageHowToReportStepContent { get; }

		// extern NSString *const kIBGBetaWelcomeMessageFinishStepTitle;
		[Field ("kIBGBetaWelcomeMessageFinishStepTitle", "__Internal")]
		NSString kIBGBetaWelcomeMessageFinishStepTitle { get; }

		// extern NSString *const kIBGBetaWelcomeMessageFinishStepContent;
		[Field ("kIBGBetaWelcomeMessageFinishStepContent", "__Internal")]
		NSString kIBGBetaWelcomeMessageFinishStepContent { get; }

		// extern NSString *const kIBGBetaWelcomeDoneButtonTitle;
		[Field ("kIBGBetaWelcomeDoneButtonTitle", "__Internal")]
		NSString kIBGBetaWelcomeDoneButtonTitle { get; }

		// extern NSString *const kIBGLiveWelcomeMessageTitle;
		[Field ("kIBGLiveWelcomeMessageTitle", "__Internal")]
		NSString kIBGLiveWelcomeMessageTitle { get; }

		// extern NSString *const kIBGLiveWelcomeMessageContent;
		[Field ("kIBGLiveWelcomeMessageContent", "__Internal")]
		NSString kIBGLiveWelcomeMessageContent { get; }

		// extern NSString *const kIBGInvalidEmailMessageStringName;
		[Field ("kIBGInvalidEmailMessageStringName", "__Internal")]
		NSString kIBGInvalidEmailMessageStringName { get; }

		// extern NSString *const kIBGInvalidEmailTitleStringName;
		[Field ("kIBGInvalidEmailTitleStringName", "__Internal")]
		NSString kIBGInvalidEmailTitleStringName { get; }

		// extern NSString *const kIBGInvalidCommentMessageStringName __attribute__((deprecated("'kIBGInvalidCommentMessageStringName' is deprecated: first deprecated in SDK 11.4.0. Use kIBGInsufficientContentTitleStringName instead.")));
		[Field ("kIBGInvalidCommentMessageStringName", "__Internal")]
		NSString kIBGInvalidCommentMessageStringName { get; }

		// extern NSString *const kIBGInvalidCommentTitleStringName __attribute__((deprecated("'kIBGInvalidCommentTitleStringName' is deprecated: first deprecated in SDK 11.4.0. Use kIBGInsufficientContentMessageStringName instead.")));
		[Field ("kIBGInvalidCommentTitleStringName", "__Internal")]
		NSString kIBGInvalidCommentTitleStringName { get; }

		// extern NSString *const kIBGInvalidNumberTitleStringName;
		[Field ("kIBGInvalidNumberTitleStringName", "__Internal")]
		NSString kIBGInvalidNumberTitleStringName { get; }

		// extern NSString *const kIBGReportCategoriesAccessibilityScrollStringName;
		[Field ("kIBGReportCategoriesAccessibilityScrollStringName", "__Internal")]
		NSString kIBGReportCategoriesAccessibilityScrollStringName { get; }

		// extern NSString *const kIBGAnnotationCloseButtonStringName;
		[Field ("kIBGAnnotationCloseButtonStringName", "__Internal")]
		NSString kIBGAnnotationCloseButtonStringName { get; }

		// extern NSString *const kIBGAnnotationSaveButtonStringName;
		[Field ("kIBGAnnotationSaveButtonStringName", "__Internal")]
		NSString kIBGAnnotationSaveButtonStringName { get; }

		// extern NSString *const kIBGAnnotationDrawnShapeStringName;
		[Field ("kIBGAnnotationDrawnShapeStringName", "__Internal")]
		NSString kIBGAnnotationDrawnShapeStringName { get; }

		// extern NSString *const kIBGAttachmentActionSheetStopScreenRecording;
		[Field ("kIBGAttachmentActionSheetStopScreenRecording", "__Internal")]
		NSString kIBGAttachmentActionSheetStopScreenRecording { get; }

		// extern NSString *const kIBGAttachmentActionSheetUnmuteMic;
		[Field ("kIBGAttachmentActionSheetUnmuteMic", "__Internal")]
		NSString kIBGAttachmentActionSheetUnmuteMic { get; }

		// extern NSString *const kIBGAttachmentActionSheetMuteMic;
		[Field ("kIBGAttachmentActionSheetMuteMic", "__Internal")]
		NSString kIBGAttachmentActionSheetMuteMic { get; }

		// extern NSString *const kIBGScreenRecordingDuration;
		[Field ("kIBGScreenRecordingDuration", "__Internal")]
		NSString kIBGScreenRecordingDuration { get; }

		// extern NSString *const kIBGInvalidNumberMessageStringName;
		[Field ("kIBGInvalidNumberMessageStringName", "__Internal")]
		NSString kIBGInvalidNumberMessageStringName { get; }

		// extern NSString *const kIBGCloseConversationsStringLabel;
		[Field ("kIBGCloseConversationsStringLabel", "__Internal")]
		NSString kIBGCloseConversationsStringLabel { get; }

		// extern NSString *const kIBGBackToConversationsStringLabel;
		[Field ("kIBGBackToConversationsStringLabel", "__Internal")]
		NSString kIBGBackToConversationsStringLabel { get; }

		// extern NSString *const kIBGSendMessageStringLabel;
		[Field ("kIBGSendMessageStringLabel", "__Internal")]
		NSString kIBGSendMessageStringLabel { get; }

		// extern NSString *const kIBGDismissMessageStringLabel;
		[Field ("kIBGDismissMessageStringLabel", "__Internal")]
		NSString kIBGDismissMessageStringLabel { get; }

		// extern NSString *const kIBGReplyToMessageStringLabel;
		[Field ("kIBGReplyToMessageStringLabel", "__Internal")]
		NSString kIBGReplyToMessageStringLabel { get; }

		// extern NSString *const kIBGInvocationTitleStringName;
		[Field ("kIBGInvocationTitleStringName", "__Internal")]
		NSString kIBGInvocationTitleStringName { get; }

		// extern NSString *const kIBGInvocationTitleHintStringName;
		[Field ("kIBGInvocationTitleHintStringName", "__Internal")]
		NSString kIBGInvocationTitleHintStringName { get; }

		// extern NSString *const kIBGChatsListHintStringName;
		[Field ("kIBGChatsListHintStringName", "__Internal")]
		NSString kIBGChatsListHintStringName { get; }

		// extern NSString *const kIBGOneChatsListHintStringName;
		[Field ("kIBGOneChatsListHintStringName", "__Internal")]
		NSString kIBGOneChatsListHintStringName { get; }

		// extern NSString *const kIBGCancelPromptHintStringName;
		[Field ("kIBGCancelPromptHintStringName", "__Internal")]
		NSString kIBGCancelPromptHintStringName { get; }

		// extern NSString *const kIBGReportCategoriesBackButtonStringName;
		[Field ("kIBGReportCategoriesBackButtonStringName", "__Internal")]
		NSString kIBGReportCategoriesBackButtonStringName { get; }

		// extern NSString *const kIBGReportCategoriesBackButtonHintStringName;
		[Field ("kIBGReportCategoriesBackButtonHintStringName", "__Internal")]
		NSString kIBGReportCategoriesBackButtonHintStringName { get; }

		// extern NSString *const kIBGFeatureRequetsPromptName __attribute__((deprecated("")));
		[Field ("kIBGFeatureRequetsPromptName", "__Internal")]
		NSString kIBGFeatureRequetsPromptName { get; }

		// extern NSString *const kIBGAskAQuestionStringName;
		[Field ("kIBGAskAQuestionStringName", "__Internal")]
		NSString kIBGAskAQuestionStringName { get; }

		// extern NSString *const kIBGReportBugStringName;
		[Field ("kIBGReportBugStringName", "__Internal")]
		NSString kIBGReportBugStringName { get; }

		// extern NSString *const kIBGReportFeedbackStringName;
		[Field ("kIBGReportFeedbackStringName", "__Internal")]
		NSString kIBGReportFeedbackStringName { get; }

		// extern NSString *const kIBGReportBugDescriptionStringName;
		[Field ("kIBGReportBugDescriptionStringName", "__Internal")]
		NSString kIBGReportBugDescriptionStringName { get; }

		// extern NSString *const kIBGReportFeedbackDescriptionStringName;
		[Field ("kIBGReportFeedbackDescriptionStringName", "__Internal")]
		NSString kIBGReportFeedbackDescriptionStringName { get; }

		// extern NSString *const kIBGReportQuestionDescriptionStringName;
		[Field ("kIBGReportQuestionDescriptionStringName", "__Internal")]
		NSString kIBGReportQuestionDescriptionStringName { get; }

		// extern NSString *const kIBGRequestFeatureDescriptionStringName;
		[Field ("kIBGRequestFeatureDescriptionStringName", "__Internal")]
		NSString kIBGRequestFeatureDescriptionStringName { get; }

		// extern NSString *const kIBGAccessibilityReportFeedbackDescriptionStringName;
		[Field ("kIBGAccessibilityReportFeedbackDescriptionStringName", "__Internal")]
		NSString kIBGAccessibilityReportFeedbackDescriptionStringName { get; }

		// extern NSString *const kIBGAccessibilityReportBugDescriptionStringName;
		[Field ("kIBGAccessibilityReportBugDescriptionStringName", "__Internal")]
		NSString kIBGAccessibilityReportBugDescriptionStringName { get; }

		// extern NSString *const kIBGAccessibilityRequestFeatureDescriptionStringName;
		[Field ("kIBGAccessibilityRequestFeatureDescriptionStringName", "__Internal")]
		NSString kIBGAccessibilityRequestFeatureDescriptionStringName { get; }

		// extern NSString *const kIBGPhotoPickerTitle;
		[Field ("kIBGPhotoPickerTitle", "__Internal")]
		NSString kIBGPhotoPickerTitle { get; }

		// extern NSString *const kIBGProgressViewTitle;
		[Field ("kIBGProgressViewTitle", "__Internal")]
		NSString kIBGProgressViewTitle { get; }

		// extern NSString *const kIBGGalleryPermissionDeniedAlertTitle;
		[Field ("kIBGGalleryPermissionDeniedAlertTitle", "__Internal")]
		NSString kIBGGalleryPermissionDeniedAlertTitle { get; }

		// extern NSString *const kIBGGalleryPermissionDeniedAlertMessage;
		[Field ("kIBGGalleryPermissionDeniedAlertMessage", "__Internal")]
		NSString kIBGGalleryPermissionDeniedAlertMessage { get; }

		// extern NSString *const kIBGMaximumSizeExceededAlertTitle;
		[Field ("kIBGMaximumSizeExceededAlertTitle", "__Internal")]
		NSString kIBGMaximumSizeExceededAlertTitle { get; }

		// extern NSString *const kIBGMaximumSizeExceededAlertMessage;
		[Field ("kIBGMaximumSizeExceededAlertMessage", "__Internal")]
		NSString kIBGMaximumSizeExceededAlertMessage { get; }

		// extern NSString *const kIBGiCloudImportErrorAlertTitle;
		[Field ("kIBGiCloudImportErrorAlertTitle", "__Internal")]
		NSString kIBGiCloudImportErrorAlertTitle { get; }

		// extern NSString *const kIBGiCloudImportErrorAlertMessage;
		[Field ("kIBGiCloudImportErrorAlertMessage", "__Internal")]
		NSString kIBGiCloudImportErrorAlertMessage { get; }

		// extern NSString *const kIBGEmailFieldPlaceholderStringName;
		[Field ("kIBGEmailFieldPlaceholderStringName", "__Internal")]
		NSString kIBGEmailFieldPlaceholderStringName { get; }

		// extern NSString *const kIBGEmailFieldAccessibilityStringLabel;
		[Field ("kIBGEmailFieldAccessibilityStringLabel", "__Internal")]
		NSString kIBGEmailFieldAccessibilityStringLabel { get; }

		// extern NSString *const kIBGEmailFieldAccessibilityStringHint;
		[Field ("kIBGEmailFieldAccessibilityStringHint", "__Internal")]
		NSString kIBGEmailFieldAccessibilityStringHint { get; }

		// extern NSString *const kIBGNumberFieldPlaceholderStringName;
		[Field ("kIBGNumberFieldPlaceholderStringName", "__Internal")]
		NSString kIBGNumberFieldPlaceholderStringName { get; }

		// extern NSString *const kIBGNumberInfoAlertMessageStringName;
		[Field ("kIBGNumberInfoAlertMessageStringName", "__Internal")]
		NSString kIBGNumberInfoAlertMessageStringName { get; }

		// extern NSString *const kIBGCommentFieldPlaceholderForBugReportStringName;
		[Field ("kIBGCommentFieldPlaceholderForBugReportStringName", "__Internal")]
		NSString kIBGCommentFieldPlaceholderForBugReportStringName { get; }

		// extern NSString *const kIBGCommentFieldPlaceholderForFeedbackStringName;
		[Field ("kIBGCommentFieldPlaceholderForFeedbackStringName", "__Internal")]
		NSString kIBGCommentFieldPlaceholderForFeedbackStringName { get; }

		// extern NSString *const kIBGCommentFieldPlaceholderForQuestionStringName;
		[Field ("kIBGCommentFieldPlaceholderForQuestionStringName", "__Internal")]
		NSString kIBGCommentFieldPlaceholderForQuestionStringName { get; }

		// extern NSString *const kIBGCommentFieldAccessibilityStringLabel;
		[Field ("kIBGCommentFieldAccessibilityStringLabel", "__Internal")]
		NSString kIBGCommentFieldAccessibilityStringLabel { get; }

		// extern NSString *const kIBGCommentFieldBugAccessibilityStringHint;
		[Field ("kIBGCommentFieldBugAccessibilityStringHint", "__Internal")]
		NSString kIBGCommentFieldBugAccessibilityStringHint { get; }

		// extern NSString *const kIBGCommentFieldImprovementAccessibilityStringHint;
		[Field ("kIBGCommentFieldImprovementAccessibilityStringHint", "__Internal")]
		NSString kIBGCommentFieldImprovementAccessibilityStringHint { get; }

		// extern NSString *const kIBGCommentFieldAskQuestionAccessibilityStringHint;
		[Field ("kIBGCommentFieldAskQuestionAccessibilityStringHint", "__Internal")]
		NSString kIBGCommentFieldAskQuestionAccessibilityStringHint { get; }

		// extern NSString *const kIBGChatReplyFieldPlaceholderStringName;
		[Field ("kIBGChatReplyFieldPlaceholderStringName", "__Internal")]
		NSString kIBGChatReplyFieldPlaceholderStringName { get; }

		// extern NSString *const kIBGAddScreenRecordingMessageStringName;
		[Field ("kIBGAddScreenRecordingMessageStringName", "__Internal")]
		NSString kIBGAddScreenRecordingMessageStringName { get; }

		// extern NSString *const kIBGAddVoiceMessageStringName;
		[Field ("kIBGAddVoiceMessageStringName", "__Internal")]
		NSString kIBGAddVoiceMessageStringName { get; }

		// extern NSString *const kIBGAddImageFromGalleryStringName;
		[Field ("kIBGAddImageFromGalleryStringName", "__Internal")]
		NSString kIBGAddImageFromGalleryStringName { get; }

		// extern NSString *const kIBGExtraFieldsStringLabel;
		[Field ("kIBGExtraFieldsStringLabel", "__Internal")]
		NSString kIBGExtraFieldsStringLabel { get; }

		// extern NSString *const kIBGAccessibilityExtraFieldsStepsLabel;
		[Field ("kIBGAccessibilityExtraFieldsStepsLabel", "__Internal")]
		NSString kIBGAccessibilityExtraFieldsStepsLabel { get; }

		// extern NSString *const kIBGAccessibilityExtraFieldsStepsRequiredLabel;
		[Field ("kIBGAccessibilityExtraFieldsStepsRequiredLabel", "__Internal")]
		NSString kIBGAccessibilityExtraFieldsStepsRequiredLabel { get; }

		// extern NSString *const kIBGRequiredExtraFieldsStringLabel;
		[Field ("kIBGRequiredExtraFieldsStringLabel", "__Internal")]
		NSString kIBGRequiredExtraFieldsStringLabel { get; }

		// extern NSString *const kIBGAddExtraScreenshotStringName;
		[Field ("kIBGAddExtraScreenshotStringName", "__Internal")]
		NSString kIBGAddExtraScreenshotStringName { get; }

		// extern NSString *const kIBGAccessibilityReproStepsDisclaimerStringLabel;
		[Field ("kIBGAccessibilityReproStepsDisclaimerStringLabel", "__Internal")]
		NSString kIBGAccessibilityReproStepsDisclaimerStringLabel { get; }

		// extern NSString *const kIBGAccessibilityImageAttachmentStringHint;
		[Field ("kIBGAccessibilityImageAttachmentStringHint", "__Internal")]
		NSString kIBGAccessibilityImageAttachmentStringHint { get; }

		// extern NSString *const kIBGAccessibilityVideoAttachmentStringHint;
		[Field ("kIBGAccessibilityVideoAttachmentStringHint", "__Internal")]
		NSString kIBGAccessibilityVideoAttachmentStringHint { get; }

		// extern NSString *const kIBGTakeScreenshotAccessibilityStringLabel;
		[Field ("kIBGTakeScreenshotAccessibilityStringLabel", "__Internal")]
		NSString kIBGTakeScreenshotAccessibilityStringLabel { get; }

		// extern NSString *const kIBGTakeScreenRecordingAccessibilityStringLabel;
		[Field ("kIBGTakeScreenRecordingAccessibilityStringLabel", "__Internal")]
		NSString kIBGTakeScreenRecordingAccessibilityStringLabel { get; }

		// extern NSString *const kIBGSelectImageFromGalleryLabel;
		[Field ("kIBGSelectImageFromGalleryLabel", "__Internal")]
		NSString kIBGSelectImageFromGalleryLabel { get; }

		// extern NSString *const kIBGAddAttachmentAccessibilityStringLabel;
		[Field ("kIBGAddAttachmentAccessibilityStringLabel", "__Internal")]
		NSString kIBGAddAttachmentAccessibilityStringLabel { get; }

		// extern NSString *const kIBGAddAttachmentAccessibilityStringHint;
		[Field ("kIBGAddAttachmentAccessibilityStringHint", "__Internal")]
		NSString kIBGAddAttachmentAccessibilityStringHint { get; }

		// extern NSString *const kIBGExpandAttachmentAccessibilityStringLabel;
		[Field ("kIBGExpandAttachmentAccessibilityStringLabel", "__Internal")]
		NSString kIBGExpandAttachmentAccessibilityStringLabel { get; }

		// extern NSString *const kIBGCollapseAttachmentAccessibilityStringLabel;
		[Field ("kIBGCollapseAttachmentAccessibilityStringLabel", "__Internal")]
		NSString kIBGCollapseAttachmentAccessibilityStringLabel { get; }

		// extern NSString *const kIBGAudioRecordingPermissionDeniedTitleStringName;
		[Field ("kIBGAudioRecordingPermissionDeniedTitleStringName", "__Internal")]
		NSString kIBGAudioRecordingPermissionDeniedTitleStringName { get; }

		// extern NSString *const kIBGAudioRecordingPermissionDeniedMessageStringName;
		[Field ("kIBGAudioRecordingPermissionDeniedMessageStringName", "__Internal")]
		NSString kIBGAudioRecordingPermissionDeniedMessageStringName { get; }

		// extern NSString *const kIBGScreenRecordingPermissionDeniedMessageStringName;
		[Field ("kIBGScreenRecordingPermissionDeniedMessageStringName", "__Internal")]
		NSString kIBGScreenRecordingPermissionDeniedMessageStringName { get; }

		// extern NSString *const kIBGMicrophonePermissionAlertSettingsButtonTitleStringName;
		[Field ("kIBGMicrophonePermissionAlertSettingsButtonTitleStringName", "__Internal")]
		NSString kIBGMicrophonePermissionAlertSettingsButtonTitleStringName { get; }

		// extern NSString *const kIBGMicrophonePermissionAlertLaterButtonTitleStringName;
		[Field ("kIBGMicrophonePermissionAlertLaterButtonTitleStringName", "__Internal")]
		NSString kIBGMicrophonePermissionAlertLaterButtonTitleStringName { get; }

		// extern NSString *const kIBGChatsTitleStringName;
		[Field ("kIBGChatsTitleStringName", "__Internal")]
		NSString kIBGChatsTitleStringName { get; }

		// extern NSString *const kIBGTeamStringName;
		[Field ("kIBGTeamStringName", "__Internal")]
		NSString kIBGTeamStringName { get; }

		// extern NSString *const kIBGRecordingMessageToHoldTextStringName;
		[Field ("kIBGRecordingMessageToHoldTextStringName", "__Internal")]
		NSString kIBGRecordingMessageToHoldTextStringName { get; }

		// extern NSString *const kIBGRecordingMessageToReleaseTextStringName;
		[Field ("kIBGRecordingMessageToReleaseTextStringName", "__Internal")]
		NSString kIBGRecordingMessageToReleaseTextStringName { get; }

		// extern NSString *const kIBGMessagesNotificationTitleSingleMessageStringName;
		[Field ("kIBGMessagesNotificationTitleSingleMessageStringName", "__Internal")]
		NSString kIBGMessagesNotificationTitleSingleMessageStringName { get; }

		// extern NSString *const kIBGMessagesNotificationTitleMultipleMessagesStringName;
		[Field ("kIBGMessagesNotificationTitleMultipleMessagesStringName", "__Internal")]
		NSString kIBGMessagesNotificationTitleMultipleMessagesStringName { get; }

		// extern NSString *const kIBGScreenshotTitleStringName;
		[Field ("kIBGScreenshotTitleStringName", "__Internal")]
		NSString kIBGScreenshotTitleStringName { get; }

		// extern NSString *const kIBGOkButtonTitleStringName;
		[Field ("kIBGOkButtonTitleStringName", "__Internal")]
		NSString kIBGOkButtonTitleStringName { get; }

		// extern NSString *const kIBGSendButtonTitleStringName;
		[Field ("kIBGSendButtonTitleStringName", "__Internal")]
		NSString kIBGSendButtonTitleStringName { get; }

		// extern NSString *const kIBGCancelButtonTitleStringName;
		[Field ("kIBGCancelButtonTitleStringName", "__Internal")]
		NSString kIBGCancelButtonTitleStringName { get; }

		// extern NSString *const kIBGThankYouAlertTitleStringName;
		[Field ("kIBGThankYouAlertTitleStringName", "__Internal")]
		NSString kIBGThankYouAlertTitleStringName { get; }

		// extern NSString *const kIBGThankYouAccessibilityConfirmationTitleStringName;
		[Field ("kIBGThankYouAccessibilityConfirmationTitleStringName", "__Internal")]
		NSString kIBGThankYouAccessibilityConfirmationTitleStringName { get; }

		// extern NSString *const kIBGThankYouAlertMessageStringName;
		[Field ("kIBGThankYouAlertMessageStringName", "__Internal")]
		NSString kIBGThankYouAlertMessageStringName { get; }

		// extern NSString *const kIBGAudioStringName;
		[Field ("kIBGAudioStringName", "__Internal")]
		NSString kIBGAudioStringName { get; }

		// extern NSString *const kIBGScreenRecordingStringName;
		[Field ("kIBGScreenRecordingStringName", "__Internal")]
		NSString kIBGScreenRecordingStringName { get; }

		// extern NSString *const kIBGImageStringName;
		[Field ("kIBGImageStringName", "__Internal")]
		NSString kIBGImageStringName { get; }

		// extern NSString *const kIBGReachedMaximimNumberOfAttachmentsTitleStringName;
		[Field ("kIBGReachedMaximimNumberOfAttachmentsTitleStringName", "__Internal")]
		NSString kIBGReachedMaximimNumberOfAttachmentsTitleStringName { get; }

		// extern NSString *const kIBGReachedMaximimNumberOfAttachmentsMessageStringName;
		[Field ("kIBGReachedMaximimNumberOfAttachmentsMessageStringName", "__Internal")]
		NSString kIBGReachedMaximimNumberOfAttachmentsMessageStringName { get; }

		// extern NSString *const kIBGVideoRecordingFailureMessageStringName;
		[Field ("kIBGVideoRecordingFailureMessageStringName", "__Internal")]
		NSString kIBGVideoRecordingFailureMessageStringName { get; }

		// extern NSString *const kIBGSurveyEnterYourAnswerTextPlaceholder;
		[Field ("kIBGSurveyEnterYourAnswerTextPlaceholder", "__Internal")]
		NSString kIBGSurveyEnterYourAnswerTextPlaceholder { get; }

		// extern NSString *const kIBGSurveyNoAnswerTitle;
		[Field ("kIBGSurveyNoAnswerTitle", "__Internal")]
		NSString kIBGSurveyNoAnswerTitle { get; }

		// extern NSString *const kIBGSurveyNoAnswerMessage;
		[Field ("kIBGSurveyNoAnswerMessage", "__Internal")]
		NSString kIBGSurveyNoAnswerMessage { get; }

		// extern NSString *const kIBGVideoPressRecordTitle;
		[Field ("kIBGVideoPressRecordTitle", "__Internal")]
		NSString kIBGVideoPressRecordTitle { get; }

		// extern NSString *const kIBGCollectingDataText;
		[Field ("kIBGCollectingDataText", "__Internal")]
		NSString kIBGCollectingDataText { get; }

		// extern NSString *const kIBGLowDiskStorageTitle;
		[Field ("kIBGLowDiskStorageTitle", "__Internal")]
		NSString kIBGLowDiskStorageTitle { get; }

		// extern NSString *const kIBGLowDiskStorageMessage;
		[Field ("kIBGLowDiskStorageMessage", "__Internal")]
		NSString kIBGLowDiskStorageMessage { get; }

		// extern NSString *const kIBGInboundByLineMessage;
		[Field ("kIBGInboundByLineMessage", "__Internal")]
		NSString kIBGInboundByLineMessage { get; }

		// extern NSString *const kIBGExtraFieldIsRequiredText;
		[Field ("kIBGExtraFieldIsRequiredText", "__Internal")]
		NSString kIBGExtraFieldIsRequiredText { get; }

		// extern NSString *const kIBGExtraFieldMissingDataText;
		[Field ("kIBGExtraFieldMissingDataText", "__Internal")]
		NSString kIBGExtraFieldMissingDataText { get; }

		// extern NSString *const kIBGFeatureRequestsTitle;
		[Field ("kIBGFeatureRequestsTitle", "__Internal")]
		NSString kIBGFeatureRequestsTitle { get; }

		// extern NSString *const kIBGFeatureDetailsTitle;
		[Field ("kIBGFeatureDetailsTitle", "__Internal")]
		NSString kIBGFeatureDetailsTitle { get; }

		// extern NSString *const kIBGStringFeatureRequestsRefreshText;
		[Field ("kIBGStringFeatureRequestsRefreshText", "__Internal")]
		NSString kIBGStringFeatureRequestsRefreshText { get; }

		// extern NSString *const kIBGFeatureRequestErrorStateTitleLabel;
		[Field ("kIBGFeatureRequestErrorStateTitleLabel", "__Internal")]
		NSString kIBGFeatureRequestErrorStateTitleLabel { get; }

		// extern NSString *const kIBGFeatureRequestErrorStateDescriptionLabel;
		[Field ("kIBGFeatureRequestErrorStateDescriptionLabel", "__Internal")]
		NSString kIBGFeatureRequestErrorStateDescriptionLabel { get; }

		// extern NSString *const kIBGFeatureRequestSortingByRecentlyUpdatedText;
		[Field ("kIBGFeatureRequestSortingByRecentlyUpdatedText", "__Internal")]
		NSString kIBGFeatureRequestSortingByRecentlyUpdatedText { get; }

		// extern NSString *const kIBGFeatureRequestSortingByTopVotesText;
		[Field ("kIBGFeatureRequestSortingByTopVotesText", "__Internal")]
		NSString kIBGFeatureRequestSortingByTopVotesText { get; }

		// extern NSString *const kIBGStringFeatureRequestAllFeaturesText;
		[Field ("kIBGStringFeatureRequestAllFeaturesText", "__Internal")]
		NSString kIBGStringFeatureRequestAllFeaturesText { get; }

		// extern NSString *const kIBGAddNewFeatureRequestText;
		[Field ("kIBGAddNewFeatureRequestText", "__Internal")]
		NSString kIBGAddNewFeatureRequestText { get; }

		// extern NSString *const kIBGAddNewFeatureRequestToastText;
		[Field ("kIBGAddNewFeatureRequestToastText", "__Internal")]
		NSString kIBGAddNewFeatureRequestToastText { get; }

		// extern NSString *const kIBGAddNewFeatureRequestErrorToastText;
		[Field ("kIBGAddNewFeatureRequestErrorToastText", "__Internal")]
		NSString kIBGAddNewFeatureRequestErrorToastText { get; }

		// extern NSString *const kIBGAddNewFeatureRequestLoadingHUDTitle;
		[Field ("kIBGAddNewFeatureRequestLoadingHUDTitle", "__Internal")]
		NSString kIBGAddNewFeatureRequestLoadingHUDTitle { get; }

		// extern NSString *const kIBGAddNewFeatureRequestSuccessHUDTitle;
		[Field ("kIBGAddNewFeatureRequestSuccessHUDTitle", "__Internal")]
		NSString kIBGAddNewFeatureRequestSuccessHUDTitle { get; }

		// extern NSString *const kIBGAddNewFeatureRequestSuccessHUDMessage;
		[Field ("kIBGAddNewFeatureRequestSuccessHUDMessage", "__Internal")]
		NSString kIBGAddNewFeatureRequestSuccessHUDMessage { get; }

		// extern NSString *const kIBGAddNewFeatureRequestTryAgainText;
		[Field ("kIBGAddNewFeatureRequestTryAgainText", "__Internal")]
		NSString kIBGAddNewFeatureRequestTryAgainText { get; }

		// extern NSString *const kIBGAddNewFeatureRequestCancelPromptTitle;
		[Field ("kIBGAddNewFeatureRequestCancelPromptTitle", "__Internal")]
		NSString kIBGAddNewFeatureRequestCancelPromptTitle { get; }

		// extern NSString *const kIBGAddNewFeatureRequestCancelPromptYesAction;
		[Field ("kIBGAddNewFeatureRequestCancelPromptYesAction", "__Internal")]
		NSString kIBGAddNewFeatureRequestCancelPromptYesAction { get; }

		// extern NSString *const kIBGFeatureRequestInvalidEmailText;
		[Field ("kIBGFeatureRequestInvalidEmailText", "__Internal")]
		NSString kIBGFeatureRequestInvalidEmailText { get; }

		// extern NSString *const kIBGFeatureRequestTimelineEmptyText;
		[Field ("kIBGFeatureRequestTimelineEmptyText", "__Internal")]
		NSString kIBGFeatureRequestTimelineEmptyText { get; }

		// extern NSString *const kIBGFeatureRequestTimelineErrorDescriptionLabel;
		[Field ("kIBGFeatureRequestTimelineErrorDescriptionLabel", "__Internal")]
		NSString kIBGFeatureRequestTimelineErrorDescriptionLabel { get; }

		// extern NSString *const kIBGFeatureRequestStatusChangeText;
		[Field ("kIBGFeatureRequestStatusChangeText", "__Internal")]
		NSString kIBGFeatureRequestStatusChangeText { get; }

		// extern NSString *const kIBGFeatureRequestAddButtonText;
		[Field ("kIBGFeatureRequestAddButtonText", "__Internal")]
		NSString kIBGFeatureRequestAddButtonText { get; }

		// extern NSString *const kIBGFeatureRequestVoteWithCountText;
		[Field ("kIBGFeatureRequestVoteWithCountText", "__Internal")]
		NSString kIBGFeatureRequestVoteWithCountText { get; }

		// extern NSString *const kIBGFeatureRequestVoteText;
		[Field ("kIBGFeatureRequestVoteText", "__Internal")]
		NSString kIBGFeatureRequestVoteText { get; }

		// extern NSString *const kIBGFeatureRequestPostButtonText;
		[Field ("kIBGFeatureRequestPostButtonText", "__Internal")]
		NSString kIBGFeatureRequestPostButtonText { get; }

		// extern NSString *const kIBGFeatureRequestCommentsText;
		[Field ("kIBGFeatureRequestCommentsText", "__Internal")]
		NSString kIBGFeatureRequestCommentsText { get; }

		// extern NSString *const kIBGFeatureRequestAuthorText;
		[Field ("kIBGFeatureRequestAuthorText", "__Internal")]
		NSString kIBGFeatureRequestAuthorText { get; }

		// extern NSString *const kIBGFeatureRequestEmptyViewTitle;
		[Field ("kIBGFeatureRequestEmptyViewTitle", "__Internal")]
		NSString kIBGFeatureRequestEmptyViewTitle { get; }

		// extern NSString *const kIBGFeatureRequestAddYourIdeaText;
		[Field ("kIBGFeatureRequestAddYourIdeaText", "__Internal")]
		NSString kIBGFeatureRequestAddYourIdeaText { get; }

		// extern NSString *const kIBGFeatureRequestAnonymousText;
		[Field ("kIBGFeatureRequestAnonymousText", "__Internal")]
		NSString kIBGFeatureRequestAnonymousText { get; }

		// extern NSString *const kIBGFeatureRequestStatusPosted;
		[Field ("kIBGFeatureRequestStatusPosted", "__Internal")]
		NSString kIBGFeatureRequestStatusPosted { get; }

		// extern NSString *const kIBGFeatureRequestStatusPlanned;
		[Field ("kIBGFeatureRequestStatusPlanned", "__Internal")]
		NSString kIBGFeatureRequestStatusPlanned { get; }

		// extern NSString *const kIBGFeatureRequestStatusStarted;
		[Field ("kIBGFeatureRequestStatusStarted", "__Internal")]
		NSString kIBGFeatureRequestStatusStarted { get; }

		// extern NSString *const kIBGFeatureRequestStatusCompleted;
		[Field ("kIBGFeatureRequestStatusCompleted", "__Internal")]
		NSString kIBGFeatureRequestStatusCompleted { get; }

		// extern NSString *const kIBGFeatureRequestStatusMaybeLater;
		[Field ("kIBGFeatureRequestStatusMaybeLater", "__Internal")]
		NSString kIBGFeatureRequestStatusMaybeLater { get; }

		// extern NSString *const kIBGFeatureRequestStatusMoreText;
		[Field ("kIBGFeatureRequestStatusMoreText", "__Internal")]
		NSString kIBGFeatureRequestStatusMoreText { get; }

		// extern NSString *const kIBGFeatureRequestStatusLessText;
		[Field ("kIBGFeatureRequestStatusLessText", "__Internal")]
		NSString kIBGFeatureRequestStatusLessText { get; }

		// extern NSString *const kIBGFeatureRequestAddYourThoughtsText;
		[Field ("kIBGFeatureRequestAddYourThoughtsText", "__Internal")]
		NSString kIBGFeatureRequestAddYourThoughtsText { get; }

		// extern NSString *const kIBGEmailRequiredText;
		[Field ("kIBGEmailRequiredText", "__Internal")]
		NSString kIBGEmailRequiredText { get; }

		// extern NSString *const kIBGNameText;
		[Field ("kIBGNameText", "__Internal")]
		NSString kIBGNameText { get; }

		// extern NSString *const kIBGEmailText;
		[Field ("kIBGEmailText", "__Internal")]
		NSString kIBGEmailText { get; }

		// extern NSString *const kIBGTitleText;
		[Field ("kIBGTitleText", "__Internal")]
		NSString kIBGTitleText { get; }

		// extern NSString *const kIBGDescriptionText;
		[Field ("kIBGDescriptionText", "__Internal")]
		NSString kIBGDescriptionText { get; }

		// extern NSString *const kIBGStringFeatureRequestMyFeaturesText;
		[Field ("kIBGStringFeatureRequestMyFeaturesText", "__Internal")]
		NSString kIBGStringFeatureRequestMyFeaturesText { get; }

		// extern NSString *const kIBGSurveyIntroTitleText;
		[Field ("kIBGSurveyIntroTitleText", "__Internal")]
		NSString kIBGSurveyIntroTitleText { get; }

		// extern NSString *const kIBGSurveyIntroDescriptionText;
		[Field ("kIBGSurveyIntroDescriptionText", "__Internal")]
		NSString kIBGSurveyIntroDescriptionText { get; }

		// extern NSString *const kIBGSurveyIntroTakeSurveyButtonText;
		[Field ("kIBGSurveyIntroTakeSurveyButtonText", "__Internal")]
		NSString kIBGSurveyIntroTakeSurveyButtonText { get; }

		// extern NSString *const kIBGDismissButtonTitleStringName;
		[Field ("kIBGDismissButtonTitleStringName", "__Internal")]
		NSString kIBGDismissButtonTitleStringName { get; }

		// extern NSString *const kIBGStoreRatingThankYouTitleText;
		[Field ("kIBGStoreRatingThankYouTitleText", "__Internal")]
		NSString kIBGStoreRatingThankYouTitleText { get; }

		// extern NSString *const kIBGStoreRatingThankYouDescriptionText;
		[Field ("kIBGStoreRatingThankYouDescriptionText", "__Internal")]
		NSString kIBGStoreRatingThankYouDescriptionText { get; }

		// extern NSString *const kIBGSurveysNPSLeastLikelyStringName;
		[Field ("kIBGSurveysNPSLeastLikelyStringName", "__Internal")]
		NSString kIBGSurveysNPSLeastLikelyStringName { get; }

		// extern NSString *const kIBGSurveysNPSMostLikelyStringName;
		[Field ("kIBGSurveysNPSMostLikelyStringName", "__Internal")]
		NSString kIBGSurveysNPSMostLikelyStringName { get; }

		// extern NSString *const kIBGSurveyNextButtonTitle;
		[Field ("kIBGSurveyNextButtonTitle", "__Internal")]
		NSString kIBGSurveyNextButtonTitle { get; }

		// extern NSString *const kIBGSurveySubmitButtonTitle;
		[Field ("kIBGSurveySubmitButtonTitle", "__Internal")]
		NSString kIBGSurveySubmitButtonTitle { get; }

		// extern NSString *const kIBGSurveyAppStoreThankYouTitle;
		[Field ("kIBGSurveyAppStoreThankYouTitle", "__Internal")]
		NSString kIBGSurveyAppStoreThankYouTitle { get; }

		// extern NSString *const kIBGSurveyAppStoreButtonTitle;
		[Field ("kIBGSurveyAppStoreButtonTitle", "__Internal")]
		NSString kIBGSurveyAppStoreButtonTitle { get; }

		// extern NSString *const kIBGExpectedResultsStringName;
		[Field ("kIBGExpectedResultsStringName", "__Internal")]
		NSString kIBGExpectedResultsStringName { get; }

		// extern NSString *const kIBGActualResultsStringName;
		[Field ("kIBGActualResultsStringName", "__Internal")]
		NSString kIBGActualResultsStringName { get; }

		// extern NSString *const kIBGStepsToReproduceStringName;
		[Field ("kIBGStepsToReproduceStringName", "__Internal")]
		NSString kIBGStepsToReproduceStringName { get; }

		// extern NSString *const kIBGReplyButtonTitleStringName;
		[Field ("kIBGReplyButtonTitleStringName", "__Internal")]
		NSString kIBGReplyButtonTitleStringName { get; }

		// extern NSString *const kIBGAddAttachmentButtonTitleStringName;
		[Field ("kIBGAddAttachmentButtonTitleStringName", "__Internal")]
		NSString kIBGAddAttachmentButtonTitleStringName { get; }

		// extern NSString *const kIBGDiscardAlertTitle;
		[Field ("kIBGDiscardAlertTitle", "__Internal")]
		NSString kIBGDiscardAlertTitle { get; }

		// extern NSString *const kIBGDiscardAlertMessage;
		[Field ("kIBGDiscardAlertMessage", "__Internal")]
		NSString kIBGDiscardAlertMessage { get; }

		// extern NSString *const kIBGDiscardAlertAction;
		[Field ("kIBGDiscardAlertAction", "__Internal")]
		NSString kIBGDiscardAlertAction { get; }

		// extern NSString *const kIBGDiscardAlertCancel;
		[Field ("kIBGDiscardAlertCancel", "__Internal")]
		NSString kIBGDiscardAlertCancel { get; }

		// extern NSString *const kIBGVideoGalleryErrorMessageStringName;
		[Field ("kIBGVideoGalleryErrorMessageStringName", "__Internal")]
		NSString kIBGVideoGalleryErrorMessageStringName { get; }

		// extern NSString *const kIBGVideoDurationErrorTitle;
		[Field ("kIBGVideoDurationErrorTitle", "__Internal")]
		NSString kIBGVideoDurationErrorTitle { get; }

		// extern NSString *const kIBGVideoDurationErrorMessage;
		[Field ("kIBGVideoDurationErrorMessage", "__Internal")]
		NSString kIBGVideoDurationErrorMessage { get; }

		// extern NSString *const kIBGAutoScreenRecordingAlertAllowText;
		[Field ("kIBGAutoScreenRecordingAlertAllowText", "__Internal")]
		NSString kIBGAutoScreenRecordingAlertAllowText { get; }

		// extern NSString *const kIBGAutoScreenRecordingAlertAlwaysAllowText;
		[Field ("kIBGAutoScreenRecordingAlertAlwaysAllowText", "__Internal")]
		NSString kIBGAutoScreenRecordingAlertAlwaysAllowText { get; }

		// extern NSString *const kIBGAutoScreenRecordingAlertDenyText;
		[Field ("kIBGAutoScreenRecordingAlertDenyText", "__Internal")]
		NSString kIBGAutoScreenRecordingAlertDenyText { get; }

		// extern NSString *const kIBGAutoScreenRecordingAlertTitleText;
		[Field ("kIBGAutoScreenRecordingAlertTitleText", "__Internal")]
		NSString kIBGAutoScreenRecordingAlertTitleText { get; }

		// extern NSString *const kIBGAutoScreenRecordingAlertBodyText;
		[Field ("kIBGAutoScreenRecordingAlertBodyText", "__Internal")]
		NSString kIBGAutoScreenRecordingAlertBodyText { get; }

		// extern NSString *const kIBGReproStepsDisclaimerBody;
		[Field ("kIBGReproStepsDisclaimerBody", "__Internal")]
		NSString kIBGReproStepsDisclaimerBody { get; }

		// extern NSString *const kIBGReproStepsDisclaimerLink;
		[Field ("kIBGReproStepsDisclaimerLink", "__Internal")]
		NSString kIBGReproStepsDisclaimerLink { get; }

		// extern NSString *const kIBGReproStepsListHeader;
		[Field ("kIBGReproStepsListHeader", "__Internal")]
		NSString kIBGReproStepsListHeader { get; }

		// extern NSString *const kIBGReproStepsListEmptyStateLabel;
		[Field ("kIBGReproStepsListEmptyStateLabel", "__Internal")]
		NSString kIBGReproStepsListEmptyStateLabel { get; }

		// extern NSString *const kIBGReproStepsListTitle;
		[Field ("kIBGReproStepsListTitle", "__Internal")]
		NSString kIBGReproStepsListTitle { get; }

		// extern NSString *const kIBGReproStepsListItemName;
		[Field ("kIBGReproStepsListItemName", "__Internal")]
		NSString kIBGReproStepsListItemName { get; }

		// extern NSString *const kIBGInsufficientContentTitleStringName;
		[Field ("kIBGInsufficientContentTitleStringName", "__Internal")]
		NSString kIBGInsufficientContentTitleStringName { get; }

		// extern NSString *const kIBGInsufficientContentMessageStringName;
		[Field ("kIBGInsufficientContentMessageStringName", "__Internal")]
		NSString kIBGInsufficientContentMessageStringName { get; }
	}

	// typedef void (^NetworkObfuscationCompletionBlock)(NSData *, NSURLResponse *);
	delegate void NetworkObfuscationCompletionBlock (NSData arg0, NSUrlResponse arg1);

	// @interface IBGNetworkTrace : NSObject
	/*[BaseType (typeof(NSObject))]
	interface IBGNetworkTrace
	{
	 	// @property (nonatomic, strong) NSURLRequest * _Nonnull request;
		[Export ("request", ArgumentSemantic.Strong)]
		NSUrlRequest Request { get; set; }

	 	// @property (nonatomic, strong) NSURLResponse * _Nullable response;
		[NullAllowed, Export ("response", ArgumentSemantic.Strong)]
		NSUrlResponse Response { get; set; }

	 	// @property (nonatomic, strong) NSData * _Nullable responseData;
		[NullAllowed, Export ("responseData", ArgumentSemantic.Strong)]
		NSData ResponseData { get; set; }

	 	// @property (assign, nonatomic) NSUInteger responseDataSize;
		[Export ("responseDataSize")]
		nuint ResponseDataSize { get; set; }
	}
	*/
	// @interface IBGAPM : NSObject
	[BaseType (typeof(NSObject))]
	interface IBGAPM
	{
		// @property (assign, atomic, class) BOOL enabled;
		[Static]
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (assign, atomic, class) BOOL appLaunchEnabled __attribute__((deprecated("Please use coldAppLaunchEnabled instead.")));
		[Static]
		[Export ("appLaunchEnabled")]
		bool AppLaunchEnabled { get; set; }

		// @property (assign, atomic, class) BOOL coldAppLaunchEnabled;
		[Static]
		[Export ("coldAppLaunchEnabled")]
		bool ColdAppLaunchEnabled { get; set; }

		// @property (assign, atomic, class) BOOL hotAppLaunchEnabled;
		[Static]
		[Export ("hotAppLaunchEnabled")]
		bool HotAppLaunchEnabled { get; set; }

		// @property (assign, atomic, class) BOOL autoUITraceEnabled;
		[Static]
		[Export ("autoUITraceEnabled")]
		bool AutoUITraceEnabled { get; set; }

		// @property (assign, atomic, class) BOOL UIHangsEnabled;
		[Static]
		[Export ("UIHangsEnabled")]
		bool UIHangsEnabled { get; set; }

		// @property (assign, atomic, class) BOOL screenLoadingEnabled;
		[Static]
		[Export ("screenLoadingEnabled")]
		bool ScreenLoadingEnabled { get; set; }

		// +(IBGExecutionTrace * _Nullable)startExecutionTraceWithName:(NSString * _Nonnull)name;
		[Static]
		[Export ("startExecutionTraceWithName:")]
		[return: NullAllowed]
		IBGExecutionTrace StartExecutionTraceWithName (string name);

		// +(void)startUITraceWithName:(NSString * _Nonnull)name;
		[Static]
		[Export ("startUITraceWithName:")]
		void StartUITraceWithName (string name);

		// +(void)endUITrace;
		[Static]
		[Export ("endUITrace")]
		void EndUITrace ();

		// +(void)endScreenLoadingForViewController:(UIViewController * _Nullable)viewController;
		[Static]
		[Export ("endScreenLoadingForViewController:")]
		void EndScreenLoadingForViewController ([NullAllowed] UIViewController viewController);

		// +(void)endAppLaunch;
		[Static]
		[Export ("endAppLaunch")]
		void EndAppLaunch ();

		// @property (assign, atomic, class) IBGLogLevel logLevel __attribute__((deprecated("first deprecated in SDK 11.0.0. Use Instabug.sdkDebugLogsLevel instead")));
		[Static]
		[Export ("logLevel", ArgumentSemantic.Assign)]
		IBGLogLevel LogLevel { get; set; }

		// +(NSString * _Nullable)addNetworkTraceAttributesForURLMatchingPredicate:(NSPredicate * _Nullable)urlPredicate owner:(NSObject * _Nullable)owner usingHandler:(NSDictionary<NSString *,NSString *> * _Nullable (^ _Nonnull)(IBGNetworkTrace * _Nonnull))handler;
		// [Static]
		// [Export ("addNetworkTraceAttributesForURLMatchingPredicate:owner:usingHandler:")]
		// [return: NullAllowed]
		// string AddNetworkTraceAttributesForURLMatchingPredicate ([NullAllowed] NSPredicate urlPredicate, [NullAllowed] NSObject owner, Func<IBGNetworkTrace, NSDictionary<NSString, NSString>> handler);

		// +(void)removeNetworkTraceAttributesHandlerWithID:(NSString * _Nonnull)handlerID;
		[Static]
		[Export ("removeNetworkTraceAttributesHandlerWithID:")]
		void RemoveNetworkTraceAttributesHandlerWithID (string handlerID);
	}

	// @interface IBGBugReporting : NSObject
	[BaseType (typeof(NSObject))]
	interface IBGBugReporting
	{
		// @property (assign, atomic, class) BOOL enabled;
		[Static]
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (readonly, atomic, class) BOOL usageExceeded;
		[Static]
		[Export ("usageExceeded")]
		bool UsageExceeded { get; }

		// @property (atomic, strong, class) void (^willInvokeHandler)();
		[Static]
		[Export ("willInvokeHandler", ArgumentSemantic.Strong)]
		Action WillInvokeHandler { get; set; }

		// @property (atomic, strong, class) void (^didDismissHandler)(IBGDismissType, IBGReportType);
		[Static]
		[Export ("didDismissHandler", ArgumentSemantic.Strong)]
		Action<IBGDismissType, IBGReportType> DidDismissHandler { get; set; }

		// @property (atomic, strong, class) void (^didSelectPromptOptionHandler)(IBGPromptOption);
		[Static]
		[Export ("didSelectPromptOptionHandler", ArgumentSemantic.Strong)]
		Action<IBGPromptOption> DidSelectPromptOptionHandler { get; set; }

		// @property (assign, atomic, class) IBGInvocationEvent invocationEvents;
		[Static]
		[Export ("invocationEvents", ArgumentSemantic.Assign)]
		IBGInvocationEvent InvocationEvents { get; set; }

		// @property (assign, atomic, class) CGFloat shakingThresholdForiPhone;
		[Static]
		[Export ("shakingThresholdForiPhone")]
		nfloat ShakingThresholdForiPhone { get; set; }

		// @property (assign, atomic, class) CGFloat shakingThresholdForiPad;
		[Static]
		[Export ("shakingThresholdForiPad")]
		nfloat ShakingThresholdForiPad { get; set; }

		// @property (assign, atomic, class) CGRectEdge floatingButtonEdge;
		[Static]
		[Export ("floatingButtonEdge", ArgumentSemantic.Assign)]
		CGRectEdge FloatingButtonEdge { get; set; }

		// @property (assign, atomic, class) CGFloat floatingButtonTopOffset;
		[Static]
		[Export ("floatingButtonTopOffset")]
		nfloat FloatingButtonTopOffset { get; set; }

		// @property (assign, atomic, class) IBGAttachmentType enabledAttachmentTypes;
		[Static]
		[Export ("enabledAttachmentTypes", ArgumentSemantic.Assign)]
		IBGAttachmentType EnabledAttachmentTypes { get; set; }

		// @property (assign, atomic, class) IBGBugReportingReportType promptOptionsEnabledReportTypes;
		[Static]
		[Export ("promptOptionsEnabledReportTypes", ArgumentSemantic.Assign)]
		IBGBugReportingReportType PromptOptionsEnabledReportTypes { get; set; }

		// @property (assign, atomic, class) IBGExtendedBugReportMode extendedBugReportMode;
		[Static]
		[Export ("extendedBugReportMode", ArgumentSemantic.Assign)]
		IBGExtendedBugReportMode ExtendedBugReportMode { get; set; }

		// @property (assign, atomic, class) IBGBugReportingOption bugReportingOptions;
		[Static]
		[Export ("bugReportingOptions", ArgumentSemantic.Assign)]
		IBGBugReportingOption BugReportingOptions { get; set; }

		// @property (assign, atomic, class) IBGPosition videoRecordingFloatingButtonPosition;
		[Static]
		[Export ("videoRecordingFloatingButtonPosition", ArgumentSemantic.Assign)]
		IBGPosition VideoRecordingFloatingButtonPosition { get; set; }

		// +(void)showWithReportType:(IBGBugReportingReportType)reportType options:(IBGBugReportingOption)options;
		[Static]
		[Export ("showWithReportType:options:")]
		void ShowWithReportType (IBGBugReportingReportType reportType, IBGBugReportingOption options);

		// +(void)dismiss;
		[Static]
		[Export ("dismiss")]
		void Dismiss ();

		// @property (assign, atomic, class) BOOL shouldCaptureViewHierarchy;
		[Static]
		[Export ("shouldCaptureViewHierarchy")]
		bool ShouldCaptureViewHierarchy { get; set; }

		// @property (assign, atomic, class) BOOL autoScreenRecordingEnabled;
		[Static]
		[Export ("autoScreenRecordingEnabled")]
		bool AutoScreenRecordingEnabled { get; set; }

		// @property (assign, atomic, class) CGFloat autoScreenRecordingDuration;
		[Static]
		[Export ("autoScreenRecordingDuration")]
		nfloat AutoScreenRecordingDuration { get; set; }

		// +(void)setDisclaimerText:(NSString *)text;
		[Static]
		[Export ("setDisclaimerText:")]
		void SetDisclaimerText (string text);

		// +(void)setCommentMinimumCharacterCountForReportTypes:(IBGBugReportingReportType)reportTypes withLimit:(NSInteger)limit;
		[Static]
		[Export ("setCommentMinimumCharacterCountForReportTypes:withLimit:")]
		void SetCommentMinimumCharacterCountForReportTypes (IBGBugReportingReportType reportTypes, nint limit);
	}

	// @protocol IBGNonFatalBuilder <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
// [Protocol]
	[BaseType (typeof(NSObject))]
	[Model]
	interface IBGNonFatalBuilder
	{
		// @required -(void)report;
		[Abstract]
		[Export ("report")]
		void Report ();
	}

	// @interface IBGNonFatalError : NSObject <IBGNonFatalBuilder>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface IBGNonFatalError : IBGNonFatalBuilder
	{
		// @property (atomic, strong) NSError * _Nonnull error;
		[Export ("error", ArgumentSemantic.Strong)]
		NSError Error { get; set; }

		// @property (atomic, strong) NSString * _Nonnull groupingString;
		[Export ("groupingString", ArgumentSemantic.Strong)]
		string GroupingString { get; set; }

		// @property (atomic, strong) NSDictionary<NSString *,NSString *> * _Nonnull userAttributes;
		[Export ("userAttributes", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> UserAttributes { get; set; }

		// @property (assign, atomic) IBGNonFatalLevel level;
		[Export ("level", ArgumentSemantic.Assign)]
		IBGNonFatalLevel Level { get; set; }
	}

	// @interface IBGNonFatalException : NSObject <IBGNonFatalBuilder>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface IBGNonFatalException : IBGNonFatalBuilder
	{
		// @property (atomic, strong) NSException * _Nonnull exception;
		[Export ("exception", ArgumentSemantic.Strong)]
		NSException Exception { get; set; }

		// @property (atomic, strong) NSString * _Nonnull groupingString;
		[Export ("groupingString", ArgumentSemantic.Strong)]
		string GroupingString { get; set; }

		// @property (atomic, strong) NSDictionary<NSString *,NSString *> * _Nonnull userAttributes;
		[Export ("userAttributes", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSString> UserAttributes { get; set; }

		// @property (assign, atomic) IBGNonFatalLevel level;
		[Export ("level", ArgumentSemantic.Assign)]
		IBGNonFatalLevel Level { get; set; }
	}

	// @interface IBGCrashReporting : NSObject
	[BaseType (typeof(NSObject))]
	interface IBGCrashReporting
	{
		// @property (assign, atomic, class) BOOL enabled;
		[Static]
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (assign, atomic, class) BOOL OOMEnabled;
		[Static]
		[Export ("OOMEnabled")]
		bool OOMEnabled { get; set; }

		// @property (assign, atomic, class) BOOL unhandledEnabled;
		[Static]
		[Export ("unhandledEnabled")]
		bool UnhandledEnabled { get; set; }

		// +(void)reportException:(NSException *)exception __attribute__((deprecated("Create and use NonFatalException object instead")));
		[Static]
		[Export ("reportException:")]
		void ReportException (NSException exception);

		// +(void)reportError:(NSError *)error __attribute__((deprecated("Create and use NonFatalError object instead")));
		[Static]
		[Export ("reportError:")]
		void ReportError (NSError error);

		// +(void)reportException:(NSException *)exception withUserAttributes:(NSDictionary<NSString *,NSString *> *)userAttributes __attribute__((deprecated("Create and use NonFatalException object instead")));
		[Static]
		[Export ("reportException:withUserAttributes:")]
		void ReportException (NSException exception, NSDictionary<NSString, NSString> userAttributes);

		// +(void)reportError:(NSError *)error withUserAttributes:(NSDictionary<NSString *,NSString *> *)userAttributes __attribute__((deprecated("Create and use NonFatalError object instead")));
		[Static]
		[Export ("reportError:withUserAttributes:")]
		void ReportError (NSError error, NSDictionary<NSString, NSString> userAttributes);

		// +(void)reportException:(NSException *)exception withGroupingString:(NSString *)groupingString __attribute__((deprecated("Create and use NonFatalException object instead")));
		[Static]
		[Export ("reportException:withGroupingString:")]
		void ReportException (NSException exception, string groupingString);

		// +(void)reportError:(NSError *)error withGroupingString:(NSString *)groupingString __attribute__((deprecated("Create and use NonFatalError object instead")));
		[Static]
		[Export ("reportError:withGroupingString:")]
		void ReportError (NSError error, string groupingString);

		// +(IBGNonFatalException *)exception:(NSException *)exception;
		[Static]
		[Export ("exception:")]
		IBGNonFatalException Exception (NSException exception);

		// +(IBGNonFatalError *)error:(NSError *)error;
		[Static]
		[Export ("error:")]
		IBGNonFatalError Error (NSError error);
	}

	// @interface IBGExecutionTrace : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface IBGExecutionTrace
	{
		// -(void)end;
		[Export ("end")]
		void End ();

		// -(void)setAttributeWithKey:(NSString * _Nonnull)key value:(NSString * _Nullable)value;
		[Export ("setAttributeWithKey:value:")]
		void SetAttributeWithKey (string key, [NullAllowed] string value);
	}

	// @interface IBGFeatureRequests : NSObject
	[BaseType (typeof(NSObject))]
	interface IBGFeatureRequests
	{
		// @property (assign, atomic, class) BOOL enabled;
		[Static]
		[Export ("enabled")]
		bool Enabled { get; set; }

		// +(void)setEmailFieldRequired:(BOOL)isEmailFieldRequired forAction:(IBGAction)actionType;
		[Static]
		[Export ("setEmailFieldRequired:forAction:")]
		void SetEmailFieldRequired (bool isEmailFieldRequired, IBGAction actionType);

		// +(void)show;
		[Static]
		[Export ("show")]
		void Show ();
	}

	// @interface IBGLog : NSObject
	[BaseType (typeof(NSObject))]
	interface IBGLog
	{
		// @property (assign, atomic, class) BOOL printsToConsole;
		[Static]
		[Export ("printsToConsole")]
		bool PrintsToConsole { get; set; }

		// +(void)log:(NSString *)log;
		[Static]
		[Export ("log:")]
		void Log (string log);

		// +(void)logVerbose:(NSString *)log;
		[Static]
		[Export ("logVerbose:")]
		void LogVerbose (string log);

		// +(void)logDebug:(NSString *)log;
		[Static]
		[Export ("logDebug:")]
		void LogDebug (string log);

		// +(void)logInfo:(NSString *)log;
		[Static]
		[Export ("logInfo:")]
		void LogInfo (string log);

		// +(void)logWarn:(NSString *)log;
		[Static]
		[Export ("logWarn:")]
		void LogWarn (string log);

		// +(void)logError:(NSString *)log;
		[Static]
		[Export ("logError:")]
		void LogError (string log);

		// +(void)clearAllLogs;
		[Static]
		[Export ("clearAllLogs")]
		void ClearAllLogs ();
	}

	// @interface IBGNetworkLogger : NSObject
	[BaseType (typeof(NSObject))]
	interface IBGNetworkLogger
	{
		// @property (assign, atomic, class) BOOL enabled;
		[Static]
		[Export ("enabled")]
		bool Enabled { get; set; }

		// +(void)enableLoggingForURLSessionConfiguration:(NSURLSessionConfiguration * _Nonnull)URLSessionConfiguration;
		[Static]
		[Export ("enableLoggingForURLSessionConfiguration:")]
		void EnableLoggingForURLSessionConfiguration (NSUrlSessionConfiguration URLSessionConfiguration);

		// +(void)setRequestObfuscationHandler:(NSURLRequest * _Nonnull (^ _Nonnull)(NSURLRequest * _Nonnull))obfuscationHandler;
		[Static]
		[Export ("setRequestObfuscationHandler:")]
		void SetRequestObfuscationHandler (Func<NSUrlRequest, NSUrlRequest> obfuscationHandler);

		// +(void)setResponseObfuscationHandler:(void (^ _Nonnull)(NSData * _Nullable, NSURLResponse * _Nonnull, NetworkObfuscationCompletionBlock _Nonnull))obfuscationHandler;
		[Static]
		[Export ("setResponseObfuscationHandler:")]
		void SetResponseObfuscationHandler (Action<NSData, NSUrlResponse, NetworkObfuscationCompletionBlock> obfuscationHandler);

		// +(void)setProgressHandlerForRequestURL:(NSURL * _Nonnull)URL progressHandler:(void (^ _Nonnull)(NSURLSessionTask * _Nonnull, int64_t, int64_t, int64_t))requestProgressHandler;
		[Static]
		[Export ("setProgressHandlerForRequestURL:progressHandler:")]
		void SetProgressHandlerForRequestURL (NSUrl URL, Action<NSUrlSessionTask, long, long, long> requestProgressHandler);

		// +(void)setCanAuthenticateAgainstProtectionSpaceHandler:(BOOL (^ _Nonnull)(NSURLProtectionSpace * _Nonnull))protectionSpaceHandler __attribute__((deprecated("'setCanAuthenticateAgainstProtectionSpaceHandler:' is deprecated: first deprecated in SDK 10.5.0 - Remove setCanAuthenticateAgainstProtectionSpaceHandler: to use your implementation of -[NSURLSessionTaskDelegate URLSession:task:didReceiveChallenge:completionHandler:].")));
		[Static]
		[Export ("setCanAuthenticateAgainstProtectionSpaceHandler:")]
		void SetCanAuthenticateAgainstProtectionSpaceHandler (Func<NSUrlProtectionSpace, bool> protectionSpaceHandler);

		// +(void)setDidReceiveAuthenticationChallengeHandler:(NSURLCredential * _Nullable (^ _Nonnull)(NSURLAuthenticationChallenge * _Nonnull))reciveChallengeHandler __attribute__((deprecated("'setDidReceiveAuthenticationChallengeHandler:' is deprecated: first deprecated in SDK 10.5.0 - Remove setDidReceiveAuthenticationChallengeHandler: to use your implementation of -[NSURLSessionTaskDelegate URLSession:task:didReceiveChallenge:completionHandler:].")));
		[Static]
		[Export ("setDidReceiveAuthenticationChallengeHandler:")]
		void SetDidReceiveAuthenticationChallengeHandler (Func<NSUrlAuthenticationChallenge, NSUrlCredential> reciveChallengeHandler);

		// +(void)setNetworkLoggingRequestFilterPredicate:(NSPredicate * _Nullable)requestFilterPredicate responseFilterPredicate:(NSPredicate * _Nullable)responseFilterPredicate;
		[Static]
		[Export ("setNetworkLoggingRequestFilterPredicate:responseFilterPredicate:")]
		void SetNetworkLoggingRequestFilterPredicate ([NullAllowed] NSPredicate requestFilterPredicate, [NullAllowed] NSPredicate responseFilterPredicate);

		// +(void)setTaskWillPerformHTTPRedirectionBlock:(NSURLRequest * _Nullable (^ _Nullable)(NSURLSession * _Nonnull, NSURLSessionTask * _Nonnull, NSURLResponse * _Nonnull, NSURLRequest * _Nonnull))redirectionHandler;
		[Static]
		[Export ("setTaskWillPerformHTTPRedirectionBlock:")]
		void SetTaskWillPerformHTTPRedirectionBlock ([NullAllowed] Func<NSUrlSession, NSUrlSessionTask, NSUrlResponse, NSUrlRequest, NSUrlRequest> redirectionHandler);

		// +(void)addGrpcNetworkLogWithUrl:(NSString * _Nullable)url requestBody:(NSString * _Nullable)requestBody requestBodySize:(int64_t)requestBodySize responseBody:(NSString * _Nullable)response responseBodySize:(int64_t)responseBodySize responseCode:(int32_t)responseCode requestHeaders:(NSDictionary * _Nullable)requestHeaders responseHeaders:(NSDictionary * _Nullable)responseHeaders contentType:(NSString * _Nullable)contentType startTime:(int64_t)startTime errorDomain:(NSString * _Nullable)errorDomain errorCode:(int32_t)errorCode duration:(int64_t)duration gRPCMethod:(NSString * _Nullable)gRPCMethod serverErrorMessage:(NSString * _Nullable)serverErrorMessage;
		[Static]
		[Export ("addGrpcNetworkLogWithUrl:requestBody:requestBodySize:responseBody:responseBodySize:responseCode:requestHeaders:responseHeaders:contentType:startTime:errorDomain:errorCode:duration:gRPCMethod:serverErrorMessage:")]
		void AddGrpcNetworkLogWithUrl ([NullAllowed] string url, [NullAllowed] string requestBody, long requestBodySize, [NullAllowed] string response, long responseBodySize, int responseCode, [NullAllowed] NSDictionary requestHeaders, [NullAllowed] NSDictionary responseHeaders, [NullAllowed] string contentType, long startTime, [NullAllowed] string errorDomain, int errorCode, long duration, [NullAllowed] string gRPCMethod, [NullAllowed] string serverErrorMessage);
	}

	// @interface IBGReplies : NSObject
	[BaseType (typeof(NSObject))]
	interface IBGReplies
	{
		// @property (assign, atomic, class) BOOL enabled;
		[Static]
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (atomic, strong, class) void (^didReceiveReplyHandler)();
		[Static]
		[Export ("didReceiveReplyHandler", ArgumentSemantic.Strong)]
		Action DidReceiveReplyHandler { get; set; }

		// @property (assign, atomic, class) BOOL inAppNotificationsEnabled;
		[Static]
		[Export ("inAppNotificationsEnabled")]
		bool InAppNotificationsEnabled { get; set; }

		// @property (assign, atomic, class) BOOL pushNotificationsEnabled;
		[Static]
		[Export ("pushNotificationsEnabled")]
		bool PushNotificationsEnabled { get; set; }

		// @property (readonly, assign, atomic, class) NSInteger unreadRepliesCount;
		[Static]
		[Export ("unreadRepliesCount")]
		nint UnreadRepliesCount { get; }

		// +(void)show;
		[Static]
		[Export ("show")]
		void Show ();

		// +(BOOL)hasChats;
		[Static]
		[Export ("hasChats")]
		// [Verify (MethodToProperty)]
		bool HasChats { get; }

		// +(BOOL)didReceiveRemoteNotification:(NSDictionary *)userInfo;
		[Static]
		[Export ("didReceiveRemoteNotification:")]
		bool DidReceiveRemoteNotification (NSDictionary userInfo);

		// +(void)didRegisterForRemoteNotificationsWithDeviceToken:(NSData *)deviceToken;
		[Static]
		[Export ("didRegisterForRemoteNotificationsWithDeviceToken:")]
		void DidRegisterForRemoteNotificationsWithDeviceToken (NSData deviceToken);
	}

	// @interface IBGReport : NSObject
	[BaseType (typeof(NSObject))]
	interface IBGReport
	{
		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull tags;
		[Export ("tags", ArgumentSemantic.Copy)]
		string[] Tags { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSDictionary *> * _Nonnull instabugLogs;
		[Export ("instabugLogs", ArgumentSemantic.Copy)]
		NSDictionary[] InstabugLogs { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSDictionary *> * _Nonnull consoleLogs;
		[Export ("consoleLogs", ArgumentSemantic.Copy)]
		NSDictionary[] ConsoleLogs { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull userAttributes;
		[Export ("userAttributes", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> UserAttributes { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull fileLocations;
		[Export ("fileLocations", ArgumentSemantic.Copy)]
		string[] FileLocations { get; }

		// @property (copy, nonatomic) NSString * _Nonnull userData;
		[Export ("userData")]
		string UserData { get; set; }

		// -(void)appendTag:(NSString * _Nonnull)tag;
		[Export ("appendTag:")]
		void AppendTag (string tag);

		// -(void)logVerbose:(NSString * _Nonnull)log;
		[Export ("logVerbose:")]
		void LogVerbose (string log);

		// -(void)logDebug:(NSString * _Nonnull)log;
		[Export ("logDebug:")]
		void LogDebug (string log);

		// -(void)logInfo:(NSString * _Nonnull)log;
		[Export ("logInfo:")]
		void LogInfo (string log);

		// -(void)logWarn:(NSString * _Nonnull)log;
		[Export ("logWarn:")]
		void LogWarn (string log);

		// -(void)logError:(NSString * _Nonnull)log;
		[Export ("logError:")]
		void LogError (string log);

		// -(void)appendToConsoleLogs:(NSString * _Nonnull)log;
		[Export ("appendToConsoleLogs:")]
		void AppendToConsoleLogs (string log);

		// -(void)setUserAttribute:(NSString * _Nonnull)userAttribute withKey:(NSString * _Nonnull)key;
		[Export ("setUserAttribute:withKey:")]
		void SetUserAttribute (string userAttribute, string key);

		// -(void)addFileAttachmentWithURL:(NSURL * _Nonnull)url;
		[Export ("addFileAttachmentWithURL:")]
		void AddFileAttachmentWithURL (NSUrl url);

		// -(void)addFileAttachmentWithData:(NSData * _Nonnull)data;
		[Export ("addFileAttachmentWithData:")]
		void AddFileAttachmentWithData (NSData data);

		// -(void)addFileAttachmentWithData:(NSData * _Nonnull)data andName:(NSString * _Nonnull)name;
		[Export ("addFileAttachmentWithData:andName:")]
		void AddFileAttachmentWithData (NSData data, string name);
	}

	// @interface IBGSurvey : NSObject
	[BaseType (typeof(NSObject))]
	interface IBGSurvey
	{
		// @property (readonly, nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; }

		// -(void)show;
		[Export ("show")]
		void Show ();
	}

	// @interface IBGSurveys : NSObject
	[BaseType (typeof(NSObject))]
	interface IBGSurveys
	{
		// @property (assign, atomic, class) BOOL enabled;
		[Static]
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (readonly, atomic, class) BOOL usageExceeded;
		[Static]
		[Export ("usageExceeded")]
		bool UsageExceeded { get; }

		// @property (assign, atomic, class) BOOL autoShowingEnabled;
		[Static]
		[Export ("autoShowingEnabled")]
		bool AutoShowingEnabled { get; set; }

		// +(void)availableSurveysWithCompletionHandler:(void (^ _Nonnull)(NSArray<IBGSurvey *> * _Nonnull))completionHandler;
		// [Static]
		// [Export ("availableSurveysWithCompletionHandler:")]
		// void AvailableSurveysWithCompletionHandler (Action<NSArray<IBGSurvey>> completionHandler);

		// @property (class, atomic, readonly, strong) NSArray<IBGSurvey *> *availableSurveys;
        [Static]
        [Export("availableSurveys")]
        IBGSurvey[] AvailableSurveys { get; }

		// @property (atomic, strong, class) void (^ _Nonnull)(void) willShowSurveyHandler;
		[Static]
		[Export ("willShowSurveyHandler", ArgumentSemantic.Strong)]
		Action WillShowSurveyHandler { get; set; }

		// @property (atomic, strong, class) void (^ _Nonnull)(void) didDismissSurveyHandler;
		[Static]
		[Export ("didDismissSurveyHandler", ArgumentSemantic.Strong)]
		Action DidDismissSurveyHandler { get; set; }

		// @property (atomic, strong, class) void (^ _Nullable)(IBGSurveyFinishedState, NSDictionary * _Nonnull, NSString * _Nonnull) didFinishSurveyHandler;
		[Static]
		[NullAllowed, Export ("didFinishSurveyHandler", ArgumentSemantic.Strong)]
		Action<IBGSurveyFinishedState, NSDictionary, NSString> DidFinishSurveyHandler { get; set; }

		// @property (assign, atomic, class) BOOL shouldShowWelcomeScreen;
		[Static]
		[Export ("shouldShowWelcomeScreen")]
		bool ShouldShowWelcomeScreen { get; set; }

		// +(void)showSurveyIfAvailable;
		[Static]
		[Export ("showSurveyIfAvailable")]
		void ShowSurveyIfAvailable ();

		// +(void)showSurveyWithToken:(NSString * _Nonnull)surveyToken;
		[Static]
		[Export ("showSurveyWithToken:")]
		void ShowSurveyWithToken (string surveyToken);

		// +(void)hasRespondedToSurveyWithToken:(NSString * _Nonnull)surveyToken completionHandler:(void (^ _Nonnull)(BOOL))completionHandler;
		[Static]
		[Export ("hasRespondedToSurveyWithToken:completionHandler:")]
		void HasRespondedToSurveyWithToken (string surveyToken, Action<bool> completionHandler);

		// @property (atomic, strong, class) NSString * _Nonnull appStoreURL;
		[Static]
		[Export ("appStoreURL", ArgumentSemantic.Strong)]
		string AppStoreURL { get; set; }
	}

	// @interface Instabug (UIView)
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_Instabug
	{
		// @property (assign, nonatomic) BOOL instabug_privateView;
		[Export ("instabug_privateView")]
		bool Instabug_privateView();
	}

	// @interface Instabug : NSObject
	[BaseType (typeof(NSObject))]
	interface Instabug
	{
		// @property (assign, atomic, class) BOOL enabled;
		[Static]
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (assign, atomic, class) BOOL sessionProfilerEnabled;
		[Static]
		[Export ("sessionProfilerEnabled")]
		bool SessionProfilerEnabled { get; set; }

		// @property (atomic, strong, class) UIColor * _Nonnull tintColor;
		[Static]
		[Export ("tintColor", ArgumentSemantic.Strong)]
		UIColor TintColor { get; set; }

		// @property (atomic, strong, class) IBGReport * _Nonnull (^ _Nonnull)(IBGReport * _Nonnull) willSendReportHandler;
		[Static]
		[Export ("willSendReportHandler", ArgumentSemantic.Strong)]
		Func<IBGReport, IBGReport> WillSendReportHandler { get; set; }

		// @property (assign, atomic, class) BOOL trackUserSteps;
		[Static]
		[Export ("trackUserSteps")]
		bool TrackUserSteps { get; set; }

		// @property (assign, atomic, class) IBGUserStepsMode reproStepsMode;
		[Static]
		[Export ("reproStepsMode", ArgumentSemantic.Assign)]
		IBGUserStepsMode ReproStepsMode { get; set; }

		// @property (assign, atomic, class) IBGWelcomeMessageMode welcomeMessageMode;
		[Static]
		[Export ("welcomeMessageMode", ArgumentSemantic.Assign)]
		IBGWelcomeMessageMode WelcomeMessageMode { get; set; }

		// @property (atomic, strong, class) void (^ _Nonnull)(void) didDismissWelcomeMessageHandler;
		[Static]
		[Export ("didDismissWelcomeMessageHandler", ArgumentSemantic.Strong)]
		Action DidDismissWelcomeMessageHandler { get; set; }

		// @property (atomic, strong, class) NSString * _Nonnull userData;
		[Static]
		[Export ("userData", ArgumentSemantic.Strong)]
		string UserData { get; set; }

		// +(void)startWithToken:(NSString * _Nonnull)token invocationEvents:(IBGInvocationEvent)invocationEvents;
		[Static]
		[Export ("startWithToken:invocationEvents:")]
		void StartWithToken (string token, IBGInvocationEvent invocationEvents);

		// +(void)show;
		[Static]
		[Export ("show")]
		void Show ();

		// +(void)addFileAttachmentWithURL:(NSURL * _Nonnull)fileURL;
		[Static]
		[Export ("addFileAttachmentWithURL:")]
		void AddFileAttachmentWithURL (NSUrl fileURL);

		// +(void)addFileAttachmentWithData:(NSData * _Nonnull)data;
		[Static]
		[Export ("addFileAttachmentWithData:")]
		void AddFileAttachmentWithData (NSData data);

		// +(void)addFileAttachmentWithData:(NSData * _Nonnull)data andName:(NSString * _Nonnull)name;
		[Static]
		[Export ("addFileAttachmentWithData:andName:")]
		void AddFileAttachmentWithData (NSData data, string name);

		// +(void)clearFileAttachments;
		[Static]
		[Export ("clearFileAttachments")]
		void ClearFileAttachments ();

		// +(void)showWelcomeMessageWithMode:(IBGWelcomeMessageMode)welcomeMessageMode;
		[Static]
		[Export ("showWelcomeMessageWithMode:")]
		void ShowWelcomeMessageWithMode (IBGWelcomeMessageMode welcomeMessageMode);

		// +(void)identifyUserWithEmail:(NSString * _Nonnull)email name:(NSString * _Nullable)name;
		[Static]
		[Export ("identifyUserWithEmail:name:")]
		void IdentifyUserWithEmail (string email, [NullAllowed] string name);

		// +(void)logOut;
		[Static]
		[Export ("logOut")]
		void LogOut ();

		// +(void)setLocale:(IBGLocale)locale;
		[Static]
		[Export ("setLocale:")]
		void SetLocale (IBGLocale locale);

		// +(void)setColorTheme:(IBGColorTheme)colorTheme;
		[Static]
		[Export ("setColorTheme:")]
		void SetColorTheme (IBGColorTheme colorTheme);

		// +(void)setScreenshotCapturingHandler:(UIImage * _Nonnull (^ _Nonnull)(void))screenshotCapturingHandler;
		[Static]
		[Export ("setScreenshotCapturingHandler:")]
		void SetScreenshotCapturingHandler (Func<UIImage> screenshotCapturingHandler);

		// +(void)appendTags:(NSArray<NSString *> * _Nonnull)tags;
		[Static]
		[Export ("appendTags:")]
		void AppendTags (string[] tags);

		// +(void)resetTags;
		[Static]
		[Export ("resetTags")]
		void ResetTags ();

		// +(NSArray * _Nonnull)getTags;
		[Static]
		[Export ("getTags")]
		// [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Tags { get; }

		// +(void)setValue:(NSString * _Nonnull)value forStringWithKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("setValue:forStringWithKey:")]
		void SetValue (string value, string key);

		// +(void)setUserAttribute:(NSString * _Nonnull)value withKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("setUserAttribute:withKey:")]
		void SetUserAttribute (string value, string key);

		// +(NSString * _Nullable)userAttributeForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("userAttributeForKey:")]
		[return: NullAllowed]
		string UserAttributeForKey (string key);

		// +(void)removeUserAttributeForKey:(NSString * _Nonnull)key;
		[Static]
		[Export ("removeUserAttributeForKey:")]
		void RemoveUserAttributeForKey (string key);

		// +(NSDictionary * _Nullable)userAttributes;
		[Static]
		[NullAllowed, Export ("userAttributes")]
		// [Verify (MethodToProperty)]
		NSDictionary UserAttributes { get; }

		// +(void)addExperiments:(NSArray<NSString *> * _Nonnull)experiments;
		[Static]
		[Export ("addExperiments:")]
		void AddExperiments (string[] experiments);

		// +(void)removeExperiments:(NSArray<NSString *> * _Nonnull)experiments;
		[Static]
		[Export ("removeExperiments:")]
		void RemoveExperiments (string[] experiments);

		// +(void)clearAllExperiments;
		[Static]
		[Export ("clearAllExperiments")]
		void ClearAllExperiments ();

		// +(void)logUserEventWithName:(NSString * _Nonnull)name;
		[Static]
		[Export ("logUserEventWithName:")]
		void LogUserEventWithName (string name);

		// +(void)disableMethodSwizzling;
		[Static]
		[Export ("disableMethodSwizzling")]
		void DisableMethodSwizzling ();

		// +(void)logViewDidAppearEvent:(NSString * _Nonnull)viewName;
		[Static]
		[Export ("logViewDidAppearEvent:")]
		void LogViewDidAppearEvent (string viewName);

		// +(void)logTouchEvent:(IBGUIEventType)event viewName:(NSString * _Nonnull)viewName;
		[Static]
		[Export ("logTouchEvent:viewName:")]
		void LogTouchEvent (IBGUIEventType @event, string viewName);

		// +(void)userUUID:(void (^ _Nonnull)(NSString * _Nullable))userUUIDCompletionHandler;
		[Static]
		[Export ("userUUID:")]
		void UserUUID (Action<NSString> userUUIDCompletionHandler);

		// @property (assign, atomic, class) IBGSDKDebugLogsLevel sdkDebugLogsLevel;
		[Static]
		[Export ("sdkDebugLogsLevel", ArgumentSemantic.Assign)]
		IBGSDKDebugLogsLevel SdkDebugLogsLevel { get; set; }
	}
}
