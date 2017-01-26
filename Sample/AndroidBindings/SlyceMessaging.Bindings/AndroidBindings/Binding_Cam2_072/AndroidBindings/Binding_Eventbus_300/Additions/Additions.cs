using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Org.Greenrobot.Eventbus.Util
{
    public abstract partial class ErrorDialogFragmentFactory : global::Java.Lang.Object
    {
        // Metadata.xml XPath class reference: path="/api/package[@name='org.greenrobot.eventbus.util']/class[@name='ErrorDialogFragmentFactory.Honeycomb']"
        [global::Android.Runtime.Register("org/greenrobot/eventbus/util/ErrorDialogFragmentFactory$Honeycomb", DoNotGenerateAcw = true)]
        public partial class Honeycomb : global::Org.Greenrobot.Eventbus.Util.ErrorDialogFragmentFactory
        {

            internal static new IntPtr java_class_handle;
            internal static new IntPtr class_ref
            {
                get
                {
                    return JNIEnv.FindClass("org/greenrobot/eventbus/util/ErrorDialogFragmentFactory$Honeycomb", ref java_class_handle);
                }
            }

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(Honeycomb); }
            }

            protected Honeycomb(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

            static IntPtr id_ctor_Lorg_greenrobot_eventbus_util_ErrorDialogConfig_;
            // Metadata.xml XPath constructor reference: path="/api/package[@name='org.greenrobot.eventbus.util']/class[@name='ErrorDialogFragmentFactory.Honeycomb']/constructor[@name='ErrorDialogFragmentFactory.Honeycomb' and count(parameter)=1 and parameter[1][@type='org.greenrobot.eventbus.util.ErrorDialogConfig']]"
            [Register(".ctor", "(Lorg/greenrobot/eventbus/util/ErrorDialogConfig;)V", "")]
            public unsafe Honeycomb(global::Org.Greenrobot.Eventbus.Util.ErrorDialogConfig p0)
                : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
            {
                if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                    return;

                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(p0);
                    if (GetType() != typeof(Honeycomb))
                    {
                        SetHandle(
                                global::Android.Runtime.JNIEnv.StartCreateInstance(GetType(), "(Lorg/greenrobot/eventbus/util/ErrorDialogConfig;)V", __args),
                                JniHandleOwnership.TransferLocalRef);
                        global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "(Lorg/greenrobot/eventbus/util/ErrorDialogConfig;)V", __args);
                        return;
                    }

                    if (id_ctor_Lorg_greenrobot_eventbus_util_ErrorDialogConfig_ == IntPtr.Zero)
                        id_ctor_Lorg_greenrobot_eventbus_util_ErrorDialogConfig_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Lorg/greenrobot/eventbus/util/ErrorDialogConfig;)V");
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Lorg_greenrobot_eventbus_util_ErrorDialogConfig_, __args),
                            JniHandleOwnership.TransferLocalRef);
                    JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor_Lorg_greenrobot_eventbus_util_ErrorDialogConfig_, __args);
                }
                finally
                {
                }
            }

            static Delegate cb_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
            static Delegate GetCreateErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler()
            {
                if (cb_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == null)
                    cb_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_CreateErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_);
                return cb_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
            }

            static IntPtr n_CreateErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
            {
                global::Org.Greenrobot.Eventbus.Util.ErrorDialogFragmentFactory.Honeycomb __this = global::Java.Lang.Object.GetObject<global::Org.Greenrobot.Eventbus.Util.ErrorDialogFragmentFactory.Honeycomb>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Org.Greenrobot.Eventbus.Util.ThrowableFailureEvent p0 = global::Java.Lang.Object.GetObject<global::Org.Greenrobot.Eventbus.Util.ThrowableFailureEvent>(native_p0, JniHandleOwnership.DoNotTransfer);
                global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.CreateErrorFragment(p0, p1));
                return __ret;
            }
