using UnityEngine;

namespace Kogane
{
	public static class ScreenSize
	{
		public static float   DefaultWidth      { get; private set; }
		public static float   DefaultHeight     { get; private set; }
		public static float   DefaultAspect     => DefaultWidth / DefaultHeight;
		public static float   DefaultWidthHalf  => DefaultWidth * 0.5f;
		public static float   DefaultHeightHalf => DefaultHeight * 0.5f;
		public static float   DefaultLeft       => -DefaultWidthHalf;
		public static float   DefaultTop        => DefaultHeightHalf;
		public static float   DefaultRight      => DefaultWidthHalf;
		public static float   DefaultBottom     => -DefaultHeightHalf;
		public static Vector2 DefaultSize       => new Vector2( DefaultWidth, DefaultHeight );

		public static float   Width      => Screen.width;
		public static float   Height     => Screen.height;
		public static float   Aspect     => Width / Height;
		public static float   WidthHalf  => Width * 0.5f;
		public static float   HeightHalf => Height * 0.5f;
		public static float   Left       => -WidthHalf;
		public static float   Top        => HeightHalf;
		public static float   Right      => WidthHalf;
		public static float   Bottom     => -HeightHalf;
		public static Vector2 Size       => new Vector2( Width, Height );

		public static float AspectOffset        => Aspect / DefaultAspect;
		public static float InverseAspectOffset => 1 / AspectOffset;

		public static float HeightOffset => Mathf.Abs( DefaultHeight - DefaultHeight * InverseAspectOffset );
		public static float WidthOffset  => Mathf.Abs( DefaultWidth - DefaultWidth * InverseAspectOffset );
		public static float WidthRate    => Screen.width / DefaultWidth;

		public static void SetSize( float width, float height )
		{
			DefaultWidth  = width;
			DefaultHeight = height;
		}
	}
}