using Sharp.Applications.Messages;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace Sharp.Applications.Storage
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public abstract class Asset : IEquatable<Asset>
	{
		[DisplayName("Location")]
		public virtual string Key { get { return Location; } }

		public readonly string Location = null;

		public virtual bool Exists { get { return Directory.Exists(Location); } }


		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public AssetLog Logs { get; private set; }


		public Asset()
		{
			Location = "Dummy";
			Logs = new AssetLog(this);
			Logs.Entry("Created dummy asset.");
		}


		public Asset(string location)
		{
			Location = location;
			Logs = new AssetLog(this);
			Logs.Entry("Created new asset at " + location);

			try
			{
				Path.GetFullPath(location);
			}
			catch (Exception exception)
			{
				this.Logs.Entry(ExceptionMessage.GetWarning(exception));
			}
		}


		#region Utility Methods

		public void OpenInSystem()
		{
			OpenInSystem(Location);
			this.Logs.Entry("Opening the asset location in explorer. '" + Location + "'.");
		}


		public static void OpenInSystem(string path)
		{
			if (Directory.Exists(path) || File.Exists(path))
			{
				FileAttributes attr = File.GetAttributes(path);

				if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
					Process.Start(path);
				else
					Process.Start(Path.GetDirectoryName(path));
			}
		}

		#endregion


		#region IEquatable<Asset> Members

		public bool Equals(Asset other)
		{
			if (other == null) return false;
			return (this.Key.Equals(other.Key));
		}


		/// <summary>Returns the hash code for the assets Key property.</summary>
		/// <returns>A hash code for the current assets Key.</returns>
		public override int GetHashCode()
		{
			return Key == null ? 0 : Key.GetHashCode();
			//			return this.Key.GetHashCode();
		}



		/// <summary>Override is needed to be able to use the same validation independent of the way of comparing.</summary>
		/// <returns>
		/// True if the specified <see cref="T:System.Object"></see> is a Asset object and its Key is the same as the current assets Key; 
		/// otherwise False;
		/// </returns>
		public override bool Equals(object obj)
		{
			if (obj != null && obj is Asset)
				return Equals((Asset)obj);
			else
				return false;
		}


		/// <summary>Checks if two assets are the same.</summary>
		/// <param name="A">First asset to compare with.</param>
		/// <param name="B">Second asset to compare with.</param>
		/// <returns>True if the Key property for both assets is the same; otherwise false.</returns>
		/// <remarks>Needed when working with value types.</remarks>
		public static bool operator ==(Asset A, Asset B)
		{
			if (object.ReferenceEquals(A, B)) return true;
			if (object.ReferenceEquals(A, null)) return false;
			if (object.ReferenceEquals(B, null)) return false;
			return A.Equals(B);
		}


		/// <summary>Checks if two assets are different.</summary>
		/// <param name="A">First asset to compare with.</param>
		/// <param name="B">Second asset to compare with.</param>
		/// <returns>True if the Key property for both assets are different; otherwise false.</returns>
		/// <remarks>Needed when working with value types.</remarks>
		public static bool operator !=(Asset A, Asset B)
		{
			if (object.ReferenceEquals(A, B)) return false;
			if (object.ReferenceEquals(A, null)) return true;
			if (object.ReferenceEquals(B, null)) return true;
			return !A.Equals(B);
		}

		#endregion

	}
}
