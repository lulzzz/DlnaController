﻿
using Microsoft.Extensions.Logging;

namespace SV.UPnPLite.Core
{
    public class PhotoItem : ImageItem
	{
        #region Constructors

        /// <summary>
        ///		Initializes a new instance of the <see cref="PhotoItem"/> class.
        /// </summary>
        /// <param name="loggerFactory">
        ///		The log manager to use for logging.
        ///	</param>
        public PhotoItem(ILoggerFactory loggerFactory)
			: base(loggerFactory)
		{
		}

		#endregion

		#region Properties

		/// <summary>
		///		Gets the album the photo belongs to.
		/// </summary>
		public string Album { get; private set; }

		#endregion

		#region Methods

		/// <summary>
		///     Sets a value read from an object's metadata XML.
		/// </summary>
		/// <param name="key">
		///     The key of the property read from XML.
		/// </param>
		/// <param name="value">
		///     The value of the property read from XML.
		/// </param>
		protected override void SetValue(string key, string value)
		{
			if (key.Is("album"))
			{
				this.Album = value;
			}
			else
			{
				base.SetValue(key, value);
			}
		}

		#endregion
	}
}
