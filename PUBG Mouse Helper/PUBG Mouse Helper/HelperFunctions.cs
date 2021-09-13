using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUBG_Mouse_Helper
{
    public static class HelperFunctions
    {
        public static void WaitUntilTimeoutWhileTrue(Func<bool> condition, int timeoutMs)
        {
            int startTime = Environment.TickCount;
            while (Environment.TickCount - startTime < timeoutMs && condition.Invoke())
            {
            }
        }

        public static string GetApplicationName()
        {
            return "PUBG Mouse Helper 3.1";
        }

        public static List<ToolStripMenuItem> GetListOfAllPresetMenuItems(ToolStripMenuItem toolStripMenuItemPresets)
        {
            List<ToolStripMenuItem> presetMenuItemsList = new List<ToolStripMenuItem>();

            foreach (ToolStripMenuItem presetsMenuItem in toolStripMenuItemPresets.DropDownItems)
            {
                if (!presetsMenuItem.HasDropDownItems)
                {
                    presetMenuItemsList.Add(presetsMenuItem);
                }
                else
                {
                    foreach (ToolStripMenuItem userPresetMenuItem in presetsMenuItem.DropDownItems)
                    {
                        presetMenuItemsList.Add(userPresetMenuItem);
                    }
                }
            }

            return presetMenuItemsList;
        }

        public static Keys GetFireKeyFromString(string fireKeyString)
        {
            Keys fireKey = Keys.XButton1;
            switch (fireKeyString)
            {
                case "Back Mouser":
                    fireKey = Keys.XButton1;
                    break;
                case "Forward Mouser":
                    fireKey = Keys.XButton2;
                    break;
                case "Left Mouser":
                    fireKey = Keys.LButton;
                    break;
                case "Right Mouser":
                    fireKey = Keys.RButton;
                    break;
                case "Shift":
                    fireKey = Keys.Shift;
                    break;
            }
            return fireKey;
        }

        public static Keys GetAutoTapFromString(string autotap)
        {
            Keys fireKey = Keys.XButton1;
            switch (autotap)
            {
                case "Back Mouser":
                    fireKey = Keys.XButton1;
                    break;
                case "Forward Mouser":
                    fireKey = Keys.XButton2;
                    break;
                case "Left Mouser":
                    fireKey = Keys.LButton;
                    break;
                case "Right Mouser":
                    fireKey = Keys.RButton;
                    break;
                case "Shift":
                    fireKey = Keys.Shift;
                    break;
            }
            return fireKey;
        }

        public static ToolStripMenuItem GetToolStripMenuItemFromText(ToolStripMenuItem toolStripMenuItemPresets, string menuItemText)
        {
            try
            {
                ToolStripMenuItem userPresetsMenu = (ToolStripMenuItem)toolStripMenuItemPresets.DropDownItems[0];
                foreach (ToolStripMenuItem toolStripMenuItem in userPresetsMenu.DropDownItems)
                {
                    if (toolStripMenuItem.Text == menuItemText)
                    {
                        return toolStripMenuItem;
                    }
                }
            }
            catch (ArgumentOutOfRangeException aoorex)
            {

                throw new PresetMenuNotPopulatedException("Preset menu not populated!");
            }




            throw new PresetNotFoundException($"Preset {menuItemText} not present in Presets menu!");
        }
    }
}
