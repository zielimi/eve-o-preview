﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace EveOPreview.View
{
	public interface IThumbnailView : IView
	{
		IntPtr Id { get; set; }
		string Title { get; set; }

		bool IsActive { get; set; }
		Point ThumbnailLocation { get; set; }
		Size ThumbnailSize { get; set; }
		bool IsOverlayEnabled { get; set; }

		bool IsKnownHandle(IntPtr handle);

		void SetSizeLimitations(Size minimumSize, Size maximumSize);
		void SetOpacity(double opacity);
		void SetFrames(bool enable);
		void SetTopMost(bool enableTopmost);
		void SetHighlight(bool enabled, Color color, int width);

		void ZoomIn(ViewZoomAnchor anchor, int zoomFactor);
		void ZoomOut();

		void RegisterHotkey(Keys hotkey);
		void UnregisterHotkey();

		void Refresh(bool forceRefresh);

		Action<IntPtr> ThumbnailResized { get; set; }
		Action<IntPtr> ThumbnailMoved { get; set; }
		Action<IntPtr> ThumbnailFocused { get; set; }
		Action<IntPtr> ThumbnailLostFocus { get; set; }

		Action<IntPtr, bool> ThumbnailActivated { get; set; }
		Action<IntPtr, bool> ThumbnailDeactivated { get; set; }
	}
}