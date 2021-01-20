﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SpriteSheetEditor
{
    [DefaultPropertyAttribute("Image")]
    public class PreviewProperty : IDisposable
    {
        // Constants
        private const int DefaultFPS = 60;
        private const float DefaultAnimationSpeed = 0.1f;

        #region Properties
        private Bitmap m_Image = null;
        [CategoryAttribute("Basic"), DescriptionAttribute("The spritesheet.")]
        public Bitmap Image
        {
            get { return m_Image; }
            set
            {
                m_Image = value;
                CurrentFrame = 0;
            }
        }

        private Point m_SourceOffset = new Point(0,0);
        [CategoryAttribute("Basic"), DescriptionAttribute("The SourceRectangle offset.")]
        public Point SourceOffset
        {
            get { return m_SourceOffset; }
            set { m_SourceOffset = value; }
        }

        private bool m_Paused = false;
        [CategoryAttribute("Basic"), DescriptionAttribute("Pauses the animation.")]
        public bool Paused
        {
            get { return m_Paused; }
            set { m_Paused = value; }
        }

        private int m_FPS = DefaultFPS;
        [CategoryAttribute("Basic"), DescriptionAttribute("FPS to preview the animation.")]
        public int FPS
        {
            get { return m_FPS; }
            set
            {
                m_FPS = value;
                if (m_FPS < 0)
                    m_FPS = 0;
                if (m_FPS > 999)
                    m_FPS = 999;
            }
        }

        private int m_FrameWidth;
        [CategoryAttribute("Basic"), DescriptionAttribute("Width of each frame.")]
        public int FrameWidth
        {
            get { return m_FrameWidth; }
            set
            {
                m_FrameWidth = value;
                if (m_FrameWidth < 1)
                    m_FrameWidth = 1;
                DrawArea.Width = m_FrameWidth;
            }
        }

        private int m_FrameHeight;
        [CategoryAttribute("Basic"), DescriptionAttribute("Height of each frame.")]
        public int FrameHeight
        {
            get { return m_FrameHeight; }
            set
            {
                m_FrameHeight = value;
                if (m_FrameHeight < 1)
                    m_FrameHeight = 1;
                DrawArea.Height = m_FrameHeight;
            }
        }

        private int m_FrameCount = 1;
        [CategoryAttribute("Basic"), DescriptionAttribute("Number of frames.")]
        public int FrameCount
        {
            get { return m_FrameCount; }
            set
            {
                m_FrameCount = value;
                if (m_FrameCount < 1)
                    m_FrameCount = 1;
            }
        }

        private Color m_BackgroundColor = Color.White;
        [CategoryAttribute("View"), DescriptionAttribute("Background color")]
        public Color BackgroundColor
        {
            get { return m_BackgroundColor; }
            set { DrawArea.BackColor = m_BackgroundColor = value; }
        }

        private int m_CurrentFrame = 0;
        private int CurrentFrame
        {
            get { return m_CurrentFrame; }
            set { m_CurrentFrame = value; if (CurrentFrame > FrameCount - 1) CurrentFrame = 0; }
        }
        #endregion

        private PictureBox DrawArea;
        private Bitmap Frame = null;

        public PreviewProperty(ref PictureBox pb)
        {
            DrawArea = pb;
            double interval = (double)Stopwatch.Frequency / (double)DefaultFPS;
            FrameWidth = FrameHeight = 64;
        }

        private double GetInterval()
        {
            return (double)Stopwatch.Frequency / FPS;
        }

        public void Run()
        {
            // FPS set up
            long ticks1 = 0;
            long ticks2 = 0;

            while (true)
            {
                if (!Paused)
                {
                    double interval = GetInterval();

                    Application.DoEvents();

                    if (Image != null)
                    {
                        ticks2 = Stopwatch.GetTimestamp();
                        if (ticks2 >= ticks1 + interval)
                        {
                            ticks1 = Stopwatch.GetTimestamp();

                            CurrentFrame++;
                            DrawNextFrame();
                        }

                        Thread.Sleep(1); // Free's up the cpu
                    }
                }
            }
        }

        void DrawNextFrame()
        {
            if (Image != null)
            {
                // Draw and such
                Frame = Util.CopyBitMapRegion(Image, new Rectangle(SourceOffset.X + CurrentFrame * FrameWidth, SourceOffset.Y, FrameWidth, FrameHeight));
                DrawArea.Image = Frame;
            }
        }

        public void Dispose()
        {
            if (Image != null)
                Image.Dispose();
            DrawArea.Image = null;
            if (Frame != null)
                Frame.Dispose();
        }
    }
}