﻿using dnlib.DotNet;
using System;

namespace Confuser.Renamer.BAML
{
    internal enum KnownTypes : short
    {
        Unknown = 0,
        AccessText,
        AdornedElementPlaceholder,
        Adorner,
        AdornerDecorator,
        AdornerLayer,
        AffineTransform3D,
        AmbientLight,
        AnchoredBlock,
        Animatable,
        AnimationClock,
        AnimationTimeline,
        Application,
        ArcSegment,
        ArrayExtension,
        AxisAngleRotation3D,
        BaseIListConverter,
        BeginStoryboard,
        BevelBitmapEffect,
        BezierSegment,
        Binding,
        BindingBase,
        BindingExpression,
        BindingExpressionBase,
        BindingListCollectionView,
        BitmapDecoder,
        BitmapEffect,
        BitmapEffectCollection,
        BitmapEffectGroup,
        BitmapEffectInput,
        BitmapEncoder,
        BitmapFrame,
        BitmapImage,
        BitmapMetadata,
        BitmapPalette,
        BitmapSource,
        Block,
        BlockUIContainer,
        BlurBitmapEffect,
        BmpBitmapDecoder,
        BmpBitmapEncoder,
        Bold,
        BoolIListConverter,
        Boolean,
        BooleanAnimationBase,
        BooleanAnimationUsingKeyFrames,
        BooleanConverter,
        BooleanKeyFrame,
        BooleanKeyFrameCollection,
        BooleanToVisibilityConverter,
        Border,
        BorderGapMaskConverter,
        Brush,
        BrushConverter,
        BulletDecorator,
        Button,
        ButtonBase,
        Byte,
        ByteAnimation,
        ByteAnimationBase,
        ByteAnimationUsingKeyFrames,
        ByteConverter,
        ByteKeyFrame,
        ByteKeyFrameCollection,
        CachedBitmap,
        Camera,
        Canvas,
        Char,
        CharAnimationBase,
        CharAnimationUsingKeyFrames,
        CharConverter,
        CharIListConverter,
        CharKeyFrame,
        CharKeyFrameCollection,
        CheckBox,
        Clock,
        ClockController,
        ClockGroup,
        CollectionContainer,
        CollectionView,
        CollectionViewSource,
        Color,
        ColorAnimation,
        ColorAnimationBase,
        ColorAnimationUsingKeyFrames,
        ColorConvertedBitmap,
        ColorConvertedBitmapExtension,
        ColorConverter,
        ColorKeyFrame,
        ColorKeyFrameCollection,
        ColumnDefinition,
        CombinedGeometry,
        ComboBox,
        ComboBoxItem,
        CommandConverter,
        ComponentResourceKey,
        ComponentResourceKeyConverter,
        CompositionTarget,
        Condition,
        ContainerVisual,
        ContentControl,
        ContentElement,
        ContentPresenter,
        ContentPropertyAttribute,
        ContentWrapperAttribute,
        ContextMenu,
        ContextMenuService,
        Control,
        ControlTemplate,
        ControllableStoryboardAction,
        CornerRadius,
        CornerRadiusConverter,
        CroppedBitmap,
        CultureInfo,
        CultureInfoConverter,
        CultureInfoIetfLanguageTagConverter,
        Cursor,
        CursorConverter,
        DashStyle,
        DataChangedEventManager,
        DataTemplate,
        DataTemplateKey,
        DataTrigger,
        DateTime,
        DateTimeConverter,
        DateTimeConverter2,
        Decimal,
        DecimalAnimation,
        DecimalAnimationBase,
        DecimalAnimationUsingKeyFrames,
        DecimalConverter,
        DecimalKeyFrame,
        DecimalKeyFrameCollection,
        Decorator,
        DefinitionBase,
        DependencyObject,
        DependencyProperty,
        DependencyPropertyConverter,
        DialogResultConverter,
        DiffuseMaterial,
        DirectionalLight,
        DiscreteBooleanKeyFrame,
        DiscreteByteKeyFrame,
        DiscreteCharKeyFrame,
        DiscreteColorKeyFrame,
        DiscreteDecimalKeyFrame,
        DiscreteDoubleKeyFrame,
        DiscreteInt16KeyFrame,
        DiscreteInt32KeyFrame,
        DiscreteInt64KeyFrame,
        DiscreteMatrixKeyFrame,
        DiscreteObjectKeyFrame,
        DiscretePoint3DKeyFrame,
        DiscretePointKeyFrame,
        DiscreteQuaternionKeyFrame,
        DiscreteRectKeyFrame,
        DiscreteRotation3DKeyFrame,
        DiscreteSingleKeyFrame,
        DiscreteSizeKeyFrame,
        DiscreteStringKeyFrame,
        DiscreteThicknessKeyFrame,
        DiscreteVector3DKeyFrame,
        DiscreteVectorKeyFrame,
        DockPanel,
        DocumentPageView,
        DocumentReference,
        DocumentViewer,
        DocumentViewerBase,
        Double,
        DoubleAnimation,
        DoubleAnimationBase,
        DoubleAnimationUsingKeyFrames,
        DoubleAnimationUsingPath,
        DoubleCollection,
        DoubleCollectionConverter,
        DoubleConverter,
        DoubleIListConverter,
        DoubleKeyFrame,
        DoubleKeyFrameCollection,
        Drawing,
        DrawingBrush,
        DrawingCollection,
        DrawingContext,
        DrawingGroup,
        DrawingImage,
        DrawingVisual,
        DropShadowBitmapEffect,
        Duration,
        DurationConverter,
        DynamicResourceExtension,
        DynamicResourceExtensionConverter,
        Ellipse,
        EllipseGeometry,
        EmbossBitmapEffect,
        EmissiveMaterial,
        EnumConverter,
        EventManager,
        EventSetter,
        EventTrigger,
        Expander,
        Expression,
        ExpressionConverter,
        Figure,
        FigureLength,
        FigureLengthConverter,
        FixedDocument,
        FixedDocumentSequence,
        FixedPage,
        Floater,
        FlowDocument,
        FlowDocumentPageViewer,
        FlowDocumentReader,
        FlowDocumentScrollViewer,
        FocusManager,
        FontFamily,
        FontFamilyConverter,
        FontSizeConverter,
        FontStretch,
        FontStretchConverter,
        FontStyle,
        FontStyleConverter,
        FontWeight,
        FontWeightConverter,
        FormatConvertedBitmap,
        Frame,
        FrameworkContentElement,
        FrameworkElement,
        FrameworkElementFactory,
        FrameworkPropertyMetadata,
        FrameworkPropertyMetadataOptions,
        FrameworkRichTextComposition,
        FrameworkTemplate,
        FrameworkTextComposition,
        Freezable,
        GeneralTransform,
        GeneralTransformCollection,
        GeneralTransformGroup,
        Geometry,
        Geometry3D,
        GeometryCollection,
        GeometryConverter,
        GeometryDrawing,
        GeometryGroup,
        GeometryModel3D,
        GestureRecognizer,
        GifBitmapDecoder,
        GifBitmapEncoder,
        GlyphRun,
        GlyphRunDrawing,
        GlyphTypeface,
        Glyphs,
        GradientBrush,
        GradientStop,
        GradientStopCollection,
        Grid,
        GridLength,
        GridLengthConverter,
        GridSplitter,
        GridView,
        GridViewColumn,
        GridViewColumnHeader,
        GridViewHeaderRowPresenter,
        GridViewRowPresenter,
        GridViewRowPresenterBase,
        GroupBox,
        GroupItem,
        Guid,
        GuidConverter,
        GuidelineSet,
        HeaderedContentControl,
        HeaderedItemsControl,
        HierarchicalDataTemplate,
        HostVisual,
        Hyperlink,
        IAddChild,
        IAddChildInternal,
        ICommand,
        IComponentConnector,
        INameScope,
        IStyleConnector,
        IconBitmapDecoder,
        Image,
        ImageBrush,
        ImageDrawing,
        ImageMetadata,
        ImageSource,
        ImageSourceConverter,
        InPlaceBitmapMetadataWriter,
        InkCanvas,
        InkPresenter,
        Inline,
        InlineCollection,
        InlineUIContainer,
        InputBinding,
        InputDevice,
        InputLanguageManager,
        InputManager,
        InputMethod,
        InputScope,
        InputScopeConverter,
        InputScopeName,
        InputScopeNameConverter,
        Int16,
        Int16Animation,
        Int16AnimationBase,
        Int16AnimationUsingKeyFrames,
        Int16Converter,
        Int16KeyFrame,
        Int16KeyFrameCollection,
        Int32,
        Int32Animation,
        Int32AnimationBase,
        Int32AnimationUsingKeyFrames,
        Int32Collection,
        Int32CollectionConverter,
        Int32Converter,
        Int32KeyFrame,
        Int32KeyFrameCollection,
        Int32Rect,
        Int32RectConverter,
        Int64,
        Int64Animation,
        Int64AnimationBase,
        Int64AnimationUsingKeyFrames,
        Int64Converter,
        Int64KeyFrame,
        Int64KeyFrameCollection,
        Italic,
        ItemCollection,
        ItemsControl,
        ItemsPanelTemplate,
        ItemsPresenter,
        JournalEntry,
        JournalEntryListConverter,
        JournalEntryUnifiedViewConverter,
        JpegBitmapDecoder,
        JpegBitmapEncoder,
        KeyBinding,
        KeyConverter,
        KeyGesture,
        KeyGestureConverter,
        KeySpline,
        KeySplineConverter,
        KeyTime,
        KeyTimeConverter,
        KeyboardDevice,
        Label,
        LateBoundBitmapDecoder,
        LengthConverter,
        Light,
        Line,
        LineBreak,
        LineGeometry,
        LineSegment,
        LinearByteKeyFrame,
        LinearColorKeyFrame,
        LinearDecimalKeyFrame,
        LinearDoubleKeyFrame,
        LinearGradientBrush,
        LinearInt16KeyFrame,
        LinearInt32KeyFrame,
        LinearInt64KeyFrame,
        LinearPoint3DKeyFrame,
        LinearPointKeyFrame,
        LinearQuaternionKeyFrame,
        LinearRectKeyFrame,
        LinearRotation3DKeyFrame,
        LinearSingleKeyFrame,
        LinearSizeKeyFrame,
        LinearThicknessKeyFrame,
        LinearVector3DKeyFrame,
        LinearVectorKeyFrame,
        List,
        ListBox,
        ListBoxItem,
        ListCollectionView,
        ListItem,
        ListView,
        ListViewItem,
        Localization,
        LostFocusEventManager,
        MarkupExtension,
        Material,
        MaterialCollection,
        MaterialGroup,
        Matrix,
        Matrix3D,
        Matrix3DConverter,
        MatrixAnimationBase,
        MatrixAnimationUsingKeyFrames,
        MatrixAnimationUsingPath,
        MatrixCamera,
        MatrixConverter,
        MatrixKeyFrame,
        MatrixKeyFrameCollection,
        MatrixTransform,
        MatrixTransform3D,
        MediaClock,
        MediaElement,
        MediaPlayer,
        MediaTimeline,
        Menu,
        MenuBase,
        MenuItem,
        MenuScrollingVisibilityConverter,
        MeshGeometry3D,
        Model3D,
        Model3DCollection,
        Model3DGroup,
        ModelVisual3D,
        ModifierKeysConverter,
        MouseActionConverter,
        MouseBinding,
        MouseDevice,
        MouseGesture,
        MouseGestureConverter,
        MultiBinding,
        MultiBindingExpression,
        MultiDataTrigger,
        MultiTrigger,
        NameScope,
        NavigationWindow,
        NullExtension,
        NullableBoolConverter,
        NullableConverter,
        NumberSubstitution,
        Object,
        ObjectAnimationBase,
        ObjectAnimationUsingKeyFrames,
        ObjectDataProvider,
        ObjectKeyFrame,
        ObjectKeyFrameCollection,
        OrthographicCamera,
        OuterGlowBitmapEffect,
        Page,
        PageContent,
        PageFunctionBase,
        Panel,
        Paragraph,
        ParallelTimeline,
        ParserContext,
        PasswordBox,
        Path,
        PathFigure,
        PathFigureCollection,
        PathFigureCollectionConverter,
        PathGeometry,
        PathSegment,
        PathSegmentCollection,
        PauseStoryboard,
        Pen,
        PerspectiveCamera,
        PixelFormat,
        PixelFormatConverter,
        PngBitmapDecoder,
        PngBitmapEncoder,
        Point,
        Point3D,
        Point3DAnimation,
        Point3DAnimationBase,
        Point3DAnimationUsingKeyFrames,
        Point3DCollection,
        Point3DCollectionConverter,
        Point3DConverter,
        Point3DKeyFrame,
        Point3DKeyFrameCollection,
        Point4D,
        Point4DConverter,
        PointAnimation,
        PointAnimationBase,
        PointAnimationUsingKeyFrames,
        PointAnimationUsingPath,
        PointCollection,
        PointCollectionConverter,
        PointConverter,
        PointIListConverter,
        PointKeyFrame,
        PointKeyFrameCollection,
        PointLight,
        PointLightBase,
        PolyBezierSegment,
        PolyLineSegment,
        PolyQuadraticBezierSegment,
        Polygon,
        Polyline,
        Popup,
        PresentationSource,
        PriorityBinding,
        PriorityBindingExpression,
        ProgressBar,
        ProjectionCamera,
        PropertyPath,
        PropertyPathConverter,
        QuadraticBezierSegment,
        Quaternion,
        QuaternionAnimation,
        QuaternionAnimationBase,
        QuaternionAnimationUsingKeyFrames,
        QuaternionConverter,
        QuaternionKeyFrame,
        QuaternionKeyFrameCollection,
        QuaternionRotation3D,
        RadialGradientBrush,
        RadioButton,
        RangeBase,
        Rect,
        Rect3D,
        Rect3DConverter,
        RectAnimation,
        RectAnimationBase,
        RectAnimationUsingKeyFrames,
        RectConverter,
        RectKeyFrame,
        RectKeyFrameCollection,
        Rectangle,
        RectangleGeometry,
        RelativeSource,
        RemoveStoryboard,
        RenderOptions,
        RenderTargetBitmap,
        RepeatBehavior,
        RepeatBehaviorConverter,
        RepeatButton,
        ResizeGrip,
        ResourceDictionary,
        ResourceKey,
        ResumeStoryboard,
        RichTextBox,
        RotateTransform,
        RotateTransform3D,
        Rotation3D,
        Rotation3DAnimation,
        Rotation3DAnimationBase,
        Rotation3DAnimationUsingKeyFrames,
        Rotation3DKeyFrame,
        Rotation3DKeyFrameCollection,
        RoutedCommand,
        RoutedEvent,
        RoutedEventConverter,
        RoutedUICommand,
        RoutingStrategy,
        RowDefinition,
        Run,
        RuntimeNamePropertyAttribute,
        SByte,
        SByteConverter,
        ScaleTransform,
        ScaleTransform3D,
        ScrollBar,
        ScrollContentPresenter,
        ScrollViewer,
        Section,
        SeekStoryboard,
        Selector,
        Separator,
        SetStoryboardSpeedRatio,
        Setter,
        SetterBase,
        Shape,
        Single,
        SingleAnimation,
        SingleAnimationBase,
        SingleAnimationUsingKeyFrames,
        SingleConverter,
        SingleKeyFrame,
        SingleKeyFrameCollection,
        Size,
        Size3D,
        Size3DConverter,
        SizeAnimation,
        SizeAnimationBase,
        SizeAnimationUsingKeyFrames,
        SizeConverter,
        SizeKeyFrame,
        SizeKeyFrameCollection,
        SkewTransform,
        SkipStoryboardToFill,
        Slider,
        SolidColorBrush,
        SoundPlayerAction,
        Span,
        SpecularMaterial,
        SpellCheck,
        SplineByteKeyFrame,
        SplineColorKeyFrame,
        SplineDecimalKeyFrame,
        SplineDoubleKeyFrame,
        SplineInt16KeyFrame,
        SplineInt32KeyFrame,
        SplineInt64KeyFrame,
        SplinePoint3DKeyFrame,
        SplinePointKeyFrame,
        SplineQuaternionKeyFrame,
        SplineRectKeyFrame,
        SplineRotation3DKeyFrame,
        SplineSingleKeyFrame,
        SplineSizeKeyFrame,
        SplineThicknessKeyFrame,
        SplineVector3DKeyFrame,
        SplineVectorKeyFrame,
        SpotLight,
        StackPanel,
        StaticExtension,
        StaticResourceExtension,
        StatusBar,
        StatusBarItem,
        StickyNoteControl,
        StopStoryboard,
        Storyboard,
        StreamGeometry,
        StreamGeometryContext,
        StreamResourceInfo,
        String,
        StringAnimationBase,
        StringAnimationUsingKeyFrames,
        StringConverter,
        StringKeyFrame,
        StringKeyFrameCollection,
        StrokeCollection,
        StrokeCollectionConverter,
        Style,
        Stylus,
        StylusDevice,
        TabControl,
        TabItem,
        TabPanel,
        Table,
        TableCell,
        TableColumn,
        TableRow,
        TableRowGroup,
        TabletDevice,
        TemplateBindingExpression,
        TemplateBindingExpressionConverter,
        TemplateBindingExtension,
        TemplateBindingExtensionConverter,
        TemplateKey,
        TemplateKeyConverter,
        TextBlock,
        TextBox,
        TextBoxBase,
        TextComposition,
        TextCompositionManager,
        TextDecoration,
        TextDecorationCollection,
        TextDecorationCollectionConverter,
        TextEffect,
        TextEffectCollection,
        TextElement,
        TextSearch,
        ThemeDictionaryExtension,
        Thickness,
        ThicknessAnimation,
        ThicknessAnimationBase,
        ThicknessAnimationUsingKeyFrames,
        ThicknessConverter,
        ThicknessKeyFrame,
        ThicknessKeyFrameCollection,
        Thumb,
        TickBar,
        TiffBitmapDecoder,
        TiffBitmapEncoder,
        TileBrush,
        TimeSpan,
        TimeSpanConverter,
        Timeline,
        TimelineCollection,
        TimelineGroup,
        ToggleButton,
        ToolBar,
        ToolBarOverflowPanel,
        ToolBarPanel,
        ToolBarTray,
        ToolTip,
        ToolTipService,
        Track,
        Transform,
        Transform3D,
        Transform3DCollection,
        Transform3DGroup,
        TransformCollection,
        TransformConverter,
        TransformGroup,
        TransformedBitmap,
        TranslateTransform,
        TranslateTransform3D,
        TreeView,
        TreeViewItem,
        Trigger,
        TriggerAction,
        TriggerBase,
        TypeExtension,
        TypeTypeConverter,
        Typography,
        UIElement,
        UInt16,
        UInt16Converter,
        UInt32,
        UInt32Converter,
        UInt64,
        UInt64Converter,
        UShortIListConverter,
        Underline,
        UniformGrid,
        Uri,
        UriTypeConverter,
        UserControl,
        Validation,
        Vector,
        Vector3D,
        Vector3DAnimation,
        Vector3DAnimationBase,
        Vector3DAnimationUsingKeyFrames,
        Vector3DCollection,
        Vector3DCollectionConverter,
        Vector3DConverter,
        Vector3DKeyFrame,
        Vector3DKeyFrameCollection,
        VectorAnimation,
        VectorAnimationBase,
        VectorAnimationUsingKeyFrames,
        VectorCollection,
        VectorCollectionConverter,
        VectorConverter,
        VectorKeyFrame,
        VectorKeyFrameCollection,
        VideoDrawing,
        ViewBase,
        Viewbox,
        Viewport3D,
        Viewport3DVisual,
        VirtualizingPanel,
        VirtualizingStackPanel,
        Visual,
        Visual3D,
        VisualBrush,
        VisualTarget,
        WeakEventManager,
        WhitespaceSignificantCollectionAttribute,
        Window,
        WmpBitmapDecoder,
        WmpBitmapEncoder,
        WrapPanel,
        WriteableBitmap,
        XamlBrushSerializer,
        XamlInt32CollectionSerializer,
        XamlPathDataSerializer,
        XamlPoint3DCollectionSerializer,
        XamlPointCollectionSerializer,
        XamlReader,
        XamlStyleSerializer,
        XamlTemplateSerializer,
        XamlVector3DCollectionSerializer,
        XamlWriter,
        XmlDataProvider,
        XmlLangPropertyAttribute,
        XmlLanguage,
        XmlLanguageConverter,
        XmlNamespaceMapping,
        ZoomPercentageConverter
    }

