﻿using System;

namespace TexturePacker.Editor.Domain.Entities
{
	[Serializable]
	public class Frame
	{
		public string filename;
		public FrameRect frame;
		public bool rotated;
		public bool trimmed;
		public FrameRect spriteSourceSize;
		public FrameSize sourceSize;
		public FrameVector pivot;
	}
}