//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Collections {
    
    
    #region Component Designer generated code 
    public partial class IEnumerable_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Collections.@__IEnumerable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Collections.IEnumerable))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Collections.IEnumerable))]
    internal sealed partial class @__IEnumerable : global::java.lang.Object, global::System.Collections.IEnumerable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _GetEnumerator0;
        
        protected @__IEnumerable(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Collections.@__IEnumerable.staticClass = @__class;
            global::System.Collections.@__IEnumerable._GetEnumerator0 = @__env.GetMethodID(global::System.Collections.@__IEnumerable.staticClass, "GetEnumerator", "()Lsystem/collections/IEnumerator;");
        }
        
        public global::System.Collections.IEnumerator GetEnumerator() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Collections.IEnumerator>(@__env, @__env.CallObjectMethodPtr(this, global::System.Collections.@__IEnumerable._GetEnumerator0));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IEnumerable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetEnumerator", "GetEnumerator0", "()Lsystem/collections/IEnumerator;"));
            return methods;
        }
        
        private static global::System.IntPtr GetEnumerator0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/collections/IEnumerator;
            // ()LSystem/Collections/IEnumerator;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IEnumerable @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Collections.IEnumerable>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::System.Collections.IEnumerator>(@__env, @__real.GetEnumerator());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.ICJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Collections.@__IEnumerable(@__env);
            }
        }
    }
    #endregion
}
