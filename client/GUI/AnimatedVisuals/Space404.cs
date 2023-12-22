using Microsoft.Graphics.Canvas.Geometry;
using Microsoft.UI.Composition;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;

namespace GUI.AnimatedVisuals
{
    // Name:        4RS7DCH
    // Frame rate:  30 fps
    // Frame count: 180
    // Duration:    6000.0 mS
    // ___________________________________________________________
    // | Theme property |   Accessor   | Type  |  Default value  |
    // |________________|______________|_______|_________________|
    // | #2E03E4        | Color_2E03E4 | Color |    #FF2E03E4    |
    // | #758BDF        | Color_758BDF | Color |    #FF758BDF    |
    // | #849AF5        | Color_849AF5 | Color |    #FF849AF5    |
    // | #91A6FE        | Color_91A6FE | Color |    #FF91A6FE    |
    // | #EAEAEA        | Color_EAEAEA | Color |    #FFEAEAEA    |
    // | #FFFFFF        | Color_FFFFFF | Color | #FFFFFFFF White |
    // -----------------------------------------------------------
    public sealed class Space404
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
    {
        // Animation duration: 6.000 seconds.
        internal const long c_durationTicks = 60000000;

        // Theme property: Color_2E03E4.
        internal static readonly Color c_themeColor_2E03E4 = Color.FromArgb(0xFF, 0x2E, 0x03, 0xE4);

        // Theme property: Color_758BDF.
        internal static readonly Color c_themeColor_758BDF = Color.FromArgb(0xFF, 0x75, 0x8B, 0xDF);

        // Theme property: Color_849AF5.
        internal static readonly Color c_themeColor_849AF5 = Color.FromArgb(0xFF, 0x84, 0x9A, 0xF5);

        // Theme property: Color_91A6FE.
        internal static readonly Color c_themeColor_91A6FE = Color.FromArgb(0xFF, 0x91, 0xA6, 0xFE);

        // Theme property: Color_EAEAEA.
        internal static readonly Color c_themeColor_EAEAEA = Color.FromArgb(0xFF, 0xEA, 0xEA, 0xEA);

        // Theme property: Color_FFFFFF.
        internal static readonly Color c_themeColor_FFFFFF = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);

        CompositionPropertySet _themeProperties;
        Color _themeColor_2E03E4 = c_themeColor_2E03E4;
        Color _themeColor_758BDF = c_themeColor_758BDF;
        Color _themeColor_849AF5 = c_themeColor_849AF5;
        Color _themeColor_91A6FE = c_themeColor_91A6FE;
        Color _themeColor_EAEAEA = c_themeColor_EAEAEA;
        Color _themeColor_FFFFFF = c_themeColor_FFFFFF;

