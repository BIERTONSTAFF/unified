﻿namespace AuroraLauncher
{
    internal class Build
    {
        internal const string ClientExecutable = "FortniteClient-Win64-Shipping.exe";
#if !NO_EGL
        internal const string ClientArguments = "";
#else
        internal const string ClientArguments = "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal";
#endif
        internal const string ClientNative = "AuroraNative.dll";

#if ONLINE
        internal const string LauncherUrl = "https://aurorafn.dev";
#endif

        // TODO: Figure out how to generate FLToken's without hardcoding them.
        internal const string BEToken = "f7b9gah4h5380d10f721dd6a";
        internal const string EACToken = "10ga222d803bh65851660E3d";
    }
}
