using System;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;

namespace IT.Slyce.Messaging.Message.MessageItem
{
    // Metadata.xml XPath class reference: path="/api/package[@name='it.slyce.messaging.message.messageItem']/class[@name='MessageRecyclerAdapter']"
    public partial class MessageRecyclerAdapter : RecyclerView.Adapter
    {
        private static Delegate cb_onBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_I;

        private static IntPtr id_onBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_I;

        private static Delegate cb_onCreateViewHolder_Landroid_view_ViewGroup_I;

        private static IntPtr id_onCreateViewHolder_Landroid_view_ViewGroup_I;

       
        // Metadata.xml XPath method reference: path="/api/package[@name='it.slyce.messaging.message.messageItem']/class[@name='MessageRecyclerAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='it.slyce.messaging.message.messageItem.MessageViewHolder'] and parameter[2][@type='int']]"
        [Register("onBindViewHolder", "(Lit/slyce/messaging/message/messageItem/MessageViewHolder;I)V",
            "GetOnBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_IHandler")]
        public override unsafe void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            if (id_onBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_I == IntPtr.Zero)
                id_onBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_I =
                    JNIEnv.GetMethodID(class_ref, "onBindViewHolder",
                        "(Lit/slyce/messaging/message/messageItem/MessageViewHolder;I)V");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(viewHolder);
                __args[1] = new JValue(position);

                if (GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(Handle,
                        id_onBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_I, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(Handle, ThresholdClass,
                        JNIEnv.GetMethodID(ThresholdClass, "onBindViewHolder",
                            "(Lit/slyce/messaging/message/messageItem/MessageViewHolder;I)V"), __args);
            }
            finally
            {
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='it.slyce.messaging.message.messageItem']/class[@name='MessageRecyclerAdapter']/method[@name='onCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
        [Register("onCreateViewHolder",
            "(Landroid/view/ViewGroup;I)Lit/slyce/messaging/message/messageItem/MessageViewHolder;",
            "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
        public override unsafe RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup viewGroup, int position)
        {
            if (id_onCreateViewHolder_Landroid_view_ViewGroup_I == IntPtr.Zero)
                id_onCreateViewHolder_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID(class_ref, "onCreateViewHolder",
                    "(Landroid/view/ViewGroup;I)Lit/slyce/messaging/message/messageItem/MessageViewHolder;");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(viewGroup);
                __args[1] = new JValue(position);

                MessageViewHolder __ret;
                if (GetType() == ThresholdType)
                    __ret =
                        GetObject<MessageViewHolder>(
                            JNIEnv.CallObjectMethod(Handle, id_onCreateViewHolder_Landroid_view_ViewGroup_I, __args),
                            JniHandleOwnership.TransferLocalRef);
                else
                    __ret =
                        GetObject<MessageViewHolder>(
                            JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass,
                                JNIEnv.GetMethodID(ThresholdClass, "onCreateViewHolder",
                                    "(Landroid/view/ViewGroup;I)Lit/slyce/messaging/message/messageItem/MessageViewHolder;"),
                                __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }
#pragma warning disable 0169
        private static Delegate GetOnBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_IHandler()

        {
            if (cb_onBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_I == null)
                cb_onBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_I =
                    JNINativeWrapper.CreateDelegate(
                        (Action<IntPtr, IntPtr, IntPtr, int>)
                        n_OnBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_I);
            return cb_onBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_I;
        }

        private static void n_OnBindViewHolder_Lit_slyce_messaging_message_messageItem_MessageViewHolder_I(
            IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)

        {
            var __this = GetObject<MessageRecyclerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var p0 = GetObject<MessageViewHolder>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.OnBindViewHolder(p0, p1);
        }
#pragma warning restore 0169
#pragma warning disable 0169
        private static Delegate GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler()
        {
            if (cb_onCreateViewHolder_Landroid_view_ViewGroup_I == null)
                cb_onCreateViewHolder_Landroid_view_ViewGroup_I =
                    JNINativeWrapper.CreateDelegate(
                        (Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnCreateViewHolder_Landroid_view_ViewGroup_I);
            return cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
        }

        private static IntPtr n_OnCreateViewHolder_Landroid_view_ViewGroup_I(IntPtr jnienv, IntPtr native__this,
            IntPtr native_p0, int p1)
        {
            var __this = GetObject<MessageRecyclerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var p0 = GetObject<ViewGroup>(native_p0, JniHandleOwnership.DoNotTransfer);
            var __ret = JNIEnv.ToLocalJniHandle(__this.OnCreateViewHolder(p0, p1));
            return __ret;
        }
#pragma warning restore 0169
    }
}

