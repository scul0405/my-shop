using Microsoft.Graphics.Canvas.Geometry;
using Microsoft.UI.Composition;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;

namespace GUI.AnimatedVisuals
{
    // Name:        astrounat
    // Frame rate:  29.9700012207031 fps
    // Frame count: 150.000006109625
    // Duration:    5005.0 mS
    // ___________________________________________________________
    // | Theme property |   Accessor   | Type  |  Default value  |
    // |________________|______________|_______|_________________|
    // | #000000        | Color_000000 | Color | #FF000000 Black |
    // | #160E53        | Color_160E53 | Color |    #FF160E53    |
    // | #190202        | Color_190202 | Color |    #FF190202    |
    // | #261C6A        | Color_261C6A | Color |    #FF261C6A    |
    // | #334F6C        | Color_334F6C | Color |    #FF334F6C    |
    // | #465F7A        | Color_465F7A | Color |    #FF465F7A    |
    // | #5B6C7E        | Color_5B6C7E | Color |    #FF5B6C7E    |
    // | #B3FCC8        | Color_B3FCC8 | Color |    #FFB3FCC8    |
    // | #E492F5        | Color_E492F5 | Color |    #FFE492F5    |
    // | #FFFFFF        | Color_FFFFFF | Color | #FFFFFFFF White |
    // -----------------------------------------------------------
    public sealed class Astronaut
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
    {
        // Animation duration: 5.005 seconds.
        internal const long c_durationTicks = 50050050;

        // Theme property: Color_000000.
        internal static readonly Color c_themeColor_000000 = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);

        // Theme property: Color_160E53.
        internal static readonly Color c_themeColor_160E53 = Color.FromArgb(0xFF, 0x16, 0x0E, 0x53);

        // Theme property: Color_190202.
        internal static readonly Color c_themeColor_190202 = Color.FromArgb(0xFF, 0x19, 0x02, 0x02);

        // Theme property: Color_261C6A.
        internal static readonly Color c_themeColor_261C6A = Color.FromArgb(0xFF, 0x26, 0x1C, 0x6A);

        // Theme property: Color_334F6C.
        internal static readonly Color c_themeColor_334F6C = Color.FromArgb(0xFF, 0x33, 0x4F, 0x6C);

        // Theme property: Color_465F7A.
        internal static readonly Color c_themeColor_465F7A = Color.FromArgb(0xFF, 0x46, 0x5F, 0x7A);

        // Theme property: Color_5B6C7E.
        internal static readonly Color c_themeColor_5B6C7E = Color.FromArgb(0xFF, 0x5B, 0x6C, 0x7E);

        // Theme property: Color_B3FCC8.
        internal static readonly Color c_themeColor_B3FCC8 = Color.FromArgb(0xFF, 0xB3, 0xFC, 0xC8);

        // Theme property: Color_E492F5.
        internal static readonly Color c_themeColor_E492F5 = Color.FromArgb(0xFF, 0xE4, 0x92, 0xF5);

