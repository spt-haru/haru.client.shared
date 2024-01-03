using System;
using System.Reflection;
using EFT;

namespace Haru.Client.Shared
{
    public class PatchConsts
    {
        public static readonly Type[] EftTypes;
        public const BindingFlags PrivateFlags = BindingFlags.Instance
                                               | BindingFlags.NonPublic
                                               | BindingFlags.DeclaredOnly;

        static PatchConsts()
        {
            EftTypes = typeof(TarkovApplication).Assembly.GetTypes();
        }
    }
}