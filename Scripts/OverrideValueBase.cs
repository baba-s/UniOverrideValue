using System;
using UnityEngine;

namespace Kogane
{
	public abstract class OverrideValueBase
	{
	}

	[Serializable]
	public abstract class OverrideValueBase<T> : OverrideValueBase
	{
		[SerializeField] private string m_label      = string.Empty;
		[SerializeField] private bool   m_isOverride = default;
		[SerializeField] private T      m_value      = default;

		public string Label
		{
			get => m_label;
			set => m_label = value;
		}

		public bool IsOverride
		{
			get => m_isOverride;
			set => m_isOverride = value;
		}

		public T Value
		{
			get => m_value;
			set => m_value = value;
		}

		protected OverrideValueBase() : this( default )
		{
		}

		protected OverrideValueBase( T defaultValue ) : this( string.Empty, defaultValue )
		{
		}

		protected OverrideValueBase( string label, T defaultValue )
		{
			m_label = label;
			m_value = defaultValue;
		}

		public T GetOrDefault()
		{
			return GetOrDefault( default );
		}

		public T GetOrDefault( T defaultValue )
		{
			return IsOverride ? m_value : defaultValue;
		}

		public void ApplyIfOverride( ref T target )
		{
			if ( !IsOverride ) return;
			target = m_value;
		}
	}

	[Serializable]
	public sealed class OverrideBool : OverrideValueBase<bool>
	{
		public OverrideBool()
		{
		}

		public OverrideBool( bool defaultValue ) : base( defaultValue )
		{
		}

		public OverrideBool( string label, bool defaultValue ) : base( label, defaultValue )
		{
		}
	}

	[Serializable]
	public sealed class OverrideInt : OverrideValueBase<int>
	{
		public OverrideInt()
		{
		}

		public OverrideInt( int defaultValue ) : base( defaultValue )
		{
		}

		public OverrideInt( string label, int defaultValue ) : base( label, defaultValue )
		{
		}
	}

	[Serializable]
	public sealed class OverrideUint : OverrideValueBase<uint>
	{
		public OverrideUint()
		{
		}

		public OverrideUint( uint defaultValue ) : base( defaultValue )
		{
		}

		public OverrideUint( string label, uint defaultValue ) : base( label, defaultValue )
		{
		}
	}

	[Serializable]
	public sealed class OverrideFloat : OverrideValueBase<float>
	{
		public OverrideFloat()
		{
		}

		public OverrideFloat( float defaultValue ) : base( defaultValue )
		{
		}

		public OverrideFloat( string label, float defaultValue ) : base( label, defaultValue )
		{
		}
	}

	[Serializable]
	public sealed class OverrideString : OverrideValueBase<string>
	{
		public OverrideString()
		{
		}

		public OverrideString( string defaultValue ) : base( defaultValue )
		{
		}

		public OverrideString( string label, string defaultValue ) : base( label, defaultValue )
		{
		}
	}

	[Serializable]
	public sealed class OverrideColor : OverrideValueBase<Color>
	{
		public OverrideColor()
		{
		}

		public OverrideColor( Color defaultValue ) : base( defaultValue )
		{
		}

		public OverrideColor( string label, Color defaultValue ) : base( label, defaultValue )
		{
		}
	}

	[Serializable]
	public sealed class OverrideVector2 : OverrideValueBase<Vector2>
	{
		public OverrideVector2()
		{
		}

		public OverrideVector2( Vector2 defaultValue ) : base( defaultValue )
		{
		}

		public OverrideVector2( string label, Vector2 defaultValue ) : base( label, defaultValue )
		{
		}
	}

	[Serializable]
	public sealed class OverrideVector3 : OverrideValueBase<Vector3>
	{
		public OverrideVector3()
		{
		}

		public OverrideVector3( Vector3 defaultValue ) : base( defaultValue )
		{
		}

		public OverrideVector3( string label, Vector3 defaultValue ) : base( label, defaultValue )
		{
		}
	}
}