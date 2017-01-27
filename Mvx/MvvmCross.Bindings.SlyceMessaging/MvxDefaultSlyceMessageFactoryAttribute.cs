using System;

namespace MvvmCross.Bindings.SlyceMessaging
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class MvxDefaultSlyceMessageFactoryAttribute : Attribute
    {
        public MvxDefaultSlyceMessageFactoryAttribute()
        {
        }
    }
}