        // Theme properties.
        public Color Color_2E03E4
        {
            get => _themeColor_2E03E4;
            set
            {
                _themeColor_2E03E4 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_2E03E4", ColorAsVector4((Color)_themeColor_2E03E4));
                }
            }
        }

        public Color Color_758BDF
        {
            get => _themeColor_758BDF;
            set
            {
                _themeColor_758BDF = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_758BDF", ColorAsVector4((Color)_themeColor_758BDF));
                }
            }
        }

        public Color Color_849AF5
        {
            get => _themeColor_849AF5;
            set
            {
                _themeColor_849AF5 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_849AF5", ColorAsVector4((Color)_themeColor_849AF5));
                }
            }
        }

        public Color Color_91A6FE
        {
            get => _themeColor_91A6FE;
            set
            {
                _themeColor_91A6FE = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_91A6FE", ColorAsVector4((Color)_themeColor_91A6FE));
                }
            }
        }

        public Color Color_EAEAEA
        {
            get => _themeColor_EAEAEA;
            set
            {
                _themeColor_EAEAEA = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_EAEAEA", ColorAsVector4((Color)_themeColor_EAEAEA));
                }
            }
        }

        public Color Color_FFFFFF
        {
            get => _themeColor_FFFFFF;
            set
            {
                _themeColor_FFFFFF = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_FFFFFF", ColorAsVector4((Color)_themeColor_FFFFFF));
                }
            }
        }

        static Vector4 ColorAsVector4(Color color) => new Vector4(color.R, color.G, color.B, color.A);

        CompositionPropertySet EnsureThemeProperties(Compositor compositor)
        {
            if (_themeProperties == null)
            {
                _themeProperties = compositor.CreatePropertySet();
                _themeProperties.InsertVector4("Color_2E03E4", ColorAsVector4((Color)Color_2E03E4));
                _themeProperties.InsertVector4("Color_758BDF", ColorAsVector4((Color)Color_758BDF));
                _themeProperties.InsertVector4("Color_849AF5", ColorAsVector4((Color)Color_849AF5));
                _themeProperties.InsertVector4("Color_91A6FE", ColorAsVector4((Color)Color_91A6FE));
                _themeProperties.InsertVector4("Color_EAEAEA", ColorAsVector4((Color)Color_EAEAEA));
                _themeProperties.InsertVector4("Color_FFFFFF", ColorAsVector4((Color)Color_FFFFFF));
            }
            return _themeProperties;
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;
            EnsureThemeProperties(compositor);

            var res = 
                new Space404_AnimatedVisual(
                    compositor,
                    _themeProperties
                    );
                res.CreateAnimations();
                return res;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 180d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 30d;

        /// <summary>
        /// Gets the duration of the animation.
        /// </summary>
        public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);

        /// <summary>
        /// Converts a zero-based frame number to the corresponding progress value denoting the
        /// start of the frame.
        /// </summary>
        public double FrameToProgress(double frameNumber)
        {
            return frameNumber / 180d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
            if (propertyName == "Color_2E03E4")
            {
                _themeColor_2E03E4 = value;
            }
            else if (propertyName == "Color_758BDF")
            {
                _themeColor_758BDF = value;
            }
            else if (propertyName == "Color_849AF5")
            {
                _themeColor_849AF5 = value;
            }
            else if (propertyName == "Color_91A6FE")
            {
                _themeColor_91A6FE = value;
            }
            else if (propertyName == "Color_EAEAEA")
            {
                _themeColor_EAEAEA = value;
            }
            else if (propertyName == "Color_FFFFFF")
            {
                _themeColor_FFFFFF = value;
            }
            else
            {
                return;
            }

            if (_themeProperties != null)
            {
                _themeProperties.InsertVector4(propertyName, ColorAsVector4(value));
            }
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed class Space404_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual2
        {
            const long c_durationTicks = 60000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            readonly CompositionPropertySet _themeProperties;
            CompositionColorBrush _themeColor_Color_2E03E4;
            CompositionColorBrush _themeColor_Color_758BDF;
            CompositionColorBrush _themeColor_Color_849AF5;
            CompositionColorBrush _themeColor_Color_91A6FE;
            CompositionColorBrush _themeColor_Color_EAEAEA;
            CompositionColorBrush _themeColor_Color_FFFFFF;
            CompositionContainerShape _containerShape_0;
            CompositionContainerShape _containerShape_1;
            CompositionContainerShape _containerShape_2;
            CompositionContainerShape _containerShape_3;
            CompositionContainerShape _containerShape_4;
            CompositionContainerShape _containerShape_5;
            CompositionContainerShape _containerShape_6;
            CompositionContainerShape _containerShape_7;
            CompositionPath _path_00;
            CompositionPath _path_01;
            CompositionPath _path_02;
            CompositionPath _path_03;
            CompositionPath _path_04;
            CompositionPath _path_05;
            CompositionPath _path_06;
            CompositionPath _path_07;
            CompositionPath _path_08;
            CompositionPath _path_09;
            CompositionPath _path_10;
            CompositionPath _path_11;
            CompositionPath _path_12;
            CompositionPath _path_13;
            CompositionPath _path_14;
            CompositionPath _path_15;
            CompositionPath _path_16;
            CompositionPath _path_17;
            CompositionPath _path_18;
            CompositionPath _path_19;
            CompositionPath _path_20;
            CompositionPath _path_21;
            CompositionPath _path_22;
            CompositionPath _path_23;
            CompositionPath _path_24;
            CompositionPath _path_25;
            CompositionPath _path_26;
            CompositionPath _path_27;
            CompositionPath _path_28;
            CompositionPath _path_29;
            CompositionPath _path_30;
            CompositionPath _path_31;
            CompositionPath _path_32;
            CompositionPath _path_33;
            CompositionPath _path_34;
            CompositionPath _path_35;
            CompositionPath _path_36;
            CompositionPathGeometry _pathGeometry_07;
            CompositionPathGeometry _pathGeometry_08;
            CompositionPathGeometry _pathGeometry_09;
            CompositionPathGeometry _pathGeometry_10;
            CompositionPathGeometry _pathGeometry_11;
            CompositionPathGeometry _pathGeometry_12;
            CompositionPathGeometry _pathGeometry_13;
            CompositionPathGeometry _pathGeometry_14;
            CompositionPathGeometry _pathGeometry_15;
            CompositionPathGeometry _pathGeometry_16;
            CompositionPathGeometry _pathGeometry_40;
            CompositionPathGeometry _pathGeometry_41;
            CompositionPathGeometry _pathGeometry_42;
            CompositionPathGeometry _pathGeometry_43;
            CompositionPathGeometry _pathGeometry_44;
            CompositionPathGeometry _pathGeometry_45;
            CompositionPathGeometry _pathGeometry_46;
            CompositionPathGeometry _pathGeometry_51;
            CompositionPathGeometry _pathGeometry_52;
            CompositionPathGeometry _pathGeometry_53;
            CompositionPathGeometry _pathGeometry_54;
            CompositionPathGeometry _pathGeometry_55;
            CompositionPathGeometry _pathGeometry_56;
            CompositionPathGeometry _pathGeometry_57;
            CompositionSpriteShape _spriteShape_00;
            CompositionSpriteShape _spriteShape_01;
            CompositionSpriteShape _spriteShape_02;
            CompositionSpriteShape _spriteShape_03;
            CompositionSpriteShape _spriteShape_04;
            CompositionSpriteShape _spriteShape_05;
            CompositionSpriteShape _spriteShape_06;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_00;
            CubicBezierEasingFunction _cubicBezierEasingFunction_01;
            CubicBezierEasingFunction _cubicBezierEasingFunction_02;
            CubicBezierEasingFunction _cubicBezierEasingFunction_03;
            CubicBezierEasingFunction _cubicBezierEasingFunction_04;
            CubicBezierEasingFunction _cubicBezierEasingFunction_05;
            CubicBezierEasingFunction _cubicBezierEasingFunction_06;
            CubicBezierEasingFunction _cubicBezierEasingFunction_07;
            CubicBezierEasingFunction _cubicBezierEasingFunction_08;
            CubicBezierEasingFunction _cubicBezierEasingFunction_09;
            CubicBezierEasingFunction _cubicBezierEasingFunction_10;
            ExpressionAnimation _rootProgress;
            ScalarKeyFrameAnimation _rotationAngleInDegreesScalarAnimation_0_to_0_0;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_0;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_1;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_2;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_3;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_4;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_5;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_6;
            StepEasingFunction _holdThenStepEasingFunction;
            StepEasingFunction _stepThenHoldEasingFunction;
            Vector2KeyFrameAnimation _offsetVector2Animation_2;

            static void StartProgressBoundAnimation(
                CompositionObject target,
                string animatedPropertyName,
                CompositionAnimation animation,
                ExpressionAnimation controllerProgressExpression)
            {
                target.StartAnimation(animatedPropertyName, animation);
                var controller = target.TryGetAnimationController(animatedPropertyName);
                controller.Pause();
                controller.StartAnimation("Progress", controllerProgressExpression);
            }

            void BindProperty(
                CompositionObject target,
                string animatedPropertyName,
                string expression,
                string referenceParameterName,
                CompositionObject referencedObject)
            {
                _reusableExpressionAnimation.ClearAllParameters();
                _reusableExpressionAnimation.Expression = expression;
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName, referencedObject);
                target.StartAnimation(animatedPropertyName, _reusableExpressionAnimation);
            }

            PathKeyFrameAnimation CreatePathKeyFrameAnimation(float initialProgress, CompositionPath initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreatePathKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation(float initialProgress, float initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateScalarKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_000()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-323.428986F, -225.289001F));
                    builder.AddLine(new Vector2(-338.313995F, -228.526001F));
                    builder.AddLine(new Vector2(-341.688995F, -243.380005F));
                    builder.AddCubicBezier(new Vector2(-341.80899F, -243.906006F), new Vector2(-342.277008F, -244.279999F), new Vector2(-342.816986F, -244.279999F));
                    builder.AddCubicBezier(new Vector2(-343.356995F, -244.279999F), new Vector2(-343.824005F, -243.906006F), new Vector2(-343.944F, -243.380005F));
                    builder.AddLine(new Vector2(-347.334991F, -228.457993F));
                    builder.AddLine(new Vector2(-362.225006F, -224.927994F));
                    builder.AddCubicBezier(new Vector2(-362.75F, -224.804001F), new Vector2(-363.118988F, -224.332001F), new Vector2(-363.114014F, -223.792007F));
                    builder.AddCubicBezier(new Vector2(-363.109009F, -223.251999F), new Vector2(-362.730988F, -222.789001F), new Vector2(-362.20401F, -222.673996F));
                    builder.AddLine(new Vector2(-347.320007F, -219.436005F));
                    builder.AddLine(new Vector2(-343.944F, -204.582993F));
                    builder.AddCubicBezier(new Vector2(-343.824005F, -204.057007F), new Vector2(-343.356995F, -203.682999F), new Vector2(-342.816986F, -203.682999F));
                    builder.AddCubicBezier(new Vector2(-342.277008F, -203.682999F), new Vector2(-341.80899F, -204.057007F), new Vector2(-341.688995F, -204.582993F));
                    builder.AddLine(new Vector2(-338.298004F, -219.505005F));
                    builder.AddLine(new Vector2(-323.40799F, -223.035004F));
                    builder.AddCubicBezier(new Vector2(-322.882996F, -223.158997F), new Vector2(-322.514008F, -223.630005F), new Vector2(-322.519012F, -224.169998F));
                    builder.AddCubicBezier(new Vector2(-322.523987F, -224.710007F), new Vector2(-322.902008F, -225.173996F), new Vector2(-323.428986F, -225.289001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_001()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(176.341995F, -370.881012F));
                    builder.AddLine(new Vector2(161.457001F, -374.118011F));
                    builder.AddLine(new Vector2(158.082001F, -388.971985F));
                    builder.AddCubicBezier(new Vector2(157.962006F, -389.497986F), new Vector2(157.494003F, -389.871002F), new Vector2(156.953995F, -389.871002F));
                    builder.AddCubicBezier(new Vector2(156.414001F, -389.871002F), new Vector2(155.947006F, -389.497986F), new Vector2(155.826996F, -388.971985F));
                    builder.AddLine(new Vector2(152.436005F, -374.049011F));
                    builder.AddLine(new Vector2(137.546005F, -370.519012F));
                    builder.AddCubicBezier(new Vector2(137.020996F, -370.394012F), new Vector2(136.651993F, -369.924011F), new Vector2(136.656998F, -369.384003F));
                    builder.AddCubicBezier(new Vector2(136.662003F, -368.843994F), new Vector2(137.039993F, -368.380005F), new Vector2(137.567001F, -368.265015F));
                    builder.AddLine(new Vector2(152.451004F, -365.028015F));
                    builder.AddLine(new Vector2(155.826996F, -350.174011F));
                    builder.AddCubicBezier(new Vector2(155.947006F, -349.64801F), new Vector2(156.414001F, -349.273987F), new Vector2(156.953995F, -349.273987F));
                    builder.AddCubicBezier(new Vector2(157.494003F, -349.273987F), new Vector2(157.962006F, -349.64801F), new Vector2(158.082001F, -350.174011F));
                    builder.AddLine(new Vector2(161.473007F, -365.096008F));
                    builder.AddLine(new Vector2(176.363007F, -368.626007F));
                    builder.AddCubicBezier(new Vector2(176.888F, -368.751007F), new Vector2(177.257004F, -369.221985F), new Vector2(177.251999F, -369.761993F));
                    builder.AddCubicBezier(new Vector2(177.246994F, -370.302002F), new Vector2(176.869003F, -370.765991F), new Vector2(176.341995F, -370.881012F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_002()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-296.390991F, -289.053009F));
                    builder.AddLine(new Vector2(-304.089996F, -290.727997F));
                    builder.AddLine(new Vector2(-305.835999F, -298.410004F));
                    builder.AddCubicBezier(new Vector2(-305.89801F, -298.682007F), new Vector2(-306.140015F, -298.876007F), new Vector2(-306.419006F, -298.876007F));
                    builder.AddCubicBezier(new Vector2(-306.697998F, -298.876007F), new Vector2(-306.940002F, -298.682007F), new Vector2(-307.002014F, -298.410004F));
                    builder.AddLine(new Vector2(-308.756012F, -290.692993F));
                    builder.AddLine(new Vector2(-316.457001F, -288.867004F));
                    builder.AddCubicBezier(new Vector2(-316.729004F, -288.803009F), new Vector2(-316.920013F, -288.558014F), new Vector2(-316.916992F, -288.278992F));
                    builder.AddCubicBezier(new Vector2(-316.914001F, -288F), new Vector2(-316.718994F, -287.76001F), new Vector2(-316.446014F, -287.700989F));
                    builder.AddLine(new Vector2(-308.747986F, -286.026001F));
                    builder.AddLine(new Vector2(-307.002014F, -278.343994F));
                    builder.AddCubicBezier(new Vector2(-306.940002F, -278.071991F), new Vector2(-306.697998F, -277.878998F), new Vector2(-306.419006F, -277.878998F));
                    builder.AddCubicBezier(new Vector2(-306.140015F, -277.878998F), new Vector2(-305.89801F, -278.071991F), new Vector2(-305.835999F, -278.343994F));
                    builder.AddLine(new Vector2(-304.082001F, -286.062012F));
                    builder.AddLine(new Vector2(-296.380005F, -287.888F));
                    builder.AddCubicBezier(new Vector2(-296.108002F, -287.951996F), new Vector2(-295.917999F, -288.196014F), new Vector2(-295.92099F, -288.475006F));
                    builder.AddCubicBezier(new Vector2(-295.924011F, -288.753998F), new Vector2(-296.118011F, -288.993988F), new Vector2(-296.390991F, -289.053009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_003()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(334.955994F, 366.877014F));
                    builder.AddLine(new Vector2(349.839996F, 363.639008F));
                    builder.AddLine(new Vector2(353.216003F, 348.786011F));
                    builder.AddCubicBezier(new Vector2(353.335999F, 348.26001F), new Vector2(353.803009F, 347.885986F), new Vector2(354.342987F, 347.885986F));
                    builder.AddCubicBezier(new Vector2(354.882996F, 347.885986F), new Vector2(355.350006F, 348.26001F), new Vector2(355.470001F, 348.786011F));
                    builder.AddLine(new Vector2(358.862F, 363.708008F));
                    builder.AddLine(new Vector2(373.751007F, 367.238007F));
                    builder.AddCubicBezier(new Vector2(374.276001F, 367.363007F), new Vector2(374.645996F, 367.833008F), new Vector2(374.640991F, 368.372986F));
                    builder.AddCubicBezier(new Vector2(374.635986F, 368.912994F), new Vector2(374.256989F, 369.377014F), new Vector2(373.730011F, 369.492004F));
                    builder.AddLine(new Vector2(358.846008F, 372.729004F));
                    builder.AddLine(new Vector2(355.470001F, 387.583008F));
                    builder.AddCubicBezier(new Vector2(355.350006F, 388.109009F), new Vector2(354.882996F, 388.483002F), new Vector2(354.342987F, 388.483002F));
                    builder.AddCubicBezier(new Vector2(353.803009F, 388.483002F), new Vector2(353.335999F, 388.109009F), new Vector2(353.216003F, 387.583008F));
                    builder.AddLine(new Vector2(349.825012F, 372.661011F));
                    builder.AddLine(new Vector2(334.934998F, 369.131012F));
                    builder.AddCubicBezier(new Vector2(334.410004F, 369.006012F), new Vector2(334.040985F, 368.535004F), new Vector2(334.04599F, 367.994995F));
                    builder.AddCubicBezier(new Vector2(334.050995F, 367.454987F), new Vector2(334.428986F, 366.992004F), new Vector2(334.955994F, 366.877014F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_004()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(307.917999F, 303.112F));
                    builder.AddLine(new Vector2(315.615997F, 301.437988F));
                    builder.AddLine(new Vector2(317.362F, 293.755005F));
                    builder.AddCubicBezier(new Vector2(317.424011F, 293.483002F), new Vector2(317.665985F, 293.290009F), new Vector2(317.945007F, 293.290009F));
                    builder.AddCubicBezier(new Vector2(318.223999F, 293.290009F), new Vector2(318.466003F, 293.483002F), new Vector2(318.528015F, 293.755005F));
                    builder.AddLine(new Vector2(320.282013F, 301.472992F));
                    builder.AddLine(new Vector2(327.983002F, 303.299011F));
                    builder.AddCubicBezier(new Vector2(328.255005F, 303.363007F), new Vector2(328.446014F, 303.606995F), new Vector2(328.442993F, 303.885986F));
                    builder.AddCubicBezier(new Vector2(328.440002F, 304.165009F), new Vector2(328.246002F, 304.406006F), new Vector2(327.972992F, 304.464996F));
                    builder.AddLine(new Vector2(320.273987F, 306.139008F));
                    builder.AddLine(new Vector2(318.528015F, 313.821991F));
                    builder.AddCubicBezier(new Vector2(318.466003F, 314.093994F), new Vector2(318.223999F, 314.286987F), new Vector2(317.945007F, 314.286987F));
                    builder.AddCubicBezier(new Vector2(317.665985F, 314.286987F), new Vector2(317.424011F, 314.093994F), new Vector2(317.362F, 313.821991F));
                    builder.AddLine(new Vector2(315.608002F, 306.104004F));
                    builder.AddLine(new Vector2(307.907013F, 304.278015F));
                    builder.AddCubicBezier(new Vector2(307.63501F, 304.213989F), new Vector2(307.444F, 303.970001F), new Vector2(307.446991F, 303.69101F));
                    builder.AddCubicBezier(new Vector2(307.450012F, 303.411987F), new Vector2(307.644989F, 303.17099F), new Vector2(307.917999F, 303.112F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_005()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(274.776001F, -165.860992F));
                    builder.AddLine(new Vector2(267.076996F, -167.535004F));
                    builder.AddLine(new Vector2(265.330994F, -175.216995F));
                    builder.AddCubicBezier(new Vector2(265.269012F, -175.488998F), new Vector2(265.027008F, -175.682999F), new Vector2(264.747986F, -175.682999F));
                    builder.AddCubicBezier(new Vector2(264.468994F, -175.682999F), new Vector2(264.22699F, -175.488998F), new Vector2(264.165009F, -175.216995F));
                    builder.AddLine(new Vector2(262.411011F, -167.5F));
                    builder.AddLine(new Vector2(254.710007F, -165.673996F));
                    builder.AddCubicBezier(new Vector2(254.438004F, -165.610001F), new Vector2(254.248001F, -165.365997F), new Vector2(254.25F, -165.087006F));
                    builder.AddCubicBezier(new Vector2(254.253006F, -164.807999F), new Vector2(254.447998F, -164.567001F), new Vector2(254.720993F, -164.507996F));
                    builder.AddLine(new Vector2(262.419006F, -162.834F));
                    builder.AddLine(new Vector2(264.165009F, -155.151001F));
                    builder.AddCubicBezier(new Vector2(264.22699F, -154.878998F), new Vector2(264.468994F, -154.686005F), new Vector2(264.747986F, -154.686005F));
                    builder.AddCubicBezier(new Vector2(265.027008F, -154.686005F), new Vector2(265.269012F, -154.878998F), new Vector2(265.330994F, -155.151001F));
                    builder.AddLine(new Vector2(267.084991F, -162.869003F));
                    builder.AddLine(new Vector2(274.786011F, -164.695007F));
                    builder.AddCubicBezier(new Vector2(275.058014F, -164.759003F), new Vector2(275.248993F, -165.003006F), new Vector2(275.246002F, -165.281998F));
                    builder.AddCubicBezier(new Vector2(275.243011F, -165.561005F), new Vector2(275.049011F, -165.802002F), new Vector2(274.776001F, -165.860992F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_006()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-196.037003F, 359.877014F));
                    builder.AddLine(new Vector2(-210.921005F, 356.640015F));
                    builder.AddLine(new Vector2(-214.296997F, 341.786011F));
                    builder.AddCubicBezier(new Vector2(-214.417007F, 341.26001F), new Vector2(-214.884003F, 340.885986F), new Vector2(-215.423996F, 340.885986F));
                    builder.AddCubicBezier(new Vector2(-215.964005F, 340.885986F), new Vector2(-216.431F, 341.26001F), new Vector2(-216.550995F, 341.786011F));
                    builder.AddLine(new Vector2(-219.942993F, 356.708008F));
                    builder.AddLine(new Vector2(-234.832001F, 360.238007F));
                    builder.AddCubicBezier(new Vector2(-235.356995F, 360.363007F), new Vector2(-235.727005F, 360.834015F), new Vector2(-235.722F, 361.373993F));
                    builder.AddCubicBezier(new Vector2(-235.716995F, 361.914001F), new Vector2(-235.337997F, 362.377991F), new Vector2(-234.811005F, 362.493011F));
                    builder.AddLine(new Vector2(-219.927002F, 365.730011F));
                    builder.AddLine(new Vector2(-216.550995F, 380.583008F));
                    builder.AddCubicBezier(new Vector2(-216.431F, 381.109009F), new Vector2(-215.964005F, 381.483002F), new Vector2(-215.423996F, 381.483002F));
                    builder.AddCubicBezier(new Vector2(-214.884003F, 381.483002F), new Vector2(-214.417007F, 381.109009F), new Vector2(-214.296997F, 380.583008F));
                    builder.AddLine(new Vector2(-210.904999F, 365.661011F));
                    builder.AddLine(new Vector2(-196.016006F, 362.131012F));
                    builder.AddCubicBezier(new Vector2(-195.490997F, 362.006989F), new Vector2(-195.121002F, 361.536011F), new Vector2(-195.126007F, 360.996002F));
                    builder.AddCubicBezier(new Vector2(-195.130997F, 360.455994F), new Vector2(-195.509995F, 359.992004F), new Vector2(-196.037003F, 359.877014F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_007()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(322.5F, -270.5F));
                    builder.AddCubicBezier(new Vector2(322.5F, -270.5F), new Vector2(321.75F, -281F), new Vector2(314.5F, -288.5F));
                    builder.AddCubicBezier(new Vector2(304.888F, -298.442993F), new Vector2(292.25F, -301.25F), new Vector2(292.25F, -301.25F));
                    builder.AddCubicBezier(new Vector2(292.25F, -301.25F), new Vector2(285.75F, -285.5F), new Vector2(289.945007F, -272.485992F));
                    builder.AddCubicBezier(new Vector2(293.725006F, -260.76001F), new Vector2(297.600006F, -259.757996F), new Vector2(301.5F, -257.5F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_008()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(322.5F, -270.5F));
                    builder.AddCubicBezier(new Vector2(322.5F, -270.5F), new Vector2(322.93399F, -277.399994F), new Vector2(316.078003F, -284.455994F));
                    builder.AddCubicBezier(new Vector2(306.989014F, -293.809998F), new Vector2(294.692993F, -295.289001F), new Vector2(294.692993F, -295.289001F));
                    builder.AddCubicBezier(new Vector2(294.692993F, -295.289001F), new Vector2(286.937012F, -281.144989F), new Vector2(292.575012F, -269.567993F));
                    builder.AddCubicBezier(new Vector2(297.855011F, -258.72699F), new Vector2(297.600006F, -259.757996F), new Vector2(301.5F, -257.5F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_009()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(322.5F, -270.5F));
                    builder.AddCubicBezier(new Vector2(322.5F, -270.5F), new Vector2(323.411987F, -276.65799F), new Vector2(316.556F, -283.713989F));
                    builder.AddCubicBezier(new Vector2(307.46701F, -293.067993F), new Vector2(295.074005F, -294.220001F), new Vector2(295.074005F, -294.220001F));
                    builder.AddCubicBezier(new Vector2(295.074005F, -294.220001F), new Vector2(289.006989F, -281.119995F), new Vector2(292.973999F, -268.877014F));
                    builder.AddCubicBezier(new Vector2(296.549011F, -257.845001F), new Vector2(297.600006F, -259.757996F), new Vector2(301.5F, -257.5F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_010()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(303.670013F, -278.855011F));
                    builder.AddCubicBezier(new Vector2(303.670013F, -278.855011F), new Vector2(311.556F, -298.865997F), new Vector2(297.625F, -329.846985F));
                    builder.AddCubicBezier(new Vector2(296.743011F, -331.80899F), new Vector2(293.901001F, -331.640991F), new Vector2(293.252014F, -329.589996F));
                    builder.AddCubicBezier(new Vector2(291.016998F, -322.526001F), new Vector2(287.057007F, -310.868011F), new Vector2(283.907013F, -306.208008F));
                    builder.AddLine(new Vector2(303.670013F, -278.855011F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_011()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(273.320007F, -264.634003F));
                    builder.AddCubicBezier(new Vector2(273.320007F, -264.634003F), new Vector2(252.895996F, -271.380005F), new Vector2(238.005005F, -301.911987F));
                    builder.AddCubicBezier(new Vector2(237.061996F, -303.845001F), new Vector2(239.011002F, -305.921997F), new Vector2(241.001999F, -305.108002F));
                    builder.AddCubicBezier(new Vector2(247.860001F, -302.304993F), new Vector2(259.35199F, -297.886993F), new Vector2(264.947998F, -297.325012F));
                    builder.AddLine(new Vector2(273.320007F, -264.634003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_012()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(291.567993F, -301.792999F));
                    builder.AddCubicBezier(new Vector2(289.723999F, -304.175995F), new Vector2(287.785004F, -306.60199F), new Vector2(285.744995F, -309.071014F));
                    builder.AddLine(new Vector2(261.609009F, -297.761993F));
                    builder.AddCubicBezier(new Vector2(262.200989F, -294.61499F), new Vector2(262.825012F, -291.571014F), new Vector2(263.476013F, -288.628998F));
                    builder.AddCubicBezier(new Vector2(273.365997F, -243.921005F), new Vector2(289.69101F, -222.522995F), new Vector2(302.372986F, -212.319F));
                    builder.AddLine(new Vector2(325.428986F, -223.121994F));
                    builder.AddCubicBezier(new Vector2(325.653015F, -239.375F), new Vector2(319.600006F, -265.584991F), new Vector2(291.567993F, -301.792999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_013()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(292.640015F, -238.072998F));
                    builder.AddCubicBezier(new Vector2(290.153992F, -243.378006F), new Vector2(292.438995F, -249.692993F), new Vector2(297.743988F, -252.179001F));
                    builder.AddCubicBezier(new Vector2(303.049011F, -254.664993F), new Vector2(309.364014F, -252.380005F), new Vector2(311.850006F, -247.074997F));
                    builder.AddCubicBezier(new Vector2(314.335999F, -241.770004F), new Vector2(312.050995F, -235.455002F), new Vector2(306.746002F, -232.968994F));
                    builder.AddCubicBezier(new Vector2(301.44101F, -230.483002F), new Vector2(295.126007F, -232.768005F), new Vector2(292.640015F, -238.072998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_014()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(302.372986F, -212.319F));
                    builder.AddLine(new Vector2(325.428986F, -223.121994F));
                    builder.AddCubicBezier(new Vector2(325.244995F, -209.837997F), new Vector2(320.867004F, -203.207001F), new Vector2(320.867004F, -203.207001F));
                    builder.AddLine(new Vector2(320.671997F, -203.115997F));
                    builder.AddCubicBezier(new Vector2(320.671997F, -203.115997F), new Vector2(312.739014F, -203.977997F), new Vector2(302.372986F, -212.319F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_015()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(288.727997F, -272.678009F));
                    builder.AddCubicBezier(new Vector2(287.388F, -272.049988F), new Vector2(285.790985F, -272.54599F), new Vector2(285.040985F, -273.821991F));
                    builder.AddLine(new Vector2(276.259003F, -288.777008F));
                    builder.AddCubicBezier(new Vector2(274.450989F, -291.855011F), new Vector2(272.93399F, -295.095001F), new Vector2(271.725006F, -298.45401F));
                    builder.AddLine(new Vector2(265.852997F, -314.77301F));
                    builder.AddCubicBezier(new Vector2(265.35199F, -316.165985F), new Vector2(265.993011F, -317.710999F), new Vector2(267.333008F, -318.338989F));
                    builder.AddCubicBezier(new Vector2(268.673004F, -318.96701F), new Vector2(270.272003F, -318.471008F), new Vector2(271.020996F, -317.195007F));
                    builder.AddLine(new Vector2(279.802002F, -302.239014F));
                    builder.AddCubicBezier(new Vector2(281.609985F, -299.161011F), new Vector2(283.127991F, -295.92099F), new Vector2(284.337006F, -292.562012F));
                    builder.AddLine(new Vector2(290.209015F, -276.243011F));
                    builder.AddCubicBezier(new Vector2(290.709991F, -274.850006F), new Vector2(290.067993F, -273.306F), new Vector2(288.727997F, -272.678009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 2
            CanvasGeometry Geometry_016()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-186.856995F, -190.766006F));
                    builder.AddLine(new Vector2(-141.854996F, 27.4239998F));
                    builder.AddLine(new Vector2(128.268997F, -28.2900009F));
                    builder.AddLine(new Vector2(83.2659988F, -246.479996F));
                    builder.AddCubicBezier(new Vector2(80.5899963F, -259.453003F), new Vector2(67.9039993F, -267.800995F), new Vector2(54.9309998F, -265.125F));
                    builder.AddLine(new Vector2(-168.212006F, -219.102005F));
                    builder.AddCubicBezier(new Vector2(-181.184998F, -216.425995F), new Vector2(-189.533005F, -203.738998F), new Vector2(-186.856995F, -190.766006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 2
            CanvasGeometry Geometry_017()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-175.106003F, -152.442001F));
                    builder.AddLine(new Vector2(-127.404999F, 65.1740036F));
                    builder.AddLine(new Vector2(142.007004F, 6.11999989F));
                    builder.AddLine(new Vector2(94.3059998F, -211.496002F));
                    builder.AddCubicBezier(new Vector2(91.4700012F, -224.434998F), new Vector2(78.6809998F, -232.626007F), new Vector2(65.7419968F, -229.789993F));
                    builder.AddLine(new Vector2(-156.813004F, -181.005997F));
                    builder.AddCubicBezier(new Vector2(-169.751999F, -178.169998F), new Vector2(-177.942001F, -165.380997F), new Vector2(-175.106003F, -152.442001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_018()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(286.756012F, 107.154999F));
                    builder.AddCubicBezier(new Vector2(274.549011F, 252.774994F), new Vector2(146.595993F, 360.917999F), new Vector2(0.990999997F, 348.696991F));
                    builder.AddCubicBezier(new Vector2(-48.9300003F, 344.510986F), new Vector2(-94.4420013F, 326.717987F), new Vector2(-132.197998F, 299.294006F));
                    builder.AddCubicBezier(new Vector2(-204.630005F, 246.699005F), new Vector2(-248.587006F, 158.630005F), new Vector2(-240.550995F, 62.9319992F));
                    builder.AddCubicBezier(new Vector2(-228.343994F, -82.6880035F), new Vector2(-100.390999F, -190.830994F), new Vector2(45.2140007F, -178.610001F));
                    builder.AddCubicBezier(new Vector2(169.218994F, -168.209F), new Vector2(266.050995F, -73.8820038F), new Vector2(284.515991F, 43.8089981F));
                    builder.AddCubicBezier(new Vector2(287.735992F, 64.3320007F), new Vector2(288.575989F, 85.5400009F), new Vector2(286.756012F, 107.154999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_019()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_020(), Geometry_021() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_020()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(23.5680008F, 353.846008F));
                    builder.AddCubicBezier(new Vector2(15.9569998F, 353.846008F), new Vector2(8.31099987F, 353.526001F), new Vector2(0.638999999F, 352.881989F));
                    builder.AddCubicBezier(new Vector2(-48.3269997F, 348.777008F), new Vector2(-95.1139984F, 331.420013F), new Vector2(-134.666F, 302.691986F));
                    builder.AddCubicBezier(new Vector2(-171.425003F, 276F), new Vector2(-201.054001F, 240.166F), new Vector2(-220.350998F, 199.061996F));
                    builder.AddCubicBezier(new Vector2(-240.242996F, 156.690994F), new Vector2(-248.675003F, 109.496002F), new Vector2(-244.735992F, 62.5810013F));
                    builder.AddCubicBezier(new Vector2(-238.738007F, -8.96399975F), new Vector2(-205.238007F, -73.8899994F), new Vector2(-150.404007F, -120.236F));
                    builder.AddCubicBezier(new Vector2(-95.5709991F, -166.582001F), new Vector2(-25.9750004F, -188.798996F), new Vector2(45.5660019F, -182.794006F));
                    builder.AddCubicBezier(new Vector2(106.778F, -177.660004F), new Vector2(162.714005F, -152.727997F), new Vector2(207.322998F, -110.691002F));
                    builder.AddCubicBezier(new Vector2(250.613007F, -69.8990021F), new Vector2(279.5F, -15.2609997F), new Vector2(288.665985F, 43.1580009F));
                    builder.AddCubicBezier(new Vector2(291.988007F, 64.3349991F), new Vector2(292.752991F, 85.9860001F), new Vector2(290.940002F, 107.508003F));
                    builder.AddLine(new Vector2(290.94101F, 107.505997F));
                    builder.AddCubicBezier(new Vector2(284.944F, 179.052002F), new Vector2(251.442001F, 243.977997F), new Vector2(196.608994F, 290.324005F));
                    builder.AddCubicBezier(new Vector2(147.656998F, 331.700012F), new Vector2(86.9329987F, 353.846008F), new Vector2(23.5680008F, 353.846008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_021()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(22.6520004F, -175.358002F));
                    builder.AddCubicBezier(new Vector2(-38.7369995F, -175.358002F), new Vector2(-97.5559998F, -153.906998F), new Vector2(-144.981995F, -113.821999F));
                    builder.AddCubicBezier(new Vector2(-198.102005F, -68.9229965F), new Vector2(-230.556F, -6.02600002F), new Vector2(-236.365997F, 63.2830009F));
                    builder.AddCubicBezier(new Vector2(-244.056F, 154.867996F), new Vector2(-204.192001F, 241.826996F), new Vector2(-129.729996F, 295.895996F));
                    builder.AddCubicBezier(new Vector2(-91.4199982F, 323.723999F), new Vector2(-46.0960007F, 340.533997F), new Vector2(1.34099996F, 344.511993F));
                    builder.AddCubicBezier(new Vector2(70.6529999F, 350.337006F), new Vector2(138.069F, 328.807007F), new Vector2(191.186996F, 283.910004F));
                    builder.AddCubicBezier(new Vector2(244.307007F, 239.011002F), new Vector2(276.760986F, 176.113998F), new Vector2(282.570007F, 106.805F));
                    builder.AddLine(new Vector2(282.571014F, 106.803001F));
                    builder.AddCubicBezier(new Vector2(284.326996F, 85.9509964F), new Vector2(283.584991F, 64.9749985F), new Vector2(280.367004F, 44.4599991F));
                    builder.AddCubicBezier(new Vector2(261.72699F, -74.348999F), new Vector2(164.884003F, -164.356995F), new Vector2(44.862999F, -174.423996F));
                    builder.AddCubicBezier(new Vector2(37.4350014F, -175.048004F), new Vector2(30.0209999F, -175.358002F), new Vector2(22.6520004F, -175.358002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_022()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(105.046997F, 141.397995F));
                    builder.AddCubicBezier(new Vector2(81.8779984F, 143.386002F), new Vector2(61.4119987F, 129.707993F), new Vector2(56.6100006F, 110.095001F));
                    builder.AddCubicBezier(new Vector2(56.1619987F, 108.275002F), new Vector2(55.8540001F, 106.386002F), new Vector2(55.6860008F, 104.468002F));
                    builder.AddCubicBezier(new Vector2(55.0839996F, 97.4120026F), new Vector2(56.5110016F, 90.5950012F), new Vector2(59.5489998F, 84.4909973F));
                    builder.AddCubicBezier(new Vector2(66.2269974F, 71.0940018F), new Vector2(80.6179962F, 61.1539993F), new Vector2(98.0189972F, 59.6559982F));
                    builder.AddCubicBezier(new Vector2(114.454002F, 58.2560005F), new Vector2(129.531006F, 64.723999F), new Vector2(138.602997F, 75.6009979F));
                    builder.AddCubicBezier(new Vector2(140.380997F, 77.7289963F), new Vector2(141.921005F, 80.0250015F), new Vector2(143.209F, 82.4609985F));
                    builder.AddCubicBezier(new Vector2(145.490997F, 86.7730026F), new Vector2(146.945999F, 91.5319977F), new Vector2(147.380005F, 96.5859985F));
                    builder.AddCubicBezier(new Vector2(149.326004F, 119.153F), new Vector2(130.358002F, 139.214005F), new Vector2(105.046997F, 141.397995F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_023()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_024(), Geometry_025() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_024()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(100.672997F, 145.785004F));
                    builder.AddCubicBezier(new Vector2(77.7590027F, 145.785004F), new Vector2(57.5239983F, 131.490005F), new Vector2(52.5299988F, 111.094002F));
                    builder.AddCubicBezier(new Vector2(52.0369987F, 109.086998F), new Vector2(51.6910019F, 106.980003F), new Vector2(51.5019989F, 104.834999F));
                    builder.AddCubicBezier(new Vector2(50.8540001F, 97.2360001F), new Vector2(52.3370018F, 89.5569992F), new Vector2(55.7900009F, 82.6190033F));
                    builder.AddCubicBezier(new Vector2(63.3530006F, 67.4459991F), new Vector2(79.3949966F, 57.0439987F), new Vector2(97.6589966F, 55.4720001F));
                    builder.AddCubicBezier(new Vector2(114.982002F, 53.993F), new Vector2(131.490997F, 60.5169983F), new Vector2(141.828003F, 72.9120026F));
                    builder.AddCubicBezier(new Vector2(143.781006F, 75.2480011F), new Vector2(145.494003F, 77.8010025F), new Vector2(146.921005F, 80.4970016F));
                    builder.AddCubicBezier(new Vector2(149.529007F, 85.4260025F), new Vector2(151.091003F, 90.7180023F), new Vector2(151.563995F, 96.2269974F));
                    builder.AddCubicBezier(new Vector2(153.705002F, 121.059998F), new Vector2(132.998993F, 143.201004F), new Vector2(105.406998F, 145.582001F));
                    builder.AddLine(new Vector2(105.404999F, 145.582001F));
                    builder.AddCubicBezier(new Vector2(103.818001F, 145.718002F), new Vector2(102.238998F, 145.785004F), new Vector2(100.672997F, 145.785004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_025()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(102.495003F, 63.6650009F));
                    builder.AddCubicBezier(new Vector2(101.130997F, 63.6650009F), new Vector2(99.7570038F, 63.7229996F), new Vector2(98.375F, 63.8409996F));
                    builder.AddCubicBezier(new Vector2(83.0110016F, 65.1640015F), new Vector2(69.572998F, 73.7939987F), new Vector2(63.3079987F, 86.3649979F));
                    builder.AddCubicBezier(new Vector2(60.5429993F, 91.9209976F), new Vector2(59.3530006F, 98.0569992F), new Vector2(59.8699989F, 104.110001F));
                    builder.AddCubicBezier(new Vector2(60.0200005F, 105.818001F), new Vector2(60.2949982F, 107.498001F), new Vector2(60.6870003F, 109.093002F));
                    builder.AddCubicBezier(new Vector2(65.0479965F, 126.903F), new Vector2(83.9629974F, 138.992996F), new Vector2(104.685997F, 137.212997F));
                    builder.AddCubicBezier(new Vector2(127.664001F, 135.229996F), new Vector2(144.938995F, 117.167F), new Vector2(143.195999F, 96.9469986F));
                    builder.AddCubicBezier(new Vector2(142.819F, 92.5650024F), new Vector2(141.574997F, 88.3529968F), new Vector2(139.496002F, 84.4250031F));
                    builder.AddCubicBezier(new Vector2(138.343994F, 82.2460022F), new Vector2(136.959F, 80.1839981F), new Vector2(135.380005F, 78.2939987F));
                    builder.AddCubicBezier(new Vector2(127.609001F, 68.9759979F), new Vector2(115.533997F, 63.6650009F), new Vector2(102.495003F, 63.6650009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_026()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(286.756012F, 107.154999F));
                    builder.AddCubicBezier(new Vector2(274.549011F, 252.774994F), new Vector2(146.595993F, 360.917999F), new Vector2(0.990999997F, 348.696991F));
                    builder.AddCubicBezier(new Vector2(-48.9300003F, 344.510986F), new Vector2(-94.4420013F, 326.717987F), new Vector2(-132.197998F, 299.294006F));
                    builder.AddCubicBezier(new Vector2(-17.3349991F, 335.286011F), new Vector2(245.850006F, 314.286987F), new Vector2(284.515991F, 43.8089981F));
                    builder.AddCubicBezier(new Vector2(287.735992F, 64.3320007F), new Vector2(288.575989F, 85.5400009F), new Vector2(286.756012F, 107.154999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_027()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(138.602997F, 75.6009979F));
                    builder.AddCubicBezier(new Vector2(96.1289978F, 73.1230011F), new Vector2(70.4970016F, 93.1699982F), new Vector2(56.6100006F, 110.095001F));
                    builder.AddCubicBezier(new Vector2(56.1619987F, 108.275002F), new Vector2(55.8540001F, 106.386002F), new Vector2(55.6860008F, 104.468002F));
                    builder.AddCubicBezier(new Vector2(55.0839996F, 97.4120026F), new Vector2(56.5110016F, 90.5950012F), new Vector2(59.5489998F, 84.4909973F));
                    builder.AddCubicBezier(new Vector2(66.2269974F, 71.0940018F), new Vector2(80.6179962F, 61.1539993F), new Vector2(98.0189972F, 59.6559982F));
                    builder.AddCubicBezier(new Vector2(114.454002F, 58.2560005F), new Vector2(129.531006F, 64.723999F), new Vector2(138.602997F, 75.6009979F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_028()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-16.243F, -37.7459984F));
                    builder.AddCubicBezier(new Vector2(-33.7910004F, -36.2400017F), new Vector2(-49.2929993F, -46.598999F), new Vector2(-52.9300003F, -61.4539986F));
                    builder.AddCubicBezier(new Vector2(-53.269001F, -62.8320007F), new Vector2(-53.5029984F, -64.2639999F), new Vector2(-53.6300011F, -65.7170029F));
                    builder.AddCubicBezier(new Vector2(-54.0859985F, -71.060997F), new Vector2(-53.0040016F, -76.223999F), new Vector2(-50.7029991F, -80.8470001F));
                    builder.AddCubicBezier(new Vector2(-45.6450005F, -90.9940033F), new Vector2(-34.7459984F, -98.5220032F), new Vector2(-21.566F, -99.6569977F));
                    builder.AddCubicBezier(new Vector2(-9.11800003F, -100.717003F), new Vector2(2.30200005F, -95.8190002F), new Vector2(9.17300034F, -87.5800018F));
                    builder.AddCubicBezier(new Vector2(10.5200005F, -85.9680023F), new Vector2(11.6859999F, -84.2300034F), new Vector2(12.6610003F, -82.3850021F));
                    builder.AddCubicBezier(new Vector2(14.3889999F, -79.1190033F), new Vector2(15.4919996F, -75.5139999F), new Vector2(15.8210001F, -71.685997F));
                    builder.AddCubicBezier(new Vector2(17.2950001F, -54.5940018F), new Vector2(2.92799997F, -39.4000015F), new Vector2(-16.243F, -37.7459984F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_029()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_030(), Geometry_031() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_030()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-19.5529995F, -33.4039993F));
                    builder.AddCubicBezier(new Vector2(-37.3730011F, -33.4039993F), new Vector2(-53.1160011F, -44.5519981F), new Vector2(-57.0089989F, -60.4550018F));
                    builder.AddCubicBezier(new Vector2(-57.3950005F, -62.0229988F), new Vector2(-57.6669998F, -63.6720009F), new Vector2(-57.8139992F, -65.3499985F));
                    builder.AddCubicBezier(new Vector2(-58.3209991F, -71.2929993F), new Vector2(-57.1619987F, -77.2959976F), new Vector2(-54.4640007F, -82.7190018F));
                    builder.AddCubicBezier(new Vector2(-48.5769997F, -94.5279999F), new Vector2(-36.1100006F, -102.621002F), new Vector2(-21.9260006F, -103.842003F));
                    builder.AddCubicBezier(new Vector2(-8.46800041F, -104.995003F), new Vector2(4.35599995F, -99.9140015F), new Vector2(12.3979998F, -90.2710037F));
                    builder.AddCubicBezier(new Vector2(13.9239998F, -88.4440002F), new Vector2(15.2639999F, -86.4499969F), new Vector2(16.375F, -84.3479996F));
                    builder.AddCubicBezier(new Vector2(18.4139996F, -80.4940033F), new Vector2(19.6350002F, -76.3550034F), new Vector2(20.0049992F, -72.0459976F));
                    builder.AddCubicBezier(new Vector2(21.6760006F, -52.6780014F), new Vector2(5.57700014F, -35.4140015F), new Vector2(-15.882F, -33.5620003F));
                    builder.AddLine(new Vector2(-15.8839998F, -33.5610008F));
                    builder.AddCubicBezier(new Vector2(-17.1140003F, -33.4560013F), new Vector2(-18.3390007F, -33.4039993F), new Vector2(-19.5529995F, -33.4039993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_031()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-18.1749992F, -95.6019974F));
                    builder.AddCubicBezier(new Vector2(-19.1800003F, -95.6019974F), new Vector2(-20.191F, -95.5599976F), new Vector2(-21.2089996F, -95.4729996F));
                    builder.AddCubicBezier(new Vector2(-32.493F, -94.5019989F), new Vector2(-42.355999F, -88.1790009F), new Vector2(-46.9440002F, -78.973999F));
                    builder.AddCubicBezier(new Vector2(-48.9550018F, -74.9329987F), new Vector2(-49.8199997F, -70.4720001F), new Vector2(-49.4449997F, -66.072998F));
                    builder.AddCubicBezier(new Vector2(-49.3359985F, -64.8339996F), new Vector2(-49.137001F, -63.6150017F), new Vector2(-48.8520012F, -62.4589996F));
                    builder.AddCubicBezier(new Vector2(-45.6669998F, -49.4500008F), new Vector2(-31.802F, -40.6269989F), new Vector2(-16.6030006F, -41.9300003F));
                    builder.AddCubicBezier(new Vector2(0.240999997F, -43.3839989F), new Vector2(12.9099998F, -56.5699997F), new Vector2(11.6370001F, -71.3249969F));
                    builder.AddCubicBezier(new Vector2(11.3640003F, -74.5080032F), new Vector2(10.4589996F, -77.5670013F), new Vector2(8.94900036F, -80.4209976F));
                    builder.AddCubicBezier(new Vector2(8.11100006F, -82.0049973F), new Vector2(7.10200024F, -83.5080032F), new Vector2(5.94999981F, -84.8880005F));
                    builder.AddCubicBezier(new Vector2(0.256999999F, -91.7129974F), new Vector2(-8.60000038F, -95.6019974F), new Vector2(-18.1749992F, -95.6019974F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_032()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(9.17300034F, -87.5800018F));
                    builder.AddCubicBezier(new Vector2(-22.9969997F, -89.4570007F), new Vector2(-42.4119987F, -74.2730026F), new Vector2(-52.9300003F, -61.4539986F));
                    builder.AddCubicBezier(new Vector2(-53.269001F, -62.8320007F), new Vector2(-53.5029984F, -64.2639999F), new Vector2(-53.6300011F, -65.7170029F));
                    builder.AddCubicBezier(new Vector2(-54.0859985F, -71.060997F), new Vector2(-53.0040016F, -76.223999F), new Vector2(-50.7029991F, -80.8470001F));
                    builder.AddCubicBezier(new Vector2(-45.6450005F, -90.9940033F), new Vector2(-34.7459984F, -98.5220032F), new Vector2(-21.566F, -99.6569977F));
                    builder.AddCubicBezier(new Vector2(-9.11800003F, -100.717003F), new Vector2(2.30200005F, -95.8190002F), new Vector2(9.17300034F, -87.5800018F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_033()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(72.7890015F, 254.018997F));
                    builder.AddCubicBezier(new Vector2(64.0979996F, 254.764999F), new Vector2(56.4189987F, 249.634003F), new Vector2(54.618F, 242.276993F));
                    builder.AddCubicBezier(new Vector2(54.4500008F, 241.593994F), new Vector2(54.3349991F, 240.884995F), new Vector2(54.2719994F, 240.166F));
                    builder.AddCubicBezier(new Vector2(54.0460014F, 237.518997F), new Vector2(54.5810013F, 234.962006F), new Vector2(55.7210007F, 232.671997F));
                    builder.AddCubicBezier(new Vector2(58.2260017F, 227.645996F), new Vector2(63.625F, 223.917007F), new Vector2(70.1529999F, 223.354996F));
                    builder.AddCubicBezier(new Vector2(76.3180008F, 222.830002F), new Vector2(81.973999F, 225.257004F), new Vector2(85.3769989F, 229.337006F));
                    builder.AddCubicBezier(new Vector2(86.0439987F, 230.134995F), new Vector2(86.6210022F, 230.996002F), new Vector2(87.1039963F, 231.910004F));
                    builder.AddCubicBezier(new Vector2(87.9599991F, 233.528F), new Vector2(88.5059967F, 235.313004F), new Vector2(88.6689987F, 237.209F));
                    builder.AddCubicBezier(new Vector2(89.3990021F, 245.675003F), new Vector2(82.2839966F, 253.199997F), new Vector2(72.7890015F, 254.018997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_034()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_035(), Geometry_036() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_035()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(71.1549988F, 258.289001F));
                    builder.AddCubicBezier(new Vector2(61.3660011F, 258.289001F), new Vector2(52.6990013F, 252.098999F), new Vector2(50.5390015F, 243.274994F));
                    builder.AddCubicBezier(new Vector2(50.3219986F, 242.397003F), new Vector2(50.1710014F, 241.470993F), new Vector2(50.0880013F, 240.531006F));
                    builder.AddCubicBezier(new Vector2(49.8030014F, 237.197006F), new Vector2(50.4510002F, 233.834F), new Vector2(51.9620018F, 230.800003F));
                    builder.AddCubicBezier(new Vector2(55.2050018F, 224.294006F), new Vector2(62.0359993F, 219.839005F), new Vector2(69.7919998F, 219.171997F));
                    builder.AddCubicBezier(new Vector2(77.1460037F, 218.544006F), new Vector2(84.1760025F, 221.339005F), new Vector2(88.6019974F, 226.647003F));
                    builder.AddCubicBezier(new Vector2(89.4509964F, 227.662994F), new Vector2(90.1969986F, 228.774002F), new Vector2(90.8170013F, 229.947006F));
                    builder.AddCubicBezier(new Vector2(91.9609985F, 232.108002F), new Vector2(92.6460037F, 234.431F), new Vector2(92.8539963F, 236.850006F));
                    builder.AddCubicBezier(new Vector2(93.7809982F, 247.604996F), new Vector2(84.9430008F, 257.184998F), new Vector2(73.1500015F, 258.203003F));
                    builder.AddLine(new Vector2(73.1480026F, 258.20401F));
                    builder.AddCubicBezier(new Vector2(72.4800034F, 258.260986F), new Vector2(71.8150024F, 258.289001F), new Vector2(71.1549988F, 258.289001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_036()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(71.7809982F, 227.485992F));
                    builder.AddCubicBezier(new Vector2(71.3590012F, 227.485992F), new Vector2(70.9339981F, 227.503998F), new Vector2(70.5090027F, 227.539993F));
                    builder.AddCubicBezier(new Vector2(65.6520004F, 227.957993F), new Vector2(61.4249992F, 230.641998F), new Vector2(59.4799995F, 234.544998F));
                    builder.AddCubicBezier(new Vector2(58.6459999F, 236.220001F), new Vector2(58.3019981F, 237.992004F), new Vector2(58.4570007F, 239.807999F));
                    builder.AddCubicBezier(new Vector2(58.5009995F, 240.309998F), new Vector2(58.5810013F, 240.804993F), new Vector2(58.6959991F, 241.272003F));
                    builder.AddCubicBezier(new Vector2(60.0289993F, 246.714005F), new Vector2(65.939003F, 250.386002F), new Vector2(72.4300003F, 249.835007F));
                    builder.AddCubicBezier(new Vector2(79.6070023F, 249.214005F), new Vector2(85.0149994F, 243.712006F), new Vector2(84.4850006F, 237.570007F));
                    builder.AddCubicBezier(new Vector2(84.3740005F, 236.276993F), new Vector2(84.0059967F, 235.035004F), new Vector2(83.3919983F, 233.875F));
                    builder.AddCubicBezier(new Vector2(83.0449982F, 233.220001F), new Vector2(82.6299973F, 232.598999F), new Vector2(82.1539993F, 232.029999F));
                    builder.AddCubicBezier(new Vector2(79.7659988F, 229.167007F), new Vector2(75.8769989F, 227.485992F), new Vector2(71.7809982F, 227.485992F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_037()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(85.3769989F, 229.337006F));
                    builder.AddCubicBezier(new Vector2(69.4440002F, 228.408005F), new Vector2(59.8269997F, 235.927994F), new Vector2(54.618F, 242.276993F));
                    builder.AddCubicBezier(new Vector2(54.4500008F, 241.593994F), new Vector2(54.3349991F, 240.884995F), new Vector2(54.2719994F, 240.166F));
                    builder.AddCubicBezier(new Vector2(54.0460014F, 237.518997F), new Vector2(54.5810013F, 234.962006F), new Vector2(55.7210007F, 232.671997F));
                    builder.AddCubicBezier(new Vector2(58.2260017F, 227.645996F), new Vector2(63.625F, 223.917007F), new Vector2(70.1529999F, 223.354996F));
                    builder.AddCubicBezier(new Vector2(76.3180008F, 222.830002F), new Vector2(81.973999F, 225.257004F), new Vector2(85.3769989F, 229.337006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_038()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-102.068001F, 228.744995F));
                    builder.AddCubicBezier(new Vector2(-119.850998F, 230.270996F), new Vector2(-135.559998F, 219.772995F), new Vector2(-139.244995F, 204.720001F));
                    builder.AddCubicBezier(new Vector2(-139.589005F, 203.322998F), new Vector2(-139.824997F, 201.871994F), new Vector2(-139.953995F, 200.399994F));
                    builder.AddCubicBezier(new Vector2(-140.416F, 194.985001F), new Vector2(-139.320007F, 189.751999F), new Vector2(-136.988007F, 185.067001F));
                    builder.AddCubicBezier(new Vector2(-131.863007F, 174.783997F), new Vector2(-120.818001F, 167.156006F), new Vector2(-107.461998F, 166.005997F));
                    builder.AddCubicBezier(new Vector2(-94.8479996F, 164.931F), new Vector2(-83.2750015F, 169.895004F), new Vector2(-76.3119965F, 178.244003F));
                    builder.AddCubicBezier(new Vector2(-74.9469986F, 179.876999F), new Vector2(-73.7649994F, 181.639008F), new Vector2(-72.7770004F, 183.509003F));
                    builder.AddCubicBezier(new Vector2(-71.026001F, 186.817993F), new Vector2(-69.9079971F, 190.472F), new Vector2(-69.5749969F, 194.350998F));
                    builder.AddCubicBezier(new Vector2(-68.0810013F, 211.671997F), new Vector2(-82.6409988F, 227.069F), new Vector2(-102.068001F, 228.744995F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_039()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_040(), Geometry_041() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_040()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-105.421997F, 233.089005F));
                    builder.AddCubicBezier(new Vector2(-123.454002F, 233.089005F), new Vector2(-139.384995F, 221.809998F), new Vector2(-143.324005F, 205.718994F));
                    builder.AddCubicBezier(new Vector2(-143.714996F, 204.130005F), new Vector2(-143.990005F, 202.462997F), new Vector2(-144.138F, 200.768005F));
                    builder.AddCubicBezier(new Vector2(-144.651001F, 194.755005F), new Vector2(-143.479004F, 188.682007F), new Vector2(-140.748001F, 183.195999F));
                    builder.AddCubicBezier(new Vector2(-134.792999F, 171.246994F), new Vector2(-122.177002F, 163.057007F), new Vector2(-107.821999F, 161.822006F));
                    builder.AddCubicBezier(new Vector2(-94.2099991F, 160.651993F), new Vector2(-81.2259979F, 165.796005F), new Vector2(-73.086998F, 175.554993F));
                    builder.AddCubicBezier(new Vector2(-71.5439987F, 177.401993F), new Vector2(-70.189003F, 179.417999F), new Vector2(-69.064003F, 181.546005F));
                    builder.AddCubicBezier(new Vector2(-67.0009995F, 185.445999F), new Vector2(-65.7659988F, 189.632996F), new Vector2(-65.3909988F, 193.992004F));
                    builder.AddCubicBezier(new Vector2(-63.7010002F, 213.587997F), new Vector2(-79.9929962F, 231.057007F), new Vector2(-101.707001F, 232.929993F));
                    builder.AddLine(new Vector2(-101.709F, 232.929993F));
                    builder.AddCubicBezier(new Vector2(-102.954002F, 233.037003F), new Vector2(-104.194F, 233.089005F), new Vector2(-105.421997F, 233.089005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_041()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-104.025002F, 170.059998F));
                    builder.AddCubicBezier(new Vector2(-105.045998F, 170.059998F), new Vector2(-106.071999F, 170.102997F), new Vector2(-107.105003F, 170.190994F));
                    builder.AddCubicBezier(new Vector2(-118.558998F, 171.177002F), new Vector2(-128.570999F, 177.595001F), new Vector2(-133.229004F, 186.940994F));
                    builder.AddCubicBezier(new Vector2(-135.270996F, 191.044006F), new Vector2(-136.151001F, 195.576004F), new Vector2(-135.770004F, 200.044006F));
                    builder.AddCubicBezier(new Vector2(-135.660004F, 201.300995F), new Vector2(-135.455994F, 202.541F), new Vector2(-135.167007F, 203.716995F));
                    builder.AddCubicBezier(new Vector2(-131.934006F, 216.925003F), new Vector2(-117.861F, 225.882004F), new Vector2(-102.429001F, 224.561005F));
                    builder.AddCubicBezier(new Vector2(-85.3290024F, 223.085007F), new Vector2(-72.4680023F, 209.695999F), new Vector2(-73.7600021F, 194.712006F));
                    builder.AddCubicBezier(new Vector2(-74.038002F, 191.479996F), new Vector2(-74.9550018F, 188.373001F), new Vector2(-76.4899979F, 185.473007F));
                    builder.AddCubicBezier(new Vector2(-77.3410034F, 183.863007F), new Vector2(-78.3649979F, 182.337006F), new Vector2(-79.5350037F, 180.936996F));
                    builder.AddCubicBezier(new Vector2(-85.314003F, 174.007996F), new Vector2(-94.3059998F, 170.059998F), new Vector2(-104.025002F, 170.059998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_042()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-76.3119965F, 178.244003F));
                    builder.AddCubicBezier(new Vector2(-108.912003F, 176.341995F), new Vector2(-128.585999F, 191.729004F), new Vector2(-139.244995F, 204.720001F));
                    builder.AddCubicBezier(new Vector2(-139.589005F, 203.322998F), new Vector2(-139.824997F, 201.871994F), new Vector2(-139.953995F, 200.399994F));
                    builder.AddCubicBezier(new Vector2(-140.416F, 194.985001F), new Vector2(-139.320007F, 189.751999F), new Vector2(-136.988007F, 185.067001F));
                    builder.AddCubicBezier(new Vector2(-131.863007F, 174.783997F), new Vector2(-120.818001F, 167.156006F), new Vector2(-107.461998F, 166.005997F));
                    builder.AddCubicBezier(new Vector2(-94.8479996F, 164.931F), new Vector2(-83.2750015F, 169.895004F), new Vector2(-76.3119965F, 178.244003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_043()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-68.2399979F, 59.1570015F));
                    builder.AddCubicBezier(new Vector2(-78.4449997F, 60.0330009F), new Vector2(-87.4599991F, 54.0079994F), new Vector2(-89.5749969F, 45.3689995F));
                    builder.AddCubicBezier(new Vector2(-89.7720032F, 44.5670013F), new Vector2(-89.9079971F, 43.7360001F), new Vector2(-89.9820023F, 42.8909988F));
                    builder.AddCubicBezier(new Vector2(-90.2470016F, 39.7830009F), new Vector2(-89.6179962F, 36.7799988F), new Vector2(-88.2799988F, 34.0909996F));
                    builder.AddCubicBezier(new Vector2(-85.3389969F, 28.1900005F), new Vector2(-79F, 23.8120003F), new Vector2(-71.3349991F, 23.1520004F));
                    builder.AddCubicBezier(new Vector2(-64.0960007F, 22.5349998F), new Vector2(-57.4550018F, 25.3850002F), new Vector2(-53.4589996F, 30.1760006F));
                    builder.AddCubicBezier(new Vector2(-52.6759987F, 31.1130009F), new Vector2(-51.9970016F, 32.1240005F), new Vector2(-51.4300003F, 33.1969986F));
                    builder.AddCubicBezier(new Vector2(-50.4249992F, 35.0960007F), new Vector2(-49.7840004F, 37.1930008F), new Vector2(-49.5929985F, 39.4189987F));
                    builder.AddCubicBezier(new Vector2(-48.7360001F, 49.3590012F), new Vector2(-57.0909996F, 58.1949997F), new Vector2(-68.2399979F, 59.1570015F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_044()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_045(), Geometry_046() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_045()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-70.1610031F, 63.4399986F));
                    builder.AddCubicBezier(new Vector2(-81.3219986F, 63.4399986F), new Vector2(-91.1969986F, 56.4029999F), new Vector2(-93.6539993F, 46.368F));
                    builder.AddCubicBezier(new Vector2(-93.9000015F, 45.3670006F), new Vector2(-94.072998F, 44.3180008F), new Vector2(-94.1660004F, 43.2560005F));
                    builder.AddCubicBezier(new Vector2(-94.4889984F, 39.4749985F), new Vector2(-93.7529984F, 35.6619987F), new Vector2(-92.0390015F, 32.2200012F));
                    builder.AddCubicBezier(new Vector2(-88.3450012F, 24.8080006F), new Vector2(-80.5500031F, 19.7310009F), new Vector2(-71.6949997F, 18.9680004F));
                    builder.AddCubicBezier(new Vector2(-63.3019981F, 18.25F), new Vector2(-55.2789993F, 21.4370003F), new Vector2(-50.2340012F, 27.4860001F));
                    builder.AddCubicBezier(new Vector2(-49.2719994F, 28.6389999F), new Vector2(-48.4230003F, 29.8999996F), new Vector2(-47.7179985F, 31.2329998F));
                    builder.AddCubicBezier(new Vector2(-46.4210014F, 33.6829987F), new Vector2(-45.644001F, 36.3170013F), new Vector2(-45.4080009F, 39.0589981F));
                    builder.AddCubicBezier(new Vector2(-44.3540001F, 51.2879982F), new Vector2(-54.4350014F, 62.1819992F), new Vector2(-67.8789978F, 63.3409996F));
                    builder.AddLine(new Vector2(-67.8809967F, 63.3419991F));
                    builder.AddCubicBezier(new Vector2(-68.6449966F, 63.4070015F), new Vector2(-69.4059982F, 63.4399986F), new Vector2(-70.1610031F, 63.4399986F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_046()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-69.3619995F, 27.2679996F));
                    builder.AddCubicBezier(new Vector2(-69.8970032F, 27.2679996F), new Vector2(-70.435997F, 27.2910004F), new Vector2(-70.9789963F, 27.3369999F));
                    builder.AddCubicBezier(new Vector2(-76.9329987F, 27.8500004F), new Vector2(-82.1240005F, 31.1560001F), new Vector2(-84.5210037F, 35.9650002F));
                    builder.AddCubicBezier(new Vector2(-85.560997F, 38.0540009F), new Vector2(-85.9909973F, 40.2649994F), new Vector2(-85.7969971F, 42.5340004F));
                    builder.AddCubicBezier(new Vector2(-85.7419968F, 43.1590004F), new Vector2(-85.6409988F, 43.7779999F), new Vector2(-85.4970016F, 44.3670006F));
                    builder.AddCubicBezier(new Vector2(-83.848999F, 51.098999F), new Vector2(-76.5810013F, 55.651001F), new Vector2(-68.6009979F, 54.9729996F));
                    builder.AddCubicBezier(new Vector2(-59.7709999F, 54.2109985F), new Vector2(-53.1209984F, 47.3950005F), new Vector2(-53.7770004F, 39.7789993F));
                    builder.AddCubicBezier(new Vector2(-53.9160004F, 38.1650009F), new Vector2(-54.375F, 36.6119995F), new Vector2(-55.1419983F, 35.1619987F));
                    builder.AddCubicBezier(new Vector2(-55.5730019F, 34.3470001F), new Vector2(-56.0919991F, 33.5750008F), new Vector2(-56.6819992F, 32.8689995F));
                    builder.AddCubicBezier(new Vector2(-59.6590004F, 29.2989998F), new Vector2(-64.3130035F, 27.2679996F), new Vector2(-69.3619995F, 27.2679996F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_047()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-53.4589996F, 30.1760006F));
                    builder.AddCubicBezier(new Vector2(-72.1669998F, 29.0849991F), new Vector2(-83.4580002F, 37.9140015F), new Vector2(-89.5749969F, 45.3689995F));
                    builder.AddCubicBezier(new Vector2(-89.7720032F, 44.5670013F), new Vector2(-89.9079971F, 43.7360001F), new Vector2(-89.9820023F, 42.8909988F));
                    builder.AddCubicBezier(new Vector2(-90.2470016F, 39.7830009F), new Vector2(-89.6179962F, 36.7799988F), new Vector2(-88.2799988F, 34.0909996F));
                    builder.AddCubicBezier(new Vector2(-85.3389969F, 28.1900005F), new Vector2(-79F, 23.8120003F), new Vector2(-71.3349991F, 23.1520004F));
                    builder.AddCubicBezier(new Vector2(-64.0960007F, 22.5349998F), new Vector2(-57.4550018F, 25.3850002F), new Vector2(-53.4589996F, 30.1760006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_048()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(182.306F, 29.7749996F));
                    builder.AddCubicBezier(new Vector2(174.085999F, 30.4799995F), new Vector2(166.824005F, 25.6280003F), new Vector2(165.119995F, 18.6690006F));
                    builder.AddCubicBezier(new Vector2(164.960999F, 18.0230007F), new Vector2(164.852005F, 17.3519993F), new Vector2(164.792007F, 16.6720009F));
                    builder.AddCubicBezier(new Vector2(164.578003F, 14.1689997F), new Vector2(165.085007F, 11.75F), new Vector2(166.162994F, 9.58399963F));
                    builder.AddCubicBezier(new Vector2(168.531998F, 4.83099985F), new Vector2(173.638F, 1.30400002F), new Vector2(179.811996F, 0.773000002F));
                    builder.AddCubicBezier(new Vector2(185.643005F, 0.275999993F), new Vector2(190.992996F, 2.5710001F), new Vector2(194.212006F, 6.42999983F));
                    builder.AddCubicBezier(new Vector2(194.843002F, 7.18499994F), new Vector2(195.389008F, 8F), new Vector2(195.845993F, 8.86400032F));
                    builder.AddCubicBezier(new Vector2(196.656006F, 10.3940001F), new Vector2(197.171997F, 12.0830002F), new Vector2(197.326004F, 13.8760004F));
                    builder.AddCubicBezier(new Vector2(198.016006F, 21.8829994F), new Vector2(191.285995F, 29F), new Vector2(182.306F, 29.7749996F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_049()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_050(), Geometry_051() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_050()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(180.759995F, 34.0410004F));
                    builder.AddCubicBezier(new Vector2(171.399002F, 34.0410004F), new Vector2(163.108994F, 28.1149998F), new Vector2(161.041F, 19.6669998F));
                    builder.AddCubicBezier(new Vector2(160.832993F, 18.8260002F), new Vector2(160.686996F, 17.9379997F), new Vector2(160.608002F, 17.0380001F));
                    builder.AddCubicBezier(new Vector2(160.335007F, 13.8430004F), new Vector2(160.955994F, 10.6210003F), new Vector2(162.401993F, 7.71299982F));
                    builder.AddCubicBezier(new Vector2(165.505005F, 1.48800004F), new Vector2(172.037994F, -2.773F), new Vector2(179.451996F, -3.41100001F));
                    builder.AddCubicBezier(new Vector2(186.477997F, -4.01000023F), new Vector2(193.201004F, -1.33599997F), new Vector2(197.436005F, 3.74099994F));
                    builder.AddCubicBezier(new Vector2(198.246994F, 4.71099997F), new Vector2(198.962006F, 5.7750001F), new Vector2(199.557007F, 6.89900017F));
                    builder.AddCubicBezier(new Vector2(200.654007F, 8.97200012F), new Vector2(201.311996F, 11.1990004F), new Vector2(201.511002F, 13.5170002F));
                    builder.AddCubicBezier(new Vector2(202.399002F, 23.8150005F), new Vector2(193.945007F, 32.9860001F), new Vector2(182.666F, 33.9589996F));
                    builder.AddLine(new Vector2(182.664001F, 33.9599991F));
                    builder.AddCubicBezier(new Vector2(182.026001F, 34.0149994F), new Vector2(181.389999F, 34.0410004F), new Vector2(180.759995F, 34.0410004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_051()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(181.350998F, 4.90700006F));
                    builder.AddCubicBezier(new Vector2(180.957993F, 4.90700006F), new Vector2(180.565002F, 4.92299986F), new Vector2(180.169006F, 4.95699978F));
                    builder.AddCubicBezier(new Vector2(175.654999F, 5.34600019F), new Vector2(171.725998F, 7.83699989F), new Vector2(169.921005F, 11.4580002F));
                    builder.AddCubicBezier(new Vector2(169.151001F, 13.0050001F), new Vector2(168.832993F, 14.6400003F), new Vector2(168.977005F, 16.3150005F));
                    builder.AddCubicBezier(new Vector2(169.016998F, 16.7770004F), new Vector2(169.091995F, 17.2329998F), new Vector2(169.197998F, 17.6630001F));
                    builder.AddCubicBezier(new Vector2(170.432007F, 22.7040005F), new Vector2(175.906006F, 26.1060009F), new Vector2(181.945999F, 25.5909996F));
                    builder.AddCubicBezier(new Vector2(188.608994F, 25.0160007F), new Vector2(193.632004F, 19.9230003F), new Vector2(193.141998F, 14.2370005F));
                    builder.AddCubicBezier(new Vector2(193.039001F, 13.0459995F), new Vector2(192.699997F, 11.8990002F), new Vector2(192.132996F, 10.8280001F));
                    builder.AddCubicBezier(new Vector2(191.813004F, 10.2220001F), new Vector2(191.427994F, 9.64799976F), new Vector2(190.988998F, 9.1239996F));
                    builder.AddCubicBezier(new Vector2(188.772995F, 6.46600008F), new Vector2(185.158005F, 4.90700006F), new Vector2(181.350998F, 4.90700006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_052()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(194.212006F, 6.42999983F));
                    builder.AddCubicBezier(new Vector2(179.141998F, 5.55100012F), new Vector2(170.046997F, 12.6639996F), new Vector2(165.119995F, 18.6690006F));
                    builder.AddCubicBezier(new Vector2(164.960999F, 18.0230007F), new Vector2(164.852005F, 17.3519993F), new Vector2(164.792007F, 16.6720009F));
                    builder.AddCubicBezier(new Vector2(164.578003F, 14.1689997F), new Vector2(165.085007F, 11.75F), new Vector2(166.162994F, 9.58399963F));
                    builder.AddCubicBezier(new Vector2(168.531998F, 4.83099985F), new Vector2(173.638F, 1.30400002F), new Vector2(179.811996F, 0.773000002F));
                    builder.AddCubicBezier(new Vector2(185.643005F, 0.275999993F), new Vector2(190.992996F, 2.5710001F), new Vector2(194.212006F, 6.42999983F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_053()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-89.038002F, -180.598007F));
                    builder.AddCubicBezier(new Vector2(-89.038002F, -180.598007F), new Vector2(-102.379997F, -172.673996F), new Vector2(-115.875F, -156.617004F));
                    builder.AddCubicBezier(new Vector2(-117.723F, -154.432999F), new Vector2(-119.57F, -152.110001F), new Vector2(-121.375999F, -149.617996F));
                    builder.AddCubicBezier(new Vector2(-121.375999F, -149.617996F), new Vector2(-121.375999F, -149.604004F), new Vector2(-121.375999F, -149.604004F));
                    builder.AddCubicBezier(new Vector2(-121.431999F, -149.533997F), new Vector2(-121.487999F, -149.464005F), new Vector2(-121.543999F, -149.393997F));
                    builder.AddCubicBezier(new Vector2(-124.778F, -144.942001F), new Vector2(-127.900002F, -140.001007F), new Vector2(-130.742004F, -134.582993F));
                    builder.AddCubicBezier(new Vector2(-131.470001F, -133.197006F), new Vector2(-132.184006F, -131.768997F), new Vector2(-132.869995F, -130.313004F));
                    builder.AddCubicBezier(new Vector2(-134.130005F, -127.653F), new Vector2(-135.319F, -124.894997F), new Vector2(-136.410995F, -122.025002F));
                    builder.AddCubicBezier(new Vector2(-139.225006F, -114.647003F), new Vector2(-141.408997F, -106.57F), new Vector2(-142.641006F, -97.7649994F));
                    builder.AddCubicBezier(new Vector2(-143.074997F, -94.810997F), new Vector2(-143.382996F, -91.7590027F), new Vector2(-143.565002F, -88.637001F));
                    builder.AddCubicBezier(new Vector2(-144.264999F, -77.1019974F), new Vector2(-143.326996F, -64.4599991F), new Vector2(-140.106995F, -50.6990013F));
                    builder.AddCubicBezier(new Vector2(-140.106995F, -50.6990013F), new Vector2(-200.248001F, -24.0030003F), new Vector2(-200.248001F, -24.0030003F));
                    builder.AddCubicBezier(new Vector2(-200.248001F, -24.0030003F), new Vector2(-211.908997F, -52.2249985F), new Vector2(-211.153F, -89.7009964F));
                    builder.AddCubicBezier(new Vector2(-211.097F, -92.7529984F), new Vector2(-210.957001F, -95.875F), new Vector2(-210.718994F, -99.0390015F));
                    builder.AddCubicBezier(new Vector2(-209.766998F, -111.652F), new Vector2(-207.302994F, -125.063004F), new Vector2(-202.501007F, -138.656006F));
                    builder.AddCubicBezier(new Vector2(-202.501007F, -138.656006F), new Vector2(-202.501007F, -138.669998F), new Vector2(-202.501007F, -138.669998F));
                    builder.AddCubicBezier(new Vector2(-201.423004F, -141.694F), new Vector2(-200.248001F, -144.731995F), new Vector2(-198.917999F, -147.770004F));
                    builder.AddCubicBezier(new Vector2(-197.098007F, -151.998001F), new Vector2(-195.026001F, -156.238998F), new Vector2(-192.688004F, -160.453003F));
                    builder.AddCubicBezier(new Vector2(-189.145996F, -166.837006F), new Vector2(-184.988998F, -173.177994F), new Vector2(-180.130997F, -179.421997F));
                    builder.AddCubicBezier(new Vector2(-179.949005F, -179.660004F), new Vector2(-179.753006F, -179.897995F), new Vector2(-179.557007F, -180.136002F));
                    builder.AddCubicBezier(new Vector2(-177.470993F, -182.796005F), new Vector2(-175.244995F, -185.427002F), new Vector2(-172.878998F, -188.044998F));
                    builder.AddCubicBezier(new Vector2(-162.421997F, -199.621994F), new Vector2(-149.304001F, -210.725006F), new Vector2(-132.938995F, -220.832001F));
                    builder.AddCubicBezier(new Vector2(-132.938995F, -220.832001F), new Vector2(-89.038002F, -180.598007F), new Vector2(-89.038002F, -180.598007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_054()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-89.038002F, -180.598007F));
                    builder.AddCubicBezier(new Vector2(-89.038002F, -180.598007F), new Vector2(-109.197998F, -149.520996F), new Vector2(-124.683998F, -135.373993F));
                    builder.AddCubicBezier(new Vector2(-126.795998F, -133.444F), new Vector2(-128.925995F, -131.376007F), new Vector2(-131.035995F, -129.136002F));
                    builder.AddCubicBezier(new Vector2(-131.035995F, -129.136002F), new Vector2(-131.037994F, -129.121994F), new Vector2(-131.037994F, -129.121994F));
                    builder.AddCubicBezier(new Vector2(-131.102005F, -129.059998F), new Vector2(-131.169998F, -129F), new Vector2(-131.231003F, -128.934998F));
                    builder.AddCubicBezier(new Vector2(-135.007996F, -124.933998F), new Vector2(-138.733002F, -120.431F), new Vector2(-142.248001F, -115.422997F));
                    builder.AddCubicBezier(new Vector2(-143.147003F, -114.141998F), new Vector2(-144.035995F, -112.814003F), new Vector2(-144.904999F, -111.459999F));
                    builder.AddCubicBezier(new Vector2(-146.494995F, -108.983002F), new Vector2(-148.026001F, -106.399002F), new Vector2(-149.477997F, -103.694F));
                    builder.AddCubicBezier(new Vector2(-153.212997F, -96.7369995F), new Vector2(-156.412003F, -89.0049973F), new Vector2(-158.759995F, -80.4300003F));
                    builder.AddCubicBezier(new Vector2(-159.567993F, -77.5559998F), new Vector2(-160.257996F, -74.5670013F), new Vector2(-160.845001F, -71.4960022F));
                    builder.AddCubicBezier(new Vector2(-163.014999F, -60.1450005F), new Vector2(-163.701996F, -47.4869995F), new Vector2(-162.268997F, -33.4269981F));
                    builder.AddCubicBezier(new Vector2(-162.268997F, -33.4269981F), new Vector2(-225.330994F, -14.6450005F), new Vector2(-225.330994F, -14.6450005F));
                    builder.AddCubicBezier(new Vector2(-225.330994F, -14.6450005F), new Vector2(-233.216995F, -44.1170006F), new Vector2(-227.740997F, -81.197998F));
                    builder.AddCubicBezier(new Vector2(-227.294998F, -84.2180023F), new Vector2(-226.757996F, -87.2959976F), new Vector2(-226.115997F, -90.4029999F));
                    builder.AddCubicBezier(new Vector2(-223.557999F, -102.791F), new Vector2(-219.397995F, -115.777F), new Vector2(-212.897003F, -128.643997F));
                    builder.AddCubicBezier(new Vector2(-212.897003F, -128.643997F), new Vector2(-212.895004F, -128.658005F), new Vector2(-212.895004F, -128.658005F));
                    builder.AddCubicBezier(new Vector2(-211.438995F, -131.518997F), new Vector2(-209.867004F, -134.371002F), new Vector2(-208.177002F, -137.223999F));
                    builder.AddCubicBezier(new Vector2(-205.830994F, -141.184006F), new Vector2(-204.154007F, -146.675995F), new Vector2(-201.296005F, -150.556F));
                    builder.AddCubicBezier(new Vector2(-196.966003F, -156.434006F), new Vector2(-190.705994F, -168.380997F), new Vector2(-185.089005F, -173.951996F));
                    builder.AddCubicBezier(new Vector2(-184.878006F, -174.164993F), new Vector2(-184.647995F, -174.371002F), new Vector2(-184.427994F, -174.587006F));
                    builder.AddCubicBezier(new Vector2(-182.018997F, -176.957993F), new Vector2(-179.475006F, -179.283005F), new Vector2(-176.794006F, -181.576996F));
                    builder.AddCubicBezier(new Vector2(-164.940994F, -191.720993F), new Vector2(-149.304001F, -210.725006F), new Vector2(-132.938995F, -220.832001F));
                    builder.AddCubicBezier(new Vector2(-132.938995F, -220.832001F), new Vector2(-89.038002F, -180.598007F), new Vector2(-89.038002F, -180.598007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_055()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_056(), Geometry_057() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_056()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-202.483002F, -18.4150009F));
                    builder.AddCubicBezier(new Vector2(-202.483002F, -18.4150009F), new Vector2(-204.128998F, -22.3990002F), new Vector2(-204.128998F, -22.3990002F));
                    builder.AddCubicBezier(new Vector2(-204.619003F, -23.5839996F), new Vector2(-216.117004F, -51.8689995F), new Vector2(-215.352005F, -89.7860031F));
                    builder.AddCubicBezier(new Vector2(-215.292999F, -92.987999F), new Vector2(-215.143005F, -96.2099991F), new Vector2(-214.906998F, -99.3539963F));
                    builder.AddCubicBezier(new Vector2(-213.856003F, -113.275002F), new Vector2(-211.095993F, -126.733002F), new Vector2(-206.701004F, -139.369995F));
                    builder.AddCubicBezier(new Vector2(-206.701004F, -139.369995F), new Vector2(-206.701004F, -139.382004F), new Vector2(-206.701004F, -139.382004F));
                    builder.AddCubicBezier(new Vector2(-206.701004F, -139.382004F), new Vector2(-206.457001F, -140.080002F), new Vector2(-206.457001F, -140.080002F));
                    builder.AddCubicBezier(new Vector2(-205.244003F, -143.485001F), new Vector2(-204.037003F, -146.552002F), new Vector2(-202.764999F, -149.453995F));
                    builder.AddCubicBezier(new Vector2(-200.867004F, -153.865005F), new Vector2(-198.707993F, -158.259995F), new Vector2(-196.360001F, -162.490997F));
                    builder.AddCubicBezier(new Vector2(-192.626999F, -169.220993F), new Vector2(-188.281006F, -175.785004F), new Vector2(-183.445007F, -182.001007F));
                    builder.AddCubicBezier(new Vector2(-183.263F, -182.240005F), new Vector2(-183.044006F, -182.507996F), new Vector2(-182.822998F, -182.776993F));
                    builder.AddCubicBezier(new Vector2(-180.757004F, -185.412003F), new Vector2(-178.445999F, -188.147995F), new Vector2(-175.994995F, -190.860992F));
                    builder.AddCubicBezier(new Vector2(-164.723999F, -203.339996F), new Vector2(-150.981003F, -214.625F), new Vector2(-135.145996F, -224.404007F));
                    builder.AddCubicBezier(new Vector2(-135.145996F, -224.404007F), new Vector2(-132.444F, -226.074005F), new Vector2(-132.444F, -226.074005F));
                    builder.AddCubicBezier(new Vector2(-132.444F, -226.074005F), new Vector2(-82.0319977F, -179.873993F), new Vector2(-82.0319977F, -179.873993F));
                    builder.AddCubicBezier(new Vector2(-82.0319977F, -179.873993F), new Vector2(-86.8919983F, -176.987F), new Vector2(-86.8919983F, -176.987F));
                    builder.AddCubicBezier(new Vector2(-87.1529999F, -176.830002F), new Vector2(-99.9049988F, -169.091003F), new Vector2(-112.660004F, -153.914993F));
                    builder.AddCubicBezier(new Vector2(-114.299004F, -151.975998F), new Vector2(-115.783997F, -150.112F), new Vector2(-117.176003F, -148.240997F));
                    builder.AddCubicBezier(new Vector2(-117.176003F, -148.240997F), new Vector2(-117.176003F, -148.149994F), new Vector2(-117.176003F, -148.149994F));
                    builder.AddCubicBezier(new Vector2(-117.176003F, -148.149994F), new Vector2(-118.204002F, -146.845993F), new Vector2(-118.204002F, -146.845993F));
                    builder.AddCubicBezier(new Vector2(-121.472F, -142.339005F), new Vector2(-124.439003F, -137.557007F), new Vector2(-127.022003F, -132.632004F));
                    builder.AddCubicBezier(new Vector2(-127.739998F, -131.266998F), new Vector2(-128.429001F, -129.884995F), new Vector2(-129.070999F, -128.522003F));
                    builder.AddCubicBezier(new Vector2(-130.339996F, -125.845001F), new Vector2(-131.487F, -123.157997F), new Vector2(-132.485992F, -120.531998F));
                    builder.AddCubicBezier(new Vector2(-135.347F, -113.030998F), new Vector2(-137.363007F, -105.177002F), new Vector2(-138.481003F, -97.1829987F));
                    builder.AddCubicBezier(new Vector2(-138.899002F, -94.3389969F), new Vector2(-139.197998F, -91.3909988F), new Vector2(-139.371994F, -88.3929977F));
                    builder.AddCubicBezier(new Vector2(-140.087997F, -76.586998F), new Vector2(-138.959F, -64.2300034F), new Vector2(-136.018005F, -51.6570015F));
                    builder.AddCubicBezier(new Vector2(-136.018005F, -51.6570015F), new Vector2(-135.225998F, -48.2719994F), new Vector2(-135.225998F, -48.2719994F));
                    builder.AddCubicBezier(new Vector2(-135.225998F, -48.2719994F), new Vector2(-202.483002F, -18.4150009F), new Vector2(-202.483002F, -18.4150009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_057()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-198.395004F, -137.681F));
                    builder.AddCubicBezier(new Vector2(-198.395004F, -137.681F), new Vector2(-198.542007F, -137.257996F), new Vector2(-198.542007F, -137.257996F));
                    builder.AddCubicBezier(new Vector2(-202.828995F, -125.121002F), new Vector2(-205.516998F, -112.155998F), new Vector2(-206.531006F, -98.7229996F));
                    builder.AddCubicBezier(new Vector2(-206.755997F, -95.7369995F), new Vector2(-206.897995F, -92.6750031F), new Vector2(-206.953995F, -89.6240005F));
                    builder.AddCubicBezier(new Vector2(-207.520996F, -61.5180016F), new Vector2(-200.889008F, -38.6189995F), new Vector2(-197.845001F, -29.6639996F));
                    builder.AddCubicBezier(new Vector2(-197.845001F, -29.6639996F), new Vector2(-144.951996F, -53.144001F), new Vector2(-144.951996F, -53.144001F));
                    builder.AddCubicBezier(new Vector2(-147.514008F, -65.3430023F), new Vector2(-148.457001F, -77.3519974F), new Vector2(-147.757004F, -88.8909988F));
                    builder.AddCubicBezier(new Vector2(-147.567993F, -92.1240005F), new Vector2(-147.244995F, -95.3180008F), new Vector2(-146.796005F, -98.375F));
                    builder.AddCubicBezier(new Vector2(-145.593994F, -106.964996F), new Vector2(-143.419998F, -115.434998F), new Vector2(-140.335999F, -123.521004F));
                    builder.AddCubicBezier(new Vector2(-139.259995F, -126.349998F), new Vector2(-138.024994F, -129.240997F), new Vector2(-136.666F, -132.110001F));
                    builder.AddCubicBezier(new Vector2(-135.975006F, -133.574997F), new Vector2(-135.229996F, -135.067001F), new Vector2(-134.457993F, -136.537003F));
                    builder.AddCubicBezier(new Vector2(-131.673004F, -141.845993F), new Vector2(-128.470993F, -147.003006F), new Vector2(-124.942001F, -151.862F));
                    builder.AddCubicBezier(new Vector2(-124.942001F, -151.862F), new Vector2(-124.777F, -152.080994F), new Vector2(-124.777F, -152.080994F));
                    builder.AddCubicBezier(new Vector2(-123.029999F, -154.492996F), new Vector2(-121.167F, -156.863007F), new Vector2(-119.081001F, -159.328995F));
                    builder.AddCubicBezier(new Vector2(-110.009003F, -170.123001F), new Vector2(-101.042999F, -177.339005F), new Vector2(-95.8089981F, -181.106995F));
                    builder.AddCubicBezier(new Vector2(-95.8089981F, -181.106995F), new Vector2(-133.417007F, -215.572006F), new Vector2(-133.417007F, -215.572006F));
                    builder.AddCubicBezier(new Vector2(-147.445999F, -206.610001F), new Vector2(-159.662003F, -196.412994F), new Vector2(-169.763F, -185.231003F));
                    builder.AddCubicBezier(new Vector2(-172.084F, -182.660995F), new Vector2(-174.268005F, -180.074997F), new Vector2(-176.251999F, -177.544998F));
                    builder.AddCubicBezier(new Vector2(-176.492004F, -177.251007F), new Vector2(-176.647995F, -177.061005F), new Vector2(-176.794006F, -176.871002F));
                    builder.AddCubicBezier(new Vector2(-181.386993F, -170.966995F), new Vector2(-185.490997F, -164.766998F), new Vector2(-189.014999F, -158.414993F));
                    builder.AddCubicBezier(new Vector2(-191.227997F, -154.427994F), new Vector2(-193.261002F, -150.287994F), new Vector2(-195.059998F, -146.108994F));
                    builder.AddCubicBezier(new Vector2(-196.209F, -143.483994F), new Vector2(-197.298996F, -140.729996F), new Vector2(-198.395004F, -137.681F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_058()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_059(), Geometry_060() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_059()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-228.263F, -9.38899994F));
                    builder.AddCubicBezier(new Vector2(-228.263F, -9.38899994F), new Vector2(-229.386002F, -13.5509996F), new Vector2(-229.386002F, -13.5509996F));
                    builder.AddCubicBezier(new Vector2(-229.720001F, -14.7889996F), new Vector2(-237.436996F, -44.3019981F), new Vector2(-231.895004F, -81.8199997F));
                    builder.AddCubicBezier(new Vector2(-231.427002F, -84.987999F), new Vector2(-230.867996F, -88.1640015F), new Vector2(-230.229996F, -91.2519989F));
                    builder.AddCubicBezier(new Vector2(-227.406006F, -104.924004F), new Vector2(-222.945999F, -117.918999F), new Vector2(-216.970993F, -129.889999F));
                    builder.AddCubicBezier(new Vector2(-216.970993F, -129.889999F), new Vector2(-216.970001F, -129.901001F), new Vector2(-216.970001F, -129.901001F));
                    builder.AddCubicBezier(new Vector2(-216.970001F, -129.901001F), new Vector2(-216.638F, -130.563004F), new Vector2(-216.638F, -130.563004F));
                    builder.AddCubicBezier(new Vector2(-214.998993F, -133.785004F), new Vector2(-213.391998F, -136.660995F), new Vector2(-211.776993F, -139.386993F));
                    builder.AddCubicBezier(new Vector2(-209.330002F, -143.518997F), new Vector2(-207.546005F, -149.149994F), new Vector2(-204.677002F, -153.046997F));
                    builder.AddCubicBezier(new Vector2(-200.113998F, -159.244003F), new Vector2(-193.638F, -171.388F), new Vector2(-188.046005F, -176.934006F));
                    builder.AddCubicBezier(new Vector2(-187.834F, -177.147995F), new Vector2(-187.576996F, -177.380005F), new Vector2(-187.328995F, -177.623993F));
                    builder.AddCubicBezier(new Vector2(-184.942993F, -179.973007F), new Vector2(-182.302002F, -182.389999F), new Vector2(-179.524002F, -184.768005F));
                    builder.AddCubicBezier(new Vector2(-166.748993F, -195.701996F), new Vector2(-150.981003F, -214.625F), new Vector2(-135.145996F, -224.404007F));
                    builder.AddCubicBezier(new Vector2(-135.145996F, -224.404007F), new Vector2(-132.444F, -226.074005F), new Vector2(-132.444F, -226.074005F));
                    builder.AddCubicBezier(new Vector2(-132.444F, -226.074005F), new Vector2(-82.0319977F, -179.873993F), new Vector2(-82.0319977F, -179.873993F));
                    builder.AddCubicBezier(new Vector2(-82.0319977F, -179.873993F), new Vector2(-99.6409988F, -155.703003F), new Vector2(-99.6409988F, -155.703003F));
                    builder.AddCubicBezier(new Vector2(-99.9199982F, -155.580994F), new Vector2(-107.209999F, -145.658997F), new Vector2(-121.842003F, -132.283005F));
                    builder.AddCubicBezier(new Vector2(-123.716003F, -130.570007F), new Vector2(-125.427002F, -128.910995F), new Vector2(-127.046997F, -127.234001F));
                    builder.AddCubicBezier(new Vector2(-127.046997F, -127.234001F), new Vector2(-127.057999F, -127.142998F), new Vector2(-127.057999F, -127.142998F));
                    builder.AddCubicBezier(new Vector2(-127.057999F, -127.142998F), new Vector2(-128.244995F, -125.981003F), new Vector2(-128.244995F, -125.981003F));
                    builder.AddCubicBezier(new Vector2(-132.063004F, -121.929001F), new Vector2(-135.612F, -117.563004F), new Vector2(-138.809006F, -113.012001F));
                    builder.AddCubicBezier(new Vector2(-139.695999F, -111.75F), new Vector2(-140.552994F, -110.466003F), new Vector2(-141.367004F, -109.197998F));
                    builder.AddCubicBezier(new Vector2(-142.968002F, -106.706001F), new Vector2(-144.447006F, -104.186996F), new Vector2(-145.776001F, -101.710999F));
                    builder.AddCubicBezier(new Vector2(-149.572998F, -94.6380005F), new Vector2(-152.576996F, -87.1050034F), new Vector2(-154.709F, -79.3199997F));
                    builder.AddCubicBezier(new Vector2(-155.487F, -76.5530014F), new Vector2(-156.153F, -73.6669998F), new Vector2(-156.716995F, -70.7170029F));
                    builder.AddCubicBezier(new Vector2(-158.938004F, -59.098999F), new Vector2(-159.399994F, -46.6990013F), new Vector2(-158.091995F, -33.8530006F));
                    builder.AddCubicBezier(new Vector2(-158.091995F, -33.8530006F), new Vector2(-157.738998F, -30.3950005F), new Vector2(-157.738998F, -30.3950005F));
                    builder.AddCubicBezier(new Vector2(-157.738998F, -30.3950005F), new Vector2(-228.263F, -9.38899994F), new Vector2(-228.263F, -9.38899994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_060()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-208.949005F, -127.152F));
                    builder.AddCubicBezier(new Vector2(-208.949005F, -127.152F), new Vector2(-209.149002F, -126.75F), new Vector2(-209.149002F, -126.75F));
                    builder.AddCubicBezier(new Vector2(-214.953995F, -115.261002F), new Vector2(-219.281006F, -102.747002F), new Vector2(-222.003006F, -89.5540009F));
                    builder.AddCubicBezier(new Vector2(-222.608002F, -86.6220016F), new Vector2(-223.136002F, -83.6029968F), new Vector2(-223.587006F, -80.5849991F));
                    builder.AddCubicBezier(new Vector2(-227.746002F, -52.7830009F), new Vector2(-224.097F, -29.2229996F), new Vector2(-222.223999F, -19.9519997F));
                    builder.AddCubicBezier(new Vector2(-222.223999F, -19.9519997F), new Vector2(-166.761002F, -36.4710007F), new Vector2(-166.761002F, -36.4710007F));
                    builder.AddCubicBezier(new Vector2(-167.740997F, -48.8979988F), new Vector2(-167.115005F, -60.9239998F), new Vector2(-164.970001F, -72.2839966F));
                    builder.AddCubicBezier(new Vector2(-164.369003F, -75.4660034F), new Vector2(-163.639999F, -78.5930023F), new Vector2(-162.802994F, -81.5670013F));
                    builder.AddCubicBezier(new Vector2(-160.511993F, -89.9329987F), new Vector2(-157.264999F, -98.0510025F), new Vector2(-153.179001F, -105.68F));
                    builder.AddCubicBezier(new Vector2(-151.75F, -108.348F), new Vector2(-150.149994F, -111.055F), new Vector2(-148.440002F, -113.728996F));
                    builder.AddCubicBezier(new Vector2(-147.567001F, -115.094002F), new Vector2(-146.638F, -116.476997F), new Vector2(-145.684998F, -117.836998F));
                    builder.AddCubicBezier(new Vector2(-142.244003F, -122.746002F), new Vector2(-138.408005F, -127.450996F), new Vector2(-134.285995F, -131.817993F));
                    builder.AddCubicBezier(new Vector2(-134.285995F, -131.817993F), new Vector2(-134.093994F, -132.014008F), new Vector2(-134.093994F, -132.014008F));
                    builder.AddCubicBezier(new Vector2(-132.052994F, -134.182999F), new Vector2(-129.895004F, -136.287994F), new Vector2(-127.517998F, -138.473999F));
                    builder.AddCubicBezier(new Vector2(-117.139F, -148.018997F), new Vector2(-101.042999F, -177.339005F), new Vector2(-95.8089981F, -181.106995F));
                    builder.AddCubicBezier(new Vector2(-95.8089981F, -181.106995F), new Vector2(-133.417007F, -215.572006F), new Vector2(-133.417007F, -215.572006F));
                    builder.AddCubicBezier(new Vector2(-147.445999F, -206.610001F), new Vector2(-162.613998F, -188.182999F), new Vector2(-174.063004F, -178.386002F));
                    builder.AddCubicBezier(new Vector2(-176.694F, -176.134995F), new Vector2(-179.190002F, -173.850006F), new Vector2(-181.481995F, -171.593994F));
                    builder.AddCubicBezier(new Vector2(-181.757996F, -171.332993F), new Vector2(-181.936005F, -171.164993F), new Vector2(-182.106003F, -170.996002F));
                    builder.AddCubicBezier(new Vector2(-187.416F, -165.727997F), new Vector2(-193.604996F, -153.914001F), new Vector2(-197.914001F, -148.065994F));
                    builder.AddCubicBezier(new Vector2(-200.619003F, -144.395004F), new Vector2(-202.220993F, -138.983994F), new Vector2(-204.563995F, -135.084F));
                    builder.AddCubicBezier(new Vector2(-206.039993F, -132.628006F), new Vector2(-207.472F, -130.035995F), new Vector2(-208.949005F, -127.152F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_061()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-142.641006F, -97.7649994F));
                    builder.AddCubicBezier(new Vector2(-143.074997F, -94.810997F), new Vector2(-143.382996F, -91.7590027F), new Vector2(-143.565002F, -88.637001F));
                    builder.AddCubicBezier(new Vector2(-171.255005F, -105.281998F), new Vector2(-199.533997F, -95.2450027F), new Vector2(-211.153F, -89.7009964F));
                    builder.AddCubicBezier(new Vector2(-211.097F, -92.7529984F), new Vector2(-210.957001F, -95.875F), new Vector2(-210.718994F, -99.0390015F));
                    builder.AddCubicBezier(new Vector2(-196.453995F, -104.974998F), new Vector2(-169.589996F, -112.127998F), new Vector2(-142.641006F, -97.7649994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_062()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-158.759995F, -80.4300003F));
                    builder.AddCubicBezier(new Vector2(-159.567993F, -77.5559998F), new Vector2(-160.264999F, -74.5690002F), new Vector2(-160.845001F, -71.4960022F));
                    builder.AddCubicBezier(new Vector2(-186.177994F, -91.5469971F), new Vector2(-215.507996F, -85.2099991F), new Vector2(-227.740997F, -81.197998F));
                    builder.AddCubicBezier(new Vector2(-227.294998F, -84.2180023F), new Vector2(-226.757004F, -87.2959976F), new Vector2(-226.115997F, -90.4029999F));
                    builder.AddCubicBezier(new Vector2(-211.209F, -94.4649963F), new Vector2(-183.649002F, -98.1230011F), new Vector2(-158.759995F, -80.4300003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_063()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-132.869995F, -130.313004F));
                    builder.AddCubicBezier(new Vector2(-134.130005F, -127.653F), new Vector2(-135.319F, -124.894997F), new Vector2(-136.410995F, -122.025002F));
                    builder.AddCubicBezier(new Vector2(-158.179993F, -144.535995F), new Vector2(-189.664001F, -141.218002F), new Vector2(-202.501007F, -138.669998F));
                    builder.AddCubicBezier(new Vector2(-201.423004F, -141.694F), new Vector2(-200.248001F, -144.731995F), new Vector2(-198.917999F, -147.770004F));
                    builder.AddCubicBezier(new Vector2(-183.057007F, -150.065994F), new Vector2(-154.498993F, -150.5F), new Vector2(-132.869995F, -130.313004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_064()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-144.904999F, -111.459999F));
                    builder.AddCubicBezier(new Vector2(-146.494995F, -108.983002F), new Vector2(-148.028F, -106.400002F), new Vector2(-149.477997F, -103.694F));
                    builder.AddCubicBezier(new Vector2(-168.188004F, -128.804993F), new Vector2(-199.837006F, -129.542007F), new Vector2(-212.895004F, -128.658005F));
                    builder.AddCubicBezier(new Vector2(-211.438995F, -131.518997F), new Vector2(-209.884995F, -134.380997F), new Vector2(-208.177002F, -137.223999F));
                    builder.AddCubicBezier(new Vector2(-192.151993F, -137.472F), new Vector2(-163.772995F, -134.248001F), new Vector2(-144.904999F, -111.459999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_065()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-115.875F, -156.617004F));
                    builder.AddCubicBezier(new Vector2(-117.723F, -154.432999F), new Vector2(-119.57F, -152.110001F), new Vector2(-121.375999F, -149.617996F));
                    builder.AddCubicBezier(new Vector2(-137.488998F, -176.328003F), new Vector2(-166.440002F, -179.953995F), new Vector2(-179.557007F, -180.136002F));
                    builder.AddCubicBezier(new Vector2(-177.470993F, -182.796005F), new Vector2(-175.244995F, -185.427002F), new Vector2(-172.878998F, -188.044998F));
                    builder.AddCubicBezier(new Vector2(-157.046005F, -186.561005F), new Vector2(-131.694F, -180.304001F), new Vector2(-115.875F, -156.617004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_066()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-124.683998F, -135.373993F));
                    builder.AddCubicBezier(new Vector2(-126.795998F, -133.444F), new Vector2(-128.925995F, -131.376007F), new Vector2(-131.035995F, -129.136002F));
                    builder.AddCubicBezier(new Vector2(-143.598999F, -157.688004F), new Vector2(-171.442001F, -172.727997F), new Vector2(-184.427994F, -174.587006F));
                    builder.AddCubicBezier(new Vector2(-182.018997F, -176.957993F), new Vector2(-179.475006F, -179.283005F), new Vector2(-176.794006F, -181.576996F));
                    builder.AddCubicBezier(new Vector2(-161.281006F, -178.078995F), new Vector2(-137.341995F, -160.889999F), new Vector2(-124.683998F, -135.373993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_067()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-194.953995F, -51.1759987F));
                    builder.AddCubicBezier(new Vector2(-183.041F, -60.4150009F), new Vector2(-164.259003F, -70.9309998F), new Vector2(-143.085999F, -67.7559967F));
                    builder.AddCubicBezier(new Vector2(-143.085999F, -67.7559967F), new Vector2(-99.098999F, -49.7599983F), new Vector2(-94.3420029F, -37.3209991F));
                    builder.AddCubicBezier(new Vector2(-94.3420029F, -37.3209991F), new Vector2(-89.8710022F, -18.6270008F), new Vector2(-117.658997F, -20.8400002F));
                    builder.AddCubicBezier(new Vector2(-117.658997F, -20.8400002F), new Vector2(-86.4769974F, 30.4120007F), new Vector2(-130.334F, 50.6520004F));
                    builder.AddCubicBezier(new Vector2(-130.334F, 50.6520004F), new Vector2(-161.475998F, 67.4489975F), new Vector2(-184.535995F, 28.0839996F));
                    builder.AddCubicBezier(new Vector2(-185.270996F, 26.8299999F), new Vector2(-185.860001F, 25.4950008F), new Vector2(-186.339996F, 24.1219997F));
                    builder.AddCubicBezier(new Vector2(-186.339996F, 24.1219997F), new Vector2(-203.059006F, -23.6860008F), new Vector2(-203.059006F, -23.6860008F));
                    builder.AddCubicBezier(new Vector2(-206.541F, -33.6419983F), new Vector2(-203.287994F, -44.7120018F), new Vector2(-194.953995F, -51.1759987F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_068()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-216.604004F, -40.9179993F));
                    builder.AddCubicBezier(new Vector2(-203.606995F, -48.5569992F), new Vector2(-183.632996F, -56.5820007F), new Vector2(-163.041F, -50.723999F));
                    builder.AddCubicBezier(new Vector2(-163.041F, -50.723999F), new Vector2(-121.719002F, -27.2479992F), new Vector2(-118.592003F, -14.3030005F));
                    builder.AddCubicBezier(new Vector2(-118.592003F, -14.3030005F), new Vector2(-116.550003F, 4.80800009F), new Vector2(-143.826004F, -0.941999972F));
                    builder.AddCubicBezier(new Vector2(-143.826004F, -0.941999972F), new Vector2(-119.458F, 53.8790016F), new Vector2(-165.544006F, 68.3410034F));
                    builder.AddCubicBezier(new Vector2(-165.544006F, 68.3410034F), new Vector2(-198.578995F, 81.0159988F), new Vector2(-216.412994F, 39.0239983F));
                    builder.AddCubicBezier(new Vector2(-216.981003F, 37.6860008F), new Vector2(-217.393997F, 36.2869987F), new Vector2(-217.695007F, 34.8639984F));
                    builder.AddCubicBezier(new Vector2(-217.695007F, 34.8639984F), new Vector2(-228.160004F, -14.6899996F), new Vector2(-228.160004F, -14.6899996F));
                    builder.AddCubicBezier(new Vector2(-230.339005F, -25.0090008F), new Vector2(-225.697006F, -35.5740013F), new Vector2(-216.604004F, -40.9179993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_069()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_070(), Geometry_071() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_070()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-146.399002F, 58.3230019F));
                    builder.AddCubicBezier(new Vector2(-158.574005F, 58.3230019F), new Vector2(-174.792007F, 53.0289993F), new Vector2(-188.160004F, 30.2070007F));
                    builder.AddCubicBezier(new Vector2(-188.985992F, 28.7980003F), new Vector2(-189.707001F, 27.2169991F), new Vector2(-190.304001F, 25.5079994F));
                    builder.AddCubicBezier(new Vector2(-190.304001F, 25.5079994F), new Vector2(-207.024002F, -22.2999992F), new Vector2(-207.024002F, -22.2999992F));
                    builder.AddCubicBezier(new Vector2(-211.110001F, -33.9819984F), new Vector2(-207.292999F, -46.9199982F), new Vector2(-197.528F, -54.4949989F));
                    builder.AddCubicBezier(new Vector2(-197.528F, -54.4949989F), new Vector2(-197.526993F, -54.4949989F), new Vector2(-197.526993F, -54.4949989F));
                    builder.AddCubicBezier(new Vector2(-184.873993F, -64.3079987F), new Vector2(-165.046005F, -75.2969971F), new Vector2(-142.464005F, -71.9089966F));
                    builder.AddCubicBezier(new Vector2(-142.464005F, -71.9089966F), new Vector2(-141.964005F, -71.8339996F), new Vector2(-141.964005F, -71.8339996F));
                    builder.AddCubicBezier(new Vector2(-141.964005F, -71.8339996F), new Vector2(-141.496002F, -71.6419983F), new Vector2(-141.496002F, -71.6419983F));
                    builder.AddCubicBezier(new Vector2(-133.869995F, -68.5220032F), new Vector2(-95.5660019F, -52.276001F), new Vector2(-90.4199982F, -38.8199997F));
                    builder.AddCubicBezier(new Vector2(-90.4199982F, -38.8199997F), new Vector2(-90.2590027F, -38.2970009F), new Vector2(-90.2590027F, -38.2970009F));
                    builder.AddCubicBezier(new Vector2(-90.177002F, -37.9560013F), new Vector2(-88.3209991F, -29.8619995F), new Vector2(-93.7979965F, -23.4599991F));
                    builder.AddCubicBezier(new Vector2(-97.3759995F, -19.2789993F), new Vector2(-103.033997F, -16.9589996F), new Vector2(-110.665001F, -16.5319996F));
                    builder.AddCubicBezier(new Vector2(-106.155998F, -6.94399977F), new Vector2(-99.3820038F, 11.6590004F), new Vector2(-104.586998F, 28.7290001F));
                    builder.AddCubicBezier(new Vector2(-108.036003F, 40.0410004F), new Vector2(-116.092003F, 48.6940002F), new Vector2(-128.533005F, 54.4459991F));
                    builder.AddCubicBezier(new Vector2(-129.779007F, 55.0620003F), new Vector2(-136.845993F, 58.3230019F), new Vector2(-146.399002F, 58.3230019F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_071()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-192.378998F, -47.8580017F));
                    builder.AddCubicBezier(new Vector2(-199.287994F, -42.4990005F), new Vector2(-201.988007F, -33.3429985F), new Vector2(-199.095001F, -25.073F));
                    builder.AddCubicBezier(new Vector2(-199.095001F, -25.073F), new Vector2(-182.375F, 22.7350006F), new Vector2(-182.375F, 22.7350006F));
                    builder.AddCubicBezier(new Vector2(-181.955994F, 23.934F), new Vector2(-181.464005F, 25.0189991F), new Vector2(-180.912003F, 25.9619999F));
                    builder.AddCubicBezier(new Vector2(-160.276001F, 61.1879997F), new Vector2(-133.442993F, 47.5449982F), new Vector2(-132.311996F, 46.9469986F));
                    builder.AddCubicBezier(new Vector2(-132.311996F, 46.9469986F), new Vector2(-132.093994F, 46.8380013F), new Vector2(-132.093994F, 46.8380013F));
                    builder.AddCubicBezier(new Vector2(-121.897003F, 42.132F), new Vector2(-115.346001F, 35.2159996F), new Vector2(-112.621002F, 26.2800007F));
                    builder.AddCubicBezier(new Vector2(-106.445F, 6.02299976F), new Vector2(-121.098F, -18.4130001F), new Vector2(-121.247002F, -18.6580009F));
                    builder.AddCubicBezier(new Vector2(-121.247002F, -18.6580009F), new Vector2(-125.518997F, -25.6800003F), new Vector2(-125.518997F, -25.6800003F));
                    builder.AddCubicBezier(new Vector2(-125.518997F, -25.6800003F), new Vector2(-117.324997F, -25.0270004F), new Vector2(-117.324997F, -25.0270004F));
                    builder.AddCubicBezier(new Vector2(-108.918999F, -24.3519993F), new Vector2(-103.005997F, -25.6849995F), new Vector2(-100.230003F, -28.8640003F));
                    builder.AddCubicBezier(new Vector2(-97.8990021F, -31.5340004F), new Vector2(-98.2409973F, -35.1269989F), new Vector2(-98.3909988F, -36.1189995F));
                    builder.AddCubicBezier(new Vector2(-101.758003F, -43.5180016F), new Vector2(-126.880997F, -56.5369987F), new Vector2(-144.201004F, -63.6730003F));
                    builder.AddCubicBezier(new Vector2(-163.654007F, -66.387001F), new Vector2(-181.117004F, -56.5929985F), new Vector2(-192.380005F, -47.8580017F));
                    builder.AddCubicBezier(new Vector2(-192.380005F, -47.8580017F), new Vector2(-192.378998F, -47.8580017F), new Vector2(-192.378998F, -47.8580017F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_072()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_073(), Geometry_074() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_073()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-182.457993F, 73.8939972F));
                    builder.AddCubicBezier(new Vector2(-194.533005F, 72.3359985F), new Vector2(-209.934998F, 65.0080032F), new Vector2(-220.279007F, 40.6660004F));
                    builder.AddCubicBezier(new Vector2(-220.917999F, 39.1629982F), new Vector2(-221.429993F, 37.5019989F), new Vector2(-221.804001F, 35.730999F));
                    builder.AddCubicBezier(new Vector2(-221.804001F, 35.730999F), new Vector2(-232.270004F, -13.823F), new Vector2(-232.270004F, -13.823F));
                    builder.AddCubicBezier(new Vector2(-234.826996F, -25.9319992F), new Vector2(-229.386002F, -38.2750015F), new Vector2(-218.731995F, -44.5390015F));
                    builder.AddCubicBezier(new Vector2(-218.731995F, -44.5390015F), new Vector2(-218.731995F, -44.5390015F), new Vector2(-218.731995F, -44.5390015F));
                    builder.AddCubicBezier(new Vector2(-204.927002F, -52.6520004F), new Vector2(-183.856003F, -61.0130005F), new Vector2(-161.893005F, -54.7639999F));
                    builder.AddCubicBezier(new Vector2(-161.893005F, -54.7639999F), new Vector2(-161.406998F, -54.625F), new Vector2(-161.406998F, -54.625F));
                    builder.AddCubicBezier(new Vector2(-161.406998F, -54.625F), new Vector2(-160.968002F, -54.3759995F), new Vector2(-160.968002F, -54.3759995F));
                    builder.AddCubicBezier(new Vector2(-153.802994F, -50.3059998F), new Vector2(-117.891998F, -29.2919998F), new Vector2(-114.510002F, -15.2880001F));
                    builder.AddCubicBezier(new Vector2(-114.510002F, -15.2880001F), new Vector2(-114.417F, -14.7489996F), new Vector2(-114.417F, -14.7489996F));
                    builder.AddCubicBezier(new Vector2(-114.378998F, -14.3999996F), new Vector2(-113.573997F, -6.13500023F), new Vector2(-119.825996F, -0.486999989F));
                    builder.AddCubicBezier(new Vector2(-123.910004F, 3.2019999F), new Vector2(-129.817993F, 4.77899981F), new Vector2(-137.440994F, 4.22599983F));
                    builder.AddCubicBezier(new Vector2(-134.195999F, 14.3120003F), new Vector2(-129.858994F, 33.6290016F), new Vector2(-137.203995F, 49.8930016F));
                    builder.AddCubicBezier(new Vector2(-142.072006F, 60.6710014F), new Vector2(-151.169998F, 68.2220001F), new Vector2(-164.244003F, 72.3349991F));
                    builder.AddCubicBezier(new Vector2(-165.559006F, 72.7860031F), new Vector2(-172.983002F, 75.1159973F), new Vector2(-182.457993F, 73.8939972F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_074()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-214.475998F, -37.2970009F));
                    builder.AddCubicBezier(new Vector2(-222.014008F, -32.8660011F), new Vector2(-225.862F, -24.1299992F), new Vector2(-224.050995F, -15.5579996F));
                    builder.AddCubicBezier(new Vector2(-224.050995F, -15.5579996F), new Vector2(-213.585007F, 33.9959984F), new Vector2(-213.585007F, 33.9959984F));
                    builder.AddCubicBezier(new Vector2(-213.322998F, 35.2389984F), new Vector2(-212.973999F, 36.3790016F), new Vector2(-212.546997F, 37.3839989F));
                    builder.AddCubicBezier(new Vector2(-196.587997F, 74.9609985F), new Vector2(-168.231003F, 64.8619995F), new Vector2(-167.031998F, 64.4140015F));
                    builder.AddCubicBezier(new Vector2(-167.031998F, 64.4140015F), new Vector2(-166.802002F, 64.3339996F), new Vector2(-166.802002F, 64.3339996F));
                    builder.AddCubicBezier(new Vector2(-156.085999F, 60.9720001F), new Vector2(-148.703003F, 54.9500008F), new Vector2(-144.858002F, 46.4360008F));
                    builder.AddCubicBezier(new Vector2(-136.141006F, 27.1350002F), new Vector2(-147.546997F, 1.02600002F), new Vector2(-147.662994F, 0.763999999F));
                    builder.AddCubicBezier(new Vector2(-147.662994F, 0.763999999F), new Vector2(-151.001999F, -6.74599981F), new Vector2(-151.001999F, -6.74599981F));
                    builder.AddCubicBezier(new Vector2(-151.001999F, -6.74599981F), new Vector2(-142.959F, -5.05100012F), new Vector2(-142.959F, -5.05100012F));
                    builder.AddCubicBezier(new Vector2(-134.709F, -3.30599999F), new Vector2(-128.673004F, -3.87100005F), new Vector2(-125.513F, -6.66900015F));
                    builder.AddCubicBezier(new Vector2(-122.860001F, -9.01900005F), new Vector2(-122.738998F, -12.6260004F), new Vector2(-122.761002F, -13.6289997F));
                    builder.AddCubicBezier(new Vector2(-125.153999F, -21.3980007F), new Vector2(-148.404999F, -37.5250015F), new Vector2(-164.669998F, -46.8180008F));
                    builder.AddCubicBezier(new Vector2(-183.615997F, -51.9990005F), new Vector2(-202.188004F, -44.519001F), new Vector2(-214.475998F, -37.2970009F));
                    builder.AddCubicBezier(new Vector2(-214.475998F, -37.2970009F), new Vector2(-214.475998F, -37.2970009F), new Vector2(-214.475998F, -37.2970009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_075()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(379.403992F, -81.2330017F));
                    builder.AddCubicBezier(new Vector2(381.80899F, -85.4440002F), new Vector2(385.950012F, -88.3779984F), new Vector2(391.819F, -90.0360031F));
                    builder.AddCubicBezier(new Vector2(397.687988F, -91.6869965F), new Vector2(405.363007F, -92.5199966F), new Vector2(414.843994F, -92.5199966F));
                    builder.AddCubicBezier(new Vector2(424.325012F, -92.5199966F), new Vector2(431.923004F, -91.5390015F), new Vector2(437.644012F, -89.5849991F));
                    builder.AddCubicBezier(new Vector2(443.358002F, -87.6240005F), new Vector2(447.420013F, -84.4639969F), new Vector2(449.833008F, -80.1039963F));
                    builder.AddCubicBezier(new Vector2(452.238007F, -75.7369995F), new Vector2(453.67099F, -71.7519989F), new Vector2(454.122009F, -68.1409988F));
                    builder.AddCubicBezier(new Vector2(454.574005F, -64.5289993F), new Vector2(454.799011F, -59.2589989F), new Vector2(454.799011F, -52.3390007F));
                    builder.AddLine(new Vector2(454.799011F, 198.677994F));
                    builder.AddCubicBezier(new Vector2(454.799011F, 210.416F), new Vector2(453.368011F, 219.070999F), new Vector2(450.510986F, 224.636993F));
                    builder.AddCubicBezier(new Vector2(447.647003F, 230.210007F), new Vector2(443.286987F, 233.893005F), new Vector2(437.417999F, 235.699005F));
                    builder.AddCubicBezier(new Vector2(431.549011F, 237.505005F), new Vector2(424.247986F, 238.406998F), new Vector2(415.522003F, 238.406998F));
                    builder.AddCubicBezier(new Vector2(406.789001F, 238.406998F), new Vector2(399.868988F, 237.660004F), new Vector2(394.753998F, 236.149994F));
                    builder.AddCubicBezier(new Vector2(389.632996F, 234.647995F), new Vector2(385.725006F, 232.841003F), new Vector2(383.015991F, 230.731995F));
                    builder.AddCubicBezier(new Vector2(380.307007F, 228.630005F), new Vector2(378.346008F, 225.617996F), new Vector2(377.147003F, 221.703003F));
                    builder.AddCubicBezier(new Vector2(375.341003F, 216.589005F), new Vector2(374.437988F, 208.764999F), new Vector2(374.437988F, 198.225998F));
                    builder.AddLine(new Vector2(374.437988F, 143.147003F));
                    builder.AddLine(new Vector2(252.089996F, 143.147003F));
                    builder.AddCubicBezier(new Vector2(231.018997F, 143.147003F), new Vector2(218.526993F, 137.434006F), new Vector2(214.617996F, 125.991997F));
                    builder.AddCubicBezier(new Vector2(213.108994F, 121.181F), new Vector2(212.360992F, 114.705002F), new Vector2(212.360992F, 106.578003F));
                    builder.AddCubicBezier(new Vector2(212.360992F, 98.4520035F), new Vector2(212.811996F, 92.4349976F), new Vector2(213.714996F, 88.5199966F));
                    builder.AddLine(new Vector2(251.186996F, -62.7229996F));
                    builder.AddCubicBezier(new Vector2(252.992996F, -69.6429977F), new Vector2(254.572006F, -74.913002F), new Vector2(255.927002F, -78.5240021F));
                    builder.AddCubicBezier(new Vector2(257.281006F, -82.1360016F), new Vector2(259.990997F, -85.5930023F), new Vector2(264.053986F, -88.9079971F));
                    builder.AddCubicBezier(new Vector2(268.118011F, -92.2160034F), new Vector2(273.30899F, -93.8740005F), new Vector2(279.630005F, -93.8740005F));
                    builder.AddCubicBezier(new Vector2(285.950012F, -93.8740005F), new Vector2(292.869995F, -92.8170013F), new Vector2(300.397003F, -90.7139969F));
                    builder.AddCubicBezier(new Vector2(321.460999F, -84.9929962F), new Vector2(332F, -75.3639984F), new Vector2(332F, -61.8199997F));
                    builder.AddCubicBezier(new Vector2(332F, -57.0019989F), new Vector2(330.94101F, -50.6809998F), new Vector2(328.838989F, -42.8580017F));
                    builder.AddCubicBezier(new Vector2(328.536011F, -42.2519989F), new Vector2(328.388F, -41.7999992F), new Vector2(328.388F, -41.5040016F));
                    builder.AddLine(new Vector2(300.848999F, 68.6549988F));
                    builder.AddLine(new Vector2(374.437988F, 68.6549988F));
                    builder.AddLine(new Vector2(374.437988F, -54.5960007F));
                    builder.AddCubicBezier(new Vector2(374.437988F, -61.5159988F), new Vector2(374.664001F, -66.6309967F), new Vector2(375.115997F, -69.9459991F));
                    builder.AddCubicBezier(new Vector2(375.566986F, -73.2549973F), new Vector2(376.992004F, -77.0149994F), new Vector2(379.403992F, -81.2330017F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_076()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_077(), Geometry_078(), Geometry_079() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_077()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(415.522003F, 242.606995F));
                    builder.AddCubicBezier(new Vector2(406.283997F, 242.606995F), new Vector2(399.10199F, 241.811996F), new Vector2(393.565002F, 240.177994F));
                    builder.AddCubicBezier(new Vector2(387.894012F, 238.514008F), new Vector2(383.596008F, 236.507996F), new Vector2(380.434998F, 234.046005F));
                    builder.AddCubicBezier(new Vector2(377.062012F, 231.429001F), new Vector2(374.613007F, 227.716995F), new Vector2(373.15799F, 223.018005F));
                    builder.AddCubicBezier(new Vector2(371.192993F, 217.403F), new Vector2(370.238007F, 209.291F), new Vector2(370.238007F, 198.225998F));
                    builder.AddLine(new Vector2(370.238007F, 147.347F));
                    builder.AddLine(new Vector2(252.089996F, 147.347F));
                    builder.AddCubicBezier(new Vector2(229.121002F, 147.347F), new Vector2(215.175995F, 140.619003F), new Vector2(210.643005F, 127.348999F));
                    builder.AddCubicBezier(new Vector2(208.962006F, 121.995003F), new Vector2(208.160995F, 115.233002F), new Vector2(208.160995F, 106.578003F));
                    builder.AddCubicBezier(new Vector2(208.160995F, 98.0569992F), new Vector2(208.639008F, 91.8420029F), new Vector2(209.623001F, 87.5759964F));
                    builder.AddLine(new Vector2(247.110001F, -63.7330017F));
                    builder.AddCubicBezier(new Vector2(248.985992F, -70.9229965F), new Vector2(250.580002F, -76.2259979F), new Vector2(251.994995F, -79.9990005F));
                    builder.AddCubicBezier(new Vector2(253.604996F, -84.2910004F), new Vector2(256.769012F, -88.3830032F), new Vector2(261.398987F, -92.1610031F));
                    builder.AddCubicBezier(new Vector2(266.218994F, -96.0849991F), new Vector2(272.35199F, -98.0739975F), new Vector2(279.630005F, -98.0739975F));
                    builder.AddCubicBezier(new Vector2(286.283997F, -98.0739975F), new Vector2(293.652008F, -96.9580002F), new Vector2(301.527008F, -94.7580032F));
                    builder.AddCubicBezier(new Vector2(324.523987F, -88.512001F), new Vector2(336.199005F, -77.4280014F), new Vector2(336.199005F, -61.8199997F));
                    builder.AddCubicBezier(new Vector2(336.199005F, -56.6020012F), new Vector2(335.118988F, -50.0419998F), new Vector2(332.895996F, -41.7680016F));
                    builder.AddLine(new Vector2(332.785004F, -41.3580017F));
                    builder.AddLine(new Vector2(332.595001F, -40.9780006F));
                    builder.AddCubicBezier(new Vector2(332.588989F, -40.9659996F), new Vector2(332.583008F, -40.9529991F), new Vector2(332.576996F, -40.9410019F));
                    builder.AddLine(new Vector2(332.463013F, -40.4850006F));
                    builder.AddLine(new Vector2(306.227997F, 64.4550018F));
                    builder.AddLine(new Vector2(370.238007F, 64.4550018F));
                    builder.AddLine(new Vector2(370.238007F, -54.5960007F));
                    builder.AddCubicBezier(new Vector2(370.238007F, -61.7719994F), new Vector2(370.472992F, -66.9779968F), new Vector2(370.95401F, -70.5130005F));
                    builder.AddCubicBezier(new Vector2(371.484009F, -74.4039993F), new Vector2(373.056F, -78.5920029F), new Vector2(375.759003F, -83.3170013F));
                    builder.AddCubicBezier(new Vector2(378.717987F, -88.4970016F), new Vector2(383.737F, -92.1179962F), new Vector2(390.678009F, -94.0780029F));
                    builder.AddCubicBezier(new Vector2(396.911011F, -95.8310013F), new Vector2(405.040009F, -96.7190018F), new Vector2(414.843994F, -96.7190018F));
                    builder.AddCubicBezier(new Vector2(424.735992F, -96.7190018F), new Vector2(432.863007F, -95.6559982F), new Vector2(439.001007F, -93.5589981F));
                    builder.AddCubicBezier(new Vector2(445.708008F, -91.2570038F), new Vector2(450.587006F, -87.4160004F), new Vector2(453.507996F, -82.1380005F));
                    builder.AddCubicBezier(new Vector2(456.167999F, -77.3099976F), new Vector2(457.774994F, -72.7770004F), new Vector2(458.290009F, -68.6610031F));
                    builder.AddCubicBezier(new Vector2(458.766998F, -64.8430023F), new Vector2(458.998993F, -59.5040016F), new Vector2(458.998993F, -52.3390007F));
                    builder.AddLine(new Vector2(458.998993F, 198.677994F));
                    builder.AddCubicBezier(new Vector2(458.998993F, 211.205994F), new Vector2(457.445007F, 220.324005F), new Vector2(454.247009F, 226.554993F));
                    builder.AddCubicBezier(new Vector2(450.860992F, 233.143997F), new Vector2(445.614014F, 237.570007F), new Vector2(438.653015F, 239.712006F));
                    builder.AddCubicBezier(new Vector2(432.411011F, 241.632996F), new Vector2(424.628998F, 242.606995F), new Vector2(415.522003F, 242.606995F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_078()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(279.630005F, -89.6750031F));
                    builder.AddCubicBezier(new Vector2(274.259003F, -89.6750031F), new Vector2(270.031006F, -88.3580017F), new Vector2(266.704987F, -85.651001F));
                    builder.AddCubicBezier(new Vector2(263.244995F, -82.8280029F), new Vector2(260.94101F, -79.9319992F), new Vector2(259.859985F, -77.0490036F));
                    builder.AddCubicBezier(new Vector2(258.565002F, -73.598999F), new Vector2(257.015015F, -68.4229965F), new Vector2(255.251007F, -61.6629982F));
                    builder.AddLine(new Vector2(217.792007F, 89.5299988F));
                    builder.AddCubicBezier(new Vector2(216.979996F, 93.052002F), new Vector2(216.559998F, 98.8099976F), new Vector2(216.559998F, 106.578003F));
                    builder.AddCubicBezier(new Vector2(216.559998F, 114.259003F), new Vector2(217.255005F, 120.367996F), new Vector2(218.625F, 124.735001F));
                    builder.AddCubicBezier(new Vector2(221.837006F, 134.132004F), new Vector2(233.106995F, 138.947998F), new Vector2(252.089996F, 138.947998F));
                    builder.AddLine(new Vector2(378.638F, 138.947998F));
                    builder.AddLine(new Vector2(378.638F, 198.225998F));
                    builder.AddCubicBezier(new Vector2(378.638F, 208.235992F), new Vector2(379.467987F, 215.664001F), new Vector2(381.106995F, 220.304001F));
                    builder.AddLine(new Vector2(381.162994F, 220.473007F));
                    builder.AddCubicBezier(new Vector2(382.109985F, 223.567001F), new Vector2(383.558014F, 225.837006F), new Vector2(385.589996F, 227.414001F));
                    builder.AddCubicBezier(new Vector2(387.877014F, 229.194F), new Vector2(391.355011F, 230.776993F), new Vector2(395.936005F, 232.119995F));
                    builder.AddCubicBezier(new Vector2(400.631012F, 233.505997F), new Vector2(407.218994F, 234.207993F), new Vector2(415.522003F, 234.207993F));
                    builder.AddCubicBezier(new Vector2(423.790985F, 234.207993F), new Vector2(430.742004F, 233.358994F), new Vector2(436.183014F, 231.684998F));
                    builder.AddCubicBezier(new Vector2(440.96701F, 230.212997F), new Vector2(444.431F, 227.279007F), new Vector2(446.774994F, 222.718002F));
                    builder.AddCubicBezier(new Vector2(449.312012F, 217.774994F), new Vector2(450.600006F, 209.684998F), new Vector2(450.600006F, 198.677994F));
                    builder.AddLine(new Vector2(450.600006F, -52.3390007F));
                    builder.AddCubicBezier(new Vector2(450.600006F, -59.0579987F), new Vector2(450.382996F, -64.1989975F), new Vector2(449.954987F, -67.6190033F));
                    builder.AddCubicBezier(new Vector2(449.572998F, -70.6750031F), new Vector2(448.295013F, -74.1930008F), new Vector2(446.154999F, -78.0770035F));
                    builder.AddCubicBezier(new Vector2(444.25F, -81.5189972F), new Vector2(441.019012F, -83.9860001F), new Vector2(436.279999F, -85.612999F));
                    builder.AddCubicBezier(new Vector2(431.023987F, -87.4089966F), new Vector2(423.809998F, -88.3199997F), new Vector2(414.843994F, -88.3199997F));
                    builder.AddCubicBezier(new Vector2(405.80899F, -88.3199997F), new Vector2(398.445007F, -87.5370026F), new Vector2(392.957001F, -85.9940033F));
                    builder.AddCubicBezier(new Vector2(388.147003F, -84.6350021F), new Vector2(384.904999F, -82.3960037F), new Vector2(383.050995F, -79.1500015F));
                    builder.AddLine(new Vector2(383.049011F, -79.1480026F));
                    builder.AddCubicBezier(new Vector2(380.921997F, -75.4290009F), new Vector2(379.653992F, -72.1409988F), new Vector2(379.277008F, -69.3779984F));
                    builder.AddCubicBezier(new Vector2(378.852997F, -66.2669983F), new Vector2(378.638F, -61.2939987F), new Vector2(378.638F, -54.5960007F));
                    builder.AddLine(new Vector2(378.638F, 72.8550034F));
                    builder.AddLine(new Vector2(295.470001F, 72.8550034F));
                    builder.AddLine(new Vector2(324.237F, -42.2159996F));
                    builder.AddCubicBezier(new Vector2(324.325989F, -42.8699989F), new Vector2(324.536987F, -43.5559998F), new Vector2(324.881989F, -44.3149986F));
                    builder.AddCubicBezier(new Vector2(326.819F, -51.5950012F), new Vector2(327.799988F, -57.4830017F), new Vector2(327.799988F, -61.8199997F));
                    builder.AddCubicBezier(new Vector2(327.799988F, -73.3259964F), new Vector2(318.476013F, -81.4520035F), new Vector2(299.29599F, -86.6610031F));
                    builder.AddCubicBezier(new Vector2(292.127014F, -88.663002F), new Vector2(285.519989F, -89.6750031F), new Vector2(279.630005F, -89.6750031F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_079()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(332.484009F, -40.7350006F));
                    builder.AddLine(new Vector2(332.484009F, -40.7340012F));
                    builder.AddLine(new Vector2(332.484009F, -40.7350006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_080()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-296.756989F, -81.2330017F));
                    builder.AddCubicBezier(new Vector2(-294.35199F, -85.4440002F), new Vector2(-290.209991F, -88.3779984F), new Vector2(-284.341003F, -90.0360031F));
                    builder.AddCubicBezier(new Vector2(-278.471985F, -91.6869965F), new Vector2(-270.798004F, -92.5199966F), new Vector2(-261.316986F, -92.5199966F));
                    builder.AddCubicBezier(new Vector2(-251.835999F, -92.5199966F), new Vector2(-244.238007F, -91.5390015F), new Vector2(-238.516998F, -89.5849991F));
                    builder.AddCubicBezier(new Vector2(-232.802994F, -87.6240005F), new Vector2(-228.740005F, -84.4639969F), new Vector2(-226.326996F, -80.1039963F));
                    builder.AddCubicBezier(new Vector2(-223.921997F, -75.7369995F), new Vector2(-222.490005F, -71.7519989F), new Vector2(-222.039001F, -68.1409988F));
                    builder.AddCubicBezier(new Vector2(-221.587006F, -64.5289993F), new Vector2(-221.360992F, -59.2589989F), new Vector2(-221.360992F, -52.3390007F));
                    builder.AddLine(new Vector2(-221.360992F, 198.677994F));
                    builder.AddCubicBezier(new Vector2(-221.360992F, 210.416F), new Vector2(-222.792999F, 219.070999F), new Vector2(-225.649994F, 224.636993F));
                    builder.AddCubicBezier(new Vector2(-228.514008F, 230.210007F), new Vector2(-232.873993F, 233.893005F), new Vector2(-238.742996F, 235.699005F));
                    builder.AddCubicBezier(new Vector2(-244.612F, 237.505005F), new Vector2(-251.912994F, 238.406998F), new Vector2(-260.639008F, 238.406998F));
                    builder.AddCubicBezier(new Vector2(-269.372009F, 238.406998F), new Vector2(-276.291992F, 237.660004F), new Vector2(-281.407013F, 236.149994F));
                    builder.AddCubicBezier(new Vector2(-286.528015F, 234.647995F), new Vector2(-290.436005F, 232.841003F), new Vector2(-293.144989F, 230.731995F));
                    builder.AddCubicBezier(new Vector2(-295.854004F, 228.630005F), new Vector2(-297.815002F, 225.617996F), new Vector2(-299.014008F, 221.703003F));
                    builder.AddCubicBezier(new Vector2(-300.820007F, 216.589005F), new Vector2(-301.722992F, 208.764999F), new Vector2(-301.722992F, 198.225998F));
                    builder.AddLine(new Vector2(-301.722992F, 143.147003F));
                    builder.AddLine(new Vector2(-424.071014F, 143.147003F));
                    builder.AddCubicBezier(new Vector2(-445.141998F, 143.147003F), new Vector2(-457.634003F, 137.434006F), new Vector2(-461.542999F, 125.991997F));
                    builder.AddCubicBezier(new Vector2(-463.052002F, 121.181F), new Vector2(-463.799988F, 114.705002F), new Vector2(-463.799988F, 106.578003F));
                    builder.AddCubicBezier(new Vector2(-463.799988F, 98.4520035F), new Vector2(-463.348999F, 92.4349976F), new Vector2(-462.446014F, 88.5199966F));
                    builder.AddLine(new Vector2(-424.973999F, -62.7229996F));
                    builder.AddCubicBezier(new Vector2(-423.167999F, -69.6429977F), new Vector2(-421.588013F, -74.913002F), new Vector2(-420.233002F, -78.5240021F));
                    builder.AddCubicBezier(new Vector2(-418.878998F, -82.1360016F), new Vector2(-416.170013F, -85.5930023F), new Vector2(-412.106995F, -88.9079971F));
                    builder.AddCubicBezier(new Vector2(-408.042999F, -92.2160034F), new Vector2(-402.85199F, -93.8740005F), new Vector2(-396.531006F, -93.8740005F));
                    builder.AddCubicBezier(new Vector2(-390.210999F, -93.8740005F), new Vector2(-383.290985F, -92.8170013F), new Vector2(-375.764008F, -90.7139969F));
                    builder.AddCubicBezier(new Vector2(-354.700012F, -84.9929962F), new Vector2(-344.161011F, -75.3639984F), new Vector2(-344.161011F, -61.8199997F));
                    builder.AddCubicBezier(new Vector2(-344.161011F, -57.0019989F), new Vector2(-345.218994F, -50.6809998F), new Vector2(-347.321014F, -42.8580017F));
                    builder.AddCubicBezier(new Vector2(-347.623993F, -42.2519989F), new Vector2(-347.772003F, -41.7999992F), new Vector2(-347.772003F, -41.5040016F));
                    builder.AddLine(new Vector2(-375.312012F, 68.6549988F));
                    builder.AddLine(new Vector2(-301.722992F, 68.6549988F));
                    builder.AddLine(new Vector2(-301.722992F, -54.5960007F));
                    builder.AddCubicBezier(new Vector2(-301.722992F, -61.5159988F), new Vector2(-301.497009F, -66.6309967F), new Vector2(-301.045013F, -69.9459991F));
                    builder.AddCubicBezier(new Vector2(-300.593994F, -73.2549973F), new Vector2(-299.169006F, -77.0149994F), new Vector2(-296.756989F, -81.2330017F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_081()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_082(), Geometry_083(), Geometry_084() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_082()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-260.639008F, 242.606995F));
                    builder.AddCubicBezier(new Vector2(-269.877014F, 242.606995F), new Vector2(-277.058014F, 241.811996F), new Vector2(-282.596008F, 240.177994F));
                    builder.AddCubicBezier(new Vector2(-288.266998F, 238.514008F), new Vector2(-292.563995F, 236.507996F), new Vector2(-295.725006F, 234.046005F));
                    builder.AddCubicBezier(new Vector2(-299.097992F, 231.429001F), new Vector2(-301.548004F, 227.716995F), new Vector2(-303.002991F, 223.018005F));
                    builder.AddCubicBezier(new Vector2(-304.96701F, 217.403F), new Vector2(-305.921997F, 209.291F), new Vector2(-305.921997F, 198.225998F));
                    builder.AddLine(new Vector2(-305.921997F, 147.347F));
                    builder.AddLine(new Vector2(-424.071014F, 147.347F));
                    builder.AddCubicBezier(new Vector2(-447.040009F, 147.347F), new Vector2(-460.984009F, 140.619003F), new Vector2(-465.516998F, 127.348999F));
                    builder.AddCubicBezier(new Vector2(-467.197998F, 121.995003F), new Vector2(-468F, 115.233002F), new Vector2(-468F, 106.578003F));
                    builder.AddCubicBezier(new Vector2(-468F, 98.0569992F), new Vector2(-467.522003F, 91.8420029F), new Vector2(-466.537994F, 87.5759964F));
                    builder.AddLine(new Vector2(-429.049988F, -63.7330017F));
                    builder.AddCubicBezier(new Vector2(-427.174011F, -70.9229965F), new Vector2(-425.580994F, -76.2259979F), new Vector2(-424.165985F, -79.9990005F));
                    builder.AddCubicBezier(new Vector2(-422.556F, -84.2910004F), new Vector2(-419.391998F, -88.3830032F), new Vector2(-414.761993F, -92.1610031F));
                    builder.AddCubicBezier(new Vector2(-409.941986F, -96.0849991F), new Vector2(-403.80899F, -98.0739975F), new Vector2(-396.531006F, -98.0739975F));
                    builder.AddCubicBezier(new Vector2(-389.877014F, -98.0739975F), new Vector2(-382.509003F, -96.9580002F), new Vector2(-374.634003F, -94.7580032F));
                    builder.AddCubicBezier(new Vector2(-351.636993F, -88.512001F), new Vector2(-339.962006F, -77.4280014F), new Vector2(-339.962006F, -61.8199997F));
                    builder.AddCubicBezier(new Vector2(-339.962006F, -56.6020012F), new Vector2(-341.041992F, -50.0419998F), new Vector2(-343.265015F, -41.7680016F));
                    builder.AddLine(new Vector2(-343.376007F, -41.3580017F));
                    builder.AddLine(new Vector2(-343.56601F, -40.9780006F));
                    builder.AddCubicBezier(new Vector2(-343.571991F, -40.9659996F), new Vector2(-343.578003F, -40.9529991F), new Vector2(-343.584015F, -40.9410019F));
                    builder.AddLine(new Vector2(-343.697998F, -40.4850006F));
                    builder.AddLine(new Vector2(-369.933014F, 64.4550018F));
                    builder.AddLine(new Vector2(-305.921997F, 64.4550018F));
                    builder.AddLine(new Vector2(-305.921997F, -54.5960007F));
                    builder.AddCubicBezier(new Vector2(-305.921997F, -61.7719994F), new Vector2(-305.687988F, -66.9779968F), new Vector2(-305.207001F, -70.5130005F));
                    builder.AddCubicBezier(new Vector2(-304.677002F, -74.4039993F), new Vector2(-303.105011F, -78.5920029F), new Vector2(-300.402008F, -83.3170013F));
                    builder.AddCubicBezier(new Vector2(-297.442993F, -88.4970016F), new Vector2(-292.424011F, -92.1179962F), new Vector2(-285.483002F, -94.0780029F));
                    builder.AddCubicBezier(new Vector2(-279.25F, -95.8310013F), new Vector2(-271.121002F, -96.7190018F), new Vector2(-261.316986F, -96.7190018F));
                    builder.AddCubicBezier(new Vector2(-251.425003F, -96.7190018F), new Vector2(-243.298004F, -95.6559982F), new Vector2(-237.160004F, -93.5589981F));
                    builder.AddCubicBezier(new Vector2(-230.453003F, -91.2570038F), new Vector2(-225.574005F, -87.4160004F), new Vector2(-222.653F, -82.1380005F));
                    builder.AddCubicBezier(new Vector2(-219.992996F, -77.3099976F), new Vector2(-218.386002F, -72.7770004F), new Vector2(-217.871002F, -68.6610031F));
                    builder.AddCubicBezier(new Vector2(-217.393997F, -64.8430023F), new Vector2(-217.162003F, -59.5040016F), new Vector2(-217.162003F, -52.3390007F));
                    builder.AddLine(new Vector2(-217.162003F, 198.677994F));
                    builder.AddCubicBezier(new Vector2(-217.162003F, 211.205994F), new Vector2(-218.716003F, 220.324005F), new Vector2(-221.914001F, 226.554993F));
                    builder.AddCubicBezier(new Vector2(-225.300003F, 233.143997F), new Vector2(-230.546997F, 237.570007F), new Vector2(-237.507996F, 239.712006F));
                    builder.AddCubicBezier(new Vector2(-243.75F, 241.632996F), new Vector2(-251.531998F, 242.606995F), new Vector2(-260.639008F, 242.606995F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_083()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-396.531006F, -89.6750031F));
                    builder.AddCubicBezier(new Vector2(-401.902008F, -89.6750031F), new Vector2(-406.130005F, -88.3580017F), new Vector2(-409.455994F, -85.651001F));
                    builder.AddCubicBezier(new Vector2(-412.915985F, -82.8280029F), new Vector2(-415.220001F, -79.9319992F), new Vector2(-416.300995F, -77.0490036F));
                    builder.AddCubicBezier(new Vector2(-417.596008F, -73.598999F), new Vector2(-419.145996F, -68.4229965F), new Vector2(-420.910004F, -61.6629982F));
                    builder.AddLine(new Vector2(-458.368988F, 89.5299988F));
                    builder.AddCubicBezier(new Vector2(-459.181F, 93.052002F), new Vector2(-459.601013F, 98.8099976F), new Vector2(-459.601013F, 106.578003F));
                    builder.AddCubicBezier(new Vector2(-459.601013F, 114.259003F), new Vector2(-458.906006F, 120.367996F), new Vector2(-457.536011F, 124.735001F));
                    builder.AddCubicBezier(new Vector2(-454.324005F, 134.132004F), new Vector2(-443.053986F, 138.947998F), new Vector2(-424.071014F, 138.947998F));
                    builder.AddLine(new Vector2(-297.52301F, 138.947998F));
                    builder.AddLine(new Vector2(-297.52301F, 198.225998F));
                    builder.AddCubicBezier(new Vector2(-297.52301F, 208.235992F), new Vector2(-296.691986F, 215.664001F), new Vector2(-295.053986F, 220.304001F));
                    builder.AddLine(new Vector2(-294.997986F, 220.473007F));
                    builder.AddCubicBezier(new Vector2(-294.050995F, 223.567001F), new Vector2(-292.602997F, 225.837006F), new Vector2(-290.571014F, 227.414001F));
                    builder.AddCubicBezier(new Vector2(-288.283997F, 229.194F), new Vector2(-284.804993F, 230.776993F), new Vector2(-280.223999F, 232.119995F));
                    builder.AddCubicBezier(new Vector2(-275.528992F, 233.505997F), new Vector2(-268.941986F, 234.207993F), new Vector2(-260.639008F, 234.207993F));
                    builder.AddCubicBezier(new Vector2(-252.369995F, 234.207993F), new Vector2(-245.419006F, 233.358994F), new Vector2(-239.977997F, 231.684998F));
                    builder.AddCubicBezier(new Vector2(-235.195007F, 230.212997F), new Vector2(-231.729996F, 227.279007F), new Vector2(-229.386002F, 222.718002F));
                    builder.AddCubicBezier(new Vector2(-226.848999F, 217.774994F), new Vector2(-225.561005F, 209.684998F), new Vector2(-225.561005F, 198.677994F));
                    builder.AddLine(new Vector2(-225.561005F, -52.3390007F));
                    builder.AddCubicBezier(new Vector2(-225.561005F, -59.0579987F), new Vector2(-225.778F, -64.1989975F), new Vector2(-226.205994F, -67.6190033F));
                    builder.AddCubicBezier(new Vector2(-226.587997F, -70.6750031F), new Vector2(-227.865997F, -74.1930008F), new Vector2(-230.005997F, -78.0770035F));
                    builder.AddCubicBezier(new Vector2(-231.910995F, -81.5189972F), new Vector2(-235.141998F, -83.9860001F), new Vector2(-239.880997F, -85.612999F));
                    builder.AddCubicBezier(new Vector2(-245.136993F, -87.4089966F), new Vector2(-252.350998F, -88.3199997F), new Vector2(-261.316986F, -88.3199997F));
                    builder.AddCubicBezier(new Vector2(-270.35199F, -88.3199997F), new Vector2(-277.716003F, -87.5370026F), new Vector2(-283.20401F, -85.9940033F));
                    builder.AddCubicBezier(new Vector2(-288.014008F, -84.6350021F), new Vector2(-291.256012F, -82.3960037F), new Vector2(-293.109985F, -79.1500015F));
                    builder.AddLine(new Vector2(-293.110992F, -79.1480026F));
                    builder.AddCubicBezier(new Vector2(-295.238007F, -75.4290009F), new Vector2(-296.506989F, -72.1409988F), new Vector2(-296.884003F, -69.3779984F));
                    builder.AddCubicBezier(new Vector2(-297.308014F, -66.2669983F), new Vector2(-297.52301F, -61.2939987F), new Vector2(-297.52301F, -54.5960007F));
                    builder.AddLine(new Vector2(-297.52301F, 72.8550034F));
                    builder.AddLine(new Vector2(-380.69101F, 72.8550034F));
                    builder.AddLine(new Vector2(-351.924011F, -42.2159996F));
                    builder.AddCubicBezier(new Vector2(-351.834991F, -42.8699989F), new Vector2(-351.623993F, -43.5559998F), new Vector2(-351.278992F, -44.3149986F));
                    builder.AddCubicBezier(new Vector2(-349.34201F, -51.5950012F), new Vector2(-348.360992F, -57.4830017F), new Vector2(-348.360992F, -61.8199997F));
                    builder.AddCubicBezier(new Vector2(-348.360992F, -73.3259964F), new Vector2(-357.68399F, -81.4520035F), new Vector2(-376.864014F, -86.6610031F));
                    builder.AddCubicBezier(new Vector2(-384.03299F, -88.663002F), new Vector2(-390.640991F, -89.6750031F), new Vector2(-396.531006F, -89.6750031F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_084()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-343.677002F, -40.7350006F));
                    builder.AddLine(new Vector2(-343.677002F, -40.7340012F));
                    builder.AddLine(new Vector2(-343.677002F, -40.7350006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_085()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(154.744003F, -94.2649994F));
                    builder.AddCubicBezier(new Vector2(154.744003F, -94.2649994F), new Vector2(89.1719971F, -99.7669983F), new Vector2(89.1719971F, -99.7669983F));
                    builder.AddCubicBezier(new Vector2(87.6740036F, -114.003998F), new Vector2(84.3560028F, -126.392998F), new Vector2(79.7919998F, -137.171997F));
                    builder.AddCubicBezier(new Vector2(78.6439972F, -139.957993F), new Vector2(77.3840027F, -142.632004F), new Vector2(76.0680008F, -145.194F));
                    builder.AddCubicBezier(new Vector2(72.288002F, -152.544006F), new Vector2(67.9209976F, -159.052994F), new Vector2(63.230999F, -164.792999F));
                    builder.AddCubicBezier(new Vector2(61.3409996F, -167.130997F), new Vector2(59.3810005F, -169.341995F), new Vector2(57.3650017F, -171.427994F));
                    builder.AddCubicBezier(new Vector2(52.0589981F, -177F), new Vector2(46.487999F, -181.718002F), new Vector2(40.9720001F, -185.707993F));
                    builder.AddCubicBezier(new Vector2(38.4659996F, -187.514008F), new Vector2(35.9889984F, -189.164993F), new Vector2(33.5390015F, -190.690994F));
                    builder.AddCubicBezier(new Vector2(14.6540003F, -202.380005F), new Vector2(-1.68299997F, -205.725998F), new Vector2(-1.68299997F, -205.725998F));
                    builder.AddCubicBezier(new Vector2(-1.68299997F, -205.725998F), new Vector2(26.5949993F, -258.139008F), new Vector2(26.5949993F, -258.139008F));
                    builder.AddCubicBezier(new Vector2(46.25F, -253.742996F), new Vector2(62.8950005F, -247.192001F), new Vector2(77.0059967F, -239.197998F));
                    builder.AddCubicBezier(new Vector2(80.2539978F, -237.350006F), new Vector2(83.3759995F, -235.432999F), new Vector2(86.3580017F, -233.431F));
                    builder.AddCubicBezier(new Vector2(97.1230011F, -226.276993F), new Vector2(106.194F, -218.242004F), new Vector2(113.837997F, -209.729996F));
                    builder.AddCubicBezier(new Vector2(116.064003F, -207.251999F), new Vector2(118.178001F, -204.733002F), new Vector2(120.166F, -202.184998F));
                    builder.AddCubicBezier(new Vector2(129.070007F, -190.804001F), new Vector2(135.705002F, -178.834F), new Vector2(140.647003F, -167.158997F));
                    builder.AddCubicBezier(new Vector2(141.865005F, -164.261002F), new Vector2(142.983994F, -161.391006F), new Vector2(144.005997F, -158.548996F));
                    builder.AddCubicBezier(new Vector2(156.451004F, -123.971001F), new Vector2(154.744003F, -94.2649994F), new Vector2(154.744003F, -94.2649994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_086()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(192.947006F, -108.875F));
                    builder.AddCubicBezier(new Vector2(192.947006F, -108.875F), new Vector2(128.330002F, -96.4400024F), new Vector2(128.330002F, -96.4400024F));
                    builder.AddCubicBezier(new Vector2(123.038002F, -109.741997F), new Vector2(116.492996F, -120.772003F), new Vector2(109.183998F, -129.916F));
                    builder.AddCubicBezier(new Vector2(107.325996F, -132.287994F), new Vector2(105.390999F, -134.522003F), new Vector2(103.43F, -136.632004F));
                    builder.AddCubicBezier(new Vector2(97.8040009F, -142.686005F), new Vector2(88.8160019F, -150.679993F), new Vector2(83.2289963F, -155.550995F));
                    builder.AddCubicBezier(new Vector2(80.9629974F, -157.526993F), new Vector2(78.6490021F, -159.365005F), new Vector2(76.3030014F, -161.070999F));
                    builder.AddCubicBezier(new Vector2(70.1139984F, -165.641006F), new Vector2(63.8149986F, -169.334F), new Vector2(57.6870003F, -172.298996F));
                    builder.AddCubicBezier(new Vector2(54.9070015F, -173.643997F), new Vector2(52.1839981F, -174.850006F), new Vector2(49.5040016F, -175.921997F));
                    builder.AddCubicBezier(new Vector2(28.882F, -184.167999F), new Vector2(-1.68299997F, -205.725998F), new Vector2(-1.68299997F, -205.725998F));
                    builder.AddCubicBezier(new Vector2(-1.68299997F, -205.725998F), new Vector2(26.5949993F, -258.139008F), new Vector2(26.5949993F, -258.139008F));
                    builder.AddCubicBezier(new Vector2(46.25F, -253.742996F), new Vector2(68.8300018F, -237.669998F), new Vector2(84.1009979F, -232.209F));
                    builder.AddCubicBezier(new Vector2(87.6190033F, -230.951004F), new Vector2(91.0199966F, -229.587006F), new Vector2(94.3099976F, -228.147003F));
                    builder.AddCubicBezier(new Vector2(106.151001F, -222.964005F), new Vector2(116.296997F, -215.625F), new Vector2(125.299004F, -208.565002F));
                    builder.AddCubicBezier(new Vector2(127.919998F, -206.509995F), new Vector2(130.434998F, -204.389999F), new Vector2(132.835999F, -202.227997F));
                    builder.AddCubicBezier(new Vector2(143.574005F, -192.559006F), new Vector2(151.772995F, -185.164993F), new Vector2(159.662994F, -175.240997F));
                    builder.AddCubicBezier(new Vector2(161.619003F, -172.781006F), new Vector2(163.473007F, -170.320007F), new Vector2(165.225998F, -167.860992F));
                    builder.AddCubicBezier(new Vector2(186.557999F, -137.936996F), new Vector2(192.947006F, -108.875F), new Vector2(192.947006F, -108.875F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_087()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(201.386993F, -121.624001F));
                    builder.AddCubicBezier(new Vector2(201.386993F, -121.624001F), new Vector2(142.436005F, -92.387001F), new Vector2(142.436005F, -92.387001F));
                    builder.AddCubicBezier(new Vector2(133.783997F, -103.792999F), new Vector2(119.016998F, -119.626999F), new Vector2(111.041F, -128.195007F));
                    builder.AddCubicBezier(new Vector2(109.009003F, -130.419998F), new Vector2(106.912003F, -132.503006F), new Vector2(104.797997F, -134.459F));
                    builder.AddCubicBezier(new Vector2(98.7320023F, -140.072006F), new Vector2(88.8160019F, -150.679993F), new Vector2(83.2289963F, -155.550995F));
                    builder.AddCubicBezier(new Vector2(80.9629974F, -157.526993F), new Vector2(78.6490021F, -159.365005F), new Vector2(76.3030014F, -161.070999F));
                    builder.AddCubicBezier(new Vector2(70.1139984F, -165.641006F), new Vector2(63.8149986F, -169.334F), new Vector2(57.6870003F, -172.298996F));
                    builder.AddCubicBezier(new Vector2(54.9070015F, -173.643997F), new Vector2(52.1839981F, -174.850006F), new Vector2(49.5040016F, -175.921997F));
                    builder.AddCubicBezier(new Vector2(28.882F, -184.167999F), new Vector2(-1.68299997F, -205.725998F), new Vector2(-1.68299997F, -205.725998F));
                    builder.AddCubicBezier(new Vector2(-1.68299997F, -205.725998F), new Vector2(26.5949993F, -258.139008F), new Vector2(26.5949993F, -258.139008F));
                    builder.AddCubicBezier(new Vector2(46.25F, -253.742996F), new Vector2(68.7630005F, -239.25F), new Vector2(84.0339966F, -233.789001F));
                    builder.AddCubicBezier(new Vector2(87.552002F, -232.531006F), new Vector2(90.9520035F, -231.166F), new Vector2(94.2419968F, -229.725998F));
                    builder.AddCubicBezier(new Vector2(106.083F, -224.542999F), new Vector2(116.296997F, -215.625F), new Vector2(125.299004F, -208.565002F));
                    builder.AddCubicBezier(new Vector2(127.919998F, -206.509995F), new Vector2(130.434998F, -204.389999F), new Vector2(132.835999F, -202.227997F));
                    builder.AddCubicBezier(new Vector2(143.574005F, -192.559006F), new Vector2(149.350998F, -186.492996F), new Vector2(157.964996F, -177.190994F));
                    builder.AddCubicBezier(new Vector2(160.100998F, -174.884995F), new Vector2(162.134003F, -172.570007F), new Vector2(164.067001F, -170.25F));
                    builder.AddCubicBezier(new Vector2(187.591003F, -142.016006F), new Vector2(201.386993F, -121.624001F), new Vector2(201.386993F, -121.624001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_088()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_089(), Geometry_090() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_089()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(158.688995F, -89.7190018F));
                    builder.AddCubicBezier(new Vector2(158.688995F, -89.7190018F), new Vector2(85.3590012F, -95.8720016F), new Vector2(85.3590012F, -95.8720016F));
                    builder.AddCubicBezier(new Vector2(85.3590012F, -95.8720016F), new Vector2(84.9950027F, -99.3270035F), new Vector2(84.9950027F, -99.3270035F));
                    builder.AddCubicBezier(new Vector2(83.6210022F, -112.383003F), new Vector2(80.5690002F, -124.565002F), new Vector2(75.9240036F, -135.535004F));
                    builder.AddCubicBezier(new Vector2(74.8700027F, -138.093002F), new Vector2(73.6999969F, -140.613007F), new Vector2(72.3320007F, -143.274994F));
                    builder.AddCubicBezier(new Vector2(68.8880005F, -149.972F), new Vector2(64.7320023F, -156.317993F), new Vector2(59.9790001F, -162.136002F));
                    builder.AddCubicBezier(new Vector2(58.1870003F, -164.352005F), new Vector2(56.2960014F, -166.490997F), new Vector2(54.3450012F, -168.509995F));
                    builder.AddCubicBezier(new Vector2(49.5839996F, -173.509995F), new Vector2(44.2639999F, -178.143997F), new Vector2(38.5110016F, -182.304993F));
                    builder.AddCubicBezier(new Vector2(36.1990013F, -183.970993F), new Vector2(33.7770004F, -185.595001F), new Vector2(31.3180008F, -187.126999F));
                    builder.AddCubicBezier(new Vector2(13.3760004F, -198.233002F), new Vector2(-2.37299991F, -201.580994F), new Vector2(-2.52999997F, -201.613007F));
                    builder.AddCubicBezier(new Vector2(-2.52999997F, -201.613007F), new Vector2(-8.05200005F, -202.757004F), new Vector2(-8.05200005F, -202.757004F));
                    builder.AddCubicBezier(new Vector2(-8.05200005F, -202.757004F), new Vector2(24.4080009F, -262.932007F), new Vector2(24.4080009F, -262.932007F));
                    builder.AddCubicBezier(new Vector2(24.4080009F, -262.932007F), new Vector2(27.5119991F, -262.238007F), new Vector2(27.5119991F, -262.238007F));
                    builder.AddCubicBezier(new Vector2(46.5279999F, -257.984985F), new Vector2(63.8769989F, -251.462006F), new Vector2(79.0759964F, -242.852997F));
                    builder.AddCubicBezier(new Vector2(82.487999F, -240.910995F), new Vector2(85.7229996F, -238.916F), new Vector2(88.6989975F, -236.917999F));
                    builder.AddCubicBezier(new Vector2(99.1740036F, -229.957001F), new Vector2(108.689003F, -221.75F), new Vector2(116.962997F, -212.535995F));
                    builder.AddCubicBezier(new Vector2(119.25F, -209.990005F), new Vector2(121.442001F, -207.376999F), new Vector2(123.476997F, -204.768997F));
                    builder.AddCubicBezier(new Vector2(131.878006F, -194.029999F), new Vector2(138.955994F, -181.925995F), new Vector2(144.514008F, -168.796005F));
                    builder.AddCubicBezier(new Vector2(145.763F, -165.822998F), new Vector2(146.921005F, -162.856995F), new Vector2(147.959F, -159.970001F));
                    builder.AddCubicBezier(new Vector2(160.548996F, -124.987999F), new Vector2(159.009003F, -95.2710037F), new Vector2(158.936996F, -94.0230026F));
                    builder.AddCubicBezier(new Vector2(158.936996F, -94.0230026F), new Vector2(158.688995F, -89.7190018F), new Vector2(158.688995F, -89.7190018F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_090()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(92.9449997F, -103.664001F));
                    builder.AddCubicBezier(new Vector2(92.9449997F, -103.664001F), new Vector2(150.612F, -98.8259964F), new Vector2(150.612F, -98.8259964F));
                    builder.AddCubicBezier(new Vector2(150.544006F, -108.142998F), new Vector2(149.328003F, -131.363998F), new Vector2(140.054993F, -157.126007F));
                    builder.AddCubicBezier(new Vector2(139.065994F, -159.876999F), new Vector2(137.962006F, -162.705002F), new Vector2(136.774002F, -165.533005F));
                    builder.AddCubicBezier(new Vector2(131.509003F, -177.972F), new Vector2(124.806999F, -189.436005F), new Vector2(116.858002F, -199.597F));
                    builder.AddCubicBezier(new Vector2(114.939003F, -202.057007F), new Vector2(112.873001F, -204.520004F), new Vector2(110.713997F, -206.923004F));
                    builder.AddCubicBezier(new Vector2(102.912003F, -215.612F), new Vector2(93.9349976F, -223.352997F), new Vector2(84.0329971F, -229.932999F));
                    builder.AddCubicBezier(new Vector2(81.2109985F, -231.826996F), new Vector2(78.1539993F, -233.712997F), new Vector2(74.9290009F, -235.548004F));
                    builder.AddCubicBezier(new Vector2(61.2820015F, -243.279007F), new Vector2(45.7639999F, -249.253998F), new Vector2(28.7689991F, -253.324997F));
                    builder.AddCubicBezier(new Vector2(28.7689991F, -253.324997F), new Vector2(4.54699993F, -208.427994F), new Vector2(4.54699993F, -208.427994F));
                    builder.AddCubicBezier(new Vector2(11.0769997F, -206.483002F), new Vector2(22.8040009F, -202.274994F), new Vector2(35.7490005F, -194.261993F));
                    builder.AddCubicBezier(new Vector2(38.3769989F, -192.625F), new Vector2(40.9580002F, -190.895996F), new Vector2(43.4280014F, -189.115005F));
                    builder.AddCubicBezier(new Vector2(49.6030006F, -184.649002F), new Vector2(55.3129997F, -179.673996F), new Vector2(60.4059982F, -174.324997F));
                    builder.AddCubicBezier(new Vector2(62.5079994F, -172.151001F), new Vector2(64.5650024F, -169.824005F), new Vector2(66.4980011F, -167.432999F));
                    builder.AddCubicBezier(new Vector2(71.6080017F, -161.177994F), new Vector2(76.0889969F, -154.335999F), new Vector2(79.8030014F, -147.115005F));
                    builder.AddCubicBezier(new Vector2(81.2799988F, -144.240997F), new Vector2(82.5459976F, -141.511993F), new Vector2(83.6750031F, -138.772995F));
                    builder.AddCubicBezier(new Vector2(88.2139969F, -128.052994F), new Vector2(91.3310013F, -116.247002F), new Vector2(92.9449997F, -103.664001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_091()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_092(), Geometry_093() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_092()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(197.973999F, -105.565002F));
                    builder.AddCubicBezier(new Vector2(197.973999F, -105.565002F), new Vector2(125.711998F, -91.6589966F), new Vector2(125.711998F, -91.6589966F));
                    builder.AddCubicBezier(new Vector2(125.711998F, -91.6589966F), new Vector2(124.428001F, -94.8880005F), new Vector2(124.428001F, -94.8880005F));
                    builder.AddCubicBezier(new Vector2(119.574997F, -107.085999F), new Vector2(113.342003F, -117.988998F), new Vector2(105.903999F, -127.293999F));
                    builder.AddCubicBezier(new Vector2(104.196999F, -129.472F), new Vector2(102.389999F, -131.580994F), new Vector2(100.351997F, -133.774002F));
                    builder.AddCubicBezier(new Vector2(95.2249985F, -139.291F), new Vector2(86.1480026F, -147.434006F), new Vector2(80.4850006F, -152.371002F));
                    builder.AddCubicBezier(new Vector2(78.336998F, -154.244003F), new Vector2(76.1050034F, -156.022995F), new Vector2(73.8339996F, -157.673996F));
                    builder.AddCubicBezier(new Vector2(68.2799988F, -161.774994F), new Vector2(62.2420006F, -165.429993F), new Vector2(55.8510017F, -168.522003F));
                    builder.AddCubicBezier(new Vector2(53.2849998F, -169.763F), new Vector2(50.6230011F, -170.951004F), new Vector2(47.9329987F, -172.026993F));
                    builder.AddCubicBezier(new Vector2(28.3400002F, -179.860992F), new Vector2(-2.37299991F, -201.580994F), new Vector2(-2.52999997F, -201.613007F));
                    builder.AddCubicBezier(new Vector2(-2.52999997F, -201.613007F), new Vector2(-8.05200005F, -202.757004F), new Vector2(-8.05200005F, -202.757004F));
                    builder.AddCubicBezier(new Vector2(-8.05200005F, -202.757004F), new Vector2(24.4080009F, -262.932007F), new Vector2(24.4080009F, -262.932007F));
                    builder.AddCubicBezier(new Vector2(24.4080009F, -262.932007F), new Vector2(27.5119991F, -262.238007F), new Vector2(27.5119991F, -262.238007F));
                    builder.AddCubicBezier(new Vector2(46.5279999F, -257.984985F), new Vector2(72.012001F, -245.009003F), new Vector2(86.7949982F, -236.850006F));
                    builder.AddCubicBezier(new Vector2(90.2320023F, -234.953003F), new Vector2(92.7289963F, -233.423004F), new Vector2(96.012001F, -231.985992F));
                    builder.AddCubicBezier(new Vector2(107.532997F, -226.942001F), new Vector2(118.146004F, -219.511002F), new Vector2(127.890999F, -211.869003F));
                    builder.AddCubicBezier(new Vector2(130.584F, -209.757004F), new Vector2(133.192001F, -207.559006F), new Vector2(135.649994F, -205.345993F));
                    builder.AddCubicBezier(new Vector2(145.781998F, -196.223007F), new Vector2(154.072998F, -189.024994F), new Vector2(162.944F, -177.863007F));
                    builder.AddCubicBezier(new Vector2(164.949997F, -175.339005F), new Vector2(166.865997F, -172.796005F), new Vector2(168.647003F, -170.296997F));
                    builder.AddCubicBezier(new Vector2(190.227997F, -140.022995F), new Vector2(196.779999F, -110.997002F), new Vector2(197.048004F, -109.776001F));
                    builder.AddCubicBezier(new Vector2(197.048004F, -109.776001F), new Vector2(197.973999F, -105.565002F), new Vector2(197.973999F, -105.565002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_093()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(130.908005F, -101.212997F));
                    builder.AddCubicBezier(new Vector2(130.908005F, -101.212997F), new Vector2(187.735992F, -112.149002F), new Vector2(187.735992F, -112.149002F));
                    builder.AddCubicBezier(new Vector2(185.151001F, -121.099998F), new Vector2(177.694F, -143.123001F), new Vector2(161.806F, -165.421997F));
                    builder.AddCubicBezier(new Vector2(160.110001F, -167.802994F), new Vector2(158.289993F, -170.233002F), new Vector2(156.375F, -172.628998F));
                    builder.AddCubicBezier(new Vector2(147.942001F, -183.179993F), new Vector2(139.602005F, -190.462006F), new Vector2(130.026001F, -199.106995F));
                    builder.AddCubicBezier(new Vector2(127.709999F, -201.197998F), new Vector2(125.248001F, -203.266006F), new Vector2(122.707001F, -205.259995F));
                    builder.AddCubicBezier(new Vector2(113.518997F, -212.468002F), new Vector2(103.561996F, -219.602005F), new Vector2(92.6940002F, -224.421005F));
                    builder.AddCubicBezier(new Vector2(89.586998F, -225.798004F), new Vector2(86.3310013F, -226.940002F), new Vector2(83.0189972F, -228.613007F));
                    builder.AddCubicBezier(new Vector2(72.6790009F, -233.834F), new Vector2(47.5660019F, -246.667007F), new Vector2(28.7689991F, -253.324997F));
                    builder.AddCubicBezier(new Vector2(28.7689991F, -253.324997F), new Vector2(4.54699993F, -208.427994F), new Vector2(4.54699993F, -208.427994F));
                    builder.AddCubicBezier(new Vector2(11.0769997F, -206.483002F), new Vector2(36.9430008F, -185.514008F), new Vector2(51.0629997F, -179.822006F));
                    builder.AddCubicBezier(new Vector2(53.9350014F, -178.664001F), new Vector2(56.7770004F, -177.410995F), new Vector2(59.5159988F, -176.080002F));
                    builder.AddCubicBezier(new Vector2(66.3710022F, -172.748993F), new Vector2(72.8550034F, -168.837006F), new Vector2(78.7969971F, -164.449997F));
                    builder.AddCubicBezier(new Vector2(81.2429962F, -162.673004F), new Vector2(83.6610031F, -160.725006F), new Vector2(85.9889984F, -158.716003F));
                    builder.AddCubicBezier(new Vector2(92.1039963F, -153.440002F), new Vector2(100.980003F, -145.440994F), new Vector2(106.505997F, -139.490997F));
                    builder.AddCubicBezier(new Vector2(108.705002F, -137.123001F), new Vector2(110.662003F, -134.839005F), new Vector2(112.489998F, -132.507004F));
                    builder.AddCubicBezier(new Vector2(119.759003F, -123.414001F), new Vector2(125.952003F, -112.890999F), new Vector2(130.908005F, -101.212997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_094()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_095(), Geometry_096() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_095()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(207.115997F, -119.777F));
                    builder.AddCubicBezier(new Vector2(207.115997F, -119.777F), new Vector2(141.190002F, -87.0810013F), new Vector2(141.190002F, -87.0810013F));
                    builder.AddCubicBezier(new Vector2(141.190002F, -87.0810013F), new Vector2(139.091003F, -89.848999F), new Vector2(139.091003F, -89.848999F));
                    builder.AddCubicBezier(new Vector2(131.156998F, -100.307999F), new Vector2(116.084F, -116.613998F), new Vector2(107.967003F, -125.333F));
                    builder.AddCubicBezier(new Vector2(106.100998F, -127.375999F), new Vector2(102.389999F, -131.580994F), new Vector2(100.351997F, -133.774002F));
                    builder.AddCubicBezier(new Vector2(95.2249985F, -139.291F), new Vector2(86.1480026F, -147.434006F), new Vector2(80.4850006F, -152.371002F));
                    builder.AddCubicBezier(new Vector2(78.336998F, -154.244003F), new Vector2(76.1050034F, -156.022995F), new Vector2(73.8339996F, -157.673996F));
                    builder.AddCubicBezier(new Vector2(68.2799988F, -161.774994F), new Vector2(62.2420006F, -165.429993F), new Vector2(55.8510017F, -168.522003F));
                    builder.AddCubicBezier(new Vector2(53.2849998F, -169.763F), new Vector2(50.6230011F, -170.951004F), new Vector2(47.9329987F, -172.026993F));
                    builder.AddCubicBezier(new Vector2(28.3400002F, -179.860992F), new Vector2(-2.37299991F, -201.580994F), new Vector2(-2.52999997F, -201.613007F));
                    builder.AddCubicBezier(new Vector2(-2.52999997F, -201.613007F), new Vector2(-8.05200005F, -202.757004F), new Vector2(-8.05200005F, -202.757004F));
                    builder.AddCubicBezier(new Vector2(-8.05200005F, -202.757004F), new Vector2(24.4080009F, -262.932007F), new Vector2(24.4080009F, -262.932007F));
                    builder.AddCubicBezier(new Vector2(24.4080009F, -262.932007F), new Vector2(27.5119991F, -262.238007F), new Vector2(27.5119991F, -262.238007F));
                    builder.AddCubicBezier(new Vector2(46.5279999F, -257.984985F), new Vector2(71.9449997F, -246.589005F), new Vector2(86.7279968F, -238.429993F));
                    builder.AddCubicBezier(new Vector2(90.1650009F, -236.533005F), new Vector2(92.6620026F, -235.003006F), new Vector2(95.9449997F, -233.565994F));
                    builder.AddCubicBezier(new Vector2(107.466003F, -228.522003F), new Vector2(118.146004F, -219.511002F), new Vector2(127.890999F, -211.869003F));
                    builder.AddCubicBezier(new Vector2(130.584F, -209.757004F), new Vector2(133.192001F, -207.559006F), new Vector2(135.649994F, -205.345993F));
                    builder.AddCubicBezier(new Vector2(145.781998F, -196.223007F), new Vector2(151.352997F, -190.514008F), new Vector2(161.039001F, -180.052002F));
                    builder.AddCubicBezier(new Vector2(163.229996F, -177.686005F), new Vector2(165.330994F, -175.294006F), new Vector2(167.294998F, -172.936996F));
                    builder.AddCubicBezier(new Vector2(191.093002F, -144.373001F), new Vector2(204.514008F, -124.693001F), new Vector2(205.098999F, -123.587997F));
                    builder.AddCubicBezier(new Vector2(205.098999F, -123.587997F), new Vector2(207.115997F, -119.777F), new Vector2(207.115997F, -119.777F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_096()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(143.647003F, -97.6750031F));
                    builder.AddCubicBezier(new Vector2(143.647003F, -97.6750031F), new Vector2(195.490997F, -123.388F), new Vector2(195.490997F, -123.388F));
                    builder.AddCubicBezier(new Vector2(190.610001F, -131.324005F), new Vector2(178.362F, -146.520996F), new Vector2(160.841003F, -167.561005F));
                    builder.AddCubicBezier(new Vector2(158.970001F, -169.807007F), new Vector2(156.973007F, -172.093002F), new Vector2(154.882996F, -174.337997F));
                    builder.AddCubicBezier(new Vector2(145.679993F, -184.225006F), new Vector2(139.602005F, -190.462006F), new Vector2(130.026001F, -199.106995F));
                    builder.AddCubicBezier(new Vector2(127.709999F, -201.197998F), new Vector2(125.248001F, -203.266006F), new Vector2(122.707001F, -205.259995F));
                    builder.AddCubicBezier(new Vector2(113.518997F, -212.468002F), new Vector2(103.495003F, -221.182007F), new Vector2(92.6269989F, -226.001007F));
                    builder.AddCubicBezier(new Vector2(89.5199966F, -227.378006F), new Vector2(86.2630005F, -228.520004F), new Vector2(82.9509964F, -230.192993F));
                    builder.AddCubicBezier(new Vector2(72.6110001F, -235.414001F), new Vector2(47.5660019F, -246.667007F), new Vector2(28.7689991F, -253.324997F));
                    builder.AddCubicBezier(new Vector2(28.7689991F, -253.324997F), new Vector2(4.54699993F, -208.427994F), new Vector2(4.54699993F, -208.427994F));
                    builder.AddCubicBezier(new Vector2(11.0769997F, -206.483002F), new Vector2(36.9430008F, -185.514008F), new Vector2(51.0629997F, -179.822006F));
                    builder.AddCubicBezier(new Vector2(53.9350014F, -178.664001F), new Vector2(56.7770004F, -177.410995F), new Vector2(59.5159988F, -176.080002F));
                    builder.AddCubicBezier(new Vector2(66.3710022F, -172.748993F), new Vector2(72.8550034F, -168.837006F), new Vector2(78.7969971F, -164.449997F));
                    builder.AddCubicBezier(new Vector2(81.2429962F, -162.673004F), new Vector2(83.6610031F, -160.725006F), new Vector2(85.9889984F, -158.716003F));
                    builder.AddCubicBezier(new Vector2(92.1039963F, -153.440002F), new Vector2(101.692001F, -143.059006F), new Vector2(107.650002F, -137.542007F));
                    builder.AddCubicBezier(new Vector2(110.021004F, -135.345993F), new Vector2(112.143997F, -133.214005F), new Vector2(114.141998F, -131.026993F));
                    builder.AddCubicBezier(new Vector2(122.073997F, -122.505997F), new Vector2(135.751999F, -107.606003F), new Vector2(143.647003F, -97.6750031F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_097()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(140.832993F, -118.212997F));
                    builder.AddCubicBezier(new Vector2(126.549004F, -123.033997F), new Vector2(105.357002F, -126.806F), new Vector2(86.3970032F, -116.862F));
                    builder.AddCubicBezier(new Vector2(86.3970032F, -116.862F), new Vector2(50.7470016F, -85.4329987F), new Vector2(50.3330002F, -72.1220016F));
                    builder.AddCubicBezier(new Vector2(50.3330002F, -72.1220016F), new Vector2(52.2410011F, -52.9970016F), new Vector2(77.7649994F, -64.2020035F));
                    builder.AddCubicBezier(new Vector2(77.7649994F, -64.2020035F), new Vector2(65.1190033F, -5.55800009F), new Vector2(113.189003F, -0.823000014F));
                    builder.AddCubicBezier(new Vector2(113.189003F, -0.823000014F), new Vector2(148.117996F, 4.82999992F), new Vector2(156.990005F, -39.9210014F));
                    builder.AddCubicBezier(new Vector2(157.272995F, -41.3470001F), new Vector2(157.391006F, -42.8009987F), new Vector2(157.393997F, -44.2550011F));
                    builder.AddCubicBezier(new Vector2(157.393997F, -44.2550011F), new Vector2(157.507004F, -94.9020004F), new Vector2(157.507004F, -94.9020004F));
                    builder.AddCubicBezier(new Vector2(157.529999F, -105.448997F), new Vector2(150.826004F, -114.841003F), new Vector2(140.832993F, -118.212997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_098()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(173.078003F, -128.169006F));
                    builder.AddCubicBezier(new Vector2(158.022003F, -128.947006F), new Vector2(136.598999F, -126.848999F), new Vector2(121.035004F, -112.148003F));
                    builder.AddCubicBezier(new Vector2(121.035004F, -112.148003F), new Vector2(95.211998F, -72.25F), new Vector2(98.413002F, -59.3230019F));
                    builder.AddCubicBezier(new Vector2(98.413002F, -59.3230019F), new Vector2(105.420998F, -41.4259987F), new Vector2(126.964996F, -59.1160011F));
                    builder.AddCubicBezier(new Vector2(126.964996F, -59.1160011F), new Vector2(130.649002F, 0.763999999F), new Vector2(178.207993F, -7.67700005F));
                    builder.AddCubicBezier(new Vector2(178.207993F, -7.67700005F), new Vector2(213.367004F, -11.6800003F), new Vector2(209.804993F, -57.1629982F));
                    builder.AddCubicBezier(new Vector2(209.690994F, -58.612999F), new Vector2(209.410995F, -60.0439987F), new Vector2(209.020996F, -61.4449997F));
                    builder.AddCubicBezier(new Vector2(209.020996F, -61.4449997F), new Vector2(195.434006F, -110.236F), new Vector2(195.434006F, -110.236F));
                    builder.AddCubicBezier(new Vector2(192.604996F, -120.396004F), new Vector2(183.610992F, -127.625F), new Vector2(173.078003F, -128.169006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_099()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(177.087997F, -134.912003F));
                    builder.AddCubicBezier(new Vector2(162.371002F, -131.641998F), new Vector2(142.287003F, -123.900002F), new Vector2(131.212997F, -105.577003F));
                    builder.AddCubicBezier(new Vector2(131.212997F, -105.577003F), new Vector2(116.981003F, -60.2330017F), new Vector2(123.516998F, -48.6300011F));
                    builder.AddCubicBezier(new Vector2(123.516998F, -48.6300011F), new Vector2(135.048996F, -33.2540016F), new Vector2(151.087006F, -56.0540009F));
                    builder.AddCubicBezier(new Vector2(151.087006F, -56.0540009F), new Vector2(170.625F, 0.667999983F), new Vector2(214.203995F, -20.1650009F));
                    builder.AddCubicBezier(new Vector2(214.203995F, -20.1650009F), new Vector2(247.018005F, -33.4109993F), new Vector2(231.440994F, -76.2910004F));
                    builder.AddCubicBezier(new Vector2(230.945007F, -77.6579971F), new Vector2(230.292007F, -78.9629974F), new Vector2(229.542007F, -80.2089996F));
                    builder.AddCubicBezier(new Vector2(229.542007F, -80.2089996F), new Vector2(203.421005F, -123.599998F), new Vector2(203.421005F, -123.599998F));
                    builder.AddCubicBezier(new Vector2(197.981003F, -132.636002F), new Vector2(187.384003F, -137.199997F), new Vector2(177.087997F, -134.912003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_100()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_101(), Geometry_102() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_101()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(116.586998F, 3.55999994F));
                    builder.AddCubicBezier(new Vector2(114.610001F, 3.55999994F), new Vector2(113.241997F, 3.41599989F), new Vector2(112.734001F, 3.352F));
                    builder.AddCubicBezier(new Vector2(99.0940018F, 1.99899995F), new Vector2(88.6439972F, -3.53200006F), new Vector2(81.6760025F, -13.0869999F));
                    builder.AddCubicBezier(new Vector2(71.1610031F, -27.5049992F), new Vector2(71.4580002F, -47.3019981F), new Vector2(72.5719986F, -57.8380013F));
                    builder.AddCubicBezier(new Vector2(65.2220001F, -55.7369995F), new Vector2(59.1160011F, -56.0730019F), new Vector2(54.3650017F, -58.8499985F));
                    builder.AddCubicBezier(new Vector2(47.0909996F, -63.1010017F), new Vector2(46.1889992F, -71.3560028F), new Vector2(46.1539993F, -71.7050018F));
                    builder.AddCubicBezier(new Vector2(46.1539993F, -71.7050018F), new Vector2(46.1259995F, -71.9789963F), new Vector2(46.1259995F, -71.9789963F));
                    builder.AddCubicBezier(new Vector2(46.1259995F, -71.9789963F), new Vector2(46.1349983F, -72.2529984F), new Vector2(46.1349983F, -72.2529984F));
                    builder.AddCubicBezier(new Vector2(46.5830002F, -86.6529999F), new Vector2(77.4380035F, -114.563004F), new Vector2(83.6190033F, -120.012001F));
                    builder.AddCubicBezier(new Vector2(83.6190033F, -120.012001F), new Vector2(83.9990005F, -120.346001F), new Vector2(83.9990005F, -120.346001F));
                    builder.AddCubicBezier(new Vector2(83.9990005F, -120.346001F), new Vector2(84.4459991F, -120.581001F), new Vector2(84.4459991F, -120.581001F));
                    builder.AddCubicBezier(new Vector2(104.670998F, -131.190002F), new Vector2(127.001999F, -127.313004F), new Vector2(142.175995F, -122.192001F));
                    builder.AddCubicBezier(new Vector2(142.175995F, -122.192001F), new Vector2(142.175995F, -122.192001F), new Vector2(142.175995F, -122.192001F));
                    builder.AddCubicBezier(new Vector2(153.884995F, -118.239998F), new Vector2(161.733994F, -107.269997F), new Vector2(161.707001F, -94.8929977F));
                    builder.AddCubicBezier(new Vector2(161.707001F, -94.8929977F), new Vector2(161.593994F, -44.2449989F), new Vector2(161.593994F, -44.2449989F));
                    builder.AddCubicBezier(new Vector2(161.589996F, -42.4319992F), new Vector2(161.427002F, -40.7019997F), new Vector2(161.110001F, -39.1040001F));
                    builder.AddCubicBezier(new Vector2(153.417007F, -0.298000008F), new Vector2(126.834999F, 3.55999994F), new Vector2(116.586998F, 3.55999994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_102()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(83.6039963F, -71.3509979F));
                    builder.AddCubicBezier(new Vector2(83.6039963F, -71.3509979F), new Vector2(81.8710022F, -63.3170013F), new Vector2(81.8710022F, -63.3170013F));
                    builder.AddCubicBezier(new Vector2(81.810997F, -63.0400009F), new Vector2(76.0210037F, -35.0620003F), new Vector2(88.4800034F, -18.0119991F));
                    builder.AddCubicBezier(new Vector2(93.9850006F, -10.4790001F), new Vector2(102.436996F, -6.10200024F), new Vector2(113.600998F, -5.00199986F));
                    builder.AddCubicBezier(new Vector2(113.600998F, -5.00199986F), new Vector2(113.860001F, -4.96899986F), new Vector2(113.860001F, -4.96899986F));
                    builder.AddCubicBezier(new Vector2(115.105003F, -4.77799988F), new Vector2(144.931F, -0.68900001F), new Vector2(152.869995F, -40.737999F));
                    builder.AddCubicBezier(new Vector2(153.085007F, -41.8209991F), new Vector2(153.190994F, -42.973999F), new Vector2(153.194F, -44.2649994F));
                    builder.AddCubicBezier(new Vector2(153.194F, -44.2649994F), new Vector2(153.307999F, -94.9120026F), new Vector2(153.307999F, -94.9120026F));
                    builder.AddCubicBezier(new Vector2(153.326996F, -103.672997F), new Vector2(147.774994F, -111.438004F), new Vector2(139.490005F, -114.234001F));
                    builder.AddCubicBezier(new Vector2(125.986F, -118.791F), new Vector2(106.277F, -122.310997F), new Vector2(88.7890015F, -113.371002F));
                    builder.AddCubicBezier(new Vector2(74.7630005F, -100.941002F), new Vector2(55.2929993F, -80.3889999F), new Vector2(54.5499992F, -72.3069992F));
                    builder.AddCubicBezier(new Vector2(54.723999F, -71.3710022F), new Vector2(55.5709991F, -67.8330002F), new Vector2(58.6669998F, -66.064003F));
                    builder.AddCubicBezier(new Vector2(62.3320007F, -63.9710007F), new Vector2(68.3529968F, -64.6569977F), new Vector2(76.0770035F, -68.0479965F));
                    builder.AddCubicBezier(new Vector2(76.0770035F, -68.0479965F), new Vector2(83.6039963F, -71.3509979F), new Vector2(83.6039963F, -71.3509979F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_103()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_104(), Geometry_105() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_104()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(182.664001F, -4.37699986F));
                    builder.AddCubicBezier(new Vector2(180.761002F, -3.84200001F), new Vector2(179.404999F, -3.61100006F), new Vector2(178.899002F, -3.53500009F));
                    builder.AddCubicBezier(new Vector2(165.401993F, -1.14999998F), new Vector2(153.845001F, -3.648F), new Vector2(144.552002F, -10.9630003F));
                    builder.AddCubicBezier(new Vector2(130.529999F, -22F), new Vector2(125.461998F, -41.1409988F), new Vector2(123.685997F, -51.5849991F));
                    builder.AddCubicBezier(new Vector2(117.178001F, -47.5750008F), new Vector2(111.209F, -46.2480011F), new Vector2(105.884003F, -47.6360016F));
                    builder.AddCubicBezier(new Vector2(97.7310028F, -49.762001F), new Vector2(94.6299973F, -57.4650002F), new Vector2(94.5019989F, -57.7919998F));
                    builder.AddCubicBezier(new Vector2(94.5019989F, -57.7919998F), new Vector2(94.4020004F, -58.0480003F), new Vector2(94.4020004F, -58.0480003F));
                    builder.AddCubicBezier(new Vector2(94.4020004F, -58.0480003F), new Vector2(94.3359985F, -58.3139992F), new Vector2(94.3359985F, -58.3139992F));
                    builder.AddCubicBezier(new Vector2(90.8730011F, -72.2979965F), new Vector2(113.031998F, -107.512001F), new Vector2(117.509003F, -114.43F));
                    builder.AddCubicBezier(new Vector2(117.509003F, -114.43F), new Vector2(117.783997F, -114.853996F), new Vector2(117.783997F, -114.853996F));
                    builder.AddCubicBezier(new Vector2(117.783997F, -114.853996F), new Vector2(118.151001F, -115.200996F), new Vector2(118.151001F, -115.200996F));
                    builder.AddCubicBezier(new Vector2(134.753998F, -130.884003F), new Vector2(157.302002F, -133.190002F), new Vector2(173.294998F, -132.363007F));
                    builder.AddCubicBezier(new Vector2(173.294998F, -132.363007F), new Vector2(173.294998F, -132.363007F), new Vector2(173.294998F, -132.363007F));
                    builder.AddCubicBezier(new Vector2(185.636993F, -131.725006F), new Vector2(196.160004F, -123.286003F), new Vector2(199.481003F, -111.362999F));
                    builder.AddCubicBezier(new Vector2(199.481003F, -111.362999F), new Vector2(213.067001F, -62.5709991F), new Vector2(213.067001F, -62.5709991F));
                    builder.AddCubicBezier(new Vector2(213.552994F, -60.8240013F), new Vector2(213.863998F, -59.1150017F), new Vector2(213.990997F, -57.4910011F));
                    builder.AddCubicBezier(new Vector2(217.078003F, -18.0499992F), new Vector2(192.529999F, -7.14799976F), new Vector2(182.664001F, -4.37699986F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_105()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(130.653F, -67.5780029F));
                    builder.AddCubicBezier(new Vector2(130.653F, -67.5780029F), new Vector2(131.156998F, -59.3740005F), new Vector2(131.156998F, -59.3740005F));
                    builder.AddCubicBezier(new Vector2(131.175003F, -59.0909996F), new Vector2(133.166F, -30.5909996F), new Vector2(149.770996F, -17.5450001F));
                    builder.AddCubicBezier(new Vector2(157.108002F, -11.7810001F), new Vector2(166.429001F, -9.85200024F), new Vector2(177.473999F, -11.8120003F));
                    builder.AddCubicBezier(new Vector2(177.473999F, -11.8120003F), new Vector2(177.733002F, -11.8500004F), new Vector2(177.733002F, -11.8500004F));
                    builder.AddCubicBezier(new Vector2(178.983002F, -12.0030003F), new Vector2(208.785995F, -16.1289997F), new Vector2(205.617004F, -56.8349991F));
                    builder.AddCubicBezier(new Vector2(205.531006F, -57.9360008F), new Vector2(205.320999F, -59.0760002F), new Vector2(204.975006F, -60.3190002F));
                    builder.AddCubicBezier(new Vector2(204.975006F, -60.3190002F), new Vector2(191.389008F, -109.110001F), new Vector2(191.389008F, -109.110001F));
                    builder.AddCubicBezier(new Vector2(189.037994F, -117.550003F), new Vector2(181.593002F, -123.524002F), new Vector2(172.860992F, -123.974998F));
                    builder.AddCubicBezier(new Vector2(158.628006F, -124.709999F), new Vector2(138.701004F, -122.771004F), new Vector2(124.281998F, -109.434998F));
                    builder.AddCubicBezier(new Vector2(114.139999F, -93.6760025F), new Vector2(100.954002F, -68.6240005F), new Vector2(102.424004F, -60.6419983F));
                    builder.AddCubicBezier(new Vector2(102.845001F, -59.7879982F), new Vector2(104.614998F, -56.6100006F), new Vector2(108.074997F, -55.7449989F));
                    builder.AddCubicBezier(new Vector2(112.169998F, -54.7210007F), new Vector2(117.780998F, -57.0089989F), new Vector2(124.300003F, -62.3619995F));
                    builder.AddCubicBezier(new Vector2(124.300003F, -62.3619995F), new Vector2(130.653F, -67.5780029F), new Vector2(130.653F, -67.5780029F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_106()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_107(), Geometry_108() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_107()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(219.380005F, -18.1739998F));
                    builder.AddCubicBezier(new Vector2(217.688995F, -17.1509991F), new Vector2(216.442993F, -16.566F), new Vector2(215.975998F, -16.3570004F));
                    builder.AddCubicBezier(new Vector2(203.604996F, -10.4540005F), new Vector2(191.802002F, -9.77700043F), new Vector2(180.893005F, -14.3450003F));
                    builder.AddCubicBezier(new Vector2(164.432999F, -21.2369995F), new Vector2(154.438995F, -38.3289986F), new Vector2(149.938004F, -47.9199982F));
                    builder.AddCubicBezier(new Vector2(144.737F, -42.3180008F), new Vector2(139.339996F, -39.4459991F), new Vector2(133.837006F, -39.3619995F));
                    builder.AddCubicBezier(new Vector2(125.413002F, -39.2340012F), new Vector2(120.367996F, -45.8289986F), new Vector2(120.156998F, -46.1100006F));
                    builder.AddCubicBezier(new Vector2(120.156998F, -46.1100006F), new Vector2(119.991997F, -46.3289986F), new Vector2(119.991997F, -46.3289986F));
                    builder.AddCubicBezier(new Vector2(119.991997F, -46.3289986F), new Vector2(119.857002F, -46.5680008F), new Vector2(119.857002F, -46.5680008F));
                    builder.AddCubicBezier(new Vector2(112.786003F, -59.1199989F), new Vector2(124.737999F, -98.9729996F), new Vector2(127.205002F, -106.834999F));
                    builder.AddCubicBezier(new Vector2(127.205002F, -106.834999F), new Vector2(127.357002F, -107.317001F), new Vector2(127.357002F, -107.317001F));
                    builder.AddCubicBezier(new Vector2(127.357002F, -107.317001F), new Vector2(127.617996F, -107.749001F), new Vector2(127.617996F, -107.749001F));
                    builder.AddCubicBezier(new Vector2(139.429993F, -127.294998F), new Vector2(160.544006F, -135.539001F), new Vector2(176.177002F, -139.011993F));
                    builder.AddCubicBezier(new Vector2(176.177002F, -139.011993F), new Vector2(176.177002F, -139.011993F), new Vector2(176.177002F, -139.011993F));
                    builder.AddCubicBezier(new Vector2(188.240997F, -141.692001F), new Vector2(200.634995F, -136.369995F), new Vector2(207.018997F, -125.765999F));
                    builder.AddCubicBezier(new Vector2(207.018997F, -125.765999F), new Vector2(233.139999F, -82.3740005F), new Vector2(233.139999F, -82.3740005F));
                    builder.AddCubicBezier(new Vector2(234.074997F, -80.8199997F), new Vector2(234.832001F, -79.2549973F), new Vector2(235.388F, -77.723999F));
                    builder.AddCubicBezier(new Vector2(248.893997F, -40.5390015F), new Vector2(228.147995F, -23.4790001F), new Vector2(219.380005F, -18.1739998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_108()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(152.382004F, -65.1930008F));
                    builder.AddCubicBezier(new Vector2(152.382004F, -65.1930008F), new Vector2(155.057999F, -57.4220009F), new Vector2(155.057999F, -57.4220009F));
                    builder.AddCubicBezier(new Vector2(155.149994F, -57.1539993F), new Vector2(164.679001F, -30.2199993F), new Vector2(184.164993F, -22.0809994F));
                    builder.AddCubicBezier(new Vector2(192.774002F, -18.4850006F), new Vector2(202.272003F, -19.1159992F), new Vector2(212.393005F, -23.9540005F));
                    builder.AddCubicBezier(new Vector2(212.393005F, -23.9540005F), new Vector2(212.632996F, -24.0599995F), new Vector2(212.632996F, -24.0599995F));
                    builder.AddCubicBezier(new Vector2(213.796997F, -24.5410004F), new Vector2(241.414993F, -36.4749985F), new Vector2(227.492996F, -74.8570023F));
                    builder.AddCubicBezier(new Vector2(227.115997F, -75.8949966F), new Vector2(226.610001F, -76.935997F), new Vector2(225.944F, -78.0419998F));
                    builder.AddCubicBezier(new Vector2(225.944F, -78.0419998F), new Vector2(199.822998F, -121.433998F), new Vector2(199.822998F, -121.433998F));
                    builder.AddCubicBezier(new Vector2(195.304001F, -128.940002F), new Vector2(186.533005F, -132.710007F), new Vector2(177.998001F, -130.813004F));
                    builder.AddCubicBezier(new Vector2(164.085007F, -127.721001F), new Vector2(145.401001F, -120.530998F), new Vector2(135.065994F, -103.829002F));
                    builder.AddCubicBezier(new Vector2(129.5F, -85.9339981F), new Vector2(123.481003F, -58.2719994F), new Vector2(127.028999F, -50.9720001F));
                    builder.AddCubicBezier(new Vector2(127.662003F, -50.262001F), new Vector2(130.218002F, -47.6710014F), new Vector2(133.783005F, -47.7610016F));
                    builder.AddCubicBezier(new Vector2(138.001999F, -47.868F), new Vector2(142.798996F, -51.5699997F), new Vector2(147.651993F, -58.4700012F));
                    builder.AddCubicBezier(new Vector2(147.651993F, -58.4700012F), new Vector2(152.382004F, -65.1930008F), new Vector2(152.382004F, -65.1930008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_109()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(144.005997F, -158.548996F));
                    builder.AddCubicBezier(new Vector2(129.139008F, -159.192993F), new Vector2(100.819F, -157.330994F), new Vector2(79.7919998F, -137.171997F));
                    builder.AddCubicBezier(new Vector2(78.6439972F, -139.957993F), new Vector2(77.3840027F, -142.632004F), new Vector2(76.0680008F, -145.194F));
                    builder.AddCubicBezier(new Vector2(97.4449997F, -164.386993F), new Vector2(124.225998F, -167.438995F), new Vector2(140.647003F, -167.158997F));
                    builder.AddCubicBezier(new Vector2(141.865005F, -164.261002F), new Vector2(142.983994F, -161.391006F), new Vector2(144.005997F, -158.548996F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_110()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(165.225998F, -167.860992F));
                    builder.AddCubicBezier(new Vector2(150.738998F, -164.460999F), new Vector2(123.975998F, -155.009995F), new Vector2(109.183998F, -129.916F));
                    builder.AddCubicBezier(new Vector2(107.325996F, -132.287994F), new Vector2(105.389999F, -134.520996F), new Vector2(103.43F, -136.632004F));
                    builder.AddCubicBezier(new Vector2(118.82F, -160.889999F), new Vector2(143.778F, -171.070007F), new Vector2(159.662994F, -175.240997F));
                    builder.AddCubicBezier(new Vector2(161.619003F, -172.781006F), new Vector2(163.473999F, -170.320999F), new Vector2(165.225998F, -167.860992F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_111()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(164.067001F, -170.25F));
                    builder.AddCubicBezier(new Vector2(149.876999F, -165.768997F), new Vector2(123.903F, -154.330994F), new Vector2(111.041F, -128.195007F));
                    builder.AddCubicBezier(new Vector2(109.009003F, -130.419998F), new Vector2(106.911003F, -132.501999F), new Vector2(104.797997F, -134.459F));
                    builder.AddCubicBezier(new Vector2(118.319F, -159.807007F), new Vector2(142.438995F, -171.835999F), new Vector2(157.964996F, -177.190994F));
                    builder.AddCubicBezier(new Vector2(160.100998F, -174.884995F), new Vector2(162.134995F, -172.570999F), new Vector2(164.067001F, -170.25F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_112()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(120.166F, -202.184998F));
                    builder.AddCubicBezier(new Vector2(107.035004F, -201.134995F), new Vector2(80.2819977F, -195.115005F), new Vector2(63.230999F, -164.792999F));
                    builder.AddCubicBezier(new Vector2(61.3409996F, -167.130997F), new Vector2(59.3810005F, -169.341995F), new Vector2(57.3650017F, -171.427994F));
                    builder.AddCubicBezier(new Vector2(73.9400024F, -198.781998F), new Vector2(98.3270035F, -207.210007F), new Vector2(113.837997F, -209.729996F));
                    builder.AddCubicBezier(new Vector2(116.064003F, -207.251999F), new Vector2(118.178001F, -204.733002F), new Vector2(120.166F, -202.184998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_113()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(132.835999F, -202.227997F));
                    builder.AddCubicBezier(new Vector2(120.084F, -198.921997F), new Vector2(94.7770004F, -188.365997F), new Vector2(83.2289963F, -155.550995F));
                    builder.AddCubicBezier(new Vector2(80.9629974F, -157.526993F), new Vector2(78.6490021F, -159.365005F), new Vector2(76.3030014F, -161.070999F));
                    builder.AddCubicBezier(new Vector2(87.8960037F, -190.880005F), new Vector2(110.458F, -203.399994F), new Vector2(125.299004F, -208.565002F));
                    builder.AddCubicBezier(new Vector2(127.919998F, -206.509995F), new Vector2(130.436996F, -204.393997F), new Vector2(132.835999F, -202.227997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_114()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(86.3580017F, -233.431F));
                    builder.AddCubicBezier(new Vector2(74.5709991F, -230.574997F), new Vector2(48.6160011F, -220.425995F), new Vector2(40.9720001F, -185.707993F));
                    builder.AddCubicBezier(new Vector2(38.4659996F, -187.514008F), new Vector2(35.9889984F, -189.164993F), new Vector2(33.5390015F, -190.690994F));
                    builder.AddCubicBezier(new Vector2(41.4210014F, -220.985001F), new Vector2(62.5589981F, -233.835999F), new Vector2(77.0059967F, -239.197998F));
                    builder.AddCubicBezier(new Vector2(80.2539978F, -237.350006F), new Vector2(83.3759995F, -235.432999F), new Vector2(86.3580017F, -233.431F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_115()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(94.3099976F, -228.147003F));
                    builder.AddCubicBezier(new Vector2(83.1940002F, -223.294998F), new Vector2(59.2089996F, -207.815994F), new Vector2(57.6870003F, -172.298996F));
                    builder.AddCubicBezier(new Vector2(54.9070015F, -173.643997F), new Vector2(52.1809998F, -174.843002F), new Vector2(49.5040016F, -175.921997F));
                    builder.AddCubicBezier(new Vector2(52.026001F, -207.123001F), new Vector2(70.7990036F, -224.429001F), new Vector2(84.1009979F, -232.209F));
                    builder.AddCubicBezier(new Vector2(87.6190033F, -230.951004F), new Vector2(91.0270004F, -229.602997F), new Vector2(94.3099976F, -228.147003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_116()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(94.2419968F, -229.725998F));
                    builder.AddCubicBezier(new Vector2(83.1259995F, -224.873993F), new Vector2(59.2089996F, -207.815994F), new Vector2(57.6870003F, -172.298996F));
                    builder.AddCubicBezier(new Vector2(54.9070015F, -173.643997F), new Vector2(52.1809998F, -174.843002F), new Vector2(49.5040016F, -175.921997F));
                    builder.AddCubicBezier(new Vector2(52.026001F, -207.123001F), new Vector2(70.7320023F, -226.009003F), new Vector2(84.0339966F, -233.789001F));
                    builder.AddCubicBezier(new Vector2(87.552002F, -232.531006F), new Vector2(90.9589996F, -231.182007F), new Vector2(94.2419968F, -229.725998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head
            // - - ShapeGroup: Group 6
            CanvasGeometry Geometry_117()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(16.5869999F, -334.468994F));
                    builder.AddLine(new Vector2(31.1219997F, -337.278015F));
                    builder.AddCubicBezier(new Vector2(38.8520012F, -338.772003F), new Vector2(46.3289986F, -333.71701F), new Vector2(47.8230019F, -325.987F));
                    builder.AddLine(new Vector2(54.2529984F, -292.709991F));
                    builder.AddCubicBezier(new Vector2(55.7470016F, -284.980011F), new Vector2(50.6920013F, -277.503998F), new Vector2(42.9620018F, -276.01001F));
                    builder.AddLine(new Vector2(28.427F, -273.200989F));
                    builder.AddLine(new Vector2(16.5869999F, -334.468994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head
            // - - ShapeGroup: Group 6
            CanvasGeometry Geometry_118()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-170.520996F, -298.309998F));
                    builder.AddLine(new Vector2(-185.057007F, -295.501007F));
                    builder.AddCubicBezier(new Vector2(-192.787003F, -294.006989F), new Vector2(-197.841995F, -286.531006F), new Vector2(-196.348007F, -278.800995F));
                    builder.AddLine(new Vector2(-189.917007F, -245.524994F));
                    builder.AddCubicBezier(new Vector2(-188.423004F, -237.794998F), new Vector2(-180.947006F, -232.738998F), new Vector2(-173.216995F, -234.233002F));
                    builder.AddLine(new Vector2(-158.681F, -237.042999F));
                    builder.AddLine(new Vector2(-170.520996F, -298.309998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head
            // - - ShapeGroup: Group 6
            CanvasGeometry Geometry_119()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-176.949005F, -264.666992F));
                    builder.AddCubicBezier(new Vector2(-165.602005F, -205.949005F), new Vector2(-108.803001F, -167.548004F), new Vector2(-50.0849991F, -178.895004F));
                    builder.AddCubicBezier(new Vector2(8.63300037F, -190.242004F), new Vector2(47.0340004F, -247.041F), new Vector2(35.6870003F, -305.759003F));
                    builder.AddCubicBezier(new Vector2(24.3400002F, -364.47699F), new Vector2(-32.4589996F, -402.877991F), new Vector2(-91.177002F, -391.531006F));
                    builder.AddCubicBezier(new Vector2(-149.895004F, -380.18399F), new Vector2(-188.296005F, -323.38501F), new Vector2(-176.949005F, -264.666992F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head
            // - - ShapeGroup: Group 6
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_120()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_121(), Geometry_122() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - - - Layer aggregator
            // - - - - Transforms: head
            // - - - ShapeGroup: Group 6
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_121()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-70.8649979F, -172.695007F));
                    builder.AddCubicBezier(new Vector2(-93.0940018F, -172.695007F), new Vector2(-114.809998F, -179.300995F), new Vector2(-133.632996F, -192.026993F));
                    builder.AddCubicBezier(new Vector2(-158.524002F, -208.856003F), new Vector2(-175.371994F, -234.369995F), new Vector2(-181.072006F, -263.869995F));
                    builder.AddCubicBezier(new Vector2(-192.841003F, -324.768005F), new Vector2(-152.871002F, -383.885986F), new Vector2(-91.973999F, -395.653992F));
                    builder.AddCubicBezier(new Vector2(-62.4749985F, -401.356995F), new Vector2(-32.5180016F, -395.22699F), new Vector2(-7.62799978F, -378.39801F));
                    builder.AddCubicBezier(new Vector2(17.2630005F, -361.570007F), new Vector2(34.1090012F, -336.054993F), new Vector2(39.8100014F, -306.556F));
                    builder.AddCubicBezier(new Vector2(51.5789986F, -245.658005F), new Vector2(11.6090002F, -186.541F), new Vector2(-49.2879982F, -174.772003F));
                    builder.AddCubicBezier(new Vector2(-56.4799995F, -173.382004F), new Vector2(-63.7000008F, -172.695007F), new Vector2(-70.8649979F, -172.695007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - - Layer aggregator
            // - - - - Transforms: head
            // - - - ShapeGroup: Group 6
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_122()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-70.413002F, -389.32901F));
                    builder.AddCubicBezier(new Vector2(-77.0449982F, -389.32901F), new Vector2(-83.7229996F, -388.694F), new Vector2(-90.3789978F, -387.40799F));
                    builder.AddCubicBezier(new Vector2(-146.729004F, -376.518005F), new Vector2(-183.714996F, -321.813995F), new Vector2(-172.826004F, -265.463989F));
                    builder.AddCubicBezier(new Vector2(-167.550003F, -238.167007F), new Vector2(-151.960999F, -214.557999F), new Vector2(-128.929001F, -198.985992F));
                    builder.AddCubicBezier(new Vector2(-105.897003F, -183.414993F), new Vector2(-78.1790009F, -177.744003F), new Vector2(-50.882F, -183.018005F));
                    builder.AddCubicBezier(new Vector2(5.46799994F, -193.908005F), new Vector2(42.4529991F, -248.612F), new Vector2(31.5639992F, -304.962006F));
                    builder.AddCubicBezier(new Vector2(26.2880001F, -332.259003F), new Vector2(10.6990004F, -355.868011F), new Vector2(-12.3330002F, -371.440002F));
                    builder.AddCubicBezier(new Vector2(-29.7490005F, -383.214996F), new Vector2(-49.8470001F, -389.32901F), new Vector2(-70.413002F, -389.32901F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head
            // - - ShapeGroup: Group 6
            CanvasGeometry Geometry_123()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(12.4969997F, -283.080994F));
                    builder.AddLine(new Vector2(5.60200024F, -318.764008F));
                    builder.AddCubicBezier(new Vector2(0.887000024F, -343.162994F), new Vector2(-22.7140007F, -359.118988F), new Vector2(-47.112999F, -354.403992F));
                    builder.AddLine(new Vector2(-117.634003F, -340.776001F));
                    builder.AddCubicBezier(new Vector2(-142.033005F, -336.061005F), new Vector2(-157.990005F, -312.459991F), new Vector2(-153.274994F, -288.061005F));
                    builder.AddLine(new Vector2(-146.378998F, -252.378998F));
                    builder.AddCubicBezier(new Vector2(-141.664001F, -227.979996F), new Vector2(-118.063004F, -212.022995F), new Vector2(-93.6640015F, -216.738007F));
                    builder.AddLine(new Vector2(-23.1429996F, -230.367004F));
                    builder.AddCubicBezier(new Vector2(1.25600004F, -235.082001F), new Vector2(17.2119999F, -258.682007F), new Vector2(12.4969997F, -283.080994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head
            // - - ShapeGroup: Group 6
            CanvasGeometry Geometry_124()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-26.5319996F, -304.484009F));
                    builder.AddCubicBezier(new Vector2(-25.4260006F, -298.760986F), new Vector2(-19.8899994F, -295.018005F), new Vector2(-14.1680002F, -296.123993F));
                    builder.AddCubicBezier(new Vector2(-8.44499969F, -297.230011F), new Vector2(-4.70300007F, -302.765015F), new Vector2(-5.80900002F, -308.488007F));
                    builder.AddCubicBezier(new Vector2(-6.91499996F, -314.209991F), new Vector2(-12.4499998F, -317.953003F), new Vector2(-18.1730003F, -316.846985F));
                    builder.AddCubicBezier(new Vector2(-23.8950005F, -315.740997F), new Vector2(-27.6380005F, -310.205994F), new Vector2(-26.5319996F, -304.484009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head
            // - - ShapeGroup: Group 6
            CanvasGeometry Geometry_125()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-39.2459984F, -323.52301F));
                    builder.AddCubicBezier(new Vector2(-38.5250015F, -319.790985F), new Vector2(-34.9150009F, -317.351013F), new Vector2(-31.1830006F, -318.071991F));
                    builder.AddCubicBezier(new Vector2(-27.4510002F, -318.792999F), new Vector2(-25.0100002F, -322.403015F), new Vector2(-25.7310009F, -326.13501F));
                    builder.AddCubicBezier(new Vector2(-26.4519997F, -329.867004F), new Vector2(-30.0629997F, -332.308014F), new Vector2(-33.7949982F, -331.587006F));
                    builder.AddCubicBezier(new Vector2(-37.5270004F, -330.865997F), new Vector2(-39.9669991F, -327.255005F), new Vector2(-39.2459984F, -323.52301F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // Color bound to theme property value: Color_2E03E4
            CompositionColorBrush ThemeColor_Color_2E03E4()
            {
                if (_themeColor_Color_2E03E4 != null) { return _themeColor_Color_2E03E4; }
                var result = _themeColor_Color_2E03E4 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_2E03E4, "Color", "ColorRGB(_theme.Color_2E03E4.W,_theme.Color_2E03E4.X,_theme.Color_2E03E4.Y,_theme.Color_2E03E4.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_758BDF
            CompositionColorBrush ThemeColor_Color_758BDF()
            {
                if (_themeColor_Color_758BDF != null) { return _themeColor_Color_758BDF; }
                var result = _themeColor_Color_758BDF = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_758BDF, "Color", "ColorRGB(_theme.Color_758BDF.W,_theme.Color_758BDF.X,_theme.Color_758BDF.Y,_theme.Color_758BDF.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_849AF5
            CompositionColorBrush ThemeColor_Color_849AF5()
            {
                if (_themeColor_Color_849AF5 != null) { return _themeColor_Color_849AF5; }
                var result = _themeColor_Color_849AF5 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_849AF5, "Color", "ColorRGB(_theme.Color_849AF5.W,_theme.Color_849AF5.X,_theme.Color_849AF5.Y,_theme.Color_849AF5.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_91A6FE
            CompositionColorBrush ThemeColor_Color_91A6FE()
            {
                if (_themeColor_Color_91A6FE != null) { return _themeColor_Color_91A6FE; }
                var result = _themeColor_Color_91A6FE = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_91A6FE, "Color", "ColorRGB(_theme.Color_91A6FE.W,_theme.Color_91A6FE.X,_theme.Color_91A6FE.Y,_theme.Color_91A6FE.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_EAEAEA
            CompositionColorBrush ThemeColor_Color_EAEAEA()
            {
                if (_themeColor_Color_EAEAEA != null) { return _themeColor_Color_EAEAEA; }
                var result = _themeColor_Color_EAEAEA = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_EAEAEA, "Color", "ColorRGB(_theme.Color_EAEAEA.W,_theme.Color_EAEAEA.X,_theme.Color_EAEAEA.Y,_theme.Color_EAEAEA.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF()
            {
                if (_themeColor_Color_FFFFFF != null) { return _themeColor_Color_FFFFFF; }
                var result = _themeColor_Color_FFFFFF = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_FFFFFF, "Color", "ColorRGB(_theme.Color_FFFFFF.W,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties);
                return result;
            }

            // Layer aggregator
            // Layer: Shape Layer 4
            CompositionContainerShape ContainerShape_0()
            {
                if (_containerShape_0 != null) { return _containerShape_0; }
                var result = _containerShape_0 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(281.597992F, -267.171997F);
                result.RotationAngleInDegrees = -57F;
                result.Scale = new Vector2(0F, 0F);
                var shapes = result.Shapes;
                // Transforms: Shape Layer 4 RotationDegrees:2.0490000247955322,
                // Offset:<-37.087006, -39.337006>
                shapes.Add(SpriteShape_07());
                // Transforms: Shape Layer 4 RotationDegrees:2.0490000247955322,
                // Offset:<-37.087006, -39.337006>
                shapes.Add(SpriteShape_08());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_09());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_10());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_11());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_12());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_13());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_14());
                return result;
            }

            // Layer aggregator
            // Layer: Shape Layer 8
            CompositionContainerShape ContainerShape_1()
            {
                if (_containerShape_1 != null) { return _containerShape_1; }
                var result = _containerShape_1 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(281.597992F, -267.171997F);
                result.RotationAngleInDegrees = -57F;
                result.Scale = new Vector2(0F, 0F);
                var shapes = result.Shapes;
                // Transforms: Shape Layer 8 RotationDegrees:2.0490000247955322,
                // Offset:<-37.087006, -39.337006>
                shapes.Add(SpriteShape_15());
                // Transforms: Shape Layer 8 RotationDegrees:2.0490000247955322,
                // Offset:<-37.087006, -39.337006>
                shapes.Add(SpriteShape_16());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_17());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_18());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_19());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_20());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_21());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_22());
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_2()
            {
                if (_containerShape_2 != null) { return _containerShape_2; }
                var result = _containerShape_2 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(3.32599998F, 13.7749996F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 2
                shapes.Add(SpriteShape_23());
                // ShapeGroup: Group 2
                shapes.Add(SpriteShape_24());
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_3()
            {
                if (_containerShape_3 != null) { return _containerShape_3; }
                var result = _containerShape_3 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(3.32599998F, 13.7749996F);
                // Transforms: r hand
                result.Shapes.Add(ContainerShape_4());
                return result;
            }

            // - Layer aggregator
            // Transforms for r hand
            CompositionContainerShape ContainerShape_4()
            {
                if (_containerShape_4 != null) { return _containerShape_4; }
                var result = _containerShape_4 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(-132.710007F, -219.875F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_46());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_47());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_48());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_49());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_50());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_51());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_52());
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_5()
            {
                if (_containerShape_5 != null) { return _containerShape_5; }
                var result = _containerShape_5 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(3.32599998F, 13.7749996F);
                var shapes = result.Shapes;
                // Transforms: l hand
                shapes.Add(ContainerShape_6());
                // Transforms: head
                shapes.Add(ContainerShape_7());
                return result;
            }

            // - Layer aggregator
            // Transforms for l hand
            CompositionContainerShape ContainerShape_6()
            {
                if (_containerShape_6 != null) { return _containerShape_6; }
                var result = _containerShape_6 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(24.8279991F, -261.186005F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_57());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_58());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_59());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_60());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_61());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_62());
                // ShapeGroup: Group 5
                shapes.Add(SpriteShape_63());
                return result;
            }

            // - Layer aggregator
            // Transforms for head
            CompositionContainerShape ContainerShape_7()
            {
                if (_containerShape_7 != null) { return _containerShape_7; }
                var result = _containerShape_7 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(-45.0470009F, -185.212997F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_64());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_65());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_66());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_67());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_68());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_69());
                // ShapeGroup: Group 6
                shapes.Add(SpriteShape_70());
                return result;
            }

            CompositionPath Path_00()
            {
                if (_path_00 != null) { return _path_00; }
                var result = _path_00 = new CompositionPath(Geometry_007());
                return result;
            }

            CompositionPath Path_01()
            {
                if (_path_01 != null) { return _path_01; }
                var result = _path_01 = new CompositionPath(Geometry_008());
                return result;
            }

            CompositionPath Path_02()
            {
                if (_path_02 != null) { return _path_02; }
                var result = _path_02 = new CompositionPath(Geometry_009());
                return result;
            }

            CompositionPath Path_03()
            {
                if (_path_03 != null) { return _path_03; }
                var result = _path_03 = new CompositionPath(Geometry_053());
                return result;
            }

            CompositionPath Path_04()
            {
                if (_path_04 != null) { return _path_04; }
                var result = _path_04 = new CompositionPath(Geometry_054());
                return result;
            }

            CompositionPath Path_05()
            {
                if (_path_05 != null) { return _path_05; }
                var result = _path_05 = new CompositionPath(Geometry_055());
                return result;
            }

            CompositionPath Path_06()
            {
                if (_path_06 != null) { return _path_06; }
                var result = _path_06 = new CompositionPath(Geometry_058());
                return result;
            }

            CompositionPath Path_07()
            {
                if (_path_07 != null) { return _path_07; }
                var result = _path_07 = new CompositionPath(Geometry_061());
                return result;
            }

            CompositionPath Path_08()
            {
                if (_path_08 != null) { return _path_08; }
                var result = _path_08 = new CompositionPath(Geometry_062());
                return result;
            }

            CompositionPath Path_09()
            {
                if (_path_09 != null) { return _path_09; }
                var result = _path_09 = new CompositionPath(Geometry_063());
                return result;
            }

            CompositionPath Path_10()
            {
                if (_path_10 != null) { return _path_10; }
                var result = _path_10 = new CompositionPath(Geometry_064());
                return result;
            }

            CompositionPath Path_11()
            {
                if (_path_11 != null) { return _path_11; }
                var result = _path_11 = new CompositionPath(Geometry_065());
                return result;
            }

            CompositionPath Path_12()
            {
                if (_path_12 != null) { return _path_12; }
                var result = _path_12 = new CompositionPath(Geometry_066());
                return result;
            }

            CompositionPath Path_13()
            {
                if (_path_13 != null) { return _path_13; }
                var result = _path_13 = new CompositionPath(Geometry_067());
                return result;
            }

            CompositionPath Path_14()
            {
                if (_path_14 != null) { return _path_14; }
                var result = _path_14 = new CompositionPath(Geometry_068());
                return result;
            }

            CompositionPath Path_15()
            {
                if (_path_15 != null) { return _path_15; }
                var result = _path_15 = new CompositionPath(Geometry_069());
                return result;
            }

            CompositionPath Path_16()
            {
                if (_path_16 != null) { return _path_16; }
                var result = _path_16 = new CompositionPath(Geometry_072());
                return result;
            }

            CompositionPath Path_17()
            {
                if (_path_17 != null) { return _path_17; }
                var result = _path_17 = new CompositionPath(Geometry_085());
                return result;
            }

            CompositionPath Path_18()
            {
                if (_path_18 != null) { return _path_18; }
                var result = _path_18 = new CompositionPath(Geometry_086());
                return result;
            }

            CompositionPath Path_19()
            {
                if (_path_19 != null) { return _path_19; }
                var result = _path_19 = new CompositionPath(Geometry_087());
                return result;
            }

            CompositionPath Path_20()
            {
                if (_path_20 != null) { return _path_20; }
                var result = _path_20 = new CompositionPath(Geometry_088());
                return result;
            }

            CompositionPath Path_21()
            {
                if (_path_21 != null) { return _path_21; }
                var result = _path_21 = new CompositionPath(Geometry_091());
                return result;
            }

            CompositionPath Path_22()
            {
                if (_path_22 != null) { return _path_22; }
                var result = _path_22 = new CompositionPath(Geometry_094());
                return result;
            }

            CompositionPath Path_23()
            {
                if (_path_23 != null) { return _path_23; }
                var result = _path_23 = new CompositionPath(Geometry_097());
                return result;
            }

            CompositionPath Path_24()
            {
                if (_path_24 != null) { return _path_24; }
                var result = _path_24 = new CompositionPath(Geometry_098());
                return result;
            }

            CompositionPath Path_25()
            {
                if (_path_25 != null) { return _path_25; }
                var result = _path_25 = new CompositionPath(Geometry_099());
                return result;
            }

            CompositionPath Path_26()
            {
                if (_path_26 != null) { return _path_26; }
                var result = _path_26 = new CompositionPath(Geometry_100());
                return result;
            }

            CompositionPath Path_27()
            {
                if (_path_27 != null) { return _path_27; }
                var result = _path_27 = new CompositionPath(Geometry_103());
                return result;
            }

            CompositionPath Path_28()
            {
                if (_path_28 != null) { return _path_28; }
                var result = _path_28 = new CompositionPath(Geometry_106());
                return result;
            }

            CompositionPath Path_29()
            {
                if (_path_29 != null) { return _path_29; }
                var result = _path_29 = new CompositionPath(Geometry_109());
                return result;
            }

            CompositionPath Path_30()
            {
                if (_path_30 != null) { return _path_30; }
                var result = _path_30 = new CompositionPath(Geometry_110());
                return result;
            }

            CompositionPath Path_31()
            {
                if (_path_31 != null) { return _path_31; }
                var result = _path_31 = new CompositionPath(Geometry_111());
                return result;
            }

            CompositionPath Path_32()
            {
                if (_path_32 != null) { return _path_32; }
                var result = _path_32 = new CompositionPath(Geometry_112());
                return result;
            }

            CompositionPath Path_33()
            {
                if (_path_33 != null) { return _path_33; }
                var result = _path_33 = new CompositionPath(Geometry_113());
                return result;
            }

            CompositionPath Path_34()
            {
                if (_path_34 != null) { return _path_34; }
                var result = _path_34 = new CompositionPath(Geometry_114());
                return result;
            }

            CompositionPath Path_35()
            {
                if (_path_35 != null) { return _path_35; }
                var result = _path_35 = new CompositionPath(Geometry_115());
                return result;
            }

            CompositionPath Path_36()
            {
                if (_path_36 != null) { return _path_36; }
                var result = _path_36 = new CompositionPath(Geometry_116());
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_00()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_000()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_01()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_001()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_02()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_002()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_03()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_003()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_04()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_004()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_05()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_005()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_06()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_006()));
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 4
            // Transforms: Shape Layer 4 RotationDegrees:2.0490000247955322,
            // Offset:<-37.087006, -39.337006>
            CompositionPathGeometry PathGeometry_07()
            {
                if (_pathGeometry_07 != null) { return _pathGeometry_07; }
                var result = _pathGeometry_07 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 4
            // Transforms: Shape Layer 4 RotationDegrees:2.0490000247955322,
            // Offset:<-37.087006, -39.337006>
            CompositionPathGeometry PathGeometry_08()
            {
                if (_pathGeometry_08 != null) { return _pathGeometry_08; }
                var result = _pathGeometry_08 = _c.CreatePathGeometry();
                return result;
            }

            CompositionPathGeometry PathGeometry_09()
            {
                return (_pathGeometry_09 == null)
                    ? _pathGeometry_09 = _c.CreatePathGeometry(new CompositionPath(Geometry_010()))
                    : _pathGeometry_09;
            }

            CompositionPathGeometry PathGeometry_10()
            {
                return (_pathGeometry_10 == null)
                    ? _pathGeometry_10 = _c.CreatePathGeometry(new CompositionPath(Geometry_011()))
                    : _pathGeometry_10;
            }

            CompositionPathGeometry PathGeometry_11()
            {
                return (_pathGeometry_11 == null)
                    ? _pathGeometry_11 = _c.CreatePathGeometry(new CompositionPath(Geometry_012()))
                    : _pathGeometry_11;
            }

            CompositionPathGeometry PathGeometry_12()
            {
                return (_pathGeometry_12 == null)
                    ? _pathGeometry_12 = _c.CreatePathGeometry(new CompositionPath(Geometry_013()))
                    : _pathGeometry_12;
            }

            CompositionPathGeometry PathGeometry_13()
            {
                return (_pathGeometry_13 == null)
                    ? _pathGeometry_13 = _c.CreatePathGeometry(new CompositionPath(Geometry_014()))
                    : _pathGeometry_13;
            }

            CompositionPathGeometry PathGeometry_14()
            {
                return (_pathGeometry_14 == null)
                    ? _pathGeometry_14 = _c.CreatePathGeometry(new CompositionPath(Geometry_015()))
                    : _pathGeometry_14;
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 8
            // Transforms: Shape Layer 8 RotationDegrees:2.0490000247955322,
            // Offset:<-37.087006, -39.337006>
            CompositionPathGeometry PathGeometry_15()
            {
                if (_pathGeometry_15 != null) { return _pathGeometry_15; }
                var result = _pathGeometry_15 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 8
            // Transforms: Shape Layer 8 RotationDegrees:2.0490000247955322,
            // Offset:<-37.087006, -39.337006>
            CompositionPathGeometry PathGeometry_16()
            {
                if (_pathGeometry_16 != null) { return _pathGeometry_16; }
                var result = _pathGeometry_16 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // ShapeGroup: Group 2
            CompositionPathGeometry PathGeometry_17()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_016()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 2
            CompositionPathGeometry PathGeometry_18()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_017()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_19()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_018()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_20()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_019()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_21()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_022()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_22()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_023()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_23()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_026()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_24()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_027()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_25()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_028()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_26()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_029()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_27()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_032()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_28()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_033()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_29()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_034()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_30()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_037()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_31()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_038()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_32()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_039()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_33()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_042()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_34()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_043()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_35()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_044()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_36()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_047()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_37()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_048()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_38()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_049()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_39()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_052()));
            }

            // - - - Layer aggregator
            // - Transforms: r hand
            // ShapeGroup: Group 5
            CompositionPathGeometry PathGeometry_40()
            {
                if (_pathGeometry_40 != null) { return _pathGeometry_40; }
                var result = _pathGeometry_40 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: r hand
            // ShapeGroup: Group 5
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_41()
            {
                if (_pathGeometry_41 != null) { return _pathGeometry_41; }
                var result = _pathGeometry_41 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: r hand
            // ShapeGroup: Group 5
            CompositionPathGeometry PathGeometry_42()
            {
                if (_pathGeometry_42 != null) { return _pathGeometry_42; }
                var result = _pathGeometry_42 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: r hand
            // ShapeGroup: Group 5
            CompositionPathGeometry PathGeometry_43()
            {
                if (_pathGeometry_43 != null) { return _pathGeometry_43; }
                var result = _pathGeometry_43 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: r hand
            // ShapeGroup: Group 5
            CompositionPathGeometry PathGeometry_44()
            {
                if (_pathGeometry_44 != null) { return _pathGeometry_44; }
                var result = _pathGeometry_44 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: r hand
            // ShapeGroup: Group 5
            CompositionPathGeometry PathGeometry_45()
            {
                if (_pathGeometry_45 != null) { return _pathGeometry_45; }
                var result = _pathGeometry_45 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: r hand
            // ShapeGroup: Group 5
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_46()
            {
                if (_pathGeometry_46 != null) { return _pathGeometry_46; }
                var result = _pathGeometry_46 = _c.CreatePathGeometry();
                return result;
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_47()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_075()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 3+Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_48()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_076()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_49()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_080()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 3+Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_50()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_081()));
            }

            // - - - Layer aggregator
            // - Transforms: l hand
            // ShapeGroup: Group 5
            CompositionPathGeometry PathGeometry_51()
            {
                if (_pathGeometry_51 != null) { return _pathGeometry_51; }
                var result = _pathGeometry_51 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: l hand
            // ShapeGroup: Group 5
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_52()
            {
                if (_pathGeometry_52 != null) { return _pathGeometry_52; }
                var result = _pathGeometry_52 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: l hand
            // ShapeGroup: Group 5
            CompositionPathGeometry PathGeometry_53()
            {
                if (_pathGeometry_53 != null) { return _pathGeometry_53; }
                var result = _pathGeometry_53 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: l hand
            // ShapeGroup: Group 5
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_54()
            {
                if (_pathGeometry_54 != null) { return _pathGeometry_54; }
                var result = _pathGeometry_54 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: l hand
            // ShapeGroup: Group 5
            CompositionPathGeometry PathGeometry_55()
            {
                if (_pathGeometry_55 != null) { return _pathGeometry_55; }
                var result = _pathGeometry_55 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: l hand
            // ShapeGroup: Group 5
            CompositionPathGeometry PathGeometry_56()
            {
                if (_pathGeometry_56 != null) { return _pathGeometry_56; }
                var result = _pathGeometry_56 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: l hand
            // ShapeGroup: Group 5
            CompositionPathGeometry PathGeometry_57()
            {
                if (_pathGeometry_57 != null) { return _pathGeometry_57; }
                var result = _pathGeometry_57 = _c.CreatePathGeometry();
                return result;
            }

            // - - - Layer aggregator
            // - Transforms: head
            // ShapeGroup: Group 6
            CompositionPathGeometry PathGeometry_58()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_117()));
            }

            // - - - Layer aggregator
            // - Transforms: head
            // ShapeGroup: Group 6
            CompositionPathGeometry PathGeometry_59()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_118()));
            }

            // - - - Layer aggregator
            // - Transforms: head
            // ShapeGroup: Group 6
            CompositionPathGeometry PathGeometry_60()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_119()));
            }

            // - - - Layer aggregator
            // - Transforms: head
            // ShapeGroup: Group 6
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_61()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_120()));
            }

            // - - - Layer aggregator
            // - Transforms: head
            // ShapeGroup: Group 6
            CompositionPathGeometry PathGeometry_62()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_123()));
            }

            // - - - Layer aggregator
            // - Transforms: head
            // ShapeGroup: Group 6
            CompositionPathGeometry PathGeometry_63()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_124()));
            }

            // - - - Layer aggregator
            // - Transforms: head
            // ShapeGroup: Group 6
            CompositionPathGeometry PathGeometry_64()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_125()));
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_00()
            {
                if (_spriteShape_00 != null) { return _spriteShape_00; }
                var result = _spriteShape_00 = _c.CreateSpriteShape(PathGeometry_00());
                result.CenterPoint = new Vector2(-342.816986F, -223.981003F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_01()
            {
                if (_spriteShape_01 != null) { return _spriteShape_01; }
                var result = _spriteShape_01 = _c.CreateSpriteShape(PathGeometry_01());
                result.CenterPoint = new Vector2(156.953995F, -369.572998F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_02()
            {
                if (_spriteShape_02 != null) { return _spriteShape_02; }
                var result = _spriteShape_02 = _c.CreateSpriteShape(PathGeometry_02());
                result.CenterPoint = new Vector2(-306.419006F, -288.377014F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_03()
            {
                if (_spriteShape_03 != null) { return _spriteShape_03; }
                var result = _spriteShape_03 = _c.CreateSpriteShape(PathGeometry_03());
                result.CenterPoint = new Vector2(354.342987F, 368.18399F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_04()
            {
                if (_spriteShape_04 != null) { return _spriteShape_04; }
                var result = _spriteShape_04 = _c.CreateSpriteShape(PathGeometry_04());
                result.CenterPoint = new Vector2(317.945007F, 303.789001F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_05()
            {
                if (_spriteShape_05 != null) { return _spriteShape_05; }
                var result = _spriteShape_05 = _c.CreateSpriteShape(PathGeometry_05());
                result.CenterPoint = new Vector2(264.747986F, -165.184006F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_06()
            {
                if (_spriteShape_06 != null) { return _spriteShape_06; }
                var result = _spriteShape_06 = _c.CreateSpriteShape(PathGeometry_06());
                result.CenterPoint = new Vector2(-215.423996F, 361.184998F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_07()
            {
                // Offset:<-46.880486, -50.43914>, Rotation:2.0489905960858947 degrees
                var geometry = PathGeometry_07();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.999360621F, 0.035754174F, -0.035754174F, 0.999360621F, -46.8804855F, -50.4391403F), ThemeColor_Color_EAEAEA());;
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_08()
            {
                // Offset:<23.870659, -106.15762>, Rotation:2.049025208487812 degrees,
                // Scale:<0.78, 0.78>
                var geometry = PathGeometry_08();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.779501259F, 0.0278882552F, -0.0278882552F, 0.779501259F, 23.8706589F, -106.157623F), ThemeColor_Color_91A6FE());;
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_09()
            {
                var result = _c.CreateSpriteShape(PathGeometry_09());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_10()
            {
                var result = _c.CreateSpriteShape(PathGeometry_10());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_11()
            {
                var result = _c.CreateSpriteShape(PathGeometry_11());
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_12()
            {
                var result = _c.CreateSpriteShape(PathGeometry_12());
                result.FillBrush = ThemeColor_Color_FFFFFF();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_13()
            {
                var result = _c.CreateSpriteShape(PathGeometry_13());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_14()
            {
                var result = _c.CreateSpriteShape(PathGeometry_14());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_15()
            {
                // Offset:<-46.880486, -50.43914>, Rotation:2.0489905960858947 degrees
                var geometry = PathGeometry_15();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.999360621F, 0.035754174F, -0.035754174F, 0.999360621F, -46.8804855F, -50.4391403F), ThemeColor_Color_EAEAEA());;
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_16()
            {
                // Offset:<23.870659, -106.15762>, Rotation:2.049025208487812 degrees,
                // Scale:<0.78, 0.78>
                var geometry = PathGeometry_16();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.779501259F, 0.0278882552F, -0.0278882552F, 0.779501259F, 23.8706589F, -106.157623F), ThemeColor_Color_91A6FE());;
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_17()
            {
                var result = _c.CreateSpriteShape(PathGeometry_09());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_18()
            {
                var result = _c.CreateSpriteShape(PathGeometry_10());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_19()
            {
                var result = _c.CreateSpriteShape(PathGeometry_11());
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_20()
            {
                var result = _c.CreateSpriteShape(PathGeometry_12());
                result.FillBrush = ThemeColor_Color_FFFFFF();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_21()
            {
                var result = _c.CreateSpriteShape(PathGeometry_13());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_22()
            {
                var result = _c.CreateSpriteShape(PathGeometry_14());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_23()
            {
                var result = _c.CreateSpriteShape(PathGeometry_17());
                result.FillBrush = ThemeColor_Color_758BDF();
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_24()
            {
                var result = _c.CreateSpriteShape(PathGeometry_18());
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_25()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_19();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_849AF5());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_26()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_20();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_27()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_21();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_28()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_22();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_29()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_23();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_30()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_24();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_31()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_25();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_32()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_26();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_33()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_27();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_34()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_28();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_35()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_29();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_36()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_30();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_37()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_31();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_38()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_32();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_39()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_33();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_40()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_34();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_41()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_35();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_42()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_36();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_43()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_37();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_44()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_38();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_45()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_39();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // - - Layer aggregator
            // Transforms: r hand
            // Path 1
            CompositionSpriteShape SpriteShape_46()
            {
                var result = _c.CreateSpriteShape(PathGeometry_40());
                result.FillBrush = ThemeColor_Color_FFFFFF();
                return result;
            }

            // - - Layer aggregator
            // Transforms: r hand
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_47()
            {
                var result = _c.CreateSpriteShape(PathGeometry_41());
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // - - Layer aggregator
            // Transforms: r hand
            // Path 1
            CompositionSpriteShape SpriteShape_48()
            {
                var result = _c.CreateSpriteShape(PathGeometry_42());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - - Layer aggregator
            // Transforms: r hand
            // Path 1
            CompositionSpriteShape SpriteShape_49()
            {
                var result = _c.CreateSpriteShape(PathGeometry_43());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - - Layer aggregator
            // Transforms: r hand
            // Path 1
            CompositionSpriteShape SpriteShape_50()
            {
                var result = _c.CreateSpriteShape(PathGeometry_44());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - - Layer aggregator
            // Transforms: r hand
            // Path 1
            CompositionSpriteShape SpriteShape_51()
            {
                var result = _c.CreateSpriteShape(PathGeometry_45());
                result.FillBrush = ThemeColor_Color_FFFFFF();
                return result;
            }

            // - - Layer aggregator
            // Transforms: r hand
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_52()
            {
                var result = _c.CreateSpriteShape(PathGeometry_46());
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_53()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_47();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_758BDF());;
                return result;
            }

            // Layer aggregator
            // Path 3+Path 2+Path 1
            CompositionSpriteShape SpriteShape_54()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_48();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_55()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_49();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_758BDF());;
                return result;
            }

            // Layer aggregator
            // Path 3+Path 2+Path 1
            CompositionSpriteShape SpriteShape_56()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_50();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_2E03E4());;
                return result;
            }

            // - - Layer aggregator
            // Transforms: l hand
            // Path 1
            CompositionSpriteShape SpriteShape_57()
            {
                var result = _c.CreateSpriteShape(PathGeometry_51());
                result.FillBrush = ThemeColor_Color_FFFFFF();
                return result;
            }

            // - - Layer aggregator
            // Transforms: l hand
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_58()
            {
                var result = _c.CreateSpriteShape(PathGeometry_52());
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // - - Layer aggregator
            // Transforms: l hand
            // Path 1
            CompositionSpriteShape SpriteShape_59()
            {
                var result = _c.CreateSpriteShape(PathGeometry_53());
                result.FillBrush = ThemeColor_Color_FFFFFF();
                return result;
            }

            // - - Layer aggregator
            // Transforms: l hand
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_60()
            {
                var result = _c.CreateSpriteShape(PathGeometry_54());
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // - - Layer aggregator
            // Transforms: l hand
            // Path 1
            CompositionSpriteShape SpriteShape_61()
            {
                var result = _c.CreateSpriteShape(PathGeometry_55());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - - Layer aggregator
            // Transforms: l hand
            // Path 1
            CompositionSpriteShape SpriteShape_62()
            {
                var result = _c.CreateSpriteShape(PathGeometry_56());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - - Layer aggregator
            // Transforms: l hand
            // Path 1
            CompositionSpriteShape SpriteShape_63()
            {
                var result = _c.CreateSpriteShape(PathGeometry_57());
                result.FillBrush = ThemeColor_Color_849AF5();
                return result;
            }

            // - - Layer aggregator
            // Transforms: head
            // Path 1
            CompositionSpriteShape SpriteShape_64()
            {
                var result = _c.CreateSpriteShape(PathGeometry_58());
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // - - Layer aggregator
            // Transforms: head
            // Path 1
            CompositionSpriteShape SpriteShape_65()
            {
                var result = _c.CreateSpriteShape(PathGeometry_59());
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // - - Layer aggregator
            // Transforms: head
            // Path 1
            CompositionSpriteShape SpriteShape_66()
            {
                var result = _c.CreateSpriteShape(PathGeometry_60());
                result.FillBrush = ThemeColor_Color_FFFFFF();
                return result;
            }

            // - - Layer aggregator
            // Transforms: head
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_67()
            {
                var result = _c.CreateSpriteShape(PathGeometry_61());
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // - - Layer aggregator
            // Transforms: head
            // Path 1
            CompositionSpriteShape SpriteShape_68()
            {
                var result = _c.CreateSpriteShape(PathGeometry_62());
                result.FillBrush = ThemeColor_Color_2E03E4();
                return result;
            }

            // - - Layer aggregator
            // Transforms: head
            // Path 1
            CompositionSpriteShape SpriteShape_69()
            {
                var result = _c.CreateSpriteShape(PathGeometry_63());
                result.FillBrush = ThemeColor_Color_FFFFFF();
                return result;
            }

            // - - Layer aggregator
            // Transforms: head
            // Path 1
            CompositionSpriteShape SpriteShape_70()
            {
                var result = _c.CreateSpriteShape(PathGeometry_64());
                result.FillBrush = ThemeColor_Color_FFFFFF();
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                if (_root != null) { return _root; }
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                propertySet.InsertScalar("t0", 0F);
                propertySet.InsertScalar("t1", 0F);
                propertySet.InsertScalar("t2", 0F);
                propertySet.InsertScalar("t3", 0F);
                propertySet.InsertScalar("t4", 0F);
                propertySet.InsertScalar("t5", 0F);
                // Layer aggregator
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_00()
            {
                return (_cubicBezierEasingFunction_00 == null)
                    ? _cubicBezierEasingFunction_00 = _c.CreateCubicBezierEasingFunction(new Vector2(0.194999993F, 0F), new Vector2(0.377999991F, 0.913999975F))
                    : _cubicBezierEasingFunction_00;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_01()
            {
                return (_cubicBezierEasingFunction_01 == null)
                    ? _cubicBezierEasingFunction_01 = _c.CreateCubicBezierEasingFunction(new Vector2(0.587000012F, 0F), new Vector2(0.759000003F, 1F))
                    : _cubicBezierEasingFunction_01;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_02()
            {
                return (_cubicBezierEasingFunction_02 == null)
                    ? _cubicBezierEasingFunction_02 = _c.CreateCubicBezierEasingFunction(new Vector2(0.296000004F, 0F), new Vector2(0.666999996F, 1F))
                    : _cubicBezierEasingFunction_02;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_03()
            {
                return (_cubicBezierEasingFunction_03 == null)
                    ? _cubicBezierEasingFunction_03 = _c.CreateCubicBezierEasingFunction(new Vector2(0.305000007F, 0F), new Vector2(0.666999996F, 1F))
                    : _cubicBezierEasingFunction_03;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_04()
            {
                return (_cubicBezierEasingFunction_04 == null)
                    ? _cubicBezierEasingFunction_04 = _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.833000004F, 0.833000004F))
                    : _cubicBezierEasingFunction_04;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_05()
            {
                return (_cubicBezierEasingFunction_05 == null)
                    ? _cubicBezierEasingFunction_05 = _c.CreateCubicBezierEasingFunction(new Vector2(0.333000004F, 0F), new Vector2(0.666999996F, 1F))
                    : _cubicBezierEasingFunction_05;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_06()
            {
                return (_cubicBezierEasingFunction_06 == null)
                    ? _cubicBezierEasingFunction_06 = _c.CreateCubicBezierEasingFunction(new Vector2(0.333000004F, 0.333000004F), new Vector2(0.666999996F, 0.666999996F))
                    : _cubicBezierEasingFunction_06;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_07()
            {
                return (_cubicBezierEasingFunction_07 == null)
                    ? _cubicBezierEasingFunction_07 = _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.563000023F, 0.563000023F))
                    : _cubicBezierEasingFunction_07;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_08()
            {
                return (_cubicBezierEasingFunction_08 == null)
                    ? _cubicBezierEasingFunction_08 = _c.CreateCubicBezierEasingFunction(new Vector2(0.30399999F, 0.30399999F), new Vector2(0.654999971F, 0.654999971F))
                    : _cubicBezierEasingFunction_08;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_09()
            {
                return (_cubicBezierEasingFunction_09 == null)
                    ? _cubicBezierEasingFunction_09 = _c.CreateCubicBezierEasingFunction(new Vector2(0.351999998F, 0.351999998F), new Vector2(0.703999996F, 0.703999996F))
                    : _cubicBezierEasingFunction_09;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_10()
            {
                return (_cubicBezierEasingFunction_10 == null)
                    ? _cubicBezierEasingFunction_10 = _c.CreateCubicBezierEasingFunction(new Vector2(0.435000002F, 0.435000002F), new Vector2(0.833000004F, 0.833000004F))
                    : _cubicBezierEasingFunction_10;
            }

            ExpressionAnimation RootProgress()
            {
                if (_rootProgress != null) { return _rootProgress; }
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: Shape Layer 4
            // - Transforms: Shape Layer 4 RotationDegrees:2.0490000247955322,
            // Offset:<-37.087006, -39.337006>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_00()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_00(), StepThenHoldEasingFunction());
                // Frame 7.
                result.InsertKeyFrame(0.0388888903F, Path_00(), HoldThenStepEasingFunction());
                // Frame 17.
                result.InsertKeyFrame(0.0944444463F, Path_01(), CubicBezierEasingFunction_04());
                // Frame 27.
                result.InsertKeyFrame(0.150000006F, Path_00(), CubicBezierEasingFunction_04());
                // Frame 37.
                result.InsertKeyFrame(0.205555558F, Path_01(), CubicBezierEasingFunction_04());
                // Frame 47.
                result.InsertKeyFrame(0.26111111F, Path_00(), CubicBezierEasingFunction_04());
                // Frame 57.
                result.InsertKeyFrame(0.316666663F, Path_01(), CubicBezierEasingFunction_04());
                // Frame 67.
                result.InsertKeyFrame(0.372222215F, Path_00(), CubicBezierEasingFunction_04());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: Shape Layer 4
            // - Transforms: Shape Layer 4 RotationDegrees:2.0490000247955322,
            // Offset:<-37.087006, -39.337006>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_01()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_00(), StepThenHoldEasingFunction());
                // Frame 7.
                result.InsertKeyFrame(0.0388888903F, Path_00(), HoldThenStepEasingFunction());
                // Frame 17.
                result.InsertKeyFrame(0.0944444463F, Path_02(), CubicBezierEasingFunction_04());
                // Frame 27.
                result.InsertKeyFrame(0.150000006F, Path_00(), CubicBezierEasingFunction_04());
                // Frame 37.
                result.InsertKeyFrame(0.205555558F, Path_02(), CubicBezierEasingFunction_04());
                // Frame 47.
                result.InsertKeyFrame(0.26111111F, Path_00(), CubicBezierEasingFunction_04());
                // Frame 57.
                result.InsertKeyFrame(0.316666663F, Path_02(), CubicBezierEasingFunction_04());
                // Frame 67.
                result.InsertKeyFrame(0.372222215F, Path_00(), CubicBezierEasingFunction_04());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: Shape Layer 8
            // - Transforms: Shape Layer 8 RotationDegrees:2.0490000247955322,
            // Offset:<-37.087006, -39.337006>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_02()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_00(), StepThenHoldEasingFunction());
                // Frame 97.
                result.InsertKeyFrame(0.538888872F, Path_00(), HoldThenStepEasingFunction());
                // Frame 107.
                result.InsertKeyFrame(0.594444454F, Path_01(), CubicBezierEasingFunction_04());
                // Frame 117.
                result.InsertKeyFrame(0.649999976F, Path_00(), CubicBezierEasingFunction_04());
                // Frame 127.
                result.InsertKeyFrame(0.705555558F, Path_01(), CubicBezierEasingFunction_04());
                // Frame 137.
                result.InsertKeyFrame(0.76111114F, Path_00(), CubicBezierEasingFunction_04());
                // Frame 147.
                result.InsertKeyFrame(0.816666663F, Path_01(), CubicBezierEasingFunction_04());
                // Frame 157.
                result.InsertKeyFrame(0.872222245F, Path_00(), CubicBezierEasingFunction_04());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: Shape Layer 8
            // - Transforms: Shape Layer 8 RotationDegrees:2.0490000247955322,
            // Offset:<-37.087006, -39.337006>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_03()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_00(), StepThenHoldEasingFunction());
                // Frame 97.
                result.InsertKeyFrame(0.538888872F, Path_00(), HoldThenStepEasingFunction());
                // Frame 107.
                result.InsertKeyFrame(0.594444454F, Path_02(), CubicBezierEasingFunction_04());
                // Frame 117.
                result.InsertKeyFrame(0.649999976F, Path_00(), CubicBezierEasingFunction_04());
                // Frame 127.
                result.InsertKeyFrame(0.705555558F, Path_02(), CubicBezierEasingFunction_04());
                // Frame 137.
                result.InsertKeyFrame(0.76111114F, Path_00(), CubicBezierEasingFunction_04());
                // Frame 147.
                result.InsertKeyFrame(0.816666663F, Path_02(), CubicBezierEasingFunction_04());
                // Frame 157.
                result.InsertKeyFrame(0.872222245F, Path_00(), CubicBezierEasingFunction_04());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: r hand
            // - ShapeGroup: Group 5
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_04()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_03(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_04(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_04(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_04(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_04(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_04(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_04(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_03(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: r hand
            // - ShapeGroup: Group 5
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_05()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_05(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_06(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_06(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_06(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_06(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_06(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_06(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_05(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: r hand
            // - ShapeGroup: Group 5
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_06()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_07(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_08(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_08(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_08(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_08(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_08(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_08(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_07(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: r hand
            // - ShapeGroup: Group 5
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_07()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_09(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_10(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_10(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_10(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_10(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_10(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_10(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_09(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: r hand
            // - ShapeGroup: Group 5
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_08()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_11(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_12(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_12(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_12(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_12(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_12(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_12(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_11(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: r hand
            // - ShapeGroup: Group 5
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_09()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_13(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_14(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_14(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_14(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_14(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_14(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_14(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_13(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: r hand
            // - ShapeGroup: Group 5
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_10()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_15(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_16(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_16(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_16(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_16(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_16(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_16(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_15(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: l hand
            // - ShapeGroup: Group 5
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_11()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_17(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_18(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_18(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_19(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_19(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_18(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_18(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_17(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: l hand
            // - ShapeGroup: Group 5
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_12()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_20(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_21(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_21(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_22(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_22(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_21(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_21(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_20(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: l hand
            // - ShapeGroup: Group 5
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_13()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_23(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_24(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_24(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_25(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_25(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_24(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_24(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_23(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: l hand
            // - ShapeGroup: Group 5
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_14()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_26(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_27(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_27(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_28(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_28(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_27(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_27(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_26(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: l hand
            // - ShapeGroup: Group 5
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_15()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_29(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_30(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_30(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_31(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_31(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_30(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_30(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_29(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: l hand
            // - ShapeGroup: Group 5
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_16()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_32(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_33(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_33(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_33(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_33(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_33(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_33(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_32(), CubicBezierEasingFunction_05());
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: l hand
            // - ShapeGroup: Group 5
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_17()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_34(), HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_35(), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_35(), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, Path_36(), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_36(), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_35(), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_35(), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, Path_34(), CubicBezierEasingFunction_05());
                return result;
            }

            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_0_to_0_0()
            {
                // Frame 0.
                if (_rotationAngleInDegreesScalarAnimation_0_to_0_0 != null) { return _rotationAngleInDegreesScalarAnimation_0_to_0_0; }
                var result = _rotationAngleInDegreesScalarAnimation_0_to_0_0 = CreateScalarKeyFrameAnimation(0F, 0F, HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, -3F, CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, -3F, CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, 3F, CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, 3F, CubicBezierEasingFunction_02());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, -3F, CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, -3F, CubicBezierEasingFunction_02());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, 0F, CubicBezierEasingFunction_05());
                return result;
            }

            // - - Layer aggregator
            // Transforms: r hand
            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_0_to_0_1()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, 0F, CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, 0F, CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, 0F, CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, 0F, CubicBezierEasingFunction_02());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, 0F, CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, 0F, CubicBezierEasingFunction_02());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, 0F, CubicBezierEasingFunction_05());
                return result;
            }

            // - - Layer aggregator
            // Transforms: l hand
            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_0_to_0_2()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, 0F, CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, 0F, CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, -19F, CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, -19F, CubicBezierEasingFunction_02());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, 0F, CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, 0F, CubicBezierEasingFunction_02());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, 0F, CubicBezierEasingFunction_05());
                return result;
            }

            // - - Layer aggregator
            // Transforms: head
            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_0_to_0_3()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, HoldThenStepEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, -5F, CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, -5F, CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, 5F, CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, 5F, CubicBezierEasingFunction_02());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, -5F, CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, -5F, CubicBezierEasingFunction_02());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, 0F, CubicBezierEasingFunction_05());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_0()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_0 != null) { return _scalarAnimation_0_to_0_0; }
                var result = _scalarAnimation_0_to_0_0 = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 13.
                result.InsertKeyFrame(0.0722222254F, 0F, HoldThenStepEasingFunction());
                // Frame 23.
                result.InsertKeyFrame(0.127777785F, 1F, CubicBezierEasingFunction_00());
                // Frame 33.
                result.InsertKeyFrame(0.183333337F, 0F, CubicBezierEasingFunction_01());
                // Frame 58.
                result.InsertKeyFrame(0.322222233F, 0F, CubicBezierEasingFunction_02());
                // Frame 68.
                result.InsertKeyFrame(0.377777785F, 1F, CubicBezierEasingFunction_00());
                // Frame 78.
                result.InsertKeyFrame(0.433333337F, 0F, CubicBezierEasingFunction_01());
                // Frame 103.
                result.InsertKeyFrame(0.572222233F, 0F, CubicBezierEasingFunction_03());
                // Frame 113.
                result.InsertKeyFrame(0.627777755F, 1F, CubicBezierEasingFunction_00());
                // Frame 123.
                result.InsertKeyFrame(0.683333337F, 0F, CubicBezierEasingFunction_01());
                // Frame 148.
                result.InsertKeyFrame(0.822222233F, 0F, CubicBezierEasingFunction_02());
                // Frame 158.
                result.InsertKeyFrame(0.877777755F, 1F, CubicBezierEasingFunction_00());
                // Frame 168.
                result.InsertKeyFrame(0.933333337F, 0F, CubicBezierEasingFunction_01());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_1()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_1 != null) { return _scalarAnimation_0_to_0_1; }
                var result = _scalarAnimation_0_to_0_1 = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 28.
                result.InsertKeyFrame(0.155555561F, 0F, HoldThenStepEasingFunction());
                // Frame 38.
                result.InsertKeyFrame(0.211111113F, 1F, CubicBezierEasingFunction_00());
                // Frame 48.
                result.InsertKeyFrame(0.266666681F, 0F, CubicBezierEasingFunction_01());
                // Frame 73.
                result.InsertKeyFrame(0.405555546F, 0F, CubicBezierEasingFunction_02());
                // Frame 83.
                result.InsertKeyFrame(0.461111099F, 1F, CubicBezierEasingFunction_00());
                // Frame 93.
                result.InsertKeyFrame(0.516666651F, 0F, CubicBezierEasingFunction_01());
                // Frame 118.
                result.InsertKeyFrame(0.655555546F, 0F, CubicBezierEasingFunction_03());
                // Frame 128.
                result.InsertKeyFrame(0.711111128F, 1F, CubicBezierEasingFunction_00());
                // Frame 138.
                result.InsertKeyFrame(0.766666651F, 0F, CubicBezierEasingFunction_01());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_2()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_2 != null) { return _scalarAnimation_0_to_0_2; }
                var result = _scalarAnimation_0_to_0_2 = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 5.
                result.InsertKeyFrame(0.027777778F, 0F, HoldThenStepEasingFunction());
                // Frame 15.
                result.InsertKeyFrame(0.0833333358F, 1F, CubicBezierEasingFunction_00());
                // Frame 25.
                result.InsertKeyFrame(0.138888896F, 0F, CubicBezierEasingFunction_01());
                // Frame 50.
                result.InsertKeyFrame(0.277777791F, 0F, CubicBezierEasingFunction_02());
                // Frame 60.
                result.InsertKeyFrame(0.333333343F, 1F, CubicBezierEasingFunction_00());
                // Frame 70.
                result.InsertKeyFrame(0.388888896F, 0F, CubicBezierEasingFunction_01());
                // Frame 95.
                result.InsertKeyFrame(0.527777791F, 0F, CubicBezierEasingFunction_03());
                // Frame 105.
                result.InsertKeyFrame(0.583333313F, 1F, CubicBezierEasingFunction_00());
                // Frame 115.
                result.InsertKeyFrame(0.638888896F, 0F, CubicBezierEasingFunction_01());
                // Frame 140.
                result.InsertKeyFrame(0.777777791F, 0F, CubicBezierEasingFunction_02());
                // Frame 150.
                result.InsertKeyFrame(0.833333313F, 1F, CubicBezierEasingFunction_00());
                // Frame 160.
                result.InsertKeyFrame(0.888888896F, 0F, CubicBezierEasingFunction_01());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_3()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_3 != null) { return _scalarAnimation_0_to_0_3; }
                var result = _scalarAnimation_0_to_0_3 = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 15.
                result.InsertKeyFrame(0.0833333358F, 0F, HoldThenStepEasingFunction());
                // Frame 25.
                result.InsertKeyFrame(0.138888896F, 1F, CubicBezierEasingFunction_00());
                // Frame 35.
                result.InsertKeyFrame(0.194444448F, 0F, CubicBezierEasingFunction_01());
                // Frame 60.
                result.InsertKeyFrame(0.333333343F, 0F, CubicBezierEasingFunction_02());
                // Frame 70.
                result.InsertKeyFrame(0.388888896F, 1F, CubicBezierEasingFunction_00());
                // Frame 80.
                result.InsertKeyFrame(0.444444448F, 0F, CubicBezierEasingFunction_01());
                // Frame 105.
                result.InsertKeyFrame(0.583333313F, 0F, CubicBezierEasingFunction_03());
                // Frame 115.
                result.InsertKeyFrame(0.638888896F, 1F, CubicBezierEasingFunction_00());
                // Frame 125.
                result.InsertKeyFrame(0.694444418F, 0F, CubicBezierEasingFunction_01());
                // Frame 150.
                result.InsertKeyFrame(0.833333313F, 0F, CubicBezierEasingFunction_02());
                // Frame 160.
                result.InsertKeyFrame(0.888888896F, 1F, CubicBezierEasingFunction_00());
                // Frame 170.
                result.InsertKeyFrame(0.944444418F, 0F, CubicBezierEasingFunction_01());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_4()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_4 != null) { return _scalarAnimation_0_to_0_4; }
                var result = _scalarAnimation_0_to_0_4 = CreateScalarKeyFrameAnimation(0F, 0F, HoldThenStepEasingFunction());
                // Frame 10.
                result.InsertKeyFrame(0.055555556F, 1F, CubicBezierEasingFunction_00());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, 0F, CubicBezierEasingFunction_01());
                // Frame 45.
                result.InsertKeyFrame(0.25F, 0F, CubicBezierEasingFunction_02());
                // Frame 55.
                result.InsertKeyFrame(0.305555552F, 1F, CubicBezierEasingFunction_00());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, 0F, CubicBezierEasingFunction_01());
                // Frame 90.
                result.InsertKeyFrame(0.5F, 0F, CubicBezierEasingFunction_03());
                // Frame 100.
                result.InsertKeyFrame(0.555555582F, 1F, CubicBezierEasingFunction_00());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, 0F, CubicBezierEasingFunction_01());
                // Frame 135.
                result.InsertKeyFrame(0.75F, 0F, CubicBezierEasingFunction_02());
                // Frame 145.
                result.InsertKeyFrame(0.805555582F, 1F, CubicBezierEasingFunction_00());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, 0F, CubicBezierEasingFunction_01());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_5()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_5 != null) { return _scalarAnimation_0_to_0_5; }
                var result = _scalarAnimation_0_to_0_5 = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 24.
                result.InsertKeyFrame(0.13333334F, 0F, HoldThenStepEasingFunction());
                // Frame 34.
                result.InsertKeyFrame(0.188888893F, 1F, CubicBezierEasingFunction_00());
                // Frame 44.
                result.InsertKeyFrame(0.244444445F, 0F, CubicBezierEasingFunction_01());
                // Frame 69.
                result.InsertKeyFrame(0.383333325F, 0F, CubicBezierEasingFunction_02());
                // Frame 79.
                result.InsertKeyFrame(0.438888878F, 1F, CubicBezierEasingFunction_00());
                // Frame 89.
                result.InsertKeyFrame(0.49444443F, 0F, CubicBezierEasingFunction_01());
                // Frame 114.
                result.InsertKeyFrame(0.633333325F, 0F, CubicBezierEasingFunction_03());
                // Frame 124.
                result.InsertKeyFrame(0.688888907F, 1F, CubicBezierEasingFunction_00());
                // Frame 134.
                result.InsertKeyFrame(0.74444443F, 0F, CubicBezierEasingFunction_01());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_6()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_6 != null) { return _scalarAnimation_0_to_0_6; }
                var result = _scalarAnimation_0_to_0_6 = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 9.
                result.InsertKeyFrame(0.0500000007F, 0F, HoldThenStepEasingFunction());
                // Frame 19.
                result.InsertKeyFrame(0.105555557F, 1F, CubicBezierEasingFunction_00());
                // Frame 29.
                result.InsertKeyFrame(0.161111116F, 0F, CubicBezierEasingFunction_01());
                // Frame 54.
                result.InsertKeyFrame(0.300000012F, 0F, CubicBezierEasingFunction_02());
                // Frame 64.
                result.InsertKeyFrame(0.355555564F, 1F, CubicBezierEasingFunction_00());
                // Frame 74.
                result.InsertKeyFrame(0.411111116F, 0F, CubicBezierEasingFunction_01());
                // Frame 99.
                result.InsertKeyFrame(0.550000012F, 0F, CubicBezierEasingFunction_03());
                // Frame 109.
                result.InsertKeyFrame(0.605555534F, 1F, CubicBezierEasingFunction_00());
                // Frame 119.
                result.InsertKeyFrame(0.661111116F, 0F, CubicBezierEasingFunction_01());
                // Frame 144.
                result.InsertKeyFrame(0.800000012F, 0F, CubicBezierEasingFunction_02());
                // Frame 154.
                result.InsertKeyFrame(0.855555534F, 1F, CubicBezierEasingFunction_00());
                // Frame 164.
                result.InsertKeyFrame(0.911111116F, 0F, CubicBezierEasingFunction_01());
                return result;
            }

            ScalarKeyFrameAnimation t0ScalarAnimation_0_to_1()
            {
                // Frame 7.
                var result = CreateScalarKeyFrameAnimation(0.038888894F, 0F, StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 18.77.
                result.InsertKeyFrame(0.104294434F, 1F, CubicBezierEasingFunction_07());
                // Frame 18.77.
                result.InsertKeyFrame(0.104294442F, 0F, StepThenHoldEasingFunction());
                // Frame 35.12.
                result.InsertKeyFrame(0.195094436F, 1F, CubicBezierEasingFunction_08());
                return result;
            }

            ScalarKeyFrameAnimation t1ScalarAnimation_0_to_1()
            {
                // Frame 35.12.
                var result = CreateScalarKeyFrameAnimation(0.195094451F, 0F, StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 50.3.
                result.InsertKeyFrame(0.279461086F, 1F, CubicBezierEasingFunction_09());
                // Frame 50.3.
                result.InsertKeyFrame(0.279461116F, 0F, StepThenHoldEasingFunction());
                // Frame 60.
                result.InsertKeyFrame(0.333333313F, 1F, CubicBezierEasingFunction_10());
                return result;
            }

            ScalarKeyFrameAnimation t2ScalarAnimation_0_to_1()
            {
                // Frame 97.
                var result = CreateScalarKeyFrameAnimation(0.538888931F, 0F, StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 108.77.
                result.InsertKeyFrame(0.60429436F, 1F, CubicBezierEasingFunction_07());
                // Frame 108.77.
                result.InsertKeyFrame(0.604294419F, 0F, StepThenHoldEasingFunction());
                // Frame 125.12.
                result.InsertKeyFrame(0.695094407F, 1F, CubicBezierEasingFunction_08());
                return result;
            }

            ScalarKeyFrameAnimation t3ScalarAnimation_0_to_1()
            {
                // Frame 125.12.
                var result = CreateScalarKeyFrameAnimation(0.695094466F, 0F, StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 140.3.
                result.InsertKeyFrame(0.779461026F, 1F, CubicBezierEasingFunction_09());
                // Frame 140.3.
                result.InsertKeyFrame(0.779461086F, 0F, StepThenHoldEasingFunction());
                // Frame 150.
                result.InsertKeyFrame(0.833333254F, 1F, CubicBezierEasingFunction_10());
                return result;
            }

            ScalarKeyFrameAnimation t4ScalarAnimation_0_to_1()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 10.
                result.InsertKeyFrame(0.0555555522F, 1F, CubicBezierEasingFunction_05());
                // Frame 10.
                result.InsertKeyFrame(0.055555556F, 0F, StepThenHoldEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111104F, 1F, CubicBezierEasingFunction_05());
                return result;
            }

            ScalarKeyFrameAnimation t5ScalarAnimation_0_to_1()
            {
                // Frame 135.
                var result = CreateScalarKeyFrameAnimation(0.75000006F, 0F, StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 145.
                result.InsertKeyFrame(0.805555522F, 1F, CubicBezierEasingFunction_05());
                // Frame 145.
                result.InsertKeyFrame(0.805555582F, 0F, StepThenHoldEasingFunction());
                // Frame 155.
                result.InsertKeyFrame(0.861111045F, 1F, CubicBezierEasingFunction_05());
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(1080F, 1080F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 1
                shapes.Add(SpriteShape_00());
                // ShapeGroup: Group 1
                shapes.Add(SpriteShape_01());
                // ShapeGroup: Group 1
                shapes.Add(SpriteShape_02());
                // ShapeGroup: Group 1
                shapes.Add(SpriteShape_03());
                // ShapeGroup: Group 1
                shapes.Add(SpriteShape_04());
                // ShapeGroup: Group 1
                shapes.Add(SpriteShape_05());
                // ShapeGroup: Group 1
                shapes.Add(SpriteShape_06());
                // Layer: Shape Layer 4
                shapes.Add(ContainerShape_0());
                // Layer: Shape Layer 8
                shapes.Add(ContainerShape_1());
                shapes.Add(ContainerShape_2());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_25());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_26());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_27());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_28());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_29());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_30());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_31());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_32());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_33());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_34());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_35());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_36());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_37());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_38());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_39());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_40());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_41());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_42());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_43());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_44());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_45());
                shapes.Add(ContainerShape_3());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_53());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_54());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_55());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_56());
                shapes.Add(ContainerShape_5());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                if (_holdThenStepEasingFunction != null) { return _holdThenStepEasingFunction; }
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            StepEasingFunction StepThenHoldEasingFunction()
            {
                if (_stepThenHoldEasingFunction != null) { return _stepThenHoldEasingFunction; }
                var result = _stepThenHoldEasingFunction = _c.CreateStepEasingFunction();
                result.IsInitialStepSingleFrame = true;
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 4
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-147.598007F, 877.171997F), StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 7.
                result.InsertKeyFrame(0.0388888903F, new Vector2(-147.598007F, 877.171997F), HoldThenStepEasingFunction());
                // Frame 18.77.
                result.InsertExpressionKeyFrame(0.104294434F, "Pow(1-_.t0,3)*Vector2(-147.598,877.172)+(3*Square(1-_.t0)*_.t0*Vector2(-147.598,877.172))+(3*(1-_.t0)*Square(_.t0)*Vector2(-106.398,678.172))+(Pow(_.t0,3)*Vector2(-41.598,597.172))", StepThenHoldEasingFunction());
                // Frame 35.12.
                result.InsertExpressionKeyFrame(0.195094436F, "Pow(1-_.t0,3)*Vector2(-41.598,597.172)+(3*Square(1-_.t0)*_.t0*Vector2(-25.598,577.172))+(3*(1-_.t0)*Square(_.t0)*Vector2(87.76701,448.319))+(Pow(_.t0,3)*Vector2(340.402,467.172))", StepThenHoldEasingFunction());
                // Frame 50.3.
                result.InsertExpressionKeyFrame(0.279461086F, "Pow(1-_.t1,3)*Vector2(340.402,467.172)+(3*Square(1-_.t1)*_.t1*Vector2(474.402,477.172))+(3*(1-_.t1)*Square(_.t1)*Vector2(677.175,446.786))+(Pow(_.t1,3)*Vector2(724.402,423.172))", StepThenHoldEasingFunction());
                // Frame 60.
                result.InsertExpressionKeyFrame(0.333333313F, "Pow(1-_.t1,3)*Vector2(724.402,423.172)+(3*Square(1-_.t1)*_.t1*Vector2(816.402,377.172))+(3*(1-_.t1)*Square(_.t1)*Vector2(912.402,263.172))+(Pow(_.t1,3)*Vector2(912.402,263.172))", StepThenHoldEasingFunction());
                // Frame 60.
                result.InsertKeyFrame(0.333333343F, new Vector2(912.401978F, 263.171997F), StepThenHoldEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-147.598007F, 877.171997F), StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 97.
                result.InsertKeyFrame(0.538888872F, new Vector2(-147.598007F, 877.171997F), HoldThenStepEasingFunction());
                // Frame 108.77.
                result.InsertExpressionKeyFrame(0.60429436F, "Pow(1-_.t2,3)*Vector2(-147.598,877.172)+(3*Square(1-_.t2)*_.t2*Vector2(-147.598,877.172))+(3*(1-_.t2)*Square(_.t2)*Vector2(-106.398,678.172))+(Pow(_.t2,3)*Vector2(-41.598,597.172))", StepThenHoldEasingFunction());
                // Frame 125.12.
                result.InsertExpressionKeyFrame(0.695094407F, "Pow(1-_.t2,3)*Vector2(-41.598,597.172)+(3*Square(1-_.t2)*_.t2*Vector2(-25.598,577.172))+(3*(1-_.t2)*Square(_.t2)*Vector2(87.76701,448.319))+(Pow(_.t2,3)*Vector2(340.402,467.172))", StepThenHoldEasingFunction());
                // Frame 140.3.
                result.InsertExpressionKeyFrame(0.779461026F, "Pow(1-_.t3,3)*Vector2(340.402,467.172)+(3*Square(1-_.t3)*_.t3*Vector2(474.402,477.172))+(3*(1-_.t3)*Square(_.t3)*Vector2(677.175,446.786))+(Pow(_.t3,3)*Vector2(724.402,423.172))", StepThenHoldEasingFunction());
                // Frame 150.
                result.InsertExpressionKeyFrame(0.833333254F, "Pow(1-_.t3,3)*Vector2(724.402,423.172)+(3*Square(1-_.t3)*_.t3*Vector2(816.402,377.172))+(3*(1-_.t3)*Square(_.t3)*Vector2(912.402,263.172))+(Pow(_.t3,3)*Vector2(912.402,263.172))", StepThenHoldEasingFunction());
                // Frame 150.
                result.InsertKeyFrame(0.833333313F, new Vector2(912.401978F, 263.171997F), StepThenHoldEasingFunction());
                return result;
            }

            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_2()
            {
                // Frame 0.
                if (_offsetVector2Animation_2 != null) { return _offsetVector2Animation_2; }
                var result = _offsetVector2Animation_2 = CreateVector2KeyFrameAnimation(0F, new Vector2(540F, 540F), HoldThenStepEasingFunction());
                // Frame 10.
                result.InsertKeyFrame(0.055555556F, new Vector2(540F, 543.875F), CubicBezierEasingFunction_05());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, new Vector2(540F, 540F), CubicBezierEasingFunction_05());
                // Frame 45.
                result.InsertKeyFrame(0.25F, new Vector2(540F, 540F), CubicBezierEasingFunction_06());
                // Frame 55.
                result.InsertKeyFrame(0.305555552F, new Vector2(540.5F, 542.5F), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, new Vector2(540F, 540F), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, new Vector2(540F, 540F), CubicBezierEasingFunction_06());
                // Frame 100.
                result.InsertKeyFrame(0.555555582F, new Vector2(540.5F, 542.5F), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, new Vector2(540F, 540F), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, new Vector2(540F, 540F), CubicBezierEasingFunction_06());
                // Frame 145.
                result.InsertKeyFrame(0.805555582F, new Vector2(540F, 543.875F), CubicBezierEasingFunction_05());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, new Vector2(540F, 540F), CubicBezierEasingFunction_05());
                return result;
            }

            // - - Layer aggregator
            // Transforms: head
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_3()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 10.
                result.InsertExpressionKeyFrame(0.0555555522F, "3*Square(1-_.t4)*_.t4*Vector2(-0.005,0.208)+(3*(1-_.t4)*Square(_.t4)*Vector2(-0.033,1.249))+(Pow(_.t4,3)*Vector2(-0.033,1.249))", StepThenHoldEasingFunction());
                // Frame 20.
                result.InsertExpressionKeyFrame(0.111111104F, "Pow(1-_.t4,3)*Vector2(-0.033,1.249)+(3*Square(1-_.t4)*_.t4*Vector2(-0.033,1.249))+(3*(1-_.t4)*Square(_.t4)*Vector2(-0.005,0.208))", StepThenHoldEasingFunction());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, new Vector2(0F, 0F), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, new Vector2(0F, 0F), CubicBezierEasingFunction_06());
                // Frame 55.
                result.InsertKeyFrame(0.305555552F, new Vector2(-0.25F, 1.25F), CubicBezierEasingFunction_05());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, new Vector2(0F, 0F), CubicBezierEasingFunction_05());
                // Frame 90.
                result.InsertKeyFrame(0.5F, new Vector2(0F, 0F), CubicBezierEasingFunction_06());
                // Frame 100.
                result.InsertKeyFrame(0.555555582F, new Vector2(-0.25F, 1.25F), CubicBezierEasingFunction_05());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, new Vector2(0F, 0F), CubicBezierEasingFunction_05());
                // Frame 135.
                result.InsertKeyFrame(0.75F, new Vector2(0F, 0F), CubicBezierEasingFunction_06());
                // Frame 145.
                result.InsertExpressionKeyFrame(0.805555522F, "3*Square(1-_.t5)*_.t5*Vector2(-0.005,0.208)+(3*(1-_.t5)*Square(_.t5)*Vector2(-0.033,1.249))+(Pow(_.t5,3)*Vector2(-0.033,1.249))", StepThenHoldEasingFunction());
                // Frame 155.
                result.InsertExpressionKeyFrame(0.861111045F, "Pow(1-_.t5,3)*Vector2(-0.033,1.249)+(3*Square(1-_.t5)*_.t5*Vector2(-0.033,1.249))+(3*(1-_.t5)*Square(_.t5)*Vector2(-0.005,0.208))", StepThenHoldEasingFunction());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, new Vector2(0F, 0F), StepThenHoldEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 4
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 7.
                result.InsertKeyFrame(0.0388888903F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 60.
                result.InsertKeyFrame(0.333333343F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 97.
                result.InsertKeyFrame(0.538888872F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 150.
                result.InsertKeyFrame(0.833333313F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            internal Space404_AnimatedVisual(
                Compositor compositor,
                CompositionPropertySet themeProperties
                )
            {
                _c = compositor;
                _themeProperties = themeProperties;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(1080F, 1080F);
            void IDisposable.Dispose() => _root?.Dispose();

            public void CreateAnimations()
            {
                StartProgressBoundAnimation(_containerShape_0, "Offset", OffsetVector2Animation_0(), RootProgress());
                StartProgressBoundAnimation(_containerShape_0, "Scale", ShapeVisibilityAnimation_0(), RootProgress());
                StartProgressBoundAnimation(_containerShape_1, "Offset", OffsetVector2Animation_1(), RootProgress());
                StartProgressBoundAnimation(_containerShape_1, "Scale", ShapeVisibilityAnimation_1(), RootProgress());
                StartProgressBoundAnimation(_containerShape_2, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_0(), RootProgress());
                StartProgressBoundAnimation(_containerShape_2, "Offset", OffsetVector2Animation_2(), RootProgress());
                StartProgressBoundAnimation(_containerShape_3, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_0(), RootProgress());
                StartProgressBoundAnimation(_containerShape_3, "Offset", OffsetVector2Animation_2(), RootProgress());
                StartProgressBoundAnimation(_containerShape_4, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_1(), RootProgress());
                StartProgressBoundAnimation(_containerShape_5, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_0(), RootProgress());
                StartProgressBoundAnimation(_containerShape_5, "Offset", OffsetVector2Animation_2(), RootProgress());
                StartProgressBoundAnimation(_containerShape_6, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_2(), RootProgress());
                StartProgressBoundAnimation(_containerShape_7, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_3(), RootProgress());
                StartProgressBoundAnimation(_containerShape_7, "Offset", OffsetVector2Animation_3(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_07, "Path", PathKeyFrameAnimation_00(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_08, "Path", PathKeyFrameAnimation_01(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_15, "Path", PathKeyFrameAnimation_02(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_16, "Path", PathKeyFrameAnimation_03(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_40, "Path", PathKeyFrameAnimation_04(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_41, "Path", PathKeyFrameAnimation_05(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_42, "Path", PathKeyFrameAnimation_06(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_43, "Path", PathKeyFrameAnimation_07(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_44, "Path", PathKeyFrameAnimation_08(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_45, "Path", PathKeyFrameAnimation_09(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_46, "Path", PathKeyFrameAnimation_10(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_51, "Path", PathKeyFrameAnimation_11(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_52, "Path", PathKeyFrameAnimation_12(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_53, "Path", PathKeyFrameAnimation_13(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_54, "Path", PathKeyFrameAnimation_14(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_55, "Path", PathKeyFrameAnimation_15(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_56, "Path", PathKeyFrameAnimation_16(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_57, "Path", PathKeyFrameAnimation_17(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_00, "Scale.X", ScalarAnimation_0_to_0_0(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_00, "Scale.Y", ScalarAnimation_0_to_0_0(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_01, "Scale.X", ScalarAnimation_0_to_0_1(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_01, "Scale.Y", ScalarAnimation_0_to_0_1(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_02, "Scale.X", ScalarAnimation_0_to_0_2(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_02, "Scale.Y", ScalarAnimation_0_to_0_2(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_03, "Scale.X", ScalarAnimation_0_to_0_3(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_03, "Scale.Y", ScalarAnimation_0_to_0_3(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_04, "Scale.X", ScalarAnimation_0_to_0_4(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_04, "Scale.Y", ScalarAnimation_0_to_0_4(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_05, "Scale.X", ScalarAnimation_0_to_0_5(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_05, "Scale.Y", ScalarAnimation_0_to_0_5(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_06, "Scale.X", ScalarAnimation_0_to_0_6(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_06, "Scale.Y", ScalarAnimation_0_to_0_6(), RootProgress());
                StartProgressBoundAnimation(_root.Properties, "t0", t0ScalarAnimation_0_to_1(), RootProgress());
                StartProgressBoundAnimation(_root.Properties, "t1", t1ScalarAnimation_0_to_1(), RootProgress());
                StartProgressBoundAnimation(_root.Properties, "t2", t2ScalarAnimation_0_to_1(), RootProgress());
                StartProgressBoundAnimation(_root.Properties, "t3", t3ScalarAnimation_0_to_1(), RootProgress());
                StartProgressBoundAnimation(_root.Properties, "t4", t4ScalarAnimation_0_to_1(), RootProgress());
                StartProgressBoundAnimation(_root.Properties, "t5", t5ScalarAnimation_0_to_1(), RootProgress());
            }

            public void DestroyAnimations()
            {
                _containerShape_0.StopAnimation("Offset");
                _containerShape_0.StopAnimation("Scale");
                _containerShape_1.StopAnimation("Offset");
                _containerShape_1.StopAnimation("Scale");
                _containerShape_2.StopAnimation("RotationAngleInDegrees");
                _containerShape_2.StopAnimation("Offset");
                _containerShape_3.StopAnimation("RotationAngleInDegrees");
                _containerShape_3.StopAnimation("Offset");
                _containerShape_4.StopAnimation("RotationAngleInDegrees");
                _containerShape_5.StopAnimation("RotationAngleInDegrees");
                _containerShape_5.StopAnimation("Offset");
                _containerShape_6.StopAnimation("RotationAngleInDegrees");
                _containerShape_7.StopAnimation("RotationAngleInDegrees");
                _containerShape_7.StopAnimation("Offset");
                _pathGeometry_07.StopAnimation("Path");
                _pathGeometry_08.StopAnimation("Path");
                _pathGeometry_15.StopAnimation("Path");
                _pathGeometry_16.StopAnimation("Path");
                _pathGeometry_40.StopAnimation("Path");
                _pathGeometry_41.StopAnimation("Path");
                _pathGeometry_42.StopAnimation("Path");
                _pathGeometry_43.StopAnimation("Path");
                _pathGeometry_44.StopAnimation("Path");
                _pathGeometry_45.StopAnimation("Path");
                _pathGeometry_46.StopAnimation("Path");
                _pathGeometry_51.StopAnimation("Path");
                _pathGeometry_52.StopAnimation("Path");
                _pathGeometry_53.StopAnimation("Path");
                _pathGeometry_54.StopAnimation("Path");
                _pathGeometry_55.StopAnimation("Path");
                _pathGeometry_56.StopAnimation("Path");
                _pathGeometry_57.StopAnimation("Path");
                _spriteShape_00.StopAnimation("Scale.X");
                _spriteShape_00.StopAnimation("Scale.Y");
                _spriteShape_01.StopAnimation("Scale.X");
                _spriteShape_01.StopAnimation("Scale.Y");
                _spriteShape_02.StopAnimation("Scale.X");
                _spriteShape_02.StopAnimation("Scale.Y");
                _spriteShape_03.StopAnimation("Scale.X");
                _spriteShape_03.StopAnimation("Scale.Y");
                _spriteShape_04.StopAnimation("Scale.X");
                _spriteShape_04.StopAnimation("Scale.Y");
                _spriteShape_05.StopAnimation("Scale.X");
                _spriteShape_05.StopAnimation("Scale.Y");
                _spriteShape_06.StopAnimation("Scale.X");
                _spriteShape_06.StopAnimation("Scale.Y");
                _root.Properties.StopAnimation("t0");
                _root.Properties.StopAnimation("t1");
                _root.Properties.StopAnimation("t2");
                _root.Properties.StopAnimation("t3");
                _root.Properties.StopAnimation("t4");
                _root.Properties.StopAnimation("t5");
            }

        }
    }
}