        // Theme property: Color_FFFFFF.
        internal static readonly Color c_themeColor_FFFFFF = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);

        CompositionPropertySet _themeProperties;
        Color _themeColor_000000 = c_themeColor_000000;
        Color _themeColor_160E53 = c_themeColor_160E53;
        Color _themeColor_190202 = c_themeColor_190202;
        Color _themeColor_261C6A = c_themeColor_261C6A;
        Color _themeColor_334F6C = c_themeColor_334F6C;
        Color _themeColor_465F7A = c_themeColor_465F7A;
        Color _themeColor_5B6C7E = c_themeColor_5B6C7E;
        Color _themeColor_B3FCC8 = c_themeColor_B3FCC8;
        Color _themeColor_E492F5 = c_themeColor_E492F5;
        Color _themeColor_FFFFFF = c_themeColor_FFFFFF;

        // Theme properties.
        public Color Color_000000
        {
            get => _themeColor_000000;
            set
            {
                _themeColor_000000 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_000000", ColorAsVector4((Color)_themeColor_000000));
                }
            }
        }

        public Color Color_160E53
        {
            get => _themeColor_160E53;
            set
            {
                _themeColor_160E53 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_160E53", ColorAsVector4((Color)_themeColor_160E53));
                }
            }
        }

        public Color Color_190202
        {
            get => _themeColor_190202;
            set
            {
                _themeColor_190202 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_190202", ColorAsVector4((Color)_themeColor_190202));
                }
            }
        }

        public Color Color_261C6A
        {
            get => _themeColor_261C6A;
            set
            {
                _themeColor_261C6A = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_261C6A", ColorAsVector4((Color)_themeColor_261C6A));
                }
            }
        }

        public Color Color_334F6C
        {
            get => _themeColor_334F6C;
            set
            {
                _themeColor_334F6C = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_334F6C", ColorAsVector4((Color)_themeColor_334F6C));
                }
            }
        }

        public Color Color_465F7A
        {
            get => _themeColor_465F7A;
            set
            {
                _themeColor_465F7A = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_465F7A", ColorAsVector4((Color)_themeColor_465F7A));
                }
            }
        }

        public Color Color_5B6C7E
        {
            get => _themeColor_5B6C7E;
            set
            {
                _themeColor_5B6C7E = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_5B6C7E", ColorAsVector4((Color)_themeColor_5B6C7E));
                }
            }
        }

        public Color Color_B3FCC8
        {
            get => _themeColor_B3FCC8;
            set
            {
                _themeColor_B3FCC8 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_B3FCC8", ColorAsVector4((Color)_themeColor_B3FCC8));
                }
            }
        }

        public Color Color_E492F5
        {
            get => _themeColor_E492F5;
            set
            {
                _themeColor_E492F5 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_E492F5", ColorAsVector4((Color)_themeColor_E492F5));
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
                _themeProperties.InsertVector4("Color_000000", ColorAsVector4((Color)Color_000000));
                _themeProperties.InsertVector4("Color_160E53", ColorAsVector4((Color)Color_160E53));
                _themeProperties.InsertVector4("Color_190202", ColorAsVector4((Color)Color_190202));
                _themeProperties.InsertVector4("Color_261C6A", ColorAsVector4((Color)Color_261C6A));
                _themeProperties.InsertVector4("Color_334F6C", ColorAsVector4((Color)Color_334F6C));
                _themeProperties.InsertVector4("Color_465F7A", ColorAsVector4((Color)Color_465F7A));
                _themeProperties.InsertVector4("Color_5B6C7E", ColorAsVector4((Color)Color_5B6C7E));
                _themeProperties.InsertVector4("Color_B3FCC8", ColorAsVector4((Color)Color_B3FCC8));
                _themeProperties.InsertVector4("Color_E492F5", ColorAsVector4((Color)Color_E492F5));
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
                new Astronauta_AnimatedVisual(
                    compositor,
                    _themeProperties
                    );
                res.CreateAnimations();
                return res;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 150.000006109625;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 29.9700012207031;

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
            return frameNumber / 150.000006109625;
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
            if (propertyName == "Color_000000")
            {
                _themeColor_000000 = value;
            }
            else if (propertyName == "Color_160E53")
            {
                _themeColor_160E53 = value;
            }
            else if (propertyName == "Color_190202")
            {
                _themeColor_190202 = value;
            }
            else if (propertyName == "Color_261C6A")
            {
                _themeColor_261C6A = value;
            }
            else if (propertyName == "Color_334F6C")
            {
                _themeColor_334F6C = value;
            }
            else if (propertyName == "Color_465F7A")
            {
                _themeColor_465F7A = value;
            }
            else if (propertyName == "Color_5B6C7E")
            {
                _themeColor_5B6C7E = value;
            }
            else if (propertyName == "Color_B3FCC8")
            {
                _themeColor_B3FCC8 = value;
            }
            else if (propertyName == "Color_E492F5")
            {
                _themeColor_E492F5 = value;
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

        sealed class Astronauta_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual2
        {
            const long c_durationTicks = 50050050;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            readonly CompositionPropertySet _themeProperties;
            CompositionColorBrush _themeColor_Color_000000;
            CompositionColorBrush _themeColor_Color_160E53_0;
            CompositionColorBrush _themeColor_Color_160E53_1;
            CompositionColorBrush _themeColor_Color_190202;
            CompositionColorBrush _themeColor_Color_261C6A;
            CompositionColorBrush _themeColor_Color_334F6C;
            CompositionColorBrush _themeColor_Color_465F7A;
            CompositionColorBrush _themeColor_Color_5B6C7E;
            CompositionColorBrush _themeColor_Color_B3FCC8_0;
            CompositionColorBrush _themeColor_Color_B3FCC8_1;
            CompositionColorBrush _themeColor_Color_E492F5;
            CompositionColorBrush _themeColor_Color_FFFFFF_0;
            CompositionColorBrush _themeColor_Color_FFFFFF_1;
            CompositionColorBrush _themeColor_Color_FFFFFF_2;
            CompositionColorBrush _themeColor_Color_FFFFFF_3;
            CompositionColorBrush _themeColor_Color_FFFFFF_4;
            CompositionColorBrush _themeColor_Color_FFFFFF_5;
            CompositionColorBrush _themeColor_Color_FFFFFF_6;
            CompositionColorBrush _themeColor_Color_FFFFFF_7;
            CompositionColorBrush _themeColor_Color_FFFFFF_8;
            CompositionContainerShape _containerShape_0;
            CompositionContainerShape _containerShape_1;
            CompositionContainerShape _containerShape_2;
            CompositionPathGeometry _pathGeometry_01;
            CompositionPathGeometry _pathGeometry_04;
            CompositionPathGeometry _pathGeometry_06;
            CompositionPathGeometry _pathGeometry_31;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            CubicBezierEasingFunction _cubicBezierEasingFunction_1;
            ExpressionAnimation _rootProgress;
            StepEasingFunction _holdThenStepEasingFunction;
            StepEasingFunction _stepThenHoldEasingFunction;

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

            void BindProperty2(
                CompositionObject target,
                string animatedPropertyName,
                string expression,
                string referenceParameterName0,
                CompositionObject referencedObject0,
                string referenceParameterName1,
                CompositionObject referencedObject1)
            {
                _reusableExpressionAnimation.ClearAllParameters();
                _reusableExpressionAnimation.Expression = expression;
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName0, referencedObject0);
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName1, referencedObject1);
                target.StartAnimation(animatedPropertyName, _reusableExpressionAnimation);
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
            // - - ShapeGroup: Group 1 Offset:<247.975, 238.895>
            CanvasGeometry Geometry_00()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(174.725006F, -174.320007F));
                    builder.AddCubicBezier(new Vector2(230.438995F, -98.7030029F), new Vector2(269.734985F, 124.557999F), new Vector2(164.783997F, 201.884003F));
                    builder.AddCubicBezier(new Vector2(59.8330002F, 279.210999F), new Vector2(-149.621994F, 181.322006F), new Vector2(-205.335999F, 105.704002F));
                    builder.AddCubicBezier(new Vector2(-261.049988F, 30.0869999F), new Vector2(-221.134995F, -93.8980026F), new Vector2(-116.183998F, -171.225006F));
                    builder.AddCubicBezier(new Vector2(-11.2329998F, -248.550995F), new Vector2(119.011002F, -249.936996F), new Vector2(174.725006F, -174.320007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_01()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(7F, 0F));
                    builder.AddCubicBezier(new Vector2(7F, 3.86599994F), new Vector2(3.86599994F, 7F), new Vector2(0F, 7F));
                    builder.AddCubicBezier(new Vector2(-3.86599994F, 7F), new Vector2(-7F, 3.86599994F), new Vector2(-7F, 0F));
                    builder.AddCubicBezier(new Vector2(-7F, -3.86599994F), new Vector2(-3.86599994F, -7F), new Vector2(0F, -7F));
                    builder.AddCubicBezier(new Vector2(3.86599994F, -7F), new Vector2(7F, -3.86599994F), new Vector2(7F, 0F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1 Offset:<472, 234>
            CanvasGeometry Geometry_02()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(9F, 0F));
                    builder.AddCubicBezier(new Vector2(9F, 4.97100019F), new Vector2(4.97100019F, 9F), new Vector2(0F, 9F));
                    builder.AddCubicBezier(new Vector2(-4.97100019F, 9F), new Vector2(-9F, 4.97100019F), new Vector2(-9F, 0F));
                    builder.AddCubicBezier(new Vector2(-9F, -4.97100019F), new Vector2(-4.97100019F, -9F), new Vector2(0F, -9F));
                    builder.AddCubicBezier(new Vector2(4.97100019F, -9F), new Vector2(9F, -4.97100019F), new Vector2(9F, 0F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1 Offset:<60.5, 341.5>
            CanvasGeometry Geometry_03()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(5.5F, 0F));
                    builder.AddCubicBezier(new Vector2(5.5F, 3.03699994F), new Vector2(3.03800011F, 5.5F), new Vector2(0F, 5.5F));
                    builder.AddCubicBezier(new Vector2(-3.03800011F, 5.5F), new Vector2(-5.5F, 3.03699994F), new Vector2(-5.5F, 0F));
                    builder.AddCubicBezier(new Vector2(-5.5F, -3.03699994F), new Vector2(-3.03800011F, -5.5F), new Vector2(0F, -5.5F));
                    builder.AddCubicBezier(new Vector2(3.03800011F, -5.5F), new Vector2(5.5F, -3.03699994F), new Vector2(5.5F, 0F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_04()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(3F, 0F));
                    builder.AddCubicBezier(new Vector2(3F, 1.65699995F), new Vector2(1.65699995F, 3F), new Vector2(0F, 3F));
                    builder.AddCubicBezier(new Vector2(-1.65699995F, 3F), new Vector2(-3F, 1.65699995F), new Vector2(-3F, 0F));
                    builder.AddCubicBezier(new Vector2(-3F, -1.65699995F), new Vector2(-1.65699995F, -3F), new Vector2(0F, -3F));
                    builder.AddCubicBezier(new Vector2(1.65699995F, -3F), new Vector2(3F, -1.65699995F), new Vector2(3F, 0F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1 Offset:<263, 162>
            CanvasGeometry Geometry_05()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(11F, 0F));
                    builder.AddCubicBezier(new Vector2(11F, 6.07499981F), new Vector2(6.07499981F, 11F), new Vector2(0F, 11F));
                    builder.AddCubicBezier(new Vector2(-6.07499981F, 11F), new Vector2(-11F, 6.07499981F), new Vector2(-11F, 0F));
                    builder.AddCubicBezier(new Vector2(-11F, -6.07499981F), new Vector2(-6.07499981F, -11F), new Vector2(0F, -11F));
                    builder.AddCubicBezier(new Vector2(6.07499981F, -11F), new Vector2(11F, -6.07499981F), new Vector2(11F, 0F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_06()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(4.5F, 0F));
                    builder.AddCubicBezier(new Vector2(4.5F, 2.4849999F), new Vector2(2.4849999F, 4.5F), new Vector2(0F, 4.5F));
                    builder.AddCubicBezier(new Vector2(-2.4849999F, 4.5F), new Vector2(-4.5F, 2.4849999F), new Vector2(-4.5F, 0F));
                    builder.AddCubicBezier(new Vector2(-4.5F, -2.4849999F), new Vector2(-2.4849999F, -4.5F), new Vector2(0F, -4.5F));
                    builder.AddCubicBezier(new Vector2(2.4849999F, -4.5F), new Vector2(4.5F, -2.4849999F), new Vector2(4.5F, 0F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 2 Offset:<182.545, 346.877>
            CanvasGeometry Geometry_07()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-0.00100000005F, -50.4539986F));
                    builder.AddCubicBezier(new Vector2(27.8460007F, -50.4539986F), new Vector2(50.4539986F, -27.8470001F), new Vector2(50.4539986F, 0F));
                    builder.AddCubicBezier(new Vector2(50.4539986F, 27.8470001F), new Vector2(27.8460007F, 50.4539986F), new Vector2(-0.00100000005F, 50.4539986F));
                    builder.AddCubicBezier(new Vector2(-27.8470001F, 50.4539986F), new Vector2(-50.4550018F, 27.8470001F), new Vector2(-50.4550018F, 0F));
                    builder.AddCubicBezier(new Vector2(-50.4550018F, -27.8470001F), new Vector2(-27.8470001F, -50.4539986F), new Vector2(-0.00100000005F, -50.4539986F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1 Offset:<179.849, 355.341>
            CanvasGeometry Geometry_08()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-34.9959984F, -41.9910011F));
                    builder.AddCubicBezier(new Vector2(-38.4449997F, -35.1650009F), new Vector2(-40.3889999F, -27.4510002F), new Vector2(-40.3889999F, -19.2880001F));
                    builder.AddCubicBezier(new Vector2(-40.3889999F, 8.56000042F), new Vector2(-17.7810001F, 31.1679993F), new Vector2(10.066F, 31.1679993F));
                    builder.AddCubicBezier(new Vector2(25.0480003F, 31.1679993F), new Vector2(38.5139999F, 24.6240005F), new Vector2(47.7579994F, 14.2399998F));
                    builder.AddCubicBezier(new Vector2(39.4430008F, 30.6970005F), new Vector2(22.3789997F, 41.9910011F), new Vector2(2.6960001F, 41.9910011F));
                    builder.AddCubicBezier(new Vector2(-25.1499996F, 41.9910011F), new Vector2(-47.7579994F, 19.3840008F), new Vector2(-47.7579994F, -8.4630003F));
                    builder.AddCubicBezier(new Vector2(-47.7579994F, -21.3269997F), new Vector2(-42.9329987F, -33.0750008F), new Vector2(-34.9959984F, -41.9910011F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 22 Offset:<159.611, 172.546>
            CanvasGeometry Geometry_09()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(16.1580009F, -3.82800007F));
                    builder.AddCubicBezier(new Vector2(13.934F, -5.47800016F), new Vector2(11.3900003F, -6.94700003F), new Vector2(8.58899975F, -8.14299965F));
                    builder.AddCubicBezier(new Vector2(-0.861999989F, -12.1809998F), new Vector2(-10.5430002F, -11.9549999F), new Vector2(-16.1580009F, -8.16699982F));
                    builder.AddCubicBezier(new Vector2(-15.0129995F, -1.49100006F), new Vector2(-8.4829998F, 5.65999985F), new Vector2(0.967999995F, 9.69799995F));
                    builder.AddCubicBezier(new Vector2(3.76900005F, 10.8940001F), new Vector2(6.59000015F, 11.7150002F), new Vector2(9.31999969F, 12.1809998F));
                    builder.AddCubicBezier(new Vector2(12.868F, 7.59700012F), new Vector2(15.1949997F, 2.28900003F), new Vector2(16.1580009F, -3.82800007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 21 Offset:<158.415, 174.554>
            CanvasGeometry Geometry_10()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-14.9619999F, -10.1739998F));
                    builder.AddCubicBezier(new Vector2(-13.8170004F, -3.49799991F), new Vector2(-7.28700018F, 3.65199995F), new Vector2(2.16400003F, 7.69000006F));
                    builder.AddCubicBezier(new Vector2(4.96500015F, 8.88599968F), new Vector2(7.78599977F, 9.70800018F), new Vector2(10.5159998F, 10.1739998F));
                    builder.AddCubicBezier(new Vector2(12.3199997F, 7.84299994F), new Vector2(13.809F, 5.32499981F), new Vector2(14.9619999F, 2.60800004F));
                    builder.AddLine(new Vector2(-14.9619999F, -10.1739998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 20 Offset:<166.364, 157.584>
            CanvasGeometry Geometry_11()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-8.40100002F, 7.6420002F));
                    builder.AddLine(new Vector2(-4.39699984F, -17.6879997F));
                    builder.AddLine(new Vector2(8.40100002F, -7.6420002F));
                    builder.AddLine(new Vector2(4.39699984F, 17.6879997F));
                    builder.AddLine(new Vector2(-8.40100002F, 7.6420002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 19 Offset:<167.14, 150.7>
            CanvasGeometry Geometry_12()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-7.62599993F, 4.71799994F));
                    builder.AddCubicBezier(new Vector2(-3.7809999F, 6.98899984F), new Vector2(0.100000001F, 9.01799965F), new Vector2(3.98300004F, 10.8030005F));
                    builder.AddCubicBezier(new Vector2(4.6789999F, 10.2729998F), new Vector2(5.36899996F, 9.73799992F), new Vector2(6.05200005F, 9.19499969F));
                    builder.AddLine(new Vector2(7.625F, -0.758000016F));
                    builder.AddLine(new Vector2(-5.17299986F, -10.8030005F));
                    builder.AddLine(new Vector2(-7.62599993F, 4.71799994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 18 Offset:<218.693, 98.422>
            CanvasGeometry Geometry_13()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(14.0810003F, 4.97100019F));
                    builder.AddCubicBezier(new Vector2(12.9809999F, 2.43000007F), new Vector2(11.5120001F, -0.114F), new Vector2(9.68500042F, -2.54999995F));
                    builder.AddCubicBezier(new Vector2(3.51799989F, -10.7720003F), new Vector2(-4.97900009F, -15.4160004F), new Vector2(-11.7349997F, -14.9429998F));
                    builder.AddCubicBezier(new Vector2(-14.0810003F, -8.58899975F), new Vector2(-12.0019999F, 0.867999971F), new Vector2(-5.83599997F, 9.09000015F));
                    builder.AddCubicBezier(new Vector2(-4.0079999F, 11.5270004F), new Vector2(-1.97599995F, 13.6490002F), new Vector2(0.155000001F, 15.4169998F));
                    builder.AddCubicBezier(new Vector2(5.51999998F, 13.2220001F), new Vector2(10.1890001F, 9.7869997F), new Vector2(14.0810003F, 4.97100019F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 17 Offset:<215.547, 98.658>
            CanvasGeometry Geometry_14()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-8.58899975F, -15.1800003F));
                    builder.AddCubicBezier(new Vector2(-10.9350004F, -8.82600021F), new Vector2(-8.85599995F, 0.630999982F), new Vector2(-2.69000006F, 8.85299969F));
                    builder.AddCubicBezier(new Vector2(-0.861999989F, 11.29F), new Vector2(1.16999996F, 13.4119997F), new Vector2(3.30100012F, 15.1800003F));
                    builder.AddCubicBezier(new Vector2(6.02899981F, 14.0640001F), new Vector2(8.57699966F, 12.6269999F), new Vector2(10.9350004F, 10.8520002F));
                    builder.AddLine(new Vector2(-8.58899975F, -15.1800003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 16 Offset:<205.444, 107.798>
            CanvasGeometry Geometry_15()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(5.42799997F, -9.97599983F));
                    builder.AddLine(new Vector2(-18.2259998F, -0.0700000003F));
                    builder.AddLine(new Vector2(-5.42799997F, 9.97599983F));
                    builder.AddLine(new Vector2(18.2259998F, 0.0700000003F));
                    builder.AddLine(new Vector2(5.42799997F, -9.97599983F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 15 Offset:<198.924, 109.633>
            CanvasGeometry Geometry_16()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(3.18799996F, -8.1420002F));
                    builder.AddLine(new Vector2(-11.7060003F, -1.90400004F));
                    builder.AddLine(new Vector2(1.09200001F, 8.1420002F));
                    builder.AddLine(new Vector2(10.4879999F, 4.20699978F));
                    builder.AddCubicBezier(new Vector2(10.9020004F, 3.32500005F), new Vector2(11.309F, 2.43600011F), new Vector2(11.7069998F, 1.53900003F));
                    builder.AddCubicBezier(new Vector2(9.09399986F, -1.75600004F), new Vector2(6.25F, -4.99399996F), new Vector2(3.18799996F, -8.1420002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 14 Offset:<194.994, 139.475>
            CanvasGeometry Geometry_17()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(12.8529997F, -25.2649994F));
                    builder.AddCubicBezier(new Vector2(4.40199995F, -7.3579998F), new Vector2(-7.25299978F, 7.27299976F), new Vector2(-21.8110008F, 18.9319992F));
                    builder.AddCubicBezier(new Vector2(-17.9300003F, 21.3439999F), new Vector2(-13.9969997F, 23.4559994F), new Vector2(-10.0609999F, 25.2649994F));
                    builder.AddCubicBezier(new Vector2(3.62100005F, 14.8599997F), new Vector2(14.3590002F, 1.44099998F), new Vector2(21.8110008F, -15.3389997F));
                    builder.AddCubicBezier(new Vector2(19.1149998F, -18.7380009F), new Vector2(16.1229992F, -22.0629997F), new Vector2(12.8529997F, -25.2649994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 13 Offset:<188.329, 151.527>
            CanvasGeometry Geometry_18()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(4.73999977F, -13.2130003F));
                    builder.AddCubicBezier(new Vector2(-1.11399996F, -5.72300005F), new Vector2(-7.75600004F, 0.962000012F), new Vector2(-15.1459999F, 6.88000011F));
                    builder.AddCubicBezier(new Vector2(-11.2650003F, 9.29199982F), new Vector2(-7.33199978F, 11.4040003F), new Vector2(-3.39599991F, 13.2130003F));
                    builder.AddCubicBezier(new Vector2(3.56100011F, 7.92199993F), new Vector2(9.75599957F, 1.85099995F), new Vector2(15.1459999F, -5.04400015F));
                    builder.AddLine(new Vector2(4.73999977F, -13.2130003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 12 Offset:<155.364, 111.447>
            CanvasGeometry Geometry_19()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-39.1380005F, -47.7610016F));
                    builder.AddLine(new Vector2(-39.3059998F, -47.75F));
                    builder.AddLine(new Vector2(-39.2369995F, -47.7550011F));
                    builder.AddLine(new Vector2(-39.1380005F, -47.7610016F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-39.3139992F, -47.75F));
                    builder.AddLine(new Vector2(-39.4760017F, -47.7389984F));
                    builder.AddLine(new Vector2(-39.3919983F, -47.7449989F));
                    builder.AddLine(new Vector2(-39.3139992F, -47.75F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-39.4860001F, -47.7389984F));
                    builder.AddLine(new Vector2(-39.6500015F, -47.7270012F));
                    builder.AddLine(new Vector2(-39.5480003F, -47.7340012F));
                    builder.AddLine(new Vector2(-39.4860001F, -47.7389984F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-39.6549988F, -47.7270012F));
                    builder.AddCubicBezier(new Vector2(-39.9949989F, -47.7029991F), new Vector2(-40.3349991F, -47.6769981F), new Vector2(-40.6730003F, -47.6479988F));
                    builder.AddCubicBezier(new Vector2(-40.3349991F, -47.6769981F), new Vector2(-39.9949989F, -47.7029991F), new Vector2(-39.6549988F, -47.7270012F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-40.6899986F, -47.6469994F));
                    builder.AddLine(new Vector2(-40.8380013F, -47.6339989F));
                    builder.AddLine(new Vector2(-40.7840004F, -47.6389999F));
                    builder.AddLine(new Vector2(-40.6899986F, -47.6469994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-40.862999F, -47.632F));
                    builder.AddLine(new Vector2(-41.0040016F, -47.6189995F));
                    builder.AddLine(new Vector2(-40.9379997F, -47.625F));
                    builder.AddLine(new Vector2(-40.862999F, -47.632F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-41.0320015F, -47.6160011F));
                    builder.AddLine(new Vector2(-41.1720009F, -47.6030006F));
                    builder.AddLine(new Vector2(-41.0909996F, -47.6110001F));
                    builder.AddLine(new Vector2(-41.0320015F, -47.6160011F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-41.1980019F, -47.6010017F));
                    builder.AddLine(new Vector2(-41.3440018F, -47.5870018F));
                    builder.AddLine(new Vector2(-41.2439995F, -47.5970001F));
                    builder.AddLine(new Vector2(-41.1980019F, -47.6010017F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-41.362999F, -47.5849991F));
                    builder.AddCubicBezier(new Vector2(-41.5859985F, -47.5639992F), new Vector2(-41.8089981F, -47.5410004F), new Vector2(-42.0309982F, -47.5169983F));
                    builder.AddCubicBezier(new Vector2(-41.8089981F, -47.5410004F), new Vector2(-41.5859985F, -47.5639992F), new Vector2(-41.362999F, -47.5849991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-42.0400009F, -47.5159988F));
                    builder.AddLine(new Vector2(-42.1930008F, -47.4990005F));
                    builder.AddLine(new Vector2(-42.1599998F, -47.5029984F));
                    builder.AddLine(new Vector2(-42.0400009F, -47.5159988F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-42.2210007F, -47.4959984F));
                    builder.AddLine(new Vector2(-42.3549995F, -47.480999F));
                    builder.AddLine(new Vector2(-42.3120003F, -47.4860001F));
                    builder.AddLine(new Vector2(-42.2210007F, -47.4959984F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-42.3919983F, -47.4770012F));
                    builder.AddLine(new Vector2(-42.5169983F, -47.4630013F));
                    builder.AddLine(new Vector2(-42.4640007F, -47.4690018F));
                    builder.AddLine(new Vector2(-42.3919983F, -47.4770012F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-42.5579987F, -47.4580002F));
                    builder.AddLine(new Vector2(-42.6809998F, -47.4440002F));
                    builder.AddLine(new Vector2(-42.6160011F, -47.4510002F));
                    builder.AddLine(new Vector2(-42.5579987F, -47.4580002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-42.7220001F, -47.4389992F));
                    builder.AddLine(new Vector2(-42.8470001F, -47.4239998F));
                    builder.AddLine(new Vector2(-42.7669983F, -47.4329987F));
                    builder.AddLine(new Vector2(-42.7220001F, -47.4389992F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-42.8839989F, -47.4189987F));
                    builder.AddLine(new Vector2(-43.0180016F, -47.4029999F));
                    builder.AddLine(new Vector2(-42.9189987F, -47.4150009F));
                    builder.AddLine(new Vector2(-42.8839989F, -47.4189987F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-43.0460014F, -47.3989983F));
                    builder.AddLine(new Vector2(-43.2050018F, -47.3790016F));
                    builder.AddLine(new Vector2(-43.0699997F, -47.3959999F));
                    builder.AddLine(new Vector2(-43.0460014F, -47.3989983F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-43.3720016F, -47.3580017F));
                    builder.AddLine(new Vector2(-43.5369987F, -47.3359985F));
                    builder.AddCubicBezier(new Vector2(-43.4269981F, -47.3510017F), new Vector2(-43.3170013F, -47.3650017F), new Vector2(-43.2060013F, -47.3790016F));
                    builder.AddLine(new Vector2(-43.3720016F, -47.3580017F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-43.5509987F, -47.3339996F));
                    builder.AddLine(new Vector2(-43.6959991F, -47.3149986F));
                    builder.AddLine(new Vector2(-43.6720009F, -47.3180008F));
                    builder.AddLine(new Vector2(-43.5509987F, -47.3339996F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-43.7319984F, -47.3100014F));
                    builder.AddLine(new Vector2(-43.8549995F, -47.2929993F));
                    builder.AddLine(new Vector2(-43.8219986F, -47.2970009F));
                    builder.AddLine(new Vector2(-43.7319984F, -47.3100014F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-43.901001F, -47.2859993F));
                    builder.AddLine(new Vector2(-44.0149994F, -47.2700005F));
                    builder.AddLine(new Vector2(-43.9720001F, -47.2770004F));
                    builder.AddLine(new Vector2(-43.901001F, -47.2859993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-44.0639992F, -47.2630005F));
                    builder.AddLine(new Vector2(-44.1749992F, -47.2480011F));
                    builder.AddLine(new Vector2(-44.1209984F, -47.2550011F));
                    builder.AddLine(new Vector2(-44.0639992F, -47.2630005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-44.2249985F, -47.2400017F));
                    builder.AddLine(new Vector2(-44.3359985F, -47.223999F));
                    builder.AddLine(new Vector2(-44.2709999F, -47.2340012F));
                    builder.AddLine(new Vector2(-44.2249985F, -47.2400017F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-44.3860016F, -47.2169991F));
                    builder.AddLine(new Vector2(-44.5F, -47.2000008F));
                    builder.AddLine(new Vector2(-44.4199982F, -47.2120018F));
                    builder.AddLine(new Vector2(-44.3860016F, -47.2169991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-44.5439987F, -47.1930008F));
                    builder.AddLine(new Vector2(-44.6710014F, -47.1739998F));
                    builder.AddLine(new Vector2(-44.5690002F, -47.1899986F));
                    builder.AddLine(new Vector2(-44.5439987F, -47.1930008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-44.8610001F, -47.1450005F));
                    builder.AddLine(new Vector2(-45.0239983F, -47.1189995F));
                    builder.AddCubicBezier(new Vector2(-44.9169998F, -47.1360016F), new Vector2(-44.8100014F, -47.1529999F), new Vector2(-44.7019997F, -47.1689987F));
                    builder.AddLine(new Vector2(-44.8610001F, -47.1450005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-45.0349998F, -47.1170006F));
                    builder.AddLine(new Vector2(-45.1809998F, -47.0940018F));
                    builder.AddLine(new Vector2(-45.1629982F, -47.0970001F));
                    builder.AddLine(new Vector2(-45.0349998F, -47.1170006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-45.2220001F, -47.0870018F));
                    builder.AddLine(new Vector2(-45.3380013F, -47.0680008F));
                    builder.AddLine(new Vector2(-45.3110008F, -47.0719986F));
                    builder.AddLine(new Vector2(-45.2220001F, -47.0870018F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-45.3880005F, -47.0600014F));
                    builder.AddLine(new Vector2(-45.4939995F, -47.0419998F));
                    builder.AddLine(new Vector2(-45.4589996F, -47.0480003F));
                    builder.AddLine(new Vector2(-45.3880005F, -47.0600014F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-45.5499992F, -47.0330009F));
                    builder.AddLine(new Vector2(-45.6520004F, -47.0149994F));
                    builder.AddLine(new Vector2(-45.6069984F, -47.0229988F));
                    builder.AddLine(new Vector2(-45.5499992F, -47.0330009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-45.7080002F, -47.0060005F));
                    builder.AddLine(new Vector2(-45.8089981F, -46.987999F));
                    builder.AddLine(new Vector2(-45.7550011F, -46.9980011F));
                    builder.AddLine(new Vector2(-45.7080002F, -47.0060005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-45.8660011F, -46.9780006F));
                    builder.AddLine(new Vector2(-45.9690018F, -46.9599991F));
                    builder.AddLine(new Vector2(-45.9020004F, -46.9720001F));
                    builder.AddLine(new Vector2(-45.8660011F, -46.9780006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-46.0219994F, -46.9510002F));
                    builder.AddLine(new Vector2(-46.1310005F, -46.9319992F));
                    builder.AddLine(new Vector2(-46.0489998F, -46.9459991F));
                    builder.AddLine(new Vector2(-46.0219994F, -46.9510002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-46.1780014F, -46.9230003F));
                    builder.AddLine(new Vector2(-46.3040009F, -46.9000015F));
                    builder.AddLine(new Vector2(-46.1959991F, -46.9199982F));
                    builder.AddLine(new Vector2(-46.1780014F, -46.9230003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-46.4920006F, -46.8660011F));
                    builder.AddLine(new Vector2(-46.6469994F, -46.8359985F));
                    builder.AddCubicBezier(new Vector2(-46.5419998F, -46.855999F), new Vector2(-46.4379997F, -46.8759995F), new Vector2(-46.3330002F, -46.8950005F));
                    builder.AddLine(new Vector2(-46.4920006F, -46.8660011F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-46.6879997F, -46.8289986F));
                    builder.AddLine(new Vector2(-46.8009987F, -46.8069992F));
                    builder.AddLine(new Vector2(-46.7809982F, -46.8110008F));
                    builder.AddLine(new Vector2(-46.6879997F, -46.8289986F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-46.8540001F, -46.7970009F));
                    builder.AddLine(new Vector2(-46.9550018F, -46.7770004F));
                    builder.AddLine(new Vector2(-46.9269981F, -46.7830009F));
                    builder.AddLine(new Vector2(-46.8540001F, -46.7970009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-47.0130005F, -46.7659988F));
                    builder.AddLine(new Vector2(-47.1100006F, -46.7470016F));
                    builder.AddLine(new Vector2(-47.0719986F, -46.7540016F));
                    builder.AddLine(new Vector2(-47.0130005F, -46.7659988F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-47.1699982F, -46.7350006F));
                    builder.AddLine(new Vector2(-47.2639999F, -46.7159996F));
                    builder.AddLine(new Vector2(-47.2179985F, -46.7249985F));
                    builder.AddLine(new Vector2(-47.1699982F, -46.7350006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-47.3250008F, -46.7039986F));
                    builder.AddLine(new Vector2(-47.4199982F, -46.6839981F));
                    builder.AddLine(new Vector2(-47.362999F, -46.6959991F));
                    builder.AddLine(new Vector2(-47.3250008F, -46.7039986F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-47.4790001F, -46.6720009F));
                    builder.AddLine(new Vector2(-47.5769997F, -46.6520004F));
                    builder.AddLine(new Vector2(-47.507F, -46.6669998F));
                    builder.AddLine(new Vector2(-47.4790001F, -46.6720009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-47.6329994F, -46.6409988F));
                    builder.AddLine(new Vector2(-47.7389984F, -46.618F));
                    builder.AddLine(new Vector2(-47.6520004F, -46.637001F));
                    builder.AddLine(new Vector2(-47.6329994F, -46.6409988F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-47.7849998F, -46.6090012F));
                    builder.AddLine(new Vector2(-47.9280014F, -46.5779991F));
                    builder.AddLine(new Vector2(-47.7970009F, -46.605999F));
                    builder.AddLine(new Vector2(-47.7849998F, -46.6090012F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-47.9379997F, -46.5760002F));
                    builder.AddLine(new Vector2(-48.0919991F, -46.5429993F));
                    builder.AddCubicBezier(new Vector2(-48.0410004F, -46.5540009F), new Vector2(-47.9900017F, -46.5649986F), new Vector2(-47.9379997F, -46.5760002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-48.1300011F, -46.5349998F));
                    builder.AddLine(new Vector2(-48.2439995F, -46.5099983F));
                    builder.AddLine(new Vector2(-48.2290001F, -46.5130005F));
                    builder.AddLine(new Vector2(-48.1300011F, -46.5349998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-48.2980003F, -46.4980011F));
                    builder.AddLine(new Vector2(-48.3959999F, -46.4760017F));
                    builder.AddLine(new Vector2(-48.3720016F, -46.480999F));
                    builder.AddLine(new Vector2(-48.2980003F, -46.4980011F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-48.4550018F, -46.4630013F));
                    builder.AddLine(new Vector2(-48.5480003F, -46.4420013F));
                    builder.AddLine(new Vector2(-48.5149994F, -46.4490013F));
                    builder.AddLine(new Vector2(-48.4550018F, -46.4630013F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-48.6090012F, -46.4280014F));
                    builder.AddLine(new Vector2(-48.7000008F, -46.4070015F));
                    builder.AddLine(new Vector2(-48.6590004F, -46.4169998F));
                    builder.AddLine(new Vector2(-48.6090012F, -46.4280014F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-48.762001F, -46.3930016F));
                    builder.AddLine(new Vector2(-48.8520012F, -46.3720016F));
                    builder.AddLine(new Vector2(-48.8019981F, -46.3839989F));
                    builder.AddLine(new Vector2(-48.762001F, -46.3930016F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-48.9140015F, -46.3580017F));
                    builder.AddLine(new Vector2(-49.0050011F, -46.3359985F));
                    builder.AddLine(new Vector2(-48.9449997F, -46.3499985F));
                    builder.AddLine(new Vector2(-48.9140015F, -46.3580017F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-49.0649986F, -46.3219986F));
                    builder.AddLine(new Vector2(-49.1609993F, -46.2989998F));
                    builder.AddLine(new Vector2(-49.0870018F, -46.3170013F));
                    builder.AddLine(new Vector2(-49.0649986F, -46.3219986F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-49.2159996F, -46.2859993F));
                    builder.AddLine(new Vector2(-49.3269997F, -46.2589989F));
                    builder.AddLine(new Vector2(-49.2290001F, -46.2830009F));
                    builder.AddLine(new Vector2(-49.2159996F, -46.2859993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-49.3660011F, -46.25F));
                    builder.AddLine(new Vector2(-49.5159988F, -46.2130013F));
                    builder.AddCubicBezier(new Vector2(-49.4659996F, -46.2249985F), new Vector2(-49.4160004F, -46.237999F), new Vector2(-49.3660011F, -46.25F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-49.5410004F, -46.2070007F));
                    builder.AddLine(new Vector2(-49.6660004F, -46.1759987F));
                    builder.AddLine(new Vector2(-49.6549988F, -46.1790009F));
                    builder.AddLine(new Vector2(-49.5410004F, -46.2070007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-49.7169991F, -46.1629982F));
                    builder.AddLine(new Vector2(-49.8149986F, -46.1380005F));
                    builder.AddLine(new Vector2(-49.7960014F, -46.1430016F));
                    builder.AddLine(new Vector2(-49.7169991F, -46.1629982F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-49.8740005F, -46.1230011F));
                    builder.AddLine(new Vector2(-49.9650002F, -46.0999985F));
                    builder.AddLine(new Vector2(-49.9370003F, -46.1069984F));
                    builder.AddLine(new Vector2(-49.8740005F, -46.1230011F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-50.026001F, -46.0839996F));
                    builder.AddLine(new Vector2(-50.1139984F, -46.0620003F));
                    builder.AddLine(new Vector2(-50.0779991F, -46.0709991F));
                    builder.AddLine(new Vector2(-50.026001F, -46.0839996F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-50.1769981F, -46.0449982F));
                    builder.AddLine(new Vector2(-50.2630005F, -46.0229988F));
                    builder.AddLine(new Vector2(-50.2190018F, -46.0340004F));
                    builder.AddLine(new Vector2(-50.1769981F, -46.0449982F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-50.3260002F, -46.0060005F));
                    builder.AddLine(new Vector2(-50.4129982F, -45.9830017F));
                    builder.AddLine(new Vector2(-50.3600006F, -45.9980011F));
                    builder.AddLine(new Vector2(-50.3260002F, -46.0060005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-50.4749985F, -45.9669991F));
                    builder.AddLine(new Vector2(-50.5649986F, -45.9430008F));
                    builder.AddLine(new Vector2(-50.5F, -45.9599991F));
                    builder.AddLine(new Vector2(-50.4749985F, -45.9669991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-50.6230011F, -45.9269981F));
                    builder.AddLine(new Vector2(-50.7210007F, -45.9000015F));
                    builder.AddLine(new Vector2(-50.6399994F, -45.9230003F));
                    builder.AddLine(new Vector2(-50.6230011F, -45.9269981F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-50.7709999F, -45.887001F));
                    builder.AddLine(new Vector2(-50.9059982F, -45.8499985F));
                    builder.AddLine(new Vector2(-50.7799988F, -45.8849983F));
                    builder.AddLine(new Vector2(-50.7709999F, -45.887001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-50.9179993F, -45.8460007F));
                    builder.AddLine(new Vector2(-51.0649986F, -45.8050003F));
                    builder.AddCubicBezier(new Vector2(-51.0159988F, -45.8190002F), new Vector2(-50.9669991F, -45.8330002F), new Vector2(-50.9179993F, -45.8460007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-51.1110001F, -45.7929993F));
                    builder.AddLine(new Vector2(-51.2120018F, -45.7639999F));
                    builder.AddLine(new Vector2(-51.1980019F, -45.7680016F));
                    builder.AddLine(new Vector2(-51.1110001F, -45.7929993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-51.269001F, -45.7480011F));
                    builder.AddLine(new Vector2(-51.3590012F, -45.7220001F));
                    builder.AddLine(new Vector2(-51.3359985F, -45.7290001F));
                    builder.AddLine(new Vector2(-51.269001F, -45.7480011F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-51.4199982F, -45.7050018F));
                    builder.AddLine(new Vector2(-51.5060005F, -45.6800003F));
                    builder.AddLine(new Vector2(-51.4749985F, -45.6889992F));
                    builder.AddLine(new Vector2(-51.4199982F, -45.7050018F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-51.5680008F, -45.6619987F));
                    builder.AddLine(new Vector2(-51.6529999F, -45.637001F));
                    builder.AddLine(new Vector2(-51.6139984F, -45.6489983F));
                    builder.AddLine(new Vector2(-51.5680008F, -45.6619987F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-51.7150002F, -45.6189995F));
                    builder.AddLine(new Vector2(-51.7999992F, -45.5940018F));
                    builder.AddLine(new Vector2(-51.7509995F, -45.6080017F));
                    builder.AddLine(new Vector2(-51.7150002F, -45.6189995F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-51.8610001F, -45.5750008F));
                    builder.AddLine(new Vector2(-51.9480019F, -45.5499992F));
                    builder.AddLine(new Vector2(-51.8889999F, -45.5670013F));
                    builder.AddLine(new Vector2(-51.8610001F, -45.5750008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-52.007F, -45.5320015F));
                    builder.AddLine(new Vector2(-52.0979996F, -45.5040016F));
                    builder.AddLine(new Vector2(-52.0270004F, -45.526001F));
                    builder.AddLine(new Vector2(-52.007F, -45.5320015F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-52.1529999F, -45.487999F));
                    builder.AddLine(new Vector2(-52.2599983F, -45.4550018F));
                    builder.AddLine(new Vector2(-52.1640015F, -45.4840012F));
                    builder.AddLine(new Vector2(-52.1529999F, -45.487999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-52.2980003F, -45.4430008F));
                    builder.AddLine(new Vector2(-52.4420013F, -45.3979988F));
                    builder.AddLine(new Vector2(-52.2980003F, -45.4430008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-52.4749985F, -45.3880005F));
                    builder.AddLine(new Vector2(-52.5859985F, -45.3530006F));
                    builder.AddLine(new Vector2(-52.5750008F, -45.3569984F));
                    builder.AddLine(new Vector2(-52.4749985F, -45.3880005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-52.6389999F, -45.3370018F));
                    builder.AddLine(new Vector2(-52.730999F, -45.3079987F));
                    builder.AddLine(new Vector2(-52.7120018F, -45.3139992F));
                    builder.AddLine(new Vector2(-52.6389999F, -45.3370018F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-52.7890015F, -45.2890015F));
                    builder.AddLine(new Vector2(-52.875F, -45.2610016F));
                    builder.AddLine(new Vector2(-52.8479996F, -45.2700005F));
                    builder.AddLine(new Vector2(-52.7890015F, -45.2890015F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-52.9350014F, -45.2420006F));
                    builder.AddLine(new Vector2(-53.019001F, -45.2150002F));
                    builder.AddLine(new Vector2(-52.9840012F, -45.2260017F));
                    builder.AddLine(new Vector2(-52.9350014F, -45.2420006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.0800018F, -45.1949997F));
                    builder.AddLine(new Vector2(-53.1629982F, -45.1679993F));
                    builder.AddLine(new Vector2(-53.1199989F, -45.1819992F));
                    builder.AddLine(new Vector2(-53.0800018F, -45.1949997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.223999F, -45.1469994F));
                    builder.AddLine(new Vector2(-53.3079987F, -45.1199989F));
                    builder.AddLine(new Vector2(-53.2560005F, -45.137001F));
                    builder.AddLine(new Vector2(-53.223999F, -45.1469994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.3670006F, -45.0999985F));
                    builder.AddLine(new Vector2(-53.4539986F, -45.0709991F));
                    builder.AddLine(new Vector2(-53.3909988F, -45.0919991F));
                    builder.AddLine(new Vector2(-53.3670006F, -45.0999985F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.5110016F, -45.0519981F));
                    builder.AddLine(new Vector2(-53.605999F, -45.0200005F));
                    builder.AddLine(new Vector2(-53.526001F, -45.0470009F));
                    builder.AddLine(new Vector2(-53.5110016F, -45.0519981F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.6529999F, -45.0040016F));
                    builder.AddLine(new Vector2(-53.7949982F, -44.9550018F));
                    builder.AddLine(new Vector2(-53.6599998F, -45.0009995F));
                    builder.AddLine(new Vector2(-53.6529999F, -45.0040016F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.7949982F, -44.9550018F));
                    builder.AddLine(new Vector2(-53.8079987F, -44.8050003F));
                    builder.AddLine(new Vector2(-53.8079987F, -44.8129997F));
                    builder.AddLine(new Vector2(-53.7949982F, -44.9550018F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8129997F, -44.7560005F));
                    builder.AddLine(new Vector2(-53.8219986F, -44.6559982F));
                    builder.AddLine(new Vector2(-53.8199997F, -44.6710014F));
                    builder.AddLine(new Vector2(-53.8129997F, -44.7560005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8260002F, -44.5970001F));
                    builder.AddLine(new Vector2(-53.8339996F, -44.5050011F));
                    builder.AddLine(new Vector2(-53.8320007F, -44.5299988F));
                    builder.AddLine(new Vector2(-53.8260002F, -44.5970001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8400002F, -44.4430008F));
                    builder.AddLine(new Vector2(-53.8460007F, -44.3549995F));
                    builder.AddLine(new Vector2(-53.8440018F, -44.387001F));
                    builder.AddLine(new Vector2(-53.8400002F, -44.4430008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8510017F, -44.2910004F));
                    builder.AddLine(new Vector2(-53.8580017F, -44.2039986F));
                    builder.AddLine(new Vector2(-53.8549995F, -44.2449989F));
                    builder.AddLine(new Vector2(-53.8510017F, -44.2910004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.862999F, -44.1389999F));
                    builder.AddLine(new Vector2(-53.8689995F, -44.0519981F));
                    builder.AddLine(new Vector2(-53.8660011F, -44.1030006F));
                    builder.AddLine(new Vector2(-53.862999F, -44.1389999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8740005F, -43.987999F));
                    builder.AddLine(new Vector2(-53.8810005F, -43.8979988F));
                    builder.AddLine(new Vector2(-53.8759995F, -43.9599991F));
                    builder.AddLine(new Vector2(-53.8740005F, -43.987999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8849983F, -43.8370018F));
                    builder.AddLine(new Vector2(-53.8909988F, -43.7410011F));
                    builder.AddLine(new Vector2(-53.8860016F, -43.8180008F));
                    builder.AddLine(new Vector2(-53.8849983F, -43.8370018F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8950005F, -43.6860008F));
                    builder.AddLine(new Vector2(-53.9020004F, -43.5699997F));
                    builder.AddLine(new Vector2(-53.8959999F, -43.6749992F));
                    builder.AddLine(new Vector2(-53.8950005F, -43.6860008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9049988F, -43.5349998F));
                    builder.AddLine(new Vector2(-53.9140015F, -43.3839989F));
                    builder.AddCubicBezier(new Vector2(-53.9109993F, -43.4350014F), new Vector2(-53.9080009F, -43.4850006F), new Vector2(-53.9049988F, -43.5349998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9160004F, -43.3450012F));
                    builder.AddLine(new Vector2(-53.9230003F, -43.2330017F));
                    builder.AddLine(new Vector2(-53.9220009F, -43.2449989F));
                    builder.AddLine(new Vector2(-53.9160004F, -43.3450012F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9259987F, -43.1759987F));
                    builder.AddLine(new Vector2(-53.9309998F, -43.0810013F));
                    builder.AddLine(new Vector2(-53.9290009F, -43.1020012F));
                    builder.AddLine(new Vector2(-53.9259987F, -43.1759987F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9339981F, -43.019001F));
                    builder.AddLine(new Vector2(-53.9389992F, -42.9290009F));
                    builder.AddLine(new Vector2(-53.9370003F, -42.9580002F));
                    builder.AddLine(new Vector2(-53.9339981F, -43.019001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9420013F, -42.8650017F));
                    builder.AddLine(new Vector2(-53.9459991F, -42.7770004F));
                    builder.AddLine(new Vector2(-53.9440002F, -42.8149986F));
                    builder.AddLine(new Vector2(-53.9420013F, -42.8650017F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9490013F, -42.7120018F));
                    builder.AddLine(new Vector2(-53.9529991F, -42.6240005F));
                    builder.AddLine(new Vector2(-53.9510002F, -42.6710014F));
                    builder.AddLine(new Vector2(-53.9490013F, -42.7120018F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9550018F, -42.5589981F));
                    builder.AddLine(new Vector2(-53.9589996F, -42.4690018F));
                    builder.AddLine(new Vector2(-53.9570007F, -42.5270004F));
                    builder.AddLine(new Vector2(-53.9550018F, -42.5589981F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9620018F, -42.4059982F));
                    builder.AddLine(new Vector2(-53.9650002F, -42.3129997F));
                    builder.AddLine(new Vector2(-53.9630013F, -42.3829994F));
                    builder.AddLine(new Vector2(-53.9620018F, -42.4059982F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9679985F, -42.2540016F));
                    builder.AddLine(new Vector2(-53.9710007F, -42.1489983F));
                    builder.AddLine(new Vector2(-53.9679985F, -42.2389984F));
                    builder.AddLine(new Vector2(-53.9679985F, -42.2540016F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9729996F, -42.1010017F));
                    builder.AddLine(new Vector2(-53.9780006F, -41.9490013F));
                    builder.AddCubicBezier(new Vector2(-53.9760017F, -41.9990005F), new Vector2(-53.973999F, -42.0499992F), new Vector2(-53.9729996F, -42.1010017F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9780006F, -41.9360008F));
                    builder.AddLine(new Vector2(-53.9819984F, -41.7960014F));
                    builder.AddLine(new Vector2(-53.9819984F, -41.8050003F));
                    builder.AddLine(new Vector2(-53.9780006F, -41.9360008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9840012F, -41.7439995F));
                    builder.AddLine(new Vector2(-53.9860001F, -41.6430016F));
                    builder.AddLine(new Vector2(-53.9860001F, -41.6599998F));
                    builder.AddLine(new Vector2(-53.9840012F, -41.7439995F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.987999F, -41.5830002F));
                    builder.AddLine(new Vector2(-53.9900017F, -41.4889984F));
                    builder.AddLine(new Vector2(-53.9889984F, -41.5149994F));
                    builder.AddLine(new Vector2(-53.987999F, -41.5830002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9910011F, -41.4259987F));
                    builder.AddLine(new Vector2(-53.9920006F, -41.3349991F));
                    builder.AddLine(new Vector2(-53.9920006F, -41.3699989F));
                    builder.AddLine(new Vector2(-53.9910011F, -41.4259987F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.993F, -41.2709999F));
                    builder.AddLine(new Vector2(-53.9949989F, -41.1809998F));
                    builder.AddLine(new Vector2(-53.9939995F, -41.2249985F));
                    builder.AddLine(new Vector2(-53.993F, -41.2709999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9959984F, -41.1160011F));
                    builder.AddLine(new Vector2(-53.9970016F, -41.0250015F));
                    builder.AddLine(new Vector2(-53.9959984F, -41.0789986F));
                    builder.AddLine(new Vector2(-53.9959984F, -41.1160011F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9980011F, -40.9620018F));
                    builder.AddLine(new Vector2(-53.9990005F, -40.868F));
                    builder.AddLine(new Vector2(-53.9980011F, -40.9339981F));
                    builder.AddLine(new Vector2(-53.9980011F, -40.9620018F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9990005F, -40.8079987F));
                    builder.AddLine(new Vector2(-54F, -40.7070007F));
                    builder.AddLine(new Vector2(-53.9990005F, -40.7879982F));
                    builder.AddLine(new Vector2(-53.9990005F, -40.8079987F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-54F, -40.6539993F));
                    builder.AddLine(new Vector2(-54.0009995F, -40.5250015F));
                    builder.AddLine(new Vector2(-54F, -40.6430016F));
                    builder.AddLine(new Vector2(-54F, -40.6539993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-54.0009995F, -40.5F));
                    builder.AddLine(new Vector2(-54.0009995F, -40.3450012F));
                    builder.AddLine(new Vector2(-54.0009995F, -40.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-54.0009995F, -40.3050003F));
                    builder.AddLine(new Vector2(-54F, -40.1899986F));
                    builder.AddLine(new Vector2(-54F, -40.2039986F));
                    builder.AddLine(new Vector2(-54.0009995F, -40.3050003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-54F, -40.1339989F));
                    builder.AddLine(new Vector2(-53.9990005F, -40.0349998F));
                    builder.AddLine(new Vector2(-54F, -40.0579987F));
                    builder.AddLine(new Vector2(-54F, -40.1339989F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9990005F, -39.973999F));
                    builder.AddLine(new Vector2(-53.9980011F, -39.8800011F));
                    builder.AddLine(new Vector2(-53.9980011F, -39.9119987F));
                    builder.AddLine(new Vector2(-53.9990005F, -39.973999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9970016F, -39.8170013F));
                    builder.AddLine(new Vector2(-53.9959984F, -39.723999F));
                    builder.AddLine(new Vector2(-53.9970016F, -39.7649994F));
                    builder.AddLine(new Vector2(-53.9970016F, -39.8170013F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9949989F, -39.6599998F));
                    builder.AddLine(new Vector2(-53.9939995F, -39.5680008F));
                    builder.AddLine(new Vector2(-53.9949989F, -39.6189995F));
                    builder.AddLine(new Vector2(-53.9949989F, -39.6599998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.993F, -39.5050011F));
                    builder.AddLine(new Vector2(-53.9910011F, -39.4099998F));
                    builder.AddLine(new Vector2(-53.9920006F, -39.4720001F));
                    builder.AddLine(new Vector2(-53.993F, -39.5050011F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9900017F, -39.348999F));
                    builder.AddLine(new Vector2(-53.987999F, -39.2480011F));
                    builder.AddLine(new Vector2(-53.9900017F, -39.3250008F));
                    builder.AddLine(new Vector2(-53.9900017F, -39.348999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9869995F, -39.1930008F));
                    builder.AddLine(new Vector2(-53.9840012F, -39.0769997F));
                    builder.AddLine(new Vector2(-53.9869995F, -39.1780014F));
                    builder.AddLine(new Vector2(-53.9869995F, -39.1930008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9830017F, -39.0379982F));
                    builder.AddLine(new Vector2(-53.9790001F, -38.8800011F));
                    builder.AddCubicBezier(new Vector2(-53.9799995F, -38.9329987F), new Vector2(-53.9819984F, -38.9850006F), new Vector2(-53.9830017F, -39.0379982F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9780006F, -38.8699989F));
                    builder.AddLine(new Vector2(-53.973999F, -38.723999F));
                    builder.AddLine(new Vector2(-53.973999F, -38.7360001F));
                    builder.AddLine(new Vector2(-53.9780006F, -38.8699989F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9720001F, -38.6769981F));
                    builder.AddLine(new Vector2(-53.9690018F, -38.5680008F));
                    builder.AddLine(new Vector2(-53.9700012F, -38.5880013F));
                    builder.AddLine(new Vector2(-53.9720001F, -38.6769981F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9669991F, -38.512001F));
                    builder.AddLine(new Vector2(-53.9630013F, -38.4119987F));
                    builder.AddLine(new Vector2(-53.9640007F, -38.4410019F));
                    builder.AddLine(new Vector2(-53.9669991F, -38.512001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9609985F, -38.3510017F));
                    builder.AddLine(new Vector2(-53.9570007F, -38.2540016F));
                    builder.AddLine(new Vector2(-53.9589996F, -38.2929993F));
                    builder.AddLine(new Vector2(-53.9609985F, -38.3510017F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9539986F, -38.1930008F));
                    builder.AddLine(new Vector2(-53.9500008F, -38.0970001F));
                    builder.AddLine(new Vector2(-53.9519997F, -38.1450005F));
                    builder.AddLine(new Vector2(-53.9539986F, -38.1930008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9480019F, -38.0349998F));
                    builder.AddLine(new Vector2(-53.9440002F, -37.9370003F));
                    builder.AddLine(new Vector2(-53.9459991F, -37.9970016F));
                    builder.AddLine(new Vector2(-53.9480019F, -38.0349998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9410019F, -37.8779984F));
                    builder.AddLine(new Vector2(-53.9360008F, -37.7750015F));
                    builder.AddLine(new Vector2(-53.9389992F, -37.848999F));
                    builder.AddLine(new Vector2(-53.9410019F, -37.8779984F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9329987F, -37.7210007F));
                    builder.AddLine(new Vector2(-53.9269981F, -37.6069984F));
                    builder.AddLine(new Vector2(-53.9319992F, -37.7000008F));
                    builder.AddLine(new Vector2(-53.9329987F, -37.7210007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9160004F, -37.4070015F));
                    builder.AddLine(new Vector2(-53.9070015F, -37.2459984F));
                    builder.AddLine(new Vector2(-53.9249992F, -37.5639992F));
                    builder.AddLine(new Vector2(-53.9160004F, -37.4070015F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.9059982F, -37.2169991F));
                    builder.AddLine(new Vector2(-53.8979988F, -37.0880013F));
                    builder.AddLine(new Vector2(-53.8989983F, -37.105999F));
                    builder.AddLine(new Vector2(-53.9059982F, -37.2169991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8950005F, -37.0400009F));
                    builder.AddLine(new Vector2(-53.8880005F, -36.9300003F));
                    builder.AddLine(new Vector2(-53.8889999F, -36.9570007F));
                    builder.AddLine(new Vector2(-53.8950005F, -37.0400009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8839989F, -36.8759995F));
                    builder.AddLine(new Vector2(-53.8769989F, -36.7719994F));
                    builder.AddLine(new Vector2(-53.8800011F, -36.8079987F));
                    builder.AddLine(new Vector2(-53.8839989F, -36.8759995F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8730011F, -36.7150002F));
                    builder.AddLine(new Vector2(-53.8660011F, -36.612999F));
                    builder.AddLine(new Vector2(-53.8699989F, -36.6590004F));
                    builder.AddLine(new Vector2(-53.8730011F, -36.7150002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.862999F, -36.5550003F));
                    builder.AddLine(new Vector2(-53.8549995F, -36.4519997F));
                    builder.AddLine(new Vector2(-53.8590012F, -36.5099983F));
                    builder.AddLine(new Vector2(-53.862999F, -36.5550003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8510017F, -36.3959999F));
                    builder.AddLine(new Vector2(-53.8429985F, -36.2890015F));
                    builder.AddLine(new Vector2(-53.8479996F, -36.3610001F));
                    builder.AddLine(new Vector2(-53.8510017F, -36.3959999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8390007F, -36.237999F));
                    builder.AddLine(new Vector2(-53.8300018F, -36.1209984F));
                    builder.AddLine(new Vector2(-53.8370018F, -36.2109985F));
                    builder.AddLine(new Vector2(-53.8390007F, -36.237999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.8269997F, -36.0789986F));
                    builder.AddLine(new Vector2(-53.8149986F, -35.9329987F));
                    builder.AddLine(new Vector2(-53.8250008F, -36.0620003F));
                    builder.AddLine(new Vector2(-53.8269997F, -36.0789986F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.7999992F, -35.757F));
                    builder.AddLine(new Vector2(-53.7859993F, -35.5970001F));
                    builder.AddCubicBezier(new Vector2(-53.7960014F, -35.7050018F), new Vector2(-53.8050003F, -35.8129997F), new Vector2(-53.8139992F, -35.9210014F));
                    builder.AddLine(new Vector2(-53.7999992F, -35.757F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.7830009F, -35.5649986F));
                    builder.AddLine(new Vector2(-53.7719994F, -35.4370003F));
                    builder.AddLine(new Vector2(-53.7739983F, -35.4620018F));
                    builder.AddLine(new Vector2(-53.7830009F, -35.5649986F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.7680016F, -35.3930016F));
                    builder.AddLine(new Vector2(-53.7579994F, -35.2770004F));
                    builder.AddLine(new Vector2(-53.7610016F, -35.3120003F));
                    builder.AddLine(new Vector2(-53.7680016F, -35.3930016F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.7529984F, -35.2280006F));
                    builder.AddLine(new Vector2(-53.7420006F, -35.1160011F));
                    builder.AddLine(new Vector2(-53.7470016F, -35.1619987F));
                    builder.AddLine(new Vector2(-53.7529984F, -35.2280006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.737999F, -35.0660019F));
                    builder.AddLine(new Vector2(-53.7260017F, -34.9539986F));
                    builder.AddLine(new Vector2(-53.7319984F, -35.012001F));
                    builder.AddLine(new Vector2(-53.737999F, -35.0660019F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.7210007F, -34.9049988F));
                    builder.AddLine(new Vector2(-53.7099991F, -34.7900009F));
                    builder.AddLine(new Vector2(-53.7169991F, -34.8610001F));
                    builder.AddLine(new Vector2(-53.7210007F, -34.9049988F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.7050018F, -34.7439995F));
                    builder.AddLine(new Vector2(-53.6930008F, -34.6209984F));
                    builder.AddLine(new Vector2(-53.7019997F, -34.7109985F));
                    builder.AddLine(new Vector2(-53.7050018F, -34.7439995F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.6889992F, -34.5839996F));
                    builder.AddLine(new Vector2(-53.6730003F, -34.4379997F));
                    builder.AddLine(new Vector2(-53.6860008F, -34.5600014F));
                    builder.AddLine(new Vector2(-53.6889992F, -34.5839996F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.6539993F, -34.2599983F));
                    builder.AddLine(new Vector2(-53.6349983F, -34.0929985F));
                    builder.AddCubicBezier(new Vector2(-53.6469994F, -34.2039986F), new Vector2(-53.6599998F, -34.3139992F), new Vector2(-53.6720009F, -34.4249992F));
                    builder.AddLine(new Vector2(-53.6539993F, -34.2599983F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.6349983F, -34.0919991F));
                    builder.AddLine(new Vector2(-53.6160011F, -33.9319992F));
                    builder.AddLine(new Vector2(-53.6189995F, -33.9560013F));
                    builder.AddLine(new Vector2(-53.6349983F, -34.0919991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.612999F, -33.9049988F));
                    builder.AddLine(new Vector2(-53.5970001F, -33.7709999F));
                    builder.AddLine(new Vector2(-53.6010017F, -33.8050003F));
                    builder.AddLine(new Vector2(-53.612999F, -33.9049988F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.5929985F, -33.7340012F));
                    builder.AddLine(new Vector2(-53.5779991F, -33.6090012F));
                    builder.AddLine(new Vector2(-53.5830002F, -33.6539993F));
                    builder.AddLine(new Vector2(-53.5929985F, -33.7340012F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.5730019F, -33.5680008F));
                    builder.AddLine(new Vector2(-53.5569992F, -33.4449997F));
                    builder.AddLine(new Vector2(-53.5649986F, -33.5029984F));
                    builder.AddLine(new Vector2(-53.5730019F, -33.5680008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.5530014F, -33.4039993F));
                    builder.AddLine(new Vector2(-53.5369987F, -33.2789993F));
                    builder.AddLine(new Vector2(-53.5460014F, -33.3510017F));
                    builder.AddLine(new Vector2(-53.5530014F, -33.4039993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.5320015F, -33.2420006F));
                    builder.AddLine(new Vector2(-53.5149994F, -33.1090012F));
                    builder.AddLine(new Vector2(-53.5270004F, -33.2000008F));
                    builder.AddLine(new Vector2(-53.5320015F, -33.2420006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.5110016F, -33.0800018F));
                    builder.AddLine(new Vector2(-53.4910011F, -32.9280014F));
                    builder.AddLine(new Vector2(-53.507F, -33.0480003F));
                    builder.AddLine(new Vector2(-53.5110016F, -33.0800018F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.4900017F, -32.9189987F));
                    builder.AddCubicBezier(new Vector2(-53.4599991F, -32.6980019F), new Vector2(-53.4290009F, -32.4760017F), new Vector2(-53.3969994F, -32.2540016F));
                    builder.AddCubicBezier(new Vector2(-53.4290009F, -32.4760017F), new Vector2(-53.4599991F, -32.6980019F), new Vector2(-53.4900017F, -32.9189987F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.3950005F, -32.2350006F));
                    builder.AddLine(new Vector2(-53.3730011F, -32.0900002F));
                    builder.AddLine(new Vector2(-53.3800011F, -32.1360016F));
                    builder.AddLine(new Vector2(-53.3950005F, -32.2350006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.3699989F, -32.0639992F));
                    builder.AddLine(new Vector2(-53.348999F, -31.9249992F));
                    builder.AddLine(new Vector2(-53.3580017F, -31.9839993F));
                    builder.AddLine(new Vector2(-53.3699989F, -32.0639992F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.3450012F, -31.8969994F));
                    builder.AddLine(new Vector2(-53.3240013F, -31.757F));
                    builder.AddLine(new Vector2(-53.3349991F, -31.8309994F));
                    builder.AddLine(new Vector2(-53.3450012F, -31.8969994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.3199997F, -31.7320004F));
                    builder.AddLine(new Vector2(-53.2970009F, -31.5849991F));
                    builder.AddLine(new Vector2(-53.3120003F, -31.6790009F));
                    builder.AddLine(new Vector2(-53.3199997F, -31.7320004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.2949982F, -31.5690002F));
                    builder.AddCubicBezier(new Vector2(-53.2420006F, -31.2329998F), new Vector2(-53.1870003F, -30.8969994F), new Vector2(-53.1300011F, -30.5610008F));
                    builder.AddCubicBezier(new Vector2(-53.1870003F, -30.8969994F), new Vector2(-53.2420006F, -31.2329998F), new Vector2(-53.2949982F, -31.5690002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.1290016F, -30.5559998F));
                    builder.AddLine(new Vector2(-53.0999985F, -30.3939991F));
                    builder.AddLine(new Vector2(-53.1110001F, -30.4549999F));
                    builder.AddLine(new Vector2(-53.1290016F, -30.5559998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.098999F, -30.3850002F));
                    builder.AddLine(new Vector2(-53.0709991F, -30.2250004F));
                    builder.AddLine(new Vector2(-53.0839996F, -30.302F));
                    builder.AddLine(new Vector2(-53.098999F, -30.3850002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-53.0690002F, -30.2159996F));
                    builder.AddLine(new Vector2(-53.0400009F, -30.0510006F));
                    builder.AddLine(new Vector2(-53.0569992F, -30.1480007F));
                    builder.AddLine(new Vector2(-53.0690002F, -30.2159996F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-39.137001F, -47.7610016F));
                    builder.AddCubicBezier(new Vector2(-17.7870007F, -49.0750008F), new Vector2(8.54500008F, -40.1969986F), new Vector2(31.8129997F, -21.9330006F));
                    builder.AddCubicBezier(new Vector2(40.3959999F, -15.1960001F), new Vector2(47.8370018F, -7.75F), new Vector2(54.0009995F, 0.0209999997F));
                    builder.AddCubicBezier(new Vector2(44.9980011F, 20.2929993F), new Vector2(32.026001F, 36.5040016F), new Vector2(15.4960003F, 49.0750008F));
                    builder.AddCubicBezier(new Vector2(6.4829998F, 44.9329987F), new Vector2(-2.51600003F, 39.4729996F), new Vector2(-11.099F, 32.7360001F));
                    builder.AddCubicBezier(new Vector2(-34.3660011F, 14.4720001F), new Vector2(-49.2449989F, -8.9989996F), new Vector2(-53.0390015F, -30.0499992F));
                    builder.AddCubicBezier(new Vector2(-52.6619987F, -27.9559994F), new Vector2(-52.1749992F, -25.8379993F), new Vector2(-51.5810013F, -23.7040005F));
                    builder.AddCubicBezier(new Vector2(-46.6170006F, -25.3540001F), new Vector2(-42.0219994F, -28.4710007F), new Vector2(-38.5040016F, -32.9519997F));
                    builder.AddCubicBezier(new Vector2(-34.9869995F, -37.4339981F), new Vector2(-33.0509987F, -42.6380005F), new Vector2(-32.6259995F, -47.8510017F));
                    builder.AddCubicBezier(new Vector2(-34.8409996F, -47.9210014F), new Vector2(-37.0130005F, -47.8919983F), new Vector2(-39.137001F, -47.7610016F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 11 Offset:<148.225, 119.509>
            CanvasGeometry Geometry_20()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-31.3659992F, -41.0139999F));
                    builder.AddLine(new Vector2(45.0359993F, 18.9589996F));
                    builder.AddCubicBezier(new Vector2(38.5250015F, 27.2889996F), new Vector2(31.0389996F, 34.6220016F), new Vector2(22.6340008F, 41.0139999F));
                    builder.AddCubicBezier(new Vector2(13.6210003F, 36.8720016F), new Vector2(4.62200022F, 31.4120007F), new Vector2(-3.96099997F, 24.6749992F));
                    builder.AddCubicBezier(new Vector2(-24.5540009F, 8.51000023F), new Vector2(-38.5750008F, -11.7340002F), new Vector2(-44.1580009F, -30.7679996F));
                    builder.AddCubicBezier(new Vector2(-44.8829994F, -33.2410011F), new Vector2(-45.0369987F, -33.8989983F), new Vector2(-44.4430008F, -31.7649994F));
                    builder.AddCubicBezier(new Vector2(-39.4790001F, -33.4150009F), new Vector2(-34.8839989F, -36.5330009F), new Vector2(-31.3659992F, -41.0139999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 10 Offset:<111.845, 75.548>
            CanvasGeometry Geometry_21()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(10.8929996F, -11.9519997F));
                    builder.AddCubicBezier(new Vector2(3.23200011F, -12.1949997F), new Vector2(-3.93400002F, -11.2410002F), new Vector2(-10.2770004F, -9.05599976F));
                    builder.AddCubicBezier(new Vector2(-10.8929996F, -2.37599993F), new Vector2(-10.1169996F, 4.81099987F), new Vector2(-8.06200027F, 12.1949997F));
                    builder.AddCubicBezier(new Vector2(-3.09800005F, 10.5450001F), new Vector2(1.49600005F, 7.42799997F), new Vector2(5.01399994F, 2.94700003F));
                    builder.AddCubicBezier(new Vector2(8.53199959F, -1.53499997F), new Vector2(10.4689999F, -6.73899984F), new Vector2(10.8929996F, -11.9519997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 9 Offset:<108.906, 77.118>
            CanvasGeometry Geometry_22()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-7.33699989F, -10.6260004F));
                    builder.AddCubicBezier(new Vector2(-7.95300007F, -3.9460001F), new Vector2(-7.1789999F, 3.2420001F), new Vector2(-5.12400007F, 10.6260004F));
                    builder.AddCubicBezier(new Vector2(-0.159999996F, 8.97599983F), new Vector2(4.43599987F, 5.85900021F), new Vector2(7.954F, 1.37800002F));
                    builder.AddLine(new Vector2(-7.33699989F, -10.6260004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 8 Offset:<169.871, 120.106>
            CanvasGeometry Geometry_23()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-12.5450001F, -9.84700012F));
                    builder.AddCubicBezier(new Vector2(-18.2169991F, -2.62100005F), new Vector2(-17.2000008F, 7.65700006F), new Vector2(-10.2770004F, 13.092F));
                    builder.AddCubicBezier(new Vector2(-3.35299993F, 18.5270004F), new Vector2(6.87300014F, 17.073F), new Vector2(12.5450001F, 9.84700012F));
                    builder.AddCubicBezier(new Vector2(18.2169991F, 2.62100005F), new Vector2(17.2000008F, -7.65700006F), new Vector2(10.2770004F, -13.092F));
                    builder.AddCubicBezier(new Vector2(3.35299993F, -18.5270004F), new Vector2(-6.87300014F, -17.073F), new Vector2(-12.5450001F, -9.84700012F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 7 Offset:<167.035, 124.446>
            CanvasGeometry Geometry_24()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-9.70899963F, -14.1870003F));
                    builder.AddCubicBezier(new Vector2(-15.3809996F, -6.96099997F), new Vector2(-14.3640003F, 3.31699991F), new Vector2(-7.44099998F, 8.75199986F));
                    builder.AddCubicBezier(new Vector2(-0.51700002F, 14.1870003F), new Vector2(9.70899963F, 12.7329998F), new Vector2(15.3809996F, 5.50699997F));
                    builder.AddLine(new Vector2(-9.70899963F, -14.1870003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 6 Offset:<169.871, 120.106>
            CanvasGeometry Geometry_25()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(9.65799999F, 7.58099985F));
                    builder.AddCubicBezier(new Vector2(14.0240002F, 2.01799989F), new Vector2(13.2419996F, -5.89499998F), new Vector2(7.91200018F, -10.0790005F));
                    builder.AddCubicBezier(new Vector2(2.58100009F, -14.2629995F), new Vector2(-5.29099989F, -13.1440001F), new Vector2(-9.65799999F, -7.58099985F));
                    builder.AddCubicBezier(new Vector2(-14.0240002F, -2.01799989F), new Vector2(-13.2419996F, 5.89499998F), new Vector2(-7.91099977F, 10.0790005F));
                    builder.AddCubicBezier(new Vector2(-2.58100009F, 14.2629995F), new Vector2(5.29099989F, 13.1440001F), new Vector2(9.65799999F, 7.58099985F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 5 Offset:<167.688, 123.447>
            CanvasGeometry Geometry_26()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-7.4749999F, -10.9219999F));
                    builder.AddCubicBezier(new Vector2(-11.8409996F, -5.35900021F), new Vector2(-11.059F, 2.5539999F), new Vector2(-5.72800016F, 6.73799992F));
                    builder.AddCubicBezier(new Vector2(-0.398000002F, 10.9219999F), new Vector2(7.47399998F, 9.80300045F), new Vector2(11.8409996F, 4.23999977F));
                    builder.AddLine(new Vector2(-7.4749999F, -10.9219999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 4 Offset:<138.946, 95.832>
            CanvasGeometry Geometry_27()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-12.5439997F, -9.84700012F));
                    builder.AddCubicBezier(new Vector2(-18.2159996F, -2.62199998F), new Vector2(-17.2010002F, 7.65700006F), new Vector2(-10.2770004F, 13.092F));
                    builder.AddCubicBezier(new Vector2(-3.35299993F, 18.5270004F), new Vector2(6.87300014F, 17.073F), new Vector2(12.5439997F, 9.84700012F));
                    builder.AddCubicBezier(new Vector2(18.2159996F, 2.62100005F), new Vector2(17.2010002F, -7.65799999F), new Vector2(10.2770004F, -13.092F));
                    builder.AddCubicBezier(new Vector2(3.35400009F, -18.5270004F), new Vector2(-6.87200022F, -17.073F), new Vector2(-12.5439997F, -9.84700012F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 3 Offset:<136.11, 100.172>
            CanvasGeometry Geometry_28()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-9.70800018F, -14.1870003F));
                    builder.AddCubicBezier(new Vector2(-15.3800001F, -6.96199989F), new Vector2(-14.3640003F, 3.31699991F), new Vector2(-7.44099998F, 8.75199986F));
                    builder.AddCubicBezier(new Vector2(-0.51700002F, 14.1870003F), new Vector2(9.70899963F, 12.7329998F), new Vector2(15.3800001F, 5.50699997F));
                    builder.AddLine(new Vector2(-9.70800018F, -14.1870003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 2 Offset:<138.947, 95.832>
            CanvasGeometry Geometry_29()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(9.65799999F, 7.58099985F));
                    builder.AddCubicBezier(new Vector2(14.0249996F, 2.01799989F), new Vector2(13.2410002F, -5.89499998F), new Vector2(7.91099977F, -10.0790005F));
                    builder.AddCubicBezier(new Vector2(2.58100009F, -14.2629995F), new Vector2(-5.29199982F, -13.1440001F), new Vector2(-9.65799999F, -7.58099985F));
                    builder.AddCubicBezier(new Vector2(-14.0249996F, -2.01799989F), new Vector2(-13.2410002F, 5.89499998F), new Vector2(-7.91099977F, 10.0790005F));
                    builder.AddCubicBezier(new Vector2(-2.58100009F, 14.2629995F), new Vector2(5.29199982F, 13.1429996F), new Vector2(9.65799999F, 7.58099985F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - ShapeGroup: Group 1 Offset:<136.763, 99.173>
            CanvasGeometry Geometry_30()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-7.47399998F, -10.9219999F));
                    builder.AddCubicBezier(new Vector2(-11.8409996F, -5.35900021F), new Vector2(-11.0579996F, 2.5539999F), new Vector2(-5.72800016F, 6.73799992F));
                    builder.AddCubicBezier(new Vector2(-0.398000002F, 10.9219999F), new Vector2(7.4749999F, 9.80200005F), new Vector2(11.8409996F, 4.23999977F));
                    builder.AddLine(new Vector2(-7.47399998F, -10.9219999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 1 Offset:<249.659, 251.362>
            CanvasGeometry Geometry_31()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-38.8950005F, -6F));
                    builder.AddCubicBezier(new Vector2(-32.3089981F, -6.64599991F), new Vector2(-25.6739998F, -6.88899994F), new Vector2(-19.0270004F, -6.83500004F));
                    builder.AddCubicBezier(new Vector2(-15.7049999F, -6.78100014F), new Vector2(-12.3789997F, -6.65299988F), new Vector2(-9.05500031F, -6.42700005F));
                    builder.AddCubicBezier(new Vector2(-5.73500013F, -6.17299986F), new Vector2(-2.41700006F, -5.83500004F), new Vector2(0.893000007F, -5.40899992F));
                    builder.AddCubicBezier(new Vector2(4.20699978F, -5.0170002F), new Vector2(7.52099991F, -4.51300001F), new Vector2(10.8199997F, -3.98600006F));
                    builder.AddCubicBezier(new Vector2(14.1110001F, -3.4230001F), new Vector2(17.3630009F, -2.64700007F), new Vector2(20.5480003F, -1.64600003F));
                    builder.AddCubicBezier(new Vector2(26.9239998F, 0.363999993F), new Vector2(33.0880013F, 2.98699999F), new Vector2(38.8950005F, 6.3670001F));
                    builder.AddLine(new Vector2(38.737999F, 6.84200001F));
                    builder.AddCubicBezier(new Vector2(35.3829994F, 6.49700022F), new Vector2(32.098999F, 5.85699987F), new Vector2(28.882F, 5.204F));
                    builder.AddCubicBezier(new Vector2(25.6550007F, 4.55600023F), new Vector2(22.4510002F, 3.88599992F), new Vector2(19.2609997F, 3.18499994F));
                    builder.AddCubicBezier(new Vector2(16.0720005F, 2.48300004F), new Vector2(12.9090004F, 1.70700002F), new Vector2(9.75599957F, 0.848999977F));
                    builder.AddCubicBezier(new Vector2(6.6079998F, -0.0250000004F), new Vector2(3.44799995F, -0.809000015F), new Vector2(0.246000007F, -1.46200001F));
                    builder.AddCubicBezier(new Vector2(-6.15899992F, -2.72099996F), new Vector2(-12.6409998F, -3.68099999F), new Vector2(-19.1700001F, -4.33900023F));
                    builder.AddCubicBezier(new Vector2(-25.698F, -5.06099987F), new Vector2(-32.2750015F, -5.34800005F), new Vector2(-38.875F, -5.5F));
                    builder.AddLine(new Vector2(-38.8950005F, -6F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 30 Offset:<335.808, 343.415>
            CanvasGeometry Geometry_32()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(29.3880005F, -131.414993F));
                    builder.AddCubicBezier(new Vector2(24.4080009F, -128.048004F), new Vector2(19.7350006F, -124.245003F), new Vector2(15.4300003F, -120.074997F));
                    builder.AddCubicBezier(new Vector2(11.1120005F, -115.918999F), new Vector2(7.15100002F, -111.402F), new Vector2(3.61599994F, -106.579002F));
                    builder.AddCubicBezier(new Vector2(-3.44000006F, -96.9489975F), new Vector2(-8.87800026F, -86.0449982F), new Vector2(-11.8909998F, -74.5820007F));
                    builder.AddCubicBezier(new Vector2(-12.5559998F, -71.697998F), new Vector2(-13.1730003F, -68.7959976F), new Vector2(-13.4420004F, -65.8529968F));
                    builder.AddCubicBezier(new Vector2(-13.6459999F, -64.3889999F), new Vector2(-13.6619997F, -62.9119987F), new Vector2(-13.7609997F, -61.4420013F));
                    builder.AddCubicBezier(new Vector2(-13.776F, -60.7070007F), new Vector2(-13.757F, -59.9710007F), new Vector2(-13.7580004F, -59.2350006F));
                    builder.AddCubicBezier(new Vector2(-13.7650003F, -58.5F), new Vector2(-13.7469997F, -57.7659988F), new Vector2(-13.6759996F, -57.0349998F));
                    builder.AddCubicBezier(new Vector2(-13.5640001F, -54.0960007F), new Vector2(-13.0010004F, -51.2099991F), new Vector2(-12.2799997F, -48.3959999F));
                    builder.AddCubicBezier(new Vector2(-11.5019999F, -45.5890007F), new Vector2(-10.3170004F, -42.9339981F), new Vector2(-8.88199997F, -40.4379997F));
                    builder.AddCubicBezier(new Vector2(-7.31500006F, -38.026001F), new Vector2(-5.50099993F, -35.7789993F), new Vector2(-3.30599999F, -33.9259987F));
                    builder.AddCubicBezier(new Vector2(-1.13699996F, -32.0509987F), new Vector2(1.35300004F, -30.5529995F), new Vector2(3.98200011F, -29.2999992F));
                    builder.AddCubicBezier(new Vector2(9.25800037F, -26.7940006F), new Vector2(15.0480003F, -25.2719994F), new Vector2(20.8050003F, -23.3619995F));
                    builder.AddCubicBezier(new Vector2(23.6860008F, -22.4069996F), new Vector2(26.5750008F, -21.3540001F), new Vector2(29.3810005F, -20.0189991F));
                    builder.AddCubicBezier(new Vector2(32.1920013F, -18.6879997F), new Vector2(34.8709984F, -17.0480003F), new Vector2(37.3520012F, -15.177F));
                    builder.AddCubicBezier(new Vector2(42.3260002F, -11.4250002F), new Vector2(46.5F, -6.76100016F), new Vector2(50.0499992F, -1.75100005F));
                    builder.AddCubicBezier(new Vector2(53.5800018F, 3.28299999F), new Vector2(56.5880013F, 8.63000011F), new Vector2(59.0089989F, 14.2959995F));
                    builder.AddCubicBezier(new Vector2(61.4160004F, 19.9540005F), new Vector2(63.1749992F, 25.9519997F), new Vector2(63.8419991F, 32.1720009F));
                    builder.AddCubicBezier(new Vector2(64.1399994F, 35.2830009F), new Vector2(64.1679993F, 38.4389992F), new Vector2(63.8219986F, 41.5810013F));
                    builder.AddCubicBezier(new Vector2(63.4539986F, 44.7229996F), new Vector2(62.6590004F, 47.8240013F), new Vector2(61.4990005F, 50.7859993F));
                    builder.AddCubicBezier(new Vector2(59.1570015F, 56.730999F), new Vector2(55.0169983F, 61.8769989F), new Vector2(50.0349998F, 65.7220001F));
                    builder.AddCubicBezier(new Vector2(47.5620003F, 67.689003F), new Vector2(44.8230019F, 69.2529984F), new Vector2(42.0299988F, 70.6620026F));
                    builder.AddCubicBezier(new Vector2(39.2080002F, 72.0240021F), new Vector2(36.2630005F, 73.0820007F), new Vector2(33.2700005F, 73.9550018F));
                    builder.AddCubicBezier(new Vector2(27.2520008F, 75.572998F), new Vector2(20.9920006F, 76.2870026F), new Vector2(14.7609997F, 75.8740005F));
                    builder.AddCubicBezier(new Vector2(11.6499996F, 75.6699982F), new Vector2(8.55300045F, 75.2279968F), new Vector2(5.52799988F, 74.4779968F));
                    builder.AddCubicBezier(new Vector2(4.00099993F, 74.1569977F), new Vector2(2.51999998F, 73.6579971F), new Vector2(1.02400005F, 73.2190018F));
                    builder.AddCubicBezier(new Vector2(-0.437999994F, 72.6719971F), new Vector2(-1.92900002F, 72.2020035F), new Vector2(-3.34500003F, 71.5309982F));
                    builder.AddCubicBezier(new Vector2(-6.22800016F, 70.3219986F), new Vector2(-8.97099972F, 68.7630005F), new Vector2(-11.5570002F, 66.9720001F));
                    builder.AddCubicBezier(new Vector2(-14.1660004F, 65.2099991F), new Vector2(-16.5189991F, 63.0499992F), new Vector2(-18.6229992F, 60.6749992F));
                    builder.AddCubicBezier(new Vector2(-22.8430004F, 55.9269981F), new Vector2(-25.6350002F, 49.7970009F), new Vector2(-26.4829998F, 43.5200005F));
                    builder.AddCubicBezier(new Vector2(-26.9360008F, 40.3829994F), new Vector2(-26.9850006F, 37.2169991F), new Vector2(-26.7320004F, 34.0979996F));
                    builder.AddCubicBezier(new Vector2(-26.4869995F, 30.9729996F), new Vector2(-25.8990002F, 27.8689995F), new Vector2(-24.9829998F, 24.8570004F));
                    builder.AddCubicBezier(new Vector2(-23.1660004F, 18.8500004F), new Vector2(-19.8899994F, 13.132F), new Vector2(-15.073F, 8.86400032F));
                    builder.AddCubicBezier(new Vector2(-12.6730003F, 6.74399996F), new Vector2(-9.83699989F, 5.04199982F), new Vector2(-6.84800005F, 3.8900001F));
                    builder.AddCubicBezier(new Vector2(-3.83899999F, 2.76600003F), new Vector2(-0.644999981F, 2.14700007F), new Vector2(2.57999992F, 2.0999999F));
                    builder.AddCubicBezier(new Vector2(5.80200005F, 2.10100007F), new Vector2(9.06999969F, 2.68199992F), new Vector2(12.0740004F, 4.00899982F));
                    builder.AddCubicBezier(new Vector2(15.0699997F, 5.3670001F), new Vector2(17.7110004F, 7.44999981F), new Vector2(19.7460003F, 9.98799992F));
                    builder.AddCubicBezier(new Vector2(21.7980003F, 12.526F), new Vector2(23.1989994F, 15.4879999F), new Vector2(24.1019993F, 18.5179996F));
                    builder.AddCubicBezier(new Vector2(25.0139999F, 21.5540009F), new Vector2(25.4650002F, 24.6720009F), new Vector2(25.6159992F, 27.7730007F));
                    builder.AddCubicBezier(new Vector2(25.7619991F, 30.8780003F), new Vector2(25.6079998F, 33.9729996F), new Vector2(25.2299995F, 37.0289993F));
                    builder.AddCubicBezier(new Vector2(24.8349991F, 40.0639992F), new Vector2(24.2940006F, 43.0680008F), new Vector2(23.6149998F, 46.0449982F));
                    builder.AddCubicBezier(new Vector2(22.2189999F, 51.9860001F), new Vector2(20.2759991F, 57.7980003F), new Vector2(17.743F, 63.3409996F));
                    builder.AddCubicBezier(new Vector2(15.2419996F, 68.8980026F), new Vector2(12.1590004F, 74.1839981F), new Vector2(8.62699986F, 79.137001F));
                    builder.AddCubicBezier(new Vector2(5.03999996F, 84.052002F), new Vector2(1.03600001F, 88.6419983F), new Vector2(-3.3039999F, 92.8720016F));
                    builder.AddCubicBezier(new Vector2(-7.63700008F, 97.1159973F), new Vector2(-12.3649998F, 100.917F), new Vector2(-17.2199993F, 104.500999F));
                    builder.AddCubicBezier(new Vector2(-22.0849991F, 108.081001F), new Vector2(-27.1380005F, 111.384003F), new Vector2(-32.3139992F, 114.464996F));
                    builder.AddCubicBezier(new Vector2(-37.4850006F, 117.554001F), new Vector2(-42.7410011F, 120.490997F), new Vector2(-48.0699997F, 123.278999F));
                    builder.AddCubicBezier(new Vector2(-53.4049988F, 126.057999F), new Vector2(-58.7820015F, 128.746002F), new Vector2(-64.1689987F, 131.414993F));
                    builder.AddCubicBezier(new Vector2(-58.875F, 128.567001F), new Vector2(-53.5909996F, 125.699997F), new Vector2(-48.3590012F, 122.748001F));
                    builder.AddCubicBezier(new Vector2(-43.1119995F, 119.821999F), new Vector2(-37.9399986F, 116.768997F), new Vector2(-32.8709984F, 113.563004F));
                    builder.AddCubicBezier(new Vector2(-27.7959995F, 110.366997F), new Vector2(-22.8570004F, 106.959999F), new Vector2(-18.1299992F, 103.293999F));
                    builder.AddCubicBezier(new Vector2(-13.4090004F, 99.625F), new Vector2(-8.8380003F, 95.7559967F), new Vector2(-4.68400002F, 91.4779968F));
                    builder.AddCubicBezier(new Vector2(-0.501999974F, 87.2330017F), new Vector2(3.36500001F, 82.6920013F), new Vector2(6.78900003F, 77.8379974F));
                    builder.AddCubicBezier(new Vector2(10.1599998F, 72.9530029F), new Vector2(13.0839996F, 67.7590027F), new Vector2(15.434F, 62.3149986F));
                    builder.AddCubicBezier(new Vector2(17.816F, 56.887001F), new Vector2(19.6159992F, 51.2120018F), new Vector2(20.8799992F, 45.4339981F));
                    builder.AddCubicBezier(new Vector2(22.0830002F, 39.6389999F), new Vector2(22.9290009F, 33.737999F), new Vector2(22.5429993F, 27.9419994F));
                    builder.AddCubicBezier(new Vector2(22.3600006F, 25.0480003F), new Vector2(21.8929996F, 22.1819992F), new Vector2(21.0330009F, 19.4720001F));
                    builder.AddCubicBezier(new Vector2(20.1800003F, 16.7630005F), new Vector2(18.9090004F, 14.2119999F), new Vector2(17.1399994F, 12.0970001F));
                    builder.AddCubicBezier(new Vector2(15.3839998F, 9.97999954F), new Vector2(13.1759996F, 8.25500011F), new Vector2(10.6870003F, 7.1500001F));
                    builder.AddCubicBezier(new Vector2(8.17599964F, 6.06599998F), new Vector2(5.39799976F, 5.58599997F), new Vector2(2.61800003F, 5.60400009F));
                    builder.AddCubicBezier(new Vector2(-0.166999996F, 5.66900015F), new Vector2(-2.9519999F, 6.23000002F), new Vector2(-5.56500006F, 7.22800016F));
                    builder.AddCubicBezier(new Vector2(-8.17399979F, 8.2670002F), new Vector2(-10.5570002F, 9.71700001F), new Vector2(-12.6520004F, 11.5909996F));
                    builder.AddCubicBezier(new Vector2(-16.8339996F, 15.3549995F), new Vector2(-19.7460003F, 20.4659996F), new Vector2(-21.3560009F, 25.9500008F));
                    builder.AddCubicBezier(new Vector2(-22.9570007F, 31.4300003F), new Vector2(-23.4650002F, 37.3400002F), new Vector2(-22.6609993F, 42.9659996F));
                    builder.AddCubicBezier(new Vector2(-22.2360001F, 45.7719994F), new Vector2(-21.5109997F, 48.5289993F), new Vector2(-20.2800007F, 51.0540009F));
                    builder.AddCubicBezier(new Vector2(-19.0939999F, 53.5909996F), new Vector2(-17.5919991F, 56.0079994F), new Vector2(-15.6800003F, 58.1030006F));
                    builder.AddCubicBezier(new Vector2(-13.8000002F, 60.2099991F), new Vector2(-11.6890001F, 62.1529999F), new Vector2(-9.30700016F, 63.7470016F));
                    builder.AddCubicBezier(new Vector2(-6.95300007F, 65.3679962F), new Vector2(-4.43900013F, 66.7949982F), new Vector2(-1.77400005F, 67.901001F));
                    builder.AddCubicBezier(new Vector2(-0.470999986F, 68.5189972F), new Vector2(0.915000021F, 68.9449997F), new Vector2(2.26600003F, 69.4509964F));
                    builder.AddCubicBezier(new Vector2(3.6559999F, 69.8519974F), new Vector2(5.02699995F, 70.314003F), new Vector2(6.4460001F, 70.6060028F));
                    builder.AddCubicBezier(new Vector2(9.25500011F, 71.2990036F), new Vector2(12.1359997F, 71.6930008F), new Vector2(15.0179996F, 71.8850021F));
                    builder.AddCubicBezier(new Vector2(20.7870007F, 72.2850037F), new Vector2(26.6280003F, 71.6330032F), new Vector2(32.2179985F, 70.1470032F));
                    builder.AddCubicBezier(new Vector2(34.9959984F, 69.3410034F), new Vector2(37.7260017F, 68.3710022F), new Vector2(40.3240013F, 67.1240005F));
                    builder.AddCubicBezier(new Vector2(42.8909988F, 65.8330002F), new Vector2(45.4059982F, 64.4120026F), new Vector2(47.6459999F, 62.6339989F));
                    builder.AddCubicBezier(new Vector2(52.1689987F, 59.1529999F), new Vector2(55.8279991F, 54.6069984F), new Vector2(57.9189987F, 49.3510017F));
                    builder.AddCubicBezier(new Vector2(58.9519997F, 46.7220001F), new Vector2(59.6739998F, 43.9620018F), new Vector2(60.0139999F, 41.1310005F));
                    builder.AddCubicBezier(new Vector2(60.3250008F, 38.2960014F), new Vector2(60.3380013F, 35.4169998F), new Vector2(60.0830002F, 32.5439987F));
                    builder.AddCubicBezier(new Vector2(59.5130005F, 26.7950001F), new Vector2(57.9119987F, 21.1159992F), new Vector2(55.6580009F, 15.7049999F));
                    builder.AddCubicBezier(new Vector2(53.4000015F, 10.2989998F), new Vector2(50.5219994F, 5.08699989F), new Vector2(47.1879997F, 0.256999999F));
                    builder.AddCubicBezier(new Vector2(43.8409996F, -4.56099987F), new Vector2(39.9099998F, -8.96700001F), new Vector2(35.3250008F, -12.526F));
                    builder.AddCubicBezier(new Vector2(33.0340004F, -14.3079996F), new Vector2(30.5860004F, -15.8590002F), new Vector2(27.9839993F, -17.1410007F));
                    builder.AddCubicBezier(new Vector2(25.3799992F, -18.4300003F), new Vector2(22.6270008F, -19.4839993F), new Vector2(19.8199997F, -20.4619999F));
                    builder.AddCubicBezier(new Vector2(14.21F, -22.4249992F), new Vector2(8.32900047F, -24.0510006F), new Vector2(2.76200008F, -26.7910004F));
                    builder.AddCubicBezier(new Vector2(-0.00800000038F, -28.1630001F), new Vector2(-2.69400001F, -29.8279991F), new Vector2(-5.04400015F, -31.9220009F));
                    builder.AddCubicBezier(new Vector2(-7.421F, -33.993F), new Vector2(-9.38000011F, -36.487999F), new Vector2(-11.0389996F, -39.144001F));
                    builder.AddCubicBezier(new Vector2(-12.5649996F, -41.8779984F), new Vector2(-13.7910004F, -44.7669983F), new Vector2(-14.5760002F, -47.7709999F));
                    builder.AddCubicBezier(new Vector2(-15.302F, -50.7789993F), new Vector2(-15.8409996F, -53.8409996F), new Vector2(-15.9160004F, -56.9169998F));
                    builder.AddCubicBezier(new Vector2(-15.9759998F, -57.6850014F), new Vector2(-15.9840002F, -58.4519997F), new Vector2(-15.9659996F, -59.2200012F));
                    builder.AddCubicBezier(new Vector2(-15.9540005F, -59.9869995F), new Vector2(-15.9619999F, -60.7550011F), new Vector2(-15.9329996F, -61.5200005F));
                    builder.AddCubicBezier(new Vector2(-15.8100004F, -63.0470009F), new Vector2(-15.7670002F, -64.5810013F), new Vector2(-15.5340004F, -66.0940018F));
                    builder.AddCubicBezier(new Vector2(-15.1990004F, -69.1350021F), new Vector2(-14.5469999F, -72.1259995F), new Vector2(-13.7770004F, -75.072998F));
                    builder.AddCubicBezier(new Vector2(-10.3809996F, -86.7910004F), new Vector2(-4.60099983F, -97.6409988F), new Vector2(2.773F, -107.211998F));
                    builder.AddCubicBezier(new Vector2(6.46600008F, -111.992996F), new Vector2(10.566F, -116.450996F), new Vector2(15.0200005F, -120.513F));
                    builder.AddCubicBezier(new Vector2(19.4869995F, -124.560997F), new Vector2(24.2980003F, -128.216003F), new Vector2(29.3880005F, -131.414993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 29 Offset:<375.923, 314.862>
            CanvasGeometry Geometry_33()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-8.31900024F, -9.82400036F));
                    builder.AddCubicBezier(new Vector2(-9.76200008F, -9.4460001F), new Vector2(-10.2290001F, -5.6789999F), new Vector2(-9.9829998F, -4.56099987F));
                    builder.AddCubicBezier(new Vector2(-9.84200001F, -3.9230001F), new Vector2(-9.40499973F, -3.32800007F), new Vector2(-9.02200031F, -2.81399989F));
                    builder.AddCubicBezier(new Vector2(-5.76800013F, 1.55900002F), new Vector2(-1.49300003F, 6.04300022F), new Vector2(3.27999997F, 8.71399975F));
                    builder.AddCubicBezier(new Vector2(8.11800003F, 11.4230003F), new Vector2(10.2279997F, 8.88599968F), new Vector2(9.01799965F, 3.92799997F));
                    builder.AddCubicBezier(new Vector2(8.4989996F, 1.80499995F), new Vector2(7.72900009F, -0.252999991F), new Vector2(7.10400009F, -2.34500003F));
                    builder.AddCubicBezier(new Vector2(6.17600012F, -5.44899988F), new Vector2(5.59499979F, -8.55500031F), new Vector2(4.04699993F, -11.4230003F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 28 Offset:<425.346, 294.375>
            CanvasGeometry Geometry_34()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-5.53999996F, -12.1940002F));
                    builder.AddCubicBezier(new Vector2(-7.03100014F, -12.1479998F), new Vector2(-8.32999992F, -8.58199978F), new Vector2(-8.34000015F, -7.4380002F));
                    builder.AddCubicBezier(new Vector2(-8.34599972F, -6.78299999F), new Vector2(-8.0539999F, -6.10599995F), new Vector2(-7.796F, -5.51900005F));
                    builder.AddCubicBezier(new Vector2(-5.60400009F, -0.527999997F), new Vector2(-2.44000006F, 4.79899979F), new Vector2(1.61099994F, 8.47099972F));
                    builder.AddCubicBezier(new Vector2(5.72100019F, 12.1949997F), new Vector2(8.34599972F, 10.1960001F), new Vector2(8.27600002F, 5.09200001F));
                    builder.AddCubicBezier(new Vector2(8.24699974F, 2.90799999F), new Vector2(7.95599985F, 0.728999972F), new Vector2(7.81599998F, -1.45099998F));
                    builder.AddCubicBezier(new Vector2(7.6079998F, -4.68300009F), new Vector2(7.73600006F, -7.84000015F), new Vector2(6.86999989F, -10.9820004F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 27 Offset:<406.311, 99.421>
            CanvasGeometry Geometry_35()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(3.31800008F, 6.83799982F));
                    builder.AddCubicBezier(new Vector2(2.47300005F, 8.04599953F), new Vector2(-7.03700018F, 6.26800013F), new Vector2(-7.38500023F, 4.421F));
                    builder.AddCubicBezier(new Vector2(-7.64799976F, 3.03200006F), new Vector2(-4.77400017F, 3.45600009F), new Vector2(-3.50099993F, 2.81399989F));
                    builder.AddCubicBezier(new Vector2(-2.43799996F, 2.27800012F), new Vector2(-7.3119998F, -3.91199994F), new Vector2(-5.90899992F, -5.03399992F));
                    builder.AddCubicBezier(new Vector2(-5.16300011F, -5.63000011F), new Vector2(-2.97399998F, -3.3210001F), new Vector2(-1.977F, -2.51900005F));
                    builder.AddCubicBezier(new Vector2(-1.93200004F, -2.48300004F), new Vector2(-2.4920001F, -7.02099991F), new Vector2(-1.44700003F, -7.54899979F));
                    builder.AddCubicBezier(new Vector2(-1.02100003F, -7.76499987F), new Vector2(0.797999978F, -4.99800014F), new Vector2(1.33700001F, -3.48600006F));
                    builder.AddCubicBezier(new Vector2(1.35099995F, -3.44199991F), new Vector2(1.58599997F, -7.50199986F), new Vector2(2.602F, -7.74700022F));
                    builder.AddCubicBezier(new Vector2(3.83800006F, -8.04599953F), new Vector2(4.57200003F, -3.55599999F), new Vector2(4.61600018F, -3.64700007F));
                    builder.AddCubicBezier(new Vector2(4.95300007F, -4.34299994F), new Vector2(5.50099993F, -6.22300005F), new Vector2(6.64699984F, -5.64900017F));
                    builder.AddCubicBezier(new Vector2(7.64699984F, -5.14900017F), new Vector2(7.1500001F, 0.342000008F), new Vector2(6.96999979F, 0.93900001F));
                    builder.AddCubicBezier(new Vector2(5.75699997F, 4.96500015F), new Vector2(3.31800008F, 6.83799982F), new Vector2(3.31800008F, 6.83799982F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 26 Offset:<323.675, 239.112>
            CanvasGeometry Geometry_36()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-3.80800009F, -6.81699991F));
                    builder.AddCubicBezier(new Vector2(-3.03600001F, -8.07199955F), new Vector2(6.56099987F, -6.85200024F), new Vector2(7.0170002F, -5.02899981F));
                    builder.AddCubicBezier(new Vector2(7.36000013F, -3.65700006F), new Vector2(4.46600008F, -3.91199994F), new Vector2(3.23300004F, -3.19700003F));
                    builder.AddCubicBezier(new Vector2(2.204F, -2.5999999F), new Vector2(7.42999983F, 3.29500008F), new Vector2(6.09399986F, 4.49700022F));
                    builder.AddCubicBezier(new Vector2(5.38700008F, 5.13600016F), new Vector2(3.06599998F, 2.95700002F), new Vector2(2.02399993F, 2.21499991F));
                    builder.AddCubicBezier(new Vector2(1.97599995F, 2.18099999F), new Vector2(2.79900002F, 6.6789999F), new Vector2(1.78799999F, 7.2670002F));
                    builder.AddCubicBezier(new Vector2(1.375F, 7.50699997F), new Vector2(-0.601999998F, 4.85099983F), new Vector2(-1.227F, 3.37400007F));
                    builder.AddCubicBezier(new Vector2(-1.24600005F, 3.32999992F), new Vector2(-1.24300003F, 7.39699984F), new Vector2(-2.24399996F, 7.70200014F));
                    builder.AddCubicBezier(new Vector2(-3.45900011F, 8.0710001F), new Vector2(-4.454F, 3.6329999F), new Vector2(-4.49399996F, 3.72600007F));
                    builder.AddCubicBezier(new Vector2(-4.78800011F, 4.44099998F), new Vector2(-5.22599983F, 6.34899998F), new Vector2(-6.40399981F, 5.84299994F));
                    builder.AddCubicBezier(new Vector2(-7.42999983F, 5.40199995F), new Vector2(-7.25500011F, -0.108000003F), new Vector2(-7.11000013F, -0.713999987F));
                    builder.AddCubicBezier(new Vector2(-6.13500023F, -4.8039999F), new Vector2(-3.80800009F, -6.81699991F), new Vector2(-3.80800009F, -6.81699991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 25 Offset:<326.061, 201.075>
            CanvasGeometry Geometry_37()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(16.7670002F, -42.4070015F));
                    builder.AddCubicBezier(new Vector2(17.3069992F, -42.368F), new Vector2(17.8490009F, -42.3590012F), new Vector2(18.3850002F, -42.2879982F));
                    builder.AddCubicBezier(new Vector2(23.7360001F, -41.5800018F), new Vector2(28.4960003F, -37.5159988F), new Vector2(29.9869995F, -32.2470016F));
                    builder.AddCubicBezier(new Vector2(31.1660004F, -28.0739994F), new Vector2(30.2639999F, -23.3770008F), new Vector2(27.6219997F, -19.941F));
                    builder.AddCubicBezier(new Vector2(26.632F, -18.6520004F), new Vector2(25.4169998F, -17.5400009F), new Vector2(24.0459995F, -16.6679993F));
                    builder.AddCubicBezier(new Vector2(22.7560005F, -15.8470001F), new Vector2(21.3409996F, -15.2320004F), new Vector2(19.9990005F, -14.4759998F));
                    builder.AddCubicBezier(new Vector2(12.8739996F, -10.4630003F), new Vector2(6.03100014F, -5.63000011F), new Vector2(1.09800005F, 0.936999977F));
                    builder.AddCubicBezier(new Vector2(0.736000001F, 1.41900003F), new Vector2(0.388999999F, 1.91100001F), new Vector2(0.0590000004F, 2.41499996F));
                    builder.AddCubicBezier(new Vector2(-1.85300004F, 5.33099985F), new Vector2(-3.22900009F, 8.80300045F), new Vector2(-2.47000003F, 12.2360001F));
                    builder.AddCubicBezier(new Vector2(-1.93299997F, 14.6669998F), new Vector2(-0.59799999F, 16.8729992F), new Vector2(0.931999981F, 18.868F));
                    builder.AddLine(new Vector2(0.991999984F, 18.9449997F));
                    builder.AddCubicBezier(new Vector2(1.80299997F, 20.1340008F), new Vector2(2.06399989F, 20.4050007F), new Vector2(2.66000009F, 21.7240009F));
                    builder.AddCubicBezier(new Vector2(4.44500017F, 25.6730003F), new Vector2(4.24900007F, 30.4549999F), new Vector2(2.148F, 34.2449989F));
                    builder.AddCubicBezier(new Vector2(-0.725000024F, 39.4249992F), new Vector2(-7.13000011F, 42.4070015F), new Vector2(-13.0469999F, 41.1119995F));
                    builder.AddCubicBezier(new Vector2(-15.6940002F, 40.5330009F), new Vector2(-18.1560001F, 39.1660004F), new Vector2(-20.0489998F, 37.2280006F));
                    builder.AddCubicBezier(new Vector2(-20.9230003F, 36.3339996F), new Vector2(-21.6569996F, 35.3149986F), new Vector2(-22.3840008F, 34.2949982F));
                    builder.AddCubicBezier(new Vector2(-26.7110004F, 28.2339993F), new Vector2(-29.7140007F, 21.1959991F), new Vector2(-30.4440002F, 13.8199997F));
                    builder.AddCubicBezier(new Vector2(-31.1660004F, 6.52799988F), new Vector2(-29.6049995F, -0.920000017F), new Vector2(-26.3710003F, -7.51599979F));
                    builder.AddCubicBezier(new Vector2(-21.7819996F, -16.8729992F), new Vector2(-14.2720003F, -24.4540005F), new Vector2(-6.15399981F, -30.632F));
                    builder.AddCubicBezier(new Vector2(-0.95599997F, -34.5880013F), new Vector2(4.58099985F, -38.1469994F), new Vector2(10.4219999F, -40.9910011F));
                    builder.AddLine(new Vector2(10.4779997F, -41.0180016F));
                    builder.AddCubicBezier(new Vector2(10.9790001F, -41.2249985F), new Vector2(11.4680004F, -41.4609985F), new Vector2(11.9790001F, -41.6389999F));
                    builder.AddCubicBezier(new Vector2(13.3459997F, -42.112999F), new Vector2(13.7229996F, -42.1100006F), new Vector2(15.1450005F, -42.3380013F));
                    builder.AddCubicBezier(new Vector2(15.6859999F, -42.3610001F), new Vector2(16.2269993F, -42.3839989F), new Vector2(16.7670002F, -42.4070015F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 24 Offset:<400.932, 137.064>
            CanvasGeometry Geometry_38()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(12.4020004F, -36.7060013F));
                    builder.AddCubicBezier(new Vector2(12.8400002F, -36.7070007F), new Vector2(12.9499998F, -36.7130013F), new Vector2(13.3870001F, -36.6910019F));
                    builder.AddCubicBezier(new Vector2(18.073F, -36.4550018F), new Vector2(22.4540005F, -33.7010002F), new Vector2(24.8740005F, -29.5599995F));
                    builder.AddCubicBezier(new Vector2(30.3279991F, -20.2269993F), new Vector2(33.8009987F, -9.36800003F), new Vector2(31.8689995F, 1.30599999F));
                    builder.AddCubicBezier(new Vector2(31.1730003F, 5.15100002F), new Vector2(29.7770004F, 8.82199955F), new Vector2(27.8139992F, 12.1960001F));
                    builder.AddCubicBezier(new Vector2(25.8880005F, 15.507F), new Vector2(23.4139996F, 18.5330009F), new Vector2(20.5209999F, 21.1539993F));
                    builder.AddCubicBezier(new Vector2(12.8299999F, 28.1210003F), new Vector2(2.94000006F, 32.1699982F), new Vector2(-6.95200014F, 34.6450005F));
                    builder.AddCubicBezier(new Vector2(-10.3540001F, 35.4959984F), new Vector2(-13.7980003F, 36.1949997F), new Vector2(-17.2730007F, 36.5979996F));
                    builder.AddCubicBezier(new Vector2(-17.2730007F, 36.5979996F), new Vector2(-18.3939991F, 36.7130013F), new Vector2(-19.3059998F, 36.6860008F));
                    builder.AddCubicBezier(new Vector2(-25.3530006F, 36.5089989F), new Vector2(-31.0259991F, 32.0149994F), new Vector2(-32.4720001F, 25.9869995F));
                    builder.AddCubicBezier(new Vector2(-33.8019981F, 20.4400005F), new Vector2(-31.375F, 14.1520004F), new Vector2(-26.4379997F, 10.9820004F));
                    builder.AddCubicBezier(new Vector2(-24.4880009F, 9.73099995F), new Vector2(-22.2280006F, 9.11100006F), new Vector2(-19.9060001F, 8.78499985F));
                    builder.AddCubicBezier(new Vector2(-13.2299995F, 7.83699989F), new Vector2(-6.546F, 6.04300022F), new Vector2(-0.834999979F, 2.41599989F));
                    builder.AddCubicBezier(new Vector2(1.70599997F, 0.802999973F), new Vector2(4.2249999F, -1.26199996F), new Vector2(4.47300005F, -4.28200006F));
                    builder.AddCubicBezier(new Vector2(4.67799997F, -6.77600002F), new Vector2(3.7980001F, -9.27799988F), new Vector2(2.75F, -11.6350002F));
                    builder.AddCubicBezier(new Vector2(2.15199995F, -12.9840002F), new Vector2(1.45899999F, -14.2889996F), new Vector2(0.713999987F, -15.5620003F));
                    builder.AddCubicBezier(new Vector2(0.713999987F, -15.5620003F), new Vector2(0.134000003F, -16.559F), new Vector2(-0.224000007F, -17.4279995F));
                    builder.AddCubicBezier(new Vector2(-2.34800005F, -22.5830002F), new Vector2(-1.04900002F, -28.9440002F), new Vector2(3.05100012F, -32.8530006F));
                    builder.AddCubicBezier(new Vector2(5.54799986F, -35.2319984F), new Vector2(8.98200035F, -36.5760002F), new Vector2(12.4020004F, -36.7060013F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 23 Offset:<388.359, 228.433>
            CanvasGeometry Geometry_39()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-31.5259991F, 27.4820004F));
                    builder.AddCubicBezier(new Vector2(-35.3930016F, 21.2819996F), new Vector2(-40.8429985F, 12.1429996F), new Vector2(-43.8370018F, 7.21400023F));
                    builder.AddCubicBezier(new Vector2(-48.3330002F, -0.187000006F), new Vector2(-50.5379982F, -13.6000004F), new Vector2(-53.3709984F, -22.3999996F));
                    builder.AddCubicBezier(new Vector2(-55.8590012F, -30.1289997F), new Vector2(-61.7700005F, -38.019001F), new Vector2(-60.8349991F, -45.5880013F));
                    builder.AddCubicBezier(new Vector2(-59.9000015F, -53.1570015F), new Vector2(-57.8769989F, -64.5559998F), new Vector2(-47.7610016F, -67.8130035F));
                    builder.AddLine(new Vector2(-11.1000004F, -79.6149979F));
                    builder.AddCubicBezier(new Vector2(-0.984000027F, -82.8720016F), new Vector2(8.0880003F, -76.0419998F), new Vector2(12.4849997F, -69.1920013F));
                    builder.AddCubicBezier(new Vector2(16.8530006F, -62.387001F), new Vector2(22.3950005F, -47.5660019F), new Vector2(25.9500008F, -34.5530014F));
                    builder.AddCubicBezier(new Vector2(26.2010002F, -34.3829994F), new Vector2(39.8260002F, -22.6049995F), new Vector2(45.1049995F, -15.908F));
                    builder.AddCubicBezier(new Vector2(53.3019981F, -5.50899982F), new Vector2(59.4410019F, 6.7579999F), new Vector2(60.7459984F, 20F));
                    builder.AddCubicBezier(new Vector2(61.7700005F, 30.3929996F), new Vector2(59.5460014F, 41.0839996F), new Vector2(54.7029991F, 50.3089981F));
                    builder.AddLine(new Vector2(54.6419983F, 50.4239998F));
                    builder.AddCubicBezier(new Vector2(53.7669983F, 51.8950005F), new Vector2(53.598999F, 52.3040009F), new Vector2(52.507F, 53.6300011F));
                    builder.AddCubicBezier(new Vector2(48.0209999F, 59.0779991F), new Vector2(40.3769989F, 61.7039986F), new Vector2(33.4179993F, 60.0540009F));
                    builder.AddCubicBezier(new Vector2(27.1499996F, 58.5680008F), new Vector2(21.8169994F, 53.6980019F), new Vector2(19.7660007F, 47.6010017F));
                    builder.AddCubicBezier(new Vector2(18.3309994F, 43.3380013F), new Vector2(18.4680004F, 38.5699997F), new Vector2(20.1639996F, 34.3829994F));
                    builder.AddCubicBezier(new Vector2(20.6720009F, 33.1269989F), new Vector2(21.3780003F, 31.9589996F), new Vector2(21.875F, 30.6959991F));
                    builder.AddCubicBezier(new Vector2(22.5699997F, 28.9300003F), new Vector2(22.9459991F, 27.0380001F), new Vector2(22.9290009F, 25.1350002F));
                    builder.AddCubicBezier(new Vector2(22.8869991F, 20.4230003F), new Vector2(20.8040009F, 16.0060005F), new Vector2(18.3759995F, 12.1400003F));
                    builder.AddCubicBezier(new Vector2(14.7119999F, 6.30600023F), new Vector2(9.97700024F, 1.21000004F), new Vector2(4.51300001F, -3.09299994F));
                    builder.AddCubicBezier(new Vector2(4.37300014F, -3.204F), new Vector2(4.15500021F, -3.37199998F), new Vector2(4.15500021F, -3.37199998F));
                    builder.AddLine(new Vector2(3.39299989F, -3.99799991F));
                    builder.AddCubicBezier(new Vector2(2.96700001F, -3.87299991F), new Vector2(2.55200005F, -3.74799991F), new Vector2(2.148F, -3.61800003F));
                    builder.AddLine(new Vector2(-4.30000019F, -1.01100004F));
                    builder.AddCubicBezier(new Vector2(-2.62100005F, 1.86000001F), new Vector2(-0.861000001F, 4.69500017F), new Vector2(0.913999975F, 7.54500008F));
                    builder.AddCubicBezier(new Vector2(4.41499996F, 13.1759996F), new Vector2(7.60200024F, 19.0760002F), new Vector2(9.32199955F, 25.4629993F));
                    builder.AddCubicBezier(new Vector2(12.0959997F, 35.7630005F), new Vector2(11.2349997F, 46.7589989F), new Vector2(9.45100021F, 57.3909988F));
                    builder.AddCubicBezier(new Vector2(8.90499973F, 60.651001F), new Vector2(8.2670002F, 63.894001F), new Vector2(7.57999992F, 67.1279984F));
                    builder.AddLine(new Vector2(7.52699995F, 67.3769989F));
                    builder.AddLine(new Vector2(7.4749999F, 67.6190033F));
                    builder.AddLine(new Vector2(6.97599983F, 69.4810028F));
                    builder.AddCubicBezier(new Vector2(6.74800014F, 70.0820007F), new Vector2(6.55000019F, 70.6949997F), new Vector2(6.29199982F, 71.2839966F));
                    builder.AddCubicBezier(new Vector2(3.45499992F, 77.7470016F), new Vector2(-3.18899989F, 82.348999F), new Vector2(-10.3339996F, 82.6520004F));
                    builder.AddCubicBezier(new Vector2(-15.4790001F, 82.8710022F), new Vector2(-20.6720009F, 80.8970032F), new Vector2(-24.3710003F, 77.3209991F));
                    builder.AddCubicBezier(new Vector2(-28.5289993F, 73.302002F), new Vector2(-30.7040005F, 67.3580017F), new Vector2(-30.0639992F, 61.5489998F));
                    builder.AddCubicBezier(new Vector2(-29.9300003F, 60.3250008F), new Vector2(-29.6429996F, 59.125F), new Vector2(-29.3929996F, 57.9220009F));
                    builder.AddCubicBezier(new Vector2(-28.1110001F, 51.7299995F), new Vector2(-26.7800007F, 45.4900017F), new Vector2(-26.9629993F, 39.1100006F));
                    builder.AddCubicBezier(new Vector2(-27.0039997F, 37.6609993F), new Vector2(-27.1580009F, 36.2039986F), new Vector2(-27.6019993F, 34.8310013F));
                    builder.AddCubicBezier(new Vector2(-28.4519997F, 32.2029991F), new Vector2(-30.0400009F, 29.8630009F), new Vector2(-31.5259991F, 27.4820004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 22 Offset:<369.012, 250.246>
            CanvasGeometry Geometry_40()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(22.823F, -25.7450008F));
                    builder.AddCubicBezier(new Vector2(22.823F, -25.7450008F), new Vector2(27.3139992F, -30.6539993F), new Vector2(27.7399998F, -30.7789993F));
                    builder.AddCubicBezier(new Vector2(27.7399998F, -30.7789993F), new Vector2(40.5489998F, -15.8249998F), new Vector2(44.2140007F, -9.99100018F));
                    builder.AddCubicBezier(new Vector2(46.6430016F, -6.12400007F), new Vector2(48.7249985F, -1.70899999F), new Vector2(48.7669983F, 3.00300002F));
                    builder.AddCubicBezier(new Vector2(48.7830009F, 4.90600014F), new Vector2(48.4070015F, 6.79899979F), new Vector2(47.7120018F, 8.56400013F));
                    builder.AddCubicBezier(new Vector2(47.2140007F, 9.82800007F), new Vector2(46.5099983F, 10.9969997F), new Vector2(46.0009995F, 12.2530003F));
                    builder.AddCubicBezier(new Vector2(44.3059998F, 16.4389992F), new Vector2(44.1699982F, 21.2070007F), new Vector2(45.6040001F, 25.4699993F));
                    builder.AddCubicBezier(new Vector2(47.6559982F, 31.5669994F), new Vector2(52.987999F, 36.4360008F), new Vector2(59.2540016F, 37.9230003F));
                    builder.AddCubicBezier(new Vector2(59.9389992F, 38.0849991F), new Vector2(60.6220016F, 38.1870003F), new Vector2(61.3019981F, 38.237999F));
                    builder.AddCubicBezier(new Vector2(58.5139999F, 38.8759995F), new Vector2(55.5839996F, 38.9090004F), new Vector2(52.7659988F, 38.2410011F));
                    builder.AddCubicBezier(new Vector2(46.4980011F, 36.7550011F), new Vector2(41.1640015F, 31.8859997F), new Vector2(39.112999F, 25.7889996F));
                    builder.AddCubicBezier(new Vector2(37.6780014F, 21.5259991F), new Vector2(37.8160019F, 16.757F), new Vector2(39.512001F, 12.5699997F));
                    builder.AddCubicBezier(new Vector2(40.0200005F, 11.3129997F), new Vector2(40.7260017F, 10.1450005F), new Vector2(41.2229996F, 8.88300037F));
                    builder.AddCubicBezier(new Vector2(41.9179993F, 7.1170001F), new Vector2(42.2929993F, 5.22399998F), new Vector2(42.276001F, 3.3210001F));
                    builder.AddCubicBezier(new Vector2(42.2340012F, -1.39100003F), new Vector2(40.1520004F, -5.80600023F), new Vector2(37.723999F, -9.67199993F));
                    builder.AddCubicBezier(new Vector2(34.0600014F, -15.5059996F), new Vector2(29.3250008F, -20.6030006F), new Vector2(23.8610001F, -24.9060001F));
                    builder.AddCubicBezier(new Vector2(23.7210007F, -25.0170002F), new Vector2(23.5030003F, -25.1849995F), new Vector2(23.5030003F, -25.1849995F));
                    builder.AddLine(new Vector2(22.823F, -25.7450008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-36.098999F, -59.776001F));
                    builder.AddCubicBezier(new Vector2(-35.5180016F, -60.2130013F), new Vector2(-34.9280014F, -60.6389999F), new Vector2(-34.3320007F, -61.0569992F));
                    builder.AddCubicBezier(new Vector2(-32.7879982F, -55.5820007F), new Vector2(-29.2989998F, -50.0159988F), new Vector2(-27.5340004F, -44.5309982F));
                    builder.AddCubicBezier(new Vector2(-24.7000008F, -35.730999F), new Vector2(-22.4960003F, -22.3180008F), new Vector2(-18F, -14.9169998F));
                    builder.AddCubicBezier(new Vector2(-15.0050001F, -9.98700047F), new Vector2(-9.55500031F, -0.848999977F), new Vector2(-5.6880002F, 5.3499999F));
                    builder.AddCubicBezier(new Vector2(-4.62099981F, 7.06099987F), new Vector2(-3.5F, 8.75199986F), new Vector2(-2.63800001F, 10.5430002F));
                    builder.AddCubicBezier(new Vector2(-2.30100012F, 11.2440004F), new Vector2(-2.00200009F, 11.9619999F), new Vector2(-1.76400006F, 12.7010002F));
                    builder.AddCubicBezier(new Vector2(-1.31900001F, 14.0740004F), new Vector2(-1.16700006F, 15.5299997F), new Vector2(-1.125F, 16.9780006F));
                    builder.AddCubicBezier(new Vector2(-0.943000019F, 23.3589993F), new Vector2(-2.27399993F, 29.5990009F), new Vector2(-3.55500007F, 35.7919998F));
                    builder.AddCubicBezier(new Vector2(-3.80500007F, 36.9949989F), new Vector2(-4.09200001F, 38.1930008F), new Vector2(-4.22700024F, 39.4179993F));
                    builder.AddCubicBezier(new Vector2(-4.86600018F, 45.2260017F), new Vector2(-2.69199991F, 51.1710014F), new Vector2(1.46500003F, 55.1889992F));
                    builder.AddCubicBezier(new Vector2(5.16699982F, 58.7659988F), new Vector2(9.66100025F, 58.9440002F), new Vector2(14.8059998F, 58.7249985F));
                    builder.AddCubicBezier(new Vector2(15.6059999F, 58.6910019F), new Vector2(16.4109993F, 58.6259995F), new Vector2(17.2099991F, 58.5270004F));
                    builder.AddCubicBezier(new Vector2(14.7049999F, 59.8919983F), new Vector2(11.8990002F, 60.7169991F), new Vector2(9.01299953F, 60.8390007F));
                    builder.AddCubicBezier(new Vector2(3.86800003F, 61.0569992F), new Vector2(-1.324F, 59.0839996F), new Vector2(-5.02299976F, 55.5079994F));
                    builder.AddCubicBezier(new Vector2(-9.18099976F, 51.4889984F), new Vector2(-11.3559999F, 45.5439987F), new Vector2(-10.7159996F, 39.7350006F));
                    builder.AddCubicBezier(new Vector2(-10.5819998F, 38.5110016F), new Vector2(-10.2959995F, 37.3110008F), new Vector2(-10.0459995F, 36.1090012F));
                    builder.AddCubicBezier(new Vector2(-8.76399994F, 29.9169998F), new Vector2(-7.43300009F, 23.677F), new Vector2(-7.61600018F, 17.2970009F));
                    builder.AddCubicBezier(new Vector2(-7.65700006F, 15.8479996F), new Vector2(-7.81099987F, 14.3909998F), new Vector2(-8.25500011F, 13.0170002F));
                    builder.AddCubicBezier(new Vector2(-9.10499954F, 10.3900003F), new Vector2(-10.6920004F, 8.05000019F), new Vector2(-12.1780005F, 5.66900015F));
                    builder.AddCubicBezier(new Vector2(-16.0450001F, -0.531000018F), new Vector2(-21.4960003F, -9.67000008F), new Vector2(-24.4899998F, -14.599F));
                    builder.AddCubicBezier(new Vector2(-28.9860001F, -22F), new Vector2(-31.1900005F, -35.4140015F), new Vector2(-34.0229988F, -44.2140007F));
                    builder.AddCubicBezier(new Vector2(-34.9550018F, -47.1100006F), new Vector2(-36.3699989F, -50.0279999F), new Vector2(-37.7229996F, -52.9440002F));
                    builder.AddCubicBezier(new Vector2(-39.2060013F, -51.4770012F), new Vector2(-40.5919991F, -49.9119987F), new Vector2(-41.8530006F, -48.2330017F));
                    builder.AddCubicBezier(new Vector2(-42.2150002F, -47.7509995F), new Vector2(-42.5629997F, -47.2589989F), new Vector2(-42.8930016F, -46.7550011F));
                    builder.AddCubicBezier(new Vector2(-44.8050003F, -43.8390007F), new Vector2(-46.1809998F, -40.368F), new Vector2(-45.4220009F, -36.9350014F));
                    builder.AddCubicBezier(new Vector2(-44.8849983F, -34.5040016F), new Vector2(-43.5480003F, -32.2970009F), new Vector2(-42.0180016F, -30.302F));
                    builder.AddLine(new Vector2(-41.9580002F, -30.2250004F));
                    builder.AddCubicBezier(new Vector2(-41.1469994F, -29.0359993F), new Vector2(-40.8860016F, -28.7660007F), new Vector2(-40.2900009F, -27.4470005F));
                    builder.AddCubicBezier(new Vector2(-38.5050011F, -23.4979992F), new Vector2(-38.7010002F, -18.7159996F), new Vector2(-40.8019981F, -14.9259996F));
                    builder.AddCubicBezier(new Vector2(-43.6749992F, -9.74600029F), new Vector2(-50.0800018F, -6.76399994F), new Vector2(-55.9970016F, -8.05900002F));
                    builder.AddCubicBezier(new Vector2(-57.9109993F, -8.47799969F), new Vector2(-59.7280006F, -9.30700016F), new Vector2(-61.3019981F, -10.4659996F));
                    builder.AddCubicBezier(new Vector2(-60.8619995F, -10.3219995F), new Vector2(-60.4140015F, -10.1990004F), new Vector2(-59.9609985F, -10.1000004F));
                    builder.AddCubicBezier(new Vector2(-54.0439987F, -8.80500031F), new Vector2(-47.6389999F, -11.7869997F), new Vector2(-44.7659988F, -16.9669991F));
                    builder.AddCubicBezier(new Vector2(-42.6640015F, -20.7579994F), new Vector2(-42.4690018F, -25.5389996F), new Vector2(-44.2540016F, -29.4880009F));
                    builder.AddCubicBezier(new Vector2(-44.8499985F, -30.8069992F), new Vector2(-45.1110001F, -31.0779991F), new Vector2(-45.9230003F, -32.2669983F));
                    builder.AddLine(new Vector2(-45.9819984F, -32.3450012F));
                    builder.AddCubicBezier(new Vector2(-47.512001F, -34.3400002F), new Vector2(-48.8470001F, -36.5460014F), new Vector2(-49.3839989F, -38.9770012F));
                    builder.AddCubicBezier(new Vector2(-50.1430016F, -42.4099998F), new Vector2(-48.7669983F, -45.8810005F), new Vector2(-46.8549995F, -48.7970009F));
                    builder.AddCubicBezier(new Vector2(-46.5250015F, -49.3009987F), new Vector2(-46.1769981F, -49.7939987F), new Vector2(-45.8149986F, -50.276001F));
                    builder.AddCubicBezier(new Vector2(-43.9570007F, -52.7490005F), new Vector2(-41.8289986F, -54.9770012F), new Vector2(-39.5169983F, -57.007F));
                    builder.AddLine(new Vector2(-39.4949989F, -57.026001F));
                    builder.AddLine(new Vector2(-39.4150009F, -57.0950012F));
                    builder.AddLine(new Vector2(-39.3740005F, -57.132F));
                    builder.AddLine(new Vector2(-39.2550011F, -57.2340012F));
                    builder.AddLine(new Vector2(-39.2070007F, -57.276001F));
                    builder.AddLine(new Vector2(-39.1809998F, -57.2970009F));
                    builder.AddLine(new Vector2(-39.0940018F, -57.375F));
                    builder.AddLine(new Vector2(-39.0519981F, -57.4099998F));
                    builder.AddLine(new Vector2(-39.026001F, -57.4309998F));
                    builder.AddLine(new Vector2(-38.9309998F, -57.5130005F));
                    builder.AddLine(new Vector2(-38.7700005F, -57.651001F));
                    builder.AddLine(new Vector2(-38.6069984F, -57.7879982F));
                    builder.AddLine(new Vector2(-38.5680008F, -57.8190002F));
                    builder.AddCubicBezier(new Vector2(-38.1599998F, -58.1619987F), new Vector2(-37.7459984F, -58.5F), new Vector2(-37.3269997F, -58.8310013F));
                    builder.AddLine(new Vector2(-37.2849998F, -58.8650017F));
                    builder.AddLine(new Vector2(-37.1730003F, -58.9510002F));
                    builder.AddLine(new Vector2(-37.1160011F, -58.9959984F));
                    builder.AddLine(new Vector2(-37.0159988F, -59.0740013F));
                    builder.AddLine(new Vector2(-36.9480019F, -59.1279984F));
                    builder.AddLine(new Vector2(-36.8549995F, -59.1990013F));
                    builder.AddLine(new Vector2(-36.8190002F, -59.2270012F));
                    builder.AddLine(new Vector2(-36.7799988F, -59.2579994F));
                    builder.AddLine(new Vector2(-36.6930008F, -59.3240013F));
                    builder.AddLine(new Vector2(-36.6559982F, -59.3530006F));
                    builder.AddLine(new Vector2(-36.6110001F, -59.3880005F));
                    builder.AddLine(new Vector2(-36.5289993F, -59.4510002F));
                    builder.AddLine(new Vector2(-36.4949989F, -59.4780006F));
                    builder.AddLine(new Vector2(-36.4790001F, -59.4900017F));
                    builder.AddLine(new Vector2(-36.4399986F, -59.5169983F));
                    builder.AddLine(new Vector2(-36.362999F, -59.5769997F));
                    builder.AddLine(new Vector2(-36.3289986F, -59.6030006F));
                    builder.AddLine(new Vector2(-36.3120003F, -59.6160011F));
                    builder.AddLine(new Vector2(-36.2709999F, -59.6469994F));
                    builder.AddLine(new Vector2(-36.1980019F, -59.7019997F));
                    builder.AddLine(new Vector2(-36.1650009F, -59.7270012F));
                    builder.AddLine(new Vector2(-36.1459999F, -59.7410011F));
                    builder.AddLine(new Vector2(-36.0999985F, -59.776001F));
                    builder.AddLine(new Vector2(-36.098999F, -59.776001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 21 Offset:<419.326, 134.246>
            CanvasGeometry Geometry_41()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-15.4090004F, 30.6580009F));
                    builder.AddCubicBezier(new Vector2(-10.8620005F, 28.4920006F), new Vector2(-6.58400011F, 25.7859993F), new Vector2(-2.82999992F, 22.3850002F));
                    builder.AddCubicBezier(new Vector2(3.01200008F, 17.0930004F), new Vector2(7.13999987F, 10.1549997F), new Vector2(8.51900005F, 2.53699994F));
                    builder.AddCubicBezier(new Vector2(10.4510002F, -8.13700008F), new Vector2(6.97800016F, -18.9960003F), new Vector2(1.52400005F, -28.3290005F));
                    builder.AddCubicBezier(new Vector2(0.163000003F, -30.6580009F), new Vector2(-1.81900001F, -32.5480003F), new Vector2(-4.12599993F, -33.7989998F));
                    builder.AddCubicBezier(new Vector2(0.223000005F, -33.2849998F), new Vector2(4.21299982F, -30.6229992F), new Vector2(6.48099995F, -26.7420006F));
                    builder.AddCubicBezier(new Vector2(11.9350004F, -17.4090004F), new Vector2(15.408F, -6.55000019F), new Vector2(13.4759998F, 4.12400007F));
                    builder.AddCubicBezier(new Vector2(12.0970001F, 11.7419996F), new Vector2(7.96899986F, 18.6800003F), new Vector2(2.12800002F, 23.9720001F));
                    builder.AddCubicBezier(new Vector2(-2.58299994F, 28.2399998F), new Vector2(-8.11900043F, 31.4120007F), new Vector2(-13.9750004F, 33.7989998F));
                    builder.AddCubicBezier(new Vector2(-14.4549999F, 32.7000008F), new Vector2(-14.934F, 31.6499996F), new Vector2(-15.4090004F, 30.6580009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 20 Offset:<355.439, 157.878>
            CanvasGeometry Geometry_42()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(37.0760002F, -14.7449999F));
                    builder.AddCubicBezier(new Vector2(34.9140015F, -11.125F), new Vector2(32.1290016F, -7.97100019F), new Vector2(28.8180008F, -5.71000004F));
                    builder.AddCubicBezier(new Vector2(27.2560005F, -4.64300013F), new Vector2(-16.1800003F, 13.5430002F), new Vector2(-28.5389996F, 14.5229998F));
                    builder.AddCubicBezier(new Vector2(-31.3500004F, 14.7449999F), new Vector2(-34.2360001F, 14.4610004F), new Vector2(-37.0760002F, 13.7639999F));
                    builder.AddCubicBezier(new Vector2(-36.5649986F, 13.3579998F), new Vector2(-36.0499992F, 12.9589996F), new Vector2(-35.5309982F, 12.5649996F));
                    builder.AddCubicBezier(new Vector2(-34.3530006F, 11.6669998F), new Vector2(-33.1549988F, 10.79F), new Vector2(-31.9419994F, 9.93700027F));
                    builder.AddCubicBezier(new Vector2(-31.0139999F, 9.96899986F), new Vector2(-30.0900002F, 9.94999981F), new Vector2(-29.1739998F, 9.87699986F));
                    builder.AddCubicBezier(new Vector2(-14.927F, 8.74800014F), new Vector2(16.382F, -2.296F), new Vector2(28.184F, -10.3549995F));
                    builder.AddCubicBezier(new Vector2(29.3799992F, -11.1719999F), new Vector2(30.5079994F, -12.1049995F), new Vector2(31.5610008F, -13.1350002F));
                    builder.AddCubicBezier(new Vector2(33.4300003F, -13.5719995F), new Vector2(35.276001F, -14.1009998F), new Vector2(37.0760002F, -14.7449999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 19 Offset:<316.793, 192.963>
            CanvasGeometry Geometry_43()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-8.39900017F, -12.0640001F));
                    builder.AddCubicBezier(new Vector2(-7.39900017F, -11.4829998F), new Vector2(-6.42199993F, -10.8830004F), new Vector2(-5.47599983F, -10.3149996F));
                    builder.AddCubicBezier(new Vector2(1.58000004F, -6.05600023F), new Vector2(8.22200012F, -0.893000007F), new Vector2(13.4230003F, 5.43599987F));
                    builder.AddCubicBezier(new Vector2(12.3409996F, 6.57999992F), new Vector2(11.3190002F, 7.78200006F), new Vector2(10.3669996F, 9.04899979F));
                    builder.AddCubicBezier(new Vector2(10.0039997F, 9.53100014F), new Vector2(9.65699959F, 10.0229998F), new Vector2(9.32699966F, 10.5270004F));
                    builder.AddCubicBezier(new Vector2(9F, 11.0240002F), new Vector2(8.68999958F, 11.5369997F), new Vector2(8.40400028F, 12.0640001F));
                    builder.AddCubicBezier(new Vector2(8.22200012F, 11.8299999F), new Vector2(8.03899956F, 11.6000004F), new Vector2(7.85699987F, 11.3719997F));
                    builder.AddCubicBezier(new Vector2(2.83699989F, 5.13800001F), new Vector2(-3.61500001F, 0.118000001F), new Vector2(-10.4890003F, -3.94099998F));
                    builder.AddCubicBezier(new Vector2(-11.4639997F, -4.51999998F), new Vector2(-12.4300003F, -5.13899994F), new Vector2(-13.4230003F, -5.6960001F));
                    builder.AddCubicBezier(new Vector2(-11.8979998F, -7.93200016F), new Vector2(-10.21F, -10.052F), new Vector2(-8.39900017F, -12.0640001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 18 Offset:<326.184, 200.116>
            CanvasGeometry Geometry_44()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(1.19599998F, -4.91099977F));
                    builder.AddCubicBezier(new Vector2(2.18099999F, -3.88100004F), new Vector2(3.12899995F, -2.81699991F), new Vector2(4.03200006F, -1.71700001F));
                    builder.AddLine(new Vector2(4.01100016F, -1.69599998F));
                    builder.AddLine(new Vector2(3.95499992F, -1.63600004F));
                    builder.AddLine(new Vector2(3.93000007F, -1.61000001F));
                    builder.AddLine(new Vector2(3.91599989F, -1.59399998F));
                    builder.AddLine(new Vector2(3.87700009F, -1.55400002F));
                    builder.AddLine(new Vector2(3.84299994F, -1.51699996F));
                    builder.AddLine(new Vector2(3.829F, -1.50199997F));
                    builder.AddLine(new Vector2(3.79900002F, -1.46800005F));
                    builder.AddLine(new Vector2(3.74399996F, -1.41100001F));
                    builder.AddLine(new Vector2(3.69700003F, -1.36000001F));
                    builder.AddLine(new Vector2(3.62899995F, -1.28600001F));
                    builder.AddLine(new Vector2(3.62700009F, -1.28400004F));
                    builder.AddLine(new Vector2(3.61100006F, -1.26699996F));
                    builder.AddLine(new Vector2(3.56599998F, -1.21800005F));
                    builder.AddLine(new Vector2(3.52900004F, -1.17700005F));
                    builder.AddLine(new Vector2(3.50900006F, -1.15499997F));
                    builder.AddLine(new Vector2(3.47900009F, -1.12300003F));
                    builder.AddLine(new Vector2(3.45000005F, -1.09000003F));
                    builder.AddLine(new Vector2(3.4289999F, -1.06799996F));
                    builder.AddLine(new Vector2(3.38800001F, -1.02199996F));
                    builder.AddLine(new Vector2(3.34800005F, -0.977999985F));
                    builder.AddLine(new Vector2(3.33400011F, -0.963F));
                    builder.AddCubicBezier(new Vector2(3.29999995F, -0.922999978F), new Vector2(3.26300001F, -0.884000003F), new Vector2(3.22799993F, -0.845000029F));
                    builder.AddLine(new Vector2(3.21700001F, -0.832000017F));
                    builder.AddLine(new Vector2(3.18099999F, -0.791999996F));
                    builder.AddLine(new Vector2(3.1329999F, -0.737999976F));
                    builder.AddLine(new Vector2(3.11100006F, -0.713F));
                    builder.AddLine(new Vector2(3.08599997F, -0.68599999F));
                    builder.AddLine(new Vector2(3.06100011F, -0.657000005F));
                    builder.AddLine(new Vector2(3.03500009F, -0.628000021F));
                    builder.AddLine(new Vector2(2.98900008F, -0.574999988F));
                    builder.AddLine(new Vector2(2.95700002F, -0.538999975F));
                    builder.AddLine(new Vector2(2.94499993F, -0.526000023F));
                    builder.AddCubicBezier(new Vector2(2.90899992F, -0.483999997F), new Vector2(2.87199998F, -0.442000002F), new Vector2(2.83599997F, -0.400999993F));
                    builder.AddLine(new Vector2(2.82800007F, -0.39199999F));
                    builder.AddLine(new Vector2(2.79999995F, -0.360000014F));
                    builder.AddLine(new Vector2(2.74300003F, -0.294F));
                    builder.AddLine(new Vector2(2.72000003F, -0.26699999F));
                    builder.AddLine(new Vector2(2.70000005F, -0.244000003F));
                    builder.AddLine(new Vector2(2.67700005F, -0.216999993F));
                    builder.AddLine(new Vector2(2.64599991F, -0.181999996F));
                    builder.AddLine(new Vector2(2.59899998F, -0.126000002F));
                    builder.AddLine(new Vector2(2.57200003F, -0.0949999988F));
                    builder.AddLine(new Vector2(2.56100011F, -0.0820000023F));
                    builder.AddCubicBezier(new Vector2(2.52399993F, -0.0390000008F), new Vector2(2.48699999F, 0.00400000019F), new Vector2(2.45000005F, 0.0480000004F));
                    builder.AddLine(new Vector2(2.44499993F, 0.0540000014F));
                    builder.AddLine(new Vector2(2.42499995F, 0.0799999982F));
                    builder.AddLine(new Vector2(2.35899997F, 0.156000003F));
                    builder.AddLine(new Vector2(2.33599997F, 0.184F));
                    builder.AddLine(new Vector2(2.31900001F, 0.203999996F));
                    builder.AddLine(new Vector2(2.2980001F, 0.230000004F));
                    builder.AddLine(new Vector2(2.26399994F, 0.270000011F));
                    builder.AddLine(new Vector2(2.21700001F, 0.326000005F));
                    builder.AddLine(new Vector2(2.19300008F, 0.354999989F));
                    builder.AddLine(new Vector2(2.18300009F, 0.367000014F));
                    builder.AddLine(new Vector2(2.07200003F, 0.501999974F));
                    builder.AddLine(new Vector2(2.06800008F, 0.505999982F));
                    builder.AddLine(new Vector2(2.05200005F, 0.524999976F));
                    builder.AddLine(new Vector2(1.98099995F, 0.611999989F));
                    builder.AddLine(new Vector2(1.95899999F, 0.638999999F));
                    builder.AddLine(new Vector2(1.94400001F, 0.657999992F));
                    builder.AddLine(new Vector2(1.92400002F, 0.683000028F));
                    builder.AddLine(new Vector2(1.88800001F, 0.726999998F));
                    builder.AddLine(new Vector2(1.84200001F, 0.782999992F));
                    builder.AddLine(new Vector2(1.82000005F, 0.810000002F));
                    builder.AddLine(new Vector2(1.80999994F, 0.824000001F));
                    builder.AddCubicBezier(new Vector2(1.773F, 0.869000018F), new Vector2(1.73599994F, 0.915000021F), new Vector2(1.70000005F, 0.961000025F));
                    builder.AddLine(new Vector2(1.69799995F, 0.963F));
                    builder.AddLine(new Vector2(1.68700004F, 0.976999998F));
                    builder.AddLine(new Vector2(1.61000001F, 1.074F));
                    builder.AddLine(new Vector2(1.59000003F, 1.10000002F));
                    builder.AddLine(new Vector2(1.57500005F, 1.11699998F));
                    builder.AddLine(new Vector2(1.55499995F, 1.14300001F));
                    builder.AddLine(new Vector2(1.51800001F, 1.19000006F));
                    builder.AddLine(new Vector2(1.47500002F, 1.245F));
                    builder.AddLine(new Vector2(1.454F, 1.27100003F));
                    builder.AddLine(new Vector2(1.44299996F, 1.28600001F));
                    builder.AddCubicBezier(new Vector2(1.40699995F, 1.33200002F), new Vector2(1.37F, 1.37899995F), new Vector2(1.33399999F, 1.42499995F));
                    builder.AddLine(new Vector2(1.33299994F, 1.426F));
                    builder.AddLine(new Vector2(1.32700002F, 1.43400002F));
                    builder.AddLine(new Vector2(1.245F, 1.54100001F));
                    builder.AddLine(new Vector2(1.22599995F, 1.56599998F));
                    builder.AddLine(new Vector2(1.21399999F, 1.58200002F));
                    builder.AddLine(new Vector2(1.19299996F, 1.60800004F));
                    builder.AddLine(new Vector2(1.15499997F, 1.65900004F));
                    builder.AddLine(new Vector2(1.11399996F, 1.71200001F));
                    builder.AddLine(new Vector2(1.09399998F, 1.73899996F));
                    builder.AddLine(new Vector2(1.08200002F, 1.75399995F));
                    builder.AddCubicBezier(new Vector2(1.04799998F, 1.801F), new Vector2(1.01100004F, 1.84800005F), new Vector2(0.975000024F, 1.89600003F));
                    builder.AddCubicBezier(new Vector2(0.612999976F, 2.37800002F), new Vector2(0.264999986F, 2.86999989F), new Vector2(-0.0649999976F, 3.37400007F));
                    builder.AddCubicBezier(new Vector2(-0.0920000002F, 3.41499996F), new Vector2(-0.116999999F, 3.45600009F), new Vector2(-0.144999996F, 3.49600005F));
                    builder.AddLine(new Vector2(-0.155000001F, 3.51200008F));
                    builder.AddLine(new Vector2(-0.165000007F, 3.52800012F));
                    builder.AddLine(new Vector2(-0.187000006F, 3.56200004F));
                    builder.AddLine(new Vector2(-0.237000003F, 3.6400001F));
                    builder.AddLine(new Vector2(-0.241999999F, 3.64899993F));
                    builder.AddLine(new Vector2(-0.244000003F, 3.65199995F));
                    builder.AddCubicBezier(new Vector2(-0.270999998F, 3.69300008F), new Vector2(-0.296000004F, 3.73300004F), new Vector2(-0.321999997F, 3.77399993F));
                    builder.AddLine(new Vector2(-0.331F, 3.78800011F));
                    builder.AddLine(new Vector2(-0.342000008F, 3.80599999F));
                    builder.AddLine(new Vector2(-0.365999997F, 3.84500003F));
                    builder.AddLine(new Vector2(-0.407999992F, 3.91199994F));
                    builder.AddLine(new Vector2(-0.416999996F, 3.92799997F));
                    builder.AddLine(new Vector2(-0.419999987F, 3.93300009F));
                    builder.AddCubicBezier(new Vector2(-0.44600001F, 3.97300005F), new Vector2(-0.470999986F, 4.01399994F), new Vector2(-0.493999988F, 4.05499983F));
                    builder.AddLine(new Vector2(-0.503000021F, 4.06799984F));
                    builder.AddLine(new Vector2(-0.536000013F, 4.12300014F));
                    builder.AddLine(new Vector2(-0.541999996F, 4.13199997F));
                    builder.AddLine(new Vector2(-0.542999983F, 4.13399982F));
                    builder.AddCubicBezier(new Vector2(-0.560000002F, 4.16300011F), new Vector2(-0.577000022F, 4.19199991F), new Vector2(-0.595000029F, 4.22100019F));
                    builder.AddLine(new Vector2(-0.598999977F, 4.22800016F));
                    builder.AddLine(new Vector2(-0.606999993F, 4.24100018F));
                    builder.AddLine(new Vector2(-0.629999995F, 4.27899981F));
                    builder.AddLine(new Vector2(-0.648999989F, 4.3119998F));
                    builder.AddLine(new Vector2(-0.656000018F, 4.32399988F));
                    builder.AddLine(new Vector2(-0.660000026F, 4.33300018F));
                    builder.AddCubicBezier(new Vector2(-0.69599998F, 4.3920002F), new Vector2(-0.730000019F, 4.45200014F), new Vector2(-0.764999986F, 4.51100016F));
                    builder.AddLine(new Vector2(-0.768999994F, 4.51800013F));
                    builder.AddLine(new Vector2(-0.774999976F, 4.52899981F));
                    builder.AddLine(new Vector2(-0.795000017F, 4.56400013F));
                    builder.AddLine(new Vector2(-0.819000006F, 4.60699987F));
                    builder.AddLine(new Vector2(-0.824999988F, 4.61600018F));
                    builder.AddLine(new Vector2(-0.825999975F, 4.62099981F));
                    builder.AddCubicBezier(new Vector2(-0.861999989F, 4.68200016F), new Vector2(-0.897000015F, 4.74399996F), new Vector2(-0.930999994F, 4.80600023F));
                    builder.AddLine(new Vector2(-0.934000015F, 4.8119998F));
                    builder.AddLine(new Vector2(-0.938000023F, 4.81899977F));
                    builder.AddLine(new Vector2(-0.95599997F, 4.85200024F));
                    builder.AddLine(new Vector2(-0.987999976F, 4.91099977F));
                    builder.AddCubicBezier(new Vector2(-1.16900003F, 4.67700005F), new Vector2(-1.352F, 4.44700003F), new Vector2(-1.53400004F, 4.21899986F));
                    builder.AddCubicBezier(new Vector2(-2.33200002F, 3.22900009F), new Vector2(-3.16599989F, 2.26799989F), new Vector2(-4.03200006F, 1.33800006F));
                    builder.AddLine(new Vector2(-4.02799988F, 1.33200002F));
                    builder.AddCubicBezier(new Vector2(-3.69799995F, 0.828000009F), new Vector2(-3.3499999F, 0.335000008F), new Vector2(-2.98799992F, -0.147F));
                    builder.AddCubicBezier(new Vector2(-1.71099997F, -1.84599996F), new Vector2(-0.307000011F, -3.4289999F), new Vector2(1.19599998F, -4.91099977F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 17 Offset:<408.014, 150.922>
            CanvasGeometry Geometry_45()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-8.56799984F, -10.4049997F));
                    builder.AddCubicBezier(new Vector2(-8.51299953F, -10.4300003F), new Vector2(-8.45699978F, -10.4569998F), new Vector2(-8.40200043F, -10.4860001F));
                    builder.AddCubicBezier(new Vector2(-8.45800018F, -10.4589996F), new Vector2(-8.51399994F, -10.4320002F), new Vector2(-8.56799984F, -10.4049997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-3.83200002F, -14.9689999F));
                    builder.AddCubicBezier(new Vector2(-3.51999998F, -14.6829996F), new Vector2(-3.21700001F, -14.3940001F), new Vector2(-2.91899991F, -14.1120005F));
                    builder.AddCubicBezier(new Vector2(2.39299989F, -9.06099987F), new Vector2(6.46199989F, -2.67600012F), new Vector2(8.94200039F, 4.204F));
                    builder.AddCubicBezier(new Vector2(9.59200001F, 6.00500011F), new Vector2(10.1470003F, 7.88800001F), new Vector2(10.4420004F, 9.78600025F));
                    builder.AddCubicBezier(new Vector2(7.82800007F, 11.7779999F), new Vector2(5.01999998F, 13.4919996F), new Vector2(2.08599997F, 14.9689999F));
                    builder.AddCubicBezier(new Vector2(2.70600009F, 13.7779999F), new Vector2(2.64400005F, 12.2930002F), new Vector2(2.43600011F, 10.9110003F));
                    builder.AddCubicBezier(new Vector2(1.84899998F, 6.99499989F), new Vector2(0.0270000007F, 3.329F), new Vector2(-2.04099989F, -0.143000007F));
                    builder.AddCubicBezier(new Vector2(-4.079F, -3.56299996F), new Vector2(-6.47599983F, -6.71400023F), new Vector2(-9.72599983F, -9.42399979F));
                    builder.AddCubicBezier(new Vector2(-9.95899963F, -9.61800003F), new Vector2(-10.1949997F, -9.80700016F), new Vector2(-10.4420004F, -9.98400021F));
                    builder.AddCubicBezier(new Vector2(-9.58300018F, -10.4329996F), new Vector2(-8.73799992F, -10.9180002F), new Vector2(-7.91599989F, -11.441F));
                    builder.AddCubicBezier(new Vector2(-6.38199997F, -12.415F), new Vector2(-4.85400009F, -13.5550003F), new Vector2(-3.83200002F, -14.9689999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 16 Offset:<414.278, 160.915>
            CanvasGeometry Geometry_46()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(2.96300006F, -4.97599983F));
                    builder.AddCubicBezier(new Vector2(3.48699999F, -3.42499995F), new Vector2(3.92700005F, -1.82000005F), new Vector2(4.17799997F, -0.206F));
                    builder.AddLine(new Vector2(4.05700016F, -0.114F));
                    builder.AddLine(new Vector2(4.05200005F, -0.109999999F));
                    builder.AddLine(new Vector2(3.93700004F, -0.023F));
                    builder.AddLine(new Vector2(3.92700005F, -0.0149999997F));
                    builder.AddLine(new Vector2(3.81500006F, 0.0680000037F));
                    builder.AddLine(new Vector2(3.80200005F, 0.0790000036F));
                    builder.AddLine(new Vector2(3.69099998F, 0.158000007F));
                    builder.AddLine(new Vector2(3.67700005F, 0.171000004F));
                    builder.AddLine(new Vector2(3.56999993F, 0.248999998F));
                    builder.AddLine(new Vector2(3.55299997F, 0.261999995F));
                    builder.AddLine(new Vector2(3.44700003F, 0.338999987F));
                    builder.AddLine(new Vector2(3.42799997F, 0.354000002F));
                    builder.AddLine(new Vector2(3.32399988F, 0.430000007F));
                    builder.AddLine(new Vector2(3.30500007F, 0.444999993F));
                    builder.AddLine(new Vector2(3.20099998F, 0.518999994F));
                    builder.AddLine(new Vector2(3.18099999F, 0.532999992F));
                    builder.AddLine(new Vector2(3.07599998F, 0.609000027F));
                    builder.AddLine(new Vector2(3.05699992F, 0.624000013F));
                    builder.AddLine(new Vector2(2.95099998F, 0.697000027F));
                    builder.AddLine(new Vector2(2.93199992F, 0.712000012F));
                    builder.AddLine(new Vector2(2.82599998F, 0.787F));
                    builder.AddLine(new Vector2(2.80699992F, 0.800000012F));
                    builder.AddLine(new Vector2(2.69899988F, 0.876999974F));
                    builder.AddLine(new Vector2(2.68400002F, 0.887000024F));
                    builder.AddLine(new Vector2(2.56999993F, 0.967000008F));
                    builder.AddLine(new Vector2(2.55999994F, 0.976000011F));
                    builder.AddLine(new Vector2(2.44099998F, 1.05700004F));
                    builder.AddLine(new Vector2(2.43499994F, 1.06200004F));
                    builder.AddCubicBezier(new Vector2(2.05699992F, 1.32500005F), new Vector2(1.67499995F, 1.58200002F), new Vector2(1.28999996F, 1.83500004F));
                    builder.AddLine(new Vector2(1.28299999F, 1.83899999F));
                    builder.AddLine(new Vector2(1.16299999F, 1.91700006F));
                    builder.AddLine(new Vector2(1.148F, 1.926F));
                    builder.AddLine(new Vector2(1.03499997F, 1.99899995F));
                    builder.AddLine(new Vector2(1.01600003F, 2.01200008F));
                    builder.AddLine(new Vector2(0.907999992F, 2.08100009F));
                    builder.AddLine(new Vector2(0.884000003F, 2.09699988F));
                    builder.AddLine(new Vector2(0.779999971F, 2.16199994F));
                    builder.AddLine(new Vector2(0.754000008F, 2.18000007F));
                    builder.AddLine(new Vector2(0.65200001F, 2.24399996F));
                    builder.AddLine(new Vector2(0.624000013F, 2.26200008F));
                    builder.AddLine(new Vector2(0.524999976F, 2.32599998F));
                    builder.AddLine(new Vector2(0.493000001F, 2.3440001F));
                    builder.AddLine(new Vector2(0.395999998F, 2.40700006F));
                    builder.AddLine(new Vector2(0.363000005F, 2.42600012F));
                    builder.AddLine(new Vector2(0.26699999F, 2.48600006F));
                    builder.AddLine(new Vector2(0.233999997F, 2.50699997F));
                    builder.AddLine(new Vector2(0.136999995F, 2.56800008F));
                    builder.AddLine(new Vector2(0.104999997F, 2.58699989F));
                    builder.AddLine(new Vector2(0.00700000022F, 2.648F));
                    builder.AddLine(new Vector2(-0.0250000004F, 2.66700006F));
                    builder.AddLine(new Vector2(-0.123999998F, 2.727F));
                    builder.AddLine(new Vector2(-0.153999999F, 2.74499989F));
                    builder.AddLine(new Vector2(-0.254999995F, 2.80800009F));
                    builder.AddLine(new Vector2(-0.282999992F, 2.82500005F));
                    builder.AddLine(new Vector2(-0.388000011F, 2.88700008F));
                    builder.AddLine(new Vector2(-0.412999988F, 2.90300012F));
                    builder.AddLine(new Vector2(-0.519999981F, 2.96799994F));
                    builder.AddLine(new Vector2(-0.542999983F, 2.98099995F));
                    builder.AddLine(new Vector2(-0.654999971F, 3.0480001F));
                    builder.AddLine(new Vector2(-0.674000025F, 3.05900002F));
                    builder.AddLine(new Vector2(-0.791999996F, 3.12800002F));
                    builder.AddLine(new Vector2(-0.805000007F, 3.13599992F));
                    builder.AddLine(new Vector2(-0.934000015F, 3.21199989F));
                    builder.AddLine(new Vector2(-0.934000015F, 3.21300006F));
                    builder.AddCubicBezier(new Vector2(-1.41999996F, 3.49799991F), new Vector2(-1.90999997F, 3.7750001F), new Vector2(-2.40400004F, 4.046F));
                    builder.AddLine(new Vector2(-2.40799999F, 4.04799986F));
                    builder.AddLine(new Vector2(-2.53800011F, 4.11899996F));
                    builder.AddLine(new Vector2(-2.546F, 4.12300014F));
                    builder.AddLine(new Vector2(-2.67400002F, 4.19199991F));
                    builder.AddLine(new Vector2(-2.68199992F, 4.1960001F));
                    builder.AddLine(new Vector2(-2.80900002F, 4.26499987F));
                    builder.AddLine(new Vector2(-2.81599998F, 4.26900005F));
                    builder.AddLine(new Vector2(-2.94300008F, 4.33699989F));
                    builder.AddLine(new Vector2(-2.95099998F, 4.34000015F));
                    builder.AddLine(new Vector2(-3.079F, 4.40799999F));
                    builder.AddLine(new Vector2(-3.08599997F, 4.41200018F));
                    builder.AddLine(new Vector2(-3.21700001F, 4.48099995F));
                    builder.AddLine(new Vector2(-3.22300005F, 4.48400021F));
                    builder.AddLine(new Vector2(-3.35400009F, 4.5539999F));
                    builder.AddLine(new Vector2(-3.35599995F, 4.55499983F));
                    builder.AddCubicBezier(new Vector2(-3.62800002F, 4.69799995F), new Vector2(-3.90199995F, 4.83799982F), new Vector2(-4.17799997F, 4.97599983F));
                    builder.AddCubicBezier(new Vector2(-3.55800009F, 3.78500009F), new Vector2(-3.61999989F, 2.29900002F), new Vector2(-3.82800007F, 0.916999996F));
                    builder.AddCubicBezier(new Vector2(-3.85299993F, 0.745999992F), new Vector2(-3.88100004F, 0.577000022F), new Vector2(-3.91199994F, 0.405999988F));
                    builder.AddCubicBezier(new Vector2(-1.75399995F, -0.989000022F), new Vector2(0.300999999F, -2.54500008F), new Vector2(2.2190001F, -4.28299999F));
                    builder.AddCubicBezier(new Vector2(2.47099996F, -4.51000023F), new Vector2(2.7190001F, -4.7420001F), new Vector2(2.96300006F, -4.97599983F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 15 Offset:<371.829, 243.74>
            CanvasGeometry Geometry_47()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(14.6630001F, -12.2580004F));
                    builder.AddCubicBezier(new Vector2(15.5790005F, -10.7589998F), new Vector2(16.5090008F, -9.26299953F), new Vector2(17.4440002F, -7.76300001F));
                    builder.AddCubicBezier(new Vector2(18.0849991F, -6.73199987F), new Vector2(18.7150002F, -5.69199991F), new Vector2(19.3279991F, -4.6420002F));
                    builder.AddCubicBezier(new Vector2(17.5650005F, -4.66900015F), new Vector2(15.7530003F, -4.33099985F), new Vector2(14.0089998F, -3.9690001F));
                    builder.AddCubicBezier(new Vector2(7.86399984F, -2.69700003F), new Vector2(1.98099995F, -0.182999998F), new Vector2(-3.46099997F, 3.01999998F));
                    builder.AddCubicBezier(new Vector2(-7.70900011F, 5.51999998F), new Vector2(-11.8140001F, 8.45499992F), new Vector2(-14.9440002F, 12.2580004F));
                    builder.AddLine(new Vector2(-14.9960003F, 12.1750002F));
                    builder.AddCubicBezier(new Vector2(-16.3110008F, 10.0679998F), new Vector2(-17.8069992F, 7.62200022F), new Vector2(-19.3279991F, 5.1170001F));
                    builder.AddCubicBezier(new Vector2(-13.1709995F, -1.38199997F), new Vector2(-4.99100018F, -5.9369998F), new Vector2(3.20300007F, -9.09000015F));
                    builder.AddCubicBezier(new Vector2(6.91699982F, -10.5190001F), new Vector2(10.7670002F, -11.6879997F), new Vector2(14.6630001F, -12.2580004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 14 Offset:<365.295, 244.773>
            CanvasGeometry Geometry_48()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(12.7939997F, -11.2250004F));
                    builder.AddCubicBezier(new Vector2(10.6450005F, -6.80999994F), new Vector2(8.04300022F, -2.64899993F), new Vector2(4.78499985F, 1.00999999F));
                    builder.AddCubicBezier(new Vector2(4.21000004F, 1.32700002F), new Vector2(3.63899994F, 1.65400004F), new Vector2(3.07299995F, 1.98699999F));
                    builder.AddCubicBezier(new Vector2(-1.17499995F, 4.48699999F), new Vector2(-5.27899981F, 7.42199993F), new Vector2(-8.40999985F, 11.2250004F));
                    builder.AddLine(new Vector2(-8.46199989F, 11.1420002F));
                    builder.AddLine(new Vector2(-8.75500011F, 10.6709995F));
                    builder.AddLine(new Vector2(-8.84000015F, 10.533F));
                    builder.AddLine(new Vector2(-9.0710001F, 10.1610003F));
                    builder.AddLine(new Vector2(-9.14299965F, 10.0450001F));
                    builder.AddCubicBezier(new Vector2(-9.35499954F, 9.70199966F), new Vector2(-9.5710001F, 9.35400009F), new Vector2(-9.78999996F, 9F));
                    builder.AddLine(new Vector2(-9.84500027F, 8.9090004F));
                    builder.AddLine(new Vector2(-9.86800003F, 8.87199974F));
                    builder.AddLine(new Vector2(-9.93700027F, 8.75800037F));
                    builder.AddLine(new Vector2(-9.99199963F, 8.67199993F));
                    builder.AddLine(new Vector2(-10.1000004F, 8.49499989F));
                    builder.AddLine(new Vector2(-10.1280003F, 8.44999981F));
                    builder.AddLine(new Vector2(-10.1879997F, 8.35000038F));
                    builder.AddCubicBezier(new Vector2(-10.4350004F, 7.94899988F), new Vector2(-10.6850004F, 7.54300022F), new Vector2(-10.9359999F, 7.13000011F));
                    builder.AddLine(new Vector2(-10.993F, 7.03800011F));
                    builder.AddLine(new Vector2(-11.0439997F, 6.95599985F));
                    builder.AddLine(new Vector2(-11.1470003F, 6.78599977F));
                    builder.AddLine(new Vector2(-11.2539997F, 6.61199999F));
                    builder.AddLine(new Vector2(-11.2770004F, 6.57499981F));
                    builder.AddLine(new Vector2(-11.2869997F, 6.55900002F));
                    builder.AddLine(new Vector2(-11.3500004F, 6.454F));
                    builder.AddLine(new Vector2(-11.5220003F, 6.171F));
                    builder.AddLine(new Vector2(-11.632F, 5.99300003F));
                    builder.AddLine(new Vector2(-11.7180004F, 5.85099983F));
                    builder.AddLine(new Vector2(-12.1859999F, 5.08099985F));
                    builder.AddLine(new Vector2(-12.2089996F, 5.046F));
                    builder.AddCubicBezier(new Vector2(-12.4029999F, 4.72700024F), new Vector2(-12.5979996F, 4.40600014F), new Vector2(-12.7939997F, 4.08400011F));
                    builder.AddCubicBezier(new Vector2(-11.4560003F, 2.671F), new Vector2(-10.0209999F, 1.35000002F), new Vector2(-8.51299953F, 0.115999997F));
                    builder.AddCubicBezier(new Vector2(-8.33100033F, 0.416999996F), new Vector2(-8.14799976F, 0.717999995F), new Vector2(-7.96500015F, 1.02100003F));
                    builder.AddCubicBezier(new Vector2(-4.92299986F, -0.36500001F), new Vector2(-2.38899994F, -2.83500004F), new Vector2(-0.307000011F, -5.4380002F));
                    builder.AddCubicBezier(new Vector2(2.94300008F, -7.2670002F), new Vector2(6.33900023F, -8.81599998F), new Vector2(9.73700047F, -10.1230001F));
                    builder.AddCubicBezier(new Vector2(10.7460003F, -10.5109997F), new Vector2(11.7659998F, -10.882F), new Vector2(12.7939997F, -11.2250004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 13 Offset:<419.59, 226.196>
            CanvasGeometry Geometry_49()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(11.9379997F, -15.9560003F));
                    builder.AddCubicBezier(new Vector2(12.6610003F, -15.151F), new Vector2(13.3149996F, -14.382F), new Vector2(13.875F, -13.6709995F));
                    builder.AddCubicBezier(new Vector2(14.9840002F, -12.2639999F), new Vector2(16.0550003F, -10.823F), new Vector2(17.0820007F, -9.35000038F));
                    builder.AddCubicBezier(new Vector2(15.2270002F, -8.69999981F), new Vector2(13.4729996F, -7.92000008F), new Vector2(11.9180002F, -7.17399979F));
                    builder.AddCubicBezier(new Vector2(1.70200002F, -2.273F), new Vector2(-7.25199986F, 5.51900005F), new Vector2(-11.9049997F, 15.9560003F));
                    builder.AddCubicBezier(new Vector2(-12.2119999F, 15.4209995F), new Vector2(-12.5310001F, 14.8950005F), new Vector2(-12.8540001F, 14.3780003F));
                    builder.AddCubicBezier(new Vector2(-14.1370001F, 12.3360004F), new Vector2(-15.5500002F, 10.3839998F), new Vector2(-17.0809994F, 8.52499962F));
                    builder.AddCubicBezier(new Vector2(-11.1090002F, -1.73699999F), new Vector2(-1.29499996F, -9.86499977F), new Vector2(9.07999992F, -14.724F));
                    builder.AddCubicBezier(new Vector2(10.0179996F, -15.1569996F), new Vector2(10.9729996F, -15.5710001F), new Vector2(11.9379997F, -15.9560003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 12 Offset:<419.59, 227.285>
            CanvasGeometry Geometry_50()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(13.875F, -14.7609997F));
                    builder.AddLine(new Vector2(14.0609999F, -14.5240002F));
                    builder.AddLine(new Vector2(14.1149998F, -14.4549999F));
                    builder.AddLine(new Vector2(14.2550001F, -14.2749996F));
                    builder.AddLine(new Vector2(14.3050003F, -14.21F));
                    builder.AddLine(new Vector2(14.4899998F, -13.9720001F));
                    builder.AddLine(new Vector2(14.5139999F, -13.9399996F));
                    builder.AddLine(new Vector2(14.6739998F, -13.7309999F));
                    builder.AddLine(new Vector2(14.7290001F, -13.6610003F));
                    builder.AddLine(new Vector2(14.8730001F, -13.4729996F));
                    builder.AddLine(new Vector2(14.9219999F, -13.4069996F));
                    builder.AddLine(new Vector2(14.9569998F, -13.3620005F));
                    builder.AddLine(new Vector2(15.0629997F, -13.2220001F));
                    builder.AddLine(new Vector2(15.0930004F, -13.1800003F));
                    builder.AddLine(new Vector2(15.2209997F, -13.0109997F));
                    builder.AddLine(new Vector2(15.2559996F, -12.9639997F));
                    builder.AddLine(new Vector2(15.3579998F, -12.8290005F));
                    builder.AddLine(new Vector2(15.3950005F, -12.7799997F));
                    builder.AddLine(new Vector2(15.5190001F, -12.6129999F));
                    builder.AddLine(new Vector2(15.5550003F, -12.5629997F));
                    builder.AddLine(new Vector2(15.651F, -12.4350004F));
                    builder.AddLine(new Vector2(15.6940002F, -12.3760004F));
                    builder.AddLine(new Vector2(15.8140001F, -12.2130003F));
                    builder.AddLine(new Vector2(15.8540001F, -12.158F));
                    builder.AddLine(new Vector2(15.941F, -12.0389996F));
                    builder.AddLine(new Vector2(15.9919996F, -11.9700003F));
                    builder.AddLine(new Vector2(16.0979996F, -11.8240004F));
                    builder.AddLine(new Vector2(16.1070004F, -11.8109999F));
                    builder.AddLine(new Vector2(16.1539993F, -11.7469997F));
                    builder.AddLine(new Vector2(16.2299995F, -11.6420002F));
                    builder.AddLine(new Vector2(16.2880001F, -11.5600004F));
                    builder.AddLine(new Vector2(16.3619995F, -11.4580002F));
                    builder.AddLine(new Vector2(16.4020004F, -11.4020004F));
                    builder.AddLine(new Vector2(16.4559994F, -11.3269997F));
                    builder.AddLine(new Vector2(16.5160007F, -11.243F));
                    builder.AddLine(new Vector2(16.5849991F, -11.1459999F));
                    builder.AddLine(new Vector2(16.632F, -11.0780001F));
                    builder.AddLine(new Vector2(16.6949997F, -10.9910002F));
                    builder.AddLine(new Vector2(16.7639999F, -10.8920002F));
                    builder.AddLine(new Vector2(16.7980003F, -10.8430004F));
                    builder.AddLine(new Vector2(16.8799992F, -10.7279997F));
                    builder.AddLine(new Vector2(16.9069996F, -10.691F));
                    builder.AddCubicBezier(new Vector2(16.9640007F, -10.6070004F), new Vector2(17.0240002F, -10.5229998F), new Vector2(17.0820007F, -10.4399996F));
                    builder.AddCubicBezier(new Vector2(15.2270002F, -9.78999996F), new Vector2(13.4729996F, -9.01000023F), new Vector2(11.9180002F, -8.26399994F));
                    builder.AddCubicBezier(new Vector2(8.79300022F, -6.76499987F), new Vector2(5.78800011F, -4.99599981F), new Vector2(2.98600006F, -2.96300006F));
                    builder.AddCubicBezier(new Vector2(-0.326000005F, -2.50600004F), new Vector2(-3.68799996F, -2.34899998F), new Vector2(-7.03900003F, -2.41300011F));
                    builder.AddCubicBezier(new Vector2(-7.87300014F, -2.42799997F), new Vector2(-8.70899963F, -2.45700002F), new Vector2(-9.54599953F, -2.5F));
                    builder.AddCubicBezier(new Vector2(-6.62200022F, -5.55700016F), new Vector2(-3.35800004F, -8.29599953F), new Vector2(0.0960000008F, -10.6669998F));
                    builder.AddCubicBezier(new Vector2(2.3499999F, -10.9259996F), new Vector2(4.58500004F, -11.335F), new Vector2(6.78200006F, -11.8929996F));
                    builder.AddCubicBezier(new Vector2(9.27999973F, -12.5279999F), new Vector2(11.8389997F, -13.342F), new Vector2(13.7919998F, -14.8660002F));
                    builder.AddLine(new Vector2(13.875F, -14.7609997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-14.0190001F, 2.79399991F));
                    builder.AddCubicBezier(new Vector2(-12.2019997F, 5.046F), new Vector2(-10.3900003F, 7.34499979F), new Vector2(-8.89999962F, 9.34599972F));
                    builder.AddCubicBezier(new Vector2(-10.0360003F, 11.0950003F), new Vector2(-11.0430002F, 12.9350004F), new Vector2(-11.9049997F, 14.8660002F));
                    builder.AddLine(new Vector2(-11.9630003F, 14.7629995F));
                    builder.AddLine(new Vector2(-12.0050001F, 14.6920004F));
                    builder.AddLine(new Vector2(-12.0200005F, 14.6660004F));
                    builder.AddLine(new Vector2(-12.0380001F, 14.6370001F));
                    builder.AddLine(new Vector2(-12.073F, 14.5760002F));
                    builder.AddLine(new Vector2(-12.1020002F, 14.526F));
                    builder.AddLine(new Vector2(-12.1370001F, 14.4659996F));
                    builder.AddLine(new Vector2(-12.1490002F, 14.4460001F));
                    builder.AddLine(new Vector2(-12.1820002F, 14.3900003F));
                    builder.AddLine(new Vector2(-12.2320004F, 14.3050003F));
                    builder.AddLine(new Vector2(-12.2539997F, 14.2679996F));
                    builder.AddLine(new Vector2(-12.2670002F, 14.2460003F));
                    builder.AddLine(new Vector2(-12.2919998F, 14.2040005F));
                    builder.AddLine(new Vector2(-12.3450003F, 14.1169996F));
                    builder.AddLine(new Vector2(-12.3730001F, 14.0699997F));
                    builder.AddLine(new Vector2(-12.3850002F, 14.0500002F));
                    builder.AddLine(new Vector2(-12.4040003F, 14.0200005F));
                    builder.AddLine(new Vector2(-12.4589996F, 13.9280005F));
                    builder.AddLine(new Vector2(-12.493F, 13.8730001F));
                    builder.AddLine(new Vector2(-12.5019999F, 13.8570004F));
                    builder.AddLine(new Vector2(-12.5150003F, 13.8360004F));
                    builder.AddLine(new Vector2(-12.5769997F, 13.7360001F));
                    builder.AddLine(new Vector2(-12.6129999F, 13.677F));
                    builder.AddLine(new Vector2(-12.6199999F, 13.6660004F));
                    builder.AddLine(new Vector2(-12.6269999F, 13.6520004F));
                    builder.AddLine(new Vector2(-12.7010002F, 13.5369997F));
                    builder.AddLine(new Vector2(-12.7329998F, 13.4820004F));
                    builder.AddLine(new Vector2(-12.7379999F, 13.4759998F));
                    builder.AddCubicBezier(new Vector2(-12.7770004F, 13.4139996F), new Vector2(-12.8149996F, 13.3509998F), new Vector2(-12.8540001F, 13.2880001F));
                    builder.AddCubicBezier(new Vector2(-12.8900003F, 13.2309999F), new Vector2(-12.9259996F, 13.1739998F), new Vector2(-12.9619999F, 13.118F));
                    builder.AddLine(new Vector2(-12.9750004F, 13.0970001F));
                    builder.AddLine(new Vector2(-12.993F, 13.0699997F));
                    builder.AddLine(new Vector2(-13.0270004F, 13.0150003F));
                    builder.AddLine(new Vector2(-13.0799999F, 12.934F));
                    builder.AddLine(new Vector2(-13.0959997F, 12.9069996F));
                    builder.AddLine(new Vector2(-13.1029997F, 12.8959999F));
                    builder.AddCubicBezier(new Vector2(-13.1389999F, 12.8389997F), new Vector2(-13.1750002F, 12.783F), new Vector2(-13.2110004F, 12.7270002F));
                    builder.AddLine(new Vector2(-13.2180004F, 12.7159996F));
                    builder.AddLine(new Vector2(-13.2370005F, 12.6890001F));
                    builder.AddLine(new Vector2(-13.2889996F, 12.6079998F));
                    builder.AddLine(new Vector2(-13.3260002F, 12.5539999F));
                    builder.AddLine(new Vector2(-13.3409996F, 12.5270004F));
                    builder.AddLine(new Vector2(-13.3540001F, 12.507F));
                    builder.AddCubicBezier(new Vector2(-13.4280005F, 12.3940001F), new Vector2(-13.5019999F, 12.2810001F), new Vector2(-13.5769997F, 12.1689997F));
                    builder.AddLine(new Vector2(-13.5889997F, 12.1490002F));
                    builder.AddLine(new Vector2(-13.6070004F, 12.1219997F));
                    builder.AddLine(new Vector2(-13.6429996F, 12.0690002F));
                    builder.AddLine(new Vector2(-13.698F, 11.9879999F));
                    builder.AddLine(new Vector2(-13.7139997F, 11.9610004F));
                    builder.AddLine(new Vector2(-13.7220001F, 11.9510002F));
                    builder.AddCubicBezier(new Vector2(-13.7589998F, 11.8950005F), new Vector2(-13.7959995F, 11.8400002F), new Vector2(-13.8330002F, 11.7840004F));
                    builder.AddLine(new Vector2(-13.8400002F, 11.7740002F));
                    builder.AddLine(new Vector2(-13.8579998F, 11.7469997F));
                    builder.AddLine(new Vector2(-13.9139996F, 11.6669998F));
                    builder.AddLine(new Vector2(-13.9510002F, 11.6129999F));
                    builder.AddLine(new Vector2(-13.967F, 11.5869999F));
                    builder.AddLine(new Vector2(-13.9799995F, 11.5670004F));
                    builder.AddCubicBezier(new Vector2(-14.0559998F, 11.4560003F), new Vector2(-14.1330004F, 11.3450003F), new Vector2(-14.2089996F, 11.2340002F));
                    builder.AddLine(new Vector2(-14.2229996F, 11.2150002F));
                    builder.AddLine(new Vector2(-14.2410002F, 11.1890001F));
                    builder.AddLine(new Vector2(-14.2790003F, 11.1350002F));
                    builder.AddLine(new Vector2(-14.3339996F, 11.0539999F));
                    builder.AddLine(new Vector2(-14.3509998F, 11.0290003F));
                    builder.AddLine(new Vector2(-14.3579998F, 11.0190001F));
                    builder.AddCubicBezier(new Vector2(-14.3970003F, 10.9639997F), new Vector2(-14.4350004F, 10.9090004F), new Vector2(-14.474F, 10.8540001F));
                    builder.AddLine(new Vector2(-14.4809999F, 10.8439999F));
                    builder.AddLine(new Vector2(-14.4980001F, 10.8199997F));
                    builder.AddLine(new Vector2(-14.5550003F, 10.7390003F));
                    builder.AddLine(new Vector2(-14.5939999F, 10.6850004F));
                    builder.AddLine(new Vector2(-14.6120005F, 10.6599998F));
                    builder.AddLine(new Vector2(-14.625F, 10.6420002F));
                    builder.AddCubicBezier(new Vector2(-14.7040005F, 10.5310001F), new Vector2(-14.783F, 10.4209995F), new Vector2(-14.8620005F, 10.3109999F));
                    builder.AddLine(new Vector2(-14.8739996F, 10.2930002F));
                    builder.AddLine(new Vector2(-14.8920002F, 10.2690001F));
                    builder.AddLine(new Vector2(-14.9309998F, 10.2150002F));
                    builder.AddLine(new Vector2(-14.9919996F, 10.1330004F));
                    builder.AddLine(new Vector2(-15.007F, 10.1110001F));
                    builder.AddLine(new Vector2(-15.0129995F, 10.1020002F));
                    builder.AddCubicBezier(new Vector2(-15.0530005F, 10.0469999F), new Vector2(-15.0939999F, 9.99199963F), new Vector2(-15.1339998F, 9.93700027F));
                    builder.AddLine(new Vector2(-15.1400003F, 9.92800045F));
                    builder.AddLine(new Vector2(-15.1569996F, 9.90699959F));
                    builder.AddLine(new Vector2(-15.217F, 9.82499981F));
                    builder.AddLine(new Vector2(-15.2580004F, 9.76900005F));
                    builder.AddLine(new Vector2(-15.2740002F, 9.74699974F));
                    builder.AddLine(new Vector2(-15.2880001F, 9.72999954F));
                    builder.AddCubicBezier(new Vector2(-15.3690004F, 9.61999989F), new Vector2(-15.4510002F, 9.51099968F), new Vector2(-15.533F, 9.40100002F));
                    builder.AddLine(new Vector2(-15.5439997F, 9.38500023F));
                    builder.AddLine(new Vector2(-15.5600004F, 9.36499977F));
                    builder.AddLine(new Vector2(-15.6029997F, 9.30799961F));
                    builder.AddLine(new Vector2(-15.6669998F, 9.22299957F));
                    builder.AddLine(new Vector2(-15.6800003F, 9.20499992F));
                    builder.AddLine(new Vector2(-15.6859999F, 9.19799995F));
                    builder.AddCubicBezier(new Vector2(-15.7279997F, 9.14299965F), new Vector2(-15.7700005F, 9.0880003F), new Vector2(-15.8120003F, 9.03199959F));
                    builder.AddLine(new Vector2(-15.8170004F, 9.02600002F));
                    builder.AddLine(new Vector2(-15.8310003F, 9.01000023F));
                    builder.AddLine(new Vector2(-15.8959999F, 8.92399979F));
                    builder.AddLine(new Vector2(-15.941F, 8.86600018F));
                    builder.AddLine(new Vector2(-15.9560003F, 8.84700012F));
                    builder.AddLine(new Vector2(-15.9650002F, 8.83300018F));
                    builder.AddCubicBezier(new Vector2(-16.0510006F, 8.72299957F), new Vector2(-16.1359997F, 8.61299992F), new Vector2(-16.2220001F, 8.50300026F));
                    builder.AddLine(new Vector2(-16.2320004F, 8.49100018F));
                    builder.AddLine(new Vector2(-16.2460003F, 8.47500038F));
                    builder.AddLine(new Vector2(-16.2919998F, 8.41499996F));
                    builder.AddLine(new Vector2(-16.3649998F, 8.32400036F));
                    builder.AddLine(new Vector2(-16.3729992F, 8.31400013F));
                    builder.AddLine(new Vector2(-16.375F, 8.31000042F));
                    builder.AddCubicBezier(new Vector2(-16.4200001F, 8.25300026F), new Vector2(-16.4640007F, 8.19699955F), new Vector2(-16.5090008F, 8.14000034F));
                    builder.AddLine(new Vector2(-16.5119991F, 8.13700008F));
                    builder.AddLine(new Vector2(-16.5189991F, 8.12899971F));
                    builder.AddLine(new Vector2(-16.5919991F, 8.03600025F));
                    builder.AddLine(new Vector2(-16.6429996F, 7.97399998F));
                    builder.AddLine(new Vector2(-16.6539993F, 7.96099997F));
                    builder.AddLine(new Vector2(-16.6620007F, 7.95100021F));
                    builder.AddCubicBezier(new Vector2(-16.75F, 7.84000015F), new Vector2(-16.8409996F, 7.72800016F), new Vector2(-16.9309998F, 7.6170001F));
                    builder.AddLine(new Vector2(-16.9379997F, 7.61000013F));
                    builder.AddLine(new Vector2(-16.9459991F, 7.5999999F));
                    builder.AddLine(new Vector2(-16.9979992F, 7.53499985F));
                    builder.AddLine(new Vector2(-17.0809994F, 7.43499994F));
                    builder.AddCubicBezier(new Vector2(-16.1490002F, 5.83500004F), new Vector2(-15.1239996F, 4.28599977F), new Vector2(-14.0190001F, 2.79399991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 11 Offset:<336.857, 112.722>
            CanvasGeometry Geometry_51()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-49.6150017F, 18.8390007F));
                    builder.AddCubicBezier(new Vector2(-49.7820015F, 18.4389992F), new Vector2(-49.9449997F, 18.0359993F), new Vector2(-50.1030006F, 17.6289997F));
                    builder.AddCubicBezier(new Vector2(-60.4029999F, -8.8760004F), new Vector2(-45.8660011F, -39.2929993F), new Vector2(-17.6609993F, -50.2529984F));
                    builder.AddCubicBezier(new Vector2(-3.24499989F, -55.8549995F), new Vector2(11.9700003F, -55.2970009F), new Vector2(24.7759991F, -49.8730011F));
                    builder.AddCubicBezier(new Vector2(33.9459991F, -46.9230003F), new Vector2(40.4669991F, -41.4510002F), new Vector2(45.5559998F, -34.9049988F));
                    builder.AddCubicBezier(new Vector2(52.6879997F, -25.7320004F), new Vector2(60.0219994F, -4.94099998F), new Vector2(60.223999F, 6.67600012F));
                    builder.AddCubicBezier(new Vector2(60.4039993F, 17.0680008F), new Vector2(55.348999F, 28.9400005F), new Vector2(46.7669983F, 34.8009987F));
                    builder.AddCubicBezier(new Vector2(34.9640007F, 42.8600006F), new Vector2(3.6559999F, 53.9039993F), new Vector2(-10.592F, 55.0330009F));
                    builder.AddCubicBezier(new Vector2(-20.9510002F, 55.8549995F), new Vector2(-32.3380013F, 49.7809982F), new Vector2(-38.7169991F, 41.5769997F));
                    builder.AddCubicBezier(new Vector2(-42.7179985F, 36.4300003F), new Vector2(-46.7809982F, 27.6270008F), new Vector2(-49.6150017F, 18.8390007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 10 Offset:<337.624, 110.002>
            CanvasGeometry Geometry_52()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-48.6819992F, 9.06000042F));
                    builder.AddCubicBezier(new Vector2(-49.0909996F, 6.72200012F), new Vector2(-49.3040009F, 4.53299999F), new Vector2(-49.2849998F, 2.66199994F));
                    builder.AddCubicBezier(new Vector2(-49.1940002F, -5.66499996F), new Vector2(-43.8339996F, -16.5790005F), new Vector2(-36.3880005F, -21.5270004F));
                    builder.AddCubicBezier(new Vector2(-23.3990002F, -30.1609993F), new Vector2(4.83599997F, -40.2490005F), new Vector2(18.8129997F, -39.7779999F));
                    builder.AddCubicBezier(new Vector2(30.7140007F, -39.3759995F), new Vector2(35.8919983F, -36.144001F), new Vector2(41.0540009F, -30.7469997F));
                    builder.AddCubicBezier(new Vector2(42.2809982F, -29.4640007F), new Vector2(43.5340004F, -27.8180008F), new Vector2(44.7389984F, -25.941F));
                    builder.AddCubicBezier(new Vector2(44.8479996F, -26.0230007F), new Vector2(44.9690018F, -26.0860004F), new Vector2(45.1010017F, -26.1270008F));
                    builder.AddCubicBezier(new Vector2(46.6790009F, -26.6280003F), new Vector2(49.1769981F, -23.9449997F), new Vector2(50.6759987F, -20.1389999F));
                    builder.AddCubicBezier(new Vector2(52.0340004F, -16.6940002F), new Vector2(52.1110001F, -13.5030003F), new Vector2(50.9430008F, -12.5570002F));
                    builder.AddCubicBezier(new Vector2(52.0900002F, -8.83500004F), new Vector2(52.7029991F, -5.22700024F), new Vector2(52.4560013F, -2.3210001F));
                    builder.AddCubicBezier(new Vector2(51.8230019F, 5.11999989F), new Vector2(47.2019997F, 15.0880003F), new Vector2(38.9609985F, 19.9510002F));
                    builder.AddCubicBezier(new Vector2(27.6289997F, 26.6380005F), new Vector2(-1.63900006F, 36.9620018F), new Vector2(-14.6599998F, 38.8650017F));
                    builder.AddCubicBezier(new Vector2(-24.1270008F, 40.2490005F), new Vector2(-33.9959984F, 36.7649994F), new Vector2(-39.1590004F, 31.368F));
                    builder.AddCubicBezier(new Vector2(-39.9070015F, 30.5860004F), new Vector2(-40.632F, 29.6620007F), new Vector2(-41.3279991F, 28.6299992F));
                    builder.AddCubicBezier(new Vector2(-41.9620018F, 27.691F), new Vector2(-42.5719986F, 26.6609993F), new Vector2(-43.1520004F, 25.5650005F));
                    builder.AddCubicBezier(new Vector2(-43.4109993F, 25.8460007F), new Vector2(-43.7130013F, 26.052F), new Vector2(-44.0569992F, 26.1709995F));
                    builder.AddCubicBezier(new Vector2(-46.2919998F, 26.9470005F), new Vector2(-49.4339981F, 23.7530003F), new Vector2(-51.0699997F, 19.0429993F));
                    builder.AddCubicBezier(new Vector2(-52.7029991F, 14.3330002F), new Vector2(-52.2150002F, 9.87899971F), new Vector2(-49.980999F, 9.10299969F));
                    builder.AddCubicBezier(new Vector2(-49.5730019F, 8.96199989F), new Vector2(-49.1349983F, 8.95300007F), new Vector2(-48.6819992F, 9.06000042F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 9 Offset:<339.633, 133.549>
            CanvasGeometry Geometry_53()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-54.1380005F, -35.0279999F));
                    builder.AddCubicBezier(new Vector2(-55.4860001F, -26.6159992F), new Vector2(-54.7089996F, -17.8600006F), new Vector2(-51.4580002F, -9.49300003F));
                    builder.AddCubicBezier(new Vector2(-51.2999992F, -9.08600044F), new Vector2(-51.1380005F, -8.68299961F), new Vector2(-50.9700012F, -8.28299999F));
                    builder.AddCubicBezier(new Vector2(-48.137001F, 0.504999995F), new Vector2(-44.0719986F, 9.30799961F), new Vector2(-40.0699997F, 14.4540005F));
                    builder.AddCubicBezier(new Vector2(-33.6910019F, 22.6590004F), new Vector2(-22.3069992F, 28.7320004F), new Vector2(-11.948F, 27.9109993F));
                    builder.AddCubicBezier(new Vector2(2.29900002F, 26.7819996F), new Vector2(33.6090012F, 15.7379999F), new Vector2(45.4109993F, 7.6789999F));
                    builder.AddCubicBezier(new Vector2(50.9329987F, 3.90799999F), new Vector2(54.9959984F, -2.352F), new Vector2(57.1419983F, -9.10400009F));
                    builder.AddCubicBezier(new Vector2(55.9280014F, -0.130999997F), new Vector2(51.2070007F, 9.04599953F), new Vector2(43.9910011F, 13.974F));
                    builder.AddCubicBezier(new Vector2(32.1879997F, 22.0330009F), new Vector2(0.879999995F, 33.0769997F), new Vector2(-13.3669996F, 34.2060013F));
                    builder.AddCubicBezier(new Vector2(-23.7269993F, 35.0279999F), new Vector2(-35.1139984F, 28.9540005F), new Vector2(-41.4920006F, 20.75F));
                    builder.AddCubicBezier(new Vector2(-45.493F, 15.6029997F), new Vector2(-49.5579987F, 6.80000019F), new Vector2(-52.3919983F, -1.98800004F));
                    builder.AddCubicBezier(new Vector2(-52.5589981F, -2.38800001F), new Vector2(-52.7220001F, -2.79099989F), new Vector2(-52.8800011F, -3.19799995F));
                    builder.AddCubicBezier(new Vector2(-56.9529991F, -13.6780005F), new Vector2(-57.1409988F, -24.7689991F), new Vector2(-54.1380005F, -35.0279999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 8 Offset:<340.134, 107.565>
            CanvasGeometry Geometry_54()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(39.1539993F, -30.7469997F));
                    builder.AddCubicBezier(new Vector2(33.9920006F, -36.144001F), new Vector2(28.8129997F, -39.3759995F), new Vector2(16.9130001F, -39.7779999F));
                    builder.AddCubicBezier(new Vector2(2.93499994F, -40.2490005F), new Vector2(-25.2989998F, -30.1609993F), new Vector2(-38.2890015F, -21.5270004F));
                    builder.AddCubicBezier(new Vector2(-45.7350006F, -16.5790005F), new Vector2(-51.0940018F, -5.66499996F), new Vector2(-51.1850014F, 2.66199994F));
                    builder.AddCubicBezier(new Vector2(-51.2630005F, 9.83699989F), new Vector2(-47.9070015F, 21.698F), new Vector2(-43.2290001F, 28.6299992F));
                    builder.AddCubicBezier(new Vector2(-42.5330009F, 29.6630001F), new Vector2(-41.8069992F, 30.5860004F), new Vector2(-41.0589981F, 31.368F));
                    builder.AddCubicBezier(new Vector2(-35.8969994F, 36.7649994F), new Vector2(-26.0279999F, 40.2490005F), new Vector2(-16.5599995F, 38.8650017F));
                    builder.AddCubicBezier(new Vector2(-3.53999996F, 36.9620018F), new Vector2(25.7280006F, 26.6380005F), new Vector2(37.0610008F, 19.9510002F));
                    builder.AddCubicBezier(new Vector2(45.2999992F, 15.0880003F), new Vector2(49.9220009F, 5.11999989F), new Vector2(50.5550003F, -2.3210001F));
                    builder.AddCubicBezier(new Vector2(51.2630005F, -10.6400003F), new Vector2(44.9249992F, -24.7129993F), new Vector2(39.1539993F, -30.7469997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 7 Offset:<291.215, 125.202>
            CanvasGeometry Geometry_55()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-2.96099997F, -8.5340004F));
                    builder.AddCubicBezier(new Vector2(-0.726000011F, -9.31000042F), new Vector2(2.41599989F, -6.11600018F), new Vector2(4.05100012F, -1.40600002F));
                    builder.AddCubicBezier(new Vector2(5.68499994F, 3.3039999F), new Vector2(5.19700003F, 7.75899982F), new Vector2(2.96199989F, 8.53499985F));
                    builder.AddCubicBezier(new Vector2(0.726999998F, 9.31000042F), new Vector2(-2.41599989F, 6.11600018F), new Vector2(-4.05100012F, 1.40600002F));
                    builder.AddCubicBezier(new Vector2(-5.68499994F, -3.3039999F), new Vector2(-5.19700003F, -7.75899982F), new Vector2(-2.96099997F, -8.5340004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 6 Offset:<290.643, 125.576>
            CanvasGeometry Geometry_56()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-2.77600002F, -8F));
                    builder.AddCubicBezier(new Vector2(-0.906000018F, -8.64900017F), new Vector2(1.85599995F, -5.59100008F), new Vector2(3.38800001F, -1.176F));
                    builder.AddCubicBezier(new Vector2(4.921F, 3.24000001F), new Vector2(4.64699984F, 7.35099983F), new Vector2(2.77699995F, 8F));
                    builder.AddCubicBezier(new Vector2(0.907000005F, 8.64900017F), new Vector2(-1.85500002F, 5.59100008F), new Vector2(-3.38700008F, 1.176F));
                    builder.AddCubicBezier(new Vector2(-4.921F, -3.24000001F), new Vector2(-4.64499998F, -7.35099983F), new Vector2(-2.77600002F, -8F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 5 Offset:<386.052, 88.334>
            CanvasGeometry Geometry_57()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-2.71700001F, -6.89599991F));
                    builder.AddCubicBezier(new Vector2(-4.29400015F, -6.39499998F), new Vector2(-4.3579998F, -2.89899993F), new Vector2(-2.85899997F, 0.907000005F));
                    builder.AddCubicBezier(new Vector2(-1.35899997F, 4.71299982F), new Vector2(1.13900006F, 7.39599991F), new Vector2(2.71700001F, 6.89499998F));
                    builder.AddCubicBezier(new Vector2(4.29400015F, 6.39400005F), new Vector2(4.3579998F, 2.898F), new Vector2(2.85800004F, -0.907999992F));
                    builder.AddCubicBezier(new Vector2(1.35899997F, -4.71400023F), new Vector2(-1.13900006F, -7.39699984F), new Vector2(-2.71700001F, -6.89599991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 4 Offset:<386.747, 88.063>
            CanvasGeometry Geometry_58()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-2.61100006F, -6.62799978F));
                    builder.AddCubicBezier(new Vector2(-4.03999996F, -6.17500019F), new Vector2(-4.02899981F, -2.83699989F), new Vector2(-2.58800006F, 0.82099998F));
                    builder.AddCubicBezier(new Vector2(-1.14699996F, 4.47900009F), new Vector2(1.18299997F, 7.08099985F), new Vector2(2.61199999F, 6.62699986F));
                    builder.AddCubicBezier(new Vector2(4.03900003F, 6.17299986F), new Vector2(4.02899981F, 2.83599997F), new Vector2(2.58699989F, -0.82099998F));
                    builder.AddCubicBezier(new Vector2(1.14600003F, -4.47900009F), new Vector2(-1.18200004F, -7.08199978F), new Vector2(-2.61100006F, -6.62799978F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 3 Offset:<340.61, 103.548>
            CanvasGeometry Geometry_59()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-47.6500015F, 1.47800004F));
                    builder.AddCubicBezier(new Vector2(-46.0569992F, -13.5880003F), new Vector2(-32.3310013F, -28.5949993F), new Vector2(-12.5039997F, -35.0940018F));
                    builder.AddCubicBezier(new Vector2(3.43400002F, -40.3180008F), new Vector2(19.4489994F, -38.7770004F), new Vector2(30.4179993F, -32.1549988F));
                    builder.AddCubicBezier(new Vector2(33.4690018F, -30.5160007F), new Vector2(35.9370003F, -28.4570007F), new Vector2(38.0569992F, -26.2409992F));
                    builder.AddCubicBezier(new Vector2(43.4119987F, -20.6429996F), new Vector2(48.1230011F, -6.954F), new Vector2(47.4669991F, 0.764999986F));
                    builder.AddCubicBezier(new Vector2(46.8790016F, 7.66900015F), new Vector2(41.4869995F, 16.9720001F), new Vector2(33.8400002F, 21.4839993F));
                    builder.AddCubicBezier(new Vector2(23.3260002F, 27.6889992F), new Vector2(-3.83200002F, 37.2680016F), new Vector2(-15.9130001F, 39.0340004F));
                    builder.AddCubicBezier(new Vector2(-24.698F, 40.3180008F), new Vector2(-33.855999F, 37.0849991F), new Vector2(-38.6450005F, 32.0779991F));
                    builder.AddCubicBezier(new Vector2(-43.9990005F, 26.4790001F), new Vector2(-48.1230011F, 13.092F), new Vector2(-48.0390015F, 5.44199991F));
                    builder.AddCubicBezier(new Vector2(-48.026001F, 4.19999981F), new Vector2(-47.8930016F, 2.86400008F), new Vector2(-47.6500015F, 1.47800004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 2 Offset:<360.173, 94.033>
            CanvasGeometry Geometry_60()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-40.2799988F, -22.2399998F));
                    builder.AddLine(new Vector2(13.0769997F, 31.1700001F));
                    builder.AddCubicBezier(new Vector2(13.0769997F, 31.1700001F), new Vector2(40.2799988F, 16.7169991F), new Vector2(22.5529995F, -10.158F));
                    builder.AddCubicBezier(new Vector2(22.5529995F, -10.158F), new Vector2(17.566F, -31.1700001F), new Vector2(-21.3029995F, -28.1009998F));
                    builder.AddCubicBezier(new Vector2(-21.3029995F, -28.1009998F), new Vector2(-36.3860016F, -24.4470005F), new Vector2(-40.2799988F, -22.2399998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Group 1 Offset:<375.5, 187.5>
            CanvasGeometry Geometry_61()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(24.4680004F, 4.829F));
                    builder.AddLine(new Vector2(-13.5349998F, 20.9470005F));
                    builder.AddCubicBezier(new Vector2(-16.7560005F, 22.3129997F), new Vector2(-20.5079994F, 20.7959995F), new Vector2(-21.8740005F, 17.5760002F));
                    builder.AddLine(new Vector2(-27.8400002F, 3.5079999F));
                    builder.AddCubicBezier(new Vector2(-29.2059994F, 0.287999988F), new Vector2(-27.6879997F, -3.46399999F), new Vector2(-24.4680004F, -4.82999992F));
                    builder.AddLine(new Vector2(13.5349998F, -20.9470005F));
                    builder.AddCubicBezier(new Vector2(16.7560005F, -22.3129997F), new Vector2(20.5079994F, -20.7959995F), new Vector2(21.8740005F, -17.5760002F));
                    builder.AddLine(new Vector2(27.8400002F, -3.5079999F));
                    builder.AddCubicBezier(new Vector2(29.2059994F, -0.287999988F), new Vector2(27.6889992F, 3.46300006F), new Vector2(24.4680004F, 4.829F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // Color bound to theme property value: Color_000000
            CompositionColorBrush ThemeColor_Color_000000()
            {
                if (_themeColor_Color_000000 != null) { return _themeColor_Color_000000; }
                var result = _themeColor_Color_000000 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_000000, "Color", "ColorRGB(_theme.Color_000000.W,_theme.Color_000000.X,_theme.Color_000000.Y,_theme.Color_000000.Z)", "_theme", _themeProperties);
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<247.975, 238.895>
            // Color bound to theme property value: Color_160E53
            CompositionColorBrush ThemeColor_Color_160E53_0()
            {
                if (_themeColor_Color_160E53_0 != null) { return _themeColor_Color_160E53_0; }
                var result = _themeColor_Color_160E53_0 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_160E53_0, "Color", "ColorRGB(_theme.Color_160E53.W*0.1,_theme.Color_160E53.X,_theme.Color_160E53.Y,_theme.Color_160E53.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_160E53
            CompositionColorBrush ThemeColor_Color_160E53_1()
            {
                if (_themeColor_Color_160E53_1 != null) { return _themeColor_Color_160E53_1; }
                var result = _themeColor_Color_160E53_1 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_160E53_1, "Color", "ColorRGB(_theme.Color_160E53.W,_theme.Color_160E53.X,_theme.Color_160E53.Y,_theme.Color_160E53.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_190202
            CompositionColorBrush ThemeColor_Color_190202()
            {
                if (_themeColor_Color_190202 != null) { return _themeColor_Color_190202; }
                var result = _themeColor_Color_190202 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_190202, "Color", "ColorRGB(_theme.Color_190202.W,_theme.Color_190202.X,_theme.Color_190202.Y,_theme.Color_190202.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_261C6A
            CompositionColorBrush ThemeColor_Color_261C6A()
            {
                if (_themeColor_Color_261C6A != null) { return _themeColor_Color_261C6A; }
                var result = _themeColor_Color_261C6A = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_261C6A, "Color", "ColorRGB(_theme.Color_261C6A.W,_theme.Color_261C6A.X,_theme.Color_261C6A.Y,_theme.Color_261C6A.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_334F6C
            CompositionColorBrush ThemeColor_Color_334F6C()
            {
                if (_themeColor_Color_334F6C != null) { return _themeColor_Color_334F6C; }
                var result = _themeColor_Color_334F6C = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_334F6C, "Color", "ColorRGB(_theme.Color_334F6C.W,_theme.Color_334F6C.X,_theme.Color_334F6C.Y,_theme.Color_334F6C.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_465F7A
            CompositionColorBrush ThemeColor_Color_465F7A()
            {
                if (_themeColor_Color_465F7A != null) { return _themeColor_Color_465F7A; }
                var result = _themeColor_Color_465F7A = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_465F7A, "Color", "ColorRGB(_theme.Color_465F7A.W,_theme.Color_465F7A.X,_theme.Color_465F7A.Y,_theme.Color_465F7A.Z)", "_theme", _themeProperties);
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 19 Offset:<167.14, 150.7>
            // Color bound to theme property value: Color_5B6C7E
            CompositionColorBrush ThemeColor_Color_5B6C7E()
            {
                if (_themeColor_Color_5B6C7E != null) { return _themeColor_Color_5B6C7E; }
                var result = _themeColor_Color_5B6C7E = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_5B6C7E, "Color", "ColorRGB(_theme.Color_5B6C7E.W,_theme.Color_5B6C7E.X,_theme.Color_5B6C7E.Y,_theme.Color_5B6C7E.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_B3FCC8
            CompositionColorBrush ThemeColor_Color_B3FCC8_0()
            {
                if (_themeColor_Color_B3FCC8_0 != null) { return _themeColor_Color_B3FCC8_0; }
                var result = _themeColor_Color_B3FCC8_0 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_B3FCC8_0, "Color", "ColorRGB(_theme.Color_B3FCC8.W,_theme.Color_B3FCC8.X,_theme.Color_B3FCC8.Y,_theme.Color_B3FCC8.Z)", "_theme", _themeProperties);
                return result;
            }

            // - - Layer aggregator
            // ShapeGroup: Group 1 Offset:<249.659, 251.362>
            // Color bound to theme property value: Color_B3FCC8
            CompositionColorBrush ThemeColor_Color_B3FCC8_1()
            {
                if (_themeColor_Color_B3FCC8_1 != null) { return _themeColor_Color_B3FCC8_1; }
                var result = _themeColor_Color_B3FCC8_1 = _c.CreateColorBrush();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Opacity0", 0.300000012F);
                BindProperty2(_themeColor_Color_B3FCC8_1, "Color", "ColorRGB(_theme.Color_B3FCC8.W*my.Opacity0,_theme.Color_B3FCC8.X,_theme.Color_B3FCC8.Y,_theme.Color_B3FCC8.Z)", "_theme", _themeProperties, "my", propertySet);
                return result;
            }

            // Color bound to theme property value: Color_E492F5
            CompositionColorBrush ThemeColor_Color_E492F5()
            {
                if (_themeColor_Color_E492F5 != null) { return _themeColor_Color_E492F5; }
                var result = _themeColor_Color_E492F5 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_E492F5, "Color", "ColorRGB(_theme.Color_E492F5.W,_theme.Color_E492F5.X,_theme.Color_E492F5.Y,_theme.Color_E492F5.Z)", "_theme", _themeProperties);
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<333, 465>
            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF_0()
            {
                if (_themeColor_Color_FFFFFF_0 != null) { return _themeColor_Color_FFFFFF_0; }
                var result = _themeColor_Color_FFFFFF_0 = _c.CreateColorBrush();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Opacity0", 1F);
                BindProperty2(_themeColor_Color_FFFFFF_0, "Color", "ColorRGB(_theme.Color_FFFFFF.W*my.Opacity0,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties, "my", propertySet);
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<472, 234>
            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF_1()
            {
                if (_themeColor_Color_FFFFFF_1 != null) { return _themeColor_Color_FFFFFF_1; }
                var result = _themeColor_Color_FFFFFF_1 = _c.CreateColorBrush();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Opacity0", 1F);
                BindProperty2(_themeColor_Color_FFFFFF_1, "Color", "ColorRGB(_theme.Color_FFFFFF.W*my.Opacity0,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties, "my", propertySet);
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<60.5, 341.5>
            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF_2()
            {
                if (_themeColor_Color_FFFFFF_2 != null) { return _themeColor_Color_FFFFFF_2; }
                var result = _themeColor_Color_FFFFFF_2 = _c.CreateColorBrush();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Opacity0", 1F);
                BindProperty2(_themeColor_Color_FFFFFF_2, "Color", "ColorRGB(_theme.Color_FFFFFF.W*my.Opacity0,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties, "my", propertySet);
                return result;
            }

            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF_3()
            {
                if (_themeColor_Color_FFFFFF_3 != null) { return _themeColor_Color_FFFFFF_3; }
                var result = _themeColor_Color_FFFFFF_3 = _c.CreateColorBrush();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Opacity0", 1F);
                BindProperty2(_themeColor_Color_FFFFFF_3, "Color", "ColorRGB(_theme.Color_FFFFFF.W*my.Opacity0,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties, "my", propertySet);
                return result;
            }

            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF_4()
            {
                if (_themeColor_Color_FFFFFF_4 != null) { return _themeColor_Color_FFFFFF_4; }
                var result = _themeColor_Color_FFFFFF_4 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_FFFFFF_4, "Color", "ColorRGB(_theme.Color_FFFFFF.W,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties);
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<274, 336>
            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF_5()
            {
                if (_themeColor_Color_FFFFFF_5 != null) { return _themeColor_Color_FFFFFF_5; }
                var result = _themeColor_Color_FFFFFF_5 = _c.CreateColorBrush();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Opacity0", 1F);
                BindProperty2(_themeColor_Color_FFFFFF_5, "Color", "ColorRGB(_theme.Color_FFFFFF.W*my.Opacity0,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties, "my", propertySet);
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<183, 232>
            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF_6()
            {
                if (_themeColor_Color_FFFFFF_6 != null) { return _themeColor_Color_FFFFFF_6; }
                var result = _themeColor_Color_FFFFFF_6 = _c.CreateColorBrush();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Opacity0", 0F);
                BindProperty2(_themeColor_Color_FFFFFF_6, "Color", "ColorRGB(_theme.Color_FFFFFF.W*my.Opacity0,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties, "my", propertySet);
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<101.5, 135.5>
            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF_7()
            {
                if (_themeColor_Color_FFFFFF_7 != null) { return _themeColor_Color_FFFFFF_7; }
                var result = _themeColor_Color_FFFFFF_7 = _c.CreateColorBrush();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Opacity0", 1F);
                BindProperty2(_themeColor_Color_FFFFFF_7, "Color", "ColorRGB(_theme.Color_FFFFFF.W*my.Opacity0,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties, "my", propertySet);
                return result;
            }

            // - - Layer aggregator
            // ShapeGroup: Group 1 Offset:<296.5, 262.5>
            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF_8()
            {
                if (_themeColor_Color_FFFFFF_8 != null) { return _themeColor_Color_FFFFFF_8; }
                var result = _themeColor_Color_FFFFFF_8 = _c.CreateColorBrush();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Opacity0", 0.300000012F);
                BindProperty2(_themeColor_Color_FFFFFF_8, "Color", "ColorRGB(_theme.Color_FFFFFF.W*my.Opacity0,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties, "my", propertySet);
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_0()
            {
                if (_containerShape_0 != null) { return _containerShape_0; }
                var result = _containerShape_0 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(293.037994F, 258.901001F);
                // ShapeGroup: Group 1 Offset:<249.659, 251.362>
                result.Shapes.Add(SpriteShape_37());
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_1()
            {
                if (_containerShape_1 != null) { return _containerShape_1; }
                var result = _containerShape_1 = _c.CreateContainerShape();
                // ShapeGroup: Group 1 Offset:<296.5, 262.5>
                result.Shapes.Add(SpriteShape_38());
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_2()
            {
                if (_containerShape_2 != null) { return _containerShape_2; }
                var result = _containerShape_2 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(282F, 470F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 30 Offset:<335.808, 343.415>
                shapes.Add(SpriteShape_39());
                // ShapeGroup: Group 29 Offset:<375.923, 314.862>
                shapes.Add(SpriteShape_40());
                // ShapeGroup: Group 28 Offset:<425.346, 294.375>
                shapes.Add(SpriteShape_41());
                // ShapeGroup: Group 27 Offset:<406.311, 99.421>
                shapes.Add(SpriteShape_42());
                // ShapeGroup: Group 26 Offset:<323.675, 239.112>
                shapes.Add(SpriteShape_43());
                // ShapeGroup: Group 25 Offset:<326.061, 201.075>
                shapes.Add(SpriteShape_44());
                // ShapeGroup: Group 24 Offset:<400.932, 137.064>
                shapes.Add(SpriteShape_45());
                // ShapeGroup: Group 23 Offset:<388.359, 228.433>
                shapes.Add(SpriteShape_46());
                // ShapeGroup: Group 22 Offset:<369.012, 250.246>
                shapes.Add(SpriteShape_47());
                // ShapeGroup: Group 21 Offset:<419.326, 134.246>
                shapes.Add(SpriteShape_48());
                // ShapeGroup: Group 20 Offset:<355.439, 157.878>
                shapes.Add(SpriteShape_49());
                // ShapeGroup: Group 19 Offset:<316.793, 192.963>
                shapes.Add(SpriteShape_50());
                // ShapeGroup: Group 18 Offset:<326.184, 200.116>
                shapes.Add(SpriteShape_51());
                // ShapeGroup: Group 17 Offset:<408.014, 150.922>
                shapes.Add(SpriteShape_52());
                // ShapeGroup: Group 16 Offset:<414.278, 160.915>
                shapes.Add(SpriteShape_53());
                // ShapeGroup: Group 15 Offset:<371.829, 243.74>
                shapes.Add(SpriteShape_54());
                // ShapeGroup: Group 14 Offset:<365.295, 244.773>
                shapes.Add(SpriteShape_55());
                // ShapeGroup: Group 13 Offset:<419.59, 226.196>
                shapes.Add(SpriteShape_56());
                // ShapeGroup: Group 12 Offset:<419.59, 227.285>
                shapes.Add(SpriteShape_57());
                // ShapeGroup: Group 11 Offset:<336.857, 112.722>
                shapes.Add(SpriteShape_58());
                // ShapeGroup: Group 10 Offset:<337.624, 110.002>
                shapes.Add(SpriteShape_59());
                // ShapeGroup: Group 9 Offset:<339.633, 133.549>
                shapes.Add(SpriteShape_60());
                // ShapeGroup: Group 8 Offset:<340.134, 107.565>
                shapes.Add(SpriteShape_61());
                // ShapeGroup: Group 7 Offset:<291.215, 125.202>
                shapes.Add(SpriteShape_62());
                // ShapeGroup: Group 6 Offset:<290.643, 125.576>
                shapes.Add(SpriteShape_63());
                // ShapeGroup: Group 5 Offset:<386.052, 88.334>
                shapes.Add(SpriteShape_64());
                // ShapeGroup: Group 4 Offset:<386.747, 88.063>
                shapes.Add(SpriteShape_65());
                // ShapeGroup: Group 3 Offset:<340.61, 103.548>
                shapes.Add(SpriteShape_66());
                // ShapeGroup: Group 2 Offset:<360.173, 94.033>
                shapes.Add(SpriteShape_67());
                // ShapeGroup: Group 1 Offset:<375.5, 187.5>
                shapes.Add(SpriteShape_68());
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<247.975, 238.895>
            CompositionPathGeometry PathGeometry_00()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_00()));
            }

            CompositionPathGeometry PathGeometry_01()
            {
                return (_pathGeometry_01 == null)
                    ? _pathGeometry_01 = _c.CreatePathGeometry(new CompositionPath(Geometry_01()))
                    : _pathGeometry_01;
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<472, 234>
            CompositionPathGeometry PathGeometry_02()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_02()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<60.5, 341.5>
            CompositionPathGeometry PathGeometry_03()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_03()));
            }

            CompositionPathGeometry PathGeometry_04()
            {
                return (_pathGeometry_04 == null)
                    ? _pathGeometry_04 = _c.CreatePathGeometry(new CompositionPath(Geometry_04()))
                    : _pathGeometry_04;
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<263, 162>
            CompositionPathGeometry PathGeometry_05()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_05()));
            }

            CompositionPathGeometry PathGeometry_06()
            {
                return (_pathGeometry_06 == null)
                    ? _pathGeometry_06 = _c.CreatePathGeometry(new CompositionPath(Geometry_06()))
                    : _pathGeometry_06;
            }

            // - Layer aggregator
            // ShapeGroup: Group 2 Offset:<182.545, 346.877>
            CompositionPathGeometry PathGeometry_07()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_07()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<179.849, 355.341>
            CompositionPathGeometry PathGeometry_08()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_08()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 22 Offset:<159.611, 172.546>
            CompositionPathGeometry PathGeometry_09()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_09()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 21 Offset:<158.415, 174.554>
            CompositionPathGeometry PathGeometry_10()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_10()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 20 Offset:<166.364, 157.584>
            CompositionPathGeometry PathGeometry_11()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_11()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 19 Offset:<167.14, 150.7>
            CompositionPathGeometry PathGeometry_12()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_12()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 18 Offset:<218.693, 98.422>
            CompositionPathGeometry PathGeometry_13()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_13()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 17 Offset:<215.547, 98.658>
            CompositionPathGeometry PathGeometry_14()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_14()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 16 Offset:<205.444, 107.798>
            CompositionPathGeometry PathGeometry_15()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_15()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 15 Offset:<198.924, 109.633>
            CompositionPathGeometry PathGeometry_16()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_16()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 14 Offset:<194.994, 139.475>
            CompositionPathGeometry PathGeometry_17()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_17()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 13 Offset:<188.329, 151.527>
            CompositionPathGeometry PathGeometry_18()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_18()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 12 Offset:<155.364, 111.447>
            CompositionPathGeometry PathGeometry_19()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_19()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 11 Offset:<148.225, 119.509>
            CompositionPathGeometry PathGeometry_20()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_20()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 10 Offset:<111.845, 75.548>
            CompositionPathGeometry PathGeometry_21()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_21()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 9 Offset:<108.906, 77.118>
            CompositionPathGeometry PathGeometry_22()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_22()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 8 Offset:<169.871, 120.106>
            CompositionPathGeometry PathGeometry_23()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_23()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 7 Offset:<167.035, 124.446>
            CompositionPathGeometry PathGeometry_24()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_24()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 6 Offset:<169.871, 120.106>
            CompositionPathGeometry PathGeometry_25()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_25()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 5 Offset:<167.688, 123.447>
            CompositionPathGeometry PathGeometry_26()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_26()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 4 Offset:<138.946, 95.832>
            CompositionPathGeometry PathGeometry_27()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_27()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 3 Offset:<136.11, 100.172>
            CompositionPathGeometry PathGeometry_28()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_28()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 2 Offset:<138.947, 95.832>
            CompositionPathGeometry PathGeometry_29()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_29()));
            }

            // - Layer aggregator
            // ShapeGroup: Group 1 Offset:<136.763, 99.173>
            CompositionPathGeometry PathGeometry_30()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_30()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 1 Offset:<249.659, 251.362>
            CompositionPathGeometry PathGeometry_31()
            {
                if (_pathGeometry_31 != null) { return _pathGeometry_31; }
                var result = _pathGeometry_31 = _c.CreatePathGeometry(new CompositionPath(Geometry_31()));
                return result;
            }

            // - - Layer aggregator
            // ShapeGroup: Group 30 Offset:<335.808, 343.415>
            CompositionPathGeometry PathGeometry_32()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_32()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 29 Offset:<375.923, 314.862>
            CompositionPathGeometry PathGeometry_33()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_33()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 28 Offset:<425.346, 294.375>
            CompositionPathGeometry PathGeometry_34()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_34()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 27 Offset:<406.311, 99.421>
            CompositionPathGeometry PathGeometry_35()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_35()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 26 Offset:<323.675, 239.112>
            CompositionPathGeometry PathGeometry_36()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_36()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 25 Offset:<326.061, 201.075>
            CompositionPathGeometry PathGeometry_37()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_37()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 24 Offset:<400.932, 137.064>
            CompositionPathGeometry PathGeometry_38()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_38()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 23 Offset:<388.359, 228.433>
            CompositionPathGeometry PathGeometry_39()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_39()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 22 Offset:<369.012, 250.246>
            CompositionPathGeometry PathGeometry_40()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_40()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 21 Offset:<419.326, 134.246>
            CompositionPathGeometry PathGeometry_41()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_41()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 20 Offset:<355.439, 157.878>
            CompositionPathGeometry PathGeometry_42()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_42()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 19 Offset:<316.793, 192.963>
            CompositionPathGeometry PathGeometry_43()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_43()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 18 Offset:<326.184, 200.116>
            CompositionPathGeometry PathGeometry_44()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_44()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 17 Offset:<408.014, 150.922>
            CompositionPathGeometry PathGeometry_45()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_45()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 16 Offset:<414.278, 160.915>
            CompositionPathGeometry PathGeometry_46()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_46()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 15 Offset:<371.829, 243.74>
            CompositionPathGeometry PathGeometry_47()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_47()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 14 Offset:<365.295, 244.773>
            CompositionPathGeometry PathGeometry_48()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_48()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 13 Offset:<419.59, 226.196>
            CompositionPathGeometry PathGeometry_49()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_49()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 12 Offset:<419.59, 227.285>
            CompositionPathGeometry PathGeometry_50()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_50()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 11 Offset:<336.857, 112.722>
            CompositionPathGeometry PathGeometry_51()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_51()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 10 Offset:<337.624, 110.002>
            CompositionPathGeometry PathGeometry_52()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_52()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 9 Offset:<339.633, 133.549>
            CompositionPathGeometry PathGeometry_53()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_53()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 8 Offset:<340.134, 107.565>
            CompositionPathGeometry PathGeometry_54()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_54()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 7 Offset:<291.215, 125.202>
            CompositionPathGeometry PathGeometry_55()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_55()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 6 Offset:<290.643, 125.576>
            CompositionPathGeometry PathGeometry_56()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_56()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 5 Offset:<386.052, 88.334>
            CompositionPathGeometry PathGeometry_57()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_57()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 4 Offset:<386.747, 88.063>
            CompositionPathGeometry PathGeometry_58()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_58()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 3 Offset:<340.61, 103.548>
            CompositionPathGeometry PathGeometry_59()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_59()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 2 Offset:<360.173, 94.033>
            CompositionPathGeometry PathGeometry_60()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_60()));
            }

            // - - Layer aggregator
            // ShapeGroup: Group 1 Offset:<375.5, 187.5>
            CompositionPathGeometry PathGeometry_61()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_61()));
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_00()
            {
                // Offset:<247.975, 238.895>
                var geometry = PathGeometry_00();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 247.975006F, 238.895004F), ThemeColor_Color_160E53_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_01()
            {
                // Offset:<333, 465>
                var geometry = PathGeometry_01();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 333F, 465F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_02()
            {
                // Offset:<472, 234>
                var geometry = PathGeometry_02();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 472F, 234F), ThemeColor_Color_FFFFFF_1());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_03()
            {
                // Offset:<60.5, 341.5>
                var geometry = PathGeometry_03();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 60.5F, 341.5F), ThemeColor_Color_FFFFFF_2());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_04()
            {
                // Offset:<226, 433>
                var geometry = PathGeometry_04();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 226F, 433F), ThemeColor_Color_FFFFFF_3());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_05()
            {
                // Offset:<295, 404>
                var geometry = PathGeometry_04();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 295F, 404F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_06()
            {
                // Offset:<274, 336>
                var geometry = PathGeometry_04();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 274F, 336F), ThemeColor_Color_FFFFFF_5());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_07()
            {
                // Offset:<277, 222>
                var geometry = PathGeometry_04();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 277F, 222F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_08()
            {
                // Offset:<183, 232>
                var geometry = PathGeometry_04();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 183F, 232F), ThemeColor_Color_FFFFFF_6());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_09()
            {
                // Offset:<263, 162>
                var geometry = PathGeometry_05();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 263F, 162F), ThemeColor_Color_FFFFFF_3());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_10()
            {
                // Offset:<60.5, 226.5>
                var geometry = PathGeometry_06();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 60.5F, 226.5F), ThemeColor_Color_FFFFFF_3());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_11()
            {
                // Offset:<101.5, 135.5>
                var geometry = PathGeometry_06();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 101.5F, 135.5F), ThemeColor_Color_FFFFFF_7());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_12()
            {
                // Offset:<283, 25>
                var geometry = PathGeometry_01();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 283F, 25F), ThemeColor_Color_FFFFFF_3());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_13()
            {
                // Offset:<182.545, 346.877>
                var geometry = PathGeometry_07();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 182.544998F, 346.877014F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_14()
            {
                // Offset:<179.849, 355.341>
                var geometry = PathGeometry_08();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 179.848999F, 355.341003F), ThemeColor_Color_B3FCC8_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_15()
            {
                // Offset:<159.611, 172.546>
                var geometry = PathGeometry_09();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 159.610992F, 172.546005F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_16()
            {
                // Offset:<158.415, 174.554>
                var geometry = PathGeometry_10();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 158.414993F, 174.554001F), ThemeColor_Color_B3FCC8_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_17()
            {
                // Offset:<166.364, 157.584>
                var geometry = PathGeometry_11();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 166.363998F, 157.584F), ThemeColor_Color_E492F5());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_18()
            {
                // Offset:<167.14, 150.7>
                var geometry = PathGeometry_12();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 167.139999F, 150.699997F), ThemeColor_Color_5B6C7E());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_19()
            {
                // Offset:<218.693, 98.422>
                var geometry = PathGeometry_13();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 218.692993F, 98.4219971F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_20()
            {
                // Offset:<215.547, 98.658>
                var geometry = PathGeometry_14();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 215.546997F, 98.6579971F), ThemeColor_Color_B3FCC8_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_21()
            {
                // Offset:<205.444, 107.798>
                var geometry = PathGeometry_15();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 205.444F, 107.797997F), ThemeColor_Color_B3FCC8_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_22()
            {
                // Offset:<198.924, 109.633>
                var geometry = PathGeometry_16();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 198.923996F, 109.633003F), ThemeColor_Color_E492F5());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_23()
            {
                // Offset:<194.994, 139.475>
                var geometry = PathGeometry_17();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 194.994003F, 139.475006F), ThemeColor_Color_B3FCC8_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_24()
            {
                // Offset:<188.329, 151.527>
                var geometry = PathGeometry_18();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 188.328995F, 151.526993F), ThemeColor_Color_E492F5());;
                return result;
            }

            // Layer aggregator
            // ShapeGroup: Group 12 Offset:<155.364, 111.447>
            CompositionSpriteShape SpriteShape_25()
            {
                // Offset:<155.364, 111.447>
                var geometry = PathGeometry_19();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 155.363998F, 111.446999F), ThemeColor_Color_190202());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_26()
            {
                // Offset:<148.225, 119.509>
                var geometry = PathGeometry_20();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 148.225006F, 119.509003F), ThemeColor_Color_E492F5());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_27()
            {
                // Offset:<111.845, 75.548>
                var geometry = PathGeometry_21();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 111.845001F, 75.5479965F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_28()
            {
                // Offset:<108.906, 77.118>
                var geometry = PathGeometry_22();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 108.905998F, 77.1179962F), ThemeColor_Color_B3FCC8_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_29()
            {
                // Offset:<169.871, 120.106>
                var geometry = PathGeometry_23();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 169.871002F, 120.106003F), ThemeColor_Color_B3FCC8_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_30()
            {
                // Offset:<167.035, 124.446>
                var geometry = PathGeometry_24();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 167.035004F, 124.445999F), ThemeColor_Color_000000());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_31()
            {
                // Offset:<169.871, 120.106>
                var geometry = PathGeometry_25();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 169.871002F, 120.106003F), ThemeColor_Color_261C6A());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_32()
            {
                // Offset:<167.688, 123.447>
                var geometry = PathGeometry_26();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 167.688004F, 123.446999F), ThemeColor_Color_160E53_1());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_33()
            {
                // Offset:<138.946, 95.832>
                var geometry = PathGeometry_27();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 138.945999F, 95.8320007F), ThemeColor_Color_B3FCC8_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_34()
            {
                // Offset:<136.11, 100.172>
                var geometry = PathGeometry_28();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 136.110001F, 100.171997F), ThemeColor_Color_000000());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_35()
            {
                // Offset:<138.947, 95.832>
                var geometry = PathGeometry_29();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 138.947006F, 95.8320007F), ThemeColor_Color_261C6A());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_36()
            {
                // Offset:<136.763, 99.173>
                var geometry = PathGeometry_30();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 136.763F, 99.1729965F), ThemeColor_Color_160E53_1());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_37()
            {
                // Offset:<249.659, 251.362>
                var geometry = PathGeometry_31();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 249.658997F, 251.362F), ThemeColor_Color_B3FCC8_1());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_38()
            {
                // Offset:<296.5, 262.5>
                var geometry = PathGeometry_06();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 296.5F, 262.5F), ThemeColor_Color_FFFFFF_8());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_39()
            {
                // Offset:<335.808, 343.415>
                var geometry = PathGeometry_32();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 335.808014F, 343.415009F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_40()
            {
                // Offset:<375.923, 314.862>
                var geometry = PathGeometry_33();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 375.923004F, 314.862F), ThemeColor_Color_E492F5());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_41()
            {
                // Offset:<425.346, 294.375>
                var geometry = PathGeometry_34();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 425.346008F, 294.375F), ThemeColor_Color_E492F5());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_42()
            {
                // Offset:<406.311, 99.421>
                var geometry = PathGeometry_35();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 406.311005F, 99.4209976F), ThemeColor_Color_E492F5());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_43()
            {
                // Offset:<323.675, 239.112>
                var geometry = PathGeometry_36();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 323.674988F, 239.112F), ThemeColor_Color_E492F5());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_44()
            {
                // Offset:<326.061, 201.075>
                var geometry = PathGeometry_37();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 326.061005F, 201.074997F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_45()
            {
                // Offset:<400.932, 137.064>
                var geometry = PathGeometry_38();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 400.932007F, 137.063995F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_46()
            {
                // Offset:<388.359, 228.433>
                var geometry = PathGeometry_39();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 388.359009F, 228.432999F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 22 Offset:<369.012, 250.246>
            CompositionSpriteShape SpriteShape_47()
            {
                // Offset:<369.012, 250.246>
                var geometry = PathGeometry_40();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 369.011993F, 250.246002F), ThemeColor_Color_E492F5());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_48()
            {
                // Offset:<419.326, 134.246>
                var geometry = PathGeometry_41();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 419.325989F, 134.246002F), ThemeColor_Color_E492F5());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_49()
            {
                // Offset:<355.439, 157.878>
                var geometry = PathGeometry_42();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 355.438995F, 157.878006F), ThemeColor_Color_B3FCC8_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_50()
            {
                // Offset:<316.793, 192.963>
                var geometry = PathGeometry_43();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 316.792999F, 192.962997F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_51()
            {
                // Offset:<326.184, 200.116>
                var geometry = PathGeometry_44();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 326.18399F, 200.115997F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 17 Offset:<408.014, 150.922>
            CompositionSpriteShape SpriteShape_52()
            {
                // Offset:<408.014, 150.922>
                var geometry = PathGeometry_45();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 408.014008F, 150.921997F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_53()
            {
                // Offset:<414.278, 160.915>
                var geometry = PathGeometry_46();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 414.278015F, 160.914993F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_54()
            {
                // Offset:<371.829, 243.74>
                var geometry = PathGeometry_47();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 371.82901F, 243.740005F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_55()
            {
                // Offset:<365.295, 244.773>
                var geometry = PathGeometry_48();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 365.295013F, 244.772995F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_56()
            {
                // Offset:<419.59, 226.196>
                var geometry = PathGeometry_49();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 419.589996F, 226.195999F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Group 12 Offset:<419.59, 227.285>
            CompositionSpriteShape SpriteShape_57()
            {
                // Offset:<419.59, 227.285>
                var geometry = PathGeometry_50();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 419.589996F, 227.285004F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_58()
            {
                // Offset:<336.857, 112.722>
                var geometry = PathGeometry_51();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 336.856995F, 112.722F), ThemeColor_Color_FFFFFF_4());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_59()
            {
                // Offset:<337.624, 110.002>
                var geometry = PathGeometry_52();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 337.623993F, 110.001999F), ThemeColor_Color_E492F5());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_60()
            {
                // Offset:<339.633, 133.549>
                var geometry = PathGeometry_53();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 339.632996F, 133.548996F), ThemeColor_Color_E492F5());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_61()
            {
                // Offset:<340.134, 107.565>
                var geometry = PathGeometry_54();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 340.134003F, 107.565002F), ThemeColor_Color_465F7A());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_62()
            {
                // Offset:<291.215, 125.202>
                var geometry = PathGeometry_55();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 291.214996F, 125.202003F), ThemeColor_Color_334F6C());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_63()
            {
                // Offset:<290.643, 125.576>
                var geometry = PathGeometry_56();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 290.643005F, 125.575996F), ThemeColor_Color_465F7A());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_64()
            {
                // Offset:<386.052, 88.334>
                var geometry = PathGeometry_57();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 386.052002F, 88.3339996F), ThemeColor_Color_334F6C());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_65()
            {
                // Offset:<386.747, 88.063>
                var geometry = PathGeometry_58();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 386.747009F, 88.0630035F), ThemeColor_Color_465F7A());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_66()
            {
                // Offset:<340.61, 103.548>
                var geometry = PathGeometry_59();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 340.609985F, 103.547997F), ThemeColor_Color_160E53_1());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_67()
            {
                // Offset:<360.173, 94.033>
                var geometry = PathGeometry_60();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 360.173004F, 94.0329971F), ThemeColor_Color_261C6A());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_68()
            {
                // Offset:<375.5, 187.5>
                var geometry = PathGeometry_61();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 375.5F, 187.5F), ThemeColor_Color_190202());;
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
                // Layer aggregator
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return (_cubicBezierEasingFunction_0 == null)
                    ? _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.833000004F, 0.833000004F))
                    : _cubicBezierEasingFunction_0;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_1()
            {
                return (_cubicBezierEasingFunction_1 == null)
                    ? _cubicBezierEasingFunction_1 = _c.CreateCubicBezierEasingFunction(new Vector2(0.333000004F, 0F), new Vector2(0.666999996F, 1F))
                    : _cubicBezierEasingFunction_1;
            }

            ExpressionAnimation RootProgress()
            {
                if (_rootProgress != null) { return _rootProgress; }
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // Opacity0
            ScalarKeyFrameAnimation Opacity0ScalarAnimation_0_to_0()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, HoldThenStepEasingFunction());
                // Frame 10.
                result.InsertKeyFrame(0.0666666627F, 1F, CubicBezierEasingFunction_0());
                // Frame 21.
                result.InsertKeyFrame(0.140000001F, 0F, CubicBezierEasingFunction_0());
                // Frame 40.
                result.InsertKeyFrame(0.266666651F, 1F, CubicBezierEasingFunction_0());
                // Frame 60.
                result.InsertKeyFrame(0.399999976F, 0F, CubicBezierEasingFunction_0());
                // Frame 80.
                result.InsertKeyFrame(0.533333302F, 1F, CubicBezierEasingFunction_0());
                // Frame 110.
                result.InsertKeyFrame(0.73333329F, 0F, CubicBezierEasingFunction_0());
                // Frame 131.
                result.InsertKeyFrame(0.873333275F, 1F, CubicBezierEasingFunction_0());
                // Frame 150.
                result.InsertKeyFrame(1F, 0F, CubicBezierEasingFunction_0());
                return result;
            }

            // Opacity0
            ScalarKeyFrameAnimation Opacity0ScalarAnimation_0p3_to_0_0()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0.300000012F, HoldThenStepEasingFunction());
                // Frame 76.
                result.InsertKeyFrame(0.50666666F, 0.300000012F, CubicBezierEasingFunction_0());
                // Frame 142.
                result.InsertKeyFrame(0.946666658F, 0F, CubicBezierEasingFunction_0());
                return result;
            }

            // Opacity0
            ScalarKeyFrameAnimation Opacity0ScalarAnimation_0p3_to_0_1()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0.300000012F, HoldThenStepEasingFunction());
                // Frame 76.
                result.InsertKeyFrame(0.50666666F, 1F, CubicBezierEasingFunction_0());
                // Frame 149.
                result.InsertKeyFrame(0.99333334F, 0F, CubicBezierEasingFunction_0());
                return result;
            }

            // Opacity0
            ScalarKeyFrameAnimation Opacity0ScalarAnimation_1_to_0_0()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 1F, HoldThenStepEasingFunction());
                // Frame 6.69.
                result.InsertKeyFrame(0.0445859842F, 0F, CubicBezierEasingFunction_0());
                // Frame 16.24.
                result.InsertKeyFrame(0.108280249F, 1F, CubicBezierEasingFunction_0());
                // Frame 26.75.
                result.InsertKeyFrame(0.178343937F, 0F, CubicBezierEasingFunction_0());
                // Frame 44.9.
                result.InsertKeyFrame(0.299363047F, 1F, CubicBezierEasingFunction_0());
                // Frame 64.01.
                result.InsertKeyFrame(0.426751584F, 0F, CubicBezierEasingFunction_0());
                // Frame 83.12.
                result.InsertKeyFrame(0.554140091F, 1F, CubicBezierEasingFunction_0());
                // Frame 111.78.
                result.InsertKeyFrame(0.745222926F, 0F, CubicBezierEasingFunction_0());
                // Frame 131.85.
                result.InsertKeyFrame(0.878980875F, 1F, CubicBezierEasingFunction_0());
                // Frame 150.
                result.InsertKeyFrame(1F, 0F, CubicBezierEasingFunction_0());
                return result;
            }

            // Opacity0
            ScalarKeyFrameAnimation Opacity0ScalarAnimation_1_to_0_1()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 1F, HoldThenStepEasingFunction());
                // Frame 11.
                result.InsertKeyFrame(0.0733333305F, 0F, CubicBezierEasingFunction_0());
                // Frame 30.
                result.InsertKeyFrame(0.199999988F, 1F, CubicBezierEasingFunction_0());
                // Frame 50.
                result.InsertKeyFrame(0.333333313F, 0F, CubicBezierEasingFunction_0());
                // Frame 70.
                result.InsertKeyFrame(0.466666639F, 1F, CubicBezierEasingFunction_0());
                // Frame 100.
                result.InsertKeyFrame(0.666666627F, 0F, CubicBezierEasingFunction_0());
                // Frame 121.
                result.InsertKeyFrame(0.806666613F, 1F, CubicBezierEasingFunction_0());
                // Frame 140.
                result.InsertKeyFrame(0.933333337F, 0F, CubicBezierEasingFunction_0());
                return result;
            }

            // Opacity0
            ScalarKeyFrameAnimation Opacity0ScalarAnimation_1_to_0_2()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 1F, StepThenHoldEasingFunction());
                // Frame 6.
                result.InsertKeyFrame(0.0399999991F, 1F, HoldThenStepEasingFunction());
                // Frame 17.
                result.InsertKeyFrame(0.11333333F, 0F, CubicBezierEasingFunction_0());
                // Frame 36.
                result.InsertKeyFrame(0.239999995F, 1F, CubicBezierEasingFunction_0());
                // Frame 56.
                result.InsertKeyFrame(0.373333305F, 0F, CubicBezierEasingFunction_0());
                // Frame 76.
                result.InsertKeyFrame(0.50666666F, 1F, CubicBezierEasingFunction_0());
                // Frame 106.
                result.InsertKeyFrame(0.706666648F, 0F, CubicBezierEasingFunction_0());
                // Frame 127.
                result.InsertKeyFrame(0.846666634F, 1F, CubicBezierEasingFunction_0());
                // Frame 146.
                result.InsertKeyFrame(0.973333359F, 0F, CubicBezierEasingFunction_0());
                return result;
            }

            // Opacity0
            ScalarKeyFrameAnimation Opacity0ScalarAnimation_1_to_0_3()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 1F, HoldThenStepEasingFunction());
                // Frame 8.08.
                result.InsertKeyFrame(0.0538616367F, 0F, CubicBezierEasingFunction_0());
                // Frame 22.04.
                result.InsertKeyFrame(0.146905661F, 1F, CubicBezierEasingFunction_0());
                // Frame 36.73.
                result.InsertKeyFrame(0.244836479F, 0F, CubicBezierEasingFunction_0());
                // Frame 51.42.
                result.InsertKeyFrame(0.342767298F, 1F, CubicBezierEasingFunction_0());
                // Frame 73.45.
                result.InsertKeyFrame(0.489672959F, 0F, CubicBezierEasingFunction_0());
                // Frame 88.88.
                result.InsertKeyFrame(0.59250313F, 1F, CubicBezierEasingFunction_0());
                // Frame 102.83.
                result.InsertKeyFrame(0.685534596F, 1F, CubicBezierEasingFunction_0());
                // Frame 113.21.
                result.InsertKeyFrame(0.754716992F, 0F, CubicBezierEasingFunction_0());
                // Frame 131.13.
                result.InsertKeyFrame(0.874213815F, 1F, CubicBezierEasingFunction_0());
                // Frame 150.
                result.InsertKeyFrame(1F, 0F, CubicBezierEasingFunction_0());
                return result;
            }

            // Opacity0
            ScalarKeyFrameAnimation Opacity0ScalarAnimation_1_to_0p2()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 1F, HoldThenStepEasingFunction());
                // Frame 7.23.
                result.InsertKeyFrame(0.0482085906F, 0.200000003F, CubicBezierEasingFunction_0());
                // Frame 19.72.
                result.InsertKeyFrame(0.131466255F, 1F, CubicBezierEasingFunction_0());
                // Frame 32.87.
                result.InsertKeyFrame(0.21910429F, 0.200000003F, CubicBezierEasingFunction_0());
                // Frame 46.01.
                result.InsertKeyFrame(0.30674848F, 1F, CubicBezierEasingFunction_0());
                // Frame 65.73.
                result.InsertKeyFrame(0.438214719F, 0.200000003F, CubicBezierEasingFunction_0());
                // Frame 79.54.
                result.InsertKeyFrame(0.530239284F, 1F, CubicBezierEasingFunction_0());
                // Frame 92.02.
                result.InsertKeyFrame(0.613496959F, 0.200000003F, CubicBezierEasingFunction_0());
                // Frame 103.99.
                result.InsertKeyFrame(0.69325155F, 1F, CubicBezierEasingFunction_0());
                // Frame 114.11.
                result.InsertKeyFrame(0.760736167F, 0.200000003F, CubicBezierEasingFunction_0());
                // Frame 131.6.
                result.InsertKeyFrame(0.87730062F, 1F, CubicBezierEasingFunction_0());
                // Frame 150.
                result.InsertKeyFrame(1F, 0.200000003F, CubicBezierEasingFunction_0());
                return result;
            }

            // Opacity0
            ScalarKeyFrameAnimation Opacity0ScalarAnimation_1_to_0p3()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 1F, HoldThenStepEasingFunction());
                // Frame 11.79.
                result.InsertKeyFrame(0.0785733312F, 0.300000012F, CubicBezierEasingFunction_0());
                // Frame 32.14.
                result.InsertKeyFrame(0.214286655F, 1F, CubicBezierEasingFunction_0());
                // Frame 53.57.
                result.InsertKeyFrame(0.357139975F, 0.300000012F, CubicBezierEasingFunction_0());
                // Frame 75.
                result.InsertKeyFrame(0.49999997F, 1F, CubicBezierEasingFunction_0());
                // Frame 107.14.
                result.InsertKeyFrame(0.714286625F, 0.300000012F, CubicBezierEasingFunction_0());
                // Frame 129.64.
                result.InsertKeyFrame(0.864286661F, 1F, CubicBezierEasingFunction_0());
                // Frame 150.
                result.InsertKeyFrame(1F, 0.300000012F, CubicBezierEasingFunction_0());
                return result;
            }

            // - Layer aggregator
            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_m7_to_m7()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, -7F, HoldThenStepEasingFunction());
                // Frame 72.
                result.InsertKeyFrame(0.479999989F, 3F, CubicBezierEasingFunction_1());
                // Frame 150.
                result.InsertKeyFrame(1F, -7F, CubicBezierEasingFunction_1());
                return result;
            }

            // - Layer aggregator
            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_m25_to_18()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, -25F, HoldThenStepEasingFunction());
                // Frame 76.
                result.InsertKeyFrame(0.50666666F, 2F, CubicBezierEasingFunction_0());
                // Frame 149.
                result.InsertKeyFrame(0.99333334F, 18F, CubicBezierEasingFunction_0());
                return result;
            }

            ScalarKeyFrameAnimation t0ScalarAnimation_0_to_1()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 76.
                result.InsertKeyFrame(0.506666601F, 1F, CubicBezierEasingFunction_0());
                // Frame 76.
                result.InsertKeyFrame(0.50666666F, 0F, StepThenHoldEasingFunction());
                // Frame 149.
                result.InsertKeyFrame(0.99333328F, 1F, CubicBezierEasingFunction_0());
                return result;
            }

            ScalarKeyFrameAnimation t1ScalarAnimation_0_to_1()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 149.
                result.InsertKeyFrame(0.99333328F, 1F, CubicBezierEasingFunction_0());
                return result;
            }

            // - - - Layer aggregator
            // - ShapeGroup: Group 1 Offset:<249.659, 251.362>
            // TrimStart
            ScalarKeyFrameAnimation TrimStartScalarAnimation_0p82_to_0()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0.819999993F, HoldThenStepEasingFunction());
                // Frame 76.
                result.InsertKeyFrame(0.50666666F, 0F, CubicBezierEasingFunction_0());
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(500F, 500F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 1 Offset:<247.975, 238.895>
                shapes.Add(SpriteShape_00());
                // ShapeGroup: Group 1 Offset:<333, 465>
                shapes.Add(SpriteShape_01());
                // ShapeGroup: Group 1 Offset:<472, 234>
                shapes.Add(SpriteShape_02());
                // ShapeGroup: Group 1 Offset:<60.5, 341.5>
                shapes.Add(SpriteShape_03());
                // ShapeGroup: Group 1 Offset:<226, 433>
                shapes.Add(SpriteShape_04());
                // ShapeGroup: Group 1 Offset:<295, 404>
                shapes.Add(SpriteShape_05());
                // ShapeGroup: Group 1 Offset:<274, 336>
                shapes.Add(SpriteShape_06());
                // ShapeGroup: Group 1 Offset:<277, 222>
                shapes.Add(SpriteShape_07());
                // ShapeGroup: Group 1 Offset:<183, 232>
                shapes.Add(SpriteShape_08());
                // ShapeGroup: Group 1 Offset:<263, 162>
                shapes.Add(SpriteShape_09());
                // ShapeGroup: Group 1 Offset:<60.5, 226.5>
                shapes.Add(SpriteShape_10());
                // ShapeGroup: Group 1 Offset:<101.5, 135.5>
                shapes.Add(SpriteShape_11());
                // ShapeGroup: Group 1 Offset:<283, 25>
                shapes.Add(SpriteShape_12());
                // ShapeGroup: Group 2 Offset:<182.545, 346.877>
                shapes.Add(SpriteShape_13());
                // ShapeGroup: Group 1 Offset:<179.849, 355.341>
                shapes.Add(SpriteShape_14());
                // ShapeGroup: Group 22 Offset:<159.611, 172.546>
                shapes.Add(SpriteShape_15());
                // ShapeGroup: Group 21 Offset:<158.415, 174.554>
                shapes.Add(SpriteShape_16());
                // ShapeGroup: Group 20 Offset:<166.364, 157.584>
                shapes.Add(SpriteShape_17());
                // ShapeGroup: Group 19 Offset:<167.14, 150.7>
                shapes.Add(SpriteShape_18());
                // ShapeGroup: Group 18 Offset:<218.693, 98.422>
                shapes.Add(SpriteShape_19());
                // ShapeGroup: Group 17 Offset:<215.547, 98.658>
                shapes.Add(SpriteShape_20());
                // ShapeGroup: Group 16 Offset:<205.444, 107.798>
                shapes.Add(SpriteShape_21());
                // ShapeGroup: Group 15 Offset:<198.924, 109.633>
                shapes.Add(SpriteShape_22());
                // ShapeGroup: Group 14 Offset:<194.994, 139.475>
                shapes.Add(SpriteShape_23());
                // ShapeGroup: Group 13 Offset:<188.329, 151.527>
                shapes.Add(SpriteShape_24());
                // ShapeGroup: Group 12 Offset:<155.364, 111.447>
                shapes.Add(SpriteShape_25());
                // ShapeGroup: Group 11 Offset:<148.225, 119.509>
                shapes.Add(SpriteShape_26());
                // ShapeGroup: Group 10 Offset:<111.845, 75.548>
                shapes.Add(SpriteShape_27());
                // ShapeGroup: Group 9 Offset:<108.906, 77.118>
                shapes.Add(SpriteShape_28());
                // ShapeGroup: Group 8 Offset:<169.871, 120.106>
                shapes.Add(SpriteShape_29());
                // ShapeGroup: Group 7 Offset:<167.035, 124.446>
                shapes.Add(SpriteShape_30());
                // ShapeGroup: Group 6 Offset:<169.871, 120.106>
                shapes.Add(SpriteShape_31());
                // ShapeGroup: Group 5 Offset:<167.688, 123.447>
                shapes.Add(SpriteShape_32());
                // ShapeGroup: Group 4 Offset:<138.946, 95.832>
                shapes.Add(SpriteShape_33());
                // ShapeGroup: Group 3 Offset:<136.11, 100.172>
                shapes.Add(SpriteShape_34());
                // ShapeGroup: Group 2 Offset:<138.947, 95.832>
                shapes.Add(SpriteShape_35());
                // ShapeGroup: Group 1 Offset:<136.763, 99.173>
                shapes.Add(SpriteShape_36());
                shapes.Add(ContainerShape_0());
                shapes.Add(ContainerShape_1());
                shapes.Add(ContainerShape_2());
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
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-257.378998F, 11.4610004F), HoldThenStepEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 76.
                result.InsertExpressionKeyFrame(0.506666601F, "Pow(1-_.t0,3)*Vector2(-257.379,11.461)+(3*Square(1-_.t0)*_.t0*Vector2(-163.392,-1.590973))+(3*(1-_.t0)*Square(_.t0)*Vector2(-138.2236,5.991454))+(Pow(_.t0,3)*Vector2(-75.872,21.759))", StepThenHoldEasingFunction());
                // Frame 149.
                result.InsertExpressionKeyFrame(0.99333328F, "Pow(1-_.t0,3)*Vector2(-75.872,21.759)+(3*Square(1-_.t0)*_.t0*Vector2(24.20045,47.06544))+(3*(1-_.t0)*Square(_.t0)*Vector2(104.1823,89.16788))+(Pow(_.t0,3)*Vector2(142.621,113.461))", StepThenHoldEasingFunction());
                // Frame 149.
                result.InsertKeyFrame(0.99333334F, new Vector2(142.621002F, 113.460999F), StepThenHoldEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-258F, 8F), HoldThenStepEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 149.
                result.InsertExpressionKeyFrame(0.99333328F, "Pow(1-_.t1,3)*Vector2(-258,8)+(3*Square(1-_.t1)*_.t1*Vector2(-52.5,-27))+(3*(1-_.t1)*Square(_.t1)*Vector2(107,63))+(Pow(_.t1,3)*Vector2(168,98))", StepThenHoldEasingFunction());
                // Frame 149.
                result.InsertKeyFrame(0.99333334F, new Vector2(168F, 98F), StepThenHoldEasingFunction());
                return result;
            }

            internal Astronauta_AnimatedVisual(
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
            public Vector2 Size => new Vector2(500F, 500F);
            void IDisposable.Dispose() => _root?.Dispose();

            public void CreateAnimations()
            {
                StartProgressBoundAnimation(_themeColor_Color_B3FCC8_1.Properties, "Opacity0", Opacity0ScalarAnimation_0p3_to_0_0(), RootProgress());
                _themeColor_Color_FFFFFF_0.Properties.StartAnimation("Opacity0", Opacity0ScalarAnimation_1_to_0p2());
                var controller = _themeColor_Color_FFFFFF_0.Properties.TryGetAnimationController("Opacity0");
                controller.Pause();
                BindProperty(controller, "Progress", "_.Progress*0.9202454", "_", _root);
                StartProgressBoundAnimation(_themeColor_Color_FFFFFF_1.Properties, "Opacity0", Opacity0ScalarAnimation_1_to_0p3(), RootProgress());
                _themeColor_Color_FFFFFF_2.Properties.StartAnimation("Opacity0", Opacity0ScalarAnimation_1_to_0_0());
                controller = _themeColor_Color_FFFFFF_2.Properties.TryGetAnimationController("Opacity0");
                controller.Pause();
                BindProperty(controller, "Progress", "_.Progress*0.955414", "_", _root);
                StartProgressBoundAnimation(_themeColor_Color_FFFFFF_3.Properties, "Opacity0", Opacity0ScalarAnimation_1_to_0_1(), RootProgress());
                StartProgressBoundAnimation(_themeColor_Color_FFFFFF_5.Properties, "Opacity0", Opacity0ScalarAnimation_1_to_0_2(), RootProgress());
                StartProgressBoundAnimation(_themeColor_Color_FFFFFF_6.Properties, "Opacity0", Opacity0ScalarAnimation_0_to_0(), RootProgress());
                _themeColor_Color_FFFFFF_7.Properties.StartAnimation("Opacity0", Opacity0ScalarAnimation_1_to_0_3());
                controller = _themeColor_Color_FFFFFF_7.Properties.TryGetAnimationController("Opacity0");
                controller.Pause();
                BindProperty(controller, "Progress", "_.Progress*0.9433963", "_", _root);
                StartProgressBoundAnimation(_themeColor_Color_FFFFFF_8.Properties, "Opacity0", Opacity0ScalarAnimation_0p3_to_0_1(), RootProgress());
                StartProgressBoundAnimation(_containerShape_0, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_m25_to_18(), RootProgress());
                StartProgressBoundAnimation(_containerShape_0, "Offset", OffsetVector2Animation_0(), RootProgress());
                StartProgressBoundAnimation(_containerShape_1, "Offset", OffsetVector2Animation_1(), RootProgress());
                StartProgressBoundAnimation(_containerShape_2, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_m7_to_m7(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_31, "TrimStart", TrimStartScalarAnimation_0p82_to_0(), RootProgress());
                StartProgressBoundAnimation(_root.Properties, "t0", t0ScalarAnimation_0_to_1(), RootProgress());
                StartProgressBoundAnimation(_root.Properties, "t1", t1ScalarAnimation_0_to_1(), RootProgress());
            }

            public void DestroyAnimations()
            {
                _themeColor_Color_B3FCC8_1.Properties.StopAnimation("Opacity0");
                _themeColor_Color_FFFFFF_0.Properties.StopAnimation("Opacity0");
                _themeColor_Color_FFFFFF_1.Properties.StopAnimation("Opacity0");
                _themeColor_Color_FFFFFF_2.Properties.StopAnimation("Opacity0");
                _themeColor_Color_FFFFFF_3.Properties.StopAnimation("Opacity0");
                _themeColor_Color_FFFFFF_5.Properties.StopAnimation("Opacity0");
                _themeColor_Color_FFFFFF_6.Properties.StopAnimation("Opacity0");
                _themeColor_Color_FFFFFF_7.Properties.StopAnimation("Opacity0");
                _themeColor_Color_FFFFFF_8.Properties.StopAnimation("Opacity0");
                _containerShape_0.StopAnimation("RotationAngleInDegrees");
                _containerShape_0.StopAnimation("Offset");
                _containerShape_1.StopAnimation("Offset");
                _containerShape_2.StopAnimation("RotationAngleInDegrees");
                _pathGeometry_31.StopAnimation("TrimStart");
                _root.Properties.StopAnimation("t0");
                _root.Properties.StopAnimation("t1");
            }

        }
    }
}
