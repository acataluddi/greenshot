// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2019 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: http://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using Greenshot.Gfx;

namespace Greenshot.Addons.Interfaces.Drawing
{
    /// <summary>
    /// The interface for the Bitmap Container
    /// </summary>
	public interface IBitmapContainer : IDrawableContainer
	{
        /// <summary>
        /// The actual IBitmap
        /// </summary>
        IBitmapWithNativeSupport Bitmap { get; set; }

		/// <summary>
		/// Load a bitmap into this container
		/// </summary>
		/// <param name="filename">string</param>
		void Load(string filename);
	}
}