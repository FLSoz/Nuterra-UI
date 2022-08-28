using UnityEngine;

namespace Nuterra.UI
{
    public class Toggle
    {
        public GUIStyle Default { get; set; }

        public GUIStyle Check { get; set; }

        internal Toggle()
        {
            Default = new GUIStyle
            {
                normal =
                {
                    background = Elements.LoadImageFromModContainer("Toggle_OFF.png"),
                    textColor = new Color(0.85f,0.85f,0.85f)
                },
                active =
                {
                    background = Elements.LoadImageFromModContainer("Toggle_ON.png"),
                    textColor = new Color(0.8f,0.95f,0.95f)
                },
                onNormal =
                {
                    background = Elements.LoadImageFromModContainer("Toggle_ON.png"),
                    textColor = new Color(0.9f,0.9f,0.9f)
                },
                onActive =
                {
                    background = Elements.LoadImageFromModContainer("Toggle_OFF.png"),
                    textColor = new Color(.85f,.85f,.95f)
                },
                onHover =
                {
                    textColor = new Color(.95f,1f,1f)
                },
                padding = new RectOffset(40,0,0,0),
                fixedWidth = 40f,
                fixedHeight = 20f,
            };
            Check = new GUIStyle(GUI.skin.toggle)
            {
                normal =
                {
                    background = Elements.LoadImageFromModContainer("Check_Unticked.png")
                },
                active =
                {
					background = Elements.LoadImageFromModContainer("Check_Unticked.png")
				},
				hover =
				{
					background = Elements.LoadImageFromModContainer("Check_Unticked.png")
				},
				onNormal =
				{
					background = Elements.LoadImageFromModContainer("Check_Ticked.png")
				},
				onActive =
				{
					background = Elements.LoadImageFromModContainer("Check_Ticked.png")
				},
				onHover =
				{
					background = Elements.LoadImageFromModContainer("Check_Ticked.png")
				},
				border = new RectOffset(2, 2, 2, 2),
				fixedWidth = 32f,
				fixedHeight = 32f,
			};
        }
    }
}
