using ES2.Amplitude.Xml.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ES2.Editor.Model
{
	public class Database<T> : IDatabaseControl, IDatabase<T>, IEnumerable<T>, IEnumerable where T : IDatatableElement
	{
		private List<Datatable> datatables = new List<Datatable>();


		public void Add(T element)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public byte[] ComputeHash()
		{
			throw new NotImplementedException();
		}

		public bool ContainsKey(string key)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		public T GetValue(string key)
		{
			throw new NotImplementedException();
		}

		public T GetValue(string key, T defaultValue)
		{
			throw new NotImplementedException();
		}

		public T[] GetValues()
		{
			throw new NotImplementedException();
		}

		public bool LoadFile(string path, XmlAttributeOverride[] overrides = null, XmlExtraType[] extraTypes = null)
		{
			throw new NotImplementedException();
		}

		public void Remove(T element)
		{
			throw new NotImplementedException();
		}

		public void Remove(string key)
		{
			throw new NotImplementedException();
		}

		public void RemoveFromAllRevisions(T element)
		{
			throw new NotImplementedException();
		}

		public void RollbackTo(int revision)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> Shuffle()
		{
			throw new NotImplementedException();
		}

		public void Touch(T element)
		{
			throw new NotImplementedException();
		}

		public bool TryGetValue(string key, out T value)
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}


	internal interface IDatabaseControl
	{
		byte[] ComputeHash();

		bool LoadFile(string path, XmlAttributeOverride[] overrides = null, XmlExtraType[] extraTypes = null);

		void RollbackTo(int revision);
	}

	public interface IDatabase<T> : IEnumerable<T>, IEnumerable where T : IDatatableElement
	{
		void Add(T element);

		void Clear();

		void Touch(T element);

		bool ContainsKey(string key);

		T GetValue(string key);

		T GetValue(string key, T defaultValue);

		T[] GetValues();

		void Remove(T element);

		void Remove(string key);

		void RemoveFromAllRevisions(T element);

		IEnumerable<T> Shuffle();

		bool TryGetValue(string key, out T value);
	}
}
