using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace Sharp.Storage
{
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public abstract class Asset : IEquatable<Asset>
	{
		protected readonly string URI;
		public virtual bool Exists { get { return Directory.Exists(URI); } }


		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public AssetLog Logs { get; private set; }


		public Asset(string uri)
		{
			URI = Path.GetFullPath(uri);
			Logs = new AssetLog(this);
			Logs.Entry("Allocated asset URI for " + uri);
		}


		#region Utility

		public void OpenDirectory()
		{
			Logs.Entry("Opening the asset URI in windows explorer. '" + URI + "'.");
			OpenDirectory(URI);
		}


		public static void OpenDirectory(string path)
		{
			if (Directory.Exists(path) || File.Exists(path))
			{
				FileAttributes attribute = File.GetAttributes(path);

				if ((attribute & FileAttributes.Directory) == FileAttributes.Directory)
					Process.Start(path);
				else
					Process.Start(Path.GetDirectoryName(path));
			}
		}

		#endregion


		#region IEquatable<Asset>

		public bool Equals(Asset other)
		{
			if (other == null) return false;
			return (URI.Equals(other.URI));
		}


		/// <summary>Returns the hash code for the assets Key property.</summary>
		/// <returns>A hash code for the current assets Key.</returns>
		public override int GetHashCode()
		{
			return URI == null ? 0 : URI.GetHashCode();
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
			if (ReferenceEquals(A, B)) return true;
			if (ReferenceEquals(A, null)) return false;
			if (ReferenceEquals(B, null)) return false;
			return A.Equals(B);
		}


		/// <summary>Checks if two assets are different.</summary>
		/// <param name="A">First asset to compare with.</param>
		/// <param name="B">Second asset to compare with.</param>
		/// <returns>True if the Key property for both assets are different; otherwise false.</returns>
		/// <remarks>Needed when working with value types.</remarks>
		public static bool operator !=(Asset A, Asset B)
		{
			if (ReferenceEquals(A, B)) return false;
			if (ReferenceEquals(A, null)) return true;
			if (ReferenceEquals(B, null)) return true;
			return !A.Equals(B);
		}

		#endregion

	}
}