    internal enum KnownProperties : short
    {
        Unknown = 0,
        AccessText_Text,
        BeginStoryboard_Storyboard,
        BitmapEffectGroup_Children,
        Border_Background,
        Border_BorderBrush,
        Border_BorderThickness,
        ButtonBase_Command,
        ButtonBase_CommandParameter,
        ButtonBase_CommandTarget,
        ButtonBase_IsPressed,
        ColumnDefinition_MaxWidth,
        ColumnDefinition_MinWidth,
        ColumnDefinition_Width,
        ContentControl_Content,
        ContentControl_ContentTemplate,
        ContentControl_ContentTemplateSelector,
        ContentControl_HasContent,
        ContentElement_Focusable,
        ContentPresenter_Content,
        ContentPresenter_ContentSource,
        ContentPresenter_ContentTemplate,
        ContentPresenter_ContentTemplateSelector,
        ContentPresenter_RecognizesAccessKey,
        Control_Background,
        Control_BorderBrush,
        Control_BorderThickness,
        Control_FontFamily,
        Control_FontSize,
        Control_FontStretch,
        Control_FontStyle,
        Control_FontWeight,
        Control_Foreground,
        Control_HorizontalContentAlignment,
        Control_IsTabStop,
        Control_Padding,
        Control_TabIndex,
        Control_Template,
        Control_VerticalContentAlignment,
        DockPanel_Dock,
        DockPanel_LastChildFill,
        DocumentViewerBase_Document,
        DrawingGroup_Children,
        FlowDocumentReader_Document,
        FlowDocumentScrollViewer_Document,
        FrameworkContentElement_Style,
        FrameworkElement_FlowDirection,
        FrameworkElement_Height,
        FrameworkElement_HorizontalAlignment,
        FrameworkElement_Margin,
        FrameworkElement_MaxHeight,
        FrameworkElement_MaxWidth,
        FrameworkElement_MinHeight,
        FrameworkElement_MinWidth,
        FrameworkElement_Name,
        FrameworkElement_Style,
        FrameworkElement_VerticalAlignment,
        FrameworkElement_Width,
        GeneralTransformGroup_Children,
        GeometryGroup_Children,
        GradientBrush_GradientStops,
        Grid_Column,
        Grid_ColumnSpan,
        Grid_Row,
        Grid_RowSpan,
        GridViewColumn_Header,
        HeaderedContentControl_HasHeader,
        HeaderedContentControl_Header,
        HeaderedContentControl_HeaderTemplate,
        HeaderedContentControl_HeaderTemplateSelector,
        HeaderedItemsControl_HasHeader,
        HeaderedItemsControl_Header,
        HeaderedItemsControl_HeaderTemplate,
        HeaderedItemsControl_HeaderTemplateSelector,
        Hyperlink_NavigateUri,
        Image_Source,
        Image_Stretch,
        ItemsControl_ItemContainerStyle,
        ItemsControl_ItemContainerStyleSelector,
        ItemsControl_ItemTemplate,
        ItemsControl_ItemTemplateSelector,
        ItemsControl_ItemsPanel,
        ItemsControl_ItemsSource,
        MaterialGroup_Children,
        Model3DGroup_Children,
        Page_Content,
        Panel_Background,
        Path_Data,
        PathFigure_Segments,
        PathGeometry_Figures,
        Popup_Child,
        Popup_IsOpen,
        Popup_Placement,
        Popup_PopupAnimation,
        RowDefinition_Height,
        RowDefinition_MaxHeight,
        RowDefinition_MinHeight,
        ScrollViewer_CanContentScroll,
        ScrollViewer_HorizontalScrollBarVisibility,
        ScrollViewer_VerticalScrollBarVisibility,
        Shape_Fill,
        Shape_Stroke,
        Shape_StrokeThickness,
        TextBlock_Background,
        TextBlock_FontFamily,
        TextBlock_FontSize,
        TextBlock_FontStretch,
        TextBlock_FontStyle,
        TextBlock_FontWeight,
        TextBlock_Foreground,
        TextBlock_Text,
        TextBlock_TextDecorations,
        TextBlock_TextTrimming,
        TextBlock_TextWrapping,
        TextBox_Text,
        TextElement_Background,
        TextElement_FontFamily,
        TextElement_FontSize,
        TextElement_FontStretch,
        TextElement_FontStyle,
        TextElement_FontWeight,
        TextElement_Foreground,
        TimelineGroup_Children,
        Track_IsDirectionReversed,
        Track_Maximum,
        Track_Minimum,
        Track_Orientation,
        Track_Value,
        Track_ViewportSize,
        Transform3DGroup_Children,
        TransformGroup_Children,
        UIElement_ClipToBounds,
        UIElement_Focusable,
        UIElement_IsEnabled,
        UIElement_RenderTransform,
        UIElement_Visibility,
        Viewport3D_Children,
        MaxDependencyProperty,
        AdornedElementPlaceholder_Child,
        AdornerDecorator_Child,
        AnchoredBlock_Blocks,
        ArrayExtension_Items,
        BlockUIContainer_Child,
        Bold_Inlines,
        BooleanAnimationUsingKeyFrames_KeyFrames,
        Border_Child,
        BulletDecorator_Child,
        Button_Content,
        ButtonBase_Content,
        ByteAnimationUsingKeyFrames_KeyFrames,
        Canvas_Children,
        CharAnimationUsingKeyFrames_KeyFrames,
        CheckBox_Content,
        ColorAnimationUsingKeyFrames_KeyFrames,
        ComboBox_Items,
        ComboBoxItem_Content,
        ContextMenu_Items,
        ControlTemplate_VisualTree,
        DataTemplate_VisualTree,
        DataTrigger_Setters,
        DecimalAnimationUsingKeyFrames_KeyFrames,
        Decorator_Child,
        DockPanel_Children,
        DocumentViewer_Document,
        DoubleAnimationUsingKeyFrames_KeyFrames,
        EventTrigger_Actions,
        Expander_Content,
        Figure_Blocks,
        FixedDocument_Pages,
        FixedDocumentSequence_References,
        FixedPage_Children,
        Floater_Blocks,
        FlowDocument_Blocks,
        FlowDocumentPageViewer_Document,
        FrameworkTemplate_VisualTree,
        Grid_Children,
        GridView_Columns,
        GridViewColumnHeader_Content,
        GroupBox_Content,
        GroupItem_Content,
        HeaderedContentControl_Content,
        HeaderedItemsControl_Items,
        HierarchicalDataTemplate_VisualTree,
        Hyperlink_Inlines,
        InkCanvas_Children,
        InkPresenter_Child,
        InlineUIContainer_Child,
        InputScopeName_NameValue,
        Int16AnimationUsingKeyFrames_KeyFrames,
        Int32AnimationUsingKeyFrames_KeyFrames,
        Int64AnimationUsingKeyFrames_KeyFrames,
        Italic_Inlines,
        ItemsControl_Items,
        ItemsPanelTemplate_VisualTree,
        Label_Content,
        LinearGradientBrush_GradientStops,
        List_ListItems,
        ListBox_Items,
        ListBoxItem_Content,
        ListItem_Blocks,
        ListView_Items,
        ListViewItem_Content,
        MatrixAnimationUsingKeyFrames_KeyFrames,
        Menu_Items,
        MenuBase_Items,
        MenuItem_Items,
        ModelVisual3D_Children,
        MultiBinding_Bindings,
        MultiDataTrigger_Setters,
        MultiTrigger_Setters,
        ObjectAnimationUsingKeyFrames_KeyFrames,
        PageContent_Child,
        PageFunctionBase_Content,
        Panel_Children,
        Paragraph_Inlines,
        ParallelTimeline_Children,
        Point3DAnimationUsingKeyFrames_KeyFrames,
        PointAnimationUsingKeyFrames_KeyFrames,
        PriorityBinding_Bindings,
        QuaternionAnimationUsingKeyFrames_KeyFrames,
        RadialGradientBrush_GradientStops,
        RadioButton_Content,
        RectAnimationUsingKeyFrames_KeyFrames,
        RepeatButton_Content,
        RichTextBox_Document,
        Rotation3DAnimationUsingKeyFrames_KeyFrames,
        Run_Text,
        ScrollViewer_Content,
        Section_Blocks,
        Selector_Items,
        SingleAnimationUsingKeyFrames_KeyFrames,
        SizeAnimationUsingKeyFrames_KeyFrames,
        Span_Inlines,
        StackPanel_Children,
        StatusBar_Items,
        StatusBarItem_Content,
        Storyboard_Children,
        StringAnimationUsingKeyFrames_KeyFrames,
        Style_Setters,
        TabControl_Items,
        TabItem_Content,
        TabPanel_Children,
        Table_RowGroups,
        TableCell_Blocks,
        TableRow_Cells,
        TableRowGroup_Rows,
        TextBlock_Inlines,
        ThicknessAnimationUsingKeyFrames_KeyFrames,
        ToggleButton_Content,
        ToolBar_Items,
        ToolBarOverflowPanel_Children,
        ToolBarPanel_Children,
        ToolBarTray_ToolBars,
        ToolTip_Content,
        TreeView_Items,
        TreeViewItem_Items,
        Trigger_Setters,
        Underline_Inlines,
        UniformGrid_Children,
        UserControl_Content,
        Vector3DAnimationUsingKeyFrames_KeyFrames,
        VectorAnimationUsingKeyFrames_KeyFrames,
        Viewbox_Child,
        Viewport3DVisual_Children,
        VirtualizingPanel_Children,
        VirtualizingStackPanel_Children,
        Window_Content,
        WrapPanel_Children,
        XmlDataProvider_XmlSerializer
    }

    internal interface IKnownThings
    {
        Func<KnownTypes, TypeDef> Types { get; }
        Func<KnownProperties, Tuple<KnownTypes, PropertyDef, TypeDef>> Properties { get; }
        AssemblyDef FrameworkAssembly { get; }
    }
}