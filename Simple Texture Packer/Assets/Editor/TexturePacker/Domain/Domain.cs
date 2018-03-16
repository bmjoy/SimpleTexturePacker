﻿using System;
using Editor.TexturePacker.Domain.Entities;
using UnityEngine;

namespace Editor.TexturePacker.Domain
{
	public static class Domain
	{
		public static FramesContainer LoadContainer(TextAsset asset)
		{
			var data = asset.text;
			var container = default(FramesContainer);
			try
			{
				container = JsonUtility.FromJson<FramesContainer>(data);
			}
			catch (Exception e)
			{
				Debug.Log(e.Message);
				throw;
			}
			return container;
		}
	}
}