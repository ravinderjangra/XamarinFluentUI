using System;
using ObjCRuntime;

namespace FluentUIComponents
{
	[Native]
	public enum MSFActionsCellActionType : long
	{
		Regular = 0,
		Destructive = 1,
		Communication = 2
	}

	[Native]
	public enum MSFActivityIndicatorViewSize : long
	{
		XSmall = 0,
		Small = 1,
		Medium = 2,
		Large = 3,
		XLarge = 4
	}

	[Native]
	public enum MSFAvatarSize : long
	{
		ExtraSmall = 0,
		Small = 1,
		Medium = 2,
		Large = 3,
		ExtraLarge = 4,
		ExtraExtraLarge = 5
	}

	[Native]
	public enum MSFAvatarStyle : long
	{
		Circle = 0,
		Square = 1
	}

	[Native]
	public enum MSFBadgeViewStyle : long
	{
		Default = 0,
		Warning = 1,
		Error = 2
	}

	[Native]
	public enum MSFBadgeViewSize : long
	{
		Small = 0,
		Medium = 1
	}

	[Native]
	public enum MSFTableViewCellCustomViewSize : long
	{
		Default = 0,
		Zero = 1,
		Small = 2,
		Medium = 3
	}

	[Native]
	public enum MSFTableViewCellSeparatorType : long
	{
		None = 0,
		Inset = 1,
		Full = 2
	}

	[Native]
	public enum MSFButtonStyle : long
	{
		PrimaryFilled = 0,
		PrimaryOutline = 1,
		SecondaryOutline = 2,
		TertiaryOutline = 3,
		Borderless = 4
	}

	[Native]
	public enum MSFColorPalette : long
	{
		PinkRed10 = 0,
		Red20 = 1,
		Red10 = 2,
		Orange30 = 3,
		Orange20 = 4,
		OrangeYellow20 = 5,
		Green20 = 6,
		Green10 = 7,
		Cyan30 = 8,
		Cyan20 = 9,
		CyanBlue20 = 10,
		CyanBlue10 = 11,
		Blue10 = 12,
		BlueMagenta30 = 13,
		BlueMagenta20 = 14,
		Magenta20 = 15,
		Magenta10 = 16,
		MagentaPink10 = 17,
		Gray40 = 18,
		Gray30 = 19,
		Gray20 = 20,
		Gray12 = 21,
		Gray11 = 22,
		Gray10 = 23,
		Gray9 = 24,
		Gray8 = 25,
		Gray7 = 26,
		Gray6 = 27,
		Gray5 = 28,
		Gray4 = 29,
		Gray3 = 30,
		Gray2 = 31,
		Gray1 = 32,
		CommunicationBlue = 33,
		CommunicationBlueTint40 = 34,
		CommunicationBlueTint30 = 35,
		CommunicationBlueTint20 = 36,
		CommunicationBlueTint10 = 37,
		CommunicationBlueShade30 = 38,
		CommunicationBlueShade20 = 39,
		CommunicationBlueShade10 = 40,
		DangerPrimary = 41,
		DangerTint40 = 42,
		DangerTint10 = 43,
		DangerShade40 = 44,
		DangerShade10 = 45,
		WarningPrimary = 46,
		WarningTint40 = 47,
		WarningTint10 = 48,
		WarningShade40 = 49,
		WarningShade30 = 50
	}

	[Native]
	public enum MSFDateStringCompactness : long
	{
		LongDaynameDayMonth = 1,
		LongDaynameDayMonthYear = 2,
		ShortDayname = 3,
		ShortDaynameShortMonthnameDay = 4,
		ShortDaynameShortMonthnameDayFullYear = 5,
		PartialDaynameShortDayMonth = 6,
		LongDaynameDayMonthHoursColumnsMinutes = 7,
		ShortDaynameShortMonthnameHoursColumnsMinutes = 8,
		PartialDaynameShortDayMonthHoursColumsMinutes = 9,
		PartialMonthnameDaynameFullYear = 10,
		PartialMonthnameDaynameHoursColumnsMinutes = 11,
		PartialMonthnameDayname = 12,
		LongMonthNameFullYear = 13,
		ShortDaynameHoursColumnMinutes = 14,
		ShortDayMonth = 15,
		LongDayMonthYearTime = 16,
		ShortDaynameDayShortMonthYear = 17
	}

	[Native]
	public enum MSFDateTimePickerDatePickerType : long
	{
		alendar = 0,
		omponents = 1
	}

	[Native]
	public enum MSFDateTimePickerDateRangePresentation : long
	{
		Paged = 0,
		Tabbed = 1
	}

	[Native]
	public enum MSFDateTimePickerMode : long
	{
		MSFDateTimePickerModeDate = 0,
		Time = 1,
		Range = 2,
		TimeRange = 3
	}

	[Native]
	public enum MSFDayOfWeek : long
	{
		Sunday = 0,
		Monday = 1,
		Tuesday = 2,
		Wednesday = 3,
		Thursday = 4,
		Friday = 5,
		Saturday = 6
	}

