using System;
using System.Globalization;
using UnityEngine;
using Wenzil.Console;

namespace DaggerfallWorkshop.Game
{
    public static class FPSConsoleCommands
    {
        const string noInstanceMessage = "RealGrass instance not found.";

        public static void RegisterCommands()
        {
            try
            {
                ConsoleCommandsDatabase.RegisterCommand(OffsetDistance.name, OffsetDistance.description, OffsetDistance.usage, OffsetDistance.Execute);
                ConsoleCommandsDatabase.RegisterCommand(ChangeOffset.name, ChangeOffset.description, ChangeOffset.usage, ChangeOffset.Execute);
            }
            catch (Exception e)
            {
                Debug.LogError(string.Format("Error Registering RealGrass Console commands: {0}", e.Message));
            }
        }

        public class OffsetDistance
        {
            public static readonly string name = "OffsetDistance";
            public static readonly string error = "Failed to set OffsetDistance - invalid setting or DaggerfallUnity singleton object";
            public static readonly string description = "Changes animation offset distance";
            public static readonly string usage = "OffsetDistance";

            public static float offsetDistance { get; private set; }

            public static string Execute(params string[] args)
            {
                float lrange;
                DaggerfallWorkshop.DaggerfallUnity daggerfallUnity = DaggerfallWorkshop.DaggerfallUnity.Instance;

                if (daggerfallUnity == null)
                    return error;

                if (args == null || args.Length < 1)
                {
                    return "Insert a number";
                }
                else if (!float.TryParse(args[0], out lrange))
                    return error;
                else if (lrange < 0)
                    return "Improper number";
                else
                {
                    try
                    {
                        offsetDistance = lrange;
                        return string.Format("Lerp set to: {0}", lrange);
                    }
                    catch
                    {
                        return "Unspecified error; failed to set lerp";
                    }

                }
            }
        }

        public class ChangeOffset
        {
            public static readonly string name = "ChangeOffset";
            public static readonly string error = "Failed to set ChangeOffset - invalid setting or DaggerfallUnity singleton object";
            public static readonly string description = "Enables Changing Offsets or Default";
            public static readonly string usage = "ChangeOffset";

            public static bool changeOffset { get; private set; }

            public static string Execute(params string[] args)
            {            
                bool trigger;
                DaggerfallWorkshop.DaggerfallUnity daggerfallUnity = DaggerfallWorkshop.DaggerfallUnity.Instance;

                if (daggerfallUnity == null)
                    return error;

                if (args == null || args.Length < 1)
                {
                    return "true or false";
                }
                else if (!bool.TryParse(args[0], out trigger))
                    return error;
                else
                {
                    try
                    {
                        changeOffset = trigger;
                        return string.Format("trigger set to:" + trigger.ToString());
                    }
                    catch
                    {
                        return "Unspecified error; failed to set lerp";
                    }

                }
            }
        }
    }
}