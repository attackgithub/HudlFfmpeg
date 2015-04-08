﻿using Hudl.FFmpeg.Attributes;
using Hudl.FFmpeg.BaseTypes;
using Hudl.FFmpeg.Resources.BaseTypes;

namespace Hudl.FFmpeg.Resources
{
    [ContainsStream(Type = typeof(VideoStream))]
    public class Jpg : BaseContainer
    {
        private const string FileFormat = ".jpg";

        public Jpg() 
            : base(FileFormat)
        {
        }

        protected override IContainer Clone()
        {
            return new Jpg();
        }
    }
}
