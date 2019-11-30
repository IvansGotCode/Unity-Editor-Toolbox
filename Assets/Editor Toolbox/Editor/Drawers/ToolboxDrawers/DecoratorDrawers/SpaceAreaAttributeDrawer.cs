﻿using UnityEngine;

namespace Toolbox.Editor.Drawers
{
    public class SpaceAreaAttributeDrawer : ToolboxDecoratorDrawer<SpaceAreaAttribute>
    {
        protected override void OnGuiBeginSafe(SpaceAreaAttribute attribute)
        {
            GUILayout.Space(attribute.SpaceBefore);         
        }

        protected override void OnGuiEndSafe(SpaceAreaAttribute attribute)
        {
            GUILayout.Space(attribute.SpaceAfter);
        }
    }
}