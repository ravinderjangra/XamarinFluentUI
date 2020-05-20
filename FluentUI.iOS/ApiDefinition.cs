using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using NSTextAlignment = UIKit.UITextAlignment;
using NSLineBreakMode = UIKit.UILineBreakMode;

namespace FluentUIComponents
{
	interface IAccessibleViewDelegate { }

	// @protocol AccessibleViewDelegate
	[Protocol, Model]
    [BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFAccessibleViewDelegate)]
	interface AccessibleViewDelegate
	{
		// @optional -(NSString * _Nullable)accessibilityValueForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result));
		[Export ("accessibilityValueForAccessibleView:")]
		[return: NullAllowed]
		string AccessibilityValueForAccessibleView (UIView accessibleView);

		// @optional -(NSString * _Nullable)accessibilityLabelForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result));
		[Export ("accessibilityLabelForAccessibleView:")]
		[return: NullAllowed]
		string AccessibilityLabelForAccessibleView (UIView accessibleView);

		// @optional -(BOOL)accessibilityActivateForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result));
		[Export ("accessibilityActivateForAccessibleView:")]
		bool AccessibilityActivateForAccessibleView (UIView accessibleView);

		// @optional -(void)accessibilityIncrementForAccessibleView:(UIView * _Nonnull)accessibleView;
		[Export ("accessibilityIncrementForAccessibleView:")]
		void AccessibilityIncrementForAccessibleView (UIView accessibleView);

		// @optional -(void)accessibilityDecrementForAccessibleView:(UIView * _Nonnull)accessibleView;
		[Export ("accessibilityDecrementForAccessibleView:")]
		void AccessibilityDecrementForAccessibleView (UIView accessibleView);

		// @optional -(BOOL)accessibilityPerformMagicTapForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result));
		[Export ("accessibilityPerformMagicTapForAccessibleView:")]
		bool AccessibilityPerformMagicTapForAccessibleView (UIView accessibleView);

		// @optional -(NSArray * _Nullable)accessibilityElementsForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result));
		[Export ("accessibilityElementsForAccessibleView:")]
		[return: NullAllowed]
		NSObject[] AccessibilityElementsForAccessibleView (UIView accessibleView);
	}

	interface IAccessibleTableViewDelegate { }

	// @protocol AccessibleTableViewDelegate <AccessibleViewDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFAccessibleTableViewDelegate)]
	interface AccessibleTableViewDelegate
	{
		// @optional -(NSString * _Nullable)accessibilityValueForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath forTableView:(UITableView * _Nonnull)forTableView __attribute__((warn_unused_result));
		[Export ("accessibilityValueForRowAtIndexPath:forTableView:")]
		[return: NullAllowed]
		string ForTableView (NSIndexPath indexPath, UITableView forTableView);
	}

	// @interface MSFActionsCell : UITableViewCell
	[BaseType(typeof(UITableViewCell), Name = ApiDefinitionConstants.MSFActionsCell)]
	interface MSFActionsCell
	{
		// +(CGFloat)heightWithAction1Title:(NSString * _Nonnull)action1Title action2Title:(NSString * _Nonnull)action2Title containerWidth:(CGFloat)containerWidth __attribute__((warn_unused_result));
		[Static]
		[Export ("heightWithAction1Title:action2Title:containerWidth:")]
		nfloat HeightWithAction1Title (string action1Title, string action2Title, nfloat containerWidth);

		// +(CGFloat)preferredWidthWithAction1Title:(NSString * _Nonnull)action1Title action2Title:(NSString * _Nonnull)action2Title __attribute__((warn_unused_result));
		[Static]
		[Export ("preferredWidthWithAction1Title:action2Title:")]
		nfloat PreferredWidthWithAction1Title (string action1Title, string action2Title);

		// @property (nonatomic) enum MSFTableViewCellSeparatorType topSeparatorType;
		[Export ("topSeparatorType", ArgumentSemantic.Assign)]
		MSFTableViewCellSeparatorType TopSeparatorType { get; set; }

		// @property (nonatomic) enum MSFTableViewCellSeparatorType bottomSeparatorType;
		[Export ("bottomSeparatorType", ArgumentSemantic.Assign)]
		MSFTableViewCellSeparatorType BottomSeparatorType { get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// @property (readonly, nonatomic, strong) UIButton * _Nonnull action1Button;
		[Export ("action1Button", ArgumentSemantic.Strong)]
		UIButton Action1Button { get; }

		// @property (readonly, nonatomic, strong) UIButton * _Nonnull action2Button;
		[Export ("action2Button", ArgumentSemantic.Strong)]
		UIButton Action2Button { get; }

		// -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:reuseIdentifier:")]
		[DesignatedInitializer]
		IntPtr Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

		// -(void)setupWithAction1Title:(NSString * _Nonnull)action1Title action2Title:(NSString * _Nonnull)action2Title action1Type:(enum MSFActionsCellActionType)action1Type action2Type:(enum MSFActionsCellActionType)action2Type;
		[Export ("setupWithAction1Title:action2Title:action1Type:action2Type:")]
		void SetupWithAction1Title (string action1Title, string action2Title, MSFActionsCellActionType action1Type, MSFActionsCellActionType action2Type);

		// -(void)setupWithAction1Title:(NSString * _Nonnull)action1Title action1Type:(enum MSFActionsCellActionType)action1Type;
		[Export ("setupWithAction1Title:action1Type:")]
		void SetupWithAction1Title (string action1Title, MSFActionsCellActionType action1Type);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)prepareForReuse __attribute__((objc_requires_super));
		[Export ("prepareForReuse")]
		[RequiresSuper]
		void PrepareForReuse ();

		// -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
		[Export ("setHighlighted:animated:")]
		void SetHighlighted (bool highlighted, bool animated);

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);
	}

	// @interface MSFActivityIndicatorCell : UITableViewCell
	[BaseType(typeof(UITableViewCell), Name = ApiDefinitionConstants.MSFActivityIndicatorCell)]
	interface MSFActivityIndicatorCell
	{
		// -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:reuseIdentifier:")]
		[DesignatedInitializer]
		IntPtr Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)prepareForReuse __attribute__((objc_requires_super));
		[Export ("prepareForReuse")]
		[RequiresSuper]
		void PrepareForReuse ();

		// -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
		[Export ("setHighlighted:animated:")]
		void SetHighlighted (bool highlighted, bool animated);

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);
	}

	// @interface MSFActivityIndicatorView : UIView
	[BaseType(typeof(UIView), Name = ApiDefinitionConstants.MSFActivityIndicatorView)]
	interface MSFActivityIndicatorView
	{
		// +(CGSize)sizeThatFitsWithSize:(enum MSFActivityIndicatorViewSize)size __attribute__((warn_unused_result));
		[Static]
		[Export ("sizeThatFitsWithSize:")]
		CGSize SizeThatFitsWithSize (MSFActivityIndicatorViewSize size);

		// @property (nonatomic) enum MSFActivityIndicatorViewSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		MSFActivityIndicatorViewSize Size { get; set; }

		// @property (nonatomic) BOOL hidesWhenStopped;
		[Export ("hidesWhenStopped")]
		bool HidesWhenStopped { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (readonly, nonatomic) BOOL isAnimating;
		[Export ("isAnimating")]
		bool IsAnimating { get; }

		// -(instancetype _Nonnull)initWithSize:(enum MSFActivityIndicatorViewSize)size;
		[Export ("initWithSize:")]
		IntPtr Constructor (MSFActivityIndicatorViewSize size);

		// -(instancetype _Nonnull)initWithSideSize:(CGFloat)sideSize strokeThickness:(CGFloat)strokeThickness __attribute__((objc_designated_initializer));
		[Export ("initWithSideSize:strokeThickness:")]
		[DesignatedInitializer]
		IntPtr Constructor (nfloat sideSize, nfloat strokeThickness);

		// -(void)startAnimating;
		[Export ("startAnimating")]
		void StartAnimating ();

		// -(void)stopAnimating;
		[Export ("stopAnimating")]
		void StopAnimating ();

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)sizeToFit;
		[Export ("sizeToFit")]
		void SizeToFit ();
	}

	interface IMSFAnimationSynchronizerProtocol { }

	// @protocol MSFAnimationSynchronizerProtocol
	[Model, Protocol]
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFAnimationSynchronizerProtocol)]
	interface MSFAnimationSynchronizerProtocol
	{
		// @required @property (nonatomic, strong) CALayer * _Nullable referenceLayer;
		[Abstract]
		[NullAllowed, Export ("referenceLayer", ArgumentSemantic.Strong)]
		CALayer ReferenceLayer { get; set; }

		// @required -(CFTimeInterval)timeOffsetFor:(CALayer * _Nonnull)layer __attribute__((warn_unused_result));
		[Abstract]
		[Export ("timeOffsetFor:")]
		double TimeOffsetFor (CALayer layer);
	}

	// @interface MSFAnimationSynchronizer : NSObject <MSFAnimationSynchronizerProtocol>
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFAnimationSynchronizer)]
	[DisableDefaultCtor]
	interface MSFAnimationSynchronizer
	{
		// -(instancetype _Nonnull)initWithReferenceLayer:(CALayer * _Nullable)referenceLayer __attribute__((objc_designated_initializer));
		[Export ("initWithReferenceLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] CALayer referenceLayer);

		// @property (nonatomic, weak) CALayer * _Nullable referenceLayer;
		[NullAllowed, Export ("referenceLayer", ArgumentSemantic.Weak)]
		CALayer ReferenceLayer { get; set; }

		// -(CFTimeInterval)timeOffsetFor:(CALayer * _Nonnull)layer __attribute__((warn_unused_result));
		[Export ("timeOffsetFor:")]
		double TimeOffsetFor (CALayer layer);
	}

	// @protocol MSFAvatar
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MSFAvatar
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull primaryText;
		[Abstract]
		[Export ("primaryText")]
		string PrimaryText { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull secondaryText;
		[Abstract]
		[Export ("secondaryText")]
		string SecondaryText { get; }

		// @required @property (readonly, nonatomic, strong) UIImage * _Nullable image;
		[Abstract]
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; }
	}

	// @interface MSFAvatarData : NSObject <MSFAvatar>
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFAvatarData)]
	[DisableDefaultCtor]
	interface MSFAvatarData : MSFAvatar
	{
		// @property (copy, nonatomic) NSString * _Nonnull primaryText;
		[Export ("primaryText")]
		string PrimaryText { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull secondaryText;
		[Export ("secondaryText")]
		string SecondaryText { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// -(instancetype _Nonnull)initWithPrimaryText:(NSString * _Nonnull)primaryText secondaryText:(NSString * _Nonnull)secondaryText image:(UIImage * _Nullable)image __attribute__((objc_designated_initializer));
		[Export ("initWithPrimaryText:secondaryText:image:")]
		[DesignatedInitializer]
		IntPtr Constructor (string primaryText, string secondaryText, [NullAllowed] UIImage image);
	}

	// @interface MSFAvatarView : UIView
	[BaseType(typeof(UIView), Name = ApiDefinitionConstants.MSFAvatarView)]
	interface MSFAvatarView
	{
		// @property (nonatomic) enum MSFAvatarSize avatarSize;
		[Export ("avatarSize", ArgumentSemantic.Assign)]
		MSFAvatarSize AvatarSize { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull avatarBackgroundColor;
		[Export ("avatarBackgroundColor", ArgumentSemantic.Strong)]
		UIColor AvatarBackgroundColor { get; set; }

		// @property (nonatomic) enum MSFAvatarStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		MSFAvatarStyle Style { get; set; }

		// -(instancetype _Nonnull)initWithAvatarSize:(enum MSFAvatarSize)avatarSize withBorder:(BOOL)hasBorder style:(enum MSFAvatarStyle)style __attribute__((objc_designated_initializer));
		[Export ("initWithAvatarSize:withBorder:style:")]
		[DesignatedInitializer]
		IntPtr Constructor (MSFAvatarSize avatarSize, bool hasBorder, MSFAvatarStyle style);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)setupWithPrimaryText:(NSString * _Nullable)primaryText secondaryText:(NSString * _Nullable)secondaryText image:(UIImage * _Nullable)image;
		[Export ("setupWithPrimaryText:secondaryText:image:")]
		void SetupWithPrimaryText ([NullAllowed] string primaryText, [NullAllowed] string secondaryText, [NullAllowed] UIImage image);

		// -(void)setupWithImage:(UIImage * _Nonnull)image;
		[Export ("setupWithImage:")]
		void SetupWithImage (UIImage image);

		// -(void)setupWithAvatar:(id<MSFAvatar> _Nullable)avatar;
		[Export ("setupWithAvatar:")]
		void SetupWithAvatar ([NullAllowed] MSFAvatar avatar);

		// @property (nonatomic) BOOL isAccessibilityElement;
		[Export ("isAccessibilityElement")]
		bool IsAccessibilityElement { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
		[NullAllowed, Export ("accessibilityLabel")]
		string AccessibilityLabel { get; set; }

		// @property (nonatomic) UIAccessibilityTraits accessibilityTraits;
		[Export ("accessibilityTraits")]
		ulong AccessibilityTraits { get; set; }
	}

	// @interface MSFBadgeField : UIView
	[BaseType(typeof(UIView), Name = ApiDefinitionConstants.MSFBadgeField)]
	interface MSFBadgeField
	{
		// @property (copy, nonatomic) NSString * _Nonnull label;
		[Export ("label")]
		string Label { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull placeholder;
		[Export ("placeholder")]
		string Placeholder { get; set; }

		// @property (nonatomic) NSInteger numberOfLines;
		[Export ("numberOfLines")]
		nint NumberOfLines { get; set; }

		// @property (nonatomic) BOOL isEditable;
		[Export ("isEditable")]
		bool IsEditable { get; set; }

		// @property (nonatomic) BOOL isActive;
		[Export ("isActive")]
		bool IsActive { get; set; }

		// @property (nonatomic) BOOL allowsDragAndDrop;
		[Export ("allowsDragAndDrop")]
		bool AllowsDragAndDrop { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull softBadgingCharacters;
		[Export ("softBadgingCharacters")]
		string SoftBadgingCharacters { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull hardBadgingCharacters;
		[Export ("hardBadgingCharacters")]
		string HardBadgingCharacters { get; set; }

		// @property (readonly, copy, nonatomic) NSArray<MSFBadgeView *> * _Nonnull badges;
		[Export ("badges", ArgumentSemantic.Copy)]
		MSFBadgeView[] Badges { get; }

		// @property (readonly, copy, nonatomic) NSArray<MSFBadgeViewDataSource *> * _Nonnull badgeDataSources;
		[Export ("badgeDataSources", ArgumentSemantic.Copy)]
		MSFBadgeViewDataSource[] BadgeDataSources { get; }

		[Wrap ("WeakBadgeFieldDelegate")]
		[NullAllowed]
		MSFBadgeFieldDelegate BadgeFieldDelegate { get; set; }

		// @property (nonatomic, weak) id<MSFBadgeFieldDelegate> _Nullable badgeFieldDelegate;
		[NullAllowed, Export ("badgeFieldDelegate", ArgumentSemantic.Weak)]
		NSObject WeakBadgeFieldDelegate { get; set; }

		// -(void)setupWithDataSources:(NSArray<MSFBadgeViewDataSource *> * _Nonnull)dataSources;
		[Export ("setupWithDataSources:")]
		void SetupWithDataSources (MSFBadgeViewDataSource[] dataSources);

		// -(void)reload;
		[Export ("reload")]
		void Reload ();

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGFloat)heightThatFitsWithNumberOfLines:(NSInteger)numberOfLines __attribute__((warn_unused_result));
		[Export ("heightThatFitsWithNumberOfLines:")]
		nfloat HeightThatFitsWithNumberOfLines (nint numberOfLines);

		// -(void)badgeText;
		[Export ("badgeText")]
		void BadgeText ();

		// -(void)addBadgesWithDataSources:(NSArray<MSFBadgeViewDataSource *> * _Nonnull)dataSources;
		[Export ("addBadgesWithDataSources:")]
		void AddBadgesWithDataSources (MSFBadgeViewDataSource[] dataSources);

		// -(void)addBadgeWithDataSource:(MSFBadgeViewDataSource * _Nonnull)dataSource fromUserAction:(BOOL)fromUserAction updateConstrainedBadges:(BOOL)updateConstrainedBadges;
		[Export ("addBadgeWithDataSource:fromUserAction:updateConstrainedBadges:")]
		void AddBadgeWithDataSource (MSFBadgeViewDataSource dataSource, bool fromUserAction, bool updateConstrainedBadges);

		// -(void)deleteBadgesWithDataSource:(MSFBadgeViewDataSource * _Nonnull)dataSource;
		[Export ("deleteBadgesWithDataSource:")]
		void DeleteBadgesWithDataSource (MSFBadgeViewDataSource dataSource);

		// -(void)deleteAllBadges;
		[Export ("deleteAllBadges")]
		void DeleteAllBadges ();

		// -(void)selectBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("selectBadge:")]
		void SelectBadge (MSFBadgeView badge);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull textFieldContent;
		[Export ("textFieldContent")]
		string TextFieldContent { get; }

		// -(void)resetTextFieldContent;
		[Export ("resetTextFieldContent")]
		void ResetTextFieldContent ();

		// -(BOOL)becomeFirstResponder;
		[Export ("becomeFirstResponder")]
		bool BecomeFirstResponder { get; }

		// @property (readonly, nonatomic) BOOL isFirstResponder;
		[Export ("isFirstResponder")]
		bool IsFirstResponder { get; }

		// -(BOOL)resignFirstResponder;
		[Export ("resignFirstResponder")]
		bool ResignFirstResponder { get; }

		// -(void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary<NSKeyValueChangeKey,id> * _Nullable)change context:(void * _Nullable)context;
		//[Export ("observeValueForKeyPath:ofObject:change:context:")]
		//unsafe void ObserveValueForKeyPath ([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> change, [NullAllowed] void* context);

		// -(NSInteger)accessibilityElementCount __attribute__((warn_unused_result));
		[Export ("accessibilityElementCount")]
		nint AccessibilityElementCount { get; }

		// -(id _Nullable)accessibilityElementAtIndex:(NSInteger)index __attribute__((warn_unused_result));
		[Export ("accessibilityElementAtIndex:")]
		[return: NullAllowed]
		NSObject AccessibilityElementAtIndex (nint index);

		// -(NSInteger)indexOfAccessibilityElement:(id _Nonnull)element __attribute__((warn_unused_result));
		[Export ("indexOfAccessibilityElement:")]
		nint IndexOfAccessibilityElement (NSObject element);

		// -(void)voiceOverFocusOnTextFieldAndAnnounce:(NSString * _Nullable)announcement;
		[Export ("voiceOverFocusOnTextFieldAndAnnounce:")]
		void VoiceOverFocusOnTextFieldAndAnnounce ([NullAllowed] string announcement);
	}

	interface IMSFBadgeViewDelegate { }

	// @protocol MSFBadgeViewDelegate
	[Protocol, Model]
    [BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFBadgeViewDelegate)]
	interface MSFBadgeViewDelegate
	{
		// @required -(void)didSelectBadge:(MSFBadgeView * _Nonnull)badge;
		[Abstract]
		[Export ("didSelectBadge:")]
		void DidSelectBadge (MSFBadgeView badge);

		// @required -(void)didTapSelectedBadge:(MSFBadgeView * _Nonnull)badge;
		[Abstract]
		[Export ("didTapSelectedBadge:")]
		void DidTapSelectedBadge (MSFBadgeView badge);
	}

	interface IMSFBadgeFieldDelegate { }

	// @protocol MSFBadgeFieldDelegate
	[Protocol, Model]
    [BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFBadgeFieldDelegate)]
	interface MSFBadgeFieldDelegate
	{
		// @optional -(MSFBadgeViewDataSource * _Nonnull)badgeField:(MSFBadgeField * _Nonnull)badgeField badgeDataSourceForText:(NSString * _Nonnull)text __attribute__((warn_unused_result));
		[Export ("badgeField:badgeDataSourceForText:")]
		MSFBadgeViewDataSource BadgeField (MSFBadgeField badgeField, string text);

		// @optional -(void)badgeField:(MSFBadgeField * _Nonnull)badgeField willChangeTextFieldContentWithText:(NSString * _Nonnull)newText;
		[Export ("badgeField:willChangeTextFieldContentWithText:")]
		void WillChangeTextFieldContentWithText(MSFBadgeField badgeField, string newText);

		// @optional -(void)badgeFieldDidChangeTextFieldContent:(MSFBadgeField * _Nonnull)badgeField isPaste:(BOOL)isPaste;
		[Export ("badgeFieldDidChangeTextFieldContent:isPaste:")]
		void BadgeFieldDidChangeTextFieldContent(MSFBadgeField badgeField, bool isPaste);

		// @optional -(BOOL)badgeField:(MSFBadgeField * _Nonnull)badgeField shouldBadgeText:(NSString * _Nonnull)text forSoftBadgingString:(NSString * _Nonnull)badgingString __attribute__((warn_unused_result));
		[Export ("badgeField:shouldBadgeText:forSoftBadgingString:")]
		bool ShouldBadgeText(MSFBadgeField badgeField, string text, string badgingString);

		// @optional -(void)badgeField:(MSFBadgeField * _Nonnull)badgeField didAddBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("badgeField:didAddBadge:")]
		void DidAddBadge(MSFBadgeField badgeField, MSFBadgeView badge);

		// @optional -(void)badgeField:(MSFBadgeField * _Nonnull)badgeField didDeleteBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("badgeField:didDeleteBadge:")]
		void DidDeleteBadge(MSFBadgeField badgeField, MSFBadgeView badge);

		// @optional -(BOOL)badgeField:(MSFBadgeField * _Nonnull)badgeField shouldAddBadgeForBadgeDataSource:(MSFBadgeViewDataSource * _Nonnull)badgeDataSource __attribute__((warn_unused_result));
		[Export ("badgeField:shouldAddBadgeForBadgeDataSource:")]
		bool ShouldAddBadgeForBadgeDataSource(MSFBadgeField badgeField, MSFBadgeViewDataSource badgeDataSource);

		// @optional -(MSFBadgeView * _Nonnull)badgeField:(MSFBadgeField * _Nonnull)badgeField newBadgeForBadgeDataSource:(MSFBadgeViewDataSource * _Nonnull)badgeDataSource __attribute__((warn_unused_result));
		[Export ("badgeField:newBadgeForBadgeDataSource:")]
		MSFBadgeView NewBadgeForBadgeDataSource(MSFBadgeField badgeField, MSFBadgeViewDataSource badgeDataSource);

		// @optional -(MSFBadgeView * _Nonnull)badgeField:(MSFBadgeField * _Nonnull)badgeField newMoreBadgeForBadgeDataSources:(NSArray<MSFBadgeViewDataSource *> * _Nonnull)badgeDataSources __attribute__((warn_unused_result));
		[Export ("badgeField:newMoreBadgeForBadgeDataSources:")]
		MSFBadgeView NewMoreBadgeForBadgeDataSources(MSFBadgeField badgeField, MSFBadgeViewDataSource[] badgeDataSources);

		// @optional -(void)badgeFieldContentHeightDidChange:(MSFBadgeField * _Nonnull)badgeField;
		[Export ("badgeFieldContentHeightDidChange:")]
		void BadgeFieldContentHeightDidChange (MSFBadgeField badgeField);

		// @optional -(void)badgeField:(MSFBadgeField * _Nonnull)badgeField didTapSelectedBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("badgeField:didTapSelectedBadge:")]
		void DidTapSelectedBadge(MSFBadgeField badgeField, MSFBadgeView badge);

		// @optional -(BOOL)badgeField:(MSFBadgeField * _Nonnull)badgeField shouldDragBadge:(MSFBadgeView * _Nonnull)badge __attribute__((warn_unused_result));
		[Export ("badgeField:shouldDragBadge:")]
		bool ShouldDragBadge(MSFBadgeField badgeField, MSFBadgeView badge);

		// @optional -(void)badgeField:(MSFBadgeField * _Nonnull)originbadgeField didEndDraggingOriginBadge:(MSFBadgeView * _Nonnull)originBadge toBadgeField:(MSFBadgeField * _Nullable)destinationBadgeField withNewBadge:(MSFBadgeView * _Nullable)newBadge;
		[Export ("badgeField:didEndDraggingOriginBadge:toBadgeField:withNewBadge:")]
		void DidEndDraggingOriginBadge(MSFBadgeField originbadgeField, MSFBadgeView originBadge, [NullAllowed] MSFBadgeField destinationBadgeField, [NullAllowed] MSFBadgeView newBadge);

		// @optional -(BOOL)badgeFieldShouldBeginEditing:(MSFBadgeField * _Nonnull)badgeField __attribute__((warn_unused_result));
		[Export ("badgeFieldShouldBeginEditing:")]
		bool BadgeFieldShouldBeginEditing (MSFBadgeField badgeField);

		// @optional -(void)badgeFieldDidBeginEditing:(MSFBadgeField * _Nonnull)badgeField;
		[Export ("badgeFieldDidBeginEditing:")]
		void BadgeFieldDidBeginEditing (MSFBadgeField badgeField);

		// @optional -(void)badgeFieldDidEndEditing:(MSFBadgeField * _Nonnull)badgeField;
		[Export ("badgeFieldDidEndEditing:")]
		void BadgeFieldDidEndEditing (MSFBadgeField badgeField);

		// @optional -(BOOL)badgeFieldShouldReturn:(MSFBadgeField * _Nonnull)badgeField __attribute__((warn_unused_result));
		[Export ("badgeFieldShouldReturn:")]
		bool BadgeFieldShouldReturn (MSFBadgeField badgeField);
	}

	// @interface MSFBadgeView : UIView
	[BaseType(typeof(UIView), Name = ApiDefinitionConstants.MSFBadgeView)]
	interface MSFBadgeView
	{
		// @property (nonatomic, strong) MSFBadgeViewDataSource * _Nullable dataSource;
		[NullAllowed, Export ("dataSource", ArgumentSemantic.Strong)]
		MSFBadgeViewDataSource DataSource { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFBadgeViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFBadgeViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) BOOL isActive;
		[Export ("isActive")]
		bool IsActive { get; set; }

		// @property (nonatomic) BOOL isSelected;
		[Export ("isSelected")]
		bool IsSelected { get; set; }

		// @property (nonatomic) CGFloat minWidth;
		[Export ("minWidth")]
		nfloat MinWidth { get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(instancetype _Nonnull)initWithDataSource:(MSFBadgeViewDataSource * _Nonnull)dataSource __attribute__((objc_designated_initializer));
		[Export ("initWithDataSource:")]
		[DesignatedInitializer]
		IntPtr Constructor (MSFBadgeViewDataSource dataSource);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
		[NullAllowed, Export ("accessibilityLabel")]
		string AccessibilityLabel { get; set; }
	}

	// @interface MSFBadgeViewDataSource : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFBadgeViewDataSource)]
	[DisableDefaultCtor]
	interface MSFBadgeViewDataSource
	{
		// @property (copy, nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }

		// @property (nonatomic) enum MSFBadgeViewStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		MSFBadgeViewStyle Style { get; set; }

		// @property (nonatomic) enum MSFBadgeViewSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		MSFBadgeViewSize Size { get; set; }

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text style:(enum MSFBadgeViewStyle)style size:(enum MSFBadgeViewSize)size __attribute__((objc_designated_initializer));
		[Export ("initWithText:style:size:")]
		[DesignatedInitializer]
		IntPtr Constructor (string text, MSFBadgeViewStyle style, MSFBadgeViewSize size);
	}

	// @interface BarButtonItems : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFBarButtonItems)]
	[DisableDefaultCtor]
	interface BarButtonItems
	{
	}

	// @interface MSFBlurringView : UIView
	[BaseType(typeof(UIView), Name = ApiDefinitionConstants.MSFBlurringView)]
	interface MSFBlurringView
	{
		// -(instancetype _Nonnull)initWithStyle:(UIBlurEffectStyle)style backgroundColor:(UIColor * _Nullable)backgroundColor __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:backgroundColor:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIBlurEffectStyle style, [NullAllowed] UIColor backgroundColor);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)updateBackgroundWithBackgroundColor:(UIColor * _Nullable)backgroundColor;
		[Export ("updateBackgroundWithBackgroundColor:")]
		void UpdateBackgroundWithBackgroundColor ([NullAllowed] UIColor backgroundColor);
	}

	// @interface MSFTableViewCell : UITableViewCell
	[BaseType(typeof(UITableViewCell), Name = ApiDefinitionConstants.MSFTableViewCell)]
	interface MSFTableViewCell
	{
		// @property (readonly, nonatomic, class) CGFloat smallHeight;
		[Static]
		[Export ("smallHeight")]
		nfloat SmallHeight { get; }

		// @property (readonly, nonatomic, class) CGFloat mediumHeight;
		[Static]
		[Export ("mediumHeight")]
		nfloat MediumHeight { get; }

		// @property (readonly, nonatomic, class) CGFloat largeHeight;
		[Static]
		[Export ("largeHeight")]
		nfloat LargeHeight { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull identifier;
		[Static]
		[Export ("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic, class) NSInteger defaultNumberOfLinesForLargerDynamicType;
		[Static]
		[Export ("defaultNumberOfLinesForLargerDynamicType")]
		nint DefaultNumberOfLinesForLargerDynamicType { get; }

		// +(CGFloat)heightWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nonnull)subtitle footer:(NSString * _Nonnull)footer titleLeadingAccessoryView:(UIView * _Nullable)titleLeadingAccessoryView titleTrailingAccessoryView:(UIView * _Nullable)titleTrailingAccessoryView subtitleLeadingAccessoryView:(UIView * _Nullable)subtitleLeadingAccessoryView subtitleTrailingAccessoryView:(UIView * _Nullable)subtitleTrailingAccessoryView footerLeadingAccessoryView:(UIView * _Nullable)footerLeadingAccessoryView footerTrailingAccessoryView:(UIView * _Nullable)footerTrailingAccessoryView customViewSize:(enum MSFTableViewCellCustomViewSize)customViewSize customAccessoryView:(UIView * _Nullable)customAccessoryView accessoryType:(enum MSFTableViewCellAccessoryType)accessoryType titleNumberOfLines:(NSInteger)titleNumberOfLines subtitleNumberOfLines:(NSInteger)subtitleNumberOfLines footerNumberOfLines:(NSInteger)footerNumberOfLines customAccessoryViewExtendsToEdge:(BOOL)customAccessoryViewExtendsToEdge containerWidth:(CGFloat)containerWidth isInSelectionMode:(BOOL)isInSelectionMode __attribute__((warn_unused_result));
		[Static]
		[Export ("heightWithTitle:subtitle:footer:titleLeadingAccessoryView:titleTrailingAccessoryView:subtitleLeadingAccessoryView:subtitleTrailingAccessoryView:footerLeadingAccessoryView:footerTrailingAccessoryView:customViewSize:customAccessoryView:accessoryType:titleNumberOfLines:subtitleNumberOfLines:footerNumberOfLines:customAccessoryViewExtendsToEdge:containerWidth:isInSelectionMode:")]
		nfloat HeightWithTitle (string title, string subtitle, string footer, [NullAllowed] UIView titleLeadingAccessoryView, [NullAllowed] UIView titleTrailingAccessoryView, [NullAllowed] UIView subtitleLeadingAccessoryView, [NullAllowed] UIView subtitleTrailingAccessoryView, [NullAllowed] UIView footerLeadingAccessoryView, [NullAllowed] UIView footerTrailingAccessoryView, MSFTableViewCellCustomViewSize customViewSize, [NullAllowed] UIView customAccessoryView, MSFTableViewCellAccessoryType accessoryType, nint titleNumberOfLines, nint subtitleNumberOfLines, nint footerNumberOfLines, bool customAccessoryViewExtendsToEdge, nfloat containerWidth, bool isInSelectionMode);

		// +(CGFloat)preferredWidthWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nonnull)subtitle footer:(NSString * _Nonnull)footer titleLeadingAccessoryView:(UIView * _Nullable)titleLeadingAccessoryView titleTrailingAccessoryView:(UIView * _Nullable)titleTrailingAccessoryView subtitleLeadingAccessoryView:(UIView * _Nullable)subtitleLeadingAccessoryView subtitleTrailingAccessoryView:(UIView * _Nullable)subtitleTrailingAccessoryView footerLeadingAccessoryView:(UIView * _Nullable)footerLeadingAccessoryView footerTrailingAccessoryView:(UIView * _Nullable)footerTrailingAccessoryView customViewSize:(enum MSFTableViewCellCustomViewSize)customViewSize customAccessoryView:(UIView * _Nullable)customAccessoryView accessoryType:(enum MSFTableViewCellAccessoryType)accessoryType customAccessoryViewExtendsToEdge:(BOOL)customAccessoryViewExtendsToEdge isInSelectionMode:(BOOL)isInSelectionMode __attribute__((warn_unused_result));
		[Static]
		[Export ("preferredWidthWithTitle:subtitle:footer:titleLeadingAccessoryView:titleTrailingAccessoryView:subtitleLeadingAccessoryView:subtitleTrailingAccessoryView:footerLeadingAccessoryView:footerTrailingAccessoryView:customViewSize:customAccessoryView:accessoryType:customAccessoryViewExtendsToEdge:isInSelectionMode:")]
		nfloat PreferredWidthWithTitle (string title, string subtitle, string footer, [NullAllowed] UIView titleLeadingAccessoryView, [NullAllowed] UIView titleTrailingAccessoryView, [NullAllowed] UIView subtitleLeadingAccessoryView, [NullAllowed] UIView subtitleTrailingAccessoryView, [NullAllowed] UIView footerLeadingAccessoryView, [NullAllowed] UIView footerTrailingAccessoryView, MSFTableViewCellCustomViewSize customViewSize, [NullAllowed] UIView customAccessoryView, MSFTableViewCellAccessoryType accessoryType, bool customAccessoryViewExtendsToEdge, bool isInSelectionMode);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull subtitle;
		[Export ("subtitle")]
		string Subtitle { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull footer;
		[Export ("footer")]
		string Footer { get; }

		// @property (nonatomic) NSInteger titleNumberOfLines;
		[Export ("titleNumberOfLines")]
		nint TitleNumberOfLines { get; set; }

		// @property (nonatomic) NSInteger subtitleNumberOfLines;
		[Export ("subtitleNumberOfLines")]
		nint SubtitleNumberOfLines { get; set; }

		// @property (nonatomic) NSInteger footerNumberOfLines;
		[Export ("footerNumberOfLines")]
		nint FooterNumberOfLines { get; set; }

		// @property (nonatomic) NSInteger titleNumberOfLinesForLargerDynamicType;
		[Export ("titleNumberOfLinesForLargerDynamicType")]
		nint TitleNumberOfLinesForLargerDynamicType { get; set; }

		// @property (nonatomic) NSInteger subtitleNumberOfLinesForLargerDynamicType;
		[Export ("subtitleNumberOfLinesForLargerDynamicType")]
		nint SubtitleNumberOfLinesForLargerDynamicType { get; set; }

		// @property (nonatomic) NSInteger footerNumberOfLinesForLargerDynamicType;
		[Export ("footerNumberOfLinesForLargerDynamicType")]
		nint FooterNumberOfLinesForLargerDynamicType { get; set; }

		// @property (nonatomic) NSLineBreakMode titleLineBreakMode;
		[Export ("titleLineBreakMode", ArgumentSemantic.Assign)]
		NSLineBreakMode TitleLineBreakMode { get; set; }

		// @property (nonatomic) NSLineBreakMode subtitleLineBreakMode;
		[Export ("subtitleLineBreakMode", ArgumentSemantic.Assign)]
		NSLineBreakMode SubtitleLineBreakMode { get; set; }

		// @property (nonatomic) NSLineBreakMode footerLineBreakMode;
		[Export ("footerLineBreakMode", ArgumentSemantic.Assign)]
		NSLineBreakMode FooterLineBreakMode { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable titleLeadingAccessoryView;
		[NullAllowed, Export ("titleLeadingAccessoryView", ArgumentSemantic.Strong)]
		UIView TitleLeadingAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable titleTrailingAccessoryView;
		[NullAllowed, Export ("titleTrailingAccessoryView", ArgumentSemantic.Strong)]
		UIView TitleTrailingAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable subtitleLeadingAccessoryView;
		[NullAllowed, Export ("subtitleLeadingAccessoryView", ArgumentSemantic.Strong)]
		UIView SubtitleLeadingAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable subtitleTrailingAccessoryView;
		[NullAllowed, Export ("subtitleTrailingAccessoryView", ArgumentSemantic.Strong)]
		UIView SubtitleTrailingAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable footerLeadingAccessoryView;
		[NullAllowed, Export ("footerLeadingAccessoryView", ArgumentSemantic.Strong)]
		UIView FooterLeadingAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable footerTrailingAccessoryView;
		[NullAllowed, Export ("footerTrailingAccessoryView", ArgumentSemantic.Strong)]
		UIView FooterTrailingAccessoryView { get; set; }

		// @property (nonatomic) enum MSFTableViewCellCustomViewSize customViewSize;
		[Export ("customViewSize", ArgumentSemantic.Assign)]
		MSFTableViewCellCustomViewSize CustomViewSize { get; set; }

		// @property (readonly, nonatomic, strong) UIView * _Nullable customAccessoryView;
		[NullAllowed, Export ("customAccessoryView", ArgumentSemantic.Strong)]
		UIView CustomAccessoryView { get; }

		// @property (nonatomic) BOOL customAccessoryViewExtendsToEdge;
		[Export ("customAccessoryViewExtendsToEdge")]
		bool CustomAccessoryViewExtendsToEdge { get; set; }

		// @property (nonatomic) enum MSFTableViewCellSeparatorType topSeparatorType;
		[Export ("topSeparatorType", ArgumentSemantic.Assign)]
		MSFTableViewCellSeparatorType TopSeparatorType { get; set; }

		// @property (nonatomic) enum MSFTableViewCellSeparatorType bottomSeparatorType;
		[Export ("bottomSeparatorType", ArgumentSemantic.Assign)]
		MSFTableViewCellSeparatorType BottomSeparatorType { get; set; }

		// @property (nonatomic) BOOL isEnabled;
		[Export ("isEnabled")]
		bool IsEnabled { get; set; }

		// @property (nonatomic) BOOL isInSelectionMode;
		[Export ("isInSelectionMode")]
		bool IsInSelectionMode { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onAccessoryTapped;
		[NullAllowed, Export ("onAccessoryTapped", ArgumentSemantic.Copy)]
		Action OnAccessoryTapped { get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// @property (nonatomic) CGRect bounds;
		[Export ("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// @property (nonatomic) CGRect frame;
		[Export ("frame", ArgumentSemantic.Assign)]
		CGRect Frame { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accessibilityHint;
		[NullAllowed, Export ("accessibilityHint")]
		string AccessibilityHint { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accessibilityValue;
		[NullAllowed, Export ("accessibilityValue")]
		string AccessibilityValue { get; set; }

		// @property (nonatomic) CGPoint accessibilityActivationPoint;
		[Export ("accessibilityActivationPoint", ArgumentSemantic.Assign)]
		CGPoint AccessibilityActivationPoint { get; set; }

		// -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:reuseIdentifier:")]
		[DesignatedInitializer]
		IntPtr Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

		// -(void)setupWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nonnull)subtitle footer:(NSString * _Nonnull)footer customView:(UIView * _Nullable)customView customAccessoryView:(UIView * _Nullable)customAccessoryView accessoryType:(enum MSFTableViewCellAccessoryType)accessoryType;
		[Export ("setupWithTitle:subtitle:footer:customView:customAccessoryView:accessoryType:")]
		void SetupWithTitle (string title, string subtitle, string footer, [NullAllowed] UIView customView, [NullAllowed] UIView customAccessoryView, MSFTableViewCellAccessoryType accessoryType);

		// -(void)changeAccessoryTypeTo:(enum MSFTableViewCellAccessoryType)accessoryType;
		[Export ("changeAccessoryTypeTo:")]
		void ChangeAccessoryTypeTo (MSFTableViewCellAccessoryType accessoryType);

		// -(void)setIsInSelectionMode:(BOOL)isInSelectionMode animated:(BOOL)animated;
		[Export ("setIsInSelectionMode:animated:")]
		void SetIsInSelectionMode (bool isInSelectionMode, bool animated);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)prepareForReuse __attribute__((objc_requires_super));
		[Export ("prepareForReuse")]
		[RequiresSuper]
		void PrepareForReuse ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesBegan:withEvent:")]
		void TouchesBegan (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesCancelled:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesCancelled:withEvent:")]
		void TouchesCancelled (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesEnded:withEvent:")]
		void TouchesEnded (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);
	}

	// @interface MSFBooleanCell : MSFTableViewCell
	[BaseType(typeof(MSFTableViewCell), Name = ApiDefinitionConstants.MSFBooleanCell)]
	interface MSFBooleanCell
	{
		// @property (nonatomic) BOOL isOn;
		[Export ("isOn")]
		bool IsOn { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onValueChanged;
		[NullAllowed, Export ("onValueChanged", ArgumentSemantic.Copy)]
		Action OnValueChanged { get; set; }

		// -(void)setupWithTitle:(NSString * _Nonnull)title customView:(UIView * _Nullable)customView isOn:(BOOL)isOn;
		[Export ("setupWithTitle:customView:isOn:")]
		void SetupWithTitle (string title, [NullAllowed] UIView customView, bool isOn);

		// -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:reuseIdentifier:")]
		[DesignatedInitializer]
		IntPtr Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);
	}

	// @interface MSFButton : UIButton
	[BaseType(typeof(UIButton), Name = ApiDefinitionConstants.MSFButton)]
	interface MSFButton
	{
		// @property (nonatomic) enum MSFButtonStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		MSFButtonStyle Style { get; set; }

		// @property (getter = isHighlighted, nonatomic) BOOL highlighted;
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(instancetype _Nonnull)initWithStyle:(enum MSFButtonStyle)style __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:")]
		[DesignatedInitializer]
		IntPtr Constructor (MSFButtonStyle style);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);
	}

	// @interface MSFCalendarConfiguration : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFCalendarConfiguration)]
	[DisableDefaultCtor]
	interface MSFCalendarConfiguration
	{
		// @property (readonly, getter = default, nonatomic, strong, class) MSFCalendarConfiguration * _Nonnull default_;
		[Static]
		[Export ("default_", ArgumentSemantic.Strong)]
		MSFCalendarConfiguration Default_ { [Bind ("default")] get; }

		// @property (nonatomic) NSInteger firstWeekday;
		[Export ("firstWeekday")]
		nint FirstWeekday { get; set; }
	}

	// @interface MSFCenteredLabelCell : UITableViewCell
	[BaseType(typeof(UITableViewCell), Name = ApiDefinitionConstants.MSFCenteredLabelCell)]
	interface MSFCenteredLabelCell
	{
		// -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:reuseIdentifier:")]
		[DesignatedInitializer]
		IntPtr Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
		[Export ("setHighlighted:animated:")]
		void SetHighlighted (bool highlighted, bool animated);

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);
	}

	// @interface MSFColors : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFColors)]
	[DisableDefaultCtor]
	interface MSFColors
	{
		// @property (nonatomic, strong, class) UIColor * _Nonnull primary;
		[Static]
		[Export ("primary", ArgumentSemantic.Strong)]
		UIColor Primary { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryTint10;
		[Static]
		[Export ("primaryTint10", ArgumentSemantic.Strong)]
		UIColor PrimaryTint10 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryTint20;
		[Static]
		[Export ("primaryTint20", ArgumentSemantic.Strong)]
		UIColor PrimaryTint20 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryTint30;
		[Static]
		[Export ("primaryTint30", ArgumentSemantic.Strong)]
		UIColor PrimaryTint30 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryTint40;
		[Static]
		[Export ("primaryTint40", ArgumentSemantic.Strong)]
		UIColor PrimaryTint40 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryShade10;
		[Static]
		[Export ("primaryShade10", ArgumentSemantic.Strong)]
		UIColor PrimaryShade10 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryShade20;
		[Static]
		[Export ("primaryShade20", ArgumentSemantic.Strong)]
		UIColor PrimaryShade20 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryShade30;
		[Static]
		[Export ("primaryShade30", ArgumentSemantic.Strong)]
		UIColor PrimaryShade30 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull foregroundOnPrimary;
		[Static]
		[Export ("foregroundOnPrimary", ArgumentSemantic.Strong)]
		UIColor ForegroundOnPrimary { get; set; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray950;
		[Static]
		[Export ("gray950", ArgumentSemantic.Strong)]
		UIColor Gray950 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray900;
		[Static]
		[Export ("gray900", ArgumentSemantic.Strong)]
		UIColor Gray900 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray800;
		[Static]
		[Export ("gray800", ArgumentSemantic.Strong)]
		UIColor Gray800 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray700;
		[Static]
		[Export ("gray700", ArgumentSemantic.Strong)]
		UIColor Gray700 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray600;
		[Static]
		[Export ("gray600", ArgumentSemantic.Strong)]
		UIColor Gray600 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray500;
		[Static]
		[Export ("gray500", ArgumentSemantic.Strong)]
		UIColor Gray500 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray400;
		[Static]
		[Export ("gray400", ArgumentSemantic.Strong)]
		UIColor Gray400 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray300;
		[Static]
		[Export ("gray300", ArgumentSemantic.Strong)]
		UIColor Gray300 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray200;
		[Static]
		[Export ("gray200", ArgumentSemantic.Strong)]
		UIColor Gray200 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray100;
		[Static]
		[Export ("gray100", ArgumentSemantic.Strong)]
		UIColor Gray100 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray50;
		[Static]
		[Export ("gray50", ArgumentSemantic.Strong)]
		UIColor Gray50 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray25;
		[Static]
		[Export ("gray25", ArgumentSemantic.Strong)]
		UIColor Gray25 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull error;
		[Static]
		[Export ("error", ArgumentSemantic.Strong)]
		UIColor Error { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull warning;
		[Static]
		[Export ("warning", ArgumentSemantic.Strong)]
		UIColor Warning { get; }

		// @property (copy, nonatomic, class) NSArray<UIColor *> * _Nonnull avatarBackgroundColors;
		[Static]
		[Export ("avatarBackgroundColors", ArgumentSemantic.Copy)]
		UIColor[] AvatarBackgroundColors { get; set; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull communicationBlue;
		[Static]
		[Export ("communicationBlue", ArgumentSemantic.Strong)]
		UIColor CommunicationBlue { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull background1;
		[Static]
		[Export ("background1", ArgumentSemantic.Strong)]
		UIColor Background1 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull background1b;
		[Static]
		[Export ("background1b", ArgumentSemantic.Strong)]
		UIColor Background1b { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull background1c;
		[Static]
		[Export ("background1c", ArgumentSemantic.Strong)]
		UIColor Background1c { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull background2;
		[Static]
		[Export ("background2", ArgumentSemantic.Strong)]
		UIColor Background2 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull background2b;
		[Static]
		[Export ("background2b", ArgumentSemantic.Strong)]
		UIColor Background2b { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull background3;
		[Static]
		[Export ("background3", ArgumentSemantic.Strong)]
		UIColor Background3 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull background3b;
		[Static]
		[Export ("background3b", ArgumentSemantic.Strong)]
		UIColor Background3b { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull disabled;
		[Static]
		[Export ("disabled", ArgumentSemantic.Strong)]
		UIColor Disabled { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground1;
		[Static]
		[Export ("foreground1", ArgumentSemantic.Strong)]
		UIColor Foreground1 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground1b;
		[Static]
		[Export ("foreground1b", ArgumentSemantic.Strong)]
		UIColor Foreground1b { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground2;
		[Static]
		[Export ("foreground2", ArgumentSemantic.Strong)]
		UIColor Foreground2 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground2b;
		[Static]
		[Export ("foreground2b", ArgumentSemantic.Strong)]
		UIColor Foreground2b { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground2c;
		[Static]
		[Export ("foreground2c", ArgumentSemantic.Strong)]
		UIColor Foreground2c { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground2d;
		[Static]
		[Export ("foreground2d", ArgumentSemantic.Strong)]
		UIColor Foreground2d { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground3;
		[Static]
		[Export ("foreground3", ArgumentSemantic.Strong)]
		UIColor Foreground3 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground3b;
		[Static]
		[Export ("foreground3b", ArgumentSemantic.Strong)]
		UIColor Foreground3b { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground3c;
		[Static]
		[Export ("foreground3c", ArgumentSemantic.Strong)]
		UIColor Foreground3c { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground4;
		[Static]
		[Export ("foreground4", ArgumentSemantic.Strong)]
		UIColor Foreground4 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground4b;
		[Static]
		[Export ("foreground4b", ArgumentSemantic.Strong)]
		UIColor Foreground4b { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground5;
		[Static]
		[Export ("foreground5", ArgumentSemantic.Strong)]
		UIColor Foreground5 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground6;
		[Static]
		[Export ("foreground6", ArgumentSemantic.Strong)]
		UIColor Foreground6 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground6b;
		[Static]
		[Export ("foreground6b", ArgumentSemantic.Strong)]
		UIColor Foreground6b { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground6c;
		[Static]
		[Export ("foreground6c", ArgumentSemantic.Strong)]
		UIColor Foreground6c { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull foreground7b;
		[Static]
		[Export ("foreground7b", ArgumentSemantic.Strong)]
		UIColor Foreground7b { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull separatorDefault;
		[Static]
		[Export ("separatorDefault", ArgumentSemantic.Strong)]
		UIColor SeparatorDefault { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableBackground;
		[Static]
		[Export ("tableBackground", ArgumentSemantic.Strong)]
		UIColor TableBackground { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableBackgroundGrouped;
		[Static]
		[Export ("tableBackgroundGrouped", ArgumentSemantic.Strong)]
		UIColor TableBackgroundGrouped { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableCellBackground;
		[Static]
		[Export ("tableCellBackground", ArgumentSemantic.Strong)]
		UIColor TableCellBackground { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableCellBackgroundGrouped;
		[Static]
		[Export ("tableCellBackgroundGrouped", ArgumentSemantic.Strong)]
		UIColor TableCellBackgroundGrouped { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableCellImage;
		[Static]
		[Export ("tableCellImage", ArgumentSemantic.Strong)]
		UIColor TableCellImage { get; }

		// +(UIColor * _Nonnull)colorFrom:(enum MSFColorPalette)palette __attribute__((warn_unused_result));
		[Static]
		[Export ("colorFrom:")]
		UIColor ColorFrom (MSFColorPalette palette);
	}

	// @interface MSFDateTimePicker : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFDateTimePicker)]
	interface MSFDateTimePicker
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFDateTimePickerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFDateTimePickerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)presentFrom:(UIViewController * _Nonnull)presentingController with:(enum MSFDateTimePickerMode)mode startDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nullable)endDate datePickerType:(enum MSFDateTimePickerDatePickerType)datePickerType dateRangePresentation:(enum MSFDateTimePickerDateRangePresentation)dateRangePresentation titles:(MSFDateTimePickerTitles * _Nullable)titles;
		[Export ("presentFrom:with:startDate:endDate:datePickerType:dateRangePresentation:titles:")]
		void PresentFrom (UIViewController presentingController, MSFDateTimePickerMode mode, NSDate startDate, [NullAllowed] NSDate endDate, MSFDateTimePickerDatePickerType datePickerType, MSFDateTimePickerDateRangePresentation dateRangePresentation, [NullAllowed] MSFDateTimePickerTitles titles);

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();
	}

	// @interface MSFDateTimePickerTitles : NSObject
	[BaseType (typeof(NSObject))]
	interface MSFDateTimePickerTitles
	{
	}

	interface IMSFDateTimePickerDelegate { }

	// @protocol MSFDateTimePickerDelegate
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFDateTimePickerDelegate)]
	interface MSFDateTimePickerDelegate
	{
		// @required -(void)dateTimePicker:(MSFDateTimePicker * _Nonnull)dateTimePicker didPickStartDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nonnull)endDate;
		[Abstract]
		[Export ("dateTimePicker:didPickStartDate:endDate:")]
		void DidPickStartDate(MSFDateTimePicker dateTimePicker, NSDate startDate, NSDate endDate);

		// @optional -(BOOL)dateTimePicker:(MSFDateTimePicker * _Nonnull)dateTimePicker shouldEndPickingStartDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nonnull)endDate __attribute__((warn_unused_result));
		[Export ("dateTimePicker:shouldEndPickingStartDate:endDate:")]
		bool ShouldEndPickingStartDate(MSFDateTimePicker dateTimePicker, NSDate startDate, NSDate endDate);
	}

	// @interface MSFDimmingView : UIView
	[BaseType(typeof(UIView), Name = ApiDefinitionConstants.MSFDimmingView)]
	interface MSFDimmingView
	{
		// -(instancetype _Nonnull)initWithType:(enum MSFDimmingViewType)type __attribute__((objc_designated_initializer));
		[Export ("initWithType:")]
		[DesignatedInitializer]
		IntPtr Constructor (MSFDimmingViewType type);
	}

	// @interface MSFDotView : UIView
	[BaseType(typeof(UIView), Name = ApiDefinitionConstants.MSFDotView)]
	interface MSFDotView
	{
		// @property (nonatomic, strong) UIColor * _Nullable color;
		[NullAllowed, Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(void)drawRect:(CGRect)rect;
		[Export ("drawRect:")]
		void DrawRect (CGRect rect);
	}

	// @interface MSFDrawerController : UIViewController
	[BaseType(typeof(UIViewController), Name = ApiDefinitionConstants.MSFDrawerController)]
	interface MSFDrawerController
	{
		// @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIViewController * _Nullable contentController;
		[NullAllowed, Export ("contentController", ArgumentSemantic.Strong)]
		UIViewController ContentController { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable contentView;
		[NullAllowed, Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }

		// @property (nonatomic, strong) UIScrollView * _Nullable contentScrollView;
		[NullAllowed, Export ("contentScrollView", ArgumentSemantic.Strong)]
		UIScrollView ContentScrollView { get; set; }

		// @property (nonatomic) enum MSFDrawerPresentationStyle presentationStyle;
		[Export ("presentationStyle", ArgumentSemantic.Assign)]
		MSFDrawerPresentationStyle PresentationStyle { get; set; }

		// @property (nonatomic) CGFloat presentationOffset;
		[Export ("presentationOffset")]
		nfloat PresentationOffset { get; set; }

		// @property (nonatomic) enum MSFDrawerPresentationBackground presentationBackground;
		[Export ("presentationBackground", ArgumentSemantic.Assign)]
		MSFDrawerPresentationBackground PresentationBackground { get; set; }

		// @property (nonatomic, strong) UIPanGestureRecognizer * _Nullable presentingGesture;
		[NullAllowed, Export ("presentingGesture", ArgumentSemantic.Strong)]
		UIPanGestureRecognizer PresentingGesture { get; set; }

		// @property (nonatomic) enum MSFDrawerResizingBehavior resizingBehavior;
		[Export ("resizingBehavior", ArgumentSemantic.Assign)]
		MSFDrawerResizingBehavior ResizingBehavior { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull resizingHandleViewBackgroundColor;
		[Export ("resizingHandleViewBackgroundColor", ArgumentSemantic.Strong)]
		UIColor ResizingHandleViewBackgroundColor { get; set; }

		// @property (nonatomic) BOOL isExpanded;
		[Export ("isExpanded")]
		bool IsExpanded { get; set; }

		// @property (nonatomic) BOOL adjustsHeightForKeyboard;
		[Export ("adjustsHeightForKeyboard")]
		bool AdjustsHeightForKeyboard { get; set; }

		// @property (nonatomic) UIPopoverArrowDirection permittedArrowDirections;
		[Export ("permittedArrowDirections", ArgumentSemantic.Assign)]
		UIPopoverArrowDirection PermittedArrowDirections { get; set; }

		// @property (nonatomic) CGSize preferredContentSize;
		[Export ("preferredContentSize", ArgumentSemantic.Assign)]
		CGSize PreferredContentSize { get; set; }

		// @property (readonly, nonatomic) BOOL shouldAutorotate;
		[Export ("shouldAutorotate")]
		bool ShouldAutorotate { get; }

		// @property (readonly, nonatomic) UIInterfaceOrientationMask supportedInterfaceOrientations;
		[Export ("supportedInterfaceOrientations")]
		UIInterfaceOrientationMask SupportedInterfaceOrientations { get; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onDismiss;
		[NullAllowed, Export ("onDismiss", ArgumentSemantic.Copy)]
		Action OnDismiss { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onDismissCompleted;
		[NullAllowed, Export ("onDismissCompleted", ArgumentSemantic.Copy)]
		Action OnDismissCompleted { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFDrawerControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFDrawerControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithSourceView:(UIView * _Nonnull)sourceView sourceRect:(CGRect)sourceRect presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSFDrawerPresentationDirection)presentationDirection __attribute__((objc_designated_initializer));
		[Export ("initWithSourceView:sourceRect:presentationOrigin:presentationDirection:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIView sourceView, CGRect sourceRect, nfloat presentationOrigin, MSFDrawerPresentationDirection presentationDirection);

		// -(instancetype _Nonnull)initWithBarButtonItem:(UIBarButtonItem * _Nonnull)barButtonItem presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSFDrawerPresentationDirection)presentationDirection __attribute__((objc_designated_initializer));
		[Export ("initWithBarButtonItem:presentationOrigin:presentationDirection:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIBarButtonItem barButtonItem, nfloat presentationOrigin, MSFDrawerPresentationDirection presentationDirection);

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewWillAppear:(BOOL)animated;
		[Export ("viewWillAppear:")]
		void ViewWillAppear (bool animated);

		// -(void)viewDidAppear:(BOOL)animated;
		[Export ("viewDidAppear:")]
		void ViewDidAppear (bool animated);

		// -(void)viewWillDisappear:(BOOL)animated;
		[Export ("viewWillDisappear:")]
		void ViewWillDisappear (bool animated);

		// -(void)viewDidDisappear:(BOOL)animated;
		[Export ("viewDidDisappear:")]
		void ViewDidDisappear (bool animated);

		// -(void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
		[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
		void ViewWillTransitionToSize (CGSize size, IUIViewControllerTransitionCoordinator coordinator);

		// -(void)preferredContentSizeDidChangeForChildContentContainer:(id<UIContentContainer> _Nonnull)container;
		[Export ("preferredContentSizeDidChangeForChildContentContainer:")]
		void PreferredContentSizeDidChangeForChildContentContainer (UIContentContainer container);

		// -(BOOL)accessibilityPerformEscape __attribute__((warn_unused_result));
		[Export ("accessibilityPerformEscape")]
		bool AccessibilityPerformEscape { get; }
	}

	interface IMSFDrawerControllerDelegate { }

	// @protocol MSFDrawerControllerDelegate
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFDrawerControllerDelegate)]
	interface MSFDrawerControllerDelegate
	{
		// @optional -(void)drawerControllerDidChangeExpandedState:(MSFDrawerController * _Nonnull)controller;
		[Export ("drawerControllerDidChangeExpandedState:")]
		void DrawerControllerDidChangeExpandedState (MSFDrawerController controller);

		// @optional -(void)drawerControllerWillDismiss:(MSFDrawerController * _Nonnull)controller;
		[Export ("drawerControllerWillDismiss:")]
		void DrawerControllerWillDismiss (MSFDrawerController controller);

		// @optional -(void)drawerControllerDidDismiss:(MSFDrawerController * _Nonnull)controller;
		[Export ("drawerControllerDidDismiss:")]
		void DrawerControllerDidDismiss (MSFDrawerController controller);
	}

	// @interface MSFEasyTapButton : UIButton
	[BaseType(typeof(UIButton), Name = ApiDefinitionConstants.MSFEasyTapButton)]
	interface MSFEasyTapButton
	{
		// -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
		[Export ("pointInside:withEvent:")]
		bool PointInside (CGPoint point, [NullAllowed] UIEvent @event);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}

	// @interface FluentUIFramework : NSObject
	[BaseType (typeof (NSObject), Name = ApiDefinitionConstants.FluentUIFramework)]
	interface FluentUIFramework
	{
		// @property (readonly, nonatomic, strong, class) NSBundle * _Nonnull bundle;
		[Static]
		[Export ("bundle", ArgumentSemantic.Strong)]
		NSBundle Bundle { get; }

		// @property (readonly, nonatomic, strong, class) NSBundle * _Nonnull resourceBundle;
		[Static]
		[Export ("resourceBundle", ArgumentSemantic.Strong)]
		NSBundle ResourceBundle { get; }

		// @property (nonatomic, class) BOOL usesFluentIcons __attribute__((deprecated("Non-fluent icons no longer supported. Setting this var no longer has any effect and it will be removed in a future update.")));
		[Static]
		[Export ("usesFluentIcons")]
		bool UsesFluentIcons { get; set; }

		// +(void)initializeAppearance;
		[Static]
		[Export ("initializeAppearance")]
		void InitializeAppearance ();
	}

	// @interface MSFFonts : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFFonts)]
	[DisableDefaultCtor]
	interface MSFFonts
	{
		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull largeTitle;
		[Static]
		[Export ("largeTitle", ArgumentSemantic.Strong)]
		UIFont LargeTitle { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull title1;
		[Static]
		[Export ("title1", ArgumentSemantic.Strong)]
		UIFont Title1 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull title2;
		[Static]
		[Export ("title2", ArgumentSemantic.Strong)]
		UIFont Title2 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull headline;
		[Static]
		[Export ("headline", ArgumentSemantic.Strong)]
		UIFont Headline { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull headlineUnscaled;
		[Static]
		[Export ("headlineUnscaled", ArgumentSemantic.Strong)]
		UIFont HeadlineUnscaled { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull body;
		[Static]
		[Export ("body", ArgumentSemantic.Strong)]
		UIFont Body { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull bodyUnscaled;
		[Static]
		[Export ("bodyUnscaled", ArgumentSemantic.Strong)]
		UIFont BodyUnscaled { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull subhead;
		[Static]
		[Export ("subhead", ArgumentSemantic.Strong)]
		UIFont Subhead { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull footnote;
		[Static]
		[Export ("footnote", ArgumentSemantic.Strong)]
		UIFont Footnote { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull footnoteUnscaled;
		[Static]
		[Export ("footnoteUnscaled", ArgumentSemantic.Strong)]
		UIFont FootnoteUnscaled { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull button1;
		[Static]
		[Export ("button1", ArgumentSemantic.Strong)]
		UIFont Button1 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull button2;
		[Static]
		[Export ("button2", ArgumentSemantic.Strong)]
		UIFont Button2 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull button3;
		[Static]
		[Export ("button3", ArgumentSemantic.Strong)]
		UIFont Button3 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull button4;
		[Static]
		[Export ("button4", ArgumentSemantic.Strong)]
		UIFont Button4 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull caption1;
		[Static]
		[Export ("caption1", ArgumentSemantic.Strong)]
		UIFont Caption1 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull caption2;
		[Static]
		[Export ("caption2", ArgumentSemantic.Strong)]
		UIFont Caption2 { get; }
	}

	// @interface MSFHUD : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFHud)]
	[DisableDefaultCtor]
	interface MSFHUD
	{
		// @property (readonly, nonatomic, strong, class) MSFHUD * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		MSFHUD Shared { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFHUDDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFHUDDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)showIn:(UIView * _Nonnull)view;
		[Export ("showIn:")]
		void ShowIn (UIView view);

		// -(void)showIn:(UIView * _Nonnull)view with:(MSFHUDParams * _Nonnull)params;
		[Export ("showIn:with:")]
		void ShowIn (UIView view, MSFHUDParams @params);

		// -(void)showIn:(UIView * _Nonnull)view with:(MSFHUDParams * _Nonnull)params onTap:(void (^ _Nullable)(void))onTap;
		[Export ("showIn:with:onTap:")]
		void ShowIn (UIView view, MSFHUDParams @params, [NullAllowed] Action onTap);

		// -(void)showFrom:(UIViewController * _Nonnull)controller;
		[Export ("showFrom:")]
		void ShowFrom (UIViewController controller);

		// -(void)showFrom:(UIViewController * _Nonnull)controller with:(MSFHUDParams * _Nonnull)params;
		[Export ("showFrom:with:")]
		void ShowFrom (UIViewController controller, MSFHUDParams @params);

		// -(void)showSuccessIn:(UIView * _Nonnull)view with:(NSString * _Nonnull)caption;
		[Export ("showSuccessIn:with:")]
		void ShowSuccessIn (UIView view, string caption);

		// -(void)showSuccessFrom:(UIViewController * _Nonnull)controller with:(NSString * _Nonnull)caption;
		[Export ("showSuccessFrom:with:")]
		void ShowSuccessFrom (UIViewController controller, string caption);

		// -(void)showFailureIn:(UIView * _Nonnull)view with:(NSString * _Nonnull)caption;
		[Export ("showFailureIn:with:")]
		void ShowFailureIn (UIView view, string caption);

		// -(void)showFailureFrom:(UIViewController * _Nonnull)controller with:(NSString * _Nonnull)caption;
		[Export ("showFailureFrom:with:")]
		void ShowFailureFrom (UIViewController controller, string caption);

		// -(void)hideAnimated:(BOOL)animated;
		[Export ("hideAnimated:")]
		void HideAnimated (bool animated);

		// -(void)updateWith:(NSString * _Nonnull)caption;
		[Export ("updateWith:")]
		void UpdateWith (string caption);
	}

	interface IMSFHUDDelegate { }

	// @protocol MSFHUDDelegate
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFHudDelegate)]
	interface MSFHUDDelegate
	{
		// @required -(UIWindow * _Nullable)defaultWindowForHUD:(MSFHUD * _Nonnull)hud __attribute__((warn_unused_result));
		[Abstract]
		[Export ("defaultWindowForHUD:")]
		[return: NullAllowed]
		UIWindow DefaultWindowForHUD (MSFHUD hud);
	}

	// @interface MSFHUDParams : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFHudParams)]
	interface MSFHUDParams
	{
		// @property (copy, nonatomic) NSString * _Nonnull caption;
		[Export ("caption")]
		string Caption { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (nonatomic) BOOL isBlocking;
		[Export ("isBlocking")]
		bool IsBlocking { get; set; }

		// @property (nonatomic) BOOL isPersistent;
		[Export ("isPersistent")]
		bool IsPersistent { get; set; }

		// -(instancetype _Nonnull)initWithCaption:(NSString * _Nonnull)caption image:(UIImage * _Nullable)image isPersistent:(BOOL)isPersistent isBlocking:(BOOL)isBlocking;
		[Export ("initWithCaption:image:isPersistent:isBlocking:")]
		IntPtr Constructor (string caption, [NullAllowed] UIImage image, bool isPersistent, bool isBlocking);
	}

	// @interface MSFLabel : UILabel
	[BaseType (typeof (UILabel), Name = ApiDefinitionConstants.MSFLabel)]
	interface MSFLabel
	{
		// @property (nonatomic) enum MSFTextColorStyle colorStyle;
		[Export ("colorStyle", ArgumentSemantic.Assign)]
		MSFTextColorStyle ColorStyle { get; set; }

		// @property (nonatomic) enum MSFTextStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		MSFTextStyle Style { get; set; }

		// @property (nonatomic) CGFloat maxFontSize;
		[Export ("maxFontSize")]
		nfloat MaxFontSize { get; set; }

		// @property (nonatomic, strong) UIColor * _Null_unspecified textColor;
		[Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// -(instancetype _Nonnull)initWithStyle:(enum MSFTextStyle)style colorStyle:(enum MSFTextColorStyle)colorStyle __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:colorStyle:")]
		[DesignatedInitializer]
		IntPtr Constructor (MSFTextStyle style, MSFTextColorStyle colorStyle);
	}

	// @interface MSFNavigationBar : UINavigationBar
	[BaseType(typeof(UINavigationBar), Name = ApiDefinitionConstants.MSFNavigationBar)]
	interface MSFNavigationBar
	{
		// @property (nonatomic, strong) id<MSFAvatar> _Nullable avatar;
		[NullAllowed, Export ("avatar", ArgumentSemantic.Strong)]
		MSFAvatar Avatar { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable avatarCustomAccessibilityLabel;
		[NullAllowed, Export ("avatarCustomAccessibilityLabel")]
		string AvatarCustomAccessibilityLabel { get; set; }

		// @property (nonatomic) enum MSFNavigationBarElementSize avatarSize;
		[Export ("avatarSize", ArgumentSemantic.Assign)]
		MSFNavigationBarElementSize AvatarSize { get; set; }

		// @property (readonly, nonatomic) enum MSFNavigationBarElementSize barHeight;
		[Export ("barHeight")]
		MSFNavigationBarElementSize BarHeight { get; }

		// @property (nonatomic) enum MSFNavigationBarElementSize titleSize;
		[Export ("titleSize", ArgumentSemantic.Assign)]
		MSFNavigationBarElementSize TitleSize { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onAvatarTapped;
		[NullAllowed, Export ("onAvatarTapped", ArgumentSemantic.Copy)]
		Action OnAvatarTapped { get; set; }

		// @property (nonatomic) CGPoint center;
		[Export ("center", ArgumentSemantic.Assign)]
		CGPoint Center { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
		[Export ("pointInside:withEvent:")]
		bool PointInside (CGPoint point, [NullAllowed] UIEvent @event);

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);
	}

	// @interface MSFNavigationController : UINavigationController
	[BaseType(typeof(UINavigationController), Name = ApiDefinitionConstants.MSFNavigationController)]
	interface MSFNavigationController
	{
		// @property (readonly, nonatomic, strong) MSFNavigationBar * _Nonnull msfNavigationBar;
		[Export ("msfNavigationBar", ArgumentSemantic.Strong)]
		MSFNavigationBar MsfNavigationBar { get; }

		// @property (readonly, nonatomic, strong) UIViewController * _Nullable topContentViewController;
		[NullAllowed, Export ("topContentViewController", ArgumentSemantic.Strong)]
		UIViewController TopContentViewController { get; }

		// @property (readonly, nonatomic, strong) UIViewController * _Nullable childViewControllerForStatusBarStyle;
		[NullAllowed, Export ("childViewControllerForStatusBarStyle", ArgumentSemantic.Strong)]
		UIViewController ChildViewControllerForStatusBarStyle { get; }

		// @property (readonly, nonatomic) UIStatusBarStyle preferredStatusBarStyle;
		[Export ("preferredStatusBarStyle")]
		UIStatusBarStyle PreferredStatusBarStyle { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		UINavigationControllerDelegate Delegate { get; set; }

		// @property (nonatomic, strong) id<UINavigationControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithNavigationBarClass:(Class _Nullable)navigationBarClass toolbarClass:(Class _Nullable)toolbarClass __attribute__((objc_designated_initializer));
		[Export ("initWithNavigationBarClass:toolbarClass:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] Class navigationBarClass, [NullAllowed] Class toolbarClass);

		// -(instancetype _Nonnull)initWithRootViewController:(UIViewController * _Nonnull)rootViewController;
		[Export ("initWithRootViewController:")]
		IntPtr Constructor (UIViewController rootViewController);

		// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewWillLayoutSubviews;
		[Export ("viewWillLayoutSubviews")]
		void ViewWillLayoutSubviews ();

		// -(void)pushViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated;
		[Export ("pushViewController:animated:")]
		void PushViewController (UIViewController viewController, bool animated);

		// -(void)setViewControllers:(NSArray<UIViewController *> * _Nonnull)viewControllers animated:(BOOL)animated;
		[Export ("setViewControllers:animated:")]
		void SetViewControllers (UIViewController[] viewControllers, bool animated);

		// -(void)expandNavigationBarWithAnimated:(BOOL)animated;
		[Export ("expandNavigationBarWithAnimated:")]
		void ExpandNavigationBarWithAnimated (bool animated);

		// -(void)contractNavigationBarWithAnimated:(BOOL)animated;
		[Export ("contractNavigationBarWithAnimated:")]
		void ContractNavigationBarWithAnimated (bool animated);

		// -(UIViewController * _Nonnull)contentViewControllerFor:(UIViewController * _Nonnull)controller __attribute__((warn_unused_result));
		[Export ("contentViewControllerFor:")]
		UIViewController ContentViewControllerFor (UIViewController controller);

		// -(void)setNavigationBarHidden:(BOOL)hidden animated:(BOOL)animated;
		[Export ("setNavigationBarHidden:animated:")]
		void SetNavigationBarHidden (bool hidden, bool animated);
	}

    // @interface MSFNotificationView : UIView
	[BaseType(typeof(UIView), Name = ApiDefinitionConstants.MSFNotificationView)]
	interface MSFNotificationView
	{
		// @property (nonatomic, class) BOOL allowsMultipleToasts;
		[Static]
		[Export ("allowsMultipleToasts")]
		bool AllowsMultipleToasts { get; set; }

		// @property (readonly, nonatomic) BOOL isShown;
		[Export ("isShown")]
		bool IsShown { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(void)initialize;
		[Export ("initialize")]
		void Initialize ();

		// -(instancetype _Nonnull)setupWithStyle:(enum MSFNotificationViewStyle)style title:(NSString * _Nonnull)title message:(NSString * _Nonnull)message image:(UIImage * _Nullable)image actionTitle:(NSString * _Nonnull)actionTitle action:(void (^ _Nullable)(void))action messageAction:(void (^ _Nullable)(void))messageAction;
		[Export ("setupWithStyle:title:message:image:actionTitle:action:messageAction:")]
		MSFNotificationView SetupWithStyle (MSFNotificationViewStyle style, string title, string message, [NullAllowed] UIImage image, string actionTitle, [NullAllowed] Action action, [NullAllowed] Action messageAction);

		// -(void)showIn:(UIView * _Nonnull)view from:(UIView * _Nullable)anchorView animated:(BOOL)animated completion:(void (^ _Nullable)(MSFNotificationView * _Nonnull))completion;
		[Export ("showIn:from:animated:completion:")]
		void ShowIn (UIView view, [NullAllowed] UIView anchorView, bool animated, [NullAllowed] Action<MSFNotificationView> completion);

		// -(void)showFrom:(UIViewController * _Nonnull)controller animated:(BOOL)animated completion:(void (^ _Nullable)(MSFNotificationView * _Nonnull))completion;
		[Export ("showFrom:animated:completion:")]
		void ShowFrom (UIViewController controller, bool animated, [NullAllowed] Action<MSFNotificationView> completion);

		// -(void)hideAfter:(NSTimeInterval)delay animated:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
		[Export ("hideAfter:animated:completion:")]
		void HideAfter (double delay, bool animated, [NullAllowed] Action completion);

		// -(void)safeAreaInsetsDidChange;
		[Export ("safeAreaInsetsDidChange")]
		void SafeAreaInsetsDidChange ();
	}

	// @interface MSFPageCardPresenterController : UIViewController
	[BaseType(typeof(UIViewController), Name = ApiDefinitionConstants.MSFPageCardPresenterController)]
	interface MSFPageCardPresenterController
	{
		// @property (nonatomic) UIModalPresentationStyle modalPresentationStyle;
		[Export ("modalPresentationStyle", ArgumentSemantic.Assign)]
		UIModalPresentationStyle ModalPresentationStyle { get; set; }

		[Wrap ("WeakTransitioningDelegate")]
		[NullAllowed]
		UIViewControllerTransitioningDelegate TransitioningDelegate { get; set; }

		// @property (nonatomic, strong) id<UIViewControllerTransitioningDelegate> _Nullable transitioningDelegate;
		[NullAllowed, Export ("transitioningDelegate", ArgumentSemantic.Strong)]
		NSObject WeakTransitioningDelegate { get; set; }

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewWillAppear:(BOOL)animated;
		[Export ("viewWillAppear:")]
		void ViewWillAppear (bool animated);

		// -(void)viewWillLayoutSubviews;
		[Export ("viewWillLayoutSubviews")]
		void ViewWillLayoutSubviews ();
	}

    // @interface MSFPeoplePicker : MSFBadgeField
	[BaseType(typeof(MSFBadgeField), Name = ApiDefinitionConstants.MSFPeoplePicker)]
	interface MSFPeoplePicker
	{
		// @property (copy, nonatomic) NSArray<id<MSFPersona>> * _Nonnull availablePersonas;
		[Export ("availablePersonas", ArgumentSemantic.Copy)]
		MSFPersona[] AvailablePersonas { get; set; }

		// @property (copy, nonatomic) NSArray<id<MSFPersona>> * _Nonnull pickedPersonas;
		[Export ("pickedPersonas", ArgumentSemantic.Copy)]
		MSFPersona[] PickedPersonas { get; set; }

		// @property (nonatomic) BOOL showsSearchDirectoryButton;
		[Export ("showsSearchDirectoryButton")]
		bool ShowsSearchDirectoryButton { get; set; }

		// @property (nonatomic) BOOL allowsPickedPersonasToAppearAsSuggested;
		[Export ("allowsPickedPersonasToAppearAsSuggested")]
		bool AllowsPickedPersonasToAppearAsSuggested { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFPeoplePickerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFPeoplePickerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(MSFBadgeView * _Nullable)badgeFor:(id<MSFPersona> _Nonnull)persona __attribute__((warn_unused_result));
		[Export ("badgeFor:")]
		[return: NullAllowed]
		MSFBadgeView BadgeFor (MSFPersona persona);

		// -(void)willMoveToWindow:(UIWindow * _Nullable)newWindow;
		[Export ("willMoveToWindow:")]
		void WillMoveToWindow ([NullAllowed] UIWindow newWindow);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)badgeText;
		[Export ("badgeText")]
		void BadgeText ();

		// -(void)addBadgeWithDataSource:(MSFBadgeViewDataSource * _Nonnull)dataSource fromUserAction:(BOOL)fromUserAction updateConstrainedBadges:(BOOL)updateConstrainedBadges;
		[Export ("addBadgeWithDataSource:fromUserAction:updateConstrainedBadges:")]
		void AddBadgeWithDataSource (MSFBadgeViewDataSource dataSource, bool fromUserAction, bool updateConstrainedBadges);

		// -(void)resetTextFieldContent;
		[Export ("resetTextFieldContent")]
		void ResetTextFieldContent ();

		// -(void)textFieldDidEndEditing:(UITextField * _Nonnull)textField;
		[Export ("textFieldDidEndEditing:")]
		void TextFieldDidEndEditing (UITextField textField);

		// -(void)didSelectBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("didSelectBadge:")]
		void DidSelectBadge (MSFBadgeView badge);

		// -(void)didTapSelectedBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("didTapSelectedBadge:")]
		void DidTapSelectedBadge (MSFBadgeView badge);
	}

	interface IMSFPersonaListViewSearchDirectoryDelegate { }

	// @protocol MSFPersonaListViewSearchDirectoryDelegate
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFPersonaListViewSearchDirectoryDelegate)]
	interface MSFPersonaListViewSearchDirectoryDelegate
	{
		// @required -(void)personaListSearchDirectory:(MSFPersonaListView * _Nonnull)personaListView completion:(void (^ _Nonnull)(BOOL))completion;
		[Abstract]
		[Export ("personaListSearchDirectory:completion:")]
		void Completion (MSFPersonaListView personaListView, Action<bool> completion);
	}

	interface IMSFPeoplePickerDelegate { }

	// @protocol MSFPeoplePickerDelegate <MSFBadgeFieldDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFPeoplePickerDelegate)]
	interface MSFPeoplePickerDelegate : MSFBadgeFieldDelegate
	{
		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker getSuggestedPersonasForText:(NSString * _Nonnull)text completion:(void (^ _Nonnull)(NSArray<id<MSFPersona>> * _Nonnull))completion;
		//[Export ("peoplePicker:getSuggestedPersonasForText:completion:")]
		//void GetSuggestedPersonasForText(MSFPeoplePicker peoplePicker, string text, Action<NSArray<MSFPersona>> completion);

		// @optional -(BOOL)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker shouldPickPersona:(id<MSFPersona> _Nonnull)persona __attribute__((warn_unused_result));
		[Export ("peoplePicker:shouldPickPersona:")]
		bool ShouldPickPersona (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker didPickPersona:(id<MSFPersona> _Nonnull)persona;
		[Export ("peoplePicker:didPickPersona:")]
		void DidPickPersona (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(id<MSFPersona> _Nonnull)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker personaFromText:(NSString * _Nonnull)text __attribute__((warn_unused_result));
		[Export ("peoplePicker:personaFromText:")]
		MSFPersona PersonaFromText (MSFPeoplePicker peoplePicker, string text);

		// @optional -(BOOL)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker personaIsValid:(id<MSFPersona> _Nonnull)persona __attribute__((warn_unused_result));
		[Export ("peoplePicker:personaIsValid:")]
		bool PersonaIsValid (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker didSelectPersona:(id<MSFPersona> _Nonnull)persona;
		[Export ("peoplePicker:didSelectPersona:")]
		void DidSelect (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker didTapSelectedPersona:(id<MSFPersona> _Nonnull)persona;
		[Export ("peoplePicker:didTapSelectedPersona:")]
		void DidTapSelectedPersona (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker didRemovePersona:(id<MSFPersona> _Nonnull)persona;
		[Export ("peoplePicker:didRemovePersona:")]
		void DidRemovePersona (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker searchDirectoryWithCompletion:(void (^ _Nonnull)(NSArray<id<MSFPersona>> * _Nonnull, BOOL))completion;
		//[Export ("peoplePicker:searchDirectoryWithCompletion:")]
		//void SearchDirectoryWithCompletion (MSFPeoplePicker peoplePicker, Action<NSArray<MSFPersona>, bool> completion);
	}
	
	public interface IMSFPersona { }

	// @protocol MSFPersona <MSFAvatar>
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFPersona)]
	interface MSFPersona
	{
		// @required @property (readonly, nonatomic, strong) UIImage * _Nullable avatarImage;
		[Abstract]
		[NullAllowed, Export ("avatarImage", ArgumentSemantic.Strong)]
		UIImage AvatarImage { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull email;
		[Abstract]
		[Export ("email")]
		string Email { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Abstract]
		[Export ("name")]
		string Name { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull subtitle;
		[Abstract]
		[Export ("subtitle")]
		string Subtitle { get; }
	}

	// @interface MSFPersonaBadgeViewDataSource : MSFBadgeViewDataSource
	[BaseType(typeof(MSFBadgeViewDataSource), Name = ApiDefinitionConstants.MSFPersonaBadgeViewDataSource)]
	interface MSFPersonaBadgeViewDataSource
	{
		// @property (nonatomic, strong) id<MSFPersona> _Nonnull persona;
		[Export ("persona", ArgumentSemantic.Strong)]
		MSFPersona Persona { get; set; }

		// -(instancetype _Nonnull)initWithPersona:(id<MSFPersona> _Nonnull)persona style:(enum MSFBadgeViewStyle)style size:(enum MSFBadgeViewSize)size __attribute__((objc_designated_initializer));
		[Export ("initWithPersona:style:size:")]
		[DesignatedInitializer]
		IntPtr Constructor (MSFPersona persona, MSFBadgeViewStyle style, MSFBadgeViewSize size);
	}

	// @interface MSFPersonaCell : MSFTableViewCell
	[BaseType(typeof(MSFTableViewCell), Name = ApiDefinitionConstants.MSFPersonaCell)]
	interface MSFPersonaCell
	{
		// @property (nonatomic) enum MSFTableViewCellCustomViewSize customViewSize;
		[Export ("customViewSize", ArgumentSemantic.Assign)]
		MSFTableViewCellCustomViewSize CustomViewSize { get; set; }

		// -(void)setupWithPersona:(id<MSFPersona> _Nonnull)persona accessoryType:(enum MSFTableViewCellAccessoryType)accessoryType;
		[Export ("setupWithPersona:accessoryType:")]
		void SetupWithPersona (MSFPersona persona, MSFTableViewCellAccessoryType accessoryType);

		// -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:reuseIdentifier:")]
		[DesignatedInitializer]
		IntPtr Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);
	}

	// @interface MSFPersonaData : NSObject <MSFPersona>
	[BaseType (typeof (NSObject), Name = ApiDefinitionConstants.MSFPersonaData)]
	[DisableDefaultCtor]
	interface MSFPersonaData : IMSFPersona
	{
		// @property (nonatomic, strong) UIImage * _Nullable avatarImage;
		[NullAllowed, Export ("avatarImage", ArgumentSemantic.Strong)]
		UIImage AvatarImage { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull email;
		[Export ("email")]
		string Email { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull subtitle;
		[Export ("subtitle")]
		string Subtitle { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull primaryText;
		[Export ("primaryText")]
		string PrimaryText { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull secondaryText;
		[Export ("secondaryText")]
		string SecondaryText { get; }

		// @property (readonly, nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name email:(NSString * _Nonnull)email subtitle:(NSString * _Nonnull)subtitle avatarImage:(UIImage * _Nullable)avatarImage __attribute__((objc_designated_initializer));
		[Export ("initWithName:email:subtitle:avatarImage:")]
		[DesignatedInitializer]
		IntPtr Constructor (string name, string email, string subtitle, [NullAllowed] UIImage avatarImage);
	}

	// @interface MSFPersonaListView : UITableView
	[BaseType (typeof (UITableView), Name = ApiDefinitionConstants.MSFPersonaListView)]
	interface MSFPersonaListView
	{
		// @property (copy, nonatomic) NSArray<id<MSFPersona>> * _Nonnull personaList;
		[Export ("personaList", ArgumentSemantic.Copy)]
		MSFPersona[] PersonaList { get; set; }

		// @property (nonatomic) enum MSFTableViewCellAccessoryType accessoryType;
		[Export ("accessoryType", ArgumentSemantic.Assign)]
		MSFTableViewCellAccessoryType AccessoryType { get; set; }

		// @property (nonatomic) BOOL showsSearchDirectoryButton;
		[Export ("showsSearchDirectoryButton")]
		bool ShowsSearchDirectoryButton { get; set; }

		[Wrap ("WeakSearchDirectoryDelegate")]
		[NullAllowed]
		MSFPersonaListViewSearchDirectoryDelegate SearchDirectoryDelegate { get; set; }

		// @property (nonatomic, weak) id<MSFPersonaListViewSearchDirectoryDelegate> _Nullable searchDirectoryDelegate;
		[NullAllowed, Export ("searchDirectoryDelegate", ArgumentSemantic.Weak)]
		NSObject WeakSearchDirectoryDelegate { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(id<MSFPersona> _Nonnull) onPersonaSelected;
		[NullAllowed, Export ("onPersonaSelected", ArgumentSemantic.Copy)]
		Action<MSFPersona> OnPersonaSelected { get; set; }

		// -(void)pickPersona;
		[Export ("pickPersona")]
		void PickPersona ();

		// -(void)selectPersonaWithDirection:(enum MSFPersonaListViewSelectionDirection)direction;
		[Export ("selectPersonaWithDirection:")]
		void SelectPersonaWithDirection (MSFPersonaListViewSelectionDirection direction);
	}

    // @interface MSFPillButton : UIButton
	[BaseType (typeof(UIButton), Name = ApiDefinitionConstants.MSFPillButton)]
	interface MSFPillButton
	{
		// @property (readonly, nonatomic, strong) MSFPillButtonBarItem * _Nonnull pillBarItem;
		[Export ("pillBarItem", ArgumentSemantic.Strong)]
		MSFPillButtonBarItem PillBarItem { get; }

		// @property (readonly, nonatomic) enum MSFPillButtonStyle style;
		[Export ("style")]
		MSFPillButtonStyle Style { get; }

		// @property (getter = isSelected, nonatomic) BOOL selected;
		[Export ("selected")]
		bool Selected { [Bind ("isSelected")] get; set; }

		// -(instancetype _Nonnull)initWithPillBarItem:(MSFPillButtonBarItem * _Nonnull)pillBarItem style:(enum MSFPillButtonStyle)style __attribute__((objc_designated_initializer));
		[Export ("initWithPillBarItem:style:")]
		[DesignatedInitializer]
		IntPtr Constructor (MSFPillButtonBarItem pillBarItem, MSFPillButtonStyle style);
	}

	// @interface MSFPillButtonBar : UIScrollView
	[BaseType (typeof(UIScrollView), Name = ApiDefinitionConstants.MSFPillButtonBar)]
	interface MSFPillButtonBar
	{
		[Wrap ("WeakBarDelegate")]
		[NullAllowed]
		MSFPillButtonBarDelegate BarDelegate { get; set; }

		// @property (nonatomic, weak) id<MSFPillButtonBarDelegate> _Nullable barDelegate;
		[NullAllowed, Export ("barDelegate", ArgumentSemantic.Weak)]
		NSObject WeakBarDelegate { get; set; }

		// @property (nonatomic) BOOL centerAligned;
		[Export ("centerAligned")]
		bool CenterAligned { get; set; }

		// @property (copy, nonatomic) NSArray<MSFPillButtonBarItem *> * _Nullable items;
		[NullAllowed, Export ("items", ArgumentSemantic.Copy)]
		MSFPillButtonBarItem[] Items { get; set; }

		// @property (readonly, nonatomic) enum MSFPillButtonStyle pillButtonStyle;
		[Export ("pillButtonStyle")]
		MSFPillButtonStyle PillButtonStyle { get; }

		// @property (nonatomic, strong) MSFPillButtonBarItem * _Nullable selectedItem;
		[NullAllowed, Export ("selectedItem", ArgumentSemantic.Strong)]
		MSFPillButtonBarItem SelectedItem { get; set; }

		// @property (nonatomic) CGRect bounds;
		[Export ("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// -(instancetype _Nonnull)initWithPillButtonStyle:(enum MSFPillButtonStyle)pillButtonStyle __attribute__((objc_designated_initializer));
		[Export ("initWithPillButtonStyle:")]
		[DesignatedInitializer]
		IntPtr Constructor (MSFPillButtonStyle pillButtonStyle);

		// -(void)selectItem:(MSFPillButtonBarItem * _Nonnull)item;
		[Export ("selectItem:")]
		void SelectItem (MSFPillButtonBarItem item);

		// -(BOOL)selectItemAtIndex:(NSInteger)index __attribute__((warn_unused_result));
		[Export ("selectItemAtIndex:")]
		bool SelectItemAtIndex (nint index);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();
	}

	interface IMSFPillButtonBarDelegate { }

	// @protocol MSFPillButtonBarDelegate
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFPillButtonBarDelegate)]
	[Protocol, Model]
	interface MSFPillButtonBarDelegate
	{
		// @optional -(void)pillBar:(MSFPillButtonBar * _Nonnull)pillBar didSelectItem:(MSFPillButtonBarItem * _Nonnull)item atIndex:(NSInteger)index;
		[Export ("pillBar:didSelectItem:atIndex:")]
		void DidSelectItem (MSFPillButtonBar pillBar, MSFPillButtonBarItem item, nint index);
	}

	// @interface MSFPillButtonBarItem : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFPillButtonBarItem)]
	[DisableDefaultCtor]
	interface MSFPillButtonBarItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:")]
		[DesignatedInitializer]
		IntPtr Constructor (string title);
	}

	// @interface MSFPopupMenuController : MSFDrawerController
	[BaseType (typeof (MSFDrawerController), Name = ApiDefinitionConstants.MSFPopupMenuController)]
	interface MSFPopupMenuController
	{
		// @property (nonatomic, strong) UIView * _Nullable contentView;
		[NullAllowed, Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }

		// @property (nonatomic) enum MSFDrawerPresentationStyle presentationStyle;
		[Export ("presentationStyle", ArgumentSemantic.Assign)]
		MSFDrawerPresentationStyle PresentationStyle { get; set; }

		// @property (nonatomic) enum MSFDrawerResizingBehavior resizingBehavior;
		[Export ("resizingBehavior", ArgumentSemantic.Assign)]
		MSFDrawerResizingBehavior ResizingBehavior { get; set; }

		// @property (nonatomic) CGSize preferredContentSize;
		[Export ("preferredContentSize", ArgumentSemantic.Assign)]
		CGSize PreferredContentSize { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) MSFPopupMenuItem * _Nullable headerItem;
		[NullAllowed, Export ("headerItem", ArgumentSemantic.Strong)]
		MSFPopupMenuItem HeaderItem { get; set; }

		// @property (copy, nonatomic) NSIndexPath * _Nullable selectedItemIndexPath;
		[NullAllowed, Export ("selectedItemIndexPath", ArgumentSemantic.Copy)]
		NSIndexPath SelectedItemIndexPath { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull separatorColor;
		[Export ("separatorColor", ArgumentSemantic.Strong)]
		UIColor SeparatorColor { get; set; }

		// -(void)addItems:(NSArray<MSFPopupMenuItem *> * _Nonnull)items;
		[Export ("addItems:")]
		void AddItems (MSFPopupMenuItem[] items);

		// -(void)addSection:(MSFPopupMenuSection * _Nonnull)section;
		[Export ("addSection:")]
		void AddSection (MSFPopupMenuSection section);

		// -(void)addSections:(NSArray<MSFPopupMenuSection *> * _Nonnull)sections;
		[Export ("addSections:")]
		void AddSections (MSFPopupMenuSection[] sections);

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewWillAppear:(BOOL)animated;
		[Export ("viewWillAppear:")]
		void ViewWillAppear (bool animated);

		// -(void)viewDidLayoutSubviews;
		[Export ("viewDidLayoutSubviews")]
		void ViewDidLayoutSubviews ();

		// -(instancetype _Nonnull)initWithSourceView:(UIView * _Nonnull)sourceView sourceRect:(CGRect)sourceRect presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSFDrawerPresentationDirection)presentationDirection __attribute__((objc_designated_initializer));
		[Export ("initWithSourceView:sourceRect:presentationOrigin:presentationDirection:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIView sourceView, CGRect sourceRect, nfloat presentationOrigin, MSFDrawerPresentationDirection presentationDirection);

		// -(instancetype _Nonnull)initWithBarButtonItem:(UIBarButtonItem * _Nonnull)barButtonItem presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSFDrawerPresentationDirection)presentationDirection __attribute__((objc_designated_initializer));
		[Export ("initWithBarButtonItem:presentationOrigin:presentationDirection:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIBarButtonItem barButtonItem, nfloat presentationOrigin, MSFDrawerPresentationDirection presentationDirection);
	}

	// @interface MSFPopupMenuItem : NSObject
	[BaseType (typeof (NSObject), Name = ApiDefinitionConstants.MSFPopupMenuItem)]
	[DisableDefaultCtor]
	interface MSFPopupMenuItem
	{
		// @property (readonly, nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; }

		// @property (readonly, nonatomic, strong) UIImage * _Nullable selectedImage;
		[NullAllowed, Export ("selectedImage", ArgumentSemantic.Strong)]
		UIImage SelectedImage { get; }

		// @property (readonly, nonatomic, strong) UIImage * _Nullable accessoryImage;
		[NullAllowed, Export ("accessoryImage", ArgumentSemantic.Strong)]
		UIImage AccessoryImage { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable subtitle;
		[NullAllowed, Export ("subtitle")]
		string Subtitle { get; }

		// @property (readonly, nonatomic, strong) UIView * _Nullable accessoryView;
		[NullAllowed, Export ("accessoryView", ArgumentSemantic.Strong)]
		UIView AccessoryView { get; }

		// @property (readonly, nonatomic) enum MSFPopupMenuItemExecutionMode executionMode;
		[Export ("executionMode")]
		MSFPopupMenuItemExecutionMode ExecutionMode { get; }

		// @property (nonatomic) BOOL isEnabled;
		[Export ("isEnabled")]
		bool IsEnabled { get; set; }

		// @property (nonatomic) BOOL isSelected;
		[Export ("isSelected")]
		bool IsSelected { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull titleColor;
		[Export ("titleColor", ArgumentSemantic.Strong)]
		UIColor TitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull subtitleColor;
		[Export ("subtitleColor", ArgumentSemantic.Strong)]
		UIColor SubtitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull imageColor;
		[Export ("imageColor", ArgumentSemantic.Strong)]
		UIColor ImageColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull titleSelectedColor;
		[Export ("titleSelectedColor", ArgumentSemantic.Strong)]
		UIColor TitleSelectedColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull subtitleSelectedColor;
		[Export ("subtitleSelectedColor", ArgumentSemantic.Strong)]
		UIColor SubtitleSelectedColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull imageSelectedColor;
		[Export ("imageSelectedColor", ArgumentSemantic.Strong)]
		UIColor ImageSelectedColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull accessoryCheckmarkColor;
		[Export ("accessoryCheckmarkColor", ArgumentSemantic.Strong)]
		UIColor AccessoryCheckmarkColor { get; set; }

		// @property (readonly, copy, nonatomic) void (^ _Nullable)(void) onSelected;
		[NullAllowed, Export ("onSelected", ArgumentSemantic.Copy)]
		Action OnSelected { get; }

		// @property (readonly, nonatomic) BOOL isAccessoryCheckmarkVisible;
		[Export ("isAccessoryCheckmarkVisible")]
		bool IsAccessoryCheckmarkVisible { get; }

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nullable)image selectedImage:(UIImage * _Nullable)selectedImage accessoryImage:(UIImage * _Nullable)accessoryImage title:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle accessoryView:(UIView * _Nullable)accessoryView isEnabled:(BOOL)isEnabled isSelected:(BOOL)isSelected executes:(enum MSFPopupMenuItemExecutionMode)executionMode onSelected:(void (^ _Nullable)(void))onSelected isAccessoryCheckmarkVisible:(BOOL)isAccessoryCheckmarkVisible __attribute__((objc_designated_initializer));
		[Export ("initWithImage:selectedImage:accessoryImage:title:subtitle:accessoryView:isEnabled:isSelected:executes:onSelected:isAccessoryCheckmarkVisible:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIImage image, [NullAllowed] UIImage selectedImage, [NullAllowed] UIImage accessoryImage, string title, [NullAllowed] string subtitle, [NullAllowed] UIView accessoryView, bool isEnabled, bool isSelected, MSFPopupMenuItemExecutionMode executionMode, [NullAllowed] Action onSelected, bool isAccessoryCheckmarkVisible);

		// -(instancetype _Nonnull)initWithImageName:(NSString * _Nonnull)imageName generateSelectedImage:(BOOL)generateSelectedImage title:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle isEnabled:(BOOL)isEnabled isSelected:(BOOL)isSelected executes:(enum MSFPopupMenuItemExecutionMode)executionMode onSelected:(void (^ _Nullable)(void))onSelected isAccessoryCheckmarkVisible:(BOOL)isAccessoryCheckmarkVisible;
		[Export ("initWithImageName:generateSelectedImage:title:subtitle:isEnabled:isSelected:executes:onSelected:isAccessoryCheckmarkVisible:")]
		IntPtr Constructor (string imageName, bool generateSelectedImage, string title, [NullAllowed] string subtitle, bool isEnabled, bool isSelected, MSFPopupMenuItemExecutionMode executionMode, [NullAllowed] Action onSelected, bool isAccessoryCheckmarkVisible);
	}

	// @interface MSFPopupMenuSection : NSObject
	[BaseType (typeof (NSObject), Name = ApiDefinitionConstants.MSFPopupMenuSection)]
	[DisableDefaultCtor]
	interface MSFPopupMenuSection
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; }

		// @property (copy, nonatomic) NSArray<MSFPopupMenuItem *> * _Nonnull items;
		[Export ("items", ArgumentSemantic.Copy)]
		MSFPopupMenuItem[] Items { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title items:(NSArray<MSFPopupMenuItem *> * _Nonnull)items __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:items:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string title, MSFPopupMenuItem[] items);
	}

	// @interface MSFResizingHandleView : UIView
	[BaseType (typeof (UIView), Name = ApiDefinitionConstants.MSFResizingHandleView)]
	interface MSFResizingHandleView
	{
		// @property (readonly, nonatomic, class) CGFloat height;
		[Static]
		[Export ("height")]
		nfloat Height { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();
	}

	// @interface MSFScrollView : UIScrollView
	//[Unavailable (PlatformName.iOSAppExtension)]
	[BaseType(typeof(UIScrollView), Name = ApiDefinitionConstants.MSFScrollView)]
	interface MSFScrollView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
		// @property (nonatomic) CGSize contentSize;
		[Export ("contentSize", ArgumentSemantic.Assign)]
		CGSize ContentSize { get; set; }

		// -(void)prepareForInterfaceBuilder;
		[Export ("prepareForInterfaceBuilder")]
		void PrepareForInterfaceBuilder ();
	}

	// @interface MSFSearchBar : UIView
	[BaseType(typeof(UIView), Name = ApiDefinitionConstants.MSFSearchBar)]
	interface MSFSearchBar
	{
		// @property (nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholderText;
		[NullAllowed, Export ("placeholderText")]
		string PlaceholderText { get; set; }

		// @property (nonatomic) enum MSFSearchBarStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		MSFSearchBarStyle Style { get; set; }

		// @property (readonly, nonatomic) BOOL isActive;
		[Export ("isActive")]
		bool IsActive { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFSearchBarDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFSearchBarDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(void)cancelSearch;
		[Export ("cancelSearch")]
		void CancelSearch ();

		// @property (copy, nonatomic) NSString * _Nullable searchText;
		[NullAllowed, Export ("searchText")]
		string SearchText { get; set; }

		// -(BOOL)becomeFirstResponder __attribute__((warn_unused_result));
		[Export ("becomeFirstResponder")]
		bool BecomeFirstResponder { get; }

		// -(BOOL)resignFirstResponder __attribute__((warn_unused_result));
		[Export ("resignFirstResponder")]
		bool ResignFirstResponder { get; }

		// @property (readonly, nonatomic) BOOL isFirstResponder;
		[Export ("isFirstResponder")]
		bool IsFirstResponder { get; }
	}

	interface IMSFSearchBarDelegate { }

	// @protocol MSFSearchBarDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFSearchBarDelegate)]
	interface MSFSearchBarDelegate
	{
		// @required -(void)searchBarDidBeginEditing:(MSFSearchBar * _Nonnull)searchBar;
		[Abstract]
		[Export ("searchBarDidBeginEditing:")]
		void SearchBarDidBeginEditing (MSFSearchBar searchBar);

		// @required -(void)searchBar:(MSFSearchBar * _Nonnull)searchBar didUpdateSearchText:(NSString * _Nullable)newSearchText;
		[Abstract]
		[Export ("searchBar:didUpdateSearchText:")]
		void SearchBar (MSFSearchBar searchBar, [NullAllowed] string newSearchText);

		// @optional -(void)searchBarDidFinishEditing:(MSFSearchBar * _Nonnull)searchBar;
		[Export ("searchBarDidFinishEditing:")]
		void SearchBarDidFinishEditing (MSFSearchBar searchBar);

		// @required -(void)searchBarDidCancel:(MSFSearchBar * _Nonnull)searchBar;
		[Abstract]
		[Export ("searchBarDidCancel:")]
		void SearchBarDidCancel (MSFSearchBar searchBar);

		// @optional -(void)searchBarDidRequestSearch:(MSFSearchBar * _Nonnull)searchBar;
		[Export ("searchBarDidRequestSearch:")]
		void SearchBarDidRequestSearch (MSFSearchBar searchBar);
	}

	// @interface MSFSegmentedControl : UIControl
	[BaseType (typeof (UIControl), Name = ApiDefinitionConstants.MSFSegmentedControl)]
	interface MSFSegmentedControl
	{
		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (nonatomic) BOOL isAnimated;
		[Export ("isAnimated")]
		bool IsAnimated { get; set; }

		// @property (readonly, nonatomic) NSInteger numberOfSegments;
		[Export ("numberOfSegments")]
		nint NumberOfSegments { get; }

		// @property (nonatomic) NSInteger selectedSegmentIndex;
		[Export ("selectedSegmentIndex")]
		nint SelectedSegmentIndex { get; set; }

		// -(instancetype _Nonnull)initWithItems:(NSArray<NSString *> * _Nonnull)items style:(enum MSFSegmentedControlStyle)style __attribute__((objc_designated_initializer));
		[Export ("initWithItems:style:")]
		[DesignatedInitializer]
		IntPtr Constructor (string[] items, MSFSegmentedControlStyle style);

		// -(void)insertSegmentWithTitle:(NSString * _Nonnull)title at:(NSInteger)index;
		[Export ("insertSegmentWithTitle:at:")]
		void InsertSegmentWithTitle (string title, nint index);

		// -(void)removeSegmentAt:(NSInteger)index;
		[Export ("removeSegmentAt:")]
		void RemoveSegmentAt (nint index);

		// -(void)selectSegmentAt:(NSInteger)index animated:(BOOL)animated;
		[Export ("selectSegmentAt:animated:")]
		void SelectSegmentAt (nint index, bool animated);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);
	}

	// @interface MSFSeparator : UIView
	[BaseType (typeof (UIView), Name = ApiDefinitionConstants.MSFSeparator)]
	interface MSFSeparator
	{
		// -(instancetype _Nonnull)initWithStyle:(enum MSFSeparatorStyle)style orientation:(enum MSFSeparatorOrientation)orientation __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:orientation:")]
		[DesignatedInitializer]
		IntPtr Constructor (MSFSeparatorStyle style, MSFSeparatorOrientation orientation);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);
	}

	// @interface MSFShimmerAppearance : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFShimmerAppearance)]
	[DisableDefaultCtor]
	interface MSFShimmerAppearance
	{
		// @property (readonly, nonatomic) CGFloat alpha;
		[Export ("alpha")]
		nfloat Alpha { get; }

		// @property (readonly, nonatomic) CGFloat width;
		[Export ("width")]
		nfloat Width { get; }

		// @property (readonly, nonatomic) CGFloat angle;
		[Export ("angle")]
		nfloat Angle { get; }

		// @property (readonly, nonatomic) CGFloat speed;
		[Export ("speed")]
		nfloat Speed { get; }

		// @property (readonly, nonatomic) NSTimeInterval delay;
		[Export ("delay")]
		double Delay { get; }

		// -(instancetype _Nonnull)initWithAlpha:(CGFloat)alpha width:(CGFloat)width angle:(CGFloat)angle speed:(CGFloat)speed delay:(NSTimeInterval)delay __attribute__((objc_designated_initializer));
		[Export ("initWithAlpha:width:angle:speed:delay:")]
		[DesignatedInitializer]
		IntPtr Constructor (nfloat alpha, nfloat width, nfloat angle, nfloat speed, double delay);
	}

	// @interface MSFShimmerView : UIView
	[BaseType(typeof(UIView), Name = ApiDefinitionConstants.MSFShimmerView)]
	interface MSFShimmerView
	{
		// @property (nonatomic, strong) MSFShimmerAppearance * _Nonnull shimmerAppearance;
		[Export ("shimmerAppearance", ArgumentSemantic.Strong)]
		MSFShimmerAppearance ShimmerAppearance { get; set; }

		// @property (nonatomic, strong) MSFShimmerViewAppearence * _Nonnull appearance;
		//[Export ("appearance", ArgumentSemantic.Strong)]
		//MSFShimmerViewAppearence Appearance { get; set; }

		// @property (nonatomic, weak) id<MSFAnimationSynchronizerProtocol> _Nullable animationSynchronizer;
		[NullAllowed, Export ("animationSynchronizer", ArgumentSemantic.Weak)]
		IMSFAnimationSynchronizerProtocol AnimationSynchronizer { get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(instancetype _Nonnull)initWithContainerView:(UIView * _Nullable)containerView excludedViews:(NSArray<UIView *> * _Nonnull)excludedViews animationSynchronizer:(id<MSFAnimationSynchronizerProtocol> _Nullable)animationSynchronizer __attribute__((objc_designated_initializer));
		[Export ("initWithContainerView:excludedViews:animationSynchronizer:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIView containerView, UIView[] excludedViews, [NullAllowed] IMSFAnimationSynchronizerProtocol animationSynchronizer);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)syncAnimation;
		[Export ("syncAnimation")]
		void SyncAnimation ();
	}

	// @interface MSFShimmerLinesView : MSFShimmerView
	[BaseType(typeof(MSFShimmerView), Name = ApiDefinitionConstants.MSFShimmerLinesView)]
	interface MSFShimmerLinesView
	{
		// +(CGSize)sizeThatFits:(CGSize)size appearance:(MSFShimmerLinesViewAppearance * _Nonnull)appearance __attribute__((warn_unused_result));
		[Static]
		[Export ("sizeThatFits:appearance:")]
		CGSize SizeThatFits (CGSize size, MSFShimmerLinesViewAppearance appearance);

		// @property (nonatomic, strong) MSFShimmerLinesViewAppearance * _Nonnull shimmerLinesViewAppearance;
		[Export ("shimmerLinesViewAppearance", ArgumentSemantic.Strong)]
		MSFShimmerLinesViewAppearance ShimmerLinesViewAppearance { get; set; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(instancetype _Nonnull)initWithContainerView:(UIView * _Nullable)containerView excludedViews:(NSArray<UIView *> * _Nonnull)excludedViews animationSynchronizer:(id<MSFAnimationSynchronizerProtocol> _Nullable)animationSynchronizer __attribute__((objc_designated_initializer));
		[Export ("initWithContainerView:excludedViews:animationSynchronizer:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIView containerView, UIView[] excludedViews, [NullAllowed] IMSFAnimationSynchronizerProtocol animationSynchronizer);
	}

	// @interface MSFShimmerLinesViewAppearance : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFShimmerLinesViewAppearance)]
	[DisableDefaultCtor]
	interface MSFShimmerLinesViewAppearance
	{
		// @property (readonly, nonatomic) NSInteger lineCount;
		[Export ("lineCount")]
		nint LineCount { get; }

		// @property (readonly, nonatomic) CGFloat lineHeight;
		[Export ("lineHeight")]
		nfloat LineHeight { get; }

		// @property (readonly, nonatomic) CGFloat lineSpacing;
		[Export ("lineSpacing")]
		nfloat LineSpacing { get; }

		// @property (readonly, nonatomic) CGFloat firstLineFillPercent;
		[Export ("firstLineFillPercent")]
		nfloat FirstLineFillPercent { get; }

		// @property (readonly, nonatomic) CGFloat lastLineFillPercent;
		[Export ("lastLineFillPercent")]
		nfloat LastLineFillPercent { get; }

		// -(instancetype _Nonnull)initWithLineCount:(NSInteger)lineCount lineHeight:(CGFloat)lineHeight lineSpacing:(CGFloat)lineSpacing firstLineFillPercent:(CGFloat)firstLineFillPercent lastLineFillPercent:(CGFloat)lastLineFillPercent __attribute__((objc_designated_initializer));
		[Export ("initWithLineCount:lineHeight:lineSpacing:firstLineFillPercent:lastLineFillPercent:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint lineCount, nfloat lineHeight, nfloat lineSpacing, nfloat firstLineFillPercent, nfloat lastLineFillPercent);
	}

	// @interface MSFShimmerViewAppearence : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFShimmerViewAppearence)]
	[DisableDefaultCtor]
	interface MSFShimmerViewAppearence
	{
		// @property (readonly, nonatomic, strong) UIColor * _Nonnull tintColor;
		[Export ("tintColor", ArgumentSemantic.Strong)]
		UIColor TintColor { get; }

		// @property (readonly, nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; }

		// @property (readonly, nonatomic) CGFloat labelCornerRadius;
		[Export ("labelCornerRadius")]
		nfloat LabelCornerRadius { get; }

		// @property (readonly, nonatomic) BOOL usesTextHeightForLabels;
		[Export ("usesTextHeightForLabels")]
		bool UsesTextHeightForLabels { get; }

		// @property (readonly, nonatomic) CGFloat labelHeight;
		[Export ("labelHeight")]
		nfloat LabelHeight { get; }

		// -(instancetype _Nonnull)initWithTintColor:(UIColor * _Nonnull)tintColor cornerRadius:(CGFloat)cornerRadius labelCornerRadius:(CGFloat)labelCornerRadius usesTextHeightForLabels:(BOOL)usesTextHeightForLabels labelHeight:(CGFloat)labelHeight __attribute__((objc_designated_initializer));
		[Export ("initWithTintColor:cornerRadius:labelCornerRadius:usesTextHeightForLabels:labelHeight:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIColor tintColor, nfloat cornerRadius, nfloat labelCornerRadius, bool usesTextHeightForLabels, nfloat labelHeight);
	}

	// @interface MSFTabBarItem : NSObject
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFTabBarItem)]
	[DisableDefaultCtor]
	interface MSFTabBarItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title image:(UIImage * _Nonnull)image selectedImage:(UIImage * _Nullable)selectedImage landscapeImage:(UIImage * _Nullable)landscapeImage landscapeSelectedImage:(UIImage * _Nullable)landscapeSelectedImage largeContentImage:(UIImage * _Nullable)largeContentImage __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:image:selectedImage:landscapeImage:landscapeSelectedImage:largeContentImage:")]
		[DesignatedInitializer]
		IntPtr Constructor (string title, UIImage image, [NullAllowed] UIImage selectedImage, [NullAllowed] UIImage landscapeImage, [NullAllowed] UIImage landscapeSelectedImage, [NullAllowed] UIImage largeContentImage);
	}

	// @interface MSFTabBarView : UIView
	[BaseType(typeof(UIView), Name = ApiDefinitionConstants.MSFTabBarView)]
	interface MSFTabBarView
	{
		// @property (copy, nonatomic) NSArray<MSFTabBarItem *> * _Nonnull items;
		[Export ("items", ArgumentSemantic.Copy)]
		MSFTabBarItem[] Items { get; set; }

		// @property (nonatomic, strong) MSFTabBarItem * _Nullable selectedItem;
		[NullAllowed, Export ("selectedItem", ArgumentSemantic.Strong)]
		MSFTabBarItem SelectedItem { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFTabBarViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFTabBarViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithShowsItemTitles:(BOOL)showsItemTitles __attribute__((objc_designated_initializer));
		[Export ("initWithShowsItemTitles:")]
		[DesignatedInitializer]
		IntPtr Constructor (bool showsItemTitles);

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);
	}

	interface IMSFTabBarViewDelegate { }

	// @protocol MSFTabBarViewDelegate
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFTabBarViewDelegate)]
	interface MSFTabBarViewDelegate
	{
		// @optional -(void)tabBarView:(MSFTabBarView * _Nonnull)tabBarView didSelect:(MSFTabBarItem * _Nonnull)item;
		[Export ("tabBarView:didSelect:")]
		void DidSelect (MSFTabBarView tabBarView, MSFTabBarItem item);
	}

	// @interface MSFTableViewHeaderFooterView : UITableViewHeaderFooterView
	[BaseType (typeof (UITableViewHeaderFooterView), Name = ApiDefinitionConstants.MSFTableViewHeaderFooterView)]
	interface MSFTableViewHeaderFooterView
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull identifier;
		[Static]
		[Export ("identifier")]
		string Identifier { get; }

		// +(CGFloat)heightWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title titleNumberOfLines:(NSInteger)titleNumberOfLines containerWidth:(CGFloat)containerWidth __attribute__((warn_unused_result));
		[Static]
		[Export ("heightWithStyle:title:titleNumberOfLines:containerWidth:")]
		nfloat HeightWithStyle (MSFTableViewHeaderFooterViewStyle style, string title, nint titleNumberOfLines, nfloat containerWidth);

		// +(CGFloat)preferredWidthWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title accessoryButton:(UIButton * _Nullable)accessoryButton __attribute__((warn_unused_result));
		[Static]
		[Export ("preferredWidthWithStyle:title:accessoryButton:")]
		nfloat PreferredWidthWithStyle (MSFTableViewHeaderFooterViewStyle style, string title, [NullAllowed] UIButton accessoryButton);

		// @property (nonatomic) enum MSFTableViewHeaderFooterViewAccessoryButtonStyle accessoryButtonStyle;
		[Export ("accessoryButtonStyle", ArgumentSemantic.Assign)]
		MSFTableViewHeaderFooterViewAccessoryButtonStyle AccessoryButtonStyle { get; set; }

		// @property (nonatomic) NSInteger titleNumberOfLines;
		[Export ("titleNumberOfLines")]
		nint TitleNumberOfLines { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onAccessoryButtonTapped;
		[NullAllowed, Export ("onAccessoryButtonTapped", ArgumentSemantic.Copy)]
		Action OnAccessoryButtonTapped { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFTableViewHeaderFooterViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFTableViewHeaderFooterViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// @property (nonatomic) CGRect bounds;
		[Export ("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// @property (nonatomic) CGRect frame;
		[Export ("frame", ArgumentSemantic.Assign)]
		CGRect Frame { get; set; }

		// -(instancetype _Nonnull)initWithReuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithReuseIdentifier:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string reuseIdentifier);

		// -(void)setupWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title accessoryButtonTitle:(NSString * _Nonnull)accessoryButtonTitle;
		[Export ("setupWithStyle:title:accessoryButtonTitle:")]
		void SetupWithStyle (MSFTableViewHeaderFooterViewStyle style, string title, string accessoryButtonTitle);

		// -(void)setupWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style attributedTitle:(NSAttributedString * _Nonnull)attributedTitle accessoryButtonTitle:(NSString * _Nonnull)accessoryButtonTitle;
		[Export ("setupWithStyle:attributedTitle:accessoryButtonTitle:")]
		void SetupWithStyle (MSFTableViewHeaderFooterViewStyle style, NSAttributedString attributedTitle, string accessoryButtonTitle);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)prepareForReuse __attribute__((objc_requires_super));
		[Export ("prepareForReuse")]
		[RequiresSuper]
		void PrepareForReuse ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);
	}

    interface IMSFTableViewHeaderFooterViewDelegate { }

	// @protocol [BaseType(typeof(NSObject))]
	[Protocol, Model]
	[BaseType(typeof(NSObject), Name = ApiDefinitionConstants.MSFTableViewHeaderFooterViewDelegate)]
	interface MSFTableViewHeaderFooterViewDelegate
	{
		// @optional -(BOOL)headerFooterView:(MSFTableViewHeaderFooterView * _Nonnull)headerFooterView shouldInteractWith:(NSURL * _Nonnull)URL in:(NSRange)characterRange interaction:(UITextItemInteraction)interaction __attribute__((warn_unused_result));
		[Export ("headerFooterView:shouldInteractWith:in:interaction:")]
		bool ShouldInteractWith (MSFTableViewHeaderFooterView headerFooterView, NSUrl URL, NSRange characterRange, UITextItemInteraction interaction);
	}

	// @interface MSFTooltip : NSObject
	[BaseType (typeof (NSObject), Name = ApiDefinitionConstants.MSFTooltip)]
	[DisableDefaultCtor]
	interface MSFTooltip
	{
		// @property (readonly, nonatomic, class) UIEdgeInsets defaultScreenMargins;
		[Static]
		[Export ("defaultScreenMargins")]
		UIEdgeInsets DefaultScreenMargins { get; }

		// @property (readonly, nonatomic, strong, class) MSFTooltip * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		MSFTooltip Shared { get; }

		// @property (nonatomic) NSTextAlignment textAlignment;
		[Export ("textAlignment", ArgumentSemantic.Assign)]
		NSTextAlignment TextAlignment { get; set; }

		// @property (readonly, nonatomic) BOOL isShowing;
		[Export ("isShowing")]
		bool IsShowing { get; }

		// -(void)showWith:(NSString * _Nonnull)message for:(UIView * _Nonnull)anchorView preferredArrowDirection:(enum MSFTooltipArrowDirection)preferredArrowDirection offset:(CGPoint)offset screenMargins:(UIEdgeInsets)screenMargins dismissOn:(enum MSFTooltipDismissMode)dismissMode onTap:(void (^ _Nullable)(void))onTap;
		[Export ("showWith:for:preferredArrowDirection:offset:screenMargins:dismissOn:onTap:")]
		void ShowWith (string message, UIView anchorView, MSFTooltipArrowDirection preferredArrowDirection, CGPoint offset, UIEdgeInsets screenMargins, MSFTooltipDismissMode dismissMode, [NullAllowed] Action onTap);

		// -(void)hide;
		[Export ("hide")]
		void Hide ();
	}

	// @interface MSFTouchForwardingView : UIView
	[BaseType (typeof (UIView), Name = ApiDefinitionConstants.MSFTouchForwardingView)]
	interface MSFTouchForwardingView
	{
		// -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
		[Export ("pointInside:withEvent:")]
		bool PointInside (CGPoint point, [NullAllowed] UIEvent @event);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}

	// @interface MSFTwoLineTitleView : UIView
	[BaseType (typeof (UIView), Name = ApiDefinitionConstants.MSFTwoLineTitleView)]
	interface MSFTwoLineTitleView
	{
		// @property (copy, nonatomic) NSString * _Nullable titleAccessibilityHint;
		[NullAllowed, Export ("titleAccessibilityHint")]
		string TitleAccessibilityHint { get; set; }

		// @property (nonatomic) UIAccessibilityTraits titleAccessibilityTraits;
		[Export ("titleAccessibilityTraits")]
		ulong TitleAccessibilityTraits { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable subtitleAccessibilityHint;
		[NullAllowed, Export ("subtitleAccessibilityHint")]
		string SubtitleAccessibilityHint { get; set; }

		// @property (nonatomic) UIAccessibilityTraits subtitleAccessibilityTraits;
		[Export ("subtitleAccessibilityTraits")]
		ulong SubtitleAccessibilityTraits { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFTwoLineTitleViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFTwoLineTitleViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithStyle:(enum MSFTwoLineTitleViewStyle)style;
		[Export ("initWithStyle:")]
		IntPtr Constructor (MSFTwoLineTitleViewStyle style);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(void)setupWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle interactivePart:(enum MSFTwoLineTitleViewInteractivePart)interactivePart accessoryType:(enum MSFTwoLineTitleViewAccessoryType)accessoryType;
		[Export ("setupWithTitle:subtitle:interactivePart:accessoryType:")]
		void SetupWithTitle (string title, [NullAllowed] string subtitle, MSFTwoLineTitleViewInteractivePart interactivePart, MSFTwoLineTitleViewAccessoryType accessoryType);

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// @property (nonatomic) BOOL isAccessibilityElement;
		[Export ("isAccessibilityElement")]
		bool IsAccessibilityElement { get; set; }

		// -(NSInteger)accessibilityElementCount __attribute__((warn_unused_result));
		[Export ("accessibilityElementCount")]
		nint AccessibilityElementCount { get; }

		// -(id _Nullable)accessibilityElementAtIndex:(NSInteger)index __attribute__((warn_unused_result));
		[Export ("accessibilityElementAtIndex:")]
		[return: NullAllowed]
		NSObject AccessibilityElementAtIndex (nint index);

		// -(NSInteger)indexOfAccessibilityElement:(id _Nonnull)element __attribute__((warn_unused_result));
		[Export ("indexOfAccessibilityElement:")]
		nint IndexOfAccessibilityElement (NSObject element);
	}

	interface IMSFTwoLineTitleViewDelegate { }

	// @protocol MSFTwoLineTitleViewDelegate
	[Protocol, Model]
	[BaseType (typeof (NSObject), Name = ApiDefinitionConstants.MSFTwoLineTitleViewDelegate)]
	interface MSFTwoLineTitleViewDelegate
	{
		// @required -(void)twoLineTitleViewDidTapOnTitle:(MSFTwoLineTitleView * _Nonnull)twoLineTitleView;
		[Abstract]
		[Export ("twoLineTitleViewDidTapOnTitle:")]
		void TwoLineTitleViewDidTapOnTitle (MSFTwoLineTitleView twoLineTitleView);
	}
}
