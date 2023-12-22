using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Effects;
using Microsoft.Graphics.Canvas.Geometry;
using Microsoft.UI.Composition;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;

namespace GUI.AnimatedVisuals
{
    // Name:        A8927JK
    // Frame rate:  30 fps
    // Frame count: 180
    // Duration:    6000.0 mS
    // ________________________________________________________________
    // | Theme property |   Accessor   | Type  |    Default value     |
    // |________________|______________|_______|______________________|
    // | #00B7F7        | Color_00B7F7 | Color |      #FF00B7F7       |
    // | #29B6F6        | Color_29B6F6 | Color |      #FF29B6F6       |
    // | #650000        | Color_650000 | Color |      #FF650000       |
    // | #77E5ED        | Color_77E5ED | Color |      #FF77E5ED       |
    // | #909090        | Color_909090 | Color |      #FF909090       |
    // | #A0D35E        | Color_A0D35E | Color |      #FFA0D35E       |
    // | #AD82FF        | Color_AD82FF | Color |      #FFAD82FF       |
    // | #E1F5FE        | Color_E1F5FE | Color |      #FFE1F5FE       |
    // | #ED1B24        | Color_ED1B24 | Color |      #FFED1B24       |
    // | #F5F5F5        | Color_F5F5F5 | Color | #FFF5F5F5 WhiteSmoke |
    // | #FF3600        | Color_FF3600 | Color |      #FFFF3600       |
    // | #FF971A        | Color_FF971A | Color |      #FFFF971A       |
    // | #FFA42C        | Color_FFA42C | Color |      #FFFFA42C       |
    // | #FFC107        | Color_FFC107 | Color |      #FFFFC107       |
    // | #FFCE00        | Color_FFCE00 | Color |      #FFFFCE00       |
    // | #FFF3E0        | Color_FFF3E0 | Color |      #FFFFF3E0       |
    // | #FFFFFF        | Color_FFFFFF | Color |   #FFFFFFFF White    |
    // ----------------------------------------------------------------
    public sealed class Astronaut2
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
    {
        // Animation duration: 6.000 seconds.
        internal const long c_durationTicks = 60000000;

        // Theme property: Color_00B7F7.
        internal static readonly Color c_themeColor_00B7F7 = Color.FromArgb(0xFF, 0x00, 0xB7, 0xF7);

        // Theme property: Color_29B6F6.
        internal static readonly Color c_themeColor_29B6F6 = Color.FromArgb(0xFF, 0x29, 0xB6, 0xF6);

        // Theme property: Color_650000.
        internal static readonly Color c_themeColor_650000 = Color.FromArgb(0xFF, 0x65, 0x00, 0x00);

        // Theme property: Color_77E5ED.
        internal static readonly Color c_themeColor_77E5ED = Color.FromArgb(0xFF, 0x77, 0xE5, 0xED);

        // Theme property: Color_909090.
        internal static readonly Color c_themeColor_909090 = Color.FromArgb(0xFF, 0x90, 0x90, 0x90);

        // Theme property: Color_A0D35E.
        internal static readonly Color c_themeColor_A0D35E = Color.FromArgb(0xFF, 0xA0, 0xD3, 0x5E);

        // Theme property: Color_AD82FF.
        internal static readonly Color c_themeColor_AD82FF = Color.FromArgb(0xFF, 0xAD, 0x82, 0xFF);

        // Theme property: Color_E1F5FE.
        internal static readonly Color c_themeColor_E1F5FE = Color.FromArgb(0xFF, 0xE1, 0xF5, 0xFE);

        // Theme property: Color_ED1B24.
        internal static readonly Color c_themeColor_ED1B24 = Color.FromArgb(0xFF, 0xED, 0x1B, 0x24);

        // Theme property: Color_F5F5F5.
        internal static readonly Color c_themeColor_F5F5F5 = Color.FromArgb(0xFF, 0xF5, 0xF5, 0xF5);

        // Theme property: Color_FF3600.
        internal static readonly Color c_themeColor_FF3600 = Color.FromArgb(0xFF, 0xFF, 0x36, 0x00);

        // Theme property: Color_FF971A.
        internal static readonly Color c_themeColor_FF971A = Color.FromArgb(0xFF, 0xFF, 0x97, 0x1A);

        // Theme property: Color_FFA42C.
        internal static readonly Color c_themeColor_FFA42C = Color.FromArgb(0xFF, 0xFF, 0xA4, 0x2C);

        // Theme property: Color_FFC107.
        internal static readonly Color c_themeColor_FFC107 = Color.FromArgb(0xFF, 0xFF, 0xC1, 0x07);

        // Theme property: Color_FFCE00.
        internal static readonly Color c_themeColor_FFCE00 = Color.FromArgb(0xFF, 0xFF, 0xCE, 0x00);

        // Theme property: Color_FFF3E0.
        internal static readonly Color c_themeColor_FFF3E0 = Color.FromArgb(0xFF, 0xFF, 0xF3, 0xE0);

        // Theme property: Color_FFFFFF.
        internal static readonly Color c_themeColor_FFFFFF = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);

        CompositionPropertySet _themeProperties;
        Color _themeColor_00B7F7 = c_themeColor_00B7F7;
        Color _themeColor_29B6F6 = c_themeColor_29B6F6;
        Color _themeColor_650000 = c_themeColor_650000;
        Color _themeColor_77E5ED = c_themeColor_77E5ED;
        Color _themeColor_909090 = c_themeColor_909090;
        Color _themeColor_A0D35E = c_themeColor_A0D35E;
        Color _themeColor_AD82FF = c_themeColor_AD82FF;
        Color _themeColor_E1F5FE = c_themeColor_E1F5FE;
        Color _themeColor_ED1B24 = c_themeColor_ED1B24;
        Color _themeColor_F5F5F5 = c_themeColor_F5F5F5;
        Color _themeColor_FF3600 = c_themeColor_FF3600;
        Color _themeColor_FF971A = c_themeColor_FF971A;
        Color _themeColor_FFA42C = c_themeColor_FFA42C;
        Color _themeColor_FFC107 = c_themeColor_FFC107;
        Color _themeColor_FFCE00 = c_themeColor_FFCE00;
        Color _themeColor_FFF3E0 = c_themeColor_FFF3E0;
        Color _themeColor_FFFFFF = c_themeColor_FFFFFF;

        // Theme properties.
        public Color Color_00B7F7
        {
            get => _themeColor_00B7F7;
            set
            {
                _themeColor_00B7F7 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_00B7F7", ColorAsVector4((Color)_themeColor_00B7F7));
                }
            }
        }

        public Color Color_29B6F6
        {
            get => _themeColor_29B6F6;
            set
            {
                _themeColor_29B6F6 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_29B6F6", ColorAsVector4((Color)_themeColor_29B6F6));
                }
            }
        }

        public Color Color_650000
        {
            get => _themeColor_650000;
            set
            {
                _themeColor_650000 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_650000", ColorAsVector4((Color)_themeColor_650000));
                }
            }
        }

        public Color Color_77E5ED
        {
            get => _themeColor_77E5ED;
            set
            {
                _themeColor_77E5ED = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_77E5ED", ColorAsVector4((Color)_themeColor_77E5ED));
                }
            }
        }

        public Color Color_909090
        {
            get => _themeColor_909090;
            set
            {
                _themeColor_909090 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_909090", ColorAsVector4((Color)_themeColor_909090));
                }
            }
        }

        public Color Color_A0D35E
        {
            get => _themeColor_A0D35E;
            set
            {
                _themeColor_A0D35E = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_A0D35E", ColorAsVector4((Color)_themeColor_A0D35E));
                }
            }
        }

        public Color Color_AD82FF
        {
            get => _themeColor_AD82FF;
            set
            {
                _themeColor_AD82FF = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_AD82FF", ColorAsVector4((Color)_themeColor_AD82FF));
                }
            }
        }

        public Color Color_E1F5FE
        {
            get => _themeColor_E1F5FE;
            set
            {
                _themeColor_E1F5FE = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_E1F5FE", ColorAsVector4((Color)_themeColor_E1F5FE));
                }
            }
        }

        public Color Color_ED1B24
        {
            get => _themeColor_ED1B24;
            set
            {
                _themeColor_ED1B24 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_ED1B24", ColorAsVector4((Color)_themeColor_ED1B24));
                }
            }
        }

        public Color Color_F5F5F5
        {
            get => _themeColor_F5F5F5;
            set
            {
                _themeColor_F5F5F5 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_F5F5F5", ColorAsVector4((Color)_themeColor_F5F5F5));
                }
            }
        }

        public Color Color_FF3600
        {
            get => _themeColor_FF3600;
            set
            {
                _themeColor_FF3600 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_FF3600", ColorAsVector4((Color)_themeColor_FF3600));
                }
            }
        }

        public Color Color_FF971A
        {
            get => _themeColor_FF971A;
            set
            {
                _themeColor_FF971A = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_FF971A", ColorAsVector4((Color)_themeColor_FF971A));
                }
            }
        }

        public Color Color_FFA42C
        {
            get => _themeColor_FFA42C;
            set
            {
                _themeColor_FFA42C = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_FFA42C", ColorAsVector4((Color)_themeColor_FFA42C));
                }
            }
        }

        public Color Color_FFC107
        {
            get => _themeColor_FFC107;
            set
            {
                _themeColor_FFC107 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_FFC107", ColorAsVector4((Color)_themeColor_FFC107));
                }
            }
        }

        public Color Color_FFCE00
        {
            get => _themeColor_FFCE00;
            set
            {
                _themeColor_FFCE00 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_FFCE00", ColorAsVector4((Color)_themeColor_FFCE00));
                }
            }
        }

        public Color Color_FFF3E0
        {
            get => _themeColor_FFF3E0;
            set
            {
                _themeColor_FFF3E0 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_FFF3E0", ColorAsVector4((Color)_themeColor_FFF3E0));
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
                _themeProperties.InsertVector4("Color_00B7F7", ColorAsVector4((Color)Color_00B7F7));
                _themeProperties.InsertVector4("Color_29B6F6", ColorAsVector4((Color)Color_29B6F6));
                _themeProperties.InsertVector4("Color_650000", ColorAsVector4((Color)Color_650000));
                _themeProperties.InsertVector4("Color_77E5ED", ColorAsVector4((Color)Color_77E5ED));
                _themeProperties.InsertVector4("Color_909090", ColorAsVector4((Color)Color_909090));
                _themeProperties.InsertVector4("Color_A0D35E", ColorAsVector4((Color)Color_A0D35E));
                _themeProperties.InsertVector4("Color_AD82FF", ColorAsVector4((Color)Color_AD82FF));
                _themeProperties.InsertVector4("Color_E1F5FE", ColorAsVector4((Color)Color_E1F5FE));
                _themeProperties.InsertVector4("Color_ED1B24", ColorAsVector4((Color)Color_ED1B24));
                _themeProperties.InsertVector4("Color_F5F5F5", ColorAsVector4((Color)Color_F5F5F5));
                _themeProperties.InsertVector4("Color_FF3600", ColorAsVector4((Color)Color_FF3600));
                _themeProperties.InsertVector4("Color_FF971A", ColorAsVector4((Color)Color_FF971A));
                _themeProperties.InsertVector4("Color_FFA42C", ColorAsVector4((Color)Color_FFA42C));
                _themeProperties.InsertVector4("Color_FFC107", ColorAsVector4((Color)Color_FFC107));
                _themeProperties.InsertVector4("Color_FFCE00", ColorAsVector4((Color)Color_FFCE00));
                _themeProperties.InsertVector4("Color_FFF3E0", ColorAsVector4((Color)Color_FFF3E0));
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
                new Astronaut2_AnimatedVisual(
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
            if (propertyName == "Color_00B7F7")
            {
                _themeColor_00B7F7 = value;
            }
            else if (propertyName == "Color_29B6F6")
            {
                _themeColor_29B6F6 = value;
            }
            else if (propertyName == "Color_650000")
            {
                _themeColor_650000 = value;
            }
            else if (propertyName == "Color_77E5ED")
            {
                _themeColor_77E5ED = value;
            }
            else if (propertyName == "Color_909090")
            {
                _themeColor_909090 = value;
            }
            else if (propertyName == "Color_A0D35E")
            {
                _themeColor_A0D35E = value;
            }
            else if (propertyName == "Color_AD82FF")
            {
                _themeColor_AD82FF = value;
            }
            else if (propertyName == "Color_E1F5FE")
            {
                _themeColor_E1F5FE = value;
            }
            else if (propertyName == "Color_ED1B24")
            {
                _themeColor_ED1B24 = value;
            }
            else if (propertyName == "Color_F5F5F5")
            {
                _themeColor_F5F5F5 = value;
            }
            else if (propertyName == "Color_FF3600")
            {
                _themeColor_FF3600 = value;
            }
            else if (propertyName == "Color_FF971A")
            {
                _themeColor_FF971A = value;
            }
            else if (propertyName == "Color_FFA42C")
            {
                _themeColor_FFA42C = value;
            }
            else if (propertyName == "Color_FFC107")
            {
                _themeColor_FFC107 = value;
            }
            else if (propertyName == "Color_FFCE00")
            {
                _themeColor_FFCE00 = value;
            }
            else if (propertyName == "Color_FFF3E0")
            {
                _themeColor_FFF3E0 = value;
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

        sealed class Astronaut2_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual2
        {
            const long c_durationTicks = 60000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            readonly CompositionPropertySet _themeProperties;
            BooleanKeyFrameAnimation _isVisibleBooleanAnimation_0;
            BooleanKeyFrameAnimation _isVisibleBooleanAnimation_1;
            BooleanKeyFrameAnimation _isVisibleBooleanAnimation_2;
            BooleanKeyFrameAnimation _isVisibleBooleanAnimation_3;
            CompositionColorBrush _themeColor_Color_00B7F7;
            CompositionColorBrush _themeColor_Color_29B6F6;
            CompositionColorBrush _themeColor_Color_650000_0;
            CompositionColorBrush _themeColor_Color_650000_1;
            CompositionColorBrush _themeColor_Color_650000_2;
            CompositionColorBrush _themeColor_Color_77E5ED;
            CompositionColorBrush _themeColor_Color_909090;
            CompositionColorBrush _themeColor_Color_A0D35E;
            CompositionColorBrush _themeColor_Color_AD82FF;
            CompositionColorBrush _themeColor_Color_E1F5FE;
            CompositionColorBrush _themeColor_Color_ED1B24;
            CompositionColorBrush _themeColor_Color_F5F5F5;
            CompositionColorBrush _themeColor_Color_FF3600;
            CompositionColorBrush _themeColor_Color_FF971A;
            CompositionColorBrush _themeColor_Color_FFA42C;
            CompositionColorBrush _themeColor_Color_FFC107;
            CompositionColorBrush _themeColor_Color_FFCE00;
            CompositionColorBrush _themeColor_Color_FFF3E0;
            CompositionColorBrush _themeColor_Color_FFFFFF_0;
            CompositionColorBrush _themeColor_Color_FFFFFF_1;
            CompositionContainerShape _containerShape_00;
            CompositionContainerShape _containerShape_01;
            CompositionContainerShape _containerShape_02;
            CompositionContainerShape _containerShape_03;
            CompositionContainerShape _containerShape_04;
            CompositionContainerShape _containerShape_05;
            CompositionContainerShape _containerShape_06;
            CompositionContainerShape _containerShape_07;
            CompositionContainerShape _containerShape_08;
            CompositionContainerShape _containerShape_09;
            CompositionContainerShape _containerShape_10;
            CompositionContainerShape _containerShape_11;
            CompositionContainerShape _containerShape_12;
            CompositionContainerShape _containerShape_13;
            CompositionContainerShape _containerShape_14;
            CompositionContainerShape _containerShape_15;
            CompositionContainerShape _containerShape_16;
            CompositionContainerShape _containerShape_17;
            CompositionContainerShape _containerShape_18;
            CompositionContainerShape _containerShape_19;
            CompositionContainerShape _containerShape_20;
            CompositionContainerShape _containerShape_21;
            CompositionEllipseGeometry _ellipse_120p5;
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
            CompositionPathGeometry _pathGeometry_001;
            CompositionPathGeometry _pathGeometry_004;
            CompositionPathGeometry _pathGeometry_008;
            CompositionPathGeometry _pathGeometry_009;
            CompositionPathGeometry _pathGeometry_068;
            CompositionPathGeometry _pathGeometry_069;
            CompositionPathGeometry _pathGeometry_070;
            CompositionPathGeometry _pathGeometry_071;
            CompositionPathGeometry _pathGeometry_072;
            CompositionPathGeometry _pathGeometry_073;
            CompositionPathGeometry _pathGeometry_074;
            CompositionPathGeometry _pathGeometry_075;
            CompositionPathGeometry _pathGeometry_076;
            CompositionPathGeometry _pathGeometry_077;
            CompositionPathGeometry _pathGeometry_078;
            CompositionPathGeometry _pathGeometry_079;
            CompositionPathGeometry _pathGeometry_080;
            CompositionPathGeometry _pathGeometry_081;
            CompositionPathGeometry _pathGeometry_082;
            CompositionPathGeometry _pathGeometry_083;
            CompositionPathGeometry _pathGeometry_084;
            CompositionPathGeometry _pathGeometry_085;
            CompositionPathGeometry _pathGeometry_086;
            CompositionPathGeometry _pathGeometry_087;
            CompositionPathGeometry _pathGeometry_088;
            CompositionPathGeometry _pathGeometry_089;
            CompositionPathGeometry _pathGeometry_090;
            CompositionPathGeometry _pathGeometry_091;
            CompositionPathGeometry _pathGeometry_092;
            CompositionPathGeometry _pathGeometry_093;
            CompositionPathGeometry _pathGeometry_094;
            CompositionPathGeometry _pathGeometry_095;
            CompositionPathGeometry _pathGeometry_096;
            CompositionPathGeometry _pathGeometry_097;
            CompositionPathGeometry _pathGeometry_098;
            CompositionPathGeometry _pathGeometry_099;
            CompositionPathGeometry _pathGeometry_100;
            CompositionPathGeometry _pathGeometry_101;
            CompositionPathGeometry _pathGeometry_102;
            CompositionPathGeometry _pathGeometry_103;
            CompositionPathGeometry _pathGeometry_104;
            CompositionPathGeometry _pathGeometry_105;
            CompositionPathGeometry _pathGeometry_106;
            CompositionPathGeometry _pathGeometry_107;
            CompositionPathGeometry _pathGeometry_108;
            CompositionPathGeometry _pathGeometry_109;
            CompositionPathGeometry _pathGeometry_110;
            CompositionPathGeometry _pathGeometry_111;
            CompositionPathGeometry _pathGeometry_112;
            CompositionPathGeometry _pathGeometry_113;
            CompositionPathGeometry _pathGeometry_114;
            CompositionPathGeometry _pathGeometry_115;
            CompositionPathGeometry _pathGeometry_116;
            CompositionPathGeometry _pathGeometry_117;
            CompositionPathGeometry _pathGeometry_118;
            CompositionPathGeometry _pathGeometry_119;
            CompositionPathGeometry _pathGeometry_120;
            CompositionPathGeometry _pathGeometry_121;
            CompositionPathGeometry _pathGeometry_122;
            CompositionPathGeometry _pathGeometry_123;
            CompositionPathGeometry _pathGeometry_124;
            CompositionPathGeometry _pathGeometry_125;
            CompositionPathGeometry _pathGeometry_126;
            CompositionPathGeometry _pathGeometry_127;
            CompositionPathGeometry _pathGeometry_128;
            CompositionPathGeometry _pathGeometry_129;
            CompositionPathGeometry _pathGeometry_130;
            CompositionPathGeometry _pathGeometry_131;
            CompositionPathGeometry _pathGeometry_132;
            CompositionPathGeometry _pathGeometry_133;
            CompositionPathGeometry _pathGeometry_134;
            CompositionPathGeometry _pathGeometry_135;
            CompositionPathGeometry _pathGeometry_136;
            CompositionPathGeometry _pathGeometry_137;
            CompositionPathGeometry _pathGeometry_138;
            CompositionPathGeometry _pathGeometry_139;
            CompositionPathGeometry _pathGeometry_140;
            CompositionPathGeometry _pathGeometry_141;
            CompositionPathGeometry _pathGeometry_170;
            CompositionPathGeometry _pathGeometry_171;
            CompositionPathGeometry _pathGeometry_172;
            CompositionPathGeometry _pathGeometry_173;
            CompositionPathGeometry _pathGeometry_174;
            CompositionPathGeometry _pathGeometry_175;
            CompositionPathGeometry _pathGeometry_176;
            CompositionPathGeometry _pathGeometry_177;
            CompositionPathGeometry _pathGeometry_178;
            CompositionPathGeometry _pathGeometry_179;
            CompositionPathGeometry _pathGeometry_180;
            CompositionPathGeometry _pathGeometry_181;
            CompositionPathGeometry _pathGeometry_182;
            CompositionPathGeometry _pathGeometry_183;
            CompositionPathGeometry _pathGeometry_184;
            CompositionPathGeometry _pathGeometry_185;
            CompositionPathGeometry _pathGeometry_186;
            CompositionPathGeometry _pathGeometry_187;
            CompositionSpriteShape _spriteShape_001;
            CompositionSpriteShape _spriteShape_002;
            CompositionSpriteShape _spriteShape_003;
            CompositionSpriteShape _spriteShape_004;
            CompositionSpriteShape _spriteShape_005;
            CompositionSpriteShape _spriteShape_006;
            CompositionSpriteShape _spriteShape_007;
            CompositionSpriteShape _spriteShape_008;
            CompositionSpriteShape _spriteShape_009;
            CompositionSpriteShape _spriteShape_074;
            CompositionSpriteShape _spriteShape_075;
            CompositionSpriteShape _spriteShape_076;
            CompositionSpriteShape _spriteShape_080;
            CompositionSpriteShape _spriteShape_081;
            CompositionSpriteShape _spriteShape_082;
            CompositionSpriteShape _spriteShape_083;
            CompositionSpriteShape _spriteShape_084;
            CompositionSpriteShape _spriteShape_085;
            CompositionSpriteShape _spriteShape_086;
            CompositionSpriteShape _spriteShape_088;
            CompositionSpriteShape _spriteShape_089;
            CompositionSpriteShape _spriteShape_090;
            CompositionSpriteShape _spriteShape_091;
            CompositionSpriteShape _spriteShape_094;
            CompositionSpriteShape _spriteShape_095;
            CompositionSpriteShape _spriteShape_100;
            CompositionSpriteShape _spriteShape_101;
            CompositionSpriteShape _spriteShape_102;
            CompositionSpriteShape _spriteShape_103;
            CompositionSpriteShape _spriteShape_104;
            CompositionSpriteShape _spriteShape_108;
            CompositionSpriteShape _spriteShape_109;
            CompositionSpriteShape _spriteShape_110;
            CompositionSpriteShape _spriteShape_114;
            CompositionSpriteShape _spriteShape_115;
            CompositionSpriteShape _spriteShape_116;
            CompositionSpriteShape _spriteShape_117;
            CompositionSpriteShape _spriteShape_118;
            CompositionSpriteShape _spriteShape_119;
            CompositionSpriteShape _spriteShape_120;
            CompositionSpriteShape _spriteShape_122;
            CompositionSpriteShape _spriteShape_123;
            CompositionSpriteShape _spriteShape_124;
            CompositionSpriteShape _spriteShape_125;
            CompositionSpriteShape _spriteShape_128;
            CompositionSpriteShape _spriteShape_129;
            CompositionSpriteShape _spriteShape_134;
            CompositionSpriteShape _spriteShape_135;
            CompositionSpriteShape _spriteShape_136;
            CompositionSpriteShape _spriteShape_137;
            CompositionSpriteShape _spriteShape_138;
            CompositionSpriteShape _spriteShape_142;
            CompositionSpriteShape _spriteShape_143;
            CompositionSpriteShape _spriteShape_144;
            CompositionSpriteShape _spriteShape_148;
            CompositionSpriteShape _spriteShape_149;
            CompositionSpriteShape _spriteShape_150;
            CompositionSpriteShape _spriteShape_151;
            CompositionSpriteShape _spriteShape_152;
            CompositionSpriteShape _spriteShape_153;
            CompositionSpriteShape _spriteShape_154;
            CompositionSpriteShape _spriteShape_156;
            CompositionSpriteShape _spriteShape_157;
            CompositionSpriteShape _spriteShape_158;
            CompositionSpriteShape _spriteShape_159;
            CompositionSpriteShape _spriteShape_162;
            CompositionSpriteShape _spriteShape_163;
            CompositionSpriteShape _spriteShape_168;
            CompositionSpriteShape _spriteShape_169;
            CompositionSpriteShape _spriteShape_170;
            CompositionSpriteShape _spriteShape_171;
            CompositionSpriteShape _spriteShape_172;
            CompositionSpriteShape _spriteShape_176;
            CompositionSpriteShape _spriteShape_177;
            CompositionSpriteShape _spriteShape_178;
            CompositionSpriteShape _spriteShape_182;
            CompositionSpriteShape _spriteShape_183;
            CompositionSpriteShape _spriteShape_184;
            CompositionSpriteShape _spriteShape_185;
            CompositionSpriteShape _spriteShape_186;
            CompositionSpriteShape _spriteShape_187;
            CompositionSpriteShape _spriteShape_188;
            CompositionSpriteShape _spriteShape_190;
            CompositionSpriteShape _spriteShape_191;
            CompositionSpriteShape _spriteShape_192;
            CompositionSpriteShape _spriteShape_193;
            CompositionSpriteShape _spriteShape_196;
            CompositionSpriteShape _spriteShape_197;
            CompositionSpriteShape _spriteShape_202;
            CompositionSpriteShape _spriteShape_203;
            CompositionSpriteShape _spriteShape_204;
            CompositionSpriteShape _spriteShape_205;
            CompositionSpriteShape _spriteShape_206;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            CubicBezierEasingFunction _cubicBezierEasingFunction_1;
            CubicBezierEasingFunction _cubicBezierEasingFunction_2;
            CubicBezierEasingFunction _cubicBezierEasingFunction_3;
            CubicBezierEasingFunction _cubicBezierEasingFunction_4;
            CubicBezierEasingFunction _cubicBezierEasingFunction_5;
            ExpressionAnimation _rootProgress;
            ExpressionAnimation _rootProgressRemapped_0;
            ExpressionAnimation _rootProgressRemapped_1;
            ExpressionAnimation _rootProgressRemapped_2;
            ExpressionAnimation _rootProgressRemapped_3;
            ScalarKeyFrameAnimation _rotationAngleInDegreesScalarAnimation_0_to_0_2;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_0;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_1;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_2;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_3;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_4;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_5;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_0_6;
            ScalarKeyFrameAnimation _scalarAnimation_0_to_1;
            ScalarKeyFrameAnimation _scalarAnimation_1_to_0;
            ShapeVisual _shapeVisual_01;
            ShapeVisual _shapeVisual_02;
            ShapeVisual _shapeVisual_03;
            ShapeVisual _shapeVisual_04;
            ShapeVisual _shapeVisual_05;
            ShapeVisual _shapeVisual_06;
            ShapeVisual _shapeVisual_07;
            ShapeVisual _shapeVisual_08;
            ShapeVisual _shapeVisual_09;
            ShapeVisual _shapeVisual_10;
            ShapeVisual _shapeVisual_11;
            ShapeVisual _shapeVisual_12;
            ShapeVisual _shapeVisual_13;
            ShapeVisual _shapeVisual_14;
            ShapeVisual _shapeVisual_15;
            ShapeVisual _shapeVisual_16;
            StepEasingFunction _holdThenStepEasingFunction;
            StepEasingFunction _stepThenHoldEasingFunction;
            Vector2KeyFrameAnimation _offsetVector2Animation_00;
            Vector2KeyFrameAnimation _offsetVector2Animation_01;
            Vector2KeyFrameAnimation _offsetVector2Animation_02;
            Vector2KeyFrameAnimation _offsetVector2Animation_03;
            Vector2KeyFrameAnimation _offsetVector2Animation_04;

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

            BooleanKeyFrameAnimation CreateBooleanKeyFrameAnimation(float initialProgress, bool initialValue)
            {
                var result = _c.CreateBooleanKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue);
                return result;
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

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            BooleanKeyFrameAnimation IsVisibleBooleanAnimation_0()
            {
                // Frame 0.
                if (_isVisibleBooleanAnimation_0 != null) { return _isVisibleBooleanAnimation_0; }
                var result = _isVisibleBooleanAnimation_0 = CreateBooleanKeyFrameAnimation(0F, true);
                // Frame 45.
                result.InsertKeyFrame(0.25F, false);
                return result;
            }

            BooleanKeyFrameAnimation IsVisibleBooleanAnimation_1()
            {
                // Frame 0.
                if (_isVisibleBooleanAnimation_1 != null) { return _isVisibleBooleanAnimation_1; }
                var result = _isVisibleBooleanAnimation_1 = CreateBooleanKeyFrameAnimation(0F, false);
                // Frame 45.
                result.InsertKeyFrame(0.25F, true);
                // Frame 90.
                result.InsertKeyFrame(0.5F, false);
                return result;
            }

            BooleanKeyFrameAnimation IsVisibleBooleanAnimation_2()
            {
                // Frame 0.
                if (_isVisibleBooleanAnimation_2 != null) { return _isVisibleBooleanAnimation_2; }
                var result = _isVisibleBooleanAnimation_2 = CreateBooleanKeyFrameAnimation(0F, false);
                // Frame 90.
                result.InsertKeyFrame(0.5F, true);
                // Frame 135.
                result.InsertKeyFrame(0.75F, false);
                return result;
            }

            BooleanKeyFrameAnimation IsVisibleBooleanAnimation_3()
            {
                // Frame 0.
                if (_isVisibleBooleanAnimation_3 != null) { return _isVisibleBooleanAnimation_3; }
                var result = _isVisibleBooleanAnimation_3 = CreateBooleanKeyFrameAnimation(0F, false);
                // Frame 135.
                result.InsertKeyFrame(0.75F, true);
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_000()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(401.756989F, 22.3789997F));
                    builder.AddCubicBezier(new Vector2(401.756989F, 243.729996F), new Vector2(222.317001F, 423.169006F), new Vector2(0.966000021F, 423.169006F));
                    builder.AddCubicBezier(new Vector2(-220.384995F, 423.169006F), new Vector2(-399.824005F, 243.729996F), new Vector2(-399.824005F, 22.3789997F));
                    builder.AddCubicBezier(new Vector2(-399.824005F, -198.972F), new Vector2(-220.384995F, -378.411987F), new Vector2(0.966000021F, -378.411987F));
                    builder.AddCubicBezier(new Vector2(222.317001F, -378.411987F), new Vector2(401.756989F, -198.972F), new Vector2(401.756989F, 22.3789997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_001()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-323.983002F, 384.197998F));
                    builder.AddCubicBezier(new Vector2(-327.315002F, 380.865997F), new Vector2(-327.315002F, 375.463989F), new Vector2(-323.983002F, 372.131989F));
                    builder.AddCubicBezier(new Vector2(-320.651001F, 368.799988F), new Vector2(-315.248993F, 368.799988F), new Vector2(-311.916992F, 372.131989F));
                    builder.AddCubicBezier(new Vector2(-308.584991F, 375.463989F), new Vector2(-308.584991F, 380.865997F), new Vector2(-311.916992F, 384.197998F));
                    builder.AddCubicBezier(new Vector2(-315.248993F, 387.529999F), new Vector2(-320.651001F, 387.529999F), new Vector2(-323.983002F, 384.197998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - - Layer: Layer 12
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_002()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(358.893005F, 354.118988F));
                    builder.AddCubicBezier(new Vector2(358.893005F, 359.553009F), new Vector2(354.488007F, 363.958008F), new Vector2(349.053986F, 363.958008F));
                    builder.AddCubicBezier(new Vector2(343.619995F, 363.958008F), new Vector2(339.214996F, 359.553009F), new Vector2(339.214996F, 354.118988F));
                    builder.AddCubicBezier(new Vector2(339.214996F, 348.684998F), new Vector2(343.619995F, 344.279999F), new Vector2(349.053986F, 344.279999F));
                    builder.AddCubicBezier(new Vector2(354.488007F, 344.279999F), new Vector2(358.893005F, 348.684998F), new Vector2(358.893005F, 354.118988F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - - Layer: Layer 13
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_003()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(433.588013F, -230.266998F));
                    builder.AddCubicBezier(new Vector2(435.200012F, -226.028F), new Vector2(433.070007F, -221.285995F), new Vector2(428.830994F, -219.673996F));
                    builder.AddCubicBezier(new Vector2(424.59201F, -218.061996F), new Vector2(419.850006F, -220.192001F), new Vector2(418.238007F, -224.431F));
                    builder.AddCubicBezier(new Vector2(416.626007F, -228.669998F), new Vector2(418.755005F, -233.412003F), new Vector2(422.993988F, -235.024002F));
                    builder.AddCubicBezier(new Vector2(427.233002F, -236.636002F), new Vector2(431.976013F, -234.505997F), new Vector2(433.588013F, -230.266998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_004()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(381.630005F, -281.174988F));
                    builder.AddCubicBezier(new Vector2(383.527008F, -283.071991F), new Vector2(382.329987F, -287.578003F), new Vector2(378.97699F, -292.683014F));
                    builder.AddCubicBezier(new Vector2(377.980011F, -294.200989F), new Vector2(377.980011F, -296.157013F), new Vector2(378.97699F, -297.674988F));
                    builder.AddCubicBezier(new Vector2(382.329987F, -302.779999F), new Vector2(383.527008F, -307.286011F), new Vector2(381.630005F, -309.183014F));
                    builder.AddCubicBezier(new Vector2(379.733002F, -311.079987F), new Vector2(375.22699F, -309.881989F), new Vector2(370.122009F, -306.528992F));
                    builder.AddCubicBezier(new Vector2(368.604004F, -305.532013F), new Vector2(366.64801F, -305.532013F), new Vector2(365.130005F, -306.528992F));
                    builder.AddCubicBezier(new Vector2(360.024994F, -309.881989F), new Vector2(355.519989F, -311.079987F), new Vector2(353.622986F, -309.183014F));
                    builder.AddCubicBezier(new Vector2(351.726013F, -307.286011F), new Vector2(352.923004F, -302.779999F), new Vector2(356.276001F, -297.674988F));
                    builder.AddCubicBezier(new Vector2(357.27301F, -296.157013F), new Vector2(357.27301F, -294.200989F), new Vector2(356.276001F, -292.683014F));
                    builder.AddCubicBezier(new Vector2(352.923004F, -287.578003F), new Vector2(351.726013F, -283.071991F), new Vector2(353.622986F, -281.174988F));
                    builder.AddCubicBezier(new Vector2(355.519989F, -279.278015F), new Vector2(360.024994F, -280.475006F), new Vector2(365.130005F, -283.828003F));
                    builder.AddCubicBezier(new Vector2(366.64801F, -284.825012F), new Vector2(368.604004F, -284.825012F), new Vector2(370.122009F, -283.828003F));
                    builder.AddCubicBezier(new Vector2(375.22699F, -280.475006F), new Vector2(379.733002F, -279.278015F), new Vector2(381.630005F, -281.174988F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - - Layer: Layer 15
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_005()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-365.298004F, 322.286987F));
                    builder.AddCubicBezier(new Vector2(-363.115997F, 322.286987F), new Vector2(-361.213013F, 319.006012F), new Vector2(-360.204987F, 314.140991F));
                    builder.AddCubicBezier(new Vector2(-359.904999F, 312.694F), new Vector2(-358.781006F, 311.570007F), new Vector2(-357.334015F, 311.269989F));
                    builder.AddCubicBezier(new Vector2(-352.468994F, 310.261993F), new Vector2(-349.187988F, 308.359009F), new Vector2(-349.187988F, 306.177002F));
                    builder.AddCubicBezier(new Vector2(-349.187988F, 303.994995F), new Vector2(-352.468994F, 302.09201F), new Vector2(-357.334015F, 301.084015F));
                    builder.AddCubicBezier(new Vector2(-358.781006F, 300.783997F), new Vector2(-359.904999F, 299.660004F), new Vector2(-360.204987F, 298.213013F));
                    builder.AddCubicBezier(new Vector2(-361.213013F, 293.347992F), new Vector2(-363.115997F, 290.066986F), new Vector2(-365.298004F, 290.066986F));
                    builder.AddCubicBezier(new Vector2(-367.480011F, 290.066986F), new Vector2(-369.382996F, 293.347992F), new Vector2(-370.390991F, 298.213013F));
                    builder.AddCubicBezier(new Vector2(-370.69101F, 299.660004F), new Vector2(-371.815002F, 300.783997F), new Vector2(-373.261993F, 301.084015F));
                    builder.AddCubicBezier(new Vector2(-378.127014F, 302.09201F), new Vector2(-381.40799F, 303.994995F), new Vector2(-381.40799F, 306.177002F));
                    builder.AddCubicBezier(new Vector2(-381.40799F, 308.359009F), new Vector2(-378.127014F, 310.261993F), new Vector2(-373.261993F, 311.269989F));
                    builder.AddCubicBezier(new Vector2(-371.815002F, 311.570007F), new Vector2(-370.69101F, 312.694F), new Vector2(-370.390991F, 314.140991F));
                    builder.AddCubicBezier(new Vector2(-369.382996F, 319.006012F), new Vector2(-367.480011F, 322.286987F), new Vector2(-365.298004F, 322.286987F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - - Layer: Layer 16
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_006()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-406.576996F, -342.147003F));
                    builder.AddCubicBezier(new Vector2(-411.665009F, -347.223999F), new Vector2(-411.673004F, -355.463989F), new Vector2(-406.596008F, -360.552002F));
                    builder.AddCubicBezier(new Vector2(-401.519012F, -365.640015F), new Vector2(-393.279999F, -365.64801F), new Vector2(-388.191986F, -360.571014F));
                    builder.AddCubicBezier(new Vector2(-383.104004F, -355.493988F), new Vector2(-383.095001F, -347.255005F), new Vector2(-388.171997F, -342.166992F));
                    builder.AddCubicBezier(new Vector2(-393.248993F, -337.07901F), new Vector2(-401.489014F, -337.070007F), new Vector2(-406.576996F, -342.147003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - - Layer: Layer 17
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_007()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-470.231995F, -280.834015F));
                    builder.AddCubicBezier(new Vector2(-470.237F, -285.532013F), new Vector2(-466.432007F, -289.345001F), new Vector2(-461.734009F, -289.350006F));
                    builder.AddCubicBezier(new Vector2(-457.036011F, -289.355011F), new Vector2(-453.222992F, -285.549988F), new Vector2(-453.217987F, -280.85199F));
                    builder.AddCubicBezier(new Vector2(-453.213013F, -276.153992F), new Vector2(-457.018005F, -272.34201F), new Vector2(-461.716003F, -272.337006F));
                    builder.AddCubicBezier(new Vector2(-466.414001F, -272.332001F), new Vector2(-470.22699F, -276.135986F), new Vector2(-470.231995F, -280.834015F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
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
                    builder.BeginFigure(new Vector2(18F, 184F));
                    builder.AddCubicBezier(new Vector2(-8.33399963F, 189.386993F), new Vector2(-39.5F, 284.5F), new Vector2(-39.5F, 284.5F));
                    builder.AddCubicBezier(new Vector2(-39.5F, 284.5F), new Vector2(35F, 285F), new Vector2(71.5F, 259.5F));
                    builder.AddCubicBezier(new Vector2(96F, 233F), new Vector2(73F, 197.5F), new Vector2(73F, 197.5F));
                    builder.AddCubicBezier(new Vector2(73F, 197.5F), new Vector2(52F, 173F), new Vector2(18F, 184F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
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
                    builder.BeginFigure(new Vector2(22F, 186F));
                    builder.AddCubicBezier(new Vector2(-4.33400011F, 191.386993F), new Vector2(-29.5F, 276.5F), new Vector2(-29.5F, 276.5F));
                    builder.AddCubicBezier(new Vector2(-29.5F, 276.5F), new Vector2(32.5F, 280.5F), new Vector2(69F, 255F));
                    builder.AddCubicBezier(new Vector2(93.5F, 228.5F), new Vector2(73F, 197.5F), new Vector2(73F, 197.5F));
                    builder.AddCubicBezier(new Vector2(73F, 197.5F), new Vector2(56F, 175F), new Vector2(22F, 186F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
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
                    builder.BeginFigure(new Vector2(16F, 183.5F));
                    builder.AddCubicBezier(new Vector2(-10.3339996F, 188.886993F), new Vector2(-56F, 296F), new Vector2(-56F, 296F));
                    builder.AddCubicBezier(new Vector2(-56F, 296F), new Vector2(36F, 287F), new Vector2(72.5F, 261.5F));
                    builder.AddCubicBezier(new Vector2(97F, 235F), new Vector2(73F, 197.5F), new Vector2(73F, 197.5F));
                    builder.AddCubicBezier(new Vector2(73F, 197.5F), new Vector2(50F, 172.5F), new Vector2(16F, 183.5F));
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
                    builder.BeginFigure(new Vector2(22F, 186F));
                    builder.AddCubicBezier(new Vector2(-4.33400011F, 191.386993F), new Vector2(-13.5F, 266.5F), new Vector2(-13.5F, 266.5F));
                    builder.AddCubicBezier(new Vector2(-13.5F, 266.5F), new Vector2(32.5F, 280.5F), new Vector2(69F, 255F));
                    builder.AddCubicBezier(new Vector2(93.5F, 228.5F), new Vector2(73F, 197.5F), new Vector2(73F, 197.5F));
                    builder.AddCubicBezier(new Vector2(73F, 197.5F), new Vector2(56F, 175F), new Vector2(22F, 186F));
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
                    builder.BeginFigure(new Vector2(18F, 184F));
                    builder.AddCubicBezier(new Vector2(-8.33399963F, 189.386993F), new Vector2(-22.5510006F, 270.94101F), new Vector2(-22.5510006F, 270.94101F));
                    builder.AddCubicBezier(new Vector2(-22.5510006F, 270.94101F), new Vector2(35F, 285F), new Vector2(71.5F, 259.5F));
                    builder.AddCubicBezier(new Vector2(96F, 233F), new Vector2(73F, 197.5F), new Vector2(73F, 197.5F));
                    builder.AddCubicBezier(new Vector2(73F, 197.5F), new Vector2(52F, 173F), new Vector2(18F, 184F));
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
                    builder.BeginFigure(new Vector2(18.8470001F, 184F));
                    builder.AddCubicBezier(new Vector2(-7.48699999F, 189.386993F), new Vector2(-64.9240036F, 298.05899F), new Vector2(-64.9240036F, 298.05899F));
                    builder.AddCubicBezier(new Vector2(-64.9240036F, 298.05899F), new Vector2(36.6949997F, 286.695007F), new Vector2(73.1949997F, 261.195007F));
                    builder.AddCubicBezier(new Vector2(97.6949997F, 234.695007F), new Vector2(73F, 197.5F), new Vector2(73F, 197.5F));
                    builder.AddCubicBezier(new Vector2(73F, 197.5F), new Vector2(52.8470001F, 173F), new Vector2(18.8470001F, 184F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_014()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(100.324997F, 203.485992F));
                    builder.AddLine(new Vector2(75.6350021F, 173.992996F));
                    builder.AddCubicBezier(new Vector2(67.3769989F, 164.128006F), new Vector2(68.6790009F, 149.436996F), new Vector2(78.5439987F, 141.179001F));
                    builder.AddLine(new Vector2(133.139008F, 206.395004F));
                    builder.AddCubicBezier(new Vector2(123.274002F, 214.653F), new Vector2(108.583F, 213.350998F), new Vector2(100.324997F, 203.485992F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_015()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_016(), Geometry_017() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_016()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(117.149002F, 219.100006F));
                    builder.AddCubicBezier(new Vector2(111.570999F, 219.100006F), new Vector2(106.320999F, 216.649002F), new Vector2(102.742996F, 212.376007F));
                    builder.AddLine(new Vector2(67.3089981F, 170.048996F));
                    builder.AddCubicBezier(new Vector2(60.6629982F, 162.110001F), new Vector2(61.7150002F, 150.244003F), new Vector2(69.6539993F, 143.598007F));
                    builder.AddLine(new Vector2(76.0709991F, 138.225006F));
                    builder.AddCubicBezier(new Vector2(77.7030029F, 136.860001F), new Vector2(80.1320038F, 137.074997F), new Vector2(81.4980011F, 138.705994F));
                    builder.AddLine(new Vector2(136.091995F, 203.921997F));
                    builder.AddCubicBezier(new Vector2(136.748001F, 204.705002F), new Vector2(137.065994F, 205.716995F), new Vector2(136.975998F, 206.735001F));
                    builder.AddCubicBezier(new Vector2(136.886002F, 207.753006F), new Vector2(136.395004F, 208.692993F), new Vector2(135.612F, 209.348999F));
                    builder.AddLine(new Vector2(129.194F, 214.720993F));
                    builder.AddCubicBezier(new Vector2(125.82F, 217.544998F), new Vector2(121.542999F, 219.100006F), new Vector2(117.149002F, 219.100006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_017()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(78.0630035F, 146.606003F));
                    builder.AddLine(new Vector2(74.5999985F, 149.505005F));
                    builder.AddCubicBezier(new Vector2(69.9179993F, 153.423996F), new Vector2(69.2979965F, 160.421997F), new Vector2(73.2170029F, 165.104004F));
                    builder.AddLine(new Vector2(108.650002F, 207.429993F));
                    builder.AddCubicBezier(new Vector2(110.760002F, 209.949997F), new Vector2(113.858002F, 211.395996F), new Vector2(117.149002F, 211.395996F));
                    builder.AddCubicBezier(new Vector2(119.737999F, 211.395996F), new Vector2(122.260002F, 210.479004F), new Vector2(124.249001F, 208.813004F));
                    builder.AddLine(new Vector2(127.711998F, 205.914001F));
                    builder.AddLine(new Vector2(78.0630035F, 146.606003F));
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
                    builder.BeginFigure(new Vector2(78.5439987F, 141.179001F));
                    builder.AddLine(new Vector2(78.2910004F, 141.391006F));
                    builder.AddLine(new Vector2(114.649002F, 184.822998F));
                    builder.AddLine(new Vector2(108.232002F, 190.195999F));
                    builder.AddCubicBezier(new Vector2(102.731003F, 194.800995F), new Vector2(94.8899994F, 194.761002F), new Vector2(89.4599991F, 190.507996F));
                    builder.AddLine(new Vector2(105.696999F, 209.903F));
                    builder.AddCubicBezier(new Vector2(110.987999F, 216.223999F), new Vector2(120.401001F, 217.057999F), new Vector2(126.722F, 211.766998F));
                    builder.AddLine(new Vector2(133.139008F, 206.395004F));
                    builder.AddLine(new Vector2(78.5439987F, 141.179001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_019()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(82.5070038F, 151.912994F));
                    builder.AddLine(new Vector2(78.7279968F, 155.076004F));
                    builder.AddCubicBezier(new Vector2(75.1190033F, 158.098007F), new Vector2(73.7939987F, 162.822998F), new Vector2(74.8909988F, 167.102997F));
                    builder.AddLine(new Vector2(82.5920029F, 176.302002F));
                    builder.AddCubicBezier(new Vector2(81.5110016F, 172.035004F), new Vector2(82.8359985F, 167.332993F), new Vector2(86.4329987F, 164.320999F));
                    builder.AddLine(new Vector2(90.2320023F, 161.141006F));
                    builder.AddLine(new Vector2(82.5070038F, 151.912994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_020()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(126.936996F, 199.496994F));
                    builder.AddLine(new Vector2(83.4240036F, 147.520004F));
                    builder.AddCubicBezier(new Vector2(77.8929977F, 140.912994F), new Vector2(78.7659988F, 131.072998F), new Vector2(85.3730011F, 125.542F));
                    builder.AddLine(new Vector2(148.914001F, 201.445007F));
                    builder.AddCubicBezier(new Vector2(142.307007F, 206.975998F), new Vector2(132.468002F, 206.104004F), new Vector2(126.936996F, 199.496994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_021()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_022(), Geometry_023() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_022()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(138.238998F, 211.115005F));
                    builder.AddCubicBezier(new Vector2(134.044006F, 211.115005F), new Vector2(130.095001F, 209.270996F), new Vector2(127.403999F, 206.057007F));
                    builder.AddLine(new Vector2(77.0490036F, 145.904999F));
                    builder.AddCubicBezier(new Vector2(74.6269989F, 143.011993F), new Vector2(73.4779968F, 139.350006F), new Vector2(73.810997F, 135.591995F));
                    builder.AddCubicBezier(new Vector2(74.1439972F, 131.834F), new Vector2(75.9199982F, 128.432007F), new Vector2(78.8130035F, 126.010002F));
                    builder.AddLine(new Vector2(82.9000015F, 122.587997F));
                    builder.AddCubicBezier(new Vector2(83.6829987F, 121.931999F), new Vector2(84.6949997F, 121.615997F), new Vector2(85.7129974F, 121.705002F));
                    builder.AddCubicBezier(new Vector2(86.7310028F, 121.794998F), new Vector2(87.6699982F, 122.286003F), new Vector2(88.3259964F, 123.069F));
                    builder.AddLine(new Vector2(151.867996F, 198.973007F));
                    builder.AddCubicBezier(new Vector2(153.233994F, 200.604004F), new Vector2(153.018005F, 203.033005F), new Vector2(151.386993F, 204.399002F));
                    builder.AddLine(new Vector2(147.300003F, 207.820999F));
                    builder.AddCubicBezier(new Vector2(144.761993F, 209.945007F), new Vector2(141.544006F, 211.115005F), new Vector2(138.238998F, 211.115005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_023()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(84.8919983F, 130.968994F));
                    builder.AddLine(new Vector2(83.7580032F, 131.917007F));
                    builder.AddCubicBezier(new Vector2(82.4430008F, 133.018005F), new Vector2(81.6350021F, 134.565002F), new Vector2(81.4840012F, 136.272995F));
                    builder.AddCubicBezier(new Vector2(81.3330002F, 137.981003F), new Vector2(81.8550034F, 139.645004F), new Vector2(82.9560013F, 140.960007F));
                    builder.AddLine(new Vector2(133.311996F, 201.112F));
                    builder.AddCubicBezier(new Vector2(134.535004F, 202.572998F), new Vector2(136.330994F, 203.410995F), new Vector2(138.238998F, 203.410995F));
                    builder.AddCubicBezier(new Vector2(139.761002F, 203.410995F), new Vector2(141.184998F, 202.893005F), new Vector2(142.354996F, 201.912994F));
                    builder.AddLine(new Vector2(143.488007F, 200.964005F));
                    builder.AddLine(new Vector2(84.8919983F, 130.968994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_024()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(84.987999F, 129.882996F));
                    builder.AddLine(new Vector2(84.2710037F, 130.483002F));
                    builder.AddLine(new Vector2(129.164993F, 184.110992F));
                    builder.AddLine(new Vector2(127.440002F, 185.556F));
                    builder.AddCubicBezier(new Vector2(125.371002F, 187.287003F), new Vector2(122.616997F, 187.619995F), new Vector2(120.259003F, 186.720001F));
                    builder.AddLine(new Vector2(132.720001F, 201.606003F));
                    builder.AddCubicBezier(new Vector2(135.264008F, 204.643997F), new Vector2(139.809006F, 205.048004F), new Vector2(142.848999F, 202.505005F));
                    builder.AddLine(new Vector2(144.572998F, 201.059998F));
                    builder.AddLine(new Vector2(84.987999F, 129.882996F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_025()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(90.7289963F, 137.940002F));
                    builder.AddLine(new Vector2(89.4250031F, 139.031006F));
                    builder.AddCubicBezier(new Vector2(87.3850021F, 140.740005F), new Vector2(86.5660019F, 143.343002F), new Vector2(87.0019989F, 145.792007F));
                    builder.AddLine(new Vector2(93.1289978F, 153.112F));
                    builder.AddCubicBezier(new Vector2(92.8339996F, 150.778F), new Vector2(93.6539993F, 148.356995F), new Vector2(95.5889969F, 146.735992F));
                    builder.AddLine(new Vector2(97.0599976F, 145.503998F));
                    builder.AddLine(new Vector2(90.7289963F, 137.940002F));
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
                    builder.BeginFigure(new Vector2(437.928986F, -133.852997F));
                    builder.AddCubicBezier(new Vector2(373.97699F, -135.876007F), new Vector2(215.634003F, -115.123001F), new Vector2(94.1190033F, 114.589996F));
                    builder.AddLine(new Vector2(84.7350006F, 122.473F));
                    builder.AddLine(new Vector2(117.489998F, 161.468002F));
                    builder.AddLine(new Vector2(118.346001F, 162.487F));
                    builder.AddLine(new Vector2(151.100998F, 201.481995F));
                    builder.AddLine(new Vector2(160.485001F, 193.600006F));
                    builder.AddCubicBezier(new Vector2(407.72699F, 113.566002F), new Vector2(455.505005F, -38.8170013F), new Vector2(464.552002F, -102.157997F));
                    builder.AddCubicBezier(new Vector2(466.897003F, -118.572998F), new Vector2(454.502014F, -133.328995F), new Vector2(437.928986F, -133.852997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_027()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_028(), Geometry_029() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_028()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(151.100998F, 206.104004F));
                    builder.AddCubicBezier(new Vector2(150.968002F, 206.104004F), new Vector2(150.834F, 206.098999F), new Vector2(150.699997F, 206.087006F));
                    builder.AddCubicBezier(new Vector2(149.479004F, 205.981003F), new Vector2(148.348999F, 205.393997F), new Vector2(147.561005F, 204.455002F));
                    builder.AddLine(new Vector2(81.1959991F, 125.445999F));
                    builder.AddCubicBezier(new Vector2(79.5540009F, 123.490997F), new Vector2(79.8069992F, 120.574997F), new Vector2(81.762001F, 118.932999F));
                    builder.AddLine(new Vector2(90.4560013F, 111.629997F));
                    builder.AddCubicBezier(new Vector2(141.690002F, 15.0459995F), new Vector2(204.811005F, -54.9939995F), new Vector2(278.075012F, -96.5540009F));
                    builder.AddCubicBezier(new Vector2(339.334015F, -131.304001F), new Vector2(394.588013F, -138.597F), new Vector2(430.153992F, -138.597F));
                    builder.AddCubicBezier(new Vector2(432.808014F, -138.597F), new Vector2(435.472992F, -138.556F), new Vector2(438.075012F, -138.473999F));
                    builder.AddCubicBezier(new Vector2(447.286987F, -138.182999F), new Vector2(455.960999F, -133.977997F), new Vector2(461.873993F, -126.938004F));
                    builder.AddCubicBezier(new Vector2(467.786987F, -119.899002F), new Vector2(470.431F, -110.628998F), new Vector2(469.127991F, -101.504997F));
                    builder.AddCubicBezier(new Vector2(466.162994F, -80.7490005F), new Vector2(460.5F, -59.6469994F), new Vector2(452.295013F, -38.7869987F));
                    builder.AddCubicBezier(new Vector2(441.065002F, -10.2360001F), new Vector2(425.312988F, 17.0499992F), new Vector2(405.47699F, 42.3149986F));
                    builder.AddCubicBezier(new Vector2(380.962006F, 73.5400009F), new Vector2(350.053986F, 101.818001F), new Vector2(313.610992F, 126.363998F));
                    builder.AddCubicBezier(new Vector2(271.096985F, 155F), new Vector2(220.350006F, 179.005005F), new Vector2(162.768005F, 197.718994F));
                    builder.AddLine(new Vector2(154.074005F, 205.020996F));
                    builder.AddCubicBezier(new Vector2(153.238007F, 205.723007F), new Vector2(152.184006F, 206.104004F), new Vector2(151.100998F, 206.104004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_029()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(91.2470016F, 123.039001F));
                    builder.AddLine(new Vector2(151.667007F, 194.968994F));
                    builder.AddLine(new Vector2(157.511993F, 190.059998F));
                    builder.AddCubicBezier(new Vector2(157.968002F, 189.677002F), new Vector2(158.494003F, 189.386002F), new Vector2(159.061005F, 189.201996F));
                    builder.AddCubicBezier(new Vector2(404.350006F, 109.801003F), new Vector2(451.213013F, -41.4630013F), new Vector2(459.976013F, -102.811996F));
                    builder.AddCubicBezier(new Vector2(460.90799F, -109.336998F), new Vector2(459.019989F, -115.962997F), new Vector2(454.79599F, -120.991997F));
                    builder.AddCubicBezier(new Vector2(450.571991F, -126.021004F), new Vector2(444.369995F, -129.024994F), new Vector2(437.78299F, -129.233002F));
                    builder.AddCubicBezier(new Vector2(435.277008F, -129.311996F), new Vector2(432.709991F, -129.352997F), new Vector2(430.153992F, -129.352997F));
                    builder.AddCubicBezier(new Vector2(369.48999F, -129.352997F), new Vector2(215.705002F, -105.372002F), new Vector2(98.2050018F, 116.751999F));
                    builder.AddCubicBezier(new Vector2(97.9260025F, 117.278999F), new Vector2(97.5490036F, 117.747002F), new Vector2(97.0920029F, 118.129997F));
                    builder.AddLine(new Vector2(91.2470016F, 123.039001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_030()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(177.660004F, 98.3590012F));
                    builder.AddCubicBezier(new Vector2(174.356995F, 100.026001F), new Vector2(171.880997F, 101.700996F), new Vector2(170.104996F, 103.464996F));
                    builder.AddLine(new Vector2(83.6350021F, 188.350006F));
                    builder.AddLine(new Vector2(98.3050003F, 205.873993F));
                    builder.AddLine(new Vector2(196.731995F, 135.199997F));
                    builder.AddCubicBezier(new Vector2(198.794998F, 133.742004F), new Vector2(200.871994F, 131.591995F), new Vector2(203.084F, 128.628006F));
                    builder.AddCubicBezier(new Vector2(208.895004F, 120.841003F), new Vector2(208.651993F, 110.671997F), new Vector2(202.479996F, 103.322998F));
                    builder.AddCubicBezier(new Vector2(196.307999F, 95.973999F), new Vector2(186.332993F, 93.9800034F), new Vector2(177.660004F, 98.3590012F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_031()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(454.798004F, -73.6689987F));
                    builder.AddCubicBezier(new Vector2(457.707001F, -84.689003F), new Vector2(459.567993F, -94.5029984F), new Vector2(460.739014F, -102.703003F));
                    builder.AddCubicBezier(new Vector2(461.701996F, -109.444F), new Vector2(459.751007F, -116.290001F), new Vector2(455.385986F, -121.487F));
                    builder.AddCubicBezier(new Vector2(451.020996F, -126.683998F), new Vector2(444.614014F, -129.787994F), new Vector2(437.807007F, -130.003998F));
                    builder.AddCubicBezier(new Vector2(429.312012F, -130.272995F), new Vector2(419.019012F, -130.121994F), new Vector2(407.286011F, -129.087006F));
                    builder.AddCubicBezier(new Vector2(412.96701F, -117.632004F), new Vector2(428.122986F, -91.3590012F), new Vector2(454.798004F, -73.6689987F));
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
                    builder.BeginFigure(new Vector2(452.153015F, -129.410995F));
                    builder.AddCubicBezier(new Vector2(442.934998F, -65.7870026F), new Vector2(394.785004F, 86.0299988F), new Vector2(148.158005F, 165.865005F));
                    builder.AddLine(new Vector2(138.774002F, 173.746994F));
                    builder.AddLine(new Vector2(130.628006F, 164.048996F));
                    builder.AddCubicBezier(new Vector2(125.148003F, 91.5599976F), new Vector2(156.589996F, 33.1640015F), new Vector2(156.589996F, 33.1640015F));
                    builder.AddLine(new Vector2(116.575996F, 98.1299973F));
                    builder.AddLine(new Vector2(101.021004F, 103.108002F));
                    builder.AddLine(new Vector2(91.1669998F, 117.07F));
                    builder.AddLine(new Vector2(84.9160004F, 122.320999F));
                    builder.AddLine(new Vector2(111.327003F, 153.764008F));
                    builder.AddLine(new Vector2(112.182999F, 154.783005F));
                    builder.AddLine(new Vector2(144.938004F, 193.778F));
                    builder.AddLine(new Vector2(154.322006F, 185.895004F));
                    builder.AddCubicBezier(new Vector2(401.563995F, 105.861F), new Vector2(449.34201F, -46.5219994F), new Vector2(458.389008F, -109.862999F));
                    builder.AddCubicBezier(new Vector2(459.272003F, -116.043999F), new Vector2(458.054993F, -121.981003F), new Vector2(455.320007F, -127.016998F));
                    builder.AddCubicBezier(new Vector2(454.325012F, -127.886002F), new Vector2(453.268005F, -128.688004F), new Vector2(452.153015F, -129.410995F));
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
                    builder.BeginFigure(new Vector2(455.319F, -127.018997F));
                    builder.AddCubicBezier(new Vector2(455.319F, -127.017998F), new Vector2(455.320007F, -127.017998F), new Vector2(455.320007F, -127.016998F));
                    builder.AddCubicBezier(new Vector2(455.322998F, -127.014999F), new Vector2(455.324005F, -127.013F), new Vector2(455.326996F, -127.011002F));
                    builder.AddCubicBezier(new Vector2(455.324005F, -127.014F), new Vector2(455.321991F, -127.015999F), new Vector2(455.319F, -127.018997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_034()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(458.342987F, -116.998001F));
                    builder.AddCubicBezier(new Vector2(453.980988F, -122.110001F), new Vector2(447.63501F, -125.167F), new Vector2(440.889008F, -125.380997F));
                    builder.AddCubicBezier(new Vector2(432.394012F, -125.650002F), new Vector2(422.101013F, -125.5F), new Vector2(410.368011F, -124.464996F));
                    builder.AddCubicBezier(new Vector2(412.167999F, -120.834999F), new Vector2(414.95401F, -115.695F), new Vector2(418.727997F, -109.830002F));
                    builder.AddCubicBezier(new Vector2(419.218994F, -109.122002F), new Vector2(419.700012F, -108.418999F), new Vector2(420.217987F, -107.697998F));
                    builder.AddCubicBezier(new Vector2(417.235992F, -112.526001F), new Vector2(414.993011F, -116.731003F), new Vector2(413.450012F, -119.842003F));
                    builder.AddCubicBezier(new Vector2(425.183014F, -120.876999F), new Vector2(435.475006F, -121.028F), new Vector2(443.970001F, -120.759003F));
                    builder.AddCubicBezier(new Vector2(449.77301F, -120.574997F), new Vector2(455.272003F, -118.276001F), new Vector2(459.475006F, -114.386002F));
                    builder.AddCubicBezier(new Vector2(459.147003F, -115.277F), new Vector2(458.776001F, -116.150002F), new Vector2(458.342987F, -116.998001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_035()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(253.195999F, 150.074005F));
                    builder.AddLine(new Vector2(234.485992F, 201.371002F));
                    builder.AddCubicBezier(new Vector2(230.656998F, 211.869995F), new Vector2(223.608994F, 220.891006F), new Vector2(214.348999F, 227.147003F));
                    builder.AddLine(new Vector2(140.272995F, 277.188995F));
                    builder.AddCubicBezier(new Vector2(134.570999F, 281.040985F), new Vector2(127.617996F, 274.458008F), new Vector2(131.153F, 268.554993F));
                    builder.AddLine(new Vector2(172.638F, 199.274002F));
                    builder.AddLine(new Vector2(178.470993F, 178.369003F));
                    builder.AddLine(new Vector2(253.195999F, 150.074005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_036()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_037(), Geometry_038() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_037()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(136.667007F, 282.960999F));
                    builder.AddCubicBezier(new Vector2(132.701996F, 282.960999F), new Vector2(128.996002F, 280.768005F), new Vector2(126.995003F, 277.238007F));
                    builder.AddCubicBezier(new Vector2(125.037003F, 273.783997F), new Vector2(125.109001F, 269.649994F), new Vector2(127.186996F, 266.179993F));
                    builder.AddLine(new Vector2(168.352997F, 197.432007F));
                    builder.AddLine(new Vector2(174.018005F, 177.126999F));
                    builder.AddCubicBezier(new Vector2(174.412994F, 175.710999F), new Vector2(175.459F, 174.567001F), new Vector2(176.834F, 174.046005F));
                    builder.AddLine(new Vector2(251.559006F, 145.751999F));
                    builder.AddCubicBezier(new Vector2(253.25F, 145.110992F), new Vector2(255.158997F, 145.514999F), new Vector2(256.445007F, 146.785995F));
                    builder.AddCubicBezier(new Vector2(257.730988F, 148.056F), new Vector2(258.158997F, 149.960999F), new Vector2(257.539001F, 151.658997F));
                    builder.AddLine(new Vector2(238.828995F, 202.955002F));
                    builder.AddCubicBezier(new Vector2(234.639008F, 214.442001F), new Vector2(227.069F, 224.132004F), new Vector2(216.936996F, 230.977005F));
                    builder.AddLine(new Vector2(142.860992F, 281.019989F));
                    builder.AddCubicBezier(new Vector2(140.981003F, 282.290009F), new Vector2(138.839005F, 282.960999F), new Vector2(136.667007F, 282.960999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_038()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(182.294998F, 181.863998F));
                    builder.AddLine(new Vector2(177.091003F, 200.516006F));
                    builder.AddCubicBezier(new Vector2(176.979996F, 200.914001F), new Vector2(176.815994F, 201.294998F), new Vector2(176.604004F, 201.649002F));
                    builder.AddLine(new Vector2(135.119003F, 270.928986F));
                    builder.AddCubicBezier(new Vector2(134.742996F, 271.557007F), new Vector2(134.716995F, 272.113007F), new Vector2(135.037994F, 272.678986F));
                    builder.AddCubicBezier(new Vector2(135.384003F, 273.289001F), new Vector2(136.054001F, 273.716003F), new Vector2(136.667007F, 273.716003F));
                    builder.AddCubicBezier(new Vector2(136.996002F, 273.716003F), new Vector2(137.328995F, 273.598999F), new Vector2(137.684998F, 273.359009F));
                    builder.AddLine(new Vector2(211.761002F, 223.317001F));
                    builder.AddCubicBezier(new Vector2(220.268997F, 217.569F), new Vector2(226.625F, 209.432999F), new Vector2(230.143005F, 199.787994F));
                    builder.AddLine(new Vector2(245.395996F, 157.970993F));
                    builder.AddLine(new Vector2(182.294998F, 181.863998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_039()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(230.143005F, 199.787003F));
                    builder.AddLine(new Vector2(245.395996F, 157.970993F));
                    builder.AddLine(new Vector2(238.544998F, 160.565994F));
                    builder.AddLine(new Vector2(224.703995F, 198.511002F));
                    builder.AddCubicBezier(new Vector2(221.130005F, 208.309998F), new Vector2(214.671997F, 216.574997F), new Vector2(206.029999F, 222.414993F));
                    builder.AddLine(new Vector2(135.735001F, 269.903015F));
                    builder.AddLine(new Vector2(135.119995F, 270.928986F));
                    builder.AddCubicBezier(new Vector2(134.501999F, 271.959991F), new Vector2(134.945007F, 272.720001F), new Vector2(135.427002F, 273.174011F));
                    builder.AddCubicBezier(new Vector2(135.910004F, 273.630005F), new Vector2(136.695999F, 274.024994F), new Vector2(137.684998F, 273.359985F));
                    builder.AddLine(new Vector2(211.761002F, 223.315994F));
                    builder.AddCubicBezier(new Vector2(220.268997F, 217.570007F), new Vector2(226.625F, 209.432007F), new Vector2(230.143005F, 199.787003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_040()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(154.001999F, 31.9829998F));
                    builder.AddLine(new Vector2(100.246002F, 41.5569992F));
                    builder.AddCubicBezier(new Vector2(89.2440033F, 43.5159988F), new Vector2(79.1419983F, 48.901001F), new Vector2(71.3809967F, 56.9420013F));
                    builder.AddLine(new Vector2(9.30099964F, 121.265999F));
                    builder.AddCubicBezier(new Vector2(4.52299976F, 126.217003F), new Vector2(9.80700016F, 134.203003F), new Vector2(16.2320004F, 131.740005F));
                    builder.AddLine(new Vector2(91.6340027F, 102.837997F));
                    builder.AddLine(new Vector2(113.232002F, 100.702003F));
                    builder.AddLine(new Vector2(154.001999F, 31.9829998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_041()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_042(), Geometry_043() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_042()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(13.8310003F, 136.822998F));
                    builder.AddLine(new Vector2(13.8299999F, 136.822998F));
                    builder.AddCubicBezier(new Vector2(9.45100021F, 136.822006F), new Vector2(5.4829998F, 134.141998F), new Vector2(3.72199988F, 129.994003F));
                    builder.AddCubicBezier(new Vector2(1.97599995F, 125.879997F), new Vector2(2.83899999F, 121.306999F), new Vector2(5.9749999F, 118.056999F));
                    builder.AddLine(new Vector2(68.0550003F, 53.7319984F));
                    builder.AddCubicBezier(new Vector2(76.5459976F, 44.9329987F), new Vector2(87.3970032F, 39.1500015F), new Vector2(99.4349976F, 37.0060005F));
                    builder.AddLine(new Vector2(153.192001F, 27.4319992F));
                    builder.AddCubicBezier(new Vector2(154.975006F, 27.1159992F), new Vector2(156.772995F, 27.8649998F), new Vector2(157.802002F, 29.3509998F));
                    builder.AddCubicBezier(new Vector2(158.832001F, 30.8369999F), new Vector2(158.899994F, 32.7869987F), new Vector2(157.977997F, 34.3419991F));
                    builder.AddLine(new Vector2(117.207001F, 103.059998F));
                    builder.AddCubicBezier(new Vector2(116.457001F, 104.324997F), new Vector2(115.150002F, 105.156998F), new Vector2(113.686996F, 105.302002F));
                    builder.AddLine(new Vector2(92.7080002F, 107.376999F));
                    builder.AddLine(new Vector2(17.8859997F, 136.056F));
                    builder.AddCubicBezier(new Vector2(16.559F, 136.565002F), new Vector2(15.1949997F, 136.822998F), new Vector2(13.8310003F, 136.822998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_043()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(144.878006F, 38.3030014F));
                    builder.AddLine(new Vector2(101.056F, 46.1080017F));
                    builder.AddCubicBezier(new Vector2(90.947998F, 47.9080009F), new Vector2(81.836998F, 52.7639999F), new Vector2(74.7070007F, 60.1520004F));
                    builder.AddLine(new Vector2(12.6280003F, 124.476997F));
                    builder.AddCubicBezier(new Vector2(12.4209995F, 124.692001F), new Vector2(11.7910004F, 125.343002F), new Vector2(12.2320004F, 126.380997F));
                    builder.AddCubicBezier(new Vector2(12.4849997F, 126.975998F), new Vector2(13.0769997F, 127.578003F), new Vector2(13.8310003F, 127.578003F));
                    builder.AddCubicBezier(new Vector2(14.059F, 127.578003F), new Vector2(14.3109999F, 127.525002F), new Vector2(14.5780001F, 127.422997F));
                    builder.AddLine(new Vector2(89.9800034F, 98.5220032F));
                    builder.AddCubicBezier(new Vector2(90.3649979F, 98.3740005F), new Vector2(90.7679977F, 98.2789993F), new Vector2(91.1790009F, 98.237999F));
                    builder.AddLine(new Vector2(110.449997F, 96.3320007F));
                    builder.AddLine(new Vector2(144.878006F, 38.3030014F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_044()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(141.602997F, 43.8240013F));
                    builder.AddLine(new Vector2(144.878998F, 38.3030014F));
                    builder.AddLine(new Vector2(101.056999F, 46.105999F));
                    builder.AddCubicBezier(new Vector2(90.9469986F, 47.9090004F), new Vector2(81.8359985F, 52.7639999F), new Vector2(74.7080002F, 60.151001F));
                    builder.AddLine(new Vector2(12.6260004F, 124.475998F));
                    builder.AddCubicBezier(new Vector2(11.7939997F, 125.339996F), new Vector2(12.0539999F, 126.179001F), new Vector2(12.4200001F, 126.733002F));
                    builder.AddCubicBezier(new Vector2(12.7840004F, 127.283997F), new Vector2(13.4519997F, 127.852997F), new Vector2(14.5760002F, 127.424004F));
                    builder.AddLine(new Vector2(22.1310005F, 124.528F));
                    builder.AddLine(new Vector2(80.3160019F, 64.2399979F));
                    builder.AddCubicBezier(new Vector2(87.5579987F, 56.7360001F), new Vector2(96.814003F, 51.8019981F), new Vector2(107.084999F, 49.9710007F));
                    builder.AddLine(new Vector2(141.602997F, 43.8240013F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_045()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(455.406006F, -63.9099998F));
                    builder.AddCubicBezier(new Vector2(454.842987F, -63.9099998F), new Vector2(454.27301F, -64.064003F), new Vector2(453.760986F, -64.3880005F));
                    builder.AddCubicBezier(new Vector2(416.587006F, -87.9069977F), new Vector2(400.928986F, -124.346001F), new Vector2(400.282013F, -125.885002F));
                    builder.AddCubicBezier(new Vector2(399.621002F, -127.453003F), new Vector2(400.358002F, -129.259003F), new Vector2(401.924011F, -129.919998F));
                    builder.AddCubicBezier(new Vector2(403.494995F, -130.580994F), new Vector2(405.299011F, -129.845001F), new Vector2(405.960999F, -128.279007F));
                    builder.AddCubicBezier(new Vector2(406.113007F, -127.918999F), new Vector2(421.572998F, -92.0459976F), new Vector2(457.057007F, -69.5960007F));
                    builder.AddCubicBezier(new Vector2(458.494995F, -68.685997F), new Vector2(458.923004F, -66.7839966F), new Vector2(458.014008F, -65.3450012F));
                    builder.AddCubicBezier(new Vector2(457.427002F, -64.4179993F), new Vector2(456.428009F, -63.9099998F), new Vector2(455.406006F, -63.9099998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_046()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(458.488007F, -68.5319977F));
                    builder.AddCubicBezier(new Vector2(457.924011F, -68.5319977F), new Vector2(457.354004F, -68.685997F), new Vector2(456.842987F, -69.0100021F));
                    builder.AddCubicBezier(new Vector2(437.408997F, -81.3050003F), new Vector2(423.920013F, -97.336998F), new Vector2(416.027008F, -108.620003F));
                    builder.AddCubicBezier(new Vector2(407.463989F, -120.861F), new Vector2(403.526001F, -130.119995F), new Vector2(403.363007F, -130.507996F));
                    builder.AddCubicBezier(new Vector2(402.701996F, -132.076996F), new Vector2(403.440002F, -133.884003F), new Vector2(405.007996F, -134.544006F));
                    builder.AddCubicBezier(new Vector2(406.575989F, -135.203995F), new Vector2(408.381989F, -134.468994F), new Vector2(409.042999F, -132.901993F));
                    builder.AddCubicBezier(new Vector2(409.080994F, -132.811996F), new Vector2(412.951996F, -123.740997F), new Vector2(421.178986F, -112.009003F));
                    builder.AddCubicBezier(new Vector2(428.735992F, -101.233002F), new Vector2(441.627991F, -85.9290009F), new Vector2(460.138F, -74.2190018F));
                    builder.AddCubicBezier(new Vector2(461.575989F, -73.3089981F), new Vector2(462.005005F, -71.4049988F), new Vector2(461.095001F, -69.9670029F));
                    builder.AddCubicBezier(new Vector2(460.509003F, -69.0400009F), new Vector2(459.509003F, -68.5319977F), new Vector2(458.488007F, -68.5319977F));
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
                    builder.BeginFigure(new Vector2(350.346985F, -20.7770004F));
                    builder.AddCubicBezier(new Vector2(340.895996F, -32.0299988F), new Vector2(327.627014F, -38.9290009F), new Vector2(312.988007F, -40.2019997F));
                    builder.AddCubicBezier(new Vector2(298.346985F, -41.4729996F), new Vector2(284.088013F, -36.9700012F), new Vector2(272.835999F, -27.5179996F));
                    builder.AddCubicBezier(new Vector2(261.584015F, -18.0669994F), new Vector2(254.684998F, -4.79899979F), new Vector2(253.412003F, 9.8409996F));
                    builder.AddCubicBezier(new Vector2(252.139008F, 24.4810009F), new Vector2(256.641998F, 38.7410011F), new Vector2(266.095001F, 49.993F));
                    builder.AddCubicBezier(new Vector2(275.54599F, 61.2449989F), new Vector2(288.815002F, 68.1439972F), new Vector2(303.45401F, 69.4169998F));
                    builder.AddCubicBezier(new Vector2(305.080994F, 69.5579987F), new Vector2(306.700989F, 69.6279984F), new Vector2(308.313995F, 69.6279984F));
                    builder.AddCubicBezier(new Vector2(321.223999F, 69.6279984F), new Vector2(333.604004F, 65.1360016F), new Vector2(343.605988F, 56.7340012F));
                    builder.AddCubicBezier(new Vector2(354.858002F, 47.2830009F), new Vector2(361.756989F, 34.0139999F), new Vector2(363.029999F, 19.3740005F));
                    builder.AddCubicBezier(new Vector2(364.303009F, 4.73400021F), new Vector2(359.799988F, -9.52499962F), new Vector2(350.346985F, -20.7770004F));
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
                    builder.BeginFigure(new Vector2(340.083008F, 46.6710014F));
                    builder.AddCubicBezier(new Vector2(318.119995F, 65.1190033F), new Vector2(285.360992F, 62.2700005F), new Vector2(266.912994F, 40.3069992F));
                    builder.AddCubicBezier(new Vector2(248.464996F, 18.3439999F), new Vector2(251.313995F, -14.415F), new Vector2(273.277008F, -32.862999F));
                    builder.AddCubicBezier(new Vector2(295.23999F, -51.3110008F), new Vector2(327.998993F, -48.4630013F), new Vector2(346.446991F, -26.5F));
                    builder.AddCubicBezier(new Vector2(364.894989F, -4.53700018F), new Vector2(362.04599F, 28.2229996F), new Vector2(340.083008F, 46.6710014F));
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
                    builder.BeginFigure(new Vector2(306.707001F, 62.6910019F));
                    builder.AddCubicBezier(new Vector2(290.170013F, 62.6910019F), new Vector2(274.591003F, 55.4350014F), new Vector2(263.963989F, 42.7840004F));
                    builder.AddCubicBezier(new Vector2(254.380005F, 31.3740005F), new Vector2(249.811996F, 16.9150009F), new Vector2(251.102997F, 2.06999993F));
                    builder.AddCubicBezier(new Vector2(252.393997F, -12.7749996F), new Vector2(259.389008F, -26.2290001F), new Vector2(270.799011F, -35.8129997F));
                    builder.AddCubicBezier(new Vector2(280.834015F, -44.2420006F), new Vector2(293.566986F, -48.8839989F), new Vector2(306.653015F, -48.8839989F));
                    builder.AddCubicBezier(new Vector2(323.19101F, -48.8839989F), new Vector2(338.769989F, -41.6279984F), new Vector2(349.397003F, -28.9769993F));
                    builder.AddCubicBezier(new Vector2(358.980988F, -17.5669994F), new Vector2(363.548004F, -3.10800004F), new Vector2(362.256989F, 11.7370005F));
                    builder.AddCubicBezier(new Vector2(360.966003F, 26.5820007F), new Vector2(353.971008F, 40.0359993F), new Vector2(342.561005F, 49.6199989F));
                    builder.AddCubicBezier(new Vector2(332.526001F, 58.0489998F), new Vector2(319.792999F, 62.6910019F), new Vector2(306.707001F, 62.6910019F));
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
                    builder.BeginFigure(new Vector2(306.653015F, -41.1800003F));
                    builder.AddCubicBezier(new Vector2(295.377014F, -41.1800003F), new Vector2(284.403015F, -37.1790009F), new Vector2(275.753998F, -29.9139996F));
                    builder.AddCubicBezier(new Vector2(265.920013F, -21.6529999F), new Vector2(259.891998F, -10.0570002F), new Vector2(258.778992F, 2.73799992F));
                    builder.AddCubicBezier(new Vector2(257.665985F, 15.533F), new Vector2(261.60199F, 27.9950008F), new Vector2(269.863007F, 37.8289986F));
                    builder.AddCubicBezier(new Vector2(279.022003F, 48.7330017F), new Vector2(292.450989F, 54.9869995F), new Vector2(306.707001F, 54.9869995F));
                    builder.AddCubicBezier(new Vector2(317.983002F, 54.9869995F), new Vector2(328.957001F, 50.9860001F), new Vector2(337.605988F, 43.7210007F));
                    builder.AddCubicBezier(new Vector2(347.440002F, 35.4599991F), new Vector2(353.468994F, 23.8649998F), new Vector2(354.582001F, 11.0699997F));
                    builder.AddCubicBezier(new Vector2(355.695007F, -1.72500002F), new Vector2(351.759003F, -14.1879997F), new Vector2(343.497986F, -24.0219994F));
                    builder.AddCubicBezier(new Vector2(334.338989F, -34.9259987F), new Vector2(320.908997F, -41.1800003F), new Vector2(306.653015F, -41.1800003F));
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
                    builder.BeginFigure(new Vector2(343.497986F, -24.0219994F));
                    builder.AddCubicBezier(new Vector2(335.237F, -33.855999F), new Vector2(323.641998F, -39.8849983F), new Vector2(310.846985F, -40.9980011F));
                    builder.AddCubicBezier(new Vector2(309.427002F, -41.1209984F), new Vector2(308.006989F, -41.1829987F), new Vector2(306.596985F, -41.1829987F));
                    builder.AddCubicBezier(new Vector2(295.315002F, -41.1829987F), new Vector2(284.497009F, -37.257F), new Vector2(275.755005F, -29.9139996F));
                    builder.AddCubicBezier(new Vector2(265.920013F, -21.6529999F), new Vector2(259.890991F, -10.0570002F), new Vector2(258.778992F, 2.73799992F));
                    builder.AddCubicBezier(new Vector2(258.350006F, 7.66800022F), new Vector2(258.678009F, 12.5459995F), new Vector2(259.707001F, 17.2460003F));
                    builder.AddCubicBezier(new Vector2(259.325012F, 13.9770002F), new Vector2(259.259003F, 10.6479998F), new Vector2(259.550995F, 7.29300022F));
                    builder.AddCubicBezier(new Vector2(260.683014F, -5.70699978F), new Vector2(266.80899F, -17.4880009F), new Vector2(276.799988F, -25.8810005F));
                    builder.AddCubicBezier(new Vector2(285.682007F, -33.3419991F), new Vector2(296.674011F, -37.3310013F), new Vector2(308.138F, -37.3310013F));
                    builder.AddCubicBezier(new Vector2(309.569F, -37.3310013F), new Vector2(311.010986F, -37.269001F), new Vector2(312.45401F, -37.1430016F));
                    builder.AddCubicBezier(new Vector2(325.453003F, -36.012001F), new Vector2(337.234985F, -29.8859997F), new Vector2(345.627991F, -19.8950005F));
                    builder.AddCubicBezier(new Vector2(347.441986F, -17.7360001F), new Vector2(349.036011F, -15.4460001F), new Vector2(350.428986F, -13.0600004F));
                    builder.AddCubicBezier(new Vector2(348.641998F, -16.9599991F), new Vector2(346.330994F, -20.6480007F), new Vector2(343.497986F, -24.0219994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_053()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(330.306F, 35.0309982F));
                    builder.AddCubicBezier(new Vector2(314.772003F, 48.0789986F), new Vector2(291.601013F, 46.0639992F), new Vector2(278.553009F, 30.5300007F));
                    builder.AddCubicBezier(new Vector2(265.505005F, 14.9960003F), new Vector2(267.519989F, -8.17599964F), new Vector2(283.053986F, -21.2240009F));
                    builder.AddCubicBezier(new Vector2(298.588013F, -34.2719994F), new Vector2(321.759003F, -32.257F), new Vector2(334.807007F, -16.7229996F));
                    builder.AddCubicBezier(new Vector2(347.855011F, -1.18900001F), new Vector2(345.839996F, 21.9829998F), new Vector2(330.306F, 35.0309982F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_054()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_055(), Geometry_056() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_055()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(306.699005F, 46.7190018F));
                    builder.AddCubicBezier(new Vector2(294.895996F, 46.7190018F), new Vector2(283.777008F, 41.5410004F), new Vector2(276.192993F, 32.512001F));
                    builder.AddCubicBezier(new Vector2(269.352997F, 24.3689995F), new Vector2(266.093994F, 14.0489998F), new Vector2(267.015015F, 3.454F));
                    builder.AddCubicBezier(new Vector2(267.936005F, -7.14099979F), new Vector2(272.928986F, -16.743F), new Vector2(281.071991F, -23.5830002F));
                    builder.AddCubicBezier(new Vector2(288.234009F, -29.5990009F), new Vector2(297.321991F, -32.9119987F), new Vector2(306.661011F, -32.9119987F));
                    builder.AddCubicBezier(new Vector2(318.463989F, -32.9119987F), new Vector2(329.583008F, -27.7339993F), new Vector2(337.166992F, -18.7049999F));
                    builder.AddCubicBezier(new Vector2(351.286987F, -1.89400005F), new Vector2(349.098999F, 23.2700005F), new Vector2(332.289001F, 37.3909988F));
                    builder.AddCubicBezier(new Vector2(325.127014F, 43.4070015F), new Vector2(316.037994F, 46.7190018F), new Vector2(306.699005F, 46.7190018F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_056()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(306.661011F, -26.7490005F));
                    builder.AddCubicBezier(new Vector2(298.769012F, -26.7490005F), new Vector2(291.088989F, -23.9489994F), new Vector2(285.036011F, -18.8640003F));
                    builder.AddCubicBezier(new Vector2(278.153015F, -13.0830002F), new Vector2(273.93399F, -4.96700001F), new Vector2(273.154999F, 3.98799992F));
                    builder.AddCubicBezier(new Vector2(272.376007F, 12.9429998F), new Vector2(275.131012F, 21.6639996F), new Vector2(280.911987F, 28.5470009F));
                    builder.AddCubicBezier(new Vector2(287.321991F, 36.1790009F), new Vector2(296.721008F, 40.5559998F), new Vector2(306.699005F, 40.5559998F));
                    builder.AddCubicBezier(new Vector2(314.591003F, 40.5559998F), new Vector2(322.272003F, 37.7560005F), new Vector2(328.325012F, 32.6710014F));
                    builder.AddCubicBezier(new Vector2(342.53299F, 20.7360001F), new Vector2(344.382996F, -0.532999992F), new Vector2(332.447998F, -14.7410002F));
                    builder.AddCubicBezier(new Vector2(326.037994F, -22.3719997F), new Vector2(316.639008F, -26.7490005F), new Vector2(306.661011F, -26.7490005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_057()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(286.13501F, -10.4379997F));
                    builder.AddCubicBezier(new Vector2(301.669006F, -23.4860001F), new Vector2(324.841003F, -21.4710007F), new Vector2(337.889008F, -5.9369998F));
                    builder.AddCubicBezier(new Vector2(340.042999F, -3.37199998F), new Vector2(341.778015F, -0.596000016F), new Vector2(343.118011F, 2.30500007F));
                    builder.AddCubicBezier(new Vector2(342.269012F, -4.47599983F), new Vector2(339.529999F, -11.1000004F), new Vector2(334.807007F, -16.7229996F));
                    builder.AddCubicBezier(new Vector2(321.759003F, -32.257F), new Vector2(298.588013F, -34.2719994F), new Vector2(283.053986F, -21.2240009F));
                    builder.AddCubicBezier(new Vector2(270.084991F, -10.3299999F), new Vector2(266.546997F, 7.6170001F), new Vector2(273.322998F, 22.2880001F));
                    builder.AddCubicBezier(new Vector2(271.825989F, 10.3339996F), new Vector2(276.222992F, -2.11199999F), new Vector2(286.13501F, -10.4379997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_058()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(196.914993F, 118.621002F));
                    builder.AddCubicBezier(new Vector2(207.436996F, 104.521004F), new Vector2(192.018005F, 86.1640015F), new Vector2(176.313004F, 94.0940018F));
                    builder.AddCubicBezier(new Vector2(173.584F, 95.4720001F), new Vector2(171.292999F, 96.9489975F), new Vector2(169.720993F, 98.5100021F));
                    builder.AddLine(new Vector2(53.493F, 212.608002F));
                    builder.AddCubicBezier(new Vector2(49.6110001F, 216.419006F), new Vector2(54.7299995F, 222.503006F), new Vector2(59.1489983F, 219.330002F));
                    builder.AddLine(new Vector2(191.427002F, 124.350998F));
                    builder.AddCubicBezier(new Vector2(193.235992F, 123.072998F), new Vector2(195.087006F, 121.070999F), new Vector2(196.914993F, 118.621002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_059()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_060(), Geometry_061() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_060()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(56.5550003F, 224.837997F));
                    builder.AddCubicBezier(new Vector2(52.9459991F, 224.837997F), new Vector2(49.5750008F, 222.522995F), new Vector2(48.1660004F, 219.078003F));
                    builder.AddCubicBezier(new Vector2(46.7770004F, 215.681F), new Vector2(47.5779991F, 211.938004F), new Vector2(50.2550011F, 209.309998F));
                    builder.AddLine(new Vector2(166.483002F, 95.211998F));
                    builder.AddCubicBezier(new Vector2(168.311996F, 93.3960037F), new Vector2(170.850998F, 91.6740036F), new Vector2(174.229004F, 89.9680023F));
                    builder.AddCubicBezier(new Vector2(177.399002F, 88.3669968F), new Vector2(180.699997F, 87.5559998F), new Vector2(184.039993F, 87.5559998F));
                    builder.AddCubicBezier(new Vector2(191.824005F, 87.5559998F), new Vector2(199.175003F, 92.1839981F), new Vector2(202.766998F, 99.3460007F));
                    builder.AddCubicBezier(new Vector2(206.365005F, 106.521004F), new Vector2(205.563004F, 114.760002F), new Vector2(200.619003F, 121.385002F));
                    builder.AddCubicBezier(new Vector2(198.360992F, 124.411003F), new Vector2(196.231995F, 126.612999F), new Vector2(194.108994F, 128.115997F));
                    builder.AddLine(new Vector2(61.8450012F, 223.085007F));
                    builder.AddCubicBezier(new Vector2(60.2480011F, 224.231995F), new Vector2(58.4179993F, 224.837997F), new Vector2(56.5550003F, 224.837997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_061()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(184.039993F, 96.8010025F));
                    builder.AddCubicBezier(new Vector2(182.160995F, 96.8010025F), new Vector2(180.263F, 97.2789993F), new Vector2(178.397003F, 98.2210007F));
                    builder.AddCubicBezier(new Vector2(175.328995F, 99.7699966F), new Vector2(173.755997F, 101.016998F), new Vector2(172.977997F, 101.790001F));
                    builder.AddLine(new Vector2(58.7459984F, 213.929001F));
                    builder.AddLine(new Vector2(188.731003F, 120.596001F));
                    builder.AddCubicBezier(new Vector2(188.740005F, 120.588997F), new Vector2(188.748993F, 120.583F), new Vector2(188.759003F, 120.575996F));
                    builder.AddCubicBezier(new Vector2(189.654999F, 119.943001F), new Vector2(191.154999F, 118.610001F), new Vector2(193.210007F, 115.856003F));
                    builder.AddCubicBezier(new Vector2(196.059006F, 112.038002F), new Vector2(196.531006F, 107.530998F), new Vector2(194.503998F, 103.489998F));
                    builder.AddCubicBezier(new Vector2(192.466003F, 99.427002F), new Vector2(188.358002F, 96.8010025F), new Vector2(184.039993F, 96.8010025F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_062()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(193.056F, 95.0289993F));
                    builder.AddCubicBezier(new Vector2(194.983002F, 99.8720016F), new Vector2(194.654007F, 105.684998F), new Vector2(190.751007F, 110.916F));
                    builder.AddCubicBezier(new Vector2(188.923004F, 113.365997F), new Vector2(187.072998F, 115.369003F), new Vector2(185.264008F, 116.647003F));
                    builder.AddLine(new Vector2(58.6010017F, 207.593994F));
                    builder.AddLine(new Vector2(53.493F, 212.608002F));
                    builder.AddCubicBezier(new Vector2(49.6110001F, 216.419006F), new Vector2(54.7299995F, 222.503006F), new Vector2(59.1489983F, 219.330002F));
                    builder.AddLine(new Vector2(191.427002F, 124.350998F));
                    builder.AddCubicBezier(new Vector2(193.235992F, 123.072998F), new Vector2(195.087006F, 121.070999F), new Vector2(196.914993F, 118.621002F));
                    builder.AddCubicBezier(new Vector2(203.324997F, 110.030998F), new Vector2(200.100006F, 99.8730011F), new Vector2(193.056F, 95.0289993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_063()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(192.910004F, 101.070999F));
                    builder.AddCubicBezier(new Vector2(191.007996F, 98.8059998F), new Vector2(187.837006F, 96.8119965F), new Vector2(184.003006F, 96.8119965F));
                    builder.AddCubicBezier(new Vector2(182.253006F, 96.8119965F), new Vector2(180.365997F, 97.2279968F), new Vector2(178.397995F, 98.2210007F));
                    builder.AddCubicBezier(new Vector2(175.330994F, 99.7679977F), new Vector2(173.757996F, 101.014999F), new Vector2(172.979004F, 101.790001F));
                    builder.AddLine(new Vector2(58.7669983F, 213.906998F));
                    builder.AddLine(new Vector2(83.6740036F, 196.024994F));
                    builder.AddLine(new Vector2(175.516998F, 105.864998F));
                    builder.AddCubicBezier(new Vector2(176.709F, 104.681999F), new Vector2(178.598007F, 103.433998F), new Vector2(181.132004F, 102.154999F));
                    builder.AddCubicBezier(new Vector2(183.223999F, 101.098999F), new Vector2(185.231003F, 100.657997F), new Vector2(187.091995F, 100.657997F));
                    builder.AddCubicBezier(new Vector2(189.886993F, 100.657997F), new Vector2(192.337006F, 101.663002F), new Vector2(194.263F, 103.065002F));
                    builder.AddCubicBezier(new Vector2(193.863007F, 102.330002F), new Vector2(193.404007F, 101.658997F), new Vector2(192.910004F, 101.070999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_064()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(428.545013F, -95.4940033F));
                    builder.AddLine(new Vector2(348.421997F, -27.698F));
                    builder.AddLine(new Vector2(428.545013F, -95.4940033F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_065()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(348.424011F, -25.3869991F));
                    builder.AddCubicBezier(new Vector2(347.768005F, -25.3869991F), new Vector2(347.11499F, -25.6650009F), new Vector2(346.65799F, -26.2049999F));
                    builder.AddCubicBezier(new Vector2(345.833008F, -27.1790009F), new Vector2(345.954987F, -28.6380005F), new Vector2(346.929993F, -29.4629993F));
                    builder.AddLine(new Vector2(427.052002F, -97.2590027F));
                    builder.AddCubicBezier(new Vector2(428.026001F, -98.0830002F), new Vector2(429.484985F, -97.961998F), new Vector2(430.309998F, -96.9869995F));
                    builder.AddCubicBezier(new Vector2(431.13501F, -96.0130005F), new Vector2(431.013F, -94.5550003F), new Vector2(430.037994F, -93.7300034F));
                    builder.AddLine(new Vector2(349.915009F, -25.934F));
                    builder.AddCubicBezier(new Vector2(349.480988F, -25.5669994F), new Vector2(348.950989F, -25.3869991F), new Vector2(348.424011F, -25.3869991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_066()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(265.480988F, 38.6539993F));
                    builder.AddCubicBezier(new Vector2(264.683014F, 37.6580009F), new Vector2(263.227997F, 37.4959984F), new Vector2(262.233002F, 38.2939987F));
                    builder.AddLine(new Vector2(192.298004F, 94.3010025F));
                    builder.AddCubicBezier(new Vector2(191.302002F, 95.098999F), new Vector2(191.139999F, 96.5540009F), new Vector2(191.938004F, 97.5500031F));
                    builder.AddCubicBezier(new Vector2(192.393997F, 98.1200027F), new Vector2(193.067001F, 98.4160004F), new Vector2(193.744003F, 98.4160004F));
                    builder.AddCubicBezier(new Vector2(194.251007F, 98.4160004F), new Vector2(194.761002F, 98.2509995F), new Vector2(195.186996F, 97.9089966F));
                    builder.AddLine(new Vector2(265.122009F, 41.9020004F));
                    builder.AddCubicBezier(new Vector2(266.118011F, 41.1040001F), new Vector2(266.278992F, 39.6500015F), new Vector2(265.480988F, 38.6539993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_067()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(266.759003F, 43.1800003F));
                    builder.AddLine(new Vector2(196.824997F, 99.1869965F));
                    builder.AddLine(new Vector2(266.759003F, 43.1800003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_068()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(196.826004F, 101.498001F));
                    builder.AddCubicBezier(new Vector2(196.147995F, 101.498001F), new Vector2(195.477997F, 101.202003F), new Vector2(195.020996F, 100.632004F));
                    builder.AddCubicBezier(new Vector2(194.223007F, 99.6360016F), new Vector2(194.384003F, 98.1809998F), new Vector2(195.380005F, 97.3830032F));
                    builder.AddLine(new Vector2(265.313995F, 41.3759995F));
                    builder.AddCubicBezier(new Vector2(266.309998F, 40.5769997F), new Vector2(267.765015F, 40.7389984F), new Vector2(268.562988F, 41.7350006F));
                    builder.AddCubicBezier(new Vector2(269.360992F, 42.730999F), new Vector2(269.199005F, 44.1860008F), new Vector2(268.203003F, 44.9840012F));
                    builder.AddLine(new Vector2(198.268997F, 100.990997F));
                    builder.AddCubicBezier(new Vector2(197.843002F, 101.333F), new Vector2(197.332001F, 101.498001F), new Vector2(196.826004F, 101.498001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_069()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(249.809998F, -69.3000031F));
                    builder.AddLine(new Vector2(276.860992F, -35.3419991F));
                    builder.AddLine(new Vector2(249.809998F, -69.3000031F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_070()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(276.863007F, -33.0309982F));
                    builder.AddCubicBezier(new Vector2(276.183014F, -33.0309982F), new Vector2(275.51001F, -33.3289986F), new Vector2(275.053986F, -33.9020004F));
                    builder.AddLine(new Vector2(248.001999F, -67.8600006F));
                    builder.AddCubicBezier(new Vector2(247.207001F, -68.8580017F), new Vector2(247.371002F, -70.3130035F), new Vector2(248.369003F, -71.1080017F));
                    builder.AddCubicBezier(new Vector2(249.367996F, -71.9029999F), new Vector2(250.822006F, -71.7389984F), new Vector2(251.617004F, -70.7409973F));
                    builder.AddLine(new Vector2(278.669006F, -36.7820015F));
                    builder.AddCubicBezier(new Vector2(279.463989F, -35.7840004F), new Vector2(279.299011F, -34.3289986F), new Vector2(278.300995F, -33.5340004F));
                    builder.AddCubicBezier(new Vector2(277.875F, -33.1949997F), new Vector2(277.368011F, -33.0309982F), new Vector2(276.863007F, -33.0309982F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_071()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(250.076004F, -67.6589966F));
                    builder.AddCubicBezier(new Vector2(249.281998F, -68.6569977F), new Vector2(247.830994F, -68.8219986F), new Vector2(246.828995F, -68.0270004F));
                    builder.AddCubicBezier(new Vector2(245.830002F, -67.2320023F), new Vector2(245.666F, -65.7770004F), new Vector2(246.462006F, -64.7789993F));
                    builder.AddLine(new Vector2(273.513F, -30.8199997F));
                    builder.AddCubicBezier(new Vector2(273.968994F, -30.2469997F), new Vector2(274.641998F, -29.9489994F), new Vector2(275.321991F, -29.9489994F));
                    builder.AddCubicBezier(new Vector2(275.825989F, -29.9489994F), new Vector2(276.334991F, -30.1140003F), new Vector2(276.760986F, -30.4529991F));
                    builder.AddCubicBezier(new Vector2(277.76001F, -31.2479992F), new Vector2(277.924011F, -32.7019997F), new Vector2(277.127991F, -33.7000008F));
                    builder.AddLine(new Vector2(250.076004F, -67.6589966F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_072()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(364.093994F, 81.7969971F));
                    builder.AddLine(new Vector2(339.44101F, 50.9799995F));
                    builder.AddCubicBezier(new Vector2(338.647003F, 49.9850006F), new Vector2(337.194F, 49.8219986F), new Vector2(336.191986F, 50.6209984F));
                    builder.AddCubicBezier(new Vector2(335.196014F, 51.4189987F), new Vector2(335.035004F, 52.8709984F), new Vector2(335.833008F, 53.8689995F));
                    builder.AddLine(new Vector2(360.485992F, 84.685997F));
                    builder.AddCubicBezier(new Vector2(360.941986F, 85.2559967F), new Vector2(361.612F, 85.552002F), new Vector2(362.290985F, 85.552002F));
                    builder.AddCubicBezier(new Vector2(362.796997F, 85.552002F), new Vector2(363.307007F, 85.387001F), new Vector2(363.734009F, 85.0449982F));
                    builder.AddCubicBezier(new Vector2(364.730011F, 84.2470016F), new Vector2(364.890991F, 82.7949982F), new Vector2(364.093994F, 81.7969971F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_073()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(339.178009F, 49.3429985F));
                    builder.AddLine(new Vector2(363.830994F, 80.1600037F));
                    builder.AddLine(new Vector2(339.178009F, 49.3429985F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_074()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(363.832001F, 82.4710007F));
                    builder.AddCubicBezier(new Vector2(363.153992F, 82.4710007F), new Vector2(362.483002F, 82.1740036F), new Vector2(362.026001F, 81.6039963F));
                    builder.AddLine(new Vector2(337.372986F, 50.7869987F));
                    builder.AddCubicBezier(new Vector2(336.575989F, 49.7900009F), new Vector2(336.737F, 48.3359985F), new Vector2(337.734009F, 47.5379982F));
                    builder.AddCubicBezier(new Vector2(338.730988F, 46.7410011F), new Vector2(340.184998F, 46.9029999F), new Vector2(340.981995F, 47.8989983F));
                    builder.AddLine(new Vector2(365.635986F, 78.7160034F));
                    builder.AddCubicBezier(new Vector2(366.433014F, 79.7129974F), new Vector2(366.272003F, 81.1669998F), new Vector2(365.274994F, 81.9649963F));
                    builder.AddCubicBezier(new Vector2(364.848999F, 82.3059998F), new Vector2(364.338013F, 82.4710007F), new Vector2(363.832001F, 82.4710007F));
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
                    builder.BeginFigure(new Vector2(412.10199F, -93.2220001F));
                    builder.AddCubicBezier(new Vector2(410.338013F, -91.4729996F), new Vector2(407.48999F, -91.4860001F), new Vector2(405.740997F, -93.25F));
                    builder.AddCubicBezier(new Vector2(403.992004F, -95.0139999F), new Vector2(404.005005F, -97.8619995F), new Vector2(405.769012F, -99.6110001F));
                    builder.AddCubicBezier(new Vector2(407.53299F, -101.360001F), new Vector2(410.381012F, -101.347F), new Vector2(412.130005F, -99.5830002F));
                    builder.AddCubicBezier(new Vector2(413.878998F, -97.8190002F), new Vector2(413.865997F, -94.9710007F), new Vector2(412.10199F, -93.2220001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_076()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(430.59201F, -73.1910019F));
                    builder.AddCubicBezier(new Vector2(428.828003F, -71.4420013F), new Vector2(425.980011F, -71.4550018F), new Vector2(424.230988F, -73.2190018F));
                    builder.AddCubicBezier(new Vector2(422.481995F, -74.9830017F), new Vector2(422.494995F, -77.8310013F), new Vector2(424.259003F, -79.5800018F));
                    builder.AddCubicBezier(new Vector2(426.02301F, -81.3290024F), new Vector2(428.871002F, -81.3160019F), new Vector2(430.619995F, -79.552002F));
                    builder.AddCubicBezier(new Vector2(432.368988F, -77.788002F), new Vector2(432.355988F, -74.9400024F), new Vector2(430.59201F, -73.1910019F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_077()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(273.192993F, -54.5600014F));
                    builder.AddCubicBezier(new Vector2(271.688995F, -56.5369987F), new Vector2(272.071991F, -59.3590012F), new Vector2(274.049011F, -60.862999F));
                    builder.AddCubicBezier(new Vector2(276.026001F, -62.3670006F), new Vector2(278.847992F, -61.9840012F), new Vector2(280.35199F, -60.007F));
                    builder.AddCubicBezier(new Vector2(281.855988F, -58.0299988F), new Vector2(281.473999F, -55.2080002F), new Vector2(279.497009F, -53.7039986F));
                    builder.AddCubicBezier(new Vector2(277.519989F, -52.2000008F), new Vector2(274.696991F, -52.5830002F), new Vector2(273.192993F, -54.5600014F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_078()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(250.925995F, -38.8349991F));
                    builder.AddCubicBezier(new Vector2(249.421997F, -40.8120003F), new Vector2(249.804001F, -43.6349983F), new Vector2(251.781006F, -45.1389999F));
                    builder.AddCubicBezier(new Vector2(253.757996F, -46.6430016F), new Vector2(256.580994F, -46.2599983F), new Vector2(258.084991F, -44.2830009F));
                    builder.AddCubicBezier(new Vector2(259.588989F, -42.3059998F), new Vector2(259.205994F, -39.4830017F), new Vector2(257.229004F, -37.9790001F));
                    builder.AddCubicBezier(new Vector2(255.251999F, -36.4749985F), new Vector2(252.429993F, -36.8580017F), new Vector2(250.925995F, -38.8349991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_079()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(354.333008F, 54.1430016F));
                    builder.AddCubicBezier(new Vector2(352.647003F, 52.3180008F), new Vector2(352.76001F, 49.4729996F), new Vector2(354.584991F, 47.7869987F));
                    builder.AddCubicBezier(new Vector2(356.410004F, 46.1010017F), new Vector2(359.255005F, 46.2130013F), new Vector2(360.94101F, 48.0379982F));
                    builder.AddCubicBezier(new Vector2(362.627014F, 49.862999F), new Vector2(362.514008F, 52.7080002F), new Vector2(360.688995F, 54.394001F));
                    builder.AddCubicBezier(new Vector2(358.864014F, 56.0800018F), new Vector2(356.019012F, 55.9679985F), new Vector2(354.333008F, 54.1430016F));
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
                    builder.BeginFigure(new Vector2(333.664001F, 71.9169998F));
                    builder.AddCubicBezier(new Vector2(331.977997F, 70.0920029F), new Vector2(332.091003F, 67.2460022F), new Vector2(333.915985F, 65.5599976F));
                    builder.AddCubicBezier(new Vector2(335.740997F, 63.8740005F), new Vector2(338.585999F, 63.9869995F), new Vector2(340.272003F, 65.8119965F));
                    builder.AddCubicBezier(new Vector2(341.958008F, 67.637001F), new Vector2(341.846008F, 70.4820023F), new Vector2(340.020996F, 72.1679993F));
                    builder.AddCubicBezier(new Vector2(338.196014F, 73.8539963F), new Vector2(335.350006F, 73.7419968F), new Vector2(333.664001F, 71.9169998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_081()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(205.632004F, 80.8909988F));
                    builder.AddCubicBezier(new Vector2(203.867996F, 82.6399994F), new Vector2(201.020004F, 82.6279984F), new Vector2(199.270996F, 80.8639984F));
                    builder.AddCubicBezier(new Vector2(197.522003F, 79.0999985F), new Vector2(197.535004F, 76.2509995F), new Vector2(199.298996F, 74.5019989F));
                    builder.AddCubicBezier(new Vector2(201.063004F, 72.7529984F), new Vector2(203.910995F, 72.7659988F), new Vector2(205.660004F, 74.5299988F));
                    builder.AddCubicBezier(new Vector2(207.408997F, 76.2939987F), new Vector2(207.395996F, 79.1419983F), new Vector2(205.632004F, 80.8909988F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_082()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(224.121994F, 100.921997F));
                    builder.AddCubicBezier(new Vector2(222.358002F, 102.670998F), new Vector2(219.509995F, 102.657997F), new Vector2(217.761002F, 100.893997F));
                    builder.AddCubicBezier(new Vector2(216.011993F, 99.1299973F), new Vector2(216.024002F, 96.2819977F), new Vector2(217.787994F, 94.5329971F));
                    builder.AddCubicBezier(new Vector2(219.552002F, 92.7839966F), new Vector2(222.399994F, 92.7969971F), new Vector2(224.149002F, 94.560997F));
                    builder.AddCubicBezier(new Vector2(225.897995F, 96.3249969F), new Vector2(225.886002F, 99.1729965F), new Vector2(224.121994F, 100.921997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_083()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(369.665009F, -7.31799984F));
                    builder.AddLine(new Vector2(245.843994F, 17.823F));
                    builder.AddLine(new Vector2(242.164993F, -0.296999991F));
                    builder.AddLine(new Vector2(365.985992F, -25.4379997F));
                    builder.AddLine(new Vector2(369.665009F, -7.31799984F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_084()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(372.813995F, 16.25F));
                    builder.AddLine(new Vector2(248.992996F, 41.3909988F));
                    builder.AddLine(new Vector2(247.093994F, 32.0369987F));
                    builder.AddLine(new Vector2(370.915009F, 6.89599991F));
                    builder.AddLine(new Vector2(372.813995F, 16.25F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_085()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(427.286987F, -99.9990005F));
                    builder.AddCubicBezier(new Vector2(426.463989F, -100.974998F), new Vector2(425.005005F, -101.098F), new Vector2(424.029999F, -100.276001F));
                    builder.AddLine(new Vector2(343.795013F, -32.612999F));
                    builder.AddCubicBezier(new Vector2(342.819F, -31.7900009F), new Vector2(342.694F, -30.3330002F), new Vector2(343.516998F, -29.3570004F));
                    builder.AddCubicBezier(new Vector2(343.973999F, -28.8150005F), new Vector2(344.626007F, -28.5359993F), new Vector2(345.282013F, -28.5349998F));
                    builder.AddCubicBezier(new Vector2(345.80899F, -28.5340004F), new Vector2(346.339996F, -28.7140007F), new Vector2(346.773987F, -29.0799999F));
                    builder.AddLine(new Vector2(427.01001F, -96.7429962F));
                    builder.AddCubicBezier(new Vector2(427.985992F, -97.5660019F), new Vector2(428.109985F, -99.0230026F), new Vector2(427.286987F, -99.9990005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_086()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(145.804001F, 39.3279991F));
                    builder.AddCubicBezier(new Vector2(145.804001F, 39.3279991F), new Vector2(119.610001F, 79.3889999F), new Vector2(11.7519999F, 127.154999F));
                    builder.AddLine(new Vector2(14.8339996F, 130.235992F));
                    builder.AddLine(new Vector2(91.8740005F, 103.600998F));
                    builder.AddLine(new Vector2(113.446999F, 100.960999F));
                    builder.AddLine(new Vector2(148.886002F, 43.9500008F));
                    builder.AddLine(new Vector2(145.804001F, 39.3279991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_087()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(238.253006F, 159.511993F));
                    builder.AddCubicBezier(new Vector2(238.253006F, 159.511993F), new Vector2(184.324005F, 199.574005F), new Vector2(135.018005F, 270.451996F));
                    builder.AddLine(new Vector2(137.328995F, 261.97699F));
                    builder.AddLine(new Vector2(172.768005F, 197.261993F));
                    builder.AddLine(new Vector2(178.932007F, 178.772003F));
                    builder.AddLine(new Vector2(238.253006F, 159.511993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_088()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(182F, 0F));
                    builder.AddCubicBezier(new Vector2(182F, 0F), new Vector2(134.061005F, -68.9700012F), new Vector2(78F, -72F));
                    builder.AddCubicBezier(new Vector2(41F, -74F), new Vector2(17F, -57F), new Vector2(-35.5F, -40F));
                    builder.AddCubicBezier(new Vector2(-84.8610001F, -24.0160007F), new Vector2(-172F, -68F), new Vector2(-172F, -68F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - Path
            CanvasGeometry Geometry_089()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(182F, 0F));
                    builder.AddCubicBezier(new Vector2(182F, 0F), new Vector2(128.259995F, -41.0820007F), new Vector2(73F, -51F));
                    builder.AddCubicBezier(new Vector2(34F, -58F), new Vector2(3.6500001F, -51.5449982F), new Vector2(-68.5F, -47F));
                    builder.AddCubicBezier(new Vector2(-132F, -43F), new Vector2(-198F, -97F), new Vector2(-198F, -97F));
                    builder.EndFigure(CanvasFigureLoop.Open);
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
                    builder.BeginFigure(new Vector2(-135.610001F, -189.218994F));
                    builder.AddCubicBezier(new Vector2(-150.154007F, -181.119995F), new Vector2(-155.949997F, -157.623993F), new Vector2(-155.949997F, -157.623993F));
                    builder.AddCubicBezier(new Vector2(-166.862F, -127.806F), new Vector2(-189.692993F, -109.205002F), new Vector2(-189.692993F, -109.205002F));
                    builder.AddCubicBezier(new Vector2(-220.695999F, -120.753998F), new Vector2(-245.401993F, -92.4440002F), new Vector2(-250.914001F, -85.4410019F));
                    builder.AddCubicBezier(new Vector2(-259.77301F, -86.4079971F), new Vector2(-297.285004F, -88.5930023F), new Vector2(-310.747009F, -58.3709984F));
                    builder.AddCubicBezier(new Vector2(-310.747009F, -58.3709984F), new Vector2(-340.014008F, -55.0940018F), new Vector2(-368.942993F, -68.1809998F));
                    builder.AddCubicBezier(new Vector2(-368.942993F, -68.1809998F), new Vector2(-388.998993F, -80.0350037F), new Vector2(-404.835999F, -76.0289993F));
                    builder.AddCubicBezier(new Vector2(-413.761993F, -73.7710037F), new Vector2(-419F, -64.7170029F), new Vector2(-416.915009F, -55.7490005F));
                    builder.AddCubicBezier(new Vector2(-414.989014F, -47.4640007F), new Vector2(-409.63501F, -35.7709999F), new Vector2(-395.223999F, -25.6000004F));
                    builder.AddCubicBezier(new Vector2(-395.223999F, -25.6000004F), new Vector2(-348.828003F, 16.2029991F), new Vector2(-308.437012F, 13.6619997F));
                    builder.AddCubicBezier(new Vector2(-308.437012F, 13.6619997F), new Vector2(-299.281006F, 134.192001F), new Vector2(-206.763F, 165.639999F));
                    builder.AddCubicBezier(new Vector2(-206.763F, 165.639999F), new Vector2(-164.932007F, 175.112F), new Vector2(-180.528F, 129.388F));
                    builder.AddCubicBezier(new Vector2(-180.528F, 129.388F), new Vector2(-193.610001F, 90.7249985F), new Vector2(-193.610001F, 90.7249985F));
                    builder.AddCubicBezier(new Vector2(-195.535004F, 85.0350037F), new Vector2(-195.294006F, 78.7300034F), new Vector2(-192.475998F, 73.4250031F));
                    builder.AddCubicBezier(new Vector2(-192.432999F, 73.3450012F), new Vector2(-192.391006F, 73.2649994F), new Vector2(-192.347F, 73.1849976F));
                    builder.AddCubicBezier(new Vector2(-189.701004F, 68.3590012F), new Vector2(-183.966995F, 65.9509964F), new Vector2(-178.669006F, 67.4410019F));
                    builder.AddCubicBezier(new Vector2(-178.582001F, 67.4660034F), new Vector2(-178.494995F, 67.4899979F), new Vector2(-178.408997F, 67.5159988F));
                    builder.AddCubicBezier(new Vector2(-172.647003F, 69.2180023F), new Vector2(-167.975006F, 73.4629974F), new Vector2(-165.259995F, 78.8219986F));
                    builder.AddCubicBezier(new Vector2(-165.259995F, 78.8219986F), new Vector2(-146.817001F, 115.231003F), new Vector2(-146.817001F, 115.231003F));
                    builder.AddCubicBezier(new Vector2(-125.092003F, 158.382004F), new Vector2(-102.565002F, 121.884003F), new Vector2(-102.565002F, 121.884003F));
                    builder.AddCubicBezier(new Vector2(-60.237999F, 33.8100014F), new Vector2(-139.880997F, -57.1199989F), new Vector2(-139.880997F, -57.1199989F));
                    builder.AddCubicBezier(new Vector2(-109.785004F, -84.1790009F), new Vector2(-107.147003F, -146.572998F), new Vector2(-107.147003F, -146.572998F));
                    builder.AddCubicBezier(new Vector2(-104.252998F, -164.386993F), new Vector2(-109.136002F, -176.548004F), new Vector2(-113.802002F, -183.662003F));
                    builder.AddCubicBezier(new Vector2(-118.531998F, -190.871994F), new Vector2(-128.076004F, -193.414001F), new Vector2(-135.610001F, -189.218994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_091()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-101.499001F, -180.539993F));
                    builder.AddCubicBezier(new Vector2(-117.776001F, -177.046997F), new Vector2(-130.186996F, -156.272003F), new Vector2(-130.186996F, -156.272003F));
                    builder.AddCubicBezier(new Vector2(-149.339996F, -130.947006F), new Vector2(-176.613007F, -119.834999F), new Vector2(-176.613007F, -119.834999F));
                    builder.AddCubicBezier(new Vector2(-202.884995F, -139.944F), new Vector2(-245.401993F, -92.4440002F), new Vector2(-250.914001F, -85.4410019F));
                    builder.AddCubicBezier(new Vector2(-259.77301F, -86.4079971F), new Vector2(-306.203003F, -91.0080032F), new Vector2(-317.006012F, -59.7369995F));
                    builder.AddCubicBezier(new Vector2(-317.006012F, -59.7369995F), new Vector2(-356.158997F, -55.3689995F), new Vector2(-387.457001F, -60.7140007F));
                    builder.AddCubicBezier(new Vector2(-387.457001F, -60.7140007F), new Vector2(-409.859985F, -67.1110001F), new Vector2(-424.167999F, -59.2290001F));
                    builder.AddCubicBezier(new Vector2(-432.231995F, -54.7869987F), new Vector2(-435.010986F, -44.7019997F), new Vector2(-430.725006F, -36.5530014F));
                    builder.AddCubicBezier(new Vector2(-426.765991F, -29.0249996F), new Vector2(-418.628998F, -19.066F), new Vector2(-402.114014F, -12.8699999F));
                    builder.AddCubicBezier(new Vector2(-402.114014F, -12.8699999F), new Vector2(-348.507996F, 17.8460007F), new Vector2(-308.487F, 11.8280001F));
                    builder.AddCubicBezier(new Vector2(-308.487F, 11.8280001F), new Vector2(-299.281006F, 134.192001F), new Vector2(-206.763F, 165.639999F));
                    builder.AddCubicBezier(new Vector2(-206.763F, 165.639999F), new Vector2(-164.932007F, 175.112F), new Vector2(-180.528F, 129.388F));
                    builder.AddCubicBezier(new Vector2(-180.528F, 129.388F), new Vector2(-193.610001F, 90.7249985F), new Vector2(-193.610001F, 90.7249985F));
                    builder.AddCubicBezier(new Vector2(-195.535004F, 85.0350037F), new Vector2(-195.294006F, 78.7300034F), new Vector2(-192.475998F, 73.4250031F));
                    builder.AddCubicBezier(new Vector2(-192.432999F, 73.3450012F), new Vector2(-192.391006F, 73.2649994F), new Vector2(-192.347F, 73.1849976F));
                    builder.AddCubicBezier(new Vector2(-189.701004F, 68.3590012F), new Vector2(-183.966995F, 65.9509964F), new Vector2(-178.669006F, 67.4410019F));
                    builder.AddCubicBezier(new Vector2(-178.582001F, 67.4649963F), new Vector2(-178.494995F, 67.4899979F), new Vector2(-178.408997F, 67.5159988F));
                    builder.AddCubicBezier(new Vector2(-172.647003F, 69.2180023F), new Vector2(-167.975006F, 73.4629974F), new Vector2(-165.259995F, 78.8219986F));
                    builder.AddCubicBezier(new Vector2(-165.259995F, 78.8219986F), new Vector2(-146.817001F, 115.231003F), new Vector2(-146.817001F, 115.231003F));
                    builder.AddCubicBezier(new Vector2(-125.092003F, 158.382004F), new Vector2(-102.565002F, 121.884003F), new Vector2(-102.565002F, 121.884003F));
                    builder.AddCubicBezier(new Vector2(-60.237999F, 33.8100014F), new Vector2(-144.205002F, -55.4620018F), new Vector2(-144.205002F, -55.4620018F));
                    builder.AddCubicBezier(new Vector2(-107.513F, -72.5390015F), new Vector2(-86.7480011F, -131.436005F), new Vector2(-86.7480011F, -131.436005F));
                    builder.AddCubicBezier(new Vector2(-78.7720032F, -147.626007F), new Vector2(-79.8860016F, -160.682007F), new Vector2(-82.2689972F, -168.848999F));
                    builder.AddCubicBezier(new Vector2(-84.6839981F, -177.126999F), new Vector2(-93.0680008F, -182.348999F), new Vector2(-101.499001F, -180.539993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_092()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_093(), Geometry_094() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_093()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-198.488998F, 171.076004F));
                    builder.AddCubicBezier(new Vector2(-203.630005F, 171.076004F), new Vector2(-207.617004F, 170.186996F), new Vector2(-207.783997F, 170.149002F));
                    builder.AddCubicBezier(new Vector2(-207.942001F, 170.113007F), new Vector2(-208.098007F, 170.069F), new Vector2(-208.251007F, 170.016998F));
                    builder.AddCubicBezier(new Vector2(-230.126999F, 162.580994F), new Vector2(-249.268997F, 149.684998F), new Vector2(-265.147003F, 131.684998F));
                    builder.AddCubicBezier(new Vector2(-277.761993F, 117.384003F), new Vector2(-288.335999F, 99.8600006F), new Vector2(-296.575989F, 79.5999985F));
                    builder.AddCubicBezier(new Vector2(-307.604004F, 52.4840012F), new Vector2(-311.425995F, 28.0799999F), new Vector2(-312.592987F, 18.3939991F));
                    builder.AddCubicBezier(new Vector2(-329.713989F, 18.2460003F), new Vector2(-349.317993F, 11.3900003F), new Vector2(-370.873993F, -1.98599994F));
                    builder.AddCubicBezier(new Vector2(-385.894989F, -11.3070002F), new Vector2(-396.460999F, -20.5170002F), new Vector2(-398.108002F, -21.9780006F));
                    builder.AddCubicBezier(new Vector2(-413.64801F, -33.0279999F), new Vector2(-419.360992F, -45.8619995F), new Vector2(-421.416992F, -54.7019997F));
                    builder.AddCubicBezier(new Vector2(-422.700989F, -60.2229996F), new Vector2(-421.837006F, -65.9240036F), new Vector2(-418.984985F, -70.7549973F));
                    builder.AddCubicBezier(new Vector2(-416.092987F, -75.6539993F), new Vector2(-411.470001F, -79.1190033F), new Vector2(-405.968994F, -80.5110016F));
                    builder.AddCubicBezier(new Vector2(-403.429993F, -81.1529999F), new Vector2(-400.674011F, -81.4789963F), new Vector2(-397.777008F, -81.4789963F));
                    builder.AddCubicBezier(new Vector2(-383.369995F, -81.4789963F), new Vector2(-368.915985F, -73.4970016F), new Vector2(-366.826996F, -72.2979965F));
                    builder.AddCubicBezier(new Vector2(-348.11499F, -63.887001F), new Vector2(-329.109009F, -62.6279984F), new Vector2(-319.424011F, -62.6279984F));
                    builder.AddCubicBezier(new Vector2(-317.075989F, -62.6279984F), new Vector2(-315.151001F, -62.7000008F), new Vector2(-313.760986F, -62.7779999F));
                    builder.AddCubicBezier(new Vector2(-301.416992F, -86.8430023F), new Vector2(-274.84201F, -90.5230026F), new Vector2(-259.778015F, -90.5230026F));
                    builder.AddCubicBezier(new Vector2(-257.119995F, -90.5230026F), new Vector2(-254.798004F, -90.4089966F), new Vector2(-252.940994F, -90.2679977F));
                    builder.AddCubicBezier(new Vector2(-246.080002F, -98.4140015F), new Vector2(-228.132996F, -116.564003F), new Vector2(-204.554993F, -116.564003F));
                    builder.AddCubicBezier(new Vector2(-199.921005F, -116.564003F), new Vector2(-195.285004F, -115.850998F), new Vector2(-190.738007F, -114.443001F));
                    builder.AddCubicBezier(new Vector2(-185.223999F, -119.494003F), new Vector2(-168.927002F, -135.789001F), new Vector2(-160.371002F, -158.994003F));
                    builder.AddCubicBezier(new Vector2(-159.626007F, -161.862F), new Vector2(-153.278F, -184.671005F), new Vector2(-137.858994F, -193.257004F));
                    builder.AddCubicBezier(new Vector2(-134.792007F, -194.964996F), new Vector2(-131.311005F, -195.867996F), new Vector2(-127.792F, -195.867996F));
                    builder.AddCubicBezier(new Vector2(-120.584F, -195.867996F), new Vector2(-113.910004F, -192.253006F), new Vector2(-109.936996F, -186.197006F));
                    builder.AddCubicBezier(new Vector2(-104.874001F, -178.479004F), new Vector2(-99.4970016F, -165.268005F), new Vector2(-102.542F, -146.097F));
                    builder.AddCubicBezier(new Vector2(-102.654999F, -143.820999F), new Vector2(-103.528F, -128.964996F), new Vector2(-107.725998F, -110.945F));
                    builder.AddCubicBezier(new Vector2(-113.309998F, -86.9729996F), new Vector2(-122.002998F, -68.7779999F), new Vector2(-133.591995F, -56.7729988F));
                    builder.AddCubicBezier(new Vector2(-127.491997F, -49.1559982F), new Vector2(-112.747002F, -29.3419991F), new Vector2(-101.109001F, -2.48399997F));
                    builder.AddCubicBezier(new Vector2(-92.413002F, 17.5849991F), new Vector2(-87.3059998F, 37.4049988F), new Vector2(-85.9290009F, 56.4239998F));
                    builder.AddCubicBezier(new Vector2(-84.1949997F, 80.362999F), new Vector2(-88.3899994F, 103.060997F), new Vector2(-98.3980026F, 123.886002F));
                    builder.AddCubicBezier(new Vector2(-98.4680023F, 124.031998F), new Vector2(-98.5459976F, 124.174004F), new Vector2(-98.6309967F, 124.310997F));
                    builder.AddCubicBezier(new Vector2(-99.0490036F, 124.988998F), new Vector2(-109.045998F, 140.921997F), new Vector2(-123.463997F, 140.923004F));
                    builder.AddCubicBezier(new Vector2(-123.466003F, 140.923004F), new Vector2(-123.467003F, 140.923004F), new Vector2(-123.469002F, 140.923004F));
                    builder.AddCubicBezier(new Vector2(-133.813995F, 140.921005F), new Vector2(-143.059006F, 132.975998F), new Vector2(-150.945999F, 117.309998F));
                    builder.AddCubicBezier(new Vector2(-150.945999F, 117.309998F), new Vector2(-169.384003F, 80.9110031F), new Vector2(-169.384003F, 80.9110031F));
                    builder.AddCubicBezier(new Vector2(-171.621002F, 76.4950027F), new Vector2(-175.388F, 73.2279968F), new Vector2(-179.718002F, 71.9489975F));
                    builder.AddCubicBezier(new Vector2(-179.718002F, 71.9489975F), new Vector2(-179.914001F, 71.8929977F), new Vector2(-179.914001F, 71.8929977F));
                    builder.AddCubicBezier(new Vector2(-180.546997F, 71.7149963F), new Vector2(-181.195999F, 71.625F), new Vector2(-181.850006F, 71.625F));
                    builder.AddCubicBezier(new Vector2(-184.505005F, 71.625F), new Vector2(-187.033005F, 73.1100006F), new Vector2(-188.292999F, 75.4069977F));
                    builder.AddCubicBezier(new Vector2(-188.328995F, 75.4720001F), new Vector2(-188.360992F, 75.5309982F), new Vector2(-188.391998F, 75.5889969F));
                    builder.AddCubicBezier(new Vector2(-190.513F, 79.5810013F), new Vector2(-190.817001F, 84.5559998F), new Vector2(-189.231003F, 89.2440033F));
                    builder.AddCubicBezier(new Vector2(-189.231003F, 89.2440033F), new Vector2(-176.149994F, 127.905998F), new Vector2(-176.149994F, 127.905998F));
                    builder.AddCubicBezier(new Vector2(-171.061005F, 142.824005F), new Vector2(-171.207993F, 154.210007F), new Vector2(-176.591003F, 161.733002F));
                    builder.AddCubicBezier(new Vector2(-180.964005F, 167.845001F), new Vector2(-188.535995F, 171.076004F), new Vector2(-198.488998F, 171.076004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_094()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-205.539993F, 161.173004F));
                    builder.AddCubicBezier(new Vector2(-204.779007F, 161.324005F), new Vector2(-201.955994F, 161.830994F), new Vector2(-198.488998F, 161.830994F));
                    builder.AddCubicBezier(new Vector2(-193.716995F, 161.830994F), new Vector2(-187.348999F, 160.880005F), new Vector2(-184.110001F, 156.352997F));
                    builder.AddCubicBezier(new Vector2(-180.612F, 151.464996F), new Vector2(-180.886002F, 142.656006F), new Vector2(-184.903F, 130.880005F));
                    builder.AddCubicBezier(new Vector2(-184.903F, 130.880005F), new Vector2(-197.988998F, 92.2070007F), new Vector2(-197.988998F, 92.2070007F));
                    builder.AddCubicBezier(new Vector2(-200.386993F, 85.1179962F), new Vector2(-199.865005F, 77.4810028F), new Vector2(-196.557999F, 71.2559967F));
                    builder.AddCubicBezier(new Vector2(-196.505997F, 71.1589966F), new Vector2(-196.451996F, 71.0579987F), new Vector2(-196.395996F, 70.9560013F));
                    builder.AddCubicBezier(new Vector2(-193.496994F, 65.6689987F), new Vector2(-187.921997F, 62.3810005F), new Vector2(-181.850006F, 62.3810005F));
                    builder.AddCubicBezier(new Vector2(-180.350006F, 62.3810005F), new Vector2(-178.858002F, 62.5859985F), new Vector2(-177.417007F, 62.9910011F));
                    builder.AddCubicBezier(new Vector2(-177.313004F, 63.0200005F), new Vector2(-177.203995F, 63.0519981F), new Vector2(-177.095001F, 63.0839996F));
                    builder.AddCubicBezier(new Vector2(-170.337006F, 65.0810013F), new Vector2(-164.520004F, 70.0559998F), new Vector2(-161.136993F, 76.7330017F));
                    builder.AddCubicBezier(new Vector2(-161.136993F, 76.7330017F), new Vector2(-142.692993F, 113.142998F), new Vector2(-142.692993F, 113.142998F));
                    builder.AddCubicBezier(new Vector2(-138.432999F, 121.602997F), new Vector2(-131.645004F, 131.675995F), new Vector2(-123.466003F, 131.677994F));
                    builder.AddCubicBezier(new Vector2(-123.464996F, 131.677994F), new Vector2(-123.464996F, 131.677994F), new Vector2(-123.464996F, 131.677994F));
                    builder.AddCubicBezier(new Vector2(-114.889999F, 131.677994F), new Vector2(-107.581001F, 121.097F), new Vector2(-106.608002F, 119.625F));
                    builder.AddCubicBezier(new Vector2(-89.7900009F, 84.4250031F), new Vector2(-90.7929993F, 44.5789986F), new Vector2(-109.592003F, 1.19200003F));
                    builder.AddCubicBezier(new Vector2(-123.761002F, -31.5079994F), new Vector2(-143.164993F, -53.8530006F), new Vector2(-143.358994F, -54.0750008F));
                    builder.AddCubicBezier(new Vector2(-145.026001F, -55.9780006F), new Vector2(-144.852997F, -58.8670006F), new Vector2(-142.972F, -60.5579987F));
                    builder.AddCubicBezier(new Vector2(-114.691002F, -85.9850006F), new Vector2(-111.791F, -146.164993F), new Vector2(-111.764999F, -146.770004F));
                    builder.AddCubicBezier(new Vector2(-111.757004F, -146.951996F), new Vector2(-111.737999F, -147.134995F), new Vector2(-111.709F, -147.315002F));
                    builder.AddCubicBezier(new Vector2(-109.047997F, -163.697006F), new Vector2(-113.480003F, -174.744003F), new Vector2(-117.667F, -181.126007F));
                    builder.AddCubicBezier(new Vector2(-119.925003F, -184.567993F), new Vector2(-123.709999F, -186.623001F), new Vector2(-127.792F, -186.623001F));
                    builder.AddCubicBezier(new Vector2(-129.768005F, -186.623001F), new Vector2(-131.641998F, -186.136993F), new Vector2(-133.360992F, -185.179993F));
                    builder.AddCubicBezier(new Vector2(-143.850998F, -179.339005F), new Vector2(-149.983002F, -162.509003F), new Vector2(-151.460999F, -156.516998F));
                    builder.AddCubicBezier(new Vector2(-151.501007F, -156.354004F), new Vector2(-151.550995F, -156.192993F), new Vector2(-151.608994F, -156.035004F));
                    builder.AddCubicBezier(new Vector2(-162.828003F, -125.376999F), new Vector2(-185.802002F, -106.414001F), new Vector2(-186.774002F, -105.622002F));
                    builder.AddCubicBezier(new Vector2(-188.046005F, -104.585999F), new Vector2(-189.770004F, -104.301003F), new Vector2(-191.307007F, -104.874001F));
                    builder.AddCubicBezier(new Vector2(-195.662994F, -106.497002F), new Vector2(-200.119995F, -107.319F), new Vector2(-204.554993F, -107.319F));
                    builder.AddCubicBezier(new Vector2(-226.132004F, -107.319F), new Vector2(-242.714005F, -88.3850021F), new Vector2(-247.281998F, -82.5820007F));
                    builder.AddCubicBezier(new Vector2(-248.268005F, -81.3290024F), new Vector2(-249.830994F, -80.6740036F), new Vector2(-251.416F, -80.8460007F));
                    builder.AddCubicBezier(new Vector2(-253.220001F, -81.0429993F), new Vector2(-256.13501F, -81.2779999F), new Vector2(-259.778015F, -81.2779999F));
                    builder.AddCubicBezier(new Vector2(-273.113007F, -81.2779999F), new Vector2(-296.917999F, -78.0569992F), new Vector2(-306.524994F, -56.4900017F));
                    builder.AddCubicBezier(new Vector2(-307.191986F, -54.9920006F), new Vector2(-308.602997F, -53.9599991F), new Vector2(-310.233002F, -53.7770004F));
                    builder.AddCubicBezier(new Vector2(-310.377014F, -53.7610016F), new Vector2(-313.812988F, -53.3829994F), new Vector2(-319.424011F, -53.3829994F));
                    builder.AddCubicBezier(new Vector2(-329.890015F, -53.3829994F), new Vector2(-350.488007F, -54.7579994F), new Vector2(-370.847992F, -63.9690018F));
                    builder.AddCubicBezier(new Vector2(-371.001007F, -64.038002F), new Vector2(-371.149994F, -64.1149979F), new Vector2(-371.295013F, -64.2009964F));
                    builder.AddCubicBezier(new Vector2(-371.428009F, -64.2789993F), new Vector2(-385.095001F, -72.2340012F), new Vector2(-397.777008F, -72.2340012F));
                    builder.AddCubicBezier(new Vector2(-399.910004F, -72.2340012F), new Vector2(-401.903992F, -72.0029984F), new Vector2(-403.701996F, -71.5479965F));
                    builder.AddCubicBezier(new Vector2(-410.131989F, -69.9209976F), new Vector2(-413.957001F, -63.4410019F), new Vector2(-412.411987F, -56.7960014F));
                    builder.AddCubicBezier(new Vector2(-410.710999F, -49.4790001F), new Vector2(-405.885986F, -38.7830009F), new Vector2(-392.55899F, -29.3759995F));
                    builder.AddCubicBezier(new Vector2(-392.408997F, -29.2700005F), new Vector2(-392.265991F, -29.1560001F), new Vector2(-392.130005F, -29.0340004F));
                    builder.AddCubicBezier(new Vector2(-391.707001F, -28.6529999F), new Vector2(-349.260986F, 9.15100002F), new Vector2(-312.026001F, 9.15100002F));
                    builder.AddCubicBezier(new Vector2(-310.915009F, 9.15100002F), new Vector2(-309.804993F, 9.11699963F), new Vector2(-308.72699F, 9.04899979F));
                    builder.AddCubicBezier(new Vector2(-306.207001F, 8.88599968F), new Vector2(-304.019989F, 10.79F), new Vector2(-303.828003F, 13.3120003F));
                    builder.AddCubicBezier(new Vector2(-303.806F, 13.6059999F), new Vector2(-301.394012F, 43.3260002F), new Vector2(-287.915009F, 76.3550034F));
                    builder.AddCubicBezier(new Vector2(-270.092987F, 120.025002F), new Vector2(-242.380005F, 148.559998F), new Vector2(-205.539993F, 161.173004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_095()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_096(), Geometry_097() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_096()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-198.488998F, 171.076004F));
                    builder.AddCubicBezier(new Vector2(-203.630005F, 171.076004F), new Vector2(-207.617004F, 170.186996F), new Vector2(-207.783997F, 170.149002F));
                    builder.AddCubicBezier(new Vector2(-207.942001F, 170.113007F), new Vector2(-208.098007F, 170.069F), new Vector2(-208.251007F, 170.016998F));
                    builder.AddCubicBezier(new Vector2(-230.126999F, 162.580994F), new Vector2(-249.268997F, 149.684998F), new Vector2(-265.147003F, 131.684998F));
                    builder.AddCubicBezier(new Vector2(-277.761993F, 117.384003F), new Vector2(-288.335999F, 99.8600006F), new Vector2(-296.575989F, 79.5999985F));
                    builder.AddCubicBezier(new Vector2(-307.604004F, 52.4840012F), new Vector2(-310.220001F, 26.4489994F), new Vector2(-312.218994F, 16.8999996F));
                    builder.AddCubicBezier(new Vector2(-329.289001F, 18.2299995F), new Vector2(-348.345001F, 11.3070002F), new Vector2(-372.583008F, 3.81800008F));
                    builder.AddCubicBezier(new Vector2(-389.472992F, -1.40100002F), new Vector2(-402.024994F, -7.63999987F), new Vector2(-403.988007F, -8.63700008F));
                    builder.AddCubicBezier(new Vector2(-421.817993F, -15.3970003F), new Vector2(-430.59201F, -26.3689995F), new Vector2(-434.81601F, -34.401001F));
                    builder.AddCubicBezier(new Vector2(-437.45401F, -39.4169998F), new Vector2(-438.061005F, -45.151001F), new Vector2(-436.52301F, -50.5470009F));
                    builder.AddCubicBezier(new Vector2(-434.963989F, -56.0180016F), new Vector2(-431.368011F, -60.5400009F), new Vector2(-426.39801F, -63.2779999F));
                    builder.AddCubicBezier(new Vector2(-424.104004F, -64.5419998F), new Vector2(-421.519989F, -65.5530014F), new Vector2(-418.71701F, -66.2860031F));
                    builder.AddCubicBezier(new Vector2(-404.778992F, -69.9300003F), new Vector2(-388.777008F, -65.862999F), new Vector2(-386.451996F, -65.2320023F));
                    builder.AddCubicBezier(new Vector2(-366.221008F, -61.8279991F), new Vector2(-335.667999F, -62.3930016F), new Vector2(-326.019012F, -63.2290001F));
                    builder.AddCubicBezier(new Vector2(-323.679993F, -63.4319992F), new Vector2(-321.766998F, -63.6710014F), new Vector2(-320.389008F, -63.868F));
                    builder.AddCubicBezier(new Vector2(-310.167999F, -88.9089966F), new Vector2(-274.84201F, -90.5230026F), new Vector2(-259.778015F, -90.5230026F));
                    builder.AddCubicBezier(new Vector2(-257.119995F, -90.5230026F), new Vector2(-254.798004F, -90.4089966F), new Vector2(-252.940994F, -90.2679977F));
                    builder.AddCubicBezier(new Vector2(-246.080002F, -98.4140015F), new Vector2(-228.132996F, -116.564003F), new Vector2(-204.554993F, -116.564003F));
                    builder.AddCubicBezier(new Vector2(-199.921005F, -116.564003F), new Vector2(-180.016998F, -127.824997F), new Vector2(-176.080002F, -125.149002F));
                    builder.AddCubicBezier(new Vector2(-169.330994F, -128.367004F), new Vector2(-148.981003F, -139.184998F), new Vector2(-134.014008F, -158.875F));
                    builder.AddCubicBezier(new Vector2(-132.462997F, -161.399994F), new Vector2(-119.724998F, -181.356995F), new Vector2(-102.469002F, -185.059006F));
                    builder.AddCubicBezier(new Vector2(-99.0370026F, -185.794998F), new Vector2(-95.4440002F, -185.641998F), new Vector2(-92.0790024F, -184.613007F));
                    builder.AddCubicBezier(new Vector2(-85.185997F, -182.505997F), new Vector2(-79.8590012F, -177.095993F), new Vector2(-77.8310013F, -170.143997F));
                    builder.AddCubicBezier(new Vector2(-75.2460022F, -161.283005F), new Vector2(-73.9649963F, -147.076996F), new Vector2(-82.4830017F, -129.634003F));
                    builder.AddCubicBezier(new Vector2(-83.2570038F, -127.490997F), new Vector2(-88.435997F, -113.540001F), new Vector2(-97.7190018F, -97.5339966F));
                    builder.AddCubicBezier(new Vector2(-110.068001F, -76.2419968F), new Vector2(-123.699997F, -61.3829994F), new Vector2(-138.292999F, -53.2910004F));
                    builder.AddCubicBezier(new Vector2(-134.686996F, -44.223999F), new Vector2(-112.747002F, -29.3419991F), new Vector2(-101.109001F, -2.48399997F));
                    builder.AddCubicBezier(new Vector2(-92.413002F, 17.5849991F), new Vector2(-87.3059998F, 37.4049988F), new Vector2(-85.9290009F, 56.4239998F));
                    builder.AddCubicBezier(new Vector2(-84.1949997F, 80.362999F), new Vector2(-88.3899994F, 103.060997F), new Vector2(-98.3980026F, 123.886002F));
                    builder.AddCubicBezier(new Vector2(-98.4680023F, 124.031998F), new Vector2(-98.5459976F, 124.174004F), new Vector2(-98.6309967F, 124.310997F));
                    builder.AddCubicBezier(new Vector2(-99.0490036F, 124.988998F), new Vector2(-109.045998F, 140.921997F), new Vector2(-123.463997F, 140.923004F));
                    builder.AddCubicBezier(new Vector2(-123.466003F, 140.923004F), new Vector2(-123.467003F, 140.923004F), new Vector2(-123.469002F, 140.923004F));
                    builder.AddCubicBezier(new Vector2(-133.813995F, 140.921005F), new Vector2(-143.059006F, 132.975998F), new Vector2(-150.945999F, 117.309998F));
                    builder.AddCubicBezier(new Vector2(-150.945999F, 117.309998F), new Vector2(-169.384003F, 80.9110031F), new Vector2(-169.384003F, 80.9110031F));
                    builder.AddCubicBezier(new Vector2(-171.621002F, 76.4950027F), new Vector2(-175.388F, 73.2279968F), new Vector2(-179.718002F, 71.9489975F));
                    builder.AddCubicBezier(new Vector2(-179.718002F, 71.9489975F), new Vector2(-179.914001F, 71.8929977F), new Vector2(-179.914001F, 71.8929977F));
                    builder.AddCubicBezier(new Vector2(-180.546997F, 71.7149963F), new Vector2(-181.195999F, 71.625F), new Vector2(-181.850006F, 71.625F));
                    builder.AddCubicBezier(new Vector2(-184.505005F, 71.625F), new Vector2(-187.033005F, 73.1100006F), new Vector2(-188.292999F, 75.4069977F));
                    builder.AddCubicBezier(new Vector2(-188.328995F, 75.4720001F), new Vector2(-188.360992F, 75.5309982F), new Vector2(-188.391998F, 75.5889969F));
                    builder.AddCubicBezier(new Vector2(-190.513F, 79.5810013F), new Vector2(-190.817001F, 84.5559998F), new Vector2(-189.231003F, 89.2440033F));
                    builder.AddCubicBezier(new Vector2(-189.231003F, 89.2440033F), new Vector2(-176.149994F, 127.905998F), new Vector2(-176.149994F, 127.905998F));
                    builder.AddCubicBezier(new Vector2(-171.061005F, 142.824005F), new Vector2(-171.207993F, 154.210007F), new Vector2(-176.591003F, 161.733002F));
                    builder.AddCubicBezier(new Vector2(-180.964005F, 167.845001F), new Vector2(-188.535995F, 171.076004F), new Vector2(-198.488998F, 171.076004F));
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
                    builder.BeginFigure(new Vector2(-205.539993F, 161.173004F));
                    builder.AddCubicBezier(new Vector2(-204.779007F, 161.324005F), new Vector2(-201.955994F, 161.830994F), new Vector2(-198.488998F, 161.830994F));
                    builder.AddCubicBezier(new Vector2(-193.716995F, 161.830994F), new Vector2(-187.348999F, 160.880005F), new Vector2(-184.110001F, 156.352997F));
                    builder.AddCubicBezier(new Vector2(-180.612F, 151.464996F), new Vector2(-180.886002F, 142.656006F), new Vector2(-184.903F, 130.880005F));
                    builder.AddCubicBezier(new Vector2(-184.903F, 130.880005F), new Vector2(-197.988998F, 92.2070007F), new Vector2(-197.988998F, 92.2070007F));
                    builder.AddCubicBezier(new Vector2(-200.386993F, 85.1179962F), new Vector2(-199.865005F, 77.4810028F), new Vector2(-196.557999F, 71.2559967F));
                    builder.AddCubicBezier(new Vector2(-196.505997F, 71.1589966F), new Vector2(-196.451996F, 71.0579987F), new Vector2(-196.395996F, 70.9560013F));
                    builder.AddCubicBezier(new Vector2(-193.496994F, 65.6689987F), new Vector2(-187.921997F, 62.3810005F), new Vector2(-181.850006F, 62.3810005F));
                    builder.AddCubicBezier(new Vector2(-180.350006F, 62.3810005F), new Vector2(-178.858002F, 62.5859985F), new Vector2(-177.417007F, 62.9910011F));
                    builder.AddCubicBezier(new Vector2(-177.313004F, 63.0200005F), new Vector2(-177.203995F, 63.0519981F), new Vector2(-177.095001F, 63.0839996F));
                    builder.AddCubicBezier(new Vector2(-170.337006F, 65.0810013F), new Vector2(-164.520004F, 70.0559998F), new Vector2(-161.136993F, 76.7330017F));
                    builder.AddCubicBezier(new Vector2(-161.136993F, 76.7330017F), new Vector2(-142.692993F, 113.142998F), new Vector2(-142.692993F, 113.142998F));
                    builder.AddCubicBezier(new Vector2(-138.432999F, 121.602997F), new Vector2(-131.645004F, 131.675995F), new Vector2(-123.466003F, 131.677994F));
                    builder.AddCubicBezier(new Vector2(-123.464996F, 131.677994F), new Vector2(-123.464996F, 131.677994F), new Vector2(-123.464996F, 131.677994F));
                    builder.AddCubicBezier(new Vector2(-114.889999F, 131.677994F), new Vector2(-107.581001F, 121.097F), new Vector2(-106.608002F, 119.625F));
                    builder.AddCubicBezier(new Vector2(-89.7900009F, 84.4250031F), new Vector2(-90.7929993F, 44.5789986F), new Vector2(-109.592003F, 1.19200003F));
                    builder.AddCubicBezier(new Vector2(-123.761002F, -31.5079994F), new Vector2(-148.300003F, -53.2970009F), new Vector2(-148.421005F, -53.5660019F));
                    builder.AddCubicBezier(new Vector2(-149.457993F, -55.8730011F), new Vector2(-148.449005F, -58.5859985F), new Vector2(-146.156006F, -59.6529999F));
                    builder.AddCubicBezier(new Vector2(-111.677002F, -75.6999969F), new Vector2(-91.3089981F, -132.403F), new Vector2(-91.1070023F, -132.973999F));
                    builder.AddCubicBezier(new Vector2(-91.0459976F, -133.145996F), new Vector2(-90.973999F, -133.315994F), new Vector2(-90.8939972F, -133.479004F));
                    builder.AddCubicBezier(new Vector2(-83.5599976F, -148.367004F), new Vector2(-84.5680008F, -160.227005F), new Vector2(-86.7060013F, -167.554993F));
                    builder.AddCubicBezier(new Vector2(-87.8590012F, -171.505997F), new Vector2(-90.8779984F, -174.578995F), new Vector2(-94.7819977F, -175.772003F));
                    builder.AddCubicBezier(new Vector2(-96.6719971F, -176.350006F), new Vector2(-98.6050034F, -176.432999F), new Vector2(-100.528999F, -176.020004F));
                    builder.AddCubicBezier(new Vector2(-112.267998F, -173.501007F), new Vector2(-123.054001F, -159.199005F), new Vector2(-126.219002F, -153.901001F));
                    builder.AddCubicBezier(new Vector2(-126.305F, -153.757004F), new Vector2(-126.399002F, -153.617996F), new Vector2(-126.5F, -153.483994F));
                    builder.AddCubicBezier(new Vector2(-146.192993F, -127.445999F), new Vector2(-173.705994F, -116.027F), new Vector2(-174.867996F, -115.554001F));
                    builder.AddCubicBezier(new Vector2(-176.386993F, -114.934998F), new Vector2(-178.119995F, -115.167F), new Vector2(-179.421997F, -116.164001F));
                    builder.AddCubicBezier(new Vector2(-183.113007F, -118.988998F), new Vector2(-200.119995F, -107.319F), new Vector2(-204.554993F, -107.319F));
                    builder.AddCubicBezier(new Vector2(-226.132004F, -107.319F), new Vector2(-242.714005F, -88.3850021F), new Vector2(-247.281998F, -82.5820007F));
                    builder.AddCubicBezier(new Vector2(-248.268005F, -81.3290024F), new Vector2(-249.830994F, -80.6740036F), new Vector2(-251.416F, -80.8460007F));
                    builder.AddCubicBezier(new Vector2(-253.220001F, -81.0429993F), new Vector2(-256.13501F, -81.2779999F), new Vector2(-259.778015F, -81.2779999F));
                    builder.AddCubicBezier(new Vector2(-273.113007F, -81.2779999F), new Vector2(-304.928009F, -80.5429993F), new Vector2(-312.636993F, -58.2270012F));
                    builder.AddCubicBezier(new Vector2(-313.171997F, -56.6769981F), new Vector2(-314.489014F, -55.5279999F), new Vector2(-316.096985F, -55.2050018F));
                    builder.AddCubicBezier(new Vector2(-316.239014F, -55.1769981F), new Vector2(-319.631012F, -54.5029984F), new Vector2(-325.221008F, -54.019001F));
                    builder.AddCubicBezier(new Vector2(-335.64801F, -53.1150017F), new Vector2(-366.207001F, -52.3959999F), new Vector2(-388.234985F, -56.1570015F));
                    builder.AddCubicBezier(new Vector2(-388.401001F, -56.1850014F), new Vector2(-388.565002F, -56.2229996F), new Vector2(-388.726013F, -56.269001F));
                    builder.AddCubicBezier(new Vector2(-388.873993F, -56.3110008F), new Vector2(-404.109985F, -60.5499992F), new Vector2(-416.378998F, -57.3419991F));
                    builder.AddCubicBezier(new Vector2(-418.442993F, -56.8019981F), new Vector2(-420.312988F, -56.0750008F), new Vector2(-421.937988F, -55.1800003F));
                    builder.AddCubicBezier(new Vector2(-427.747009F, -51.9799995F), new Vector2(-429.809998F, -44.7439995F), new Vector2(-426.634003F, -38.7050018F));
                    builder.AddCubicBezier(new Vector2(-423.136993F, -32.0559998F), new Vector2(-415.763F, -22.9279995F), new Vector2(-400.48999F, -17.198F));
                    builder.AddCubicBezier(new Vector2(-400.319F, -17.1340008F), new Vector2(-400.152008F, -17.059F), new Vector2(-399.989014F, -16.9750004F));
                    builder.AddCubicBezier(new Vector2(-399.483002F, -16.7129993F), new Vector2(-349.548004F, 10.8570004F), new Vector2(-312.451996F, 7.64300013F));
                    builder.AddCubicBezier(new Vector2(-311.345001F, 7.54699993F), new Vector2(-310.242004F, 7.42000008F), new Vector2(-309.174011F, 7.25699997F));
                    builder.AddCubicBezier(new Vector2(-306.678009F, 6.87699986F), new Vector2(-304.334015F, 8.58500004F), new Vector2(-303.924988F, 11.0810003F));
                    builder.AddCubicBezier(new Vector2(-303.877014F, 11.3719997F), new Vector2(-301.394012F, 43.3260002F), new Vector2(-287.915009F, 76.3550034F));
                    builder.AddCubicBezier(new Vector2(-270.092987F, 120.025002F), new Vector2(-242.380005F, 148.559998F), new Vector2(-205.539993F, 161.173004F));
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
                    builder.BeginFigure(new Vector2(-174.688004F, -120.917999F));
                    builder.AddCubicBezier(new Vector2(-174.688004F, -120.917999F), new Vector2(-176.227997F, -85.4789963F), new Vector2(-255.720001F, -51.1100006F));
                    builder.AddCubicBezier(new Vector2(-281.006012F, -40.1749992F), new Vector2(-294.700989F, -12.5480003F), new Vector2(-288.67099F, 14.3330002F));
                    builder.AddCubicBezier(new Vector2(-276.330994F, 69.3410034F), new Vector2(-247.283997F, 149.436005F), new Vector2(-181.621002F, 163.363998F));
                    builder.AddCubicBezier(new Vector2(-181.621002F, 163.363998F), new Vector2(-286.39801F, 194.179993F), new Vector2(-309.51001F, 12.3629999F));
                    builder.AddCubicBezier(new Vector2(-309.51001F, 12.3629999F), new Vector2(-415.826996F, -7.66800022F), new Vector2(-412.744995F, -56.973999F));
                    builder.AddCubicBezier(new Vector2(-412.744995F, -56.973999F), new Vector2(-402.140015F, -47.8019981F), new Vector2(-387.112F, -38.1119995F));
                    builder.AddCubicBezier(new Vector2(-376.092987F, -31.007F), new Vector2(-363.076996F, -27.3759995F), new Vector2(-350.002014F, -28.3430004F));
                    builder.AddCubicBezier(new Vector2(-333.46701F, -29.566F), new Vector2(-324.796997F, -37.4029999F), new Vector2(-322.606995F, -57.7439995F));
                    builder.AddCubicBezier(new Vector2(-322.606995F, -57.7439995F), new Vector2(-314.069F, -60.4430008F), new Vector2(-314.069F, -60.4430008F));
                    builder.AddCubicBezier(new Vector2(-314.069F, -60.4430008F), new Vector2(-174.688004F, -120.917999F), new Vector2(-174.688004F, -120.917999F));
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
                    builder.BeginFigure(new Vector2(-158.837997F, -126.649002F));
                    builder.AddCubicBezier(new Vector2(-158.837997F, -126.649002F), new Vector2(-176.227997F, -85.4789963F), new Vector2(-255.720001F, -51.1100006F));
                    builder.AddCubicBezier(new Vector2(-281.006012F, -40.1749992F), new Vector2(-294.700989F, -12.5480003F), new Vector2(-288.67099F, 14.3330002F));
                    builder.AddCubicBezier(new Vector2(-276.330994F, 69.3410034F), new Vector2(-247.283997F, 149.436005F), new Vector2(-181.621002F, 163.363998F));
                    builder.AddCubicBezier(new Vector2(-181.621002F, 163.363998F), new Vector2(-270.946991F, 189.770004F), new Vector2(-309.667999F, 10.6260004F));
                    builder.AddCubicBezier(new Vector2(-309.667999F, 10.6260004F), new Vector2(-417.510986F, 9.69099998F), new Vector2(-427.001007F, -38.7919998F));
                    builder.AddCubicBezier(new Vector2(-427.001007F, -38.7919998F), new Vector2(-414.421997F, -32.6010017F), new Vector2(-397.431F, -27.0270004F));
                    builder.AddCubicBezier(new Vector2(-384.972992F, -22.9400005F), new Vector2(-371.462006F, -22.7189999F), new Vector2(-359.057007F, -26.9619999F));
                    builder.AddCubicBezier(new Vector2(-343.368988F, -32.3269997F), new Vector2(-329.194F, -37.6349983F), new Vector2(-328.768005F, -58.0890007F));
                    builder.AddCubicBezier(new Vector2(-328.768005F, -58.0890007F), new Vector2(-320.494995F, -61.5139999F), new Vector2(-320.494995F, -61.5139999F));
                    builder.AddCubicBezier(new Vector2(-320.494995F, -61.5139999F), new Vector2(-158.837997F, -126.649002F), new Vector2(-158.837997F, -126.649002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_100()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-114.719002F, -11.2329998F));
                    builder.AddCubicBezier(new Vector2(-131.839996F, 0.524999976F), new Vector2(-194.733994F, 40.4300003F), new Vector2(-292.855011F, 65.4049988F));
                    builder.AddCubicBezier(new Vector2(-291.585999F, 69.0699997F), new Vector2(-290.19101F, 72.8130035F), new Vector2(-288.644989F, 76.6050034F));
                    builder.AddCubicBezier(new Vector2(-288.066986F, 78.0230026F), new Vector2(-287.47699F, 79.4250031F), new Vector2(-286.877991F, 80.810997F));
                    builder.AddCubicBezier(new Vector2(-260.735992F, 71.9140015F), new Vector2(-137.554001F, 29.1550007F), new Vector2(-107.936996F, 3.48399997F));
                    builder.AddCubicBezier(new Vector2(-110.092003F, -1.67999995F), new Vector2(-112.380997F, -6.5999999F), new Vector2(-114.719002F, -11.2329998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_101()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-156.720993F, 82.5830002F));
                    builder.AddLine(new Vector2(-177.533997F, 76.913002F));
                    builder.AddLine(new Vector2(-152.020004F, -16.7460003F));
                    builder.AddLine(new Vector2(-131.207001F, -11.0760002F));
                    builder.AddLine(new Vector2(-156.720993F, 82.5830002F));
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
                    builder.BeginFigure(new Vector2(-193.932999F, 82.6100006F));
                    builder.AddLine(new Vector2(-207.382996F, 78.9459991F));
                    builder.AddLine(new Vector2(-181.869003F, -14.7130003F));
                    builder.AddLine(new Vector2(-168.419006F, -11.0489998F));
                    builder.AddLine(new Vector2(-193.932999F, 82.6100006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_103()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-374.140015F, -66.5650024F));
                    builder.AddCubicBezier(new Vector2(-380.136993F, -69.5039978F), new Vector2(-393.322998F, -74.9700012F), new Vector2(-403.890991F, -72.2949982F));
                    builder.AddCubicBezier(new Vector2(-410.730988F, -70.5650024F), new Vector2(-414.804993F, -63.6800003F), new Vector2(-413.162994F, -56.6220016F));
                    builder.AddCubicBezier(new Vector2(-411.665985F, -50.1809998F), new Vector2(-407.783997F, -41.1720009F), new Vector2(-398.015015F, -32.6790009F));
                    builder.AddCubicBezier(new Vector2(-384.109985F, -41.9700012F), new Vector2(-376.372986F, -60.5060005F), new Vector2(-374.140015F, -66.5650024F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_104()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-392.076996F, -57.8359985F));
                    builder.AddCubicBezier(new Vector2(-398.622009F, -59.1619987F), new Vector2(-412.760986F, -61.1139984F), new Vector2(-422.30899F, -55.8549995F));
                    builder.AddCubicBezier(new Vector2(-428.489014F, -52.4510002F), new Vector2(-430.688995F, -44.7599983F), new Vector2(-427.31601F, -38.3460007F));
                    builder.AddCubicBezier(new Vector2(-424.238007F, -32.493F), new Vector2(-418.203003F, -24.7600002F), new Vector2(-406.604004F, -19.0139999F));
                    builder.AddCubicBezier(new Vector2(-395.501007F, -31.5200005F), new Vector2(-392.704987F, -51.4099998F), new Vector2(-392.076996F, -57.8359985F));
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
                    builder.BeginFigure(new Vector2(-110.227997F, -153.934998F));
                    builder.AddCubicBezier(new Vector2(-109.539001F, -166.899994F), new Vector2(-113.365997F, -175.973999F), new Vector2(-117.023003F, -181.548004F));
                    builder.AddCubicBezier(new Vector2(-120.691002F, -187.139999F), new Vector2(-128.031998F, -189.029999F), new Vector2(-133.735992F, -185.852997F));
                    builder.AddCubicBezier(new Vector2(-142.701996F, -180.860001F), new Vector2(-148.106003F, -168.809998F), new Vector2(-150.584F, -161.865005F));
                    builder.AddCubicBezier(new Vector2(-142.735992F, -157.910995F), new Vector2(-124.986F, -150.335999F), new Vector2(-110.227997F, -153.934998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_106()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-87.5410004F, -139.376999F));
                    builder.AddCubicBezier(new Vector2(-83.0910034F, -151.574005F), new Vector2(-84.0999985F, -161.369995F), new Vector2(-85.9670029F, -167.770004F));
                    builder.AddCubicBezier(new Vector2(-87.8399963F, -174.190002F), new Vector2(-94.3079987F, -178.143005F), new Vector2(-100.691002F, -176.772995F));
                    builder.AddCubicBezier(new Vector2(-110.725998F, -174.619995F), new Vector2(-119.416F, -164.675995F), new Vector2(-123.816002F, -158.759003F));
                    builder.AddCubicBezier(new Vector2(-117.467003F, -152.682999F), new Vector2(-102.706001F, -140.248993F), new Vector2(-87.5410004F, -139.376999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_107()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-117.023003F, -181.548004F));
                    builder.AddCubicBezier(new Vector2(-120.691002F, -187.139999F), new Vector2(-128.031998F, -189.029999F), new Vector2(-133.735992F, -185.852997F));
                    builder.AddCubicBezier(new Vector2(-135.054001F, -185.119003F), new Vector2(-136.285004F, -184.220001F), new Vector2(-137.451004F, -183.220001F));
                    builder.AddCubicBezier(new Vector2(-131.897003F, -185.733994F), new Vector2(-125.122002F, -183.766998F), new Vector2(-121.646004F, -178.466995F));
                    builder.AddCubicBezier(new Vector2(-118.213997F, -173.235992F), new Vector2(-114.632004F, -164.919006F), new Vector2(-114.774002F, -153.199005F));
                    builder.AddCubicBezier(new Vector2(-113.238998F, -153.350006F), new Vector2(-111.716003F, -153.572006F), new Vector2(-110.227997F, -153.934998F));
                    builder.AddCubicBezier(new Vector2(-109.539001F, -166.899994F), new Vector2(-113.365997F, -175.973999F), new Vector2(-117.023003F, -181.548004F));
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
                    builder.BeginFigure(new Vector2(-85.9670029F, -167.770004F));
                    builder.AddCubicBezier(new Vector2(-87.8399963F, -174.190002F), new Vector2(-94.3079987F, -178.143005F), new Vector2(-100.691002F, -176.772995F));
                    builder.AddCubicBezier(new Vector2(-102.166F, -176.457001F), new Vector2(-103.606003F, -175.955994F), new Vector2(-105.013F, -175.341003F));
                    builder.AddCubicBezier(new Vector2(-98.9660034F, -176.121002F), new Vector2(-93.0650024F, -172.259003F), new Vector2(-91.2890015F, -166.175003F));
                    builder.AddCubicBezier(new Vector2(-89.5360031F, -160.169006F), new Vector2(-88.5410004F, -151.169006F), new Vector2(-92.1039963F, -140.001999F));
                    builder.AddCubicBezier(new Vector2(-90.5920029F, -139.697006F), new Vector2(-89.0699997F, -139.464996F), new Vector2(-87.5410004F, -139.376999F));
                    builder.AddCubicBezier(new Vector2(-83.0910034F, -151.574005F), new Vector2(-84.0999985F, -161.369995F), new Vector2(-85.9670029F, -167.770004F));
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
                    builder.BeginFigure(new Vector2(-232.399994F, 149.037994F));
                    builder.AddCubicBezier(new Vector2(-224.125F, 154.369995F), new Vector2(-215.237F, 158.671997F), new Vector2(-205.742996F, 161.917999F));
                    builder.AddCubicBezier(new Vector2(-204.065002F, 162.255005F), new Vector2(-190.473999F, 164.705002F), new Vector2(-184.242996F, 157.75F));
                    builder.AddCubicBezier(new Vector2(-179.826996F, 152.820999F), new Vector2(-179.804001F, 143.445007F), new Vector2(-184.173996F, 130.630997F));
                    builder.AddLine(new Vector2(-188.014999F, 119.280998F));
                    builder.AddCubicBezier(new Vector2(-209.787003F, 118.621002F), new Vector2(-228.339005F, 143.240997F), new Vector2(-232.399994F, 149.037994F));
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
                    builder.BeginFigure(new Vector2(-198.039001F, 154.214005F));
                    builder.AddCubicBezier(new Vector2(-207.533005F, 150.968002F), new Vector2(-216.421005F, 146.666F), new Vector2(-224.695999F, 141.334F));
                    builder.AddCubicBezier(new Vector2(-223.490997F, 139.613998F), new Vector2(-221.001007F, 136.231003F), new Vector2(-217.537994F, 132.348007F));
                    builder.AddCubicBezier(new Vector2(-225.042007F, 138.985001F), new Vector2(-230.429993F, 146.225998F), new Vector2(-232.399994F, 149.037994F));
                    builder.AddCubicBezier(new Vector2(-224.125F, 154.369995F), new Vector2(-215.237F, 158.671997F), new Vector2(-205.742996F, 161.917999F));
                    builder.AddCubicBezier(new Vector2(-204.065002F, 162.255005F), new Vector2(-190.473999F, 164.705002F), new Vector2(-184.242996F, 157.75F));
                    builder.AddCubicBezier(new Vector2(-183.197006F, 156.582001F), new Vector2(-182.406998F, 155.156998F), new Vector2(-181.854004F, 153.503998F));
                    builder.AddCubicBezier(new Vector2(-188.462006F, 155.957993F), new Vector2(-196.751999F, 154.473007F), new Vector2(-198.039001F, 154.214005F));
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
                    builder.BeginFigure(new Vector2(-184.173996F, 130.630997F));
                    builder.AddLine(new Vector2(-188.014999F, 119.280998F));
                    builder.AddCubicBezier(new Vector2(-191.964005F, 119.161003F), new Vector2(-195.806F, 119.880997F), new Vector2(-199.475998F, 121.162003F));
                    builder.AddCubicBezier(new Vector2(-197.735001F, 120.899002F), new Vector2(-195.968994F, 120.767998F), new Vector2(-194.177994F, 120.821999F));
                    builder.AddLine(new Vector2(-190.337006F, 132.171005F));
                    builder.AddCubicBezier(new Vector2(-185.966995F, 144.985001F), new Vector2(-185.990997F, 154.362F), new Vector2(-190.406998F, 159.291F));
                    builder.AddCubicBezier(new Vector2(-191.660004F, 160.690002F), new Vector2(-193.216995F, 161.694F), new Vector2(-194.908997F, 162.425995F));
                    builder.AddCubicBezier(new Vector2(-191.016998F, 162.005997F), new Vector2(-186.940002F, 160.761002F), new Vector2(-184.242996F, 157.75F));
                    builder.AddCubicBezier(new Vector2(-179.826996F, 152.820999F), new Vector2(-179.804001F, 143.445007F), new Vector2(-184.173996F, 130.630997F));
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
                    builder.BeginFigure(new Vector2(-123.946999F, 132.438004F));
                    builder.AddCubicBezier(new Vector2(-114.720001F, 132.847F), new Vector2(-106.864998F, 121.412003F), new Vector2(-105.933998F, 120.000999F));
                    builder.AddCubicBezier(new Vector2(-101.802002F, 111.360001F), new Vector2(-98.9059982F, 102.675003F), new Vector2(-97.0049973F, 94.0439987F));
                    builder.AddCubicBezier(new Vector2(-121.143997F, 85.3209991F), new Vector2(-140.294006F, 96.6719971F), new Vector2(-148.610001F, 103.167F));
                    builder.AddLine(new Vector2(-143.380997F, 113.489998F));
                    builder.AddCubicBezier(new Vector2(-137.283005F, 125.600998F), new Vector2(-130.563995F, 132.151993F), new Vector2(-123.946999F, 132.438004F));
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
                    builder.BeginFigure(new Vector2(-118.518997F, 91.0319977F));
                    builder.AddCubicBezier(new Vector2(-114.143997F, 91.3720016F), new Vector2(-109.528F, 92.3030014F), new Vector2(-104.709F, 94.0439987F));
                    builder.AddCubicBezier(new Vector2(-106.610001F, 102.675003F), new Vector2(-109.507004F, 111.360001F), new Vector2(-113.639F, 120.000999F));
                    builder.AddCubicBezier(new Vector2(-114.417999F, 121.181F), new Vector2(-120.044998F, 129.350006F), new Vector2(-127.262001F, 131.759995F));
                    builder.AddCubicBezier(new Vector2(-126.156998F, 132.153F), new Vector2(-125.050003F, 132.389999F), new Vector2(-123.946999F, 132.438004F));
                    builder.AddCubicBezier(new Vector2(-114.720001F, 132.847F), new Vector2(-106.864998F, 121.412003F), new Vector2(-105.933998F, 120.000999F));
                    builder.AddCubicBezier(new Vector2(-101.802002F, 111.360001F), new Vector2(-98.9059982F, 102.675003F), new Vector2(-97.0049973F, 94.0439987F));
                    builder.AddCubicBezier(new Vector2(-104.757004F, 91.2429962F), new Vector2(-111.989998F, 90.5189972F), new Vector2(-118.518997F, 91.0319977F));
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
                    builder.BeginFigure(new Vector2(-185.938004F, -28.5200005F));
                    builder.AddCubicBezier(new Vector2(-194.757004F, -49.5200005F), new Vector2(-219.016998F, -59.4300003F), new Vector2(-240.016998F, -50.6110001F));
                    builder.AddCubicBezier(new Vector2(-250.190002F, -46.3390007F), new Vector2(-258.089996F, -38.3610001F), new Vector2(-262.263F, -28.1469994F));
                    builder.AddCubicBezier(new Vector2(-266.436005F, -17.9330006F), new Vector2(-266.381012F, -6.70599985F), new Vector2(-262.109009F, 3.46700001F));
                    builder.AddCubicBezier(new Vector2(-257.837006F, 13.6400003F), new Vector2(-249.858994F, 21.5389996F), new Vector2(-239.645004F, 25.7119999F));
                    builder.AddCubicBezier(new Vector2(-234.600998F, 27.7730007F), new Vector2(-229.309006F, 28.802F), new Vector2(-224.020004F, 28.802F));
                    builder.AddCubicBezier(new Vector2(-218.598999F, 28.802F), new Vector2(-213.179993F, 27.7210007F), new Vector2(-208.031006F, 25.559F));
                    builder.AddCubicBezier(new Vector2(-187.031006F, 16.7399998F), new Vector2(-177.119995F, -7.51999998F), new Vector2(-185.938004F, -28.5200005F));
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
                    builder.BeginFigure(new Vector2(-185.697998F, -33.4900017F));
                    builder.AddCubicBezier(new Vector2(-177.524002F, -14.026F), new Vector2(-186.677994F, 8.38000011F), new Vector2(-206.141998F, 16.5540009F));
                    builder.AddCubicBezier(new Vector2(-225.606003F, 24.7280006F), new Vector2(-248.011002F, 15.5740004F), new Vector2(-256.184998F, -3.8900001F));
                    builder.AddCubicBezier(new Vector2(-264.359009F, -23.3540001F), new Vector2(-255.205994F, -45.7589989F), new Vector2(-235.742004F, -53.9329987F));
                    builder.AddCubicBezier(new Vector2(-216.278F, -62.1069984F), new Vector2(-193.871994F, -52.9539986F), new Vector2(-185.697998F, -33.4900017F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_116()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_117(), Geometry_118() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            CanvasGeometry Geometry_117()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-220.925995F, 23.3969994F));
                    builder.AddCubicBezier(new Vector2(-237.921997F, 23.3969994F), new Vector2(-253.156998F, 13.2720003F), new Vector2(-259.737F, -2.398F));
                    builder.AddCubicBezier(new Vector2(-268.720001F, -23.7900009F), new Vector2(-258.625F, -48.5019989F), new Vector2(-237.233002F, -57.4850006F));
                    builder.AddCubicBezier(new Vector2(-232.031998F, -59.6689987F), new Vector2(-226.556F, -60.7770004F), new Vector2(-220.957993F, -60.7770004F));
                    builder.AddCubicBezier(new Vector2(-203.962006F, -60.7770004F), new Vector2(-188.727005F, -50.651001F), new Vector2(-182.147003F, -34.980999F));
                    builder.AddCubicBezier(new Vector2(-177.794998F, -24.6189995F), new Vector2(-177.740005F, -13.1809998F), new Vector2(-181.990005F, -2.77699995F));
                    builder.AddCubicBezier(new Vector2(-186.240005F, 7.62699986F), new Vector2(-194.287994F, 15.7530003F), new Vector2(-204.651001F, 20.1049995F));
                    builder.AddCubicBezier(new Vector2(-209.852005F, 22.2889996F), new Vector2(-215.328003F, 23.3969994F), new Vector2(-220.925995F, 23.3969994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_118()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-220.957993F, -53.0730019F));
                    builder.AddCubicBezier(new Vector2(-225.526001F, -53.0730019F), new Vector2(-229.998993F, -52.1679993F), new Vector2(-234.251007F, -50.382F));
                    builder.AddCubicBezier(new Vector2(-251.725998F, -43.0439987F), new Vector2(-259.971985F, -22.8560009F), new Vector2(-252.634003F, -5.38100004F));
                    builder.AddCubicBezier(new Vector2(-247.257996F, 7.421F), new Vector2(-234.811996F, 15.6929998F), new Vector2(-220.925995F, 15.6929998F));
                    builder.AddCubicBezier(new Vector2(-216.358002F, 15.6929998F), new Vector2(-211.884995F, 14.7880001F), new Vector2(-207.632996F, 13.0019999F));
                    builder.AddCubicBezier(new Vector2(-199.167999F, 9.44699955F), new Vector2(-192.593994F, 2.80800009F), new Vector2(-189.121994F, -5.69099998F));
                    builder.AddCubicBezier(new Vector2(-185.649994F, -14.191F), new Vector2(-185.695007F, -23.5330009F), new Vector2(-189.25F, -31.9979992F));
                    builder.AddCubicBezier(new Vector2(-194.626007F, -44.7999992F), new Vector2(-207.072006F, -53.0730019F), new Vector2(-220.957993F, -53.0730019F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_119()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-224.565994F, -23.0259991F));
                    builder.AddLine(new Vector2(-239.889008F, -16.5919991F));
                    builder.AddCubicBezier(new Vector2(-242.427994F, -15.526F), new Vector2(-245.350006F, -16.7189999F), new Vector2(-246.416F, -19.2579994F));
                    builder.AddCubicBezier(new Vector2(-247.481995F, -21.7970009F), new Vector2(-246.289001F, -24.7199993F), new Vector2(-243.75F, -25.7859993F));
                    builder.AddLine(new Vector2(-228.425995F, -32.2200012F));
                    builder.AddCubicBezier(new Vector2(-225.886993F, -33.2859993F), new Vector2(-222.964996F, -32.0929985F), new Vector2(-221.899002F, -29.5540009F));
                    builder.AddCubicBezier(new Vector2(-220.832993F, -27.0149994F), new Vector2(-222.026993F, -24.0919991F), new Vector2(-224.565994F, -23.0259991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_120()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-205.809998F, -36.3100014F));
                    builder.AddCubicBezier(new Vector2(-204.744003F, -33.7709999F), new Vector2(-205.936996F, -30.8490009F), new Vector2(-208.475998F, -29.7830009F));
                    builder.AddCubicBezier(new Vector2(-211.014999F, -28.7169991F), new Vector2(-213.938004F, -29.9099998F), new Vector2(-215.003998F, -32.4490013F));
                    builder.AddCubicBezier(new Vector2(-216.070007F, -34.987999F), new Vector2(-214.876007F, -37.9109993F), new Vector2(-212.337006F, -38.9770012F));
                    builder.AddCubicBezier(new Vector2(-209.798004F, -40.0429993F), new Vector2(-206.876007F, -38.848999F), new Vector2(-205.809998F, -36.3100014F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_121()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-215.755997F, -4.19399977F));
                    builder.AddLine(new Vector2(-231.078995F, 2.24099994F));
                    builder.AddCubicBezier(new Vector2(-233.617996F, 3.30699992F), new Vector2(-236.541F, 2.11299992F), new Vector2(-237.606995F, -0.425999999F));
                    builder.AddCubicBezier(new Vector2(-238.673004F, -2.96499991F), new Vector2(-237.479004F, -5.88700008F), new Vector2(-234.940002F, -6.95300007F));
                    builder.AddLine(new Vector2(-219.617004F, -13.3879995F));
                    builder.AddCubicBezier(new Vector2(-217.078003F, -14.4540005F), new Vector2(-214.154999F, -13.2600002F), new Vector2(-213.089005F, -10.7209997F));
                    builder.AddCubicBezier(new Vector2(-212.022995F, -8.18200016F), new Vector2(-213.216995F, -5.26000023F), new Vector2(-215.755997F, -4.19399977F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_122()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-197.766006F, -17.1560001F));
                    builder.AddCubicBezier(new Vector2(-196.699997F, -14.6169996F), new Vector2(-197.893997F, -11.6949997F), new Vector2(-200.432999F, -10.6289997F));
                    builder.AddCubicBezier(new Vector2(-202.972F, -9.56299973F), new Vector2(-205.893997F, -10.7559996F), new Vector2(-206.960007F, -13.2950001F));
                    builder.AddCubicBezier(new Vector2(-208.026001F, -15.8339996F), new Vector2(-206.832993F, -18.757F), new Vector2(-204.294006F, -19.823F));
                    builder.AddCubicBezier(new Vector2(-201.755005F, -20.8889999F), new Vector2(-198.832001F, -19.6949997F), new Vector2(-197.766006F, -17.1560001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_123()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-400.345001F, -27.5669994F));
                    builder.AddCubicBezier(new Vector2(-401.365997F, -27.5669994F), new Vector2(-402.365997F, -28.0739994F), new Vector2(-402.951996F, -29.0009995F));
                    builder.AddCubicBezier(new Vector2(-403.862F, -30.4389992F), new Vector2(-403.43399F, -32.3429985F), new Vector2(-401.996002F, -33.2529984F));
                    builder.AddCubicBezier(new Vector2(-382.326996F, -45.7000008F), new Vector2(-377.903992F, -69.6070023F), new Vector2(-377.862F, -69.8470001F));
                    builder.AddCubicBezier(new Vector2(-377.56601F, -71.5210037F), new Vector2(-375.971008F, -72.6399994F), new Vector2(-374.295013F, -72.348999F));
                    builder.AddCubicBezier(new Vector2(-372.619995F, -72.0559998F), new Vector2(-371.498993F, -70.461998F), new Vector2(-371.790009F, -68.7870026F));
                    builder.AddCubicBezier(new Vector2(-371.979004F, -67.6989975F), new Vector2(-376.674011F, -41.9840012F), new Vector2(-398.700012F, -28.0450001F));
                    builder.AddCubicBezier(new Vector2(-399.210999F, -27.7210007F), new Vector2(-399.781006F, -27.5669994F), new Vector2(-400.345001F, -27.5669994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_124()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-407.56601F, -13.4779997F));
                    builder.AddCubicBezier(new Vector2(-408.553986F, -13.2200003F), new Vector2(-409.648987F, -13.4580002F), new Vector2(-410.450989F, -14.2060003F));
                    builder.AddCubicBezier(new Vector2(-411.695007F, -15.3669996F), new Vector2(-411.761993F, -17.3180008F), new Vector2(-410.601013F, -18.5620003F));
                    builder.AddCubicBezier(new Vector2(-394.720001F, -35.5789986F), new Vector2(-396.488007F, -59.8269997F), new Vector2(-396.507996F, -60.0699997F));
                    builder.AddCubicBezier(new Vector2(-396.644989F, -61.7649994F), new Vector2(-395.38501F, -63.2519989F), new Vector2(-393.690002F, -63.3919983F));
                    builder.AddCubicBezier(new Vector2(-391.996002F, -63.5320015F), new Vector2(-390.507996F, -62.2739983F), new Vector2(-390.365997F, -60.5800018F));
                    builder.AddCubicBezier(new Vector2(-390.273987F, -59.4799995F), new Vector2(-388.311005F, -33.4129982F), new Vector2(-406.095001F, -14.3570004F));
                    builder.AddCubicBezier(new Vector2(-406.507996F, -13.915F), new Vector2(-407.020996F, -13.6210003F), new Vector2(-407.56601F, -13.4779997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_125()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-117.611F, -149.878998F));
                    builder.AddCubicBezier(new Vector2(-137.261993F, -149.878998F), new Vector2(-152.354996F, -160.097F), new Vector2(-153.110992F, -160.617996F));
                    builder.AddCubicBezier(new Vector2(-154.511993F, -161.584F), new Vector2(-154.865005F, -163.503006F), new Vector2(-153.899002F, -164.904007F));
                    builder.AddCubicBezier(new Vector2(-152.932999F, -166.304993F), new Vector2(-151.014008F, -166.658005F), new Vector2(-149.613007F, -165.692001F));
                    builder.AddCubicBezier(new Vector2(-149.414993F, -165.557007F), new Vector2(-129.246994F, -151.975006F), new Vector2(-106.592003F, -157.302994F));
                    builder.AddCubicBezier(new Vector2(-104.932999F, -157.692993F), new Vector2(-103.276001F, -156.666F), new Vector2(-102.887001F, -155.009003F));
                    builder.AddCubicBezier(new Vector2(-102.498001F, -153.352005F), new Vector2(-103.524002F, -151.694F), new Vector2(-105.181F, -151.304001F));
                    builder.AddCubicBezier(new Vector2(-109.457001F, -150.298996F), new Vector2(-113.627998F, -149.878998F), new Vector2(-117.611F, -149.878998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_126()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-95.788002F, -137.656006F));
                    builder.AddCubicBezier(new Vector2(-114.581001F, -143.401001F), new Vector2(-126.027F, -157.587006F), new Vector2(-126.597F, -158.306F));
                    builder.AddCubicBezier(new Vector2(-127.654999F, -159.639008F), new Vector2(-127.431F, -161.576996F), new Vector2(-126.098F, -162.634995F));
                    builder.AddCubicBezier(new Vector2(-124.764999F, -163.692993F), new Vector2(-122.827003F, -163.468994F), new Vector2(-121.768997F, -162.134995F));
                    builder.AddCubicBezier(new Vector2(-121.619003F, -161.947998F), new Vector2(-106.303001F, -143.061996F), new Vector2(-83.0800018F, -141.535004F));
                    builder.AddCubicBezier(new Vector2(-81.3799973F, -141.423004F), new Vector2(-80.0950012F, -139.955002F), new Vector2(-80.2070007F, -138.257004F));
                    builder.AddCubicBezier(new Vector2(-80.3190002F, -136.559006F), new Vector2(-81.7870026F, -135.272995F), new Vector2(-83.4850006F, -135.384995F));
                    builder.AddCubicBezier(new Vector2(-87.8679962F, -135.673996F), new Vector2(-91.9789963F, -136.492004F), new Vector2(-95.788002F, -137.656006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_127()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-231.985992F, 155.880997F));
                    builder.AddCubicBezier(new Vector2(-232.470001F, 155.880997F), new Vector2(-232.960999F, 155.766998F), new Vector2(-233.419006F, 155.526001F));
                    builder.AddCubicBezier(new Vector2(-234.925003F, 154.733002F), new Vector2(-235.503998F, 152.869003F), new Vector2(-234.710999F, 151.363007F));
                    builder.AddCubicBezier(new Vector2(-234.528F, 151.016006F), new Vector2(-230.139008F, 142.759995F), new Vector2(-221.828995F, 134.403F));
                    builder.AddCubicBezier(new Vector2(-210.671997F, 123.183998F), new Vector2(-197.733994F, 117.205002F), new Vector2(-184.410995F, 117.112F));
                    builder.AddLine(new Vector2(-184.389008F, 117.112F));
                    builder.AddCubicBezier(new Vector2(-182.697006F, 117.112F), new Vector2(-181.319F, 118.476997F), new Vector2(-181.307007F, 120.171997F));
                    builder.AddCubicBezier(new Vector2(-181.294998F, 121.874001F), new Vector2(-182.664993F, 123.264F), new Vector2(-184.367004F, 123.276001F));
                    builder.AddCubicBezier(new Vector2(-212.746994F, 123.473F), new Vector2(-229.093994F, 153.925003F), new Vector2(-229.255997F, 154.233002F));
                    builder.AddCubicBezier(new Vector2(-229.807007F, 155.281006F), new Vector2(-230.878006F, 155.880997F), new Vector2(-231.985992F, 155.880997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_128()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-150.677994F, 109.119003F));
                    builder.AddCubicBezier(new Vector2(-151.464005F, 109.119003F), new Vector2(-152.25F, 108.820999F), new Vector2(-152.850998F, 108.223F));
                    builder.AddCubicBezier(new Vector2(-154.057999F, 107.023003F), new Vector2(-154.063004F, 105.070999F), new Vector2(-152.863007F, 103.863998F));
                    builder.AddCubicBezier(new Vector2(-143.468002F, 94.4169998F), new Vector2(-130.139999F, 89.3659973F), new Vector2(-114.318001F, 89.2559967F));
                    builder.AddCubicBezier(new Vector2(-102.536003F, 89.1839981F), new Vector2(-93.5650024F, 91.8209991F), new Vector2(-93.189003F, 91.9339981F));
                    builder.AddCubicBezier(new Vector2(-91.5589981F, 92.4229965F), new Vector2(-90.6340027F, 94.1409988F), new Vector2(-91.1230011F, 95.7710037F));
                    builder.AddCubicBezier(new Vector2(-91.6119995F, 97.4000015F), new Vector2(-93.3270035F, 98.3239975F), new Vector2(-94.9570007F, 97.8379974F));
                    builder.AddCubicBezier(new Vector2(-95.0400009F, 97.8130035F), new Vector2(-103.213997F, 95.4169998F), new Vector2(-113.792F, 95.4169998F));
                    builder.AddCubicBezier(new Vector2(-114.010002F, 95.4169998F), new Vector2(-114.227997F, 95.4179993F), new Vector2(-114.447998F, 95.4199982F));
                    builder.AddCubicBezier(new Vector2(-128.733002F, 95.5550003F), new Vector2(-140.186996F, 99.8580017F), new Vector2(-148.492996F, 108.209999F));
                    builder.AddCubicBezier(new Vector2(-149.095001F, 108.815002F), new Vector2(-149.886993F, 109.119003F), new Vector2(-150.677994F, 109.119003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_129()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-388.053009F, -21.4009991F));
                    builder.AddCubicBezier(new Vector2(-388.053009F, -21.4009991F), new Vector2(-359.734985F, -44.1080017F), new Vector2(-363.502991F, -65.9589996F));
                    builder.AddCubicBezier(new Vector2(-363.502991F, -65.9589996F), new Vector2(-388.053009F, -21.4009991F), new Vector2(-388.053009F, -21.4009991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_130()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-394.114014F, -10.6219997F));
                    builder.AddCubicBezier(new Vector2(-394.114014F, -10.6219997F), new Vector2(-372.460999F, -39.7529984F), new Vector2(-381.632996F, -59.9399986F));
                    builder.AddCubicBezier(new Vector2(-381.632996F, -59.9399986F), new Vector2(-394.114014F, -10.6219997F), new Vector2(-394.114014F, -10.6219997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_131()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-388.050995F, -18.3190002F));
                    builder.AddCubicBezier(new Vector2(-388.95401F, -18.3190002F), new Vector2(-389.847992F, -18.7140007F), new Vector2(-390.457001F, -19.4729996F));
                    builder.AddCubicBezier(new Vector2(-391.522003F, -20.8010006F), new Vector2(-391.30899F, -22.7399998F), new Vector2(-389.980988F, -23.8050003F));
                    builder.AddCubicBezier(new Vector2(-389.652008F, -24.0699997F), new Vector2(-363.131012F, -45.6669998F), new Vector2(-366.540009F, -65.4349976F));
                    builder.AddCubicBezier(new Vector2(-366.82901F, -67.1119995F), new Vector2(-365.70401F, -68.7060013F), new Vector2(-364.027008F, -68.9950027F));
                    builder.AddCubicBezier(new Vector2(-362.35199F, -69.2829971F), new Vector2(-360.756012F, -68.1589966F), new Vector2(-360.46701F, -66.4820023F));
                    builder.AddCubicBezier(new Vector2(-356.436005F, -43.1090012F), new Vector2(-384.911011F, -19.9710007F), new Vector2(-386.125F, -18.9969997F));
                    builder.AddCubicBezier(new Vector2(-386.694F, -18.5410004F), new Vector2(-387.375F, -18.3190002F), new Vector2(-388.050995F, -18.3190002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_132()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-393.333008F, -7.64099979F));
                    builder.AddCubicBezier(new Vector2(-394.205994F, -7.41300011F), new Vector2(-395.17099F, -7.56899977F), new Vector2(-395.951996F, -8.14900017F));
                    builder.AddCubicBezier(new Vector2(-397.317993F, -9.16399956F), new Vector2(-397.60199F, -11.0939999F), new Vector2(-396.587006F, -12.46F));
                    builder.AddCubicBezier(new Vector2(-396.334991F, -12.8000002F), new Vector2(-376.138F, -40.4029999F), new Vector2(-384.437988F, -58.6650009F));
                    builder.AddCubicBezier(new Vector2(-385.141998F, -60.2140007F), new Vector2(-384.457001F, -62.0419998F), new Vector2(-382.907013F, -62.7449989F));
                    builder.AddCubicBezier(new Vector2(-381.359009F, -63.4469986F), new Vector2(-379.531006F, -62.7639999F), new Vector2(-378.826996F, -61.2140007F));
                    builder.AddCubicBezier(new Vector2(-369.015015F, -39.6209984F), new Vector2(-390.712006F, -10.0319996F), new Vector2(-391.640015F, -8.78299999F));
                    builder.AddCubicBezier(new Vector2(-392.075012F, -8.19799995F), new Vector2(-392.678986F, -7.8119998F), new Vector2(-393.333008F, -7.64099979F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_133()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-107.637001F, -139.156998F));
                    builder.AddCubicBezier(new Vector2(-107.637001F, -139.156998F), new Vector2(-143.677002F, -134.837997F), new Vector2(-156.639008F, -152.828003F));
                    builder.AddCubicBezier(new Vector2(-156.639008F, -152.828003F), new Vector2(-107.637001F, -139.156998F), new Vector2(-107.637001F, -139.156998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_134()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-89.3850021F, -124.487F));
                    builder.AddCubicBezier(new Vector2(-89.3850021F, -124.487F), new Vector2(-125.112999F, -130.893997F), new Vector2(-132.248993F, -151.886993F));
                    builder.AddCubicBezier(new Vector2(-132.248993F, -151.886993F), new Vector2(-89.3850021F, -124.487F), new Vector2(-89.3850021F, -124.487F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_135()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-117.091003F, -135.602005F));
                    builder.AddCubicBezier(new Vector2(-129.283005F, -135.602005F), new Vector2(-149.580002F, -137.759003F), new Vector2(-159.139999F, -151.026001F));
                    builder.AddCubicBezier(new Vector2(-160.134995F, -152.406998F), new Vector2(-159.822006F, -154.332993F), new Vector2(-158.440994F, -155.328003F));
                    builder.AddCubicBezier(new Vector2(-157.059998F, -156.322998F), new Vector2(-155.134003F, -156.009995F), new Vector2(-154.139008F, -154.628998F));
                    builder.AddCubicBezier(new Vector2(-142.399002F, -138.335007F), new Vector2(-108.346001F, -142.175995F), new Vector2(-108.002998F, -142.216995F));
                    builder.AddCubicBezier(new Vector2(-106.314003F, -142.417007F), new Vector2(-104.778999F, -141.210999F), new Vector2(-104.578003F, -139.522003F));
                    builder.AddCubicBezier(new Vector2(-104.376999F, -137.832993F), new Vector2(-105.582001F, -136.298996F), new Vector2(-107.271004F, -136.097F));
                    builder.AddCubicBezier(new Vector2(-107.750999F, -136.039993F), new Vector2(-111.599998F, -135.602005F), new Vector2(-117.091003F, -135.602005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_136()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-99.4649963F, -123.850998F));
                    builder.AddCubicBezier(new Vector2(-111.124001F, -127.416F), new Vector2(-129.904999F, -135.412003F), new Vector2(-135.167007F, -150.895004F));
                    builder.AddCubicBezier(new Vector2(-135.714996F, -152.505997F), new Vector2(-134.852005F, -154.257004F), new Vector2(-133.240997F, -154.804993F));
                    builder.AddCubicBezier(new Vector2(-131.630005F, -155.352997F), new Vector2(-129.878998F, -154.490997F), new Vector2(-129.330994F, -152.878998F));
                    builder.AddCubicBezier(new Vector2(-122.867996F, -133.865005F), new Vector2(-89.1800003F, -127.581001F), new Vector2(-88.8399963F, -127.519997F));
                    builder.AddCubicBezier(new Vector2(-87.1660004F, -127.218002F), new Vector2(-86.052002F, -125.615997F), new Vector2(-86.3529968F, -123.942001F));
                    builder.AddCubicBezier(new Vector2(-86.6539993F, -122.267998F), new Vector2(-88.2539978F, -121.153999F), new Vector2(-89.9290009F, -121.454002F));
                    builder.AddCubicBezier(new Vector2(-90.4039993F, -121.539001F), new Vector2(-94.2139969F, -122.245003F), new Vector2(-99.4649963F, -123.850998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_137()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-241.531998F, 148.173004F));
                    builder.AddCubicBezier(new Vector2(-241.977005F, 148.173004F), new Vector2(-242.427994F, 148.076004F), new Vector2(-242.856003F, 147.871994F));
                    builder.AddCubicBezier(new Vector2(-244.391998F, 147.139008F), new Vector2(-245.044006F, 145.300003F), new Vector2(-244.311005F, 143.764008F));
                    builder.AddCubicBezier(new Vector2(-244.121002F, 143.365005F), new Vector2(-239.548996F, 133.891006F), new Vector2(-230.358002F, 124.582001F));
                    builder.AddCubicBezier(new Vector2(-218.031998F, 112.098999F), new Vector2(-203.255005F, 105.963997F), new Vector2(-187.634003F, 106.834999F));
                    builder.AddCubicBezier(new Vector2(-185.934998F, 106.93F), new Vector2(-184.632996F, 108.385002F), new Vector2(-184.727997F, 110.084F));
                    builder.AddCubicBezier(new Vector2(-184.822998F, 111.783997F), new Vector2(-186.283997F, 113.082001F), new Vector2(-187.977005F, 112.988998F));
                    builder.AddCubicBezier(new Vector2(-201.977997F, 112.205002F), new Vector2(-214.766006F, 117.565002F), new Vector2(-225.972F, 128.912994F));
                    builder.AddCubicBezier(new Vector2(-234.440994F, 137.490005F), new Vector2(-238.705994F, 146.328995F), new Vector2(-238.748001F, 146.417007F));
                    builder.AddCubicBezier(new Vector2(-239.276001F, 147.524994F), new Vector2(-240.380997F, 148.173004F), new Vector2(-241.531998F, 148.173004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_138()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-155.628006F, 99.4810028F));
                    builder.AddCubicBezier(new Vector2(-156.348999F, 99.4810028F), new Vector2(-157.074005F, 99.2289963F), new Vector2(-157.658997F, 98.7160034F));
                    builder.AddCubicBezier(new Vector2(-158.938995F, 97.5940018F), new Vector2(-159.065994F, 95.6470032F), new Vector2(-157.944F, 94.3669968F));
                    builder.AddCubicBezier(new Vector2(-147.626999F, 82.6009979F), new Vector2(-132.899994F, 76.3499985F), new Vector2(-115.358002F, 76.2900009F));
                    builder.AddLine(new Vector2(-115.100998F, 76.2900009F));
                    builder.AddCubicBezier(new Vector2(-102.146004F, 76.2900009F), new Vector2(-92.3079987F, 79.6169968F), new Vector2(-91.8929977F, 79.7590027F));
                    builder.AddCubicBezier(new Vector2(-90.2829971F, 80.3119965F), new Vector2(-89.4260025F, 82.064003F), new Vector2(-89.9789963F, 83.6740036F));
                    builder.AddCubicBezier(new Vector2(-90.5309982F, 85.2829971F), new Vector2(-92.2819977F, 86.1409988F), new Vector2(-93.8919983F, 85.5889969F));
                    builder.AddCubicBezier(new Vector2(-93.9860001F, 85.5569992F), new Vector2(-103.450996F, 82.3830032F), new Vector2(-115.524002F, 82.4540024F));
                    builder.AddCubicBezier(new Vector2(-131.386993F, 82.5510025F), new Vector2(-144.100006F, 87.927002F), new Vector2(-153.309998F, 98.4309998F));
                    builder.AddCubicBezier(new Vector2(-153.919006F, 99.125F), new Vector2(-154.770996F, 99.4810028F), new Vector2(-155.628006F, 99.4810028F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_139()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-294.865997F, 70.5289993F));
                    builder.AddCubicBezier(new Vector2(-296.203003F, 70.5289993F), new Vector2(-297.434998F, 69.6520004F), new Vector2(-297.825012F, 68.302002F));
                    builder.AddCubicBezier(new Vector2(-298.296997F, 66.6669998F), new Vector2(-297.354004F, 64.9580002F), new Vector2(-295.718994F, 64.4860001F));
                    builder.AddCubicBezier(new Vector2(-295.410004F, 64.3970032F), new Vector2(-264.411987F, 55.4020004F), new Vector2(-226.464005F, 41.105999F));
                    builder.AddCubicBezier(new Vector2(-191.539001F, 27.948F), new Vector2(-143.419998F, 7.48600006F), new Vector2(-112.513F, -15.2790003F));
                    builder.AddCubicBezier(new Vector2(-111.141998F, -16.2889996F), new Vector2(-109.213997F, -15.9949999F), new Vector2(-108.204002F, -14.625F));
                    builder.AddCubicBezier(new Vector2(-107.195F, -13.2550001F), new Vector2(-107.487F, -11.3260002F), new Vector2(-108.857002F, -10.3170004F));
                    builder.AddCubicBezier(new Vector2(-140.341003F, 12.8730001F), new Vector2(-189.033997F, 33.5929985F), new Vector2(-224.337997F, 46.8909988F));
                    builder.AddCubicBezier(new Vector2(-262.505005F, 61.2680016F), new Vector2(-293.697998F, 70.3170013F), new Vector2(-294.009003F, 70.4069977F));
                    builder.AddCubicBezier(new Vector2(-294.295013F, 70.4889984F), new Vector2(-294.583008F, 70.5289993F), new Vector2(-294.865997F, 70.5289993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_140()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-289.075012F, 84.3199997F));
                    builder.AddCubicBezier(new Vector2(-290.411987F, 84.3199997F), new Vector2(-291.644012F, 83.4430008F), new Vector2(-292.033997F, 82.0930023F));
                    builder.AddCubicBezier(new Vector2(-292.506012F, 80.4580002F), new Vector2(-291.562988F, 78.7490005F), new Vector2(-289.928009F, 78.2770004F));
                    builder.AddCubicBezier(new Vector2(-289.618988F, 78.1880035F), new Vector2(-258.621002F, 69.1930008F), new Vector2(-220.673004F, 54.8969994F));
                    builder.AddCubicBezier(new Vector2(-185.748001F, 41.7400017F), new Vector2(-137.628006F, 21.2770004F), new Vector2(-106.721001F, -1.48800004F));
                    builder.AddCubicBezier(new Vector2(-105.349998F, -2.49799991F), new Vector2(-103.421997F, -2.20499992F), new Vector2(-102.412003F, -0.834999979F));
                    builder.AddCubicBezier(new Vector2(-101.403F, 0.536000013F), new Vector2(-101.695999F, 2.46499991F), new Vector2(-103.066002F, 3.47399998F));
                    builder.AddCubicBezier(new Vector2(-134.550003F, 26.6630001F), new Vector2(-183.242996F, 47.3839989F), new Vector2(-218.546997F, 60.6819992F));
                    builder.AddCubicBezier(new Vector2(-256.713989F, 75.0589981F), new Vector2(-287.907013F, 84.1080017F), new Vector2(-288.217987F, 84.197998F));
                    builder.AddCubicBezier(new Vector2(-288.503998F, 84.2799988F), new Vector2(-288.791992F, 84.3199997F), new Vector2(-289.075012F, 84.3199997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_141()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-185.473999F, 65.5220032F));
                    builder.AddCubicBezier(new Vector2(-185.473999F, 65.5220032F), new Vector2(-153.117004F, 51.6549988F), new Vector2(-131.544998F, 110.206001F));
                    builder.AddCubicBezier(new Vector2(-131.544998F, 110.206001F), new Vector2(-123.839996F, 131.778F), new Vector2(-106.890999F, 128.695999F));
                    builder.AddCubicBezier(new Vector2(-106.890999F, 128.695999F), new Vector2(-133.210999F, 156.095001F), new Vector2(-158.957001F, 91.163002F));
                    builder.AddCubicBezier(new Vector2(-158.957001F, 91.163002F), new Vector2(-166.214005F, 70.9150009F), new Vector2(-185.473999F, 65.5220032F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_142()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-410.105011F, -157.268005F));
                    builder.AddCubicBezier(new Vector2(-410.105011F, -157.268005F), new Vector2(-414.826996F, -151.192001F), new Vector2(-415.885986F, -140.414001F));
                    builder.AddCubicBezier(new Vector2(-416.627991F, -132.860992F), new Vector2(-415.135986F, -125.249001F), new Vector2(-411.924011F, -118.373001F));
                    builder.AddCubicBezier(new Vector2(-399.988007F, -92.8180008F), new Vector2(-384.002991F, -94.098999F), new Vector2(-376.05899F, -94.3119965F));
                    builder.AddCubicBezier(new Vector2(-376.05899F, -94.3119965F), new Vector2(-392.052002F, -140.485992F), new Vector2(-392.410004F, -141.315002F));
                    builder.AddCubicBezier(new Vector2(-392.768005F, -142.143997F), new Vector2(-410.105011F, -157.268005F), new Vector2(-410.105011F, -157.268005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_143()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_144(), Geometry_145() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head Offset:<292.928, 119.112>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_144()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-379.647003F, -90.3840027F));
                    builder.AddLine(new Vector2(-379.64801F, -90.3840027F));
                    builder.AddCubicBezier(new Vector2(-389.71701F, -90.3840027F), new Vector2(-404.378998F, -93.1159973F), new Vector2(-415.414001F, -116.741997F));
                    builder.AddCubicBezier(new Vector2(-419.018005F, -124.458F), new Vector2(-420.506989F, -132.774002F), new Vector2(-419.718994F, -140.791F));
                    builder.AddCubicBezier(new Vector2(-418.563995F, -152.542007F), new Vector2(-413.367004F, -159.348007F), new Vector2(-413.147003F, -159.632004F));
                    builder.AddCubicBezier(new Vector2(-412.497009F, -160.468994F), new Vector2(-411.531006F, -161.001007F), new Vector2(-410.476013F, -161.102997F));
                    builder.AddCubicBezier(new Vector2(-409.420013F, -161.203995F), new Vector2(-408.371002F, -160.867996F), new Vector2(-407.572998F, -160.171005F));
                    builder.AddCubicBezier(new Vector2(-407.528992F, -160.132996F), new Vector2(-403.175995F, -156.335007F), new Vector2(-398.834991F, -152.483994F));
                    builder.AddCubicBezier(new Vector2(-389.436005F, -144.145996F), new Vector2(-389.294006F, -143.817001F), new Vector2(-388.872986F, -142.841003F));
                    builder.AddCubicBezier(new Vector2(-388.513F, -142.005997F), new Vector2(-378.408997F, -112.867996F), new Vector2(-372.419006F, -95.572998F));
                    builder.AddCubicBezier(new Vector2(-372.016998F, -94.413002F), new Vector2(-372.191986F, -93.1299973F), new Vector2(-372.890991F, -92.1200027F));
                    builder.AddCubicBezier(new Vector2(-373.589996F, -91.1100006F), new Vector2(-374.729004F, -90.4940033F), new Vector2(-375.955994F, -90.4609985F));
                    builder.AddLine(new Vector2(-376.679993F, -90.4400024F));
                    builder.AddCubicBezier(new Vector2(-377.563995F, -90.4140015F), new Vector2(-378.565002F, -90.3840027F), new Vector2(-379.647003F, -90.3840027F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head Offset:<292.928, 119.112>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_145()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-409.095001F, -151.264999F));
                    builder.AddCubicBezier(new Vector2(-410.255005F, -148.725006F), new Vector2(-411.572998F, -144.917007F), new Vector2(-412.052002F, -140.037994F));
                    builder.AddCubicBezier(new Vector2(-412.704987F, -133.395996F), new Vector2(-411.45401F, -126.468002F), new Vector2(-408.43399F, -120.002998F));
                    builder.AddCubicBezier(new Vector2(-399.984009F, -101.912003F), new Vector2(-389.795013F, -98.5100021F), new Vector2(-381.458008F, -98.1279984F));
                    builder.AddCubicBezier(new Vector2(-387.162994F, -114.591003F), new Vector2(-394.394989F, -135.425995F), new Vector2(-395.776001F, -139.302994F));
                    builder.AddCubicBezier(new Vector2(-397.355988F, -140.867004F), new Vector2(-403.096985F, -145.998001F), new Vector2(-409.095001F, -151.264999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_146()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-403.812012F, -118.461998F));
                    builder.AddCubicBezier(new Vector2(-406.832001F, -124.926003F), new Vector2(-408.082001F, -131.854004F), new Vector2(-407.429993F, -138.496994F));
                    builder.AddCubicBezier(new Vector2(-407.054993F, -142.309998F), new Vector2(-406.167999F, -145.457993F), new Vector2(-405.243988F, -147.869995F));
                    builder.AddCubicBezier(new Vector2(-406.489014F, -148.972F), new Vector2(-407.783997F, -150.113007F), new Vector2(-409.093994F, -151.264008F));
                    builder.AddCubicBezier(new Vector2(-410.256012F, -148.720993F), new Vector2(-411.571991F, -144.914993F), new Vector2(-412.052002F, -140.037994F));
                    builder.AddCubicBezier(new Vector2(-412.70401F, -133.395004F), new Vector2(-411.45401F, -126.467003F), new Vector2(-408.43399F, -120.002998F));
                    builder.AddCubicBezier(new Vector2(-401.537994F, -105.237999F), new Vector2(-393.501007F, -100.338997F), new Vector2(-386.566986F, -98.7799988F));
                    builder.AddCubicBezier(new Vector2(-392.29599F, -101.373001F), new Vector2(-398.404999F, -106.885002F), new Vector2(-403.812012F, -118.461998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_147()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-187.651993F, -250.931F));
                    builder.AddCubicBezier(new Vector2(-187.651993F, -250.931F), new Vector2(-180.007996F, -250.046997F), new Vector2(-171.570999F, -243.257004F));
                    builder.AddCubicBezier(new Vector2(-165.658997F, -238.498993F), new Vector2(-161.268997F, -232.102997F), new Vector2(-158.608002F, -224.994995F));
                    builder.AddCubicBezier(new Vector2(-148.720993F, -198.580002F), new Vector2(-160.826996F, -188.063995F), new Vector2(-166.542007F, -182.542007F));
                    builder.AddCubicBezier(new Vector2(-166.542007F, -182.542007F), new Vector2(-188.311005F, -226.291F), new Vector2(-188.651993F, -227.126007F));
                    builder.AddCubicBezier(new Vector2(-188.992996F, -227.960999F), new Vector2(-187.651993F, -250.931F), new Vector2(-187.651993F, -250.931F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_148()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_149(), Geometry_150() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head Offset:<292.928, 119.112>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_149()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-166.542007F, -178.690002F));
                    builder.AddCubicBezier(new Vector2(-166.759003F, -178.690002F), new Vector2(-166.977005F, -178.709F), new Vector2(-167.195007F, -178.746002F));
                    builder.AddCubicBezier(new Vector2(-168.404999F, -178.953995F), new Vector2(-169.442993F, -179.727005F), new Vector2(-169.990005F, -180.826004F));
                    builder.AddCubicBezier(new Vector2(-178.143997F, -197.212006F), new Vector2(-191.873993F, -224.828003F), new Vector2(-192.218002F, -225.669998F));
                    builder.AddCubicBezier(new Vector2(-192.619995F, -226.654007F), new Vector2(-192.755005F, -226.985001F), new Vector2(-192.126999F, -239.533997F));
                    builder.AddCubicBezier(new Vector2(-191.837006F, -245.330002F), new Vector2(-191.501007F, -251.097F), new Vector2(-191.498001F, -251.154999F));
                    builder.AddCubicBezier(new Vector2(-191.436005F, -252.212997F), new Vector2(-190.940994F, -253.197998F), new Vector2(-190.130005F, -253.880005F));
                    builder.AddCubicBezier(new Vector2(-189.319F, -254.561996F), new Vector2(-188.263F, -254.878998F), new Vector2(-187.210007F, -254.757004F));
                    builder.AddCubicBezier(new Vector2(-186.852997F, -254.716003F), new Vector2(-178.354996F, -253.660995F), new Vector2(-169.156006F, -246.257996F));
                    builder.AddCubicBezier(new Vector2(-162.880997F, -241.207993F), new Vector2(-157.987F, -234.322006F), new Vector2(-155.001007F, -226.345993F));
                    builder.AddCubicBezier(new Vector2(-144.522003F, -198.350006F), new Vector2(-157.233994F, -186.141006F), new Vector2(-163.343002F, -180.274002F));
                    builder.AddLine(new Vector2(-163.865005F, -179.772003F));
                    builder.AddCubicBezier(new Vector2(-164.589005F, -179.072006F), new Vector2(-165.552002F, -178.690002F), new Vector2(-166.542007F, -178.690002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head Offset:<292.928, 119.112>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_150()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-184.858994F, -228.121002F));
                    builder.AddCubicBezier(new Vector2(-183.057999F, -224.421005F), new Vector2(-173.244995F, -204.666F), new Vector2(-165.485001F, -189.065994F));
                    builder.AddCubicBezier(new Vector2(-160.253006F, -194.882004F), new Vector2(-155.029007F, -204.444F), new Vector2(-162.216003F, -223.645004F));
                    builder.AddCubicBezier(new Vector2(-164.718002F, -230.328003F), new Vector2(-168.787994F, -236.070999F), new Vector2(-173.987F, -240.255997F));
                    builder.AddCubicBezier(new Vector2(-177.809998F, -243.332993F), new Vector2(-181.449005F, -245.059006F), new Vector2(-184.072998F, -246.007996F));
                    builder.AddCubicBezier(new Vector2(-184.511993F, -238.037003F), new Vector2(-184.869003F, -230.343994F), new Vector2(-184.858994F, -228.121002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_151()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-184.072998F, -241.386002F));
                    builder.AddCubicBezier(new Vector2(-181.449005F, -240.436996F), new Vector2(-177.809998F, -238.710007F), new Vector2(-173.987F, -235.634003F));
                    builder.AddCubicBezier(new Vector2(-168.787994F, -231.449005F), new Vector2(-164.718002F, -225.703995F), new Vector2(-162.216003F, -219.022003F));
                    builder.AddCubicBezier(new Vector2(-160.106003F, -213.384995F), new Vector2(-159.087006F, -208.598007F), new Vector2(-158.802994F, -204.473007F));
                    builder.AddCubicBezier(new Vector2(-158.425995F, -209.516006F), new Vector2(-159.263F, -215.757004F), new Vector2(-162.216003F, -223.645004F));
                    builder.AddCubicBezier(new Vector2(-164.718002F, -230.326996F), new Vector2(-168.787994F, -236.072006F), new Vector2(-173.987F, -240.257004F));
                    builder.AddCubicBezier(new Vector2(-177.809998F, -243.332993F), new Vector2(-181.449005F, -245.059998F), new Vector2(-184.072998F, -246.009003F));
                    builder.AddCubicBezier(new Vector2(-184.511993F, -238.026001F), new Vector2(-184.869995F, -230.320999F), new Vector2(-184.858994F, -228.110992F));
                    builder.AddCubicBezier(new Vector2(-184.824005F, -228.039001F), new Vector2(-184.779007F, -227.949005F), new Vector2(-184.737F, -227.862F));
                    builder.AddCubicBezier(new Vector2(-184.597F, -231.371002F), new Vector2(-184.352005F, -236.319F), new Vector2(-184.072998F, -241.386002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_152()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-194.145996F, -255.315002F));
                    builder.AddCubicBezier(new Vector2(-205.832001F, -268.618988F), new Vector2(-221.899002F, -276.765015F), new Vector2(-238.959F, -281.601013F));
                    builder.AddCubicBezier(new Vector2(-300.05899F, -298.921997F), new Vector2(-365.592987F, -271.402008F), new Vector2(-396.007996F, -215.651001F));
                    builder.AddCubicBezier(new Vector2(-404.5F, -200.085007F), new Vector2(-409.93399F, -182.910004F), new Vector2(-408.618011F, -165.251999F));
                    builder.AddCubicBezier(new Vector2(-404.334015F, -107.773003F), new Vector2(-357.416992F, -62.0839996F), new Vector2(-299.841003F, -59.4090004F));
                    builder.AddCubicBezier(new Vector2(-283.200989F, -58.6360016F), new Vector2(-264.393005F, -61.2739983F), new Vector2(-243.75F, -69.5439987F));
                    builder.AddLine(new Vector2(-243.735001F, -69.5110016F));
                    builder.AddCubicBezier(new Vector2(-243.313995F, -69.6880035F), new Vector2(-242.910004F, -69.8730011F), new Vector2(-242.494003F, -70.052002F));
                    builder.AddCubicBezier(new Vector2(-242.074997F, -70.223999F), new Vector2(-241.660004F, -70.3830032F), new Vector2(-241.238998F, -70.5599976F));
                    builder.AddLine(new Vector2(-241.253006F, -70.5930023F));
                    builder.AddCubicBezier(new Vector2(-220.893997F, -79.5410004F), new Vector2(-205.841003F, -91.1220016F), new Vector2(-194.742004F, -103.543999F));
                    builder.AddCubicBezier(new Vector2(-156.337997F, -146.524002F), new Vector2(-156.108002F, -212.011002F), new Vector2(-194.145996F, -255.315002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_153()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_154(), Geometry_155() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head Offset:<292.928, 119.112>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_154()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-294.302002F, -54.6580009F));
                    builder.AddCubicBezier(new Vector2(-296.216003F, -54.6580009F), new Vector2(-298.152008F, -54.7029991F), new Vector2(-300.056F, -54.7910004F));
                    builder.AddCubicBezier(new Vector2(-329.027008F, -56.137001F), new Vector2(-356.509003F, -68.0960007F), new Vector2(-377.437988F, -88.4660034F));
                    builder.AddCubicBezier(new Vector2(-398.360992F, -108.830002F), new Vector2(-411.071991F, -135.977005F), new Vector2(-413.227997F, -164.908005F));
                    builder.AddCubicBezier(new Vector2(-414.483002F, -181.738998F), new Vector2(-410.053986F, -199.554993F), new Vector2(-400.06601F, -217.863998F));
                    builder.AddCubicBezier(new Vector2(-387.842987F, -240.268997F), new Vector2(-369.688995F, -258.954987F), new Vector2(-347.56601F, -271.901001F));
                    builder.AddCubicBezier(new Vector2(-325.803009F, -284.635986F), new Vector2(-301.036011F, -291.368011F), new Vector2(-275.942993F, -291.368011F));
                    builder.AddCubicBezier(new Vector2(-263.018005F, -291.368011F), new Vector2(-250.151001F, -289.578003F), new Vector2(-237.699005F, -286.048004F));
                    builder.AddCubicBezier(new Vector2(-217.632996F, -280.359985F), new Vector2(-201.811996F, -271.04599F), new Vector2(-190.673996F, -258.365997F));
                    builder.AddCubicBezier(new Vector2(-171.528F, -236.570007F), new Vector2(-161.044998F, -208.485992F), new Vector2(-161.156006F, -179.289993F));
                    builder.AddCubicBezier(new Vector2(-161.266998F, -150.085007F), new Vector2(-171.970001F, -122.091003F), new Vector2(-191.294998F, -100.463997F));
                    builder.AddCubicBezier(new Vector2(-203.832993F, -86.4319992F), new Vector2(-219.832993F, -75.0390015F), new Vector2(-238.854996F, -66.5979996F));
                    builder.AddCubicBezier(new Vector2(-239.044006F, -66.4850006F), new Vector2(-239.242996F, -66.3840027F), new Vector2(-239.451004F, -66.2969971F));
                    builder.AddCubicBezier(new Vector2(-239.718994F, -66.1839981F), new Vector2(-239.985001F, -66.0780029F), new Vector2(-240.251007F, -65.9720001F));
                    builder.AddCubicBezier(new Vector2(-240.401993F, -65.9120026F), new Vector2(-240.552994F, -65.8509979F), new Vector2(-240.705002F, -65.7890015F));
                    builder.AddCubicBezier(new Vector2(-240.854996F, -65.723999F), new Vector2(-241.003998F, -65.6600037F), new Vector2(-241.151993F, -65.5940018F));
                    builder.AddCubicBezier(new Vector2(-241.414001F, -65.4779968F), new Vector2(-241.675995F, -65.362999F), new Vector2(-241.944F, -65.25F));
                    builder.AddCubicBezier(new Vector2(-242.153F, -65.1620026F), new Vector2(-242.363998F, -65.0910034F), new Vector2(-242.576996F, -65.0360031F));
                    builder.AddCubicBezier(new Vector2(-259.944F, -58.1500015F), new Vector2(-277.343994F, -54.6580009F), new Vector2(-294.302002F, -54.6580009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head Offset:<292.928, 119.112>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_155()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-275.942993F, -282.122986F));
                    builder.AddCubicBezier(new Vector2(-324.38501F, -282.122986F), new Vector2(-368.837006F, -255.804001F), new Vector2(-391.950012F, -213.436996F));
                    builder.AddCubicBezier(new Vector2(-401.071014F, -196.716995F), new Vector2(-405.127991F, -180.619995F), new Vector2(-404.007996F, -165.595001F));
                    builder.AddCubicBezier(new Vector2(-399.882996F, -110.264F), new Vector2(-355.01001F, -66.598999F), new Vector2(-299.627014F, -64.026001F));
                    builder.AddCubicBezier(new Vector2(-297.86499F, -63.9440002F), new Vector2(-296.072998F, -63.9029999F), new Vector2(-294.302002F, -63.9029999F));
                    builder.AddCubicBezier(new Vector2(-278.348999F, -63.9029999F), new Vector2(-261.919006F, -67.2440033F), new Vector2(-245.468994F, -73.8349991F));
                    builder.AddCubicBezier(new Vector2(-245.326996F, -73.8919983F), new Vector2(-245.182007F, -73.9420013F), new Vector2(-245.037994F, -73.9840012F));
                    builder.AddCubicBezier(new Vector2(-244.987F, -74.0059967F), new Vector2(-244.938004F, -74.0289993F), new Vector2(-244.886993F, -74.0510025F));
                    builder.AddCubicBezier(new Vector2(-244.699005F, -74.1340027F), new Vector2(-244.509995F, -74.2170029F), new Vector2(-244.320007F, -74.2990036F));
                    builder.AddLine(new Vector2(-244.248001F, -74.3290024F));
                    builder.AddCubicBezier(new Vector2(-244.057007F, -74.4069977F), new Vector2(-243.865997F, -74.4830017F), new Vector2(-243.675995F, -74.5589981F));
                    builder.AddCubicBezier(new Vector2(-243.623993F, -74.5800018F), new Vector2(-243.572006F, -74.5999985F), new Vector2(-243.520004F, -74.6210022F));
                    builder.AddCubicBezier(new Vector2(-243.389008F, -74.6949997F), new Vector2(-243.253006F, -74.7630005F), new Vector2(-243.112F, -74.8249969F));
                    builder.AddCubicBezier(new Vector2(-225.072006F, -82.7539978F), new Vector2(-209.957993F, -93.4530029F), new Vector2(-198.188995F, -106.624001F));
                    builder.AddCubicBezier(new Vector2(-161.248001F, -147.966995F), new Vector2(-161.001999F, -210.578995F), new Vector2(-197.619003F, -252.264999F));
                    builder.AddCubicBezier(new Vector2(-207.561996F, -263.584991F), new Vector2(-221.895996F, -271.958008F), new Vector2(-240.220001F, -277.153015F));
                    builder.AddCubicBezier(new Vector2(-251.852005F, -280.450012F), new Vector2(-263.869995F, -282.122986F), new Vector2(-275.942993F, -282.122986F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_156()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-342.950012F, -269.171997F));
                    builder.AddCubicBezier(new Vector2(-361.455994F, -257.15799F), new Vector2(-377.216003F, -240.595993F), new Vector2(-388.303009F, -220.272995F));
                    builder.AddCubicBezier(new Vector2(-396.795013F, -204.707001F), new Vector2(-402.230011F, -187.531998F), new Vector2(-400.914001F, -169.873993F));
                    builder.AddCubicBezier(new Vector2(-396.630005F, -112.394997F), new Vector2(-349.713013F, -66.7060013F), new Vector2(-292.136993F, -64.0309982F));
                    builder.AddCubicBezier(new Vector2(-282.606995F, -63.5880013F), new Vector2(-272.364014F, -64.2720032F), new Vector2(-261.473999F, -66.4840012F));
                    builder.AddCubicBezier(new Vector2(-248.287994F, -69.8990021F), new Vector2(-237.483994F, -73.8300018F), new Vector2(-230.350998F, -76.7200012F));
                    builder.AddCubicBezier(new Vector2(-230.018005F, -76.6279984F), new Vector2(-229.692993F, -76.5329971F), new Vector2(-229.358994F, -76.4410019F));
                    builder.AddCubicBezier(new Vector2(-400.132996F, -123.213997F), new Vector2(-331.516998F, -262.858002F), new Vector2(-323.359009F, -278.23999F));
                    builder.AddCubicBezier(new Vector2(-330.115997F, -275.744995F), new Vector2(-336.658997F, -272.694F), new Vector2(-342.950012F, -269.171997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_157()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-368.061005F, -189.485001F));
                    builder.AddLine(new Vector2(-354.317993F, -201.492004F));
                    builder.AddCubicBezier(new Vector2(-371.286011F, -213.292007F), new Vector2(-377.65799F, -227.563004F), new Vector2(-379.630005F, -233.223007F));
                    builder.AddCubicBezier(new Vector2(-383.915009F, -227.917007F), new Vector2(-387.808014F, -222.229004F), new Vector2(-391.266998F, -216.195999F));
                    builder.AddCubicBezier(new Vector2(-385.68399F, -205.156998F), new Vector2(-368.061005F, -189.485001F), new Vector2(-368.061005F, -189.485001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_158()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-256.817993F, -244.164001F));
                    builder.AddLine(new Vector2(-241.056F, -241.404999F));
                    builder.AddCubicBezier(new Vector2(-241.056F, -241.404999F), new Vector2(-237.664001F, -265.487F), new Vector2(-242.235992F, -278.483002F));
                    builder.AddCubicBezier(new Vector2(-248.335999F, -280.096008F), new Vector2(-254.483002F, -281.248993F), new Vector2(-260.638F, -281.955994F));
                    builder.AddCubicBezier(new Vector2(-258.479004F, -274.544006F), new Vector2(-253.507004F, -255.197998F), new Vector2(-256.817993F, -244.164001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_159()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-362.667999F, -188.714005F));
                    builder.AddCubicBezier(new Vector2(-371.819F, -197.865005F), new Vector2(-379.27301F, -211.264008F), new Vector2(-382.505005F, -217.559006F));
                    builder.AddCubicBezier(new Vector2(-383.618011F, -219.725998F), new Vector2(-383.63501F, -222.283997F), new Vector2(-382.545013F, -224.462997F));
                    builder.AddLine(new Vector2(-379.617004F, -230.317001F));
                    builder.AddLine(new Vector2(-380.515015F, -232.112F));
                    builder.AddCubicBezier(new Vector2(-383.720001F, -228.054001F), new Vector2(-386.695007F, -223.776001F), new Vector2(-389.429993F, -219.298996F));
                    builder.AddCubicBezier(new Vector2(-383.942993F, -204.677002F), new Vector2(-362.667999F, -188.714005F), new Vector2(-362.667999F, -188.714005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_160()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-249.151001F, -269.990997F));
                    builder.AddCubicBezier(new Vector2(-245.917999F, -261.015991F), new Vector2(-241.287994F, -245.035995F), new Vector2(-245.565994F, -236.479996F));
                    builder.AddCubicBezier(new Vector2(-245.565994F, -236.479996F), new Vector2(-236.572998F, -254.488998F), new Vector2(-243.242004F, -278.75F));
                    builder.AddCubicBezier(new Vector2(-248.694F, -280.144989F), new Vector2(-254.182999F, -281.167999F), new Vector2(-259.678986F, -281.841003F));
                    builder.AddLine(new Vector2(-257.121002F, -280.135986F));
                    builder.AddCubicBezier(new Vector2(-253.449005F, -277.687988F), new Vector2(-250.645996F, -274.143005F), new Vector2(-249.151001F, -269.990997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_161()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-295.313995F, -91.7949982F));
                    builder.AddCubicBezier(new Vector2(-267.675995F, -93.1279984F), new Vector2(-241.339005F, -104.188004F), new Vector2(-221.035004F, -122.987F));
                    builder.AddCubicBezier(new Vector2(-199.384003F, -143.033005F), new Vector2(-178.296005F, -174.276993F), new Vector2(-196.048996F, -211.839996F));
                    builder.AddCubicBezier(new Vector2(-196.048996F, -211.839996F), new Vector2(-221.880005F, -264.968994F), new Vector2(-306.645996F, -232.841995F));
                    builder.AddCubicBezier(new Vector2(-306.645996F, -232.841995F), new Vector2(-309.092987F, -231.951996F), new Vector2(-310.265015F, -231.436005F));
                    builder.AddCubicBezier(new Vector2(-311.45401F, -230.960999F), new Vector2(-313.803009F, -229.837006F), new Vector2(-313.803009F, -229.837006F));
                    builder.AddCubicBezier(new Vector2(-396.09201F, -191.811996F), new Vector2(-376.246002F, -136.169006F), new Vector2(-376.246002F, -136.169006F));
                    builder.AddCubicBezier(new Vector2(-361.858002F, -97.1940002F), new Vector2(-324.786011F, -90.3730011F), new Vector2(-295.313995F, -91.7949982F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_162()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-368.222992F, -187.399994F));
                    builder.AddCubicBezier(new Vector2(-368.881012F, -187.399994F), new Vector2(-369.542999F, -187.608994F), new Vector2(-370.104004F, -188.042007F));
                    builder.AddCubicBezier(new Vector2(-387.217987F, -201.255005F), new Vector2(-395.152008F, -220.722F), new Vector2(-395.480988F, -221.544006F));
                    builder.AddCubicBezier(new Vector2(-396.114014F, -223.123993F), new Vector2(-395.346008F, -224.917999F), new Vector2(-393.765991F, -225.550995F));
                    builder.AddCubicBezier(new Vector2(-392.186005F, -226.182999F), new Vector2(-390.393005F, -225.416F), new Vector2(-389.76001F, -223.837006F));
                    builder.AddCubicBezier(new Vector2(-389.665985F, -223.604004F), new Vector2(-382.065002F, -205.063004F), new Vector2(-366.338013F, -192.921005F));
                    builder.AddCubicBezier(new Vector2(-364.990997F, -191.880997F), new Vector2(-364.742004F, -189.945007F), new Vector2(-365.782013F, -188.598007F));
                    builder.AddCubicBezier(new Vector2(-366.389008F, -187.811996F), new Vector2(-367.300995F, -187.399994F), new Vector2(-368.222992F, -187.399994F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_163()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-356.777008F, -199.106995F));
                    builder.AddCubicBezier(new Vector2(-357.434998F, -199.106995F), new Vector2(-358.096985F, -199.317001F), new Vector2(-358.65799F, -199.75F));
                    builder.AddCubicBezier(new Vector2(-375.806F, -212.988007F), new Vector2(-383.734009F, -233.979996F), new Vector2(-384.062988F, -234.867004F));
                    builder.AddCubicBezier(new Vector2(-384.654999F, -236.462997F), new Vector2(-383.84201F, -238.235992F), new Vector2(-382.246002F, -238.828003F));
                    builder.AddCubicBezier(new Vector2(-380.651001F, -239.419998F), new Vector2(-378.878998F, -238.606995F), new Vector2(-378.286011F, -237.013F));
                    builder.AddCubicBezier(new Vector2(-378.210999F, -236.811996F), new Vector2(-370.609985F, -216.763F), new Vector2(-354.890991F, -204.628006F));
                    builder.AddCubicBezier(new Vector2(-353.544006F, -203.587997F), new Vector2(-353.295013F, -201.653F), new Vector2(-354.334991F, -200.306F));
                    builder.AddCubicBezier(new Vector2(-354.941986F, -199.520004F), new Vector2(-355.855011F, -199.106995F), new Vector2(-356.777008F, -199.106995F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_164()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-240.440994F, -241.057007F));
                    builder.AddCubicBezier(new Vector2(-240.561996F, -241.057007F), new Vector2(-240.684006F, -241.063995F), new Vector2(-240.807999F, -241.078995F));
                    builder.AddCubicBezier(new Vector2(-242.498001F, -241.279999F), new Vector2(-243.705994F, -242.811996F), new Vector2(-243.505005F, -244.501999F));
                    builder.AddCubicBezier(new Vector2(-241.162003F, -264.22699F), new Vector2(-250.112F, -282.071991F), new Vector2(-250.203003F, -282.25F));
                    builder.AddCubicBezier(new Vector2(-250.975998F, -283.765991F), new Vector2(-250.371994F, -285.622009F), new Vector2(-248.856003F, -286.394989F));
                    builder.AddCubicBezier(new Vector2(-247.339996F, -287.167999F), new Vector2(-245.483994F, -286.563995F), new Vector2(-244.710999F, -285.048004F));
                    builder.AddCubicBezier(new Vector2(-244.306F, -284.252991F), new Vector2(-234.824005F, -265.338989F), new Vector2(-237.384995F, -243.774994F));
                    builder.AddCubicBezier(new Vector2(-237.570999F, -242.207993F), new Vector2(-238.901993F, -241.057007F), new Vector2(-240.440994F, -241.057007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_165()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-256.815002F, -241.082001F));
                    builder.AddCubicBezier(new Vector2(-256.936005F, -241.082001F), new Vector2(-257.058014F, -241.089005F), new Vector2(-257.182007F, -241.104004F));
                    builder.AddCubicBezier(new Vector2(-258.872009F, -241.304993F), new Vector2(-260.079987F, -242.837997F), new Vector2(-259.878998F, -244.528F));
                    builder.AddCubicBezier(new Vector2(-257.529999F, -264.304993F), new Vector2(-266.528015F, -283.709015F), new Vector2(-266.618988F, -283.903015F));
                    builder.AddCubicBezier(new Vector2(-267.343994F, -285.442993F), new Vector2(-266.683014F, -287.278992F), new Vector2(-265.143005F, -288.003998F));
                    builder.AddCubicBezier(new Vector2(-263.60199F, -288.729004F), new Vector2(-261.765991F, -288.067993F), new Vector2(-261.041992F, -286.528015F));
                    builder.AddCubicBezier(new Vector2(-260.639008F, -285.671997F), new Vector2(-251.203003F, -265.312988F), new Vector2(-253.757996F, -243.800995F));
                    builder.AddCubicBezier(new Vector2(-253.944F, -242.233994F), new Vector2(-255.276001F, -241.082001F), new Vector2(-256.815002F, -241.082001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_166()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-263.196991F, -77.1750031F));
                    builder.AddCubicBezier(new Vector2(-265.540009F, -77.1750031F), new Vector2(-267.640015F, -78.5709991F), new Vector2(-268.546997F, -80.7310028F));
                    builder.AddCubicBezier(new Vector2(-269.785004F, -83.6800003F), new Vector2(-268.393005F, -87.086998F), new Vector2(-265.444F, -88.3249969F));
                    builder.AddCubicBezier(new Vector2(-264.72699F, -88.6259995F), new Vector2(-263.972992F, -88.7779999F), new Vector2(-263.200012F, -88.7779999F));
                    builder.AddCubicBezier(new Vector2(-260.856995F, -88.7779999F), new Vector2(-258.756989F, -87.3830032F), new Vector2(-257.850006F, -85.2229996F));
                    builder.AddCubicBezier(new Vector2(-256.612F, -82.2740021F), new Vector2(-258.003998F, -78.8669968F), new Vector2(-260.953003F, -77.6289978F));
                    builder.AddCubicBezier(new Vector2(-261.670013F, -77.3280029F), new Vector2(-262.424011F, -77.1750031F), new Vector2(-263.196991F, -77.1750031F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_167()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_168(), Geometry_169() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head Offset:<292.928, 119.112>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_168()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-263.200012F, -87.0210037F));
                    builder.AddCubicBezier(new Vector2(-261.621002F, -87.0210037F), new Vector2(-260.121002F, -86.0899963F), new Vector2(-259.471008F, -84.5419998F));
                    builder.AddCubicBezier(new Vector2(-258.606995F, -82.4830017F), new Vector2(-259.574005F, -80.1139984F), new Vector2(-261.632996F, -79.2490005F));
                    builder.AddCubicBezier(new Vector2(-262.144012F, -79.0339966F), new Vector2(-262.674988F, -78.9329987F), new Vector2(-263.196991F, -78.9329987F));
                    builder.AddCubicBezier(new Vector2(-264.777008F, -78.9329987F), new Vector2(-266.276001F, -79.8639984F), new Vector2(-266.925995F, -81.4120026F));
                    builder.AddCubicBezier(new Vector2(-267.790009F, -83.4710007F), new Vector2(-266.822998F, -85.8399963F), new Vector2(-264.764008F, -86.7050018F));
                    builder.AddCubicBezier(new Vector2(-264.252991F, -86.9199982F), new Vector2(-263.721985F, -87.0210037F), new Vector2(-263.200012F, -87.0210037F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - Layer aggregator
            // - - - Transforms: head Offset:<292.928, 119.112>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_169()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-263.200012F, -90.5360031F));
                    builder.AddLine(new Vector2(-263.200989F, -90.5360031F));
                    builder.AddCubicBezier(new Vector2(-264.208008F, -90.5360031F), new Vector2(-265.191986F, -90.336998F), new Vector2(-266.125F, -89.9449997F));
                    builder.AddCubicBezier(new Vector2(-269.96701F, -88.3310013F), new Vector2(-271.779999F, -83.8929977F), new Vector2(-270.166992F, -80.0510025F));
                    builder.AddCubicBezier(new Vector2(-268.984985F, -77.2360001F), new Vector2(-266.248993F, -75.4179993F), new Vector2(-263.196991F, -75.4179993F));
                    builder.AddCubicBezier(new Vector2(-262.190002F, -75.4179993F), new Vector2(-261.204987F, -75.6169968F), new Vector2(-260.272003F, -76.0090027F));
                    builder.AddCubicBezier(new Vector2(-256.429993F, -77.6230011F), new Vector2(-254.617004F, -82.060997F), new Vector2(-256.230011F, -85.9029999F));
                    builder.AddCubicBezier(new Vector2(-257.411987F, -88.7180023F), new Vector2(-260.14801F, -90.5360031F), new Vector2(-263.200012F, -90.5360031F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_170()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-234.962997F, -89.4779968F));
                    builder.AddLine(new Vector2(-244.826996F, -85.3359985F));
                    builder.AddCubicBezier(new Vector2(-247.341003F, -84.2799988F), new Vector2(-250.235992F, -85.4629974F), new Vector2(-251.292007F, -87.9769974F));
                    builder.AddCubicBezier(new Vector2(-252.348007F, -90.4909973F), new Vector2(-251.164993F, -93.3850021F), new Vector2(-248.651001F, -94.4410019F));
                    builder.AddLine(new Vector2(-238.787003F, -98.5830002F));
                    builder.AddCubicBezier(new Vector2(-236.272995F, -99.6389999F), new Vector2(-233.378998F, -98.4570007F), new Vector2(-232.322998F, -95.9430008F));
                    builder.AddCubicBezier(new Vector2(-231.266998F, -93.4290009F), new Vector2(-232.449005F, -90.5339966F), new Vector2(-234.962997F, -89.4779968F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_171()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-270.231995F, -225.720001F));
                    builder.AddCubicBezier(new Vector2(-258.554993F, -229.028F), new Vector2(-246.408005F, -222.242996F), new Vector2(-243.100006F, -210.565994F));
                    builder.AddCubicBezier(new Vector2(-239.792007F, -198.889008F), new Vector2(-246.576004F, -186.742004F), new Vector2(-258.252991F, -183.434006F));
                    builder.AddCubicBezier(new Vector2(-269.929993F, -180.126007F), new Vector2(-282.076996F, -186.910004F), new Vector2(-285.38501F, -198.587006F));
                    builder.AddCubicBezier(new Vector2(-288.692993F, -210.264008F), new Vector2(-281.908997F, -222.412003F), new Vector2(-270.231995F, -225.720001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_172()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-224.949005F, -192.798004F));
                    builder.AddCubicBezier(new Vector2(-220.932007F, -193.936005F), new Vector2(-216.753006F, -191.602997F), new Vector2(-215.615005F, -187.585999F));
                    builder.AddCubicBezier(new Vector2(-214.477005F, -183.569F), new Vector2(-216.811005F, -179.389999F), new Vector2(-220.828003F, -178.251999F));
                    builder.AddCubicBezier(new Vector2(-224.845001F, -177.113998F), new Vector2(-229.024002F, -179.447998F), new Vector2(-230.162003F, -183.464996F));
                    builder.AddCubicBezier(new Vector2(-231.300003F, -187.481995F), new Vector2(-228.966003F, -191.660004F), new Vector2(-224.949005F, -192.798004F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - Transforms: head Offset:<292.928, 119.112>
            CanvasGeometry Geometry_173()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-288.938995F, -125.042F));
                    builder.AddCubicBezier(new Vector2(-288.938995F, -125.042F), new Vector2(-331.182007F, -110.157997F), new Vector2(-348.751007F, -146.365005F));
                    builder.AddCubicBezier(new Vector2(-348.751007F, -146.365005F), new Vector2(-349.666992F, -138.110001F), new Vector2(-344.401001F, -128.897995F));
                    builder.AddCubicBezier(new Vector2(-332.729004F, -108.482002F), new Vector2(-304.063995F, -106.181F), new Vector2(-289.347992F, -124.524002F));
                    builder.AddCubicBezier(new Vector2(-289.210999F, -124.694F), new Vector2(-289.075012F, -124.866997F), new Vector2(-288.938995F, -125.042F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_174()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(218.223007F, -304.416992F));
                    builder.AddCubicBezier(new Vector2(218.223007F, -236.507996F), new Vector2(163.171005F, -181.455994F), new Vector2(95.262001F, -181.455994F));
                    builder.AddCubicBezier(new Vector2(27.3530006F, -181.455994F), new Vector2(-27.6989994F, -236.507996F), new Vector2(-27.6989994F, -304.416992F));
                    builder.AddCubicBezier(new Vector2(-27.6989994F, -372.325989F), new Vector2(27.3530006F, -427.377014F), new Vector2(95.262001F, -427.377014F));
                    builder.AddCubicBezier(new Vector2(163.171005F, -427.377014F), new Vector2(218.223007F, -372.325989F), new Vector2(218.223007F, -304.416992F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_175()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_176(), Geometry_177() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_176()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(95.262001F, -176.834F));
                    builder.AddCubicBezier(new Vector2(78.0410004F, -176.834F), new Vector2(61.3320007F, -180.207993F), new Vector2(45.5999985F, -186.862F));
                    builder.AddCubicBezier(new Vector2(30.4069996F, -193.287994F), new Vector2(16.7619991F, -202.485992F), new Vector2(5.04699993F, -214.201996F));
                    builder.AddCubicBezier(new Vector2(-6.66900015F, -225.917007F), new Vector2(-15.8669996F, -239.561005F), new Vector2(-22.2929993F, -254.753998F));
                    builder.AddCubicBezier(new Vector2(-28.9470005F, -270.485992F), new Vector2(-32.3209991F, -287.195007F), new Vector2(-32.3209991F, -304.416992F));
                    builder.AddCubicBezier(new Vector2(-32.3209991F, -321.639008F), new Vector2(-28.9470005F, -338.346985F), new Vector2(-22.2929993F, -354.07901F));
                    builder.AddCubicBezier(new Vector2(-15.8669996F, -369.272003F), new Vector2(-6.66900015F, -382.916992F), new Vector2(5.04699993F, -394.631989F));
                    builder.AddCubicBezier(new Vector2(16.7619991F, -406.347992F), new Vector2(30.4069996F, -415.54599F), new Vector2(45.5999985F, -421.971985F));
                    builder.AddCubicBezier(new Vector2(61.3320007F, -428.626007F), new Vector2(78.0410004F, -432F), new Vector2(95.262001F, -432F));
                    builder.AddCubicBezier(new Vector2(112.483002F, -432F), new Vector2(129.192993F, -428.626007F), new Vector2(144.925003F, -421.971985F));
                    builder.AddCubicBezier(new Vector2(160.117996F, -415.54599F), new Vector2(173.761993F, -406.347992F), new Vector2(185.477005F, -394.631989F));
                    builder.AddCubicBezier(new Vector2(197.192993F, -382.916992F), new Vector2(206.391006F, -369.272003F), new Vector2(212.817001F, -354.07901F));
                    builder.AddCubicBezier(new Vector2(219.470993F, -338.346985F), new Vector2(222.845001F, -321.639008F), new Vector2(222.845001F, -304.416992F));
                    builder.AddCubicBezier(new Vector2(222.845001F, -287.195007F), new Vector2(219.470993F, -270.485992F), new Vector2(212.817001F, -254.753998F));
                    builder.AddCubicBezier(new Vector2(206.391006F, -239.561005F), new Vector2(197.192993F, -225.917007F), new Vector2(185.477005F, -214.201996F));
                    builder.AddCubicBezier(new Vector2(173.761993F, -202.485992F), new Vector2(160.117996F, -193.287994F), new Vector2(144.925003F, -186.862F));
                    builder.AddCubicBezier(new Vector2(129.192993F, -180.207993F), new Vector2(112.483002F, -176.834F), new Vector2(95.262001F, -176.834F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<540, 540>
            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_177()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(95.262001F, -422.755005F));
                    builder.AddCubicBezier(new Vector2(30.0100002F, -422.755005F), new Vector2(-23.0760002F, -369.669006F), new Vector2(-23.0760002F, -304.416992F));
                    builder.AddCubicBezier(new Vector2(-23.0760002F, -239.164993F), new Vector2(30.0100002F, -186.078995F), new Vector2(95.262001F, -186.078995F));
                    builder.AddCubicBezier(new Vector2(160.514008F, -186.078995F), new Vector2(213.600006F, -239.164993F), new Vector2(213.600006F, -304.416992F));
                    builder.AddCubicBezier(new Vector2(213.600006F, -369.669006F), new Vector2(160.514008F, -422.755005F), new Vector2(95.262001F, -422.755005F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_178()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(95.262001F, -423.526001F));
                    builder.AddCubicBezier(new Vector2(79.9120026F, -423.526001F), new Vector2(65.2480011F, -420.574005F), new Vector2(51.762001F, -415.263F));
                    builder.AddCubicBezier(new Vector2(29.4200001F, -406.463989F), new Vector2(10.3520002F, -391.119995F), new Vector2(-3.04200006F, -371.576996F));
                    builder.AddCubicBezier(new Vector2(-16.1550007F, -352.442993F), new Vector2(-23.8460007F, -329.313995F), new Vector2(-23.8460007F, -304.416992F));
                    builder.AddCubicBezier(new Vector2(-23.8460007F, -265.470001F), new Vector2(-5.05499983F, -230.832993F), new Vector2(23.9349995F, -209.087006F));
                    builder.AddCubicBezier(new Vector2(0.263000011F, -230.869995F), new Vector2(-14.6009998F, -262.084015F), new Vector2(-14.6009998F, -296.713013F));
                    builder.AddCubicBezier(new Vector2(-14.6009998F, -323.621002F), new Vector2(-5.62200022F, -348.463989F), new Vector2(9.4829998F, -368.428986F));
                    builder.AddCubicBezier(new Vector2(17.052F, -369.112F), new Vector2(26.2849998F, -372.894989F), new Vector2(34.8810005F, -379.415985F));
                    builder.AddCubicBezier(new Vector2(44.848999F, -386.97699F), new Vector2(51.4889984F, -396.347992F), new Vector2(53.3139992F, -404.239014F));
                    builder.AddCubicBezier(new Vector2(68.8320007F, -411.657013F), new Vector2(86.1910019F, -415.821014F), new Vector2(104.507004F, -415.821014F));
                    builder.AddCubicBezier(new Vector2(131.237F, -415.821014F), new Vector2(155.936996F, -406.967987F), new Vector2(175.834F, -392.042999F));
                    builder.AddCubicBezier(new Vector2(154.610001F, -411.574005F), new Vector2(126.308998F, -423.526001F), new Vector2(95.262001F, -423.526001F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<540, 540>
            CanvasGeometry Geometry_179()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(145.399002F, -412.390991F));
                    builder.AddCubicBezier(new Vector2(143.289001F, -413.373993F), new Vector2(141.156006F, -414.31601F), new Vector2(138.981995F, -415.177002F));
                    builder.AddCubicBezier(new Vector2(160.779999F, -393.57901F), new Vector2(174.309006F, -363.64801F), new Vector2(174.309006F, -330.610992F));
                    builder.AddCubicBezier(new Vector2(174.309006F, -328.424988F), new Vector2(174.240997F, -326.255005F), new Vector2(174.123993F, -324.096985F));
                    builder.AddCubicBezier(new Vector2(168.533005F, -319.154999F), new Vector2(163.854004F, -310.096008F), new Vector2(161.966995F, -299.230011F));
                    builder.AddCubicBezier(new Vector2(160.660995F, -291.708008F), new Vector2(160.912003F, -284.557007F), new Vector2(162.378006F, -278.691986F));
                    builder.AddCubicBezier(new Vector2(143.050995F, -238.957001F), new Vector2(102.275002F, -211.503006F), new Vector2(55.2010002F, -211.503006F));
                    builder.AddCubicBezier(new Vector2(39.7680016F, -211.503006F), new Vector2(25.0270004F, -214.485001F), new Vector2(11.4809999F, -219.850998F));
                    builder.AddCubicBezier(new Vector2(19.5489998F, -211.856995F), new Vector2(28.7490005F, -205.005997F), new Vector2(38.8170013F, -199.561996F));
                    builder.AddCubicBezier(new Vector2(54.1030006F, -192.408997F), new Vector2(71.137001F, -188.389999F), new Vector2(89.098999F, -188.389999F));
                    builder.AddCubicBezier(new Vector2(154.774994F, -188.389999F), new Vector2(208.207001F, -241.822006F), new Vector2(208.207001F, -307.498993F));
                    builder.AddCubicBezier(new Vector2(208.207001F, -352.816986F), new Vector2(182.75F, -392.269012F), new Vector2(145.399002F, -412.390991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_180()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(130.966995F, -290.947998F));
                    builder.AddCubicBezier(new Vector2(122.249001F, -304.981995F), new Vector2(103.737999F, -309.309998F), new Vector2(89.7020035F, -300.589996F));
                    builder.AddCubicBezier(new Vector2(82.9039993F, -296.367004F), new Vector2(78.1569977F, -289.748993F), new Vector2(76.3359985F, -281.954987F));
                    builder.AddCubicBezier(new Vector2(74.5149994F, -274.161011F), new Vector2(75.8379974F, -266.125F), new Vector2(80.0619965F, -259.326996F));
                    builder.AddCubicBezier(new Vector2(84.2860031F, -252.528F), new Vector2(90.9029999F, -247.781006F), new Vector2(98.6959991F, -245.960007F));
                    builder.AddCubicBezier(new Vector2(100.980003F, -245.427002F), new Vector2(103.283997F, -245.162994F), new Vector2(105.570999F, -245.162994F));
                    builder.AddCubicBezier(new Vector2(111.092003F, -245.162994F), new Vector2(116.516998F, -246.699005F), new Vector2(121.324997F, -249.684998F));
                    builder.AddCubicBezier(new Vector2(135.358994F, -258.403015F), new Vector2(139.684006F, -276.912994F), new Vector2(130.966995F, -290.947998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_181()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(98.1050034F, -339.195007F));
                    builder.AddCubicBezier(new Vector2(100.071999F, -338.734985F), new Vector2(102.056F, -338.509003F), new Vector2(104.027F, -338.509003F));
                    builder.AddCubicBezier(new Vector2(108.781998F, -338.509003F), new Vector2(113.456001F, -339.832001F), new Vector2(117.597F, -342.403992F));
                    builder.AddCubicBezier(new Vector2(123.452003F, -346.041992F), new Vector2(127.541F, -351.742004F), new Vector2(129.108994F, -358.454987F));
                    builder.AddCubicBezier(new Vector2(130.677994F, -365.167999F), new Vector2(129.537994F, -372.089996F), new Vector2(125.901001F, -377.946014F));
                    builder.AddCubicBezier(new Vector2(118.391998F, -390.033997F), new Vector2(102.445F, -393.756989F), new Vector2(90.3580017F, -386.251007F));
                    builder.AddCubicBezier(new Vector2(84.5029984F, -382.614014F), new Vector2(80.4140015F, -376.912994F), new Vector2(78.8460007F, -370.200012F));
                    builder.AddCubicBezier(new Vector2(77.2770004F, -363.487F), new Vector2(78.4169998F, -356.565002F), new Vector2(82.0540009F, -350.709015F));
                    builder.AddCubicBezier(new Vector2(85.6910019F, -344.852997F), new Vector2(91.3919983F, -340.764008F), new Vector2(98.1050034F, -339.195007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_182()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(34.2190018F, -332.040009F));
                    builder.AddCubicBezier(new Vector2(29.2159996F, -333.208008F), new Vector2(24.0459995F, -332.359985F), new Vector2(19.6730003F, -329.644989F));
                    builder.AddCubicBezier(new Vector2(10.6520004F, -324.040985F), new Vector2(7.87300014F, -312.141998F), new Vector2(13.4750004F, -303.121002F));
                    builder.AddCubicBezier(new Vector2(13.4750004F, -303.121002F), new Vector2(13.4750004F, -303.122009F), new Vector2(13.4750004F, -303.121002F));
                    builder.AddCubicBezier(new Vector2(17.1189995F, -297.256012F), new Vector2(23.4239998F, -294.028992F), new Vector2(29.8689995F, -294.028992F));
                    builder.AddCubicBezier(new Vector2(33.3359985F, -294.028992F), new Vector2(36.8450012F, -294.963013F), new Vector2(40F, -296.924011F));
                    builder.AddCubicBezier(new Vector2(44.3699989F, -299.638F), new Vector2(47.4210014F, -303.891998F), new Vector2(48.5919991F, -308.902008F));
                    builder.AddCubicBezier(new Vector2(49.7630005F, -313.911987F), new Vector2(48.9129982F, -319.076996F), new Vector2(46.1980019F, -323.446991F));
                    builder.AddCubicBezier(new Vector2(43.4830017F, -327.816986F), new Vector2(39.2299995F, -330.868988F), new Vector2(34.2190018F, -332.040009F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_183()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(76.5159988F, -265.575012F));
                    builder.AddCubicBezier(new Vector2(68.6819992F, -278.186005F), new Vector2(72.5550003F, -294.760986F), new Vector2(85.1660004F, -302.595001F));
                    builder.AddCubicBezier(new Vector2(97.7770004F, -310.428986F), new Vector2(114.351997F, -306.556F), new Vector2(122.185997F, -293.945007F));
                    builder.AddCubicBezier(new Vector2(130.020004F, -281.334015F), new Vector2(126.146004F, -264.759003F), new Vector2(113.535004F, -256.924988F));
                    builder.AddCubicBezier(new Vector2(100.924004F, -249.091003F), new Vector2(84.3499985F, -252.964005F), new Vector2(76.5159988F, -265.575012F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_184()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_185(), Geometry_186() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_185()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(99.3759995F, -249.022003F));
                    builder.AddCubicBezier(new Vector2(88.6600037F, -249.022003F), new Vector2(78.8919983F, -254.451004F), new Vector2(73.2440033F, -263.542999F));
                    builder.AddCubicBezier(new Vector2(68.9120026F, -270.516998F), new Vector2(67.5550003F, -278.759003F), new Vector2(69.4229965F, -286.752991F));
                    builder.AddCubicBezier(new Vector2(71.2910004F, -294.747009F), new Vector2(76.1600037F, -301.535004F), new Vector2(83.1340027F, -305.867004F));
                    builder.AddCubicBezier(new Vector2(88.0110016F, -308.895996F), new Vector2(93.6090012F, -310.497986F), new Vector2(99.3249969F, -310.497986F));
                    builder.AddCubicBezier(new Vector2(110.041F, -310.497986F), new Vector2(119.809998F, -305.069F), new Vector2(125.458F, -295.97699F));
                    builder.AddCubicBezier(new Vector2(129.789993F, -289.002991F), new Vector2(131.147003F, -280.760986F), new Vector2(129.279007F, -272.766998F));
                    builder.AddCubicBezier(new Vector2(127.411003F, -264.77301F), new Vector2(122.542F, -257.984985F), new Vector2(115.568001F, -253.653F));
                    builder.AddCubicBezier(new Vector2(110.691002F, -250.623993F), new Vector2(105.092003F, -249.022003F), new Vector2(99.3759995F, -249.022003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_186()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(99.3249969F, -302.794006F));
                    builder.AddCubicBezier(new Vector2(95.0469971F, -302.794006F), new Vector2(90.8539963F, -301.593994F), new Vector2(87.1989975F, -299.322998F));
                    builder.AddCubicBezier(new Vector2(81.973999F, -296.076996F), new Vector2(78.3249969F, -290.98999F), new Vector2(76.9250031F, -285F));
                    builder.AddCubicBezier(new Vector2(75.5250015F, -279.01001F), new Vector2(76.5419998F, -272.833008F), new Vector2(79.788002F, -267.608002F));
                    builder.AddCubicBezier(new Vector2(84.0199966F, -260.794006F), new Vector2(91.3430023F, -256.726013F), new Vector2(99.3759995F, -256.726013F));
                    builder.AddCubicBezier(new Vector2(103.653999F, -256.726013F), new Vector2(107.848F, -257.925995F), new Vector2(111.502998F, -260.196991F));
                    builder.AddCubicBezier(new Vector2(116.727997F, -263.442993F), new Vector2(120.376999F, -268.529999F), new Vector2(121.777F, -274.519989F));
                    builder.AddCubicBezier(new Vector2(123.177002F, -280.51001F), new Vector2(122.160004F, -286.687012F), new Vector2(118.914001F, -291.911987F));
                    builder.AddCubicBezier(new Vector2(114.681999F, -298.726013F), new Vector2(107.358002F, -302.794006F), new Vector2(99.3249969F, -302.794006F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_187()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(78.5080032F, -356.958008F));
                    builder.AddCubicBezier(new Vector2(71.8850021F, -367.619995F), new Vector2(75.1600037F, -381.632996F), new Vector2(85.8219986F, -388.256012F));
                    builder.AddCubicBezier(new Vector2(96.4840012F, -394.878998F), new Vector2(110.497002F, -391.604004F), new Vector2(117.120003F, -380.941986F));
                    builder.AddCubicBezier(new Vector2(123.742996F, -370.279999F), new Vector2(120.468002F, -356.266998F), new Vector2(109.806F, -349.644012F));
                    builder.AddCubicBezier(new Vector2(99.1439972F, -343.020996F), new Vector2(85.1309967F, -346.29599F), new Vector2(78.5080032F, -356.958008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_188()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_189(), Geometry_190() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_189()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(97.8359985F, -342.368011F));
                    builder.AddCubicBezier(new Vector2(88.5690002F, -342.368011F), new Vector2(80.1200027F, -347.062012F), new Vector2(75.2360001F, -354.924988F));
                    builder.AddCubicBezier(new Vector2(71.4899979F, -360.955994F), new Vector2(70.3170013F, -368.084991F), new Vector2(71.9319992F, -374.997986F));
                    builder.AddCubicBezier(new Vector2(73.5469971F, -381.911011F), new Vector2(77.7580032F, -387.782013F), new Vector2(83.7890015F, -391.528015F));
                    builder.AddCubicBezier(new Vector2(88.0059967F, -394.14801F), new Vector2(92.8479996F, -395.532013F), new Vector2(97.7919998F, -395.532013F));
                    builder.AddCubicBezier(new Vector2(107.058998F, -395.532013F), new Vector2(115.507004F, -390.838013F), new Vector2(120.391998F, -382.975006F));
                    builder.AddCubicBezier(new Vector2(124.138F, -376.944F), new Vector2(125.310997F, -369.815002F), new Vector2(123.695999F, -362.902008F));
                    builder.AddCubicBezier(new Vector2(122.080002F, -355.989014F), new Vector2(117.870003F, -350.118011F), new Vector2(111.838997F, -346.372009F));
                    builder.AddCubicBezier(new Vector2(107.622002F, -343.752014F), new Vector2(102.779999F, -342.368011F), new Vector2(97.8359985F, -342.368011F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_190()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(97.7919998F, -387.828003F));
                    builder.AddCubicBezier(new Vector2(94.2860031F, -387.828003F), new Vector2(90.8499985F, -386.845001F), new Vector2(87.8539963F, -384.984009F));
                    builder.AddCubicBezier(new Vector2(83.5709991F, -382.324005F), new Vector2(80.5810013F, -378.153992F), new Vector2(79.4339981F, -373.244995F));
                    builder.AddCubicBezier(new Vector2(78.2870026F, -368.334991F), new Vector2(79.1210022F, -363.27301F), new Vector2(81.7809982F, -358.98999F));
                    builder.AddCubicBezier(new Vector2(85.25F, -353.404999F), new Vector2(91.2519989F, -350.071991F), new Vector2(97.8359985F, -350.071991F));
                    builder.AddCubicBezier(new Vector2(101.342003F, -350.071991F), new Vector2(104.778F, -351.056F), new Vector2(107.774002F, -352.916992F));
                    builder.AddCubicBezier(new Vector2(112.056999F, -355.576996F), new Vector2(115.046997F, -359.744995F), new Vector2(116.194F, -364.654999F));
                    builder.AddCubicBezier(new Vector2(117.341003F, -369.563995F), new Vector2(116.508003F, -374.627014F), new Vector2(113.848F, -378.910004F));
                    builder.AddCubicBezier(new Vector2(110.378998F, -384.494995F), new Vector2(104.375999F, -387.828003F), new Vector2(97.7919998F, -387.828003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_191()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(9.93000031F, -309.369995F));
                    builder.AddCubicBezier(new Vector2(5.21500015F, -316.959991F), new Vector2(7.546F, -326.934998F), new Vector2(15.1359997F, -331.649994F));
                    builder.AddCubicBezier(new Vector2(22.7259998F, -336.36499F), new Vector2(32.7010002F, -334.033997F), new Vector2(37.4160004F, -326.444F));
                    builder.AddCubicBezier(new Vector2(42.1310005F, -318.854004F), new Vector2(39.7999992F, -308.878998F), new Vector2(32.2099991F, -304.164001F));
                    builder.AddCubicBezier(new Vector2(24.6200008F, -299.449005F), new Vector2(14.6450005F, -301.779999F), new Vector2(9.93000031F, -309.369995F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_192()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_193(), Geometry_194() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_193()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(23.6889992F, -297.873993F));
                    builder.AddCubicBezier(new Vector2(16.7059994F, -297.873993F), new Vector2(10.3389997F, -301.411011F), new Vector2(6.65799999F, -307.337006F));
                    builder.AddCubicBezier(new Vector2(0.829999983F, -316.718994F), new Vector2(3.72199988F, -329.093994F), new Vector2(13.1040001F, -334.921997F));
                    builder.AddCubicBezier(new Vector2(16.2819996F, -336.895996F), new Vector2(19.9309998F, -337.940002F), new Vector2(23.6580009F, -337.940002F));
                    builder.AddCubicBezier(new Vector2(30.6410007F, -337.940002F), new Vector2(37.0079994F, -334.403015F), new Vector2(40.6889992F, -328.47699F));
                    builder.AddCubicBezier(new Vector2(43.512001F, -323.932007F), new Vector2(44.3959999F, -318.55899F), new Vector2(43.1790009F, -313.348999F));
                    builder.AddCubicBezier(new Vector2(41.9620018F, -308.139008F), new Vector2(38.7879982F, -303.714996F), new Vector2(34.243F, -300.891998F));
                    builder.AddCubicBezier(new Vector2(31.0650005F, -298.917999F), new Vector2(27.4160004F, -297.873993F), new Vector2(23.6889992F, -297.873993F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_194()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(23.6580009F, -330.235992F));
                    builder.AddCubicBezier(new Vector2(21.3689995F, -330.235992F), new Vector2(19.1259995F, -329.592987F), new Vector2(17.1690006F, -328.377991F));
                    builder.AddCubicBezier(new Vector2(11.3950005F, -324.791992F), new Vector2(9.61499977F, -317.177002F), new Vector2(13.2019997F, -311.403015F));
                    builder.AddCubicBezier(new Vector2(15.467F, -307.756012F), new Vector2(19.3880005F, -305.578003F), new Vector2(23.6889992F, -305.578003F));
                    builder.AddCubicBezier(new Vector2(25.9780006F, -305.578003F), new Vector2(28.2210007F, -306.221008F), new Vector2(30.1779995F, -307.436005F));
                    builder.AddCubicBezier(new Vector2(32.9749985F, -309.173004F), new Vector2(34.9280014F, -311.895996F), new Vector2(35.6769981F, -315.10199F));
                    builder.AddCubicBezier(new Vector2(36.4259987F, -318.308014F), new Vector2(35.8810005F, -321.614014F), new Vector2(34.144001F, -324.411011F));
                    builder.AddCubicBezier(new Vector2(31.8789997F, -328.058014F), new Vector2(27.9580002F, -330.235992F), new Vector2(23.6580009F, -330.235992F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_195()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(119.771004F, -297.196991F));
                    builder.AddCubicBezier(new Vector2(120.172997F, -296.725006F), new Vector2(120.563004F, -296.239014F), new Vector2(120.941002F, -295.73999F));
                    builder.AddCubicBezier(new Vector2(120.568001F, -296.244995F), new Vector2(120.172997F, -296.725006F), new Vector2(119.771004F, -297.196991F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_196()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(74.3089981F, -270.027008F));
                    builder.AddCubicBezier(new Vector2(82.788002F, -260.076996F), new Vector2(97.4700012F, -257.520996F), new Vector2(108.913002F, -264.628998F));
                    builder.AddCubicBezier(new Vector2(120.086998F, -271.570007F), new Vector2(124.380997F, -285.368988F), new Vector2(119.769997F, -297.196991F));
                    builder.AddCubicBezier(new Vector2(111.291F, -307.147003F), new Vector2(96.6090012F, -309.703003F), new Vector2(85.1660004F, -302.595001F));
                    builder.AddCubicBezier(new Vector2(73.2779999F, -295.209991F), new Vector2(69.1640015F, -280.062012F), new Vector2(75.2929993F, -267.785004F));
                    builder.AddCubicBezier(new Vector2(74.9300003F, -268.52301F), new Vector2(74.6039963F, -269.270996F), new Vector2(74.3089981F, -270.027008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_197()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(114.609001F, -384.240997F));
                    builder.AddCubicBezier(new Vector2(115.063004F, -383.742004F), new Vector2(115.499001F, -383.221008F), new Vector2(115.916F, -382.678009F));
                    builder.AddCubicBezier(new Vector2(115.501999F, -383.225006F), new Vector2(115.063004F, -383.740997F), new Vector2(114.609001F, -384.240997F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_198()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(77.3000031F, -359.184998F));
                    builder.AddCubicBezier(new Vector2(76.961998F, -359.901001F), new Vector2(76.6610031F, -360.626007F), new Vector2(76.4000015F, -361.359985F));
                    builder.AddCubicBezier(new Vector2(76.6610031F, -360.626007F), new Vector2(76.9589996F, -359.899994F), new Vector2(77.3000031F, -359.184998F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_199()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(105.183998F, -357.348999F));
                    builder.AddCubicBezier(new Vector2(114.43F, -363.09201F), new Vector2(118.108002F, -374.390015F), new Vector2(114.606003F, -384.243988F));
                    builder.AddCubicBezier(new Vector2(107.373001F, -392.201996F), new Vector2(95.2839966F, -394.134003F), new Vector2(85.8219986F, -388.256012F));
                    builder.AddCubicBezier(new Vector2(76.5759964F, -382.513F), new Vector2(72.8980026F, -371.213989F), new Vector2(76.4000015F, -361.359985F));
                    builder.AddCubicBezier(new Vector2(83.6330032F, -353.402008F), new Vector2(95.7220001F, -351.471008F), new Vector2(105.183998F, -357.348999F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_200()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(78.5080032F, -356.958008F));
                    builder.AddCubicBezier(new Vector2(78.0699997F, -357.664001F), new Vector2(77.6780014F, -358.384003F), new Vector2(77.3290024F, -359.117004F));
                    builder.AddCubicBezier(new Vector2(77.6809998F, -358.38501F), new Vector2(78.0699997F, -357.664001F), new Vector2(78.5080032F, -356.958008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_201()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(33.0470009F, -331.096008F));
                    builder.AddCubicBezier(new Vector2(33.4669991F, -330.798004F), new Vector2(33.8759995F, -330.479004F), new Vector2(34.269001F, -330.138F));
                    builder.AddCubicBezier(new Vector2(33.8759995F, -330.479004F), new Vector2(33.4669991F, -330.796997F), new Vector2(33.0470009F, -331.096008F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_202()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(36.4749985F, -327.802002F));
                    builder.AddCubicBezier(new Vector2(35.8230019F, -328.64801F), new Vector2(35.0970001F, -329.411011F), new Vector2(34.3160019F, -330.092987F));
                    builder.AddCubicBezier(new Vector2(35.0970001F, -329.411011F), new Vector2(35.8230019F, -328.64801F), new Vector2(36.4749985F, -327.802002F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_203()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(27.3099995F, -309.756012F));
                    builder.AddCubicBezier(new Vector2(34.5979996F, -314.28299F), new Vector2(37.0169983F, -323.653015F), new Vector2(33.0270004F, -331.112F));
                    builder.AddCubicBezier(new Vector2(27.875F, -334.757996F), new Vector2(20.8349991F, -335.188995F), new Vector2(15.1370001F, -331.649994F));
                    builder.AddCubicBezier(new Vector2(7.84899998F, -327.122986F), new Vector2(5.4289999F, -317.752014F), new Vector2(9.41899967F, -310.294006F));
                    builder.AddCubicBezier(new Vector2(14.5710001F, -306.64801F), new Vector2(21.6119995F, -306.21701F), new Vector2(27.3099995F, -309.756012F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Color bound to theme property value: Color_00B7F7
            CompositionColorBrush ThemeColor_Color_00B7F7()
            {
                if (_themeColor_Color_00B7F7 != null) { return _themeColor_Color_00B7F7; }
                var result = _themeColor_Color_00B7F7 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_00B7F7, "Color", "ColorRGB(_theme.Color_00B7F7.W,_theme.Color_00B7F7.X,_theme.Color_00B7F7.Y,_theme.Color_00B7F7.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_29B6F6
            CompositionColorBrush ThemeColor_Color_29B6F6()
            {
                if (_themeColor_Color_29B6F6 != null) { return _themeColor_Color_29B6F6; }
                var result = _themeColor_Color_29B6F6 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_29B6F6, "Color", "ColorRGB(_theme.Color_29B6F6.W,_theme.Color_29B6F6.X,_theme.Color_29B6F6.Y,_theme.Color_29B6F6.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_650000
            CompositionColorBrush ThemeColor_Color_650000_0()
            {
                if (_themeColor_Color_650000_0 != null) { return _themeColor_Color_650000_0; }
                var result = _themeColor_Color_650000_0 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_650000_0, "Color", "ColorRGB(_theme.Color_650000.W,_theme.Color_650000.X,_theme.Color_650000.Y,_theme.Color_650000.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_650000
            CompositionColorBrush ThemeColor_Color_650000_1()
            {
                if (_themeColor_Color_650000_1 != null) { return _themeColor_Color_650000_1; }
                var result = _themeColor_Color_650000_1 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_650000_1, "Color", "ColorRGB(_theme.Color_650000.W*0.3,_theme.Color_650000.X,_theme.Color_650000.Y,_theme.Color_650000.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_650000
            CompositionColorBrush ThemeColor_Color_650000_2()
            {
                if (_themeColor_Color_650000_2 != null) { return _themeColor_Color_650000_2; }
                var result = _themeColor_Color_650000_2 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_650000_2, "Color", "ColorRGB(_theme.Color_650000.W*0.2,_theme.Color_650000.X,_theme.Color_650000.Y,_theme.Color_650000.Z)", "_theme", _themeProperties);
                return result;
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Color bound to theme property value: Color_77E5ED
            CompositionColorBrush ThemeColor_Color_77E5ED()
            {
                if (_themeColor_Color_77E5ED != null) { return _themeColor_Color_77E5ED; }
                var result = _themeColor_Color_77E5ED = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_77E5ED, "Color", "ColorRGB(_theme.Color_77E5ED.W,_theme.Color_77E5ED.X,_theme.Color_77E5ED.Y,_theme.Color_77E5ED.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_909090
            CompositionColorBrush ThemeColor_Color_909090()
            {
                if (_themeColor_Color_909090 != null) { return _themeColor_Color_909090; }
                var result = _themeColor_Color_909090 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_909090, "Color", "ColorRGB(_theme.Color_909090.W,_theme.Color_909090.X,_theme.Color_909090.Y,_theme.Color_909090.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_A0D35E
            CompositionColorBrush ThemeColor_Color_A0D35E()
            {
                if (_themeColor_Color_A0D35E != null) { return _themeColor_Color_A0D35E; }
                var result = _themeColor_Color_A0D35E = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_A0D35E, "Color", "ColorRGB(_theme.Color_A0D35E.W,_theme.Color_A0D35E.X,_theme.Color_A0D35E.Y,_theme.Color_A0D35E.Z)", "_theme", _themeProperties);
                return result;
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Color bound to theme property value: Color_AD82FF
            CompositionColorBrush ThemeColor_Color_AD82FF()
            {
                if (_themeColor_Color_AD82FF != null) { return _themeColor_Color_AD82FF; }
                var result = _themeColor_Color_AD82FF = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_AD82FF, "Color", "ColorRGB(_theme.Color_AD82FF.W,_theme.Color_AD82FF.X,_theme.Color_AD82FF.Y,_theme.Color_AD82FF.Z)", "_theme", _themeProperties);
                return result;
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Color bound to theme property value: Color_E1F5FE
            CompositionColorBrush ThemeColor_Color_E1F5FE()
            {
                if (_themeColor_Color_E1F5FE != null) { return _themeColor_Color_E1F5FE; }
                var result = _themeColor_Color_E1F5FE = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_E1F5FE, "Color", "ColorRGB(_theme.Color_E1F5FE.W,_theme.Color_E1F5FE.X,_theme.Color_E1F5FE.Y,_theme.Color_E1F5FE.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_ED1B24
            CompositionColorBrush ThemeColor_Color_ED1B24()
            {
                if (_themeColor_Color_ED1B24 != null) { return _themeColor_Color_ED1B24; }
                var result = _themeColor_Color_ED1B24 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_ED1B24, "Color", "ColorRGB(_theme.Color_ED1B24.W,_theme.Color_ED1B24.X,_theme.Color_ED1B24.Y,_theme.Color_ED1B24.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_F5F5F5
            CompositionColorBrush ThemeColor_Color_F5F5F5()
            {
                if (_themeColor_Color_F5F5F5 != null) { return _themeColor_Color_F5F5F5; }
                var result = _themeColor_Color_F5F5F5 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_F5F5F5, "Color", "ColorRGB(_theme.Color_F5F5F5.W,_theme.Color_F5F5F5.X,_theme.Color_F5F5F5.Y,_theme.Color_F5F5F5.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_FF3600
            CompositionColorBrush ThemeColor_Color_FF3600()
            {
                if (_themeColor_Color_FF3600 != null) { return _themeColor_Color_FF3600; }
                var result = _themeColor_Color_FF3600 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_FF3600, "Color", "ColorRGB(_theme.Color_FF3600.W,_theme.Color_FF3600.X,_theme.Color_FF3600.Y,_theme.Color_FF3600.Z)", "_theme", _themeProperties);
                return result;
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Color bound to theme property value: Color_FF971A
            CompositionColorBrush ThemeColor_Color_FF971A()
            {
                if (_themeColor_Color_FF971A != null) { return _themeColor_Color_FF971A; }
                var result = _themeColor_Color_FF971A = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_FF971A, "Color", "ColorRGB(_theme.Color_FF971A.W,_theme.Color_FF971A.X,_theme.Color_FF971A.Y,_theme.Color_FF971A.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_FFA42C
            CompositionColorBrush ThemeColor_Color_FFA42C()
            {
                if (_themeColor_Color_FFA42C != null) { return _themeColor_Color_FFA42C; }
                var result = _themeColor_Color_FFA42C = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_FFA42C, "Color", "ColorRGB(_theme.Color_FFA42C.W,_theme.Color_FFA42C.X,_theme.Color_FFA42C.Y,_theme.Color_FFA42C.Z)", "_theme", _themeProperties);
                return result;
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Color bound to theme property value: Color_FFC107
            CompositionColorBrush ThemeColor_Color_FFC107()
            {
                if (_themeColor_Color_FFC107 != null) { return _themeColor_Color_FFC107; }
                var result = _themeColor_Color_FFC107 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_FFC107, "Color", "ColorRGB(_theme.Color_FFC107.W,_theme.Color_FFC107.X,_theme.Color_FFC107.Y,_theme.Color_FFC107.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_FFCE00
            CompositionColorBrush ThemeColor_Color_FFCE00()
            {
                if (_themeColor_Color_FFCE00 != null) { return _themeColor_Color_FFCE00; }
                var result = _themeColor_Color_FFCE00 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_FFCE00, "Color", "ColorRGB(_theme.Color_FFCE00.W,_theme.Color_FFCE00.X,_theme.Color_FFCE00.Y,_theme.Color_FFCE00.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_FFF3E0
            CompositionColorBrush ThemeColor_Color_FFF3E0()
            {
                if (_themeColor_Color_FFF3E0 != null) { return _themeColor_Color_FFF3E0; }
                var result = _themeColor_Color_FFF3E0 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_FFF3E0, "Color", "ColorRGB(_theme.Color_FFF3E0.W,_theme.Color_FFF3E0.X,_theme.Color_FFF3E0.Y,_theme.Color_FFF3E0.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF_0()
            {
                if (_themeColor_Color_FFFFFF_0 != null) { return _themeColor_Color_FFFFFF_0; }
                var result = _themeColor_Color_FFFFFF_0 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_FFFFFF_0, "Color", "ColorRGB(_theme.Color_FFFFFF.W*0.4,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties);
                return result;
            }

            // Color bound to theme property value: Color_FFFFFF
            CompositionColorBrush ThemeColor_Color_FFFFFF_1()
            {
                if (_themeColor_Color_FFFFFF_1 != null) { return _themeColor_Color_FFFFFF_1; }
                var result = _themeColor_Color_FFFFFF_1 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_FFFFFF_1, "Color", "ColorRGB(_theme.Color_FFFFFF.W*0.6,_theme.Color_FFFFFF.X,_theme.Color_FFFFFF.Y,_theme.Color_FFFFFF.Z)", "_theme", _themeProperties);
                return result;
            }

            // Layer aggregator
            // Layer: Layer 11
            CompositionContainerShape ContainerShape_00()
            {
                if (_containerShape_00 != null) { return _containerShape_00; }
                var result = _containerShape_00 = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                // ShapeGroup: Group 1
                result.Shapes.Add(SpriteShape_001());
                return result;
            }

            // Layer aggregator
            // Layer: Layer 19
            CompositionContainerShape ContainerShape_01()
            {
                if (_containerShape_01 != null) { return _containerShape_01; }
                var result = _containerShape_01 = _c.CreateContainerShape();
                // ShapeGroup: Group 1
                result.Shapes.Add(SpriteShape_002());
                return result;
            }

            // Layer aggregator
            // Layer: Layer 12
            CompositionContainerShape ContainerShape_02()
            {
                if (_containerShape_02 != null) { return _containerShape_02; }
                var result = _containerShape_02 = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                // ShapeGroup: Group 1
                result.Shapes.Add(SpriteShape_003());
                return result;
            }

            // Layer aggregator
            // Layer: Layer 13
            CompositionContainerShape ContainerShape_03()
            {
                if (_containerShape_03 != null) { return _containerShape_03; }
                var result = _containerShape_03 = _c.CreateContainerShape();
                // ShapeGroup: Group 1
                result.Shapes.Add(SpriteShape_004());
                return result;
            }

            // Layer aggregator
            // Layer: Layer 14
            CompositionContainerShape ContainerShape_04()
            {
                if (_containerShape_04 != null) { return _containerShape_04; }
                var result = _containerShape_04 = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                // ShapeGroup: Group 1
                result.Shapes.Add(SpriteShape_005());
                return result;
            }

            // Layer aggregator
            // Layer: Layer 18
            CompositionContainerShape ContainerShape_05()
            {
                if (_containerShape_05 != null) { return _containerShape_05; }
                var result = _containerShape_05 = _c.CreateContainerShape();
                // ShapeGroup: Group 1
                result.Shapes.Add(SpriteShape_006());
                return result;
            }

            // Layer aggregator
            // Layer: Layer 15
            CompositionContainerShape ContainerShape_06()
            {
                if (_containerShape_06 != null) { return _containerShape_06; }
                var result = _containerShape_06 = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                // ShapeGroup: Group 1
                result.Shapes.Add(SpriteShape_007());
                return result;
            }

            // Layer aggregator
            // Layer: Layer 16
            CompositionContainerShape ContainerShape_07()
            {
                if (_containerShape_07 != null) { return _containerShape_07; }
                var result = _containerShape_07 = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                // ShapeGroup: Group 1
                result.Shapes.Add(SpriteShape_008());
                return result;
            }

            // Layer aggregator
            // Layer: Layer 17
            CompositionContainerShape ContainerShape_08()
            {
                if (_containerShape_08 != null) { return _containerShape_08; }
                var result = _containerShape_08 = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                // ShapeGroup: Group 1
                result.Shapes.Add(SpriteShape_009());
                return result;
            }

            // Layer aggregator
            // Layer: body
            CompositionContainerShape ContainerShape_09()
            {
                if (_containerShape_09 != null) { return _containerShape_09; }
                var result = _containerShape_09 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(50F, 50F);
                var shapes = result.Shapes;
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_071());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_072());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_073());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_074());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_075());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_076());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_077());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_078());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_079());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_080());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_081());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_082());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_083());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_084());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_085());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_086());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_087());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_088());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_089());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_090());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_091());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_092());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_093());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_094());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_095());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_096());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_097());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_098());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_099());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_100());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_101());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_102());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_103());
                // Transforms: body Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_104());
                return result;
            }

            // Layer aggregator
            // Layer: body 2
            CompositionContainerShape ContainerShape_10()
            {
                if (_containerShape_10 != null) { return _containerShape_10; }
                var result = _containerShape_10 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(50F, 50F);
                result.Scale = new Vector2(0F, 0F);
                var shapes = result.Shapes;
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_105());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_106());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_107());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_108());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_109());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_110());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_111());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_112());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_113());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_114());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_115());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_116());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_117());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_118());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_119());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_120());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_121());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_122());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_123());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_124());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_125());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_126());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_127());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_128());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_129());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_130());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_131());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_132());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_133());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_134());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_135());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_136());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_137());
                // Transforms: body 2 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_138());
                return result;
            }

            // Layer aggregator
            // Layer: body 3
            CompositionContainerShape ContainerShape_11()
            {
                if (_containerShape_11 != null) { return _containerShape_11; }
                var result = _containerShape_11 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(50F, 50F);
                result.Scale = new Vector2(0F, 0F);
                var shapes = result.Shapes;
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_139());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_140());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_141());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_142());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_143());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_144());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_145());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_146());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_147());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_148());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_149());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_150());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_151());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_152());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_153());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_154());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_155());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_156());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_157());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_158());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_159());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_160());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_161());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_162());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_163());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_164());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_165());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_166());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_167());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_168());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_169());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_170());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_171());
                // Transforms: body 3 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_172());
                return result;
            }

            // Layer aggregator
            // Layer: body 4
            CompositionContainerShape ContainerShape_12()
            {
                if (_containerShape_12 != null) { return _containerShape_12; }
                var result = _containerShape_12 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(50F, 50F);
                result.Scale = new Vector2(0F, 0F);
                var shapes = result.Shapes;
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_173());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_174());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_175());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_176());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_177());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_178());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_179());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_180());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_181());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_182());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_183());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_184());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_185());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_186());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_187());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_188());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_189());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_190());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_191());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_192());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_193());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_194());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_195());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_196());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_197());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_198());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_199());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_200());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_201());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_202());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_203());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_204());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_205());
                // Transforms: body 4 Offset:<292.929, 119.112>
                shapes.Add(SpriteShape_206());
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_13()
            {
                if (_containerShape_13 != null) { return _containerShape_13; }
                var result = _containerShape_13 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(50F, 50F);
                var shapes = result.Shapes;
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_207());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_208());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_209());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_210());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_211());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_212());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_213());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_214());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_215());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_216());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_217());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_218());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_219());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_220());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_221());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_222());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_223());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_224());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_225());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_226());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_227());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_228());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_229());
                // Transforms: head Offset:<292.928, 119.112>
                shapes.Add(SpriteShape_230());
                return result;
            }

            // Shape tree root for layer: Layer 3
            CompositionContainerShape ContainerShape_14()
            {
                if (_containerShape_14 != null) { return _containerShape_14; }
                var result = _containerShape_14 = _c.CreateContainerShape();
                var shapes = result.Shapes;
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_235());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_236());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_237());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_238());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_239());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_240());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_241());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_242());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_243());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_244());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_245());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_246());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_247());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_248());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_249());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_250());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_251());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_252());
                return result;
            }

            // Shape tree root for layer: Layer 4
            CompositionContainerShape ContainerShape_15()
            {
                if (_containerShape_15 != null) { return _containerShape_15; }
                var result = _containerShape_15 = _c.CreateContainerShape();
                var shapes = result.Shapes;
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_254());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_255());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_256());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_257());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_258());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_259());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_260());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_261());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_262());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_263());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_264());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_265());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_266());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_267());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_268());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_269());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_270());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_271());
                return result;
            }

            // Shape tree root for layer: Layer 5
            CompositionContainerShape ContainerShape_16()
            {
                if (_containerShape_16 != null) { return _containerShape_16; }
                var result = _containerShape_16 = _c.CreateContainerShape();
                var shapes = result.Shapes;
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_273());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_274());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_275());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_276());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_277());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_278());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_279());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_280());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_281());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_282());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_283());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_284());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_285());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_286());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_287());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_288());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_289());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_290());
                return result;
            }

            // Shape tree root for layer: Layer 6
            CompositionContainerShape ContainerShape_17()
            {
                if (_containerShape_17 != null) { return _containerShape_17; }
                var result = _containerShape_17 = _c.CreateContainerShape();
                var shapes = result.Shapes;
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_292());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_293());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_294());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_295());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_296());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_297());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_298());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_299());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_300());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_301());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_302());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_303());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_304());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_305());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_306());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_307());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_308());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_309());
                return result;
            }

            // Shape tree root for layer: Layer 7
            CompositionContainerShape ContainerShape_18()
            {
                if (_containerShape_18 != null) { return _containerShape_18; }
                var result = _containerShape_18 = _c.CreateContainerShape();
                var shapes = result.Shapes;
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_311());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_312());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_313());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_314());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_315());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_316());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_317());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_318());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_319());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_320());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_321());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_322());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_323());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_324());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_325());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_326());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_327());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_328());
                return result;
            }

            // Shape tree root for layer: Layer 8
            CompositionContainerShape ContainerShape_19()
            {
                if (_containerShape_19 != null) { return _containerShape_19; }
                var result = _containerShape_19 = _c.CreateContainerShape();
                var shapes = result.Shapes;
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_330());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_331());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_332());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_333());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_334());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_335());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_336());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_337());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_338());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_339());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_340());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_341());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_342());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_343());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_344());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_345());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_346());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_347());
                return result;
            }

            // Shape tree root for layer: Layer 9
            CompositionContainerShape ContainerShape_20()
            {
                if (_containerShape_20 != null) { return _containerShape_20; }
                var result = _containerShape_20 = _c.CreateContainerShape();
                var shapes = result.Shapes;
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_349());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_350());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_351());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_352());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_353());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_354());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_355());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_356());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_357());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_358());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_359());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_360());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_361());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_362());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_363());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_364());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_365());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_366());
                return result;
            }

            // Shape tree root for layer: Layer 10
            CompositionContainerShape ContainerShape_21()
            {
                if (_containerShape_21 != null) { return _containerShape_21; }
                var result = _containerShape_21 = _c.CreateContainerShape();
                var shapes = result.Shapes;
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_368());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_369());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_370());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_371());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_372());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_373());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_374());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_375());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_376());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_377());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_378());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_379());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_380());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_381());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_382());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_383());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_384());
                // ShapeGroup: Group 7
                shapes.Add(SpriteShape_385());
                return result;
            }

            CompositionEffectBrush EffectBrush_0()
            {
                var compositeEffect = new CompositeEffect();
                compositeEffect.Mode = CanvasComposite.DestinationIn;
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("destination"));
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("source"));
                var effectFactory = _c.CreateEffectFactory(compositeEffect);
                var result = effectFactory.CreateBrush();
                result.SetSourceParameter("destination", SurfaceBrush_00());
                result.SetSourceParameter("source", SurfaceBrush_01());
                return result;
            }

            CompositionEffectBrush EffectBrush_1()
            {
                var compositeEffect = new CompositeEffect();
                compositeEffect.Mode = CanvasComposite.DestinationIn;
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("destination"));
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("source"));
                var effectFactory = _c.CreateEffectFactory(compositeEffect);
                var result = effectFactory.CreateBrush();
                result.SetSourceParameter("destination", SurfaceBrush_02());
                result.SetSourceParameter("source", SurfaceBrush_03());
                return result;
            }

            CompositionEffectBrush EffectBrush_2()
            {
                var compositeEffect = new CompositeEffect();
                compositeEffect.Mode = CanvasComposite.DestinationIn;
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("destination"));
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("source"));
                var effectFactory = _c.CreateEffectFactory(compositeEffect);
                var result = effectFactory.CreateBrush();
                result.SetSourceParameter("destination", SurfaceBrush_04());
                result.SetSourceParameter("source", SurfaceBrush_05());
                return result;
            }

            CompositionEffectBrush EffectBrush_3()
            {
                var compositeEffect = new CompositeEffect();
                compositeEffect.Mode = CanvasComposite.DestinationIn;
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("destination"));
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("source"));
                var effectFactory = _c.CreateEffectFactory(compositeEffect);
                var result = effectFactory.CreateBrush();
                result.SetSourceParameter("destination", SurfaceBrush_06());
                result.SetSourceParameter("source", SurfaceBrush_07());
                return result;
            }

            CompositionEffectBrush EffectBrush_4()
            {
                var compositeEffect = new CompositeEffect();
                compositeEffect.Mode = CanvasComposite.DestinationIn;
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("destination"));
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("source"));
                var effectFactory = _c.CreateEffectFactory(compositeEffect);
                var result = effectFactory.CreateBrush();
                result.SetSourceParameter("destination", SurfaceBrush_08());
                result.SetSourceParameter("source", SurfaceBrush_09());
                return result;
            }

            CompositionEffectBrush EffectBrush_5()
            {
                var compositeEffect = new CompositeEffect();
                compositeEffect.Mode = CanvasComposite.DestinationIn;
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("destination"));
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("source"));
                var effectFactory = _c.CreateEffectFactory(compositeEffect);
                var result = effectFactory.CreateBrush();
                result.SetSourceParameter("destination", SurfaceBrush_10());
                result.SetSourceParameter("source", SurfaceBrush_11());
                return result;
            }

            CompositionEffectBrush EffectBrush_6()
            {
                var compositeEffect = new CompositeEffect();
                compositeEffect.Mode = CanvasComposite.DestinationIn;
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("destination"));
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("source"));
                var effectFactory = _c.CreateEffectFactory(compositeEffect);
                var result = effectFactory.CreateBrush();
                result.SetSourceParameter("destination", SurfaceBrush_12());
                result.SetSourceParameter("source", SurfaceBrush_13());
                return result;
            }

            CompositionEffectBrush EffectBrush_7()
            {
                var compositeEffect = new CompositeEffect();
                compositeEffect.Mode = CanvasComposite.DestinationIn;
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("destination"));
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("source"));
                var effectFactory = _c.CreateEffectFactory(compositeEffect);
                var result = effectFactory.CreateBrush();
                result.SetSourceParameter("destination", SurfaceBrush_14());
                result.SetSourceParameter("source", SurfaceBrush_15());
                return result;
            }

            // Ellipse Path 1.EllipseGeometry
            CompositionEllipseGeometry Ellipse_120p5()
            {
                if (_ellipse_120p5 != null) { return _ellipse_120p5; }
                var result = _ellipse_120p5 = _c.CreateEllipseGeometry();
                result.Radius = new Vector2(120.5F, 120.5F);
                return result;
            }

            CompositionPath Path_00()
            {
                if (_path_00 != null) { return _path_00; }
                var result = _path_00 = new CompositionPath(Geometry_008());
                return result;
            }

            CompositionPath Path_01()
            {
                if (_path_01 != null) { return _path_01; }
                var result = _path_01 = new CompositionPath(Geometry_009());
                return result;
            }

            CompositionPath Path_02()
            {
                if (_path_02 != null) { return _path_02; }
                var result = _path_02 = new CompositionPath(Geometry_010());
                return result;
            }

            CompositionPath Path_03()
            {
                if (_path_03 != null) { return _path_03; }
                var result = _path_03 = new CompositionPath(Geometry_011());
                return result;
            }

            CompositionPath Path_04()
            {
                if (_path_04 != null) { return _path_04; }
                var result = _path_04 = new CompositionPath(Geometry_012());
                return result;
            }

            CompositionPath Path_05()
            {
                if (_path_05 != null) { return _path_05; }
                var result = _path_05 = new CompositionPath(Geometry_013());
                return result;
            }

            CompositionPath Path_06()
            {
                if (_path_06 != null) { return _path_06; }
                var result = _path_06 = new CompositionPath(Geometry_088());
                return result;
            }

            CompositionPath Path_07()
            {
                if (_path_07 != null) { return _path_07; }
                var result = _path_07 = new CompositionPath(Geometry_090());
                return result;
            }

            CompositionPath Path_08()
            {
                if (_path_08 != null) { return _path_08; }
                var result = _path_08 = new CompositionPath(Geometry_091());
                return result;
            }

            CompositionPath Path_09()
            {
                if (_path_09 != null) { return _path_09; }
                var result = _path_09 = new CompositionPath(Geometry_092());
                return result;
            }

            CompositionPath Path_10()
            {
                if (_path_10 != null) { return _path_10; }
                var result = _path_10 = new CompositionPath(Geometry_095());
                return result;
            }

            CompositionPath Path_11()
            {
                if (_path_11 != null) { return _path_11; }
                var result = _path_11 = new CompositionPath(Geometry_098());
                return result;
            }

            CompositionPath Path_12()
            {
                if (_path_12 != null) { return _path_12; }
                var result = _path_12 = new CompositionPath(Geometry_099());
                return result;
            }

            CompositionPath Path_13()
            {
                if (_path_13 != null) { return _path_13; }
                var result = _path_13 = new CompositionPath(Geometry_103());
                return result;
            }

            CompositionPath Path_14()
            {
                if (_path_14 != null) { return _path_14; }
                var result = _path_14 = new CompositionPath(Geometry_104());
                return result;
            }

            CompositionPath Path_15()
            {
                if (_path_15 != null) { return _path_15; }
                var result = _path_15 = new CompositionPath(Geometry_105());
                return result;
            }

            CompositionPath Path_16()
            {
                if (_path_16 != null) { return _path_16; }
                var result = _path_16 = new CompositionPath(Geometry_106());
                return result;
            }

            CompositionPath Path_17()
            {
                if (_path_17 != null) { return _path_17; }
                var result = _path_17 = new CompositionPath(Geometry_107());
                return result;
            }

            CompositionPath Path_18()
            {
                if (_path_18 != null) { return _path_18; }
                var result = _path_18 = new CompositionPath(Geometry_108());
                return result;
            }

            CompositionPath Path_19()
            {
                if (_path_19 != null) { return _path_19; }
                var result = _path_19 = new CompositionPath(Geometry_116());
                return result;
            }

            CompositionPath Path_20()
            {
                if (_path_20 != null) { return _path_20; }
                var result = _path_20 = new CompositionPath(Geometry_123());
                return result;
            }

            CompositionPath Path_21()
            {
                if (_path_21 != null) { return _path_21; }
                var result = _path_21 = new CompositionPath(Geometry_124());
                return result;
            }

            CompositionPath Path_22()
            {
                if (_path_22 != null) { return _path_22; }
                var result = _path_22 = new CompositionPath(Geometry_125());
                return result;
            }

            CompositionPath Path_23()
            {
                if (_path_23 != null) { return _path_23; }
                var result = _path_23 = new CompositionPath(Geometry_126());
                return result;
            }

            CompositionPath Path_24()
            {
                if (_path_24 != null) { return _path_24; }
                var result = _path_24 = new CompositionPath(Geometry_129());
                return result;
            }

            CompositionPath Path_25()
            {
                if (_path_25 != null) { return _path_25; }
                var result = _path_25 = new CompositionPath(Geometry_130());
                return result;
            }

            CompositionPath Path_26()
            {
                if (_path_26 != null) { return _path_26; }
                var result = _path_26 = new CompositionPath(Geometry_131());
                return result;
            }

            CompositionPath Path_27()
            {
                if (_path_27 != null) { return _path_27; }
                var result = _path_27 = new CompositionPath(Geometry_132());
                return result;
            }

            CompositionPath Path_28()
            {
                if (_path_28 != null) { return _path_28; }
                var result = _path_28 = new CompositionPath(Geometry_133());
                return result;
            }

            CompositionPath Path_29()
            {
                if (_path_29 != null) { return _path_29; }
                var result = _path_29 = new CompositionPath(Geometry_134());
                return result;
            }

            CompositionPath Path_30()
            {
                if (_path_30 != null) { return _path_30; }
                var result = _path_30 = new CompositionPath(Geometry_135());
                return result;
            }

            CompositionPath Path_31()
            {
                if (_path_31 != null) { return _path_31; }
                var result = _path_31 = new CompositionPath(Geometry_136());
                return result;
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_000()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_000()));
            }

            CompositionPathGeometry PathGeometry_001()
            {
                return (_pathGeometry_001 == null)
                    ? _pathGeometry_001 = _c.CreatePathGeometry(new CompositionPath(Geometry_001()))
                    : _pathGeometry_001;
            }

            // - - Layer aggregator
            // - Layer: Layer 12
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_002()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_002()));
            }

            // - - Layer aggregator
            // - Layer: Layer 13
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_003()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_003()));
            }

            CompositionPathGeometry PathGeometry_004()
            {
                return (_pathGeometry_004 == null)
                    ? _pathGeometry_004 = _c.CreatePathGeometry(new CompositionPath(Geometry_004()))
                    : _pathGeometry_004;
            }

            // - - Layer aggregator
            // - Layer: Layer 15
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_005()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_005()));
            }

            // - - Layer aggregator
            // - Layer: Layer 16
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_006()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_006()));
            }

            // - - Layer aggregator
            // - Layer: Layer 17
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_007()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_007()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_008()
            {
                if (_pathGeometry_008 != null) { return _pathGeometry_008; }
                var result = _pathGeometry_008 = _c.CreatePathGeometry();
                return result;
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_009()
            {
                if (_pathGeometry_009 != null) { return _pathGeometry_009; }
                var result = _pathGeometry_009 = _c.CreatePathGeometry();
                return result;
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_010()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_014()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_011()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_015()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_012()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_018()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_013()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_019()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_014()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_020()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_015()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_021()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_016()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_024()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_017()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_025()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_018()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_026()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_019()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_027()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_020()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_030()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_021()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_031()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_022()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_032()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_023()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_033()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_024()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_034()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_025()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_035()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_026()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_036()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_027()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_039()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_028()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_040()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_029()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_041()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_030()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_044()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_031()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_045()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_032()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_046()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_033()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_047()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_034()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_048()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_035()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_049()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_036()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_052()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_037()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_053()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_038()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_054()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_039()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_057()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_040()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_058()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_041()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_059()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_042()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_062()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_043()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_063()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_044()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_064()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_045()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_065()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_046()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_066()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_047()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_067()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_048()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_068()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_049()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_069()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_050()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_070()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_051()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_071()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_052()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_072()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_053()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_073()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_054()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_074()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_055()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_075()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_056()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_076()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_057()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_077()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_058()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_078()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_059()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_079()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_060()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_080()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_061()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_081()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_062()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_082()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_063()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_083()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_064()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_084()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_065()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_085()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_066()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_086()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_067()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_087()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_068()
            {
                if (_pathGeometry_068 != null) { return _pathGeometry_068; }
                var result = _pathGeometry_068 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_069()
            {
                if (_pathGeometry_069 != null) { return _pathGeometry_069; }
                var result = _pathGeometry_069 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_070()
            {
                if (_pathGeometry_070 != null) { return _pathGeometry_070; }
                var result = _pathGeometry_070 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_071()
            {
                if (_pathGeometry_071 != null) { return _pathGeometry_071; }
                var result = _pathGeometry_071 = _c.CreatePathGeometry();
                return result;
            }

            CompositionPathGeometry PathGeometry_072()
            {
                return (_pathGeometry_072 == null)
                    ? _pathGeometry_072 = _c.CreatePathGeometry(new CompositionPath(Geometry_100()))
                    : _pathGeometry_072;
            }

            CompositionPathGeometry PathGeometry_073()
            {
                return (_pathGeometry_073 == null)
                    ? _pathGeometry_073 = _c.CreatePathGeometry(new CompositionPath(Geometry_101()))
                    : _pathGeometry_073;
            }

            CompositionPathGeometry PathGeometry_074()
            {
                return (_pathGeometry_074 == null)
                    ? _pathGeometry_074 = _c.CreatePathGeometry(new CompositionPath(Geometry_102()))
                    : _pathGeometry_074;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_075()
            {
                if (_pathGeometry_075 != null) { return _pathGeometry_075; }
                var result = _pathGeometry_075 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_076()
            {
                if (_pathGeometry_076 != null) { return _pathGeometry_076; }
                var result = _pathGeometry_076 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_077()
            {
                if (_pathGeometry_077 != null) { return _pathGeometry_077; }
                var result = _pathGeometry_077 = _c.CreatePathGeometry();
                return result;
            }

            CompositionPathGeometry PathGeometry_078()
            {
                return (_pathGeometry_078 == null)
                    ? _pathGeometry_078 = _c.CreatePathGeometry(new CompositionPath(Geometry_109()))
                    : _pathGeometry_078;
            }

            CompositionPathGeometry PathGeometry_079()
            {
                return (_pathGeometry_079 == null)
                    ? _pathGeometry_079 = _c.CreatePathGeometry(new CompositionPath(Geometry_110()))
                    : _pathGeometry_079;
            }

            CompositionPathGeometry PathGeometry_080()
            {
                return (_pathGeometry_080 == null)
                    ? _pathGeometry_080 = _c.CreatePathGeometry(new CompositionPath(Geometry_111()))
                    : _pathGeometry_080;
            }

            CompositionPathGeometry PathGeometry_081()
            {
                return (_pathGeometry_081 == null)
                    ? _pathGeometry_081 = _c.CreatePathGeometry(new CompositionPath(Geometry_112()))
                    : _pathGeometry_081;
            }

            CompositionPathGeometry PathGeometry_082()
            {
                return (_pathGeometry_082 == null)
                    ? _pathGeometry_082 = _c.CreatePathGeometry(new CompositionPath(Geometry_113()))
                    : _pathGeometry_082;
            }

            CompositionPathGeometry PathGeometry_083()
            {
                return (_pathGeometry_083 == null)
                    ? _pathGeometry_083 = _c.CreatePathGeometry(new CompositionPath(Geometry_114()))
                    : _pathGeometry_083;
            }

            CompositionPathGeometry PathGeometry_084()
            {
                return (_pathGeometry_084 == null)
                    ? _pathGeometry_084 = _c.CreatePathGeometry(new CompositionPath(Geometry_115()))
                    : _pathGeometry_084;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_085()
            {
                if (_pathGeometry_085 != null) { return _pathGeometry_085; }
                var result = _pathGeometry_085 = _c.CreatePathGeometry();
                return result;
            }

            CompositionPathGeometry PathGeometry_086()
            {
                return (_pathGeometry_086 == null)
                    ? _pathGeometry_086 = _c.CreatePathGeometry(new CompositionPath(Geometry_119()))
                    : _pathGeometry_086;
            }

            CompositionPathGeometry PathGeometry_087()
            {
                return (_pathGeometry_087 == null)
                    ? _pathGeometry_087 = _c.CreatePathGeometry(new CompositionPath(Geometry_120()))
                    : _pathGeometry_087;
            }

            CompositionPathGeometry PathGeometry_088()
            {
                return (_pathGeometry_088 == null)
                    ? _pathGeometry_088 = _c.CreatePathGeometry(new CompositionPath(Geometry_121()))
                    : _pathGeometry_088;
            }

            CompositionPathGeometry PathGeometry_089()
            {
                return (_pathGeometry_089 == null)
                    ? _pathGeometry_089 = _c.CreatePathGeometry(new CompositionPath(Geometry_122()))
                    : _pathGeometry_089;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_090()
            {
                if (_pathGeometry_090 != null) { return _pathGeometry_090; }
                var result = _pathGeometry_090 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_091()
            {
                if (_pathGeometry_091 != null) { return _pathGeometry_091; }
                var result = _pathGeometry_091 = _c.CreatePathGeometry();
                return result;
            }

            CompositionPathGeometry PathGeometry_092()
            {
                return (_pathGeometry_092 == null)
                    ? _pathGeometry_092 = _c.CreatePathGeometry(new CompositionPath(Geometry_127()))
                    : _pathGeometry_092;
            }

            CompositionPathGeometry PathGeometry_093()
            {
                return (_pathGeometry_093 == null)
                    ? _pathGeometry_093 = _c.CreatePathGeometry(new CompositionPath(Geometry_128()))
                    : _pathGeometry_093;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_094()
            {
                if (_pathGeometry_094 != null) { return _pathGeometry_094; }
                var result = _pathGeometry_094 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_095()
            {
                if (_pathGeometry_095 != null) { return _pathGeometry_095; }
                var result = _pathGeometry_095 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_096()
            {
                if (_pathGeometry_096 != null) { return _pathGeometry_096; }
                var result = _pathGeometry_096 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body
            // Transforms: body Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_097()
            {
                if (_pathGeometry_097 != null) { return _pathGeometry_097; }
                var result = _pathGeometry_097 = _c.CreatePathGeometry();
                return result;
            }

            CompositionPathGeometry PathGeometry_098()
            {
                return (_pathGeometry_098 == null)
                    ? _pathGeometry_098 = _c.CreatePathGeometry(new CompositionPath(Geometry_137()))
                    : _pathGeometry_098;
            }

            CompositionPathGeometry PathGeometry_099()
            {
                return (_pathGeometry_099 == null)
                    ? _pathGeometry_099 = _c.CreatePathGeometry(new CompositionPath(Geometry_138()))
                    : _pathGeometry_099;
            }

            CompositionPathGeometry PathGeometry_100()
            {
                return (_pathGeometry_100 == null)
                    ? _pathGeometry_100 = _c.CreatePathGeometry(new CompositionPath(Geometry_139()))
                    : _pathGeometry_100;
            }

            CompositionPathGeometry PathGeometry_101()
            {
                return (_pathGeometry_101 == null)
                    ? _pathGeometry_101 = _c.CreatePathGeometry(new CompositionPath(Geometry_140()))
                    : _pathGeometry_101;
            }

            CompositionPathGeometry PathGeometry_102()
            {
                return (_pathGeometry_102 == null)
                    ? _pathGeometry_102 = _c.CreatePathGeometry(new CompositionPath(Geometry_141()))
                    : _pathGeometry_102;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_103()
            {
                if (_pathGeometry_103 != null) { return _pathGeometry_103; }
                var result = _pathGeometry_103 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_104()
            {
                if (_pathGeometry_104 != null) { return _pathGeometry_104; }
                var result = _pathGeometry_104 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_105()
            {
                if (_pathGeometry_105 != null) { return _pathGeometry_105; }
                var result = _pathGeometry_105 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_106()
            {
                if (_pathGeometry_106 != null) { return _pathGeometry_106; }
                var result = _pathGeometry_106 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_107()
            {
                if (_pathGeometry_107 != null) { return _pathGeometry_107; }
                var result = _pathGeometry_107 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_108()
            {
                if (_pathGeometry_108 != null) { return _pathGeometry_108; }
                var result = _pathGeometry_108 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_109()
            {
                if (_pathGeometry_109 != null) { return _pathGeometry_109; }
                var result = _pathGeometry_109 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_110()
            {
                if (_pathGeometry_110 != null) { return _pathGeometry_110; }
                var result = _pathGeometry_110 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_111()
            {
                if (_pathGeometry_111 != null) { return _pathGeometry_111; }
                var result = _pathGeometry_111 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_112()
            {
                if (_pathGeometry_112 != null) { return _pathGeometry_112; }
                var result = _pathGeometry_112 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_113()
            {
                if (_pathGeometry_113 != null) { return _pathGeometry_113; }
                var result = _pathGeometry_113 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_114()
            {
                if (_pathGeometry_114 != null) { return _pathGeometry_114; }
                var result = _pathGeometry_114 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 2
            // Transforms: body 2 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_115()
            {
                if (_pathGeometry_115 != null) { return _pathGeometry_115; }
                var result = _pathGeometry_115 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_116()
            {
                if (_pathGeometry_116 != null) { return _pathGeometry_116; }
                var result = _pathGeometry_116 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_117()
            {
                if (_pathGeometry_117 != null) { return _pathGeometry_117; }
                var result = _pathGeometry_117 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_118()
            {
                if (_pathGeometry_118 != null) { return _pathGeometry_118; }
                var result = _pathGeometry_118 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_119()
            {
                if (_pathGeometry_119 != null) { return _pathGeometry_119; }
                var result = _pathGeometry_119 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_120()
            {
                if (_pathGeometry_120 != null) { return _pathGeometry_120; }
                var result = _pathGeometry_120 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_121()
            {
                if (_pathGeometry_121 != null) { return _pathGeometry_121; }
                var result = _pathGeometry_121 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_122()
            {
                if (_pathGeometry_122 != null) { return _pathGeometry_122; }
                var result = _pathGeometry_122 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_123()
            {
                if (_pathGeometry_123 != null) { return _pathGeometry_123; }
                var result = _pathGeometry_123 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_124()
            {
                if (_pathGeometry_124 != null) { return _pathGeometry_124; }
                var result = _pathGeometry_124 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_125()
            {
                if (_pathGeometry_125 != null) { return _pathGeometry_125; }
                var result = _pathGeometry_125 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_126()
            {
                if (_pathGeometry_126 != null) { return _pathGeometry_126; }
                var result = _pathGeometry_126 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_127()
            {
                if (_pathGeometry_127 != null) { return _pathGeometry_127; }
                var result = _pathGeometry_127 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 3
            // Transforms: body 3 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_128()
            {
                if (_pathGeometry_128 != null) { return _pathGeometry_128; }
                var result = _pathGeometry_128 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_129()
            {
                if (_pathGeometry_129 != null) { return _pathGeometry_129; }
                var result = _pathGeometry_129 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_130()
            {
                if (_pathGeometry_130 != null) { return _pathGeometry_130; }
                var result = _pathGeometry_130 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_131()
            {
                if (_pathGeometry_131 != null) { return _pathGeometry_131; }
                var result = _pathGeometry_131 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_132()
            {
                if (_pathGeometry_132 != null) { return _pathGeometry_132; }
                var result = _pathGeometry_132 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_133()
            {
                if (_pathGeometry_133 != null) { return _pathGeometry_133; }
                var result = _pathGeometry_133 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_134()
            {
                if (_pathGeometry_134 != null) { return _pathGeometry_134; }
                var result = _pathGeometry_134 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_135()
            {
                if (_pathGeometry_135 != null) { return _pathGeometry_135; }
                var result = _pathGeometry_135 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_136()
            {
                if (_pathGeometry_136 != null) { return _pathGeometry_136; }
                var result = _pathGeometry_136 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_137()
            {
                if (_pathGeometry_137 != null) { return _pathGeometry_137; }
                var result = _pathGeometry_137 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_138()
            {
                if (_pathGeometry_138 != null) { return _pathGeometry_138; }
                var result = _pathGeometry_138 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_139()
            {
                if (_pathGeometry_139 != null) { return _pathGeometry_139; }
                var result = _pathGeometry_139 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_140()
            {
                if (_pathGeometry_140 != null) { return _pathGeometry_140; }
                var result = _pathGeometry_140 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // - Layer: body 4
            // Transforms: body 4 Offset:<292.929, 119.112>
            CompositionPathGeometry PathGeometry_141()
            {
                if (_pathGeometry_141 != null) { return _pathGeometry_141; }
                var result = _pathGeometry_141 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_142()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_142()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_143()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_143()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_144()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_146()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_145()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_147()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_146()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_148()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_147()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_151()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_148()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_152()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_149()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_153()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_150()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_156()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_151()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_157()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_152()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_158()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_153()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_159()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_154()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_160()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_155()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_161()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_156()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_162()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_157()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_163()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_158()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_164()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_159()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_165()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_160()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_166()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_161()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_167()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_162()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_170()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_163()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_171()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_164()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_172()));
            }

            // - - Layer aggregator
            // Transforms: head Offset:<292.928, 119.112>
            CompositionPathGeometry PathGeometry_165()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_173()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_166()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_174()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_167()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_175()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_168()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_178()));
            }

            // - Layer aggregator
            // Offset:<540, 540>
            CompositionPathGeometry PathGeometry_169()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_179()));
            }

            CompositionPathGeometry PathGeometry_170()
            {
                return (_pathGeometry_170 == null)
                    ? _pathGeometry_170 = _c.CreatePathGeometry(new CompositionPath(Geometry_180()))
                    : _pathGeometry_170;
            }

            CompositionPathGeometry PathGeometry_171()
            {
                return (_pathGeometry_171 == null)
                    ? _pathGeometry_171 = _c.CreatePathGeometry(new CompositionPath(Geometry_181()))
                    : _pathGeometry_171;
            }

            CompositionPathGeometry PathGeometry_172()
            {
                return (_pathGeometry_172 == null)
                    ? _pathGeometry_172 = _c.CreatePathGeometry(new CompositionPath(Geometry_182()))
                    : _pathGeometry_172;
            }

            CompositionPathGeometry PathGeometry_173()
            {
                return (_pathGeometry_173 == null)
                    ? _pathGeometry_173 = _c.CreatePathGeometry(new CompositionPath(Geometry_183()))
                    : _pathGeometry_173;
            }

            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_174()
            {
                return (_pathGeometry_174 == null)
                    ? _pathGeometry_174 = _c.CreatePathGeometry(new CompositionPath(Geometry_184()))
                    : _pathGeometry_174;
            }

            CompositionPathGeometry PathGeometry_175()
            {
                return (_pathGeometry_175 == null)
                    ? _pathGeometry_175 = _c.CreatePathGeometry(new CompositionPath(Geometry_187()))
                    : _pathGeometry_175;
            }

            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_176()
            {
                return (_pathGeometry_176 == null)
                    ? _pathGeometry_176 = _c.CreatePathGeometry(new CompositionPath(Geometry_188()))
                    : _pathGeometry_176;
            }

            CompositionPathGeometry PathGeometry_177()
            {
                return (_pathGeometry_177 == null)
                    ? _pathGeometry_177 = _c.CreatePathGeometry(new CompositionPath(Geometry_191()))
                    : _pathGeometry_177;
            }

            // Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_178()
            {
                return (_pathGeometry_178 == null)
                    ? _pathGeometry_178 = _c.CreatePathGeometry(new CompositionPath(Geometry_192()))
                    : _pathGeometry_178;
            }

            CompositionPathGeometry PathGeometry_179()
            {
                return (_pathGeometry_179 == null)
                    ? _pathGeometry_179 = _c.CreatePathGeometry(new CompositionPath(Geometry_195()))
                    : _pathGeometry_179;
            }

            CompositionPathGeometry PathGeometry_180()
            {
                return (_pathGeometry_180 == null)
                    ? _pathGeometry_180 = _c.CreatePathGeometry(new CompositionPath(Geometry_196()))
                    : _pathGeometry_180;
            }

            CompositionPathGeometry PathGeometry_181()
            {
                return (_pathGeometry_181 == null)
                    ? _pathGeometry_181 = _c.CreatePathGeometry(new CompositionPath(Geometry_197()))
                    : _pathGeometry_181;
            }

            CompositionPathGeometry PathGeometry_182()
            {
                return (_pathGeometry_182 == null)
                    ? _pathGeometry_182 = _c.CreatePathGeometry(new CompositionPath(Geometry_198()))
                    : _pathGeometry_182;
            }

            CompositionPathGeometry PathGeometry_183()
            {
                return (_pathGeometry_183 == null)
                    ? _pathGeometry_183 = _c.CreatePathGeometry(new CompositionPath(Geometry_199()))
                    : _pathGeometry_183;
            }

            CompositionPathGeometry PathGeometry_184()
            {
                return (_pathGeometry_184 == null)
                    ? _pathGeometry_184 = _c.CreatePathGeometry(new CompositionPath(Geometry_200()))
                    : _pathGeometry_184;
            }

            CompositionPathGeometry PathGeometry_185()
            {
                return (_pathGeometry_185 == null)
                    ? _pathGeometry_185 = _c.CreatePathGeometry(new CompositionPath(Geometry_201()))
                    : _pathGeometry_185;
            }

            CompositionPathGeometry PathGeometry_186()
            {
                return (_pathGeometry_186 == null)
                    ? _pathGeometry_186 = _c.CreatePathGeometry(new CompositionPath(Geometry_202()))
                    : _pathGeometry_186;
            }

            CompositionPathGeometry PathGeometry_187()
            {
                return (_pathGeometry_187 == null)
                    ? _pathGeometry_187 = _c.CreatePathGeometry(new CompositionPath(Geometry_203()))
                    : _pathGeometry_187;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_000()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_000();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_AD82FF());;
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 11
            // Path 1
            CompositionSpriteShape SpriteShape_001()
            {
                if (_spriteShape_001 != null) { return _spriteShape_001; }
                var result = _spriteShape_001 = _c.CreateSpriteShape(PathGeometry_001());
                result.CenterPoint = new Vector2(-317.950012F, 378.165009F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 19
            // Path 1
            CompositionSpriteShape SpriteShape_002()
            {
                if (_spriteShape_002 != null) { return _spriteShape_002; }
                var result = _spriteShape_002 = _c.CreateSpriteShape(PathGeometry_001());
                result.CenterPoint = new Vector2(-317.950012F, 378.165009F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 12
            // Path 1
            CompositionSpriteShape SpriteShape_003()
            {
                if (_spriteShape_003 != null) { return _spriteShape_003; }
                var result = _spriteShape_003 = _c.CreateSpriteShape(PathGeometry_002());
                result.CenterPoint = new Vector2(349.053986F, 354.118988F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 13
            // Path 1
            CompositionSpriteShape SpriteShape_004()
            {
                if (_spriteShape_004 != null) { return _spriteShape_004; }
                var result = _spriteShape_004 = _c.CreateSpriteShape(PathGeometry_003());
                result.CenterPoint = new Vector2(425.912994F, -227.348999F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 14
            // Path 1
            CompositionSpriteShape SpriteShape_005()
            {
                if (_spriteShape_005 != null) { return _spriteShape_005; }
                var result = _spriteShape_005 = _c.CreateSpriteShape(PathGeometry_004());
                result.CenterPoint = new Vector2(367.626007F, -295.178986F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 18
            // Path 1
            CompositionSpriteShape SpriteShape_006()
            {
                if (_spriteShape_006 != null) { return _spriteShape_006; }
                var result = _spriteShape_006 = _c.CreateSpriteShape(PathGeometry_004());
                result.CenterPoint = new Vector2(367.626007F, -295.178986F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 15
            // Path 1
            CompositionSpriteShape SpriteShape_007()
            {
                if (_spriteShape_007 != null) { return _spriteShape_007; }
                var result = _spriteShape_007 = _c.CreateSpriteShape(PathGeometry_005());
                result.CenterPoint = new Vector2(-365.298004F, 306.177002F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 16
            // Path 1
            CompositionSpriteShape SpriteShape_008()
            {
                if (_spriteShape_008 != null) { return _spriteShape_008; }
                var result = _spriteShape_008 = _c.CreateSpriteShape(PathGeometry_006());
                result.CenterPoint = new Vector2(-397.384003F, -351.359009F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 17
            // Path 1
            CompositionSpriteShape SpriteShape_009()
            {
                if (_spriteShape_009 != null) { return _spriteShape_009; }
                var result = _spriteShape_009 = _c.CreateSpriteShape(PathGeometry_007());
                result.CenterPoint = new Vector2(-461.725006F, -280.842987F);
                result.Offset = new Vector2(540F, 540F);
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_010()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_008();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFC107());;
                result.StrokeBrush = ThemeColor_Color_650000_0();
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 8F;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_011()
            {
                // Offset:<555.8749, 632.9603>, Rotation:-0.008535189539860039 degrees,
                // Scale:<0.59, 0.59>
                var geometry = PathGeometry_009();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.589999974F, 0F, 0F, 0.589999974F, 555.874878F, 632.960327F), ThemeColor_Color_FF3600());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_012()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_010();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_909090());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_013()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_011();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_014()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_012();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_1());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_015()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_013();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_016()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_014();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_909090());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_017()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_015();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_018()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_016();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_1());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_019()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_017();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_020()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_018();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_E1F5FE());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_021()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_019();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_022()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_020();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_1());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_023()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_021();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_00B7F7());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_024()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_022();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_1());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_025()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_023();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_1());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_026()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_024();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_027()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_025();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_028()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_026();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_029()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_027();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_030()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_028();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_031()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_029();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_032()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_030();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_033()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_031();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_2());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_034()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_032();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_035()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_033();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_2());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_036()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_034();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFCE00());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_037()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_035();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_038()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_036();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_039()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_037();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_77E5ED());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_040()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_038();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_041()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_039();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_2());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_042()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_040();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_043()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_041();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_044()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_042();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_2());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_045()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_043();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_046()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_044();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_047()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_045();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_048()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_046();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_2());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_049()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_047();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_050()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_048();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_051()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_049();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_052()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_050();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_053()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_051();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_2());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_054()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_052();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_2());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_055()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_053();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_056()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_054();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_057()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_055();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_058()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_056();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_059()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_057();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_060()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_058();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_061()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_059();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_062()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_060();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_063()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_061();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_064()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_062();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_065()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_063();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_066()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_064();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_067()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_065();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_2());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_068()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_066();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_2());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_069()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_067();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_2());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_070()
            {
                // Offset:<540, 540>
                var result = CreateSpriteShape(PathGeometry_068(), new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F));;
                result.StrokeBrush = ThemeColor_Color_650000_0();
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 10F;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_071()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_069();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFF3E0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_072()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_070();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_073()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_071();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_074()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_072();
                if (_spriteShape_074 != null) { return _spriteShape_074; }
                var result = _spriteShape_074 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFCE00());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_075()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_073();
                if (_spriteShape_075 != null) { return _spriteShape_075; }
                var result = _spriteShape_075 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_1());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_076()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_074();
                if (_spriteShape_076 != null) { return _spriteShape_076; }
                var result = _spriteShape_076 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_1());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_077()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_075();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_078()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_076();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_079()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_077();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_080()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_078();
                if (_spriteShape_080 != null) { return _spriteShape_080; }
                var result = _spriteShape_080 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_081()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_079();
                if (_spriteShape_081 != null) { return _spriteShape_081; }
                var result = _spriteShape_081 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_082()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_080();
                if (_spriteShape_082 != null) { return _spriteShape_082; }
                var result = _spriteShape_082 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_083()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_081();
                if (_spriteShape_083 != null) { return _spriteShape_083; }
                var result = _spriteShape_083 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_084()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_082();
                if (_spriteShape_084 != null) { return _spriteShape_084; }
                var result = _spriteShape_084 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_085()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_083();
                if (_spriteShape_085 != null) { return _spriteShape_085; }
                var result = _spriteShape_085 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_086()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_084();
                if (_spriteShape_086 != null) { return _spriteShape_086; }
                var result = _spriteShape_086 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFF3E0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_087()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_085();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_088()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_086();
                if (_spriteShape_088 != null) { return _spriteShape_088; }
                var result = _spriteShape_088 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_089()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_087();
                if (_spriteShape_089 != null) { return _spriteShape_089; }
                var result = _spriteShape_089 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_A0D35E());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_090()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_088();
                if (_spriteShape_090 != null) { return _spriteShape_090; }
                var result = _spriteShape_090 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_091()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_089();
                if (_spriteShape_091 != null) { return _spriteShape_091; }
                var result = _spriteShape_091 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_29B6F6());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_092()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_090();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_093()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_091();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_094()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_092();
                if (_spriteShape_094 != null) { return _spriteShape_094; }
                var result = _spriteShape_094 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_095()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_093();
                if (_spriteShape_095 != null) { return _spriteShape_095; }
                var result = _spriteShape_095 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_096()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_094();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_097()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_095();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_098()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_096();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_099()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_097();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_100()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_098();
                if (_spriteShape_100 != null) { return _spriteShape_100; }
                var result = _spriteShape_100 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_101()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_099();
                if (_spriteShape_101 != null) { return _spriteShape_101; }
                var result = _spriteShape_101 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_102()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_100();
                if (_spriteShape_102 != null) { return _spriteShape_102; }
                var result = _spriteShape_102 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_103()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_101();
                if (_spriteShape_103 != null) { return _spriteShape_103; }
                var result = _spriteShape_103 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body
            // Path 1
            CompositionSpriteShape SpriteShape_104()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_102();
                if (_spriteShape_104 != null) { return _spriteShape_104; }
                var result = _spriteShape_104 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_105()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_103();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFF3E0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_106()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_104();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_107()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_105();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_108()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_072();
                if (_spriteShape_108 != null) { return _spriteShape_108; }
                var result = _spriteShape_108 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFCE00());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_109()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_073();
                if (_spriteShape_109 != null) { return _spriteShape_109; }
                var result = _spriteShape_109 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_1());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_110()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_074();
                if (_spriteShape_110 != null) { return _spriteShape_110; }
                var result = _spriteShape_110 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_1());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_111()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_106();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_112()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_107();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_113()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_108();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_114()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_078();
                if (_spriteShape_114 != null) { return _spriteShape_114; }
                var result = _spriteShape_114 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_115()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_079();
                if (_spriteShape_115 != null) { return _spriteShape_115; }
                var result = _spriteShape_115 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_116()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_080();
                if (_spriteShape_116 != null) { return _spriteShape_116; }
                var result = _spriteShape_116 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_117()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_081();
                if (_spriteShape_117 != null) { return _spriteShape_117; }
                var result = _spriteShape_117 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_118()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_082();
                if (_spriteShape_118 != null) { return _spriteShape_118; }
                var result = _spriteShape_118 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_119()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_083();
                if (_spriteShape_119 != null) { return _spriteShape_119; }
                var result = _spriteShape_119 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_120()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_084();
                if (_spriteShape_120 != null) { return _spriteShape_120; }
                var result = _spriteShape_120 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFF3E0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_121()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_109();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_122()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_086();
                if (_spriteShape_122 != null) { return _spriteShape_122; }
                var result = _spriteShape_122 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_123()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_087();
                if (_spriteShape_123 != null) { return _spriteShape_123; }
                var result = _spriteShape_123 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_A0D35E());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_124()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_088();
                if (_spriteShape_124 != null) { return _spriteShape_124; }
                var result = _spriteShape_124 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_125()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_089();
                if (_spriteShape_125 != null) { return _spriteShape_125; }
                var result = _spriteShape_125 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_29B6F6());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_126()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_110();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_127()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_111();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_128()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_092();
                if (_spriteShape_128 != null) { return _spriteShape_128; }
                var result = _spriteShape_128 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_129()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_093();
                if (_spriteShape_129 != null) { return _spriteShape_129; }
                var result = _spriteShape_129 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_130()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_112();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_131()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_113();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_132()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_114();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_133()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_115();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_134()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_098();
                if (_spriteShape_134 != null) { return _spriteShape_134; }
                var result = _spriteShape_134 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_135()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_099();
                if (_spriteShape_135 != null) { return _spriteShape_135; }
                var result = _spriteShape_135 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_136()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_100();
                if (_spriteShape_136 != null) { return _spriteShape_136; }
                var result = _spriteShape_136 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_137()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_101();
                if (_spriteShape_137 != null) { return _spriteShape_137; }
                var result = _spriteShape_137 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            // Path 1
            CompositionSpriteShape SpriteShape_138()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_102();
                if (_spriteShape_138 != null) { return _spriteShape_138; }
                var result = _spriteShape_138 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_139()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_116();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFF3E0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_140()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_117();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_141()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_118();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_142()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_072();
                if (_spriteShape_142 != null) { return _spriteShape_142; }
                var result = _spriteShape_142 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFCE00());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_143()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_073();
                if (_spriteShape_143 != null) { return _spriteShape_143; }
                var result = _spriteShape_143 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_1());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_144()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_074();
                if (_spriteShape_144 != null) { return _spriteShape_144; }
                var result = _spriteShape_144 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_1());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_145()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_119();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_146()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_120();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_147()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_121();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_148()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_078();
                if (_spriteShape_148 != null) { return _spriteShape_148; }
                var result = _spriteShape_148 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_149()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_079();
                if (_spriteShape_149 != null) { return _spriteShape_149; }
                var result = _spriteShape_149 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_150()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_080();
                if (_spriteShape_150 != null) { return _spriteShape_150; }
                var result = _spriteShape_150 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_151()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_081();
                if (_spriteShape_151 != null) { return _spriteShape_151; }
                var result = _spriteShape_151 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_152()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_082();
                if (_spriteShape_152 != null) { return _spriteShape_152; }
                var result = _spriteShape_152 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_153()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_083();
                if (_spriteShape_153 != null) { return _spriteShape_153; }
                var result = _spriteShape_153 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_154()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_084();
                if (_spriteShape_154 != null) { return _spriteShape_154; }
                var result = _spriteShape_154 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFF3E0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_155()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_122();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_156()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_086();
                if (_spriteShape_156 != null) { return _spriteShape_156; }
                var result = _spriteShape_156 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_157()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_087();
                if (_spriteShape_157 != null) { return _spriteShape_157; }
                var result = _spriteShape_157 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_A0D35E());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_158()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_088();
                if (_spriteShape_158 != null) { return _spriteShape_158; }
                var result = _spriteShape_158 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_159()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_089();
                if (_spriteShape_159 != null) { return _spriteShape_159; }
                var result = _spriteShape_159 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_29B6F6());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_160()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_123();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_161()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_124();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_162()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_092();
                if (_spriteShape_162 != null) { return _spriteShape_162; }
                var result = _spriteShape_162 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_163()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_093();
                if (_spriteShape_163 != null) { return _spriteShape_163; }
                var result = _spriteShape_163 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_164()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_125();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_165()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_126();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_166()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_127();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_167()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_128();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_168()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_098();
                if (_spriteShape_168 != null) { return _spriteShape_168; }
                var result = _spriteShape_168 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_169()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_099();
                if (_spriteShape_169 != null) { return _spriteShape_169; }
                var result = _spriteShape_169 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_170()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_100();
                if (_spriteShape_170 != null) { return _spriteShape_170; }
                var result = _spriteShape_170 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_171()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_101();
                if (_spriteShape_171 != null) { return _spriteShape_171; }
                var result = _spriteShape_171 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            // Path 1
            CompositionSpriteShape SpriteShape_172()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_102();
                if (_spriteShape_172 != null) { return _spriteShape_172; }
                var result = _spriteShape_172 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_173()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_129();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFF3E0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_174()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_130();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_175()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_131();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_176()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_072();
                if (_spriteShape_176 != null) { return _spriteShape_176; }
                var result = _spriteShape_176 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFCE00());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_177()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_073();
                if (_spriteShape_177 != null) { return _spriteShape_177; }
                var result = _spriteShape_177 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_1());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_178()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_074();
                if (_spriteShape_178 != null) { return _spriteShape_178; }
                var result = _spriteShape_178 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_1());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_179()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_132();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_180()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_133();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_181()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_134();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_182()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_078();
                if (_spriteShape_182 != null) { return _spriteShape_182; }
                var result = _spriteShape_182 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_183()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_079();
                if (_spriteShape_183 != null) { return _spriteShape_183; }
                var result = _spriteShape_183 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_184()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_080();
                if (_spriteShape_184 != null) { return _spriteShape_184; }
                var result = _spriteShape_184 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_185()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_081();
                if (_spriteShape_185 != null) { return _spriteShape_185; }
                var result = _spriteShape_185 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_186()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_082();
                if (_spriteShape_186 != null) { return _spriteShape_186; }
                var result = _spriteShape_186 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_187()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_083();
                if (_spriteShape_187 != null) { return _spriteShape_187; }
                var result = _spriteShape_187 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_188()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_084();
                if (_spriteShape_188 != null) { return _spriteShape_188; }
                var result = _spriteShape_188 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_FFF3E0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_189()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_135();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_190()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_086();
                if (_spriteShape_190 != null) { return _spriteShape_190; }
                var result = _spriteShape_190 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_191()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_087();
                if (_spriteShape_191 != null) { return _spriteShape_191; }
                var result = _spriteShape_191 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_A0D35E());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_192()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_088();
                if (_spriteShape_192 != null) { return _spriteShape_192; }
                var result = _spriteShape_192 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_193()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_089();
                if (_spriteShape_193 != null) { return _spriteShape_193; }
                var result = _spriteShape_193 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_29B6F6());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_194()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_136();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_195()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_137();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_196()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_092();
                if (_spriteShape_196 != null) { return _spriteShape_196; }
                var result = _spriteShape_196 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_197()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_093();
                if (_spriteShape_197 != null) { return _spriteShape_197; }
                var result = _spriteShape_197 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_198()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_138();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_199()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_139();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_200()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_140();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_F5F5F5());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_201()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_141();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_202()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_098();
                if (_spriteShape_202 != null) { return _spriteShape_202; }
                var result = _spriteShape_202 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_203()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_099();
                if (_spriteShape_203 != null) { return _spriteShape_203; }
                var result = _spriteShape_203 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_204()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_100();
                if (_spriteShape_204 != null) { return _spriteShape_204; }
                var result = _spriteShape_204 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_205()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_101();
                if (_spriteShape_205 != null) { return _spriteShape_205; }
                var result = _spriteShape_205 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            // Path 1
            CompositionSpriteShape SpriteShape_206()
            {
                // Offset:<292.929, 119.112>
                var geometry = PathGeometry_102();
                if (_spriteShape_206 != null) { return _spriteShape_206; }
                var result = _spriteShape_206 = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928986F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_207()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_142();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_208()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_143();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_209()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_144();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_210()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_145();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_211()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_146();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_212()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_147();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_213()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_148();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_FFF3E0());;
                return result;
            }

            // - Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_214()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_149();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_215()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_150();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_650000_2());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_216()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_151();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_217()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_152();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_ED1B24());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_218()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_153();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_219()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_154();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_220()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_155();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_221()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_156();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_222()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_157();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_223()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_158();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_224()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_159();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_225()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_160();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_FFCE00());;
                return result;
            }

            // - Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_226()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_161();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_227()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_162();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_650000_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_228()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_163();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_229()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_164();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_230()
            {
                // Offset:<292.928, 119.112>
                var geometry = PathGeometry_165();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 292.928009F, 119.112F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_231()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_166();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FF971A());;
                return result;
            }

            // Layer aggregator
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_232()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_167();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_233()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_168();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_FFFFFF_0());;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_234()
            {
                // Offset:<540, 540>
                var geometry = PathGeometry_169();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 540F, 540F), ThemeColor_Color_650000_1());;
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_235()
            {
                var result = _c.CreateSpriteShape(PathGeometry_170());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_236()
            {
                var result = _c.CreateSpriteShape(PathGeometry_171());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_237()
            {
                var result = _c.CreateSpriteShape(PathGeometry_172());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_238()
            {
                var result = _c.CreateSpriteShape(PathGeometry_173());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_239()
            {
                var result = _c.CreateSpriteShape(PathGeometry_174());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_240()
            {
                var result = _c.CreateSpriteShape(PathGeometry_175());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_241()
            {
                var result = _c.CreateSpriteShape(PathGeometry_176());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_242()
            {
                var result = _c.CreateSpriteShape(PathGeometry_177());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_243()
            {
                var result = _c.CreateSpriteShape(PathGeometry_178());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_244()
            {
                var result = _c.CreateSpriteShape(PathGeometry_179());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_245()
            {
                var result = _c.CreateSpriteShape(PathGeometry_180());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_246()
            {
                var result = _c.CreateSpriteShape(PathGeometry_181());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_247()
            {
                var result = _c.CreateSpriteShape(PathGeometry_182());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_248()
            {
                var result = _c.CreateSpriteShape(PathGeometry_183());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_249()
            {
                var result = _c.CreateSpriteShape(PathGeometry_184());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_250()
            {
                var result = _c.CreateSpriteShape(PathGeometry_185());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_251()
            {
                var result = _c.CreateSpriteShape(PathGeometry_186());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Path 1
            CompositionSpriteShape SpriteShape_252()
            {
                var result = _c.CreateSpriteShape(PathGeometry_187());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // Shape tree root for layer: Shape Layer 3
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_253()
            {
                // Offset:<635, 234.5>, Rotation:-0.005074697115182556 degrees, Scale:<0.98, 0.98>
                var geometry = Ellipse_120p5();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.980000019F, 0F, 0F, 0.980000019F, 635F, 234.5F), ThemeColor_Color_FF3600());;
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_254()
            {
                var result = _c.CreateSpriteShape(PathGeometry_170());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_255()
            {
                var result = _c.CreateSpriteShape(PathGeometry_171());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_256()
            {
                var result = _c.CreateSpriteShape(PathGeometry_172());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_257()
            {
                var result = _c.CreateSpriteShape(PathGeometry_173());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_258()
            {
                var result = _c.CreateSpriteShape(PathGeometry_174());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_259()
            {
                var result = _c.CreateSpriteShape(PathGeometry_175());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_260()
            {
                var result = _c.CreateSpriteShape(PathGeometry_176());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_261()
            {
                var result = _c.CreateSpriteShape(PathGeometry_177());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_262()
            {
                var result = _c.CreateSpriteShape(PathGeometry_178());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_263()
            {
                var result = _c.CreateSpriteShape(PathGeometry_179());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_264()
            {
                var result = _c.CreateSpriteShape(PathGeometry_180());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_265()
            {
                var result = _c.CreateSpriteShape(PathGeometry_181());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_266()
            {
                var result = _c.CreateSpriteShape(PathGeometry_182());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_267()
            {
                var result = _c.CreateSpriteShape(PathGeometry_183());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_268()
            {
                var result = _c.CreateSpriteShape(PathGeometry_184());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_269()
            {
                var result = _c.CreateSpriteShape(PathGeometry_185());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_270()
            {
                var result = _c.CreateSpriteShape(PathGeometry_186());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Path 1
            CompositionSpriteShape SpriteShape_271()
            {
                var result = _c.CreateSpriteShape(PathGeometry_187());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // Shape tree root for layer: Shape Layer 4
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_272()
            {
                // Offset:<635, 234.5>, Rotation:-0.005074697115182556 degrees, Scale:<0.98, 0.98>
                var geometry = Ellipse_120p5();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.980000019F, 0F, 0F, 0.980000019F, 635F, 234.5F), ThemeColor_Color_FF3600());;
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_273()
            {
                var result = _c.CreateSpriteShape(PathGeometry_170());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_274()
            {
                var result = _c.CreateSpriteShape(PathGeometry_171());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_275()
            {
                var result = _c.CreateSpriteShape(PathGeometry_172());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_276()
            {
                var result = _c.CreateSpriteShape(PathGeometry_173());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_277()
            {
                var result = _c.CreateSpriteShape(PathGeometry_174());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_278()
            {
                var result = _c.CreateSpriteShape(PathGeometry_175());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_279()
            {
                var result = _c.CreateSpriteShape(PathGeometry_176());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_280()
            {
                var result = _c.CreateSpriteShape(PathGeometry_177());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_281()
            {
                var result = _c.CreateSpriteShape(PathGeometry_178());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_282()
            {
                var result = _c.CreateSpriteShape(PathGeometry_179());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_283()
            {
                var result = _c.CreateSpriteShape(PathGeometry_180());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_284()
            {
                var result = _c.CreateSpriteShape(PathGeometry_181());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_285()
            {
                var result = _c.CreateSpriteShape(PathGeometry_182());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_286()
            {
                var result = _c.CreateSpriteShape(PathGeometry_183());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_287()
            {
                var result = _c.CreateSpriteShape(PathGeometry_184());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_288()
            {
                var result = _c.CreateSpriteShape(PathGeometry_185());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_289()
            {
                var result = _c.CreateSpriteShape(PathGeometry_186());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Path 1
            CompositionSpriteShape SpriteShape_290()
            {
                var result = _c.CreateSpriteShape(PathGeometry_187());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // Shape tree root for layer: Shape Layer 5
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_291()
            {
                // Offset:<635, 234.5>, Rotation:-0.005074697115182556 degrees, Scale:<0.98, 0.98>
                var geometry = Ellipse_120p5();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.980000019F, 0F, 0F, 0.980000019F, 635F, 234.5F), ThemeColor_Color_FF3600());;
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_292()
            {
                var result = _c.CreateSpriteShape(PathGeometry_170());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_293()
            {
                var result = _c.CreateSpriteShape(PathGeometry_171());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_294()
            {
                var result = _c.CreateSpriteShape(PathGeometry_172());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_295()
            {
                var result = _c.CreateSpriteShape(PathGeometry_173());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_296()
            {
                var result = _c.CreateSpriteShape(PathGeometry_174());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_297()
            {
                var result = _c.CreateSpriteShape(PathGeometry_175());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_298()
            {
                var result = _c.CreateSpriteShape(PathGeometry_176());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_299()
            {
                var result = _c.CreateSpriteShape(PathGeometry_177());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_300()
            {
                var result = _c.CreateSpriteShape(PathGeometry_178());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_301()
            {
                var result = _c.CreateSpriteShape(PathGeometry_179());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_302()
            {
                var result = _c.CreateSpriteShape(PathGeometry_180());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_303()
            {
                var result = _c.CreateSpriteShape(PathGeometry_181());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_304()
            {
                var result = _c.CreateSpriteShape(PathGeometry_182());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_305()
            {
                var result = _c.CreateSpriteShape(PathGeometry_183());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_306()
            {
                var result = _c.CreateSpriteShape(PathGeometry_184());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_307()
            {
                var result = _c.CreateSpriteShape(PathGeometry_185());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_308()
            {
                var result = _c.CreateSpriteShape(PathGeometry_186());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_309()
            {
                var result = _c.CreateSpriteShape(PathGeometry_187());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // Shape tree root for layer: Shape Layer 6
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_310()
            {
                // Offset:<635, 234.5>, Rotation:-0.005074697115182556 degrees, Scale:<0.98, 0.98>
                var geometry = Ellipse_120p5();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.980000019F, 0F, 0F, 0.980000019F, 635F, 234.5F), ThemeColor_Color_FF3600());;
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_311()
            {
                var result = _c.CreateSpriteShape(PathGeometry_170());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_312()
            {
                var result = _c.CreateSpriteShape(PathGeometry_171());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_313()
            {
                var result = _c.CreateSpriteShape(PathGeometry_172());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_314()
            {
                var result = _c.CreateSpriteShape(PathGeometry_173());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_315()
            {
                var result = _c.CreateSpriteShape(PathGeometry_174());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_316()
            {
                var result = _c.CreateSpriteShape(PathGeometry_175());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_317()
            {
                var result = _c.CreateSpriteShape(PathGeometry_176());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_318()
            {
                var result = _c.CreateSpriteShape(PathGeometry_177());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_319()
            {
                var result = _c.CreateSpriteShape(PathGeometry_178());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_320()
            {
                var result = _c.CreateSpriteShape(PathGeometry_179());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_321()
            {
                var result = _c.CreateSpriteShape(PathGeometry_180());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_322()
            {
                var result = _c.CreateSpriteShape(PathGeometry_181());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_323()
            {
                var result = _c.CreateSpriteShape(PathGeometry_182());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_324()
            {
                var result = _c.CreateSpriteShape(PathGeometry_183());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_325()
            {
                var result = _c.CreateSpriteShape(PathGeometry_184());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_326()
            {
                var result = _c.CreateSpriteShape(PathGeometry_185());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_327()
            {
                var result = _c.CreateSpriteShape(PathGeometry_186());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Path 1
            CompositionSpriteShape SpriteShape_328()
            {
                var result = _c.CreateSpriteShape(PathGeometry_187());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // Shape tree root for layer: Shape Layer 7
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_329()
            {
                // Offset:<635, 234.5>, Rotation:-0.005074697115182556 degrees, Scale:<0.98, 0.98>
                var geometry = Ellipse_120p5();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.980000019F, 0F, 0F, 0.980000019F, 635F, 234.5F), ThemeColor_Color_FF3600());;
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_330()
            {
                var result = _c.CreateSpriteShape(PathGeometry_170());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_331()
            {
                var result = _c.CreateSpriteShape(PathGeometry_171());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_332()
            {
                var result = _c.CreateSpriteShape(PathGeometry_172());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_333()
            {
                var result = _c.CreateSpriteShape(PathGeometry_173());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_334()
            {
                var result = _c.CreateSpriteShape(PathGeometry_174());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_335()
            {
                var result = _c.CreateSpriteShape(PathGeometry_175());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_336()
            {
                var result = _c.CreateSpriteShape(PathGeometry_176());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_337()
            {
                var result = _c.CreateSpriteShape(PathGeometry_177());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_338()
            {
                var result = _c.CreateSpriteShape(PathGeometry_178());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_339()
            {
                var result = _c.CreateSpriteShape(PathGeometry_179());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_340()
            {
                var result = _c.CreateSpriteShape(PathGeometry_180());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_341()
            {
                var result = _c.CreateSpriteShape(PathGeometry_181());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_342()
            {
                var result = _c.CreateSpriteShape(PathGeometry_182());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_343()
            {
                var result = _c.CreateSpriteShape(PathGeometry_183());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_344()
            {
                var result = _c.CreateSpriteShape(PathGeometry_184());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_345()
            {
                var result = _c.CreateSpriteShape(PathGeometry_185());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_346()
            {
                var result = _c.CreateSpriteShape(PathGeometry_186());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Path 1
            CompositionSpriteShape SpriteShape_347()
            {
                var result = _c.CreateSpriteShape(PathGeometry_187());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // Shape tree root for layer: Shape Layer 8
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_348()
            {
                // Offset:<635, 234.5>, Rotation:-0.005074697115182556 degrees, Scale:<0.98, 0.98>
                var geometry = Ellipse_120p5();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.980000019F, 0F, 0F, 0.980000019F, 635F, 234.5F), ThemeColor_Color_FF3600());;
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_349()
            {
                var result = _c.CreateSpriteShape(PathGeometry_170());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_350()
            {
                var result = _c.CreateSpriteShape(PathGeometry_171());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_351()
            {
                var result = _c.CreateSpriteShape(PathGeometry_172());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_352()
            {
                var result = _c.CreateSpriteShape(PathGeometry_173());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_353()
            {
                var result = _c.CreateSpriteShape(PathGeometry_174());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_354()
            {
                var result = _c.CreateSpriteShape(PathGeometry_175());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_355()
            {
                var result = _c.CreateSpriteShape(PathGeometry_176());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_356()
            {
                var result = _c.CreateSpriteShape(PathGeometry_177());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_357()
            {
                var result = _c.CreateSpriteShape(PathGeometry_178());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_358()
            {
                var result = _c.CreateSpriteShape(PathGeometry_179());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_359()
            {
                var result = _c.CreateSpriteShape(PathGeometry_180());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_360()
            {
                var result = _c.CreateSpriteShape(PathGeometry_181());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_361()
            {
                var result = _c.CreateSpriteShape(PathGeometry_182());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_362()
            {
                var result = _c.CreateSpriteShape(PathGeometry_183());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_363()
            {
                var result = _c.CreateSpriteShape(PathGeometry_184());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_364()
            {
                var result = _c.CreateSpriteShape(PathGeometry_185());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_365()
            {
                var result = _c.CreateSpriteShape(PathGeometry_186());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Path 1
            CompositionSpriteShape SpriteShape_366()
            {
                var result = _c.CreateSpriteShape(PathGeometry_187());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // Shape tree root for layer: Shape Layer 9
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_367()
            {
                // Offset:<635, 234.5>, Rotation:-0.005074697115182556 degrees, Scale:<0.98, 0.98>
                var geometry = Ellipse_120p5();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.980000019F, 0F, 0F, 0.980000019F, 635F, 234.5F), ThemeColor_Color_FF3600());;
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_368()
            {
                var result = _c.CreateSpriteShape(PathGeometry_170());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_369()
            {
                var result = _c.CreateSpriteShape(PathGeometry_171());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_370()
            {
                var result = _c.CreateSpriteShape(PathGeometry_172());
                result.FillBrush = ThemeColor_Color_FFFFFF_0();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_371()
            {
                var result = _c.CreateSpriteShape(PathGeometry_173());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_372()
            {
                var result = _c.CreateSpriteShape(PathGeometry_174());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_373()
            {
                var result = _c.CreateSpriteShape(PathGeometry_175());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_374()
            {
                var result = _c.CreateSpriteShape(PathGeometry_176());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_375()
            {
                var result = _c.CreateSpriteShape(PathGeometry_177());
                result.FillBrush = ThemeColor_Color_FFA42C();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 2+Path 1
            CompositionSpriteShape SpriteShape_376()
            {
                var result = _c.CreateSpriteShape(PathGeometry_178());
                result.FillBrush = ThemeColor_Color_650000_0();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_377()
            {
                var result = _c.CreateSpriteShape(PathGeometry_179());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_378()
            {
                var result = _c.CreateSpriteShape(PathGeometry_180());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_379()
            {
                var result = _c.CreateSpriteShape(PathGeometry_181());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_380()
            {
                var result = _c.CreateSpriteShape(PathGeometry_182());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_381()
            {
                var result = _c.CreateSpriteShape(PathGeometry_183());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_382()
            {
                var result = _c.CreateSpriteShape(PathGeometry_184());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_383()
            {
                var result = _c.CreateSpriteShape(PathGeometry_185());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_384()
            {
                var result = _c.CreateSpriteShape(PathGeometry_186());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Path 1
            CompositionSpriteShape SpriteShape_385()
            {
                var result = _c.CreateSpriteShape(PathGeometry_187());
                result.FillBrush = ThemeColor_Color_650000_1();
                return result;
            }

            // Shape tree root for layer: Shape Layer 10
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_386()
            {
                // Offset:<635, 234.5>, Rotation:-0.005074697115182556 degrees, Scale:<0.98, 0.98>
                var geometry = Ellipse_120p5();
                var result = CreateSpriteShape(geometry, new Matrix3x2(0.980000019F, 0F, 0F, 0.980000019F, 635F, 234.5F), ThemeColor_Color_FF3600());;
                return result;
            }

            CompositionSurfaceBrush SurfaceBrush_00()
            {
                return _c.CreateSurfaceBrush(VisualSurface_00());
            }

            CompositionSurfaceBrush SurfaceBrush_01()
            {
                return _c.CreateSurfaceBrush(VisualSurface_01());
            }

            CompositionSurfaceBrush SurfaceBrush_02()
            {
                return _c.CreateSurfaceBrush(VisualSurface_02());
            }

            CompositionSurfaceBrush SurfaceBrush_03()
            {
                return _c.CreateSurfaceBrush(VisualSurface_03());
            }

            CompositionSurfaceBrush SurfaceBrush_04()
            {
                return _c.CreateSurfaceBrush(VisualSurface_04());
            }

            CompositionSurfaceBrush SurfaceBrush_05()
            {
                return _c.CreateSurfaceBrush(VisualSurface_05());
            }

            CompositionSurfaceBrush SurfaceBrush_06()
            {
                return _c.CreateSurfaceBrush(VisualSurface_06());
            }

            CompositionSurfaceBrush SurfaceBrush_07()
            {
                return _c.CreateSurfaceBrush(VisualSurface_07());
            }

            CompositionSurfaceBrush SurfaceBrush_08()
            {
                return _c.CreateSurfaceBrush(VisualSurface_08());
            }

            CompositionSurfaceBrush SurfaceBrush_09()
            {
                return _c.CreateSurfaceBrush(VisualSurface_09());
            }

            CompositionSurfaceBrush SurfaceBrush_10()
            {
                return _c.CreateSurfaceBrush(VisualSurface_10());
            }

            CompositionSurfaceBrush SurfaceBrush_11()
            {
                return _c.CreateSurfaceBrush(VisualSurface_11());
            }

            CompositionSurfaceBrush SurfaceBrush_12()
            {
                return _c.CreateSurfaceBrush(VisualSurface_12());
            }

            CompositionSurfaceBrush SurfaceBrush_13()
            {
                return _c.CreateSurfaceBrush(VisualSurface_13());
            }

            CompositionSurfaceBrush SurfaceBrush_14()
            {
                return _c.CreateSurfaceBrush(VisualSurface_14());
            }

            CompositionSurfaceBrush SurfaceBrush_15()
            {
                return _c.CreateSurfaceBrush(VisualSurface_15());
            }

            CompositionVisualSurface VisualSurface_00()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_00();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_01()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_01();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_02()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_02();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_03()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_03();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_04()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_04();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_05()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_05();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_06()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_06();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_07()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_07();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_08()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_08();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_09()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_09();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_10()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_10();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_11()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_11();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_12()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_12();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_13()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_13();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_14()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_14();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            CompositionVisualSurface VisualSurface_15()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_15();
                result.SourceSize = new Vector2(1080F, 1080F);
                return result;
            }

            ContainerVisual ContainerVisual_00()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Layer 3
                result.Children.InsertAtTop(ShapeVisual_01());
                return result;
            }

            ContainerVisual ContainerVisual_01()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Shape Layer 3
                result.Children.InsertAtTop(ShapeVisual_02());
                return result;
            }

            ContainerVisual ContainerVisual_02()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Layer 4
                result.Children.InsertAtTop(ShapeVisual_03());
                return result;
            }

            ContainerVisual ContainerVisual_03()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Shape Layer 4
                result.Children.InsertAtTop(ShapeVisual_04());
                return result;
            }

            ContainerVisual ContainerVisual_04()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Layer 5
                result.Children.InsertAtTop(ShapeVisual_05());
                return result;
            }

            ContainerVisual ContainerVisual_05()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Shape Layer 5
                result.Children.InsertAtTop(ShapeVisual_06());
                return result;
            }

            ContainerVisual ContainerVisual_06()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Layer 6
                result.Children.InsertAtTop(ShapeVisual_07());
                return result;
            }

            ContainerVisual ContainerVisual_07()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Shape Layer 6
                result.Children.InsertAtTop(ShapeVisual_08());
                return result;
            }

            ContainerVisual ContainerVisual_08()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Layer 7
                result.Children.InsertAtTop(ShapeVisual_09());
                return result;
            }

            ContainerVisual ContainerVisual_09()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Shape Layer 7
                result.Children.InsertAtTop(ShapeVisual_10());
                return result;
            }

            ContainerVisual ContainerVisual_10()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Layer 8
                result.Children.InsertAtTop(ShapeVisual_11());
                return result;
            }

            ContainerVisual ContainerVisual_11()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Shape Layer 8
                result.Children.InsertAtTop(ShapeVisual_12());
                return result;
            }

            ContainerVisual ContainerVisual_12()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Layer 9
                result.Children.InsertAtTop(ShapeVisual_13());
                return result;
            }

            ContainerVisual ContainerVisual_13()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Shape Layer 9
                result.Children.InsertAtTop(ShapeVisual_14());
                return result;
            }

            ContainerVisual ContainerVisual_14()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Layer 10
                result.Children.InsertAtTop(ShapeVisual_15());
                return result;
            }

            ContainerVisual ContainerVisual_15()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: Shape Layer 10
                result.Children.InsertAtTop(ShapeVisual_16());
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
                var children = result.Children;
                // Layer aggregator
                children.InsertAtTop(ShapeVisual_00());
                children.InsertAtTop(SpriteVisual_0());
                children.InsertAtTop(SpriteVisual_1());
                children.InsertAtTop(SpriteVisual_2());
                children.InsertAtTop(SpriteVisual_3());
                children.InsertAtTop(SpriteVisual_4());
                children.InsertAtTop(SpriteVisual_5());
                children.InsertAtTop(SpriteVisual_6());
                children.InsertAtTop(SpriteVisual_7());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return (_cubicBezierEasingFunction_0 == null)
                    ? _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.064000003F, 0F), new Vector2(0.31400001F, 0.880999982F))
                    : _cubicBezierEasingFunction_0;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_1()
            {
                return (_cubicBezierEasingFunction_1 == null)
                    ? _cubicBezierEasingFunction_1 = _c.CreateCubicBezierEasingFunction(new Vector2(0.629000008F, 0F), new Vector2(0.847000003F, 1F))
                    : _cubicBezierEasingFunction_1;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_2()
            {
                return (_cubicBezierEasingFunction_2 == null)
                    ? _cubicBezierEasingFunction_2 = _c.CreateCubicBezierEasingFunction(new Vector2(0.296000004F, 0F), new Vector2(0.666999996F, 1F))
                    : _cubicBezierEasingFunction_2;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_3()
            {
                return (_cubicBezierEasingFunction_3 == null)
                    ? _cubicBezierEasingFunction_3 = _c.CreateCubicBezierEasingFunction(new Vector2(0.305000007F, 0F), new Vector2(0.666999996F, 1F))
                    : _cubicBezierEasingFunction_3;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_4()
            {
                return (_cubicBezierEasingFunction_4 == null)
                    ? _cubicBezierEasingFunction_4 = _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.833000004F, 0.833000004F))
                    : _cubicBezierEasingFunction_4;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_5()
            {
                return (_cubicBezierEasingFunction_5 == null)
                    ? _cubicBezierEasingFunction_5 = _c.CreateCubicBezierEasingFunction(new Vector2(0.333000004F, 0F), new Vector2(0.666999996F, 1F))
                    : _cubicBezierEasingFunction_5;
            }

            ExpressionAnimation RootProgress()
            {
                if (_rootProgress != null) { return _rootProgress; }
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            ExpressionAnimation RootProgressRemapped_0()
            {
                if (_rootProgressRemapped_0 != null) { return _rootProgressRemapped_0; }
                var result = _rootProgressRemapped_0 = _c.CreateExpressionAnimation("_.Progress*0.9625669");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            ExpressionAnimation RootProgressRemapped_1()
            {
                if (_rootProgressRemapped_1 != null) { return _rootProgressRemapped_1; }
                var result = _rootProgressRemapped_1 = _c.CreateExpressionAnimation("_.Progress*0.9836066+0.01639344");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            ExpressionAnimation RootProgressRemapped_2()
            {
                if (_rootProgressRemapped_2 != null) { return _rootProgressRemapped_2; }
                var result = _rootProgressRemapped_2 = _c.CreateExpressionAnimation("_.Progress*0.989011");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            ExpressionAnimation RootProgressRemapped_3()
            {
                if (_rootProgressRemapped_3 != null) { return _rootProgressRemapped_3; }
                var result = _rootProgressRemapped_3 = _c.CreateExpressionAnimation("_.Progress*0.9574468+0.04255319");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // - - Layer aggregator
            // -  Offset:<540, 540>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_00()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_00(), HoldThenStepEasingFunction());
                // Frame 2.
                result.InsertKeyFrame(0.0111111114F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 4.
                result.InsertKeyFrame(0.0222222228F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 6.
                result.InsertKeyFrame(0.0333333351F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 8.
                result.InsertKeyFrame(0.0444444455F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 10.
                result.InsertKeyFrame(0.055555556F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 12.
                result.InsertKeyFrame(0.0666666701F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 14.
                result.InsertKeyFrame(0.0777777806F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 16.
                result.InsertKeyFrame(0.088888891F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 18.
                result.InsertKeyFrame(0.100000001F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 22.
                result.InsertKeyFrame(0.122222222F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 24.
                result.InsertKeyFrame(0.13333334F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 26.
                result.InsertKeyFrame(0.144444451F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 28.
                result.InsertKeyFrame(0.155555561F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 30.
                result.InsertKeyFrame(0.166666672F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 32.
                result.InsertKeyFrame(0.177777782F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 34.
                result.InsertKeyFrame(0.188888893F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 36.
                result.InsertKeyFrame(0.200000003F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 38.
                result.InsertKeyFrame(0.211111113F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 40.
                result.InsertKeyFrame(0.222222224F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 42.
                result.InsertKeyFrame(0.233333334F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 44.
                result.InsertKeyFrame(0.244444445F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 46.
                result.InsertKeyFrame(0.25555557F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 48.
                result.InsertKeyFrame(0.266666681F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 50.
                result.InsertKeyFrame(0.277777791F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 52.
                result.InsertKeyFrame(0.288888901F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 54.
                result.InsertKeyFrame(0.300000012F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 56.
                result.InsertKeyFrame(0.311111122F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 58.
                result.InsertKeyFrame(0.322222233F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 60.
                result.InsertKeyFrame(0.333333343F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 62.
                result.InsertKeyFrame(0.344444454F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 64.
                result.InsertKeyFrame(0.355555564F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 66.
                result.InsertKeyFrame(0.366666675F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 68.
                result.InsertKeyFrame(0.377777785F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 70.
                result.InsertKeyFrame(0.388888896F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 72.
                result.InsertKeyFrame(0.400000006F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 74.
                result.InsertKeyFrame(0.411111116F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 76.
                result.InsertKeyFrame(0.422222227F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 78.
                result.InsertKeyFrame(0.433333337F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 80.
                result.InsertKeyFrame(0.444444448F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 82.
                result.InsertKeyFrame(0.455555558F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 84.
                result.InsertKeyFrame(0.466666669F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 86.
                result.InsertKeyFrame(0.477777779F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 88.
                result.InsertKeyFrame(0.48888889F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 92.
                result.InsertKeyFrame(0.51111114F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 94.
                result.InsertKeyFrame(0.522222221F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 96.
                result.InsertKeyFrame(0.533333361F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 98.
                result.InsertKeyFrame(0.544444442F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 100.
                result.InsertKeyFrame(0.555555582F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 102.
                result.InsertKeyFrame(0.566666663F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 104.
                result.InsertKeyFrame(0.577777803F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 106.
                result.InsertKeyFrame(0.588888884F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 108.
                result.InsertKeyFrame(0.600000024F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 112.
                result.InsertKeyFrame(0.622222245F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 114.
                result.InsertKeyFrame(0.633333325F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 116.
                result.InsertKeyFrame(0.644444466F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 118.
                result.InsertKeyFrame(0.655555546F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 120.
                result.InsertKeyFrame(0.666666687F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 122.
                result.InsertKeyFrame(0.677777767F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 124.
                result.InsertKeyFrame(0.688888907F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 126.
                result.InsertKeyFrame(0.699999988F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 128.
                result.InsertKeyFrame(0.711111128F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 130.
                result.InsertKeyFrame(0.722222209F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 132.
                result.InsertKeyFrame(0.733333349F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 134.
                result.InsertKeyFrame(0.74444443F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 136.
                result.InsertKeyFrame(0.75555557F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 138.
                result.InsertKeyFrame(0.766666651F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 140.
                result.InsertKeyFrame(0.777777791F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 142.
                result.InsertKeyFrame(0.788888872F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 144.
                result.InsertKeyFrame(0.800000012F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 146.
                result.InsertKeyFrame(0.811111093F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 148.
                result.InsertKeyFrame(0.822222233F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 150.
                result.InsertKeyFrame(0.833333313F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 152.
                result.InsertKeyFrame(0.844444454F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 154.
                result.InsertKeyFrame(0.855555534F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 156.
                result.InsertKeyFrame(0.866666675F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 158.
                result.InsertKeyFrame(0.877777755F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 160.
                result.InsertKeyFrame(0.888888896F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 162.
                result.InsertKeyFrame(0.899999976F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 164.
                result.InsertKeyFrame(0.911111116F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 166.
                result.InsertKeyFrame(0.922222197F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 168.
                result.InsertKeyFrame(0.933333337F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 170.
                result.InsertKeyFrame(0.944444418F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 172.
                result.InsertKeyFrame(0.955555558F, Path_01(), CubicBezierEasingFunction_4());
                // Frame 174.
                result.InsertKeyFrame(0.966666639F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 176.
                result.InsertKeyFrame(0.977777779F, Path_03(), CubicBezierEasingFunction_4());
                // Frame 178.
                result.InsertKeyFrame(0.98888886F, Path_02(), CubicBezierEasingFunction_4());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_00(), CubicBezierEasingFunction_4());
                return result;
            }

            // - - Layer aggregator
            // -  Offset:<540, 540>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_01()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_00(), HoldThenStepEasingFunction());
                // Frame 2.
                result.InsertKeyFrame(0.0111111114F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 4.
                result.InsertKeyFrame(0.0222222228F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 6.
                result.InsertKeyFrame(0.0333333351F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 8.
                result.InsertKeyFrame(0.0444444455F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 10.
                result.InsertKeyFrame(0.055555556F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 12.
                result.InsertKeyFrame(0.0666666701F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 14.
                result.InsertKeyFrame(0.0777777806F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 16.
                result.InsertKeyFrame(0.088888891F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 18.
                result.InsertKeyFrame(0.100000001F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 22.
                result.InsertKeyFrame(0.122222222F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 24.
                result.InsertKeyFrame(0.13333334F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 26.
                result.InsertKeyFrame(0.144444451F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 28.
                result.InsertKeyFrame(0.155555561F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 30.
                result.InsertKeyFrame(0.166666672F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 32.
                result.InsertKeyFrame(0.177777782F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 34.
                result.InsertKeyFrame(0.188888893F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 36.
                result.InsertKeyFrame(0.200000003F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 38.
                result.InsertKeyFrame(0.211111113F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 40.
                result.InsertKeyFrame(0.222222224F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 42.
                result.InsertKeyFrame(0.233333334F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 44.
                result.InsertKeyFrame(0.244444445F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 46.
                result.InsertKeyFrame(0.25555557F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 48.
                result.InsertKeyFrame(0.266666681F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 50.
                result.InsertKeyFrame(0.277777791F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 52.
                result.InsertKeyFrame(0.288888901F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 54.
                result.InsertKeyFrame(0.300000012F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 56.
                result.InsertKeyFrame(0.311111122F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 58.
                result.InsertKeyFrame(0.322222233F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 60.
                result.InsertKeyFrame(0.333333343F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 62.
                result.InsertKeyFrame(0.344444454F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 64.
                result.InsertKeyFrame(0.355555564F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 66.
                result.InsertKeyFrame(0.366666675F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 68.
                result.InsertKeyFrame(0.377777785F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 70.
                result.InsertKeyFrame(0.388888896F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 72.
                result.InsertKeyFrame(0.400000006F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 74.
                result.InsertKeyFrame(0.411111116F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 76.
                result.InsertKeyFrame(0.422222227F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 78.
                result.InsertKeyFrame(0.433333337F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 80.
                result.InsertKeyFrame(0.444444448F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 82.
                result.InsertKeyFrame(0.455555558F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 84.
                result.InsertKeyFrame(0.466666669F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 86.
                result.InsertKeyFrame(0.477777779F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 88.
                result.InsertKeyFrame(0.48888889F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 92.
                result.InsertKeyFrame(0.51111114F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 94.
                result.InsertKeyFrame(0.522222221F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 96.
                result.InsertKeyFrame(0.533333361F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 98.
                result.InsertKeyFrame(0.544444442F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 100.
                result.InsertKeyFrame(0.555555582F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 102.
                result.InsertKeyFrame(0.566666663F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 104.
                result.InsertKeyFrame(0.577777803F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 106.
                result.InsertKeyFrame(0.588888884F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 108.
                result.InsertKeyFrame(0.600000024F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 112.
                result.InsertKeyFrame(0.622222245F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 114.
                result.InsertKeyFrame(0.633333325F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 116.
                result.InsertKeyFrame(0.644444466F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 118.
                result.InsertKeyFrame(0.655555546F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 120.
                result.InsertKeyFrame(0.666666687F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 122.
                result.InsertKeyFrame(0.677777767F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 124.
                result.InsertKeyFrame(0.688888907F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 126.
                result.InsertKeyFrame(0.699999988F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 128.
                result.InsertKeyFrame(0.711111128F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 130.
                result.InsertKeyFrame(0.722222209F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 132.
                result.InsertKeyFrame(0.733333349F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 134.
                result.InsertKeyFrame(0.74444443F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 136.
                result.InsertKeyFrame(0.75555557F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 138.
                result.InsertKeyFrame(0.766666651F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 140.
                result.InsertKeyFrame(0.777777791F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 142.
                result.InsertKeyFrame(0.788888872F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 144.
                result.InsertKeyFrame(0.800000012F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 146.
                result.InsertKeyFrame(0.811111093F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 148.
                result.InsertKeyFrame(0.822222233F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 150.
                result.InsertKeyFrame(0.833333313F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 152.
                result.InsertKeyFrame(0.844444454F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 154.
                result.InsertKeyFrame(0.855555534F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 156.
                result.InsertKeyFrame(0.866666675F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 158.
                result.InsertKeyFrame(0.877777755F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 160.
                result.InsertKeyFrame(0.888888896F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 162.
                result.InsertKeyFrame(0.899999976F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 164.
                result.InsertKeyFrame(0.911111116F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 166.
                result.InsertKeyFrame(0.922222197F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 168.
                result.InsertKeyFrame(0.933333337F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 170.
                result.InsertKeyFrame(0.944444418F, Path_00(), CubicBezierEasingFunction_4());
                // Frame 172.
                result.InsertKeyFrame(0.955555558F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 174.
                result.InsertKeyFrame(0.966666639F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 176.
                result.InsertKeyFrame(0.977777779F, Path_04(), CubicBezierEasingFunction_4());
                // Frame 178.
                result.InsertKeyFrame(0.98888886F, Path_05(), CubicBezierEasingFunction_4());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_00(), CubicBezierEasingFunction_4());
                return result;
            }

            // - - Layer aggregator
            // -  Offset:<540, 540>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_02()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_06(), HoldThenStepEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, new CompositionPath(Geometry_089()), CubicBezierEasingFunction_5());
                // Frame 179.
                result.InsertKeyFrame(0.99444443F, Path_06(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_03()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_07(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_08(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_07(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_04()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_09(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_10(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_09(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_05()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_11(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_12(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_11(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_06()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_13(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_14(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_13(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_07()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_15(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_16(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_15(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_08()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_17(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_18(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_17(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_09()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_19(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_19(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_19(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_10()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_20(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_21(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_20(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_11()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_22(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_23(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_22(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_12()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_24(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_25(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_24(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_13()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_26(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_27(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_26(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_14()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_28(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_29(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_28(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body
            // - Transforms: body Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_15()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_30(), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, Path_31(), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_30(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_16()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_07(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_07(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_08(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_07(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_17()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_09(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_09(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_10(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_09(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_18()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_11(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_11(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_12(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_11(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_19()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_13(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_13(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_14(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_13(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_20()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_15(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_15(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_16(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_15(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_21()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_17(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_17(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_18(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_17(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_22()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_19(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_19(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_19(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_19(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_23()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_20(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_20(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_21(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_20(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_24()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_22(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_22(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_23(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_22(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_25()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_24(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_24(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_25(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_24(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_26()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_26(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_26(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_27(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_26(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_27()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_28(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_28(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_29(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_28(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 2
            // - Transforms: body 2 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_28()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_30(), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, Path_30(), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, Path_31(), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_30(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_29()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_07(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_07(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_08(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_07(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_30()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_09(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_09(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_10(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_09(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_31()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_11(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_11(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_12(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_11(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_32()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_13(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_13(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_14(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_13(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_33()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_15(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_15(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_16(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_15(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_34()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_17(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_17(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_18(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_17(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_35()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_19(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_19(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_19(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_19(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_36()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_20(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_20(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_21(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_20(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_37()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_22(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_22(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_23(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_22(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_38()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_24(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_24(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_25(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_24(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_39()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_26(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_26(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_27(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_26(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_40()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_28(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_28(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_29(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_28(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 3
            // - Transforms: body 3 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_41()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_30(), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, Path_30(), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, Path_31(), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_30(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_42()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_07(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_07(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_08(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_07(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_43()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_09(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_09(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_10(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_09(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_44()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_11(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_11(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_12(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_11(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_45()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_13(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_13(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_14(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_13(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_46()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_15(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_15(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_16(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_15(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_47()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_17(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_17(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_18(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_17(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path 2+Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_48()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_19(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_19(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_19(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_19(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_49()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_20(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_20(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_21(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_20(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_50()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_22(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_22(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_23(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_22(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_51()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_24(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_24(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_25(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_24(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_52()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_26(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_26(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_27(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_26(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_53()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_28(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_28(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_29(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_28(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: body 4
            // - Transforms: body 4 Offset:<292.929, 119.112>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_54()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, Path_30(), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, Path_30(), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, Path_31(), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, Path_30(), CubicBezierEasingFunction_5());
                return result;
            }

            // - - Layer aggregator
            // - Layer: Layer 18
            // ShapeGroup: Group 1
            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_0_to_0_0()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, HoldThenStepEasingFunction());
                // Frame 9.57.
                result.InsertKeyFrame(0.0531914905F, 360F, CubicBezierEasingFunction_0());
                // Frame 19.15.
                result.InsertKeyFrame(0.106382981F, 0F, CubicBezierEasingFunction_1());
                // Frame 43.09.
                result.InsertKeyFrame(0.239361703F, 0F, CubicBezierEasingFunction_2());
                // Frame 52.66.
                result.InsertKeyFrame(0.292553186F, 360F, CubicBezierEasingFunction_0());
                // Frame 62.23.
                result.InsertKeyFrame(0.345744669F, 0F, CubicBezierEasingFunction_1());
                // Frame 86.17.
                result.InsertKeyFrame(0.478723407F, 0F, CubicBezierEasingFunction_3());
                // Frame 95.74.
                result.InsertKeyFrame(0.53191489F, 360F, CubicBezierEasingFunction_0());
                // Frame 105.32.
                result.InsertKeyFrame(0.585106373F, 0F, CubicBezierEasingFunction_1());
                // Frame 129.26.
                result.InsertKeyFrame(0.71808511F, 0F, CubicBezierEasingFunction_2());
                // Frame 138.83.
                result.InsertKeyFrame(0.771276593F, 360F, CubicBezierEasingFunction_0());
                // Frame 148.4.
                result.InsertKeyFrame(0.824468076F, 0F, CubicBezierEasingFunction_1());
                return result;
            }

            // - - Layer aggregator
            // - Layer: Layer 15
            // ShapeGroup: Group 1
            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_0_to_0_1()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 15.
                result.InsertKeyFrame(0.0833333358F, 0F, HoldThenStepEasingFunction());
                // Frame 25.
                result.InsertKeyFrame(0.138888896F, 360F, CubicBezierEasingFunction_0());
                // Frame 35.
                result.InsertKeyFrame(0.194444448F, 0F, CubicBezierEasingFunction_1());
                // Frame 60.
                result.InsertKeyFrame(0.333333343F, 0F, CubicBezierEasingFunction_2());
                // Frame 70.
                result.InsertKeyFrame(0.388888896F, 360F, CubicBezierEasingFunction_0());
                // Frame 80.
                result.InsertKeyFrame(0.444444448F, 0F, CubicBezierEasingFunction_1());
                // Frame 105.
                result.InsertKeyFrame(0.583333313F, 0F, CubicBezierEasingFunction_3());
                // Frame 115.
                result.InsertKeyFrame(0.638888896F, 360F, CubicBezierEasingFunction_0());
                // Frame 125.
                result.InsertKeyFrame(0.694444418F, 0F, CubicBezierEasingFunction_1());
                // Frame 150.
                result.InsertKeyFrame(0.833333313F, 0F, CubicBezierEasingFunction_2());
                // Frame 160.
                result.InsertKeyFrame(0.888888896F, 360F, CubicBezierEasingFunction_0());
                // Frame 170.
                result.InsertKeyFrame(0.944444418F, 0F, CubicBezierEasingFunction_1());
                return result;
            }

            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_0_to_0_2()
            {
                // Frame 0.
                if (_rotationAngleInDegreesScalarAnimation_0_to_0_2 != null) { return _rotationAngleInDegreesScalarAnimation_0_to_0_2; }
                var result = _rotationAngleInDegreesScalarAnimation_0_to_0_2 = CreateScalarKeyFrameAnimation(0F, 0F, HoldThenStepEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, 18F, CubicBezierEasingFunction_5());
                // Frame 179.
                result.InsertKeyFrame(0.99444443F, 0F, CubicBezierEasingFunction_5());
                return result;
            }

            // - - Layer aggregator
            // - Layer: Layer 14
            // ShapeGroup: Group 1
            // Rotation
            ScalarKeyFrameAnimation RotationAngleInDegreesScalarAnimation_0_to_360()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 170.11.
                result.InsertKeyFrame(0.945054948F, 0F, HoldThenStepEasingFunction());
                // Frame 180.
                result.InsertKeyFrame(1F, 360F, CubicBezierEasingFunction_0());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_0()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_0 != null) { return _scalarAnimation_0_to_0_0; }
                var result = _scalarAnimation_0_to_0_0 = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 160.75.
                result.InsertKeyFrame(0.893048108F, 0F, HoldThenStepEasingFunction());
                // Frame 170.37.
                result.InsertKeyFrame(0.946524084F, 1F, CubicBezierEasingFunction_0());
                // Frame 180.
                result.InsertKeyFrame(1F, 0F, CubicBezierEasingFunction_1());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_1()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_1 != null) { return _scalarAnimation_0_to_0_1; }
                var result = _scalarAnimation_0_to_0_1 = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.0666666701F, 0F, HoldThenStepEasingFunction());
                // Frame 22.
                result.InsertKeyFrame(0.122222222F, 1F, CubicBezierEasingFunction_0());
                // Frame 32.
                result.InsertKeyFrame(0.177777782F, 0F, CubicBezierEasingFunction_1());
                // Frame 57.
                result.InsertKeyFrame(0.316666663F, 0F, CubicBezierEasingFunction_2());
                // Frame 67.
                result.InsertKeyFrame(0.372222215F, 1F, CubicBezierEasingFunction_0());
                // Frame 77.
                result.InsertKeyFrame(0.427777767F, 0F, CubicBezierEasingFunction_1());
                // Frame 102.
                result.InsertKeyFrame(0.566666663F, 0F, CubicBezierEasingFunction_3());
                // Frame 112.
                result.InsertKeyFrame(0.622222245F, 1F, CubicBezierEasingFunction_0());
                // Frame 122.
                result.InsertKeyFrame(0.677777767F, 0F, CubicBezierEasingFunction_1());
                // Frame 147.
                result.InsertKeyFrame(0.816666663F, 0F, CubicBezierEasingFunction_2());
                // Frame 157.
                result.InsertKeyFrame(0.872222245F, 1F, CubicBezierEasingFunction_0());
                // Frame 167.
                result.InsertKeyFrame(0.927777767F, 0F, CubicBezierEasingFunction_1());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_2()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_2 != null) { return _scalarAnimation_0_to_0_2; }
                var result = _scalarAnimation_0_to_0_2 = CreateScalarKeyFrameAnimation(0F, 0F, HoldThenStepEasingFunction());
                // Frame 10.
                result.InsertKeyFrame(0.055555556F, 1F, CubicBezierEasingFunction_0());
                // Frame 20.
                result.InsertKeyFrame(0.111111112F, 0F, CubicBezierEasingFunction_1());
                // Frame 45.
                result.InsertKeyFrame(0.25F, 0F, CubicBezierEasingFunction_2());
                // Frame 55.
                result.InsertKeyFrame(0.305555552F, 1F, CubicBezierEasingFunction_0());
                // Frame 65.
                result.InsertKeyFrame(0.361111104F, 0F, CubicBezierEasingFunction_1());
                // Frame 90.
                result.InsertKeyFrame(0.5F, 0F, CubicBezierEasingFunction_3());
                // Frame 100.
                result.InsertKeyFrame(0.555555582F, 1F, CubicBezierEasingFunction_0());
                // Frame 110.
                result.InsertKeyFrame(0.611111104F, 0F, CubicBezierEasingFunction_1());
                // Frame 135.
                result.InsertKeyFrame(0.75F, 0F, CubicBezierEasingFunction_2());
                // Frame 145.
                result.InsertKeyFrame(0.805555582F, 1F, CubicBezierEasingFunction_0());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, 0F, CubicBezierEasingFunction_1());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_3()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_3 != null) { return _scalarAnimation_0_to_0_3; }
                var result = _scalarAnimation_0_to_0_3 = CreateScalarKeyFrameAnimation(0F, 0F, HoldThenStepEasingFunction());
                // Frame 9.57.
                result.InsertKeyFrame(0.0531914905F, 1F, CubicBezierEasingFunction_0());
                // Frame 19.15.
                result.InsertKeyFrame(0.106382981F, 0F, CubicBezierEasingFunction_1());
                // Frame 43.09.
                result.InsertKeyFrame(0.239361703F, 0F, CubicBezierEasingFunction_2());
                // Frame 52.66.
                result.InsertKeyFrame(0.292553186F, 1F, CubicBezierEasingFunction_0());
                // Frame 62.23.
                result.InsertKeyFrame(0.345744669F, 0F, CubicBezierEasingFunction_1());
                // Frame 86.17.
                result.InsertKeyFrame(0.478723407F, 0F, CubicBezierEasingFunction_3());
                // Frame 95.74.
                result.InsertKeyFrame(0.53191489F, 1F, CubicBezierEasingFunction_0());
                // Frame 105.32.
                result.InsertKeyFrame(0.585106373F, 0F, CubicBezierEasingFunction_1());
                // Frame 129.26.
                result.InsertKeyFrame(0.71808511F, 0F, CubicBezierEasingFunction_2());
                // Frame 138.83.
                result.InsertKeyFrame(0.771276593F, 1F, CubicBezierEasingFunction_0());
                // Frame 148.4.
                result.InsertKeyFrame(0.824468076F, 0F, CubicBezierEasingFunction_1());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_4()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_4 != null) { return _scalarAnimation_0_to_0_4; }
                var result = _scalarAnimation_0_to_0_4 = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 15.
                result.InsertKeyFrame(0.0833333358F, 0F, HoldThenStepEasingFunction());
                // Frame 25.
                result.InsertKeyFrame(0.138888896F, 1F, CubicBezierEasingFunction_0());
                // Frame 35.
                result.InsertKeyFrame(0.194444448F, 0F, CubicBezierEasingFunction_1());
                // Frame 60.
                result.InsertKeyFrame(0.333333343F, 0F, CubicBezierEasingFunction_2());
                // Frame 70.
                result.InsertKeyFrame(0.388888896F, 1F, CubicBezierEasingFunction_0());
                // Frame 80.
                result.InsertKeyFrame(0.444444448F, 0F, CubicBezierEasingFunction_1());
                // Frame 105.
                result.InsertKeyFrame(0.583333313F, 0F, CubicBezierEasingFunction_3());
                // Frame 115.
                result.InsertKeyFrame(0.638888896F, 1F, CubicBezierEasingFunction_0());
                // Frame 125.
                result.InsertKeyFrame(0.694444418F, 0F, CubicBezierEasingFunction_1());
                // Frame 150.
                result.InsertKeyFrame(0.833333313F, 0F, CubicBezierEasingFunction_2());
                // Frame 160.
                result.InsertKeyFrame(0.888888896F, 1F, CubicBezierEasingFunction_0());
                // Frame 170.
                result.InsertKeyFrame(0.944444418F, 0F, CubicBezierEasingFunction_1());
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
                result.InsertKeyFrame(0.188888893F, 1F, CubicBezierEasingFunction_0());
                // Frame 44.
                result.InsertKeyFrame(0.244444445F, 0F, CubicBezierEasingFunction_1());
                // Frame 69.
                result.InsertKeyFrame(0.383333325F, 0F, CubicBezierEasingFunction_2());
                // Frame 79.
                result.InsertKeyFrame(0.438888878F, 1F, CubicBezierEasingFunction_0());
                // Frame 89.
                result.InsertKeyFrame(0.49444443F, 0F, CubicBezierEasingFunction_1());
                // Frame 114.
                result.InsertKeyFrame(0.633333325F, 0F, CubicBezierEasingFunction_3());
                // Frame 124.
                result.InsertKeyFrame(0.688888907F, 1F, CubicBezierEasingFunction_0());
                // Frame 134.
                result.InsertKeyFrame(0.74444443F, 0F, CubicBezierEasingFunction_1());
                // Frame 159.
                result.InsertKeyFrame(0.883333325F, 0F, CubicBezierEasingFunction_2());
                // Frame 169.
                result.InsertKeyFrame(0.938888907F, 1F, CubicBezierEasingFunction_0());
                // Frame 179.
                result.InsertKeyFrame(0.99444443F, 0F, CubicBezierEasingFunction_1());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_0_6()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_0_6 != null) { return _scalarAnimation_0_to_0_6; }
                var result = _scalarAnimation_0_to_0_6 = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 3.
                result.InsertKeyFrame(0.0166666675F, 0F, HoldThenStepEasingFunction());
                // Frame 13.
                result.InsertKeyFrame(0.0722222254F, 1F, CubicBezierEasingFunction_0());
                // Frame 23.
                result.InsertKeyFrame(0.127777785F, 0F, CubicBezierEasingFunction_1());
                // Frame 48.
                result.InsertKeyFrame(0.266666681F, 0F, CubicBezierEasingFunction_2());
                // Frame 58.
                result.InsertKeyFrame(0.322222233F, 1F, CubicBezierEasingFunction_0());
                // Frame 68.
                result.InsertKeyFrame(0.377777785F, 0F, CubicBezierEasingFunction_1());
                // Frame 93.
                result.InsertKeyFrame(0.516666651F, 0F, CubicBezierEasingFunction_3());
                // Frame 103.
                result.InsertKeyFrame(0.572222233F, 1F, CubicBezierEasingFunction_0());
                // Frame 113.
                result.InsertKeyFrame(0.627777755F, 0F, CubicBezierEasingFunction_1());
                // Frame 138.
                result.InsertKeyFrame(0.766666651F, 0F, CubicBezierEasingFunction_2());
                // Frame 148.
                result.InsertKeyFrame(0.822222233F, 1F, CubicBezierEasingFunction_0());
                // Frame 158.
                result.InsertKeyFrame(0.877777755F, 0F, CubicBezierEasingFunction_1());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_0_to_1()
            {
                // Frame 0.
                if (_scalarAnimation_0_to_1 != null) { return _scalarAnimation_0_to_1; }
                var result = _scalarAnimation_0_to_1 = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 170.11.
                result.InsertKeyFrame(0.945054948F, 0F, HoldThenStepEasingFunction());
                // Frame 180.
                result.InsertKeyFrame(1F, 1F, CubicBezierEasingFunction_0());
                return result;
            }

            // Scale
            ScalarKeyFrameAnimation ScalarAnimation_1_to_0()
            {
                // Frame 0.
                if (_scalarAnimation_1_to_0 != null) { return _scalarAnimation_1_to_0; }
                var result = _scalarAnimation_1_to_0 = CreateScalarKeyFrameAnimation(0F, 1F, CubicBezierEasingFunction_0());
                // Frame 9.84.
                result.InsertKeyFrame(0.0546448082F, 0F, CubicBezierEasingFunction_1());
                // Frame 34.43.
                result.InsertKeyFrame(0.191256836F, 0F, CubicBezierEasingFunction_2());
                // Frame 44.26.
                result.InsertKeyFrame(0.245901644F, 1F, CubicBezierEasingFunction_0());
                // Frame 54.1.
                result.InsertKeyFrame(0.300546438F, 0F, CubicBezierEasingFunction_1());
                // Frame 78.69.
                result.InsertKeyFrame(0.437158465F, 0F, CubicBezierEasingFunction_3());
                // Frame 88.52.
                result.InsertKeyFrame(0.491803288F, 1F, CubicBezierEasingFunction_0());
                // Frame 98.36.
                result.InsertKeyFrame(0.546448112F, 0F, CubicBezierEasingFunction_1());
                // Frame 122.95.
                result.InsertKeyFrame(0.68306011F, 0F, CubicBezierEasingFunction_2());
                // Frame 132.79.
                result.InsertKeyFrame(0.737704933F, 1F, CubicBezierEasingFunction_0());
                // Frame 142.62.
                result.InsertKeyFrame(0.792349756F, 0F, CubicBezierEasingFunction_1());
                return result;
            }

            ScalarKeyFrameAnimation t0ScalarAnimation_0_to_1()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 45.
                result.InsertKeyFrame(0.249999985F, 1F, CubicBezierEasingFunction_4());
                // Frame 45.
                result.InsertKeyFrame(0.25000003F, 0F, StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.49999997F, 1F, CubicBezierEasingFunction_4());
                return result;
            }

            ScalarKeyFrameAnimation t1ScalarAnimation_0_to_1()
            {
                // Frame 90.
                var result = CreateScalarKeyFrameAnimation(0.50000006F, 0F, StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 135.
                result.InsertKeyFrame(0.74999994F, 1F, CubicBezierEasingFunction_4());
                // Frame 135.
                result.InsertKeyFrame(0.75000006F, 0F, StepThenHoldEasingFunction());
                // Frame 180.
                result.InsertKeyFrame(0.99999994F, 1F, CubicBezierEasingFunction_4());
                return result;
            }

            ScalarKeyFrameAnimation t2ScalarAnimation_0_to_1()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 90.
                result.InsertKeyFrame(0.49999997F, 1F, CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, 0F, StepThenHoldEasingFunction());
                // Frame 179.
                result.InsertKeyFrame(0.99444437F, 1F, CubicBezierEasingFunction_5());
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_00()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(1080F, 1080F);
                var shapes = result.Shapes;
                // Offset:<540, 540>
                shapes.Add(SpriteShape_000());
                // Layer: Layer 11
                shapes.Add(ContainerShape_00());
                // Layer: Layer 19
                shapes.Add(ContainerShape_01());
                // Layer: Layer 12
                shapes.Add(ContainerShape_02());
                // Layer: Layer 13
                shapes.Add(ContainerShape_03());
                // Layer: Layer 14
                shapes.Add(ContainerShape_04());
                // Layer: Layer 18
                shapes.Add(ContainerShape_05());
                // Layer: Layer 15
                shapes.Add(ContainerShape_06());
                // Layer: Layer 16
                shapes.Add(ContainerShape_07());
                // Layer: Layer 17
                shapes.Add(ContainerShape_08());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_010());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_011());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_012());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_013());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_014());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_015());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_016());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_017());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_018());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_019());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_020());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_021());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_022());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_023());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_024());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_025());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_026());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_027());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_028());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_029());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_030());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_031());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_032());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_033());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_034());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_035());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_036());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_037());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_038());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_039());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_040());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_041());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_042());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_043());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_044());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_045());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_046());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_047());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_048());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_049());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_050());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_051());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_052());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_053());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_054());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_055());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_056());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_057());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_058());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_059());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_060());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_061());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_062());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_063());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_064());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_065());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_066());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_067());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_068());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_069());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_070());
                // Layer: body
                shapes.Add(ContainerShape_09());
                // Layer: body 2
                shapes.Add(ContainerShape_10());
                // Layer: body 3
                shapes.Add(ContainerShape_11());
                // Layer: body 4
                shapes.Add(ContainerShape_12());
                shapes.Add(ContainerShape_13());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_231());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_232());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_233());
                // Offset:<540, 540>
                shapes.Add(SpriteShape_234());
                return result;
            }

            // Shape tree root for layer: Layer 3
            ShapeVisual ShapeVisual_01()
            {
                if (_shapeVisual_01 != null) { return _shapeVisual_01; }
                var result = _shapeVisual_01 = _c.CreateShapeVisual();
                result.Size = new Vector2(1080F, 1080F);
                result.Shapes.Add(ContainerShape_14());
                return result;
            }

            // Shape tree root for layer: Shape Layer 3
            ShapeVisual ShapeVisual_02()
            {
                if (_shapeVisual_02 != null) { return _shapeVisual_02; }
                var result = _shapeVisual_02 = _c.CreateShapeVisual();
                result.Size = new Vector2(1080F, 1080F);
                // Scale:0.98,0.98, Offset:<539.5, 537>
                result.Shapes.Add(SpriteShape_253());
                return result;
            }

            // Shape tree root for layer: Layer 4
            ShapeVisual ShapeVisual_03()
            {
                if (_shapeVisual_03 != null) { return _shapeVisual_03; }
                var result = _shapeVisual_03 = _c.CreateShapeVisual();
                result.Size = new Vector2(1080F, 1080F);
                result.Shapes.Add(ContainerShape_15());
                return result;
            }

            // Shape tree root for layer: Shape Layer 4
            ShapeVisual ShapeVisual_04()
            {
                if (_shapeVisual_04 != null) { return _shapeVisual_04; }
                var result = _shapeVisual_04 = _c.CreateShapeVisual();
                result.Size = new Vector2(1080F, 1080F);
                // Scale:0.98,0.98, Offset:<539.5, 537>
                result.Shapes.Add(SpriteShape_272());
                return result;
            }

            // Shape tree root for layer: Layer 5
            ShapeVisual ShapeVisual_05()
            {
                if (_shapeVisual_05 != null) { return _shapeVisual_05; }
                var result = _shapeVisual_05 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                result.Shapes.Add(ContainerShape_16());
                return result;
            }

            // Shape tree root for layer: Shape Layer 5
            ShapeVisual ShapeVisual_06()
            {
                if (_shapeVisual_06 != null) { return _shapeVisual_06; }
                var result = _shapeVisual_06 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                // Scale:0.98,0.98, Offset:<539.5, 537>
                result.Shapes.Add(SpriteShape_291());
                return result;
            }

            // Shape tree root for layer: Layer 6
            ShapeVisual ShapeVisual_07()
            {
                if (_shapeVisual_07 != null) { return _shapeVisual_07; }
                var result = _shapeVisual_07 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                result.Shapes.Add(ContainerShape_17());
                return result;
            }

            // Shape tree root for layer: Shape Layer 6
            ShapeVisual ShapeVisual_08()
            {
                if (_shapeVisual_08 != null) { return _shapeVisual_08; }
                var result = _shapeVisual_08 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                // Scale:0.98,0.98, Offset:<539.5, 537>
                result.Shapes.Add(SpriteShape_310());
                return result;
            }

            // Shape tree root for layer: Layer 7
            ShapeVisual ShapeVisual_09()
            {
                if (_shapeVisual_09 != null) { return _shapeVisual_09; }
                var result = _shapeVisual_09 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                result.Shapes.Add(ContainerShape_18());
                return result;
            }

            // Shape tree root for layer: Shape Layer 7
            ShapeVisual ShapeVisual_10()
            {
                if (_shapeVisual_10 != null) { return _shapeVisual_10; }
                var result = _shapeVisual_10 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                // Scale:0.98,0.98, Offset:<539.5, 537>
                result.Shapes.Add(SpriteShape_329());
                return result;
            }

            // Shape tree root for layer: Layer 8
            ShapeVisual ShapeVisual_11()
            {
                if (_shapeVisual_11 != null) { return _shapeVisual_11; }
                var result = _shapeVisual_11 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                result.Shapes.Add(ContainerShape_19());
                return result;
            }

            // Shape tree root for layer: Shape Layer 8
            ShapeVisual ShapeVisual_12()
            {
                if (_shapeVisual_12 != null) { return _shapeVisual_12; }
                var result = _shapeVisual_12 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                // Scale:0.98,0.98, Offset:<539.5, 537>
                result.Shapes.Add(SpriteShape_348());
                return result;
            }

            // Shape tree root for layer: Layer 9
            ShapeVisual ShapeVisual_13()
            {
                if (_shapeVisual_13 != null) { return _shapeVisual_13; }
                var result = _shapeVisual_13 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                result.Shapes.Add(ContainerShape_20());
                return result;
            }

            // Shape tree root for layer: Shape Layer 9
            ShapeVisual ShapeVisual_14()
            {
                if (_shapeVisual_14 != null) { return _shapeVisual_14; }
                var result = _shapeVisual_14 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                // Scale:0.98,0.98, Offset:<539.5, 537>
                result.Shapes.Add(SpriteShape_367());
                return result;
            }

            // Shape tree root for layer: Layer 10
            ShapeVisual ShapeVisual_15()
            {
                if (_shapeVisual_15 != null) { return _shapeVisual_15; }
                var result = _shapeVisual_15 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                result.Shapes.Add(ContainerShape_21());
                return result;
            }

            // Shape tree root for layer: Shape Layer 10
            ShapeVisual ShapeVisual_16()
            {
                if (_shapeVisual_16 != null) { return _shapeVisual_16; }
                var result = _shapeVisual_16 = _c.CreateShapeVisual();
                result.IsVisible = false;
                result.Size = new Vector2(1080F, 1080F);
                // Scale:0.98,0.98, Offset:<539.5, 537>
                result.Shapes.Add(SpriteShape_386());
                return result;
            }

            SpriteVisual SpriteVisual_0()
            {
                var result = _c.CreateSpriteVisual();
                result.Size = new Vector2(1080F, 1080F);
                result.Brush = EffectBrush_0();
                return result;
            }

            SpriteVisual SpriteVisual_1()
            {
                var result = _c.CreateSpriteVisual();
                result.Size = new Vector2(1080F, 1080F);
                result.Brush = EffectBrush_1();
                return result;
            }

            SpriteVisual SpriteVisual_2()
            {
                var result = _c.CreateSpriteVisual();
                result.Size = new Vector2(1080F, 1080F);
                result.Brush = EffectBrush_2();
                return result;
            }

            SpriteVisual SpriteVisual_3()
            {
                var result = _c.CreateSpriteVisual();
                result.Size = new Vector2(1080F, 1080F);
                result.Brush = EffectBrush_3();
                return result;
            }

            SpriteVisual SpriteVisual_4()
            {
                var result = _c.CreateSpriteVisual();
                result.Size = new Vector2(1080F, 1080F);
                result.Brush = EffectBrush_4();
                return result;
            }

            SpriteVisual SpriteVisual_5()
            {
                var result = _c.CreateSpriteVisual();
                result.Size = new Vector2(1080F, 1080F);
                result.Brush = EffectBrush_5();
                return result;
            }

            SpriteVisual SpriteVisual_6()
            {
                var result = _c.CreateSpriteVisual();
                result.Size = new Vector2(1080F, 1080F);
                result.Brush = EffectBrush_6();
                return result;
            }

            SpriteVisual SpriteVisual_7()
            {
                var result = _c.CreateSpriteVisual();
                result.Size = new Vector2(1080F, 1080F);
                result.Brush = EffectBrush_7();
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

            // Path animation as a translation.
            Vector2KeyFrameAnimation OffsetVector2Animation_00()
            {
                // Frame 0.
                if (_offsetVector2Animation_00 != null) { return _offsetVector2Animation_00; }
                var result = _offsetVector2Animation_00 = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 22.5.
                result.InsertKeyFrame(0.125F, new Vector2(0F, 0F), CubicBezierEasingFunction_5());
                // Frame 45.
                result.InsertKeyFrame(0.25F, new Vector2(0F, 0F), CubicBezierEasingFunction_5());
                return result;
            }

            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_01()
            {
                // Frame 0.
                if (_offsetVector2Animation_01 != null) { return _offsetVector2Animation_01; }
                var result = _offsetVector2Animation_01 = CreateVector2KeyFrameAnimation(0F, new Vector2(247.072006F, 420.888F), HoldThenStepEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 90.
                result.InsertExpressionKeyFrame(0.49999997F, "Pow(1-_.t2,3)*Vector2(247.072,420.888)+(3*Square(1-_.t2)*_.t2*Vector2(243.739,411.221))+(3*(1-_.t2)*Square(_.t2)*Vector2(227.072,362.888))+(Pow(_.t2,3)*Vector2(227.072,362.888))", StepThenHoldEasingFunction());
                // Frame 179.
                result.InsertExpressionKeyFrame(0.99444437F, "Pow(1-_.t2,3)*Vector2(227.072,362.888)+(3*Square(1-_.t2)*_.t2*Vector2(227.072,362.888))+(3*(1-_.t2)*Square(_.t2)*Vector2(243.739,411.221))+(Pow(_.t2,3)*Vector2(247.072,420.888))", StepThenHoldEasingFunction());
                // Frame 179.
                result.InsertKeyFrame(0.99444443F, new Vector2(247.072006F, 420.888F), StepThenHoldEasingFunction());
                return result;
            }

            // Path animation as a translation.
            Vector2KeyFrameAnimation OffsetVector2Animation_02()
            {
                // Frame 0.
                if (_offsetVector2Animation_02 != null) { return _offsetVector2Animation_02; }
                var result = _offsetVector2Animation_02 = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 67.5.
                result.InsertKeyFrame(0.375F, new Vector2(0F, 0F), CubicBezierEasingFunction_5());
                // Frame 90.
                result.InsertKeyFrame(0.5F, new Vector2(0F, 0F), CubicBezierEasingFunction_5());
                return result;
            }

            // Path animation as a translation.
            Vector2KeyFrameAnimation OffsetVector2Animation_03()
            {
                // Frame 0.
                if (_offsetVector2Animation_03 != null) { return _offsetVector2Animation_03; }
                var result = _offsetVector2Animation_03 = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 112.5.
                result.InsertKeyFrame(0.625F, new Vector2(0F, 0F), CubicBezierEasingFunction_5());
                // Frame 135.
                result.InsertKeyFrame(0.75F, new Vector2(0F, 0F), CubicBezierEasingFunction_5());
                return result;
            }

            // Path animation as a translation.
            Vector2KeyFrameAnimation OffsetVector2Animation_04()
            {
                // Frame 0.
                if (_offsetVector2Animation_04 != null) { return _offsetVector2Animation_04; }
                var result = _offsetVector2Animation_04 = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 157.5.
                result.InsertKeyFrame(0.875F, new Vector2(0F, 0F), CubicBezierEasingFunction_5());
                // Frame 180.
                result.InsertKeyFrame(1F, new Vector2(0F, 0F), CubicBezierEasingFunction_5());
                return result;
            }

            // - Shape tree root for layer: Layer 3
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_05()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(540F, 540F), HoldThenStepEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 45.
                result.InsertExpressionKeyFrame(0.249999985F, "Pow(1-_.t0,3)*Vector2(540,540)+(3*Square(1-_.t0)*_.t0*Vector2(569.917,559.167))+(3*(1-_.t0)*Square(_.t0)*Vector2(689.583,635.833))+(Pow(_.t0,3)*Vector2(719.5,655))", StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, new Vector2(719.5F, 655F), StepThenHoldEasingFunction());
                return result;
            }

            // - Shape tree root for layer: Layer 4
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_06()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(372.5F, 401F), HoldThenStepEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 45.
                result.InsertExpressionKeyFrame(0.249999985F, "Pow(1-_.t0,3)*Vector2(372.5,401)+(3*Square(1-_.t0)*_.t0*Vector2(400.417,424.167))+(3*(1-_.t0)*Square(_.t0)*Vector2(512.083,516.833))+(Pow(_.t0,3)*Vector2(540,540))", StepThenHoldEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, new Vector2(540F, 540F), StepThenHoldEasingFunction());
                return result;
            }

            // - Shape tree root for layer: Layer 5
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_07()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(540F, 540F), StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 45.
                result.InsertKeyFrame(0.25F, new Vector2(540F, 540F), HoldThenStepEasingFunction());
                // Frame 90.
                result.InsertExpressionKeyFrame(0.49999997F, "Pow(1-_.t0,3)*Vector2(540,540)+(3*Square(1-_.t0)*_.t0*Vector2(569.917,559.167))+(3*(1-_.t0)*Square(_.t0)*Vector2(689.583,635.833))+(Pow(_.t0,3)*Vector2(719.5,655))", StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, new Vector2(719.5F, 655F), StepThenHoldEasingFunction());
                return result;
            }

            // - Shape tree root for layer: Layer 6
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_08()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(372.5F, 401F), StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 45.
                result.InsertKeyFrame(0.25F, new Vector2(372.5F, 401F), HoldThenStepEasingFunction());
                // Frame 90.
                result.InsertExpressionKeyFrame(0.49999997F, "Pow(1-_.t0,3)*Vector2(372.5,401)+(3*Square(1-_.t0)*_.t0*Vector2(400.417,424.167))+(3*(1-_.t0)*Square(_.t0)*Vector2(512.083,516.833))+(Pow(_.t0,3)*Vector2(540,540))", StepThenHoldEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, new Vector2(540F, 540F), StepThenHoldEasingFunction());
                return result;
            }

            // - Shape tree root for layer: Layer 7
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_09()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(540F, 540F), StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 90.
                result.InsertKeyFrame(0.5F, new Vector2(540F, 540F), HoldThenStepEasingFunction());
                // Frame 135.
                result.InsertExpressionKeyFrame(0.74999994F, "Pow(1-_.t1,3)*Vector2(540,540)+(3*Square(1-_.t1)*_.t1*Vector2(569.917,559.167))+(3*(1-_.t1)*Square(_.t1)*Vector2(689.583,635.833))+(Pow(_.t1,3)*Vector2(719.5,655))", StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, new Vector2(719.5F, 655F), StepThenHoldEasingFunction());
                return result;
            }

            // - Shape tree root for layer: Layer 8
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_10()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(372.5F, 401F), StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 90.
                result.InsertKeyFrame(0.5F, new Vector2(372.5F, 401F), HoldThenStepEasingFunction());
                // Frame 135.
                result.InsertExpressionKeyFrame(0.74999994F, "Pow(1-_.t1,3)*Vector2(372.5,401)+(3*Square(1-_.t1)*_.t1*Vector2(400.417,424.167))+(3*(1-_.t1)*Square(_.t1)*Vector2(512.083,516.833))+(Pow(_.t1,3)*Vector2(540,540))", StepThenHoldEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, new Vector2(540F, 540F), StepThenHoldEasingFunction());
                return result;
            }

            // - Shape tree root for layer: Layer 9
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_11()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(540F, 540F), StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 135.
                result.InsertKeyFrame(0.75F, new Vector2(540F, 540F), HoldThenStepEasingFunction());
                // Frame 180.
                result.InsertExpressionKeyFrame(0.99999994F, "Pow(1-_.t1,3)*Vector2(540,540)+(3*Square(1-_.t1)*_.t1*Vector2(569.917,559.167))+(3*(1-_.t1)*Square(_.t1)*Vector2(689.583,635.833))+(Pow(_.t1,3)*Vector2(719.5,655))", StepThenHoldEasingFunction());
                // Frame 180.
                result.InsertKeyFrame(1F, new Vector2(719.5F, 655F), StepThenHoldEasingFunction());
                return result;
            }

            // - Shape tree root for layer: Layer 10
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_12()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(372.5F, 401F), StepThenHoldEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 135.
                result.InsertKeyFrame(0.75F, new Vector2(372.5F, 401F), HoldThenStepEasingFunction());
                // Frame 180.
                result.InsertExpressionKeyFrame(0.99999994F, "Pow(1-_.t1,3)*Vector2(372.5,401)+(3*Square(1-_.t1)*_.t1*Vector2(400.417,424.167))+(3*(1-_.t1)*Square(_.t1)*Vector2(512.083,516.833))+(Pow(_.t1,3)*Vector2(540,540))", StepThenHoldEasingFunction());
                // Frame 180.
                result.InsertKeyFrame(1F, new Vector2(540F, 540F), StepThenHoldEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 11
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_00()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 167.
                result.InsertKeyFrame(0.927777767F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 19
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_01()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 142.
                result.InsertKeyFrame(0.788888872F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 12
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_02()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.0666666701F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 167.
                result.InsertKeyFrame(0.927777767F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 13
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_03()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 155.
                result.InsertKeyFrame(0.861111104F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 14
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_04()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 172.
                result.InsertKeyFrame(0.955555558F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 18
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_05()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 147.
                result.InsertKeyFrame(0.816666663F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 15
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_06()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 15.
                result.InsertKeyFrame(0.0833333358F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 170.
                result.InsertKeyFrame(0.944444418F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 16
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_07()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 24.
                result.InsertKeyFrame(0.13333334F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 179.
                result.InsertKeyFrame(0.99444443F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: Layer 17
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_08()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 3.
                result.InsertKeyFrame(0.0166666675F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 158.
                result.InsertKeyFrame(0.877777755F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: body
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_09()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: body 2
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_10()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 45.
                result.InsertKeyFrame(0.25F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: body 3
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_11()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 90.
                result.InsertKeyFrame(0.5F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                return result;
            }

            // - Layer aggregator
            // Layer: body 4
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_12()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 135.
                result.InsertKeyFrame(0.75F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                return result;
            }

            internal Astronaut2_AnimatedVisual(
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
                StartProgressBoundAnimation(_containerShape_00, "Scale", ShapeVisibilityAnimation_00(), RootProgress());
                StartProgressBoundAnimation(_containerShape_01, "Scale", ShapeVisibilityAnimation_01(), RootProgress());
                StartProgressBoundAnimation(_containerShape_02, "Scale", ShapeVisibilityAnimation_02(), RootProgress());
                StartProgressBoundAnimation(_containerShape_03, "Scale", ShapeVisibilityAnimation_03(), RootProgress());
                StartProgressBoundAnimation(_containerShape_04, "Scale", ShapeVisibilityAnimation_04(), RootProgress());
                StartProgressBoundAnimation(_containerShape_05, "Scale", ShapeVisibilityAnimation_05(), RootProgress());
                StartProgressBoundAnimation(_containerShape_06, "Scale", ShapeVisibilityAnimation_06(), RootProgress());
                StartProgressBoundAnimation(_containerShape_07, "Scale", ShapeVisibilityAnimation_07(), RootProgress());
                StartProgressBoundAnimation(_containerShape_08, "Scale", ShapeVisibilityAnimation_08(), RootProgress());
                StartProgressBoundAnimation(_containerShape_09, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_2(), RootProgress());
                StartProgressBoundAnimation(_containerShape_09, "Offset", OffsetVector2Animation_01(), RootProgress());
                StartProgressBoundAnimation(_containerShape_09, "Scale", ShapeVisibilityAnimation_09(), RootProgress());
                StartProgressBoundAnimation(_containerShape_10, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_2(), RootProgress());
                StartProgressBoundAnimation(_containerShape_10, "Offset", OffsetVector2Animation_01(), RootProgress());
                StartProgressBoundAnimation(_containerShape_10, "Scale", ShapeVisibilityAnimation_10(), RootProgress());
                StartProgressBoundAnimation(_containerShape_11, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_2(), RootProgress());
                StartProgressBoundAnimation(_containerShape_11, "Offset", OffsetVector2Animation_01(), RootProgress());
                StartProgressBoundAnimation(_containerShape_11, "Scale", ShapeVisibilityAnimation_11(), RootProgress());
                StartProgressBoundAnimation(_containerShape_12, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_2(), RootProgress());
                StartProgressBoundAnimation(_containerShape_12, "Offset", OffsetVector2Animation_01(), RootProgress());
                StartProgressBoundAnimation(_containerShape_12, "Scale", ShapeVisibilityAnimation_12(), RootProgress());
                StartProgressBoundAnimation(_containerShape_13, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_2(), RootProgress());
                StartProgressBoundAnimation(_containerShape_13, "Offset", OffsetVector2Animation_01(), RootProgress());
                StartProgressBoundAnimation(_containerShape_14, "Offset", OffsetVector2Animation_05(), RootProgress());
                StartProgressBoundAnimation(_containerShape_15, "Offset", OffsetVector2Animation_06(), RootProgress());
                StartProgressBoundAnimation(_containerShape_16, "Offset", OffsetVector2Animation_07(), RootProgress());
                StartProgressBoundAnimation(_containerShape_17, "Offset", OffsetVector2Animation_08(), RootProgress());
                StartProgressBoundAnimation(_containerShape_18, "Offset", OffsetVector2Animation_09(), RootProgress());
                StartProgressBoundAnimation(_containerShape_19, "Offset", OffsetVector2Animation_10(), RootProgress());
                StartProgressBoundAnimation(_containerShape_20, "Offset", OffsetVector2Animation_11(), RootProgress());
                StartProgressBoundAnimation(_containerShape_21, "Offset", OffsetVector2Animation_12(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_008, "Path", PathKeyFrameAnimation_00(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_009, "Path", PathKeyFrameAnimation_01(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_068, "Path", PathKeyFrameAnimation_02(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_069, "Path", PathKeyFrameAnimation_03(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_070, "Path", PathKeyFrameAnimation_04(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_071, "Path", PathKeyFrameAnimation_05(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_075, "Path", PathKeyFrameAnimation_06(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_076, "Path", PathKeyFrameAnimation_07(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_077, "Path", PathKeyFrameAnimation_08(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_085, "Path", PathKeyFrameAnimation_09(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_090, "Path", PathKeyFrameAnimation_10(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_091, "Path", PathKeyFrameAnimation_11(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_094, "Path", PathKeyFrameAnimation_12(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_095, "Path", PathKeyFrameAnimation_13(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_096, "Path", PathKeyFrameAnimation_14(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_097, "Path", PathKeyFrameAnimation_15(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_103, "Path", PathKeyFrameAnimation_16(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_104, "Path", PathKeyFrameAnimation_17(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_105, "Path", PathKeyFrameAnimation_18(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_106, "Path", PathKeyFrameAnimation_19(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_107, "Path", PathKeyFrameAnimation_20(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_108, "Path", PathKeyFrameAnimation_21(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_109, "Path", PathKeyFrameAnimation_22(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_110, "Path", PathKeyFrameAnimation_23(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_111, "Path", PathKeyFrameAnimation_24(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_112, "Path", PathKeyFrameAnimation_25(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_113, "Path", PathKeyFrameAnimation_26(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_114, "Path", PathKeyFrameAnimation_27(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_115, "Path", PathKeyFrameAnimation_28(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_116, "Path", PathKeyFrameAnimation_29(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_117, "Path", PathKeyFrameAnimation_30(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_118, "Path", PathKeyFrameAnimation_31(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_119, "Path", PathKeyFrameAnimation_32(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_120, "Path", PathKeyFrameAnimation_33(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_121, "Path", PathKeyFrameAnimation_34(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_122, "Path", PathKeyFrameAnimation_35(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_123, "Path", PathKeyFrameAnimation_36(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_124, "Path", PathKeyFrameAnimation_37(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_125, "Path", PathKeyFrameAnimation_38(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_126, "Path", PathKeyFrameAnimation_39(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_127, "Path", PathKeyFrameAnimation_40(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_128, "Path", PathKeyFrameAnimation_41(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_129, "Path", PathKeyFrameAnimation_42(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_130, "Path", PathKeyFrameAnimation_43(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_131, "Path", PathKeyFrameAnimation_44(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_132, "Path", PathKeyFrameAnimation_45(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_133, "Path", PathKeyFrameAnimation_46(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_134, "Path", PathKeyFrameAnimation_47(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_135, "Path", PathKeyFrameAnimation_48(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_136, "Path", PathKeyFrameAnimation_49(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_137, "Path", PathKeyFrameAnimation_50(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_138, "Path", PathKeyFrameAnimation_51(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_139, "Path", PathKeyFrameAnimation_52(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_140, "Path", PathKeyFrameAnimation_53(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_141, "Path", PathKeyFrameAnimation_54(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_001, "Scale.X", ScalarAnimation_0_to_0_0(), RootProgressRemapped_0());
                StartProgressBoundAnimation(_spriteShape_001, "Scale.Y", ScalarAnimation_0_to_0_0(), RootProgressRemapped_0());
                StartProgressBoundAnimation(_spriteShape_002, "Scale.X", ScalarAnimation_1_to_0(), RootProgressRemapped_1());
                StartProgressBoundAnimation(_spriteShape_002, "Scale.Y", ScalarAnimation_1_to_0(), RootProgressRemapped_1());
                StartProgressBoundAnimation(_spriteShape_003, "Scale.X", ScalarAnimation_0_to_0_1(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_003, "Scale.Y", ScalarAnimation_0_to_0_1(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_004, "Scale.X", ScalarAnimation_0_to_0_2(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_004, "Scale.Y", ScalarAnimation_0_to_0_2(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_005, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_360(), RootProgressRemapped_2());
                StartProgressBoundAnimation(_spriteShape_005, "Scale.X", ScalarAnimation_0_to_1(), RootProgressRemapped_2());
                StartProgressBoundAnimation(_spriteShape_005, "Scale.Y", ScalarAnimation_0_to_1(), RootProgressRemapped_2());
                StartProgressBoundAnimation(_spriteShape_006, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_0(), RootProgressRemapped_3());
                StartProgressBoundAnimation(_spriteShape_006, "Scale.X", ScalarAnimation_0_to_0_3(), RootProgressRemapped_3());
                StartProgressBoundAnimation(_spriteShape_006, "Scale.Y", ScalarAnimation_0_to_0_3(), RootProgressRemapped_3());
                StartProgressBoundAnimation(_spriteShape_007, "RotationAngleInDegrees", RotationAngleInDegreesScalarAnimation_0_to_0_1(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_007, "Scale.X", ScalarAnimation_0_to_0_4(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_007, "Scale.Y", ScalarAnimation_0_to_0_4(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_008, "Scale.X", ScalarAnimation_0_to_0_5(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_008, "Scale.Y", ScalarAnimation_0_to_0_5(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_009, "Scale.X", ScalarAnimation_0_to_0_6(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_009, "Scale.Y", ScalarAnimation_0_to_0_6(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_074, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_075, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_076, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_080, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_081, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_082, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_083, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_084, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_085, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_086, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_088, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_089, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_090, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_091, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_094, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_095, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_100, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_101, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_102, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_103, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_104, "Offset", OffsetVector2Animation_00(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_108, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_109, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_110, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_114, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_115, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_116, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_117, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_118, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_119, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_120, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_122, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_123, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_124, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_125, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_128, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_129, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_134, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_135, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_136, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_137, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_138, "Offset", OffsetVector2Animation_02(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_142, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_143, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_144, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_148, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_149, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_150, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_151, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_152, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_153, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_154, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_156, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_157, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_158, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_159, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_162, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_163, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_168, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_169, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_170, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_171, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_172, "Offset", OffsetVector2Animation_03(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_176, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_177, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_178, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_182, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_183, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_184, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_185, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_186, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_187, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_188, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_190, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_191, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_192, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_193, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_196, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_197, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_202, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_203, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_204, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_205, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_206, "Offset", OffsetVector2Animation_04(), RootProgress());
                StartProgressBoundAnimation(_root.Properties, "t0", t0ScalarAnimation_0_to_1(), RootProgress());
                StartProgressBoundAnimation(_root.Properties, "t1", t1ScalarAnimation_0_to_1(), RootProgress());
                StartProgressBoundAnimation(_root.Properties, "t2", t2ScalarAnimation_0_to_1(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_01, "IsVisible", IsVisibleBooleanAnimation_0(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_02, "IsVisible", IsVisibleBooleanAnimation_0(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_03, "IsVisible", IsVisibleBooleanAnimation_0(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_04, "IsVisible", IsVisibleBooleanAnimation_0(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_05, "IsVisible", IsVisibleBooleanAnimation_1(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_06, "IsVisible", IsVisibleBooleanAnimation_1(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_07, "IsVisible", IsVisibleBooleanAnimation_1(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_08, "IsVisible", IsVisibleBooleanAnimation_1(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_09, "IsVisible", IsVisibleBooleanAnimation_2(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_10, "IsVisible", IsVisibleBooleanAnimation_2(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_11, "IsVisible", IsVisibleBooleanAnimation_2(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_12, "IsVisible", IsVisibleBooleanAnimation_2(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_13, "IsVisible", IsVisibleBooleanAnimation_3(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_14, "IsVisible", IsVisibleBooleanAnimation_3(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_15, "IsVisible", IsVisibleBooleanAnimation_3(), RootProgress());
                StartProgressBoundAnimation(_shapeVisual_16, "IsVisible", IsVisibleBooleanAnimation_3(), RootProgress());
            }

            public void DestroyAnimations()
            {
                _containerShape_00.StopAnimation("Scale");
                _containerShape_01.StopAnimation("Scale");
                _containerShape_02.StopAnimation("Scale");
                _containerShape_03.StopAnimation("Scale");
                _containerShape_04.StopAnimation("Scale");
                _containerShape_05.StopAnimation("Scale");
                _containerShape_06.StopAnimation("Scale");
                _containerShape_07.StopAnimation("Scale");
                _containerShape_08.StopAnimation("Scale");
                _containerShape_09.StopAnimation("RotationAngleInDegrees");
                _containerShape_09.StopAnimation("Offset");
                _containerShape_09.StopAnimation("Scale");
                _containerShape_10.StopAnimation("RotationAngleInDegrees");
                _containerShape_10.StopAnimation("Offset");
                _containerShape_10.StopAnimation("Scale");
                _containerShape_11.StopAnimation("RotationAngleInDegrees");
                _containerShape_11.StopAnimation("Offset");
                _containerShape_11.StopAnimation("Scale");
                _containerShape_12.StopAnimation("RotationAngleInDegrees");
                _containerShape_12.StopAnimation("Offset");
                _containerShape_12.StopAnimation("Scale");
                _containerShape_13.StopAnimation("RotationAngleInDegrees");
                _containerShape_13.StopAnimation("Offset");
                _containerShape_14.StopAnimation("Offset");
                _containerShape_15.StopAnimation("Offset");
                _containerShape_16.StopAnimation("Offset");
                _containerShape_17.StopAnimation("Offset");
                _containerShape_18.StopAnimation("Offset");
                _containerShape_19.StopAnimation("Offset");
                _containerShape_20.StopAnimation("Offset");
                _containerShape_21.StopAnimation("Offset");
                _pathGeometry_008.StopAnimation("Path");
                _pathGeometry_009.StopAnimation("Path");
                _pathGeometry_068.StopAnimation("Path");
                _pathGeometry_069.StopAnimation("Path");
                _pathGeometry_070.StopAnimation("Path");
                _pathGeometry_071.StopAnimation("Path");
                _pathGeometry_075.StopAnimation("Path");
                _pathGeometry_076.StopAnimation("Path");
                _pathGeometry_077.StopAnimation("Path");
                _pathGeometry_085.StopAnimation("Path");
                _pathGeometry_090.StopAnimation("Path");
                _pathGeometry_091.StopAnimation("Path");
                _pathGeometry_094.StopAnimation("Path");
                _pathGeometry_095.StopAnimation("Path");
                _pathGeometry_096.StopAnimation("Path");
                _pathGeometry_097.StopAnimation("Path");
                _pathGeometry_103.StopAnimation("Path");
                _pathGeometry_104.StopAnimation("Path");
                _pathGeometry_105.StopAnimation("Path");
                _pathGeometry_106.StopAnimation("Path");
                _pathGeometry_107.StopAnimation("Path");
                _pathGeometry_108.StopAnimation("Path");
                _pathGeometry_109.StopAnimation("Path");
                _pathGeometry_110.StopAnimation("Path");
                _pathGeometry_111.StopAnimation("Path");
                _pathGeometry_112.StopAnimation("Path");
                _pathGeometry_113.StopAnimation("Path");
                _pathGeometry_114.StopAnimation("Path");
                _pathGeometry_115.StopAnimation("Path");
                _pathGeometry_116.StopAnimation("Path");
                _pathGeometry_117.StopAnimation("Path");
                _pathGeometry_118.StopAnimation("Path");
                _pathGeometry_119.StopAnimation("Path");
                _pathGeometry_120.StopAnimation("Path");
                _pathGeometry_121.StopAnimation("Path");
                _pathGeometry_122.StopAnimation("Path");
                _pathGeometry_123.StopAnimation("Path");
                _pathGeometry_124.StopAnimation("Path");
                _pathGeometry_125.StopAnimation("Path");
                _pathGeometry_126.StopAnimation("Path");
                _pathGeometry_127.StopAnimation("Path");
                _pathGeometry_128.StopAnimation("Path");
                _pathGeometry_129.StopAnimation("Path");
                _pathGeometry_130.StopAnimation("Path");
                _pathGeometry_131.StopAnimation("Path");
                _pathGeometry_132.StopAnimation("Path");
                _pathGeometry_133.StopAnimation("Path");
                _pathGeometry_134.StopAnimation("Path");
                _pathGeometry_135.StopAnimation("Path");
                _pathGeometry_136.StopAnimation("Path");
                _pathGeometry_137.StopAnimation("Path");
                _pathGeometry_138.StopAnimation("Path");
                _pathGeometry_139.StopAnimation("Path");
                _pathGeometry_140.StopAnimation("Path");
                _pathGeometry_141.StopAnimation("Path");
                _spriteShape_001.StopAnimation("Scale.X");
                _spriteShape_001.StopAnimation("Scale.Y");
                _spriteShape_002.StopAnimation("Scale.X");
                _spriteShape_002.StopAnimation("Scale.Y");
                _spriteShape_003.StopAnimation("Scale.X");
                _spriteShape_003.StopAnimation("Scale.Y");
                _spriteShape_004.StopAnimation("Scale.X");
                _spriteShape_004.StopAnimation("Scale.Y");
                _spriteShape_005.StopAnimation("RotationAngleInDegrees");
                _spriteShape_005.StopAnimation("Scale.X");
                _spriteShape_005.StopAnimation("Scale.Y");
                _spriteShape_006.StopAnimation("RotationAngleInDegrees");
                _spriteShape_006.StopAnimation("Scale.X");
                _spriteShape_006.StopAnimation("Scale.Y");
                _spriteShape_007.StopAnimation("RotationAngleInDegrees");
                _spriteShape_007.StopAnimation("Scale.X");
                _spriteShape_007.StopAnimation("Scale.Y");
                _spriteShape_008.StopAnimation("Scale.X");
                _spriteShape_008.StopAnimation("Scale.Y");
                _spriteShape_009.StopAnimation("Scale.X");
                _spriteShape_009.StopAnimation("Scale.Y");
                _spriteShape_074.StopAnimation("Offset");
                _spriteShape_075.StopAnimation("Offset");
                _spriteShape_076.StopAnimation("Offset");
                _spriteShape_080.StopAnimation("Offset");
                _spriteShape_081.StopAnimation("Offset");
                _spriteShape_082.StopAnimation("Offset");
                _spriteShape_083.StopAnimation("Offset");
                _spriteShape_084.StopAnimation("Offset");
                _spriteShape_085.StopAnimation("Offset");
                _spriteShape_086.StopAnimation("Offset");
                _spriteShape_088.StopAnimation("Offset");
                _spriteShape_089.StopAnimation("Offset");
                _spriteShape_090.StopAnimation("Offset");
                _spriteShape_091.StopAnimation("Offset");
                _spriteShape_094.StopAnimation("Offset");
                _spriteShape_095.StopAnimation("Offset");
                _spriteShape_100.StopAnimation("Offset");
                _spriteShape_101.StopAnimation("Offset");
                _spriteShape_102.StopAnimation("Offset");
                _spriteShape_103.StopAnimation("Offset");
                _spriteShape_104.StopAnimation("Offset");
                _spriteShape_108.StopAnimation("Offset");
                _spriteShape_109.StopAnimation("Offset");
                _spriteShape_110.StopAnimation("Offset");
                _spriteShape_114.StopAnimation("Offset");
                _spriteShape_115.StopAnimation("Offset");
                _spriteShape_116.StopAnimation("Offset");
                _spriteShape_117.StopAnimation("Offset");
                _spriteShape_118.StopAnimation("Offset");
                _spriteShape_119.StopAnimation("Offset");
                _spriteShape_120.StopAnimation("Offset");
                _spriteShape_122.StopAnimation("Offset");
                _spriteShape_123.StopAnimation("Offset");
                _spriteShape_124.StopAnimation("Offset");
                _spriteShape_125.StopAnimation("Offset");
                _spriteShape_128.StopAnimation("Offset");
                _spriteShape_129.StopAnimation("Offset");
                _spriteShape_134.StopAnimation("Offset");
                _spriteShape_135.StopAnimation("Offset");
                _spriteShape_136.StopAnimation("Offset");
                _spriteShape_137.StopAnimation("Offset");
                _spriteShape_138.StopAnimation("Offset");
                _spriteShape_142.StopAnimation("Offset");
                _spriteShape_143.StopAnimation("Offset");
                _spriteShape_144.StopAnimation("Offset");
                _spriteShape_148.StopAnimation("Offset");
                _spriteShape_149.StopAnimation("Offset");
                _spriteShape_150.StopAnimation("Offset");
                _spriteShape_151.StopAnimation("Offset");
                _spriteShape_152.StopAnimation("Offset");
                _spriteShape_153.StopAnimation("Offset");
                _spriteShape_154.StopAnimation("Offset");
                _spriteShape_156.StopAnimation("Offset");
                _spriteShape_157.StopAnimation("Offset");
                _spriteShape_158.StopAnimation("Offset");
                _spriteShape_159.StopAnimation("Offset");
                _spriteShape_162.StopAnimation("Offset");
                _spriteShape_163.StopAnimation("Offset");
                _spriteShape_168.StopAnimation("Offset");
                _spriteShape_169.StopAnimation("Offset");
                _spriteShape_170.StopAnimation("Offset");
                _spriteShape_171.StopAnimation("Offset");
                _spriteShape_172.StopAnimation("Offset");
                _spriteShape_176.StopAnimation("Offset");
                _spriteShape_177.StopAnimation("Offset");
                _spriteShape_178.StopAnimation("Offset");
                _spriteShape_182.StopAnimation("Offset");
                _spriteShape_183.StopAnimation("Offset");
                _spriteShape_184.StopAnimation("Offset");
                _spriteShape_185.StopAnimation("Offset");
                _spriteShape_186.StopAnimation("Offset");
                _spriteShape_187.StopAnimation("Offset");
                _spriteShape_188.StopAnimation("Offset");
                _spriteShape_190.StopAnimation("Offset");
                _spriteShape_191.StopAnimation("Offset");
                _spriteShape_192.StopAnimation("Offset");
                _spriteShape_193.StopAnimation("Offset");
                _spriteShape_196.StopAnimation("Offset");
                _spriteShape_197.StopAnimation("Offset");
                _spriteShape_202.StopAnimation("Offset");
                _spriteShape_203.StopAnimation("Offset");
                _spriteShape_204.StopAnimation("Offset");
                _spriteShape_205.StopAnimation("Offset");
                _spriteShape_206.StopAnimation("Offset");
                _root.Properties.StopAnimation("t0");
                _root.Properties.StopAnimation("t1");
                _root.Properties.StopAnimation("t2");
                _shapeVisual_01.StopAnimation("IsVisible");
                _shapeVisual_02.StopAnimation("IsVisible");
                _shapeVisual_03.StopAnimation("IsVisible");
                _shapeVisual_04.StopAnimation("IsVisible");
                _shapeVisual_05.StopAnimation("IsVisible");
                _shapeVisual_06.StopAnimation("IsVisible");
                _shapeVisual_07.StopAnimation("IsVisible");
                _shapeVisual_08.StopAnimation("IsVisible");
                _shapeVisual_09.StopAnimation("IsVisible");
                _shapeVisual_10.StopAnimation("IsVisible");
                _shapeVisual_11.StopAnimation("IsVisible");
                _shapeVisual_12.StopAnimation("IsVisible");
                _shapeVisual_13.StopAnimation("IsVisible");
                _shapeVisual_14.StopAnimation("IsVisible");
                _shapeVisual_15.StopAnimation("IsVisible");
                _shapeVisual_16.StopAnimation("IsVisible");
            }

        }
    }
}
