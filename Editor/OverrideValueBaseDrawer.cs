using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
	[CustomPropertyDrawer( typeof( OverrideValueBase ), true )]
	internal sealed class OverrideValueBaseDrawer : PropertyDrawer
	{
		public override void OnGUI
		(
			Rect               position,
			SerializedProperty property,
			GUIContent         label
		)
		{
			var labelProperty      = property.FindPropertyRelative( "m_label" );
			var isOverrideProperty = property.FindPropertyRelative( "m_isOverride" );
			var valueProperty      = property.FindPropertyRelative( "m_value" );

			var isOverrideRect = position;
			isOverrideRect.width = 16;

			var valueRect = position;
			valueRect.x = 40;

			isOverrideProperty.boolValue = EditorGUI.Toggle( isOverrideRect, isOverrideProperty.boolValue );

			var displayName = string.IsNullOrWhiteSpace( labelProperty.stringValue )
					? property.displayName
					: labelProperty.stringValue
				;

			using ( new EditorGUI.DisabledScope( !isOverrideProperty.boolValue ) )
			{
				EditorGUI.PropertyField( valueRect, valueProperty, new GUIContent( displayName ) );
			}
		}
	}
}