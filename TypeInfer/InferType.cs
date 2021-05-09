using System.Runtime.CompilerServices;

namespace Vst.TypeInfer {
    /// <summary>
    /// </summary>
    public static class InferType {

        /// <summary>
        /// </summary>
#if !NET20
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static TI<T> IT<T>() => IT<T>;


        /// <summary>
        /// </summary>
#if !NET20
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static TI<T1, T2> IT<T1, T2>() => IT<T1, T2>;


        /// <summary>
        /// </summary>
#if !NET20
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static TI<T1, T2, T3> IT<T1, T2, T3>() => IT<T1, T2, T3>;


        /// <summary>
        /// </summary>
#if !NET20
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static TI<T1, T2, T3, T4> IT<T1, T2, T3, T4>() => IT<T1, T2, T3, T4>;


        /// <summary>
        /// </summary>
#if !NET20
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static TI<T1, T2, T3, T4, T5> IT<T1, T2, T3, T4, T5>() => IT<T1, T2, T3, T4, T5>;


        /// <summary>
        /// </summary>
#if !NET20
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static TI<T1, T2, T3, T4, T5, T6> IT<T1, T2, T3, T4, T5, T6>() => IT<T1, T2, T3, T4, T5, T6>;


        /// <summary>
        /// </summary>
#if !NET20
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static TI<T1, T2, T3, T4, T5, T6, T7> IT<T1, T2, T3, T4, T5, T6, T7>() => IT<T1, T2, T3, T4, T5, T6, T7>;


        /// <summary>
        /// </summary>
#if !NET20
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static TI<T1, T2, T3, T4, T5, T6, T7, T8> IT<T1, T2, T3, T4, T5, T6, T7, T8>() => IT<T1, T2, T3, T4, T5, T6, T7, T8>;


//#if !NET20
//        [MethodImpl(MethodImplOptions.AggressiveInlining)]
//#endif
//        public static GetArg<T, TArg> IT<T, TArg>(TArg a) => () => a;


//#if !NET20
//        [MethodImpl(MethodImplOptions.AggressiveInlining)]
//#endif
//        public static TArg IT<T1, T2, TArg>(TArg a) => a;


//#if !NET20
//        [MethodImpl(MethodImplOptions.AggressiveInlining)]
//#endif
//        public static TArg IT<T1, T2, T3, TArg>(TArg a) => a;


//#if !NET20
//        [MethodImpl(MethodImplOptions.AggressiveInlining)]
//#endif
//        public static TArg IT<T1, T2, T3, T4, TArg>(TArg a) => a;


//#if !NET20
//        [MethodImpl(MethodImplOptions.AggressiveInlining)]
//#endif
//        public static TArg IT<T1, T2, T3, T4, T5, TArg>(TArg a) => a;


//#if !NET20
//        [MethodImpl(MethodImplOptions.AggressiveInlining)]
//#endif
//        public static TArg IT<T1, T2, T3, T4, T5, T6, TArg>(TArg a) => a;


//#if !NET20
//        [MethodImpl(MethodImplOptions.AggressiveInlining)]
//#endif
//        public static TArg IT<T1, T2, T3, T4, T5, T6, T7, TArg>(TArg a) => a;


//#if !NET20
//        [MethodImpl(MethodImplOptions.AggressiveInlining)]
//#endif
//        public static TArg IT<T1, T2, T3, T4, T5, T6, T7, T8, TArg>(TArg a) => a;

    }

}