#pragma warning restore 0169

            static IntPtr id_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
            // Metadata.xml XPath method reference: path="/api/package[@name='org.greenrobot.eventbus.util']/class[@name='ErrorDialogFragmentFactory.Honeycomb']/method[@name='createErrorFragment' and count(parameter)=2 and parameter[1][@type='org.greenrobot.eventbus.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
            [Register("createErrorFragment", "(Lorg/greenrobot/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Landroid/app/Fragment;", "GetCreateErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
            protected override unsafe Java.Lang.Object CreateErrorFragment(global::Org.Greenrobot.Eventbus.Util.ThrowableFailureEvent p0, global::Android.OS.Bundle p1)
            {
                if (id_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == IntPtr.Zero)
                    id_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNIEnv.GetMethodID(class_ref, "createErrorFragment", "(Lorg/greenrobot/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Landroid/app/Fragment;");
                try
                {
                    JValue* __args = stackalloc JValue[2];
                    __args[0] = new JValue(p0);
                    __args[1] = new JValue(p1);

                    global::Android.App.Fragment __ret;
                    if (GetType() == ThresholdType)
                        __ret = global::Java.Lang.Object.GetObject<global::Android.App.Fragment>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
                    else
                        __ret = global::Java.Lang.Object.GetObject<global::Android.App.Fragment>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "createErrorFragment", "(Lorg/greenrobot/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Landroid/app/Fragment;"), __args), JniHandleOwnership.TransferLocalRef);
                    return __ret;
                }
                finally
                {
                }
            }

        }

        // Metadata.xml XPath class reference: path="/api/package[@name='org.greenrobot.eventbus.util']/class[@name='ErrorDialogFragmentFactory.Support']"
        [global::Android.Runtime.Register("org/greenrobot/eventbus/util/ErrorDialogFragmentFactory$Support", DoNotGenerateAcw = true)]
        public partial class Support : global::Org.Greenrobot.Eventbus.Util.ErrorDialogFragmentFactory
        {

            internal static new IntPtr java_class_handle;
            internal static new IntPtr class_ref
            {
                get
                {
                    return JNIEnv.FindClass("org/greenrobot/eventbus/util/ErrorDialogFragmentFactory$Support", ref java_class_handle);
                }
            }

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(Support); }
            }

            protected Support(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

            static IntPtr id_ctor_Lorg_greenrobot_eventbus_util_ErrorDialogConfig_;
            // Metadata.xml XPath constructor reference: path="/api/package[@name='org.greenrobot.eventbus.util']/class[@name='ErrorDialogFragmentFactory.Support']/constructor[@name='ErrorDialogFragmentFactory.Support' and count(parameter)=1 and parameter[1][@type='org.greenrobot.eventbus.util.ErrorDialogConfig']]"
            [Register(".ctor", "(Lorg/greenrobot/eventbus/util/ErrorDialogConfig;)V", "")]
            public unsafe Support(global::Org.Greenrobot.Eventbus.Util.ErrorDialogConfig p0)
                : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
            {
                if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                    return;

                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(p0);
                    if (GetType() != typeof(Support))
                    {
                        SetHandle(
                                global::Android.Runtime.JNIEnv.StartCreateInstance(GetType(), "(Lorg/greenrobot/eventbus/util/ErrorDialogConfig;)V", __args),
                                JniHandleOwnership.TransferLocalRef);
                        global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "(Lorg/greenrobot/eventbus/util/ErrorDialogConfig;)V", __args);
                        return;
                    }

                    if (id_ctor_Lorg_greenrobot_eventbus_util_ErrorDialogConfig_ == IntPtr.Zero)
                        id_ctor_Lorg_greenrobot_eventbus_util_ErrorDialogConfig_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Lorg/greenrobot/eventbus/util/ErrorDialogConfig;)V");
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Lorg_greenrobot_eventbus_util_ErrorDialogConfig_, __args),
                            JniHandleOwnership.TransferLocalRef);
                    JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor_Lorg_greenrobot_eventbus_util_ErrorDialogConfig_, __args);
                }
                finally
                {
                }
            }

            static Delegate cb_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
            static Delegate GetCreateErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler()
            {
                if (cb_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == null)
                    cb_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_CreateErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_);
                return cb_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
            }

            static IntPtr n_CreateErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
            {
                global::Org.Greenrobot.Eventbus.Util.ErrorDialogFragmentFactory.Support __this = global::Java.Lang.Object.GetObject<global::Org.Greenrobot.Eventbus.Util.ErrorDialogFragmentFactory.Support>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Org.Greenrobot.Eventbus.Util.ThrowableFailureEvent p0 = global::Java.Lang.Object.GetObject<global::Org.Greenrobot.Eventbus.Util.ThrowableFailureEvent>(native_p0, JniHandleOwnership.DoNotTransfer);
                global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.CreateErrorFragment(p0, p1));
                return __ret;
            }
#pragma warning restore 0169

            static IntPtr id_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_;
            // Metadata.xml XPath method reference: path="/api/package[@name='org.greenrobot.eventbus.util']/class[@name='ErrorDialogFragmentFactory.Support']/method[@name='createErrorFragment' and count(parameter)=2 and parameter[1][@type='org.greenrobot.eventbus.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
            [Register("createErrorFragment", "(Lorg/greenrobot/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Landroid/support/v4/app/Fragment;", "GetCreateErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
            protected override unsafe Java.Lang.Object CreateErrorFragment(global::Org.Greenrobot.Eventbus.Util.ThrowableFailureEvent p0, global::Android.OS.Bundle p1)
            {
                if (id_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ == IntPtr.Zero)
                    id_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNIEnv.GetMethodID(class_ref, "createErrorFragment", "(Lorg/greenrobot/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Landroid/support/v4/app/Fragment;");
                try
                {
                    JValue* __args = stackalloc JValue[2];
                    __args[0] = new JValue(p0);
                    __args[1] = new JValue(p1);

                    global::Android.Support.V4.App.Fragment __ret;
                    if (GetType() == ThresholdType)
                        __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_createErrorFragment_Lorg_greenrobot_eventbus_util_ThrowableFailureEvent_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
                    else
                        __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "createErrorFragment", "(Lorg/greenrobot/eventbus/util/ThrowableFailureEvent;Landroid/os/Bundle;)Landroid/support/v4/app/Fragment;"), __args), JniHandleOwnership.TransferLocalRef);
                    return __ret;
                }
                finally
                {
                }
            }

        }
    }

}