	[Native]
	public enum MSFDimmingViewType : long
	{
		White = 1,
		Black = 2,
		None = 3
	}

	[Native]
	public enum MSFDrawerPresentationBackground : long
	{
		None = 0,
		Black = 1
	}

	[Native]
	public enum MSFDrawerPresentationDirection : long
	{
		Down = 0,
		Up = 1,
		FromLeading = 2,
		FromTrailing = 3
	}

	[Native]
	public enum MSFDrawerPresentationStyle : long
	{
		Automatic = -1,
		Slideover = 0,
		Popover = 1
	}

	[Native]
	public enum MSFDrawerResizingBehavior : long
	{
		None = 0,
		Dismiss = 1,
		DismissOrExpand = 2
	}

	[Native]
	public enum MSFNavigationBarStyle : long
	{
		Default = 0,
		Primary = 1,
		System = 2,
		Custom = 3
	}

	[Native]
	public enum MSFNavigationBarElementSize : long
	{
		Automatic = 0,
		Contracted = 1,
		Expanded = 2
	}

	[Native]
	public enum MSFNavigationBarShadow : long
	{
		utomatic = 0,
		lwaysHidden = 1
	}

	[Native]
	public enum MSFNotificationViewStyle : long
	{
		PrimaryToast = 0,
		NeutralToast = 1,
		PrimaryBar = 2,
		PrimaryOutlineBar = 3,
		NeutralBar = 4
	}

	[Native]
	public enum MSFObscureStyle : long
	{
		Blur = 0,
		Dim = 1
	}

	[Native]
	public enum MSFPersonaListViewSelectionDirection : long
	{
		Next = 1,
		Prev = -1
	}

	[Native]
	public enum MSFPillButtonStyle : long
	{
		Outline = 0,
		Filled = 1
	}

	[Native]
	public enum MSFPopupMenuItemExecutionMode : long
	{
		OnSelection = 0,
		AfterPopupMenuDismissal = 1,
		AfterPopupMenuDismissalCompleted = 2
	}

	[Native]
	public enum MSFSearchBarStyle : long
	{
		LightContent = 0,
		DarkContent = 1
	}

	[Native]
	public enum MSFSegmentedControlStyle : long
	{
		Tabs = 0,
		Switch = 1
	}

	[Native]
	public enum MSFSeparatorOrientation : long
	{
		Horizontal = 0,
		Vertical = 1
	}

	[Native]
	public enum MSFSeparatorStyle : long
	{
		Default = 0,
		Shadow = 1
	}

	[Native]
	public enum MSFTableViewCellAccessoryType : long
	{
		None = 0,
		DisclosureIndicator = 1,
		DetailButton = 2,
		Checkmark = 3
	}

	[Native]
	public enum MSFTableViewHeaderFooterViewAccessoryButtonStyle : long
	{
		Regular = 0,
		Primary = 1
	}

	[Native]
	public enum MSFTableViewHeaderFooterViewStyle : long
	{
		Header = 0,
		Divider = 1,
		DividerHighlighted = 2,
		Footer = 3
	}

	[Native]
	public enum MSFTextColorStyle : long
	{
		Regular = 0,
		Secondary = 1,
		White = 2,
		Primary = 3,
		Error = 4,
		Warning = 5,
		Disabled = 6
	}

	[Native]
	public enum MSFTextStyle : long
	{
		LargeTitle = 0,
		Title1 = 1,
		Title2 = 2,
		Headline = 3,
		HeadlineUnscaled = 4,
		Body = 5,
		BodyUnscaled = 6,
		Subhead = 7,
		Footnote = 8,
		FootnoteUnscaled = 9,
		Button1 = 10,
		Button2 = 11,
		Button3 = 12,
		Caption1 = 13,
		Caption2 = 14
	}

	[Native]
	public enum MSFTimeStringCompactness : long
	{
		ColumnsMinutes = 1,
		MSFTimeStringCompactnessHours = 2
	}

	[Native]
	public enum MSFTooltipArrowDirection : long
	{
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3
	}

	[Native]
	public enum MSFTooltipDismissMode : long
	{
		Anywhere = 0,
		OnTooltip = 1,
		OnTooltipOrAnchor = 2
	}

	[Native]
	public enum MSFTwoLineTitleViewStyle : long
	{
		Light = 0,
		Dark = 1
	}

	[Native]
	public enum MSFTwoLineTitleViewInteractivePart : long
	{
		None = 0,
		Title = 1,
		Subtitle = 2
	}

	[Native]
	public enum MSFTwoLineTitleViewAccessoryType : long
	{
		None = 0,
		Disclosure = 1,
		DownArrow = 2
	}

	[Native]
	public enum MSFWeekOfMonth : long
	{
		First = 1,
		Second = 2,
		Third = 3,
		Fourth = 4,
		Last = 5
	}
}
